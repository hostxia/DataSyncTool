using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:WORD_BOOKMARKS
	/// </summary>
	public partial class WORD_BOOKMARKS
	{
		public WORD_BOOKMARKS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string FILE_NAME,string BOOKMARK)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WORD_BOOKMARKS");
			strSql.Append(" where FILE_NAME=:FILE_NAME and BOOKMARK=:BOOKMARK ");
			OracleParameter[] parameters = {
					new OracleParameter(":FILE_NAME", OracleType.VarChar,100),
					new OracleParameter(":BOOKMARK", OracleType.VarChar,50)			};
			parameters[0].Value = FILE_NAME;
			parameters[1].Value = BOOKMARK;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.WORD_BOOKMARKS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WORD_BOOKMARKS(");
			strSql.Append("FILE_NAME,BOOKMARK,DESCRIPTION)");
			strSql.Append(" values (");
			strSql.Append(":FILE_NAME,:BOOKMARK,:DESCRIPTION)");
			OracleParameter[] parameters = {
					new OracleParameter(":FILE_NAME", OracleType.VarChar,100),
					new OracleParameter(":BOOKMARK", OracleType.VarChar,50),
					new OracleParameter(":DESCRIPTION", OracleType.VarChar,100)};
			parameters[0].Value = model.FILE_NAME;
			parameters[1].Value = model.BOOKMARK;
			parameters[2].Value = model.DESCRIPTION;

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
		public bool Update(Model.WORD_BOOKMARKS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WORD_BOOKMARKS set ");
			strSql.Append("FILE_NAME=:FILE_NAME,");
			strSql.Append("BOOKMARK=:BOOKMARK,");
			strSql.Append("DESCRIPTION=:DESCRIPTION");
			strSql.Append(" where FILE_NAME=:FILE_NAME and BOOKMARK=:BOOKMARK ");
			OracleParameter[] parameters = {
					new OracleParameter(":FILE_NAME", OracleType.VarChar,100),
					new OracleParameter(":BOOKMARK", OracleType.VarChar,50),
					new OracleParameter(":DESCRIPTION", OracleType.VarChar,100)};
			parameters[0].Value = model.FILE_NAME;
			parameters[1].Value = model.BOOKMARK;
			parameters[2].Value = model.DESCRIPTION;

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
		public bool Delete(string FILE_NAME,string BOOKMARK)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WORD_BOOKMARKS ");
			strSql.Append(" where FILE_NAME=:FILE_NAME and BOOKMARK=:BOOKMARK ");
			OracleParameter[] parameters = {
					new OracleParameter(":FILE_NAME", OracleType.VarChar,100),
					new OracleParameter(":BOOKMARK", OracleType.VarChar,50)			};
			parameters[0].Value = FILE_NAME;
			parameters[1].Value = BOOKMARK;

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
		public Model.WORD_BOOKMARKS GetModel(string FILE_NAME,string BOOKMARK)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FILE_NAME,BOOKMARK,DESCRIPTION from WORD_BOOKMARKS ");
			strSql.Append(" where FILE_NAME=:FILE_NAME and BOOKMARK=:BOOKMARK ");
			OracleParameter[] parameters = {
					new OracleParameter(":FILE_NAME", OracleType.VarChar,100),
					new OracleParameter(":BOOKMARK", OracleType.VarChar,50)			};
			parameters[0].Value = FILE_NAME;
			parameters[1].Value = BOOKMARK;

			Model.WORD_BOOKMARKS model=new Model.WORD_BOOKMARKS();
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
		public Model.WORD_BOOKMARKS DataRowToModel(DataRow row)
		{
			Model.WORD_BOOKMARKS model=new Model.WORD_BOOKMARKS();
			if (row != null)
			{
				if(row["FILE_NAME"]!=null)
				{
					model.FILE_NAME=row["FILE_NAME"].ToString();
				}
				if(row["BOOKMARK"]!=null)
				{
					model.BOOKMARK=row["BOOKMARK"].ToString();
				}
				if(row["DESCRIPTION"]!=null)
				{
					model.DESCRIPTION=row["DESCRIPTION"].ToString();
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
			strSql.Append("select FILE_NAME,BOOKMARK,DESCRIPTION ");
			strSql.Append(" FROM WORD_BOOKMARKS ");
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
			strSql.Append("select count(1) FROM WORD_BOOKMARKS ");
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
				strSql.Append("order by T.BOOKMARK desc");
			}
			strSql.Append(")AS Row, T.*  from WORD_BOOKMARKS T ");
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
			parameters[0].Value = "WORD_BOOKMARKS";
			parameters[1].Value = "BOOKMARK";
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

