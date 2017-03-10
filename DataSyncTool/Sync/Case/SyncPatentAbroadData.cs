using System;
using System.Collections.Generic;
using System.Linq;
using DataEntities.Case;
using DataEntities.Case.Patents;
using DataEntities.Config;
using DataEntities.Element.Fee;
using DataSyncTool.Log;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;
using FCASE_ENT_REL = DataSyncTool.PC.BLL.FCASE_ENT_REL;
using FCASE_INVENTORS = DataSyncTool.PC.BLL.FCASE_INVENTORS;
using FCASE_PRIORITY = DataSyncTool.PC.BLL.FCASE_PRIORITY;

namespace DataSyncTool.Sync.Case
{
    public class SyncPatentAbroadData : SyncData<ExtendedPatent, FCASE>
    {
        public SyncPatentAbroadData(object dataIPSPIndex) : base(dataIPSPIndex)
        {
        }

        public override FCASE GetExistDataPC(ExtendedPatent dataIPSP)
        {
            if (string.IsNullOrWhiteSpace(dataIPSP.s_CaseSerial))
            {
                SyncResultInfoSet.AddWarning($"{dataIPSP.n_CaseID}未填写我方卷号，跳过导入。");
                IsExistDataPC = null;
                return null;
            }
            var existPatent = new PC.BLL.FCASE().GetModel(dataIPSP.s_CaseSerial);
            IsExistDataPC = existPatent != null;
            SyncResultInfoSet.AddInfo(
                InfoString.ToSyncInfo("国外专利", IsExistDataPC.Value, dataIPSP.n_CaseID, dataIPSP.s_CaseSerial),
                dataIPSP.ClassInfo.TableName, typeof(FCASE).Name);
            return existPatent;
        }

        public override void ConvertToDataPC(FCASE dataPC, ExtendedPatent dataIPSP)
        {
            dataPC.OURNO = dataIPSP.s_CaseSerial;
            dataPC.TITLE = dataIPSP.s_CaseNativeName;
            dataPC.CTITLE = dataIPSP.s_CaseName;
            dataPC.RECEIVED = dataIPSP.dt_UndertakeDate;
            dataPC.APPNO = dataIPSP.TheLawInfo.s_AppNo;
            dataPC.APPDATE = dataIPSP.TheLawInfo.dt_AppDate;
            dataPC.COMMENTS = dataIPSP.Memos.Cast<CaseMemo>().Aggregate(string.Empty, (s, m) => s + "\r\n" + m.s_Memo + "\r\n");
            dataPC.STATUS = new[] { "结案", "放弃", "转出", "届满", "失效" }.Contains(dataIPSP.s_CaseStatus) ? "abandon" : "normal";

            var listAppType = new List<string>();
            var patentType =
                new XPQuery<CodePTCType>(dataIPSP.Session).FirstOrDefault(t => t.n_ID == dataIPSP.n_PatentTypeID);
            if (patentType != null)
                listAppType.Add(patentType.s_Code);

            if (dataIPSP is CasePCTI)
                listAppType.Add("PIP");
            else if (dataIPSP is CasePCTN)
                listAppType.Add("PNE");
            else if (dataIPSP is MacaoApplication)
                listAppType.Add("EXT");
            else
                listAppType.Add("NORM");

            if (dataIPSP.b_DivisionalCaseFlag)
                listAppType.Add("DIV");

            if (dataIPSP.s_IsRegOnline == "A")
                listAppType.Add("CONT");
            else if (dataIPSP.s_IsRegOnline == "P")
                listAppType.Add("CIP");

            dataPC.APPTYPE = string.Join(";", listAppType);
            if (!string.IsNullOrEmpty(dataPC.APPTYPE))
                dataPC.APPTYPE += ";";
            dataPC.DEADLINE = dataIPSP.dt_ShldSbmtDate;


            FillDefaultValue();
            if (!IsExistDataPC.HasValue) return;
            if (IsExistDataPC.Value)
                new PC.BLL.FCASE().Update(dataPC);
            else
                new PC.BLL.FCASE().Add(dataPC);

            var bllFCASE_ENT_REL = new FCASE_ENT_REL();
            bllFCASE_ENT_REL.GetModelList($"OURNO = '{dataIPSP.s_CaseSerial}'").ForEach(e => bllFCASE_ENT_REL.Delete(e.PID));
            foreach (var caseApplicant in dataIPSP.Applicants.Cast<Applicant>())
            {
                if (string.IsNullOrWhiteSpace(caseApplicant.s_AppCode))
                {
                    SyncResultInfoSet.AddWarning(InfoString.ToSkipInfo("案件申请人", caseApplicant.n_ID, caseApplicant.s_Name));
                    continue;
                }
                var fcaseent = new PC.Model.FCASE_ENT_REL
                {
                    PID = DateTime.Now.ToString("yyyyMMddHHmmssffffff"),
                    ROLE = "APP",
                    OURNO = dataIPSP.s_CaseSerial,
                    EID = caseApplicant.s_AppCode,
                    COUNTRY =
                        new XPQuery<CodeCountry>(dataIPSP.Session).FirstOrDefault(c => c.n_ID == caseApplicant.n_Country)
                            ?
                            .s_CountryCode,
                    ADDR = caseApplicant.s_Street,
                    ENT_REF = caseApplicant.s_AppSerial,
                    ORIG_NAME = caseApplicant.s_NativeName,
                    TRAN_NAME = caseApplicant.s_Name,
                    ENT_ORDER = caseApplicant.n_Sequence
                };
                FillDefaultValue(fcaseent);
                bllFCASE_ENT_REL.Add(fcaseent);
            }

            var bllFCASE_INVENTORS = new FCASE_INVENTORS();
            bllFCASE_INVENTORS.GetModelList($"OURNO = '{dataIPSP.s_CaseSerial}'")
                .ForEach(e => bllFCASE_INVENTORS.Delete(e.PID));
            foreach (var inventor in dataIPSP.Inventors.Cast<Inventor>())
            {
                var fcaseinventor = new PC.Model.FCASE_INVENTORS
                {
                    PID = DateTime.Now.ToString("yyyyMMddHHmmssffffff"),
                    OURNO = dataIPSP.s_CaseSerial,
                    ENT_ORDER = inventor.n_Sequence,
                    COUNTRY =
                        new XPQuery<CodeCountry>(dataIPSP.Session).FirstOrDefault(c => c.n_ID == inventor.n_Country)
                            ?
                            .s_CountryCode,
                    ADDR = inventor.s_Address,
                    ORIG_NAME = inventor.s_NativeName,
                    TRAN_NAME = inventor.s_Name
                };
                FillDefaultValue(fcaseinventor);
                bllFCASE_INVENTORS.Add(fcaseinventor);
            }

            var bllFCASE_PRIORITY = new FCASE_PRIORITY();
            bllFCASE_PRIORITY.GetModelList($"OURNO = '{dataIPSP.s_CaseSerial}'")
                .ForEach(e => bllFCASE_PRIORITY.Delete(e.PID));
            foreach (var priority in dataIPSP.Priorities.Cast<Priority>().OrderBy(p => p.dt_PDate))
            {
                var fcasepriority = new PC.Model.FCASE_PRIORITY
                {
                    PID = DateTime.Now.ToString("yyyyMMddHHmmssffffff"),
                    OURNO = dataIPSP.s_CaseSerial,
                    PRIOR_NUM = priority.s_PNum,
                    PRIOR_DATE = priority.dt_PDate,
                    PRIOR_COUNTRY =
                        new XPQuery<CodeCountry>(dataIPSP.Session).FirstOrDefault(c => c.n_ID == priority.n_PCountry)
                            ?
                            .s_CountryCode
                };
                FillDefaultValue(fcasepriority);
                bllFCASE_PRIORITY.Add(fcasepriority);
            }

            var bllFCASE_LOG = new PC.BLL.FCASE_LOG();
            var listFCASE_LOG = bllFCASE_LOG.GetModelList($"OURNO = '{dataIPSP.s_CaseSerial}'");

            AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_pub_date", dataIPSP.TheLawInfo.dt_PubDate);
            AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_pub_num", dataIPSP.TheLawInfo.s_PubNo);
            AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_pct_pub_date", dataIPSP.TheLawInfo.dt_PCTPubDate);
            AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_pct_pub_num", dataIPSP.TheLawInfo.s_PCTPubNo);
            AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_pct_ent_date", dataIPSP.TheLawInfo.dt_PCTInNationDate);
            AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_pct_app_num", dataIPSP.TheLawInfo.s_PCTAppNo);
            AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_pct_app_date", dataIPSP.TheLawInfo.dt_PCTAppDate);
            AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_anno_date", dataIPSP.TheLawInfo.dt_IssuedPubDate);
            AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_anno_num", dataIPSP.TheLawInfo.s_IssuedPubNo);
            //AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_reexam_date", dataIPSP.TheLawInfo.); //复审日
            //AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_regfee_sub_date", feeBD.dt_PayDate);//办登日
            //AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_reject_date", dataIPSP.TheLawInfo.); //驳回日
            AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_se_date", dataIPSP.TheLawInfo.dt_SubstantiveExamDate);
            AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_status_date", dataIPSP.dt_RequestSubmitDate); //提实审日
            //AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_invalid_date", dataIPSP.TheLawInfo.);//无效日
            //AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_litigate_date", dataIPSP.TheLawInfo.);//诉讼日
            //AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_ids_date", dataIPSP.TheLawInfo.); //ids日
            //AddOrUpdateCaseLogValue(listFCASE_LOG, dataIPSP.s_CaseSerial, "01_ids_num", dataIPSP.TheLawInfo.); //ids号
        }

        private void AddOrUpdateCaseLogValue(List<FCASE_LOG> listFCASE_LOG, string sCaseNo, string sItem,
            DateTime sContent)
        {
            if (sContent <= new DateTime(1900, 1, 1)) return;
            AddOrUpdateCaseLogValue(listFCASE_LOG, sCaseNo, sItem, sContent.ToShortDateString());
        }

        private void AddOrUpdateCaseLogValue(List<FCASE_LOG> listFCASE_LOG, string sCaseNo, string sItem,
            string sContent)
        {
            if (string.IsNullOrWhiteSpace(sContent)) return;
            var caselog = listFCASE_LOG.FirstOrDefault(l => l.ITEM == sItem);
            if (caselog != null)
            {
                caselog.CONTENT = sContent;
                caselog.LOGDATE = DateTime.Now;
                new PC.BLL.FCASE_LOG().Update(caselog);
            }
            else
            {
                caselog = new FCASE_LOG
                {
                    PID = DateTime.Now.ToString("yyyyMMddHHmmssffffff"),
                    CONTENT = sContent,
                    LOGDATE = DateTime.Now,
                    ITEM = sItem,
                    OURNO = sCaseNo
                };
                new PC.BLL.FCASE_LOG().Add(caselog);
            }
        }
    }
}