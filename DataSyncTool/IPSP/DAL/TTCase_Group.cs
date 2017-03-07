/**  版本信息模板在安装目录下，可自行修改。
* TTCase_Group.cs
*
* 功 能： N/A
* 类 名： TTCase_Group
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:33   N/A    初版
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
	/// 数据访问类:TTCase_Group
	/// </summary>
	public partial class TTCase_Group
	{
		public TTCase_Group()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_GroupID", "TTCase_Group"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_GroupID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TTCase_Group");
			strSql.Append(" where n_GroupID=@n_GroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_GroupID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_GroupID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TTCase_Group model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TTCase_Group(");
			strSql.Append("s_Notes)");
			strSql.Append(" values (");
			strSql.Append("@s_Notes)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800)};
			parameters[0].Value = model.s_Notes;

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
		public bool Update(IPSP.Model.TTCase_Group model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TTCase_Group set ");
			strSql.Append("s_Notes=@s_Notes");
			strSql.Append(" where n_GroupID=@n_GroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_GroupID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Notes;
			parameters[1].Value = model.n_GroupID;

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
		public bool Delete(int n_GroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TTCase_Group ");
			strSql.Append(" where n_GroupID=@n_GroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_GroupID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_GroupID;

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
		public bool DeleteList(string n_GroupIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TTCase_Group ");
			strSql.Append(" where n_GroupID in ("+n_GroupIDlist + ")  ");
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
		public IPSP.Model.TTCase_Group GetModel(int n_GroupID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_GroupID,s_Notes from TTCase_Group ");
			strSql.Append(" where n_GroupID=@n_GroupID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_GroupID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_GroupID;

			IPSP.Model.TTCase_Group model=new IPSP.Model.TTCase_Group();
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
		public IPSP.Model.TTCase_Group DataRowToModel(DataRow row)
		{
			IPSP.Model.TTCase_Group model=new IPSP.Model.TTCase_Group();
			if (row != null)
			{
				if(row["n_GroupID"]!=null && row["n_GroupID"].ToString()!="")
				{
					model.n_GroupID=int.Parse(row["n_GroupID"].ToString());
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
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
			strSql.Append("select n_GroupID,s_Notes ");
			strSql.Append(" FROM TTCase_Group ");
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
			strSql.Append(" n_GroupID,s_Notes ");
			strSql.Append(" FROM TTCase_Group ");
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
			strSql.Append("select count(1) FROM TTCase_Group ");
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
				strSql.Append("order by T.n_GroupID desc");
			}
			strSql.Append(")AS Row, T.*  from TTCase_Group T ");
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
			parameters[0].Value = "TTCase_Group";
			parameters[1].Value = "n_GroupID";
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

