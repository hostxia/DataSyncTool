using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:COUNTRY_TRANSLATION
	/// </summary>
	public partial class COUNTRY_TRANSLATION
	{
		public COUNTRY_TRANSLATION()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string NAME)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from COUNTRY_TRANSLATION");
			strSql.Append(" where NAME=:NAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":NAME", OracleType.VarChar,30)			};
			parameters[0].Value = NAME;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.COUNTRY_TRANSLATION model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into COUNTRY_TRANSLATION(");
			strSql.Append("NAME,CNAME)");
			strSql.Append(" values (");
			strSql.Append(":NAME,:CNAME)");
			OracleParameter[] parameters = {
					new OracleParameter(":NAME", OracleType.VarChar,30),
					new OracleParameter(":CNAME", OracleType.VarChar,30)};
			parameters[0].Value = model.NAME;
			parameters[1].Value = model.CNAME;

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
		public bool Update(Model.COUNTRY_TRANSLATION model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update COUNTRY_TRANSLATION set ");
			strSql.Append("NAME=:NAME,");
			strSql.Append("CNAME=:CNAME");
			strSql.Append(" where NAME=:NAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":NAME", OracleType.VarChar,30),
					new OracleParameter(":CNAME", OracleType.VarChar,30)};
			parameters[0].Value = model.NAME;
			parameters[1].Value = model.CNAME;

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
		public bool Delete(string NAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from COUNTRY_TRANSLATION ");
			strSql.Append(" where NAME=:NAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":NAME", OracleType.VarChar,30)			};
			parameters[0].Value = NAME;

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
		public bool DeleteList(string NAMElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from COUNTRY_TRANSLATION ");
			strSql.Append(" where NAME in ("+NAMElist + ")  ");
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
		public Model.COUNTRY_TRANSLATION GetModel(string NAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select NAME,CNAME from COUNTRY_TRANSLATION ");
			strSql.Append(" where NAME=:NAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":NAME", OracleType.VarChar,30)			};
			parameters[0].Value = NAME;

			Model.COUNTRY_TRANSLATION model=new Model.COUNTRY_TRANSLATION();
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
		public Model.COUNTRY_TRANSLATION DataRowToModel(DataRow row)
		{
			Model.COUNTRY_TRANSLATION model=new Model.COUNTRY_TRANSLATION();
			if (row != null)
			{
				if(row["NAME"]!=null)
				{
					model.NAME=row["NAME"].ToString();
				}
				if(row["CNAME"]!=null)
				{
					model.CNAME=row["CNAME"].ToString();
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
			strSql.Append("select NAME,CNAME ");
			strSql.Append(" FROM COUNTRY_TRANSLATION ");
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
			strSql.Append("select count(1) FROM COUNTRY_TRANSLATION ");
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
				strSql.Append("order by T.NAME desc");
			}
			strSql.Append(")AS Row, T.*  from COUNTRY_TRANSLATION T ");
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
			parameters[0].Value = "COUNTRY_TRANSLATION";
			parameters[1].Value = "NAME";
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

