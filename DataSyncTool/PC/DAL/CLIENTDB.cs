using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:CLIENTDB
	/// </summary>
	public partial class CLIENTDB
	{
		public CLIENTDB()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CLIENTID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CLIENTDB");
			strSql.Append(" where CLIENTID=:CLIENTID ");
			OracleParameter[] parameters = {
					new OracleParameter(":CLIENTID", OracleType.Char,4)			};
			parameters[0].Value = CLIENTID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.CLIENTDB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CLIENTDB(");
			strSql.Append("CLIENTID,CLIENTNAME,CLIENTCNAME,PT_APPN_COPY,PT_BILL_COPY,MAILING_ADDR,MAILING_CONTACT,BILLING_CONTACT,PT_GENERAL_INSTR,BILLALIAS)");
			strSql.Append(" values (");
			strSql.Append(":CLIENTID,:CLIENTNAME,:CLIENTCNAME,:PT_APPN_COPY,:PT_BILL_COPY,:MAILING_ADDR,:MAILING_CONTACT,:BILLING_CONTACT,:PT_GENERAL_INSTR,:BILLALIAS)");
			OracleParameter[] parameters = {
					new OracleParameter(":CLIENTID", OracleType.Char,4),
					new OracleParameter(":CLIENTNAME", OracleType.VarChar,300),
					new OracleParameter(":CLIENTCNAME", OracleType.VarChar,300),
					new OracleParameter(":PT_APPN_COPY", OracleType.Number,2),
					new OracleParameter(":PT_BILL_COPY", OracleType.Number,2),
					new OracleParameter(":MAILING_ADDR", OracleType.VarChar,300),
					new OracleParameter(":MAILING_CONTACT", OracleType.VarChar,700),
					new OracleParameter(":BILLING_CONTACT", OracleType.VarChar,700),
					new OracleParameter(":PT_GENERAL_INSTR", OracleType.VarChar,1000),
					new OracleParameter(":BILLALIAS", OracleType.VarChar,10)};
			parameters[0].Value = model.CLIENTID;
			parameters[1].Value = model.CLIENTNAME;
			parameters[2].Value = model.CLIENTCNAME;
			parameters[3].Value = model.PT_APPN_COPY;
			parameters[4].Value = model.PT_BILL_COPY;
			parameters[5].Value = model.MAILING_ADDR;
			parameters[6].Value = model.MAILING_CONTACT;
			parameters[7].Value = model.BILLING_CONTACT;
			parameters[8].Value = model.PT_GENERAL_INSTR;
			parameters[9].Value = model.BILLALIAS;

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
		public bool Update(Model.CLIENTDB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CLIENTDB set ");
			strSql.Append("CLIENTID=:CLIENTID,");
			strSql.Append("CLIENTNAME=:CLIENTNAME,");
			strSql.Append("CLIENTCNAME=:CLIENTCNAME,");
			strSql.Append("PT_APPN_COPY=:PT_APPN_COPY,");
			strSql.Append("PT_BILL_COPY=:PT_BILL_COPY,");
			strSql.Append("MAILING_ADDR=:MAILING_ADDR,");
			strSql.Append("MAILING_CONTACT=:MAILING_CONTACT,");
			strSql.Append("BILLING_CONTACT=:BILLING_CONTACT,");
			strSql.Append("PT_GENERAL_INSTR=:PT_GENERAL_INSTR,");
			strSql.Append("BILLALIAS=:BILLALIAS");
			strSql.Append(" where CLIENTID=:CLIENTID ");
			OracleParameter[] parameters = {
					new OracleParameter(":CLIENTID", OracleType.Char,4),
					new OracleParameter(":CLIENTNAME", OracleType.VarChar,300),
					new OracleParameter(":CLIENTCNAME", OracleType.VarChar,300),
					new OracleParameter(":PT_APPN_COPY", OracleType.Number,2),
					new OracleParameter(":PT_BILL_COPY", OracleType.Number,2),
					new OracleParameter(":MAILING_ADDR", OracleType.VarChar,300),
					new OracleParameter(":MAILING_CONTACT", OracleType.VarChar,700),
					new OracleParameter(":BILLING_CONTACT", OracleType.VarChar,700),
					new OracleParameter(":PT_GENERAL_INSTR", OracleType.VarChar,1000),
					new OracleParameter(":BILLALIAS", OracleType.VarChar,10)};
			parameters[0].Value = model.CLIENTID;
			parameters[1].Value = model.CLIENTNAME;
			parameters[2].Value = model.CLIENTCNAME;
			parameters[3].Value = model.PT_APPN_COPY;
			parameters[4].Value = model.PT_BILL_COPY;
			parameters[5].Value = model.MAILING_ADDR;
			parameters[6].Value = model.MAILING_CONTACT;
			parameters[7].Value = model.BILLING_CONTACT;
			parameters[8].Value = model.PT_GENERAL_INSTR;
			parameters[9].Value = model.BILLALIAS;

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
		public bool Delete(string CLIENTID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CLIENTDB ");
			strSql.Append(" where CLIENTID=:CLIENTID ");
			OracleParameter[] parameters = {
					new OracleParameter(":CLIENTID", OracleType.Char,4)			};
			parameters[0].Value = CLIENTID;

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
		public bool DeleteList(string CLIENTIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CLIENTDB ");
			strSql.Append(" where CLIENTID in ("+CLIENTIDlist + ")  ");
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
		public Model.CLIENTDB GetModel(string CLIENTID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CLIENTID,CLIENTNAME,CLIENTCNAME,PT_APPN_COPY,PT_BILL_COPY,MAILING_ADDR,MAILING_CONTACT,BILLING_CONTACT,PT_GENERAL_INSTR,BILLALIAS from CLIENTDB ");
			strSql.Append(" where CLIENTID=:CLIENTID ");
			OracleParameter[] parameters = {
					new OracleParameter(":CLIENTID", OracleType.Char,4)			};
			parameters[0].Value = CLIENTID;

			Model.CLIENTDB model=new Model.CLIENTDB();
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
		public Model.CLIENTDB DataRowToModel(DataRow row)
		{
			Model.CLIENTDB model=new Model.CLIENTDB();
			if (row != null)
			{
				if(row["CLIENTID"]!=null)
				{
					model.CLIENTID=row["CLIENTID"].ToString();
				}
				if(row["CLIENTNAME"]!=null)
				{
					model.CLIENTNAME=row["CLIENTNAME"].ToString();
				}
				if(row["CLIENTCNAME"]!=null)
				{
					model.CLIENTCNAME=row["CLIENTCNAME"].ToString();
				}
				if(row["PT_APPN_COPY"]!=null && row["PT_APPN_COPY"].ToString()!="")
				{
					model.PT_APPN_COPY=decimal.Parse(row["PT_APPN_COPY"].ToString());
				}
				if(row["PT_BILL_COPY"]!=null && row["PT_BILL_COPY"].ToString()!="")
				{
					model.PT_BILL_COPY=decimal.Parse(row["PT_BILL_COPY"].ToString());
				}
				if(row["MAILING_ADDR"]!=null)
				{
					model.MAILING_ADDR=row["MAILING_ADDR"].ToString();
				}
				if(row["MAILING_CONTACT"]!=null)
				{
					model.MAILING_CONTACT=row["MAILING_CONTACT"].ToString();
				}
				if(row["BILLING_CONTACT"]!=null)
				{
					model.BILLING_CONTACT=row["BILLING_CONTACT"].ToString();
				}
				if(row["PT_GENERAL_INSTR"]!=null)
				{
					model.PT_GENERAL_INSTR=row["PT_GENERAL_INSTR"].ToString();
				}
				if(row["BILLALIAS"]!=null)
				{
					model.BILLALIAS=row["BILLALIAS"].ToString();
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
			strSql.Append("select CLIENTID,CLIENTNAME,CLIENTCNAME,PT_APPN_COPY,PT_BILL_COPY,MAILING_ADDR,MAILING_CONTACT,BILLING_CONTACT,PT_GENERAL_INSTR,BILLALIAS ");
			strSql.Append(" FROM CLIENTDB ");
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
			strSql.Append("select count(1) FROM CLIENTDB ");
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
				strSql.Append("order by T.CLIENTID desc");
			}
			strSql.Append(")AS Row, T.*  from CLIENTDB T ");
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
			parameters[0].Value = "CLIENTDB";
			parameters[1].Value = "CLIENTID";
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

