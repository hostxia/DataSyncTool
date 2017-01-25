using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:BILL
	/// </summary>
	public partial class BILL
	{
		public BILL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string NOTENUMBER)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BILL");
			strSql.Append(" where NOTENUMBER=:NOTENUMBER ");
			OracleParameter[] parameters = {
					new OracleParameter(":NOTENUMBER", OracleType.VarChar,23)			};
			parameters[0].Value = NOTENUMBER;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.BILL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BILL(");
			strSql.Append("CASENO,NOTENUMBER,ISSUENUMBER,TYPE,ISSUED,PAID,STATUS,COMMENTS,ADDRESS,CLIENT,OWNER,CURRENCYID,ACCOUNTID,BILLING_START_DATE,BILLING_END_DATE,FIRMID,CLIENT_MATTERID,SIGS,DESCLINE)");
			strSql.Append(" values (");
			strSql.Append(":CASENO,:NOTENUMBER,:ISSUENUMBER,:TYPE,:ISSUED,:PAID,:STATUS,:COMMENTS,:ADDRESS,:CLIENT,:OWNER,:CURRENCYID,:ACCOUNTID,:BILLING_START_DATE,:BILLING_END_DATE,:FIRMID,:CLIENT_MATTERID,:SIGS,:DESCLINE)");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,24),
					new OracleParameter(":NOTENUMBER", OracleType.VarChar,23),
					new OracleParameter(":ISSUENUMBER", OracleType.VarChar,20),
					new OracleParameter(":TYPE", OracleType.Char,1),
					new OracleParameter(":ISSUED", OracleType.DateTime),
					new OracleParameter(":PAID", OracleType.DateTime),
					new OracleParameter(":STATUS", OracleType.Char,1),
					new OracleParameter(":COMMENTS", OracleType.VarChar,300),
					new OracleParameter(":ADDRESS", OracleType.VarChar,300),
					new OracleParameter(":CLIENT", OracleType.Char,4),
					new OracleParameter(":OWNER", OracleType.VarChar,15),
					new OracleParameter(":CURRENCYID", OracleType.Char,3),
					new OracleParameter(":ACCOUNTID", OracleType.VarChar,20),
					new OracleParameter(":BILLING_START_DATE", OracleType.DateTime),
					new OracleParameter(":BILLING_END_DATE", OracleType.DateTime),
					new OracleParameter(":FIRMID", OracleType.VarChar,20),
					new OracleParameter(":CLIENT_MATTERID", OracleType.VarChar,40),
					new OracleParameter(":SIGS", OracleType.VarChar,15),
					new OracleParameter(":DESCLINE", OracleType.VarChar,200)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.NOTENUMBER;
			parameters[2].Value = model.ISSUENUMBER;
			parameters[3].Value = model.TYPE;
			parameters[4].Value = model.ISSUED;
			parameters[5].Value = model.PAID;
			parameters[6].Value = model.STATUS;
			parameters[7].Value = model.COMMENTS;
			parameters[8].Value = model.ADDRESS;
			parameters[9].Value = model.CLIENT;
			parameters[10].Value = model.OWNER;
			parameters[11].Value = model.CURRENCYID;
			parameters[12].Value = model.ACCOUNTID;
			parameters[13].Value = model.BILLING_START_DATE;
			parameters[14].Value = model.BILLING_END_DATE;
			parameters[15].Value = model.FIRMID;
			parameters[16].Value = model.CLIENT_MATTERID;
			parameters[17].Value = model.SIGS;
			parameters[18].Value = model.DESCLINE;

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
		public bool Update(DataSyncTool.Model.BILL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BILL set ");
			strSql.Append("CASENO=:CASENO,");
			strSql.Append("NOTENUMBER=:NOTENUMBER,");
			strSql.Append("ISSUENUMBER=:ISSUENUMBER,");
			strSql.Append("TYPE=:TYPE,");
			strSql.Append("ISSUED=:ISSUED,");
			strSql.Append("PAID=:PAID,");
			strSql.Append("STATUS=:STATUS,");
			strSql.Append("COMMENTS=:COMMENTS,");
			strSql.Append("ADDRESS=:ADDRESS,");
			strSql.Append("CLIENT=:CLIENT,");
			strSql.Append("OWNER=:OWNER,");
			strSql.Append("CURRENCYID=:CURRENCYID,");
			strSql.Append("ACCOUNTID=:ACCOUNTID,");
			strSql.Append("BILLING_START_DATE=:BILLING_START_DATE,");
			strSql.Append("BILLING_END_DATE=:BILLING_END_DATE,");
			strSql.Append("FIRMID=:FIRMID,");
			strSql.Append("CLIENT_MATTERID=:CLIENT_MATTERID,");
			strSql.Append("SIGS=:SIGS,");
			strSql.Append("DESCLINE=:DESCLINE");
			strSql.Append(" where NOTENUMBER=:NOTENUMBER ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,24),
					new OracleParameter(":NOTENUMBER", OracleType.VarChar,23),
					new OracleParameter(":ISSUENUMBER", OracleType.VarChar,20),
					new OracleParameter(":TYPE", OracleType.Char,1),
					new OracleParameter(":ISSUED", OracleType.DateTime),
					new OracleParameter(":PAID", OracleType.DateTime),
					new OracleParameter(":STATUS", OracleType.Char,1),
					new OracleParameter(":COMMENTS", OracleType.VarChar,300),
					new OracleParameter(":ADDRESS", OracleType.VarChar,300),
					new OracleParameter(":CLIENT", OracleType.Char,4),
					new OracleParameter(":OWNER", OracleType.VarChar,15),
					new OracleParameter(":CURRENCYID", OracleType.Char,3),
					new OracleParameter(":ACCOUNTID", OracleType.VarChar,20),
					new OracleParameter(":BILLING_START_DATE", OracleType.DateTime),
					new OracleParameter(":BILLING_END_DATE", OracleType.DateTime),
					new OracleParameter(":FIRMID", OracleType.VarChar,20),
					new OracleParameter(":CLIENT_MATTERID", OracleType.VarChar,40),
					new OracleParameter(":SIGS", OracleType.VarChar,15),
					new OracleParameter(":DESCLINE", OracleType.VarChar,200)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.NOTENUMBER;
			parameters[2].Value = model.ISSUENUMBER;
			parameters[3].Value = model.TYPE;
			parameters[4].Value = model.ISSUED;
			parameters[5].Value = model.PAID;
			parameters[6].Value = model.STATUS;
			parameters[7].Value = model.COMMENTS;
			parameters[8].Value = model.ADDRESS;
			parameters[9].Value = model.CLIENT;
			parameters[10].Value = model.OWNER;
			parameters[11].Value = model.CURRENCYID;
			parameters[12].Value = model.ACCOUNTID;
			parameters[13].Value = model.BILLING_START_DATE;
			parameters[14].Value = model.BILLING_END_DATE;
			parameters[15].Value = model.FIRMID;
			parameters[16].Value = model.CLIENT_MATTERID;
			parameters[17].Value = model.SIGS;
			parameters[18].Value = model.DESCLINE;

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
		public bool Delete(string NOTENUMBER)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BILL ");
			strSql.Append(" where NOTENUMBER=:NOTENUMBER ");
			OracleParameter[] parameters = {
					new OracleParameter(":NOTENUMBER", OracleType.VarChar,23)			};
			parameters[0].Value = NOTENUMBER;

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
		public bool DeleteList(string NOTENUMBERlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BILL ");
			strSql.Append(" where NOTENUMBER in ("+NOTENUMBERlist + ")  ");
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
		public DataSyncTool.Model.BILL GetModel(string NOTENUMBER)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CASENO,NOTENUMBER,ISSUENUMBER,TYPE,ISSUED,PAID,STATUS,COMMENTS,ADDRESS,CLIENT,OWNER,CURRENCYID,ACCOUNTID,BILLING_START_DATE,BILLING_END_DATE,FIRMID,CLIENT_MATTERID,SIGS,DESCLINE from BILL ");
			strSql.Append(" where NOTENUMBER=:NOTENUMBER ");
			OracleParameter[] parameters = {
					new OracleParameter(":NOTENUMBER", OracleType.VarChar,23)			};
			parameters[0].Value = NOTENUMBER;

			DataSyncTool.Model.BILL model=new DataSyncTool.Model.BILL();
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
		public DataSyncTool.Model.BILL DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.BILL model=new DataSyncTool.Model.BILL();
			if (row != null)
			{
				if(row["CASENO"]!=null)
				{
					model.CASENO=row["CASENO"].ToString();
				}
				if(row["NOTENUMBER"]!=null)
				{
					model.NOTENUMBER=row["NOTENUMBER"].ToString();
				}
				if(row["ISSUENUMBER"]!=null)
				{
					model.ISSUENUMBER=row["ISSUENUMBER"].ToString();
				}
				if(row["TYPE"]!=null)
				{
					model.TYPE=row["TYPE"].ToString();
				}
				if(row["ISSUED"]!=null && row["ISSUED"].ToString()!="")
				{
					model.ISSUED=DateTime.Parse(row["ISSUED"].ToString());
				}
				if(row["PAID"]!=null && row["PAID"].ToString()!="")
				{
					model.PAID=DateTime.Parse(row["PAID"].ToString());
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
				}
				if(row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
				}
				if(row["ADDRESS"]!=null)
				{
					model.ADDRESS=row["ADDRESS"].ToString();
				}
				if(row["CLIENT"]!=null)
				{
					model.CLIENT=row["CLIENT"].ToString();
				}
				if(row["OWNER"]!=null)
				{
					model.OWNER=row["OWNER"].ToString();
				}
				if(row["CURRENCYID"]!=null)
				{
					model.CURRENCYID=row["CURRENCYID"].ToString();
				}
				if(row["ACCOUNTID"]!=null)
				{
					model.ACCOUNTID=row["ACCOUNTID"].ToString();
				}
				if(row["BILLING_START_DATE"]!=null && row["BILLING_START_DATE"].ToString()!="")
				{
					model.BILLING_START_DATE=DateTime.Parse(row["BILLING_START_DATE"].ToString());
				}
				if(row["BILLING_END_DATE"]!=null && row["BILLING_END_DATE"].ToString()!="")
				{
					model.BILLING_END_DATE=DateTime.Parse(row["BILLING_END_DATE"].ToString());
				}
				if(row["FIRMID"]!=null)
				{
					model.FIRMID=row["FIRMID"].ToString();
				}
				if(row["CLIENT_MATTERID"]!=null)
				{
					model.CLIENT_MATTERID=row["CLIENT_MATTERID"].ToString();
				}
				if(row["SIGS"]!=null)
				{
					model.SIGS=row["SIGS"].ToString();
				}
				if(row["DESCLINE"]!=null)
				{
					model.DESCLINE=row["DESCLINE"].ToString();
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
			strSql.Append("select CASENO,NOTENUMBER,ISSUENUMBER,TYPE,ISSUED,PAID,STATUS,COMMENTS,ADDRESS,CLIENT,OWNER,CURRENCYID,ACCOUNTID,BILLING_START_DATE,BILLING_END_DATE,FIRMID,CLIENT_MATTERID,SIGS,DESCLINE ");
			strSql.Append(" FROM BILL ");
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
			strSql.Append("select count(1) FROM BILL ");
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
				strSql.Append("order by T.NOTENUMBER desc");
			}
			strSql.Append(")AS Row, T.*  from BILL T ");
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
			parameters[0].Value = "BILL";
			parameters[1].Value = "NOTENUMBER";
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

