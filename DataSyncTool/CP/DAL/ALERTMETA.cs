using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:ALERTMETA
	/// </summary>
	public partial class ALERTMETA
	{
		public ALERTMETA()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string TYPEID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ALERTMETA");
			strSql.Append(" where TYPEID=:TYPEID ");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPEID", OracleType.VarChar,20)			};
			parameters[0].Value = TYPEID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.ALERTMETA model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ALERTMETA(");
			strSql.Append("TYPEID,BUSINESSFIELDSIG,INPUTTYPESIG,ALERT_CLASS,ALERT_SELECT,ALERT_FROM,ALERT_WHERE,ALERT_ORDERBY,CLASSIFIER,TITLE,TH,LEGEND,COMMENTS,COUNT,LASTUPDATED)");
			strSql.Append(" values (");
			strSql.Append(":TYPEID,:BUSINESSFIELDSIG,:INPUTTYPESIG,:ALERT_CLASS,:ALERT_SELECT,:ALERT_FROM,:ALERT_WHERE,:ALERT_ORDERBY,:CLASSIFIER,:TITLE,:TH,:LEGEND,:COMMENTS,:COUNT,:LASTUPDATED)");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPEID", OracleType.VarChar,20),
					new OracleParameter(":BUSINESSFIELDSIG", OracleType.Char,1),
					new OracleParameter(":INPUTTYPESIG", OracleType.Char,1),
					new OracleParameter(":ALERT_CLASS", OracleType.VarChar,100),
					new OracleParameter(":ALERT_SELECT", OracleType.VarChar,200),
					new OracleParameter(":ALERT_FROM", OracleType.VarChar,200),
					new OracleParameter(":ALERT_WHERE", OracleType.VarChar,1000),
					new OracleParameter(":ALERT_ORDERBY", OracleType.VarChar,150),
					new OracleParameter(":CLASSIFIER", OracleType.VarChar,20),
					new OracleParameter(":TITLE", OracleType.VarChar,100),
					new OracleParameter(":TH", OracleType.VarChar,4000),
					new OracleParameter(":LEGEND", OracleType.VarChar,4000),
					new OracleParameter(":COMMENTS", OracleType.VarChar,100),
					new OracleParameter(":COUNT", OracleType.Number,4),
					new OracleParameter(":LASTUPDATED", OracleType.DateTime)};
			parameters[0].Value = model.TYPEID;
			parameters[1].Value = model.BUSINESSFIELDSIG;
			parameters[2].Value = model.INPUTTYPESIG;
			parameters[3].Value = model.ALERT_CLASS;
			parameters[4].Value = model.ALERT_SELECT;
			parameters[5].Value = model.ALERT_FROM;
			parameters[6].Value = model.ALERT_WHERE;
			parameters[7].Value = model.ALERT_ORDERBY;
			parameters[8].Value = model.CLASSIFIER;
			parameters[9].Value = model.TITLE;
			parameters[10].Value = model.TH;
			parameters[11].Value = model.LEGEND;
			parameters[12].Value = model.COMMENTS;
			parameters[13].Value = model.COUNT;
			parameters[14].Value = model.LASTUPDATED;

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
		public bool Update(Model.ALERTMETA model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ALERTMETA set ");
			strSql.Append("TYPEID=:TYPEID,");
			strSql.Append("BUSINESSFIELDSIG=:BUSINESSFIELDSIG,");
			strSql.Append("INPUTTYPESIG=:INPUTTYPESIG,");
			strSql.Append("ALERT_CLASS=:ALERT_CLASS,");
			strSql.Append("ALERT_SELECT=:ALERT_SELECT,");
			strSql.Append("ALERT_FROM=:ALERT_FROM,");
			strSql.Append("ALERT_WHERE=:ALERT_WHERE,");
			strSql.Append("ALERT_ORDERBY=:ALERT_ORDERBY,");
			strSql.Append("CLASSIFIER=:CLASSIFIER,");
			strSql.Append("TITLE=:TITLE,");
			strSql.Append("TH=:TH,");
			strSql.Append("LEGEND=:LEGEND,");
			strSql.Append("COMMENTS=:COMMENTS,");
			strSql.Append("COUNT=:COUNT,");
			strSql.Append("LASTUPDATED=:LASTUPDATED");
			strSql.Append(" where TYPEID=:TYPEID ");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPEID", OracleType.VarChar,20),
					new OracleParameter(":BUSINESSFIELDSIG", OracleType.Char,1),
					new OracleParameter(":INPUTTYPESIG", OracleType.Char,1),
					new OracleParameter(":ALERT_CLASS", OracleType.VarChar,100),
					new OracleParameter(":ALERT_SELECT", OracleType.VarChar,200),
					new OracleParameter(":ALERT_FROM", OracleType.VarChar,200),
					new OracleParameter(":ALERT_WHERE", OracleType.VarChar,1000),
					new OracleParameter(":ALERT_ORDERBY", OracleType.VarChar,150),
					new OracleParameter(":CLASSIFIER", OracleType.VarChar,20),
					new OracleParameter(":TITLE", OracleType.VarChar,100),
					new OracleParameter(":TH", OracleType.VarChar,4000),
					new OracleParameter(":LEGEND", OracleType.VarChar,4000),
					new OracleParameter(":COMMENTS", OracleType.VarChar,100),
					new OracleParameter(":COUNT", OracleType.Number,4),
					new OracleParameter(":LASTUPDATED", OracleType.DateTime)};
			parameters[0].Value = model.TYPEID;
			parameters[1].Value = model.BUSINESSFIELDSIG;
			parameters[2].Value = model.INPUTTYPESIG;
			parameters[3].Value = model.ALERT_CLASS;
			parameters[4].Value = model.ALERT_SELECT;
			parameters[5].Value = model.ALERT_FROM;
			parameters[6].Value = model.ALERT_WHERE;
			parameters[7].Value = model.ALERT_ORDERBY;
			parameters[8].Value = model.CLASSIFIER;
			parameters[9].Value = model.TITLE;
			parameters[10].Value = model.TH;
			parameters[11].Value = model.LEGEND;
			parameters[12].Value = model.COMMENTS;
			parameters[13].Value = model.COUNT;
			parameters[14].Value = model.LASTUPDATED;

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
		public bool Delete(string TYPEID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ALERTMETA ");
			strSql.Append(" where TYPEID=:TYPEID ");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPEID", OracleType.VarChar,20)			};
			parameters[0].Value = TYPEID;

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
		public bool DeleteList(string TYPEIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ALERTMETA ");
			strSql.Append(" where TYPEID in ("+TYPEIDlist + ")  ");
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
		public Model.ALERTMETA GetModel(string TYPEID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TYPEID,BUSINESSFIELDSIG,INPUTTYPESIG,ALERT_CLASS,ALERT_SELECT,ALERT_FROM,ALERT_WHERE,ALERT_ORDERBY,CLASSIFIER,TITLE,TH,LEGEND,COMMENTS,COUNT,LASTUPDATED from ALERTMETA ");
			strSql.Append(" where TYPEID=:TYPEID ");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPEID", OracleType.VarChar,20)			};
			parameters[0].Value = TYPEID;

			Model.ALERTMETA model=new Model.ALERTMETA();
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
		public Model.ALERTMETA DataRowToModel(DataRow row)
		{
			Model.ALERTMETA model=new Model.ALERTMETA();
			if (row != null)
			{
				if(row["TYPEID"]!=null)
				{
					model.TYPEID=row["TYPEID"].ToString();
				}
				if(row["BUSINESSFIELDSIG"]!=null)
				{
					model.BUSINESSFIELDSIG=row["BUSINESSFIELDSIG"].ToString();
				}
				if(row["INPUTTYPESIG"]!=null)
				{
					model.INPUTTYPESIG=row["INPUTTYPESIG"].ToString();
				}
				if(row["ALERT_CLASS"]!=null)
				{
					model.ALERT_CLASS=row["ALERT_CLASS"].ToString();
				}
				if(row["ALERT_SELECT"]!=null)
				{
					model.ALERT_SELECT=row["ALERT_SELECT"].ToString();
				}
				if(row["ALERT_FROM"]!=null)
				{
					model.ALERT_FROM=row["ALERT_FROM"].ToString();
				}
				if(row["ALERT_WHERE"]!=null)
				{
					model.ALERT_WHERE=row["ALERT_WHERE"].ToString();
				}
				if(row["ALERT_ORDERBY"]!=null)
				{
					model.ALERT_ORDERBY=row["ALERT_ORDERBY"].ToString();
				}
				if(row["CLASSIFIER"]!=null)
				{
					model.CLASSIFIER=row["CLASSIFIER"].ToString();
				}
				if(row["TITLE"]!=null)
				{
					model.TITLE=row["TITLE"].ToString();
				}
				if(row["TH"]!=null)
				{
					model.TH=row["TH"].ToString();
				}
				if(row["LEGEND"]!=null)
				{
					model.LEGEND=row["LEGEND"].ToString();
				}
				if(row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
				}
				if(row["COUNT"]!=null && row["COUNT"].ToString()!="")
				{
					model.COUNT=decimal.Parse(row["COUNT"].ToString());
				}
				if(row["LASTUPDATED"]!=null && row["LASTUPDATED"].ToString()!="")
				{
					model.LASTUPDATED=DateTime.Parse(row["LASTUPDATED"].ToString());
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
			strSql.Append("select TYPEID,BUSINESSFIELDSIG,INPUTTYPESIG,ALERT_CLASS,ALERT_SELECT,ALERT_FROM,ALERT_WHERE,ALERT_ORDERBY,CLASSIFIER,TITLE,TH,LEGEND,COMMENTS,COUNT,LASTUPDATED ");
			strSql.Append(" FROM ALERTMETA ");
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
			strSql.Append("select count(1) FROM ALERTMETA ");
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
				strSql.Append("order by T.TYPEID desc");
			}
			strSql.Append(")AS Row, T.*  from ALERTMETA T ");
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
			parameters[0].Value = "ALERTMETA";
			parameters[1].Value = "TYPEID";
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

