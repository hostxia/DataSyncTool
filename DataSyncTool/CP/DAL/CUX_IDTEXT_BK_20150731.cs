using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
	/// <summary>
	/// 数据访问类:CUX_IDTEXT_BK_20150731
	/// </summary>
	public partial class CUX_IDTEXT_BK_20150731
	{
		public CUX_IDTEXT_BK_20150731()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.CUX_IDTEXT_BK_20150731 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CUX_IDTEXT_BK_20150731(");
			strSql.Append("IDGROUP,ID,TEXT,SEQ)");
			strSql.Append(" values (");
			strSql.Append(":IDGROUP,:ID,:TEXT,:SEQ)");
			OracleParameter[] parameters = {
					new OracleParameter(":IDGROUP", OracleType.VarChar,20),
					new OracleParameter(":ID", OracleType.VarChar,70),
					new OracleParameter(":TEXT", OracleType.VarChar,100),
					new OracleParameter(":SEQ", OracleType.Number,2)};
			parameters[0].Value = model.IDGROUP;
			parameters[1].Value = model.ID;
			parameters[2].Value = model.TEXT;
			parameters[3].Value = model.SEQ;

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
		public bool Update(DataSyncTool.Model.CUX_IDTEXT_BK_20150731 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CUX_IDTEXT_BK_20150731 set ");
			strSql.Append("IDGROUP=:IDGROUP,");
			strSql.Append("ID=:ID,");
			strSql.Append("TEXT=:TEXT,");
			strSql.Append("SEQ=:SEQ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":IDGROUP", OracleType.VarChar,20),
					new OracleParameter(":ID", OracleType.VarChar,70),
					new OracleParameter(":TEXT", OracleType.VarChar,100),
					new OracleParameter(":SEQ", OracleType.Number,2)};
			parameters[0].Value = model.IDGROUP;
			parameters[1].Value = model.ID;
			parameters[2].Value = model.TEXT;
			parameters[3].Value = model.SEQ;

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
			strSql.Append("delete from CUX_IDTEXT_BK_20150731 ");
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
		public DataSyncTool.Model.CUX_IDTEXT_BK_20150731 GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select IDGROUP,ID,TEXT,SEQ from CUX_IDTEXT_BK_20150731 ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			DataSyncTool.Model.CUX_IDTEXT_BK_20150731 model=new DataSyncTool.Model.CUX_IDTEXT_BK_20150731();
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
		public DataSyncTool.Model.CUX_IDTEXT_BK_20150731 DataRowToModel(DataRow row)
		{
			DataSyncTool.Model.CUX_IDTEXT_BK_20150731 model=new DataSyncTool.Model.CUX_IDTEXT_BK_20150731();
			if (row != null)
			{
				if(row["IDGROUP"]!=null)
				{
					model.IDGROUP=row["IDGROUP"].ToString();
				}
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["TEXT"]!=null)
				{
					model.TEXT=row["TEXT"].ToString();
				}
				if(row["SEQ"]!=null && row["SEQ"].ToString()!="")
				{
					model.SEQ=decimal.Parse(row["SEQ"].ToString());
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
			strSql.Append("select IDGROUP,ID,TEXT,SEQ ");
			strSql.Append(" FROM CUX_IDTEXT_BK_20150731 ");
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
			strSql.Append("select count(1) FROM CUX_IDTEXT_BK_20150731 ");
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
			strSql.Append(")AS Row, T.*  from CUX_IDTEXT_BK_20150731 T ");
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
			parameters[0].Value = "CUX_IDTEXT_BK_20150731";
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

