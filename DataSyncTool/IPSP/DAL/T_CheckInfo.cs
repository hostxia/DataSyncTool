/**  版本信息模板在安装目录下，可自行修改。
* T_CheckInfo.cs
*
* 功 能： N/A
* 类 名： T_CheckInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:34   N/A    初版
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
	/// 数据访问类:T_CheckInfo
	/// </summary>
	public partial class T_CheckInfo
	{
		public T_CheckInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CheckFlowID", "T_CheckInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CheckFlowID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_CheckInfo");
			strSql.Append(" where n_CheckFlowID=@n_CheckFlowID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CheckFlowID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CheckFlowID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_CheckInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_CheckInfo(");
			strSql.Append("n_CheckFlowID,n_Checker,s_CheckStatus,s_Reason,dt_CheckTime)");
			strSql.Append(" values (");
			strSql.Append("@n_CheckFlowID,@n_Checker,@s_CheckStatus,@s_Reason,@dt_CheckTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CheckFlowID", SqlDbType.Int,4),
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Reason", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_CheckTime", SqlDbType.DateTime)};
			parameters[0].Value = model.n_CheckFlowID;
			parameters[1].Value = model.n_Checker;
			parameters[2].Value = model.s_CheckStatus;
			parameters[3].Value = model.s_Reason;
			parameters[4].Value = model.dt_CheckTime;

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
		public bool Update(IPSP.Model.T_CheckInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_CheckInfo set ");
			strSql.Append("n_Checker=@n_Checker,");
			strSql.Append("s_CheckStatus=@s_CheckStatus,");
			strSql.Append("s_Reason=@s_Reason,");
			strSql.Append("dt_CheckTime=@dt_CheckTime");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Reason", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_CheckTime", SqlDbType.DateTime),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CheckFlowID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_Checker;
			parameters[1].Value = model.s_CheckStatus;
			parameters[2].Value = model.s_Reason;
			parameters[3].Value = model.dt_CheckTime;
			parameters[4].Value = model.n_ID;
			parameters[5].Value = model.n_CheckFlowID;

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
			strSql.Append("delete from T_CheckInfo ");
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
		public bool Delete(int n_CheckFlowID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_CheckInfo ");
			strSql.Append(" where n_CheckFlowID=@n_CheckFlowID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CheckFlowID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CheckFlowID;
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
			strSql.Append("delete from T_CheckInfo ");
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
		public IPSP.Model.T_CheckInfo GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CheckFlowID,n_Checker,s_CheckStatus,s_Reason,dt_CheckTime from T_CheckInfo ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_CheckInfo model=new IPSP.Model.T_CheckInfo();
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
		public IPSP.Model.T_CheckInfo DataRowToModel(DataRow row)
		{
			IPSP.Model.T_CheckInfo model=new IPSP.Model.T_CheckInfo();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_CheckFlowID"]!=null && row["n_CheckFlowID"].ToString()!="")
				{
					model.n_CheckFlowID=int.Parse(row["n_CheckFlowID"].ToString());
				}
				if(row["n_Checker"]!=null && row["n_Checker"].ToString()!="")
				{
					model.n_Checker=int.Parse(row["n_Checker"].ToString());
				}
				if(row["s_CheckStatus"]!=null)
				{
					model.s_CheckStatus=row["s_CheckStatus"].ToString();
				}
				if(row["s_Reason"]!=null)
				{
					model.s_Reason=row["s_Reason"].ToString();
				}
				if(row["dt_CheckTime"]!=null && row["dt_CheckTime"].ToString()!="")
				{
					model.dt_CheckTime=DateTime.Parse(row["dt_CheckTime"].ToString());
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
			strSql.Append("select n_ID,n_CheckFlowID,n_Checker,s_CheckStatus,s_Reason,dt_CheckTime ");
			strSql.Append(" FROM T_CheckInfo ");
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
			strSql.Append(" n_ID,n_CheckFlowID,n_Checker,s_CheckStatus,s_Reason,dt_CheckTime ");
			strSql.Append(" FROM T_CheckInfo ");
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
			strSql.Append("select count(1) FROM T_CheckInfo ");
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
			strSql.Append(")AS Row, T.*  from T_CheckInfo T ");
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
			parameters[0].Value = "T_CheckInfo";
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

