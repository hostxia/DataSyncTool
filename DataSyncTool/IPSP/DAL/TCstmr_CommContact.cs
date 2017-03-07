/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_CommContact.cs
*
* 功 能： N/A
* 类 名： TCstmr_CommContact
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:52   N/A    初版
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
	/// 数据访问类:TCstmr_CommContact
	/// </summary>
	public partial class TCstmr_CommContact
	{
		public TCstmr_CommContact()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ContactID", "TCstmr_CommContact"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ContactID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCstmr_CommContact");
			strSql.Append(" where n_ContactID=@n_ContactID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ContactID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ContactID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCstmr_CommContact model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCstmr_CommContact(");
			strSql.Append("s_Name,n_CountryID,s_Province,s_City,s_Tel,s_Fax,s_Email,s_WebSite,s_ZipCode,s_Addr,s_Note,s_Public,dt_CreateDate,s_Creator,dt_EditDate,s_Editor,s_Lock,s_Locker)");
			strSql.Append(" values (");
			strSql.Append("@s_Name,@n_CountryID,@s_Province,@s_City,@s_Tel,@s_Fax,@s_Email,@s_WebSite,@s_ZipCode,@s_Addr,@s_Note,@s_Public,@dt_CreateDate,@s_Creator,@dt_EditDate,@s_Editor,@s_Lock,@s_Locker)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@n_CountryID", SqlDbType.Int,4),
					new SqlParameter("@s_Province", SqlDbType.NVarChar,50),
					new SqlParameter("@s_City", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Tel", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_WebSite", SqlDbType.NVarChar,300),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Addr", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Public", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.n_CountryID;
			parameters[2].Value = model.s_Province;
			parameters[3].Value = model.s_City;
			parameters[4].Value = model.s_Tel;
			parameters[5].Value = model.s_Fax;
			parameters[6].Value = model.s_Email;
			parameters[7].Value = model.s_WebSite;
			parameters[8].Value = model.s_ZipCode;
			parameters[9].Value = model.s_Addr;
			parameters[10].Value = model.s_Note;
			parameters[11].Value = model.s_Public;
			parameters[12].Value = model.dt_CreateDate;
			parameters[13].Value = model.s_Creator;
			parameters[14].Value = model.dt_EditDate;
			parameters[15].Value = model.s_Editor;
			parameters[16].Value = model.s_Lock;
			parameters[17].Value = model.s_Locker;

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
		public bool Update(IPSP.Model.TCstmr_CommContact model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCstmr_CommContact set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("n_CountryID=@n_CountryID,");
			strSql.Append("s_Province=@s_Province,");
			strSql.Append("s_City=@s_City,");
			strSql.Append("s_Tel=@s_Tel,");
			strSql.Append("s_Fax=@s_Fax,");
			strSql.Append("s_Email=@s_Email,");
			strSql.Append("s_WebSite=@s_WebSite,");
			strSql.Append("s_ZipCode=@s_ZipCode,");
			strSql.Append("s_Addr=@s_Addr,");
			strSql.Append("s_Note=@s_Note,");
			strSql.Append("s_Public=@s_Public,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("s_Lock=@s_Lock,");
			strSql.Append("s_Locker=@s_Locker");
			strSql.Append(" where n_ContactID=@n_ContactID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@n_CountryID", SqlDbType.Int,4),
					new SqlParameter("@s_Province", SqlDbType.NVarChar,50),
					new SqlParameter("@s_City", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Tel", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_WebSite", SqlDbType.NVarChar,300),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Addr", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Public", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ContactID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.n_CountryID;
			parameters[2].Value = model.s_Province;
			parameters[3].Value = model.s_City;
			parameters[4].Value = model.s_Tel;
			parameters[5].Value = model.s_Fax;
			parameters[6].Value = model.s_Email;
			parameters[7].Value = model.s_WebSite;
			parameters[8].Value = model.s_ZipCode;
			parameters[9].Value = model.s_Addr;
			parameters[10].Value = model.s_Note;
			parameters[11].Value = model.s_Public;
			parameters[12].Value = model.dt_CreateDate;
			parameters[13].Value = model.s_Creator;
			parameters[14].Value = model.dt_EditDate;
			parameters[15].Value = model.s_Editor;
			parameters[16].Value = model.s_Lock;
			parameters[17].Value = model.s_Locker;
			parameters[18].Value = model.n_ContactID;

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
			strSql.Append("delete from TCstmr_CommContact ");
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string n_ContactIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_CommContact ");
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
		public IPSP.Model.TCstmr_CommContact GetModel(int n_ContactID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ContactID,s_Name,n_CountryID,s_Province,s_City,s_Tel,s_Fax,s_Email,s_WebSite,s_ZipCode,s_Addr,s_Note,s_Public,dt_CreateDate,s_Creator,dt_EditDate,s_Editor,s_Lock,s_Locker from TCstmr_CommContact ");
			strSql.Append(" where n_ContactID=@n_ContactID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ContactID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ContactID;

			IPSP.Model.TCstmr_CommContact model=new IPSP.Model.TCstmr_CommContact();
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
		public IPSP.Model.TCstmr_CommContact DataRowToModel(DataRow row)
		{
			IPSP.Model.TCstmr_CommContact model=new IPSP.Model.TCstmr_CommContact();
			if (row != null)
			{
				if(row["n_ContactID"]!=null && row["n_ContactID"].ToString()!="")
				{
					model.n_ContactID=int.Parse(row["n_ContactID"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["n_CountryID"]!=null && row["n_CountryID"].ToString()!="")
				{
					model.n_CountryID=int.Parse(row["n_CountryID"].ToString());
				}
				if(row["s_Province"]!=null)
				{
					model.s_Province=row["s_Province"].ToString();
				}
				if(row["s_City"]!=null)
				{
					model.s_City=row["s_City"].ToString();
				}
				if(row["s_Tel"]!=null)
				{
					model.s_Tel=row["s_Tel"].ToString();
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
				if(row["s_ZipCode"]!=null)
				{
					model.s_ZipCode=row["s_ZipCode"].ToString();
				}
				if(row["s_Addr"]!=null)
				{
					model.s_Addr=row["s_Addr"].ToString();
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
				}
				if(row["s_Public"]!=null)
				{
					model.s_Public=row["s_Public"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["s_Lock"]!=null)
				{
					model.s_Lock=row["s_Lock"].ToString();
				}
				if(row["s_Locker"]!=null)
				{
					model.s_Locker=row["s_Locker"].ToString();
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
			strSql.Append("select n_ContactID,s_Name,n_CountryID,s_Province,s_City,s_Tel,s_Fax,s_Email,s_WebSite,s_ZipCode,s_Addr,s_Note,s_Public,dt_CreateDate,s_Creator,dt_EditDate,s_Editor,s_Lock,s_Locker ");
			strSql.Append(" FROM TCstmr_CommContact ");
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
			strSql.Append(" n_ContactID,s_Name,n_CountryID,s_Province,s_City,s_Tel,s_Fax,s_Email,s_WebSite,s_ZipCode,s_Addr,s_Note,s_Public,dt_CreateDate,s_Creator,dt_EditDate,s_Editor,s_Lock,s_Locker ");
			strSql.Append(" FROM TCstmr_CommContact ");
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
			strSql.Append("select count(1) FROM TCstmr_CommContact ");
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
			strSql.Append(")AS Row, T.*  from TCstmr_CommContact T ");
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
			parameters[0].Value = "TCstmr_CommContact";
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

