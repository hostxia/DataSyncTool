using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:HEADERMAPPINGTB
	/// </summary>
	public partial class HEADERMAPPINGTB
	{
		public HEADERMAPPINGTB()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from HEADERMAPPINGTB");
			strSql.Append(" where ID=:ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleType.VarChar,40)			};
			parameters[0].Value = ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.HEADERMAPPINGTB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HEADERMAPPINGTB(");
			strSql.Append("ID,EXPRESSION,TABLENAME,TYPE,DATA_TYPE,NULLABLE,HEADING,REPORTCOL,FORMATTER)");
			strSql.Append(" values (");
			strSql.Append(":ID,:EXPRESSION,:TABLENAME,:TYPE,:DATA_TYPE,:NULLABLE,:HEADING,:REPORTCOL,:FORMATTER)");
			OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleType.VarChar,40),
					new OracleParameter(":EXPRESSION", OracleType.VarChar,800),
					new OracleParameter(":TABLENAME", OracleType.VarChar,40),
					new OracleParameter(":TYPE", OracleType.Char,1),
					new OracleParameter(":DATA_TYPE", OracleType.VarChar,40),
					new OracleParameter(":NULLABLE", OracleType.VarChar,1),
					new OracleParameter(":HEADING", OracleType.VarChar,60),
					new OracleParameter(":REPORTCOL", OracleType.VarChar,10),
					new OracleParameter(":FORMATTER", OracleType.VarChar,40)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.EXPRESSION;
			parameters[2].Value = model.TABLENAME;
			parameters[3].Value = model.TYPE;
			parameters[4].Value = model.DATA_TYPE;
			parameters[5].Value = model.NULLABLE;
			parameters[6].Value = model.HEADING;
			parameters[7].Value = model.REPORTCOL;
			parameters[8].Value = model.FORMATTER;

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
		public bool Update(Model.HEADERMAPPINGTB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HEADERMAPPINGTB set ");
			strSql.Append("ID=:ID,");
			strSql.Append("EXPRESSION=:EXPRESSION,");
			strSql.Append("TABLENAME=:TABLENAME,");
			strSql.Append("TYPE=:TYPE,");
			strSql.Append("DATA_TYPE=:DATA_TYPE,");
			strSql.Append("NULLABLE=:NULLABLE,");
			strSql.Append("HEADING=:HEADING,");
			strSql.Append("REPORTCOL=:REPORTCOL,");
			strSql.Append("FORMATTER=:FORMATTER");
			strSql.Append(" where ID=:ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleType.VarChar,40),
					new OracleParameter(":EXPRESSION", OracleType.VarChar,800),
					new OracleParameter(":TABLENAME", OracleType.VarChar,40),
					new OracleParameter(":TYPE", OracleType.Char,1),
					new OracleParameter(":DATA_TYPE", OracleType.VarChar,40),
					new OracleParameter(":NULLABLE", OracleType.VarChar,1),
					new OracleParameter(":HEADING", OracleType.VarChar,60),
					new OracleParameter(":REPORTCOL", OracleType.VarChar,10),
					new OracleParameter(":FORMATTER", OracleType.VarChar,40)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.EXPRESSION;
			parameters[2].Value = model.TABLENAME;
			parameters[3].Value = model.TYPE;
			parameters[4].Value = model.DATA_TYPE;
			parameters[5].Value = model.NULLABLE;
			parameters[6].Value = model.HEADING;
			parameters[7].Value = model.REPORTCOL;
			parameters[8].Value = model.FORMATTER;

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
		public bool Delete(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HEADERMAPPINGTB ");
			strSql.Append(" where ID=:ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleType.VarChar,40)			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HEADERMAPPINGTB ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public Model.HEADERMAPPINGTB GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,EXPRESSION,TABLENAME,TYPE,DATA_TYPE,NULLABLE,HEADING,REPORTCOL,FORMATTER from HEADERMAPPINGTB ");
			strSql.Append(" where ID=:ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleType.VarChar,40)			};
			parameters[0].Value = ID;

			Model.HEADERMAPPINGTB model=new Model.HEADERMAPPINGTB();
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
		public Model.HEADERMAPPINGTB DataRowToModel(DataRow row)
		{
			Model.HEADERMAPPINGTB model=new Model.HEADERMAPPINGTB();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["EXPRESSION"]!=null)
				{
					model.EXPRESSION=row["EXPRESSION"].ToString();
				}
				if(row["TABLENAME"]!=null)
				{
					model.TABLENAME=row["TABLENAME"].ToString();
				}
				if(row["TYPE"]!=null)
				{
					model.TYPE=row["TYPE"].ToString();
				}
				if(row["DATA_TYPE"]!=null)
				{
					model.DATA_TYPE=row["DATA_TYPE"].ToString();
				}
				if(row["NULLABLE"]!=null)
				{
					model.NULLABLE=row["NULLABLE"].ToString();
				}
				if(row["HEADING"]!=null)
				{
					model.HEADING=row["HEADING"].ToString();
				}
				if(row["REPORTCOL"]!=null)
				{
					model.REPORTCOL=row["REPORTCOL"].ToString();
				}
				if(row["FORMATTER"]!=null)
				{
					model.FORMATTER=row["FORMATTER"].ToString();
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
			strSql.Append("select ID,EXPRESSION,TABLENAME,TYPE,DATA_TYPE,NULLABLE,HEADING,REPORTCOL,FORMATTER ");
			strSql.Append(" FROM HEADERMAPPINGTB ");
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
			strSql.Append("select count(1) FROM HEADERMAPPINGTB ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from HEADERMAPPINGTB T ");
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
			parameters[0].Value = "HEADERMAPPINGTB";
			parameters[1].Value = "ID";
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

