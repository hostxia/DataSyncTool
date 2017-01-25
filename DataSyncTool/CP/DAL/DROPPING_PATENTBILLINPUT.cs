using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:DROPPING_PATENTBILLINPUT
	/// </summary>
	public partial class DROPPING_PATENTBILLINPUT
	{
		public DROPPING_PATENTBILLINPUT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DROPPING_PATENTBILLINPUT");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,30)			};
			parameters[0].Value = PID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.DROPPING_PATENTBILLINPUT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DROPPING_PATENTBILLINPUT(");
			strSql.Append("PID,NOTENUMBER,TYPE,TEXT,QUANTITY,OFFICIALFEE,OTHERFEE,WAIVE)");
			strSql.Append(" values (");
			strSql.Append(":PID,:NOTENUMBER,:TYPE,:TEXT,:QUANTITY,:OFFICIALFEE,:OTHERFEE,:WAIVE)");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,30),
					new OracleParameter(":NOTENUMBER", OracleType.VarChar,23),
					new OracleParameter(":TYPE", OracleType.VarChar,30),
					new OracleParameter(":TEXT", OracleType.VarChar,150),
					new OracleParameter(":QUANTITY", OracleType.Number,8),
					new OracleParameter(":OFFICIALFEE", OracleType.Number,4),
					new OracleParameter(":OTHERFEE", OracleType.Number,4),
					new OracleParameter(":WAIVE", OracleType.VarChar,6)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.NOTENUMBER;
			parameters[2].Value = model.TYPE;
			parameters[3].Value = model.TEXT;
			parameters[4].Value = model.QUANTITY;
			parameters[5].Value = model.OFFICIALFEE;
			parameters[6].Value = model.OTHERFEE;
			parameters[7].Value = model.WAIVE;

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
		public bool Update(DataSyncTool.Model.DROPPING_PATENTBILLINPUT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DROPPING_PATENTBILLINPUT set ");
			strSql.Append("PID=:PID,");
			strSql.Append("NOTENUMBER=:NOTENUMBER,");
			strSql.Append("TYPE=:TYPE,");
			strSql.Append("TEXT=:TEXT,");
			strSql.Append("QUANTITY=:QUANTITY,");
			strSql.Append("OFFICIALFEE=:OFFICIALFEE,");
			strSql.Append("OTHERFEE=:OTHERFEE,");
			strSql.Append("WAIVE=:WAIVE");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,30),
					new OracleParameter(":NOTENUMBER", OracleType.VarChar,23),
					new OracleParameter(":TYPE", OracleType.VarChar,30),
					new OracleParameter(":TEXT", OracleType.VarChar,150),
					new OracleParameter(":QUANTITY", OracleType.Number,8),
					new OracleParameter(":OFFICIALFEE", OracleType.Number,4),
					new OracleParameter(":OTHERFEE", OracleType.Number,4),
					new OracleParameter(":WAIVE", OracleType.VarChar,6)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.NOTENUMBER;
			parameters[2].Value = model.TYPE;
			parameters[3].Value = model.TEXT;
			parameters[4].Value = model.QUANTITY;
			parameters[5].Value = model.OFFICIALFEE;
			parameters[6].Value = model.OTHERFEE;
			parameters[7].Value = model.WAIVE;

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
			strSql.Append("delete from DROPPING_PATENTBILLINPUT ");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,30)			};
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
			strSql.Append("delete from DROPPING_PATENTBILLINPUT ");
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
		public DataSyncTool.Model.DROPPING_PATENTBILLINPUT GetModel(string PID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PID,NOTENUMBER,TYPE,TEXT,QUANTITY,OFFICIALFEE,OTHERFEE,WAIVE from DROPPING_PATENTBILLINPUT ");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,30)			};
			parameters[0].Value = PID;

			DataSyncTool.Model.DROPPING_PATENTBILLINPUT model=new DataSyncTool.Model.DROPPING_PATENTBILLINPUT();
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
		public DataSyncTool.Model.DROPPING_PATENTBILLINPUT DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.DROPPING_PATENTBILLINPUT model=new DataSyncTool.Model.DROPPING_PATENTBILLINPUT();
			if (row != null)
			{
				if(row["PID"]!=null)
				{
					model.PID=row["PID"].ToString();
				}
				if(row["NOTENUMBER"]!=null)
				{
					model.NOTENUMBER=row["NOTENUMBER"].ToString();
				}
				if(row["TYPE"]!=null)
				{
					model.TYPE=row["TYPE"].ToString();
				}
				if(row["TEXT"]!=null)
				{
					model.TEXT=row["TEXT"].ToString();
				}
				if(row["QUANTITY"]!=null && row["QUANTITY"].ToString()!="")
				{
					model.QUANTITY=decimal.Parse(row["QUANTITY"].ToString());
				}
				if(row["OFFICIALFEE"]!=null && row["OFFICIALFEE"].ToString()!="")
				{
					model.OFFICIALFEE=decimal.Parse(row["OFFICIALFEE"].ToString());
				}
				if(row["OTHERFEE"]!=null && row["OTHERFEE"].ToString()!="")
				{
					model.OTHERFEE=decimal.Parse(row["OTHERFEE"].ToString());
				}
				if(row["WAIVE"]!=null)
				{
					model.WAIVE=row["WAIVE"].ToString();
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
			strSql.Append("select PID,NOTENUMBER,TYPE,TEXT,QUANTITY,OFFICIALFEE,OTHERFEE,WAIVE ");
			strSql.Append(" FROM DROPPING_PATENTBILLINPUT ");
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
			strSql.Append("select count(1) FROM DROPPING_PATENTBILLINPUT ");
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
			strSql.Append(")AS Row, T.*  from DROPPING_PATENTBILLINPUT T ");
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
			parameters[0].Value = "DROPPING_PATENTBILLINPUT";
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

