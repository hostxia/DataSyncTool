/**  版本信息模板在安装目录下，可自行修改。
* T_OtherFiles.cs
*
* 功 能： N/A
* 类 名： T_OtherFiles
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:57   N/A    初版
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
	/// 数据访问类:T_OtherFiles
	/// </summary>
	public partial class T_OtherFiles
	{
		public T_OtherFiles()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_FileID", "T_OtherFiles"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_FileID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_OtherFiles");
			strSql.Append(" where n_FileID=@n_FileID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.T_OtherFiles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_OtherFiles(");
			strSql.Append("n_FileID,s_Version,s_CheckedOut,n_CheckedOutBy,s_CheckedOutPath,s_FileStatus)");
			strSql.Append(" values (");
			strSql.Append("@n_FileID,@s_Version,@s_CheckedOut,@n_CheckedOutBy,@s_CheckedOutPath,@s_FileStatus)");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@s_Version", SqlDbType.NVarChar,20),
					new SqlParameter("@s_CheckedOut", SqlDbType.NVarChar,1),
					new SqlParameter("@n_CheckedOutBy", SqlDbType.Int,4),
					new SqlParameter("@s_CheckedOutPath", SqlDbType.NVarChar,500),
					new SqlParameter("@s_FileStatus", SqlDbType.NVarChar,1)};
			parameters[0].Value = model.n_FileID;
			parameters[1].Value = model.s_Version;
			parameters[2].Value = model.s_CheckedOut;
			parameters[3].Value = model.n_CheckedOutBy;
			parameters[4].Value = model.s_CheckedOutPath;
			parameters[5].Value = model.s_FileStatus;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(IPSP.Model.T_OtherFiles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_OtherFiles set ");
			strSql.Append("s_Version=@s_Version,");
			strSql.Append("s_CheckedOut=@s_CheckedOut,");
			strSql.Append("n_CheckedOutBy=@n_CheckedOutBy,");
			strSql.Append("s_CheckedOutPath=@s_CheckedOutPath,");
			strSql.Append("s_FileStatus=@s_FileStatus");
			strSql.Append(" where n_FileID=@n_FileID ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Version", SqlDbType.NVarChar,20),
					new SqlParameter("@s_CheckedOut", SqlDbType.NVarChar,1),
					new SqlParameter("@n_CheckedOutBy", SqlDbType.Int,4),
					new SqlParameter("@s_CheckedOutPath", SqlDbType.NVarChar,500),
					new SqlParameter("@s_FileStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@n_FileID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Version;
			parameters[1].Value = model.s_CheckedOut;
			parameters[2].Value = model.n_CheckedOutBy;
			parameters[3].Value = model.s_CheckedOutPath;
			parameters[4].Value = model.s_FileStatus;
			parameters[5].Value = model.n_FileID;

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
		public bool Delete(int n_FileID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_OtherFiles ");
			strSql.Append(" where n_FileID=@n_FileID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;

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
		public bool DeleteList(string n_FileIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_OtherFiles ");
			strSql.Append(" where n_FileID in ("+n_FileIDlist + ")  ");
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
		public IPSP.Model.T_OtherFiles GetModel(int n_FileID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_FileID,s_Version,s_CheckedOut,n_CheckedOutBy,s_CheckedOutPath,s_FileStatus from T_OtherFiles ");
			strSql.Append(" where n_FileID=@n_FileID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;

			IPSP.Model.T_OtherFiles model=new IPSP.Model.T_OtherFiles();
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
		public IPSP.Model.T_OtherFiles DataRowToModel(DataRow row)
		{
			IPSP.Model.T_OtherFiles model=new IPSP.Model.T_OtherFiles();
			if (row != null)
			{
				if(row["n_FileID"]!=null && row["n_FileID"].ToString()!="")
				{
					model.n_FileID=int.Parse(row["n_FileID"].ToString());
				}
				if(row["s_Version"]!=null)
				{
					model.s_Version=row["s_Version"].ToString();
				}
				if(row["s_CheckedOut"]!=null)
				{
					model.s_CheckedOut=row["s_CheckedOut"].ToString();
				}
				if(row["n_CheckedOutBy"]!=null && row["n_CheckedOutBy"].ToString()!="")
				{
					model.n_CheckedOutBy=int.Parse(row["n_CheckedOutBy"].ToString());
				}
				if(row["s_CheckedOutPath"]!=null)
				{
					model.s_CheckedOutPath=row["s_CheckedOutPath"].ToString();
				}
				if(row["s_FileStatus"]!=null)
				{
					model.s_FileStatus=row["s_FileStatus"].ToString();
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
			strSql.Append("select n_FileID,s_Version,s_CheckedOut,n_CheckedOutBy,s_CheckedOutPath,s_FileStatus ");
			strSql.Append(" FROM T_OtherFiles ");
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
			strSql.Append(" n_FileID,s_Version,s_CheckedOut,n_CheckedOutBy,s_CheckedOutPath,s_FileStatus ");
			strSql.Append(" FROM T_OtherFiles ");
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
			strSql.Append("select count(1) FROM T_OtherFiles ");
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
				strSql.Append("order by T.n_FileID desc");
			}
			strSql.Append(")AS Row, T.*  from T_OtherFiles T ");
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
			parameters[0].Value = "T_OtherFiles";
			parameters[1].Value = "n_FileID";
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

