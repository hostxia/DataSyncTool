/**  版本信息模板在安装目录下，可自行修改。
* TCase_Base.cs
*
* 功 能： N/A
* 类 名： TCase_Base
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:25   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/

using System;

namespace DataSyncTool.IPSP.Model
{
	/// <summary>
	/// TCase_Base:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCase_Base
	{
		public TCase_Base()
		{}
		#region Model
		private int _n_caseid;
		private string _s_iptype;
		private string _s_caseserial;
		private int? _n_flownum;
		private string _s_casename;
		private string _s_caseothername;
		private int? _n_businesstypeid;
		private string _s_flowdirection;
		private int? _n_firstattorney;
		private int? _n_secondattorney;
		private int? _n_officeid;
		private int? _n_regcountry;
		private int _n_coopagencyfromid;
		private int _n_coopagencytoid;
		private string _s_coopagencyfromno;
		private string _s_coopagencytono;
		private int _n_clientid;
		private string _s_clientserial;
		private int _n_introid;
		private decimal? _n_introfee;
		private int? _n_introcurrency;
		private string _s_introserial;
		private DateTime? _dt_undertakedate;
		private DateTime? _dt_shldsbmtdate;
		private DateTime? _dt_submitdate;
		private string _s_casestatus;
		private string _s_feemode;
		private decimal? _n_feediscount;
		private decimal? _n_fixafee;
		private decimal? _n_fixfee;
		private string _s_paymode;
		private string _s_feestatusorder;
		private string _s_feestatusinit;
		private int? _n_chargecurrency;
		private int? _n_officialcurrency;
		private string _s_isregonline;
		private string _s_totalserial;
		private string _s_seriallocation;
		private string _s_inconsole;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private int _objecttype;
		private string _s_othername;
		private int? _n_endprocess;
		private decimal? _n_introper;
		private string _s_submitstatus;
		private DateTime? _dt_submitteddate;
		private string _s_processmark;
		private int? _n_departmentid;
		private string _s_applicants;
		private string _s_clientcontacts;
		private string _s_dealers;
		private string _s_creator;
		private string _s_editor;
		private string _s_currentoperator;
		private int _n_contractid;
		private string _s_casenativename;
		private int? _n_appcountry;
		private string _s_dealersid;
		private int? _n_processid;
		private int? _n_startprocessid;
		private string _s_appno;
		private DateTime? _dt_appdate;
		private string _s_applicantaddresses;
		private string _s_acceptno;
		private string _s_cprocesscodeids;
		private string _s_ncprocesscodeids;
		private string _s_applicantscountry;
		private string _s_applicantsnativename;
		private string _s_customfield1;
		private string _s_customfield2;
		private string _s_customfield3;
		private string _s_customfield4;
		private string _s_customfield5;
		private string _s_customfield6;
		private string _s_customfield7;
		private string _s_customfield8;
		private string _s_customfield9;
		private string _s_customfield10;
		private int _n_securitylevelid;
		private string _s_applicantid;
		private string _s_istempcase;
		private string _s_ismiddlecase;
		private DateTime? _dt_sendcheckdate;
		private int? _n_preferentialcombineid;
		private string _s_elecpayer;
		private string _s_clientcname;
		private string _s_archivestatus;
		private string _s_archiveposition;
		private int? _n_borrowtimes;
		private int? _n_creatorid;
		private string _s_relateduserids;
		private int? _n_cutrateid;
		private int? _fn_cutrateid;
		private string _s_pricedesc;
		private string _s_payerbilltoname;
		private string _s_payerstreet;
		private string _s_payercity;
		private string _s_payerstate;
		private string _s_payerzipcode;
		private int? _n_payercountry;
		private string _s_payeremail;
		private string _s_appsserial;
		private string _s_manualcreatechain;
		private string _s_applicantcodes;
		/// <summary>
		/// 
		/// </summary>
		public int n_CaseID
		{
			set{ _n_caseid=value;}
			get{return _n_caseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CaseSerial
		{
			set{ _s_caseserial=value;}
			get{return _s_caseserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FlowNum
		{
			set{ _n_flownum=value;}
			get{return _n_flownum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CaseName
		{
			set{ _s_casename=value;}
			get{return _s_casename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CaseOtherName
		{
			set{ _s_caseothername=value;}
			get{return _s_caseothername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_BusinessTypeID
		{
			set{ _n_businesstypeid=value;}
			get{return _n_businesstypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FlowDirection
		{
			set{ _s_flowdirection=value;}
			get{return _s_flowdirection;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FirstAttorney
		{
			set{ _n_firstattorney=value;}
			get{return _n_firstattorney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_SecondAttorney
		{
			set{ _n_secondattorney=value;}
			get{return _n_secondattorney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_OfficeID
		{
			set{ _n_officeid=value;}
			get{return _n_officeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_RegCountry
		{
			set{ _n_regcountry=value;}
			get{return _n_regcountry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_CoopAgencyFromID
		{
			set{ _n_coopagencyfromid=value;}
			get{return _n_coopagencyfromid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_CoopAgencyToID
		{
			set{ _n_coopagencytoid=value;}
			get{return _n_coopagencytoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CoopAgencyFromNo
		{
			set{ _s_coopagencyfromno=value;}
			get{return _s_coopagencyfromno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CoopAgencyToNo
		{
			set{ _s_coopagencytono=value;}
			get{return _s_coopagencytono;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_ClientID
		{
			set{ _n_clientid=value;}
			get{return _n_clientid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ClientSerial
		{
			set{ _s_clientserial=value;}
			get{return _s_clientserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_IntroID
		{
			set{ _n_introid=value;}
			get{return _n_introid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_IntroFee
		{
			set{ _n_introfee=value;}
			get{return _n_introfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_IntroCurrency
		{
			set{ _n_introcurrency=value;}
			get{return _n_introcurrency;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IntroSerial
		{
			set{ _s_introserial=value;}
			get{return _s_introserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_UndertakeDate
		{
			set{ _dt_undertakedate=value;}
			get{return _dt_undertakedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ShldSbmtDate
		{
			set{ _dt_shldsbmtdate=value;}
			get{return _dt_shldsbmtdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_SubmitDate
		{
			set{ _dt_submitdate=value;}
			get{return _dt_submitdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CaseStatus
		{
			set{ _s_casestatus=value;}
			get{return _s_casestatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FeeMode
		{
			set{ _s_feemode=value;}
			get{return _s_feemode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_FeeDiscount
		{
			set{ _n_feediscount=value;}
			get{return _n_feediscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_FixAFee
		{
			set{ _n_fixafee=value;}
			get{return _n_fixafee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_FixFee
		{
			set{ _n_fixfee=value;}
			get{return _n_fixfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayMode
		{
			set{ _s_paymode=value;}
			get{return _s_paymode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FeeStatusOrder
		{
			set{ _s_feestatusorder=value;}
			get{return _s_feestatusorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FeeStatusInit
		{
			set{ _s_feestatusinit=value;}
			get{return _s_feestatusinit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ChargeCurrency
		{
			set{ _n_chargecurrency=value;}
			get{return _n_chargecurrency;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_OfficialCurrency
		{
			set{ _n_officialcurrency=value;}
			get{return _n_officialcurrency;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsRegOnline
		{
			set{ _s_isregonline=value;}
			get{return _s_isregonline;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TotalSerial
		{
			set{ _s_totalserial=value;}
			get{return _s_totalserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SerialLocation
		{
			set{ _s_seriallocation=value;}
			get{return _s_seriallocation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_InConsole
		{
			set{ _s_inconsole=value;}
			get{return _s_inconsole;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CreateDate
		{
			set{ _dt_createdate=value;}
			get{return _dt_createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_EditDate
		{
			set{ _dt_editdate=value;}
			get{return _dt_editdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ObjectType
		{
			set{ _objecttype=value;}
			get{return _objecttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OtherName
		{
			set{ _s_othername=value;}
			get{return _s_othername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_EndProcess
		{
			set{ _n_endprocess=value;}
			get{return _n_endprocess;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_IntroPer
		{
			set{ _n_introper=value;}
			get{return _n_introper;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SubmitStatus
		{
			set{ _s_submitstatus=value;}
			get{return _s_submitstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_SubmittedDate
		{
			set{ _dt_submitteddate=value;}
			get{return _dt_submitteddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ProcessMark
		{
			set{ _s_processmark=value;}
			get{return _s_processmark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_DepartmentID
		{
			set{ _n_departmentid=value;}
			get{return _n_departmentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Applicants
		{
			set{ _s_applicants=value;}
			get{return _s_applicants;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ClientContacts
		{
			set{ _s_clientcontacts=value;}
			get{return _s_clientcontacts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Dealers
		{
			set{ _s_dealers=value;}
			get{return _s_dealers;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Creator
		{
			set{ _s_creator=value;}
			get{return _s_creator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Editor
		{
			set{ _s_editor=value;}
			get{return _s_editor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CurrentOperator
		{
			set{ _s_currentoperator=value;}
			get{return _s_currentoperator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_ContractID
		{
			set{ _n_contractid=value;}
			get{return _n_contractid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CaseNativeName
		{
			set{ _s_casenativename=value;}
			get{return _s_casenativename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AppCountry
		{
			set{ _n_appcountry=value;}
			get{return _n_appcountry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_DealersID
		{
			set{ _s_dealersid=value;}
			get{return _s_dealersid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ProcessID
		{
			set{ _n_processid=value;}
			get{return _n_processid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_StartProcessID
		{
			set{ _n_startprocessid=value;}
			get{return _n_startprocessid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AppNo
		{
			set{ _s_appno=value;}
			get{return _s_appno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_AppDate
		{
			set{ _dt_appdate=value;}
			get{return _dt_appdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ApplicantAddresses
		{
			set{ _s_applicantaddresses=value;}
			get{return _s_applicantaddresses;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AcceptNO
		{
			set{ _s_acceptno=value;}
			get{return _s_acceptno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CProcessCodeIDs
		{
			set{ _s_cprocesscodeids=value;}
			get{return _s_cprocesscodeids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NCProcessCodeIDs
		{
			set{ _s_ncprocesscodeids=value;}
			get{return _s_ncprocesscodeids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ApplicantsCountry
		{
			set{ _s_applicantscountry=value;}
			get{return _s_applicantscountry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ApplicantsNativeName
		{
			set{ _s_applicantsnativename=value;}
			get{return _s_applicantsnativename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CustomField1
		{
			set{ _s_customfield1=value;}
			get{return _s_customfield1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CustomField2
		{
			set{ _s_customfield2=value;}
			get{return _s_customfield2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CustomField3
		{
			set{ _s_customfield3=value;}
			get{return _s_customfield3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CustomField4
		{
			set{ _s_customfield4=value;}
			get{return _s_customfield4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CustomField5
		{
			set{ _s_customfield5=value;}
			get{return _s_customfield5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CustomField6
		{
			set{ _s_customfield6=value;}
			get{return _s_customfield6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CustomField7
		{
			set{ _s_customfield7=value;}
			get{return _s_customfield7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CustomField8
		{
			set{ _s_customfield8=value;}
			get{return _s_customfield8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CustomField9
		{
			set{ _s_customfield9=value;}
			get{return _s_customfield9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CustomField10
		{
			set{ _s_customfield10=value;}
			get{return _s_customfield10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_SecurityLevelID
		{
			set{ _n_securitylevelid=value;}
			get{return _n_securitylevelid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ApplicantID
		{
			set{ _s_applicantid=value;}
			get{return _s_applicantid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsTempCase
		{
			set{ _s_istempcase=value;}
			get{return _s_istempcase;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsMiddleCase
		{
			set{ _s_ismiddlecase=value;}
			get{return _s_ismiddlecase;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_SendCheckDate
		{
			set{ _dt_sendcheckdate=value;}
			get{return _dt_sendcheckdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PreferentialCombineID
		{
			set{ _n_preferentialcombineid=value;}
			get{return _n_preferentialcombineid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ElecPayer
		{
			set{ _s_elecpayer=value;}
			get{return _s_elecpayer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ClientCName
		{
			set{ _s_clientcname=value;}
			get{return _s_clientcname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ArchiveStatus
		{
			set{ _s_archivestatus=value;}
			get{return _s_archivestatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ArchivePosition
		{
			set{ _s_archiveposition=value;}
			get{return _s_archiveposition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_BorrowTimes
		{
			set{ _n_borrowtimes=value;}
			get{return _n_borrowtimes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CreatorID
		{
			set{ _n_creatorid=value;}
			get{return _n_creatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RelatedUserIDs
		{
			set{ _s_relateduserids=value;}
			get{return _s_relateduserids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CutRateID
		{
			set{ _n_cutrateid=value;}
			get{return _n_cutrateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? fn_CutRateID
		{
			set{ _fn_cutrateid=value;}
			get{return _fn_cutrateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PriceDesc
		{
			set{ _s_pricedesc=value;}
			get{return _s_pricedesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayerBillToName
		{
			set{ _s_payerbilltoname=value;}
			get{return _s_payerbilltoname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayerStreet
		{
			set{ _s_payerstreet=value;}
			get{return _s_payerstreet;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayerCity
		{
			set{ _s_payercity=value;}
			get{return _s_payercity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayerState
		{
			set{ _s_payerstate=value;}
			get{return _s_payerstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayerZipCode
		{
			set{ _s_payerzipcode=value;}
			get{return _s_payerzipcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PayerCountry
		{
			set{ _n_payercountry=value;}
			get{return _n_payercountry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayerEmail
		{
			set{ _s_payeremail=value;}
			get{return _s_payeremail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AppsSerial
		{
			set{ _s_appsserial=value;}
			get{return _s_appsserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ManualCreateChain
		{
			set{ _s_manualcreatechain=value;}
			get{return _s_manualcreatechain;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ApplicantCodes
		{
			set{ _s_applicantcodes=value;}
			get{return _s_applicantcodes;}
		}
		#endregion Model

	}
}

