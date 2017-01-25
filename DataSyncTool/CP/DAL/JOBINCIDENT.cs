using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:JOBINCIDENT
	/// </summary>
	public partial class JOBINCIDENT
	{
		public JOBINCIDENT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string JOBID,string INCIDENT)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from JOBINCIDENT");
			strSql.Append(" where JOBID=:JOBID and INCIDENT=:INCIDENT ");
			OracleParameter[] parameters = {
					new OracleParameter(":JOBID", OracleType.VarChar,50),
					new OracleParameter(":INCIDENT", OracleType.VarChar,20)			};
			parameters[0].Value = JOBID;
			parameters[1].Value = INCIDENT;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.JOBINCIDENT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JOBINCIDENT(");
			strSql.Append("JOBID,INCIDENT,SEVERITY,COMMENTS)");
			strSql.Append(" values (");
			strSql.Append(":JOBID,:INCIDENT,:SEVERITY,:COMMENTS)");
			OracleParameter[] parameters = {
					new OracleParameter(":JOBID", OracleType.VarChar,50),
					new OracleParameter(":INCIDENT", OracleType.VarChar,20),
					new OracleParameter(":SEVERITY", OracleType.VarChar,3),
					new OracleParameter(":COMMENTS", OracleType.VarChar,2000)};
			parameters[0].Value = model.JOBID;
			parameters[1].Value = model.INCIDENT;
			parameters[2].Value = model.SEVERITY;
			parameters[3].Value = model.COMMENTS;

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
		public bool Update(Model.JOBINCIDENT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JOBINCIDENT set ");
			strSql.Append("JOBID=:JOBID,");
			strSql.Append("INCIDENT=:INCIDENT,");
			strSql.Append("SEVERITY=:SEVERITY,");
			strSql.Append("COMMENTS=:COMMENTS");
			strSql.Append(" where JOBID=:JOBID and INCIDENT=:INCIDENT ");
			OracleParameter[] parameters = {
					new OracleParameter(":JOBID", OracleType.VarChar,50),
					new OracleParameter(":INCIDENT", OracleType.VarChar,20),
					new OracleParameter(":SEVERITY", OracleType.VarChar,3),
					new OracleParameter(":COMMENTS", OracleType.VarChar,2000)};
			parameters[0].Value = model.JOBID;
			parameters[1].Value = model.INCIDENT;
			parameters[2].Value = model.SEVERITY;
			parameters[3].Value = model.COMMENTS;

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
		public bool Delete(string JOBID,string INCIDENT)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from JOBINCIDENT ");
			strSql.Append(" where JOBID=:JOBID and INCIDENT=:INCIDENT ");
			OracleParameter[] parameters = {
					new OracleParameter(":JOBID", OracleType.VarChar,50),
					new OracleParameter(":INCIDENT", OracleType.VarChar,20)			};
			parameters[0].Value = JOBID;
			parameters[1].Value = INCIDENT;

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
		public Model.JOBINCIDENT GetModel(string JOBID,string INCIDENT)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select JOBID,INCIDENT,SEVERITY,COMMENTS from JOBINCIDENT ");
			strSql.Append(" where JOBID=:JOBID and INCIDENT=:INCIDENT ");
			OracleParameter[] parameters = {
					new OracleParameter(":JOBID", OracleType.VarChar,50),
					new OracleParameter(":INCIDENT", OracleType.VarChar,20)			};
			parameters[0].Value = JOBID;
			parameters[1].Value = INCIDENT;

			Model.JOBINCIDENT model=new Model.JOBINCIDENT();
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
		public Model.JOBINCIDENT DataRowToModel(DataRow row)
		{
			Model.JOBINCIDENT model=new Model.JOBINCIDENT();
			if (row != null)
			{
				if(row["JOBID"]!=null)
				{
					model.JOBID=row["JOBID"].ToString();
				}
				if(row["INCIDENT"]!=null)
				{
					model.INCIDENT=row["INCIDENT"].ToString();
				}
				if(row["SEVERITY"]!=null)
				{
					model.SEVERITY=row["SEVERITY"].ToString();
				}
				if(row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
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
			strSql.Append("select JOBID,INCIDENT,SEVERITY,COMMENTS ");
			strSql.Append(" FROM JOBINCIDENT ");
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
			strSql.Append("select count(1) FROM JOBINCIDENT ");
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
				strSql.Append("order by T.INCIDENT desc");
			}
			strSql.Append(")AS Row, T.*  from JOBINCIDENT T ");
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
			parameters[0].Value = "JOBINCIDENT";
			parameters[1].Value = "INCIDENT";
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

