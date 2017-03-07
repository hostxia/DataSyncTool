using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:CLASSIFIERTB
	/// </summary>
	public partial class CLASSIFIERTB
	{
		public CLASSIFIERTB()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.CLASSIFIERTB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CLASSIFIERTB(");
			strSql.Append("ID,CLASSNAME,COLUMNNAME,SETSCALE,COMMENTS)");
			strSql.Append(" values (");
			strSql.Append(":ID,:CLASSNAME,:COLUMNNAME,:SETSCALE,:COMMENTS)");
			OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleType.VarChar,20),
					new OracleParameter(":CLASSNAME", OracleType.VarChar,80),
					new OracleParameter(":COLUMNNAME", OracleType.VarChar,20),
					new OracleParameter(":SETSCALE", OracleType.VarChar,50),
					new OracleParameter(":COMMENTS", OracleType.VarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.CLASSNAME;
			parameters[2].Value = model.COLUMNNAME;
			parameters[3].Value = model.SETSCALE;
			parameters[4].Value = model.COMMENTS;

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
		public bool Update(Model.CLASSIFIERTB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CLASSIFIERTB set ");
			strSql.Append("ID=:ID,");
			strSql.Append("CLASSNAME=:CLASSNAME,");
			strSql.Append("COLUMNNAME=:COLUMNNAME,");
			strSql.Append("SETSCALE=:SETSCALE,");
			strSql.Append("COMMENTS=:COMMENTS");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleType.VarChar,20),
					new OracleParameter(":CLASSNAME", OracleType.VarChar,80),
					new OracleParameter(":COLUMNNAME", OracleType.VarChar,20),
					new OracleParameter(":SETSCALE", OracleType.VarChar,50),
					new OracleParameter(":COMMENTS", OracleType.VarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.CLASSNAME;
			parameters[2].Value = model.COLUMNNAME;
			parameters[3].Value = model.SETSCALE;
			parameters[4].Value = model.COMMENTS;

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
			strSql.Append("delete from CLASSIFIERTB ");
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
		public Model.CLASSIFIERTB GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CLASSNAME,COLUMNNAME,SETSCALE,COMMENTS from CLASSIFIERTB ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Model.CLASSIFIERTB model=new Model.CLASSIFIERTB();
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
		public Model.CLASSIFIERTB DataRowToModel(DataRow row)
		{
			Model.CLASSIFIERTB model=new Model.CLASSIFIERTB();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["CLASSNAME"]!=null)
				{
					model.CLASSNAME=row["CLASSNAME"].ToString();
				}
				if(row["COLUMNNAME"]!=null)
				{
					model.COLUMNNAME=row["COLUMNNAME"].ToString();
				}
				if(row["SETSCALE"]!=null)
				{
					model.SETSCALE=row["SETSCALE"].ToString();
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
			strSql.Append("select ID,CLASSNAME,COLUMNNAME,SETSCALE,COMMENTS ");
			strSql.Append(" FROM CLASSIFIERTB ");
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
			strSql.Append("select count(1) FROM CLASSIFIERTB ");
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
				strSql.Append("order by T.INFOTYPE desc");
			}
			strSql.Append(")AS Row, T.*  from CLASSIFIERTB T ");
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
			parameters[0].Value = "CLASSIFIERTB";
			parameters[1].Value = "INFOTYPE";
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

