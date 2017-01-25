using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:DROPPING_CASE
	/// </summary>
	public partial class DROPPING_CASE
	{
		public DROPPING_CASE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string APPNO,string PUBGZTNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DROPPING_CASE");
			strSql.Append(" where APPNO=:APPNO and PUBGZTNO=:PUBGZTNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":APPNO", OracleType.VarChar,30),
					new OracleParameter(":PUBGZTNO", OracleType.VarChar,30)			};
			parameters[0].Value = APPNO;
			parameters[1].Value = PUBGZTNO;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.DROPPING_CASE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DROPPING_CASE(");
			strSql.Append("TITLE,APPNO,APPDATE,PUBGZTNO,PUBGZTDATE,IPC,MIPC,SPLITAPPNO,ISSUEDATE,PRIORITY,APPLICANT,ADDR,INVENTOR,PCTAPP,PCTPUB,PCTENTRY,FIRM,AGENT,ABSTRACT,MCLAIM,ISGRANT,REMARK,YEAR,TYPE,NATIONALFILING)");
			strSql.Append(" values (");
			strSql.Append(":TITLE,:APPNO,:APPDATE,:PUBGZTNO,:PUBGZTDATE,:IPC,:MIPC,:SPLITAPPNO,:ISSUEDATE,:PRIORITY,:APPLICANT,:ADDR,:INVENTOR,:PCTAPP,:PCTPUB,:PCTENTRY,:FIRM,:AGENT,:ABSTRACT,:MCLAIM,:ISGRANT,:REMARK,:YEAR,:TYPE,:NATIONALFILING)");
			OracleParameter[] parameters = {
					new OracleParameter(":TITLE", OracleType.VarChar,4000),
					new OracleParameter(":APPNO", OracleType.VarChar,30),
					new OracleParameter(":APPDATE", OracleType.VarChar,20),
					new OracleParameter(":PUBGZTNO", OracleType.VarChar,30),
					new OracleParameter(":PUBGZTDATE", OracleType.VarChar,20),
					new OracleParameter(":IPC", OracleType.VarChar,1000),
					new OracleParameter(":MIPC", OracleType.VarChar,100),
					new OracleParameter(":SPLITAPPNO", OracleType.VarChar,30),
					new OracleParameter(":ISSUEDATE", OracleType.VarChar,20),
					new OracleParameter(":PRIORITY", OracleType.VarChar,300),
					new OracleParameter(":APPLICANT", OracleType.VarChar,500),
					new OracleParameter(":ADDR", OracleType.VarChar,500),
					new OracleParameter(":INVENTOR", OracleType.VarChar,1000),
					new OracleParameter(":PCTAPP", OracleType.VarChar,100),
					new OracleParameter(":PCTPUB", OracleType.VarChar,100),
					new OracleParameter(":PCTENTRY", OracleType.VarChar,20),
					new OracleParameter(":FIRM", OracleType.VarChar,200),
					new OracleParameter(":AGENT", OracleType.VarChar,200),
					new OracleParameter(":ABSTRACT", OracleType.VarChar,4000),
					new OracleParameter(":MCLAIM", OracleType.VarChar,4000),
					new OracleParameter(":ISGRANT", OracleType.Char,1),
					new OracleParameter(":REMARK", OracleType.VarChar,200),
					new OracleParameter(":YEAR", OracleType.Char,4),
					new OracleParameter(":TYPE", OracleType.VarChar,30),
					new OracleParameter(":NATIONALFILING", OracleType.Char,4)};
			parameters[0].Value = model.TITLE;
			parameters[1].Value = model.APPNO;
			parameters[2].Value = model.APPDATE;
			parameters[3].Value = model.PUBGZTNO;
			parameters[4].Value = model.PUBGZTDATE;
			parameters[5].Value = model.IPC;
			parameters[6].Value = model.MIPC;
			parameters[7].Value = model.SPLITAPPNO;
			parameters[8].Value = model.ISSUEDATE;
			parameters[9].Value = model.PRIORITY;
			parameters[10].Value = model.APPLICANT;
			parameters[11].Value = model.ADDR;
			parameters[12].Value = model.INVENTOR;
			parameters[13].Value = model.PCTAPP;
			parameters[14].Value = model.PCTPUB;
			parameters[15].Value = model.PCTENTRY;
			parameters[16].Value = model.FIRM;
			parameters[17].Value = model.AGENT;
			parameters[18].Value = model.ABSTRACT;
			parameters[19].Value = model.MCLAIM;
			parameters[20].Value = model.ISGRANT;
			parameters[21].Value = model.REMARK;
			parameters[22].Value = model.YEAR;
			parameters[23].Value = model.TYPE;
			parameters[24].Value = model.NATIONALFILING;

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
		public bool Update(Model.DROPPING_CASE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DROPPING_CASE set ");
			strSql.Append("TITLE=:TITLE,");
			strSql.Append("APPNO=:APPNO,");
			strSql.Append("APPDATE=:APPDATE,");
			strSql.Append("PUBGZTNO=:PUBGZTNO,");
			strSql.Append("PUBGZTDATE=:PUBGZTDATE,");
			strSql.Append("IPC=:IPC,");
			strSql.Append("MIPC=:MIPC,");
			strSql.Append("SPLITAPPNO=:SPLITAPPNO,");
			strSql.Append("ISSUEDATE=:ISSUEDATE,");
			strSql.Append("PRIORITY=:PRIORITY,");
			strSql.Append("APPLICANT=:APPLICANT,");
			strSql.Append("ADDR=:ADDR,");
			strSql.Append("INVENTOR=:INVENTOR,");
			strSql.Append("PCTAPP=:PCTAPP,");
			strSql.Append("PCTPUB=:PCTPUB,");
			strSql.Append("PCTENTRY=:PCTENTRY,");
			strSql.Append("FIRM=:FIRM,");
			strSql.Append("AGENT=:AGENT,");
			strSql.Append("ABSTRACT=:ABSTRACT,");
			strSql.Append("MCLAIM=:MCLAIM,");
			strSql.Append("ISGRANT=:ISGRANT,");
			strSql.Append("REMARK=:REMARK,");
			strSql.Append("YEAR=:YEAR,");
			strSql.Append("TYPE=:TYPE,");
			strSql.Append("NATIONALFILING=:NATIONALFILING");
			strSql.Append(" where APPNO=:APPNO and PUBGZTNO=:PUBGZTNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":TITLE", OracleType.VarChar,4000),
					new OracleParameter(":APPNO", OracleType.VarChar,30),
					new OracleParameter(":APPDATE", OracleType.VarChar,20),
					new OracleParameter(":PUBGZTNO", OracleType.VarChar,30),
					new OracleParameter(":PUBGZTDATE", OracleType.VarChar,20),
					new OracleParameter(":IPC", OracleType.VarChar,1000),
					new OracleParameter(":MIPC", OracleType.VarChar,100),
					new OracleParameter(":SPLITAPPNO", OracleType.VarChar,30),
					new OracleParameter(":ISSUEDATE", OracleType.VarChar,20),
					new OracleParameter(":PRIORITY", OracleType.VarChar,300),
					new OracleParameter(":APPLICANT", OracleType.VarChar,500),
					new OracleParameter(":ADDR", OracleType.VarChar,500),
					new OracleParameter(":INVENTOR", OracleType.VarChar,1000),
					new OracleParameter(":PCTAPP", OracleType.VarChar,100),
					new OracleParameter(":PCTPUB", OracleType.VarChar,100),
					new OracleParameter(":PCTENTRY", OracleType.VarChar,20),
					new OracleParameter(":FIRM", OracleType.VarChar,200),
					new OracleParameter(":AGENT", OracleType.VarChar,200),
					new OracleParameter(":ABSTRACT", OracleType.VarChar,4000),
					new OracleParameter(":MCLAIM", OracleType.VarChar,4000),
					new OracleParameter(":ISGRANT", OracleType.Char,1),
					new OracleParameter(":REMARK", OracleType.VarChar,200),
					new OracleParameter(":YEAR", OracleType.Char,4),
					new OracleParameter(":TYPE", OracleType.VarChar,30),
					new OracleParameter(":NATIONALFILING", OracleType.Char,4)};
			parameters[0].Value = model.TITLE;
			parameters[1].Value = model.APPNO;
			parameters[2].Value = model.APPDATE;
			parameters[3].Value = model.PUBGZTNO;
			parameters[4].Value = model.PUBGZTDATE;
			parameters[5].Value = model.IPC;
			parameters[6].Value = model.MIPC;
			parameters[7].Value = model.SPLITAPPNO;
			parameters[8].Value = model.ISSUEDATE;
			parameters[9].Value = model.PRIORITY;
			parameters[10].Value = model.APPLICANT;
			parameters[11].Value = model.ADDR;
			parameters[12].Value = model.INVENTOR;
			parameters[13].Value = model.PCTAPP;
			parameters[14].Value = model.PCTPUB;
			parameters[15].Value = model.PCTENTRY;
			parameters[16].Value = model.FIRM;
			parameters[17].Value = model.AGENT;
			parameters[18].Value = model.ABSTRACT;
			parameters[19].Value = model.MCLAIM;
			parameters[20].Value = model.ISGRANT;
			parameters[21].Value = model.REMARK;
			parameters[22].Value = model.YEAR;
			parameters[23].Value = model.TYPE;
			parameters[24].Value = model.NATIONALFILING;

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
		public bool Delete(string APPNO,string PUBGZTNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DROPPING_CASE ");
			strSql.Append(" where APPNO=:APPNO and PUBGZTNO=:PUBGZTNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":APPNO", OracleType.VarChar,30),
					new OracleParameter(":PUBGZTNO", OracleType.VarChar,30)			};
			parameters[0].Value = APPNO;
			parameters[1].Value = PUBGZTNO;

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
		public Model.DROPPING_CASE GetModel(string APPNO,string PUBGZTNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TITLE,APPNO,APPDATE,PUBGZTNO,PUBGZTDATE,IPC,MIPC,SPLITAPPNO,ISSUEDATE,PRIORITY,APPLICANT,ADDR,INVENTOR,PCTAPP,PCTPUB,PCTENTRY,FIRM,AGENT,ABSTRACT,MCLAIM,ISGRANT,REMARK,YEAR,TYPE,NATIONALFILING from DROPPING_CASE ");
			strSql.Append(" where APPNO=:APPNO and PUBGZTNO=:PUBGZTNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":APPNO", OracleType.VarChar,30),
					new OracleParameter(":PUBGZTNO", OracleType.VarChar,30)			};
			parameters[0].Value = APPNO;
			parameters[1].Value = PUBGZTNO;

			Model.DROPPING_CASE model=new Model.DROPPING_CASE();
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
		public Model.DROPPING_CASE DataRowToModel(DataRow row)
		{
			Model.DROPPING_CASE model=new Model.DROPPING_CASE();
			if (row != null)
			{
				if(row["TITLE"]!=null)
				{
					model.TITLE=row["TITLE"].ToString();
				}
				if(row["APPNO"]!=null)
				{
					model.APPNO=row["APPNO"].ToString();
				}
				if(row["APPDATE"]!=null)
				{
					model.APPDATE=row["APPDATE"].ToString();
				}
				if(row["PUBGZTNO"]!=null)
				{
					model.PUBGZTNO=row["PUBGZTNO"].ToString();
				}
				if(row["PUBGZTDATE"]!=null)
				{
					model.PUBGZTDATE=row["PUBGZTDATE"].ToString();
				}
				if(row["IPC"]!=null)
				{
					model.IPC=row["IPC"].ToString();
				}
				if(row["MIPC"]!=null)
				{
					model.MIPC=row["MIPC"].ToString();
				}
				if(row["SPLITAPPNO"]!=null)
				{
					model.SPLITAPPNO=row["SPLITAPPNO"].ToString();
				}
				if(row["ISSUEDATE"]!=null)
				{
					model.ISSUEDATE=row["ISSUEDATE"].ToString();
				}
				if(row["PRIORITY"]!=null)
				{
					model.PRIORITY=row["PRIORITY"].ToString();
				}
				if(row["APPLICANT"]!=null)
				{
					model.APPLICANT=row["APPLICANT"].ToString();
				}
				if(row["ADDR"]!=null)
				{
					model.ADDR=row["ADDR"].ToString();
				}
				if(row["INVENTOR"]!=null)
				{
					model.INVENTOR=row["INVENTOR"].ToString();
				}
				if(row["PCTAPP"]!=null)
				{
					model.PCTAPP=row["PCTAPP"].ToString();
				}
				if(row["PCTPUB"]!=null)
				{
					model.PCTPUB=row["PCTPUB"].ToString();
				}
				if(row["PCTENTRY"]!=null)
				{
					model.PCTENTRY=row["PCTENTRY"].ToString();
				}
				if(row["FIRM"]!=null)
				{
					model.FIRM=row["FIRM"].ToString();
				}
				if(row["AGENT"]!=null)
				{
					model.AGENT=row["AGENT"].ToString();
				}
				if(row["ABSTRACT"]!=null)
				{
					model.ABSTRACT=row["ABSTRACT"].ToString();
				}
				if(row["MCLAIM"]!=null)
				{
					model.MCLAIM=row["MCLAIM"].ToString();
				}
				if(row["ISGRANT"]!=null)
				{
					model.ISGRANT=row["ISGRANT"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
				if(row["YEAR"]!=null)
				{
					model.YEAR=row["YEAR"].ToString();
				}
				if(row["TYPE"]!=null)
				{
					model.TYPE=row["TYPE"].ToString();
				}
				if(row["NATIONALFILING"]!=null)
				{
					model.NATIONALFILING=row["NATIONALFILING"].ToString();
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
			strSql.Append("select TITLE,APPNO,APPDATE,PUBGZTNO,PUBGZTDATE,IPC,MIPC,SPLITAPPNO,ISSUEDATE,PRIORITY,APPLICANT,ADDR,INVENTOR,PCTAPP,PCTPUB,PCTENTRY,FIRM,AGENT,ABSTRACT,MCLAIM,ISGRANT,REMARK,YEAR,TYPE,NATIONALFILING ");
			strSql.Append(" FROM DROPPING_CASE ");
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
			strSql.Append("select count(1) FROM DROPPING_CASE ");
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
				strSql.Append("order by T.PUBGZTNO desc");
			}
			strSql.Append(")AS Row, T.*  from DROPPING_CASE T ");
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
			parameters[0].Value = "DROPPING_CASE";
			parameters[1].Value = "PUBGZTNO";
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

