﻿using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:SBFEEDETAIL
	/// </summary>
	public partial class SBFEEDETAIL
	{
		public SBFEEDETAIL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CASENO,string CLIENTNO,string VOUCHERNO,string FEETYPE,decimal AMOUNT,string PAYMETHOD,DateTime PAYDATE,string TRADEMARKNAME)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SBFEEDETAIL");
			strSql.Append(" where CASENO=:CASENO and CLIENTNO=:CLIENTNO and VOUCHERNO=:VOUCHERNO and FEETYPE=:FEETYPE and AMOUNT=:AMOUNT and PAYMETHOD=:PAYMETHOD and PAYDATE=:PAYDATE and TRADEMARKNAME=:TRADEMARKNAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,50),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,10),
					new OracleParameter(":VOUCHERNO", OracleType.VarChar,20),
					new OracleParameter(":FEETYPE", OracleType.VarChar,40),
					new OracleParameter(":AMOUNT", OracleType.Number,22),
					new OracleParameter(":PAYMETHOD", OracleType.VarChar,40),
					new OracleParameter(":PAYDATE", OracleType.DateTime),
					new OracleParameter(":TRADEMARKNAME", OracleType.VarChar,100)			};
			parameters[0].Value = CASENO;
			parameters[1].Value = CLIENTNO;
			parameters[2].Value = VOUCHERNO;
			parameters[3].Value = FEETYPE;
			parameters[4].Value = AMOUNT;
			parameters[5].Value = PAYMETHOD;
			parameters[6].Value = PAYDATE;
			parameters[7].Value = TRADEMARKNAME;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.SBFEEDETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SBFEEDETAIL(");
			strSql.Append("CASENO,CLIENTNO,VOUCHERNO,FEETYPE,AMOUNT,PAYMETHOD,PAYDATE,TRADEMARKNAME,CHECKBY)");
			strSql.Append(" values (");
			strSql.Append(":CASENO,:CLIENTNO,:VOUCHERNO,:FEETYPE,:AMOUNT,:PAYMETHOD,:PAYDATE,:TRADEMARKNAME,:CHECKBY)");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,50),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,10),
					new OracleParameter(":VOUCHERNO", OracleType.VarChar,20),
					new OracleParameter(":FEETYPE", OracleType.VarChar,40),
					new OracleParameter(":AMOUNT", OracleType.Number,9),
					new OracleParameter(":PAYMETHOD", OracleType.VarChar,40),
					new OracleParameter(":PAYDATE", OracleType.DateTime),
					new OracleParameter(":TRADEMARKNAME", OracleType.VarChar,100),
					new OracleParameter(":CHECKBY", OracleType.VarChar,10)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.CLIENTNO;
			parameters[2].Value = model.VOUCHERNO;
			parameters[3].Value = model.FEETYPE;
			parameters[4].Value = model.AMOUNT;
			parameters[5].Value = model.PAYMETHOD;
			parameters[6].Value = model.PAYDATE;
			parameters[7].Value = model.TRADEMARKNAME;
			parameters[8].Value = model.CHECKBY;

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
		public bool Update(Model.SBFEEDETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SBFEEDETAIL set ");
			strSql.Append("CASENO=:CASENO,");
			strSql.Append("CLIENTNO=:CLIENTNO,");
			strSql.Append("VOUCHERNO=:VOUCHERNO,");
			strSql.Append("FEETYPE=:FEETYPE,");
			strSql.Append("AMOUNT=:AMOUNT,");
			strSql.Append("PAYMETHOD=:PAYMETHOD,");
			strSql.Append("PAYDATE=:PAYDATE,");
			strSql.Append("TRADEMARKNAME=:TRADEMARKNAME,");
			strSql.Append("CHECKBY=:CHECKBY");
			strSql.Append(" where CASENO=:CASENO and CLIENTNO=:CLIENTNO and VOUCHERNO=:VOUCHERNO and FEETYPE=:FEETYPE and AMOUNT=:AMOUNT and PAYMETHOD=:PAYMETHOD and PAYDATE=:PAYDATE and TRADEMARKNAME=:TRADEMARKNAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,50),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,10),
					new OracleParameter(":VOUCHERNO", OracleType.VarChar,20),
					new OracleParameter(":FEETYPE", OracleType.VarChar,40),
					new OracleParameter(":AMOUNT", OracleType.Number,9),
					new OracleParameter(":PAYMETHOD", OracleType.VarChar,40),
					new OracleParameter(":PAYDATE", OracleType.DateTime),
					new OracleParameter(":TRADEMARKNAME", OracleType.VarChar,100),
					new OracleParameter(":CHECKBY", OracleType.VarChar,10)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.CLIENTNO;
			parameters[2].Value = model.VOUCHERNO;
			parameters[3].Value = model.FEETYPE;
			parameters[4].Value = model.AMOUNT;
			parameters[5].Value = model.PAYMETHOD;
			parameters[6].Value = model.PAYDATE;
			parameters[7].Value = model.TRADEMARKNAME;
			parameters[8].Value = model.CHECKBY;

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
		public bool Delete(string CASENO,string CLIENTNO,string VOUCHERNO,string FEETYPE,decimal AMOUNT,string PAYMETHOD,DateTime PAYDATE,string TRADEMARKNAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SBFEEDETAIL ");
			strSql.Append(" where CASENO=:CASENO and CLIENTNO=:CLIENTNO and VOUCHERNO=:VOUCHERNO and FEETYPE=:FEETYPE and AMOUNT=:AMOUNT and PAYMETHOD=:PAYMETHOD and PAYDATE=:PAYDATE and TRADEMARKNAME=:TRADEMARKNAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,50),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,10),
					new OracleParameter(":VOUCHERNO", OracleType.VarChar,20),
					new OracleParameter(":FEETYPE", OracleType.VarChar,40),
					new OracleParameter(":AMOUNT", OracleType.Number,22),
					new OracleParameter(":PAYMETHOD", OracleType.VarChar,40),
					new OracleParameter(":PAYDATE", OracleType.DateTime),
					new OracleParameter(":TRADEMARKNAME", OracleType.VarChar,100)			};
			parameters[0].Value = CASENO;
			parameters[1].Value = CLIENTNO;
			parameters[2].Value = VOUCHERNO;
			parameters[3].Value = FEETYPE;
			parameters[4].Value = AMOUNT;
			parameters[5].Value = PAYMETHOD;
			parameters[6].Value = PAYDATE;
			parameters[7].Value = TRADEMARKNAME;

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
		public Model.SBFEEDETAIL GetModel(string CASENO,string CLIENTNO,string VOUCHERNO,string FEETYPE,decimal AMOUNT,string PAYMETHOD,DateTime PAYDATE,string TRADEMARKNAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CASENO,CLIENTNO,VOUCHERNO,FEETYPE,AMOUNT,PAYMETHOD,PAYDATE,TRADEMARKNAME,CHECKBY from SBFEEDETAIL ");
			strSql.Append(" where CASENO=:CASENO and CLIENTNO=:CLIENTNO and VOUCHERNO=:VOUCHERNO and FEETYPE=:FEETYPE and AMOUNT=:AMOUNT and PAYMETHOD=:PAYMETHOD and PAYDATE=:PAYDATE and TRADEMARKNAME=:TRADEMARKNAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,50),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,10),
					new OracleParameter(":VOUCHERNO", OracleType.VarChar,20),
					new OracleParameter(":FEETYPE", OracleType.VarChar,40),
					new OracleParameter(":AMOUNT", OracleType.Number,22),
					new OracleParameter(":PAYMETHOD", OracleType.VarChar,40),
					new OracleParameter(":PAYDATE", OracleType.DateTime),
					new OracleParameter(":TRADEMARKNAME", OracleType.VarChar,100)			};
			parameters[0].Value = CASENO;
			parameters[1].Value = CLIENTNO;
			parameters[2].Value = VOUCHERNO;
			parameters[3].Value = FEETYPE;
			parameters[4].Value = AMOUNT;
			parameters[5].Value = PAYMETHOD;
			parameters[6].Value = PAYDATE;
			parameters[7].Value = TRADEMARKNAME;

			Model.SBFEEDETAIL model=new Model.SBFEEDETAIL();
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
		public Model.SBFEEDETAIL DataRowToModel(DataRow row)
		{
			Model.SBFEEDETAIL model=new Model.SBFEEDETAIL();
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
				if(row["TRADEMARKNAME"]!=null)
				{
					model.TRADEMARKNAME=row["TRADEMARKNAME"].ToString();
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
			strSql.Append("select CASENO,CLIENTNO,VOUCHERNO,FEETYPE,AMOUNT,PAYMETHOD,PAYDATE,TRADEMARKNAME,CHECKBY ");
			strSql.Append(" FROM SBFEEDETAIL ");
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
			strSql.Append("select count(1) FROM SBFEEDETAIL ");
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
				strSql.Append("order by T.TRADEMARKNAME desc");
			}
			strSql.Append(")AS Row, T.*  from SBFEEDETAIL T ");
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
			parameters[0].Value = "SBFEEDETAIL";
			parameters[1].Value = "TRADEMARKNAME";
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

