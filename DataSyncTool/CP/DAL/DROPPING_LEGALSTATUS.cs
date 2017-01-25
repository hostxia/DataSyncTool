using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:DROPPING_LEGALSTATUS
	/// </summary>
	public partial class DROPPING_LEGALSTATUS
	{
		public DROPPING_LEGALSTATUS()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.DROPPING_LEGALSTATUS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DROPPING_LEGALSTATUS(");
			strSql.Append("APPNO,STATUS,CONTENT,ANNOUNCED,ANNO)");
			strSql.Append(" values (");
			strSql.Append(":APPNO,:STATUS,:CONTENT,:ANNOUNCED,:ANNO)");
			OracleParameter[] parameters = {
					new OracleParameter(":APPNO", OracleType.VarChar,30),
					new OracleParameter(":STATUS", OracleType.VarChar,200),
					new OracleParameter(":CONTENT", OracleType.VarChar,4000),
					new OracleParameter(":ANNOUNCED", OracleType.VarChar,20),
					new OracleParameter(":ANNO", OracleType.VarChar,30)};
			parameters[0].Value = model.APPNO;
			parameters[1].Value = model.STATUS;
			parameters[2].Value = model.CONTENT;
			parameters[3].Value = model.ANNOUNCED;
			parameters[4].Value = model.ANNO;

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
		public bool Update(Model.DROPPING_LEGALSTATUS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DROPPING_LEGALSTATUS set ");
			strSql.Append("APPNO=:APPNO,");
			strSql.Append("STATUS=:STATUS,");
			strSql.Append("CONTENT=:CONTENT,");
			strSql.Append("ANNOUNCED=:ANNOUNCED,");
			strSql.Append("ANNO=:ANNO");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":APPNO", OracleType.VarChar,30),
					new OracleParameter(":STATUS", OracleType.VarChar,200),
					new OracleParameter(":CONTENT", OracleType.VarChar,4000),
					new OracleParameter(":ANNOUNCED", OracleType.VarChar,20),
					new OracleParameter(":ANNO", OracleType.VarChar,30)};
			parameters[0].Value = model.APPNO;
			parameters[1].Value = model.STATUS;
			parameters[2].Value = model.CONTENT;
			parameters[3].Value = model.ANNOUNCED;
			parameters[4].Value = model.ANNO;

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
			strSql.Append("delete from DROPPING_LEGALSTATUS ");
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
		public Model.DROPPING_LEGALSTATUS GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select APPNO,STATUS,CONTENT,ANNOUNCED,ANNO from DROPPING_LEGALSTATUS ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Model.DROPPING_LEGALSTATUS model=new Model.DROPPING_LEGALSTATUS();
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
		public Model.DROPPING_LEGALSTATUS DataRowToModel(DataRow row)
		{
			Model.DROPPING_LEGALSTATUS model=new Model.DROPPING_LEGALSTATUS();
			if (row != null)
			{
				if(row["APPNO"]!=null)
				{
					model.APPNO=row["APPNO"].ToString();
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
				}
				if(row["CONTENT"]!=null)
				{
					model.CONTENT=row["CONTENT"].ToString();
				}
				if(row["ANNOUNCED"]!=null)
				{
					model.ANNOUNCED=row["ANNOUNCED"].ToString();
				}
				if(row["ANNO"]!=null)
				{
					model.ANNO=row["ANNO"].ToString();
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
			strSql.Append("select APPNO,STATUS,CONTENT,ANNOUNCED,ANNO ");
			strSql.Append(" FROM DROPPING_LEGALSTATUS ");
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
			strSql.Append("select count(1) FROM DROPPING_LEGALSTATUS ");
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
				strSql.Append("order by T.HKNO desc");
			}
			strSql.Append(")AS Row, T.*  from DROPPING_LEGALSTATUS T ");
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
			parameters[0].Value = "DROPPING_LEGALSTATUS";
			parameters[1].Value = "HKNO";
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

