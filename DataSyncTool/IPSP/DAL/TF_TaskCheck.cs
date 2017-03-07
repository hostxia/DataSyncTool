/**  版本信息模板在安装目录下，可自行修改。
* TF_TaskCheck.cs
*
* 功 能： N/A
* 类 名： TF_TaskCheck
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:20   N/A    初版
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
	/// 数据访问类:TF_TaskCheck
	/// </summary>
	public partial class TF_TaskCheck
	{
		public TF_TaskCheck()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TF_TaskCheck");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TF_TaskCheck model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TF_TaskCheck(");
			strSql.Append("g_ID,g_TaskID,n_Sequence,g_CheckTaskID,s_CheckReselt,s_CheckReason,n_Checker,dt_CheckTime)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@g_TaskID,@n_Sequence,@g_CheckTaskID,@s_CheckReselt,@s_CheckReason,@n_Checker,@dt_CheckTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_TaskID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@g_CheckTaskID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_CheckReselt", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CheckReason", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@dt_CheckTime", SqlDbType.DateTime)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = model.n_Sequence;
			parameters[3].Value = Guid.NewGuid();
			parameters[4].Value = model.s_CheckReselt;
			parameters[5].Value = model.s_CheckReason;
			parameters[6].Value = model.n_Checker;
			parameters[7].Value = model.dt_CheckTime;

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
		public bool Update(IPSP.Model.TF_TaskCheck model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TF_TaskCheck set ");
			strSql.Append("g_TaskID=@g_TaskID,");
			strSql.Append("n_Sequence=@n_Sequence,");
			strSql.Append("g_CheckTaskID=@g_CheckTaskID,");
			strSql.Append("s_CheckReselt=@s_CheckReselt,");
			strSql.Append("s_CheckReason=@s_CheckReason,");
			strSql.Append("n_Checker=@n_Checker,");
			strSql.Append("dt_CheckTime=@dt_CheckTime");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_TaskID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@g_CheckTaskID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_CheckReselt", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CheckReason", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@dt_CheckTime", SqlDbType.DateTime),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.g_TaskID;
			parameters[1].Value = model.n_Sequence;
			parameters[2].Value = model.g_CheckTaskID;
			parameters[3].Value = model.s_CheckReselt;
			parameters[4].Value = model.s_CheckReason;
			parameters[5].Value = model.n_Checker;
			parameters[6].Value = model.dt_CheckTime;
			parameters[7].Value = model.g_ID;

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
			strSql.Append("delete from TF_TaskCheck ");
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
			strSql.Append("delete from TF_TaskCheck ");
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
		public IPSP.Model.TF_TaskCheck GetModel(Guid g_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,g_TaskID,n_Sequence,g_CheckTaskID,s_CheckReselt,s_CheckReason,n_Checker,dt_CheckTime from TF_TaskCheck ");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			IPSP.Model.TF_TaskCheck model=new IPSP.Model.TF_TaskCheck();
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
		public IPSP.Model.TF_TaskCheck DataRowToModel(DataRow row)
		{
			IPSP.Model.TF_TaskCheck model=new IPSP.Model.TF_TaskCheck();
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
				if(row["n_Sequence"]!=null && row["n_Sequence"].ToString()!="")
				{
					model.n_Sequence=int.Parse(row["n_Sequence"].ToString());
				}
				if(row["g_CheckTaskID"]!=null && row["g_CheckTaskID"].ToString()!="")
				{
					model.g_CheckTaskID= new Guid(row["g_CheckTaskID"].ToString());
				}
				if(row["s_CheckReselt"]!=null)
				{
					model.s_CheckReselt=row["s_CheckReselt"].ToString();
				}
				if(row["s_CheckReason"]!=null)
				{
					model.s_CheckReason=row["s_CheckReason"].ToString();
				}
				if(row["n_Checker"]!=null && row["n_Checker"].ToString()!="")
				{
					model.n_Checker=int.Parse(row["n_Checker"].ToString());
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
			strSql.Append("select g_ID,g_TaskID,n_Sequence,g_CheckTaskID,s_CheckReselt,s_CheckReason,n_Checker,dt_CheckTime ");
			strSql.Append(" FROM TF_TaskCheck ");
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
			strSql.Append(" g_ID,g_TaskID,n_Sequence,g_CheckTaskID,s_CheckReselt,s_CheckReason,n_Checker,dt_CheckTime ");
			strSql.Append(" FROM TF_TaskCheck ");
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
			strSql.Append("select count(1) FROM TF_TaskCheck ");
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
			strSql.Append(")AS Row, T.*  from TF_TaskCheck T ");
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
			parameters[0].Value = "TF_TaskCheck";
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

