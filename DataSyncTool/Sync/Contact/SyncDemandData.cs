using System;
using System.Collections;
using System.Data.OracleClient;
using System.Linq;
using DataEntities.Contact.Client;
using DataEntities.Contact.Demand;
using DataSyncTool.DBUtility;
using DataSyncTool.Log;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;

namespace DataSyncTool.Sync.Contact
{
    public class SyncDemandData : SyncData<Demand, GENERAL_INSTRUCTION>
    {
        private Hashtable htDemandType;
        public SyncDemandData(object dataIPSPIndex) : base(dataIPSPIndex)
        {
            GetRelatesType();
        }

        public override GENERAL_INSTRUCTION GetExistDataPC(Demand dataIPSP)
        {
            var sCondition = $"CONTENT_CN =:p AND CLIENT_NO = '{dataIPSP.TheClient?.s_ClientCode}'";
            var pid = new PC.BLL.GENERAL_INSTRUCTION().GetSingle(sCondition, dataIPSP.s_Description ?? string.Empty);
            if (pid == null) return null;
            IsExistDataPC = true;
            var instruction = new PC.BLL.GENERAL_INSTRUCTION().GetModel(pid.ToString());
            SyncResultInfoSet.AddInfo(InfoString.ToSyncInfo("客户要求", IsExistDataPC.Value, dataIPSP.n_ID, dataIPSP.TheClient?.s_ClientCode + " " + dataIPSP.s_Description),
                dataIPSP.ClassInfo.TableName, typeof(GENERAL_INSTRUCTION).Name);
            return instruction;
        }

        public override void ConvertToDataPC(GENERAL_INSTRUCTION dataPC, Demand dataIPSP)
        {
            dataPC.PID = DateTime.Now.ToString("yyyyMMdd_HHmmss_ffffff");
            if (string.IsNullOrWhiteSpace(dataIPSP.TheClient.s_ClientCode))
            {
                SyncResultInfoSet.AddWarning(InfoString.ToSkipInfo("客户代码", dataIPSP.n_ID, dataIPSP.TheClient?.s_ClientCode + " " + dataIPSP.s_Description));
                return;
            }
            dataPC.CLIENT_NO = dataIPSP.TheClient.s_ClientCode;
            if (dataIPSP.dt_ReceiptDate <= new DateTime(1900, 1, 1))
            {
                SyncResultInfoSet.AddWarning(InfoString.ToSkipInfo("收到日", dataIPSP.n_ID, dataIPSP.TheClient?.s_ClientCode + " " + dataIPSP.s_Description));
                return;
            }
            dataPC.RECEIVED = dataIPSP.dt_ReceiptDate;
            if (string.IsNullOrWhiteSpace(dataIPSP.s_ReceiptMethod))
            {
                SyncResultInfoSet.AddWarning(InfoString.ToSkipInfo("收到方式", dataIPSP.n_ID, dataIPSP.TheClient?.s_ClientCode + " " + dataIPSP.s_Description));
                return;
            }
            if (dataIPSP.s_ReceiptMethod.ToLower().Contains("fax") || dataIPSP.s_ReceiptMethod.ToLower().Contains("传真"))
                dataPC.RECEIVED_BY = "fax";
            else if (dataIPSP.s_ReceiptMethod.ToLower().Contains("mail") || dataIPSP.s_ReceiptMethod.ToLower().Contains("信"))
                dataPC.RECEIVED_BY = "mail";
            else if (dataIPSP.s_ReceiptMethod.ToLower().Contains("email") || dataIPSP.s_ReceiptMethod.ToLower().Contains("邮件") || dataIPSP.s_ReceiptMethod.ToLower().Contains("邮箱"))
                dataPC.RECEIVED_BY = "email";
            else
                dataPC.RECEIVED_BY = "other";

            dataPC.RELATES_TO = htDemandType.ContainsKey(dataIPSP.s_Title) ? htDemandType[dataIPSP.s_Title].ToString() : "other";

            dataPC.CONTENT_CN = dataIPSP.s_Description;
            dataPC.INSTRUCTOR = dataIPSP.s_Assignor;
            dataPC.STATUS = "valid";
            //dataPC.EXPIRE_DATE
            //dataPC.COMMENTS

            FillDefaultValue();
            if (!IsExistDataPC.HasValue) return;
            if (IsExistDataPC.Value)
            {
                new PC.BLL.GENERAL_INSTRUCTION().Update(dataPC);
            }
            else
            {
                new PC.BLL.GENERAL_INSTRUCTION().Add(dataPC);
            }
        }

        private void GetRelatesType()
        {
            htDemandType = new Hashtable();
            htDemandType.Add("新申请同时提实审", "se_request");
            htDemandType.Add("账单随函", "bill_requirement");
            htDemandType.Add("账单后出", "bill_requirement");
            htDemandType.Add("需制图", "new_app_handling");
            htDemandType.Add("新申请同时要求提前公开", "new_app_handling");
            htDemandType.Add("OA不要预转", "oa_handling");
            htDemandType.Add("提供OA/复审报价", "oa_handling");
            htDemandType.Add("需补交优先权在先申请文件副本", "intermediate_handling");
            htDemandType.Add("需补交优先权转让证明文件", "intermediate_handling");
            htDemandType.Add("需补交委托书", "intermediate_handling");
            htDemandType.Add("需要二校", "new_app_handling");
            htDemandType.Add("需要特殊校对", "new_app_handling");
            htDemandType.Add("递交前需送检申请文件", "new_app_handling");
            htDemandType.Add("使用宽限期", "new_app_handling");
            htDemandType.Add("在提实审时交主动修改", "se_request");
            htDemandType.Add("新申请递交之后放弃", "new_app_handling");
            htDemandType.Add("新申请递交时同时提保密审查", "new_app_handling");
            htDemandType.Add("缴纳到期官费", "other");
            htDemandType.Add("办登时提供授权权利要求的英文/日文翻译", "grant_handling");
            htDemandType.Add("进实审阶段后交主动修改", "intermediate_handling");
            htDemandType.Add("转公布时提供整套申请文件", "intermediate_handling");
            htDemandType.Add("实用新型或外观设计主动修改", "intermediate_handling");
            htDemandType.Add("结案之后仍转官方发文", "abandonment");
            htDemandType.Add("需补交生物保藏/存活证明", "intermediate_handling");
            htDemandType.Add("需补交申请权转让证明文件", "intermediate_handling");
            htDemandType.Add("需补交技术进出口许可证或合同备案证明", "intermediate_handling");
            htDemandType.Add("PCT国际阶段或国外申请已收到POA", "new_app_handling");
            htDemandType.Add("PCT国际阶段或国外申请已收到优证文件（DAS码）", "new_app_handling");
            htDemandType.Add("递交前需送检答复文件", "oa_handling");
            htDemandType.Add("不需提供OA正文翻译", "oa_handling");
            htDemandType.Add("需补交不丧失新颖性公开证明文件", "intermediate_handling");
            htDemandType.Add("新申请递交之后发国外申请时限提醒", "intermediate_handling");
            htDemandType.Add("转OA时不需要提供任何意见和建议(不适用于驳回和复审决定)", "oa_handling");
            htDemandType.Add("只在最后绝限前发提醒", "oa_handling");
            htDemandType.Add("OA简转，但需要代理人提供转达信函(不适用于驳回)", "oa_handling");
            htDemandType.Add("OA由代理人自行答复，不需发送提醒和客户的指示", "oa_handling");
            htDemandType.Add("在OA答复绝限前未收到客户指示，自行答复OA", "oa_handling");
            htDemandType.Add("OA一通转达时限为发文日起1个月", "oa_timing");
            htDemandType.Add("OA一通转达时限为发文日起20天", "oa_timing");
            htDemandType.Add("账单在动作完成后5天内开出", "bill_requirement");
            htDemandType.Add("转办登时提供提供分案报价", "grant_handling");
            htDemandType.Add("转证书时提供授权权利要求的英文/日文翻译", "grant_handling");
            htDemandType.Add("我方完成任何动作之后不需要报告", "other");
            htDemandType.Add("无需提醒提实审时限", "se_request");
            htDemandType.Add("递交新申请之后，还需单独向申请人汇报", "new_app_handling");
            htDemandType.Add("提醒客户香港申请", "intermediate_handling");
            htDemandType.Add("提醒客户澳门申请", "grant_handling");
            htDemandType.Add("寄送证书时提供整套授权公告文件纸件", "grant_handling");
            htDemandType.Add("办登绝限前无指示，我方自动办登", "grant_handling");
            htDemandType.Add("办登同时缴下一年年费", "grant_handling");
            htDemandType.Add("不必发年费提醒，我方主动代缴年费", "annuity");
            htDemandType.Add("发年费提醒，无相反指示，我方代缴年费", "annuity");
            htDemandType.Add("忽略年费，但需转后续官文", "annuity");
            htDemandType.Add("忽略年费，无需转后续官文", "annuity");
            htDemandType.Add("只提醒办登当年年费", "annuity");
            htDemandType.Add("只提醒年费缴纳期限，不代缴年费", "annuity");
            htDemandType.Add("年费绝限落在授权公告日起6个月内，我方主动代缴年费", "annuity");
            htDemandType.Add("年费直接联系专利权人", "annuity");
            htDemandType.Add("任何动作前先提供报价", "other");
            htDemandType.Add("收到受理通知书之后办理优证文件副本", "intermediate_handling");
            htDemandType.Add("收到受理通知书之后办理受理通知书/保密审查通知/缴费通知书纸件", "intermediate_handling");
            htDemandType.Add("收到受理通知书之后办理DAS码", "intermediate_handling");
            htDemandType.Add("客户自缴官费", "other");
            htDemandType.Add("包括官费在内的所有账单在动作完成2个月内开出", "bill_requirement");
            htDemandType.Add("申请后提交参考资料", "intermediate_handling");
            htDemandType.Add("申请后提交提前公开", "intermediate_handling");
            htDemandType.Add("进入实审后所有官文需转", "other");
            htDemandType.Add("申请后提交保密审查", "intermediate_handling");
            htDemandType.Add("尽量推迟提实审", "se_request");
            htDemandType.Add("收到办登通知后办理办登通知书纸件", "grant_handling");
            htDemandType.Add("任何动作前先预报以获取客户报价指示，客户同意后再动作", "other");
            htDemandType.Add("仅通过邮寄寄送专利证书，不必发送电子件", "grant_handling");
            htDemandType.Add("寄送证书时提供相应的CD光盘", "grant_handling");
            htDemandType.Add("递交PPH请求", "intermediate_handling");
            htDemandType.Add("PCT申请国际阶段所有的官文都需转达", "other");
            htDemandType.Add("PCT申请在递交日后1周内发正式报告", "new_app_timing");
            htDemandType.Add("在新申请定稿之后再发申请信息确认表", "new_app_handling");
            htDemandType.Add("根据客户指定的案件分类确定OA的转答方式", "oa_handling");
            htDemandType.Add("OA一通转达时限为发文日起4周", "oa_timing");
            htDemandType.Add("根据客户指定的案件分类确定驳回决定的转答方式", "oa_handling");
            htDemandType.Add("根据客户指定的案件分类确定复审决定的转答方式", "oa_handling");
            htDemandType.Add("转复审决定时不需要任何意见和建议", "oa_handling");
            htDemandType.Add("OA 处理方式的要求", "oa_handling");
            htDemandType.Add("办登/授权 处理方式的要求", "grant_handling");
            htDemandType.Add("关于放弃的要求", "abandonment");
            htDemandType.Add("关于年费的要求", "annuity");
            htDemandType.Add("其他", "other");
            htDemandType.Add("实审请求", "se_request");
            htDemandType.Add("文件送达方式", "delivery");
            htDemandType.Add("新申请阶段 处理方式的要求", "new_app_handling");
            htDemandType.Add("一般联系方式", "contact");
            htDemandType.Add("账单邮寄地址", "bill_addr");
            htDemandType.Add("中间阶段 处理方式的要求", "oa_handling");
            htDemandType.Add("中间阶段 时间上的要求", "oa_timing");
            htDemandType.Add("账单送达方式", "bill_method");
            htDemandType.Add("OA 时间上的要求", "oa_timing");
            htDemandType.Add("开据账单要求", "bill_requirement");
            htDemandType.Add("文件份数", "num_file");
            htDemandType.Add("新申请阶段 时间上的要求", "new_app_timing");
            htDemandType.Add("OA 联系方式", "oa_contact");
            htDemandType.Add("关于联系方式的总结", "summary_contact");
            htDemandType.Add("办登/授权 联系方式", "grant_contact");
            htDemandType.Add("新申请阶段 联系方式", "new_app_contact");
            htDemandType.Add("账单份数", "num_bill");
            htDemandType.Add("中间阶段 联系方式", "intermediate_contact");
            htDemandType.Add("驳回不需预转", "oa_handling");
            htDemandType.Add("转驳回决定时不需要任何意见和建议", "oa_handling");
            htDemandType.Add("驳回简转,但需要代理人提供转达信函", "oa_handling");
            htDemandType.Add("OA一通转达时限为发文日起2周", "oa_timing");
            htDemandType.Add("OA一通转达时限为发文日起3周", "oa_timing");
            htDemandType.Add("OA一通转达时限为发文日起75天", "oa_timing");
            htDemandType.Add("OA中通转达时限为发文日起2周", "oa_timing");
            htDemandType.Add("OA中通转达时限为发文日起20天", "oa_timing");
            htDemandType.Add("OA中通转达时限为发文日起1个月", "oa_timing");
            htDemandType.Add("OA中通转达时限为发文日起45天", "oa_timing");
            htDemandType.Add("驳回决定转达时限为发文日起2周", "oa_timing");
            htDemandType.Add("驳回决定转达时限为发文日起20天", "oa_timing");
            htDemandType.Add("驳回决定转达时限为发文日起1个月", "oa_timing");
            htDemandType.Add("驳回决定转达时限为发文日起45天", "oa_timing");
            htDemandType.Add("复审决定转达时限为发文日起2周", "oa_timing");
            htDemandType.Add("复审决定转达时限为发文日起20天", "oa_timing");
            htDemandType.Add("复审决定转达时限为发文日起1个月", "oa_timing");
            htDemandType.Add("复审决定转达时限为发文日起45天", "oa_timing");
            htDemandType.Add("复审通知书转达时限为发文日起2周", "oa_timing");
            htDemandType.Add("不需提供复审决定正文翻译", "oa_handling");
            htDemandType.Add("复审决定简转,但需要代理人提供转达信函", "oa_handling");
            htDemandType.Add("复审决定不要预转", "oa_handling");
            htDemandType.Add("不需提供驳回决定正文翻译", "oa_handling");
            htDemandType.Add("复审决定不要预转（需预转）", "oa_handling");
        }
    }
}