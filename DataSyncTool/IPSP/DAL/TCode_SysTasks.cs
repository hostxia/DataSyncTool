/**  版本信息模板在安装目录下，可自行修改。
* TCode_SysTasks.cs
*
* 功 能： N/A
* 类 名： TCode_SysTasks
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:08   N/A    初版
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
	/// 数据访问类:TCode_SysTasks
	/// </summary>
	public partial class TCode_SysTasks
	{
		public TCode_SysTasks()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TCode_SysTasks"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_SysTasks");
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
		public int Add(IPSP.Model.TCode_SysTasks model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_SysTasks(");
			strSql.Append("s_IPType,n_RegCountry,s_SysTaskCode,s_TaskName,s_OtherName,s_TaskDesc,s_Business,s_PTCType,n_ProcessID,s_IsActive,s_BaseField,n_AlarmDays,n_AlarmMonths,s_AlarmCalcOrder,n_OfficialDeadDays,n_OfficialDeadMonths,s_OfficialDeadCalcOrder,n_ClientDeadDays,n_ClientDeadMonths,s_ClientDeadCalcOrder,n_InterDeadDays,n_InterDeadMonths,s_InterDeadCalcOrder,s_TaskType,n_EmployeeID,s_SysConfigureTask,dt_CreateDate,dt_EditDate,s_TApplyType,s_OfficialDeadM,s_ClientDeadM,s_InterDeadM,s_Dealer,s_IsSystem,s_AutoSendEmail,s_Priority,s_ChangeDateSendEmail,s_RelatedElement,s_RelatedElementStatus,s_AutoFinished,s_RemindWithCreating,s_Relationer,s_Category,s_SysTaskType,s_SysFlowDirection)");
			strSql.Append(" values (");
			strSql.Append("@s_IPType,@n_RegCountry,@s_SysTaskCode,@s_TaskName,@s_OtherName,@s_TaskDesc,@s_Business,@s_PTCType,@n_ProcessID,@s_IsActive,@s_BaseField,@n_AlarmDays,@n_AlarmMonths,@s_AlarmCalcOrder,@n_OfficialDeadDays,@n_OfficialDeadMonths,@s_OfficialDeadCalcOrder,@n_ClientDeadDays,@n_ClientDeadMonths,@s_ClientDeadCalcOrder,@n_InterDeadDays,@n_InterDeadMonths,@s_InterDeadCalcOrder,@s_TaskType,@n_EmployeeID,@s_SysConfigureTask,@dt_CreateDate,@dt_EditDate,@s_TApplyType,@s_OfficialDeadM,@s_ClientDeadM,@s_InterDeadM,@s_Dealer,@s_IsSystem,@s_AutoSendEmail,@s_Priority,@s_ChangeDateSendEmail,@s_RelatedElement,@s_RelatedElementStatus,@s_AutoFinished,@s_RemindWithCreating,@s_Relationer,@s_Category,@s_SysTaskType,@s_SysFlowDirection)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_RegCountry", SqlDbType.Int,4),
					new SqlParameter("@s_SysTaskCode", SqlDbType.NVarChar,8),
					new SqlParameter("@s_TaskName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_TaskDesc", SqlDbType.NVarChar,600),
					new SqlParameter("@s_Business", SqlDbType.NVarChar,500),
					new SqlParameter("@s_PTCType", SqlDbType.NVarChar,500),
					new SqlParameter("@n_ProcessID", SqlDbType.Int,4),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@s_BaseField", SqlDbType.NVarChar,300),
					new SqlParameter("@n_AlarmDays", SqlDbType.Int,4),
					new SqlParameter("@n_AlarmMonths", SqlDbType.Int,4),
					new SqlParameter("@s_AlarmCalcOrder", SqlDbType.NVarChar,2),
					new SqlParameter("@n_OfficialDeadDays", SqlDbType.Int,4),
					new SqlParameter("@n_OfficialDeadMonths", SqlDbType.Int,4),
					new SqlParameter("@s_OfficialDeadCalcOrder", SqlDbType.NVarChar,2),
					new SqlParameter("@n_ClientDeadDays", SqlDbType.Int,4),
					new SqlParameter("@n_ClientDeadMonths", SqlDbType.Int,4),
					new SqlParameter("@s_ClientDeadCalcOrder", SqlDbType.NVarChar,2),
					new SqlParameter("@n_InterDeadDays", SqlDbType.Int,4),
					new SqlParameter("@n_InterDeadMonths", SqlDbType.Int,4),
					new SqlParameter("@s_InterDeadCalcOrder", SqlDbType.NVarChar,2),
					new SqlParameter("@s_TaskType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@s_SysConfigureTask", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_TApplyType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OfficialDeadM", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ClientDeadM", SqlDbType.NVarChar,1),
					new SqlParameter("@s_InterDeadM", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Dealer", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IsSystem", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AutoSendEmail", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Priority", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ChangeDateSendEmail", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RelatedElement", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RelatedElementStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@s_AutoFinished", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RemindWithCreating", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Relationer", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Category", SqlDbType.NVarChar,32),
					new SqlParameter("@s_SysTaskType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_SysFlowDirection", SqlDbType.NVarChar,300)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.n_RegCountry;
			parameters[2].Value = model.s_SysTaskCode;
			parameters[3].Value = model.s_TaskName;
			parameters[4].Value = model.s_OtherName;
			parameters[5].Value = model.s_TaskDesc;
			parameters[6].Value = model.s_Business;
			parameters[7].Value = model.s_PTCType;
			parameters[8].Value = model.n_ProcessID;
			parameters[9].Value = model.s_IsActive;
			parameters[10].Value = model.s_BaseField;
			parameters[11].Value = model.n_AlarmDays;
			parameters[12].Value = model.n_AlarmMonths;
			parameters[13].Value = model.s_AlarmCalcOrder;
			parameters[14].Value = model.n_OfficialDeadDays;
			parameters[15].Value = model.n_OfficialDeadMonths;
			parameters[16].Value = model.s_OfficialDeadCalcOrder;
			parameters[17].Value = model.n_ClientDeadDays;
			parameters[18].Value = model.n_ClientDeadMonths;
			parameters[19].Value = model.s_ClientDeadCalcOrder;
			parameters[20].Value = model.n_InterDeadDays;
			parameters[21].Value = model.n_InterDeadMonths;
			parameters[22].Value = model.s_InterDeadCalcOrder;
			parameters[23].Value = model.s_TaskType;
			parameters[24].Value = model.n_EmployeeID;
			parameters[25].Value = model.s_SysConfigureTask;
			parameters[26].Value = model.dt_CreateDate;
			parameters[27].Value = model.dt_EditDate;
			parameters[28].Value = model.s_TApplyType;
			parameters[29].Value = model.s_OfficialDeadM;
			parameters[30].Value = model.s_ClientDeadM;
			parameters[31].Value = model.s_InterDeadM;
			parameters[32].Value = model.s_Dealer;
			parameters[33].Value = model.s_IsSystem;
			parameters[34].Value = model.s_AutoSendEmail;
			parameters[35].Value = model.s_Priority;
			parameters[36].Value = model.s_ChangeDateSendEmail;
			parameters[37].Value = model.s_RelatedElement;
			parameters[38].Value = model.s_RelatedElementStatus;
			parameters[39].Value = model.s_AutoFinished;
			parameters[40].Value = model.s_RemindWithCreating;
			parameters[41].Value = model.s_Relationer;
			parameters[42].Value = model.s_Category;
			parameters[43].Value = model.s_SysTaskType;
			parameters[44].Value = model.s_SysFlowDirection;

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
		public bool Update(IPSP.Model.TCode_SysTasks model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_SysTasks set ");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("n_RegCountry=@n_RegCountry,");
			strSql.Append("s_SysTaskCode=@s_SysTaskCode,");
			strSql.Append("s_TaskName=@s_TaskName,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("s_TaskDesc=@s_TaskDesc,");
			strSql.Append("s_Business=@s_Business,");
			strSql.Append("s_PTCType=@s_PTCType,");
			strSql.Append("n_ProcessID=@n_ProcessID,");
			strSql.Append("s_IsActive=@s_IsActive,");
			strSql.Append("s_BaseField=@s_BaseField,");
			strSql.Append("n_AlarmDays=@n_AlarmDays,");
			strSql.Append("n_AlarmMonths=@n_AlarmMonths,");
			strSql.Append("s_AlarmCalcOrder=@s_AlarmCalcOrder,");
			strSql.Append("n_OfficialDeadDays=@n_OfficialDeadDays,");
			strSql.Append("n_OfficialDeadMonths=@n_OfficialDeadMonths,");
			strSql.Append("s_OfficialDeadCalcOrder=@s_OfficialDeadCalcOrder,");
			strSql.Append("n_ClientDeadDays=@n_ClientDeadDays,");
			strSql.Append("n_ClientDeadMonths=@n_ClientDeadMonths,");
			strSql.Append("s_ClientDeadCalcOrder=@s_ClientDeadCalcOrder,");
			strSql.Append("n_InterDeadDays=@n_InterDeadDays,");
			strSql.Append("n_InterDeadMonths=@n_InterDeadMonths,");
			strSql.Append("s_InterDeadCalcOrder=@s_InterDeadCalcOrder,");
			strSql.Append("s_TaskType=@s_TaskType,");
			strSql.Append("n_EmployeeID=@n_EmployeeID,");
			strSql.Append("s_SysConfigureTask=@s_SysConfigureTask,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_TApplyType=@s_TApplyType,");
			strSql.Append("s_OfficialDeadM=@s_OfficialDeadM,");
			strSql.Append("s_ClientDeadM=@s_ClientDeadM,");
			strSql.Append("s_InterDeadM=@s_InterDeadM,");
			strSql.Append("s_Dealer=@s_Dealer,");
			strSql.Append("s_IsSystem=@s_IsSystem,");
			strSql.Append("s_AutoSendEmail=@s_AutoSendEmail,");
			strSql.Append("s_Priority=@s_Priority,");
			strSql.Append("s_ChangeDateSendEmail=@s_ChangeDateSendEmail,");
			strSql.Append("s_RelatedElement=@s_RelatedElement,");
			strSql.Append("s_RelatedElementStatus=@s_RelatedElementStatus,");
			strSql.Append("s_AutoFinished=@s_AutoFinished,");
			strSql.Append("s_RemindWithCreating=@s_RemindWithCreating,");
			strSql.Append("s_Relationer=@s_Relationer,");
			strSql.Append("s_Category=@s_Category,");
			strSql.Append("s_SysTaskType=@s_SysTaskType,");
			strSql.Append("s_SysFlowDirection=@s_SysFlowDirection");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_RegCountry", SqlDbType.Int,4),
					new SqlParameter("@s_SysTaskCode", SqlDbType.NVarChar,8),
					new SqlParameter("@s_TaskName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_TaskDesc", SqlDbType.NVarChar,600),
					new SqlParameter("@s_Business", SqlDbType.NVarChar,500),
					new SqlParameter("@s_PTCType", SqlDbType.NVarChar,500),
					new SqlParameter("@n_ProcessID", SqlDbType.Int,4),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@s_BaseField", SqlDbType.NVarChar,300),
					new SqlParameter("@n_AlarmDays", SqlDbType.Int,4),
					new SqlParameter("@n_AlarmMonths", SqlDbType.Int,4),
					new SqlParameter("@s_AlarmCalcOrder", SqlDbType.NVarChar,2),
					new SqlParameter("@n_OfficialDeadDays", SqlDbType.Int,4),
					new SqlParameter("@n_OfficialDeadMonths", SqlDbType.Int,4),
					new SqlParameter("@s_OfficialDeadCalcOrder", SqlDbType.NVarChar,2),
					new SqlParameter("@n_ClientDeadDays", SqlDbType.Int,4),
					new SqlParameter("@n_ClientDeadMonths", SqlDbType.Int,4),
					new SqlParameter("@s_ClientDeadCalcOrder", SqlDbType.NVarChar,2),
					new SqlParameter("@n_InterDeadDays", SqlDbType.Int,4),
					new SqlParameter("@n_InterDeadMonths", SqlDbType.Int,4),
					new SqlParameter("@s_InterDeadCalcOrder", SqlDbType.NVarChar,2),
					new SqlParameter("@s_TaskType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@s_SysConfigureTask", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_TApplyType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OfficialDeadM", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ClientDeadM", SqlDbType.NVarChar,1),
					new SqlParameter("@s_InterDeadM", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Dealer", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IsSystem", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AutoSendEmail", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Priority", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ChangeDateSendEmail", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RelatedElement", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RelatedElementStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@s_AutoFinished", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RemindWithCreating", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Relationer", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Category", SqlDbType.NVarChar,32),
					new SqlParameter("@s_SysTaskType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_SysFlowDirection", SqlDbType.NVarChar,300),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.n_RegCountry;
			parameters[2].Value = model.s_SysTaskCode;
			parameters[3].Value = model.s_TaskName;
			parameters[4].Value = model.s_OtherName;
			parameters[5].Value = model.s_TaskDesc;
			parameters[6].Value = model.s_Business;
			parameters[7].Value = model.s_PTCType;
			parameters[8].Value = model.n_ProcessID;
			parameters[9].Value = model.s_IsActive;
			parameters[10].Value = model.s_BaseField;
			parameters[11].Value = model.n_AlarmDays;
			parameters[12].Value = model.n_AlarmMonths;
			parameters[13].Value = model.s_AlarmCalcOrder;
			parameters[14].Value = model.n_OfficialDeadDays;
			parameters[15].Value = model.n_OfficialDeadMonths;
			parameters[16].Value = model.s_OfficialDeadCalcOrder;
			parameters[17].Value = model.n_ClientDeadDays;
			parameters[18].Value = model.n_ClientDeadMonths;
			parameters[19].Value = model.s_ClientDeadCalcOrder;
			parameters[20].Value = model.n_InterDeadDays;
			parameters[21].Value = model.n_InterDeadMonths;
			parameters[22].Value = model.s_InterDeadCalcOrder;
			parameters[23].Value = model.s_TaskType;
			parameters[24].Value = model.n_EmployeeID;
			parameters[25].Value = model.s_SysConfigureTask;
			parameters[26].Value = model.dt_CreateDate;
			parameters[27].Value = model.dt_EditDate;
			parameters[28].Value = model.s_TApplyType;
			parameters[29].Value = model.s_OfficialDeadM;
			parameters[30].Value = model.s_ClientDeadM;
			parameters[31].Value = model.s_InterDeadM;
			parameters[32].Value = model.s_Dealer;
			parameters[33].Value = model.s_IsSystem;
			parameters[34].Value = model.s_AutoSendEmail;
			parameters[35].Value = model.s_Priority;
			parameters[36].Value = model.s_ChangeDateSendEmail;
			parameters[37].Value = model.s_RelatedElement;
			parameters[38].Value = model.s_RelatedElementStatus;
			parameters[39].Value = model.s_AutoFinished;
			parameters[40].Value = model.s_RemindWithCreating;
			parameters[41].Value = model.s_Relationer;
			parameters[42].Value = model.s_Category;
			parameters[43].Value = model.s_SysTaskType;
			parameters[44].Value = model.s_SysFlowDirection;
			parameters[45].Value = model.n_ID;

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
			strSql.Append("delete from TCode_SysTasks ");
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
			strSql.Append("delete from TCode_SysTasks ");
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
		public IPSP.Model.TCode_SysTasks GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_IPType,n_RegCountry,s_SysTaskCode,s_TaskName,s_OtherName,s_TaskDesc,s_Business,s_PTCType,n_ProcessID,s_IsActive,s_BaseField,n_AlarmDays,n_AlarmMonths,s_AlarmCalcOrder,n_OfficialDeadDays,n_OfficialDeadMonths,s_OfficialDeadCalcOrder,n_ClientDeadDays,n_ClientDeadMonths,s_ClientDeadCalcOrder,n_InterDeadDays,n_InterDeadMonths,s_InterDeadCalcOrder,s_TaskType,n_EmployeeID,s_SysConfigureTask,dt_CreateDate,dt_EditDate,s_TApplyType,s_OfficialDeadM,s_ClientDeadM,s_InterDeadM,s_Dealer,s_IsSystem,s_AutoSendEmail,s_Priority,s_ChangeDateSendEmail,s_RelatedElement,s_RelatedElementStatus,s_AutoFinished,s_RemindWithCreating,s_Relationer,s_Category,s_SysTaskType,s_SysFlowDirection from TCode_SysTasks ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_SysTasks model=new IPSP.Model.TCode_SysTasks();
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
		public IPSP.Model.TCode_SysTasks DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_SysTasks model=new IPSP.Model.TCode_SysTasks();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["n_RegCountry"]!=null && row["n_RegCountry"].ToString()!="")
				{
					model.n_RegCountry=int.Parse(row["n_RegCountry"].ToString());
				}
				if(row["s_SysTaskCode"]!=null)
				{
					model.s_SysTaskCode=row["s_SysTaskCode"].ToString();
				}
				if(row["s_TaskName"]!=null)
				{
					model.s_TaskName=row["s_TaskName"].ToString();
				}
				if(row["s_OtherName"]!=null)
				{
					model.s_OtherName=row["s_OtherName"].ToString();
				}
				if(row["s_TaskDesc"]!=null)
				{
					model.s_TaskDesc=row["s_TaskDesc"].ToString();
				}
				if(row["s_Business"]!=null)
				{
					model.s_Business=row["s_Business"].ToString();
				}
				if(row["s_PTCType"]!=null)
				{
					model.s_PTCType=row["s_PTCType"].ToString();
				}
				if(row["n_ProcessID"]!=null && row["n_ProcessID"].ToString()!="")
				{
					model.n_ProcessID=int.Parse(row["n_ProcessID"].ToString());
				}
				if(row["s_IsActive"]!=null)
				{
					model.s_IsActive=row["s_IsActive"].ToString();
				}
				if(row["s_BaseField"]!=null)
				{
					model.s_BaseField=row["s_BaseField"].ToString();
				}
				if(row["n_AlarmDays"]!=null && row["n_AlarmDays"].ToString()!="")
				{
					model.n_AlarmDays=int.Parse(row["n_AlarmDays"].ToString());
				}
				if(row["n_AlarmMonths"]!=null && row["n_AlarmMonths"].ToString()!="")
				{
					model.n_AlarmMonths=int.Parse(row["n_AlarmMonths"].ToString());
				}
				if(row["s_AlarmCalcOrder"]!=null)
				{
					model.s_AlarmCalcOrder=row["s_AlarmCalcOrder"].ToString();
				}
				if(row["n_OfficialDeadDays"]!=null && row["n_OfficialDeadDays"].ToString()!="")
				{
					model.n_OfficialDeadDays=int.Parse(row["n_OfficialDeadDays"].ToString());
				}
				if(row["n_OfficialDeadMonths"]!=null && row["n_OfficialDeadMonths"].ToString()!="")
				{
					model.n_OfficialDeadMonths=int.Parse(row["n_OfficialDeadMonths"].ToString());
				}
				if(row["s_OfficialDeadCalcOrder"]!=null)
				{
					model.s_OfficialDeadCalcOrder=row["s_OfficialDeadCalcOrder"].ToString();
				}
				if(row["n_ClientDeadDays"]!=null && row["n_ClientDeadDays"].ToString()!="")
				{
					model.n_ClientDeadDays=int.Parse(row["n_ClientDeadDays"].ToString());
				}
				if(row["n_ClientDeadMonths"]!=null && row["n_ClientDeadMonths"].ToString()!="")
				{
					model.n_ClientDeadMonths=int.Parse(row["n_ClientDeadMonths"].ToString());
				}
				if(row["s_ClientDeadCalcOrder"]!=null)
				{
					model.s_ClientDeadCalcOrder=row["s_ClientDeadCalcOrder"].ToString();
				}
				if(row["n_InterDeadDays"]!=null && row["n_InterDeadDays"].ToString()!="")
				{
					model.n_InterDeadDays=int.Parse(row["n_InterDeadDays"].ToString());
				}
				if(row["n_InterDeadMonths"]!=null && row["n_InterDeadMonths"].ToString()!="")
				{
					model.n_InterDeadMonths=int.Parse(row["n_InterDeadMonths"].ToString());
				}
				if(row["s_InterDeadCalcOrder"]!=null)
				{
					model.s_InterDeadCalcOrder=row["s_InterDeadCalcOrder"].ToString();
				}
				if(row["s_TaskType"]!=null)
				{
					model.s_TaskType=row["s_TaskType"].ToString();
				}
				if(row["n_EmployeeID"]!=null && row["n_EmployeeID"].ToString()!="")
				{
					model.n_EmployeeID=int.Parse(row["n_EmployeeID"].ToString());
				}
				if(row["s_SysConfigureTask"]!=null)
				{
					model.s_SysConfigureTask=row["s_SysConfigureTask"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_TApplyType"]!=null)
				{
					model.s_TApplyType=row["s_TApplyType"].ToString();
				}
				if(row["s_OfficialDeadM"]!=null)
				{
					model.s_OfficialDeadM=row["s_OfficialDeadM"].ToString();
				}
				if(row["s_ClientDeadM"]!=null)
				{
					model.s_ClientDeadM=row["s_ClientDeadM"].ToString();
				}
				if(row["s_InterDeadM"]!=null)
				{
					model.s_InterDeadM=row["s_InterDeadM"].ToString();
				}
				if(row["s_Dealer"]!=null)
				{
					model.s_Dealer=row["s_Dealer"].ToString();
				}
				if(row["s_IsSystem"]!=null)
				{
					model.s_IsSystem=row["s_IsSystem"].ToString();
				}
				if(row["s_AutoSendEmail"]!=null)
				{
					model.s_AutoSendEmail=row["s_AutoSendEmail"].ToString();
				}
				if(row["s_Priority"]!=null)
				{
					model.s_Priority=row["s_Priority"].ToString();
				}
				if(row["s_ChangeDateSendEmail"]!=null)
				{
					model.s_ChangeDateSendEmail=row["s_ChangeDateSendEmail"].ToString();
				}
				if(row["s_RelatedElement"]!=null)
				{
					model.s_RelatedElement=row["s_RelatedElement"].ToString();
				}
				if(row["s_RelatedElementStatus"]!=null)
				{
					model.s_RelatedElementStatus=row["s_RelatedElementStatus"].ToString();
				}
				if(row["s_AutoFinished"]!=null)
				{
					model.s_AutoFinished=row["s_AutoFinished"].ToString();
				}
				if(row["s_RemindWithCreating"]!=null)
				{
					model.s_RemindWithCreating=row["s_RemindWithCreating"].ToString();
				}
				if(row["s_Relationer"]!=null)
				{
					model.s_Relationer=row["s_Relationer"].ToString();
				}
				if(row["s_Category"]!=null)
				{
					model.s_Category=row["s_Category"].ToString();
				}
				if(row["s_SysTaskType"]!=null)
				{
					model.s_SysTaskType=row["s_SysTaskType"].ToString();
				}
				if(row["s_SysFlowDirection"]!=null)
				{
					model.s_SysFlowDirection=row["s_SysFlowDirection"].ToString();
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
			strSql.Append("select n_ID,s_IPType,n_RegCountry,s_SysTaskCode,s_TaskName,s_OtherName,s_TaskDesc,s_Business,s_PTCType,n_ProcessID,s_IsActive,s_BaseField,n_AlarmDays,n_AlarmMonths,s_AlarmCalcOrder,n_OfficialDeadDays,n_OfficialDeadMonths,s_OfficialDeadCalcOrder,n_ClientDeadDays,n_ClientDeadMonths,s_ClientDeadCalcOrder,n_InterDeadDays,n_InterDeadMonths,s_InterDeadCalcOrder,s_TaskType,n_EmployeeID,s_SysConfigureTask,dt_CreateDate,dt_EditDate,s_TApplyType,s_OfficialDeadM,s_ClientDeadM,s_InterDeadM,s_Dealer,s_IsSystem,s_AutoSendEmail,s_Priority,s_ChangeDateSendEmail,s_RelatedElement,s_RelatedElementStatus,s_AutoFinished,s_RemindWithCreating,s_Relationer,s_Category,s_SysTaskType,s_SysFlowDirection ");
			strSql.Append(" FROM TCode_SysTasks ");
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
			strSql.Append(" n_ID,s_IPType,n_RegCountry,s_SysTaskCode,s_TaskName,s_OtherName,s_TaskDesc,s_Business,s_PTCType,n_ProcessID,s_IsActive,s_BaseField,n_AlarmDays,n_AlarmMonths,s_AlarmCalcOrder,n_OfficialDeadDays,n_OfficialDeadMonths,s_OfficialDeadCalcOrder,n_ClientDeadDays,n_ClientDeadMonths,s_ClientDeadCalcOrder,n_InterDeadDays,n_InterDeadMonths,s_InterDeadCalcOrder,s_TaskType,n_EmployeeID,s_SysConfigureTask,dt_CreateDate,dt_EditDate,s_TApplyType,s_OfficialDeadM,s_ClientDeadM,s_InterDeadM,s_Dealer,s_IsSystem,s_AutoSendEmail,s_Priority,s_ChangeDateSendEmail,s_RelatedElement,s_RelatedElementStatus,s_AutoFinished,s_RemindWithCreating,s_Relationer,s_Category,s_SysTaskType,s_SysFlowDirection ");
			strSql.Append(" FROM TCode_SysTasks ");
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
			strSql.Append("select count(1) FROM TCode_SysTasks ");
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
			strSql.Append(")AS Row, T.*  from TCode_SysTasks T ");
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
			parameters[0].Value = "TCode_SysTasks";
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

