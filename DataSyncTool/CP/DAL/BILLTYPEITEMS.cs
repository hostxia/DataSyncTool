﻿using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:BILLTYPEITEMS
	/// </summary>
	public partial class BILLTYPEITEMS
	{
		public BILLTYPEITEMS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string BILLTYPE,string BILLCODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BILLTYPEITEMS");
			strSql.Append(" where BILLTYPE=:BILLTYPE and BILLCODE=:BILLCODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLTYPE", OracleType.VarChar,15),
					new OracleParameter(":BILLCODE", OracleType.VarChar,30)			};
			parameters[0].Value = BILLTYPE;
			parameters[1].Value = BILLCODE;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.BILLTYPEITEMS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BILLTYPEITEMS(");
			strSql.Append("BILLTYPE,BILLCODE)");
			strSql.Append(" values (");
			strSql.Append(":BILLTYPE,:BILLCODE)");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLTYPE", OracleType.VarChar,15),
					new OracleParameter(":BILLCODE", OracleType.VarChar,30)};
			parameters[0].Value = model.BILLTYPE;
			parameters[1].Value = model.BILLCODE;

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
		public bool Update(DataSyncTool.Model.BILLTYPEITEMS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BILLTYPEITEMS set ");
			strSql.Append("BILLTYPE=:BILLTYPE,");
			strSql.Append("BILLCODE=:BILLCODE");
			strSql.Append(" where BILLTYPE=:BILLTYPE and BILLCODE=:BILLCODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLTYPE", OracleType.VarChar,15),
					new OracleParameter(":BILLCODE", OracleType.VarChar,30)};
			parameters[0].Value = model.BILLTYPE;
			parameters[1].Value = model.BILLCODE;

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
		public bool Delete(string BILLTYPE,string BILLCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BILLTYPEITEMS ");
			strSql.Append(" where BILLTYPE=:BILLTYPE and BILLCODE=:BILLCODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLTYPE", OracleType.VarChar,15),
					new OracleParameter(":BILLCODE", OracleType.VarChar,30)			};
			parameters[0].Value = BILLTYPE;
			parameters[1].Value = BILLCODE;

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
		public DataSyncTool.Model.BILLTYPEITEMS GetModel(string BILLTYPE,string BILLCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select BILLTYPE,BILLCODE from BILLTYPEITEMS ");
			strSql.Append(" where BILLTYPE=:BILLTYPE and BILLCODE=:BILLCODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLTYPE", OracleType.VarChar,15),
					new OracleParameter(":BILLCODE", OracleType.VarChar,30)			};
			parameters[0].Value = BILLTYPE;
			parameters[1].Value = BILLCODE;

			DataSyncTool.Model.BILLTYPEITEMS model=new DataSyncTool.Model.BILLTYPEITEMS();
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
		public DataSyncTool.Model.BILLTYPEITEMS DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.BILLTYPEITEMS model=new DataSyncTool.Model.BILLTYPEITEMS();
			if (row != null)
			{
				if(row["BILLTYPE"]!=null)
				{
					model.BILLTYPE=row["BILLTYPE"].ToString();
				}
				if(row["BILLCODE"]!=null)
				{
					model.BILLCODE=row["BILLCODE"].ToString();
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
			strSql.Append("select BILLTYPE,BILLCODE ");
			strSql.Append(" FROM BILLTYPEITEMS ");
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
			strSql.Append("select count(1) FROM BILLTYPEITEMS ");
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
				strSql.Append("order by T.BILLCODE desc");
			}
			strSql.Append(")AS Row, T.*  from BILLTYPEITEMS T ");
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
			parameters[0].Value = "BILLTYPEITEMS";
			parameters[1].Value = "BILLCODE";
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

