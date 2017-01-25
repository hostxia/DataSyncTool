using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:DROPPING_FISH_RICHARDSON
	/// </summary>
	public partial class DROPPING_FISH_RICHARDSON
	{
		public DROPPING_FISH_RICHARDSON()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.DROPPING_FISH_RICHARDSON model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DROPPING_FISH_RICHARDSON(");
			strSql.Append("OURNO,APPNO,APPDATE,CTITLE,ISPREXAM,ISSUBSTANTIVE,ISGRANT,SUBMITDATE,STATUS,APP_REF,ETITLE,AGENT)");
			strSql.Append(" values (");
			strSql.Append(":OURNO,:APPNO,:APPDATE,:CTITLE,:ISPREXAM,:ISSUBSTANTIVE,:ISGRANT,:SUBMITDATE,:STATUS,:APP_REF,:ETITLE,:AGENT)");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":APPNO", OracleType.VarChar,20),
					new OracleParameter(":APPDATE", OracleType.DateTime),
					new OracleParameter(":CTITLE", OracleType.VarChar,100),
					new OracleParameter(":ISPREXAM", OracleType.VarChar,5),
					new OracleParameter(":ISSUBSTANTIVE", OracleType.VarChar,5),
					new OracleParameter(":ISGRANT", OracleType.VarChar,5),
					new OracleParameter(":SUBMITDATE", OracleType.DateTime),
					new OracleParameter(":STATUS", OracleType.VarChar,100),
					new OracleParameter(":APP_REF", OracleType.VarChar,40),
					new OracleParameter(":ETITLE", OracleType.VarChar,200),
					new OracleParameter(":AGENT", OracleType.VarChar,50)};
			parameters[0].Value = model.OURNO;
			parameters[1].Value = model.APPNO;
			parameters[2].Value = model.APPDATE;
			parameters[3].Value = model.CTITLE;
			parameters[4].Value = model.ISPREXAM;
			parameters[5].Value = model.ISSUBSTANTIVE;
			parameters[6].Value = model.ISGRANT;
			parameters[7].Value = model.SUBMITDATE;
			parameters[8].Value = model.STATUS;
			parameters[9].Value = model.APP_REF;
			parameters[10].Value = model.ETITLE;
			parameters[11].Value = model.AGENT;

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
		public bool Update(DataSyncTool.Model.DROPPING_FISH_RICHARDSON model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DROPPING_FISH_RICHARDSON set ");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("APPNO=:APPNO,");
			strSql.Append("APPDATE=:APPDATE,");
			strSql.Append("CTITLE=:CTITLE,");
			strSql.Append("ISPREXAM=:ISPREXAM,");
			strSql.Append("ISSUBSTANTIVE=:ISSUBSTANTIVE,");
			strSql.Append("ISGRANT=:ISGRANT,");
			strSql.Append("SUBMITDATE=:SUBMITDATE,");
			strSql.Append("STATUS=:STATUS,");
			strSql.Append("APP_REF=:APP_REF,");
			strSql.Append("ETITLE=:ETITLE,");
			strSql.Append("AGENT=:AGENT");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":APPNO", OracleType.VarChar,20),
					new OracleParameter(":APPDATE", OracleType.DateTime),
					new OracleParameter(":CTITLE", OracleType.VarChar,100),
					new OracleParameter(":ISPREXAM", OracleType.VarChar,5),
					new OracleParameter(":ISSUBSTANTIVE", OracleType.VarChar,5),
					new OracleParameter(":ISGRANT", OracleType.VarChar,5),
					new OracleParameter(":SUBMITDATE", OracleType.DateTime),
					new OracleParameter(":STATUS", OracleType.VarChar,100),
					new OracleParameter(":APP_REF", OracleType.VarChar,40),
					new OracleParameter(":ETITLE", OracleType.VarChar,200),
					new OracleParameter(":AGENT", OracleType.VarChar,50)};
			parameters[0].Value = model.OURNO;
			parameters[1].Value = model.APPNO;
			parameters[2].Value = model.APPDATE;
			parameters[3].Value = model.CTITLE;
			parameters[4].Value = model.ISPREXAM;
			parameters[5].Value = model.ISSUBSTANTIVE;
			parameters[6].Value = model.ISGRANT;
			parameters[7].Value = model.SUBMITDATE;
			parameters[8].Value = model.STATUS;
			parameters[9].Value = model.APP_REF;
			parameters[10].Value = model.ETITLE;
			parameters[11].Value = model.AGENT;

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
			strSql.Append("delete from DROPPING_FISH_RICHARDSON ");
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
		public DataSyncTool.Model.DROPPING_FISH_RICHARDSON GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OURNO,APPNO,APPDATE,CTITLE,ISPREXAM,ISSUBSTANTIVE,ISGRANT,SUBMITDATE,STATUS,APP_REF,ETITLE,AGENT from DROPPING_FISH_RICHARDSON ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			DataSyncTool.Model.DROPPING_FISH_RICHARDSON model=new DataSyncTool.Model.DROPPING_FISH_RICHARDSON();
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
		public DataSyncTool.Model.DROPPING_FISH_RICHARDSON DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.DROPPING_FISH_RICHARDSON model=new DataSyncTool.Model.DROPPING_FISH_RICHARDSON();
			if (row != null)
			{
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["APPNO"]!=null)
				{
					model.APPNO=row["APPNO"].ToString();
				}
				if(row["APPDATE"]!=null && row["APPDATE"].ToString()!="")
				{
					model.APPDATE=DateTime.Parse(row["APPDATE"].ToString());
				}
				if(row["CTITLE"]!=null)
				{
					model.CTITLE=row["CTITLE"].ToString();
				}
				if(row["ISPREXAM"]!=null)
				{
					model.ISPREXAM=row["ISPREXAM"].ToString();
				}
				if(row["ISSUBSTANTIVE"]!=null)
				{
					model.ISSUBSTANTIVE=row["ISSUBSTANTIVE"].ToString();
				}
				if(row["ISGRANT"]!=null)
				{
					model.ISGRANT=row["ISGRANT"].ToString();
				}
				if(row["SUBMITDATE"]!=null && row["SUBMITDATE"].ToString()!="")
				{
					model.SUBMITDATE=DateTime.Parse(row["SUBMITDATE"].ToString());
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
				}
				if(row["APP_REF"]!=null)
				{
					model.APP_REF=row["APP_REF"].ToString();
				}
				if(row["ETITLE"]!=null)
				{
					model.ETITLE=row["ETITLE"].ToString();
				}
				if(row["AGENT"]!=null)
				{
					model.AGENT=row["AGENT"].ToString();
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
			strSql.Append("select OURNO,APPNO,APPDATE,CTITLE,ISPREXAM,ISSUBSTANTIVE,ISGRANT,SUBMITDATE,STATUS,APP_REF,ETITLE,AGENT ");
			strSql.Append(" FROM DROPPING_FISH_RICHARDSON ");
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
			strSql.Append("select count(1) FROM DROPPING_FISH_RICHARDSON ");
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
			strSql.Append(")AS Row, T.*  from DROPPING_FISH_RICHARDSON T ");
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
			parameters[0].Value = "DROPPING_FISH_RICHARDSON";
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

