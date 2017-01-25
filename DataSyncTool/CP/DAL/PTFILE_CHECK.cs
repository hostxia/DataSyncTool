using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:PTFILE_CHECK
	/// </summary>
	public partial class PTFILE_CHECK
	{
		public PTFILE_CHECK()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string NAME)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PTFILE_CHECK");
			strSql.Append(" where NAME=:NAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":NAME", OracleType.VarChar,400)			};
			parameters[0].Value = NAME;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.PTFILE_CHECK model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PTFILE_CHECK(");
			strSql.Append("CASENO,NAME,PATH,TSIZE,CT,MT,LASTSEEN,LASTBKUP,LASTVERIFY)");
			strSql.Append(" values (");
			strSql.Append(":CASENO,:NAME,:PATH,:TSIZE,:CT,:MT,:LASTSEEN,:LASTBKUP,:LASTVERIFY)");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,80),
					new OracleParameter(":NAME", OracleType.VarChar,400),
					new OracleParameter(":PATH", OracleType.VarChar,200),
					new OracleParameter(":TSIZE", OracleType.VarChar,20),
					new OracleParameter(":CT", OracleType.VarChar,40),
					new OracleParameter(":MT", OracleType.VarChar,40),
					new OracleParameter(":LASTSEEN", OracleType.VarChar,40),
					new OracleParameter(":LASTBKUP", OracleType.DateTime),
					new OracleParameter(":LASTVERIFY", OracleType.DateTime)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.NAME;
			parameters[2].Value = model.PATH;
			parameters[3].Value = model.TSIZE;
			parameters[4].Value = model.CT;
			parameters[5].Value = model.MT;
			parameters[6].Value = model.LASTSEEN;
			parameters[7].Value = model.LASTBKUP;
			parameters[8].Value = model.LASTVERIFY;

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
		public bool Update(DataSyncTool.Model.PTFILE_CHECK model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PTFILE_CHECK set ");
			strSql.Append("CASENO=:CASENO,");
			strSql.Append("NAME=:NAME,");
			strSql.Append("PATH=:PATH,");
			strSql.Append("TSIZE=:TSIZE,");
			strSql.Append("CT=:CT,");
			strSql.Append("MT=:MT,");
			strSql.Append("LASTSEEN=:LASTSEEN,");
			strSql.Append("LASTBKUP=:LASTBKUP,");
			strSql.Append("LASTVERIFY=:LASTVERIFY");
			strSql.Append(" where NAME=:NAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":CASENO", OracleType.VarChar,80),
					new OracleParameter(":NAME", OracleType.VarChar,400),
					new OracleParameter(":PATH", OracleType.VarChar,200),
					new OracleParameter(":TSIZE", OracleType.VarChar,20),
					new OracleParameter(":CT", OracleType.VarChar,40),
					new OracleParameter(":MT", OracleType.VarChar,40),
					new OracleParameter(":LASTSEEN", OracleType.VarChar,40),
					new OracleParameter(":LASTBKUP", OracleType.DateTime),
					new OracleParameter(":LASTVERIFY", OracleType.DateTime)};
			parameters[0].Value = model.CASENO;
			parameters[1].Value = model.NAME;
			parameters[2].Value = model.PATH;
			parameters[3].Value = model.TSIZE;
			parameters[4].Value = model.CT;
			parameters[5].Value = model.MT;
			parameters[6].Value = model.LASTSEEN;
			parameters[7].Value = model.LASTBKUP;
			parameters[8].Value = model.LASTVERIFY;

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
		public bool Delete(string NAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PTFILE_CHECK ");
			strSql.Append(" where NAME=:NAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":NAME", OracleType.VarChar,400)			};
			parameters[0].Value = NAME;

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
		public bool DeleteList(string NAMElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PTFILE_CHECK ");
			strSql.Append(" where NAME in ("+NAMElist + ")  ");
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
		public DataSyncTool.Model.PTFILE_CHECK GetModel(string NAME)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CASENO,NAME,PATH,TSIZE,CT,MT,LASTSEEN,LASTBKUP,LASTVERIFY from PTFILE_CHECK ");
			strSql.Append(" where NAME=:NAME ");
			OracleParameter[] parameters = {
					new OracleParameter(":NAME", OracleType.VarChar,400)			};
			parameters[0].Value = NAME;

			DataSyncTool.Model.PTFILE_CHECK model=new DataSyncTool.Model.PTFILE_CHECK();
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
		public DataSyncTool.Model.PTFILE_CHECK DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.PTFILE_CHECK model=new DataSyncTool.Model.PTFILE_CHECK();
			if (row != null)
			{
				if(row["CASENO"]!=null)
				{
					model.CASENO=row["CASENO"].ToString();
				}
				if(row["NAME"]!=null)
				{
					model.NAME=row["NAME"].ToString();
				}
				if(row["PATH"]!=null)
				{
					model.PATH=row["PATH"].ToString();
				}
				if(row["TSIZE"]!=null)
				{
					model.TSIZE=row["TSIZE"].ToString();
				}
				if(row["CT"]!=null)
				{
					model.CT=row["CT"].ToString();
				}
				if(row["MT"]!=null)
				{
					model.MT=row["MT"].ToString();
				}
				if(row["LASTSEEN"]!=null)
				{
					model.LASTSEEN=row["LASTSEEN"].ToString();
				}
				if(row["LASTBKUP"]!=null && row["LASTBKUP"].ToString()!="")
				{
					model.LASTBKUP=DateTime.Parse(row["LASTBKUP"].ToString());
				}
				if(row["LASTVERIFY"]!=null && row["LASTVERIFY"].ToString()!="")
				{
					model.LASTVERIFY=DateTime.Parse(row["LASTVERIFY"].ToString());
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
			strSql.Append("select CASENO,NAME,PATH,TSIZE,CT,MT,LASTSEEN,LASTBKUP,LASTVERIFY ");
			strSql.Append(" FROM PTFILE_CHECK ");
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
			strSql.Append("select count(1) FROM PTFILE_CHECK ");
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
				strSql.Append("order by T.NAME desc");
			}
			strSql.Append(")AS Row, T.*  from PTFILE_CHECK T ");
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
			parameters[0].Value = "PTFILE_CHECK";
			parameters[1].Value = "NAME";
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

