/**  版本信息模板在安装目录下，可自行修改。
* TTCase_Renewal.cs
*
* 功 能： N/A
* 类 名： TTCase_Renewal
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:57   N/A    初版
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
	/// 数据访问类:TTCase_Renewal
	/// </summary>
	public partial class TTCase_Renewal
	{
		public TTCase_Renewal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TTCase_Renewal"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TTCase_Renewal");
			strSql.Append(" where n_CaseID=@n_CaseID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TTCase_Renewal model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TTCase_Renewal(");
			strSql.Append("n_CaseID,s_NotifyStatus,s_ClientConfStatus,dt_Consign,dt_Publish,s_PubNum,s_PubIssue,s_PubVol,s_RenewalFilePath,dt_Effective,dt_End,s_Status,n_FeeID,s_Notes)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@s_NotifyStatus,@s_ClientConfStatus,@dt_Consign,@dt_Publish,@s_PubNum,@s_PubIssue,@s_PubVol,@s_RenewalFilePath,@dt_Effective,@dt_End,@s_Status,@n_FeeID,@s_Notes)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_NotifyStatus", SqlDbType.NVarChar,20),
					new SqlParameter("@s_ClientConfStatus", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_Consign", SqlDbType.DateTime),
					new SqlParameter("@dt_Publish", SqlDbType.DateTime),
					new SqlParameter("@s_PubNum", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PubIssue", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PubVol", SqlDbType.NVarChar,50),
					new SqlParameter("@s_RenewalFilePath", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_Effective", SqlDbType.DateTime),
					new SqlParameter("@dt_End", SqlDbType.DateTime),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@n_FeeID", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_NotifyStatus;
			parameters[2].Value = model.s_ClientConfStatus;
			parameters[3].Value = model.dt_Consign;
			parameters[4].Value = model.dt_Publish;
			parameters[5].Value = model.s_PubNum;
			parameters[6].Value = model.s_PubIssue;
			parameters[7].Value = model.s_PubVol;
			parameters[8].Value = model.s_RenewalFilePath;
			parameters[9].Value = model.dt_Effective;
			parameters[10].Value = model.dt_End;
			parameters[11].Value = model.s_Status;
			parameters[12].Value = model.n_FeeID;
			parameters[13].Value = model.s_Notes;

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
		public bool Update(IPSP.Model.TTCase_Renewal model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TTCase_Renewal set ");
			strSql.Append("s_NotifyStatus=@s_NotifyStatus,");
			strSql.Append("s_ClientConfStatus=@s_ClientConfStatus,");
			strSql.Append("dt_Consign=@dt_Consign,");
			strSql.Append("dt_Publish=@dt_Publish,");
			strSql.Append("s_PubNum=@s_PubNum,");
			strSql.Append("s_PubIssue=@s_PubIssue,");
			strSql.Append("s_PubVol=@s_PubVol,");
			strSql.Append("s_RenewalFilePath=@s_RenewalFilePath,");
			strSql.Append("dt_Effective=@dt_Effective,");
			strSql.Append("dt_End=@dt_End,");
			strSql.Append("s_Status=@s_Status,");
			strSql.Append("n_FeeID=@n_FeeID,");
			strSql.Append("s_Notes=@s_Notes");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_NotifyStatus", SqlDbType.NVarChar,20),
					new SqlParameter("@s_ClientConfStatus", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_Consign", SqlDbType.DateTime),
					new SqlParameter("@dt_Publish", SqlDbType.DateTime),
					new SqlParameter("@s_PubNum", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PubIssue", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PubVol", SqlDbType.NVarChar,50),
					new SqlParameter("@s_RenewalFilePath", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_Effective", SqlDbType.DateTime),
					new SqlParameter("@dt_End", SqlDbType.DateTime),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@n_FeeID", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_NotifyStatus;
			parameters[1].Value = model.s_ClientConfStatus;
			parameters[2].Value = model.dt_Consign;
			parameters[3].Value = model.dt_Publish;
			parameters[4].Value = model.s_PubNum;
			parameters[5].Value = model.s_PubIssue;
			parameters[6].Value = model.s_PubVol;
			parameters[7].Value = model.s_RenewalFilePath;
			parameters[8].Value = model.dt_Effective;
			parameters[9].Value = model.dt_End;
			parameters[10].Value = model.s_Status;
			parameters[11].Value = model.n_FeeID;
			parameters[12].Value = model.s_Notes;
			parameters[13].Value = model.n_ID;
			parameters[14].Value = model.n_CaseID;

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
			strSql.Append("delete from TTCase_Renewal ");
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
		public bool Delete(int n_CaseID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TTCase_Renewal ");
			strSql.Append(" where n_CaseID=@n_CaseID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
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
			strSql.Append("delete from TTCase_Renewal ");
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
		public IPSP.Model.TTCase_Renewal GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CaseID,s_NotifyStatus,s_ClientConfStatus,dt_Consign,dt_Publish,s_PubNum,s_PubIssue,s_PubVol,s_RenewalFilePath,dt_Effective,dt_End,s_Status,n_FeeID,s_Notes from TTCase_Renewal ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TTCase_Renewal model=new IPSP.Model.TTCase_Renewal();
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
		public IPSP.Model.TTCase_Renewal DataRowToModel(DataRow row)
		{
			IPSP.Model.TTCase_Renewal model=new IPSP.Model.TTCase_Renewal();
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
				if(row["s_NotifyStatus"]!=null)
				{
					model.s_NotifyStatus=row["s_NotifyStatus"].ToString();
				}
				if(row["s_ClientConfStatus"]!=null)
				{
					model.s_ClientConfStatus=row["s_ClientConfStatus"].ToString();
				}
				if(row["dt_Consign"]!=null && row["dt_Consign"].ToString()!="")
				{
					model.dt_Consign=DateTime.Parse(row["dt_Consign"].ToString());
				}
				if(row["dt_Publish"]!=null && row["dt_Publish"].ToString()!="")
				{
					model.dt_Publish=DateTime.Parse(row["dt_Publish"].ToString());
				}
				if(row["s_PubNum"]!=null)
				{
					model.s_PubNum=row["s_PubNum"].ToString();
				}
				if(row["s_PubIssue"]!=null)
				{
					model.s_PubIssue=row["s_PubIssue"].ToString();
				}
				if(row["s_PubVol"]!=null)
				{
					model.s_PubVol=row["s_PubVol"].ToString();
				}
				if(row["s_RenewalFilePath"]!=null)
				{
					model.s_RenewalFilePath=row["s_RenewalFilePath"].ToString();
				}
				if(row["dt_Effective"]!=null && row["dt_Effective"].ToString()!="")
				{
					model.dt_Effective=DateTime.Parse(row["dt_Effective"].ToString());
				}
				if(row["dt_End"]!=null && row["dt_End"].ToString()!="")
				{
					model.dt_End=DateTime.Parse(row["dt_End"].ToString());
				}
				if(row["s_Status"]!=null)
				{
					model.s_Status=row["s_Status"].ToString();
				}
				if(row["n_FeeID"]!=null && row["n_FeeID"].ToString()!="")
				{
					model.n_FeeID=int.Parse(row["n_FeeID"].ToString());
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
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
			strSql.Append("select n_ID,n_CaseID,s_NotifyStatus,s_ClientConfStatus,dt_Consign,dt_Publish,s_PubNum,s_PubIssue,s_PubVol,s_RenewalFilePath,dt_Effective,dt_End,s_Status,n_FeeID,s_Notes ");
			strSql.Append(" FROM TTCase_Renewal ");
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
			strSql.Append(" n_ID,n_CaseID,s_NotifyStatus,s_ClientConfStatus,dt_Consign,dt_Publish,s_PubNum,s_PubIssue,s_PubVol,s_RenewalFilePath,dt_Effective,dt_End,s_Status,n_FeeID,s_Notes ");
			strSql.Append(" FROM TTCase_Renewal ");
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
			strSql.Append("select count(1) FROM TTCase_Renewal ");
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
			strSql.Append(")AS Row, T.*  from TTCase_Renewal T ");
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
			parameters[0].Value = "TTCase_Renewal";
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

