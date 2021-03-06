﻿using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:TEST5
	/// </summary>
	public partial class TEST5
	{
		public TEST5()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.TEST5 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TEST5(");
			strSql.Append("APPLICATION_NO,STR)");
			strSql.Append(" values (");
			strSql.Append(":APPLICATION_NO,:STR)");
			OracleParameter[] parameters = {
					new OracleParameter(":APPLICATION_NO", OracleType.VarChar,30),
					new OracleParameter(":STR", OracleType.VarChar,30)};
			parameters[0].Value = model.APPLICATION_NO;
			parameters[1].Value = model.STR;

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
		public bool Update(Model.TEST5 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TEST5 set ");
			strSql.Append("APPLICATION_NO=:APPLICATION_NO,");
			strSql.Append("STR=:STR");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":APPLICATION_NO", OracleType.VarChar,30),
					new OracleParameter(":STR", OracleType.VarChar,30)};
			parameters[0].Value = model.APPLICATION_NO;
			parameters[1].Value = model.STR;

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
			strSql.Append("delete from TEST5 ");
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
		public Model.TEST5 GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select APPLICATION_NO,STR from TEST5 ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Model.TEST5 model=new Model.TEST5();
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
		public Model.TEST5 DataRowToModel(DataRow row)
		{
			Model.TEST5 model=new Model.TEST5();
			if (row != null)
			{
				if(row["APPLICATION_NO"]!=null)
				{
					model.APPLICATION_NO=row["APPLICATION_NO"].ToString();
				}
				if(row["STR"]!=null)
				{
					model.STR=row["STR"].ToString();
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
			strSql.Append("select APPLICATION_NO,STR ");
			strSql.Append(" FROM TEST5 ");
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
			strSql.Append("select count(1) FROM TEST5 ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from TEST5 T ");
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
			parameters[0].Value = "TEST5";
			parameters[1].Value = "ID";
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

