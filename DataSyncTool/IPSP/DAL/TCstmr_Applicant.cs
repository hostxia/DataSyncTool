/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_Applicant.cs
*
* 功 能： N/A
* 类 名： TCstmr_Applicant
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:35   N/A    初版
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
	/// 数据访问类:TCstmr_Applicant
	/// </summary>
	public partial class TCstmr_Applicant
	{
		public TCstmr_Applicant()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ClientID", "TCstmr_Applicant"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ClientID,int ObjectType,int n_SecurityLevelID,int n_AppID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCstmr_Applicant");
			strSql.Append(" where n_ClientID=@n_ClientID and ObjectType=@ObjectType and n_SecurityLevelID=@n_SecurityLevelID and n_AppID=@n_AppID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@n_AppID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = ObjectType;
			parameters[2].Value = n_SecurityLevelID;
			parameters[3].Value = n_AppID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCstmr_Applicant model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCstmr_Applicant(");
			strSql.Append("n_ClientID,s_Name,s_NativeName,s_OtherName,s_IPType,s_AppType,s_IDName,s_IDNumber,s_AppCode,s_HasTrustDeed,s_TrustDeedNo,s_TrustDeedPath,s_Corporation,s_Duty,s_Notes,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,dt_CreateDate,dt_EditDate,ObjectType,s_Lock,s_Locker,s_Creator,s_Editor,s_Area,n_PatentCaseCount,n_TMCaseCount,n_CopyrightCaseCount,n_DomainCaseCount,n_OtherCaseCount,s_FirstAddress,dt_FirstCaseFromDate,dt_LastCaseFromDate,s_Addresses,s_ContactsFirstName,s_ContactsLastName,s_ContactsTel,s_ContactsFax,s_ContactsAddresses,s_GovName,s_AccountName,s_BankName,s_AccountNo,s_AccountCode,s_TaxCode,s_RegAddress,s_RegTel,s_InvoiceTo,n_SecurityLevelID,s_PayFeePerson,b_ElecPayer,n_Country,s_FeeMitigationYear,s_FeeMitigationNum)");
			strSql.Append(" values (");
			strSql.Append("@n_ClientID,@s_Name,@s_NativeName,@s_OtherName,@s_IPType,@s_AppType,@s_IDName,@s_IDNumber,@s_AppCode,@s_HasTrustDeed,@s_TrustDeedNo,@s_TrustDeedPath,@s_Corporation,@s_Duty,@s_Notes,@s_Phone,@s_Mobile,@s_Fax,@s_Email,@s_Website,@s_IMAddress,@s_Facebook,@s_Twitter,@dt_CreateDate,@dt_EditDate,@ObjectType,@s_Lock,@s_Locker,@s_Creator,@s_Editor,@s_Area,@n_PatentCaseCount,@n_TMCaseCount,@n_CopyrightCaseCount,@n_DomainCaseCount,@n_OtherCaseCount,@s_FirstAddress,@dt_FirstCaseFromDate,@dt_LastCaseFromDate,@s_Addresses,@s_ContactsFirstName,@s_ContactsLastName,@s_ContactsTel,@s_ContactsFax,@s_ContactsAddresses,@s_GovName,@s_AccountName,@s_BankName,@s_AccountNo,@s_AccountCode,@s_TaxCode,@s_RegAddress,@s_RegTel,@s_InvoiceTo,@n_SecurityLevelID,@s_PayFeePerson,@b_ElecPayer,@n_Country,@s_FeeMitigationYear,@s_FeeMitigationNum)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_AppType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IDName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IDNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@s_AppCode", SqlDbType.NVarChar,20),
					new SqlParameter("@s_HasTrustDeed", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TrustDeedNo", SqlDbType.NVarChar,30),
					new SqlParameter("@s_TrustDeedPath", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Corporation", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Duty", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Website", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IMAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Facebook", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Twitter", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Area", SqlDbType.NVarChar,100),
					new SqlParameter("@n_PatentCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_TMCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_CopyrightCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_DomainCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_OtherCaseCount", SqlDbType.Int,4),
					new SqlParameter("@s_FirstAddress", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_FirstCaseFromDate", SqlDbType.DateTime),
					new SqlParameter("@dt_LastCaseFromDate", SqlDbType.DateTime),
					new SqlParameter("@s_Addresses", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ContactsFirstName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ContactsLastName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ContactsTel", SqlDbType.NVarChar,150),
					new SqlParameter("@s_ContactsFax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_ContactsAddresses", SqlDbType.NVarChar,500),
					new SqlParameter("@s_GovName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_AccountName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_BankName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AccountNo", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AccountCode", SqlDbType.NVarChar,40),
					new SqlParameter("@s_TaxCode", SqlDbType.NVarChar,100),
					new SqlParameter("@s_RegAddress", SqlDbType.NVarChar,400),
					new SqlParameter("@s_RegTel", SqlDbType.NVarChar,100),
					new SqlParameter("@s_InvoiceTo", SqlDbType.NVarChar,200),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@s_PayFeePerson", SqlDbType.NVarChar,100),
					new SqlParameter("@b_ElecPayer", SqlDbType.Bit,1),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_FeeMitigationYear", SqlDbType.NVarChar,100),
					new SqlParameter("@s_FeeMitigationNum", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.n_ClientID;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_NativeName;
			parameters[3].Value = model.s_OtherName;
			parameters[4].Value = model.s_IPType;
			parameters[5].Value = model.s_AppType;
			parameters[6].Value = model.s_IDName;
			parameters[7].Value = model.s_IDNumber;
			parameters[8].Value = model.s_AppCode;
			parameters[9].Value = model.s_HasTrustDeed;
			parameters[10].Value = model.s_TrustDeedNo;
			parameters[11].Value = model.s_TrustDeedPath;
			parameters[12].Value = model.s_Corporation;
			parameters[13].Value = model.s_Duty;
			parameters[14].Value = model.s_Notes;
			parameters[15].Value = model.s_Phone;
			parameters[16].Value = model.s_Mobile;
			parameters[17].Value = model.s_Fax;
			parameters[18].Value = model.s_Email;
			parameters[19].Value = model.s_Website;
			parameters[20].Value = model.s_IMAddress;
			parameters[21].Value = model.s_Facebook;
			parameters[22].Value = model.s_Twitter;
			parameters[23].Value = model.dt_CreateDate;
			parameters[24].Value = model.dt_EditDate;
			parameters[25].Value = model.ObjectType;
			parameters[26].Value = model.s_Lock;
			parameters[27].Value = model.s_Locker;
			parameters[28].Value = model.s_Creator;
			parameters[29].Value = model.s_Editor;
			parameters[30].Value = model.s_Area;
			parameters[31].Value = model.n_PatentCaseCount;
			parameters[32].Value = model.n_TMCaseCount;
			parameters[33].Value = model.n_CopyrightCaseCount;
			parameters[34].Value = model.n_DomainCaseCount;
			parameters[35].Value = model.n_OtherCaseCount;
			parameters[36].Value = model.s_FirstAddress;
			parameters[37].Value = model.dt_FirstCaseFromDate;
			parameters[38].Value = model.dt_LastCaseFromDate;
			parameters[39].Value = model.s_Addresses;
			parameters[40].Value = model.s_ContactsFirstName;
			parameters[41].Value = model.s_ContactsLastName;
			parameters[42].Value = model.s_ContactsTel;
			parameters[43].Value = model.s_ContactsFax;
			parameters[44].Value = model.s_ContactsAddresses;
			parameters[45].Value = model.s_GovName;
			parameters[46].Value = model.s_AccountName;
			parameters[47].Value = model.s_BankName;
			parameters[48].Value = model.s_AccountNo;
			parameters[49].Value = model.s_AccountCode;
			parameters[50].Value = model.s_TaxCode;
			parameters[51].Value = model.s_RegAddress;
			parameters[52].Value = model.s_RegTel;
			parameters[53].Value = model.s_InvoiceTo;
			parameters[54].Value = model.n_SecurityLevelID;
			parameters[55].Value = model.s_PayFeePerson;
			parameters[56].Value = model.b_ElecPayer;
			parameters[57].Value = model.n_Country;
			parameters[58].Value = model.s_FeeMitigationYear;
			parameters[59].Value = model.s_FeeMitigationNum;

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
		public bool Update(IPSP.Model.TCstmr_Applicant model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCstmr_Applicant set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_NativeName=@s_NativeName,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_AppType=@s_AppType,");
			strSql.Append("s_IDName=@s_IDName,");
			strSql.Append("s_IDNumber=@s_IDNumber,");
			strSql.Append("s_AppCode=@s_AppCode,");
			strSql.Append("s_HasTrustDeed=@s_HasTrustDeed,");
			strSql.Append("s_TrustDeedNo=@s_TrustDeedNo,");
			strSql.Append("s_TrustDeedPath=@s_TrustDeedPath,");
			strSql.Append("s_Corporation=@s_Corporation,");
			strSql.Append("s_Duty=@s_Duty,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("s_Phone=@s_Phone,");
			strSql.Append("s_Mobile=@s_Mobile,");
			strSql.Append("s_Fax=@s_Fax,");
			strSql.Append("s_Email=@s_Email,");
			strSql.Append("s_Website=@s_Website,");
			strSql.Append("s_IMAddress=@s_IMAddress,");
			strSql.Append("s_Facebook=@s_Facebook,");
			strSql.Append("s_Twitter=@s_Twitter,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_Lock=@s_Lock,");
			strSql.Append("s_Locker=@s_Locker,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("s_Area=@s_Area,");
			strSql.Append("n_PatentCaseCount=@n_PatentCaseCount,");
			strSql.Append("n_TMCaseCount=@n_TMCaseCount,");
			strSql.Append("n_CopyrightCaseCount=@n_CopyrightCaseCount,");
			strSql.Append("n_DomainCaseCount=@n_DomainCaseCount,");
			strSql.Append("n_OtherCaseCount=@n_OtherCaseCount,");
			strSql.Append("s_FirstAddress=@s_FirstAddress,");
			strSql.Append("dt_FirstCaseFromDate=@dt_FirstCaseFromDate,");
			strSql.Append("dt_LastCaseFromDate=@dt_LastCaseFromDate,");
			strSql.Append("s_Addresses=@s_Addresses,");
			strSql.Append("s_ContactsFirstName=@s_ContactsFirstName,");
			strSql.Append("s_ContactsLastName=@s_ContactsLastName,");
			strSql.Append("s_ContactsTel=@s_ContactsTel,");
			strSql.Append("s_ContactsFax=@s_ContactsFax,");
			strSql.Append("s_ContactsAddresses=@s_ContactsAddresses,");
			strSql.Append("s_GovName=@s_GovName,");
			strSql.Append("s_AccountName=@s_AccountName,");
			strSql.Append("s_BankName=@s_BankName,");
			strSql.Append("s_AccountNo=@s_AccountNo,");
			strSql.Append("s_AccountCode=@s_AccountCode,");
			strSql.Append("s_TaxCode=@s_TaxCode,");
			strSql.Append("s_RegAddress=@s_RegAddress,");
			strSql.Append("s_RegTel=@s_RegTel,");
			strSql.Append("s_InvoiceTo=@s_InvoiceTo,");
			strSql.Append("s_PayFeePerson=@s_PayFeePerson,");
			strSql.Append("b_ElecPayer=@b_ElecPayer,");
			strSql.Append("n_Country=@n_Country,");
			strSql.Append("s_FeeMitigationYear=@s_FeeMitigationYear,");
			strSql.Append("s_FeeMitigationNum=@s_FeeMitigationNum");
			strSql.Append(" where n_AppID=@n_AppID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_AppType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IDName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IDNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@s_AppCode", SqlDbType.NVarChar,20),
					new SqlParameter("@s_HasTrustDeed", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TrustDeedNo", SqlDbType.NVarChar,30),
					new SqlParameter("@s_TrustDeedPath", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Corporation", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Duty", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Website", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IMAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Facebook", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Twitter", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Area", SqlDbType.NVarChar,100),
					new SqlParameter("@n_PatentCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_TMCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_CopyrightCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_DomainCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_OtherCaseCount", SqlDbType.Int,4),
					new SqlParameter("@s_FirstAddress", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_FirstCaseFromDate", SqlDbType.DateTime),
					new SqlParameter("@dt_LastCaseFromDate", SqlDbType.DateTime),
					new SqlParameter("@s_Addresses", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ContactsFirstName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ContactsLastName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ContactsTel", SqlDbType.NVarChar,150),
					new SqlParameter("@s_ContactsFax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_ContactsAddresses", SqlDbType.NVarChar,500),
					new SqlParameter("@s_GovName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_AccountName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_BankName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AccountNo", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AccountCode", SqlDbType.NVarChar,40),
					new SqlParameter("@s_TaxCode", SqlDbType.NVarChar,100),
					new SqlParameter("@s_RegAddress", SqlDbType.NVarChar,400),
					new SqlParameter("@s_RegTel", SqlDbType.NVarChar,100),
					new SqlParameter("@s_InvoiceTo", SqlDbType.NVarChar,200),
					new SqlParameter("@s_PayFeePerson", SqlDbType.NVarChar,100),
					new SqlParameter("@b_ElecPayer", SqlDbType.Bit,1),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_FeeMitigationYear", SqlDbType.NVarChar,100),
					new SqlParameter("@s_FeeMitigationNum", SqlDbType.NVarChar,100),
					new SqlParameter("@n_AppID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_NativeName;
			parameters[2].Value = model.s_OtherName;
			parameters[3].Value = model.s_IPType;
			parameters[4].Value = model.s_AppType;
			parameters[5].Value = model.s_IDName;
			parameters[6].Value = model.s_IDNumber;
			parameters[7].Value = model.s_AppCode;
			parameters[8].Value = model.s_HasTrustDeed;
			parameters[9].Value = model.s_TrustDeedNo;
			parameters[10].Value = model.s_TrustDeedPath;
			parameters[11].Value = model.s_Corporation;
			parameters[12].Value = model.s_Duty;
			parameters[13].Value = model.s_Notes;
			parameters[14].Value = model.s_Phone;
			parameters[15].Value = model.s_Mobile;
			parameters[16].Value = model.s_Fax;
			parameters[17].Value = model.s_Email;
			parameters[18].Value = model.s_Website;
			parameters[19].Value = model.s_IMAddress;
			parameters[20].Value = model.s_Facebook;
			parameters[21].Value = model.s_Twitter;
			parameters[22].Value = model.dt_CreateDate;
			parameters[23].Value = model.dt_EditDate;
			parameters[24].Value = model.s_Lock;
			parameters[25].Value = model.s_Locker;
			parameters[26].Value = model.s_Creator;
			parameters[27].Value = model.s_Editor;
			parameters[28].Value = model.s_Area;
			parameters[29].Value = model.n_PatentCaseCount;
			parameters[30].Value = model.n_TMCaseCount;
			parameters[31].Value = model.n_CopyrightCaseCount;
			parameters[32].Value = model.n_DomainCaseCount;
			parameters[33].Value = model.n_OtherCaseCount;
			parameters[34].Value = model.s_FirstAddress;
			parameters[35].Value = model.dt_FirstCaseFromDate;
			parameters[36].Value = model.dt_LastCaseFromDate;
			parameters[37].Value = model.s_Addresses;
			parameters[38].Value = model.s_ContactsFirstName;
			parameters[39].Value = model.s_ContactsLastName;
			parameters[40].Value = model.s_ContactsTel;
			parameters[41].Value = model.s_ContactsFax;
			parameters[42].Value = model.s_ContactsAddresses;
			parameters[43].Value = model.s_GovName;
			parameters[44].Value = model.s_AccountName;
			parameters[45].Value = model.s_BankName;
			parameters[46].Value = model.s_AccountNo;
			parameters[47].Value = model.s_AccountCode;
			parameters[48].Value = model.s_TaxCode;
			parameters[49].Value = model.s_RegAddress;
			parameters[50].Value = model.s_RegTel;
			parameters[51].Value = model.s_InvoiceTo;
			parameters[52].Value = model.s_PayFeePerson;
			parameters[53].Value = model.b_ElecPayer;
			parameters[54].Value = model.n_Country;
			parameters[55].Value = model.s_FeeMitigationYear;
			parameters[56].Value = model.s_FeeMitigationNum;
			parameters[57].Value = model.n_AppID;
			parameters[58].Value = model.n_ClientID;
			parameters[59].Value = model.ObjectType;
			parameters[60].Value = model.n_SecurityLevelID;

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
		public bool Delete(int n_AppID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_Applicant ");
			strSql.Append(" where n_AppID=@n_AppID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AppID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_AppID;

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
		public bool Delete(int n_ClientID,int ObjectType,int n_SecurityLevelID,int n_AppID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_Applicant ");
			strSql.Append(" where n_ClientID=@n_ClientID and ObjectType=@ObjectType and n_SecurityLevelID=@n_SecurityLevelID and n_AppID=@n_AppID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@n_AppID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = ObjectType;
			parameters[2].Value = n_SecurityLevelID;
			parameters[3].Value = n_AppID;

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
		public bool DeleteList(string n_AppIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_Applicant ");
			strSql.Append(" where n_AppID in ("+n_AppIDlist + ")  ");
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
		public IPSP.Model.TCstmr_Applicant GetModel(int n_AppID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_AppID,n_ClientID,s_Name,s_NativeName,s_OtherName,s_IPType,s_AppType,s_IDName,s_IDNumber,s_AppCode,s_HasTrustDeed,s_TrustDeedNo,s_TrustDeedPath,s_Corporation,s_Duty,s_Notes,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,dt_CreateDate,dt_EditDate,ObjectType,s_Lock,s_Locker,s_Creator,s_Editor,s_Area,n_PatentCaseCount,n_TMCaseCount,n_CopyrightCaseCount,n_DomainCaseCount,n_OtherCaseCount,s_FirstAddress,dt_FirstCaseFromDate,dt_LastCaseFromDate,s_Addresses,s_ContactsFirstName,s_ContactsLastName,s_ContactsTel,s_ContactsFax,s_ContactsAddresses,s_GovName,s_AccountName,s_BankName,s_AccountNo,s_AccountCode,s_TaxCode,s_RegAddress,s_RegTel,s_InvoiceTo,n_SecurityLevelID,s_PayFeePerson,b_ElecPayer,n_Country,s_FeeMitigationYear,s_FeeMitigationNum from TCstmr_Applicant ");
			strSql.Append(" where n_AppID=@n_AppID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AppID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_AppID;

			IPSP.Model.TCstmr_Applicant model=new IPSP.Model.TCstmr_Applicant();
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
		public IPSP.Model.TCstmr_Applicant DataRowToModel(DataRow row)
		{
			IPSP.Model.TCstmr_Applicant model=new IPSP.Model.TCstmr_Applicant();
			if (row != null)
			{
				if(row["n_AppID"]!=null && row["n_AppID"].ToString()!="")
				{
					model.n_AppID=int.Parse(row["n_AppID"].ToString());
				}
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
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["s_AppType"]!=null)
				{
					model.s_AppType=row["s_AppType"].ToString();
				}
				if(row["s_IDName"]!=null)
				{
					model.s_IDName=row["s_IDName"].ToString();
				}
				if(row["s_IDNumber"]!=null)
				{
					model.s_IDNumber=row["s_IDNumber"].ToString();
				}
				if(row["s_AppCode"]!=null)
				{
					model.s_AppCode=row["s_AppCode"].ToString();
				}
				if(row["s_HasTrustDeed"]!=null)
				{
					model.s_HasTrustDeed=row["s_HasTrustDeed"].ToString();
				}
				if(row["s_TrustDeedNo"]!=null)
				{
					model.s_TrustDeedNo=row["s_TrustDeedNo"].ToString();
				}
				if(row["s_TrustDeedPath"]!=null)
				{
					model.s_TrustDeedPath=row["s_TrustDeedPath"].ToString();
				}
				if(row["s_Corporation"]!=null)
				{
					model.s_Corporation=row["s_Corporation"].ToString();
				}
				if(row["s_Duty"]!=null)
				{
					model.s_Duty=row["s_Duty"].ToString();
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
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
				if(row["s_Lock"]!=null)
				{
					model.s_Lock=row["s_Lock"].ToString();
				}
				if(row["s_Locker"]!=null)
				{
					model.s_Locker=row["s_Locker"].ToString();
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["s_Area"]!=null)
				{
					model.s_Area=row["s_Area"].ToString();
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
				if(row["s_FirstAddress"]!=null)
				{
					model.s_FirstAddress=row["s_FirstAddress"].ToString();
				}
				if(row["dt_FirstCaseFromDate"]!=null && row["dt_FirstCaseFromDate"].ToString()!="")
				{
					model.dt_FirstCaseFromDate=DateTime.Parse(row["dt_FirstCaseFromDate"].ToString());
				}
				if(row["dt_LastCaseFromDate"]!=null && row["dt_LastCaseFromDate"].ToString()!="")
				{
					model.dt_LastCaseFromDate=DateTime.Parse(row["dt_LastCaseFromDate"].ToString());
				}
				if(row["s_Addresses"]!=null)
				{
					model.s_Addresses=row["s_Addresses"].ToString();
				}
				if(row["s_ContactsFirstName"]!=null)
				{
					model.s_ContactsFirstName=row["s_ContactsFirstName"].ToString();
				}
				if(row["s_ContactsLastName"]!=null)
				{
					model.s_ContactsLastName=row["s_ContactsLastName"].ToString();
				}
				if(row["s_ContactsTel"]!=null)
				{
					model.s_ContactsTel=row["s_ContactsTel"].ToString();
				}
				if(row["s_ContactsFax"]!=null)
				{
					model.s_ContactsFax=row["s_ContactsFax"].ToString();
				}
				if(row["s_ContactsAddresses"]!=null)
				{
					model.s_ContactsAddresses=row["s_ContactsAddresses"].ToString();
				}
				if(row["s_GovName"]!=null)
				{
					model.s_GovName=row["s_GovName"].ToString();
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
				if(row["s_PayFeePerson"]!=null)
				{
					model.s_PayFeePerson=row["s_PayFeePerson"].ToString();
				}
				if(row["b_ElecPayer"]!=null && row["b_ElecPayer"].ToString()!="")
				{
					if((row["b_ElecPayer"].ToString()=="1")||(row["b_ElecPayer"].ToString().ToLower()=="true"))
					{
						model.b_ElecPayer=true;
					}
					else
					{
						model.b_ElecPayer=false;
					}
				}
				if(row["n_Country"]!=null && row["n_Country"].ToString()!="")
				{
					model.n_Country=int.Parse(row["n_Country"].ToString());
				}
				if(row["s_FeeMitigationYear"]!=null)
				{
					model.s_FeeMitigationYear=row["s_FeeMitigationYear"].ToString();
				}
				if(row["s_FeeMitigationNum"]!=null)
				{
					model.s_FeeMitigationNum=row["s_FeeMitigationNum"].ToString();
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
			strSql.Append("select n_AppID,n_ClientID,s_Name,s_NativeName,s_OtherName,s_IPType,s_AppType,s_IDName,s_IDNumber,s_AppCode,s_HasTrustDeed,s_TrustDeedNo,s_TrustDeedPath,s_Corporation,s_Duty,s_Notes,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,dt_CreateDate,dt_EditDate,ObjectType,s_Lock,s_Locker,s_Creator,s_Editor,s_Area,n_PatentCaseCount,n_TMCaseCount,n_CopyrightCaseCount,n_DomainCaseCount,n_OtherCaseCount,s_FirstAddress,dt_FirstCaseFromDate,dt_LastCaseFromDate,s_Addresses,s_ContactsFirstName,s_ContactsLastName,s_ContactsTel,s_ContactsFax,s_ContactsAddresses,s_GovName,s_AccountName,s_BankName,s_AccountNo,s_AccountCode,s_TaxCode,s_RegAddress,s_RegTel,s_InvoiceTo,n_SecurityLevelID,s_PayFeePerson,b_ElecPayer,n_Country,s_FeeMitigationYear,s_FeeMitigationNum ");
			strSql.Append(" FROM TCstmr_Applicant ");
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
			strSql.Append(" n_AppID,n_ClientID,s_Name,s_NativeName,s_OtherName,s_IPType,s_AppType,s_IDName,s_IDNumber,s_AppCode,s_HasTrustDeed,s_TrustDeedNo,s_TrustDeedPath,s_Corporation,s_Duty,s_Notes,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,dt_CreateDate,dt_EditDate,ObjectType,s_Lock,s_Locker,s_Creator,s_Editor,s_Area,n_PatentCaseCount,n_TMCaseCount,n_CopyrightCaseCount,n_DomainCaseCount,n_OtherCaseCount,s_FirstAddress,dt_FirstCaseFromDate,dt_LastCaseFromDate,s_Addresses,s_ContactsFirstName,s_ContactsLastName,s_ContactsTel,s_ContactsFax,s_ContactsAddresses,s_GovName,s_AccountName,s_BankName,s_AccountNo,s_AccountCode,s_TaxCode,s_RegAddress,s_RegTel,s_InvoiceTo,n_SecurityLevelID,s_PayFeePerson,b_ElecPayer,n_Country,s_FeeMitigationYear,s_FeeMitigationNum ");
			strSql.Append(" FROM TCstmr_Applicant ");
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
			strSql.Append("select count(1) FROM TCstmr_Applicant ");
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
				strSql.Append("order by T.n_AppID desc");
			}
			strSql.Append(")AS Row, T.*  from TCstmr_Applicant T ");
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
			parameters[0].Value = "TCstmr_Applicant";
			parameters[1].Value = "n_AppID";
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

