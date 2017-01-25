using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:FCASE_WORKLOAD
	/// </summary>
	public partial class FCASE_WORKLOAD
	{
		public FCASE_WORKLOAD()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FCASE_WORKLOAD");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,20)			};
			parameters[0].Value = PID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.FCASE_WORKLOAD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FCASE_WORKLOAD(");
			strSql.Append("PID,OURNO,ITEM,AGENT,UNIT,AMOUNT,LANGUAGE,COMPLETEDATE,ISSUE)");
			strSql.Append(" values (");
			strSql.Append(":PID,:OURNO,:ITEM,:AGENT,:UNIT,:AMOUNT,:LANGUAGE,:COMPLETEDATE,:ISSUE)");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,20),
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":ITEM", OracleType.VarChar,20),
					new OracleParameter(":AGENT", OracleType.Char,3),
					new OracleParameter(":UNIT", OracleType.Char,4),
					new OracleParameter(":AMOUNT", OracleType.Number,10),
					new OracleParameter(":LANGUAGE", OracleType.Char,2),
					new OracleParameter(":COMPLETEDATE", OracleType.DateTime),
					new OracleParameter(":ISSUE", OracleType.Char,1)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.OURNO;
			parameters[2].Value = model.ITEM;
			parameters[3].Value = model.AGENT;
			parameters[4].Value = model.UNIT;
			parameters[5].Value = model.AMOUNT;
			parameters[6].Value = model.LANGUAGE;
			parameters[7].Value = model.COMPLETEDATE;
			parameters[8].Value = model.ISSUE;

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
		public bool Update(DataSyncTool.Model.FCASE_WORKLOAD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FCASE_WORKLOAD set ");
			strSql.Append("PID=:PID,");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("ITEM=:ITEM,");
			strSql.Append("AGENT=:AGENT,");
			strSql.Append("UNIT=:UNIT,");
			strSql.Append("AMOUNT=:AMOUNT,");
			strSql.Append("LANGUAGE=:LANGUAGE,");
			strSql.Append("COMPLETEDATE=:COMPLETEDATE,");
			strSql.Append("ISSUE=:ISSUE");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,20),
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":ITEM", OracleType.VarChar,20),
					new OracleParameter(":AGENT", OracleType.Char,3),
					new OracleParameter(":UNIT", OracleType.Char,4),
					new OracleParameter(":AMOUNT", OracleType.Number,10),
					new OracleParameter(":LANGUAGE", OracleType.Char,2),
					new OracleParameter(":COMPLETEDATE", OracleType.DateTime),
					new OracleParameter(":ISSUE", OracleType.Char,1)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.OURNO;
			parameters[2].Value = model.ITEM;
			parameters[3].Value = model.AGENT;
			parameters[4].Value = model.UNIT;
			parameters[5].Value = model.AMOUNT;
			parameters[6].Value = model.LANGUAGE;
			parameters[7].Value = model.COMPLETEDATE;
			parameters[8].Value = model.ISSUE;

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
			strSql.Append("delete from FCASE_WORKLOAD ");
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
			strSql.Append("delete from FCASE_WORKLOAD ");
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
		public DataSyncTool.Model.FCASE_WORKLOAD GetModel(string PID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PID,OURNO,ITEM,AGENT,UNIT,AMOUNT,LANGUAGE,COMPLETEDATE,ISSUE from FCASE_WORKLOAD ");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,20)			};
			parameters[0].Value = PID;

			DataSyncTool.Model.FCASE_WORKLOAD model=new DataSyncTool.Model.FCASE_WORKLOAD();
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
		public DataSyncTool.Model.FCASE_WORKLOAD DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.FCASE_WORKLOAD model=new DataSyncTool.Model.FCASE_WORKLOAD();
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
				if(row["ITEM"]!=null)
				{
					model.ITEM=row["ITEM"].ToString();
				}
				if(row["AGENT"]!=null)
				{
					model.AGENT=row["AGENT"].ToString();
				}
				if(row["UNIT"]!=null)
				{
					model.UNIT=row["UNIT"].ToString();
				}
				if(row["AMOUNT"]!=null && row["AMOUNT"].ToString()!="")
				{
					model.AMOUNT=decimal.Parse(row["AMOUNT"].ToString());
				}
				if(row["LANGUAGE"]!=null)
				{
					model.LANGUAGE=row["LANGUAGE"].ToString();
				}
				if(row["COMPLETEDATE"]!=null && row["COMPLETEDATE"].ToString()!="")
				{
					model.COMPLETEDATE=DateTime.Parse(row["COMPLETEDATE"].ToString());
				}
				if(row["ISSUE"]!=null)
				{
					model.ISSUE=row["ISSUE"].ToString();
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
			strSql.Append("select PID,OURNO,ITEM,AGENT,UNIT,AMOUNT,LANGUAGE,COMPLETEDATE,ISSUE ");
			strSql.Append(" FROM FCASE_WORKLOAD ");
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
			strSql.Append("select count(1) FROM FCASE_WORKLOAD ");
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
			strSql.Append(")AS Row, T.*  from FCASE_WORKLOAD T ");
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
			parameters[0].Value = "FCASE_WORKLOAD";
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

