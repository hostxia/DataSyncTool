/**  版本信息模板在安装目录下，可自行修改。
* T_SubmtFileList.cs
*
* 功 能： N/A
* 类 名： T_SubmtFileList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:05   N/A    初版
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
	/// 数据访问类:T_SubmtFileList
	/// </summary>
	public partial class T_SubmtFileList
	{
		public T_SubmtFileList()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal n_FileListID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_SubmtFileList");
			strSql.Append(" where n_FileListID=@n_FileListID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileListID", SqlDbType.Decimal)
			};
			parameters[0].Value = n_FileListID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(IPSP.Model.T_SubmtFileList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_SubmtFileList(");
			strSql.Append("s_FilePath,dt_FileListDate,dt_CreateDate,dt_EditDate,s_Note)");
			strSql.Append(" values (");
			strSql.Append("@s_FilePath,@dt_FileListDate,@dt_CreateDate,@dt_EditDate,@s_Note)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_FileListDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,300)};
			parameters[0].Value = model.s_FilePath;
			parameters[1].Value = model.dt_FileListDate;
			parameters[2].Value = model.dt_CreateDate;
			parameters[3].Value = model.dt_EditDate;
			parameters[4].Value = model.s_Note;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToDecimal(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(IPSP.Model.T_SubmtFileList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_SubmtFileList set ");
			strSql.Append("s_FilePath=@s_FilePath,");
			strSql.Append("dt_FileListDate=@dt_FileListDate,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_Note=@s_Note");
			strSql.Append(" where n_FileListID=@n_FileListID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_FileListDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,300),
					new SqlParameter("@n_FileListID", SqlDbType.Decimal,9)};
			parameters[0].Value = model.s_FilePath;
			parameters[1].Value = model.dt_FileListDate;
			parameters[2].Value = model.dt_CreateDate;
			parameters[3].Value = model.dt_EditDate;
			parameters[4].Value = model.s_Note;
			parameters[5].Value = model.n_FileListID;

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
		public bool Delete(decimal n_FileListID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_SubmtFileList ");
			strSql.Append(" where n_FileListID=@n_FileListID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileListID", SqlDbType.Decimal)
			};
			parameters[0].Value = n_FileListID;

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
		public bool DeleteList(string n_FileListIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_SubmtFileList ");
			strSql.Append(" where n_FileListID in ("+n_FileListIDlist + ")  ");
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
		public IPSP.Model.T_SubmtFileList GetModel(decimal n_FileListID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_FileListID,s_FilePath,dt_FileListDate,dt_CreateDate,dt_EditDate,s_Note from T_SubmtFileList ");
			strSql.Append(" where n_FileListID=@n_FileListID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileListID", SqlDbType.Decimal)
			};
			parameters[0].Value = n_FileListID;

			IPSP.Model.T_SubmtFileList model=new IPSP.Model.T_SubmtFileList();
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
		public IPSP.Model.T_SubmtFileList DataRowToModel(DataRow row)
		{
			IPSP.Model.T_SubmtFileList model=new IPSP.Model.T_SubmtFileList();
			if (row != null)
			{
				if(row["n_FileListID"]!=null && row["n_FileListID"].ToString()!="")
				{
					model.n_FileListID=decimal.Parse(row["n_FileListID"].ToString());
				}
				if(row["s_FilePath"]!=null)
				{
					model.s_FilePath=row["s_FilePath"].ToString();
				}
				if(row["dt_FileListDate"]!=null && row["dt_FileListDate"].ToString()!="")
				{
					model.dt_FileListDate=DateTime.Parse(row["dt_FileListDate"].ToString());
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
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
			strSql.Append("select n_FileListID,s_FilePath,dt_FileListDate,dt_CreateDate,dt_EditDate,s_Note ");
			strSql.Append(" FROM T_SubmtFileList ");
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
			strSql.Append(" n_FileListID,s_FilePath,dt_FileListDate,dt_CreateDate,dt_EditDate,s_Note ");
			strSql.Append(" FROM T_SubmtFileList ");
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
			strSql.Append("select count(1) FROM T_SubmtFileList ");
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
				strSql.Append("order by T.n_FileListID desc");
			}
			strSql.Append(")AS Row, T.*  from T_SubmtFileList T ");
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
			parameters[0].Value = "T_SubmtFileList";
			parameters[1].Value = "n_FileListID";
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

