﻿using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:BILLTYPE
	/// </summary>
	public partial class BILLTYPE
	{
		public BILLTYPE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string BILLTYPE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BILLTYPE");
			strSql.Append(" where BILLTYPE=:BILLTYPE ");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLTYPE", OracleType.VarChar,15)			};
			parameters[0].Value = BILLTYPE;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.BILLTYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BILLTYPE(");
			strSql.Append("BILLTYPE,DESCRIPTION,CASETYPE)");
			strSql.Append(" values (");
			strSql.Append(":BILLTYPE,:DESCRIPTION,:CASETYPE)");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLTYPE", OracleType.VarChar,15),
					new OracleParameter(":DESCRIPTION", OracleType.VarChar,100),
					new OracleParameter(":CASETYPE", OracleType.Char,5)};
			parameters[0].Value = model.BILLTYPE1;
			parameters[1].Value = model.DESCRIPTION;
			parameters[2].Value = model.CASETYPE;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(DataSyncTool.Model.BILLTYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BILLTYPE set ");
			strSql.Append("BILLTYPE=:BILLTYPE,");
			strSql.Append("DESCRIPTION=:DESCRIPTION,");
			strSql.Append("CASETYPE=:CASETYPE");
			strSql.Append(" where BILLTYPE=:BILLTYPE ");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLTYPE", OracleType.VarChar,15),
					new OracleParameter(":DESCRIPTION", OracleType.VarChar,100),
					new OracleParameter(":CASETYPE", OracleType.Char,5)};
			parameters[0].Value = model.BILLTYPE1;
			parameters[1].Value = model.DESCRIPTION;
			parameters[2].Value = model.CASETYPE;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(string BILLTYPE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BILLTYPE ");
			strSql.Append(" where BILLTYPE=:BILLTYPE ");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLTYPE", OracleType.VarChar,15)			};
			parameters[0].Value = BILLTYPE;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string BILLTYPElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BILLTYPE ");
			strSql.Append(" where BILLTYPE in ("+BILLTYPElist + ")  ");
			int rows=DbHelperOra.ExecuteSql(strSql.ToString());
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
		public DataSyncTool.Model.BILLTYPE GetModel(string BILLTYPE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select BILLTYPE,DESCRIPTION,CASETYPE from BILLTYPE ");
			strSql.Append(" where BILLTYPE=:BILLTYPE ");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLTYPE", OracleType.VarChar,15)			};
			parameters[0].Value = BILLTYPE;

			DataSyncTool.Model.BILLTYPE model=new DataSyncTool.Model.BILLTYPE();
			DataSet ds=DbHelperOra.Query(strSql.ToString(),parameters);
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
		public DataSyncTool.Model.BILLTYPE DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.BILLTYPE model=new DataSyncTool.Model.BILLTYPE();
			if (row != null)
			{
				if(row["BILLTYPE"]!=null)
				{
					model.BILLTYPE1=row["BILLTYPE"].ToString();
				}
				if(row["DESCRIPTION"]!=null)
				{
					model.DESCRIPTION=row["DESCRIPTION"].ToString();
				}
				if(row["CASETYPE"]!=null)
				{
					model.CASETYPE=row["CASETYPE"].ToString();
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
			strSql.Append("select BILLTYPE,DESCRIPTION,CASETYPE ");
			strSql.Append(" FROM BILLTYPE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM BILLTYPE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperOra.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.BILLTYPE desc");
			}
			strSql.Append(")AS Row, T.*  from BILLTYPE T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOra.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OracleParameter[] parameters = {
					new OracleParameter(":tblName", OracleType.VarChar, 255),
					new OracleParameter(":fldName", OracleType.VarChar, 255),
					new OracleParameter(":PageSize", OracleType.Number),
					new OracleParameter(":PageIndex", OracleType.Number),
					new OracleParameter(":IsReCount", OracleType.Clob),
					new OracleParameter(":OrderType", OracleType.Clob),
					new OracleParameter(":strWhere", OracleType.VarChar,1000),
					};
			parameters[0].Value = "BILLTYPE";
			parameters[1].Value = "BILLTYPE";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

