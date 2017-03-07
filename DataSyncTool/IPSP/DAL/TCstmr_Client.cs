/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_Client.cs
*
* 功 能： N/A
* 类 名： TCstmr_Client
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:39   N/A    初版
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
	/// 数据访问类:TCstmr_Client
	/// </summary>
	public partial class TCstmr_Client
	{
		public TCstmr_Client()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ObjectType", "TCstmr_Client"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ObjectType,int n_SecurityLevelID,int n_ClientID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCstmr_Client");
			strSql.Append(" where ObjectType=@ObjectType and n_SecurityLevelID=@n_SecurityLevelID and n_ClientID=@n_ClientID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)			};
			parameters[0].Value = ObjectType;
			parameters[1].Value = n_SecurityLevelID;
			parameters[2].Value = n_ClientID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCstmr_Client model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCstmr_Client(");
			strSql.Append("s_Name,s_NativeName,s_OtherName,s_ClientCode,s_IPType,s_Type,s_Credit,n_ApplicantID,n_CoopAgencyID,n_IntroID,s_Notes,n_Language,dt_FirstCaseDate,dt_LastCaseDate,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,s_PayMode,dt_CreateDate,dt_EditDate,ObjectType,s_IPRole,dt_FirstCaseDate34,s_IsActive,s_IsAllUser,n_ClientDeposit,n_ClientDepositCurrency,s_Source,n_Country,s_State,s_City,s_Area,n_PatentChargerID,n_TMChargerID,s_Lock,s_Locker,n_ClientDepositTransfer,s_Creator,s_Editor,s_DepositEditor,dt_DepositEditDate,n_FlowNum,s_Addresses,s_ZipCodes,s_ContactsLastName,s_ContactsFirstName,s_ContactsTel,s_ContactsAddresses,s_ContactsZipCode,n_FirstContactID,n_PatentCaseCount,n_TMCaseCount,n_CopyrightCaseCount,n_DomainCaseCount,n_OtherCaseCount,s_AccountName,s_BankName,s_AccountNo,s_AccountCode,s_TaxCode,s_RegAddress,s_RegTel,s_InvoiceTo,n_SecurityLevelID,n_PPreferentialCombineID,n_TPreferentialCombineID,n_CPreferentialCombineID,n_DPreferentialCombineID,n_OPreferentialCombineID,s_NotClaimMoney,s_FirstClientAddress,s_PriceDesc)");
			strSql.Append(" values (");
			strSql.Append("@s_Name,@s_NativeName,@s_OtherName,@s_ClientCode,@s_IPType,@s_Type,@s_Credit,@n_ApplicantID,@n_CoopAgencyID,@n_IntroID,@s_Notes,@n_Language,@dt_FirstCaseDate,@dt_LastCaseDate,@s_Phone,@s_Mobile,@s_Fax,@s_Email,@s_Website,@s_IMAddress,@s_Facebook,@s_Twitter,@s_PayMode,@dt_CreateDate,@dt_EditDate,@ObjectType,@s_IPRole,@dt_FirstCaseDate34,@s_IsActive,@s_IsAllUser,@n_ClientDeposit,@n_ClientDepositCurrency,@s_Source,@n_Country,@s_State,@s_City,@s_Area,@n_PatentChargerID,@n_TMChargerID,@s_Lock,@s_Locker,@n_ClientDepositTransfer,@s_Creator,@s_Editor,@s_DepositEditor,@dt_DepositEditDate,@n_FlowNum,@s_Addresses,@s_ZipCodes,@s_ContactsLastName,@s_ContactsFirstName,@s_ContactsTel,@s_ContactsAddresses,@s_ContactsZipCode,@n_FirstContactID,@n_PatentCaseCount,@n_TMCaseCount,@n_CopyrightCaseCount,@n_DomainCaseCount,@n_OtherCaseCount,@s_AccountName,@s_BankName,@s_AccountNo,@s_AccountCode,@s_TaxCode,@s_RegAddress,@s_RegTel,@s_InvoiceTo,@n_SecurityLevelID,@n_PPreferentialCombineID,@n_TPreferentialCombineID,@n_CPreferentialCombineID,@n_DPreferentialCombineID,@n_OPreferentialCombineID,@s_NotClaimMoney,@s_FirstClientAddress,@s_PriceDesc)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,-1),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,-1),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ClientCode", SqlDbType.NVarChar,20),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Credit", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ApplicantID", SqlDbType.Int,4),
					new SqlParameter("@n_CoopAgencyID", SqlDbType.Int,4),
					new SqlParameter("@n_IntroID", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_Language", SqlDbType.Int,4),
					new SqlParameter("@dt_FirstCaseDate", SqlDbType.DateTime),
					new SqlParameter("@dt_LastCaseDate", SqlDbType.DateTime),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Website", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IMAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Facebook", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Twitter", SqlDbType.NVarChar,200),
					new SqlParameter("@s_PayMode", SqlDbType.NVarChar,2),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@s_IPRole", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_FirstCaseDate34", SqlDbType.DateTime),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsAllUser", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ClientDeposit", SqlDbType.Decimal,9),
					new SqlParameter("@n_ClientDepositCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_Source", SqlDbType.NVarChar,100),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_State", SqlDbType.NVarChar,100),
					new SqlParameter("@s_City", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Area", SqlDbType.NVarChar,-1),
					new SqlParameter("@n_PatentChargerID", SqlDbType.Int,4),
					new SqlParameter("@n_TMChargerID", SqlDbType.Int,4),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,20),
					new SqlParameter("@n_ClientDepositTransfer", SqlDbType.Decimal,9),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_DepositEditor", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_DepositEditDate", SqlDbType.DateTime),
					new SqlParameter("@n_FlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_Addresses", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_ZipCodes", SqlDbType.NVarChar,150),
					new SqlParameter("@s_ContactsLastName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ContactsFirstName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ContactsTel", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ContactsAddresses", SqlDbType.NVarChar,4000),
					new SqlParameter("@s_ContactsZipCode", SqlDbType.NVarChar,150),
					new SqlParameter("@n_FirstContactID", SqlDbType.Int,4),
					new SqlParameter("@n_PatentCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_TMCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_CopyrightCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_DomainCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_OtherCaseCount", SqlDbType.Int,4),
					new SqlParameter("@s_AccountName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_BankName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AccountNo", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AccountCode", SqlDbType.NVarChar,40),
					new SqlParameter("@s_TaxCode", SqlDbType.NVarChar,100),
					new SqlParameter("@s_RegAddress", SqlDbType.NVarChar,400),
					new SqlParameter("@s_RegTel", SqlDbType.NVarChar,100),
					new SqlParameter("@s_InvoiceTo", SqlDbType.NVarChar,200),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@n_PPreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@n_TPreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@n_CPreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@n_DPreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@n_OPreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@s_NotClaimMoney", SqlDbType.NVarChar,2),
					new SqlParameter("@s_FirstClientAddress", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_PriceDesc", SqlDbType.NVarChar,-1)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_NativeName;
			parameters[2].Value = model.s_OtherName;
			parameters[3].Value = model.s_ClientCode;
			parameters[4].Value = model.s_IPType;
			parameters[5].Value = model.s_Type;
			parameters[6].Value = model.s_Credit;
			parameters[7].Value = model.n_ApplicantID;
			parameters[8].Value = model.n_CoopAgencyID;
			parameters[9].Value = model.n_IntroID;
			parameters[10].Value = model.s_Notes;
			parameters[11].Value = model.n_Language;
			parameters[12].Value = model.dt_FirstCaseDate;
			parameters[13].Value = model.dt_LastCaseDate;
			parameters[14].Value = model.s_Phone;
			parameters[15].Value = model.s_Mobile;
			parameters[16].Value = model.s_Fax;
			parameters[17].Value = model.s_Email;
			parameters[18].Value = model.s_Website;
			parameters[19].Value = model.s_IMAddress;
			parameters[20].Value = model.s_Facebook;
			parameters[21].Value = model.s_Twitter;
			parameters[22].Value = model.s_PayMode;
			parameters[23].Value = model.dt_CreateDate;
			parameters[24].Value = model.dt_EditDate;
			parameters[25].Value = model.ObjectType;
			parameters[26].Value = model.s_IPRole;
			parameters[27].Value = model.dt_FirstCaseDate34;
			parameters[28].Value = model.s_IsActive;
			parameters[29].Value = model.s_IsAllUser;
			parameters[30].Value = model.n_ClientDeposit;
			parameters[31].Value = model.n_ClientDepositCurrency;
			parameters[32].Value = model.s_Source;
			parameters[33].Value = model.n_Country;
			parameters[34].Value = model.s_State;
			parameters[35].Value = model.s_City;
			parameters[36].Value = model.s_Area;
			parameters[37].Value = model.n_PatentChargerID;
			parameters[38].Value = model.n_TMChargerID;
			parameters[39].Value = model.s_Lock;
			parameters[40].Value = model.s_Locker;
			parameters[41].Value = model.n_ClientDepositTransfer;
			parameters[42].Value = model.s_Creator;
			parameters[43].Value = model.s_Editor;
			parameters[44].Value = model.s_DepositEditor;
			parameters[45].Value = model.dt_DepositEditDate;
			parameters[46].Value = model.n_FlowNum;
			parameters[47].Value = model.s_Addresses;
			parameters[48].Value = model.s_ZipCodes;
			parameters[49].Value = model.s_ContactsLastName;
			parameters[50].Value = model.s_ContactsFirstName;
			parameters[51].Value = model.s_ContactsTel;
			parameters[52].Value = model.s_ContactsAddresses;
			parameters[53].Value = model.s_ContactsZipCode;
			parameters[54].Value = model.n_FirstContactID;
			parameters[55].Value = model.n_PatentCaseCount;
			parameters[56].Value = model.n_TMCaseCount;
			parameters[57].Value = model.n_CopyrightCaseCount;
			parameters[58].Value = model.n_DomainCaseCount;
			parameters[59].Value = model.n_OtherCaseCount;
			parameters[60].Value = model.s_AccountName;
			parameters[61].Value = model.s_BankName;
			parameters[62].Value = model.s_AccountNo;
			parameters[63].Value = model.s_AccountCode;
			parameters[64].Value = model.s_TaxCode;
			parameters[65].Value = model.s_RegAddress;
			parameters[66].Value = model.s_RegTel;
			parameters[67].Value = model.s_InvoiceTo;
			parameters[68].Value = model.n_SecurityLevelID;
			parameters[69].Value = model.n_PPreferentialCombineID;
			parameters[70].Value = model.n_TPreferentialCombineID;
			parameters[71].Value = model.n_CPreferentialCombineID;
			parameters[72].Value = model.n_DPreferentialCombineID;
			parameters[73].Value = model.n_OPreferentialCombineID;
			parameters[74].Value = model.s_NotClaimMoney;
			parameters[75].Value = model.s_FirstClientAddress;
			parameters[76].Value = model.s_PriceDesc;

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
		public bool Update(IPSP.Model.TCstmr_Client model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCstmr_Client set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_NativeName=@s_NativeName,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("s_ClientCode=@s_ClientCode,");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_Type=@s_Type,");
			strSql.Append("s_Credit=@s_Credit,");
			strSql.Append("n_ApplicantID=@n_ApplicantID,");
			strSql.Append("n_CoopAgencyID=@n_CoopAgencyID,");
			strSql.Append("n_IntroID=@n_IntroID,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("n_Language=@n_Language,");
			strSql.Append("dt_FirstCaseDate=@dt_FirstCaseDate,");
			strSql.Append("dt_LastCaseDate=@dt_LastCaseDate,");
			strSql.Append("s_Phone=@s_Phone,");
			strSql.Append("s_Mobile=@s_Mobile,");
			strSql.Append("s_Fax=@s_Fax,");
			strSql.Append("s_Email=@s_Email,");
			strSql.Append("s_Website=@s_Website,");
			strSql.Append("s_IMAddress=@s_IMAddress,");
			strSql.Append("s_Facebook=@s_Facebook,");
			strSql.Append("s_Twitter=@s_Twitter,");
			strSql.Append("s_PayMode=@s_PayMode,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_IPRole=@s_IPRole,");
			strSql.Append("dt_FirstCaseDate34=@dt_FirstCaseDate34,");
			strSql.Append("s_IsActive=@s_IsActive,");
			strSql.Append("s_IsAllUser=@s_IsAllUser,");
			strSql.Append("n_ClientDeposit=@n_ClientDeposit,");
			strSql.Append("n_ClientDepositCurrency=@n_ClientDepositCurrency,");
			strSql.Append("s_Source=@s_Source,");
			strSql.Append("n_Country=@n_Country,");
			strSql.Append("s_State=@s_State,");
			strSql.Append("s_City=@s_City,");
			strSql.Append("s_Area=@s_Area,");
			strSql.Append("n_PatentChargerID=@n_PatentChargerID,");
			strSql.Append("n_TMChargerID=@n_TMChargerID,");
			strSql.Append("s_Lock=@s_Lock,");
			strSql.Append("s_Locker=@s_Locker,");
			strSql.Append("n_ClientDepositTransfer=@n_ClientDepositTransfer,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("s_DepositEditor=@s_DepositEditor,");
			strSql.Append("dt_DepositEditDate=@dt_DepositEditDate,");
			strSql.Append("n_FlowNum=@n_FlowNum,");
			strSql.Append("s_Addresses=@s_Addresses,");
			strSql.Append("s_ZipCodes=@s_ZipCodes,");
			strSql.Append("s_ContactsLastName=@s_ContactsLastName,");
			strSql.Append("s_ContactsFirstName=@s_ContactsFirstName,");
			strSql.Append("s_ContactsTel=@s_ContactsTel,");
			strSql.Append("s_ContactsAddresses=@s_ContactsAddresses,");
			strSql.Append("s_ContactsZipCode=@s_ContactsZipCode,");
			strSql.Append("n_FirstContactID=@n_FirstContactID,");
			strSql.Append("n_PatentCaseCount=@n_PatentCaseCount,");
			strSql.Append("n_TMCaseCount=@n_TMCaseCount,");
			strSql.Append("n_CopyrightCaseCount=@n_CopyrightCaseCount,");
			strSql.Append("n_DomainCaseCount=@n_DomainCaseCount,");
			strSql.Append("n_OtherCaseCount=@n_OtherCaseCount,");
			strSql.Append("s_AccountName=@s_AccountName,");
			strSql.Append("s_BankName=@s_BankName,");
			strSql.Append("s_AccountNo=@s_AccountNo,");
			strSql.Append("s_AccountCode=@s_AccountCode,");
			strSql.Append("s_TaxCode=@s_TaxCode,");
			strSql.Append("s_RegAddress=@s_RegAddress,");
			strSql.Append("s_RegTel=@s_RegTel,");
			strSql.Append("s_InvoiceTo=@s_InvoiceTo,");
			strSql.Append("n_PPreferentialCombineID=@n_PPreferentialCombineID,");
			strSql.Append("n_TPreferentialCombineID=@n_TPreferentialCombineID,");
			strSql.Append("n_CPreferentialCombineID=@n_CPreferentialCombineID,");
			strSql.Append("n_DPreferentialCombineID=@n_DPreferentialCombineID,");
			strSql.Append("n_OPreferentialCombineID=@n_OPreferentialCombineID,");
			strSql.Append("s_NotClaimMoney=@s_NotClaimMoney,");
			strSql.Append("s_FirstClientAddress=@s_FirstClientAddress,");
			strSql.Append("s_PriceDesc=@s_PriceDesc");
			strSql.Append(" where n_ClientID=@n_ClientID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,-1),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,-1),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ClientCode", SqlDbType.NVarChar,20),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Credit", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ApplicantID", SqlDbType.Int,4),
					new SqlParameter("@n_CoopAgencyID", SqlDbType.Int,4),
					new SqlParameter("@n_IntroID", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_Language", SqlDbType.Int,4),
					new SqlParameter("@dt_FirstCaseDate", SqlDbType.DateTime),
					new SqlParameter("@dt_LastCaseDate", SqlDbType.DateTime),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Website", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IMAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Facebook", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Twitter", SqlDbType.NVarChar,200),
					new SqlParameter("@s_PayMode", SqlDbType.NVarChar,2),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IPRole", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_FirstCaseDate34", SqlDbType.DateTime),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsAllUser", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ClientDeposit", SqlDbType.Decimal,9),
					new SqlParameter("@n_ClientDepositCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_Source", SqlDbType.NVarChar,100),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_State", SqlDbType.NVarChar,100),
					new SqlParameter("@s_City", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Area", SqlDbType.NVarChar,-1),
					new SqlParameter("@n_PatentChargerID", SqlDbType.Int,4),
					new SqlParameter("@n_TMChargerID", SqlDbType.Int,4),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,20),
					new SqlParameter("@n_ClientDepositTransfer", SqlDbType.Decimal,9),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_DepositEditor", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_DepositEditDate", SqlDbType.DateTime),
					new SqlParameter("@n_FlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_Addresses", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_ZipCodes", SqlDbType.NVarChar,150),
					new SqlParameter("@s_ContactsLastName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ContactsFirstName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ContactsTel", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ContactsAddresses", SqlDbType.NVarChar,4000),
					new SqlParameter("@s_ContactsZipCode", SqlDbType.NVarChar,150),
					new SqlParameter("@n_FirstContactID", SqlDbType.Int,4),
					new SqlParameter("@n_PatentCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_TMCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_CopyrightCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_DomainCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_OtherCaseCount", SqlDbType.Int,4),
					new SqlParameter("@s_AccountName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_BankName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AccountNo", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AccountCode", SqlDbType.NVarChar,40),
					new SqlParameter("@s_TaxCode", SqlDbType.NVarChar,100),
					new SqlParameter("@s_RegAddress", SqlDbType.NVarChar,400),
					new SqlParameter("@s_RegTel", SqlDbType.NVarChar,100),
					new SqlParameter("@s_InvoiceTo", SqlDbType.NVarChar,200),
					new SqlParameter("@n_PPreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@n_TPreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@n_CPreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@n_DPreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@n_OPreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@s_NotClaimMoney", SqlDbType.NVarChar,2),
					new SqlParameter("@s_FirstClientAddress", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_PriceDesc", SqlDbType.NVarChar,-1),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_NativeName;
			parameters[2].Value = model.s_OtherName;
			parameters[3].Value = model.s_ClientCode;
			parameters[4].Value = model.s_IPType;
			parameters[5].Value = model.s_Type;
			parameters[6].Value = model.s_Credit;
			parameters[7].Value = model.n_ApplicantID;
			parameters[8].Value = model.n_CoopAgencyID;
			parameters[9].Value = model.n_IntroID;
			parameters[10].Value = model.s_Notes;
			parameters[11].Value = model.n_Language;
			parameters[12].Value = model.dt_FirstCaseDate;
			parameters[13].Value = model.dt_LastCaseDate;
			parameters[14].Value = model.s_Phone;
			parameters[15].Value = model.s_Mobile;
			parameters[16].Value = model.s_Fax;
			parameters[17].Value = model.s_Email;
			parameters[18].Value = model.s_Website;
			parameters[19].Value = model.s_IMAddress;
			parameters[20].Value = model.s_Facebook;
			parameters[21].Value = model.s_Twitter;
			parameters[22].Value = model.s_PayMode;
			parameters[23].Value = model.dt_CreateDate;
			parameters[24].Value = model.dt_EditDate;
			parameters[25].Value = model.s_IPRole;
			parameters[26].Value = model.dt_FirstCaseDate34;
			parameters[27].Value = model.s_IsActive;
			parameters[28].Value = model.s_IsAllUser;
			parameters[29].Value = model.n_ClientDeposit;
			parameters[30].Value = model.n_ClientDepositCurrency;
			parameters[31].Value = model.s_Source;
			parameters[32].Value = model.n_Country;
			parameters[33].Value = model.s_State;
			parameters[34].Value = model.s_City;
			parameters[35].Value = model.s_Area;
			parameters[36].Value = model.n_PatentChargerID;
			parameters[37].Value = model.n_TMChargerID;
			parameters[38].Value = model.s_Lock;
			parameters[39].Value = model.s_Locker;
			parameters[40].Value = model.n_ClientDepositTransfer;
			parameters[41].Value = model.s_Creator;
			parameters[42].Value = model.s_Editor;
			parameters[43].Value = model.s_DepositEditor;
			parameters[44].Value = model.dt_DepositEditDate;
			parameters[45].Value = model.n_FlowNum;
			parameters[46].Value = model.s_Addresses;
			parameters[47].Value = model.s_ZipCodes;
			parameters[48].Value = model.s_ContactsLastName;
			parameters[49].Value = model.s_ContactsFirstName;
			parameters[50].Value = model.s_ContactsTel;
			parameters[51].Value = model.s_ContactsAddresses;
			parameters[52].Value = model.s_ContactsZipCode;
			parameters[53].Value = model.n_FirstContactID;
			parameters[54].Value = model.n_PatentCaseCount;
			parameters[55].Value = model.n_TMCaseCount;
			parameters[56].Value = model.n_CopyrightCaseCount;
			parameters[57].Value = model.n_DomainCaseCount;
			parameters[58].Value = model.n_OtherCaseCount;
			parameters[59].Value = model.s_AccountName;
			parameters[60].Value = model.s_BankName;
			parameters[61].Value = model.s_AccountNo;
			parameters[62].Value = model.s_AccountCode;
			parameters[63].Value = model.s_TaxCode;
			parameters[64].Value = model.s_RegAddress;
			parameters[65].Value = model.s_RegTel;
			parameters[66].Value = model.s_InvoiceTo;
			parameters[67].Value = model.n_PPreferentialCombineID;
			parameters[68].Value = model.n_TPreferentialCombineID;
			parameters[69].Value = model.n_CPreferentialCombineID;
			parameters[70].Value = model.n_DPreferentialCombineID;
			parameters[71].Value = model.n_OPreferentialCombineID;
			parameters[72].Value = model.s_NotClaimMoney;
			parameters[73].Value = model.s_FirstClientAddress;
			parameters[74].Value = model.s_PriceDesc;
			parameters[75].Value = model.n_ClientID;
			parameters[76].Value = model.ObjectType;
			parameters[77].Value = model.n_SecurityLevelID;

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
		public bool Delete(int n_ClientID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_Client ");
			strSql.Append(" where n_ClientID=@n_ClientID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ClientID;

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
		public bool Delete(int ObjectType,int n_SecurityLevelID,int n_ClientID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_Client ");
			strSql.Append(" where ObjectType=@ObjectType and n_SecurityLevelID=@n_SecurityLevelID and n_ClientID=@n_ClientID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)			};
			parameters[0].Value = ObjectType;
			parameters[1].Value = n_SecurityLevelID;
			parameters[2].Value = n_ClientID;

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
		public bool DeleteList(string n_ClientIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_Client ");
			strSql.Append(" where n_ClientID in ("+n_ClientIDlist + ")  ");
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
		public IPSP.Model.TCstmr_Client GetModel(int n_ClientID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ClientID,s_Name,s_NativeName,s_OtherName,s_ClientCode,s_IPType,s_Type,s_Credit,n_ApplicantID,n_CoopAgencyID,n_IntroID,s_Notes,n_Language,dt_FirstCaseDate,dt_LastCaseDate,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,s_PayMode,dt_CreateDate,dt_EditDate,ObjectType,s_IPRole,dt_FirstCaseDate34,s_IsActive,s_IsAllUser,n_ClientDeposit,n_ClientDepositCurrency,s_Source,n_Country,s_State,s_City,s_Area,n_PatentChargerID,n_TMChargerID,s_Lock,s_Locker,n_ClientDepositTransfer,s_Creator,s_Editor,s_DepositEditor,dt_DepositEditDate,n_FlowNum,s_Addresses,s_ZipCodes,s_ContactsLastName,s_ContactsFirstName,s_ContactsTel,s_ContactsAddresses,s_ContactsZipCode,n_FirstContactID,n_PatentCaseCount,n_TMCaseCount,n_CopyrightCaseCount,n_DomainCaseCount,n_OtherCaseCount,s_AccountName,s_BankName,s_AccountNo,s_AccountCode,s_TaxCode,s_RegAddress,s_RegTel,s_InvoiceTo,n_SecurityLevelID,n_PPreferentialCombineID,n_TPreferentialCombineID,n_CPreferentialCombineID,n_DPreferentialCombineID,n_OPreferentialCombineID,s_NotClaimMoney,s_FirstClientAddress,s_PriceDesc from TCstmr_Client ");
			strSql.Append(" where n_ClientID=@n_ClientID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ClientID;

			IPSP.Model.TCstmr_Client model=new IPSP.Model.TCstmr_Client();
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
		public IPSP.Model.TCstmr_Client DataRowToModel(DataRow row)
		{
			IPSP.Model.TCstmr_Client model=new IPSP.Model.TCstmr_Client();
			if (row != null)
			{
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_NativeName"]!=null)
				{
					model.s_NativeName=row["s_NativeName"].ToString();
				}
				if(row["s_OtherName"]!=null)
				{
					model.s_OtherName=row["s_OtherName"].ToString();
				}
				if(row["s_ClientCode"]!=null)
				{
					model.s_ClientCode=row["s_ClientCode"].ToString();
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["s_Type"]!=null)
				{
					model.s_Type=row["s_Type"].ToString();
				}
				if(row["s_Credit"]!=null)
				{
					model.s_Credit=row["s_Credit"].ToString();
				}
				if(row["n_ApplicantID"]!=null && row["n_ApplicantID"].ToString()!="")
				{
					model.n_ApplicantID=int.Parse(row["n_ApplicantID"].ToString());
				}
				if(row["n_CoopAgencyID"]!=null && row["n_CoopAgencyID"].ToString()!="")
				{
					model.n_CoopAgencyID=int.Parse(row["n_CoopAgencyID"].ToString());
				}
				if(row["n_IntroID"]!=null && row["n_IntroID"].ToString()!="")
				{
					model.n_IntroID=int.Parse(row["n_IntroID"].ToString());
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["n_Language"]!=null && row["n_Language"].ToString()!="")
				{
					model.n_Language=int.Parse(row["n_Language"].ToString());
				}
				if(row["dt_FirstCaseDate"]!=null && row["dt_FirstCaseDate"].ToString()!="")
				{
					model.dt_FirstCaseDate=DateTime.Parse(row["dt_FirstCaseDate"].ToString());
				}
				if(row["dt_LastCaseDate"]!=null && row["dt_LastCaseDate"].ToString()!="")
				{
					model.dt_LastCaseDate=DateTime.Parse(row["dt_LastCaseDate"].ToString());
				}
				if(row["s_Phone"]!=null)
				{
					model.s_Phone=row["s_Phone"].ToString();
				}
				if(row["s_Mobile"]!=null)
				{
					model.s_Mobile=row["s_Mobile"].ToString();
				}
				if(row["s_Fax"]!=null)
				{
					model.s_Fax=row["s_Fax"].ToString();
				}
				if(row["s_Email"]!=null)
				{
					model.s_Email=row["s_Email"].ToString();
				}
				if(row["s_Website"]!=null)
				{
					model.s_Website=row["s_Website"].ToString();
				}
				if(row["s_IMAddress"]!=null)
				{
					model.s_IMAddress=row["s_IMAddress"].ToString();
				}
				if(row["s_Facebook"]!=null)
				{
					model.s_Facebook=row["s_Facebook"].ToString();
				}
				if(row["s_Twitter"]!=null)
				{
					model.s_Twitter=row["s_Twitter"].ToString();
				}
				if(row["s_PayMode"]!=null)
				{
					model.s_PayMode=row["s_PayMode"].ToString();
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
				if(row["s_IPRole"]!=null)
				{
					model.s_IPRole=row["s_IPRole"].ToString();
				}
				if(row["dt_FirstCaseDate34"]!=null && row["dt_FirstCaseDate34"].ToString()!="")
				{
					model.dt_FirstCaseDate34=DateTime.Parse(row["dt_FirstCaseDate34"].ToString());
				}
				if(row["s_IsActive"]!=null)
				{
					model.s_IsActive=row["s_IsActive"].ToString();
				}
				if(row["s_IsAllUser"]!=null)
				{
					model.s_IsAllUser=row["s_IsAllUser"].ToString();
				}
				if(row["n_ClientDeposit"]!=null && row["n_ClientDeposit"].ToString()!="")
				{
					model.n_ClientDeposit=decimal.Parse(row["n_ClientDeposit"].ToString());
				}
				if(row["n_ClientDepositCurrency"]!=null && row["n_ClientDepositCurrency"].ToString()!="")
				{
					model.n_ClientDepositCurrency=int.Parse(row["n_ClientDepositCurrency"].ToString());
				}
				if(row["s_Source"]!=null)
				{
					model.s_Source=row["s_Source"].ToString();
				}
				if(row["n_Country"]!=null && row["n_Country"].ToString()!="")
				{
					model.n_Country=int.Parse(row["n_Country"].ToString());
				}
				if(row["s_State"]!=null)
				{
					model.s_State=row["s_State"].ToString();
				}
				if(row["s_City"]!=null)
				{
					model.s_City=row["s_City"].ToString();
				}
				if(row["s_Area"]!=null)
				{
					model.s_Area=row["s_Area"].ToString();
				}
				if(row["n_PatentChargerID"]!=null && row["n_PatentChargerID"].ToString()!="")
				{
					model.n_PatentChargerID=int.Parse(row["n_PatentChargerID"].ToString());
				}
				if(row["n_TMChargerID"]!=null && row["n_TMChargerID"].ToString()!="")
				{
					model.n_TMChargerID=int.Parse(row["n_TMChargerID"].ToString());
				}
				if(row["s_Lock"]!=null)
				{
					model.s_Lock=row["s_Lock"].ToString();
				}
				if(row["s_Locker"]!=null)
				{
					model.s_Locker=row["s_Locker"].ToString();
				}
				if(row["n_ClientDepositTransfer"]!=null && row["n_ClientDepositTransfer"].ToString()!="")
				{
					model.n_ClientDepositTransfer=decimal.Parse(row["n_ClientDepositTransfer"].ToString());
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["s_DepositEditor"]!=null)
				{
					model.s_DepositEditor=row["s_DepositEditor"].ToString();
				}
				if(row["dt_DepositEditDate"]!=null && row["dt_DepositEditDate"].ToString()!="")
				{
					model.dt_DepositEditDate=DateTime.Parse(row["dt_DepositEditDate"].ToString());
				}
				if(row["n_FlowNum"]!=null && row["n_FlowNum"].ToString()!="")
				{
					model.n_FlowNum=int.Parse(row["n_FlowNum"].ToString());
				}
				if(row["s_Addresses"]!=null)
				{
					model.s_Addresses=row["s_Addresses"].ToString();
				}
				if(row["s_ZipCodes"]!=null)
				{
					model.s_ZipCodes=row["s_ZipCodes"].ToString();
				}
				if(row["s_ContactsLastName"]!=null)
				{
					model.s_ContactsLastName=row["s_ContactsLastName"].ToString();
				}
				if(row["s_ContactsFirstName"]!=null)
				{
					model.s_ContactsFirstName=row["s_ContactsFirstName"].ToString();
				}
				if(row["s_ContactsTel"]!=null)
				{
					model.s_ContactsTel=row["s_ContactsTel"].ToString();
				}
				if(row["s_ContactsAddresses"]!=null)
				{
					model.s_ContactsAddresses=row["s_ContactsAddresses"].ToString();
				}
				if(row["s_ContactsZipCode"]!=null)
				{
					model.s_ContactsZipCode=row["s_ContactsZipCode"].ToString();
				}
				if(row["n_FirstContactID"]!=null && row["n_FirstContactID"].ToString()!="")
				{
					model.n_FirstContactID=int.Parse(row["n_FirstContactID"].ToString());
				}
				if(row["n_PatentCaseCount"]!=null && row["n_PatentCaseCount"].ToString()!="")
				{
					model.n_PatentCaseCount=int.Parse(row["n_PatentCaseCount"].ToString());
				}
				if(row["n_TMCaseCount"]!=null && row["n_TMCaseCount"].ToString()!="")
				{
					model.n_TMCaseCount=int.Parse(row["n_TMCaseCount"].ToString());
				}
				if(row["n_CopyrightCaseCount"]!=null && row["n_CopyrightCaseCount"].ToString()!="")
				{
					model.n_CopyrightCaseCount=int.Parse(row["n_CopyrightCaseCount"].ToString());
				}
				if(row["n_DomainCaseCount"]!=null && row["n_DomainCaseCount"].ToString()!="")
				{
					model.n_DomainCaseCount=int.Parse(row["n_DomainCaseCount"].ToString());
				}
				if(row["n_OtherCaseCount"]!=null && row["n_OtherCaseCount"].ToString()!="")
				{
					model.n_OtherCaseCount=int.Parse(row["n_OtherCaseCount"].ToString());
				}
				if(row["s_AccountName"]!=null)
				{
					model.s_AccountName=row["s_AccountName"].ToString();
				}
				if(row["s_BankName"]!=null)
				{
					model.s_BankName=row["s_BankName"].ToString();
				}
				if(row["s_AccountNo"]!=null)
				{
					model.s_AccountNo=row["s_AccountNo"].ToString();
				}
				if(row["s_AccountCode"]!=null)
				{
					model.s_AccountCode=row["s_AccountCode"].ToString();
				}
				if(row["s_TaxCode"]!=null)
				{
					model.s_TaxCode=row["s_TaxCode"].ToString();
				}
				if(row["s_RegAddress"]!=null)
				{
					model.s_RegAddress=row["s_RegAddress"].ToString();
				}
				if(row["s_RegTel"]!=null)
				{
					model.s_RegTel=row["s_RegTel"].ToString();
				}
				if(row["s_InvoiceTo"]!=null)
				{
					model.s_InvoiceTo=row["s_InvoiceTo"].ToString();
				}
				if(row["n_SecurityLevelID"]!=null && row["n_SecurityLevelID"].ToString()!="")
				{
					model.n_SecurityLevelID=int.Parse(row["n_SecurityLevelID"].ToString());
				}
				if(row["n_PPreferentialCombineID"]!=null && row["n_PPreferentialCombineID"].ToString()!="")
				{
					model.n_PPreferentialCombineID=int.Parse(row["n_PPreferentialCombineID"].ToString());
				}
				if(row["n_TPreferentialCombineID"]!=null && row["n_TPreferentialCombineID"].ToString()!="")
				{
					model.n_TPreferentialCombineID=int.Parse(row["n_TPreferentialCombineID"].ToString());
				}
				if(row["n_CPreferentialCombineID"]!=null && row["n_CPreferentialCombineID"].ToString()!="")
				{
					model.n_CPreferentialCombineID=int.Parse(row["n_CPreferentialCombineID"].ToString());
				}
				if(row["n_DPreferentialCombineID"]!=null && row["n_DPreferentialCombineID"].ToString()!="")
				{
					model.n_DPreferentialCombineID=int.Parse(row["n_DPreferentialCombineID"].ToString());
				}
				if(row["n_OPreferentialCombineID"]!=null && row["n_OPreferentialCombineID"].ToString()!="")
				{
					model.n_OPreferentialCombineID=int.Parse(row["n_OPreferentialCombineID"].ToString());
				}
				if(row["s_NotClaimMoney"]!=null)
				{
					model.s_NotClaimMoney=row["s_NotClaimMoney"].ToString();
				}
				if(row["s_FirstClientAddress"]!=null)
				{
					model.s_FirstClientAddress=row["s_FirstClientAddress"].ToString();
				}
				if(row["s_PriceDesc"]!=null)
				{
					model.s_PriceDesc=row["s_PriceDesc"].ToString();
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
			strSql.Append("select n_ClientID,s_Name,s_NativeName,s_OtherName,s_ClientCode,s_IPType,s_Type,s_Credit,n_ApplicantID,n_CoopAgencyID,n_IntroID,s_Notes,n_Language,dt_FirstCaseDate,dt_LastCaseDate,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,s_PayMode,dt_CreateDate,dt_EditDate,ObjectType,s_IPRole,dt_FirstCaseDate34,s_IsActive,s_IsAllUser,n_ClientDeposit,n_ClientDepositCurrency,s_Source,n_Country,s_State,s_City,s_Area,n_PatentChargerID,n_TMChargerID,s_Lock,s_Locker,n_ClientDepositTransfer,s_Creator,s_Editor,s_DepositEditor,dt_DepositEditDate,n_FlowNum,s_Addresses,s_ZipCodes,s_ContactsLastName,s_ContactsFirstName,s_ContactsTel,s_ContactsAddresses,s_ContactsZipCode,n_FirstContactID,n_PatentCaseCount,n_TMCaseCount,n_CopyrightCaseCount,n_DomainCaseCount,n_OtherCaseCount,s_AccountName,s_BankName,s_AccountNo,s_AccountCode,s_TaxCode,s_RegAddress,s_RegTel,s_InvoiceTo,n_SecurityLevelID,n_PPreferentialCombineID,n_TPreferentialCombineID,n_CPreferentialCombineID,n_DPreferentialCombineID,n_OPreferentialCombineID,s_NotClaimMoney,s_FirstClientAddress,s_PriceDesc ");
			strSql.Append(" FROM TCstmr_Client ");
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
			strSql.Append(" n_ClientID,s_Name,s_NativeName,s_OtherName,s_ClientCode,s_IPType,s_Type,s_Credit,n_ApplicantID,n_CoopAgencyID,n_IntroID,s_Notes,n_Language,dt_FirstCaseDate,dt_LastCaseDate,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,s_PayMode,dt_CreateDate,dt_EditDate,ObjectType,s_IPRole,dt_FirstCaseDate34,s_IsActive,s_IsAllUser,n_ClientDeposit,n_ClientDepositCurrency,s_Source,n_Country,s_State,s_City,s_Area,n_PatentChargerID,n_TMChargerID,s_Lock,s_Locker,n_ClientDepositTransfer,s_Creator,s_Editor,s_DepositEditor,dt_DepositEditDate,n_FlowNum,s_Addresses,s_ZipCodes,s_ContactsLastName,s_ContactsFirstName,s_ContactsTel,s_ContactsAddresses,s_ContactsZipCode,n_FirstContactID,n_PatentCaseCount,n_TMCaseCount,n_CopyrightCaseCount,n_DomainCaseCount,n_OtherCaseCount,s_AccountName,s_BankName,s_AccountNo,s_AccountCode,s_TaxCode,s_RegAddress,s_RegTel,s_InvoiceTo,n_SecurityLevelID,n_PPreferentialCombineID,n_TPreferentialCombineID,n_CPreferentialCombineID,n_DPreferentialCombineID,n_OPreferentialCombineID,s_NotClaimMoney,s_FirstClientAddress,s_PriceDesc ");
			strSql.Append(" FROM TCstmr_Client ");
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
			strSql.Append("select count(1) FROM TCstmr_Client ");
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
				strSql.Append("order by T.n_ClientID desc");
			}
			strSql.Append(")AS Row, T.*  from TCstmr_Client T ");
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
			parameters[0].Value = "TCstmr_Client";
			parameters[1].Value = "n_ClientID";
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

