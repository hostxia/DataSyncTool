using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:DROPPING_TEMP_SONYUS
	/// </summary>
	public partial class DROPPING_TEMP_SONYUS
	{
		public DROPPING_TEMP_SONYUS()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.DROPPING_TEMP_SONYUS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DROPPING_TEMP_SONYUS(");
			strSql.Append("CASENO,SUBCASE,COUNTRY,CTYPE,APPSTATUS,APPNO,FILINGDATE,PUBNUMBER,PUBDATE,TITLE,OURNO,S1,S2,S3,S4,S5,S6,S7,S8,S9,S10,REPORT)");
			strSql.Append(" values (");
			strSql.Append(":CASENO,:SUBCASE,:COUNTRY,:CTYPE,:APPSTATUS,:APPNO,:FILINGDATE,:PUBNUMBER,:PUBDATE,:TITLE,:OURNO,:S1,:S2,:S3,:S4,:S5,:S6,:S7,:S8,:S9,:S10,:REPORT)");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,15),
					new OracleParameter(":SUBCASE", OracleType.VarChar,5),
					new OracleParameter(":COUNTRY", OracleType.VarChar,5),
					new OracleParameter(":CTYPE", OracleType.VarChar,10),
					new OracleParameter(":APPSTATUS", OracleType.VarChar,30),
					new OracleParameter(":APPNO", OracleType.VarChar,30),
					new OracleParameter(":FILINGDATE", OracleType.DateTime),
					new OracleParameter(":PUBNUMBER", OracleType.VarChar,30),
					new OracleParameter(":PUBDATE", OracleType.DateTime),
					new OracleParameter(":TITLE", OracleType.VarChar,200),
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":S1", OracleType.VarChar,500),
					new OracleParameter(":S2", OracleType.VarChar,500),
					new OracleParameter(":S3", OracleType.VarChar,500),
					new OracleParameter(":S4", OracleType.VarChar,500),
					new OracleParameter(":S5", OracleType.VarChar,500),
					new OracleParameter(":S6", OracleType.VarChar,500),
					new OracleParameter(":S7", OracleType.VarChar,500),
					new OracleParameter(":S8", OracleType.VarChar,500),
					new OracleParameter(":S9", OracleType.VarChar,500),
					new OracleParameter(":S10", OracleType.VarChar,500),
					new OracleParameter(":REPORT", OracleType.VarChar,4000)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.SUBCASE;
			parameters[2].Value = model.COUNTRY;
			parameters[3].Value = model.CTYPE;
			parameters[4].Value = model.APPSTATUS;
			parameters[5].Value = model.APPNO;
			parameters[6].Value = model.FILINGDATE;
			parameters[7].Value = model.PUBNUMBER;
			parameters[8].Value = model.PUBDATE;
			parameters[9].Value = model.TITLE;
			parameters[10].Value = model.OURNO;
			parameters[11].Value = model.S1;
			parameters[12].Value = model.S2;
			parameters[13].Value = model.S3;
			parameters[14].Value = model.S4;
			parameters[15].Value = model.S5;
			parameters[16].Value = model.S6;
			parameters[17].Value = model.S7;
			parameters[18].Value = model.S8;
			parameters[19].Value = model.S9;
			parameters[20].Value = model.S10;
			parameters[21].Value = model.REPORT;

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
		public bool Update(DataSyncTool.Model.DROPPING_TEMP_SONYUS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DROPPING_TEMP_SONYUS set ");
			strSql.Append("CASENO=:CASENO,");
			strSql.Append("SUBCASE=:SUBCASE,");
			strSql.Append("COUNTRY=:COUNTRY,");
			strSql.Append("CTYPE=:CTYPE,");
			strSql.Append("APPSTATUS=:APPSTATUS,");
			strSql.Append("APPNO=:APPNO,");
			strSql.Append("FILINGDATE=:FILINGDATE,");
			strSql.Append("PUBNUMBER=:PUBNUMBER,");
			strSql.Append("PUBDATE=:PUBDATE,");
			strSql.Append("TITLE=:TITLE,");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("S1=:S1,");
			strSql.Append("S2=:S2,");
			strSql.Append("S3=:S3,");
			strSql.Append("S4=:S4,");
			strSql.Append("S5=:S5,");
			strSql.Append("S6=:S6,");
			strSql.Append("S7=:S7,");
			strSql.Append("S8=:S8,");
			strSql.Append("S9=:S9,");
			strSql.Append("S10=:S10,");
			strSql.Append("REPORT=:REPORT");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,15),
					new OracleParameter(":SUBCASE", OracleType.VarChar,5),
					new OracleParameter(":COUNTRY", OracleType.VarChar,5),
					new OracleParameter(":CTYPE", OracleType.VarChar,10),
					new OracleParameter(":APPSTATUS", OracleType.VarChar,30),
					new OracleParameter(":APPNO", OracleType.VarChar,30),
					new OracleParameter(":FILINGDATE", OracleType.DateTime),
					new OracleParameter(":PUBNUMBER", OracleType.VarChar,30),
					new OracleParameter(":PUBDATE", OracleType.DateTime),
					new OracleParameter(":TITLE", OracleType.VarChar,200),
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":S1", OracleType.VarChar,500),
					new OracleParameter(":S2", OracleType.VarChar,500),
					new OracleParameter(":S3", OracleType.VarChar,500),
					new OracleParameter(":S4", OracleType.VarChar,500),
					new OracleParameter(":S5", OracleType.VarChar,500),
					new OracleParameter(":S6", OracleType.VarChar,500),
					new OracleParameter(":S7", OracleType.VarChar,500),
					new OracleParameter(":S8", OracleType.VarChar,500),
					new OracleParameter(":S9", OracleType.VarChar,500),
					new OracleParameter(":S10", OracleType.VarChar,500),
					new OracleParameter(":REPORT", OracleType.VarChar,4000)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.SUBCASE;
			parameters[2].Value = model.COUNTRY;
			parameters[3].Value = model.CTYPE;
			parameters[4].Value = model.APPSTATUS;
			parameters[5].Value = model.APPNO;
			parameters[6].Value = model.FILINGDATE;
			parameters[7].Value = model.PUBNUMBER;
			parameters[8].Value = model.PUBDATE;
			parameters[9].Value = model.TITLE;
			parameters[10].Value = model.OURNO;
			parameters[11].Value = model.S1;
			parameters[12].Value = model.S2;
			parameters[13].Value = model.S3;
			parameters[14].Value = model.S4;
			parameters[15].Value = model.S5;
			parameters[16].Value = model.S6;
			parameters[17].Value = model.S7;
			parameters[18].Value = model.S8;
			parameters[19].Value = model.S9;
			parameters[20].Value = model.S10;
			parameters[21].Value = model.REPORT;

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
			strSql.Append("delete from DROPPING_TEMP_SONYUS ");
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
		public DataSyncTool.Model.DROPPING_TEMP_SONYUS GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CASENO,SUBCASE,COUNTRY,CTYPE,APPSTATUS,APPNO,FILINGDATE,PUBNUMBER,PUBDATE,TITLE,OURNO,S1,S2,S3,S4,S5,S6,S7,S8,S9,S10,REPORT from DROPPING_TEMP_SONYUS ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			DataSyncTool.Model.DROPPING_TEMP_SONYUS model=new DataSyncTool.Model.DROPPING_TEMP_SONYUS();
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
		public DataSyncTool.Model.DROPPING_TEMP_SONYUS DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.DROPPING_TEMP_SONYUS model=new DataSyncTool.Model.DROPPING_TEMP_SONYUS();
			if (row != null)
			{
				if(row["CASENO"]!=null)
				{
					model.CASENO=row["CASENO"].ToString();
				}
				if(row["SUBCASE"]!=null)
				{
					model.SUBCASE=row["SUBCASE"].ToString();
				}
				if(row["COUNTRY"]!=null)
				{
					model.COUNTRY=row["COUNTRY"].ToString();
				}
				if(row["CTYPE"]!=null)
				{
					model.CTYPE=row["CTYPE"].ToString();
				}
				if(row["APPSTATUS"]!=null)
				{
					model.APPSTATUS=row["APPSTATUS"].ToString();
				}
				if(row["APPNO"]!=null)
				{
					model.APPNO=row["APPNO"].ToString();
				}
				if(row["FILINGDATE"]!=null && row["FILINGDATE"].ToString()!="")
				{
					model.FILINGDATE=DateTime.Parse(row["FILINGDATE"].ToString());
				}
				if(row["PUBNUMBER"]!=null)
				{
					model.PUBNUMBER=row["PUBNUMBER"].ToString();
				}
				if(row["PUBDATE"]!=null && row["PUBDATE"].ToString()!="")
				{
					model.PUBDATE=DateTime.Parse(row["PUBDATE"].ToString());
				}
				if(row["TITLE"]!=null)
				{
					model.TITLE=row["TITLE"].ToString();
				}
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["S1"]!=null)
				{
					model.S1=row["S1"].ToString();
				}
				if(row["S2"]!=null)
				{
					model.S2=row["S2"].ToString();
				}
				if(row["S3"]!=null)
				{
					model.S3=row["S3"].ToString();
				}
				if(row["S4"]!=null)
				{
					model.S4=row["S4"].ToString();
				}
				if(row["S5"]!=null)
				{
					model.S5=row["S5"].ToString();
				}
				if(row["S6"]!=null)
				{
					model.S6=row["S6"].ToString();
				}
				if(row["S7"]!=null)
				{
					model.S7=row["S7"].ToString();
				}
				if(row["S8"]!=null)
				{
					model.S8=row["S8"].ToString();
				}
				if(row["S9"]!=null)
				{
					model.S9=row["S9"].ToString();
				}
				if(row["S10"]!=null)
				{
					model.S10=row["S10"].ToString();
				}
				if(row["REPORT"]!=null)
				{
					model.REPORT=row["REPORT"].ToString();
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
			strSql.Append("select CASENO,SUBCASE,COUNTRY,CTYPE,APPSTATUS,APPNO,FILINGDATE,PUBNUMBER,PUBDATE,TITLE,OURNO,S1,S2,S3,S4,S5,S6,S7,S8,S9,S10,REPORT ");
			strSql.Append(" FROM DROPPING_TEMP_SONYUS ");
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
			strSql.Append("select count(1) FROM DROPPING_TEMP_SONYUS ");
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
			strSql.Append(")AS Row, T.*  from DROPPING_TEMP_SONYUS T ");
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
			parameters[0].Value = "DROPPING_TEMP_SONYUS";
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

