/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_IntroContact.cs
*
* 功 能： N/A
* 类 名： TCstmr_IntroContact
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:00   N/A    初版
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
	/// 数据访问类:TCstmr_IntroContact
	/// </summary>
	public partial class TCstmr_IntroContact
	{
		public TCstmr_IntroContact()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_IntroID", "TCstmr_IntroContact"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_IntroID,int n_ContactID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCstmr_IntroContact");
			strSql.Append(" where n_IntroID=@n_IntroID and n_ContactID=@n_ContactID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_IntroID", SqlDbType.Int,4),
					new SqlParameter("@n_ContactID", SqlDbType.Int,4)			};
			parameters[0].Value = n_IntroID;
			parameters[1].Value = n_ContactID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCstmr_IntroContact model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCstmr_IntroContact(");
			strSql.Append("n_IntroID,s_FirstName,s_LastName,s_NativeName,s_OtherName,s_IPType,n_Language,s_JobTitle,s_Prefix,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,s_PreferContact,s_Notes,n_Sequence,dt_CreateDate,dt_EditDate,s_IPRole,s_Identity)");
			strSql.Append(" values (");
			strSql.Append("@n_IntroID,@s_FirstName,@s_LastName,@s_NativeName,@s_OtherName,@s_IPType,@n_Language,@s_JobTitle,@s_Prefix,@s_Phone,@s_Mobile,@s_Fax,@s_Email,@s_Website,@s_IMAddress,@s_Facebook,@s_Twitter,@s_PreferContact,@s_Notes,@n_Sequence,@dt_CreateDate,@dt_EditDate,@s_IPRole,@s_Identity)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_IntroID", SqlDbType.Int,4),
					new SqlParameter("@s_FirstName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_LastName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_Language", SqlDbType.Int,4),
					new SqlParameter("@s_JobTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Prefix", SqlDbType.NVarChar,30),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Website", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IMAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Facebook", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Twitter", SqlDbType.NVarChar,200),
					new SqlParameter("@s_PreferContact", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IPRole", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Identity", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.n_IntroID;
			parameters[1].Value = model.s_FirstName;
			parameters[2].Value = model.s_LastName;
			parameters[3].Value = model.s_NativeName;
			parameters[4].Value = model.s_OtherName;
			parameters[5].Value = model.s_IPType;
			parameters[6].Value = model.n_Language;
			parameters[7].Value = model.s_JobTitle;
			parameters[8].Value = model.s_Prefix;
			parameters[9].Value = model.s_Phone;
			parameters[10].Value = model.s_Mobile;
			parameters[11].Value = model.s_Fax;
			parameters[12].Value = model.s_Email;
			parameters[13].Value = model.s_Website;
			parameters[14].Value = model.s_IMAddress;
			parameters[15].Value = model.s_Facebook;
			parameters[16].Value = model.s_Twitter;
			parameters[17].Value = model.s_PreferContact;
			parameters[18].Value = model.s_Notes;
			parameters[19].Value = model.n_Sequence;
			parameters[20].Value = model.dt_CreateDate;
			parameters[21].Value = model.dt_EditDate;
			parameters[22].Value = model.s_IPRole;
			parameters[23].Value = model.s_Identity;

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
		public bool Update(IPSP.Model.TCstmr_IntroContact model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCstmr_IntroContact set ");
			strSql.Append("s_FirstName=@s_FirstName,");
			strSql.Append("s_LastName=@s_LastName,");
			strSql.Append("s_NativeName=@s_NativeName,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("n_Language=@n_Language,");
			strSql.Append("s_JobTitle=@s_JobTitle,");
			strSql.Append("s_Prefix=@s_Prefix,");
			strSql.Append("s_Phone=@s_Phone,");
			strSql.Append("s_Mobile=@s_Mobile,");
			strSql.Append("s_Fax=@s_Fax,");
			strSql.Append("s_Email=@s_Email,");
			strSql.Append("s_Website=@s_Website,");
			strSql.Append("s_IMAddress=@s_IMAddress,");
			strSql.Append("s_Facebook=@s_Facebook,");
			strSql.Append("s_Twitter=@s_Twitter,");
			strSql.Append("s_PreferContact=@s_PreferContact,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("n_Sequence=@n_Sequence,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_IPRole=@s_IPRole,");
			strSql.Append("s_Identity=@s_Identity");
			strSql.Append(" where n_ContactID=@n_ContactID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_FirstName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_LastName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_Language", SqlDbType.Int,4),
					new SqlParameter("@s_JobTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Prefix", SqlDbType.NVarChar,30),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Website", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IMAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Facebook", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Twitter", SqlDbType.NVarChar,200),
					new SqlParameter("@s_PreferContact", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IPRole", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Identity", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ContactID", SqlDbType.Int,4),
					new SqlParameter("@n_IntroID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_FirstName;
			parameters[1].Value = model.s_LastName;
			parameters[2].Value = model.s_NativeName;
			parameters[3].Value = model.s_OtherName;
			parameters[4].Value = model.s_IPType;
			parameters[5].Value = model.n_Language;
			parameters[6].Value = model.s_JobTitle;
			parameters[7].Value = model.s_Prefix;
			parameters[8].Value = model.s_Phone;
			parameters[9].Value = model.s_Mobile;
			parameters[10].Value = model.s_Fax;
			parameters[11].Value = model.s_Email;
			parameters[12].Value = model.s_Website;
			parameters[13].Value = model.s_IMAddress;
			parameters[14].Value = model.s_Facebook;
			parameters[15].Value = model.s_Twitter;
			parameters[16].Value = model.s_PreferContact;
			parameters[17].Value = model.s_Notes;
			parameters[18].Value = model.n_Sequence;
			parameters[19].Value = model.dt_CreateDate;
			parameters[20].Value = model.dt_EditDate;
			parameters[21].Value = model.s_IPRole;
			parameters[22].Value = model.s_Identity;
			parameters[23].Value = model.n_ContactID;
			parameters[24].Value = model.n_IntroID;

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
		public bool Delete(int n_ContactID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_IntroContact ");
			strSql.Append(" where n_ContactID=@n_ContactID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ContactID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ContactID;

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
		public bool Delete(int n_IntroID,int n_ContactID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_IntroContact ");
			strSql.Append(" where n_IntroID=@n_IntroID and n_ContactID=@n_ContactID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_IntroID", SqlDbType.Int,4),
					new SqlParameter("@n_ContactID", SqlDbType.Int,4)			};
			parameters[0].Value = n_IntroID;
			parameters[1].Value = n_ContactID;

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
		public bool DeleteList(string n_ContactIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_IntroContact ");
			strSql.Append(" where n_ContactID in ("+n_ContactIDlist + ")  ");
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
		public IPSP.Model.TCstmr_IntroContact GetModel(int n_ContactID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ContactID,n_IntroID,s_FirstName,s_LastName,s_NativeName,s_OtherName,s_IPType,n_Language,s_JobTitle,s_Prefix,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,s_PreferContact,s_Notes,n_Sequence,dt_CreateDate,dt_EditDate,s_IPRole,s_Identity from TCstmr_IntroContact ");
			strSql.Append(" where n_ContactID=@n_ContactID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ContactID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ContactID;

			IPSP.Model.TCstmr_IntroContact model=new IPSP.Model.TCstmr_IntroContact();
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
		public IPSP.Model.TCstmr_IntroContact DataRowToModel(DataRow row)
		{
			IPSP.Model.TCstmr_IntroContact model=new IPSP.Model.TCstmr_IntroContact();
			if (row != null)
			{
				if(row["n_ContactID"]!=null && row["n_ContactID"].ToString()!="")
				{
					model.n_ContactID=int.Parse(row["n_ContactID"].ToString());
				}
				if(row["n_IntroID"]!=null && row["n_IntroID"].ToString()!="")
				{
					model.n_IntroID=int.Parse(row["n_IntroID"].ToString());
				}
				if(row["s_FirstName"]!=null)
				{
					model.s_FirstName=row["s_FirstName"].ToString();
				}
				if(row["s_LastName"]!=null)
				{
					model.s_LastName=row["s_LastName"].ToString();
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
				if(row["n_Language"]!=null && row["n_Language"].ToString()!="")
				{
					model.n_Language=int.Parse(row["n_Language"].ToString());
				}
				if(row["s_JobTitle"]!=null)
				{
					model.s_JobTitle=row["s_JobTitle"].ToString();
				}
				if(row["s_Prefix"]!=null)
				{
					model.s_Prefix=row["s_Prefix"].ToString();
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
				if(row["s_PreferContact"]!=null)
				{
					model.s_PreferContact=row["s_PreferContact"].ToString();
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["n_Sequence"]!=null && row["n_Sequence"].ToString()!="")
				{
					model.n_Sequence=int.Parse(row["n_Sequence"].ToString());
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_IPRole"]!=null)
				{
					model.s_IPRole=row["s_IPRole"].ToString();
				}
				if(row["s_Identity"]!=null)
				{
					model.s_Identity=row["s_Identity"].ToString();
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
			strSql.Append("select n_ContactID,n_IntroID,s_FirstName,s_LastName,s_NativeName,s_OtherName,s_IPType,n_Language,s_JobTitle,s_Prefix,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,s_PreferContact,s_Notes,n_Sequence,dt_CreateDate,dt_EditDate,s_IPRole,s_Identity ");
			strSql.Append(" FROM TCstmr_IntroContact ");
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
			strSql.Append(" n_ContactID,n_IntroID,s_FirstName,s_LastName,s_NativeName,s_OtherName,s_IPType,n_Language,s_JobTitle,s_Prefix,s_Phone,s_Mobile,s_Fax,s_Email,s_Website,s_IMAddress,s_Facebook,s_Twitter,s_PreferContact,s_Notes,n_Sequence,dt_CreateDate,dt_EditDate,s_IPRole,s_Identity ");
			strSql.Append(" FROM TCstmr_IntroContact ");
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
			strSql.Append("select count(1) FROM TCstmr_IntroContact ");
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
				strSql.Append("order by T.n_ContactID desc");
			}
			strSql.Append(")AS Row, T.*  from TCstmr_IntroContact T ");
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
			parameters[0].Value = "TCstmr_IntroContact";
			parameters[1].Value = "n_ContactID";
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

