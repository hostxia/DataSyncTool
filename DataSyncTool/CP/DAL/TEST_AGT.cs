using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:TEST_AGT
	/// </summary>
	public partial class TEST_AGT
	{
		public TEST_AGT()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.TEST_AGT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TEST_AGT(");
			strSql.Append("AGT_NUMBER,NAME1,NAME2)");
			strSql.Append(" values (");
			strSql.Append(":AGT_NUMBER,:NAME1,:NAME2)");
			OracleParameter[] parameters = {
					new OracleParameter(":AGT_NUMBER", OracleType.VarChar,10),
					new OracleParameter(":NAME1", OracleType.VarChar,400),
					new OracleParameter(":NAME2", OracleType.VarChar,400)};
			parameters[0].Value = model.AGT_NUMBER;
			parameters[1].Value = model.NAME1;
			parameters[2].Value = model.NAME2;

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
		public bool Update(Model.TEST_AGT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TEST_AGT set ");
			strSql.Append("AGT_NUMBER=:AGT_NUMBER,");
			strSql.Append("NAME1=:NAME1,");
			strSql.Append("NAME2=:NAME2");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":AGT_NUMBER", OracleType.VarChar,10),
					new OracleParameter(":NAME1", OracleType.VarChar,400),
					new OracleParameter(":NAME2", OracleType.VarChar,400)};
			parameters[0].Value = model.AGT_NUMBER;
			parameters[1].Value = model.NAME1;
			parameters[2].Value = model.NAME2;

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
			strSql.Append("delete from TEST_AGT ");
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
		public Model.TEST_AGT GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AGT_NUMBER,NAME1,NAME2 from TEST_AGT ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Model.TEST_AGT model=new Model.TEST_AGT();
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
		public Model.TEST_AGT DataRowToModel(DataRow row)
		{
			Model.TEST_AGT model=new Model.TEST_AGT();
			if (row != null)
			{
				if(row["AGT_NUMBER"]!=null)
				{
					model.AGT_NUMBER=row["AGT_NUMBER"].ToString();
				}
				if(row["NAME1"]!=null)
				{
					model.NAME1=row["NAME1"].ToString();
				}
				if(row["NAME2"]!=null)
				{
					model.NAME2=row["NAME2"].ToString();
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
			strSql.Append("select AGT_NUMBER,NAME1,NAME2 ");
			strSql.Append(" FROM TEST_AGT ");
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
			strSql.Append("select count(1) FROM TEST_AGT ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from TEST_AGT T ");
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
			parameters[0].Value = "TEST_AGT";
			parameters[1].Value = "ID";
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

