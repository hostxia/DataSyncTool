/**  版本信息模板在安装目录下，可自行修改。
* TCase_Base.cs
*
* 功 能： N/A
* 类 名： TCase_Base
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:26   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/

using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.IPSP.DAL
{
	/// <summary>
	/// 数据访问类:TCase_Base
	/// </summary>
	public partial class TCase_Base
	{
		public TCase_Base()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CoopAgencyFromID", "TCase_Base"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CoopAgencyFromID,int n_CoopAgencyToID,int n_ClientID,int n_IntroID,int ObjectType,int n_ContractID,int n_SecurityLevelID,int n_CaseID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCase_Base");
			strSql.Append(" where n_CoopAgencyFromID=@n_CoopAgencyFromID and n_CoopAgencyToID=@n_CoopAgencyToID and n_ClientID=@n_ClientID and n_IntroID=@n_IntroID and ObjectType=@ObjectType and n_ContractID=@n_ContractID and n_SecurityLevelID=@n_SecurityLevelID and n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CoopAgencyFromID", SqlDbType.Int,4),
					new SqlParameter("@n_CoopAgencyToID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_IntroID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@n_ContractID", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CoopAgencyFromID;
			parameters[1].Value = n_CoopAgencyToID;
			parameters[2].Value = n_ClientID;
			parameters[3].Value = n_IntroID;
			parameters[4].Value = ObjectType;
			parameters[5].Value = n_ContractID;
			parameters[6].Value = n_SecurityLevelID;
			parameters[7].Value = n_CaseID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCase_Base model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCase_Base(");
			strSql.Append("s_IPType,s_CaseSerial,n_FlowNum,s_CaseName,s_CaseOtherName,n_BusinessTypeID,s_FlowDirection,n_FirstAttorney,n_SecondAttorney,n_OfficeID,n_RegCountry,n_CoopAgencyFromID,n_CoopAgencyToID,s_CoopAgencyFromNo,s_CoopAgencyToNo,n_ClientID,s_ClientSerial,n_IntroID,n_IntroFee,n_IntroCurrency,s_IntroSerial,dt_UndertakeDate,dt_ShldSbmtDate,dt_SubmitDate,s_CaseStatus,s_FeeMode,n_FeeDiscount,n_FixAFee,n_FixFee,s_PayMode,s_FeeStatusOrder,s_FeeStatusInit,n_ChargeCurrency,n_OfficialCurrency,s_IsRegOnline,s_TotalSerial,s_SerialLocation,s_InConsole,dt_CreateDate,dt_EditDate,ObjectType,s_OtherName,n_EndProcess,n_IntroPer,s_SubmitStatus,dt_SubmittedDate,s_ProcessMark,n_DepartmentID,s_Applicants,s_ClientContacts,s_Dealers,s_Creator,s_Editor,s_CurrentOperator,n_ContractID,s_CaseNativeName,n_AppCountry,s_DealersID,n_ProcessID,n_StartProcessID,s_AppNo,dt_AppDate,s_ApplicantAddresses,s_AcceptNO,s_CProcessCodeIDs,s_NCProcessCodeIDs,s_ApplicantsCountry,s_ApplicantsNativeName,s_CustomField1,s_CustomField2,s_CustomField3,s_CustomField4,s_CustomField5,s_CustomField6,s_CustomField7,s_CustomField8,s_CustomField9,s_CustomField10,n_SecurityLevelID,s_ApplicantID,s_IsTempCase,s_IsMiddleCase,dt_SendCheckDate,n_PreferentialCombineID,s_ElecPayer,s_ClientCName,s_ArchiveStatus,s_ArchivePosition,n_BorrowTimes,n_CreatorID,s_RelatedUserIDs,n_CutRateID,fn_CutRateID,s_PriceDesc,s_PayerBillToName,s_PayerStreet,s_PayerCity,s_PayerState,s_PayerZipCode,n_PayerCountry,s_PayerEmail,s_AppsSerial,s_ManualCreateChain,s_ApplicantCodes)");
			strSql.Append(" values (");
			strSql.Append("@s_IPType,@s_CaseSerial,@n_FlowNum,@s_CaseName,@s_CaseOtherName,@n_BusinessTypeID,@s_FlowDirection,@n_FirstAttorney,@n_SecondAttorney,@n_OfficeID,@n_RegCountry,@n_CoopAgencyFromID,@n_CoopAgencyToID,@s_CoopAgencyFromNo,@s_CoopAgencyToNo,@n_ClientID,@s_ClientSerial,@n_IntroID,@n_IntroFee,@n_IntroCurrency,@s_IntroSerial,@dt_UndertakeDate,@dt_ShldSbmtDate,@dt_SubmitDate,@s_CaseStatus,@s_FeeMode,@n_FeeDiscount,@n_FixAFee,@n_FixFee,@s_PayMode,@s_FeeStatusOrder,@s_FeeStatusInit,@n_ChargeCurrency,@n_OfficialCurrency,@s_IsRegOnline,@s_TotalSerial,@s_SerialLocation,@s_InConsole,@dt_CreateDate,@dt_EditDate,@ObjectType,@s_OtherName,@n_EndProcess,@n_IntroPer,@s_SubmitStatus,@dt_SubmittedDate,@s_ProcessMark,@n_DepartmentID,@s_Applicants,@s_ClientContacts,@s_Dealers,@s_Creator,@s_Editor,@s_CurrentOperator,@n_ContractID,@s_CaseNativeName,@n_AppCountry,@s_DealersID,@n_ProcessID,@n_StartProcessID,@s_AppNo,@dt_AppDate,@s_ApplicantAddresses,@s_AcceptNO,@s_CProcessCodeIDs,@s_NCProcessCodeIDs,@s_ApplicantsCountry,@s_ApplicantsNativeName,@s_CustomField1,@s_CustomField2,@s_CustomField3,@s_CustomField4,@s_CustomField5,@s_CustomField6,@s_CustomField7,@s_CustomField8,@s_CustomField9,@s_CustomField10,@n_SecurityLevelID,@s_ApplicantID,@s_IsTempCase,@s_IsMiddleCase,@dt_SendCheckDate,@n_PreferentialCombineID,@s_ElecPayer,@s_ClientCName,@s_ArchiveStatus,@s_ArchivePosition,@n_BorrowTimes,@n_CreatorID,@s_RelatedUserIDs,@n_CutRateID,@fn_CutRateID,@s_PriceDesc,@s_PayerBillToName,@s_PayerStreet,@s_PayerCity,@s_PayerState,@s_PayerZipCode,@n_PayerCountry,@s_PayerEmail,@s_AppsSerial,@s_ManualCreateChain,@s_ApplicantCodes)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CaseSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@n_FlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_CaseName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_CaseOtherName", SqlDbType.NVarChar,500),
					new SqlParameter("@n_BusinessTypeID", SqlDbType.Int,4),
					new SqlParameter("@s_FlowDirection", SqlDbType.NVarChar,2),
					new SqlParameter("@n_FirstAttorney", SqlDbType.Int,4),
					new SqlParameter("@n_SecondAttorney", SqlDbType.Int,4),
					new SqlParameter("@n_OfficeID", SqlDbType.Int,4),
					new SqlParameter("@n_RegCountry", SqlDbType.Int,4),
					new SqlParameter("@n_CoopAgencyFromID", SqlDbType.Int,4),
					new SqlParameter("@n_CoopAgencyToID", SqlDbType.Int,4),
					new SqlParameter("@s_CoopAgencyFromNo", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CoopAgencyToNo", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@s_ClientSerial", SqlDbType.NVarChar,100),
					new SqlParameter("@n_IntroID", SqlDbType.Int,4),
					new SqlParameter("@n_IntroFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_IntroCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_IntroSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_UndertakeDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ShldSbmtDate", SqlDbType.DateTime),
					new SqlParameter("@dt_SubmitDate", SqlDbType.DateTime),
					new SqlParameter("@s_CaseStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FeeMode", SqlDbType.NVarChar,1),
					new SqlParameter("@n_FeeDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@n_FixAFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_FixFee", SqlDbType.Decimal,9),
					new SqlParameter("@s_PayMode", SqlDbType.NVarChar,2),
					new SqlParameter("@s_FeeStatusOrder", SqlDbType.NVarChar,10),
					new SqlParameter("@s_FeeStatusInit", SqlDbType.NVarChar,10),
					new SqlParameter("@n_ChargeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_OfficialCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_IsRegOnline", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TotalSerial", SqlDbType.NVarChar,20),
					new SqlParameter("@s_SerialLocation", SqlDbType.NVarChar,20),
					new SqlParameter("@s_InConsole", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,500),
					new SqlParameter("@n_EndProcess", SqlDbType.Int,4),
					new SqlParameter("@n_IntroPer", SqlDbType.Decimal,9),
					new SqlParameter("@s_SubmitStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_SubmittedDate", SqlDbType.DateTime),
					new SqlParameter("@s_ProcessMark", SqlDbType.NVarChar,10),
					new SqlParameter("@n_DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@s_Applicants", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_ClientContacts", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Dealers", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CurrentOperator", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ContractID", SqlDbType.Int,4),
					new SqlParameter("@s_CaseNativeName", SqlDbType.NVarChar,300),
					new SqlParameter("@n_AppCountry", SqlDbType.Int,4),
					new SqlParameter("@s_DealersID", SqlDbType.NVarChar,500),
					new SqlParameter("@n_ProcessID", SqlDbType.Int,4),
					new SqlParameter("@n_StartProcessID", SqlDbType.Int,4),
					new SqlParameter("@s_AppNo", SqlDbType.NVarChar,100),
					new SqlParameter("@dt_AppDate", SqlDbType.DateTime),
					new SqlParameter("@s_ApplicantAddresses", SqlDbType.NVarChar,500),
					new SqlParameter("@s_AcceptNO", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CProcessCodeIDs", SqlDbType.NVarChar,500),
					new SqlParameter("@s_NCProcessCodeIDs", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ApplicantsCountry", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ApplicantsNativeName", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_CustomField1", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField2", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField3", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField4", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField5", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField6", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField7", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField8", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField9", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField10", SqlDbType.NVarChar,100),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@s_ApplicantID", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IsTempCase", SqlDbType.NVarChar,2),
					new SqlParameter("@s_IsMiddleCase", SqlDbType.NVarChar,2),
					new SqlParameter("@dt_SendCheckDate", SqlDbType.DateTime),
					new SqlParameter("@n_PreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@s_ElecPayer", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ClientCName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ArchiveStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ArchivePosition", SqlDbType.NVarChar,100),
					new SqlParameter("@n_BorrowTimes", SqlDbType.Int,4),
					new SqlParameter("@n_CreatorID", SqlDbType.Int,4),
					new SqlParameter("@s_RelatedUserIDs", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_CutRateID", SqlDbType.Int,4),
					new SqlParameter("@fn_CutRateID", SqlDbType.Int,4),
					new SqlParameter("@s_PriceDesc", SqlDbType.NVarChar,-1),
					new SqlParameter("@s_PayerBillToName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_PayerStreet", SqlDbType.NVarChar,300),
					new SqlParameter("@s_PayerCity", SqlDbType.NVarChar,100),
					new SqlParameter("@s_PayerState", SqlDbType.NVarChar,100),
					new SqlParameter("@s_PayerZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@n_PayerCountry", SqlDbType.Int,4),
					new SqlParameter("@s_PayerEmail", SqlDbType.NVarChar,100),
					new SqlParameter("@s_AppsSerial", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ManualCreateChain", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ApplicantCodes", SqlDbType.NVarChar,1000)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_CaseSerial;
			parameters[2].Value = model.n_FlowNum;
			parameters[3].Value = model.s_CaseName;
			parameters[4].Value = model.s_CaseOtherName;
			parameters[5].Value = model.n_BusinessTypeID;
			parameters[6].Value = model.s_FlowDirection;
			parameters[7].Value = model.n_FirstAttorney;
			parameters[8].Value = model.n_SecondAttorney;
			parameters[9].Value = model.n_OfficeID;
			parameters[10].Value = model.n_RegCountry;
			parameters[11].Value = model.n_CoopAgencyFromID;
			parameters[12].Value = model.n_CoopAgencyToID;
			parameters[13].Value = model.s_CoopAgencyFromNo;
			parameters[14].Value = model.s_CoopAgencyToNo;
			parameters[15].Value = model.n_ClientID;
			parameters[16].Value = model.s_ClientSerial;
			parameters[17].Value = model.n_IntroID;
			parameters[18].Value = model.n_IntroFee;
			parameters[19].Value = model.n_IntroCurrency;
			parameters[20].Value = model.s_IntroSerial;
			parameters[21].Value = model.dt_UndertakeDate;
			parameters[22].Value = model.dt_ShldSbmtDate;
			parameters[23].Value = model.dt_SubmitDate;
			parameters[24].Value = model.s_CaseStatus;
			parameters[25].Value = model.s_FeeMode;
			parameters[26].Value = model.n_FeeDiscount;
			parameters[27].Value = model.n_FixAFee;
			parameters[28].Value = model.n_FixFee;
			parameters[29].Value = model.s_PayMode;
			parameters[30].Value = model.s_FeeStatusOrder;
			parameters[31].Value = model.s_FeeStatusInit;
			parameters[32].Value = model.n_ChargeCurrency;
			parameters[33].Value = model.n_OfficialCurrency;
			parameters[34].Value = model.s_IsRegOnline;
			parameters[35].Value = model.s_TotalSerial;
			parameters[36].Value = model.s_SerialLocation;
			parameters[37].Value = model.s_InConsole;
			parameters[38].Value = model.dt_CreateDate;
			parameters[39].Value = model.dt_EditDate;
			parameters[40].Value = model.ObjectType;
			parameters[41].Value = model.s_OtherName;
			parameters[42].Value = model.n_EndProcess;
			parameters[43].Value = model.n_IntroPer;
			parameters[44].Value = model.s_SubmitStatus;
			parameters[45].Value = model.dt_SubmittedDate;
			parameters[46].Value = model.s_ProcessMark;
			parameters[47].Value = model.n_DepartmentID;
			parameters[48].Value = model.s_Applicants;
			parameters[49].Value = model.s_ClientContacts;
			parameters[50].Value = model.s_Dealers;
			parameters[51].Value = model.s_Creator;
			parameters[52].Value = model.s_Editor;
			parameters[53].Value = model.s_CurrentOperator;
			parameters[54].Value = model.n_ContractID;
			parameters[55].Value = model.s_CaseNativeName;
			parameters[56].Value = model.n_AppCountry;
			parameters[57].Value = model.s_DealersID;
			parameters[58].Value = model.n_ProcessID;
			parameters[59].Value = model.n_StartProcessID;
			parameters[60].Value = model.s_AppNo;
			parameters[61].Value = model.dt_AppDate;
			parameters[62].Value = model.s_ApplicantAddresses;
			parameters[63].Value = model.s_AcceptNO;
			parameters[64].Value = model.s_CProcessCodeIDs;
			parameters[65].Value = model.s_NCProcessCodeIDs;
			parameters[66].Value = model.s_ApplicantsCountry;
			parameters[67].Value = model.s_ApplicantsNativeName;
			parameters[68].Value = model.s_CustomField1;
			parameters[69].Value = model.s_CustomField2;
			parameters[70].Value = model.s_CustomField3;
			parameters[71].Value = model.s_CustomField4;
			parameters[72].Value = model.s_CustomField5;
			parameters[73].Value = model.s_CustomField6;
			parameters[74].Value = model.s_CustomField7;
			parameters[75].Value = model.s_CustomField8;
			parameters[76].Value = model.s_CustomField9;
			parameters[77].Value = model.s_CustomField10;
			parameters[78].Value = model.n_SecurityLevelID;
			parameters[79].Value = model.s_ApplicantID;
			parameters[80].Value = model.s_IsTempCase;
			parameters[81].Value = model.s_IsMiddleCase;
			parameters[82].Value = model.dt_SendCheckDate;
			parameters[83].Value = model.n_PreferentialCombineID;
			parameters[84].Value = model.s_ElecPayer;
			parameters[85].Value = model.s_ClientCName;
			parameters[86].Value = model.s_ArchiveStatus;
			parameters[87].Value = model.s_ArchivePosition;
			parameters[88].Value = model.n_BorrowTimes;
			parameters[89].Value = model.n_CreatorID;
			parameters[90].Value = model.s_RelatedUserIDs;
			parameters[91].Value = model.n_CutRateID;
			parameters[92].Value = model.fn_CutRateID;
			parameters[93].Value = model.s_PriceDesc;
			parameters[94].Value = model.s_PayerBillToName;
			parameters[95].Value = model.s_PayerStreet;
			parameters[96].Value = model.s_PayerCity;
			parameters[97].Value = model.s_PayerState;
			parameters[98].Value = model.s_PayerZipCode;
			parameters[99].Value = model.n_PayerCountry;
			parameters[100].Value = model.s_PayerEmail;
			parameters[101].Value = model.s_AppsSerial;
			parameters[102].Value = model.s_ManualCreateChain;
			parameters[103].Value = model.s_ApplicantCodes;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(IPSP.Model.TCase_Base model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCase_Base set ");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_CaseSerial=@s_CaseSerial,");
			strSql.Append("n_FlowNum=@n_FlowNum,");
			strSql.Append("s_CaseName=@s_CaseName,");
			strSql.Append("s_CaseOtherName=@s_CaseOtherName,");
			strSql.Append("n_BusinessTypeID=@n_BusinessTypeID,");
			strSql.Append("s_FlowDirection=@s_FlowDirection,");
			strSql.Append("n_FirstAttorney=@n_FirstAttorney,");
			strSql.Append("n_SecondAttorney=@n_SecondAttorney,");
			strSql.Append("n_OfficeID=@n_OfficeID,");
			strSql.Append("n_RegCountry=@n_RegCountry,");
			strSql.Append("s_CoopAgencyFromNo=@s_CoopAgencyFromNo,");
			strSql.Append("s_CoopAgencyToNo=@s_CoopAgencyToNo,");
			strSql.Append("s_ClientSerial=@s_ClientSerial,");
			strSql.Append("n_IntroFee=@n_IntroFee,");
			strSql.Append("n_IntroCurrency=@n_IntroCurrency,");
			strSql.Append("s_IntroSerial=@s_IntroSerial,");
			strSql.Append("dt_UndertakeDate=@dt_UndertakeDate,");
			strSql.Append("dt_ShldSbmtDate=@dt_ShldSbmtDate,");
			strSql.Append("dt_SubmitDate=@dt_SubmitDate,");
			strSql.Append("s_CaseStatus=@s_CaseStatus,");
			strSql.Append("s_FeeMode=@s_FeeMode,");
			strSql.Append("n_FeeDiscount=@n_FeeDiscount,");
			strSql.Append("n_FixAFee=@n_FixAFee,");
			strSql.Append("n_FixFee=@n_FixFee,");
			strSql.Append("s_PayMode=@s_PayMode,");
			strSql.Append("s_FeeStatusOrder=@s_FeeStatusOrder,");
			strSql.Append("s_FeeStatusInit=@s_FeeStatusInit,");
			strSql.Append("n_ChargeCurrency=@n_ChargeCurrency,");
			strSql.Append("n_OfficialCurrency=@n_OfficialCurrency,");
			strSql.Append("s_IsRegOnline=@s_IsRegOnline,");
			strSql.Append("s_TotalSerial=@s_TotalSerial,");
			strSql.Append("s_SerialLocation=@s_SerialLocation,");
			strSql.Append("s_InConsole=@s_InConsole,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("n_EndProcess=@n_EndProcess,");
			strSql.Append("n_IntroPer=@n_IntroPer,");
			strSql.Append("s_SubmitStatus=@s_SubmitStatus,");
			strSql.Append("dt_SubmittedDate=@dt_SubmittedDate,");
			strSql.Append("s_ProcessMark=@s_ProcessMark,");
			strSql.Append("n_DepartmentID=@n_DepartmentID,");
			strSql.Append("s_Applicants=@s_Applicants,");
			strSql.Append("s_ClientContacts=@s_ClientContacts,");
			strSql.Append("s_Dealers=@s_Dealers,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("s_CurrentOperator=@s_CurrentOperator,");
			strSql.Append("s_CaseNativeName=@s_CaseNativeName,");
			strSql.Append("n_AppCountry=@n_AppCountry,");
			strSql.Append("s_DealersID=@s_DealersID,");
			strSql.Append("n_ProcessID=@n_ProcessID,");
			strSql.Append("n_StartProcessID=@n_StartProcessID,");
			strSql.Append("s_AppNo=@s_AppNo,");
			strSql.Append("dt_AppDate=@dt_AppDate,");
			strSql.Append("s_ApplicantAddresses=@s_ApplicantAddresses,");
			strSql.Append("s_AcceptNO=@s_AcceptNO,");
			strSql.Append("s_CProcessCodeIDs=@s_CProcessCodeIDs,");
			strSql.Append("s_NCProcessCodeIDs=@s_NCProcessCodeIDs,");
			strSql.Append("s_ApplicantsCountry=@s_ApplicantsCountry,");
			strSql.Append("s_ApplicantsNativeName=@s_ApplicantsNativeName,");
			strSql.Append("s_CustomField1=@s_CustomField1,");
			strSql.Append("s_CustomField2=@s_CustomField2,");
			strSql.Append("s_CustomField3=@s_CustomField3,");
			strSql.Append("s_CustomField4=@s_CustomField4,");
			strSql.Append("s_CustomField5=@s_CustomField5,");
			strSql.Append("s_CustomField6=@s_CustomField6,");
			strSql.Append("s_CustomField7=@s_CustomField7,");
			strSql.Append("s_CustomField8=@s_CustomField8,");
			strSql.Append("s_CustomField9=@s_CustomField9,");
			strSql.Append("s_CustomField10=@s_CustomField10,");
			strSql.Append("s_ApplicantID=@s_ApplicantID,");
			strSql.Append("s_IsTempCase=@s_IsTempCase,");
			strSql.Append("s_IsMiddleCase=@s_IsMiddleCase,");
			strSql.Append("dt_SendCheckDate=@dt_SendCheckDate,");
			strSql.Append("n_PreferentialCombineID=@n_PreferentialCombineID,");
			strSql.Append("s_ElecPayer=@s_ElecPayer,");
			strSql.Append("s_ClientCName=@s_ClientCName,");
			strSql.Append("s_ArchiveStatus=@s_ArchiveStatus,");
			strSql.Append("s_ArchivePosition=@s_ArchivePosition,");
			strSql.Append("n_BorrowTimes=@n_BorrowTimes,");
			strSql.Append("n_CreatorID=@n_CreatorID,");
			strSql.Append("s_RelatedUserIDs=@s_RelatedUserIDs,");
			strSql.Append("n_CutRateID=@n_CutRateID,");
			strSql.Append("fn_CutRateID=@fn_CutRateID,");
			strSql.Append("s_PriceDesc=@s_PriceDesc,");
			strSql.Append("s_PayerBillToName=@s_PayerBillToName,");
			strSql.Append("s_PayerStreet=@s_PayerStreet,");
			strSql.Append("s_PayerCity=@s_PayerCity,");
			strSql.Append("s_PayerState=@s_PayerState,");
			strSql.Append("s_PayerZipCode=@s_PayerZipCode,");
			strSql.Append("n_PayerCountry=@n_PayerCountry,");
			strSql.Append("s_PayerEmail=@s_PayerEmail,");
			strSql.Append("s_AppsSerial=@s_AppsSerial,");
			strSql.Append("s_ManualCreateChain=@s_ManualCreateChain,");
			strSql.Append("s_ApplicantCodes=@s_ApplicantCodes");
			strSql.Append(" where n_CaseID=@n_CaseID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CaseSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@n_FlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_CaseName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_CaseOtherName", SqlDbType.NVarChar,500),
					new SqlParameter("@n_BusinessTypeID", SqlDbType.Int,4),
					new SqlParameter("@s_FlowDirection", SqlDbType.NVarChar,2),
					new SqlParameter("@n_FirstAttorney", SqlDbType.Int,4),
					new SqlParameter("@n_SecondAttorney", SqlDbType.Int,4),
					new SqlParameter("@n_OfficeID", SqlDbType.Int,4),
					new SqlParameter("@n_RegCountry", SqlDbType.Int,4),
					new SqlParameter("@s_CoopAgencyFromNo", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CoopAgencyToNo", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ClientSerial", SqlDbType.NVarChar,100),
					new SqlParameter("@n_IntroFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_IntroCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_IntroSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_UndertakeDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ShldSbmtDate", SqlDbType.DateTime),
					new SqlParameter("@dt_SubmitDate", SqlDbType.DateTime),
					new SqlParameter("@s_CaseStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FeeMode", SqlDbType.NVarChar,1),
					new SqlParameter("@n_FeeDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@n_FixAFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_FixFee", SqlDbType.Decimal,9),
					new SqlParameter("@s_PayMode", SqlDbType.NVarChar,2),
					new SqlParameter("@s_FeeStatusOrder", SqlDbType.NVarChar,10),
					new SqlParameter("@s_FeeStatusInit", SqlDbType.NVarChar,10),
					new SqlParameter("@n_ChargeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_OfficialCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_IsRegOnline", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TotalSerial", SqlDbType.NVarChar,20),
					new SqlParameter("@s_SerialLocation", SqlDbType.NVarChar,20),
					new SqlParameter("@s_InConsole", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,500),
					new SqlParameter("@n_EndProcess", SqlDbType.Int,4),
					new SqlParameter("@n_IntroPer", SqlDbType.Decimal,9),
					new SqlParameter("@s_SubmitStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_SubmittedDate", SqlDbType.DateTime),
					new SqlParameter("@s_ProcessMark", SqlDbType.NVarChar,10),
					new SqlParameter("@n_DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@s_Applicants", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_ClientContacts", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Dealers", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CurrentOperator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CaseNativeName", SqlDbType.NVarChar,300),
					new SqlParameter("@n_AppCountry", SqlDbType.Int,4),
					new SqlParameter("@s_DealersID", SqlDbType.NVarChar,500),
					new SqlParameter("@n_ProcessID", SqlDbType.Int,4),
					new SqlParameter("@n_StartProcessID", SqlDbType.Int,4),
					new SqlParameter("@s_AppNo", SqlDbType.NVarChar,100),
					new SqlParameter("@dt_AppDate", SqlDbType.DateTime),
					new SqlParameter("@s_ApplicantAddresses", SqlDbType.NVarChar,500),
					new SqlParameter("@s_AcceptNO", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CProcessCodeIDs", SqlDbType.NVarChar,500),
					new SqlParameter("@s_NCProcessCodeIDs", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ApplicantsCountry", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ApplicantsNativeName", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_CustomField1", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField2", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField3", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField4", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField5", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField6", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField7", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField8", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField9", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CustomField10", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ApplicantID", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IsTempCase", SqlDbType.NVarChar,2),
					new SqlParameter("@s_IsMiddleCase", SqlDbType.NVarChar,2),
					new SqlParameter("@dt_SendCheckDate", SqlDbType.DateTime),
					new SqlParameter("@n_PreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@s_ElecPayer", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ClientCName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ArchiveStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ArchivePosition", SqlDbType.NVarChar,100),
					new SqlParameter("@n_BorrowTimes", SqlDbType.Int,4),
					new SqlParameter("@n_CreatorID", SqlDbType.Int,4),
					new SqlParameter("@s_RelatedUserIDs", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_CutRateID", SqlDbType.Int,4),
					new SqlParameter("@fn_CutRateID", SqlDbType.Int,4),
					new SqlParameter("@s_PriceDesc", SqlDbType.NVarChar,-1),
					new SqlParameter("@s_PayerBillToName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_PayerStreet", SqlDbType.NVarChar,300),
					new SqlParameter("@s_PayerCity", SqlDbType.NVarChar,100),
					new SqlParameter("@s_PayerState", SqlDbType.NVarChar,100),
					new SqlParameter("@s_PayerZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@n_PayerCountry", SqlDbType.Int,4),
					new SqlParameter("@s_PayerEmail", SqlDbType.NVarChar,100),
					new SqlParameter("@s_AppsSerial", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ManualCreateChain", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ApplicantCodes", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_CoopAgencyFromID", SqlDbType.Int,4),
					new SqlParameter("@n_CoopAgencyToID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_IntroID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@n_ContractID", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_CaseSerial;
			parameters[2].Value = model.n_FlowNum;
			parameters[3].Value = model.s_CaseName;
			parameters[4].Value = model.s_CaseOtherName;
			parameters[5].Value = model.n_BusinessTypeID;
			parameters[6].Value = model.s_FlowDirection;
			parameters[7].Value = model.n_FirstAttorney;
			parameters[8].Value = model.n_SecondAttorney;
			parameters[9].Value = model.n_OfficeID;
			parameters[10].Value = model.n_RegCountry;
			parameters[11].Value = model.s_CoopAgencyFromNo;
			parameters[12].Value = model.s_CoopAgencyToNo;
			parameters[13].Value = model.s_ClientSerial;
			parameters[14].Value = model.n_IntroFee;
			parameters[15].Value = model.n_IntroCurrency;
			parameters[16].Value = model.s_IntroSerial;
			parameters[17].Value = model.dt_UndertakeDate;
			parameters[18].Value = model.dt_ShldSbmtDate;
			parameters[19].Value = model.dt_SubmitDate;
			parameters[20].Value = model.s_CaseStatus;
			parameters[21].Value = model.s_FeeMode;
			parameters[22].Value = model.n_FeeDiscount;
			parameters[23].Value = model.n_FixAFee;
			parameters[24].Value = model.n_FixFee;
			parameters[25].Value = model.s_PayMode;
			parameters[26].Value = model.s_FeeStatusOrder;
			parameters[27].Value = model.s_FeeStatusInit;
			parameters[28].Value = model.n_ChargeCurrency;
			parameters[29].Value = model.n_OfficialCurrency;
			parameters[30].Value = model.s_IsRegOnline;
			parameters[31].Value = model.s_TotalSerial;
			parameters[32].Value = model.s_SerialLocation;
			parameters[33].Value = model.s_InConsole;
			parameters[34].Value = model.dt_CreateDate;
			parameters[35].Value = model.dt_EditDate;
			parameters[36].Value = model.s_OtherName;
			parameters[37].Value = model.n_EndProcess;
			parameters[38].Value = model.n_IntroPer;
			parameters[39].Value = model.s_SubmitStatus;
			parameters[40].Value = model.dt_SubmittedDate;
			parameters[41].Value = model.s_ProcessMark;
			parameters[42].Value = model.n_DepartmentID;
			parameters[43].Value = model.s_Applicants;
			parameters[44].Value = model.s_ClientContacts;
			parameters[45].Value = model.s_Dealers;
			parameters[46].Value = model.s_Creator;
			parameters[47].Value = model.s_Editor;
			parameters[48].Value = model.s_CurrentOperator;
			parameters[49].Value = model.s_CaseNativeName;
			parameters[50].Value = model.n_AppCountry;
			parameters[51].Value = model.s_DealersID;
			parameters[52].Value = model.n_ProcessID;
			parameters[53].Value = model.n_StartProcessID;
			parameters[54].Value = model.s_AppNo;
			parameters[55].Value = model.dt_AppDate;
			parameters[56].Value = model.s_ApplicantAddresses;
			parameters[57].Value = model.s_AcceptNO;
			parameters[58].Value = model.s_CProcessCodeIDs;
			parameters[59].Value = model.s_NCProcessCodeIDs;
			parameters[60].Value = model.s_ApplicantsCountry;
			parameters[61].Value = model.s_ApplicantsNativeName;
			parameters[62].Value = model.s_CustomField1;
			parameters[63].Value = model.s_CustomField2;
			parameters[64].Value = model.s_CustomField3;
			parameters[65].Value = model.s_CustomField4;
			parameters[66].Value = model.s_CustomField5;
			parameters[67].Value = model.s_CustomField6;
			parameters[68].Value = model.s_CustomField7;
			parameters[69].Value = model.s_CustomField8;
			parameters[70].Value = model.s_CustomField9;
			parameters[71].Value = model.s_CustomField10;
			parameters[72].Value = model.s_ApplicantID;
			parameters[73].Value = model.s_IsTempCase;
			parameters[74].Value = model.s_IsMiddleCase;
			parameters[75].Value = model.dt_SendCheckDate;
			parameters[76].Value = model.n_PreferentialCombineID;
			parameters[77].Value = model.s_ElecPayer;
			parameters[78].Value = model.s_ClientCName;
			parameters[79].Value = model.s_ArchiveStatus;
			parameters[80].Value = model.s_ArchivePosition;
			parameters[81].Value = model.n_BorrowTimes;
			parameters[82].Value = model.n_CreatorID;
			parameters[83].Value = model.s_RelatedUserIDs;
			parameters[84].Value = model.n_CutRateID;
			parameters[85].Value = model.fn_CutRateID;
			parameters[86].Value = model.s_PriceDesc;
			parameters[87].Value = model.s_PayerBillToName;
			parameters[88].Value = model.s_PayerStreet;
			parameters[89].Value = model.s_PayerCity;
			parameters[90].Value = model.s_PayerState;
			parameters[91].Value = model.s_PayerZipCode;
			parameters[92].Value = model.n_PayerCountry;
			parameters[93].Value = model.s_PayerEmail;
			parameters[94].Value = model.s_AppsSerial;
			parameters[95].Value = model.s_ManualCreateChain;
			parameters[96].Value = model.s_ApplicantCodes;
			parameters[97].Value = model.n_CaseID;
			parameters[98].Value = model.n_CoopAgencyFromID;
			parameters[99].Value = model.n_CoopAgencyToID;
			parameters[100].Value = model.n_ClientID;
			parameters[101].Value = model.n_IntroID;
			parameters[102].Value = model.ObjectType;
			parameters[103].Value = model.n_ContractID;
			parameters[104].Value = model.n_SecurityLevelID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int n_CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCase_Base ");
			strSql.Append(" where n_CaseID=@n_CaseID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_CaseID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int n_CoopAgencyFromID,int n_CoopAgencyToID,int n_ClientID,int n_IntroID,int ObjectType,int n_ContractID,int n_SecurityLevelID,int n_CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCase_Base ");
			strSql.Append(" where n_CoopAgencyFromID=@n_CoopAgencyFromID and n_CoopAgencyToID=@n_CoopAgencyToID and n_ClientID=@n_ClientID and n_IntroID=@n_IntroID and ObjectType=@ObjectType and n_ContractID=@n_ContractID and n_SecurityLevelID=@n_SecurityLevelID and n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CoopAgencyFromID", SqlDbType.Int,4),
					new SqlParameter("@n_CoopAgencyToID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_IntroID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@n_ContractID", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CoopAgencyFromID;
			parameters[1].Value = n_CoopAgencyToID;
			parameters[2].Value = n_ClientID;
			parameters[3].Value = n_IntroID;
			parameters[4].Value = ObjectType;
			parameters[5].Value = n_ContractID;
			parameters[6].Value = n_SecurityLevelID;
			parameters[7].Value = n_CaseID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string n_CaseIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCase_Base ");
			strSql.Append(" where n_CaseID in ("+n_CaseIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public IPSP.Model.TCase_Base GetModel(int n_CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_CaseID,s_IPType,s_CaseSerial,n_FlowNum,s_CaseName,s_CaseOtherName,n_BusinessTypeID,s_FlowDirection,n_FirstAttorney,n_SecondAttorney,n_OfficeID,n_RegCountry,n_CoopAgencyFromID,n_CoopAgencyToID,s_CoopAgencyFromNo,s_CoopAgencyToNo,n_ClientID,s_ClientSerial,n_IntroID,n_IntroFee,n_IntroCurrency,s_IntroSerial,dt_UndertakeDate,dt_ShldSbmtDate,dt_SubmitDate,s_CaseStatus,s_FeeMode,n_FeeDiscount,n_FixAFee,n_FixFee,s_PayMode,s_FeeStatusOrder,s_FeeStatusInit,n_ChargeCurrency,n_OfficialCurrency,s_IsRegOnline,s_TotalSerial,s_SerialLocation,s_InConsole,dt_CreateDate,dt_EditDate,ObjectType,s_OtherName,n_EndProcess,n_IntroPer,s_SubmitStatus,dt_SubmittedDate,s_ProcessMark,n_DepartmentID,s_Applicants,s_ClientContacts,s_Dealers,s_Creator,s_Editor,s_CurrentOperator,n_ContractID,s_CaseNativeName,n_AppCountry,s_DealersID,n_ProcessID,n_StartProcessID,s_AppNo,dt_AppDate,s_ApplicantAddresses,s_AcceptNO,s_CProcessCodeIDs,s_NCProcessCodeIDs,s_ApplicantsCountry,s_ApplicantsNativeName,s_CustomField1,s_CustomField2,s_CustomField3,s_CustomField4,s_CustomField5,s_CustomField6,s_CustomField7,s_CustomField8,s_CustomField9,s_CustomField10,n_SecurityLevelID,s_ApplicantID,s_IsTempCase,s_IsMiddleCase,dt_SendCheckDate,n_PreferentialCombineID,s_ElecPayer,s_ClientCName,s_ArchiveStatus,s_ArchivePosition,n_BorrowTimes,n_CreatorID,s_RelatedUserIDs,n_CutRateID,fn_CutRateID,s_PriceDesc,s_PayerBillToName,s_PayerStreet,s_PayerCity,s_PayerState,s_PayerZipCode,n_PayerCountry,s_PayerEmail,s_AppsSerial,s_ManualCreateChain,s_ApplicantCodes from TCase_Base ");
			strSql.Append(" where n_CaseID=@n_CaseID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_CaseID;

			IPSP.Model.TCase_Base model=new IPSP.Model.TCase_Base();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public IPSP.Model.TCase_Base DataRowToModel(DataRow row)
		{
			IPSP.Model.TCase_Base model=new IPSP.Model.TCase_Base();
			if (row != null)
			{
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["s_CaseSerial"]!=null)
				{
					model.s_CaseSerial=row["s_CaseSerial"].ToString();
				}
				if(row["n_FlowNum"]!=null && row["n_FlowNum"].ToString()!="")
				{
					model.n_FlowNum=int.Parse(row["n_FlowNum"].ToString());
				}
				if(row["s_CaseName"]!=null)
				{
					model.s_CaseName=row["s_CaseName"].ToString();
				}
				if(row["s_CaseOtherName"]!=null)
				{
					model.s_CaseOtherName=row["s_CaseOtherName"].ToString();
				}
				if(row["n_BusinessTypeID"]!=null && row["n_BusinessTypeID"].ToString()!="")
				{
					model.n_BusinessTypeID=int.Parse(row["n_BusinessTypeID"].ToString());
				}
				if(row["s_FlowDirection"]!=null)
				{
					model.s_FlowDirection=row["s_FlowDirection"].ToString();
				}
				if(row["n_FirstAttorney"]!=null && row["n_FirstAttorney"].ToString()!="")
				{
					model.n_FirstAttorney=int.Parse(row["n_FirstAttorney"].ToString());
				}
				if(row["n_SecondAttorney"]!=null && row["n_SecondAttorney"].ToString()!="")
				{
					model.n_SecondAttorney=int.Parse(row["n_SecondAttorney"].ToString());
				}
				if(row["n_OfficeID"]!=null && row["n_OfficeID"].ToString()!="")
				{
					model.n_OfficeID=int.Parse(row["n_OfficeID"].ToString());
				}
				if(row["n_RegCountry"]!=null && row["n_RegCountry"].ToString()!="")
				{
					model.n_RegCountry=int.Parse(row["n_RegCountry"].ToString());
				}
				if(row["n_CoopAgencyFromID"]!=null && row["n_CoopAgencyFromID"].ToString()!="")
				{
					model.n_CoopAgencyFromID=int.Parse(row["n_CoopAgencyFromID"].ToString());
				}
				if(row["n_CoopAgencyToID"]!=null && row["n_CoopAgencyToID"].ToString()!="")
				{
					model.n_CoopAgencyToID=int.Parse(row["n_CoopAgencyToID"].ToString());
				}
				if(row["s_CoopAgencyFromNo"]!=null)
				{
					model.s_CoopAgencyFromNo=row["s_CoopAgencyFromNo"].ToString();
				}
				if(row["s_CoopAgencyToNo"]!=null)
				{
					model.s_CoopAgencyToNo=row["s_CoopAgencyToNo"].ToString();
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["s_ClientSerial"]!=null)
				{
					model.s_ClientSerial=row["s_ClientSerial"].ToString();
				}
				if(row["n_IntroID"]!=null && row["n_IntroID"].ToString()!="")
				{
					model.n_IntroID=int.Parse(row["n_IntroID"].ToString());
				}
				if(row["n_IntroFee"]!=null && row["n_IntroFee"].ToString()!="")
				{
					model.n_IntroFee=decimal.Parse(row["n_IntroFee"].ToString());
				}
				if(row["n_IntroCurrency"]!=null && row["n_IntroCurrency"].ToString()!="")
				{
					model.n_IntroCurrency=int.Parse(row["n_IntroCurrency"].ToString());
				}
				if(row["s_IntroSerial"]!=null)
				{
					model.s_IntroSerial=row["s_IntroSerial"].ToString();
				}
				if(row["dt_UndertakeDate"]!=null && row["dt_UndertakeDate"].ToString()!="")
				{
					model.dt_UndertakeDate=DateTime.Parse(row["dt_UndertakeDate"].ToString());
				}
				if(row["dt_ShldSbmtDate"]!=null && row["dt_ShldSbmtDate"].ToString()!="")
				{
					model.dt_ShldSbmtDate=DateTime.Parse(row["dt_ShldSbmtDate"].ToString());
				}
				if(row["dt_SubmitDate"]!=null && row["dt_SubmitDate"].ToString()!="")
				{
					model.dt_SubmitDate=DateTime.Parse(row["dt_SubmitDate"].ToString());
				}
				if(row["s_CaseStatus"]!=null)
				{
					model.s_CaseStatus=row["s_CaseStatus"].ToString();
				}
				if(row["s_FeeMode"]!=null)
				{
					model.s_FeeMode=row["s_FeeMode"].ToString();
				}
				if(row["n_FeeDiscount"]!=null && row["n_FeeDiscount"].ToString()!="")
				{
					model.n_FeeDiscount=decimal.Parse(row["n_FeeDiscount"].ToString());
				}
				if(row["n_FixAFee"]!=null && row["n_FixAFee"].ToString()!="")
				{
					model.n_FixAFee=decimal.Parse(row["n_FixAFee"].ToString());
				}
				if(row["n_FixFee"]!=null && row["n_FixFee"].ToString()!="")
				{
					model.n_FixFee=decimal.Parse(row["n_FixFee"].ToString());
				}
				if(row["s_PayMode"]!=null)
				{
					model.s_PayMode=row["s_PayMode"].ToString();
				}
				if(row["s_FeeStatusOrder"]!=null)
				{
					model.s_FeeStatusOrder=row["s_FeeStatusOrder"].ToString();
				}
				if(row["s_FeeStatusInit"]!=null)
				{
					model.s_FeeStatusInit=row["s_FeeStatusInit"].ToString();
				}
				if(row["n_ChargeCurrency"]!=null && row["n_ChargeCurrency"].ToString()!="")
				{
					model.n_ChargeCurrency=int.Parse(row["n_ChargeCurrency"].ToString());
				}
				if(row["n_OfficialCurrency"]!=null && row["n_OfficialCurrency"].ToString()!="")
				{
					model.n_OfficialCurrency=int.Parse(row["n_OfficialCurrency"].ToString());
				}
				if(row["s_IsRegOnline"]!=null)
				{
					model.s_IsRegOnline=row["s_IsRegOnline"].ToString();
				}
				if(row["s_TotalSerial"]!=null)
				{
					model.s_TotalSerial=row["s_TotalSerial"].ToString();
				}
				if(row["s_SerialLocation"]!=null)
				{
					model.s_SerialLocation=row["s_SerialLocation"].ToString();
				}
				if(row["s_InConsole"]!=null)
				{
					model.s_InConsole=row["s_InConsole"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["ObjectType"]!=null && row["ObjectType"].ToString()!="")
				{
					model.ObjectType=int.Parse(row["ObjectType"].ToString());
				}
				if(row["s_OtherName"]!=null)
				{
					model.s_OtherName=row["s_OtherName"].ToString();
				}
				if(row["n_EndProcess"]!=null && row["n_EndProcess"].ToString()!="")
				{
					model.n_EndProcess=int.Parse(row["n_EndProcess"].ToString());
				}
				if(row["n_IntroPer"]!=null && row["n_IntroPer"].ToString()!="")
				{
					model.n_IntroPer=decimal.Parse(row["n_IntroPer"].ToString());
				}
				if(row["s_SubmitStatus"]!=null)
				{
					model.s_SubmitStatus=row["s_SubmitStatus"].ToString();
				}
				if(row["dt_SubmittedDate"]!=null && row["dt_SubmittedDate"].ToString()!="")
				{
					model.dt_SubmittedDate=DateTime.Parse(row["dt_SubmittedDate"].ToString());
				}
				if(row["s_ProcessMark"]!=null)
				{
					model.s_ProcessMark=row["s_ProcessMark"].ToString();
				}
				if(row["n_DepartmentID"]!=null && row["n_DepartmentID"].ToString()!="")
				{
					model.n_DepartmentID=int.Parse(row["n_DepartmentID"].ToString());
				}
				if(row["s_Applicants"]!=null)
				{
					model.s_Applicants=row["s_Applicants"].ToString();
				}
				if(row["s_ClientContacts"]!=null)
				{
					model.s_ClientContacts=row["s_ClientContacts"].ToString();
				}
				if(row["s_Dealers"]!=null)
				{
					model.s_Dealers=row["s_Dealers"].ToString();
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["s_CurrentOperator"]!=null)
				{
					model.s_CurrentOperator=row["s_CurrentOperator"].ToString();
				}
				if(row["n_ContractID"]!=null && row["n_ContractID"].ToString()!="")
				{
					model.n_ContractID=int.Parse(row["n_ContractID"].ToString());
				}
				if(row["s_CaseNativeName"]!=null)
				{
					model.s_CaseNativeName=row["s_CaseNativeName"].ToString();
				}
				if(row["n_AppCountry"]!=null && row["n_AppCountry"].ToString()!="")
				{
					model.n_AppCountry=int.Parse(row["n_AppCountry"].ToString());
				}
				if(row["s_DealersID"]!=null)
				{
					model.s_DealersID=row["s_DealersID"].ToString();
				}
				if(row["n_ProcessID"]!=null && row["n_ProcessID"].ToString()!="")
				{
					model.n_ProcessID=int.Parse(row["n_ProcessID"].ToString());
				}
				if(row["n_StartProcessID"]!=null && row["n_StartProcessID"].ToString()!="")
				{
					model.n_StartProcessID=int.Parse(row["n_StartProcessID"].ToString());
				}
				if(row["s_AppNo"]!=null)
				{
					model.s_AppNo=row["s_AppNo"].ToString();
				}
				if(row["dt_AppDate"]!=null && row["dt_AppDate"].ToString()!="")
				{
					model.dt_AppDate=DateTime.Parse(row["dt_AppDate"].ToString());
				}
				if(row["s_ApplicantAddresses"]!=null)
				{
					model.s_ApplicantAddresses=row["s_ApplicantAddresses"].ToString();
				}
				if(row["s_AcceptNO"]!=null)
				{
					model.s_AcceptNO=row["s_AcceptNO"].ToString();
				}
				if(row["s_CProcessCodeIDs"]!=null)
				{
					model.s_CProcessCodeIDs=row["s_CProcessCodeIDs"].ToString();
				}
				if(row["s_NCProcessCodeIDs"]!=null)
				{
					model.s_NCProcessCodeIDs=row["s_NCProcessCodeIDs"].ToString();
				}
				if(row["s_ApplicantsCountry"]!=null)
				{
					model.s_ApplicantsCountry=row["s_ApplicantsCountry"].ToString();
				}
				if(row["s_ApplicantsNativeName"]!=null)
				{
					model.s_ApplicantsNativeName=row["s_ApplicantsNativeName"].ToString();
				}
				if(row["s_CustomField1"]!=null)
				{
					model.s_CustomField1=row["s_CustomField1"].ToString();
				}
				if(row["s_CustomField2"]!=null)
				{
					model.s_CustomField2=row["s_CustomField2"].ToString();
				}
				if(row["s_CustomField3"]!=null)
				{
					model.s_CustomField3=row["s_CustomField3"].ToString();
				}
				if(row["s_CustomField4"]!=null)
				{
					model.s_CustomField4=row["s_CustomField4"].ToString();
				}
				if(row["s_CustomField5"]!=null)
				{
					model.s_CustomField5=row["s_CustomField5"].ToString();
				}
				if(row["s_CustomField6"]!=null)
				{
					model.s_CustomField6=row["s_CustomField6"].ToString();
				}
				if(row["s_CustomField7"]!=null)
				{
					model.s_CustomField7=row["s_CustomField7"].ToString();
				}
				if(row["s_CustomField8"]!=null)
				{
					model.s_CustomField8=row["s_CustomField8"].ToString();
				}
				if(row["s_CustomField9"]!=null)
				{
					model.s_CustomField9=row["s_CustomField9"].ToString();
				}
				if(row["s_CustomField10"]!=null)
				{
					model.s_CustomField10=row["s_CustomField10"].ToString();
				}
				if(row["n_SecurityLevelID"]!=null && row["n_SecurityLevelID"].ToString()!="")
				{
					model.n_SecurityLevelID=int.Parse(row["n_SecurityLevelID"].ToString());
				}
				if(row["s_ApplicantID"]!=null)
				{
					model.s_ApplicantID=row["s_ApplicantID"].ToString();
				}
				if(row["s_IsTempCase"]!=null)
				{
					model.s_IsTempCase=row["s_IsTempCase"].ToString();
				}
				if(row["s_IsMiddleCase"]!=null)
				{
					model.s_IsMiddleCase=row["s_IsMiddleCase"].ToString();
				}
				if(row["dt_SendCheckDate"]!=null && row["dt_SendCheckDate"].ToString()!="")
				{
					model.dt_SendCheckDate=DateTime.Parse(row["dt_SendCheckDate"].ToString());
				}
				if(row["n_PreferentialCombineID"]!=null && row["n_PreferentialCombineID"].ToString()!="")
				{
					model.n_PreferentialCombineID=int.Parse(row["n_PreferentialCombineID"].ToString());
				}
				if(row["s_ElecPayer"]!=null)
				{
					model.s_ElecPayer=row["s_ElecPayer"].ToString();
				}
				if(row["s_ClientCName"]!=null)
				{
					model.s_ClientCName=row["s_ClientCName"].ToString();
				}
				if(row["s_ArchiveStatus"]!=null)
				{
					model.s_ArchiveStatus=row["s_ArchiveStatus"].ToString();
				}
				if(row["s_ArchivePosition"]!=null)
				{
					model.s_ArchivePosition=row["s_ArchivePosition"].ToString();
				}
				if(row["n_BorrowTimes"]!=null && row["n_BorrowTimes"].ToString()!="")
				{
					model.n_BorrowTimes=int.Parse(row["n_BorrowTimes"].ToString());
				}
				if(row["n_CreatorID"]!=null && row["n_CreatorID"].ToString()!="")
				{
					model.n_CreatorID=int.Parse(row["n_CreatorID"].ToString());
				}
				if(row["s_RelatedUserIDs"]!=null)
				{
					model.s_RelatedUserIDs=row["s_RelatedUserIDs"].ToString();
				}
				if(row["n_CutRateID"]!=null && row["n_CutRateID"].ToString()!="")
				{
					model.n_CutRateID=int.Parse(row["n_CutRateID"].ToString());
				}
				if(row["fn_CutRateID"]!=null && row["fn_CutRateID"].ToString()!="")
				{
					model.fn_CutRateID=int.Parse(row["fn_CutRateID"].ToString());
				}
				if(row["s_PriceDesc"]!=null)
				{
					model.s_PriceDesc=row["s_PriceDesc"].ToString();
				}
				if(row["s_PayerBillToName"]!=null)
				{
					model.s_PayerBillToName=row["s_PayerBillToName"].ToString();
				}
				if(row["s_PayerStreet"]!=null)
				{
					model.s_PayerStreet=row["s_PayerStreet"].ToString();
				}
				if(row["s_PayerCity"]!=null)
				{
					model.s_PayerCity=row["s_PayerCity"].ToString();
				}
				if(row["s_PayerState"]!=null)
				{
					model.s_PayerState=row["s_PayerState"].ToString();
				}
				if(row["s_PayerZipCode"]!=null)
				{
					model.s_PayerZipCode=row["s_PayerZipCode"].ToString();
				}
				if(row["n_PayerCountry"]!=null && row["n_PayerCountry"].ToString()!="")
				{
					model.n_PayerCountry=int.Parse(row["n_PayerCountry"].ToString());
				}
				if(row["s_PayerEmail"]!=null)
				{
					model.s_PayerEmail=row["s_PayerEmail"].ToString();
				}
				if(row["s_AppsSerial"]!=null)
				{
					model.s_AppsSerial=row["s_AppsSerial"].ToString();
				}
				if(row["s_ManualCreateChain"]!=null)
				{
					model.s_ManualCreateChain=row["s_ManualCreateChain"].ToString();
				}
				if(row["s_ApplicantCodes"]!=null)
				{
					model.s_ApplicantCodes=row["s_ApplicantCodes"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select n_CaseID,s_IPType,s_CaseSerial,n_FlowNum,s_CaseName,s_CaseOtherName,n_BusinessTypeID,s_FlowDirection,n_FirstAttorney,n_SecondAttorney,n_OfficeID,n_RegCountry,n_CoopAgencyFromID,n_CoopAgencyToID,s_CoopAgencyFromNo,s_CoopAgencyToNo,n_ClientID,s_ClientSerial,n_IntroID,n_IntroFee,n_IntroCurrency,s_IntroSerial,dt_UndertakeDate,dt_ShldSbmtDate,dt_SubmitDate,s_CaseStatus,s_FeeMode,n_FeeDiscount,n_FixAFee,n_FixFee,s_PayMode,s_FeeStatusOrder,s_FeeStatusInit,n_ChargeCurrency,n_OfficialCurrency,s_IsRegOnline,s_TotalSerial,s_SerialLocation,s_InConsole,dt_CreateDate,dt_EditDate,ObjectType,s_OtherName,n_EndProcess,n_IntroPer,s_SubmitStatus,dt_SubmittedDate,s_ProcessMark,n_DepartmentID,s_Applicants,s_ClientContacts,s_Dealers,s_Creator,s_Editor,s_CurrentOperator,n_ContractID,s_CaseNativeName,n_AppCountry,s_DealersID,n_ProcessID,n_StartProcessID,s_AppNo,dt_AppDate,s_ApplicantAddresses,s_AcceptNO,s_CProcessCodeIDs,s_NCProcessCodeIDs,s_ApplicantsCountry,s_ApplicantsNativeName,s_CustomField1,s_CustomField2,s_CustomField3,s_CustomField4,s_CustomField5,s_CustomField6,s_CustomField7,s_CustomField8,s_CustomField9,s_CustomField10,n_SecurityLevelID,s_ApplicantID,s_IsTempCase,s_IsMiddleCase,dt_SendCheckDate,n_PreferentialCombineID,s_ElecPayer,s_ClientCName,s_ArchiveStatus,s_ArchivePosition,n_BorrowTimes,n_CreatorID,s_RelatedUserIDs,n_CutRateID,fn_CutRateID,s_PriceDesc,s_PayerBillToName,s_PayerStreet,s_PayerCity,s_PayerState,s_PayerZipCode,n_PayerCountry,s_PayerEmail,s_AppsSerial,s_ManualCreateChain,s_ApplicantCodes ");
			strSql.Append(" FROM TCase_Base ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" n_CaseID,s_IPType,s_CaseSerial,n_FlowNum,s_CaseName,s_CaseOtherName,n_BusinessTypeID,s_FlowDirection,n_FirstAttorney,n_SecondAttorney,n_OfficeID,n_RegCountry,n_CoopAgencyFromID,n_CoopAgencyToID,s_CoopAgencyFromNo,s_CoopAgencyToNo,n_ClientID,s_ClientSerial,n_IntroID,n_IntroFee,n_IntroCurrency,s_IntroSerial,dt_UndertakeDate,dt_ShldSbmtDate,dt_SubmitDate,s_CaseStatus,s_FeeMode,n_FeeDiscount,n_FixAFee,n_FixFee,s_PayMode,s_FeeStatusOrder,s_FeeStatusInit,n_ChargeCurrency,n_OfficialCurrency,s_IsRegOnline,s_TotalSerial,s_SerialLocation,s_InConsole,dt_CreateDate,dt_EditDate,ObjectType,s_OtherName,n_EndProcess,n_IntroPer,s_SubmitStatus,dt_SubmittedDate,s_ProcessMark,n_DepartmentID,s_Applicants,s_ClientContacts,s_Dealers,s_Creator,s_Editor,s_CurrentOperator,n_ContractID,s_CaseNativeName,n_AppCountry,s_DealersID,n_ProcessID,n_StartProcessID,s_AppNo,dt_AppDate,s_ApplicantAddresses,s_AcceptNO,s_CProcessCodeIDs,s_NCProcessCodeIDs,s_ApplicantsCountry,s_ApplicantsNativeName,s_CustomField1,s_CustomField2,s_CustomField3,s_CustomField4,s_CustomField5,s_CustomField6,s_CustomField7,s_CustomField8,s_CustomField9,s_CustomField10,n_SecurityLevelID,s_ApplicantID,s_IsTempCase,s_IsMiddleCase,dt_SendCheckDate,n_PreferentialCombineID,s_ElecPayer,s_ClientCName,s_ArchiveStatus,s_ArchivePosition,n_BorrowTimes,n_CreatorID,s_RelatedUserIDs,n_CutRateID,fn_CutRateID,s_PriceDesc,s_PayerBillToName,s_PayerStreet,s_PayerCity,s_PayerState,s_PayerZipCode,n_PayerCountry,s_PayerEmail,s_AppsSerial,s_ManualCreateChain,s_ApplicantCodes ");
			strSql.Append(" FROM TCase_Base ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TCase_Base ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.n_CaseID desc");
			}
			strSql.Append(")AS Row, T.*  from TCase_Base T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "TCase_Base";
			parameters[1].Value = "n_CaseID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

