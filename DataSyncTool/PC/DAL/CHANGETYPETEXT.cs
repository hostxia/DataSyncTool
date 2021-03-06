﻿using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:CHANGETYPETEXT
	/// </summary>
	public partial class CHANGETYPETEXT
	{
		public CHANGETYPETEXT()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.CHANGETYPETEXT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CHANGETYPETEXT(");
			strSql.Append("CHANGE,TEXT)");
			strSql.Append(" values (");
			strSql.Append(":CHANGE,:TEXT)");
			OracleParameter[] parameters = {
					new OracleParameter(":CHANGE", OracleType.Char,1),
					new OracleParameter(":TEXT", OracleType.VarChar,20)};
			parameters[0].Value = model.CHANGE;
			parameters[1].Value = model.TEXT;

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
		public bool Update(Model.CHANGETYPETEXT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CHANGETYPETEXT set ");
			strSql.Append("CHANGE=:CHANGE,");
			strSql.Append("TEXT=:TEXT");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":CHANGE", OracleType.Char,1),
					new OracleParameter(":TEXT", OracleType.VarChar,20)};
			parameters[0].Value = model.CHANGE;
			parameters[1].Value = model.TEXT;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CHANGETYPETEXT ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Model.CHANGETYPETEXT GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CHANGE,TEXT from CHANGETYPETEXT ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Model.CHANGETYPETEXT model=new Model.CHANGETYPETEXT();
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
		public Model.CHANGETYPETEXT DataRowToModel(DataRow row)
		{
			Model.CHANGETYPETEXT model=new Model.CHANGETYPETEXT();
			if (row != null)
			{
				if(row["CHANGE"]!=null)
				{
					model.CHANGE=row["CHANGE"].ToString();
				}
				if(row["TEXT"]!=null)
				{
					model.TEXT=row["TEXT"].ToString();
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
			strSql.Append("select CHANGE,TEXT ");
			strSql.Append(" FROM CHANGETYPETEXT ");
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
			strSql.Append("select count(1) FROM CHANGETYPETEXT ");
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
				strSql.Append("order by T.INFOTYPE desc");
			}
			strSql.Append(")AS Row, T.*  from CHANGETYPETEXT T ");
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
			parameters[0].Value = "CHANGETYPETEXT";
			parameters[1].Value = "INFOTYPE";
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

