/**  版本信息模板在安装目录下，可自行修改。
* TCase_Process.cs
*
* 功 能： N/A
* 类 名： TCase_Process
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:38   N/A    初版
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
	/// 数据访问类:TCase_Process
	/// </summary>
	public partial class TCase_Process
	{
		public TCase_Process()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TCase_Process"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_ProcessCodeID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCase_Process");
			strSql.Append(" where n_CaseID=@n_CaseID and n_ProcessCodeID=@n_ProcessCodeID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_ProcessCodeID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_ProcessCodeID;
			parameters[2].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCase_Process model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCase_Process(");
			strSql.Append("n_CaseID,n_OrderNum,n_ProcessCodeID,dt_StartDate,dt_EndDate,s_Status,s_Notes,n_ParentID,s_ProcessName,n_EMinTimeValue,s_EMinTimeUnit,n_EMaxTimeValue,s_EMaxTimeUnit,s_AllowRepeat,s_BaseDate)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@n_OrderNum,@n_ProcessCodeID,@dt_StartDate,@dt_EndDate,@s_Status,@s_Notes,@n_ParentID,@s_ProcessName,@n_EMinTimeValue,@s_EMinTimeUnit,@n_EMaxTimeValue,@s_EMaxTimeUnit,@s_AllowRepeat,@s_BaseDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_OrderNum", SqlDbType.Int,4),
					new SqlParameter("@n_ProcessCodeID", SqlDbType.Int,4),
					new SqlParameter("@dt_StartDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EndDate", SqlDbType.DateTime),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_ParentID", SqlDbType.Int,4),
					new SqlParameter("@s_ProcessName", SqlDbType.NVarChar,50),
					new SqlParameter("@n_EMinTimeValue", SqlDbType.Decimal,5),
					new SqlParameter("@s_EMinTimeUnit", SqlDbType.NVarChar,5),
					new SqlParameter("@n_EMaxTimeValue", SqlDbType.Decimal,5),
					new SqlParameter("@s_EMaxTimeUnit", SqlDbType.NVarChar,5),
					new SqlParameter("@s_AllowRepeat", SqlDbType.NVarChar,50),
					new SqlParameter("@s_BaseDate", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.n_OrderNum;
			parameters[2].Value = model.n_ProcessCodeID;
			parameters[3].Value = model.dt_StartDate;
			parameters[4].Value = model.dt_EndDate;
			parameters[5].Value = model.s_Status;
			parameters[6].Value = model.s_Notes;
			parameters[7].Value = model.n_ParentID;
			parameters[8].Value = model.s_ProcessName;
			parameters[9].Value = model.n_EMinTimeValue;
			parameters[10].Value = model.s_EMinTimeUnit;
			parameters[11].Value = model.n_EMaxTimeValue;
			parameters[12].Value = model.s_EMaxTimeUnit;
			parameters[13].Value = model.s_AllowRepeat;
			parameters[14].Value = model.s_BaseDate;

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
		public bool Update(IPSP.Model.TCase_Process model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCase_Process set ");
			strSql.Append("n_OrderNum=@n_OrderNum,");
			strSql.Append("dt_StartDate=@dt_StartDate,");
			strSql.Append("dt_EndDate=@dt_EndDate,");
			strSql.Append("s_Status=@s_Status,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("n_ParentID=@n_ParentID,");
			strSql.Append("s_ProcessName=@s_ProcessName,");
			strSql.Append("n_EMinTimeValue=@n_EMinTimeValue,");
			strSql.Append("s_EMinTimeUnit=@s_EMinTimeUnit,");
			strSql.Append("n_EMaxTimeValue=@n_EMaxTimeValue,");
			strSql.Append("s_EMaxTimeUnit=@s_EMaxTimeUnit,");
			strSql.Append("s_AllowRepeat=@s_AllowRepeat,");
			strSql.Append("s_BaseDate=@s_BaseDate");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_OrderNum", SqlDbType.Int,4),
					new SqlParameter("@dt_StartDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EndDate", SqlDbType.DateTime),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_ParentID", SqlDbType.Int,4),
					new SqlParameter("@s_ProcessName", SqlDbType.NVarChar,50),
					new SqlParameter("@n_EMinTimeValue", SqlDbType.Decimal,5),
					new SqlParameter("@s_EMinTimeUnit", SqlDbType.NVarChar,5),
					new SqlParameter("@n_EMaxTimeValue", SqlDbType.Decimal,5),
					new SqlParameter("@s_EMaxTimeUnit", SqlDbType.NVarChar,5),
					new SqlParameter("@s_AllowRepeat", SqlDbType.NVarChar,50),
					new SqlParameter("@s_BaseDate", SqlDbType.NVarChar,200),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_ProcessCodeID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_OrderNum;
			parameters[1].Value = model.dt_StartDate;
			parameters[2].Value = model.dt_EndDate;
			parameters[3].Value = model.s_Status;
			parameters[4].Value = model.s_Notes;
			parameters[5].Value = model.n_ParentID;
			parameters[6].Value = model.s_ProcessName;
			parameters[7].Value = model.n_EMinTimeValue;
			parameters[8].Value = model.s_EMinTimeUnit;
			parameters[9].Value = model.n_EMaxTimeValue;
			parameters[10].Value = model.s_EMaxTimeUnit;
			parameters[11].Value = model.s_AllowRepeat;
			parameters[12].Value = model.s_BaseDate;
			parameters[13].Value = model.n_ID;
			parameters[14].Value = model.n_CaseID;
			parameters[15].Value = model.n_ProcessCodeID;

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
			strSql.Append("delete from TCase_Process ");
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
		public bool Delete(int n_CaseID,int n_ProcessCodeID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCase_Process ");
			strSql.Append(" where n_CaseID=@n_CaseID and n_ProcessCodeID=@n_ProcessCodeID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_ProcessCodeID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_ProcessCodeID;
			parameters[2].Value = n_ID;

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
			strSql.Append("delete from TCase_Process ");
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
		public IPSP.Model.TCase_Process GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CaseID,n_OrderNum,n_ProcessCodeID,dt_StartDate,dt_EndDate,s_Status,s_Notes,n_ParentID,s_ProcessName,n_EMinTimeValue,s_EMinTimeUnit,n_EMaxTimeValue,s_EMaxTimeUnit,s_AllowRepeat,s_BaseDate from TCase_Process ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCase_Process model=new IPSP.Model.TCase_Process();
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
		public IPSP.Model.TCase_Process DataRowToModel(DataRow row)
		{
			IPSP.Model.TCase_Process model=new IPSP.Model.TCase_Process();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["n_OrderNum"]!=null && row["n_OrderNum"].ToString()!="")
				{
					model.n_OrderNum=int.Parse(row["n_OrderNum"].ToString());
				}
				if(row["n_ProcessCodeID"]!=null && row["n_ProcessCodeID"].ToString()!="")
				{
					model.n_ProcessCodeID=int.Parse(row["n_ProcessCodeID"].ToString());
				}
				if(row["dt_StartDate"]!=null && row["dt_StartDate"].ToString()!="")
				{
					model.dt_StartDate=DateTime.Parse(row["dt_StartDate"].ToString());
				}
				if(row["dt_EndDate"]!=null && row["dt_EndDate"].ToString()!="")
				{
					model.dt_EndDate=DateTime.Parse(row["dt_EndDate"].ToString());
				}
				if(row["s_Status"]!=null)
				{
					model.s_Status=row["s_Status"].ToString();
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["n_ParentID"]!=null && row["n_ParentID"].ToString()!="")
				{
					model.n_ParentID=int.Parse(row["n_ParentID"].ToString());
				}
				if(row["s_ProcessName"]!=null)
				{
					model.s_ProcessName=row["s_ProcessName"].ToString();
				}
				if(row["n_EMinTimeValue"]!=null && row["n_EMinTimeValue"].ToString()!="")
				{
					model.n_EMinTimeValue=decimal.Parse(row["n_EMinTimeValue"].ToString());
				}
				if(row["s_EMinTimeUnit"]!=null)
				{
					model.s_EMinTimeUnit=row["s_EMinTimeUnit"].ToString();
				}
				if(row["n_EMaxTimeValue"]!=null && row["n_EMaxTimeValue"].ToString()!="")
				{
					model.n_EMaxTimeValue=decimal.Parse(row["n_EMaxTimeValue"].ToString());
				}
				if(row["s_EMaxTimeUnit"]!=null)
				{
					model.s_EMaxTimeUnit=row["s_EMaxTimeUnit"].ToString();
				}
				if(row["s_AllowRepeat"]!=null)
				{
					model.s_AllowRepeat=row["s_AllowRepeat"].ToString();
				}
				if(row["s_BaseDate"]!=null)
				{
					model.s_BaseDate=row["s_BaseDate"].ToString();
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
			strSql.Append("select n_ID,n_CaseID,n_OrderNum,n_ProcessCodeID,dt_StartDate,dt_EndDate,s_Status,s_Notes,n_ParentID,s_ProcessName,n_EMinTimeValue,s_EMinTimeUnit,n_EMaxTimeValue,s_EMaxTimeUnit,s_AllowRepeat,s_BaseDate ");
			strSql.Append(" FROM TCase_Process ");
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
			strSql.Append(" n_ID,n_CaseID,n_OrderNum,n_ProcessCodeID,dt_StartDate,dt_EndDate,s_Status,s_Notes,n_ParentID,s_ProcessName,n_EMinTimeValue,s_EMinTimeUnit,n_EMaxTimeValue,s_EMaxTimeUnit,s_AllowRepeat,s_BaseDate ");
			strSql.Append(" FROM TCase_Process ");
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
			strSql.Append("select count(1) FROM TCase_Process ");
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
			strSql.Append(")AS Row, T.*  from TCase_Process T ");
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
			parameters[0].Value = "TCase_Process";
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

