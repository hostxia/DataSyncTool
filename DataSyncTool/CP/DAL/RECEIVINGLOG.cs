using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:RECEIVINGLOG
	/// </summary>
	public partial class RECEIVINGLOG
	{
		public RECEIVINGLOG()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from RECEIVINGLOG");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,30)			};
			parameters[0].Value = PID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.RECEIVINGLOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into RECEIVINGLOG(");
			strSql.Append("PID,ISSUEDATE,RECEIVED,RECEIVEDBY,SENDERID,SENDER,OURNO,APPNO,CLIENTNO,CONTENT,COPIES,PAGES,HANDLER,COMMENTS,STATUS)");
			strSql.Append(" values (");
			strSql.Append(":PID,:ISSUEDATE,:RECEIVED,:RECEIVEDBY,:SENDERID,:SENDER,:OURNO,:APPNO,:CLIENTNO,:CONTENT,:COPIES,:PAGES,:HANDLER,:COMMENTS,:STATUS)");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,30),
					new OracleParameter(":ISSUEDATE", OracleType.DateTime),
					new OracleParameter(":RECEIVED", OracleType.DateTime),
					new OracleParameter(":RECEIVEDBY", OracleType.VarChar,10),
					new OracleParameter(":SENDERID", OracleType.Char,4),
					new OracleParameter(":SENDER", OracleType.VarChar,100),
					new OracleParameter(":OURNO", OracleType.VarChar,20),
					new OracleParameter(":APPNO", OracleType.VarChar,40),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,40),
					new OracleParameter(":CONTENT", OracleType.VarChar,40),
					new OracleParameter(":COPIES", OracleType.Number,2),
					new OracleParameter(":PAGES", OracleType.Number,3),
					new OracleParameter(":HANDLER", OracleType.VarChar,10),
					new OracleParameter(":COMMENTS", OracleType.VarChar,100),
					new OracleParameter(":STATUS", OracleType.VarChar,5)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.ISSUEDATE;
			parameters[2].Value = model.RECEIVED;
			parameters[3].Value = model.RECEIVEDBY;
			parameters[4].Value = model.SENDERID;
			parameters[5].Value = model.SENDER;
			parameters[6].Value = model.OURNO;
			parameters[7].Value = model.APPNO;
			parameters[8].Value = model.CLIENTNO;
			parameters[9].Value = model.CONTENT;
			parameters[10].Value = model.COPIES;
			parameters[11].Value = model.PAGES;
			parameters[12].Value = model.HANDLER;
			parameters[13].Value = model.COMMENTS;
			parameters[14].Value = model.STATUS;

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
		public bool Update(Model.RECEIVINGLOG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update RECEIVINGLOG set ");
			strSql.Append("PID=:PID,");
			strSql.Append("ISSUEDATE=:ISSUEDATE,");
			strSql.Append("RECEIVED=:RECEIVED,");
			strSql.Append("RECEIVEDBY=:RECEIVEDBY,");
			strSql.Append("SENDERID=:SENDERID,");
			strSql.Append("SENDER=:SENDER,");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("APPNO=:APPNO,");
			strSql.Append("CLIENTNO=:CLIENTNO,");
			strSql.Append("CONTENT=:CONTENT,");
			strSql.Append("COPIES=:COPIES,");
			strSql.Append("PAGES=:PAGES,");
			strSql.Append("HANDLER=:HANDLER,");
			strSql.Append("COMMENTS=:COMMENTS,");
			strSql.Append("STATUS=:STATUS");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,30),
					new OracleParameter(":ISSUEDATE", OracleType.DateTime),
					new OracleParameter(":RECEIVED", OracleType.DateTime),
					new OracleParameter(":RECEIVEDBY", OracleType.VarChar,10),
					new OracleParameter(":SENDERID", OracleType.Char,4),
					new OracleParameter(":SENDER", OracleType.VarChar,100),
					new OracleParameter(":OURNO", OracleType.VarChar,20),
					new OracleParameter(":APPNO", OracleType.VarChar,40),
					new OracleParameter(":CLIENTNO", OracleType.VarChar,40),
					new OracleParameter(":CONTENT", OracleType.VarChar,40),
					new OracleParameter(":COPIES", OracleType.Number,2),
					new OracleParameter(":PAGES", OracleType.Number,3),
					new OracleParameter(":HANDLER", OracleType.VarChar,10),
					new OracleParameter(":COMMENTS", OracleType.VarChar,100),
					new OracleParameter(":STATUS", OracleType.VarChar,5)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.ISSUEDATE;
			parameters[2].Value = model.RECEIVED;
			parameters[3].Value = model.RECEIVEDBY;
			parameters[4].Value = model.SENDERID;
			parameters[5].Value = model.SENDER;
			parameters[6].Value = model.OURNO;
			parameters[7].Value = model.APPNO;
			parameters[8].Value = model.CLIENTNO;
			parameters[9].Value = model.CONTENT;
			parameters[10].Value = model.COPIES;
			parameters[11].Value = model.PAGES;
			parameters[12].Value = model.HANDLER;
			parameters[13].Value = model.COMMENTS;
			parameters[14].Value = model.STATUS;

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
			strSql.Append("delete from RECEIVINGLOG ");
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
			strSql.Append("delete from RECEIVINGLOG ");
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
		public Model.RECEIVINGLOG GetModel(string PID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PID,ISSUEDATE,RECEIVED,RECEIVEDBY,SENDERID,SENDER,OURNO,APPNO,CLIENTNO,CONTENT,COPIES,PAGES,HANDLER,COMMENTS,STATUS from RECEIVINGLOG ");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,30)			};
			parameters[0].Value = PID;

			Model.RECEIVINGLOG model=new Model.RECEIVINGLOG();
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
		public Model.RECEIVINGLOG DataRowToModel(DataRow row)
		{
			Model.RECEIVINGLOG model=new Model.RECEIVINGLOG();
			if (row != null)
			{
				if(row["PID"]!=null)
				{
					model.PID=row["PID"].ToString();
				}
				if(row["ISSUEDATE"]!=null && row["ISSUEDATE"].ToString()!="")
				{
					model.ISSUEDATE=DateTime.Parse(row["ISSUEDATE"].ToString());
				}
				if(row["RECEIVED"]!=null && row["RECEIVED"].ToString()!="")
				{
					model.RECEIVED=DateTime.Parse(row["RECEIVED"].ToString());
				}
				if(row["RECEIVEDBY"]!=null)
				{
					model.RECEIVEDBY=row["RECEIVEDBY"].ToString();
				}
				if(row["SENDERID"]!=null)
				{
					model.SENDERID=row["SENDERID"].ToString();
				}
				if(row["SENDER"]!=null)
				{
					model.SENDER=row["SENDER"].ToString();
				}
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["APPNO"]!=null)
				{
					model.APPNO=row["APPNO"].ToString();
				}
				if(row["CLIENTNO"]!=null)
				{
					model.CLIENTNO=row["CLIENTNO"].ToString();
				}
				if(row["CONTENT"]!=null)
				{
					model.CONTENT=row["CONTENT"].ToString();
				}
				if(row["COPIES"]!=null && row["COPIES"].ToString()!="")
				{
					model.COPIES=decimal.Parse(row["COPIES"].ToString());
				}
				if(row["PAGES"]!=null && row["PAGES"].ToString()!="")
				{
					model.PAGES=decimal.Parse(row["PAGES"].ToString());
				}
				if(row["HANDLER"]!=null)
				{
					model.HANDLER=row["HANDLER"].ToString();
				}
				if(row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
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
			strSql.Append("select PID,ISSUEDATE,RECEIVED,RECEIVEDBY,SENDERID,SENDER,OURNO,APPNO,CLIENTNO,CONTENT,COPIES,PAGES,HANDLER,COMMENTS,STATUS ");
			strSql.Append(" FROM RECEIVINGLOG ");
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
			strSql.Append("select count(1) FROM RECEIVINGLOG ");
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
			strSql.Append(")AS Row, T.*  from RECEIVINGLOG T ");
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
			parameters[0].Value = "RECEIVINGLOG";
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

