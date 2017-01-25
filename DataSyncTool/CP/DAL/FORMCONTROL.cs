using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:FORMCONTROL
	/// </summary>
	public partial class FORMCONTROL
	{
		public FORMCONTROL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.FORMCONTROL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FORMCONTROL(");
			strSql.Append("FORMNAME,USERNAME,CONTROLNAME,INSTRUCTION)");
			strSql.Append(" values (");
			strSql.Append(":FORMNAME,:USERNAME,:CONTROLNAME,:INSTRUCTION)");
			OracleParameter[] parameters = {
					new OracleParameter(":FORMNAME", OracleType.VarChar,50),
					new OracleParameter(":USERNAME", OracleType.VarChar,30),
					new OracleParameter(":CONTROLNAME", OracleType.VarChar,100),
					new OracleParameter(":INSTRUCTION", OracleType.VarChar,40)};
			parameters[0].Value = model.FORMNAME;
			parameters[1].Value = model.USERNAME;
			parameters[2].Value = model.CONTROLNAME;
			parameters[3].Value = model.INSTRUCTION;

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
		public bool Update(Model.FORMCONTROL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FORMCONTROL set ");
			strSql.Append("FORMNAME=:FORMNAME,");
			strSql.Append("USERNAME=:USERNAME,");
			strSql.Append("CONTROLNAME=:CONTROLNAME,");
			strSql.Append("INSTRUCTION=:INSTRUCTION");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":FORMNAME", OracleType.VarChar,50),
					new OracleParameter(":USERNAME", OracleType.VarChar,30),
					new OracleParameter(":CONTROLNAME", OracleType.VarChar,100),
					new OracleParameter(":INSTRUCTION", OracleType.VarChar,40)};
			parameters[0].Value = model.FORMNAME;
			parameters[1].Value = model.USERNAME;
			parameters[2].Value = model.CONTROLNAME;
			parameters[3].Value = model.INSTRUCTION;

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
			strSql.Append("delete from FORMCONTROL ");
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
		public Model.FORMCONTROL GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FORMNAME,USERNAME,CONTROLNAME,INSTRUCTION from FORMCONTROL ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Model.FORMCONTROL model=new Model.FORMCONTROL();
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
		public Model.FORMCONTROL DataRowToModel(DataRow row)
		{
			Model.FORMCONTROL model=new Model.FORMCONTROL();
			if (row != null)
			{
				if(row["FORMNAME"]!=null)
				{
					model.FORMNAME=row["FORMNAME"].ToString();
				}
				if(row["USERNAME"]!=null)
				{
					model.USERNAME=row["USERNAME"].ToString();
				}
				if(row["CONTROLNAME"]!=null)
				{
					model.CONTROLNAME=row["CONTROLNAME"].ToString();
				}
				if(row["INSTRUCTION"]!=null)
				{
					model.INSTRUCTION=row["INSTRUCTION"].ToString();
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
			strSql.Append("select FORMNAME,USERNAME,CONTROLNAME,INSTRUCTION ");
			strSql.Append(" FROM FORMCONTROL ");
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
			strSql.Append("select count(1) FROM FORMCONTROL ");
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
				strSql.Append("order by T.TYPENAME desc");
			}
			strSql.Append(")AS Row, T.*  from FORMCONTROL T ");
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
			parameters[0].Value = "FORMCONTROL";
			parameters[1].Value = "TYPENAME";
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

