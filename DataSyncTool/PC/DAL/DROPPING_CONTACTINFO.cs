using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:DROPPING_CONTACTINFO
	/// </summary>
	public partial class DROPPING_CONTACTINFO
	{
		public DROPPING_CONTACTINFO()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.DROPPING_CONTACTINFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DROPPING_CONTACTINFO(");
			strSql.Append("ID,NAME,NAME_CN,BILL_ALIAS,CATEGORY,ATTENTION,DEPT,JOBTITLE,NATIONALITY_CODE,COUNTRY_CODE,CITY,CITY_CN,ADDRESS,ADDRESS_CN,POSTALCODE,TELEPHONE,EMAIL,FAX,COMMENTS,INHERIT_ADDR)");
			strSql.Append(" values (");
			strSql.Append(":ID,:NAME,:NAME_CN,:BILL_ALIAS,:CATEGORY,:ATTENTION,:DEPT,:JOBTITLE,:NATIONALITY_CODE,:COUNTRY_CODE,:CITY,:CITY_CN,:ADDRESS,:ADDRESS_CN,:POSTALCODE,:TELEPHONE,:EMAIL,:FAX,:COMMENTS,:INHERIT_ADDR)");
			OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleType.VarChar,30),
					new OracleParameter(":NAME", OracleType.VarChar,20),
					new OracleParameter(":NAME_CN", OracleType.VarChar,20),
					new OracleParameter(":BILL_ALIAS", OracleType.VarChar,10),
					new OracleParameter(":CATEGORY", OracleType.Char,1),
					new OracleParameter(":ATTENTION", OracleType.VarChar,5),
					new OracleParameter(":DEPT", OracleType.VarChar,20),
					new OracleParameter(":JOBTITLE", OracleType.VarChar,20),
					new OracleParameter(":NATIONALITY_CODE", OracleType.Char,2),
					new OracleParameter(":COUNTRY_CODE", OracleType.Char,2),
					new OracleParameter(":CITY", OracleType.VarChar,20),
					new OracleParameter(":CITY_CN", OracleType.VarChar,20),
					new OracleParameter(":ADDRESS", OracleType.VarChar,100),
					new OracleParameter(":ADDRESS_CN", OracleType.VarChar,100),
					new OracleParameter(":POSTALCODE", OracleType.VarChar,10),
					new OracleParameter(":TELEPHONE", OracleType.VarChar,50),
					new OracleParameter(":EMAIL", OracleType.VarChar,30),
					new OracleParameter(":FAX", OracleType.VarChar,20),
					new OracleParameter(":COMMENTS", OracleType.VarChar,200),
					new OracleParameter(":INHERIT_ADDR", OracleType.Char,1)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.NAME;
			parameters[2].Value = model.NAME_CN;
			parameters[3].Value = model.BILL_ALIAS;
			parameters[4].Value = model.CATEGORY;
			parameters[5].Value = model.ATTENTION;
			parameters[6].Value = model.DEPT;
			parameters[7].Value = model.JOBTITLE;
			parameters[8].Value = model.NATIONALITY_CODE;
			parameters[9].Value = model.COUNTRY_CODE;
			parameters[10].Value = model.CITY;
			parameters[11].Value = model.CITY_CN;
			parameters[12].Value = model.ADDRESS;
			parameters[13].Value = model.ADDRESS_CN;
			parameters[14].Value = model.POSTALCODE;
			parameters[15].Value = model.TELEPHONE;
			parameters[16].Value = model.EMAIL;
			parameters[17].Value = model.FAX;
			parameters[18].Value = model.COMMENTS;
			parameters[19].Value = model.INHERIT_ADDR;

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
		public bool Update(Model.DROPPING_CONTACTINFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DROPPING_CONTACTINFO set ");
			strSql.Append("ID=:ID,");
			strSql.Append("NAME=:NAME,");
			strSql.Append("NAME_CN=:NAME_CN,");
			strSql.Append("BILL_ALIAS=:BILL_ALIAS,");
			strSql.Append("CATEGORY=:CATEGORY,");
			strSql.Append("ATTENTION=:ATTENTION,");
			strSql.Append("DEPT=:DEPT,");
			strSql.Append("JOBTITLE=:JOBTITLE,");
			strSql.Append("NATIONALITY_CODE=:NATIONALITY_CODE,");
			strSql.Append("COUNTRY_CODE=:COUNTRY_CODE,");
			strSql.Append("CITY=:CITY,");
			strSql.Append("CITY_CN=:CITY_CN,");
			strSql.Append("ADDRESS=:ADDRESS,");
			strSql.Append("ADDRESS_CN=:ADDRESS_CN,");
			strSql.Append("POSTALCODE=:POSTALCODE,");
			strSql.Append("TELEPHONE=:TELEPHONE,");
			strSql.Append("EMAIL=:EMAIL,");
			strSql.Append("FAX=:FAX,");
			strSql.Append("COMMENTS=:COMMENTS,");
			strSql.Append("INHERIT_ADDR=:INHERIT_ADDR");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleType.VarChar,30),
					new OracleParameter(":NAME", OracleType.VarChar,20),
					new OracleParameter(":NAME_CN", OracleType.VarChar,20),
					new OracleParameter(":BILL_ALIAS", OracleType.VarChar,10),
					new OracleParameter(":CATEGORY", OracleType.Char,1),
					new OracleParameter(":ATTENTION", OracleType.VarChar,5),
					new OracleParameter(":DEPT", OracleType.VarChar,20),
					new OracleParameter(":JOBTITLE", OracleType.VarChar,20),
					new OracleParameter(":NATIONALITY_CODE", OracleType.Char,2),
					new OracleParameter(":COUNTRY_CODE", OracleType.Char,2),
					new OracleParameter(":CITY", OracleType.VarChar,20),
					new OracleParameter(":CITY_CN", OracleType.VarChar,20),
					new OracleParameter(":ADDRESS", OracleType.VarChar,100),
					new OracleParameter(":ADDRESS_CN", OracleType.VarChar,100),
					new OracleParameter(":POSTALCODE", OracleType.VarChar,10),
					new OracleParameter(":TELEPHONE", OracleType.VarChar,50),
					new OracleParameter(":EMAIL", OracleType.VarChar,30),
					new OracleParameter(":FAX", OracleType.VarChar,20),
					new OracleParameter(":COMMENTS", OracleType.VarChar,200),
					new OracleParameter(":INHERIT_ADDR", OracleType.Char,1)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.NAME;
			parameters[2].Value = model.NAME_CN;
			parameters[3].Value = model.BILL_ALIAS;
			parameters[4].Value = model.CATEGORY;
			parameters[5].Value = model.ATTENTION;
			parameters[6].Value = model.DEPT;
			parameters[7].Value = model.JOBTITLE;
			parameters[8].Value = model.NATIONALITY_CODE;
			parameters[9].Value = model.COUNTRY_CODE;
			parameters[10].Value = model.CITY;
			parameters[11].Value = model.CITY_CN;
			parameters[12].Value = model.ADDRESS;
			parameters[13].Value = model.ADDRESS_CN;
			parameters[14].Value = model.POSTALCODE;
			parameters[15].Value = model.TELEPHONE;
			parameters[16].Value = model.EMAIL;
			parameters[17].Value = model.FAX;
			parameters[18].Value = model.COMMENTS;
			parameters[19].Value = model.INHERIT_ADDR;

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
			strSql.Append("delete from DROPPING_CONTACTINFO ");
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
		public Model.DROPPING_CONTACTINFO GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,NAME,NAME_CN,BILL_ALIAS,CATEGORY,ATTENTION,DEPT,JOBTITLE,NATIONALITY_CODE,COUNTRY_CODE,CITY,CITY_CN,ADDRESS,ADDRESS_CN,POSTALCODE,TELEPHONE,EMAIL,FAX,COMMENTS,INHERIT_ADDR from DROPPING_CONTACTINFO ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Model.DROPPING_CONTACTINFO model=new Model.DROPPING_CONTACTINFO();
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
		public Model.DROPPING_CONTACTINFO DataRowToModel(DataRow row)
		{
			Model.DROPPING_CONTACTINFO model=new Model.DROPPING_CONTACTINFO();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["NAME"]!=null)
				{
					model.NAME=row["NAME"].ToString();
				}
				if(row["NAME_CN"]!=null)
				{
					model.NAME_CN=row["NAME_CN"].ToString();
				}
				if(row["BILL_ALIAS"]!=null)
				{
					model.BILL_ALIAS=row["BILL_ALIAS"].ToString();
				}
				if(row["CATEGORY"]!=null)
				{
					model.CATEGORY=row["CATEGORY"].ToString();
				}
				if(row["ATTENTION"]!=null)
				{
					model.ATTENTION=row["ATTENTION"].ToString();
				}
				if(row["DEPT"]!=null)
				{
					model.DEPT=row["DEPT"].ToString();
				}
				if(row["JOBTITLE"]!=null)
				{
					model.JOBTITLE=row["JOBTITLE"].ToString();
				}
				if(row["NATIONALITY_CODE"]!=null)
				{
					model.NATIONALITY_CODE=row["NATIONALITY_CODE"].ToString();
				}
				if(row["COUNTRY_CODE"]!=null)
				{
					model.COUNTRY_CODE=row["COUNTRY_CODE"].ToString();
				}
				if(row["CITY"]!=null)
				{
					model.CITY=row["CITY"].ToString();
				}
				if(row["CITY_CN"]!=null)
				{
					model.CITY_CN=row["CITY_CN"].ToString();
				}
				if(row["ADDRESS"]!=null)
				{
					model.ADDRESS=row["ADDRESS"].ToString();
				}
				if(row["ADDRESS_CN"]!=null)
				{
					model.ADDRESS_CN=row["ADDRESS_CN"].ToString();
				}
				if(row["POSTALCODE"]!=null)
				{
					model.POSTALCODE=row["POSTALCODE"].ToString();
				}
				if(row["TELEPHONE"]!=null)
				{
					model.TELEPHONE=row["TELEPHONE"].ToString();
				}
				if(row["EMAIL"]!=null)
				{
					model.EMAIL=row["EMAIL"].ToString();
				}
				if(row["FAX"]!=null)
				{
					model.FAX=row["FAX"].ToString();
				}
				if(row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
				}
				if(row["INHERIT_ADDR"]!=null)
				{
					model.INHERIT_ADDR=row["INHERIT_ADDR"].ToString();
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
			strSql.Append("select ID,NAME,NAME_CN,BILL_ALIAS,CATEGORY,ATTENTION,DEPT,JOBTITLE,NATIONALITY_CODE,COUNTRY_CODE,CITY,CITY_CN,ADDRESS,ADDRESS_CN,POSTALCODE,TELEPHONE,EMAIL,FAX,COMMENTS,INHERIT_ADDR ");
			strSql.Append(" FROM DROPPING_CONTACTINFO ");
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
			strSql.Append("select count(1) FROM DROPPING_CONTACTINFO ");
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
			strSql.Append(")AS Row, T.*  from DROPPING_CONTACTINFO T ");
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
			parameters[0].Value = "DROPPING_CONTACTINFO";
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

