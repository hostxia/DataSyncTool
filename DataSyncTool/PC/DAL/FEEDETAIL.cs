﻿using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:FEEDETAIL
	/// </summary>
	public partial class FEEDETAIL
	{
		public FEEDETAIL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CASENO,string CLIENTNO,string VOUCHERNO,string FEETYPE,decimal AMOUNT,string PAYMETHOD,DateTime PAYDATE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FEEDETAIL");
			strSql.Append(" where CASENO=:CASENO and CLIENTNO=:CLIENTNO and VOUCHERNO=:VOUCHERNO and FEETYPE=:FEETYPE and AMOUNT=:AMOUNT and PAYMETHOD=:PAYMETHOD and PAYDATE=:PAYDATE ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,50),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,10),
					new OracleParameter(":VOUCHERNO", OracleType.VarChar,20),
					new OracleParameter(":FEETYPE", OracleType.VarChar,40),
					new OracleParameter(":AMOUNT", OracleType.Number,22),
					new OracleParameter(":PAYMETHOD", OracleType.VarChar,40),
					new OracleParameter(":PAYDATE", OracleType.DateTime)			};
			parameters[0].Value = CASENO;
			parameters[1].Value = CLIENTNO;
			parameters[2].Value = VOUCHERNO;
			parameters[3].Value = FEETYPE;
			parameters[4].Value = AMOUNT;
			parameters[5].Value = PAYMETHOD;
			parameters[6].Value = PAYDATE;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.FEEDETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FEEDETAIL(");
			strSql.Append("CASENO,CLIENTNO,VOUCHERNO,FEETYPE,AMOUNT,PAYMETHOD,PAYDATE,CHECKBY)");
			strSql.Append(" values (");
			strSql.Append(":CASENO,:CLIENTNO,:VOUCHERNO,:FEETYPE,:AMOUNT,:PAYMETHOD,:PAYDATE,:CHECKBY)");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,50),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,10),
					new OracleParameter(":VOUCHERNO", OracleType.VarChar,20),
					new OracleParameter(":FEETYPE", OracleType.VarChar,40),
					new OracleParameter(":AMOUNT", OracleType.Number,9),
					new OracleParameter(":PAYMETHOD", OracleType.VarChar,40),
					new OracleParameter(":PAYDATE", OracleType.DateTime),
					new OracleParameter(":CHECKBY", OracleType.VarChar,10)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.CLIENTNO;
			parameters[2].Value = model.VOUCHERNO;
			parameters[3].Value = model.FEETYPE;
			parameters[4].Value = model.AMOUNT;
			parameters[5].Value = model.PAYMETHOD;
			parameters[6].Value = model.PAYDATE;
			parameters[7].Value = model.CHECKBY;

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
		public bool Update(Model.FEEDETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FEEDETAIL set ");
			strSql.Append("CASENO=:CASENO,");
			strSql.Append("CLIENTNO=:CLIENTNO,");
			strSql.Append("VOUCHERNO=:VOUCHERNO,");
			strSql.Append("FEETYPE=:FEETYPE,");
			strSql.Append("AMOUNT=:AMOUNT,");
			strSql.Append("PAYMETHOD=:PAYMETHOD,");
			strSql.Append("PAYDATE=:PAYDATE,");
			strSql.Append("CHECKBY=:CHECKBY");
			strSql.Append(" where CASENO=:CASENO and CLIENTNO=:CLIENTNO and VOUCHERNO=:VOUCHERNO and FEETYPE=:FEETYPE and AMOUNT=:AMOUNT and PAYMETHOD=:PAYMETHOD and PAYDATE=:PAYDATE ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,50),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,10),
					new OracleParameter(":VOUCHERNO", OracleType.VarChar,20),
					new OracleParameter(":FEETYPE", OracleType.VarChar,40),
					new OracleParameter(":AMOUNT", OracleType.Number,9),
					new OracleParameter(":PAYMETHOD", OracleType.VarChar,40),
					new OracleParameter(":PAYDATE", OracleType.DateTime),
					new OracleParameter(":CHECKBY", OracleType.VarChar,10)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.CLIENTNO;
			parameters[2].Value = model.VOUCHERNO;
			parameters[3].Value = model.FEETYPE;
			parameters[4].Value = model.AMOUNT;
			parameters[5].Value = model.PAYMETHOD;
			parameters[6].Value = model.PAYDATE;
			parameters[7].Value = model.CHECKBY;

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
		public bool Delete(string CASENO,string CLIENTNO,string VOUCHERNO,string FEETYPE,decimal AMOUNT,string PAYMETHOD,DateTime PAYDATE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FEEDETAIL ");
			strSql.Append(" where CASENO=:CASENO and CLIENTNO=:CLIENTNO and VOUCHERNO=:VOUCHERNO and FEETYPE=:FEETYPE and AMOUNT=:AMOUNT and PAYMETHOD=:PAYMETHOD and PAYDATE=:PAYDATE ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,50),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,10),
					new OracleParameter(":VOUCHERNO", OracleType.VarChar,20),
					new OracleParameter(":FEETYPE", OracleType.VarChar,40),
					new OracleParameter(":AMOUNT", OracleType.Number,22),
					new OracleParameter(":PAYMETHOD", OracleType.VarChar,40),
					new OracleParameter(":PAYDATE", OracleType.DateTime)			};
			parameters[0].Value = CASENO;
			parameters[1].Value = CLIENTNO;
			parameters[2].Value = VOUCHERNO;
			parameters[3].Value = FEETYPE;
			parameters[4].Value = AMOUNT;
			parameters[5].Value = PAYMETHOD;
			parameters[6].Value = PAYDATE;

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
		public Model.FEEDETAIL GetModel(string CASENO,string CLIENTNO,string VOUCHERNO,string FEETYPE,decimal AMOUNT,string PAYMETHOD,DateTime PAYDATE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CASENO,CLIENTNO,VOUCHERNO,FEETYPE,AMOUNT,PAYMETHOD,PAYDATE,CHECKBY from FEEDETAIL ");
			strSql.Append(" where CASENO=:CASENO and CLIENTNO=:CLIENTNO and VOUCHERNO=:VOUCHERNO and FEETYPE=:FEETYPE and AMOUNT=:AMOUNT and PAYMETHOD=:PAYMETHOD and PAYDATE=:PAYDATE ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,50),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,10),
					new OracleParameter(":VOUCHERNO", OracleType.VarChar,20),
					new OracleParameter(":FEETYPE", OracleType.VarChar,40),
					new OracleParameter(":AMOUNT", OracleType.Number,22),
					new OracleParameter(":PAYMETHOD", OracleType.VarChar,40),
					new OracleParameter(":PAYDATE", OracleType.DateTime)			};
			parameters[0].Value = CASENO;
			parameters[1].Value = CLIENTNO;
			parameters[2].Value = VOUCHERNO;
			parameters[3].Value = FEETYPE;
			parameters[4].Value = AMOUNT;
			parameters[5].Value = PAYMETHOD;
			parameters[6].Value = PAYDATE;

			Model.FEEDETAIL model=new Model.FEEDETAIL();
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
		public Model.FEEDETAIL DataRowToModel(DataRow row)
		{
			Model.FEEDETAIL model=new Model.FEEDETAIL();
			if (row != null)
			{
				if(row["CASENO"]!=null)
				{
					model.CASENO=row["CASENO"].ToString();
				}
				if(row["CLIENTNO"]!=null)
				{
					model.CLIENTNO=row["CLIENTNO"].ToString();
				}
				if(row["VOUCHERNO"]!=null)
				{
					model.VOUCHERNO=row["VOUCHERNO"].ToString();
				}
				if(row["FEETYPE"]!=null)
				{
					model.FEETYPE=row["FEETYPE"].ToString();
				}
				if(row["AMOUNT"]!=null && row["AMOUNT"].ToString()!="")
				{
					model.AMOUNT=decimal.Parse(row["AMOUNT"].ToString());
				}
				if(row["PAYMETHOD"]!=null)
				{
					model.PAYMETHOD=row["PAYMETHOD"].ToString();
				}
				if(row["PAYDATE"]!=null && row["PAYDATE"].ToString()!="")
				{
					model.PAYDATE=DateTime.Parse(row["PAYDATE"].ToString());
				}
				if(row["CHECKBY"]!=null)
				{
					model.CHECKBY=row["CHECKBY"].ToString();
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
			strSql.Append("select CASENO,CLIENTNO,VOUCHERNO,FEETYPE,AMOUNT,PAYMETHOD,PAYDATE,CHECKBY ");
			strSql.Append(" FROM FEEDETAIL ");
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
			strSql.Append("select count(1) FROM FEEDETAIL ");
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
				strSql.Append("order by T.PAYDATE desc");
			}
			strSql.Append(")AS Row, T.*  from FEEDETAIL T ");
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
			parameters[0].Value = "FEEDETAIL";
			parameters[1].Value = "PAYDATE";
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

