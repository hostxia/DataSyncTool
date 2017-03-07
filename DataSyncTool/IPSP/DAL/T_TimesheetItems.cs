/**  版本信息模板在安装目录下，可自行修改。
* T_TimesheetItems.cs
*
* 功 能： N/A
* 类 名： T_TimesheetItems
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:12   N/A    初版
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
	/// 数据访问类:T_TimesheetItems
	/// </summary>
	public partial class T_TimesheetItems
	{
		public T_TimesheetItems()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_TimesheetID", "T_TimesheetItems"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_TimesheetID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_TimesheetItems");
			strSql.Append(" where n_TimesheetID=@n_TimesheetID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_TimesheetID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_TimesheetID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_TimesheetItems model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_TimesheetItems(");
			strSql.Append("n_TimesheetID,n_EmployeeID,n_ChargeRate,s_SubTask,dt_StartedTime,dt_EndTime,n_WorkingHours,n_BillingHours,s_EmployeeName)");
			strSql.Append(" values (");
			strSql.Append("@n_TimesheetID,@n_EmployeeID,@n_ChargeRate,@s_SubTask,@dt_StartedTime,@dt_EndTime,@n_WorkingHours,@n_BillingHours,@s_EmployeeName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_TimesheetID", SqlDbType.Int,4),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@n_ChargeRate", SqlDbType.Decimal,9),
					new SqlParameter("@s_SubTask", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_StartedTime", SqlDbType.DateTime),
					new SqlParameter("@dt_EndTime", SqlDbType.DateTime),
					new SqlParameter("@n_WorkingHours", SqlDbType.Decimal,9),
					new SqlParameter("@n_BillingHours", SqlDbType.Decimal,9),
					new SqlParameter("@s_EmployeeName", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.n_TimesheetID;
			parameters[1].Value = model.n_EmployeeID;
			parameters[2].Value = model.n_ChargeRate;
			parameters[3].Value = model.s_SubTask;
			parameters[4].Value = model.dt_StartedTime;
			parameters[5].Value = model.dt_EndTime;
			parameters[6].Value = model.n_WorkingHours;
			parameters[7].Value = model.n_BillingHours;
			parameters[8].Value = model.s_EmployeeName;

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
		public bool Update(IPSP.Model.T_TimesheetItems model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_TimesheetItems set ");
			strSql.Append("n_EmployeeID=@n_EmployeeID,");
			strSql.Append("n_ChargeRate=@n_ChargeRate,");
			strSql.Append("s_SubTask=@s_SubTask,");
			strSql.Append("dt_StartedTime=@dt_StartedTime,");
			strSql.Append("dt_EndTime=@dt_EndTime,");
			strSql.Append("n_WorkingHours=@n_WorkingHours,");
			strSql.Append("n_BillingHours=@n_BillingHours,");
			strSql.Append("s_EmployeeName=@s_EmployeeName");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@n_ChargeRate", SqlDbType.Decimal,9),
					new SqlParameter("@s_SubTask", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_StartedTime", SqlDbType.DateTime),
					new SqlParameter("@dt_EndTime", SqlDbType.DateTime),
					new SqlParameter("@n_WorkingHours", SqlDbType.Decimal,9),
					new SqlParameter("@n_BillingHours", SqlDbType.Decimal,9),
					new SqlParameter("@s_EmployeeName", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_TimesheetID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_EmployeeID;
			parameters[1].Value = model.n_ChargeRate;
			parameters[2].Value = model.s_SubTask;
			parameters[3].Value = model.dt_StartedTime;
			parameters[4].Value = model.dt_EndTime;
			parameters[5].Value = model.n_WorkingHours;
			parameters[6].Value = model.n_BillingHours;
			parameters[7].Value = model.s_EmployeeName;
			parameters[8].Value = model.n_ID;
			parameters[9].Value = model.n_TimesheetID;

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
			strSql.Append("delete from T_TimesheetItems ");
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
		public bool Delete(int n_TimesheetID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_TimesheetItems ");
			strSql.Append(" where n_TimesheetID=@n_TimesheetID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_TimesheetID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_TimesheetID;
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
			strSql.Append("delete from T_TimesheetItems ");
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
		public IPSP.Model.T_TimesheetItems GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_TimesheetID,n_EmployeeID,n_ChargeRate,s_SubTask,dt_StartedTime,dt_EndTime,n_WorkingHours,n_BillingHours,s_EmployeeName from T_TimesheetItems ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_TimesheetItems model=new IPSP.Model.T_TimesheetItems();
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
		public IPSP.Model.T_TimesheetItems DataRowToModel(DataRow row)
		{
			IPSP.Model.T_TimesheetItems model=new IPSP.Model.T_TimesheetItems();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_TimesheetID"]!=null && row["n_TimesheetID"].ToString()!="")
				{
					model.n_TimesheetID=int.Parse(row["n_TimesheetID"].ToString());
				}
				if(row["n_EmployeeID"]!=null && row["n_EmployeeID"].ToString()!="")
				{
					model.n_EmployeeID=int.Parse(row["n_EmployeeID"].ToString());
				}
				if(row["n_ChargeRate"]!=null && row["n_ChargeRate"].ToString()!="")
				{
					model.n_ChargeRate=decimal.Parse(row["n_ChargeRate"].ToString());
				}
				if(row["s_SubTask"]!=null)
				{
					model.s_SubTask=row["s_SubTask"].ToString();
				}
				if(row["dt_StartedTime"]!=null && row["dt_StartedTime"].ToString()!="")
				{
					model.dt_StartedTime=DateTime.Parse(row["dt_StartedTime"].ToString());
				}
				if(row["dt_EndTime"]!=null && row["dt_EndTime"].ToString()!="")
				{
					model.dt_EndTime=DateTime.Parse(row["dt_EndTime"].ToString());
				}
				if(row["n_WorkingHours"]!=null && row["n_WorkingHours"].ToString()!="")
				{
					model.n_WorkingHours=decimal.Parse(row["n_WorkingHours"].ToString());
				}
				if(row["n_BillingHours"]!=null && row["n_BillingHours"].ToString()!="")
				{
					model.n_BillingHours=decimal.Parse(row["n_BillingHours"].ToString());
				}
				if(row["s_EmployeeName"]!=null)
				{
					model.s_EmployeeName=row["s_EmployeeName"].ToString();
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
			strSql.Append("select n_ID,n_TimesheetID,n_EmployeeID,n_ChargeRate,s_SubTask,dt_StartedTime,dt_EndTime,n_WorkingHours,n_BillingHours,s_EmployeeName ");
			strSql.Append(" FROM T_TimesheetItems ");
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
			strSql.Append(" n_ID,n_TimesheetID,n_EmployeeID,n_ChargeRate,s_SubTask,dt_StartedTime,dt_EndTime,n_WorkingHours,n_BillingHours,s_EmployeeName ");
			strSql.Append(" FROM T_TimesheetItems ");
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
			strSql.Append("select count(1) FROM T_TimesheetItems ");
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
			strSql.Append(")AS Row, T.*  from T_TimesheetItems T ");
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
			parameters[0].Value = "T_TimesheetItems";
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

