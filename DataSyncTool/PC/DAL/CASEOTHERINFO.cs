using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:CASEOTHERINFO
	/// </summary>
	public partial class CASEOTHERINFO
	{
		public CASEOTHERINFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CASENO,string INFOTYPE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CASEOTHERINFO");
			strSql.Append(" where CASENO=:CASENO and INFOTYPE=:INFOTYPE ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,20),
					new OracleParameter(":INFOTYPE", OracleType.VarChar,10)			};
			parameters[0].Value = CASENO;
			parameters[1].Value = INFOTYPE;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.CASEOTHERINFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CASEOTHERINFO(");
			strSql.Append("CASENO,INFOTYPE,INFO)");
			strSql.Append(" values (");
			strSql.Append(":CASENO,:INFOTYPE,:INFO)");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,20),
					new OracleParameter(":INFOTYPE", OracleType.VarChar,10),
					new OracleParameter(":INFO", OracleType.VarChar,400)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.INFOTYPE;
			parameters[2].Value = model.INFO;

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
		public bool Update(Model.CASEOTHERINFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CASEOTHERINFO set ");
			strSql.Append("CASENO=:CASENO,");
			strSql.Append("INFOTYPE=:INFOTYPE,");
			strSql.Append("INFO=:INFO");
			strSql.Append(" where CASENO=:CASENO and INFOTYPE=:INFOTYPE ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,20),
					new OracleParameter(":INFOTYPE", OracleType.VarChar,10),
					new OracleParameter(":INFO", OracleType.VarChar,400)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.INFOTYPE;
			parameters[2].Value = model.INFO;

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
		public bool Delete(string CASENO,string INFOTYPE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CASEOTHERINFO ");
			strSql.Append(" where CASENO=:CASENO and INFOTYPE=:INFOTYPE ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,20),
					new OracleParameter(":INFOTYPE", OracleType.VarChar,10)			};
			parameters[0].Value = CASENO;
			parameters[1].Value = INFOTYPE;

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
		public Model.CASEOTHERINFO GetModel(string CASENO,string INFOTYPE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CASENO,INFOTYPE,INFO from CASEOTHERINFO ");
			strSql.Append(" where CASENO=:CASENO and INFOTYPE=:INFOTYPE ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,20),
					new OracleParameter(":INFOTYPE", OracleType.VarChar,10)			};
			parameters[0].Value = CASENO;
			parameters[1].Value = INFOTYPE;

			Model.CASEOTHERINFO model=new Model.CASEOTHERINFO();
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
		public Model.CASEOTHERINFO DataRowToModel(DataRow row)
		{
			Model.CASEOTHERINFO model=new Model.CASEOTHERINFO();
			if (row != null)
			{
				if(row["CASENO"]!=null)
				{
					model.CASENO=row["CASENO"].ToString();
				}
				if(row["INFOTYPE"]!=null)
				{
					model.INFOTYPE=row["INFOTYPE"].ToString();
				}
				if(row["INFO"]!=null)
				{
					model.INFO=row["INFO"].ToString();
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
			strSql.Append("select CASENO,INFOTYPE,INFO ");
			strSql.Append(" FROM CASEOTHERINFO ");
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
			strSql.Append("select count(1) FROM CASEOTHERINFO ");
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
				strSql.Append("order by T.INFOTYPE desc");
			}
			strSql.Append(")AS Row, T.*  from CASEOTHERINFO T ");
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
			parameters[0].Value = "CASEOTHERINFO";
			parameters[1].Value = "INFOTYPE";
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

