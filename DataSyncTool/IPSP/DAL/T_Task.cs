/**  版本信息模板在安装目录下，可自行修改。
* T_Task.cs
*
* 功 能： N/A
* 类 名： T_Task
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:06   N/A    初版
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
	/// 数据访问类:T_Task
	/// </summary>
	public partial class T_Task
	{
		public T_Task()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_FileID", "T_Task"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_FileID,int n_OutFileID,int n_FeeID,int n_BillID,int n_TaskID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Task");
			strSql.Append(" where n_FileID=@n_FileID and n_OutFileID=@n_OutFileID and n_FeeID=@n_FeeID and n_BillID=@n_BillID and n_TaskID=@n_TaskID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@n_OutFileID", SqlDbType.Int,4),
					new SqlParameter("@n_FeeID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_TaskID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;
			parameters[1].Value = n_OutFileID;
			parameters[2].Value = n_FeeID;
			parameters[3].Value = n_BillID;
			parameters[4].Value = n_TaskID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_Task model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Task(");
			strSql.Append("s_TaskType,n_SysTaskCodeID,n_EmployeeID,s_TaskToEmail,s_Level,s_TaskName,s_TaskDetail,dt_AlarmDate,dt_InterDeadline,dt_ClientDeadline,dt_OfficialDeadline,dt_Deadline,s_Status,dt_StatusDate,s_IsActive,dt_CreateDate,dt_EditDate,n_FileID,s_TaskTo,n_CameFileID,n_OutFileID,n_FeeID,n_BillID,s_Applicants,s_CaseSerial,s_Country,s_AppNo,s_Introducer,s_Attorney,s_Creator,s_Editor,s_InRecycle,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,s_TaskResult,n_MainCaseID,s_Category,s_RenewalDeadline)");
			strSql.Append(" values (");
			strSql.Append("@s_TaskType,@n_SysTaskCodeID,@n_EmployeeID,@s_TaskToEmail,@s_Level,@s_TaskName,@s_TaskDetail,@dt_AlarmDate,@dt_InterDeadline,@dt_ClientDeadline,@dt_OfficialDeadline,@dt_Deadline,@s_Status,@dt_StatusDate,@s_IsActive,@dt_CreateDate,@dt_EditDate,@n_FileID,@s_TaskTo,@n_CameFileID,@n_OutFileID,@n_FeeID,@n_BillID,@s_Applicants,@s_CaseSerial,@s_Country,@s_AppNo,@s_Introducer,@s_Attorney,@s_Creator,@s_Editor,@s_InRecycle,@n_ModuleCheckStatusID,@n_LatestCheckInfoID,@n_AuthorID,@n_CurCheckerID,@s_TaskResult,@n_MainCaseID,@s_Category,@s_RenewalDeadline)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_TaskType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_SysTaskCodeID", SqlDbType.Int,4),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@s_TaskToEmail", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Level", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TaskName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_TaskDetail", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_AlarmDate", SqlDbType.DateTime),
					new SqlParameter("@dt_InterDeadline", SqlDbType.DateTime),
					new SqlParameter("@dt_ClientDeadline", SqlDbType.DateTime),
					new SqlParameter("@dt_OfficialDeadline", SqlDbType.DateTime),
					new SqlParameter("@dt_Deadline", SqlDbType.DateTime),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_StatusDate", SqlDbType.DateTime),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@s_TaskTo", SqlDbType.NVarChar,50),
					new SqlParameter("@n_CameFileID", SqlDbType.Int,4),
					new SqlParameter("@n_OutFileID", SqlDbType.Int,4),
					new SqlParameter("@n_FeeID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@s_Applicants", SqlDbType.VarChar,1000),
					new SqlParameter("@s_CaseSerial", SqlDbType.VarChar,100),
					new SqlParameter("@s_Country", SqlDbType.VarChar,100),
					new SqlParameter("@s_AppNo", SqlDbType.VarChar,100),
					new SqlParameter("@s_Introducer", SqlDbType.VarChar,300),
					new SqlParameter("@s_Attorney", SqlDbType.VarChar,200),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_InRecycle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ModuleCheckStatusID", SqlDbType.Int,4),
					new SqlParameter("@n_LatestCheckInfoID", SqlDbType.Int,4),
					new SqlParameter("@n_AuthorID", SqlDbType.Int,4),
					new SqlParameter("@n_CurCheckerID", SqlDbType.Int,4),
					new SqlParameter("@s_TaskResult", SqlDbType.NVarChar,500),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@s_Category", SqlDbType.NVarChar,100),
					new SqlParameter("@s_RenewalDeadline", SqlDbType.NVarChar,2)};
			parameters[0].Value = model.s_TaskType;
			parameters[1].Value = model.n_SysTaskCodeID;
			parameters[2].Value = model.n_EmployeeID;
			parameters[3].Value = model.s_TaskToEmail;
			parameters[4].Value = model.s_Level;
			parameters[5].Value = model.s_TaskName;
			parameters[6].Value = model.s_TaskDetail;
			parameters[7].Value = model.dt_AlarmDate;
			parameters[8].Value = model.dt_InterDeadline;
			parameters[9].Value = model.dt_ClientDeadline;
			parameters[10].Value = model.dt_OfficialDeadline;
			parameters[11].Value = model.dt_Deadline;
			parameters[12].Value = model.s_Status;
			parameters[13].Value = model.dt_StatusDate;
			parameters[14].Value = model.s_IsActive;
			parameters[15].Value = model.dt_CreateDate;
			parameters[16].Value = model.dt_EditDate;
			parameters[17].Value = model.n_FileID;
			parameters[18].Value = model.s_TaskTo;
			parameters[19].Value = model.n_CameFileID;
			parameters[20].Value = model.n_OutFileID;
			parameters[21].Value = model.n_FeeID;
			parameters[22].Value = model.n_BillID;
			parameters[23].Value = model.s_Applicants;
			parameters[24].Value = model.s_CaseSerial;
			parameters[25].Value = model.s_Country;
			parameters[26].Value = model.s_AppNo;
			parameters[27].Value = model.s_Introducer;
			parameters[28].Value = model.s_Attorney;
			parameters[29].Value = model.s_Creator;
			parameters[30].Value = model.s_Editor;
			parameters[31].Value = model.s_InRecycle;
			parameters[32].Value = model.n_ModuleCheckStatusID;
			parameters[33].Value = model.n_LatestCheckInfoID;
			parameters[34].Value = model.n_AuthorID;
			parameters[35].Value = model.n_CurCheckerID;
			parameters[36].Value = model.s_TaskResult;
			parameters[37].Value = model.n_MainCaseID;
			parameters[38].Value = model.s_Category;
			parameters[39].Value = model.s_RenewalDeadline;

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
		public bool Update(IPSP.Model.T_Task model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Task set ");
			strSql.Append("s_TaskType=@s_TaskType,");
			strSql.Append("n_SysTaskCodeID=@n_SysTaskCodeID,");
			strSql.Append("n_EmployeeID=@n_EmployeeID,");
			strSql.Append("s_TaskToEmail=@s_TaskToEmail,");
			strSql.Append("s_Level=@s_Level,");
			strSql.Append("s_TaskName=@s_TaskName,");
			strSql.Append("s_TaskDetail=@s_TaskDetail,");
			strSql.Append("dt_AlarmDate=@dt_AlarmDate,");
			strSql.Append("dt_InterDeadline=@dt_InterDeadline,");
			strSql.Append("dt_ClientDeadline=@dt_ClientDeadline,");
			strSql.Append("dt_OfficialDeadline=@dt_OfficialDeadline,");
			strSql.Append("dt_Deadline=@dt_Deadline,");
			strSql.Append("s_Status=@s_Status,");
			strSql.Append("dt_StatusDate=@dt_StatusDate,");
			strSql.Append("s_IsActive=@s_IsActive,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_TaskTo=@s_TaskTo,");
			strSql.Append("n_CameFileID=@n_CameFileID,");
			strSql.Append("s_Applicants=@s_Applicants,");
			strSql.Append("s_CaseSerial=@s_CaseSerial,");
			strSql.Append("s_Country=@s_Country,");
			strSql.Append("s_AppNo=@s_AppNo,");
			strSql.Append("s_Introducer=@s_Introducer,");
			strSql.Append("s_Attorney=@s_Attorney,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("s_InRecycle=@s_InRecycle,");
			strSql.Append("n_ModuleCheckStatusID=@n_ModuleCheckStatusID,");
			strSql.Append("n_LatestCheckInfoID=@n_LatestCheckInfoID,");
			strSql.Append("n_AuthorID=@n_AuthorID,");
			strSql.Append("n_CurCheckerID=@n_CurCheckerID,");
			strSql.Append("s_TaskResult=@s_TaskResult,");
			strSql.Append("n_MainCaseID=@n_MainCaseID,");
			strSql.Append("s_Category=@s_Category,");
			strSql.Append("s_RenewalDeadline=@s_RenewalDeadline");
			strSql.Append(" where n_TaskID=@n_TaskID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_TaskType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_SysTaskCodeID", SqlDbType.Int,4),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@s_TaskToEmail", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Level", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TaskName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_TaskDetail", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_AlarmDate", SqlDbType.DateTime),
					new SqlParameter("@dt_InterDeadline", SqlDbType.DateTime),
					new SqlParameter("@dt_ClientDeadline", SqlDbType.DateTime),
					new SqlParameter("@dt_OfficialDeadline", SqlDbType.DateTime),
					new SqlParameter("@dt_Deadline", SqlDbType.DateTime),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_StatusDate", SqlDbType.DateTime),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_TaskTo", SqlDbType.NVarChar,50),
					new SqlParameter("@n_CameFileID", SqlDbType.Int,4),
					new SqlParameter("@s_Applicants", SqlDbType.VarChar,1000),
					new SqlParameter("@s_CaseSerial", SqlDbType.VarChar,100),
					new SqlParameter("@s_Country", SqlDbType.VarChar,100),
					new SqlParameter("@s_AppNo", SqlDbType.VarChar,100),
					new SqlParameter("@s_Introducer", SqlDbType.VarChar,300),
					new SqlParameter("@s_Attorney", SqlDbType.VarChar,200),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_InRecycle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ModuleCheckStatusID", SqlDbType.Int,4),
					new SqlParameter("@n_LatestCheckInfoID", SqlDbType.Int,4),
					new SqlParameter("@n_AuthorID", SqlDbType.Int,4),
					new SqlParameter("@n_CurCheckerID", SqlDbType.Int,4),
					new SqlParameter("@s_TaskResult", SqlDbType.NVarChar,500),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@s_Category", SqlDbType.NVarChar,100),
					new SqlParameter("@s_RenewalDeadline", SqlDbType.NVarChar,2),
					new SqlParameter("@n_TaskID", SqlDbType.Int,4),
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@n_OutFileID", SqlDbType.Int,4),
					new SqlParameter("@n_FeeID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_TaskType;
			parameters[1].Value = model.n_SysTaskCodeID;
			parameters[2].Value = model.n_EmployeeID;
			parameters[3].Value = model.s_TaskToEmail;
			parameters[4].Value = model.s_Level;
			parameters[5].Value = model.s_TaskName;
			parameters[6].Value = model.s_TaskDetail;
			parameters[7].Value = model.dt_AlarmDate;
			parameters[8].Value = model.dt_InterDeadline;
			parameters[9].Value = model.dt_ClientDeadline;
			parameters[10].Value = model.dt_OfficialDeadline;
			parameters[11].Value = model.dt_Deadline;
			parameters[12].Value = model.s_Status;
			parameters[13].Value = model.dt_StatusDate;
			parameters[14].Value = model.s_IsActive;
			parameters[15].Value = model.dt_CreateDate;
			parameters[16].Value = model.dt_EditDate;
			parameters[17].Value = model.s_TaskTo;
			parameters[18].Value = model.n_CameFileID;
			parameters[19].Value = model.s_Applicants;
			parameters[20].Value = model.s_CaseSerial;
			parameters[21].Value = model.s_Country;
			parameters[22].Value = model.s_AppNo;
			parameters[23].Value = model.s_Introducer;
			parameters[24].Value = model.s_Attorney;
			parameters[25].Value = model.s_Creator;
			parameters[26].Value = model.s_Editor;
			parameters[27].Value = model.s_InRecycle;
			parameters[28].Value = model.n_ModuleCheckStatusID;
			parameters[29].Value = model.n_LatestCheckInfoID;
			parameters[30].Value = model.n_AuthorID;
			parameters[31].Value = model.n_CurCheckerID;
			parameters[32].Value = model.s_TaskResult;
			parameters[33].Value = model.n_MainCaseID;
			parameters[34].Value = model.s_Category;
			parameters[35].Value = model.s_RenewalDeadline;
			parameters[36].Value = model.n_TaskID;
			parameters[37].Value = model.n_FileID;
			parameters[38].Value = model.n_OutFileID;
			parameters[39].Value = model.n_FeeID;
			parameters[40].Value = model.n_BillID;

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
		public bool Delete(int n_TaskID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Task ");
			strSql.Append(" where n_TaskID=@n_TaskID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_TaskID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_TaskID;

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
		public bool Delete(int n_FileID,int n_OutFileID,int n_FeeID,int n_BillID,int n_TaskID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Task ");
			strSql.Append(" where n_FileID=@n_FileID and n_OutFileID=@n_OutFileID and n_FeeID=@n_FeeID and n_BillID=@n_BillID and n_TaskID=@n_TaskID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@n_OutFileID", SqlDbType.Int,4),
					new SqlParameter("@n_FeeID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_TaskID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;
			parameters[1].Value = n_OutFileID;
			parameters[2].Value = n_FeeID;
			parameters[3].Value = n_BillID;
			parameters[4].Value = n_TaskID;

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
		public bool DeleteList(string n_TaskIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Task ");
			strSql.Append(" where n_TaskID in ("+n_TaskIDlist + ")  ");
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
		public IPSP.Model.T_Task GetModel(int n_TaskID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_TaskID,s_TaskType,n_SysTaskCodeID,n_EmployeeID,s_TaskToEmail,s_Level,s_TaskName,s_TaskDetail,dt_AlarmDate,dt_InterDeadline,dt_ClientDeadline,dt_OfficialDeadline,dt_Deadline,s_Status,dt_StatusDate,s_IsActive,dt_CreateDate,dt_EditDate,n_FileID,s_TaskTo,n_CameFileID,n_OutFileID,n_FeeID,n_BillID,s_Applicants,s_CaseSerial,s_Country,s_AppNo,s_Introducer,s_Attorney,s_Creator,s_Editor,s_InRecycle,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,s_TaskResult,n_MainCaseID,s_Category,s_RenewalDeadline from T_Task ");
			strSql.Append(" where n_TaskID=@n_TaskID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_TaskID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_TaskID;

			IPSP.Model.T_Task model=new IPSP.Model.T_Task();
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
		public IPSP.Model.T_Task DataRowToModel(DataRow row)
		{
			IPSP.Model.T_Task model=new IPSP.Model.T_Task();
			if (row != null)
			{
				if(row["n_TaskID"]!=null && row["n_TaskID"].ToString()!="")
				{
					model.n_TaskID=int.Parse(row["n_TaskID"].ToString());
				}
				if(row["s_TaskType"]!=null)
				{
					model.s_TaskType=row["s_TaskType"].ToString();
				}
				if(row["n_SysTaskCodeID"]!=null && row["n_SysTaskCodeID"].ToString()!="")
				{
					model.n_SysTaskCodeID=int.Parse(row["n_SysTaskCodeID"].ToString());
				}
				if(row["n_EmployeeID"]!=null && row["n_EmployeeID"].ToString()!="")
				{
					model.n_EmployeeID=int.Parse(row["n_EmployeeID"].ToString());
				}
				if(row["s_TaskToEmail"]!=null)
				{
					model.s_TaskToEmail=row["s_TaskToEmail"].ToString();
				}
				if(row["s_Level"]!=null)
				{
					model.s_Level=row["s_Level"].ToString();
				}
				if(row["s_TaskName"]!=null)
				{
					model.s_TaskName=row["s_TaskName"].ToString();
				}
				if(row["s_TaskDetail"]!=null)
				{
					model.s_TaskDetail=row["s_TaskDetail"].ToString();
				}
				if(row["dt_AlarmDate"]!=null && row["dt_AlarmDate"].ToString()!="")
				{
					model.dt_AlarmDate=DateTime.Parse(row["dt_AlarmDate"].ToString());
				}
				if(row["dt_InterDeadline"]!=null && row["dt_InterDeadline"].ToString()!="")
				{
					model.dt_InterDeadline=DateTime.Parse(row["dt_InterDeadline"].ToString());
				}
				if(row["dt_ClientDeadline"]!=null && row["dt_ClientDeadline"].ToString()!="")
				{
					model.dt_ClientDeadline=DateTime.Parse(row["dt_ClientDeadline"].ToString());
				}
				if(row["dt_OfficialDeadline"]!=null && row["dt_OfficialDeadline"].ToString()!="")
				{
					model.dt_OfficialDeadline=DateTime.Parse(row["dt_OfficialDeadline"].ToString());
				}
				if(row["dt_Deadline"]!=null && row["dt_Deadline"].ToString()!="")
				{
					model.dt_Deadline=DateTime.Parse(row["dt_Deadline"].ToString());
				}
				if(row["s_Status"]!=null)
				{
					model.s_Status=row["s_Status"].ToString();
				}
				if(row["dt_StatusDate"]!=null && row["dt_StatusDate"].ToString()!="")
				{
					model.dt_StatusDate=DateTime.Parse(row["dt_StatusDate"].ToString());
				}
				if(row["s_IsActive"]!=null)
				{
					model.s_IsActive=row["s_IsActive"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["n_FileID"]!=null && row["n_FileID"].ToString()!="")
				{
					model.n_FileID=int.Parse(row["n_FileID"].ToString());
				}
				if(row["s_TaskTo"]!=null)
				{
					model.s_TaskTo=row["s_TaskTo"].ToString();
				}
				if(row["n_CameFileID"]!=null && row["n_CameFileID"].ToString()!="")
				{
					model.n_CameFileID=int.Parse(row["n_CameFileID"].ToString());
				}
				if(row["n_OutFileID"]!=null && row["n_OutFileID"].ToString()!="")
				{
					model.n_OutFileID=int.Parse(row["n_OutFileID"].ToString());
				}
				if(row["n_FeeID"]!=null && row["n_FeeID"].ToString()!="")
				{
					model.n_FeeID=int.Parse(row["n_FeeID"].ToString());
				}
				if(row["n_BillID"]!=null && row["n_BillID"].ToString()!="")
				{
					model.n_BillID=int.Parse(row["n_BillID"].ToString());
				}
				if(row["s_Applicants"]!=null)
				{
					model.s_Applicants=row["s_Applicants"].ToString();
				}
				if(row["s_CaseSerial"]!=null)
				{
					model.s_CaseSerial=row["s_CaseSerial"].ToString();
				}
				if(row["s_Country"]!=null)
				{
					model.s_Country=row["s_Country"].ToString();
				}
				if(row["s_AppNo"]!=null)
				{
					model.s_AppNo=row["s_AppNo"].ToString();
				}
				if(row["s_Introducer"]!=null)
				{
					model.s_Introducer=row["s_Introducer"].ToString();
				}
				if(row["s_Attorney"]!=null)
				{
					model.s_Attorney=row["s_Attorney"].ToString();
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["s_InRecycle"]!=null)
				{
					model.s_InRecycle=row["s_InRecycle"].ToString();
				}
				if(row["n_ModuleCheckStatusID"]!=null && row["n_ModuleCheckStatusID"].ToString()!="")
				{
					model.n_ModuleCheckStatusID=int.Parse(row["n_ModuleCheckStatusID"].ToString());
				}
				if(row["n_LatestCheckInfoID"]!=null && row["n_LatestCheckInfoID"].ToString()!="")
				{
					model.n_LatestCheckInfoID=int.Parse(row["n_LatestCheckInfoID"].ToString());
				}
				if(row["n_AuthorID"]!=null && row["n_AuthorID"].ToString()!="")
				{
					model.n_AuthorID=int.Parse(row["n_AuthorID"].ToString());
				}
				if(row["n_CurCheckerID"]!=null && row["n_CurCheckerID"].ToString()!="")
				{
					model.n_CurCheckerID=int.Parse(row["n_CurCheckerID"].ToString());
				}
				if(row["s_TaskResult"]!=null)
				{
					model.s_TaskResult=row["s_TaskResult"].ToString();
				}
				if(row["n_MainCaseID"]!=null && row["n_MainCaseID"].ToString()!="")
				{
					model.n_MainCaseID=int.Parse(row["n_MainCaseID"].ToString());
				}
				if(row["s_Category"]!=null)
				{
					model.s_Category=row["s_Category"].ToString();
				}
				if(row["s_RenewalDeadline"]!=null)
				{
					model.s_RenewalDeadline=row["s_RenewalDeadline"].ToString();
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
			strSql.Append("select n_TaskID,s_TaskType,n_SysTaskCodeID,n_EmployeeID,s_TaskToEmail,s_Level,s_TaskName,s_TaskDetail,dt_AlarmDate,dt_InterDeadline,dt_ClientDeadline,dt_OfficialDeadline,dt_Deadline,s_Status,dt_StatusDate,s_IsActive,dt_CreateDate,dt_EditDate,n_FileID,s_TaskTo,n_CameFileID,n_OutFileID,n_FeeID,n_BillID,s_Applicants,s_CaseSerial,s_Country,s_AppNo,s_Introducer,s_Attorney,s_Creator,s_Editor,s_InRecycle,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,s_TaskResult,n_MainCaseID,s_Category,s_RenewalDeadline ");
			strSql.Append(" FROM T_Task ");
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
			strSql.Append(" n_TaskID,s_TaskType,n_SysTaskCodeID,n_EmployeeID,s_TaskToEmail,s_Level,s_TaskName,s_TaskDetail,dt_AlarmDate,dt_InterDeadline,dt_ClientDeadline,dt_OfficialDeadline,dt_Deadline,s_Status,dt_StatusDate,s_IsActive,dt_CreateDate,dt_EditDate,n_FileID,s_TaskTo,n_CameFileID,n_OutFileID,n_FeeID,n_BillID,s_Applicants,s_CaseSerial,s_Country,s_AppNo,s_Introducer,s_Attorney,s_Creator,s_Editor,s_InRecycle,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,s_TaskResult,n_MainCaseID,s_Category,s_RenewalDeadline ");
			strSql.Append(" FROM T_Task ");
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
			strSql.Append("select count(1) FROM T_Task ");
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
				strSql.Append("order by T.n_TaskID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Task T ");
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
			parameters[0].Value = "T_Task";
			parameters[1].Value = "n_TaskID";
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

