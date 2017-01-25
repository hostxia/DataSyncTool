using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:FLFEETYPE
	/// </summary>
	public partial class FLFEETYPE
	{
		public FLFEETYPE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string TYPENAME)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FLFEETYPE");
			strSql.Append(" where TYPENAME=:TYPENAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPENAME", OracleType.VarChar,30)			};
			parameters[0].Value = TYPENAME;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.FLFEETYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FLFEETYPE(");
			strSql.Append("TYPENAME,TYPEGROUP)");
			strSql.Append(" values (");
			strSql.Append(":TYPENAME,:TYPEGROUP)");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPENAME", OracleType.VarChar,30),
					new OracleParameter(":TYPEGROUP", OracleType.VarChar,30)};
			parameters[0].Value = model.TYPENAME;
			parameters[1].Value = model.TYPEGROUP;

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
		public bool Update(DataSyncTool.Model.FLFEETYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FLFEETYPE set ");
			strSql.Append("TYPENAME=:TYPENAME,");
			strSql.Append("TYPEGROUP=:TYPEGROUP");
			strSql.Append(" where TYPENAME=:TYPENAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPENAME", OracleType.VarChar,30),
					new OracleParameter(":TYPEGROUP", OracleType.VarChar,30)};
			parameters[0].Value = model.TYPENAME;
			parameters[1].Value = model.TYPEGROUP;

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
		public bool Delete(string TYPENAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FLFEETYPE ");
			strSql.Append(" where TYPENAME=:TYPENAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPENAME", OracleType.VarChar,30)			};
			parameters[0].Value = TYPENAME;

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
		public bool DeleteList(string TYPENAMElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FLFEETYPE ");
			strSql.Append(" where TYPENAME in ("+TYPENAMElist + ")  ");
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
		public DataSyncTool.Model.FLFEETYPE GetModel(string TYPENAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TYPENAME,TYPEGROUP from FLFEETYPE ");
			strSql.Append(" where TYPENAME=:TYPENAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":TYPENAME", OracleType.VarChar,30)			};
			parameters[0].Value = TYPENAME;

			DataSyncTool.Model.FLFEETYPE model=new DataSyncTool.Model.FLFEETYPE();
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
		public DataSyncTool.Model.FLFEETYPE DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.FLFEETYPE model=new DataSyncTool.Model.FLFEETYPE();
			if (row != null)
			{
				if(row["TYPENAME"]!=null)
				{
					model.TYPENAME=row["TYPENAME"].ToString();
				}
				if(row["TYPEGROUP"]!=null)
				{
					model.TYPEGROUP=row["TYPEGROUP"].ToString();
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
			strSql.Append("select TYPENAME,TYPEGROUP ");
			strSql.Append(" FROM FLFEETYPE ");
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
			strSql.Append("select count(1) FROM FLFEETYPE ");
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
				strSql.Append("order by T.TYPENAME desc");
			}
			strSql.Append(")AS Row, T.*  from FLFEETYPE T ");
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
			parameters[0].Value = "FLFEETYPE";
			parameters[1].Value = "TYPENAME";
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

