/**  版本信息模板在安装目录下，可自行修改。
* TF_TaskParameter.cs
*
* 功 能： N/A
* 类 名： TF_TaskParameter
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:23   N/A    初版
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
	/// 数据访问类:TF_TaskParameter
	/// </summary>
	public partial class TF_TaskParameter
	{
		public TF_TaskParameter()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CodeActionID", "TF_TaskParameter"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID,int n_CodeActionID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TF_TaskParameter");
			strSql.Append(" where g_ID=@g_ID and n_CodeActionID=@n_CodeActionID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_CodeActionID", SqlDbType.Int,4)			};
			parameters[0].Value = g_ID;
			parameters[1].Value = n_CodeActionID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TF_TaskParameter model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TF_TaskParameter(");
			strSql.Append("g_ID,g_TaskID,g_TaskChainID,n_CodeActionID,s_ParaType,s_ParaValue,n_TaskChainID)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@g_TaskID,@g_TaskChainID,@n_CodeActionID,@s_ParaType,@s_ParaValue,@n_TaskChainID)");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_TaskID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_TaskChainID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_CodeActionID", SqlDbType.Int,4),
					new SqlParameter("@s_ParaType", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ParaValue", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_TaskChainID", SqlDbType.Int,4)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = Guid.NewGuid();
			parameters[3].Value = model.n_CodeActionID;
			parameters[4].Value = model.s_ParaType;
			parameters[5].Value = model.s_ParaValue;
			parameters[6].Value = model.n_TaskChainID;

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
		public bool Update(IPSP.Model.TF_TaskParameter model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TF_TaskParameter set ");
			strSql.Append("g_TaskID=@g_TaskID,");
			strSql.Append("g_TaskChainID=@g_TaskChainID,");
			strSql.Append("s_ParaType=@s_ParaType,");
			strSql.Append("s_ParaValue=@s_ParaValue,");
			strSql.Append("n_TaskChainID=@n_TaskChainID");
			strSql.Append(" where g_ID=@g_ID and n_CodeActionID=@n_CodeActionID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_TaskID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_TaskChainID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_ParaType", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ParaValue", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_TaskChainID", SqlDbType.Int,4),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_CodeActionID", SqlDbType.Int,4)};
			parameters[0].Value = model.g_TaskID;
			parameters[1].Value = model.g_TaskChainID;
			parameters[2].Value = model.s_ParaType;
			parameters[3].Value = model.s_ParaValue;
			parameters[4].Value = model.n_TaskChainID;
			parameters[5].Value = model.g_ID;
			parameters[6].Value = model.n_CodeActionID;

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
		public bool Delete(Guid g_ID,int n_CodeActionID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TF_TaskParameter ");
			strSql.Append(" where g_ID=@g_ID and n_CodeActionID=@n_CodeActionID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_CodeActionID", SqlDbType.Int,4)			};
			parameters[0].Value = g_ID;
			parameters[1].Value = n_CodeActionID;

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
		public IPSP.Model.TF_TaskParameter GetModel(Guid g_ID,int n_CodeActionID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,g_TaskID,g_TaskChainID,n_CodeActionID,s_ParaType,s_ParaValue,n_TaskChainID from TF_TaskParameter ");
			strSql.Append(" where g_ID=@g_ID and n_CodeActionID=@n_CodeActionID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_CodeActionID", SqlDbType.Int,4)			};
			parameters[0].Value = g_ID;
			parameters[1].Value = n_CodeActionID;

			IPSP.Model.TF_TaskParameter model=new IPSP.Model.TF_TaskParameter();
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
		public IPSP.Model.TF_TaskParameter DataRowToModel(DataRow row)
		{
			IPSP.Model.TF_TaskParameter model=new IPSP.Model.TF_TaskParameter();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["g_TaskID"]!=null && row["g_TaskID"].ToString()!="")
				{
					model.g_TaskID= new Guid(row["g_TaskID"].ToString());
				}
				if(row["g_TaskChainID"]!=null && row["g_TaskChainID"].ToString()!="")
				{
					model.g_TaskChainID= new Guid(row["g_TaskChainID"].ToString());
				}
				if(row["n_CodeActionID"]!=null && row["n_CodeActionID"].ToString()!="")
				{
					model.n_CodeActionID=int.Parse(row["n_CodeActionID"].ToString());
				}
				if(row["s_ParaType"]!=null)
				{
					model.s_ParaType=row["s_ParaType"].ToString();
				}
				if(row["s_ParaValue"]!=null)
				{
					model.s_ParaValue=row["s_ParaValue"].ToString();
				}
				if(row["n_TaskChainID"]!=null && row["n_TaskChainID"].ToString()!="")
				{
					model.n_TaskChainID=int.Parse(row["n_TaskChainID"].ToString());
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
			strSql.Append("select g_ID,g_TaskID,g_TaskChainID,n_CodeActionID,s_ParaType,s_ParaValue,n_TaskChainID ");
			strSql.Append(" FROM TF_TaskParameter ");
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
			strSql.Append(" g_ID,g_TaskID,g_TaskChainID,n_CodeActionID,s_ParaType,s_ParaValue,n_TaskChainID ");
			strSql.Append(" FROM TF_TaskParameter ");
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
			strSql.Append("select count(1) FROM TF_TaskParameter ");
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
				strSql.Append("order by T.n_CodeActionID desc");
			}
			strSql.Append(")AS Row, T.*  from TF_TaskParameter T ");
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
			parameters[0].Value = "TF_TaskParameter";
			parameters[1].Value = "n_CodeActionID";
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

