using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:JOBTRACKING
	/// </summary>
	public partial class JOBTRACKING
	{
		public JOBTRACKING()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from JOBTRACKING");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,50)			};
			parameters[0].Value = PID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.JOBTRACKING model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into JOBTRACKING(");
			strSql.Append("OURNO,PID,WORKERREF,JOBTYPE,AMOUNT,WORKERID,WORKERIDL2,ENTRUSTDATE,DUEDATE,COMPLETEDATE,SCORE,COMMENTS,ASSESSOR)");
			strSql.Append(" values (");
			strSql.Append(":OURNO,:PID,:WORKERREF,:JOBTYPE,:AMOUNT,:WORKERID,:WORKERIDL2,:ENTRUSTDATE,:DUEDATE,:COMPLETEDATE,:SCORE,:COMMENTS,:ASSESSOR)");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,20),
					new OracleParameter(":PID", OracleType.VarChar,50),
					new OracleParameter(":WORKERREF", OracleType.VarChar,20),
					new OracleParameter(":JOBTYPE", OracleType.VarChar,20),
					new OracleParameter(":AMOUNT", OracleType.Number,4),
					new OracleParameter(":WORKERID", OracleType.VarChar,10),
					new OracleParameter(":WORKERIDL2", OracleType.VarChar,10),
					new OracleParameter(":ENTRUSTDATE", OracleType.DateTime),
					new OracleParameter(":DUEDATE", OracleType.DateTime),
					new OracleParameter(":COMPLETEDATE", OracleType.DateTime),
					new OracleParameter(":SCORE", OracleType.Number,4),
					new OracleParameter(":COMMENTS", OracleType.VarChar,2000),
					new OracleParameter(":ASSESSOR", OracleType.VarChar,20)};
			parameters[0].Value = model.OURNO;
			parameters[1].Value = model.PID;
			parameters[2].Value = model.WORKERREF;
			parameters[3].Value = model.JOBTYPE;
			parameters[4].Value = model.AMOUNT;
			parameters[5].Value = model.WORKERID;
			parameters[6].Value = model.WORKERIDL2;
			parameters[7].Value = model.ENTRUSTDATE;
			parameters[8].Value = model.DUEDATE;
			parameters[9].Value = model.COMPLETEDATE;
			parameters[10].Value = model.SCORE;
			parameters[11].Value = model.COMMENTS;
			parameters[12].Value = model.ASSESSOR;

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
		public bool Update(DataSyncTool.Model.JOBTRACKING model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update JOBTRACKING set ");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("PID=:PID,");
			strSql.Append("WORKERREF=:WORKERREF,");
			strSql.Append("JOBTYPE=:JOBTYPE,");
			strSql.Append("AMOUNT=:AMOUNT,");
			strSql.Append("WORKERID=:WORKERID,");
			strSql.Append("WORKERIDL2=:WORKERIDL2,");
			strSql.Append("ENTRUSTDATE=:ENTRUSTDATE,");
			strSql.Append("DUEDATE=:DUEDATE,");
			strSql.Append("COMPLETEDATE=:COMPLETEDATE,");
			strSql.Append("SCORE=:SCORE,");
			strSql.Append("COMMENTS=:COMMENTS,");
			strSql.Append("ASSESSOR=:ASSESSOR");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,20),
					new OracleParameter(":PID", OracleType.VarChar,50),
					new OracleParameter(":WORKERREF", OracleType.VarChar,20),
					new OracleParameter(":JOBTYPE", OracleType.VarChar,20),
					new OracleParameter(":AMOUNT", OracleType.Number,4),
					new OracleParameter(":WORKERID", OracleType.VarChar,10),
					new OracleParameter(":WORKERIDL2", OracleType.VarChar,10),
					new OracleParameter(":ENTRUSTDATE", OracleType.DateTime),
					new OracleParameter(":DUEDATE", OracleType.DateTime),
					new OracleParameter(":COMPLETEDATE", OracleType.DateTime),
					new OracleParameter(":SCORE", OracleType.Number,4),
					new OracleParameter(":COMMENTS", OracleType.VarChar,2000),
					new OracleParameter(":ASSESSOR", OracleType.VarChar,20)};
			parameters[0].Value = model.OURNO;
			parameters[1].Value = model.PID;
			parameters[2].Value = model.WORKERREF;
			parameters[3].Value = model.JOBTYPE;
			parameters[4].Value = model.AMOUNT;
			parameters[5].Value = model.WORKERID;
			parameters[6].Value = model.WORKERIDL2;
			parameters[7].Value = model.ENTRUSTDATE;
			parameters[8].Value = model.DUEDATE;
			parameters[9].Value = model.COMPLETEDATE;
			parameters[10].Value = model.SCORE;
			parameters[11].Value = model.COMMENTS;
			parameters[12].Value = model.ASSESSOR;

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
			strSql.Append("delete from JOBTRACKING ");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,50)			};
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
			strSql.Append("delete from JOBTRACKING ");
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
		public DataSyncTool.Model.JOBTRACKING GetModel(string PID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OURNO,PID,WORKERREF,JOBTYPE,AMOUNT,WORKERID,WORKERIDL2,ENTRUSTDATE,DUEDATE,COMPLETEDATE,SCORE,COMMENTS,ASSESSOR from JOBTRACKING ");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,50)			};
			parameters[0].Value = PID;

			DataSyncTool.Model.JOBTRACKING model=new DataSyncTool.Model.JOBTRACKING();
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
		public DataSyncTool.Model.JOBTRACKING DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.JOBTRACKING model=new DataSyncTool.Model.JOBTRACKING();
			if (row != null)
			{
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["PID"]!=null)
				{
					model.PID=row["PID"].ToString();
				}
				if(row["WORKERREF"]!=null)
				{
					model.WORKERREF=row["WORKERREF"].ToString();
				}
				if(row["JOBTYPE"]!=null)
				{
					model.JOBTYPE=row["JOBTYPE"].ToString();
				}
				if(row["AMOUNT"]!=null && row["AMOUNT"].ToString()!="")
				{
					model.AMOUNT=decimal.Parse(row["AMOUNT"].ToString());
				}
				if(row["WORKERID"]!=null)
				{
					model.WORKERID=row["WORKERID"].ToString();
				}
				if(row["WORKERIDL2"]!=null)
				{
					model.WORKERIDL2=row["WORKERIDL2"].ToString();
				}
				if(row["ENTRUSTDATE"]!=null && row["ENTRUSTDATE"].ToString()!="")
				{
					model.ENTRUSTDATE=DateTime.Parse(row["ENTRUSTDATE"].ToString());
				}
				if(row["DUEDATE"]!=null && row["DUEDATE"].ToString()!="")
				{
					model.DUEDATE=DateTime.Parse(row["DUEDATE"].ToString());
				}
				if(row["COMPLETEDATE"]!=null && row["COMPLETEDATE"].ToString()!="")
				{
					model.COMPLETEDATE=DateTime.Parse(row["COMPLETEDATE"].ToString());
				}
				if(row["SCORE"]!=null && row["SCORE"].ToString()!="")
				{
					model.SCORE=decimal.Parse(row["SCORE"].ToString());
				}
				if(row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
				}
				if(row["ASSESSOR"]!=null)
				{
					model.ASSESSOR=row["ASSESSOR"].ToString();
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
			strSql.Append("select OURNO,PID,WORKERREF,JOBTYPE,AMOUNT,WORKERID,WORKERIDL2,ENTRUSTDATE,DUEDATE,COMPLETEDATE,SCORE,COMMENTS,ASSESSOR ");
			strSql.Append(" FROM JOBTRACKING ");
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
			strSql.Append("select count(1) FROM JOBTRACKING ");
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
			strSql.Append(")AS Row, T.*  from JOBTRACKING T ");
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
			parameters[0].Value = "JOBTRACKING";
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

