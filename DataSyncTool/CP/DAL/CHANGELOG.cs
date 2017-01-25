using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:CHANGELOG
	/// </summary>
	public partial class CHANGELOG
	{
		public CHANGELOG()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.CHANGELOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CHANGELOG(");
			strSql.Append("ACT_DATE,OURNO,ACTION,COL_NAME,OLD_VAL,NEW_VAL,CUR_USER)");
			strSql.Append(" values (");
			strSql.Append(":ACT_DATE,:OURNO,:ACTION,:COL_NAME,:OLD_VAL,:NEW_VAL,:CUR_USER)");
			OracleParameter[] parameters = {
					new OracleParameter(":ACT_DATE", OracleType.DateTime),
					new OracleParameter(":OURNO", OracleType.VarChar,24),
					new OracleParameter(":ACTION", OracleType.Char,1),
					new OracleParameter(":COL_NAME", OracleType.VarChar,20),
					new OracleParameter(":OLD_VAL", OracleType.VarChar,300),
					new OracleParameter(":NEW_VAL", OracleType.VarChar,300),
					new OracleParameter(":CUR_USER", OracleType.VarChar,20)};
			parameters[0].Value = model.ACT_DATE;
			parameters[1].Value = model.OURNO;
			parameters[2].Value = model.ACTION;
			parameters[3].Value = model.COL_NAME;
			parameters[4].Value = model.OLD_VAL;
			parameters[5].Value = model.NEW_VAL;
			parameters[6].Value = model.CUR_USER;

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
		public bool Update(Model.CHANGELOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CHANGELOG set ");
			strSql.Append("ACT_DATE=:ACT_DATE,");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("ACTION=:ACTION,");
			strSql.Append("COL_NAME=:COL_NAME,");
			strSql.Append("OLD_VAL=:OLD_VAL,");
			strSql.Append("NEW_VAL=:NEW_VAL,");
			strSql.Append("CUR_USER=:CUR_USER");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":ACT_DATE", OracleType.DateTime),
					new OracleParameter(":OURNO", OracleType.VarChar,24),
					new OracleParameter(":ACTION", OracleType.Char,1),
					new OracleParameter(":COL_NAME", OracleType.VarChar,20),
					new OracleParameter(":OLD_VAL", OracleType.VarChar,300),
					new OracleParameter(":NEW_VAL", OracleType.VarChar,300),
					new OracleParameter(":CUR_USER", OracleType.VarChar,20)};
			parameters[0].Value = model.ACT_DATE;
			parameters[1].Value = model.OURNO;
			parameters[2].Value = model.ACTION;
			parameters[3].Value = model.COL_NAME;
			parameters[4].Value = model.OLD_VAL;
			parameters[5].Value = model.NEW_VAL;
			parameters[6].Value = model.CUR_USER;

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
			strSql.Append("delete from CHANGELOG ");
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
		public Model.CHANGELOG GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ACT_DATE,OURNO,ACTION,COL_NAME,OLD_VAL,NEW_VAL,CUR_USER from CHANGELOG ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Model.CHANGELOG model=new Model.CHANGELOG();
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
		public Model.CHANGELOG DataRowToModel(DataRow row)
		{
			Model.CHANGELOG model=new Model.CHANGELOG();
			if (row != null)
			{
				if(row["ACT_DATE"]!=null && row["ACT_DATE"].ToString()!="")
				{
					model.ACT_DATE=DateTime.Parse(row["ACT_DATE"].ToString());
				}
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["ACTION"]!=null)
				{
					model.ACTION=row["ACTION"].ToString();
				}
				if(row["COL_NAME"]!=null)
				{
					model.COL_NAME=row["COL_NAME"].ToString();
				}
				if(row["OLD_VAL"]!=null)
				{
					model.OLD_VAL=row["OLD_VAL"].ToString();
				}
				if(row["NEW_VAL"]!=null)
				{
					model.NEW_VAL=row["NEW_VAL"].ToString();
				}
				if(row["CUR_USER"]!=null)
				{
					model.CUR_USER=row["CUR_USER"].ToString();
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
			strSql.Append("select ACT_DATE,OURNO,ACTION,COL_NAME,OLD_VAL,NEW_VAL,CUR_USER ");
			strSql.Append(" FROM CHANGELOG ");
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
			strSql.Append("select count(1) FROM CHANGELOG ");
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
			strSql.Append(")AS Row, T.*  from CHANGELOG T ");
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
			parameters[0].Value = "CHANGELOG";
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

