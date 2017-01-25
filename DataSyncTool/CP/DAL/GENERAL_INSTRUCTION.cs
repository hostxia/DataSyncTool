using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:GENERAL_INSTRUCTION
	/// </summary>
	public partial class GENERAL_INSTRUCTION
	{
		public GENERAL_INSTRUCTION()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from GENERAL_INSTRUCTION");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,40)			};
			parameters[0].Value = PID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.GENERAL_INSTRUCTION model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into GENERAL_INSTRUCTION(");
			strSql.Append("PID,CLIENT_NO,RECEIVED,RECEIVED_BY,RELATES_TO,CONTENT_CN,CONTENT_ORIGIN,INSTRUCTOR,STATUS,EXPIRE_DATE,COMMENTS)");
			strSql.Append(" values (");
			strSql.Append(":PID,:CLIENT_NO,:RECEIVED,:RECEIVED_BY,:RELATES_TO,:CONTENT_CN,:CONTENT_ORIGIN,:INSTRUCTOR,:STATUS,:EXPIRE_DATE,:COMMENTS)");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,40),
					new OracleParameter(":CLIENT_NO", OracleType.VarChar,10),
					new OracleParameter(":RECEIVED", OracleType.DateTime),
					new OracleParameter(":RECEIVED_BY", OracleType.VarChar,20),
					new OracleParameter(":RELATES_TO", OracleType.VarChar,30),
					new OracleParameter(":CONTENT_CN", OracleType.VarChar,2000),
					new OracleParameter(":CONTENT_ORIGIN", OracleType.VarChar,2000),
					new OracleParameter(":INSTRUCTOR", OracleType.VarChar,300),
					new OracleParameter(":STATUS", OracleType.VarChar,20),
					new OracleParameter(":EXPIRE_DATE", OracleType.DateTime),
					new OracleParameter(":COMMENTS", OracleType.VarChar,4000)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.CLIENT_NO;
			parameters[2].Value = model.RECEIVED;
			parameters[3].Value = model.RECEIVED_BY;
			parameters[4].Value = model.RELATES_TO;
			parameters[5].Value = model.CONTENT_CN;
			parameters[6].Value = model.CONTENT_ORIGIN;
			parameters[7].Value = model.INSTRUCTOR;
			parameters[8].Value = model.STATUS;
			parameters[9].Value = model.EXPIRE_DATE;
			parameters[10].Value = model.COMMENTS;

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
		public bool Update(DataSyncTool.Model.GENERAL_INSTRUCTION model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update GENERAL_INSTRUCTION set ");
			strSql.Append("PID=:PID,");
			strSql.Append("CLIENT_NO=:CLIENT_NO,");
			strSql.Append("RECEIVED=:RECEIVED,");
			strSql.Append("RECEIVED_BY=:RECEIVED_BY,");
			strSql.Append("RELATES_TO=:RELATES_TO,");
			strSql.Append("CONTENT_CN=:CONTENT_CN,");
			strSql.Append("CONTENT_ORIGIN=:CONTENT_ORIGIN,");
			strSql.Append("INSTRUCTOR=:INSTRUCTOR,");
			strSql.Append("STATUS=:STATUS,");
			strSql.Append("EXPIRE_DATE=:EXPIRE_DATE,");
			strSql.Append("COMMENTS=:COMMENTS");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,40),
					new OracleParameter(":CLIENT_NO", OracleType.VarChar,10),
					new OracleParameter(":RECEIVED", OracleType.DateTime),
					new OracleParameter(":RECEIVED_BY", OracleType.VarChar,20),
					new OracleParameter(":RELATES_TO", OracleType.VarChar,30),
					new OracleParameter(":CONTENT_CN", OracleType.VarChar,2000),
					new OracleParameter(":CONTENT_ORIGIN", OracleType.VarChar,2000),
					new OracleParameter(":INSTRUCTOR", OracleType.VarChar,300),
					new OracleParameter(":STATUS", OracleType.VarChar,20),
					new OracleParameter(":EXPIRE_DATE", OracleType.DateTime),
					new OracleParameter(":COMMENTS", OracleType.VarChar,4000)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.CLIENT_NO;
			parameters[2].Value = model.RECEIVED;
			parameters[3].Value = model.RECEIVED_BY;
			parameters[4].Value = model.RELATES_TO;
			parameters[5].Value = model.CONTENT_CN;
			parameters[6].Value = model.CONTENT_ORIGIN;
			parameters[7].Value = model.INSTRUCTOR;
			parameters[8].Value = model.STATUS;
			parameters[9].Value = model.EXPIRE_DATE;
			parameters[10].Value = model.COMMENTS;

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
			strSql.Append("delete from GENERAL_INSTRUCTION ");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,40)			};
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
			strSql.Append("delete from GENERAL_INSTRUCTION ");
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
		public DataSyncTool.Model.GENERAL_INSTRUCTION GetModel(string PID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PID,CLIENT_NO,RECEIVED,RECEIVED_BY,RELATES_TO,CONTENT_CN,CONTENT_ORIGIN,INSTRUCTOR,STATUS,EXPIRE_DATE,COMMENTS from GENERAL_INSTRUCTION ");
			strSql.Append(" where PID=:PID ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,40)			};
			parameters[0].Value = PID;

			DataSyncTool.Model.GENERAL_INSTRUCTION model=new DataSyncTool.Model.GENERAL_INSTRUCTION();
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
		public DataSyncTool.Model.GENERAL_INSTRUCTION DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.GENERAL_INSTRUCTION model=new DataSyncTool.Model.GENERAL_INSTRUCTION();
			if (row != null)
			{
				if(row["PID"]!=null)
				{
					model.PID=row["PID"].ToString();
				}
				if(row["CLIENT_NO"]!=null)
				{
					model.CLIENT_NO=row["CLIENT_NO"].ToString();
				}
				if(row["RECEIVED"]!=null && row["RECEIVED"].ToString()!="")
				{
					model.RECEIVED=DateTime.Parse(row["RECEIVED"].ToString());
				}
				if(row["RECEIVED_BY"]!=null)
				{
					model.RECEIVED_BY=row["RECEIVED_BY"].ToString();
				}
				if(row["RELATES_TO"]!=null)
				{
					model.RELATES_TO=row["RELATES_TO"].ToString();
				}
				if(row["CONTENT_CN"]!=null)
				{
					model.CONTENT_CN=row["CONTENT_CN"].ToString();
				}
				if(row["CONTENT_ORIGIN"]!=null)
				{
					model.CONTENT_ORIGIN=row["CONTENT_ORIGIN"].ToString();
				}
				if(row["INSTRUCTOR"]!=null)
				{
					model.INSTRUCTOR=row["INSTRUCTOR"].ToString();
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
				}
				if(row["EXPIRE_DATE"]!=null && row["EXPIRE_DATE"].ToString()!="")
				{
					model.EXPIRE_DATE=DateTime.Parse(row["EXPIRE_DATE"].ToString());
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
			strSql.Append("select PID,CLIENT_NO,RECEIVED,RECEIVED_BY,RELATES_TO,CONTENT_CN,CONTENT_ORIGIN,INSTRUCTOR,STATUS,EXPIRE_DATE,COMMENTS ");
			strSql.Append(" FROM GENERAL_INSTRUCTION ");
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
			strSql.Append("select count(1) FROM GENERAL_INSTRUCTION ");
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
			strSql.Append(")AS Row, T.*  from GENERAL_INSTRUCTION T ");
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
			parameters[0].Value = "GENERAL_INSTRUCTION";
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

