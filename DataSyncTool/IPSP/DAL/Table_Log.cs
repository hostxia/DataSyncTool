﻿/**  版本信息模板在安装目录下，可自行修改。
* Table_Log.cs
*
* 功 能： N/A
* 类 名： Table_Log
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:22   N/A    初版
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
	/// 数据访问类:Table_Log
	/// </summary>
	public partial class Table_Log
	{
		public Table_Log()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.Table_Log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Table_Log(");
			strSql.Append("n_CaseID,n_RowID,s_CaseSerial,strsql,tableName,ExcelName,str2,msg)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@n_RowID,@s_CaseSerial,@strsql,@tableName,@ExcelName,@str2,@msg)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_RowID", SqlDbType.Int,4),
					new SqlParameter("@s_CaseSerial", SqlDbType.VarChar,500),
					new SqlParameter("@strsql", SqlDbType.VarChar,2000),
					new SqlParameter("@tableName", SqlDbType.VarChar,500),
					new SqlParameter("@ExcelName", SqlDbType.VarChar,500),
					new SqlParameter("@str2", SqlDbType.VarChar,2000),
					new SqlParameter("@msg", SqlDbType.VarChar,2000)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.n_RowID;
			parameters[2].Value = model.s_CaseSerial;
			parameters[3].Value = model.strsql;
			parameters[4].Value = model.tableName;
			parameters[5].Value = model.ExcelName;
			parameters[6].Value = model.str2;
			parameters[7].Value = model.msg;

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
		public bool Update(IPSP.Model.Table_Log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Table_Log set ");
			strSql.Append("n_CaseID=@n_CaseID,");
			strSql.Append("n_RowID=@n_RowID,");
			strSql.Append("s_CaseSerial=@s_CaseSerial,");
			strSql.Append("strsql=@strsql,");
			strSql.Append("tableName=@tableName,");
			strSql.Append("ExcelName=@ExcelName,");
			strSql.Append("str2=@str2,");
			strSql.Append("msg=@msg");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_RowID", SqlDbType.Int,4),
					new SqlParameter("@s_CaseSerial", SqlDbType.VarChar,500),
					new SqlParameter("@strsql", SqlDbType.VarChar,2000),
					new SqlParameter("@tableName", SqlDbType.VarChar,500),
					new SqlParameter("@ExcelName", SqlDbType.VarChar,500),
					new SqlParameter("@str2", SqlDbType.VarChar,2000),
					new SqlParameter("@msg", SqlDbType.VarChar,2000),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.n_RowID;
			parameters[2].Value = model.s_CaseSerial;
			parameters[3].Value = model.strsql;
			parameters[4].Value = model.tableName;
			parameters[5].Value = model.ExcelName;
			parameters[6].Value = model.str2;
			parameters[7].Value = model.msg;
			parameters[8].Value = model.n_ID;

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
			strSql.Append("delete from Table_Log ");
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
			strSql.Append("delete from Table_Log ");
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
		public IPSP.Model.Table_Log GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CaseID,n_RowID,s_CaseSerial,strsql,tableName,ExcelName,str2,msg from Table_Log ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.Table_Log model=new IPSP.Model.Table_Log();
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
		public IPSP.Model.Table_Log DataRowToModel(DataRow row)
		{
			IPSP.Model.Table_Log model=new IPSP.Model.Table_Log();
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
				if(row["n_RowID"]!=null && row["n_RowID"].ToString()!="")
				{
					model.n_RowID=int.Parse(row["n_RowID"].ToString());
				}
				if(row["s_CaseSerial"]!=null)
				{
					model.s_CaseSerial=row["s_CaseSerial"].ToString();
				}
				if(row["strsql"]!=null)
				{
					model.strsql=row["strsql"].ToString();
				}
				if(row["tableName"]!=null)
				{
					model.tableName=row["tableName"].ToString();
				}
				if(row["ExcelName"]!=null)
				{
					model.ExcelName=row["ExcelName"].ToString();
				}
				if(row["str2"]!=null)
				{
					model.str2=row["str2"].ToString();
				}
				if(row["msg"]!=null)
				{
					model.msg=row["msg"].ToString();
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
			strSql.Append("select n_ID,n_CaseID,n_RowID,s_CaseSerial,strsql,tableName,ExcelName,str2,msg ");
			strSql.Append(" FROM Table_Log ");
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
			strSql.Append(" n_ID,n_CaseID,n_RowID,s_CaseSerial,strsql,tableName,ExcelName,str2,msg ");
			strSql.Append(" FROM Table_Log ");
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
			strSql.Append("select count(1) FROM Table_Log ");
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
			strSql.Append(")AS Row, T.*  from Table_Log T ");
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
			parameters[0].Value = "Table_Log";
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

