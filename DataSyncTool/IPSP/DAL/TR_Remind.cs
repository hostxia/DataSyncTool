/**  版本信息模板在安装目录下，可自行修改。
* TR_Remind.cs
*
* 功 能： N/A
* 类 名： TR_Remind
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:56   N/A    初版
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
	/// 数据访问类:TR_Remind
	/// </summary>
	public partial class TR_Remind
	{
		public TR_Remind()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TR_Remind");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TR_Remind model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TR_Remind(");
			strSql.Append("g_ID,g_CodeRemindID,s_TriggerType,s_TriggerID,s_State,n_RemindCount,dt_RemindDate,s_RemindType,s_RemindPara,n_Creator,s_Valid)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@g_CodeRemindID,@s_TriggerType,@s_TriggerID,@s_State,@n_RemindCount,@dt_RemindDate,@s_RemindType,@s_RemindPara,@n_Creator,@s_Valid)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_CodeRemindID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_TriggerType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_TriggerID", SqlDbType.NVarChar,50),
					new SqlParameter("@s_State", SqlDbType.NVarChar,1),
					new SqlParameter("@n_RemindCount", SqlDbType.Int,4),
					new SqlParameter("@dt_RemindDate", SqlDbType.DateTime),
					new SqlParameter("@s_RemindType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RemindPara", SqlDbType.NVarChar,200),
					new SqlParameter("@n_Creator", SqlDbType.Int,4),
					new SqlParameter("@s_Valid", SqlDbType.NVarChar,1)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = model.s_TriggerType;
			parameters[3].Value = model.s_TriggerID;
			parameters[4].Value = model.s_State;
			parameters[5].Value = model.n_RemindCount;
			parameters[6].Value = model.dt_RemindDate;
			parameters[7].Value = model.s_RemindType;
			parameters[8].Value = model.s_RemindPara;
			parameters[9].Value = model.n_Creator;
			parameters[10].Value = model.s_Valid;

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
		public bool Update(IPSP.Model.TR_Remind model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TR_Remind set ");
			strSql.Append("g_CodeRemindID=@g_CodeRemindID,");
			strSql.Append("s_TriggerType=@s_TriggerType,");
			strSql.Append("s_TriggerID=@s_TriggerID,");
			strSql.Append("s_State=@s_State,");
			strSql.Append("n_RemindCount=@n_RemindCount,");
			strSql.Append("dt_RemindDate=@dt_RemindDate,");
			strSql.Append("s_RemindType=@s_RemindType,");
			strSql.Append("s_RemindPara=@s_RemindPara,");
			strSql.Append("n_Creator=@n_Creator,");
			strSql.Append("s_Valid=@s_Valid");
			strSql.Append(" where n_Num=@n_Num");
			SqlParameter[] parameters = {
					new SqlParameter("@g_CodeRemindID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_TriggerType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_TriggerID", SqlDbType.NVarChar,50),
					new SqlParameter("@s_State", SqlDbType.NVarChar,1),
					new SqlParameter("@n_RemindCount", SqlDbType.Int,4),
					new SqlParameter("@dt_RemindDate", SqlDbType.DateTime),
					new SqlParameter("@s_RemindType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RemindPara", SqlDbType.NVarChar,200),
					new SqlParameter("@n_Creator", SqlDbType.Int,4),
					new SqlParameter("@s_Valid", SqlDbType.NVarChar,1),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_Num", SqlDbType.Int,4)};
			parameters[0].Value = model.g_CodeRemindID;
			parameters[1].Value = model.s_TriggerType;
			parameters[2].Value = model.s_TriggerID;
			parameters[3].Value = model.s_State;
			parameters[4].Value = model.n_RemindCount;
			parameters[5].Value = model.dt_RemindDate;
			parameters[6].Value = model.s_RemindType;
			parameters[7].Value = model.s_RemindPara;
			parameters[8].Value = model.n_Creator;
			parameters[9].Value = model.s_Valid;
			parameters[10].Value = model.g_ID;
			parameters[11].Value = model.n_Num;

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
		public bool Delete(int n_Num)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TR_Remind ");
			strSql.Append(" where n_Num=@n_Num");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Num", SqlDbType.Int,4)
			};
			parameters[0].Value = n_Num;

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
			strSql.Append("delete from TR_Remind ");
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
		public bool DeleteList(string n_Numlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TR_Remind ");
			strSql.Append(" where n_Num in ("+n_Numlist + ")  ");
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
		public IPSP.Model.TR_Remind GetModel(int n_Num)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,g_CodeRemindID,s_TriggerType,s_TriggerID,s_State,n_RemindCount,dt_RemindDate,s_RemindType,s_RemindPara,n_Creator,s_Valid,n_Num from TR_Remind ");
			strSql.Append(" where n_Num=@n_Num");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Num", SqlDbType.Int,4)
			};
			parameters[0].Value = n_Num;

			IPSP.Model.TR_Remind model=new IPSP.Model.TR_Remind();
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
		public IPSP.Model.TR_Remind DataRowToModel(DataRow row)
		{
			IPSP.Model.TR_Remind model=new IPSP.Model.TR_Remind();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["g_CodeRemindID"]!=null && row["g_CodeRemindID"].ToString()!="")
				{
					model.g_CodeRemindID= new Guid(row["g_CodeRemindID"].ToString());
				}
				if(row["s_TriggerType"]!=null)
				{
					model.s_TriggerType=row["s_TriggerType"].ToString();
				}
				if(row["s_TriggerID"]!=null)
				{
					model.s_TriggerID=row["s_TriggerID"].ToString();
				}
				if(row["s_State"]!=null)
				{
					model.s_State=row["s_State"].ToString();
				}
				if(row["n_RemindCount"]!=null && row["n_RemindCount"].ToString()!="")
				{
					model.n_RemindCount=int.Parse(row["n_RemindCount"].ToString());
				}
				if(row["dt_RemindDate"]!=null && row["dt_RemindDate"].ToString()!="")
				{
					model.dt_RemindDate=DateTime.Parse(row["dt_RemindDate"].ToString());
				}
				if(row["s_RemindType"]!=null)
				{
					model.s_RemindType=row["s_RemindType"].ToString();
				}
				if(row["s_RemindPara"]!=null)
				{
					model.s_RemindPara=row["s_RemindPara"].ToString();
				}
				if(row["n_Creator"]!=null && row["n_Creator"].ToString()!="")
				{
					model.n_Creator=int.Parse(row["n_Creator"].ToString());
				}
				if(row["s_Valid"]!=null)
				{
					model.s_Valid=row["s_Valid"].ToString();
				}
				if(row["n_Num"]!=null && row["n_Num"].ToString()!="")
				{
					model.n_Num=int.Parse(row["n_Num"].ToString());
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
			strSql.Append("select g_ID,g_CodeRemindID,s_TriggerType,s_TriggerID,s_State,n_RemindCount,dt_RemindDate,s_RemindType,s_RemindPara,n_Creator,s_Valid,n_Num ");
			strSql.Append(" FROM TR_Remind ");
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
			strSql.Append(" g_ID,g_CodeRemindID,s_TriggerType,s_TriggerID,s_State,n_RemindCount,dt_RemindDate,s_RemindType,s_RemindPara,n_Creator,s_Valid,n_Num ");
			strSql.Append(" FROM TR_Remind ");
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
			strSql.Append("select count(1) FROM TR_Remind ");
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
				strSql.Append("order by T.n_Num desc");
			}
			strSql.Append(")AS Row, T.*  from TR_Remind T ");
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
			parameters[0].Value = "TR_Remind";
			parameters[1].Value = "n_Num";
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

