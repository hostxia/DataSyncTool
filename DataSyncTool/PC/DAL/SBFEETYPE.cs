﻿using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:SBFEETYPE
	/// </summary>
	public partial class SBFEETYPE
	{
		public SBFEETYPE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string TYPENAME)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SBFEETYPE");
			strSql.Append(" where TYPENAME=:TYPENAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPENAME", OracleType.VarChar,40)			};
			parameters[0].Value = TYPENAME;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.SBFEETYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SBFEETYPE(");
			strSql.Append("TYPENAME,TYPEGROUP)");
			strSql.Append(" values (");
			strSql.Append(":TYPENAME,:TYPEGROUP)");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPENAME", OracleType.VarChar,40),
					new OracleParameter(":TYPEGROUP", OracleType.VarChar,40)};
			parameters[0].Value = model.TYPENAME;
			parameters[1].Value = model.TYPEGROUP;

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
		public bool Update(Model.SBFEETYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SBFEETYPE set ");
			strSql.Append("TYPENAME=:TYPENAME,");
			strSql.Append("TYPEGROUP=:TYPEGROUP");
			strSql.Append(" where TYPENAME=:TYPENAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPENAME", OracleType.VarChar,40),
					new OracleParameter(":TYPEGROUP", OracleType.VarChar,40)};
			parameters[0].Value = model.TYPENAME;
			parameters[1].Value = model.TYPEGROUP;

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
		public bool Delete(string TYPENAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SBFEETYPE ");
			strSql.Append(" where TYPENAME=:TYPENAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPENAME", OracleType.VarChar,40)			};
			parameters[0].Value = TYPENAME;

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
		public bool DeleteList(string TYPENAMElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SBFEETYPE ");
			strSql.Append(" where TYPENAME in ("+TYPENAMElist + ")  ");
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
		public Model.SBFEETYPE GetModel(string TYPENAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TYPENAME,TYPEGROUP from SBFEETYPE ");
			strSql.Append(" where TYPENAME=:TYPENAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPENAME", OracleType.VarChar,40)			};
			parameters[0].Value = TYPENAME;

			Model.SBFEETYPE model=new Model.SBFEETYPE();
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
		public Model.SBFEETYPE DataRowToModel(DataRow row)
		{
			Model.SBFEETYPE model=new Model.SBFEETYPE();
			if (row != null)
			{
				if(row["TYPENAME"]!=null)
				{
					model.TYPENAME=row["TYPENAME"].ToString();
				}
				if(row["TYPEGROUP"]!=null)
				{
					model.TYPEGROUP=row["TYPEGROUP"].ToString();
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
			strSql.Append("select TYPENAME,TYPEGROUP ");
			strSql.Append(" FROM SBFEETYPE ");
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
			strSql.Append("select count(1) FROM SBFEETYPE ");
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
				strSql.Append("order by T.TYPENAME desc");
			}
			strSql.Append(")AS Row, T.*  from SBFEETYPE T ");
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
			parameters[0].Value = "SBFEETYPE";
			parameters[1].Value = "TYPENAME";
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

