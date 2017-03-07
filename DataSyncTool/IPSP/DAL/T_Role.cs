/**  版本信息模板在安装目录下，可自行修改。
* T_Role.cs
*
* 功 能： N/A
* 类 名： T_Role
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:01   N/A    初版
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
	/// 数据访问类:T_Role
	/// </summary>
	public partial class T_Role
	{
		public T_Role()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_RoleID", "T_Role"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_RoleID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Role");
			strSql.Append(" where n_RoleID=@n_RoleID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_RoleID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_RoleID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_Role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Role(");
			strSql.Append("s_RoleName,s_Notes,s_RoleCode)");
			strSql.Append(" values (");
			strSql.Append("@s_RoleName,@s_Notes,@s_RoleCode)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_RoleName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,500),
					new SqlParameter("@s_RoleCode", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.s_RoleName;
			parameters[1].Value = model.s_Notes;
			parameters[2].Value = model.s_RoleCode;

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
		public bool Update(IPSP.Model.T_Role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Role set ");
			strSql.Append("s_RoleName=@s_RoleName,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("s_RoleCode=@s_RoleCode");
			strSql.Append(" where n_RoleID=@n_RoleID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_RoleName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,500),
					new SqlParameter("@s_RoleCode", SqlDbType.NVarChar,50),
					new SqlParameter("@n_RoleID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_RoleName;
			parameters[1].Value = model.s_Notes;
			parameters[2].Value = model.s_RoleCode;
			parameters[3].Value = model.n_RoleID;

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
		public bool Delete(int n_RoleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Role ");
			strSql.Append(" where n_RoleID=@n_RoleID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_RoleID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_RoleID;

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
		public bool DeleteList(string n_RoleIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Role ");
			strSql.Append(" where n_RoleID in ("+n_RoleIDlist + ")  ");
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
		public IPSP.Model.T_Role GetModel(int n_RoleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_RoleID,s_RoleName,s_Notes,s_RoleCode from T_Role ");
			strSql.Append(" where n_RoleID=@n_RoleID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_RoleID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_RoleID;

			IPSP.Model.T_Role model=new IPSP.Model.T_Role();
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
		public IPSP.Model.T_Role DataRowToModel(DataRow row)
		{
			IPSP.Model.T_Role model=new IPSP.Model.T_Role();
			if (row != null)
			{
				if(row["n_RoleID"]!=null && row["n_RoleID"].ToString()!="")
				{
					model.n_RoleID=int.Parse(row["n_RoleID"].ToString());
				}
				if(row["s_RoleName"]!=null)
				{
					model.s_RoleName=row["s_RoleName"].ToString();
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["s_RoleCode"]!=null)
				{
					model.s_RoleCode=row["s_RoleCode"].ToString();
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
			strSql.Append("select n_RoleID,s_RoleName,s_Notes,s_RoleCode ");
			strSql.Append(" FROM T_Role ");
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
			strSql.Append(" n_RoleID,s_RoleName,s_Notes,s_RoleCode ");
			strSql.Append(" FROM T_Role ");
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
			strSql.Append("select count(1) FROM T_Role ");
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
				strSql.Append("order by T.n_RoleID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Role T ");
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
			parameters[0].Value = "T_Role";
			parameters[1].Value = "n_RoleID";
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

