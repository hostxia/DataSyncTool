/**  版本信息模板在安装目录下，可自行修改。
* TCode_OftenDemand.cs
*
* 功 能： N/A
* 类 名： TCode_OftenDemand
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:40   N/A    初版
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
	/// 数据访问类:TCode_OftenDemand
	/// </summary>
	public partial class TCode_OftenDemand
	{
		public TCode_OftenDemand()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CodeDemandID", "TCode_OftenDemand"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CodeDemandID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_OftenDemand");
			strSql.Append(" where n_CodeDemandID=@n_CodeDemandID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CodeDemandID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CodeDemandID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_OftenDemand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_OftenDemand(");
			strSql.Append("s_BusinessType,s_PatentType,s_TrademarkType,s_ApplicationType,n_CodeDemandID,s_CaseType,s_OftenCreator,s_OftenEditor,dt_OftenCreateDate,dt_OftenEditDate,s_Process)");
			strSql.Append(" values (");
			strSql.Append("@s_BusinessType,@s_PatentType,@s_TrademarkType,@s_ApplicationType,@n_CodeDemandID,@s_CaseType,@s_OftenCreator,@s_OftenEditor,@dt_OftenCreateDate,@dt_OftenEditDate,@s_Process)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_BusinessType", SqlDbType.NVarChar,500),
					new SqlParameter("@s_PatentType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_TrademarkType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ApplicationType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_CodeDemandID", SqlDbType.Int,4),
					new SqlParameter("@s_CaseType", SqlDbType.NVarChar,2),
					new SqlParameter("@s_OftenCreator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OftenEditor", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_OftenCreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_OftenEditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Process", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.s_BusinessType;
			parameters[1].Value = model.s_PatentType;
			parameters[2].Value = model.s_TrademarkType;
			parameters[3].Value = model.s_ApplicationType;
			parameters[4].Value = model.n_CodeDemandID;
			parameters[5].Value = model.s_CaseType;
			parameters[6].Value = model.s_OftenCreator;
			parameters[7].Value = model.s_OftenEditor;
			parameters[8].Value = model.dt_OftenCreateDate;
			parameters[9].Value = model.dt_OftenEditDate;
			parameters[10].Value = model.s_Process;

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
		public bool Update(IPSP.Model.TCode_OftenDemand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_OftenDemand set ");
			strSql.Append("s_BusinessType=@s_BusinessType,");
			strSql.Append("s_PatentType=@s_PatentType,");
			strSql.Append("s_TrademarkType=@s_TrademarkType,");
			strSql.Append("s_ApplicationType=@s_ApplicationType,");
			strSql.Append("s_CaseType=@s_CaseType,");
			strSql.Append("s_OftenCreator=@s_OftenCreator,");
			strSql.Append("s_OftenEditor=@s_OftenEditor,");
			strSql.Append("dt_OftenCreateDate=@dt_OftenCreateDate,");
			strSql.Append("dt_OftenEditDate=@dt_OftenEditDate,");
			strSql.Append("s_Process=@s_Process");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_BusinessType", SqlDbType.NVarChar,500),
					new SqlParameter("@s_PatentType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_TrademarkType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ApplicationType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CaseType", SqlDbType.NVarChar,2),
					new SqlParameter("@s_OftenCreator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OftenEditor", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_OftenCreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_OftenEditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Process", SqlDbType.NVarChar,500),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CodeDemandID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_BusinessType;
			parameters[1].Value = model.s_PatentType;
			parameters[2].Value = model.s_TrademarkType;
			parameters[3].Value = model.s_ApplicationType;
			parameters[4].Value = model.s_CaseType;
			parameters[5].Value = model.s_OftenCreator;
			parameters[6].Value = model.s_OftenEditor;
			parameters[7].Value = model.dt_OftenCreateDate;
			parameters[8].Value = model.dt_OftenEditDate;
			parameters[9].Value = model.s_Process;
			parameters[10].Value = model.n_ID;
			parameters[11].Value = model.n_CodeDemandID;

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
			strSql.Append("delete from TCode_OftenDemand ");
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
		public bool Delete(int n_CodeDemandID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_OftenDemand ");
			strSql.Append(" where n_CodeDemandID=@n_CodeDemandID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CodeDemandID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CodeDemandID;
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
			strSql.Append("delete from TCode_OftenDemand ");
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
		public IPSP.Model.TCode_OftenDemand GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_BusinessType,s_PatentType,s_TrademarkType,s_ApplicationType,n_CodeDemandID,s_CaseType,s_OftenCreator,s_OftenEditor,dt_OftenCreateDate,dt_OftenEditDate,s_Process from TCode_OftenDemand ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_OftenDemand model=new IPSP.Model.TCode_OftenDemand();
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
		public IPSP.Model.TCode_OftenDemand DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_OftenDemand model=new IPSP.Model.TCode_OftenDemand();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_BusinessType"]!=null)
				{
					model.s_BusinessType=row["s_BusinessType"].ToString();
				}
				if(row["s_PatentType"]!=null)
				{
					model.s_PatentType=row["s_PatentType"].ToString();
				}
				if(row["s_TrademarkType"]!=null)
				{
					model.s_TrademarkType=row["s_TrademarkType"].ToString();
				}
				if(row["s_ApplicationType"]!=null)
				{
					model.s_ApplicationType=row["s_ApplicationType"].ToString();
				}
				if(row["n_CodeDemandID"]!=null && row["n_CodeDemandID"].ToString()!="")
				{
					model.n_CodeDemandID=int.Parse(row["n_CodeDemandID"].ToString());
				}
				if(row["s_CaseType"]!=null)
				{
					model.s_CaseType=row["s_CaseType"].ToString();
				}
				if(row["s_OftenCreator"]!=null)
				{
					model.s_OftenCreator=row["s_OftenCreator"].ToString();
				}
				if(row["s_OftenEditor"]!=null)
				{
					model.s_OftenEditor=row["s_OftenEditor"].ToString();
				}
				if(row["dt_OftenCreateDate"]!=null && row["dt_OftenCreateDate"].ToString()!="")
				{
					model.dt_OftenCreateDate=DateTime.Parse(row["dt_OftenCreateDate"].ToString());
				}
				if(row["dt_OftenEditDate"]!=null && row["dt_OftenEditDate"].ToString()!="")
				{
					model.dt_OftenEditDate=DateTime.Parse(row["dt_OftenEditDate"].ToString());
				}
				if(row["s_Process"]!=null)
				{
					model.s_Process=row["s_Process"].ToString();
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
			strSql.Append("select n_ID,s_BusinessType,s_PatentType,s_TrademarkType,s_ApplicationType,n_CodeDemandID,s_CaseType,s_OftenCreator,s_OftenEditor,dt_OftenCreateDate,dt_OftenEditDate,s_Process ");
			strSql.Append(" FROM TCode_OftenDemand ");
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
			strSql.Append(" n_ID,s_BusinessType,s_PatentType,s_TrademarkType,s_ApplicationType,n_CodeDemandID,s_CaseType,s_OftenCreator,s_OftenEditor,dt_OftenCreateDate,dt_OftenEditDate,s_Process ");
			strSql.Append(" FROM TCode_OftenDemand ");
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
			strSql.Append("select count(1) FROM TCode_OftenDemand ");
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
			strSql.Append(")AS Row, T.*  from TCode_OftenDemand T ");
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
			parameters[0].Value = "TCode_OftenDemand";
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

