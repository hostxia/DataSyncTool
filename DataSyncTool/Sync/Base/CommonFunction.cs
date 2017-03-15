using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DataEntities.Config;
using DataSyncTool.PC.BLL;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Base
{
    public static class CommonFunction
    {
        public static string GetIdTextFieldType(string sFieldName)
        {
            var idtext = new IDTEXT().GetModelList($"IDGROUP = 'otherinfotype' and TEXT like '{sFieldName}%'");
            if (idtext.Count > 0)
                return idtext[0].ID;
            return string.Empty;
        }

        public static List<int> GetAbroadPatentBusinessType()
        {
            return new XPQuery<CodeBusinessType>(new UnitOfWork()).Where(b => !new[] { "UM", "PU", "ID", "IN", "PI", "AF", "HS", "HD", "HT" }.Contains(b.s_Code)).Select(b => b.n_ID).ToList();
        }

        public static List<int> GetPatentBusinessType()
        {
            return new XPQuery<CodeBusinessType>(new UnitOfWork()).Where(b => new[] { "UM", "PU", "ID", "IN", "PI", "AF" }.Contains(b.s_Code)).Select(b => b.n_ID).ToList();
        }

        public static Hashtable GetRelatesType()
        {
            var htDemandType = new Hashtable();
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
            return htDemandType;
        }

        public static List<string> UnActiveCaseStatus => new List<string> { "结案", "放弃", "转出", "届满", "失效" };
    }
}