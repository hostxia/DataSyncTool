using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:FILE_TRACKING
	/// </summary>
	public partial class FILE_TRACKING
	{
		public FILE_TRACKING()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string OURNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FILE_TRACKING");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30)			};
			parameters[0].Value = OURNO;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.FILE_TRACKING model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FILE_TRACKING(");
			strSql.Append("OURNO,BORROWER,BORROWTIME,STATUS,LIBRARY)");
			strSql.Append(" values (");
			strSql.Append(":OURNO,:BORROWER,:BORROWTIME,:STATUS,:LIBRARY)");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":BORROWER", OracleType.VarChar,20),
					new OracleParameter(":BORROWTIME", OracleType.DateTime),
					new OracleParameter(":STATUS", OracleType.VarChar,10),
					new OracleParameter(":LIBRARY", OracleType.VarChar,10)};
			parameters[0].Value = model.OURNO;
			parameters[1].Value = model.BORROWER;
			parameters[2].Value = model.BORROWTIME;
			parameters[3].Value = model.STATUS;
			parameters[4].Value = model.LIBRARY;

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
		public bool Update(Model.FILE_TRACKING model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FILE_TRACKING set ");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("BORROWER=:BORROWER,");
			strSql.Append("BORROWTIME=:BORROWTIME,");
			strSql.Append("STATUS=:STATUS,");
			strSql.Append("LIBRARY=:LIBRARY");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":BORROWER", OracleType.VarChar,20),
					new OracleParameter(":BORROWTIME", OracleType.DateTime),
					new OracleParameter(":STATUS", OracleType.VarChar,10),
					new OracleParameter(":LIBRARY", OracleType.VarChar,10)};
			parameters[0].Value = model.OURNO;
			parameters[1].Value = model.BORROWER;
			parameters[2].Value = model.BORROWTIME;
			parameters[3].Value = model.STATUS;
			parameters[4].Value = model.LIBRARY;

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
			strSql.Append("delete from FILE_TRACKING ");
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
			strSql.Append("delete from FILE_TRACKING ");
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
		public Model.FILE_TRACKING GetModel(string OURNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OURNO,BORROWER,BORROWTIME,STATUS,LIBRARY from FILE_TRACKING ");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30)			};
			parameters[0].Value = OURNO;

			Model.FILE_TRACKING model=new Model.FILE_TRACKING();
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
		public Model.FILE_TRACKING DataRowToModel(DataRow row)
		{
			Model.FILE_TRACKING model=new Model.FILE_TRACKING();
			if (row != null)
			{
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["BORROWER"]!=null)
				{
					model.BORROWER=row["BORROWER"].ToString();
				}
				if(row["BORROWTIME"]!=null && row["BORROWTIME"].ToString()!="")
				{
					model.BORROWTIME=DateTime.Parse(row["BORROWTIME"].ToString());
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
				}
				if(row["LIBRARY"]!=null)
				{
					model.LIBRARY=row["LIBRARY"].ToString();
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
			strSql.Append("select OURNO,BORROWER,BORROWTIME,STATUS,LIBRARY ");
			strSql.Append(" FROM FILE_TRACKING ");
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
			strSql.Append("select count(1) FROM FILE_TRACKING ");
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
			strSql.Append(")AS Row, T.*  from FILE_TRACKING T ");
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
			parameters[0].Value = "FILE_TRACKING";
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

