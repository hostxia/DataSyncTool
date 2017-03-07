/**  版本信息模板在安装目录下，可自行修改。
* TPCase_HongKongApplication.cs
*
* 功 能： N/A
* 类 名： TPCase_HongKongApplication
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:20   N/A    初版
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
	/// 数据访问类:TPCase_HongKongApplication
	/// </summary>
	public partial class TPCase_HongKongApplication
	{
		public TPCase_HongKongApplication()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TPCase_HongKongApplication"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPCase_HongKongApplication");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TPCase_HongKongApplication model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPCase_HongKongApplication(");
			strSql.Append("n_CaseID,n_Type,s_Note,s_ParentCaseSerial,s_ParentCaseAppNo,s_ParentCaseCountry,dt_1stRegisterDate,dt_2ndRegisterDate,dt_1stAgentReport,dt_1stPublish,dt_2ndAgentReport,dt_2ndGrantReport,dt_RemindShldDate)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@n_Type,@s_Note,@s_ParentCaseSerial,@s_ParentCaseAppNo,@s_ParentCaseCountry,@dt_1stRegisterDate,@dt_2ndRegisterDate,@dt_1stAgentReport,@dt_1stPublish,@dt_2ndAgentReport,@dt_2ndGrantReport,@dt_RemindShldDate)");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_Type", SqlDbType.Int,4),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_ParentCaseSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ParentCaseAppNo", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ParentCaseCountry", SqlDbType.NVarChar,100),
					new SqlParameter("@dt_1stRegisterDate", SqlDbType.DateTime),
					new SqlParameter("@dt_2ndRegisterDate", SqlDbType.DateTime),
					new SqlParameter("@dt_1stAgentReport", SqlDbType.DateTime),
					new SqlParameter("@dt_1stPublish", SqlDbType.DateTime),
					new SqlParameter("@dt_2ndAgentReport", SqlDbType.DateTime),
					new SqlParameter("@dt_2ndGrantReport", SqlDbType.DateTime),
					new SqlParameter("@dt_RemindShldDate", SqlDbType.DateTime)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.n_Type;
			parameters[2].Value = model.s_Note;
			parameters[3].Value = model.s_ParentCaseSerial;
			parameters[4].Value = model.s_ParentCaseAppNo;
			parameters[5].Value = model.s_ParentCaseCountry;
			parameters[6].Value = model.dt_1stRegisterDate;
			parameters[7].Value = model.dt_2ndRegisterDate;
			parameters[8].Value = model.dt_1stAgentReport;
			parameters[9].Value = model.dt_1stPublish;
			parameters[10].Value = model.dt_2ndAgentReport;
			parameters[11].Value = model.dt_2ndGrantReport;
			parameters[12].Value = model.dt_RemindShldDate;

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
		public bool Update(IPSP.Model.TPCase_HongKongApplication model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPCase_HongKongApplication set ");
			strSql.Append("n_Type=@n_Type,");
			strSql.Append("s_Note=@s_Note,");
			strSql.Append("s_ParentCaseSerial=@s_ParentCaseSerial,");
			strSql.Append("s_ParentCaseAppNo=@s_ParentCaseAppNo,");
			strSql.Append("s_ParentCaseCountry=@s_ParentCaseCountry,");
			strSql.Append("dt_1stRegisterDate=@dt_1stRegisterDate,");
			strSql.Append("dt_2ndRegisterDate=@dt_2ndRegisterDate,");
			strSql.Append("dt_1stAgentReport=@dt_1stAgentReport,");
			strSql.Append("dt_1stPublish=@dt_1stPublish,");
			strSql.Append("dt_2ndAgentReport=@dt_2ndAgentReport,");
			strSql.Append("dt_2ndGrantReport=@dt_2ndGrantReport,");
			strSql.Append("dt_RemindShldDate=@dt_RemindShldDate");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Type", SqlDbType.Int,4),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_ParentCaseSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ParentCaseAppNo", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ParentCaseCountry", SqlDbType.NVarChar,100),
					new SqlParameter("@dt_1stRegisterDate", SqlDbType.DateTime),
					new SqlParameter("@dt_2ndRegisterDate", SqlDbType.DateTime),
					new SqlParameter("@dt_1stAgentReport", SqlDbType.DateTime),
					new SqlParameter("@dt_1stPublish", SqlDbType.DateTime),
					new SqlParameter("@dt_2ndAgentReport", SqlDbType.DateTime),
					new SqlParameter("@dt_2ndGrantReport", SqlDbType.DateTime),
					new SqlParameter("@dt_RemindShldDate", SqlDbType.DateTime),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_Type;
			parameters[1].Value = model.s_Note;
			parameters[2].Value = model.s_ParentCaseSerial;
			parameters[3].Value = model.s_ParentCaseAppNo;
			parameters[4].Value = model.s_ParentCaseCountry;
			parameters[5].Value = model.dt_1stRegisterDate;
			parameters[6].Value = model.dt_2ndRegisterDate;
			parameters[7].Value = model.dt_1stAgentReport;
			parameters[8].Value = model.dt_1stPublish;
			parameters[9].Value = model.dt_2ndAgentReport;
			parameters[10].Value = model.dt_2ndGrantReport;
			parameters[11].Value = model.dt_RemindShldDate;
			parameters[12].Value = model.n_CaseID;

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
		public bool Delete(int n_CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPCase_HongKongApplication ");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

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
		public bool DeleteList(string n_CaseIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPCase_HongKongApplication ");
			strSql.Append(" where n_CaseID in ("+n_CaseIDlist + ")  ");
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
		public IPSP.Model.TPCase_HongKongApplication GetModel(int n_CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_CaseID,n_Type,s_Note,s_ParentCaseSerial,s_ParentCaseAppNo,s_ParentCaseCountry,dt_1stRegisterDate,dt_2ndRegisterDate,dt_1stAgentReport,dt_1stPublish,dt_2ndAgentReport,dt_2ndGrantReport,dt_RemindShldDate from TPCase_HongKongApplication ");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

			IPSP.Model.TPCase_HongKongApplication model=new IPSP.Model.TPCase_HongKongApplication();
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
		public IPSP.Model.TPCase_HongKongApplication DataRowToModel(DataRow row)
		{
			IPSP.Model.TPCase_HongKongApplication model=new IPSP.Model.TPCase_HongKongApplication();
			if (row != null)
			{
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["n_Type"]!=null && row["n_Type"].ToString()!="")
				{
					model.n_Type=int.Parse(row["n_Type"].ToString());
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
				}
				if(row["s_ParentCaseSerial"]!=null)
				{
					model.s_ParentCaseSerial=row["s_ParentCaseSerial"].ToString();
				}
				if(row["s_ParentCaseAppNo"]!=null)
				{
					model.s_ParentCaseAppNo=row["s_ParentCaseAppNo"].ToString();
				}
				if(row["s_ParentCaseCountry"]!=null)
				{
					model.s_ParentCaseCountry=row["s_ParentCaseCountry"].ToString();
				}
				if(row["dt_1stRegisterDate"]!=null && row["dt_1stRegisterDate"].ToString()!="")
				{
					model.dt_1stRegisterDate=DateTime.Parse(row["dt_1stRegisterDate"].ToString());
				}
				if(row["dt_2ndRegisterDate"]!=null && row["dt_2ndRegisterDate"].ToString()!="")
				{
					model.dt_2ndRegisterDate=DateTime.Parse(row["dt_2ndRegisterDate"].ToString());
				}
				if(row["dt_1stAgentReport"]!=null && row["dt_1stAgentReport"].ToString()!="")
				{
					model.dt_1stAgentReport=DateTime.Parse(row["dt_1stAgentReport"].ToString());
				}
				if(row["dt_1stPublish"]!=null && row["dt_1stPublish"].ToString()!="")
				{
					model.dt_1stPublish=DateTime.Parse(row["dt_1stPublish"].ToString());
				}
				if(row["dt_2ndAgentReport"]!=null && row["dt_2ndAgentReport"].ToString()!="")
				{
					model.dt_2ndAgentReport=DateTime.Parse(row["dt_2ndAgentReport"].ToString());
				}
				if(row["dt_2ndGrantReport"]!=null && row["dt_2ndGrantReport"].ToString()!="")
				{
					model.dt_2ndGrantReport=DateTime.Parse(row["dt_2ndGrantReport"].ToString());
				}
				if(row["dt_RemindShldDate"]!=null && row["dt_RemindShldDate"].ToString()!="")
				{
					model.dt_RemindShldDate=DateTime.Parse(row["dt_RemindShldDate"].ToString());
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
			strSql.Append("select n_CaseID,n_Type,s_Note,s_ParentCaseSerial,s_ParentCaseAppNo,s_ParentCaseCountry,dt_1stRegisterDate,dt_2ndRegisterDate,dt_1stAgentReport,dt_1stPublish,dt_2ndAgentReport,dt_2ndGrantReport,dt_RemindShldDate ");
			strSql.Append(" FROM TPCase_HongKongApplication ");
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
			strSql.Append(" n_CaseID,n_Type,s_Note,s_ParentCaseSerial,s_ParentCaseAppNo,s_ParentCaseCountry,dt_1stRegisterDate,dt_2ndRegisterDate,dt_1stAgentReport,dt_1stPublish,dt_2ndAgentReport,dt_2ndGrantReport,dt_RemindShldDate ");
			strSql.Append(" FROM TPCase_HongKongApplication ");
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
			strSql.Append("select count(1) FROM TPCase_HongKongApplication ");
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
				strSql.Append("order by T.n_CaseID desc");
			}
			strSql.Append(")AS Row, T.*  from TPCase_HongKongApplication T ");
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
			parameters[0].Value = "TPCase_HongKongApplication";
			parameters[1].Value = "n_CaseID";
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

