﻿/**  版本信息模板在安装目录下，可自行修改。
* TCode_SearchTaskRights.cs
*
* 功 能： N/A
* 类 名： TCode_SearchTaskRights
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:58   N/A    初版
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
	/// 数据访问类:TCode_SearchTaskRights
	/// </summary>
	public partial class TCode_SearchTaskRights
	{
		public TCode_SearchTaskRights()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_SearchTaskID", "TCode_SearchTaskRights"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_SearchTaskID,int n_EmployeeID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_SearchTaskRights");
			strSql.Append(" where n_SearchTaskID=@n_SearchTaskID and n_EmployeeID=@n_EmployeeID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_SearchTaskID", SqlDbType.Int,4),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_SearchTaskID;
			parameters[1].Value = n_EmployeeID;
			parameters[2].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_SearchTaskRights model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_SearchTaskRights(");
			strSql.Append("n_Sequence,n_SearchTaskID,n_EmployeeID)");
			strSql.Append(" values (");
			strSql.Append("@n_Sequence,@n_SearchTaskID,@n_EmployeeID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@n_SearchTaskID", SqlDbType.Int,4),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_Sequence;
			parameters[1].Value = model.n_SearchTaskID;
			parameters[2].Value = model.n_EmployeeID;

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
		public bool Update(IPSP.Model.TCode_SearchTaskRights model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_SearchTaskRights set ");
			strSql.Append("n_Sequence=@n_Sequence");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_SearchTaskID", SqlDbType.Int,4),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_Sequence;
			parameters[1].Value = model.n_ID;
			parameters[2].Value = model.n_SearchTaskID;
			parameters[3].Value = model.n_EmployeeID;

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
			strSql.Append("delete from TCode_SearchTaskRights ");
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
		public bool Delete(int n_SearchTaskID,int n_EmployeeID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_SearchTaskRights ");
			strSql.Append(" where n_SearchTaskID=@n_SearchTaskID and n_EmployeeID=@n_EmployeeID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_SearchTaskID", SqlDbType.Int,4),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_SearchTaskID;
			parameters[1].Value = n_EmployeeID;
			parameters[2].Value = n_ID;

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
			strSql.Append("delete from TCode_SearchTaskRights ");
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
		public IPSP.Model.TCode_SearchTaskRights GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_Sequence,n_SearchTaskID,n_EmployeeID from TCode_SearchTaskRights ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_SearchTaskRights model=new IPSP.Model.TCode_SearchTaskRights();
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
		public IPSP.Model.TCode_SearchTaskRights DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_SearchTaskRights model=new IPSP.Model.TCode_SearchTaskRights();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_Sequence"]!=null && row["n_Sequence"].ToString()!="")
				{
					model.n_Sequence=int.Parse(row["n_Sequence"].ToString());
				}
				if(row["n_SearchTaskID"]!=null && row["n_SearchTaskID"].ToString()!="")
				{
					model.n_SearchTaskID=int.Parse(row["n_SearchTaskID"].ToString());
				}
				if(row["n_EmployeeID"]!=null && row["n_EmployeeID"].ToString()!="")
				{
					model.n_EmployeeID=int.Parse(row["n_EmployeeID"].ToString());
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
			strSql.Append("select n_ID,n_Sequence,n_SearchTaskID,n_EmployeeID ");
			strSql.Append(" FROM TCode_SearchTaskRights ");
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
			strSql.Append(" n_ID,n_Sequence,n_SearchTaskID,n_EmployeeID ");
			strSql.Append(" FROM TCode_SearchTaskRights ");
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
			strSql.Append("select count(1) FROM TCode_SearchTaskRights ");
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
			strSql.Append(")AS Row, T.*  from TCode_SearchTaskRights T ");
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
			parameters[0].Value = "TCode_SearchTaskRights";
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

