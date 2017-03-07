/**  版本信息模板在安装目录下，可自行修改。
* T_Right.cs
*
* 功 能： N/A
* 类 名： T_Right
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:00   N/A    初版
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
	/// 数据访问类:T_Right
	/// </summary>
	public partial class T_Right
	{
		public T_Right()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_RightID", "T_Right"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_RightID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Right");
			strSql.Append(" where n_RightID=@n_RightID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_RightID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_RightID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_Right model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Right(");
			strSql.Append("s_RightName,n_ParentID,s_Description,s_CodeName,s_FromModule)");
			strSql.Append(" values (");
			strSql.Append("@s_RightName,@n_ParentID,@s_Description,@s_CodeName,@s_FromModule)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_RightName", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ParentID", SqlDbType.Int,4),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CodeName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_FromModule", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.s_RightName;
			parameters[1].Value = model.n_ParentID;
			parameters[2].Value = model.s_Description;
			parameters[3].Value = model.s_CodeName;
			parameters[4].Value = model.s_FromModule;

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
		public bool Update(IPSP.Model.T_Right model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Right set ");
			strSql.Append("s_RightName=@s_RightName,");
			strSql.Append("n_ParentID=@n_ParentID,");
			strSql.Append("s_Description=@s_Description,");
			strSql.Append("s_CodeName=@s_CodeName,");
			strSql.Append("s_FromModule=@s_FromModule");
			strSql.Append(" where n_RightID=@n_RightID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_RightName", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ParentID", SqlDbType.Int,4),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CodeName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_FromModule", SqlDbType.NVarChar,100),
					new SqlParameter("@n_RightID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_RightName;
			parameters[1].Value = model.n_ParentID;
			parameters[2].Value = model.s_Description;
			parameters[3].Value = model.s_CodeName;
			parameters[4].Value = model.s_FromModule;
			parameters[5].Value = model.n_RightID;

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
		public bool Delete(int n_RightID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Right ");
			strSql.Append(" where n_RightID=@n_RightID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_RightID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_RightID;

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
		public bool DeleteList(string n_RightIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Right ");
			strSql.Append(" where n_RightID in ("+n_RightIDlist + ")  ");
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
		public IPSP.Model.T_Right GetModel(int n_RightID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_RightID,s_RightName,n_ParentID,s_Description,s_CodeName,s_FromModule from T_Right ");
			strSql.Append(" where n_RightID=@n_RightID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_RightID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_RightID;

			IPSP.Model.T_Right model=new IPSP.Model.T_Right();
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
		public IPSP.Model.T_Right DataRowToModel(DataRow row)
		{
			IPSP.Model.T_Right model=new IPSP.Model.T_Right();
			if (row != null)
			{
				if(row["n_RightID"]!=null && row["n_RightID"].ToString()!="")
				{
					model.n_RightID=int.Parse(row["n_RightID"].ToString());
				}
				if(row["s_RightName"]!=null)
				{
					model.s_RightName=row["s_RightName"].ToString();
				}
				if(row["n_ParentID"]!=null && row["n_ParentID"].ToString()!="")
				{
					model.n_ParentID=int.Parse(row["n_ParentID"].ToString());
				}
				if(row["s_Description"]!=null)
				{
					model.s_Description=row["s_Description"].ToString();
				}
				if(row["s_CodeName"]!=null)
				{
					model.s_CodeName=row["s_CodeName"].ToString();
				}
				if(row["s_FromModule"]!=null)
				{
					model.s_FromModule=row["s_FromModule"].ToString();
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
			strSql.Append("select n_RightID,s_RightName,n_ParentID,s_Description,s_CodeName,s_FromModule ");
			strSql.Append(" FROM T_Right ");
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
			strSql.Append(" n_RightID,s_RightName,n_ParentID,s_Description,s_CodeName,s_FromModule ");
			strSql.Append(" FROM T_Right ");
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
			strSql.Append("select count(1) FROM T_Right ");
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
				strSql.Append("order by T.n_RightID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Right T ");
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
			parameters[0].Value = "T_Right";
			parameters[1].Value = "n_RightID";
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

