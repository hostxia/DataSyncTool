using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:DROPPING_CISCOREPORT
	/// </summary>
	public partial class DROPPING_CISCOREPORT
	{
		public DROPPING_CISCOREPORT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string OURNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DROPPING_CISCOREPORT");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30)			};
			parameters[0].Value = OURNO;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.DROPPING_CISCOREPORT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DROPPING_CISCOREPORT(");
			strSql.Append("YOURNO,OURNO,TITLE,STATUS,COUNTRY,CASE_TYPE,RELATION_TYPE,FILING_TYPE,APPLICANT,APPNO,PCT_APP_DATE,FILING_DATE,PUBLICATION_NO,PUBLICATION,GRANTNOTIC_DATE,ANNO_NO,GAZETTE,CERTIFICATE_NO,EARLIEST_PRIORITY_DATE,EXPIRATION_DATE,HISTORY)");
			strSql.Append(" values (");
			strSql.Append(":YOURNO,:OURNO,:TITLE,:STATUS,:COUNTRY,:CASE_TYPE,:RELATION_TYPE,:FILING_TYPE,:APPLICANT,:APPNO,:PCT_APP_DATE,:FILING_DATE,:PUBLICATION_NO,:PUBLICATION,:GRANTNOTIC_DATE,:ANNO_NO,:GAZETTE,:CERTIFICATE_NO,:EARLIEST_PRIORITY_DATE,:EXPIRATION_DATE,:HISTORY)");
			OracleParameter[] parameters = {
					new OracleParameter(":YOURNO", OracleType.VarChar,30),
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":TITLE", OracleType.VarChar,1000),
					new OracleParameter(":STATUS", OracleType.VarChar,40),
					new OracleParameter(":COUNTRY", OracleType.Char,4),
					new OracleParameter(":CASE_TYPE", OracleType.VarChar,40),
					new OracleParameter(":RELATION_TYPE", OracleType.VarChar,40),
					new OracleParameter(":FILING_TYPE", OracleType.VarChar,20),
					new OracleParameter(":APPLICANT", OracleType.VarChar,200),
					new OracleParameter(":APPNO", OracleType.VarChar,40),
					new OracleParameter(":PCT_APP_DATE", OracleType.DateTime),
					new OracleParameter(":FILING_DATE", OracleType.DateTime),
					new OracleParameter(":PUBLICATION_NO", OracleType.VarChar,40),
					new OracleParameter(":PUBLICATION", OracleType.DateTime),
					new OracleParameter(":GRANTNOTIC_DATE", OracleType.DateTime),
					new OracleParameter(":ANNO_NO", OracleType.VarChar,40),
					new OracleParameter(":GAZETTE", OracleType.DateTime),
					new OracleParameter(":CERTIFICATE_NO", OracleType.VarChar,40),
					new OracleParameter(":EARLIEST_PRIORITY_DATE", OracleType.DateTime),
					new OracleParameter(":EXPIRATION_DATE", OracleType.DateTime),
					new OracleParameter(":HISTORY", OracleType.VarChar,2000)};
			parameters[0].Value = model.YOURNO;
			parameters[1].Value = model.OURNO;
			parameters[2].Value = model.TITLE;
			parameters[3].Value = model.STATUS;
			parameters[4].Value = model.COUNTRY;
			parameters[5].Value = model.CASE_TYPE;
			parameters[6].Value = model.RELATION_TYPE;
			parameters[7].Value = model.FILING_TYPE;
			parameters[8].Value = model.APPLICANT;
			parameters[9].Value = model.APPNO;
			parameters[10].Value = model.PCT_APP_DATE;
			parameters[11].Value = model.FILING_DATE;
			parameters[12].Value = model.PUBLICATION_NO;
			parameters[13].Value = model.PUBLICATION;
			parameters[14].Value = model.GRANTNOTIC_DATE;
			parameters[15].Value = model.ANNO_NO;
			parameters[16].Value = model.GAZETTE;
			parameters[17].Value = model.CERTIFICATE_NO;
			parameters[18].Value = model.EARLIEST_PRIORITY_DATE;
			parameters[19].Value = model.EXPIRATION_DATE;
			parameters[20].Value = model.HISTORY;

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
		public bool Update(DataSyncTool.Model.DROPPING_CISCOREPORT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DROPPING_CISCOREPORT set ");
			strSql.Append("YOURNO=:YOURNO,");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("TITLE=:TITLE,");
			strSql.Append("STATUS=:STATUS,");
			strSql.Append("COUNTRY=:COUNTRY,");
			strSql.Append("CASE_TYPE=:CASE_TYPE,");
			strSql.Append("RELATION_TYPE=:RELATION_TYPE,");
			strSql.Append("FILING_TYPE=:FILING_TYPE,");
			strSql.Append("APPLICANT=:APPLICANT,");
			strSql.Append("APPNO=:APPNO,");
			strSql.Append("PCT_APP_DATE=:PCT_APP_DATE,");
			strSql.Append("FILING_DATE=:FILING_DATE,");
			strSql.Append("PUBLICATION_NO=:PUBLICATION_NO,");
			strSql.Append("PUBLICATION=:PUBLICATION,");
			strSql.Append("GRANTNOTIC_DATE=:GRANTNOTIC_DATE,");
			strSql.Append("ANNO_NO=:ANNO_NO,");
			strSql.Append("GAZETTE=:GAZETTE,");
			strSql.Append("CERTIFICATE_NO=:CERTIFICATE_NO,");
			strSql.Append("EARLIEST_PRIORITY_DATE=:EARLIEST_PRIORITY_DATE,");
			strSql.Append("EXPIRATION_DATE=:EXPIRATION_DATE,");
			strSql.Append("HISTORY=:HISTORY");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":YOURNO", OracleType.VarChar,30),
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":TITLE", OracleType.VarChar,1000),
					new OracleParameter(":STATUS", OracleType.VarChar,40),
					new OracleParameter(":COUNTRY", OracleType.Char,4),
					new OracleParameter(":CASE_TYPE", OracleType.VarChar,40),
					new OracleParameter(":RELATION_TYPE", OracleType.VarChar,40),
					new OracleParameter(":FILING_TYPE", OracleType.VarChar,20),
					new OracleParameter(":APPLICANT", OracleType.VarChar,200),
					new OracleParameter(":APPNO", OracleType.VarChar,40),
					new OracleParameter(":PCT_APP_DATE", OracleType.DateTime),
					new OracleParameter(":FILING_DATE", OracleType.DateTime),
					new OracleParameter(":PUBLICATION_NO", OracleType.VarChar,40),
					new OracleParameter(":PUBLICATION", OracleType.DateTime),
					new OracleParameter(":GRANTNOTIC_DATE", OracleType.DateTime),
					new OracleParameter(":ANNO_NO", OracleType.VarChar,40),
					new OracleParameter(":GAZETTE", OracleType.DateTime),
					new OracleParameter(":CERTIFICATE_NO", OracleType.VarChar,40),
					new OracleParameter(":EARLIEST_PRIORITY_DATE", OracleType.DateTime),
					new OracleParameter(":EXPIRATION_DATE", OracleType.DateTime),
					new OracleParameter(":HISTORY", OracleType.VarChar,2000)};
			parameters[0].Value = model.YOURNO;
			parameters[1].Value = model.OURNO;
			parameters[2].Value = model.TITLE;
			parameters[3].Value = model.STATUS;
			parameters[4].Value = model.COUNTRY;
			parameters[5].Value = model.CASE_TYPE;
			parameters[6].Value = model.RELATION_TYPE;
			parameters[7].Value = model.FILING_TYPE;
			parameters[8].Value = model.APPLICANT;
			parameters[9].Value = model.APPNO;
			parameters[10].Value = model.PCT_APP_DATE;
			parameters[11].Value = model.FILING_DATE;
			parameters[12].Value = model.PUBLICATION_NO;
			parameters[13].Value = model.PUBLICATION;
			parameters[14].Value = model.GRANTNOTIC_DATE;
			parameters[15].Value = model.ANNO_NO;
			parameters[16].Value = model.GAZETTE;
			parameters[17].Value = model.CERTIFICATE_NO;
			parameters[18].Value = model.EARLIEST_PRIORITY_DATE;
			parameters[19].Value = model.EXPIRATION_DATE;
			parameters[20].Value = model.HISTORY;

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
		public bool Delete(string OURNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DROPPING_CISCOREPORT ");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30)			};
			parameters[0].Value = OURNO;

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
		public bool DeleteList(string OURNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DROPPING_CISCOREPORT ");
			strSql.Append(" where OURNO in ("+OURNOlist + ")  ");
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
		public DataSyncTool.Model.DROPPING_CISCOREPORT GetModel(string OURNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select YOURNO,OURNO,TITLE,STATUS,COUNTRY,CASE_TYPE,RELATION_TYPE,FILING_TYPE,APPLICANT,APPNO,PCT_APP_DATE,FILING_DATE,PUBLICATION_NO,PUBLICATION,GRANTNOTIC_DATE,ANNO_NO,GAZETTE,CERTIFICATE_NO,EARLIEST_PRIORITY_DATE,EXPIRATION_DATE,HISTORY from DROPPING_CISCOREPORT ");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30)			};
			parameters[0].Value = OURNO;

			DataSyncTool.Model.DROPPING_CISCOREPORT model=new DataSyncTool.Model.DROPPING_CISCOREPORT();
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
		public DataSyncTool.Model.DROPPING_CISCOREPORT DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.DROPPING_CISCOREPORT model=new DataSyncTool.Model.DROPPING_CISCOREPORT();
			if (row != null)
			{
				if(row["YOURNO"]!=null)
				{
					model.YOURNO=row["YOURNO"].ToString();
				}
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["TITLE"]!=null)
				{
					model.TITLE=row["TITLE"].ToString();
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
				}
				if(row["COUNTRY"]!=null)
				{
					model.COUNTRY=row["COUNTRY"].ToString();
				}
				if(row["CASE_TYPE"]!=null)
				{
					model.CASE_TYPE=row["CASE_TYPE"].ToString();
				}
				if(row["RELATION_TYPE"]!=null)
				{
					model.RELATION_TYPE=row["RELATION_TYPE"].ToString();
				}
				if(row["FILING_TYPE"]!=null)
				{
					model.FILING_TYPE=row["FILING_TYPE"].ToString();
				}
				if(row["APPLICANT"]!=null)
				{
					model.APPLICANT=row["APPLICANT"].ToString();
				}
				if(row["APPNO"]!=null)
				{
					model.APPNO=row["APPNO"].ToString();
				}
				if(row["PCT_APP_DATE"]!=null && row["PCT_APP_DATE"].ToString()!="")
				{
					model.PCT_APP_DATE=DateTime.Parse(row["PCT_APP_DATE"].ToString());
				}
				if(row["FILING_DATE"]!=null && row["FILING_DATE"].ToString()!="")
				{
					model.FILING_DATE=DateTime.Parse(row["FILING_DATE"].ToString());
				}
				if(row["PUBLICATION_NO"]!=null)
				{
					model.PUBLICATION_NO=row["PUBLICATION_NO"].ToString();
				}
				if(row["PUBLICATION"]!=null && row["PUBLICATION"].ToString()!="")
				{
					model.PUBLICATION=DateTime.Parse(row["PUBLICATION"].ToString());
				}
				if(row["GRANTNOTIC_DATE"]!=null && row["GRANTNOTIC_DATE"].ToString()!="")
				{
					model.GRANTNOTIC_DATE=DateTime.Parse(row["GRANTNOTIC_DATE"].ToString());
				}
				if(row["ANNO_NO"]!=null)
				{
					model.ANNO_NO=row["ANNO_NO"].ToString();
				}
				if(row["GAZETTE"]!=null && row["GAZETTE"].ToString()!="")
				{
					model.GAZETTE=DateTime.Parse(row["GAZETTE"].ToString());
				}
				if(row["CERTIFICATE_NO"]!=null)
				{
					model.CERTIFICATE_NO=row["CERTIFICATE_NO"].ToString();
				}
				if(row["EARLIEST_PRIORITY_DATE"]!=null && row["EARLIEST_PRIORITY_DATE"].ToString()!="")
				{
					model.EARLIEST_PRIORITY_DATE=DateTime.Parse(row["EARLIEST_PRIORITY_DATE"].ToString());
				}
				if(row["EXPIRATION_DATE"]!=null && row["EXPIRATION_DATE"].ToString()!="")
				{
					model.EXPIRATION_DATE=DateTime.Parse(row["EXPIRATION_DATE"].ToString());
				}
				if(row["HISTORY"]!=null)
				{
					model.HISTORY=row["HISTORY"].ToString();
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
			strSql.Append("select YOURNO,OURNO,TITLE,STATUS,COUNTRY,CASE_TYPE,RELATION_TYPE,FILING_TYPE,APPLICANT,APPNO,PCT_APP_DATE,FILING_DATE,PUBLICATION_NO,PUBLICATION,GRANTNOTIC_DATE,ANNO_NO,GAZETTE,CERTIFICATE_NO,EARLIEST_PRIORITY_DATE,EXPIRATION_DATE,HISTORY ");
			strSql.Append(" FROM DROPPING_CISCOREPORT ");
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
			strSql.Append("select count(1) FROM DROPPING_CISCOREPORT ");
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
				strSql.Append("order by T.OURNO desc");
			}
			strSql.Append(")AS Row, T.*  from DROPPING_CISCOREPORT T ");
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
			parameters[0].Value = "DROPPING_CISCOREPORT";
			parameters[1].Value = "OURNO";
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

