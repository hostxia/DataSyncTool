using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:DROPPING_HKPATENT
	/// </summary>
	public partial class DROPPING_HKPATENT
	{
		public DROPPING_HKPATENT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string HKNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DROPPING_HKPATENT");
			strSql.Append(" where HKNO=:HKNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":HKNO", OracleType.VarChar,30)			};
			parameters[0].Value = HKNO;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.DROPPING_HKPATENT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DROPPING_HKPATENT(");
			strSql.Append("HKNO,OURNO,CN_APPNO,CN_APPDATE,CN_PUBNO,CN_PUBDATE,CN_GRANTNO,CN_GRANTDATE,EARLIEST_MAINTENANCE_DATE,EARLIEST_RENEW_DATE,STEP1_DATE,STEP2_DATE)");
			strSql.Append(" values (");
			strSql.Append(":HKNO,:OURNO,:CN_APPNO,:CN_APPDATE,:CN_PUBNO,:CN_PUBDATE,:CN_GRANTNO,:CN_GRANTDATE,:EARLIEST_MAINTENANCE_DATE,:EARLIEST_RENEW_DATE,:STEP1_DATE,:STEP2_DATE)");
			OracleParameter[] parameters = {
					new OracleParameter(":HKNO", OracleType.VarChar,30),
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":CN_APPNO", OracleType.VarChar,30),
					new OracleParameter(":CN_APPDATE", OracleType.DateTime),
					new OracleParameter(":CN_PUBNO", OracleType.VarChar,20),
					new OracleParameter(":CN_PUBDATE", OracleType.DateTime),
					new OracleParameter(":CN_GRANTNO", OracleType.VarChar,20),
					new OracleParameter(":CN_GRANTDATE", OracleType.DateTime),
					new OracleParameter(":EARLIEST_MAINTENANCE_DATE", OracleType.DateTime),
					new OracleParameter(":EARLIEST_RENEW_DATE", OracleType.DateTime),
					new OracleParameter(":STEP1_DATE", OracleType.DateTime),
					new OracleParameter(":STEP2_DATE", OracleType.DateTime)};
			parameters[0].Value = model.HKNO;
			parameters[1].Value = model.OURNO;
			parameters[2].Value = model.CN_APPNO;
			parameters[3].Value = model.CN_APPDATE;
			parameters[4].Value = model.CN_PUBNO;
			parameters[5].Value = model.CN_PUBDATE;
			parameters[6].Value = model.CN_GRANTNO;
			parameters[7].Value = model.CN_GRANTDATE;
			parameters[8].Value = model.EARLIEST_MAINTENANCE_DATE;
			parameters[9].Value = model.EARLIEST_RENEW_DATE;
			parameters[10].Value = model.STEP1_DATE;
			parameters[11].Value = model.STEP2_DATE;

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
		public bool Update(Model.DROPPING_HKPATENT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DROPPING_HKPATENT set ");
			strSql.Append("HKNO=:HKNO,");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("CN_APPNO=:CN_APPNO,");
			strSql.Append("CN_APPDATE=:CN_APPDATE,");
			strSql.Append("CN_PUBNO=:CN_PUBNO,");
			strSql.Append("CN_PUBDATE=:CN_PUBDATE,");
			strSql.Append("CN_GRANTNO=:CN_GRANTNO,");
			strSql.Append("CN_GRANTDATE=:CN_GRANTDATE,");
			strSql.Append("EARLIEST_MAINTENANCE_DATE=:EARLIEST_MAINTENANCE_DATE,");
			strSql.Append("EARLIEST_RENEW_DATE=:EARLIEST_RENEW_DATE,");
			strSql.Append("STEP1_DATE=:STEP1_DATE,");
			strSql.Append("STEP2_DATE=:STEP2_DATE");
			strSql.Append(" where HKNO=:HKNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":HKNO", OracleType.VarChar,30),
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":CN_APPNO", OracleType.VarChar,30),
					new OracleParameter(":CN_APPDATE", OracleType.DateTime),
					new OracleParameter(":CN_PUBNO", OracleType.VarChar,20),
					new OracleParameter(":CN_PUBDATE", OracleType.DateTime),
					new OracleParameter(":CN_GRANTNO", OracleType.VarChar,20),
					new OracleParameter(":CN_GRANTDATE", OracleType.DateTime),
					new OracleParameter(":EARLIEST_MAINTENANCE_DATE", OracleType.DateTime),
					new OracleParameter(":EARLIEST_RENEW_DATE", OracleType.DateTime),
					new OracleParameter(":STEP1_DATE", OracleType.DateTime),
					new OracleParameter(":STEP2_DATE", OracleType.DateTime)};
			parameters[0].Value = model.HKNO;
			parameters[1].Value = model.OURNO;
			parameters[2].Value = model.CN_APPNO;
			parameters[3].Value = model.CN_APPDATE;
			parameters[4].Value = model.CN_PUBNO;
			parameters[5].Value = model.CN_PUBDATE;
			parameters[6].Value = model.CN_GRANTNO;
			parameters[7].Value = model.CN_GRANTDATE;
			parameters[8].Value = model.EARLIEST_MAINTENANCE_DATE;
			parameters[9].Value = model.EARLIEST_RENEW_DATE;
			parameters[10].Value = model.STEP1_DATE;
			parameters[11].Value = model.STEP2_DATE;

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
		public bool Delete(string HKNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DROPPING_HKPATENT ");
			strSql.Append(" where HKNO=:HKNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":HKNO", OracleType.VarChar,30)			};
			parameters[0].Value = HKNO;

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
		public bool DeleteList(string HKNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DROPPING_HKPATENT ");
			strSql.Append(" where HKNO in ("+HKNOlist + ")  ");
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
		public Model.DROPPING_HKPATENT GetModel(string HKNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select HKNO,OURNO,CN_APPNO,CN_APPDATE,CN_PUBNO,CN_PUBDATE,CN_GRANTNO,CN_GRANTDATE,EARLIEST_MAINTENANCE_DATE,EARLIEST_RENEW_DATE,STEP1_DATE,STEP2_DATE from DROPPING_HKPATENT ");
			strSql.Append(" where HKNO=:HKNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":HKNO", OracleType.VarChar,30)			};
			parameters[0].Value = HKNO;

			Model.DROPPING_HKPATENT model=new Model.DROPPING_HKPATENT();
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
		public Model.DROPPING_HKPATENT DataRowToModel(DataRow row)
		{
			Model.DROPPING_HKPATENT model=new Model.DROPPING_HKPATENT();
			if (row != null)
			{
				if(row["HKNO"]!=null)
				{
					model.HKNO=row["HKNO"].ToString();
				}
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["CN_APPNO"]!=null)
				{
					model.CN_APPNO=row["CN_APPNO"].ToString();
				}
				if(row["CN_APPDATE"]!=null && row["CN_APPDATE"].ToString()!="")
				{
					model.CN_APPDATE=DateTime.Parse(row["CN_APPDATE"].ToString());
				}
				if(row["CN_PUBNO"]!=null)
				{
					model.CN_PUBNO=row["CN_PUBNO"].ToString();
				}
				if(row["CN_PUBDATE"]!=null && row["CN_PUBDATE"].ToString()!="")
				{
					model.CN_PUBDATE=DateTime.Parse(row["CN_PUBDATE"].ToString());
				}
				if(row["CN_GRANTNO"]!=null)
				{
					model.CN_GRANTNO=row["CN_GRANTNO"].ToString();
				}
				if(row["CN_GRANTDATE"]!=null && row["CN_GRANTDATE"].ToString()!="")
				{
					model.CN_GRANTDATE=DateTime.Parse(row["CN_GRANTDATE"].ToString());
				}
				if(row["EARLIEST_MAINTENANCE_DATE"]!=null && row["EARLIEST_MAINTENANCE_DATE"].ToString()!="")
				{
					model.EARLIEST_MAINTENANCE_DATE=DateTime.Parse(row["EARLIEST_MAINTENANCE_DATE"].ToString());
				}
				if(row["EARLIEST_RENEW_DATE"]!=null && row["EARLIEST_RENEW_DATE"].ToString()!="")
				{
					model.EARLIEST_RENEW_DATE=DateTime.Parse(row["EARLIEST_RENEW_DATE"].ToString());
				}
				if(row["STEP1_DATE"]!=null && row["STEP1_DATE"].ToString()!="")
				{
					model.STEP1_DATE=DateTime.Parse(row["STEP1_DATE"].ToString());
				}
				if(row["STEP2_DATE"]!=null && row["STEP2_DATE"].ToString()!="")
				{
					model.STEP2_DATE=DateTime.Parse(row["STEP2_DATE"].ToString());
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
			strSql.Append("select HKNO,OURNO,CN_APPNO,CN_APPDATE,CN_PUBNO,CN_PUBDATE,CN_GRANTNO,CN_GRANTDATE,EARLIEST_MAINTENANCE_DATE,EARLIEST_RENEW_DATE,STEP1_DATE,STEP2_DATE ");
			strSql.Append(" FROM DROPPING_HKPATENT ");
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
			strSql.Append("select count(1) FROM DROPPING_HKPATENT ");
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
				strSql.Append("order by T.HKNO desc");
			}
			strSql.Append(")AS Row, T.*  from DROPPING_HKPATENT T ");
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
			parameters[0].Value = "DROPPING_HKPATENT";
			parameters[1].Value = "HKNO";
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

