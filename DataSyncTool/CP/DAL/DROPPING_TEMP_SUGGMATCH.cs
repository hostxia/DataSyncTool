using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:DROPPING_TEMP_SUGGMATCH
	/// </summary>
	public partial class DROPPING_TEMP_SUGGMATCH
	{
		public DROPPING_TEMP_SUGGMATCH()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.DROPPING_TEMP_SUGGMATCH model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DROPPING_TEMP_SUGGMATCH(");
			strSql.Append("CASENO,SUBNO,COUNTRY,APPSTATUS,APPNO,OURNO)");
			strSql.Append(" values (");
			strSql.Append(":CASENO,:SUBNO,:COUNTRY,:APPSTATUS,:APPNO,:OURNO)");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,20),
					new OracleParameter(":SUBNO", OracleType.VarChar,5),
					new OracleParameter(":COUNTRY", OracleType.VarChar,5),
					new OracleParameter(":APPSTATUS", OracleType.VarChar,30),
					new OracleParameter(":APPNO", OracleType.VarChar,30),
					new OracleParameter(":OURNO", OracleType.VarChar,30)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.SUBNO;
			parameters[2].Value = model.COUNTRY;
			parameters[3].Value = model.APPSTATUS;
			parameters[4].Value = model.APPNO;
			parameters[5].Value = model.OURNO;

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
		public bool Update(DataSyncTool.Model.DROPPING_TEMP_SUGGMATCH model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DROPPING_TEMP_SUGGMATCH set ");
			strSql.Append("CASENO=:CASENO,");
			strSql.Append("SUBNO=:SUBNO,");
			strSql.Append("COUNTRY=:COUNTRY,");
			strSql.Append("APPSTATUS=:APPSTATUS,");
			strSql.Append("APPNO=:APPNO,");
			strSql.Append("OURNO=:OURNO");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,20),
					new OracleParameter(":SUBNO", OracleType.VarChar,5),
					new OracleParameter(":COUNTRY", OracleType.VarChar,5),
					new OracleParameter(":APPSTATUS", OracleType.VarChar,30),
					new OracleParameter(":APPNO", OracleType.VarChar,30),
					new OracleParameter(":OURNO", OracleType.VarChar,30)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.SUBNO;
			parameters[2].Value = model.COUNTRY;
			parameters[3].Value = model.APPSTATUS;
			parameters[4].Value = model.APPNO;
			parameters[5].Value = model.OURNO;

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
			strSql.Append("delete from DROPPING_TEMP_SUGGMATCH ");
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
		public DataSyncTool.Model.DROPPING_TEMP_SUGGMATCH GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CASENO,SUBNO,COUNTRY,APPSTATUS,APPNO,OURNO from DROPPING_TEMP_SUGGMATCH ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			DataSyncTool.Model.DROPPING_TEMP_SUGGMATCH model=new DataSyncTool.Model.DROPPING_TEMP_SUGGMATCH();
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
		public DataSyncTool.Model.DROPPING_TEMP_SUGGMATCH DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.DROPPING_TEMP_SUGGMATCH model=new DataSyncTool.Model.DROPPING_TEMP_SUGGMATCH();
			if (row != null)
			{
				if(row["CASENO"]!=null)
				{
					model.CASENO=row["CASENO"].ToString();
				}
				if(row["SUBNO"]!=null)
				{
					model.SUBNO=row["SUBNO"].ToString();
				}
				if(row["COUNTRY"]!=null)
				{
					model.COUNTRY=row["COUNTRY"].ToString();
				}
				if(row["APPSTATUS"]!=null)
				{
					model.APPSTATUS=row["APPSTATUS"].ToString();
				}
				if(row["APPNO"]!=null)
				{
					model.APPNO=row["APPNO"].ToString();
				}
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
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
			strSql.Append("select CASENO,SUBNO,COUNTRY,APPSTATUS,APPNO,OURNO ");
			strSql.Append(" FROM DROPPING_TEMP_SUGGMATCH ");
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
			strSql.Append("select count(1) FROM DROPPING_TEMP_SUGGMATCH ");
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
			strSql.Append(")AS Row, T.*  from DROPPING_TEMP_SUGGMATCH T ");
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
			parameters[0].Value = "DROPPING_TEMP_SUGGMATCH";
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

