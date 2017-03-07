using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:BILLFEEMNT
	/// </summary>
	public partial class BILLFEEMNT
	{
		public BILLFEEMNT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string FEEID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BILLFEEMNT");
			strSql.Append(" where FEEID=:FEEID ");
			OracleParameter[] parameters = {
					new OracleParameter(":FEEID", OracleType.VarChar,50)			};
			parameters[0].Value = FEEID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.BILLFEEMNT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BILLFEEMNT(");
			strSql.Append("FEEID,NOTENO,CASENO,CASETYPE,CLIENTNO,AMOUNT,TYP_OR_GRP,PAYCURRENCY,PAYDATE,BILLDATE,PAYMETHOD,STATUS,CHECKBY)");
			strSql.Append(" values (");
			strSql.Append(":FEEID,:NOTENO,:CASENO,:CASETYPE,:CLIENTNO,:AMOUNT,:TYP_OR_GRP,:PAYCURRENCY,:PAYDATE,:BILLDATE,:PAYMETHOD,:STATUS,:CHECKBY)");
			OracleParameter[] parameters = {
					new OracleParameter(":FEEID", OracleType.VarChar,50),
					new OracleParameter(":NOTENO", OracleType.VarChar,20),
					new OracleParameter(":CASENO", OracleType.VarChar,30),
					new OracleParameter(":CASETYPE", OracleType.VarChar,20),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,10),
					new OracleParameter(":AMOUNT", OracleType.Number,9),
					new OracleParameter(":TYP_OR_GRP", OracleType.VarChar,50),
					new OracleParameter(":PAYCURRENCY", OracleType.VarChar,10),
					new OracleParameter(":PAYDATE", OracleType.DateTime),
					new OracleParameter(":BILLDATE", OracleType.DateTime),
					new OracleParameter(":PAYMETHOD", OracleType.VarChar,40),
					new OracleParameter(":STATUS", OracleType.VarChar,10),
					new OracleParameter(":CHECKBY", OracleType.VarChar,10)};
			parameters[0].Value = model.FEEID;
			parameters[1].Value = model.NOTENO;
			parameters[2].Value = model.CASENO;
			parameters[3].Value = model.CASETYPE;
			parameters[4].Value = model.CLIENTNO;
			parameters[5].Value = model.AMOUNT;
			parameters[6].Value = model.TYP_OR_GRP;
			parameters[7].Value = model.PAYCURRENCY;
			parameters[8].Value = model.PAYDATE;
			parameters[9].Value = model.BILLDATE;
			parameters[10].Value = model.PAYMETHOD;
			parameters[11].Value = model.STATUS;
			parameters[12].Value = model.CHECKBY;

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
		public bool Update(Model.BILLFEEMNT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BILLFEEMNT set ");
			strSql.Append("FEEID=:FEEID,");
			strSql.Append("NOTENO=:NOTENO,");
			strSql.Append("CASENO=:CASENO,");
			strSql.Append("CASETYPE=:CASETYPE,");
			strSql.Append("CLIENTNO=:CLIENTNO,");
			strSql.Append("AMOUNT=:AMOUNT,");
			strSql.Append("TYP_OR_GRP=:TYP_OR_GRP,");
			strSql.Append("PAYCURRENCY=:PAYCURRENCY,");
			strSql.Append("PAYDATE=:PAYDATE,");
			strSql.Append("BILLDATE=:BILLDATE,");
			strSql.Append("PAYMETHOD=:PAYMETHOD,");
			strSql.Append("STATUS=:STATUS,");
			strSql.Append("CHECKBY=:CHECKBY");
			strSql.Append(" where FEEID=:FEEID ");
			OracleParameter[] parameters = {
					new OracleParameter(":FEEID", OracleType.VarChar,50),
					new OracleParameter(":NOTENO", OracleType.VarChar,20),
					new OracleParameter(":CASENO", OracleType.VarChar,30),
					new OracleParameter(":CASETYPE", OracleType.VarChar,20),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,10),
					new OracleParameter(":AMOUNT", OracleType.Number,9),
					new OracleParameter(":TYP_OR_GRP", OracleType.VarChar,50),
					new OracleParameter(":PAYCURRENCY", OracleType.VarChar,10),
					new OracleParameter(":PAYDATE", OracleType.DateTime),
					new OracleParameter(":BILLDATE", OracleType.DateTime),
					new OracleParameter(":PAYMETHOD", OracleType.VarChar,40),
					new OracleParameter(":STATUS", OracleType.VarChar,10),
					new OracleParameter(":CHECKBY", OracleType.VarChar,10)};
			parameters[0].Value = model.FEEID;
			parameters[1].Value = model.NOTENO;
			parameters[2].Value = model.CASENO;
			parameters[3].Value = model.CASETYPE;
			parameters[4].Value = model.CLIENTNO;
			parameters[5].Value = model.AMOUNT;
			parameters[6].Value = model.TYP_OR_GRP;
			parameters[7].Value = model.PAYCURRENCY;
			parameters[8].Value = model.PAYDATE;
			parameters[9].Value = model.BILLDATE;
			parameters[10].Value = model.PAYMETHOD;
			parameters[11].Value = model.STATUS;
			parameters[12].Value = model.CHECKBY;

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
		public bool Delete(string FEEID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BILLFEEMNT ");
			strSql.Append(" where FEEID=:FEEID ");
			OracleParameter[] parameters = {
					new OracleParameter(":FEEID", OracleType.VarChar,50)			};
			parameters[0].Value = FEEID;

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
		public bool DeleteList(string FEEIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BILLFEEMNT ");
			strSql.Append(" where FEEID in ("+FEEIDlist + ")  ");
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
		public Model.BILLFEEMNT GetModel(string FEEID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FEEID,NOTENO,CASENO,CASETYPE,CLIENTNO,AMOUNT,TYP_OR_GRP,PAYCURRENCY,PAYDATE,BILLDATE,PAYMETHOD,STATUS,CHECKBY from BILLFEEMNT ");
			strSql.Append(" where FEEID=:FEEID ");
			OracleParameter[] parameters = {
					new OracleParameter(":FEEID", OracleType.VarChar,50)			};
			parameters[0].Value = FEEID;

			Model.BILLFEEMNT model=new Model.BILLFEEMNT();
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
		public Model.BILLFEEMNT DataRowToModel(DataRow row)
		{
			Model.BILLFEEMNT model=new Model.BILLFEEMNT();
			if (row != null)
			{
				if(row["FEEID"]!=null)
				{
					model.FEEID=row["FEEID"].ToString();
				}
				if(row["NOTENO"]!=null)
				{
					model.NOTENO=row["NOTENO"].ToString();
				}
				if(row["CASENO"]!=null)
				{
					model.CASENO=row["CASENO"].ToString();
				}
				if(row["CASETYPE"]!=null)
				{
					model.CASETYPE=row["CASETYPE"].ToString();
				}
				if(row["CLIENTNO"]!=null)
				{
					model.CLIENTNO=row["CLIENTNO"].ToString();
				}
				if(row["AMOUNT"]!=null && row["AMOUNT"].ToString()!="")
				{
					model.AMOUNT=decimal.Parse(row["AMOUNT"].ToString());
				}
				if(row["TYP_OR_GRP"]!=null)
				{
					model.TYP_OR_GRP=row["TYP_OR_GRP"].ToString();
				}
				if(row["PAYCURRENCY"]!=null)
				{
					model.PAYCURRENCY=row["PAYCURRENCY"].ToString();
				}
				if(row["PAYDATE"]!=null && row["PAYDATE"].ToString()!="")
				{
					model.PAYDATE=DateTime.Parse(row["PAYDATE"].ToString());
				}
				if(row["BILLDATE"]!=null && row["BILLDATE"].ToString()!="")
				{
					model.BILLDATE=DateTime.Parse(row["BILLDATE"].ToString());
				}
				if(row["PAYMETHOD"]!=null)
				{
					model.PAYMETHOD=row["PAYMETHOD"].ToString();
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
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
			strSql.Append("select FEEID,NOTENO,CASENO,CASETYPE,CLIENTNO,AMOUNT,TYP_OR_GRP,PAYCURRENCY,PAYDATE,BILLDATE,PAYMETHOD,STATUS,CHECKBY ");
			strSql.Append(" FROM BILLFEEMNT ");
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
			strSql.Append("select count(1) FROM BILLFEEMNT ");
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
				strSql.Append("order by T.FEEID desc");
			}
			strSql.Append(")AS Row, T.*  from BILLFEEMNT T ");
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
			parameters[0].Value = "BILLFEEMNT";
			parameters[1].Value = "FEEID";
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

