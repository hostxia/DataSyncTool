/**  版本信息模板在安装目录下，可自行修改。
* TF_Task.cs
*
* 功 能： N/A
* 类 名： TF_Task
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:17   N/A    初版
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
	/// 数据访问类:TF_Task
	/// </summary>
	public partial class TF_Task
	{
		public TF_Task()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TF_Task");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TF_Task model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TF_Task(");
			strSql.Append("g_ID,s_Name,s_Description,s_State,s_ReadState,n_Level,n_UrgencyID,n_ExecutorID,n_ExecutePositionID,n_MentorID,dt_FinishTime,dt_StartDate,dt_EndDate,n_Creator,dt_CreateTime,n_Editor,dt_EditTime,s_TaskConfigType,n_RelatedDeadlineID,n_MonitorEmployeeID,b_Monitor,s_Note,n_TaskTypeID,n_Operator,g_TaskCycleConfigGuid,n_Finisher,s_Notes,s_ManualUpdateDeadline)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@s_Name,@s_Description,@s_State,@s_ReadState,@n_Level,@n_UrgencyID,@n_ExecutorID,@n_ExecutePositionID,@n_MentorID,@dt_FinishTime,@dt_StartDate,@dt_EndDate,@n_Creator,@dt_CreateTime,@n_Editor,@dt_EditTime,@s_TaskConfigType,@n_RelatedDeadlineID,@n_MonitorEmployeeID,@b_Monitor,@s_Note,@n_TaskTypeID,@n_Operator,@g_TaskCycleConfigGuid,@n_Finisher,@s_Notes,@s_ManualUpdateDeadline)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_State", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ReadState", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Level", SqlDbType.Int,4),
					new SqlParameter("@n_UrgencyID", SqlDbType.Int,4),
					new SqlParameter("@n_ExecutorID", SqlDbType.Int,4),
					new SqlParameter("@n_ExecutePositionID", SqlDbType.Int,4),
					new SqlParameter("@n_MentorID", SqlDbType.Int,4),
					new SqlParameter("@dt_FinishTime", SqlDbType.DateTime),
					new SqlParameter("@dt_StartDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EndDate", SqlDbType.DateTime),
					new SqlParameter("@n_Creator", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@n_Editor", SqlDbType.Int,4),
					new SqlParameter("@dt_EditTime", SqlDbType.DateTime),
					new SqlParameter("@s_TaskConfigType", SqlDbType.NVarChar,100),
					new SqlParameter("@n_RelatedDeadlineID", SqlDbType.Int,4),
					new SqlParameter("@n_MonitorEmployeeID", SqlDbType.Int,4),
					new SqlParameter("@b_Monitor", SqlDbType.Int,4),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_TaskTypeID", SqlDbType.Int,4),
					new SqlParameter("@n_Operator", SqlDbType.Int,4),
					new SqlParameter("@g_TaskCycleConfigGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_Finisher", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_ManualUpdateDeadline", SqlDbType.NVarChar,1)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_Description;
			parameters[3].Value = model.s_State;
			parameters[4].Value = model.s_ReadState;
			parameters[5].Value = model.n_Level;
			parameters[6].Value = model.n_UrgencyID;
			parameters[7].Value = model.n_ExecutorID;
			parameters[8].Value = model.n_ExecutePositionID;
			parameters[9].Value = model.n_MentorID;
			parameters[10].Value = model.dt_FinishTime;
			parameters[11].Value = model.dt_StartDate;
			parameters[12].Value = model.dt_EndDate;
			parameters[13].Value = model.n_Creator;
			parameters[14].Value = model.dt_CreateTime;
			parameters[15].Value = model.n_Editor;
			parameters[16].Value = model.dt_EditTime;
			parameters[17].Value = model.s_TaskConfigType;
			parameters[18].Value = model.n_RelatedDeadlineID;
			parameters[19].Value = model.n_MonitorEmployeeID;
			parameters[20].Value = model.b_Monitor;
			parameters[21].Value = model.s_Note;
			parameters[22].Value = model.n_TaskTypeID;
			parameters[23].Value = model.n_Operator;
			parameters[24].Value = Guid.NewGuid();
			parameters[25].Value = model.n_Finisher;
			parameters[26].Value = model.s_Notes;
			parameters[27].Value = model.s_ManualUpdateDeadline;

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
		public bool Update(IPSP.Model.TF_Task model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TF_Task set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_Description=@s_Description,");
			strSql.Append("s_State=@s_State,");
			strSql.Append("s_ReadState=@s_ReadState,");
			strSql.Append("n_Level=@n_Level,");
			strSql.Append("n_UrgencyID=@n_UrgencyID,");
			strSql.Append("n_ExecutorID=@n_ExecutorID,");
			strSql.Append("n_ExecutePositionID=@n_ExecutePositionID,");
			strSql.Append("n_MentorID=@n_MentorID,");
			strSql.Append("dt_FinishTime=@dt_FinishTime,");
			strSql.Append("dt_StartDate=@dt_StartDate,");
			strSql.Append("dt_EndDate=@dt_EndDate,");
			strSql.Append("n_Creator=@n_Creator,");
			strSql.Append("dt_CreateTime=@dt_CreateTime,");
			strSql.Append("n_Editor=@n_Editor,");
			strSql.Append("dt_EditTime=@dt_EditTime,");
			strSql.Append("s_TaskConfigType=@s_TaskConfigType,");
			strSql.Append("n_RelatedDeadlineID=@n_RelatedDeadlineID,");
			strSql.Append("n_MonitorEmployeeID=@n_MonitorEmployeeID,");
			strSql.Append("b_Monitor=@b_Monitor,");
			strSql.Append("s_Note=@s_Note,");
			strSql.Append("n_TaskTypeID=@n_TaskTypeID,");
			strSql.Append("n_Operator=@n_Operator,");
			strSql.Append("g_TaskCycleConfigGuid=@g_TaskCycleConfigGuid,");
			strSql.Append("n_Finisher=@n_Finisher,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("s_ManualUpdateDeadline=@s_ManualUpdateDeadline");
			strSql.Append(" where n_Num=@n_Num");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_State", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ReadState", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Level", SqlDbType.Int,4),
					new SqlParameter("@n_UrgencyID", SqlDbType.Int,4),
					new SqlParameter("@n_ExecutorID", SqlDbType.Int,4),
					new SqlParameter("@n_ExecutePositionID", SqlDbType.Int,4),
					new SqlParameter("@n_MentorID", SqlDbType.Int,4),
					new SqlParameter("@dt_FinishTime", SqlDbType.DateTime),
					new SqlParameter("@dt_StartDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EndDate", SqlDbType.DateTime),
					new SqlParameter("@n_Creator", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@n_Editor", SqlDbType.Int,4),
					new SqlParameter("@dt_EditTime", SqlDbType.DateTime),
					new SqlParameter("@s_TaskConfigType", SqlDbType.NVarChar,100),
					new SqlParameter("@n_RelatedDeadlineID", SqlDbType.Int,4),
					new SqlParameter("@n_MonitorEmployeeID", SqlDbType.Int,4),
					new SqlParameter("@b_Monitor", SqlDbType.Int,4),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_TaskTypeID", SqlDbType.Int,4),
					new SqlParameter("@n_Operator", SqlDbType.Int,4),
					new SqlParameter("@g_TaskCycleConfigGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_Finisher", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_ManualUpdateDeadline", SqlDbType.NVarChar,1),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_Num", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_Description;
			parameters[2].Value = model.s_State;
			parameters[3].Value = model.s_ReadState;
			parameters[4].Value = model.n_Level;
			parameters[5].Value = model.n_UrgencyID;
			parameters[6].Value = model.n_ExecutorID;
			parameters[7].Value = model.n_ExecutePositionID;
			parameters[8].Value = model.n_MentorID;
			parameters[9].Value = model.dt_FinishTime;
			parameters[10].Value = model.dt_StartDate;
			parameters[11].Value = model.dt_EndDate;
			parameters[12].Value = model.n_Creator;
			parameters[13].Value = model.dt_CreateTime;
			parameters[14].Value = model.n_Editor;
			parameters[15].Value = model.dt_EditTime;
			parameters[16].Value = model.s_TaskConfigType;
			parameters[17].Value = model.n_RelatedDeadlineID;
			parameters[18].Value = model.n_MonitorEmployeeID;
			parameters[19].Value = model.b_Monitor;
			parameters[20].Value = model.s_Note;
			parameters[21].Value = model.n_TaskTypeID;
			parameters[22].Value = model.n_Operator;
			parameters[23].Value = model.g_TaskCycleConfigGuid;
			parameters[24].Value = model.n_Finisher;
			parameters[25].Value = model.s_Notes;
			parameters[26].Value = model.s_ManualUpdateDeadline;
			parameters[27].Value = model.g_ID;
			parameters[28].Value = model.n_Num;

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
			strSql.Append("delete from TF_Task ");
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
			strSql.Append("delete from TF_Task ");
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
			strSql.Append("delete from TF_Task ");
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
		public IPSP.Model.TF_Task GetModel(int n_Num)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,s_Name,s_Description,s_State,s_ReadState,n_Level,n_UrgencyID,n_ExecutorID,n_ExecutePositionID,n_MentorID,dt_FinishTime,dt_StartDate,dt_EndDate,n_Creator,dt_CreateTime,n_Editor,dt_EditTime,s_TaskConfigType,n_RelatedDeadlineID,n_MonitorEmployeeID,b_Monitor,s_Note,n_TaskTypeID,n_Operator,g_TaskCycleConfigGuid,n_Num,n_Finisher,s_Notes,s_ManualUpdateDeadline from TF_Task ");
			strSql.Append(" where n_Num=@n_Num");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Num", SqlDbType.Int,4)
			};
			parameters[0].Value = n_Num;

			IPSP.Model.TF_Task model=new IPSP.Model.TF_Task();
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
		public IPSP.Model.TF_Task DataRowToModel(DataRow row)
		{
			IPSP.Model.TF_Task model=new IPSP.Model.TF_Task();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_Description"]!=null)
				{
					model.s_Description=row["s_Description"].ToString();
				}
				if(row["s_State"]!=null)
				{
					model.s_State=row["s_State"].ToString();
				}
				if(row["s_ReadState"]!=null)
				{
					model.s_ReadState=row["s_ReadState"].ToString();
				}
				if(row["n_Level"]!=null && row["n_Level"].ToString()!="")
				{
					model.n_Level=int.Parse(row["n_Level"].ToString());
				}
				if(row["n_UrgencyID"]!=null && row["n_UrgencyID"].ToString()!="")
				{
					model.n_UrgencyID=int.Parse(row["n_UrgencyID"].ToString());
				}
				if(row["n_ExecutorID"]!=null && row["n_ExecutorID"].ToString()!="")
				{
					model.n_ExecutorID=int.Parse(row["n_ExecutorID"].ToString());
				}
				if(row["n_ExecutePositionID"]!=null && row["n_ExecutePositionID"].ToString()!="")
				{
					model.n_ExecutePositionID=int.Parse(row["n_ExecutePositionID"].ToString());
				}
				if(row["n_MentorID"]!=null && row["n_MentorID"].ToString()!="")
				{
					model.n_MentorID=int.Parse(row["n_MentorID"].ToString());
				}
				if(row["dt_FinishTime"]!=null && row["dt_FinishTime"].ToString()!="")
				{
					model.dt_FinishTime=DateTime.Parse(row["dt_FinishTime"].ToString());
				}
				if(row["dt_StartDate"]!=null && row["dt_StartDate"].ToString()!="")
				{
					model.dt_StartDate=DateTime.Parse(row["dt_StartDate"].ToString());
				}
				if(row["dt_EndDate"]!=null && row["dt_EndDate"].ToString()!="")
				{
					model.dt_EndDate=DateTime.Parse(row["dt_EndDate"].ToString());
				}
				if(row["n_Creator"]!=null && row["n_Creator"].ToString()!="")
				{
					model.n_Creator=int.Parse(row["n_Creator"].ToString());
				}
				if(row["dt_CreateTime"]!=null && row["dt_CreateTime"].ToString()!="")
				{
					model.dt_CreateTime=DateTime.Parse(row["dt_CreateTime"].ToString());
				}
				if(row["n_Editor"]!=null && row["n_Editor"].ToString()!="")
				{
					model.n_Editor=int.Parse(row["n_Editor"].ToString());
				}
				if(row["dt_EditTime"]!=null && row["dt_EditTime"].ToString()!="")
				{
					model.dt_EditTime=DateTime.Parse(row["dt_EditTime"].ToString());
				}
				if(row["s_TaskConfigType"]!=null)
				{
					model.s_TaskConfigType=row["s_TaskConfigType"].ToString();
				}
				if(row["n_RelatedDeadlineID"]!=null && row["n_RelatedDeadlineID"].ToString()!="")
				{
					model.n_RelatedDeadlineID=int.Parse(row["n_RelatedDeadlineID"].ToString());
				}
				if(row["n_MonitorEmployeeID"]!=null && row["n_MonitorEmployeeID"].ToString()!="")
				{
					model.n_MonitorEmployeeID=int.Parse(row["n_MonitorEmployeeID"].ToString());
				}
				if(row["b_Monitor"]!=null && row["b_Monitor"].ToString()!="")
				{
					model.b_Monitor=int.Parse(row["b_Monitor"].ToString());
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
				}
				if(row["n_TaskTypeID"]!=null && row["n_TaskTypeID"].ToString()!="")
				{
					model.n_TaskTypeID=int.Parse(row["n_TaskTypeID"].ToString());
				}
				if(row["n_Operator"]!=null && row["n_Operator"].ToString()!="")
				{
					model.n_Operator=int.Parse(row["n_Operator"].ToString());
				}
				if(row["g_TaskCycleConfigGuid"]!=null && row["g_TaskCycleConfigGuid"].ToString()!="")
				{
					model.g_TaskCycleConfigGuid= new Guid(row["g_TaskCycleConfigGuid"].ToString());
				}
				if(row["n_Num"]!=null && row["n_Num"].ToString()!="")
				{
					model.n_Num=int.Parse(row["n_Num"].ToString());
				}
				if(row["n_Finisher"]!=null && row["n_Finisher"].ToString()!="")
				{
					model.n_Finisher=int.Parse(row["n_Finisher"].ToString());
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["s_ManualUpdateDeadline"]!=null)
				{
					model.s_ManualUpdateDeadline=row["s_ManualUpdateDeadline"].ToString();
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
			strSql.Append("select g_ID,s_Name,s_Description,s_State,s_ReadState,n_Level,n_UrgencyID,n_ExecutorID,n_ExecutePositionID,n_MentorID,dt_FinishTime,dt_StartDate,dt_EndDate,n_Creator,dt_CreateTime,n_Editor,dt_EditTime,s_TaskConfigType,n_RelatedDeadlineID,n_MonitorEmployeeID,b_Monitor,s_Note,n_TaskTypeID,n_Operator,g_TaskCycleConfigGuid,n_Num,n_Finisher,s_Notes,s_ManualUpdateDeadline ");
			strSql.Append(" FROM TF_Task ");
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
			strSql.Append(" g_ID,s_Name,s_Description,s_State,s_ReadState,n_Level,n_UrgencyID,n_ExecutorID,n_ExecutePositionID,n_MentorID,dt_FinishTime,dt_StartDate,dt_EndDate,n_Creator,dt_CreateTime,n_Editor,dt_EditTime,s_TaskConfigType,n_RelatedDeadlineID,n_MonitorEmployeeID,b_Monitor,s_Note,n_TaskTypeID,n_Operator,g_TaskCycleConfigGuid,n_Num,n_Finisher,s_Notes,s_ManualUpdateDeadline ");
			strSql.Append(" FROM TF_Task ");
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
			strSql.Append("select count(1) FROM TF_Task ");
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
			strSql.Append(")AS Row, T.*  from TF_Task T ");
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
			parameters[0].Value = "TF_Task";
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

