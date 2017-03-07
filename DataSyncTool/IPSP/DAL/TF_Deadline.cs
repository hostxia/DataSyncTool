﻿/**  版本信息模板在安装目录下，可自行修改。
* TF_Deadline.cs
*
* 功 能： N/A
* 类 名： TF_Deadline
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:11   N/A    初版
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
	/// 数据访问类:TF_Deadline
	/// </summary>
	public partial class TF_Deadline
	{
		public TF_Deadline()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TF_Deadline"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TF_Deadline");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TF_Deadline model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TF_Deadline(");
			strSql.Append("g_CodeDeadlineID,s_RelatedObjectType,n_RelatedObjectID,dt_Deadline,s_ManualUpdateDeadline,s_AllowEdit)");
			strSql.Append(" values (");
			strSql.Append("@g_CodeDeadlineID,@s_RelatedObjectType,@n_RelatedObjectID,@dt_Deadline,@s_ManualUpdateDeadline,@s_AllowEdit)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@g_CodeDeadlineID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_RelatedObjectType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_RelatedObjectID", SqlDbType.Int,4),
					new SqlParameter("@dt_Deadline", SqlDbType.DateTime),
					new SqlParameter("@s_ManualUpdateDeadline", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AllowEdit", SqlDbType.NVarChar,1)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.s_RelatedObjectType;
			parameters[2].Value = model.n_RelatedObjectID;
			parameters[3].Value = model.dt_Deadline;
			parameters[4].Value = model.s_ManualUpdateDeadline;
			parameters[5].Value = model.s_AllowEdit;

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
		public bool Update(IPSP.Model.TF_Deadline model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TF_Deadline set ");
			strSql.Append("g_CodeDeadlineID=@g_CodeDeadlineID,");
			strSql.Append("s_RelatedObjectType=@s_RelatedObjectType,");
			strSql.Append("n_RelatedObjectID=@n_RelatedObjectID,");
			strSql.Append("dt_Deadline=@dt_Deadline,");
			strSql.Append("s_ManualUpdateDeadline=@s_ManualUpdateDeadline,");
			strSql.Append("s_AllowEdit=@s_AllowEdit");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@g_CodeDeadlineID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_RelatedObjectType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_RelatedObjectID", SqlDbType.Int,4),
					new SqlParameter("@dt_Deadline", SqlDbType.DateTime),
					new SqlParameter("@s_ManualUpdateDeadline", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AllowEdit", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.g_CodeDeadlineID;
			parameters[1].Value = model.s_RelatedObjectType;
			parameters[2].Value = model.n_RelatedObjectID;
			parameters[3].Value = model.dt_Deadline;
			parameters[4].Value = model.s_ManualUpdateDeadline;
			parameters[5].Value = model.s_AllowEdit;
			parameters[6].Value = model.n_ID;

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
			strSql.Append("delete from TF_Deadline ");
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string n_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TF_Deadline ");
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
		public IPSP.Model.TF_Deadline GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,g_CodeDeadlineID,s_RelatedObjectType,n_RelatedObjectID,dt_Deadline,s_ManualUpdateDeadline,s_AllowEdit from TF_Deadline ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TF_Deadline model=new IPSP.Model.TF_Deadline();
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
		public IPSP.Model.TF_Deadline DataRowToModel(DataRow row)
		{
			IPSP.Model.TF_Deadline model=new IPSP.Model.TF_Deadline();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["g_CodeDeadlineID"]!=null && row["g_CodeDeadlineID"].ToString()!="")
				{
					model.g_CodeDeadlineID= new Guid(row["g_CodeDeadlineID"].ToString());
				}
				if(row["s_RelatedObjectType"]!=null)
				{
					model.s_RelatedObjectType=row["s_RelatedObjectType"].ToString();
				}
				if(row["n_RelatedObjectID"]!=null && row["n_RelatedObjectID"].ToString()!="")
				{
					model.n_RelatedObjectID=int.Parse(row["n_RelatedObjectID"].ToString());
				}
				if(row["dt_Deadline"]!=null && row["dt_Deadline"].ToString()!="")
				{
					model.dt_Deadline=DateTime.Parse(row["dt_Deadline"].ToString());
				}
				if(row["s_ManualUpdateDeadline"]!=null)
				{
					model.s_ManualUpdateDeadline=row["s_ManualUpdateDeadline"].ToString();
				}
				if(row["s_AllowEdit"]!=null)
				{
					model.s_AllowEdit=row["s_AllowEdit"].ToString();
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
			strSql.Append("select n_ID,g_CodeDeadlineID,s_RelatedObjectType,n_RelatedObjectID,dt_Deadline,s_ManualUpdateDeadline,s_AllowEdit ");
			strSql.Append(" FROM TF_Deadline ");
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
			strSql.Append(" n_ID,g_CodeDeadlineID,s_RelatedObjectType,n_RelatedObjectID,dt_Deadline,s_ManualUpdateDeadline,s_AllowEdit ");
			strSql.Append(" FROM TF_Deadline ");
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
			strSql.Append("select count(1) FROM TF_Deadline ");
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
			strSql.Append(")AS Row, T.*  from TF_Deadline T ");
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
			parameters[0].Value = "TF_Deadline";
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

