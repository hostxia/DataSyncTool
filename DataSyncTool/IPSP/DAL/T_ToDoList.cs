/**  版本信息模板在安装目录下，可自行修改。
* T_ToDoList.cs
*
* 功 能： N/A
* 类 名： T_ToDoList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:14   N/A    初版
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
	/// 数据访问类:T_ToDoList
	/// </summary>
	public partial class T_ToDoList
	{
		public T_ToDoList()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ConfigID", "T_ToDoList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ConfigID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_ToDoList");
			strSql.Append(" where n_ConfigID=@n_ConfigID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ConfigID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ConfigID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_ToDoList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_ToDoList(");
			strSql.Append("n_ConfigID,n_ElementID,dt_RemindTime,dt_EndTime,n_Importance,s_IsDeleted,s_IsShowForm)");
			strSql.Append(" values (");
			strSql.Append("@n_ConfigID,@n_ElementID,@dt_RemindTime,@dt_EndTime,@n_Importance,@s_IsDeleted,@s_IsShowForm)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ConfigID", SqlDbType.Int,4),
					new SqlParameter("@n_ElementID", SqlDbType.Int,4),
					new SqlParameter("@dt_RemindTime", SqlDbType.DateTime),
					new SqlParameter("@dt_EndTime", SqlDbType.DateTime),
					new SqlParameter("@n_Importance", SqlDbType.Int,4),
					new SqlParameter("@s_IsDeleted", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsShowForm", SqlDbType.NVarChar,1)};
			parameters[0].Value = model.n_ConfigID;
			parameters[1].Value = model.n_ElementID;
			parameters[2].Value = model.dt_RemindTime;
			parameters[3].Value = model.dt_EndTime;
			parameters[4].Value = model.n_Importance;
			parameters[5].Value = model.s_IsDeleted;
			parameters[6].Value = model.s_IsShowForm;

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
		public bool Update(IPSP.Model.T_ToDoList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_ToDoList set ");
			strSql.Append("n_ElementID=@n_ElementID,");
			strSql.Append("dt_RemindTime=@dt_RemindTime,");
			strSql.Append("dt_EndTime=@dt_EndTime,");
			strSql.Append("n_Importance=@n_Importance,");
			strSql.Append("s_IsDeleted=@s_IsDeleted,");
			strSql.Append("s_IsShowForm=@s_IsShowForm");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ElementID", SqlDbType.Int,4),
					new SqlParameter("@dt_RemindTime", SqlDbType.DateTime),
					new SqlParameter("@dt_EndTime", SqlDbType.DateTime),
					new SqlParameter("@n_Importance", SqlDbType.Int,4),
					new SqlParameter("@s_IsDeleted", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsShowForm", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_ConfigID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_ElementID;
			parameters[1].Value = model.dt_RemindTime;
			parameters[2].Value = model.dt_EndTime;
			parameters[3].Value = model.n_Importance;
			parameters[4].Value = model.s_IsDeleted;
			parameters[5].Value = model.s_IsShowForm;
			parameters[6].Value = model.n_ID;
			parameters[7].Value = model.n_ConfigID;

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
			strSql.Append("delete from T_ToDoList ");
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
		public bool Delete(int n_ConfigID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_ToDoList ");
			strSql.Append(" where n_ConfigID=@n_ConfigID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ConfigID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ConfigID;
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
			strSql.Append("delete from T_ToDoList ");
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
		public IPSP.Model.T_ToDoList GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_ConfigID,n_ElementID,dt_RemindTime,dt_EndTime,n_Importance,s_IsDeleted,s_IsShowForm from T_ToDoList ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_ToDoList model=new IPSP.Model.T_ToDoList();
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
		public IPSP.Model.T_ToDoList DataRowToModel(DataRow row)
		{
			IPSP.Model.T_ToDoList model=new IPSP.Model.T_ToDoList();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_ConfigID"]!=null && row["n_ConfigID"].ToString()!="")
				{
					model.n_ConfigID=int.Parse(row["n_ConfigID"].ToString());
				}
				if(row["n_ElementID"]!=null && row["n_ElementID"].ToString()!="")
				{
					model.n_ElementID=int.Parse(row["n_ElementID"].ToString());
				}
				if(row["dt_RemindTime"]!=null && row["dt_RemindTime"].ToString()!="")
				{
					model.dt_RemindTime=DateTime.Parse(row["dt_RemindTime"].ToString());
				}
				if(row["dt_EndTime"]!=null && row["dt_EndTime"].ToString()!="")
				{
					model.dt_EndTime=DateTime.Parse(row["dt_EndTime"].ToString());
				}
				if(row["n_Importance"]!=null && row["n_Importance"].ToString()!="")
				{
					model.n_Importance=int.Parse(row["n_Importance"].ToString());
				}
				if(row["s_IsDeleted"]!=null)
				{
					model.s_IsDeleted=row["s_IsDeleted"].ToString();
				}
				if(row["s_IsShowForm"]!=null)
				{
					model.s_IsShowForm=row["s_IsShowForm"].ToString();
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
			strSql.Append("select n_ID,n_ConfigID,n_ElementID,dt_RemindTime,dt_EndTime,n_Importance,s_IsDeleted,s_IsShowForm ");
			strSql.Append(" FROM T_ToDoList ");
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
			strSql.Append(" n_ID,n_ConfigID,n_ElementID,dt_RemindTime,dt_EndTime,n_Importance,s_IsDeleted,s_IsShowForm ");
			strSql.Append(" FROM T_ToDoList ");
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
			strSql.Append("select count(1) FROM T_ToDoList ");
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
			strSql.Append(")AS Row, T.*  from T_ToDoList T ");
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
			parameters[0].Value = "T_ToDoList";
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

