/**  版本信息模板在安装目录下，可自行修改。
* TF_CustomConditionInTaskChain.cs
*
* 功 能： N/A
* 类 名： TF_CustomConditionInTaskChain
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:09   N/A    初版
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
	/// 数据访问类:TF_CustomConditionInTaskChain
	/// </summary>
	public partial class TF_CustomConditionInTaskChain
	{
		public TF_CustomConditionInTaskChain()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TF_CustomConditionInTaskChain");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TF_CustomConditionInTaskChain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TF_CustomConditionInTaskChain(");
			strSql.Append("g_ID,n_CustomConditionID,g_TaskChainID,s_Values)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@n_CustomConditionID,@g_TaskChainID,@s_Values)");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_CustomConditionID", SqlDbType.Int,4),
					new SqlParameter("@g_TaskChainID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Values", SqlDbType.NVarChar,500)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.n_CustomConditionID;
			parameters[2].Value = Guid.NewGuid();
			parameters[3].Value = model.s_Values;

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
		public bool Update(IPSP.Model.TF_CustomConditionInTaskChain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TF_CustomConditionInTaskChain set ");
			strSql.Append("n_CustomConditionID=@n_CustomConditionID,");
			strSql.Append("g_TaskChainID=@g_TaskChainID,");
			strSql.Append("s_Values=@s_Values");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CustomConditionID", SqlDbType.Int,4),
					new SqlParameter("@g_TaskChainID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Values", SqlDbType.NVarChar,500),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.n_CustomConditionID;
			parameters[1].Value = model.g_TaskChainID;
			parameters[2].Value = model.s_Values;
			parameters[3].Value = model.g_ID;

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
			strSql.Append("delete from TF_CustomConditionInTaskChain ");
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
			strSql.Append("delete from TF_CustomConditionInTaskChain ");
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
		public IPSP.Model.TF_CustomConditionInTaskChain GetModel(Guid g_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,n_CustomConditionID,g_TaskChainID,s_Values from TF_CustomConditionInTaskChain ");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			IPSP.Model.TF_CustomConditionInTaskChain model=new IPSP.Model.TF_CustomConditionInTaskChain();
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
		public IPSP.Model.TF_CustomConditionInTaskChain DataRowToModel(DataRow row)
		{
			IPSP.Model.TF_CustomConditionInTaskChain model=new IPSP.Model.TF_CustomConditionInTaskChain();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["n_CustomConditionID"]!=null && row["n_CustomConditionID"].ToString()!="")
				{
					model.n_CustomConditionID=int.Parse(row["n_CustomConditionID"].ToString());
				}
				if(row["g_TaskChainID"]!=null && row["g_TaskChainID"].ToString()!="")
				{
					model.g_TaskChainID= new Guid(row["g_TaskChainID"].ToString());
				}
				if(row["s_Values"]!=null)
				{
					model.s_Values=row["s_Values"].ToString();
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
			strSql.Append("select g_ID,n_CustomConditionID,g_TaskChainID,s_Values ");
			strSql.Append(" FROM TF_CustomConditionInTaskChain ");
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
			strSql.Append(" g_ID,n_CustomConditionID,g_TaskChainID,s_Values ");
			strSql.Append(" FROM TF_CustomConditionInTaskChain ");
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
			strSql.Append("select count(1) FROM TF_CustomConditionInTaskChain ");
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
			strSql.Append(")AS Row, T.*  from TF_CustomConditionInTaskChain T ");
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
			parameters[0].Value = "TF_CustomConditionInTaskChain";
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

