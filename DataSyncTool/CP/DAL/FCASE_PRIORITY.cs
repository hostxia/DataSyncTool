using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:FCASE_PRIORITY
	/// </summary>
	public partial class FCASE_PRIORITY
	{
		public FCASE_PRIORITY()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FCASE_PRIORITY");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,20)			};
			parameters[0].Value = PID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.FCASE_PRIORITY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FCASE_PRIORITY(");
			strSql.Append("PID,OURNO,PRIOR_DATE,PRIOR_NUM,PRIOR_COUNTRY)");
			strSql.Append(" values (");
			strSql.Append(":PID,:OURNO,:PRIOR_DATE,:PRIOR_NUM,:PRIOR_COUNTRY)");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,20),
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":PRIOR_DATE", OracleType.DateTime),
					new OracleParameter(":PRIOR_NUM", OracleType.VarChar,30),
					new OracleParameter(":PRIOR_COUNTRY", OracleType.VarChar,50)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.OURNO;
			parameters[2].Value = model.PRIOR_DATE;
			parameters[3].Value = model.PRIOR_NUM;
			parameters[4].Value = model.PRIOR_COUNTRY;

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
		public bool Update(DataSyncTool.Model.FCASE_PRIORITY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FCASE_PRIORITY set ");
			strSql.Append("PID=:PID,");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("PRIOR_DATE=:PRIOR_DATE,");
			strSql.Append("PRIOR_NUM=:PRIOR_NUM,");
			strSql.Append("PRIOR_COUNTRY=:PRIOR_COUNTRY");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,20),
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":PRIOR_DATE", OracleType.DateTime),
					new OracleParameter(":PRIOR_NUM", OracleType.VarChar,30),
					new OracleParameter(":PRIOR_COUNTRY", OracleType.VarChar,50)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.OURNO;
			parameters[2].Value = model.PRIOR_DATE;
			parameters[3].Value = model.PRIOR_NUM;
			parameters[4].Value = model.PRIOR_COUNTRY;

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
		public bool Delete(string PID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FCASE_PRIORITY ");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,20)			};
			parameters[0].Value = PID;

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
		public bool DeleteList(string PIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FCASE_PRIORITY ");
			strSql.Append(" where PID in ("+PIDlist + ")  ");
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
		public DataSyncTool.Model.FCASE_PRIORITY GetModel(string PID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PID,OURNO,PRIOR_DATE,PRIOR_NUM,PRIOR_COUNTRY from FCASE_PRIORITY ");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,20)			};
			parameters[0].Value = PID;

			DataSyncTool.Model.FCASE_PRIORITY model=new DataSyncTool.Model.FCASE_PRIORITY();
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
		public DataSyncTool.Model.FCASE_PRIORITY DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.FCASE_PRIORITY model=new DataSyncTool.Model.FCASE_PRIORITY();
			if (row != null)
			{
				if(row["PID"]!=null)
				{
					model.PID=row["PID"].ToString();
				}
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["PRIOR_DATE"]!=null && row["PRIOR_DATE"].ToString()!="")
				{
					model.PRIOR_DATE=DateTime.Parse(row["PRIOR_DATE"].ToString());
				}
				if(row["PRIOR_NUM"]!=null)
				{
					model.PRIOR_NUM=row["PRIOR_NUM"].ToString();
				}
				if(row["PRIOR_COUNTRY"]!=null)
				{
					model.PRIOR_COUNTRY=row["PRIOR_COUNTRY"].ToString();
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
			strSql.Append("select PID,OURNO,PRIOR_DATE,PRIOR_NUM,PRIOR_COUNTRY ");
			strSql.Append(" FROM FCASE_PRIORITY ");
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
			strSql.Append("select count(1) FROM FCASE_PRIORITY ");
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
				strSql.Append("order by T.PID desc");
			}
			strSql.Append(")AS Row, T.*  from FCASE_PRIORITY T ");
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
			parameters[0].Value = "FCASE_PRIORITY";
			parameters[1].Value = "PID";
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

