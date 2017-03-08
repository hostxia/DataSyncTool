using System;
using System.Linq;
using DataEntities.Case;
using DataEntities.Case.Patents;
using DataEntities.Config;
using DataEntities.Contact.Client;
using DataEntities.Contact.Demand;
using DataEntities.Element.Fee;
using DataEntities.Element.Files;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Case
{
    public class SyncPatentData : SyncData<ExtendedPatent, PATENTCASE>
    {
        public override PATENTCASE GetExistDataPC(ExtendedPatent dataIPSP)
        {
            if (string.IsNullOrWhiteSpace(dataIPSP.s_CaseSerial))
            {
                SyncResultInfoSet.AddWarning($"{dataIPSP.n_CaseID}未填写我方卷号，跳过导入。");
                IsExistDataPC = null;
                return null;
            }
            var existPatent = new PC.BLL.PATENTCASE().GetModel(dataIPSP.s_CaseSerial);
            IsExistDataPC = existPatent != null;
            return existPatent;
        }

        public override void ConvertToDataPC(PATENTCASE dataPC, ExtendedPatent dataIPSP)
        {
            dataPC.OURNO = dataIPSP.s_CaseSerial;
            dataPC.CLIENT = dataIPSP.TheClient?.s_ClientCode;
            dataPC.RECEIVED = dataIPSP.dt_UndertakeDate;
            dataPC.AGENT =
                new XPQuery<CodeEmployee>(new UnitOfWork()).FirstOrDefault(c => c.n_ID == dataIPSP.n_FirstAttorney)?
                    .s_InternalCode;
            dataPC.CLIENT_NUMBER = dataIPSP.s_ClientSerial;
            if (dataIPSP.TheLawInfo != null)
                dataPC.FILING_DATE = dataIPSP.TheLawInfo.dt_AppDate;
            var earliestPriority = dataIPSP.Priorities.Cast<Priority>().OrderBy(p => p.dt_PDate).FirstOrDefault();
            if (earliestPriority != null)
                dataPC.EARLIEST_PRIORITY = earliestPriority.dt_PDate;
            if (dataIPSP.TheLawInfo != null)
                dataPC.PUBLICATION = dataIPSP.TheLawInfo.dt_PubDate;
            //dataPC.FIRST_HK_DATE//第一次香港登记日
            //dataPC.FIRST_HK_CANCELLED//放弃第一次香港登记

            //dataPC.SE_STATUS//已提实审——判断发文
            var outFile = dataIPSP.FileInCases.Cast<FileInCase>().Select(f => f.TheFile).FirstOrDefault(c => c != null && c.s_Name.Contains("实质审查请求") && c.s_ClientGov == "O" && c.s_IOType == "O");
            if (outFile != null)
                dataPC.SE_STATUS = "Y";

            //dataPC.SE_INITIATED//是否进入实审——判断来文
            var inFile = dataIPSP.FileInCases.Cast<FileInCase>().Select(f => f.TheFile).FirstOrDefault(c => c != null && c.s_Name.Contains("进入实质审查") && c.s_ClientGov == "O" && c.s_IOType == "I");
            if (inFile != null)
                dataPC.SE_INITIATED = "Y";

            //dataPC.OA_RECEIVED//收到OA——判断来文
            var inFileOA = dataIPSP.FileInCases.Cast<FileInCase>().Select(f => f.TheFile).FirstOrDefault(c => c != null && c.s_Name.Contains("审查意见通知") && c.s_ClientGov == "O" && c.s_IOType == "I");
            if (inFileOA != null)
                dataPC.OA_RECEIVED = "Y";

            if (dataIPSP.TheLawInfo != null)
                dataPC.GAZETTE = dataIPSP.TheLawInfo.dt_IssuedPubDate;
            //dataPC.SECOND_HK_CANCELLED//放弃第二次香港注册
            //dataPC.SECOND_HK_DATE//第二次香港注册日

            //dataPC.REJECTED//被驳回——判断驳回决定
            var inFileRejected = dataIPSP.FileInCases.Cast<FileInCase>().Select(f => f.TheFile).FirstOrDefault(c => c != null && c.s_Name.Contains("驳回决定") && c.s_ClientGov == "O" && c.s_IOType == "I");
            if (inFileRejected != null)
                dataPC.REJECTED = "Y";

            switch (dataIPSP.s_CaseStatus)
            {
                case "转出":
                    dataPC.WITHDREW = "T";
                    break;
                case "放弃":
                    dataPC.WITHDREW = "Y";
                    break;
                case "届满":
                    dataPC.WITHDREW = "E";
                    break;
                case "结案":
                    dataPC.WITHDREW = "Y";
                    break;
                case "失效":
                    dataPC.WITHDREW = "Y";
                    break;
                default:
                    dataPC.WITHDREW = "";
                    break;
            }
            //dataPC.UNDER_INVALIDATE //正在进行无效程序--苏文静说不用回写
            //dataPC.UNDER_REEXAMINATION //正在进行复审程序--判断是否存在复审通知书、复审决定
            var inFileReexamination = dataIPSP.FileInCases.Cast<FileInCase>().Select(f => f.TheFile).FirstOrDefault(c => c != null && c.s_Name.Contains("复审通知") && c.s_ClientGov == "O" && c.s_IOType == "I");
            var inFileReexaminationDecision = dataIPSP.FileInCases.Cast<FileInCase>().Select(f => f.TheFile).FirstOrDefault(c => c != null && c.s_Name.Contains("复审决定") && c.s_ClientGov == "O" && c.s_IOType == "I");
            if (inFileReexamination != null && inFileReexaminationDecision == null)
                dataPC.UNDER_REEXAMINATION = "Y";

            //dataPC.UNDER_LITIGATION //正在进行诉讼程序--苏文静说不用回写
            //dataPC.INVALIDATED//正被无效--苏文静说不用回写

            for (var i = 0; i < dataIPSP.CaseClients.Count; i++)
            {
                if (i > 3) continue;
                var relateClient = dataIPSP.CaseClients.Cast<CaseClients>().ToList()[i];
                dataPC.GetType().GetProperty($"CLIENT{i + 2}").SetValue(dataPC, relateClient.Client?.s_ClientCode);
            }

            dataPC.APPL_NUM = dataIPSP.Applicants.Count;//申请人总数
            for (var i = 0; i < dataIPSP.Applicants.Count; i++)
            {
                if (i > 4) continue;
                var caseApplicant = dataIPSP.Applicants.Cast<Applicant>().OrderBy(c => c.n_Sequence).ToList()[i];
                dataPC.GetType().GetProperty($"APPLICANT{i + 1}").SetValue(dataPC, caseApplicant.s_NativeName);
                dataPC.GetType().GetProperty($"APPLICANT_CH{i + 1}").SetValue(dataPC, caseApplicant.s_Name);
                var applicant = new XPQuery<DataEntities.Contact.Applicant.Applicant>(new UnitOfWork()).FirstOrDefault(a => a.n_AppID == caseApplicant.n_ApplicantID);
                if (applicant != null)
                    dataPC.GetType().GetProperty($"APPL_CODE{i + 1}").SetValue(dataPC, applicant.s_AppCode);
            }

            dataPC.INVEN_NUM = dataIPSP.Inventors.Count;//发明人总数
            for (var i = 0; i < dataIPSP.Inventors.Count; i++)
            {
                if (i > 20) continue;
                var inventor = dataIPSP.Inventors.Cast<Inventor>().OrderBy(v => v.n_Sequence).ToList()[i];
                dataPC.GetType().GetProperty($"INVENTOR{i + 1}").SetValue(dataPC, inventor.s_NativeName);
                dataPC.GetType().GetProperty($"INVENTOR_CH{i + 1}").SetValue(dataPC, inventor.s_Name);
            }

            dataPC.TOTAL_PRI = dataIPSP.Priorities.Count;
            for (int i = 0; i < dataIPSP.Priorities.Count; i++)
            {
                if (i > 11) continue;
                var priority = dataIPSP.Priorities.Cast<Priority>().OrderBy(v => v.n_Sequence).ToList()[i];
                var country = new XPQuery<CodeCountry>(new UnitOfWork()).FirstOrDefault(c => c.n_ID == priority.n_PCountry);
                dataPC.GetType().GetProperty($"PRI_COUNTRY{(i == 0 ? string.Empty : (i + 1).ToString())}").SetValue(dataPC, country?.s_CountryCode);
                dataPC.GetType().GetProperty($"PRI_NUMBER{(i == 0 ? string.Empty : (i + 1).ToString())}").SetValue(dataPC, priority.s_PNum);
                dataPC.GetType().GetProperty(i == 0 ? "EARLIEST_PRIORITY" : "PRI_DATE" + (i + 1)).SetValue(dataPC, priority.dt_PDate);
            }
            dataPC.TITLE = dataIPSP.s_CaseNativeName;
            if (dataIPSP.TheLawInfo != null)
                dataPC.PCT_APPN_DATE = dataIPSP.TheLawInfo.dt_PCTAppDate;
            dataPC.FILING_DUE = dataIPSP.dt_ShldSbmtDate; //计划日
            dataPC.COMMENTS = dataIPSP.Memos.Cast<CaseMemo>().Aggregate(string.Empty, (s, m) => s + "\r\n" + m.s_Memo + "\r\n");
            dataPC.CLIENT_NAME = dataIPSP.TheClient?.s_Name;

            if (dataIPSP.TheLawInfo != null)
                dataPC.PCT_PUBDATE = dataIPSP.TheLawInfo.dt_PCTPubDate;
            dataPC.PCT_PUBNUM = dataIPSP.TheLawInfo?.s_PCTPubNo;
            dataPC.DEADLINE = dataIPSP.dt_ShldSbmtDate;//客户指定/绝限期——要求提交日
            dataPC.TITLE_CHINESE = dataIPSP.s_CaseName;
            //dataPC.AGENT_ACTUAL //实际代理人——处理人里找对应角色人员
            var caseRoleActual = new XPQuery<CodeCaseRole>(new UnitOfWork()).FirstOrDefault(r => r.s_Name == "实际代理人")?.n_ID;
            dataPC.AGENT_ACTUAL = dataIPSP.CaseAttorneys.Cast<CaseAttorney>().FirstOrDefault(a => a.n_CaseRoleID == caseRoleActual)?.TheAttorney?.s_InternalCode;
            //dataPC.APPN_COPY//申请文件份数--苏文静说不用回写
            //dataPC.BILL_COPY//账单份数--苏文静说不用回写



            dataPC.BILLING_CONTACT = dataIPSP.TheClient?.ClientAddress.Cast<ClientAddress>().FirstOrDefault(a => a.s_Type.Contains("B"))?.s_Street;
            dataPC.MAILING_ADDR = dataIPSP.TheClient?.ClientAddress.Cast<ClientAddress>().FirstOrDefault(a => a.s_Type.Contains("M"))?.s_Street;
            dataPC.MAILING_CONTACT = dataIPSP.TheClient?.ClientAddress.Cast<ClientAddress>().FirstOrDefault(a => a.s_Type.Contains("M"))?.s_TitleAddress;

            var charCount = dataIPSP.Memos.Cast<CaseMemo>().FirstOrDefault(m => m.s_Type == "字数");//新申请任务链、翻译费类型的所有工作项字数的总和
            if (charCount != null)
            {
                var nCount = default(int);
                int.TryParse(charCount.s_Memo, out nCount);
                dataPC.CHARCOUNT = nCount;//字数
            }
            var claimNum = dataIPSP.Memos.Cast<CaseMemo>().FirstOrDefault(m => m.s_Type == "权项数");//权项数工作项
            if (claimNum != null)
            {
                int nClaimNum;
                int.TryParse(claimNum.s_Memo, out nClaimNum);
                dataPC.CLAIM_NUM = nClaimNum;//权项数
            }
            var nCodeFieldId = new XPQuery<CodeCaseCustomField>(new UnitOfWork()).FirstOrDefault(f => f.s_CustomFieldName == "文种")?.n_ID;
            if (nCodeFieldId > 0)
            {
                var memoLanguage = dataIPSP.CustomFields.Cast<CustomField>().FirstOrDefault(m => m.n_FieldCodeID == nCodeFieldId);
                if (memoLanguage != null)
                    dataPC.LANGUAGE = memoLanguage.s_Value;//文种->自定义属性
            }
            if (dataIPSP.TheLawInfo != null)
                dataPC.PRE_EXAM_PASSED = dataIPSP.TheLawInfo.dt_FirstCheckDate;//初审合格日
            if (dataIPSP.TheLawInfo != null)
                dataPC.PUBLICATION_NO = dataIPSP.TheLawInfo.s_PubNo;
            if (dataIPSP.TheLawInfo != null)
                dataPC.SE_DATE = dataIPSP.TheLawInfo.dt_SubstantiveExamDate;//进入实审日（发文日）


            var outFileBD = dataIPSP.FileInCases.Cast<FileInCase>().Select(f => f.TheFile).FirstOrDefault(c => c != null && c.s_Name.Contains("办理登记手续通知") && c.s_ClientGov == "O" && c.s_IOType == "I");
            if (outFileBD != null)
            {
                dataPC.GRANTNOTIC_DATE = outFileBD.dt_SendDate;//办登发文日——办理登记手续通知书的发文日
                dataPC.REGFEE_DL = outFileBD.dt_SendDate.AddDays(15).AddMonths(2); //办登绝限——办理登记手续通知书的发文日+15天+2月
            }

            var feeBD = dataIPSP.FeeInCases.Cast<FeeInCase>().Select(f => f.TheFee).FirstOrDefault(f => f != null && f.s_OfficialFeeName.Contains("办理登记"));
            if (feeBD != null && feeBD.dt_PayDate > new DateTime(1900, 1, 1))
                dataPC.REGFEE_SUBMIT = feeBD.dt_PayDate; //办登日

            dataPC.ANNO_NO = dataIPSP.TheLawInfo?.s_IssuedPubNo;

            dataPC.STATUS_DATE = dataIPSP.dt_RequestSubmitDate;//已提实审日
            var outFileReexam = dataIPSP.FileInCases.Cast<FileInCase>().Select(f => f.TheFile).FirstOrDefault(c => c != null && c.s_Name.Contains("提实审") && c.s_ClientGov == "C" && c.s_IOType == "O");
            if (outFileReexam != null)
                dataPC.CLIENT_STATUS = "Y";//客户提示提实审——判断是否存在“提实审”名称的客户来文
            //dataPC.YFEE_DATE//
            //dataPC.YFEE1
            //dataPC.YFEE2
            dataPC.CERTIFICATE_NO = Convert.ToDecimal(string.IsNullOrWhiteSpace(dataIPSP.TheLawInfo?.s_CertfNo) ? "0" : dataIPSP.TheLawInfo?.s_CertfNo);
            dataPC.OAGENT1 = new XPQuery<CodeEmployee>(new UnitOfWork()).FirstOrDefault(c => c.n_ID == dataIPSP.n_FirstAttorney)?
                                .s_InternalCode;
            dataPC.OAGENT2 = new XPQuery<CodeEmployee>(new UnitOfWork()).FirstOrDefault(c => c.n_ID == dataIPSP.n_SecondAttorney)?
                    .s_InternalCode;

            //实审费已交——官费是否存在“实审费”并且状态是已缴
            if (dataIPSP.FeeInCases.Cast<FeeInCase>().Select(i => i.TheFee)
                    .Any(f => f != null && f.s_OfficialFeeName.Contains("实审费") && f.s_Status[2] == 'F'))
                dataPC.SEFEE = "Y";

            //申请费已提交——官费是否存在“申请费”并且状态是已缴
            if (dataIPSP.FeeInCases.Cast<FeeInCase>().Select(i => i.TheFee)
        .Any(f => f != null && f.s_OfficialFeeName.Contains("申请费") && f.s_Status[2] == 'F'))
                dataPC.APPFEE = "Y";

            dataPC.IGNOREANNUALFEE = dataIPSP.Demands.Cast<Demand>().Where(d => d.s_Title.Contains("年费")).Aggregate(string.Empty, (s, d) => "\r\n" + d.s_Title + "\r\n" + d.s_Description + "\r\n");//年费备注——找对应的要求

            //翻译人——案件处理人
            var caseRoleTrans = new XPQuery<CodeCaseRole>(new UnitOfWork()).FirstOrDefault(r => r.s_Name == "翻译")?.n_ID;
            dataPC.TRANSLATOR = dataIPSP.CaseAttorneys.Cast<CaseAttorney>().FirstOrDefault(a => a.n_CaseRoleID == caseRoleTrans)?.TheAttorney?.s_InternalCode;

            //一校——案件处理人
            var caseRoleFirstCheck = new XPQuery<CodeCaseRole>(new UnitOfWork()).FirstOrDefault(r => r.s_Name == "一校")?.n_ID;
            dataPC.CORRECTOR1 = dataIPSP.CaseAttorneys.Cast<CaseAttorney>().FirstOrDefault(a => a.n_CaseRoleID == caseRoleFirstCheck)?.TheAttorney?.s_InternalCode;

            //二校——案件处理人
            var caseRoleSecondCheck = new XPQuery<CodeCaseRole>(new UnitOfWork()).FirstOrDefault(r => r.s_Name == "二校")?.n_ID;
            dataPC.CORRECTOR2 = dataIPSP.CaseAttorneys.Cast<CaseAttorney>().FirstOrDefault(a => a.n_CaseRoleID == caseRoleSecondCheck)?.TheAttorney?.s_InternalCode;

            //dataPC.URGENT_CO//加急系数

            //第一申请人的卷号
            dataPC.APP_REF = dataIPSP.Applicants.Cast<Applicant>().FirstOrDefault(a => !string.IsNullOrWhiteSpace(a.s_AppSerial))?.s_AppSerial;//申请人卷号——
            dataPC.DIV_FILINGDATE = dataIPSP.dt_DivSubmitDate;//分案-申请提交日
            dataPC.DIV_PARENTAPPNO = dataIPSP.s_OrigAppNo; //分案-母案申请号
            //dataPC.STATUS


            //if (!IsExistDataPC.HasValue) return;
            //if (IsExistDataPC.Value)
            //{
            //    new PC.BLL.CLIENTDB().Update(dataPC);
            //}
            //else
            //{
            //    new PC.BLL.CLIENTDB().Add(dataPC);
            //}
        }
    }
}