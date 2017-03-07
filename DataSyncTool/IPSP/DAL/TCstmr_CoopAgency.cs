/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_CoopAgency.cs
*
* 功 能： N/A
* 类 名： TCstmr_CoopAgency
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:54   N/A    初版
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
	/// 数据访问类:TCstmr_CoopAgency
	/// </summary>
	public partial class TCstmr_CoopAgency
	{
		public TCstmr_CoopAgency()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ClientID", "TCstmr_CoopAgency"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ClientID,int n_SecurityLevelID,int n_AgencyID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCstmr_CoopAgency");
			strSql.Append(" where n_ClientID=@n_ClientID and n_SecurityLevelID=@n_SecurityLevelID and n_AgencyID=@n_AgencyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = n_SecurityLevelID;
			parameters[2].Value = n_AgencyID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCstmr_CoopAgency model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCstmr_CoopAgency(");
			strSql.Append("s_Name,s_NativeName,s_OtherName,n_Language,s_IPType,s_Credit,s_Notes,n_ClientID,n_PayCurrency,dt_FirstCaseFromDate,dt_LastCaseFromDate,dt_FirstCaseToDate,dt_LastCaseToDate,s_Phone,s_Mobile,s_Fax,s_Email,s_WebSite,s_IMAddress,s_Facebook,s_Twitter,dt_CreateDate,dt_EditDate,s_Language,s_PayUnit,s_IPRole,n_PayUnit,s_Lock,s_Locker,s_Creator,s_Editor,s_Addresses,s_ContactsFirstName,s_ContactsLastName,s_ContactsTel,s_ContactsFax,s_ContactsEmail,s_FirstAddress,n_OAddressCountry,n_ToPatentCaseCount,n_ToTMCaseCount,n_ToCopyrightCaseCount,n_ToDomainCaseCount,n_ToOtherCaseCount,n_SecurityLevelID,s_Code,s_BeneficiaryBankName,s_BeneficiaryBankAddress,s_BeneficiaryName,s_BeneficiaryAddress,s_BeneficiaryAccountNumber,s_IBAN,s_SwiftCode,s_ABA)");
			strSql.Append(" values (");
			strSql.Append("@s_Name,@s_NativeName,@s_OtherName,@n_Language,@s_IPType,@s_Credit,@s_Notes,@n_ClientID,@n_PayCurrency,@dt_FirstCaseFromDate,@dt_LastCaseFromDate,@dt_FirstCaseToDate,@dt_LastCaseToDate,@s_Phone,@s_Mobile,@s_Fax,@s_Email,@s_WebSite,@s_IMAddress,@s_Facebook,@s_Twitter,@dt_CreateDate,@dt_EditDate,@s_Language,@s_PayUnit,@s_IPRole,@n_PayUnit,@s_Lock,@s_Locker,@s_Creator,@s_Editor,@s_Addresses,@s_ContactsFirstName,@s_ContactsLastName,@s_ContactsTel,@s_ContactsFax,@s_ContactsEmail,@s_FirstAddress,@n_OAddressCountry,@n_ToPatentCaseCount,@n_ToTMCaseCount,@n_ToCopyrightCaseCount,@n_ToDomainCaseCount,@n_ToOtherCaseCount,@n_SecurityLevelID,@s_Code,@s_BeneficiaryBankName,@s_BeneficiaryBankAddress,@s_BeneficiaryName,@s_BeneficiaryAddress,@s_BeneficiaryAccountNumber,@s_IBAN,@s_SwiftCode,@s_ABA)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@n_Language", SqlDbType.Int,4),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Credit", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_PayCurrency", SqlDbType.Int,4),
					new SqlParameter("@dt_FirstCaseFromDate", SqlDbType.DateTime),
					new SqlParameter("@dt_LastCaseFromDate", SqlDbType.DateTime),
					new SqlParameter("@dt_FirstCaseToDate", SqlDbType.DateTime),
					new SqlParameter("@dt_LastCaseToDate", SqlDbType.DateTime),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_WebSite", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IMAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Facebook", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Twitter", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Language", SqlDbType.Int,4),
					new SqlParameter("@s_PayUnit", SqlDbType.Int,4),
					new SqlParameter("@s_IPRole", SqlDbType.NVarChar,50),
					new SqlParameter("@n_PayUnit", SqlDbType.Int,4),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Addresses", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_ContactsFirstName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ContactsLastName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ContactsTel", SqlDbType.NVarChar,150),
					new SqlParameter("@s_ContactsFax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_ContactsEmail", SqlDbType.NVarChar,150),
					new SqlParameter("@s_FirstAddress", SqlDbType.NVarChar,500),
					new SqlParameter("@n_OAddressCountry", SqlDbType.Int,4),
					new SqlParameter("@n_ToPatentCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_ToTMCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_ToCopyrightCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_ToDomainCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_ToOtherCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@s_Code", SqlDbType.NVarChar,200),
					new SqlParameter("@s_BeneficiaryBankName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_BeneficiaryBankAddress", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_BeneficiaryName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_BeneficiaryAddress", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_BeneficiaryAccountNumber", SqlDbType.NVarChar,500),
					new SqlParameter("@s_IBAN", SqlDbType.NVarChar,500),
					new SqlParameter("@s_SwiftCode", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ABA", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_NativeName;
			parameters[2].Value = model.s_OtherName;
			parameters[3].Value = model.n_Language;
			parameters[4].Value = model.s_IPType;
			parameters[5].Value = model.s_Credit;
			parameters[6].Value = model.s_Notes;
			parameters[7].Value = model.n_ClientID;
			parameters[8].Value = model.n_PayCurrency;
			parameters[9].Value = model.dt_FirstCaseFromDate;
			parameters[10].Value = model.dt_LastCaseFromDate;
			parameters[11].Value = model.dt_FirstCaseToDate;
			parameters[12].Value = model.dt_LastCaseToDate;
			parameters[13].Value = model.s_Phone;
			parameters[14].Value = model.s_Mobile;
			parameters[15].Value = model.s_Fax;
			parameters[16].Value = model.s_Email;
			parameters[17].Value = model.s_WebSite;
			parameters[18].Value = model.s_IMAddress;
			parameters[19].Value = model.s_Facebook;
			parameters[20].Value = model.s_Twitter;
			parameters[21].Value = model.dt_CreateDate;
			parameters[22].Value = model.dt_EditDate;
			parameters[23].Value = model.s_Language;
			parameters[24].Value = model.s_PayUnit;
			parameters[25].Value = model.s_IPRole;
			parameters[26].Value = model.n_PayUnit;
			parameters[27].Value = model.s_Lock;
			parameters[28].Value = model.s_Locker;
			parameters[29].Value = model.s_Creator;
			parameters[30].Value = model.s_Editor;
			parameters[31].Value = model.s_Addresses;
			parameters[32].Value = model.s_ContactsFirstName;
			parameters[33].Value = model.s_ContactsLastName;
			parameters[34].Value = model.s_ContactsTel;
			parameters[35].Value = model.s_ContactsFax;
			parameters[36].Value = model.s_ContactsEmail;
			parameters[37].Value = model.s_FirstAddress;
			parameters[38].Value = model.n_OAddressCountry;
			parameters[39].Value = model.n_ToPatentCaseCount;
			parameters[40].Value = model.n_ToTMCaseCount;
			parameters[41].Value = model.n_ToCopyrightCaseCount;
			parameters[42].Value = model.n_ToDomainCaseCount;
			parameters[43].Value = model.n_ToOtherCaseCount;
			parameters[44].Value = model.n_SecurityLevelID;
			parameters[45].Value = model.s_Code;
			parameters[46].Value = model.s_BeneficiaryBankName;
			parameters[47].Value = model.s_BeneficiaryBankAddress;
			parameters[48].Value = model.s_BeneficiaryName;
			parameters[49].Value = model.s_BeneficiaryAddress;
			parameters[50].Value = model.s_BeneficiaryAccountNumber;
			parameters[51].Value = model.s_IBAN;
			parameters[52].Value = model.s_SwiftCode;
			parameters[53].Value = model.s_ABA;

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
		public bool Update(IPSP.Model.TCstmr_CoopAgency model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCstmr_CoopAgency set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_NativeName=@s_NativeName,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("n_Language=@n_Language,");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_Credit=@s_Credit,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("n_PayCurrency=@n_PayCurrency,");
			strSql.Append("dt_FirstCaseFromDate=@dt_FirstCaseFromDate,");
			strSql.Append("dt_LastCaseFromDate=@dt_LastCaseFromDate,");
			strSql.Append("dt_FirstCaseToDate=@dt_FirstCaseToDate,");
			strSql.Append("dt_LastCaseToDate=@dt_LastCaseToDate,");
			strSql.Append("s_Phone=@s_Phone,");
			strSql.Append("s_Mobile=@s_Mobile,");
			strSql.Append("s_Fax=@s_Fax,");
			strSql.Append("s_Email=@s_Email,");
			strSql.Append("s_WebSite=@s_WebSite,");
			strSql.Append("s_IMAddress=@s_IMAddress,");
			strSql.Append("s_Facebook=@s_Facebook,");
			strSql.Append("s_Twitter=@s_Twitter,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_Language=@s_Language,");
			strSql.Append("s_PayUnit=@s_PayUnit,");
			strSql.Append("s_IPRole=@s_IPRole,");
			strSql.Append("n_PayUnit=@n_PayUnit,");
			strSql.Append("s_Lock=@s_Lock,");
			strSql.Append("s_Locker=@s_Locker,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("s_Addresses=@s_Addresses,");
			strSql.Append("s_ContactsFirstName=@s_ContactsFirstName,");
			strSql.Append("s_ContactsLastName=@s_ContactsLastName,");
			strSql.Append("s_ContactsTel=@s_ContactsTel,");
			strSql.Append("s_ContactsFax=@s_ContactsFax,");
			strSql.Append("s_ContactsEmail=@s_ContactsEmail,");
			strSql.Append("s_FirstAddress=@s_FirstAddress,");
			strSql.Append("n_OAddressCountry=@n_OAddressCountry,");
			strSql.Append("n_ToPatentCaseCount=@n_ToPatentCaseCount,");
			strSql.Append("n_ToTMCaseCount=@n_ToTMCaseCount,");
			strSql.Append("n_ToCopyrightCaseCount=@n_ToCopyrightCaseCount,");
			strSql.Append("n_ToDomainCaseCount=@n_ToDomainCaseCount,");
			strSql.Append("n_ToOtherCaseCount=@n_ToOtherCaseCount,");
			strSql.Append("s_Code=@s_Code,");
			strSql.Append("s_BeneficiaryBankName=@s_BeneficiaryBankName,");
			strSql.Append("s_BeneficiaryBankAddress=@s_BeneficiaryBankAddress,");
			strSql.Append("s_BeneficiaryName=@s_BeneficiaryName,");
			strSql.Append("s_BeneficiaryAddress=@s_BeneficiaryAddress,");
			strSql.Append("s_BeneficiaryAccountNumber=@s_BeneficiaryAccountNumber,");
			strSql.Append("s_IBAN=@s_IBAN,");
			strSql.Append("s_SwiftCode=@s_SwiftCode,");
			strSql.Append("s_ABA=@s_ABA");
			strSql.Append(" where n_AgencyID=@n_AgencyID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@n_Language", SqlDbType.Int,4),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Credit", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_PayCurrency", SqlDbType.Int,4),
					new SqlParameter("@dt_FirstCaseFromDate", SqlDbType.DateTime),
					new SqlParameter("@dt_LastCaseFromDate", SqlDbType.DateTime),
					new SqlParameter("@dt_FirstCaseToDate", SqlDbType.DateTime),
					new SqlParameter("@dt_LastCaseToDate", SqlDbType.DateTime),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_WebSite", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IMAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Facebook", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Twitter", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Language", SqlDbType.Int,4),
					new SqlParameter("@s_PayUnit", SqlDbType.Int,4),
					new SqlParameter("@s_IPRole", SqlDbType.NVarChar,50),
					new SqlParameter("@n_PayUnit", SqlDbType.Int,4),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Addresses", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_ContactsFirstName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ContactsLastName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ContactsTel", SqlDbType.NVarChar,150),
					new SqlParameter("@s_ContactsFax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_ContactsEmail", SqlDbType.NVarChar,150),
					new SqlParameter("@s_FirstAddress", SqlDbType.NVarChar,500),
					new SqlParameter("@n_OAddressCountry", SqlDbType.Int,4),
					new SqlParameter("@n_ToPatentCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_ToTMCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_ToCopyrightCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_ToDomainCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_ToOtherCaseCount", SqlDbType.Int,4),
					new SqlParameter("@s_Code", SqlDbType.NVarChar,200),
					new SqlParameter("@s_BeneficiaryBankName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_BeneficiaryBankAddress", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_BeneficiaryName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_BeneficiaryAddress", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_BeneficiaryAccountNumber", SqlDbType.NVarChar,500),
					new SqlParameter("@s_IBAN", SqlDbType.NVarChar,500),
					new SqlParameter("@s_SwiftCode", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ABA", SqlDbType.NVarChar,500),
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_NativeName;
			parameters[2].Value = model.s_OtherName;
			parameters[3].Value = model.n_Language;
			parameters[4].Value = model.s_IPType;
			parameters[5].Value = model.s_Credit;
			parameters[6].Value = model.s_Notes;
			parameters[7].Value = model.n_PayCurrency;
			parameters[8].Value = model.dt_FirstCaseFromDate;
			parameters[9].Value = model.dt_LastCaseFromDate;
			parameters[10].Value = model.dt_FirstCaseToDate;
			parameters[11].Value = model.dt_LastCaseToDate;
			parameters[12].Value = model.s_Phone;
			parameters[13].Value = model.s_Mobile;
			parameters[14].Value = model.s_Fax;
			parameters[15].Value = model.s_Email;
			parameters[16].Value = model.s_WebSite;
			parameters[17].Value = model.s_IMAddress;
			parameters[18].Value = model.s_Facebook;
			parameters[19].Value = model.s_Twitter;
			parameters[20].Value = model.dt_CreateDate;
			parameters[21].Value = model.dt_EditDate;
			parameters[22].Value = model.s_Language;
			parameters[23].Value = model.s_PayUnit;
			parameters[24].Value = model.s_IPRole;
			parameters[25].Value = model.n_PayUnit;
			parameters[26].Value = model.s_Lock;
			parameters[27].Value = model.s_Locker;
			parameters[28].Value = model.s_Creator;
			parameters[29].Value = model.s_Editor;
			parameters[30].Value = model.s_Addresses;
			parameters[31].Value = model.s_ContactsFirstName;
			parameters[32].Value = model.s_ContactsLastName;
			parameters[33].Value = model.s_ContactsTel;
			parameters[34].Value = model.s_ContactsFax;
			parameters[35].Value = model.s_ContactsEmail;
			parameters[36].Value = model.s_FirstAddress;
			parameters[37].Value = model.n_OAddressCountry;
			parameters[38].Value = model.n_ToPatentCaseCount;
			parameters[39].Value = model.n_ToTMCaseCount;
			parameters[40].Value = model.n_ToCopyrightCaseCount;
			parameters[41].Value = model.n_ToDomainCaseCount;
			parameters[42].Value = model.n_ToOtherCaseCount;
			parameters[43].Value = model.s_Code;
			parameters[44].Value = model.s_BeneficiaryBankName;
			parameters[45].Value = model.s_BeneficiaryBankAddress;
			parameters[46].Value = model.s_BeneficiaryName;
			parameters[47].Value = model.s_BeneficiaryAddress;
			parameters[48].Value = model.s_BeneficiaryAccountNumber;
			parameters[49].Value = model.s_IBAN;
			parameters[50].Value = model.s_SwiftCode;
			parameters[51].Value = model.s_ABA;
			parameters[52].Value = model.n_AgencyID;
			parameters[53].Value = model.n_ClientID;
			parameters[54].Value = model.n_SecurityLevelID;

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
		public bool Delete(int n_AgencyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_CoopAgency ");
			strSql.Append(" where n_AgencyID=@n_AgencyID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_AgencyID;

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
		public bool Delete(int n_ClientID,int n_SecurityLevelID,int n_AgencyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_CoopAgency ");
			strSql.Append(" where n_ClientID=@n_ClientID and n_SecurityLevelID=@n_SecurityLevelID and n_AgencyID=@n_AgencyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = n_SecurityLevelID;
			parameters[2].Value = n_AgencyID;

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
		public bool DeleteList(string n_AgencyIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_CoopAgency ");
			strSql.Append(" where n_AgencyID in ("+n_AgencyIDlist + ")  ");
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
		public IPSP.Model.TCstmr_CoopAgency GetModel(int n_AgencyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_AgencyID,s_Name,s_NativeName,s_OtherName,n_Language,s_IPType,s_Credit,s_Notes,n_ClientID,n_PayCurrency,dt_FirstCaseFromDate,dt_LastCaseFromDate,dt_FirstCaseToDate,dt_LastCaseToDate,s_Phone,s_Mobile,s_Fax,s_Email,s_WebSite,s_IMAddress,s_Facebook,s_Twitter,dt_CreateDate,dt_EditDate,s_Language,s_PayUnit,s_IPRole,n_PayUnit,s_Lock,s_Locker,s_Creator,s_Editor,s_Addresses,s_ContactsFirstName,s_ContactsLastName,s_ContactsTel,s_ContactsFax,s_ContactsEmail,s_FirstAddress,n_OAddressCountry,n_ToPatentCaseCount,n_ToTMCaseCount,n_ToCopyrightCaseCount,n_ToDomainCaseCount,n_ToOtherCaseCount,n_SecurityLevelID,s_Code,s_BeneficiaryBankName,s_BeneficiaryBankAddress,s_BeneficiaryName,s_BeneficiaryAddress,s_BeneficiaryAccountNumber,s_IBAN,s_SwiftCode,s_ABA from TCstmr_CoopAgency ");
			strSql.Append(" where n_AgencyID=@n_AgencyID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_AgencyID;

			IPSP.Model.TCstmr_CoopAgency model=new IPSP.Model.TCstmr_CoopAgency();
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
		public IPSP.Model.TCstmr_CoopAgency DataRowToModel(DataRow row)
		{
			IPSP.Model.TCstmr_CoopAgency model=new IPSP.Model.TCstmr_CoopAgency();
			if (row != null)
			{
				if(row["n_AgencyID"]!=null && row["n_AgencyID"].ToString()!="")
				{
					model.n_AgencyID=int.Parse(row["n_AgencyID"].ToString());
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
				if(row["n_Language"]!=null && row["n_Language"].ToString()!="")
				{
					model.n_Language=int.Parse(row["n_Language"].ToString());
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["s_Credit"]!=null)
				{
					model.s_Credit=row["s_Credit"].ToString();
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["n_PayCurrency"]!=null && row["n_PayCurrency"].ToString()!="")
				{
					model.n_PayCurrency=int.Parse(row["n_PayCurrency"].ToString());
				}
				if(row["dt_FirstCaseFromDate"]!=null && row["dt_FirstCaseFromDate"].ToString()!="")
				{
					model.dt_FirstCaseFromDate=DateTime.Parse(row["dt_FirstCaseFromDate"].ToString());
				}
				if(row["dt_LastCaseFromDate"]!=null && row["dt_LastCaseFromDate"].ToString()!="")
				{
					model.dt_LastCaseFromDate=DateTime.Parse(row["dt_LastCaseFromDate"].ToString());
				}
				if(row["dt_FirstCaseToDate"]!=null && row["dt_FirstCaseToDate"].ToString()!="")
				{
					model.dt_FirstCaseToDate=DateTime.Parse(row["dt_FirstCaseToDate"].ToString());
				}
				if(row["dt_LastCaseToDate"]!=null && row["dt_LastCaseToDate"].ToString()!="")
				{
					model.dt_LastCaseToDate=DateTime.Parse(row["dt_LastCaseToDate"].ToString());
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
				if(row["s_WebSite"]!=null)
				{
					model.s_WebSite=row["s_WebSite"].ToString();
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
				if(row["s_Language"]!=null && row["s_Language"].ToString()!="")
				{
					model.s_Language=int.Parse(row["s_Language"].ToString());
				}
				if(row["s_PayUnit"]!=null && row["s_PayUnit"].ToString()!="")
				{
					model.s_PayUnit=int.Parse(row["s_PayUnit"].ToString());
				}
				if(row["s_IPRole"]!=null)
				{
					model.s_IPRole=row["s_IPRole"].ToString();
				}
				if(row["n_PayUnit"]!=null && row["n_PayUnit"].ToString()!="")
				{
					model.n_PayUnit=int.Parse(row["n_PayUnit"].ToString());
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
				if(row["s_ContactsEmail"]!=null)
				{
					model.s_ContactsEmail=row["s_ContactsEmail"].ToString();
				}
				if(row["s_FirstAddress"]!=null)
				{
					model.s_FirstAddress=row["s_FirstAddress"].ToString();
				}
				if(row["n_OAddressCountry"]!=null && row["n_OAddressCountry"].ToString()!="")
				{
					model.n_OAddressCountry=int.Parse(row["n_OAddressCountry"].ToString());
				}
				if(row["n_ToPatentCaseCount"]!=null && row["n_ToPatentCaseCount"].ToString()!="")
				{
					model.n_ToPatentCaseCount=int.Parse(row["n_ToPatentCaseCount"].ToString());
				}
				if(row["n_ToTMCaseCount"]!=null && row["n_ToTMCaseCount"].ToString()!="")
				{
					model.n_ToTMCaseCount=int.Parse(row["n_ToTMCaseCount"].ToString());
				}
				if(row["n_ToCopyrightCaseCount"]!=null && row["n_ToCopyrightCaseCount"].ToString()!="")
				{
					model.n_ToCopyrightCaseCount=int.Parse(row["n_ToCopyrightCaseCount"].ToString());
				}
				if(row["n_ToDomainCaseCount"]!=null && row["n_ToDomainCaseCount"].ToString()!="")
				{
					model.n_ToDomainCaseCount=int.Parse(row["n_ToDomainCaseCount"].ToString());
				}
				if(row["n_ToOtherCaseCount"]!=null && row["n_ToOtherCaseCount"].ToString()!="")
				{
					model.n_ToOtherCaseCount=int.Parse(row["n_ToOtherCaseCount"].ToString());
				}
				if(row["n_SecurityLevelID"]!=null && row["n_SecurityLevelID"].ToString()!="")
				{
					model.n_SecurityLevelID=int.Parse(row["n_SecurityLevelID"].ToString());
				}
				if(row["s_Code"]!=null)
				{
					model.s_Code=row["s_Code"].ToString();
				}
				if(row["s_BeneficiaryBankName"]!=null)
				{
					model.s_BeneficiaryBankName=row["s_BeneficiaryBankName"].ToString();
				}
				if(row["s_BeneficiaryBankAddress"]!=null)
				{
					model.s_BeneficiaryBankAddress=row["s_BeneficiaryBankAddress"].ToString();
				}
				if(row["s_BeneficiaryName"]!=null)
				{
					model.s_BeneficiaryName=row["s_BeneficiaryName"].ToString();
				}
				if(row["s_BeneficiaryAddress"]!=null)
				{
					model.s_BeneficiaryAddress=row["s_BeneficiaryAddress"].ToString();
				}
				if(row["s_BeneficiaryAccountNumber"]!=null)
				{
					model.s_BeneficiaryAccountNumber=row["s_BeneficiaryAccountNumber"].ToString();
				}
				if(row["s_IBAN"]!=null)
				{
					model.s_IBAN=row["s_IBAN"].ToString();
				}
				if(row["s_SwiftCode"]!=null)
				{
					model.s_SwiftCode=row["s_SwiftCode"].ToString();
				}
				if(row["s_ABA"]!=null)
				{
					model.s_ABA=row["s_ABA"].ToString();
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
			strSql.Append("select n_AgencyID,s_Name,s_NativeName,s_OtherName,n_Language,s_IPType,s_Credit,s_Notes,n_ClientID,n_PayCurrency,dt_FirstCaseFromDate,dt_LastCaseFromDate,dt_FirstCaseToDate,dt_LastCaseToDate,s_Phone,s_Mobile,s_Fax,s_Email,s_WebSite,s_IMAddress,s_Facebook,s_Twitter,dt_CreateDate,dt_EditDate,s_Language,s_PayUnit,s_IPRole,n_PayUnit,s_Lock,s_Locker,s_Creator,s_Editor,s_Addresses,s_ContactsFirstName,s_ContactsLastName,s_ContactsTel,s_ContactsFax,s_ContactsEmail,s_FirstAddress,n_OAddressCountry,n_ToPatentCaseCount,n_ToTMCaseCount,n_ToCopyrightCaseCount,n_ToDomainCaseCount,n_ToOtherCaseCount,n_SecurityLevelID,s_Code,s_BeneficiaryBankName,s_BeneficiaryBankAddress,s_BeneficiaryName,s_BeneficiaryAddress,s_BeneficiaryAccountNumber,s_IBAN,s_SwiftCode,s_ABA ");
			strSql.Append(" FROM TCstmr_CoopAgency ");
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
			strSql.Append(" n_AgencyID,s_Name,s_NativeName,s_OtherName,n_Language,s_IPType,s_Credit,s_Notes,n_ClientID,n_PayCurrency,dt_FirstCaseFromDate,dt_LastCaseFromDate,dt_FirstCaseToDate,dt_LastCaseToDate,s_Phone,s_Mobile,s_Fax,s_Email,s_WebSite,s_IMAddress,s_Facebook,s_Twitter,dt_CreateDate,dt_EditDate,s_Language,s_PayUnit,s_IPRole,n_PayUnit,s_Lock,s_Locker,s_Creator,s_Editor,s_Addresses,s_ContactsFirstName,s_ContactsLastName,s_ContactsTel,s_ContactsFax,s_ContactsEmail,s_FirstAddress,n_OAddressCountry,n_ToPatentCaseCount,n_ToTMCaseCount,n_ToCopyrightCaseCount,n_ToDomainCaseCount,n_ToOtherCaseCount,n_SecurityLevelID,s_Code,s_BeneficiaryBankName,s_BeneficiaryBankAddress,s_BeneficiaryName,s_BeneficiaryAddress,s_BeneficiaryAccountNumber,s_IBAN,s_SwiftCode,s_ABA ");
			strSql.Append(" FROM TCstmr_CoopAgency ");
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
			strSql.Append("select count(1) FROM TCstmr_CoopAgency ");
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
				strSql.Append("order by T.n_AgencyID desc");
			}
			strSql.Append(")AS Row, T.*  from TCstmr_CoopAgency T ");
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
			parameters[0].Value = "TCstmr_CoopAgency";
			parameters[1].Value = "n_AgencyID";
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

