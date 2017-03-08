using System;
using System.Linq;
using DataSyncTool.DBIPS4_Import;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Case
{
    public class SyncPatentData : SyncData<TPCase_Patent, PATENTCASE>
    {
        public override PATENTCASE GetExistDataPC(TPCase_Patent dataIPSP)
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

        public override void ConvertToDataPC(PATENTCASE dataPC, TPCase_Patent dataIPSP)
        {
            dataPC.OURNO = dataIPSP.s_CaseSerial;
            dataPC.CLIENT = dataIPSP.n_ClientID?.s_ClientCode;
            dataPC.RECEIVED = dataIPSP.dt_UndertakeDate;
            dataPC.AGENT =
                new XPQuery<TCode_Employee>(new UnitOfWork()).FirstOrDefault(c => c.n_ID == dataIPSP.n_FirstAttorney)?
                    .s_InternalCode;
            dataPC.CLIENT_NUMBER = dataIPSP.s_ClientSerial;
            if (dataIPSP.n_LawID != null)
                dataPC.FILING_DATE = dataIPSP.n_LawID.dt_AppDate;
            var earliestPriority = dataIPSP.TPCase_Prioritys.OrderBy(p => p.dt_PDate).FirstOrDefault();
            if (earliestPriority != null)
                dataPC.EARLIEST_PRIORITY = earliestPriority.dt_PDate;
            if (dataIPSP.n_LawID != null)
                dataPC.PUBLICATION = dataIPSP.n_LawID.dt_PubDate;
            //dataPC.FIRST_HK_DATE//第一次香港登记日
            //dataPC.FIRST_HK_CANCELLED//放弃第一次香港登记

            //dataPC.SE_STATUS//已提实审——判断发文
            var outFile = new XPQuery<T_OutFiles>(new UnitOfWork()).Where(dataIPSP.T_FileInCases.Select(f => f.n_FileID).Contains).FirstOrDefault(c => c.s_Name.Contains("实质审查请求") && c.s_ClientGov == "O");
            if (outFile != null)
                dataPC.SE_STATUS = "Y";

            //dataPC.SE_INITIATED//是否进入实审——判断来文
            var inFile = new XPQuery<T_InFiles>(new UnitOfWork()).Where(dataIPSP.T_FileInCases.Select(f => f.n_FileID).Contains).FirstOrDefault(c => c.s_Name.Contains("进入实质审查") && c.s_ClientGov == "O");
            if (inFile != null)
                dataPC.SE_INITIATED = "Y";

            //dataPC.OA_RECEIVED//收到OA——判断来文
            var inFileOA = new XPQuery<T_InFiles>(new UnitOfWork()).Where(dataIPSP.T_FileInCases.Select(f => f.n_FileID).Contains).FirstOrDefault(c => c.s_Name.Contains("审查意见通知") && c.s_ClientGov == "O");
            if (inFileOA != null)
                dataPC.OA_RECEIVED = "Y";

            if (dataIPSP.n_LawID != null)
                dataPC.GAZETTE = dataIPSP.n_LawID.dt_IssuedPubDate;
            //dataPC.SECOND_HK_CANCELLED//放弃第二次香港注册
            //dataPC.SECOND_HK_DATE//第二次香港注册日

            //dataPC.REJECTED//被驳回——判断驳回决定
            var inFileRejected = new XPQuery<T_InFiles>(new UnitOfWork()).Where(dataIPSP.T_FileInCases.Select(f => f.n_FileID).Contains).FirstOrDefault(c => c.s_Name.Contains("驳回决定") && c.s_ClientGov == "O");
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
            var inFileReexamination = new XPQuery<T_InFiles>(new UnitOfWork()).Where(dataIPSP.T_FileInCases.Select(f => f.n_FileID).Contains).FirstOrDefault(c => c.s_Name.Contains("复审通知") && c.s_ClientGov == "O");
            var inFileReexaminationDecision = new XPQuery<T_InFiles>(new UnitOfWork()).Where(dataIPSP.T_FileInCases.Select(f => f.n_FileID).Contains).FirstOrDefault(c => c.s_Name.Contains("复审决定") && c.s_ClientGov == "O");
            if (inFileReexamination != null && inFileReexaminationDecision == null)
                dataPC.UNDER_REEXAMINATION = "Y";

            //dataPC.UNDER_LITIGATION //正在进行诉讼程序--苏文静说不用回写
            //dataPC.INVALIDATED//正被无效--苏文静说不用回写

            for (var i = 0; i < dataIPSP.TCase_Clientss.Count; i++)
            {
                if (i > 3) continue;
                var relateClient = dataIPSP.TCase_Clientss[i].n_ClientID;
                dataPC.GetType().GetProperty($"CLIENT{i + 2}").SetValue(dataIPSP, relateClient?.s_ClientCode);
            }

            dataPC.APPL_NUM = dataIPSP.TCase_Applicants.Count;//申请人总数
            for (var i = 0; i < dataIPSP.TCase_Applicants.Count; i++)
            {
                if (i > 4) continue;
                var caseApplicant = dataIPSP.TCase_Applicants.OrderBy(c => c.n_Sequence).ToList()[i];
                dataPC.GetType().GetProperty($"APPLICANT{i + 1}").SetValue(dataIPSP, caseApplicant.s_NativeName);
                dataPC.GetType().GetProperty($"APPLICANT_CH{i + 1}").SetValue(dataIPSP, caseApplicant.s_Name);
                var applicant = new XPQuery<TCstmr_Applicant>(new UnitOfWork()).FirstOrDefault(a => a.n_AppID == caseApplicant.n_ApplicantID);
                if (applicant != null)
                    dataPC.GetType().GetProperty($"APPL_CODE{i + 1}").SetValue(dataIPSP, applicant.s_AppCode);
            }

            dataPC.INVEN_NUM = dataIPSP.TPCase_Inventors.Count;//发明人总数
            for (var i = 0; i < dataIPSP.TPCase_Inventors.Count; i++)
            {
                if (i > 20) continue;
                var inventor = dataIPSP.TPCase_Inventors.OrderBy(v => v.n_Sequence).ToList()[i];
                dataPC.GetType().GetProperty($"INVENTOR{i + 1}").SetValue(dataIPSP, inventor.s_NativeName);
                dataPC.GetType().GetProperty($"INVENTOR_CH{i + 1}").SetValue(dataIPSP, inventor.s_Name);
            }

            dataPC.TOTAL_PRI = dataIPSP.TPCase_Prioritys.Count;
            for (int i = 0; i < dataIPSP.TPCase_Prioritys.Count; i++)
            {
                if (i > 11) continue;
                var priority = dataIPSP.TPCase_Prioritys.OrderBy(v => v.n_Sequence).ToList()[i];
                var country = new XPQuery<TCode_Country>(new UnitOfWork()).FirstOrDefault(c => c.n_ID == priority.n_PCountry);
                dataPC.GetType().GetProperty($"PRI_COUNTRY{(i == 0 ? string.Empty : (i + 1).ToString())}").SetValue(dataIPSP, country?.s_CountryCode);
                dataPC.GetType().GetProperty($"PRI_NUMBER{i + 1}").SetValue(dataIPSP, priority.s_PNum);
                dataPC.GetType().GetProperty($"PRI_DATE{i + 1}").SetValue(dataIPSP, priority.dt_PDate);
            }
            dataPC.TITLE = dataIPSP.s_CaseNativeName;
            if (dataIPSP.n_LawID != null)
                dataPC.PCT_APPN_DATE = dataIPSP.n_LawID.dt_PctAppDate;
            dataPC.FILING_DUE = dataIPSP.dt_ShldSbmtDate; //计划日
            dataPC.COMMENTS = dataIPSP.TCase_Memos.Aggregate(string.Empty, (s, m) => s + "\r\n" + m.s_Memo + "\r\n");
            dataPC.CLIENT_NAME = dataIPSP.n_ClientID?.s_Name;

            if (dataIPSP.n_LawID != null)
                dataPC.PCT_PUBDATE = dataIPSP.n_LawID.dt_PctPubDate;
            dataPC.PCT_PUBNUM = dataIPSP.n_LawID?.s_PCTPubNo;
            dataPC.DEADLINE = dataIPSP.dt_ShldSbmtDate;//客户指定/绝限期——要求提交日
            dataPC.TITLE_CHINESE = dataIPSP.s_CaseName;
            //dataPC.AGENT_ACTUAL //实际代理人——处理人里找对应角色人员
            var caseRoleActual = new XPQuery<TCode_CaseRole>(new UnitOfWork()).FirstOrDefault(r => r.s_Name == "实际代理人")?.n_ID;
            dataPC.AGENT_ACTUAL = dataIPSP.TCase_Attorneys.FirstOrDefault(a => a.n_CaseRoleID == caseRoleActual)?.n_AttorneyID?.s_InternalCode;
            //dataPC.APPN_COPY//申请文件份数--苏文静说不用回写
            //dataPC.BILL_COPY//账单份数--苏文静说不用回写



            dataPC.BILLING_CONTACT = dataIPSP.n_ClientID?.TCstmr_ClientAddresss.FirstOrDefault(a => a.s_Type.Contains("B"))?.s_Street;
            dataPC.MAILING_ADDR = dataIPSP.n_ClientID?.TCstmr_ClientAddresss.FirstOrDefault(a => a.s_Type.Contains("M"))?.s_Street;
            dataPC.MAILING_CONTACT = dataIPSP.n_ClientID?.TCstmr_ClientAddresss.FirstOrDefault(a => a.s_Type.Contains("M"))?.s_TitleAddress;

            var charCount = dataIPSP.TCase_Memos.FirstOrDefault(m => m.s_Type == "字数");//新申请任务链、翻译费类型的所有工作项字数的总和
            if (charCount != null)
            {
                var nCount = default(int);
                int.TryParse(charCount.s_Memo, out nCount);
                dataPC.CHARCOUNT = nCount;//字数
            }
            var claimNum = dataIPSP.TCase_Memos.FirstOrDefault(m => m.s_Type == "权项数");//权项数工作项
            if (claimNum != null)
            {
                int nClaimNum;
                int.TryParse(claimNum.s_Memo, out nClaimNum);
                dataPC.CLAIM_NUM = nClaimNum;//权项数
            }
            var nCodeFieldId = new XPQuery<TCode_CaseCustomField>(new UnitOfWork()).FirstOrDefault(f => f.s_CustomFieldName == "文种")?.n_ID;
            if (nCodeFieldId > 0)
            {
                var memoLanguage = dataIPSP.TCase_CaseCustomFields.FirstOrDefault(m => m.n_FieldCodeID == nCodeFieldId);
                if (memoLanguage != null)
                    dataPC.LANGUAGE = memoLanguage.s_Value;//文种->自定义属性
            }
            if (dataIPSP.n_LawID != null)
                dataPC.PRE_EXAM_PASSED = dataIPSP.n_LawID.dt_FirstCheckDate;//初审合格日
            if (dataIPSP.n_LawID != null)
                dataPC.PUBLICATION_NO = dataIPSP.n_LawID.s_PubNo;
            if (dataIPSP.n_LawID != null)
                dataPC.SE_DATE = dataIPSP.n_LawID.dt_SubstantiveExamDate;//进入实审日（发文日）


            var outFileBD = new XPQuery<T_OutFiles>(new UnitOfWork()).Where(dataIPSP.T_FileInCases.Select(f => f.n_FileID).Contains).FirstOrDefault(c => c.s_Name.Contains("办理登记手续") && c.s_ClientGov == "O");
            if (outFileBD != null)
            {
                dataPC.GRANTNOTIC_DATE = outFileBD.dt_SendDate;//办登发文日——办理登记手续通知书的发文日
                dataPC.REGFEE_DL = outFileBD.dt_SendDate.AddDays(15).AddMonths(2); //办登绝限——办理登记手续通知书的发文日+15天+2月
            }

            var feeBD = dataIPSP.T_FeeInCases.Select(f => f.n_FeeID).FirstOrDefault(f => f != null && f.s_OfficialFeeName.Contains("办理登记"));
            if (feeBD != null && feeBD.dt_PayDate > new DateTime(1900, 1, 1))
                dataPC.REGFEE_SUBMIT = feeBD.dt_PayDate; //办登日

            dataPC.ANNO_NO = dataIPSP.n_LawID?.s_IssuedPubNo;

            dataPC.STATUS_DATE = dataIPSP.dt_RequestSubmitDate;//已提实审日
            var outFileReexam = new XPQuery<T_OutFiles>(new UnitOfWork()).Where(dataIPSP.T_FileInCases.Select(f => f.n_FileID).Contains).FirstOrDefault(c => c.s_Name.Contains("提实审") && c.s_ClientGov == "C");
            if (outFileReexam != null)
                dataPC.CLIENT_STATUS = "Y";//客户提示提实审——判断是否存在“提实审”名称的客户来文
            //dataPC.YFEE_DATE//
            //dataPC.YFEE1
            //dataPC.YFEE2
            dataPC.CERTIFICATE_NO = Convert.ToDecimal(dataIPSP.n_LawID?.s_CertfNo);
            dataPC.OAGENT1 = new XPQuery<TCode_Employee>(new UnitOfWork()).FirstOrDefault(c => c.n_ID == dataIPSP.n_FirstAttorney)?
                                .s_InternalCode;
            dataPC.OAGENT2 = new XPQuery<TCode_Employee>(new UnitOfWork()).FirstOrDefault(c => c.n_ID == dataIPSP.n_SecondAttorney)?
                    .s_InternalCode;

            //实审费已交——官费是否存在“实审费”并且状态是已缴
            if (dataIPSP.T_FeeInCases.Select(i => i.n_FeeID)
                    .Any(f => f != null && f.s_OfficialFeeName.Contains("实审费") && f.s_Status[2] == 'F'))
                dataPC.SEFEE = "Y";

            //申请费已提交——官费是否存在“申请费”并且状态是已缴
            if (dataIPSP.T_FeeInCases.Select(i => i.n_FeeID)
        .Any(f => f != null && f.s_OfficialFeeName.Contains("申请费") && f.s_Status[2] == 'F'))
                dataPC.APPFEE = "Y";

            dataPC.IGNOREANNUALFEE = dataIPSP.T_Demands.Where(d => d.s_Title.Contains("年费")).Aggregate(string.Empty, (s, d) => "\r\n" + d.s_Title + "\r\n" + d.s_Description + "\r\n");//年费备注——找对应的要求

            //翻译人——案件处理人
            var caseRoleTrans = new XPQuery<TCode_CaseRole>(new UnitOfWork()).FirstOrDefault(r => r.s_Name == "翻译")?.n_ID;
            dataPC.TRANSLATOR = dataIPSP.TCase_Attorneys.FirstOrDefault(a => a.n_CaseRoleID == caseRoleTrans)?.n_AttorneyID?.s_InternalCode;

            //一校——案件处理人
            var caseRoleFirstCheck = new XPQuery<TCode_CaseRole>(new UnitOfWork()).FirstOrDefault(r => r.s_Name == "一校")?.n_ID;
            dataPC.CORRECTOR1 = dataIPSP.TCase_Attorneys.FirstOrDefault(a => a.n_CaseRoleID == caseRoleFirstCheck)?.n_AttorneyID?.s_InternalCode;

            //二校——案件处理人
            var caseRoleSecondCheck = new XPQuery<TCode_CaseRole>(new UnitOfWork()).FirstOrDefault(r => r.s_Name == "二校")?.n_ID;
            dataPC.CORRECTOR2 = dataIPSP.TCase_Attorneys.FirstOrDefault(a => a.n_CaseRoleID == caseRoleSecondCheck)?.n_AttorneyID?.s_InternalCode;

            //dataPC.URGENT_CO//加急系数

            //第一申请人的卷号
            dataPC.APP_REF = dataIPSP.TCase_Applicants.FirstOrDefault(a => !string.IsNullOrWhiteSpace(a.s_AppSerial))?.s_AppSerial;//申请人卷号——
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