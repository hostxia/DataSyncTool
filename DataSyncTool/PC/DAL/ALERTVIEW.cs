using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:ALERTVIEW
	/// </summary>
	public partial class ALERTVIEW
	{
		public ALERTVIEW()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.ALERTVIEW model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ALERTVIEW(");
			strSql.Append("ID,STATUS,ALERTTYPE,CASENO,AGENT,TARGETDATE,TR,DOR,LINENUM)");
			strSql.Append(" values (");
			strSql.Append(":ID,:STATUS,:ALERTTYPE,:CASENO,:AGENT,:TARGETDATE,:TR,:DOR,:LINENUM)");
			OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleType.VarChar,100),
					new OracleParameter(":STATUS", OracleType.Char,1),
					new OracleParameter(":ALERTTYPE", OracleType.VarChar,20),
					new OracleParameter(":CASENO", OracleType.VarChar,40),
					new OracleParameter(":AGENT", OracleType.VarChar,40),
					new OracleParameter(":TARGETDATE", OracleType.DateTime),
					new OracleParameter(":TR", OracleType.VarChar,450),
					new OracleParameter(":DOR", OracleType.Number,6),
					new OracleParameter(":LINENUM", OracleType.Number,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.STATUS;
			parameters[2].Value = model.ALERTTYPE;
			parameters[3].Value = model.CASENO;
			parameters[4].Value = model.AGENT;
			parameters[5].Value = model.TARGETDATE;
			parameters[6].Value = model.TR;
			parameters[7].Value = model.DOR;
			parameters[8].Value = model.LINENUM;

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
		public bool Update(Model.ALERTVIEW model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ALERTVIEW set ");
			strSql.Append("ID=:ID,");
			strSql.Append("STATUS=:STATUS,");
			strSql.Append("ALERTTYPE=:ALERTTYPE,");
			strSql.Append("CASENO=:CASENO,");
			strSql.Append("AGENT=:AGENT,");
			strSql.Append("TARGETDATE=:TARGETDATE,");
			strSql.Append("TR=:TR,");
			strSql.Append("DOR=:DOR,");
			strSql.Append("LINENUM=:LINENUM");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleType.VarChar,100),
					new OracleParameter(":STATUS", OracleType.Char,1),
					new OracleParameter(":ALERTTYPE", OracleType.VarChar,20),
					new OracleParameter(":CASENO", OracleType.VarChar,40),
					new OracleParameter(":AGENT", OracleType.VarChar,40),
					new OracleParameter(":TARGETDATE", OracleType.DateTime),
					new OracleParameter(":TR", OracleType.VarChar,450),
					new OracleParameter(":DOR", OracleType.Number,6),
					new OracleParameter(":LINENUM", OracleType.Number,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.STATUS;
			parameters[2].Value = model.ALERTTYPE;
			parameters[3].Value = model.CASENO;
			parameters[4].Value = model.AGENT;
			parameters[5].Value = model.TARGETDATE;
			parameters[6].Value = model.TR;
			parameters[7].Value = model.DOR;
			parameters[8].Value = model.LINENUM;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ALERTVIEW ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Model.ALERTVIEW GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,STATUS,ALERTTYPE,CASENO,AGENT,TARGETDATE,TR,DOR,LINENUM from ALERTVIEW ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Model.ALERTVIEW model=new Model.ALERTVIEW();
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
		public Model.ALERTVIEW DataRowToModel(DataRow row)
		{
			Model.ALERTVIEW model=new Model.ALERTVIEW();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
				}
				if(row["ALERTTYPE"]!=null)
				{
					model.ALERTTYPE=row["ALERTTYPE"].ToString();
				}
				if(row["CASENO"]!=null)
				{
					model.CASENO=row["CASENO"].ToString();
				}
				if(row["AGENT"]!=null)
				{
					model.AGENT=row["AGENT"].ToString();
				}
				if(row["TARGETDATE"]!=null && row["TARGETDATE"].ToString()!="")
				{
					model.TARGETDATE=DateTime.Parse(row["TARGETDATE"].ToString());
				}
				if(row["TR"]!=null)
				{
					model.TR=row["TR"].ToString();
				}
				if(row["DOR"]!=null && row["DOR"].ToString()!="")
				{
					model.DOR=decimal.Parse(row["DOR"].ToString());
				}
				if(row["LINENUM"]!=null && row["LINENUM"].ToString()!="")
				{
					model.LINENUM=decimal.Parse(row["LINENUM"].ToString());
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
			strSql.Append("select ID,STATUS,ALERTTYPE,CASENO,AGENT,TARGETDATE,TR,DOR,LINENUM ");
			strSql.Append(" FROM ALERTVIEW ");
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
			strSql.Append("select count(1) FROM ALERTVIEW ");
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
				strSql.Append("order by T.GROUPID desc");
			}
			strSql.Append(")AS Row, T.*  from ALERTVIEW T ");
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
			parameters[0].Value = "ALERTVIEW";
			parameters[1].Value = "GROUPID";
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

