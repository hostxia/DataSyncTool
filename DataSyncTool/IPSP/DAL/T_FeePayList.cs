/**  版本信息模板在安装目录下，可自行修改。
* T_FeePayList.cs
*
* 功 能： N/A
* 类 名： T_FeePayList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:46   N/A    初版
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
	/// 数据访问类:T_FeePayList
	/// </summary>
	public partial class T_FeePayList
	{
		public T_FeePayList()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_PayListID", "T_FeePayList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_PayListID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_FeePayList");
			strSql.Append(" where n_PayListID=@n_PayListID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_PayListID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_PayListID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_FeePayList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_FeePayList(");
			strSql.Append("s_FilePath,s_Notes,s_ListType,dt_CreateDate,dt_EditDate)");
			strSql.Append(" values (");
			strSql.Append("@s_FilePath,@s_Notes,@s_ListType,@dt_CreateDate,@dt_EditDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_ListType", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime)};
			parameters[0].Value = model.s_FilePath;
			parameters[1].Value = model.s_Notes;
			parameters[2].Value = model.s_ListType;
			parameters[3].Value = model.dt_CreateDate;
			parameters[4].Value = model.dt_EditDate;

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
		public bool Update(IPSP.Model.T_FeePayList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_FeePayList set ");
			strSql.Append("s_FilePath=@s_FilePath,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("s_ListType=@s_ListType,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate");
			strSql.Append(" where n_PayListID=@n_PayListID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_ListType", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_PayListID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_FilePath;
			parameters[1].Value = model.s_Notes;
			parameters[2].Value = model.s_ListType;
			parameters[3].Value = model.dt_CreateDate;
			parameters[4].Value = model.dt_EditDate;
			parameters[5].Value = model.n_PayListID;

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
		public bool Delete(int n_PayListID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_FeePayList ");
			strSql.Append(" where n_PayListID=@n_PayListID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_PayListID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_PayListID;

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
		public bool DeleteList(string n_PayListIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_FeePayList ");
			strSql.Append(" where n_PayListID in ("+n_PayListIDlist + ")  ");
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
		public IPSP.Model.T_FeePayList GetModel(int n_PayListID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_PayListID,s_FilePath,s_Notes,s_ListType,dt_CreateDate,dt_EditDate from T_FeePayList ");
			strSql.Append(" where n_PayListID=@n_PayListID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_PayListID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_PayListID;

			IPSP.Model.T_FeePayList model=new IPSP.Model.T_FeePayList();
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
		public IPSP.Model.T_FeePayList DataRowToModel(DataRow row)
		{
			IPSP.Model.T_FeePayList model=new IPSP.Model.T_FeePayList();
			if (row != null)
			{
				if(row["n_PayListID"]!=null && row["n_PayListID"].ToString()!="")
				{
					model.n_PayListID=int.Parse(row["n_PayListID"].ToString());
				}
				if(row["s_FilePath"]!=null)
				{
					model.s_FilePath=row["s_FilePath"].ToString();
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["s_ListType"]!=null)
				{
					model.s_ListType=row["s_ListType"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
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
			strSql.Append("select n_PayListID,s_FilePath,s_Notes,s_ListType,dt_CreateDate,dt_EditDate ");
			strSql.Append(" FROM T_FeePayList ");
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
			strSql.Append(" n_PayListID,s_FilePath,s_Notes,s_ListType,dt_CreateDate,dt_EditDate ");
			strSql.Append(" FROM T_FeePayList ");
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
			strSql.Append("select count(1) FROM T_FeePayList ");
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
				strSql.Append("order by T.n_PayListID desc");
			}
			strSql.Append(")AS Row, T.*  from T_FeePayList T ");
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
			parameters[0].Value = "T_FeePayList";
			parameters[1].Value = "n_PayListID";
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

