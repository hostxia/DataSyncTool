﻿using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:BILLCODE
	/// </summary>
	public partial class BILLCODE
	{
		public BILLCODE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BILLCODE");
			strSql.Append(" where CODE=:CODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":CODE", OracleType.VarChar,20)			};
			parameters[0].Value = CODE;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.BILLCODE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BILLCODE(");
			strSql.Append("CODE,GROUPID,TEXT,TYPES,DISPLAYORDER)");
			strSql.Append(" values (");
			strSql.Append(":CODE,:GROUPID,:TEXT,:TYPES,:DISPLAYORDER)");
			OracleParameter[] parameters = {
					new OracleParameter(":CODE", OracleType.VarChar,20),
					new OracleParameter(":GROUPID", OracleType.VarChar,20),
					new OracleParameter(":TEXT", OracleType.VarChar,200),
					new OracleParameter(":TYPES", OracleType.VarChar,10),
					new OracleParameter(":DISPLAYORDER", OracleType.Number,3)};
			parameters[0].Value = model.CODE;
			parameters[1].Value = model.GROUPID;
			parameters[2].Value = model.TEXT;
			parameters[3].Value = model.TYPES;
			parameters[4].Value = model.DISPLAYORDER;

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
		public bool Update(Model.BILLCODE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BILLCODE set ");
			strSql.Append("CODE=:CODE,");
			strSql.Append("GROUPID=:GROUPID,");
			strSql.Append("TEXT=:TEXT,");
			strSql.Append("TYPES=:TYPES,");
			strSql.Append("DISPLAYORDER=:DISPLAYORDER");
			strSql.Append(" where CODE=:CODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":CODE", OracleType.VarChar,20),
					new OracleParameter(":GROUPID", OracleType.VarChar,20),
					new OracleParameter(":TEXT", OracleType.VarChar,200),
					new OracleParameter(":TYPES", OracleType.VarChar,10),
					new OracleParameter(":DISPLAYORDER", OracleType.Number,3)};
			parameters[0].Value = model.CODE;
			parameters[1].Value = model.GROUPID;
			parameters[2].Value = model.TEXT;
			parameters[3].Value = model.TYPES;
			parameters[4].Value = model.DISPLAYORDER;

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
		public bool Delete(string CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BILLCODE ");
			strSql.Append(" where CODE=:CODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":CODE", OracleType.VarChar,20)			};
			parameters[0].Value = CODE;

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
		public bool DeleteList(string CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BILLCODE ");
			strSql.Append(" where CODE in ("+CODElist + ")  ");
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
		public Model.BILLCODE GetModel(string CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CODE,GROUPID,TEXT,TYPES,DISPLAYORDER from BILLCODE ");
			strSql.Append(" where CODE=:CODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":CODE", OracleType.VarChar,20)			};
			parameters[0].Value = CODE;

			Model.BILLCODE model=new Model.BILLCODE();
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
		public Model.BILLCODE DataRowToModel(DataRow row)
		{
			Model.BILLCODE model=new Model.BILLCODE();
			if (row != null)
			{
				if(row["CODE"]!=null)
				{
					model.CODE=row["CODE"].ToString();
				}
				if(row["GROUPID"]!=null)
				{
					model.GROUPID=row["GROUPID"].ToString();
				}
				if(row["TEXT"]!=null)
				{
					model.TEXT=row["TEXT"].ToString();
				}
				if(row["TYPES"]!=null)
				{
					model.TYPES=row["TYPES"].ToString();
				}
				if(row["DISPLAYORDER"]!=null && row["DISPLAYORDER"].ToString()!="")
				{
					model.DISPLAYORDER=decimal.Parse(row["DISPLAYORDER"].ToString());
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
			strSql.Append("select CODE,GROUPID,TEXT,TYPES,DISPLAYORDER ");
			strSql.Append(" FROM BILLCODE ");
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
			strSql.Append("select count(1) FROM BILLCODE ");
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
				strSql.Append("order by T.CODE desc");
			}
			strSql.Append(")AS Row, T.*  from BILLCODE T ");
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
			parameters[0].Value = "BILLCODE";
			parameters[1].Value = "CODE";
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

