using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:FCASE
	/// </summary>
	public partial class FCASE
	{
		public FCASE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string OURNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FCASE");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30)			};
			parameters[0].Value = OURNO;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.FCASE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FCASE(");
			strSql.Append("OURNO,TITLE,CTITLE,RECEIVED,APPNO,APPDATE,COMMENTS,STATUS,APPTYPE,DEADLINE)");
			strSql.Append(" values (");
			strSql.Append(":OURNO,:TITLE,:CTITLE,:RECEIVED,:APPNO,:APPDATE,:COMMENTS,:STATUS,:APPTYPE,:DEADLINE)");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":TITLE", OracleType.VarChar,400),
					new OracleParameter(":CTITLE", OracleType.VarChar,200),
					new OracleParameter(":RECEIVED", OracleType.DateTime),
					new OracleParameter(":APPNO", OracleType.VarChar,30),
					new OracleParameter(":APPDATE", OracleType.DateTime),
					new OracleParameter(":COMMENTS", OracleType.VarChar,1500),
					new OracleParameter(":STATUS", OracleType.VarChar,10),
					new OracleParameter(":APPTYPE", OracleType.VarChar,50),
					new OracleParameter(":DEADLINE", OracleType.DateTime)};
			parameters[0].Value = model.OURNO;
			parameters[1].Value = model.TITLE;
			parameters[2].Value = model.CTITLE;
			parameters[3].Value = model.RECEIVED;
			parameters[4].Value = model.APPNO;
			parameters[5].Value = model.APPDATE;
			parameters[6].Value = model.COMMENTS;
			parameters[7].Value = model.STATUS;
			parameters[8].Value = model.APPTYPE;
			parameters[9].Value = model.DEADLINE;

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
		public bool Update(Model.FCASE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FCASE set ");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("TITLE=:TITLE,");
			strSql.Append("CTITLE=:CTITLE,");
			strSql.Append("RECEIVED=:RECEIVED,");
			strSql.Append("APPNO=:APPNO,");
			strSql.Append("APPDATE=:APPDATE,");
			strSql.Append("COMMENTS=:COMMENTS,");
			strSql.Append("STATUS=:STATUS,");
			strSql.Append("APPTYPE=:APPTYPE,");
			strSql.Append("DEADLINE=:DEADLINE");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":TITLE", OracleType.VarChar,400),
					new OracleParameter(":CTITLE", OracleType.VarChar,200),
					new OracleParameter(":RECEIVED", OracleType.DateTime),
					new OracleParameter(":APPNO", OracleType.VarChar,30),
					new OracleParameter(":APPDATE", OracleType.DateTime),
					new OracleParameter(":COMMENTS", OracleType.VarChar,1500),
					new OracleParameter(":STATUS", OracleType.VarChar,10),
					new OracleParameter(":APPTYPE", OracleType.VarChar,50),
					new OracleParameter(":DEADLINE", OracleType.DateTime)};
			parameters[0].Value = model.OURNO;
			parameters[1].Value = model.TITLE;
			parameters[2].Value = model.CTITLE;
			parameters[3].Value = model.RECEIVED;
			parameters[4].Value = model.APPNO;
			parameters[5].Value = model.APPDATE;
			parameters[6].Value = model.COMMENTS;
			parameters[7].Value = model.STATUS;
			parameters[8].Value = model.APPTYPE;
			parameters[9].Value = model.DEADLINE;

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
			strSql.Append("delete from FCASE ");
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
			strSql.Append("delete from FCASE ");
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
		public Model.FCASE GetModel(string OURNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OURNO,TITLE,CTITLE,RECEIVED,APPNO,APPDATE,COMMENTS,STATUS,APPTYPE,DEADLINE from FCASE ");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30)			};
			parameters[0].Value = OURNO;

			Model.FCASE model=new Model.FCASE();
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
		public Model.FCASE DataRowToModel(DataRow row)
		{
			Model.FCASE model=new Model.FCASE();
			if (row != null)
			{
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["TITLE"]!=null)
				{
					model.TITLE=row["TITLE"].ToString();
				}
				if(row["CTITLE"]!=null)
				{
					model.CTITLE=row["CTITLE"].ToString();
				}
				if(row["RECEIVED"]!=null && row["RECEIVED"].ToString()!="")
				{
					model.RECEIVED=DateTime.Parse(row["RECEIVED"].ToString());
				}
				if(row["APPNO"]!=null)
				{
					model.APPNO=row["APPNO"].ToString();
				}
				if(row["APPDATE"]!=null && row["APPDATE"].ToString()!="")
				{
					model.APPDATE=DateTime.Parse(row["APPDATE"].ToString());
				}
				if(row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
				}
				if(row["APPTYPE"]!=null)
				{
					model.APPTYPE=row["APPTYPE"].ToString();
				}
				if(row["DEADLINE"]!=null && row["DEADLINE"].ToString()!="")
				{
					model.DEADLINE=DateTime.Parse(row["DEADLINE"].ToString());
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
			strSql.Append("select OURNO,TITLE,CTITLE,RECEIVED,APPNO,APPDATE,COMMENTS,STATUS,APPTYPE,DEADLINE ");
			strSql.Append(" FROM FCASE ");
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
			strSql.Append("select count(1) FROM FCASE ");
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
			strSql.Append(")AS Row, T.*  from FCASE T ");
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
			parameters[0].Value = "FCASE";
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

