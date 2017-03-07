/**  版本信息模板在安装目录下，可自行修改。
* T_Timesheet.cs
*
* 功 能： N/A
* 类 名： T_Timesheet
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:11   N/A    初版
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
	/// 数据访问类:T_Timesheet
	/// </summary>
	public partial class T_Timesheet
	{
		public T_Timesheet()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_BillID", "T_Timesheet"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_BillID,int n_TimesheetID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Timesheet");
			strSql.Append(" where n_BillID=@n_BillID and n_TimesheetID=@n_TimesheetID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_TimesheetID", SqlDbType.Int,4)			};
			parameters[0].Value = n_BillID;
			parameters[1].Value = n_TimesheetID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_Timesheet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Timesheet(");
			strSql.Append("s_Task,s_Status,s_Invoiced,s_Paid,n_ChargeCurrency,n_Rate,n_ExchangeCurrency,s_Notes,s_IsActive,dt_CreateDate,dt_EditDate,s_CaseSerial,s_CaseName,s_Creator,s_Editor,n_MainCaseID,n_CreatorID,s_CheckStatus,n_BillID)");
			strSql.Append(" values (");
			strSql.Append("@s_Task,@s_Status,@s_Invoiced,@s_Paid,@n_ChargeCurrency,@n_Rate,@n_ExchangeCurrency,@s_Notes,@s_IsActive,@dt_CreateDate,@dt_EditDate,@s_CaseSerial,@s_CaseName,@s_Creator,@s_Editor,@n_MainCaseID,@n_CreatorID,@s_CheckStatus,@n_BillID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Task", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Invoiced", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Paid", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ChargeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_Rate", SqlDbType.Decimal,9),
					new SqlParameter("@n_ExchangeCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_CaseSerial", SqlDbType.VarChar,100),
					new SqlParameter("@s_CaseName", SqlDbType.VarChar,100),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@n_CreatorID", SqlDbType.Int,4),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@n_BillID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Task;
			parameters[1].Value = model.s_Status;
			parameters[2].Value = model.s_Invoiced;
			parameters[3].Value = model.s_Paid;
			parameters[4].Value = model.n_ChargeCurrency;
			parameters[5].Value = model.n_Rate;
			parameters[6].Value = model.n_ExchangeCurrency;
			parameters[7].Value = model.s_Notes;
			parameters[8].Value = model.s_IsActive;
			parameters[9].Value = model.dt_CreateDate;
			parameters[10].Value = model.dt_EditDate;
			parameters[11].Value = model.s_CaseSerial;
			parameters[12].Value = model.s_CaseName;
			parameters[13].Value = model.s_Creator;
			parameters[14].Value = model.s_Editor;
			parameters[15].Value = model.n_MainCaseID;
			parameters[16].Value = model.n_CreatorID;
			parameters[17].Value = model.s_CheckStatus;
			parameters[18].Value = model.n_BillID;

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
		public bool Update(IPSP.Model.T_Timesheet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Timesheet set ");
			strSql.Append("s_Task=@s_Task,");
			strSql.Append("s_Status=@s_Status,");
			strSql.Append("s_Invoiced=@s_Invoiced,");
			strSql.Append("s_Paid=@s_Paid,");
			strSql.Append("n_ChargeCurrency=@n_ChargeCurrency,");
			strSql.Append("n_Rate=@n_Rate,");
			strSql.Append("n_ExchangeCurrency=@n_ExchangeCurrency,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("s_IsActive=@s_IsActive,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_CaseSerial=@s_CaseSerial,");
			strSql.Append("s_CaseName=@s_CaseName,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("n_MainCaseID=@n_MainCaseID,");
			strSql.Append("n_CreatorID=@n_CreatorID,");
			strSql.Append("s_CheckStatus=@s_CheckStatus");
			strSql.Append(" where n_TimesheetID=@n_TimesheetID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Task", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Invoiced", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Paid", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ChargeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_Rate", SqlDbType.Decimal,9),
					new SqlParameter("@n_ExchangeCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_CaseSerial", SqlDbType.VarChar,100),
					new SqlParameter("@s_CaseName", SqlDbType.VarChar,100),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@n_CreatorID", SqlDbType.Int,4),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@n_TimesheetID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Task;
			parameters[1].Value = model.s_Status;
			parameters[2].Value = model.s_Invoiced;
			parameters[3].Value = model.s_Paid;
			parameters[4].Value = model.n_ChargeCurrency;
			parameters[5].Value = model.n_Rate;
			parameters[6].Value = model.n_ExchangeCurrency;
			parameters[7].Value = model.s_Notes;
			parameters[8].Value = model.s_IsActive;
			parameters[9].Value = model.dt_CreateDate;
			parameters[10].Value = model.dt_EditDate;
			parameters[11].Value = model.s_CaseSerial;
			parameters[12].Value = model.s_CaseName;
			parameters[13].Value = model.s_Creator;
			parameters[14].Value = model.s_Editor;
			parameters[15].Value = model.n_MainCaseID;
			parameters[16].Value = model.n_CreatorID;
			parameters[17].Value = model.s_CheckStatus;
			parameters[18].Value = model.n_TimesheetID;
			parameters[19].Value = model.n_BillID;

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
		public bool Delete(int n_TimesheetID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Timesheet ");
			strSql.Append(" where n_TimesheetID=@n_TimesheetID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_TimesheetID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_TimesheetID;

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
		public bool Delete(int n_BillID,int n_TimesheetID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Timesheet ");
			strSql.Append(" where n_BillID=@n_BillID and n_TimesheetID=@n_TimesheetID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_TimesheetID", SqlDbType.Int,4)			};
			parameters[0].Value = n_BillID;
			parameters[1].Value = n_TimesheetID;

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
		public bool DeleteList(string n_TimesheetIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Timesheet ");
			strSql.Append(" where n_TimesheetID in ("+n_TimesheetIDlist + ")  ");
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
		public IPSP.Model.T_Timesheet GetModel(int n_TimesheetID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_TimesheetID,s_Task,s_Status,s_Invoiced,s_Paid,n_ChargeCurrency,n_Rate,n_ExchangeCurrency,s_Notes,s_IsActive,dt_CreateDate,dt_EditDate,s_CaseSerial,s_CaseName,s_Creator,s_Editor,n_MainCaseID,n_CreatorID,s_CheckStatus,n_BillID from T_Timesheet ");
			strSql.Append(" where n_TimesheetID=@n_TimesheetID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_TimesheetID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_TimesheetID;

			IPSP.Model.T_Timesheet model=new IPSP.Model.T_Timesheet();
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
		public IPSP.Model.T_Timesheet DataRowToModel(DataRow row)
		{
			IPSP.Model.T_Timesheet model=new IPSP.Model.T_Timesheet();
			if (row != null)
			{
				if(row["n_TimesheetID"]!=null && row["n_TimesheetID"].ToString()!="")
				{
					model.n_TimesheetID=int.Parse(row["n_TimesheetID"].ToString());
				}
				if(row["s_Task"]!=null)
				{
					model.s_Task=row["s_Task"].ToString();
				}
				if(row["s_Status"]!=null)
				{
					model.s_Status=row["s_Status"].ToString();
				}
				if(row["s_Invoiced"]!=null)
				{
					model.s_Invoiced=row["s_Invoiced"].ToString();
				}
				if(row["s_Paid"]!=null)
				{
					model.s_Paid=row["s_Paid"].ToString();
				}
				if(row["n_ChargeCurrency"]!=null && row["n_ChargeCurrency"].ToString()!="")
				{
					model.n_ChargeCurrency=int.Parse(row["n_ChargeCurrency"].ToString());
				}
				if(row["n_Rate"]!=null && row["n_Rate"].ToString()!="")
				{
					model.n_Rate=decimal.Parse(row["n_Rate"].ToString());
				}
				if(row["n_ExchangeCurrency"]!=null && row["n_ExchangeCurrency"].ToString()!="")
				{
					model.n_ExchangeCurrency=int.Parse(row["n_ExchangeCurrency"].ToString());
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
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
				if(row["s_CaseSerial"]!=null)
				{
					model.s_CaseSerial=row["s_CaseSerial"].ToString();
				}
				if(row["s_CaseName"]!=null)
				{
					model.s_CaseName=row["s_CaseName"].ToString();
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["n_MainCaseID"]!=null && row["n_MainCaseID"].ToString()!="")
				{
					model.n_MainCaseID=int.Parse(row["n_MainCaseID"].ToString());
				}
				if(row["n_CreatorID"]!=null && row["n_CreatorID"].ToString()!="")
				{
					model.n_CreatorID=int.Parse(row["n_CreatorID"].ToString());
				}
				if(row["s_CheckStatus"]!=null)
				{
					model.s_CheckStatus=row["s_CheckStatus"].ToString();
				}
				if(row["n_BillID"]!=null && row["n_BillID"].ToString()!="")
				{
					model.n_BillID=int.Parse(row["n_BillID"].ToString());
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
			strSql.Append("select n_TimesheetID,s_Task,s_Status,s_Invoiced,s_Paid,n_ChargeCurrency,n_Rate,n_ExchangeCurrency,s_Notes,s_IsActive,dt_CreateDate,dt_EditDate,s_CaseSerial,s_CaseName,s_Creator,s_Editor,n_MainCaseID,n_CreatorID,s_CheckStatus,n_BillID ");
			strSql.Append(" FROM T_Timesheet ");
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
			strSql.Append(" n_TimesheetID,s_Task,s_Status,s_Invoiced,s_Paid,n_ChargeCurrency,n_Rate,n_ExchangeCurrency,s_Notes,s_IsActive,dt_CreateDate,dt_EditDate,s_CaseSerial,s_CaseName,s_Creator,s_Editor,n_MainCaseID,n_CreatorID,s_CheckStatus,n_BillID ");
			strSql.Append(" FROM T_Timesheet ");
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
			strSql.Append("select count(1) FROM T_Timesheet ");
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
				strSql.Append("order by T.n_TimesheetID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Timesheet T ");
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
			parameters[0].Value = "T_Timesheet";
			parameters[1].Value = "n_TimesheetID";
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

