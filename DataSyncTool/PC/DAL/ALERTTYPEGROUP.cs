using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:ALERTTYPEGROUP
	/// </summary>
	public partial class ALERTTYPEGROUP
	{
		public ALERTTYPEGROUP()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string GROUPID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ALERTTYPEGROUP");
			strSql.Append(" where GROUPID=:GROUPID ");
			OracleParameter[] parameters = {
					new OracleParameter(":GROUPID", OracleType.VarChar,20)			};
			parameters[0].Value = GROUPID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.ALERTTYPEGROUP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ALERTTYPEGROUP(");
			strSql.Append("GROUPID,GROUPNAME,GROUPMEMBERS)");
			strSql.Append(" values (");
			strSql.Append(":GROUPID,:GROUPNAME,:GROUPMEMBERS)");
			OracleParameter[] parameters = {
					new OracleParameter(":GROUPID", OracleType.VarChar,20),
					new OracleParameter(":GROUPNAME", OracleType.VarChar,100),
					new OracleParameter(":GROUPMEMBERS", OracleType.VarChar,800)};
			parameters[0].Value = model.GROUPID;
			parameters[1].Value = model.GROUPNAME;
			parameters[2].Value = model.GROUPMEMBERS;

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
		public bool Update(Model.ALERTTYPEGROUP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ALERTTYPEGROUP set ");
			strSql.Append("GROUPID=:GROUPID,");
			strSql.Append("GROUPNAME=:GROUPNAME,");
			strSql.Append("GROUPMEMBERS=:GROUPMEMBERS");
			strSql.Append(" where GROUPID=:GROUPID ");
			OracleParameter[] parameters = {
					new OracleParameter(":GROUPID", OracleType.VarChar,20),
					new OracleParameter(":GROUPNAME", OracleType.VarChar,100),
					new OracleParameter(":GROUPMEMBERS", OracleType.VarChar,800)};
			parameters[0].Value = model.GROUPID;
			parameters[1].Value = model.GROUPNAME;
			parameters[2].Value = model.GROUPMEMBERS;

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
		public bool Delete(string GROUPID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ALERTTYPEGROUP ");
			strSql.Append(" where GROUPID=:GROUPID ");
			OracleParameter[] parameters = {
					new OracleParameter(":GROUPID", OracleType.VarChar,20)			};
			parameters[0].Value = GROUPID;

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
		public bool DeleteList(string GROUPIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ALERTTYPEGROUP ");
			strSql.Append(" where GROUPID in ("+GROUPIDlist + ")  ");
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
		public Model.ALERTTYPEGROUP GetModel(string GROUPID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select GROUPID,GROUPNAME,GROUPMEMBERS from ALERTTYPEGROUP ");
			strSql.Append(" where GROUPID=:GROUPID ");
			OracleParameter[] parameters = {
					new OracleParameter(":GROUPID", OracleType.VarChar,20)			};
			parameters[0].Value = GROUPID;

			Model.ALERTTYPEGROUP model=new Model.ALERTTYPEGROUP();
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
		public Model.ALERTTYPEGROUP DataRowToModel(DataRow row)
		{
			Model.ALERTTYPEGROUP model=new Model.ALERTTYPEGROUP();
			if (row != null)
			{
				if(row["GROUPID"]!=null)
				{
					model.GROUPID=row["GROUPID"].ToString();
				}
				if(row["GROUPNAME"]!=null)
				{
					model.GROUPNAME=row["GROUPNAME"].ToString();
				}
				if(row["GROUPMEMBERS"]!=null)
				{
					model.GROUPMEMBERS=row["GROUPMEMBERS"].ToString();
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
			strSql.Append("select GROUPID,GROUPNAME,GROUPMEMBERS ");
			strSql.Append(" FROM ALERTTYPEGROUP ");
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
			strSql.Append("select count(1) FROM ALERTTYPEGROUP ");
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
				strSql.Append("order by T.GROUPID desc");
			}
			strSql.Append(")AS Row, T.*  from ALERTTYPEGROUP T ");
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
			parameters[0].Value = "ALERTTYPEGROUP";
			parameters[1].Value = "GROUPID";
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

