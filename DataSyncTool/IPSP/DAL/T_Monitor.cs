/**  版本信息模板在安装目录下，可自行修改。
* T_Monitor.cs
*
* 功 能： N/A
* 类 名： T_Monitor
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:56   N/A    初版
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
	/// 数据访问类:T_Monitor
	/// </summary>
	public partial class T_Monitor
	{
		public T_Monitor()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_MonitorID", "T_Monitor"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_MonitorID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Monitor");
			strSql.Append(" where n_MonitorID=@n_MonitorID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_MonitorID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_MonitorID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_Monitor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Monitor(");
			strSql.Append("s_Title,s_Detail,dt_MonitorDate,s_ObjType,n_GovOfficeID,n_ClientID,dt_BeginDate,s_Status,s_IsActive,dt_CreateDate,dt_EditDate,s_CaseSerial,s_AppNo,s_Creator,s_Editor,n_MainCaseID,n_CreatorID)");
			strSql.Append(" values (");
			strSql.Append("@s_Title,@s_Detail,@dt_MonitorDate,@s_ObjType,@n_GovOfficeID,@n_ClientID,@dt_BeginDate,@s_Status,@s_IsActive,@dt_CreateDate,@dt_EditDate,@s_CaseSerial,@s_AppNo,@s_Creator,@s_Editor,@n_MainCaseID,@n_CreatorID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Title", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Detail", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_MonitorDate", SqlDbType.DateTime),
					new SqlParameter("@s_ObjType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_GovOfficeID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@dt_BeginDate", SqlDbType.DateTime),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_CaseSerial", SqlDbType.VarChar,100),
					new SqlParameter("@s_AppNo", SqlDbType.VarChar,100),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@n_CreatorID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Title;
			parameters[1].Value = model.s_Detail;
			parameters[2].Value = model.dt_MonitorDate;
			parameters[3].Value = model.s_ObjType;
			parameters[4].Value = model.n_GovOfficeID;
			parameters[5].Value = model.n_ClientID;
			parameters[6].Value = model.dt_BeginDate;
			parameters[7].Value = model.s_Status;
			parameters[8].Value = model.s_IsActive;
			parameters[9].Value = model.dt_CreateDate;
			parameters[10].Value = model.dt_EditDate;
			parameters[11].Value = model.s_CaseSerial;
			parameters[12].Value = model.s_AppNo;
			parameters[13].Value = model.s_Creator;
			parameters[14].Value = model.s_Editor;
			parameters[15].Value = model.n_MainCaseID;
			parameters[16].Value = model.n_CreatorID;

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
		public bool Update(IPSP.Model.T_Monitor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Monitor set ");
			strSql.Append("s_Title=@s_Title,");
			strSql.Append("s_Detail=@s_Detail,");
			strSql.Append("dt_MonitorDate=@dt_MonitorDate,");
			strSql.Append("s_ObjType=@s_ObjType,");
			strSql.Append("n_GovOfficeID=@n_GovOfficeID,");
			strSql.Append("n_ClientID=@n_ClientID,");
			strSql.Append("dt_BeginDate=@dt_BeginDate,");
			strSql.Append("s_Status=@s_Status,");
			strSql.Append("s_IsActive=@s_IsActive,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_CaseSerial=@s_CaseSerial,");
			strSql.Append("s_AppNo=@s_AppNo,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("n_MainCaseID=@n_MainCaseID,");
			strSql.Append("n_CreatorID=@n_CreatorID");
			strSql.Append(" where n_MonitorID=@n_MonitorID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Title", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Detail", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_MonitorDate", SqlDbType.DateTime),
					new SqlParameter("@s_ObjType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_GovOfficeID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@dt_BeginDate", SqlDbType.DateTime),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_CaseSerial", SqlDbType.VarChar,100),
					new SqlParameter("@s_AppNo", SqlDbType.VarChar,100),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@n_CreatorID", SqlDbType.Int,4),
					new SqlParameter("@n_MonitorID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Title;
			parameters[1].Value = model.s_Detail;
			parameters[2].Value = model.dt_MonitorDate;
			parameters[3].Value = model.s_ObjType;
			parameters[4].Value = model.n_GovOfficeID;
			parameters[5].Value = model.n_ClientID;
			parameters[6].Value = model.dt_BeginDate;
			parameters[7].Value = model.s_Status;
			parameters[8].Value = model.s_IsActive;
			parameters[9].Value = model.dt_CreateDate;
			parameters[10].Value = model.dt_EditDate;
			parameters[11].Value = model.s_CaseSerial;
			parameters[12].Value = model.s_AppNo;
			parameters[13].Value = model.s_Creator;
			parameters[14].Value = model.s_Editor;
			parameters[15].Value = model.n_MainCaseID;
			parameters[16].Value = model.n_CreatorID;
			parameters[17].Value = model.n_MonitorID;

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
		public bool Delete(int n_MonitorID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Monitor ");
			strSql.Append(" where n_MonitorID=@n_MonitorID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_MonitorID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_MonitorID;

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
		public bool DeleteList(string n_MonitorIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Monitor ");
			strSql.Append(" where n_MonitorID in ("+n_MonitorIDlist + ")  ");
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
		public IPSP.Model.T_Monitor GetModel(int n_MonitorID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_MonitorID,s_Title,s_Detail,dt_MonitorDate,s_ObjType,n_GovOfficeID,n_ClientID,dt_BeginDate,s_Status,s_IsActive,dt_CreateDate,dt_EditDate,s_CaseSerial,s_AppNo,s_Creator,s_Editor,n_MainCaseID,n_CreatorID from T_Monitor ");
			strSql.Append(" where n_MonitorID=@n_MonitorID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_MonitorID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_MonitorID;

			IPSP.Model.T_Monitor model=new IPSP.Model.T_Monitor();
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
		public IPSP.Model.T_Monitor DataRowToModel(DataRow row)
		{
			IPSP.Model.T_Monitor model=new IPSP.Model.T_Monitor();
			if (row != null)
			{
				if(row["n_MonitorID"]!=null && row["n_MonitorID"].ToString()!="")
				{
					model.n_MonitorID=int.Parse(row["n_MonitorID"].ToString());
				}
				if(row["s_Title"]!=null)
				{
					model.s_Title=row["s_Title"].ToString();
				}
				if(row["s_Detail"]!=null)
				{
					model.s_Detail=row["s_Detail"].ToString();
				}
				if(row["dt_MonitorDate"]!=null && row["dt_MonitorDate"].ToString()!="")
				{
					model.dt_MonitorDate=DateTime.Parse(row["dt_MonitorDate"].ToString());
				}
				if(row["s_ObjType"]!=null)
				{
					model.s_ObjType=row["s_ObjType"].ToString();
				}
				if(row["n_GovOfficeID"]!=null && row["n_GovOfficeID"].ToString()!="")
				{
					model.n_GovOfficeID=int.Parse(row["n_GovOfficeID"].ToString());
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["dt_BeginDate"]!=null && row["dt_BeginDate"].ToString()!="")
				{
					model.dt_BeginDate=DateTime.Parse(row["dt_BeginDate"].ToString());
				}
				if(row["s_Status"]!=null)
				{
					model.s_Status=row["s_Status"].ToString();
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
				if(row["s_AppNo"]!=null)
				{
					model.s_AppNo=row["s_AppNo"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select n_MonitorID,s_Title,s_Detail,dt_MonitorDate,s_ObjType,n_GovOfficeID,n_ClientID,dt_BeginDate,s_Status,s_IsActive,dt_CreateDate,dt_EditDate,s_CaseSerial,s_AppNo,s_Creator,s_Editor,n_MainCaseID,n_CreatorID ");
			strSql.Append(" FROM T_Monitor ");
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
			strSql.Append(" n_MonitorID,s_Title,s_Detail,dt_MonitorDate,s_ObjType,n_GovOfficeID,n_ClientID,dt_BeginDate,s_Status,s_IsActive,dt_CreateDate,dt_EditDate,s_CaseSerial,s_AppNo,s_Creator,s_Editor,n_MainCaseID,n_CreatorID ");
			strSql.Append(" FROM T_Monitor ");
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
			strSql.Append("select count(1) FROM T_Monitor ");
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
				strSql.Append("order by T.n_MonitorID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Monitor T ");
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
			parameters[0].Value = "T_Monitor";
			parameters[1].Value = "n_MonitorID";
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

