using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:GENERALALERT
	/// </summary>
	public partial class GENERALALERT
	{
		public GENERALALERT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(DateTime CREATED)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from GENERALALERT");
			strSql.Append(" where CREATED=:CREATED ");
			OracleParameter[] parameters = {
					new OracleParameter(":CREATED", OracleType.DateTime)			};
			parameters[0].Value = CREATED;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.GENERALALERT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into GENERALALERT(");
			strSql.Append("CREATED,TYPEID,OURNO,ITEMNUMBER,TRIGERDATE1,SUBCOMPLETE1,SUBCOMPLETE2,SUBCOMPLETE3,SUBCOMPLETE4,DUEDATE,COMPLETEDATE,COMMENTS,OATYPE,AGENT,DLTYPE)");
			strSql.Append(" values (");
			strSql.Append(":CREATED,:TYPEID,:OURNO,:ITEMNUMBER,:TRIGERDATE1,:SUBCOMPLETE1,:SUBCOMPLETE2,:SUBCOMPLETE3,:SUBCOMPLETE4,:DUEDATE,:COMPLETEDATE,:COMMENTS,:OATYPE,:AGENT,:DLTYPE)");
			OracleParameter[] parameters = {
					new OracleParameter(":CREATED", OracleType.DateTime),
					new OracleParameter(":TYPEID", OracleType.VarChar,20),
					new OracleParameter(":OURNO", OracleType.VarChar,20),
					new OracleParameter(":ITEMNUMBER", OracleType.Number,4),
					new OracleParameter(":TRIGERDATE1", OracleType.DateTime),
					new OracleParameter(":SUBCOMPLETE1", OracleType.DateTime),
					new OracleParameter(":SUBCOMPLETE2", OracleType.DateTime),
					new OracleParameter(":SUBCOMPLETE3", OracleType.DateTime),
					new OracleParameter(":SUBCOMPLETE4", OracleType.DateTime),
					new OracleParameter(":DUEDATE", OracleType.DateTime),
					new OracleParameter(":COMPLETEDATE", OracleType.DateTime),
					new OracleParameter(":COMMENTS", OracleType.VarChar,600),
					new OracleParameter(":OATYPE", OracleType.VarChar,40),
					new OracleParameter(":AGENT", OracleType.VarChar,20),
					new OracleParameter(":DLTYPE", OracleType.VarChar,10)};
			parameters[0].Value = model.CREATED;
			parameters[1].Value = model.TYPEID;
			parameters[2].Value = model.OURNO;
			parameters[3].Value = model.ITEMNUMBER;
			parameters[4].Value = model.TRIGERDATE1;
			parameters[5].Value = model.SUBCOMPLETE1;
			parameters[6].Value = model.SUBCOMPLETE2;
			parameters[7].Value = model.SUBCOMPLETE3;
			parameters[8].Value = model.SUBCOMPLETE4;
			parameters[9].Value = model.DUEDATE;
			parameters[10].Value = model.COMPLETEDATE;
			parameters[11].Value = model.COMMENTS;
			parameters[12].Value = model.OATYPE;
			parameters[13].Value = model.AGENT;
			parameters[14].Value = model.DLTYPE;

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
		public bool Update(Model.GENERALALERT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update GENERALALERT set ");
			strSql.Append("CREATED=:CREATED,");
			strSql.Append("TYPEID=:TYPEID,");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("ITEMNUMBER=:ITEMNUMBER,");
			strSql.Append("TRIGERDATE1=:TRIGERDATE1,");
			strSql.Append("SUBCOMPLETE1=:SUBCOMPLETE1,");
			strSql.Append("SUBCOMPLETE2=:SUBCOMPLETE2,");
			strSql.Append("SUBCOMPLETE3=:SUBCOMPLETE3,");
			strSql.Append("SUBCOMPLETE4=:SUBCOMPLETE4,");
			strSql.Append("DUEDATE=:DUEDATE,");
			strSql.Append("COMPLETEDATE=:COMPLETEDATE,");
			strSql.Append("COMMENTS=:COMMENTS,");
			strSql.Append("OATYPE=:OATYPE,");
			strSql.Append("AGENT=:AGENT,");
			strSql.Append("DLTYPE=:DLTYPE");
			strSql.Append(" where CREATED=:CREATED ");
			OracleParameter[] parameters = {
					new OracleParameter(":CREATED", OracleType.DateTime),
					new OracleParameter(":TYPEID", OracleType.VarChar,20),
					new OracleParameter(":OURNO", OracleType.VarChar,20),
					new OracleParameter(":ITEMNUMBER", OracleType.Number,4),
					new OracleParameter(":TRIGERDATE1", OracleType.DateTime),
					new OracleParameter(":SUBCOMPLETE1", OracleType.DateTime),
					new OracleParameter(":SUBCOMPLETE2", OracleType.DateTime),
					new OracleParameter(":SUBCOMPLETE3", OracleType.DateTime),
					new OracleParameter(":SUBCOMPLETE4", OracleType.DateTime),
					new OracleParameter(":DUEDATE", OracleType.DateTime),
					new OracleParameter(":COMPLETEDATE", OracleType.DateTime),
					new OracleParameter(":COMMENTS", OracleType.VarChar,600),
					new OracleParameter(":OATYPE", OracleType.VarChar,40),
					new OracleParameter(":AGENT", OracleType.VarChar,20),
					new OracleParameter(":DLTYPE", OracleType.VarChar,10)};
			parameters[0].Value = model.CREATED;
			parameters[1].Value = model.TYPEID;
			parameters[2].Value = model.OURNO;
			parameters[3].Value = model.ITEMNUMBER;
			parameters[4].Value = model.TRIGERDATE1;
			parameters[5].Value = model.SUBCOMPLETE1;
			parameters[6].Value = model.SUBCOMPLETE2;
			parameters[7].Value = model.SUBCOMPLETE3;
			parameters[8].Value = model.SUBCOMPLETE4;
			parameters[9].Value = model.DUEDATE;
			parameters[10].Value = model.COMPLETEDATE;
			parameters[11].Value = model.COMMENTS;
			parameters[12].Value = model.OATYPE;
			parameters[13].Value = model.AGENT;
			parameters[14].Value = model.DLTYPE;

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
		public bool Delete(DateTime CREATED)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GENERALALERT ");
			strSql.Append(" where CREATED=:CREATED ");
			OracleParameter[] parameters = {
					new OracleParameter(":CREATED", OracleType.DateTime)			};
			parameters[0].Value = CREATED;

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
		public bool DeleteList(string CREATEDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GENERALALERT ");
			strSql.Append(" where CREATED in ("+CREATEDlist + ")  ");
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
		public Model.GENERALALERT GetModel(DateTime CREATED)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CREATED,TYPEID,OURNO,ITEMNUMBER,TRIGERDATE1,SUBCOMPLETE1,SUBCOMPLETE2,SUBCOMPLETE3,SUBCOMPLETE4,DUEDATE,COMPLETEDATE,COMMENTS,OATYPE,AGENT,DLTYPE from GENERALALERT ");
			strSql.Append(" where CREATED=:CREATED ");
			OracleParameter[] parameters = {
					new OracleParameter(":CREATED", OracleType.DateTime)			};
			parameters[0].Value = CREATED;

			Model.GENERALALERT model=new Model.GENERALALERT();
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
		public Model.GENERALALERT DataRowToModel(DataRow row)
		{
			Model.GENERALALERT model=new Model.GENERALALERT();
			if (row != null)
			{
				if(row["CREATED"]!=null && row["CREATED"].ToString()!="")
				{
					model.CREATED=DateTime.Parse(row["CREATED"].ToString());
				}
				if(row["TYPEID"]!=null)
				{
					model.TYPEID=row["TYPEID"].ToString();
				}
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["ITEMNUMBER"]!=null && row["ITEMNUMBER"].ToString()!="")
				{
					model.ITEMNUMBER=decimal.Parse(row["ITEMNUMBER"].ToString());
				}
				if(row["TRIGERDATE1"]!=null && row["TRIGERDATE1"].ToString()!="")
				{
					model.TRIGERDATE1=DateTime.Parse(row["TRIGERDATE1"].ToString());
				}
				if(row["SUBCOMPLETE1"]!=null && row["SUBCOMPLETE1"].ToString()!="")
				{
					model.SUBCOMPLETE1=DateTime.Parse(row["SUBCOMPLETE1"].ToString());
				}
				if(row["SUBCOMPLETE2"]!=null && row["SUBCOMPLETE2"].ToString()!="")
				{
					model.SUBCOMPLETE2=DateTime.Parse(row["SUBCOMPLETE2"].ToString());
				}
				if(row["SUBCOMPLETE3"]!=null && row["SUBCOMPLETE3"].ToString()!="")
				{
					model.SUBCOMPLETE3=DateTime.Parse(row["SUBCOMPLETE3"].ToString());
				}
				if(row["SUBCOMPLETE4"]!=null && row["SUBCOMPLETE4"].ToString()!="")
				{
					model.SUBCOMPLETE4=DateTime.Parse(row["SUBCOMPLETE4"].ToString());
				}
				if(row["DUEDATE"]!=null && row["DUEDATE"].ToString()!="")
				{
					model.DUEDATE=DateTime.Parse(row["DUEDATE"].ToString());
				}
				if(row["COMPLETEDATE"]!=null && row["COMPLETEDATE"].ToString()!="")
				{
					model.COMPLETEDATE=DateTime.Parse(row["COMPLETEDATE"].ToString());
				}
				if(row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
				}
				if(row["OATYPE"]!=null)
				{
					model.OATYPE=row["OATYPE"].ToString();
				}
				if(row["AGENT"]!=null)
				{
					model.AGENT=row["AGENT"].ToString();
				}
				if(row["DLTYPE"]!=null)
				{
					model.DLTYPE=row["DLTYPE"].ToString();
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
			strSql.Append("select CREATED,TYPEID,OURNO,ITEMNUMBER,TRIGERDATE1,SUBCOMPLETE1,SUBCOMPLETE2,SUBCOMPLETE3,SUBCOMPLETE4,DUEDATE,COMPLETEDATE,COMMENTS,OATYPE,AGENT,DLTYPE ");
			strSql.Append(" FROM GENERALALERT ");
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
			strSql.Append("select count(1) FROM GENERALALERT ");
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
				strSql.Append("order by T.CREATED desc");
			}
			strSql.Append(")AS Row, T.*  from GENERALALERT T ");
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
			parameters[0].Value = "GENERALALERT";
			parameters[1].Value = "CREATED";
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

