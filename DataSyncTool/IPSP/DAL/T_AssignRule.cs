/**  版本信息模板在安装目录下，可自行修改。
* T_AssignRule.cs
*
* 功 能： N/A
* 类 名： T_AssignRule
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:29   N/A    初版
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
	/// 数据访问类:T_AssignRule
	/// </summary>
	public partial class T_AssignRule
	{
		public T_AssignRule()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.T_AssignRule model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_AssignRule(");
			strSql.Append("s_AssignType,n_AssignID,s_AssignUser)");
			strSql.Append(" values (");
			strSql.Append("@s_AssignType,@n_AssignID,@s_AssignUser)");
			SqlParameter[] parameters = {
					new SqlParameter("@s_AssignType", SqlDbType.NVarChar,500),
					new SqlParameter("@n_AssignID", SqlDbType.Int,4),
					new SqlParameter("@s_AssignUser", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.s_AssignType;
			parameters[1].Value = model.n_AssignID;
			parameters[2].Value = model.s_AssignUser;

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
		public bool Update(IPSP.Model.T_AssignRule model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_AssignRule set ");
			strSql.Append("s_AssignType=@s_AssignType,");
			strSql.Append("n_AssignID=@n_AssignID,");
			strSql.Append("s_AssignUser=@s_AssignUser");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_AssignType", SqlDbType.NVarChar,500),
					new SqlParameter("@n_AssignID", SqlDbType.Int,4),
					new SqlParameter("@s_AssignUser", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.s_AssignType;
			parameters[1].Value = model.n_AssignID;
			parameters[2].Value = model.s_AssignUser;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_AssignRule ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public IPSP.Model.T_AssignRule GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 s_AssignType,n_AssignID,s_AssignUser from T_AssignRule ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			IPSP.Model.T_AssignRule model=new IPSP.Model.T_AssignRule();
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
		public IPSP.Model.T_AssignRule DataRowToModel(DataRow row)
		{
			IPSP.Model.T_AssignRule model=new IPSP.Model.T_AssignRule();
			if (row != null)
			{
				if(row["s_AssignType"]!=null)
				{
					model.s_AssignType=row["s_AssignType"].ToString();
				}
				if(row["n_AssignID"]!=null && row["n_AssignID"].ToString()!="")
				{
					model.n_AssignID=int.Parse(row["n_AssignID"].ToString());
				}
				if(row["s_AssignUser"]!=null)
				{
					model.s_AssignUser=row["s_AssignUser"].ToString();
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
			strSql.Append("select s_AssignType,n_AssignID,s_AssignUser ");
			strSql.Append(" FROM T_AssignRule ");
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
			strSql.Append(" s_AssignType,n_AssignID,s_AssignUser ");
			strSql.Append(" FROM T_AssignRule ");
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
			strSql.Append("select count(1) FROM T_AssignRule ");
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
				strSql.Append("order by T.n_AnnualFeeID desc");
			}
			strSql.Append(")AS Row, T.*  from T_AssignRule T ");
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
			parameters[0].Value = "T_AssignRule";
			parameters[1].Value = "n_AnnualFeeID";
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

