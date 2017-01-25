using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:INVENTORS
	/// </summary>
	public partial class INVENTORS
	{
		public INVENTORS()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.INVENTORS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into INVENTORS(");
			strSql.Append("INVENTOR,INVENTOR_CH,APPL_CODE1,PREFERRED)");
			strSql.Append(" values (");
			strSql.Append(":INVENTOR,:INVENTOR_CH,:APPL_CODE1,:PREFERRED)");
			OracleParameter[] parameters = {
					new OracleParameter(":INVENTOR", OracleType.VarChar,100),
					new OracleParameter(":INVENTOR_CH", OracleType.VarChar,150),
					new OracleParameter(":APPL_CODE1", OracleType.Char,4),
					new OracleParameter(":PREFERRED", OracleType.Char,1)};
			parameters[0].Value = model.INVENTOR;
			parameters[1].Value = model.INVENTOR_CH;
			parameters[2].Value = model.APPL_CODE1;
			parameters[3].Value = model.PREFERRED;

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
		public bool Update(DataSyncTool.Model.INVENTORS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update INVENTORS set ");
			strSql.Append("INVENTOR=:INVENTOR,");
			strSql.Append("INVENTOR_CH=:INVENTOR_CH,");
			strSql.Append("APPL_CODE1=:APPL_CODE1,");
			strSql.Append("PREFERRED=:PREFERRED");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":INVENTOR", OracleType.VarChar,100),
					new OracleParameter(":INVENTOR_CH", OracleType.VarChar,150),
					new OracleParameter(":APPL_CODE1", OracleType.Char,4),
					new OracleParameter(":PREFERRED", OracleType.Char,1)};
			parameters[0].Value = model.INVENTOR;
			parameters[1].Value = model.INVENTOR_CH;
			parameters[2].Value = model.APPL_CODE1;
			parameters[3].Value = model.PREFERRED;

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
			strSql.Append("delete from INVENTORS ");
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
		public DataSyncTool.Model.INVENTORS GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select INVENTOR,INVENTOR_CH,APPL_CODE1,PREFERRED from INVENTORS ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			DataSyncTool.Model.INVENTORS model=new DataSyncTool.Model.INVENTORS();
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
		public DataSyncTool.Model.INVENTORS DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.INVENTORS model=new DataSyncTool.Model.INVENTORS();
			if (row != null)
			{
				if(row["INVENTOR"]!=null)
				{
					model.INVENTOR=row["INVENTOR"].ToString();
				}
				if(row["INVENTOR_CH"]!=null)
				{
					model.INVENTOR_CH=row["INVENTOR_CH"].ToString();
				}
				if(row["APPL_CODE1"]!=null)
				{
					model.APPL_CODE1=row["APPL_CODE1"].ToString();
				}
				if(row["PREFERRED"]!=null)
				{
					model.PREFERRED=row["PREFERRED"].ToString();
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
			strSql.Append("select INVENTOR,INVENTOR_CH,APPL_CODE1,PREFERRED ");
			strSql.Append(" FROM INVENTORS ");
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
			strSql.Append("select count(1) FROM INVENTORS ");
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
			strSql.Append(")AS Row, T.*  from INVENTORS T ");
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
			parameters[0].Value = "INVENTORS";
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

