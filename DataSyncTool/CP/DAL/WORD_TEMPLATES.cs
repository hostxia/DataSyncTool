using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:WORD_TEMPLATES
	/// </summary>
	public partial class WORD_TEMPLATES
	{
		public WORD_TEMPLATES()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string FILE_NAME)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WORD_TEMPLATES");
			strSql.Append(" where FILE_NAME=:FILE_NAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":FILE_NAME", OracleType.VarChar,100)			};
			parameters[0].Value = FILE_NAME;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.WORD_TEMPLATES model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WORD_TEMPLATES(");
			strSql.Append("FILE_NAME,DESCRIPTION,TEMPLATE_TYPE,USEDBY)");
			strSql.Append(" values (");
			strSql.Append(":FILE_NAME,:DESCRIPTION,:TEMPLATE_TYPE,:USEDBY)");
			OracleParameter[] parameters = {
					new OracleParameter(":FILE_NAME", OracleType.VarChar,100),
					new OracleParameter(":DESCRIPTION", OracleType.VarChar,100),
					new OracleParameter(":TEMPLATE_TYPE", OracleType.VarChar,100),
					new OracleParameter(":USEDBY", OracleType.VarChar,10)};
			parameters[0].Value = model.FILE_NAME;
			parameters[1].Value = model.DESCRIPTION;
			parameters[2].Value = model.TEMPLATE_TYPE;
			parameters[3].Value = model.USEDBY;

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
		public bool Update(DataSyncTool.Model.WORD_TEMPLATES model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WORD_TEMPLATES set ");
			strSql.Append("FILE_NAME=:FILE_NAME,");
			strSql.Append("DESCRIPTION=:DESCRIPTION,");
			strSql.Append("TEMPLATE_TYPE=:TEMPLATE_TYPE,");
			strSql.Append("USEDBY=:USEDBY");
			strSql.Append(" where FILE_NAME=:FILE_NAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":FILE_NAME", OracleType.VarChar,100),
					new OracleParameter(":DESCRIPTION", OracleType.VarChar,100),
					new OracleParameter(":TEMPLATE_TYPE", OracleType.VarChar,100),
					new OracleParameter(":USEDBY", OracleType.VarChar,10)};
			parameters[0].Value = model.FILE_NAME;
			parameters[1].Value = model.DESCRIPTION;
			parameters[2].Value = model.TEMPLATE_TYPE;
			parameters[3].Value = model.USEDBY;

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
		public bool Delete(string FILE_NAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WORD_TEMPLATES ");
			strSql.Append(" where FILE_NAME=:FILE_NAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":FILE_NAME", OracleType.VarChar,100)			};
			parameters[0].Value = FILE_NAME;

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
		public bool DeleteList(string FILE_NAMElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WORD_TEMPLATES ");
			strSql.Append(" where FILE_NAME in ("+FILE_NAMElist + ")  ");
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
		public DataSyncTool.Model.WORD_TEMPLATES GetModel(string FILE_NAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FILE_NAME,DESCRIPTION,TEMPLATE_TYPE,USEDBY from WORD_TEMPLATES ");
			strSql.Append(" where FILE_NAME=:FILE_NAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":FILE_NAME", OracleType.VarChar,100)			};
			parameters[0].Value = FILE_NAME;

			DataSyncTool.Model.WORD_TEMPLATES model=new DataSyncTool.Model.WORD_TEMPLATES();
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
		public DataSyncTool.Model.WORD_TEMPLATES DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.WORD_TEMPLATES model=new DataSyncTool.Model.WORD_TEMPLATES();
			if (row != null)
			{
				if(row["FILE_NAME"]!=null)
				{
					model.FILE_NAME=row["FILE_NAME"].ToString();
				}
				if(row["DESCRIPTION"]!=null)
				{
					model.DESCRIPTION=row["DESCRIPTION"].ToString();
				}
				if(row["TEMPLATE_TYPE"]!=null)
				{
					model.TEMPLATE_TYPE=row["TEMPLATE_TYPE"].ToString();
				}
				if(row["USEDBY"]!=null)
				{
					model.USEDBY=row["USEDBY"].ToString();
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
			strSql.Append("select FILE_NAME,DESCRIPTION,TEMPLATE_TYPE,USEDBY ");
			strSql.Append(" FROM WORD_TEMPLATES ");
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
			strSql.Append("select count(1) FROM WORD_TEMPLATES ");
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
				strSql.Append("order by T.FILE_NAME desc");
			}
			strSql.Append(")AS Row, T.*  from WORD_TEMPLATES T ");
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
			parameters[0].Value = "WORD_TEMPLATES";
			parameters[1].Value = "FILE_NAME";
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

