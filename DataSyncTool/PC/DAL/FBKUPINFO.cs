using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:FBKUPINFO
	/// </summary>
	public partial class FBKUPINFO
	{
		public FBKUPINFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string FNAME)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FBKUPINFO");
			strSql.Append(" where FNAME=:FNAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":FNAME", OracleType.VarChar,200)			};
			parameters[0].Value = FNAME;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.FBKUPINFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FBKUPINFO(");
			strSql.Append("FNAME,BKTIME,COMMENTS,CASENO,LBKT)");
			strSql.Append(" values (");
			strSql.Append(":FNAME,:BKTIME,:COMMENTS,:CASENO,:LBKT)");
			OracleParameter[] parameters = {
					new OracleParameter(":FNAME", OracleType.VarChar,200),
					new OracleParameter(":BKTIME", OracleType.Number,4),
					new OracleParameter(":COMMENTS", OracleType.VarChar,800),
					new OracleParameter(":CASENO", OracleType.VarChar,30),
					new OracleParameter(":LBKT", OracleType.DateTime)};
			parameters[0].Value = model.FNAME;
			parameters[1].Value = model.BKTIME;
			parameters[2].Value = model.COMMENTS;
			parameters[3].Value = model.CASENO;
			parameters[4].Value = model.LBKT;

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
		public bool Update(Model.FBKUPINFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FBKUPINFO set ");
			strSql.Append("FNAME=:FNAME,");
			strSql.Append("BKTIME=:BKTIME,");
			strSql.Append("COMMENTS=:COMMENTS,");
			strSql.Append("CASENO=:CASENO,");
			strSql.Append("LBKT=:LBKT");
			strSql.Append(" where FNAME=:FNAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":FNAME", OracleType.VarChar,200),
					new OracleParameter(":BKTIME", OracleType.Number,4),
					new OracleParameter(":COMMENTS", OracleType.VarChar,800),
					new OracleParameter(":CASENO", OracleType.VarChar,30),
					new OracleParameter(":LBKT", OracleType.DateTime)};
			parameters[0].Value = model.FNAME;
			parameters[1].Value = model.BKTIME;
			parameters[2].Value = model.COMMENTS;
			parameters[3].Value = model.CASENO;
			parameters[4].Value = model.LBKT;

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
		public bool Delete(string FNAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FBKUPINFO ");
			strSql.Append(" where FNAME=:FNAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":FNAME", OracleType.VarChar,200)			};
			parameters[0].Value = FNAME;

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
		public bool DeleteList(string FNAMElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FBKUPINFO ");
			strSql.Append(" where FNAME in ("+FNAMElist + ")  ");
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
		public Model.FBKUPINFO GetModel(string FNAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FNAME,BKTIME,COMMENTS,CASENO,LBKT from FBKUPINFO ");
			strSql.Append(" where FNAME=:FNAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":FNAME", OracleType.VarChar,200)			};
			parameters[0].Value = FNAME;

			Model.FBKUPINFO model=new Model.FBKUPINFO();
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
		public Model.FBKUPINFO DataRowToModel(DataRow row)
		{
			Model.FBKUPINFO model=new Model.FBKUPINFO();
			if (row != null)
			{
				if(row["FNAME"]!=null)
				{
					model.FNAME=row["FNAME"].ToString();
				}
				if(row["BKTIME"]!=null && row["BKTIME"].ToString()!="")
				{
					model.BKTIME=decimal.Parse(row["BKTIME"].ToString());
				}
				if(row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
				}
				if(row["CASENO"]!=null)
				{
					model.CASENO=row["CASENO"].ToString();
				}
				if(row["LBKT"]!=null && row["LBKT"].ToString()!="")
				{
					model.LBKT=DateTime.Parse(row["LBKT"].ToString());
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
			strSql.Append("select FNAME,BKTIME,COMMENTS,CASENO,LBKT ");
			strSql.Append(" FROM FBKUPINFO ");
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
			strSql.Append("select count(1) FROM FBKUPINFO ");
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
				strSql.Append("order by T.FNAME desc");
			}
			strSql.Append(")AS Row, T.*  from FBKUPINFO T ");
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
			parameters[0].Value = "FBKUPINFO";
			parameters[1].Value = "FNAME";
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

