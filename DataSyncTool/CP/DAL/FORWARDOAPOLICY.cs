using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:FORWARDOAPOLICY
	/// </summary>
	public partial class FORWARDOAPOLICY
	{
		public FORWARDOAPOLICY()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.FORWARDOAPOLICY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FORWARDOAPOLICY(");
			strSql.Append("PID,DAYS,DESCRIPTION)");
			strSql.Append(" values (");
			strSql.Append(":PID,:DAYS,:DESCRIPTION)");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,40),
					new OracleParameter(":DAYS", OracleType.Number,4),
					new OracleParameter(":DESCRIPTION", OracleType.VarChar,100)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.DAYS;
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
		public bool Update(DataSyncTool.Model.FORWARDOAPOLICY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FORWARDOAPOLICY set ");
			strSql.Append("PID=:PID,");
			strSql.Append("DAYS=:DAYS,");
			strSql.Append("DESCRIPTION=:DESCRIPTION");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,40),
					new OracleParameter(":DAYS", OracleType.Number,4),
					new OracleParameter(":DESCRIPTION", OracleType.VarChar,100)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.DAYS;
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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FORWARDOAPOLICY ");
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
		public DataSyncTool.Model.FORWARDOAPOLICY GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PID,DAYS,DESCRIPTION from FORWARDOAPOLICY ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			DataSyncTool.Model.FORWARDOAPOLICY model=new DataSyncTool.Model.FORWARDOAPOLICY();
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
		public DataSyncTool.Model.FORWARDOAPOLICY DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.FORWARDOAPOLICY model=new DataSyncTool.Model.FORWARDOAPOLICY();
			if (row != null)
			{
				if(row["PID"]!=null)
				{
					model.PID=row["PID"].ToString();
				}
				if(row["DAYS"]!=null && row["DAYS"].ToString()!="")
				{
					model.DAYS=decimal.Parse(row["DAYS"].ToString());
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
			strSql.Append("select PID,DAYS,DESCRIPTION ");
			strSql.Append(" FROM FORWARDOAPOLICY ");
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
			strSql.Append("select count(1) FROM FORWARDOAPOLICY ");
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
			strSql.Append(")AS Row, T.*  from FORWARDOAPOLICY T ");
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
			parameters[0].Value = "FORWARDOAPOLICY";
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

