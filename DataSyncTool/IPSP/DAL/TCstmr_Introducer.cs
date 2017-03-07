/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_Introducer.cs
*
* 功 能： N/A
* 类 名： TCstmr_Introducer
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:02   N/A    初版
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
	/// 数据访问类:TCstmr_Introducer
	/// </summary>
	public partial class TCstmr_Introducer
	{
		public TCstmr_Introducer()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_SecurityLevelID", "TCstmr_Introducer"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_SecurityLevelID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCstmr_Introducer");
			strSql.Append(" where n_SecurityLevelID=@n_SecurityLevelID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_SecurityLevelID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCstmr_Introducer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCstmr_Introducer(");
			strSql.Append("s_LastName,s_FirstName,s_Initial,s_Prefix,s_NativeName,s_IntroCode,s_Type,s_JobTitle,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,s_Notes,dt_FirstCaseDate,dt_LastCaseDate,dt_CreateDate,dt_EditDate,s_IPType,s_Lock,s_Locker,s_Creator,s_Editor,n_Percent,n_PatentCaseCount,n_TMCaseCount,n_CopyrightCaseCount,n_DomainCaseCount,n_OtherCaseCount,s_FirstAddress,s_Addresses,s_AccountName,s_BankName,s_AccountNo,s_AccountCode,s_TaxCode,s_RegAddress,s_RegTel,s_InvoiceTo,n_SecurityLevelID)");
			strSql.Append(" values (");
			strSql.Append("@s_LastName,@s_FirstName,@s_Initial,@s_Prefix,@s_NativeName,@s_IntroCode,@s_Type,@s_JobTitle,@s_Phone,@s_Mobile,@s_Fax,@s_Email,@s_Website,@s_IMAddress,@s_Facebook,@s_Twitter,@s_Notes,@dt_FirstCaseDate,@dt_LastCaseDate,@dt_CreateDate,@dt_EditDate,@s_IPType,@s_Lock,@s_Locker,@s_Creator,@s_Editor,@n_Percent,@n_PatentCaseCount,@n_TMCaseCount,@n_CopyrightCaseCount,@n_DomainCaseCount,@n_OtherCaseCount,@s_FirstAddress,@s_Addresses,@s_AccountName,@s_BankName,@s_AccountNo,@s_AccountCode,@s_TaxCode,@s_RegAddress,@s_RegTel,@s_InvoiceTo,@n_SecurityLevelID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_LastName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_FirstName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Initial", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Prefix", SqlDbType.NVarChar,30),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_IntroCode", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@s_JobTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Website", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IMAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Facebook", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Twitter", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_FirstCaseDate", SqlDbType.DateTime),
					new SqlParameter("@dt_LastCaseDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_Percent", SqlDbType.NVarChar,50),
					new SqlParameter("@n_PatentCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_TMCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_CopyrightCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_DomainCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_OtherCaseCount", SqlDbType.Int,4),
					new SqlParameter("@s_FirstAddress", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Addresses", SqlDbType.NVarChar,500),
					new SqlParameter("@s_AccountName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_BankName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AccountNo", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AccountCode", SqlDbType.NVarChar,40),
					new SqlParameter("@s_TaxCode", SqlDbType.NVarChar,100),
					new SqlParameter("@s_RegAddress", SqlDbType.NVarChar,400),
					new SqlParameter("@s_RegTel", SqlDbType.NVarChar,100),
					new SqlParameter("@s_InvoiceTo", SqlDbType.NVarChar,200),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_LastName;
			parameters[1].Value = model.s_FirstName;
			parameters[2].Value = model.s_Initial;
			parameters[3].Value = model.s_Prefix;
			parameters[4].Value = model.s_NativeName;
			parameters[5].Value = model.s_IntroCode;
			parameters[6].Value = model.s_Type;
			parameters[7].Value = model.s_JobTitle;
			parameters[8].Value = model.s_Phone;
			parameters[9].Value = model.s_Mobile;
			parameters[10].Value = model.s_Fax;
			parameters[11].Value = model.s_Email;
			parameters[12].Value = model.s_Website;
			parameters[13].Value = model.s_IMAddress;
			parameters[14].Value = model.s_Facebook;
			parameters[15].Value = model.s_Twitter;
			parameters[16].Value = model.s_Notes;
			parameters[17].Value = model.dt_FirstCaseDate;
			parameters[18].Value = model.dt_LastCaseDate;
			parameters[19].Value = model.dt_CreateDate;
			parameters[20].Value = model.dt_EditDate;
			parameters[21].Value = model.s_IPType;
			parameters[22].Value = model.s_Lock;
			parameters[23].Value = model.s_Locker;
			parameters[24].Value = model.s_Creator;
			parameters[25].Value = model.s_Editor;
			parameters[26].Value = model.n_Percent;
			parameters[27].Value = model.n_PatentCaseCount;
			parameters[28].Value = model.n_TMCaseCount;
			parameters[29].Value = model.n_CopyrightCaseCount;
			parameters[30].Value = model.n_DomainCaseCount;
			parameters[31].Value = model.n_OtherCaseCount;
			parameters[32].Value = model.s_FirstAddress;
			parameters[33].Value = model.s_Addresses;
			parameters[34].Value = model.s_AccountName;
			parameters[35].Value = model.s_BankName;
			parameters[36].Value = model.s_AccountNo;
			parameters[37].Value = model.s_AccountCode;
			parameters[38].Value = model.s_TaxCode;
			parameters[39].Value = model.s_RegAddress;
			parameters[40].Value = model.s_RegTel;
			parameters[41].Value = model.s_InvoiceTo;
			parameters[42].Value = model.n_SecurityLevelID;

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
		public bool Update(IPSP.Model.TCstmr_Introducer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCstmr_Introducer set ");
			strSql.Append("s_LastName=@s_LastName,");
			strSql.Append("s_FirstName=@s_FirstName,");
			strSql.Append("s_Initial=@s_Initial,");
			strSql.Append("s_Prefix=@s_Prefix,");
			strSql.Append("s_NativeName=@s_NativeName,");
			strSql.Append("s_IntroCode=@s_IntroCode,");
			strSql.Append("s_Type=@s_Type,");
			strSql.Append("s_JobTitle=@s_JobTitle,");
			strSql.Append("s_Phone=@s_Phone,");
			strSql.Append("s_Mobile=@s_Mobile,");
			strSql.Append("s_Fax=@s_Fax,");
			strSql.Append("s_Email=@s_Email,");
			strSql.Append("s_Website=@s_Website,");
			strSql.Append("s_IMAddress=@s_IMAddress,");
			strSql.Append("s_Facebook=@s_Facebook,");
			strSql.Append("s_Twitter=@s_Twitter,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("dt_FirstCaseDate=@dt_FirstCaseDate,");
			strSql.Append("dt_LastCaseDate=@dt_LastCaseDate,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_Lock=@s_Lock,");
			strSql.Append("s_Locker=@s_Locker,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("n_Percent=@n_Percent,");
			strSql.Append("n_PatentCaseCount=@n_PatentCaseCount,");
			strSql.Append("n_TMCaseCount=@n_TMCaseCount,");
			strSql.Append("n_CopyrightCaseCount=@n_CopyrightCaseCount,");
			strSql.Append("n_DomainCaseCount=@n_DomainCaseCount,");
			strSql.Append("n_OtherCaseCount=@n_OtherCaseCount,");
			strSql.Append("s_FirstAddress=@s_FirstAddress,");
			strSql.Append("s_Addresses=@s_Addresses,");
			strSql.Append("s_AccountName=@s_AccountName,");
			strSql.Append("s_BankName=@s_BankName,");
			strSql.Append("s_AccountNo=@s_AccountNo,");
			strSql.Append("s_AccountCode=@s_AccountCode,");
			strSql.Append("s_TaxCode=@s_TaxCode,");
			strSql.Append("s_RegAddress=@s_RegAddress,");
			strSql.Append("s_RegTel=@s_RegTel,");
			strSql.Append("s_InvoiceTo=@s_InvoiceTo");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_LastName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_FirstName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Initial", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Prefix", SqlDbType.NVarChar,30),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_IntroCode", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@s_JobTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Website", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IMAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Facebook", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Twitter", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_FirstCaseDate", SqlDbType.DateTime),
					new SqlParameter("@dt_LastCaseDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_Percent", SqlDbType.NVarChar,50),
					new SqlParameter("@n_PatentCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_TMCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_CopyrightCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_DomainCaseCount", SqlDbType.Int,4),
					new SqlParameter("@n_OtherCaseCount", SqlDbType.Int,4),
					new SqlParameter("@s_FirstAddress", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Addresses", SqlDbType.NVarChar,500),
					new SqlParameter("@s_AccountName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_BankName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AccountNo", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AccountCode", SqlDbType.NVarChar,40),
					new SqlParameter("@s_TaxCode", SqlDbType.NVarChar,100),
					new SqlParameter("@s_RegAddress", SqlDbType.NVarChar,400),
					new SqlParameter("@s_RegTel", SqlDbType.NVarChar,100),
					new SqlParameter("@s_InvoiceTo", SqlDbType.NVarChar,200),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_LastName;
			parameters[1].Value = model.s_FirstName;
			parameters[2].Value = model.s_Initial;
			parameters[3].Value = model.s_Prefix;
			parameters[4].Value = model.s_NativeName;
			parameters[5].Value = model.s_IntroCode;
			parameters[6].Value = model.s_Type;
			parameters[7].Value = model.s_JobTitle;
			parameters[8].Value = model.s_Phone;
			parameters[9].Value = model.s_Mobile;
			parameters[10].Value = model.s_Fax;
			parameters[11].Value = model.s_Email;
			parameters[12].Value = model.s_Website;
			parameters[13].Value = model.s_IMAddress;
			parameters[14].Value = model.s_Facebook;
			parameters[15].Value = model.s_Twitter;
			parameters[16].Value = model.s_Notes;
			parameters[17].Value = model.dt_FirstCaseDate;
			parameters[18].Value = model.dt_LastCaseDate;
			parameters[19].Value = model.dt_CreateDate;
			parameters[20].Value = model.dt_EditDate;
			parameters[21].Value = model.s_IPType;
			parameters[22].Value = model.s_Lock;
			parameters[23].Value = model.s_Locker;
			parameters[24].Value = model.s_Creator;
			parameters[25].Value = model.s_Editor;
			parameters[26].Value = model.n_Percent;
			parameters[27].Value = model.n_PatentCaseCount;
			parameters[28].Value = model.n_TMCaseCount;
			parameters[29].Value = model.n_CopyrightCaseCount;
			parameters[30].Value = model.n_DomainCaseCount;
			parameters[31].Value = model.n_OtherCaseCount;
			parameters[32].Value = model.s_FirstAddress;
			parameters[33].Value = model.s_Addresses;
			parameters[34].Value = model.s_AccountName;
			parameters[35].Value = model.s_BankName;
			parameters[36].Value = model.s_AccountNo;
			parameters[37].Value = model.s_AccountCode;
			parameters[38].Value = model.s_TaxCode;
			parameters[39].Value = model.s_RegAddress;
			parameters[40].Value = model.s_RegTel;
			parameters[41].Value = model.s_InvoiceTo;
			parameters[42].Value = model.n_ID;
			parameters[43].Value = model.n_SecurityLevelID;

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
		public bool Delete(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_Introducer ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

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
		public bool Delete(int n_SecurityLevelID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_Introducer ");
			strSql.Append(" where n_SecurityLevelID=@n_SecurityLevelID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_SecurityLevelID;
			parameters[1].Value = n_ID;

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
		public bool DeleteList(string n_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_Introducer ");
			strSql.Append(" where n_ID in ("+n_IDlist + ")  ");
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
		public IPSP.Model.TCstmr_Introducer GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_LastName,s_FirstName,s_Initial,s_Prefix,s_NativeName,s_IntroCode,s_Type,s_JobTitle,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,s_Notes,dt_FirstCaseDate,dt_LastCaseDate,dt_CreateDate,dt_EditDate,s_IPType,s_Lock,s_Locker,s_Creator,s_Editor,n_Percent,n_PatentCaseCount,n_TMCaseCount,n_CopyrightCaseCount,n_DomainCaseCount,n_OtherCaseCount,s_FirstAddress,s_Addresses,s_AccountName,s_BankName,s_AccountNo,s_AccountCode,s_TaxCode,s_RegAddress,s_RegTel,s_InvoiceTo,n_SecurityLevelID from TCstmr_Introducer ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCstmr_Introducer model=new IPSP.Model.TCstmr_Introducer();
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
		public IPSP.Model.TCstmr_Introducer DataRowToModel(DataRow row)
		{
			IPSP.Model.TCstmr_Introducer model=new IPSP.Model.TCstmr_Introducer();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_LastName"]!=null)
				{
					model.s_LastName=row["s_LastName"].ToString();
				}
				if(row["s_FirstName"]!=null)
				{
					model.s_FirstName=row["s_FirstName"].ToString();
				}
				if(row["s_Initial"]!=null)
				{
					model.s_Initial=row["s_Initial"].ToString();
				}
				if(row["s_Prefix"]!=null)
				{
					model.s_Prefix=row["s_Prefix"].ToString();
				}
				if(row["s_NativeName"]!=null)
				{
					model.s_NativeName=row["s_NativeName"].ToString();
				}
				if(row["s_IntroCode"]!=null)
				{
					model.s_IntroCode=row["s_IntroCode"].ToString();
				}
				if(row["s_Type"]!=null)
				{
					model.s_Type=row["s_Type"].ToString();
				}
				if(row["s_JobTitle"]!=null)
				{
					model.s_JobTitle=row["s_JobTitle"].ToString();
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
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["dt_FirstCaseDate"]!=null && row["dt_FirstCaseDate"].ToString()!="")
				{
					model.dt_FirstCaseDate=DateTime.Parse(row["dt_FirstCaseDate"].ToString());
				}
				if(row["dt_LastCaseDate"]!=null && row["dt_LastCaseDate"].ToString()!="")
				{
					model.dt_LastCaseDate=DateTime.Parse(row["dt_LastCaseDate"].ToString());
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
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
				if(row["n_Percent"]!=null)
				{
					model.n_Percent=row["n_Percent"].ToString();
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
				if(row["s_Addresses"]!=null)
				{
					model.s_Addresses=row["s_Addresses"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select n_ID,s_LastName,s_FirstName,s_Initial,s_Prefix,s_NativeName,s_IntroCode,s_Type,s_JobTitle,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,s_Notes,dt_FirstCaseDate,dt_LastCaseDate,dt_CreateDate,dt_EditDate,s_IPType,s_Lock,s_Locker,s_Creator,s_Editor,n_Percent,n_PatentCaseCount,n_TMCaseCount,n_CopyrightCaseCount,n_DomainCaseCount,n_OtherCaseCount,s_FirstAddress,s_Addresses,s_AccountName,s_BankName,s_AccountNo,s_AccountCode,s_TaxCode,s_RegAddress,s_RegTel,s_InvoiceTo,n_SecurityLevelID ");
			strSql.Append(" FROM TCstmr_Introducer ");
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
			strSql.Append(" n_ID,s_LastName,s_FirstName,s_Initial,s_Prefix,s_NativeName,s_IntroCode,s_Type,s_JobTitle,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,s_Notes,dt_FirstCaseDate,dt_LastCaseDate,dt_CreateDate,dt_EditDate,s_IPType,s_Lock,s_Locker,s_Creator,s_Editor,n_Percent,n_PatentCaseCount,n_TMCaseCount,n_CopyrightCaseCount,n_DomainCaseCount,n_OtherCaseCount,s_FirstAddress,s_Addresses,s_AccountName,s_BankName,s_AccountNo,s_AccountCode,s_TaxCode,s_RegAddress,s_RegTel,s_InvoiceTo,n_SecurityLevelID ");
			strSql.Append(" FROM TCstmr_Introducer ");
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
			strSql.Append("select count(1) FROM TCstmr_Introducer ");
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
				strSql.Append("order by T.n_ID desc");
			}
			strSql.Append(")AS Row, T.*  from TCstmr_Introducer T ");
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
			parameters[0].Value = "TCstmr_Introducer";
			parameters[1].Value = "n_ID";
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

