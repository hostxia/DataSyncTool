﻿/**  版本信息模板在安装目录下，可自行修改。
* TF_OperationLog.cs
*
* 功 能： N/A
* 类 名： TF_OperationLog
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:15   N/A    初版
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
	/// 数据访问类:TF_OperationLog
	/// </summary>
	public partial class TF_OperationLog
	{
		public TF_OperationLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TF_OperationLog");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TF_OperationLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TF_OperationLog(");
			strSql.Append("g_ID,g_TaskChainGuid,g_TaskGuid,s_CodeNodeCode,s_TaskName,s_OperationType,s_StateBefore,s_StateAfter,s_Reason,n_Creator,dt_CreateTime)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@g_TaskChainGuid,@g_TaskGuid,@s_CodeNodeCode,@s_TaskName,@s_OperationType,@s_StateBefore,@s_StateAfter,@s_Reason,@n_Creator,@dt_CreateTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_TaskChainGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_TaskGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_CodeNodeCode", SqlDbType.NVarChar,21),
					new SqlParameter("@s_TaskName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_OperationType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_StateBefore", SqlDbType.NVarChar,1),
					new SqlParameter("@s_StateAfter", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Reason", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_Creator", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateTime", SqlDbType.DateTime)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = Guid.NewGuid();
			parameters[3].Value = model.s_CodeNodeCode;
			parameters[4].Value = model.s_TaskName;
			parameters[5].Value = model.s_OperationType;
			parameters[6].Value = model.s_StateBefore;
			parameters[7].Value = model.s_StateAfter;
			parameters[8].Value = model.s_Reason;
			parameters[9].Value = model.n_Creator;
			parameters[10].Value = model.dt_CreateTime;

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
		public bool Update(IPSP.Model.TF_OperationLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TF_OperationLog set ");
			strSql.Append("g_TaskChainGuid=@g_TaskChainGuid,");
			strSql.Append("g_TaskGuid=@g_TaskGuid,");
			strSql.Append("s_CodeNodeCode=@s_CodeNodeCode,");
			strSql.Append("s_TaskName=@s_TaskName,");
			strSql.Append("s_OperationType=@s_OperationType,");
			strSql.Append("s_StateBefore=@s_StateBefore,");
			strSql.Append("s_StateAfter=@s_StateAfter,");
			strSql.Append("s_Reason=@s_Reason,");
			strSql.Append("n_Creator=@n_Creator,");
			strSql.Append("dt_CreateTime=@dt_CreateTime");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_TaskChainGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_TaskGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_CodeNodeCode", SqlDbType.NVarChar,21),
					new SqlParameter("@s_TaskName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_OperationType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_StateBefore", SqlDbType.NVarChar,1),
					new SqlParameter("@s_StateAfter", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Reason", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_Creator", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.g_TaskChainGuid;
			parameters[1].Value = model.g_TaskGuid;
			parameters[2].Value = model.s_CodeNodeCode;
			parameters[3].Value = model.s_TaskName;
			parameters[4].Value = model.s_OperationType;
			parameters[5].Value = model.s_StateBefore;
			parameters[6].Value = model.s_StateAfter;
			parameters[7].Value = model.s_Reason;
			parameters[8].Value = model.n_Creator;
			parameters[9].Value = model.dt_CreateTime;
			parameters[10].Value = model.g_ID;

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
		public bool Delete(Guid g_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TF_OperationLog ");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

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
		public bool DeleteList(string g_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TF_OperationLog ");
			strSql.Append(" where g_ID in ("+g_IDlist + ")  ");
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
		public IPSP.Model.TF_OperationLog GetModel(Guid g_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,g_TaskChainGuid,g_TaskGuid,s_CodeNodeCode,s_TaskName,s_OperationType,s_StateBefore,s_StateAfter,s_Reason,n_Creator,dt_CreateTime from TF_OperationLog ");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			IPSP.Model.TF_OperationLog model=new IPSP.Model.TF_OperationLog();
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
		public IPSP.Model.TF_OperationLog DataRowToModel(DataRow row)
		{
			IPSP.Model.TF_OperationLog model=new IPSP.Model.TF_OperationLog();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["g_TaskChainGuid"]!=null && row["g_TaskChainGuid"].ToString()!="")
				{
					model.g_TaskChainGuid= new Guid(row["g_TaskChainGuid"].ToString());
				}
				if(row["g_TaskGuid"]!=null && row["g_TaskGuid"].ToString()!="")
				{
					model.g_TaskGuid= new Guid(row["g_TaskGuid"].ToString());
				}
				if(row["s_CodeNodeCode"]!=null)
				{
					model.s_CodeNodeCode=row["s_CodeNodeCode"].ToString();
				}
				if(row["s_TaskName"]!=null)
				{
					model.s_TaskName=row["s_TaskName"].ToString();
				}
				if(row["s_OperationType"]!=null)
				{
					model.s_OperationType=row["s_OperationType"].ToString();
				}
				if(row["s_StateBefore"]!=null)
				{
					model.s_StateBefore=row["s_StateBefore"].ToString();
				}
				if(row["s_StateAfter"]!=null)
				{
					model.s_StateAfter=row["s_StateAfter"].ToString();
				}
				if(row["s_Reason"]!=null)
				{
					model.s_Reason=row["s_Reason"].ToString();
				}
				if(row["n_Creator"]!=null && row["n_Creator"].ToString()!="")
				{
					model.n_Creator=int.Parse(row["n_Creator"].ToString());
				}
				if(row["dt_CreateTime"]!=null && row["dt_CreateTime"].ToString()!="")
				{
					model.dt_CreateTime=DateTime.Parse(row["dt_CreateTime"].ToString());
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
			strSql.Append("select g_ID,g_TaskChainGuid,g_TaskGuid,s_CodeNodeCode,s_TaskName,s_OperationType,s_StateBefore,s_StateAfter,s_Reason,n_Creator,dt_CreateTime ");
			strSql.Append(" FROM TF_OperationLog ");
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
			strSql.Append(" g_ID,g_TaskChainGuid,g_TaskGuid,s_CodeNodeCode,s_TaskName,s_OperationType,s_StateBefore,s_StateAfter,s_Reason,n_Creator,dt_CreateTime ");
			strSql.Append(" FROM TF_OperationLog ");
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
			strSql.Append("select count(1) FROM TF_OperationLog ");
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
				strSql.Append("order by T.g_ID desc");
			}
			strSql.Append(")AS Row, T.*  from TF_OperationLog T ");
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
			parameters[0].Value = "TF_OperationLog";
			parameters[1].Value = "g_ID";
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

