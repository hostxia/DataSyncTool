using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace DataSyncTool.DAL
{
    /// <summary>
    /// 数据访问类:CASEOTHERTEXT
    /// </summary>
    public partial class CASEOTHERTEXT
    {
        public CASEOTHERTEXT()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string CASENO, string INFOTYPE)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CASEOTHERTEXT");
            strSql.Append(" where CASENO=:CASENO and INFOTYPE=:INFOTYPE ");
            OracleParameter[] parameters = {
                    new OracleParameter(":CASENO", OracleType.VarChar,20),
                    new OracleParameter(":INFOTYPE", OracleType.VarChar,10)         };
            parameters[0].Value = CASENO;
            parameters[1].Value = INFOTYPE;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(DataSyncTool.Model.CASEOTHERTEXT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CASEOTHERTEXT(");
            strSql.Append("CASENO,INFOTYPE,INFO)");
            strSql.Append(" values (");
            strSql.Append(":CASENO,:INFOTYPE,:INFO)");
            OracleParameter[] parameters = {
                    new OracleParameter(":CASENO", OracleType.VarChar,20),
                    new OracleParameter(":INFOTYPE", OracleType.VarChar,10),
                    new OracleParameter(":INFO", OracleType.Clob,4000)};
            parameters[0].Value = model.CASENO;
            parameters[1].Value = model.INFOTYPE;
            parameters[2].Value = model.INFO;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(DataSyncTool.Model.CASEOTHERTEXT model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CASEOTHERTEXT set ");
            strSql.Append("CASENO=:CASENO,");
            strSql.Append("INFOTYPE=:INFOTYPE,");
            strSql.Append("INFO=:INFO");
            strSql.Append(" where CASENO=:CASENO and INFOTYPE=:INFOTYPE ");
            OracleParameter[] parameters = {
                    new OracleParameter(":CASENO", OracleType.VarChar,20),
                    new OracleParameter(":INFOTYPE", OracleType.VarChar,10),
                    new OracleParameter(":INFO", OracleType.Clob,4000)};
            parameters[0].Value = model.CASENO;
            parameters[1].Value = model.INFOTYPE;
            parameters[2].Value = model.INFO;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(string CASENO, string INFOTYPE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CASEOTHERTEXT ");
            strSql.Append(" where CASENO=:CASENO and INFOTYPE=:INFOTYPE ");
            OracleParameter[] parameters = {
                    new OracleParameter(":CASENO", OracleType.VarChar,20),
                    new OracleParameter(":INFOTYPE", OracleType.VarChar,10)         };
            parameters[0].Value = CASENO;
            parameters[1].Value = INFOTYPE;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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
        public DataSyncTool.Model.CASEOTHERTEXT GetModel(string CASENO, string INFOTYPE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CASENO,INFOTYPE,INFO from CASEOTHERTEXT ");
            strSql.Append(" where CASENO=:CASENO and INFOTYPE=:INFOTYPE ");
            OracleParameter[] parameters = {
                    new OracleParameter(":CASENO", OracleType.VarChar,20),
                    new OracleParameter(":INFOTYPE", OracleType.VarChar,10)         };
            parameters[0].Value = CASENO;
            parameters[1].Value = INFOTYPE;

            DataSyncTool.Model.CASEOTHERTEXT model = new DataSyncTool.Model.CASEOTHERTEXT();
            DataSet ds = DbHelperOra.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public DataSyncTool.Model.CASEOTHERTEXT DataRowToModel(DataRow row)
        {
            DataSyncTool.Model.CASEOTHERTEXT model = new DataSyncTool.Model.CASEOTHERTEXT();
            if (row != null)
            {
                if (row["CASENO"] != null)
                {
                    model.CASENO = row["CASENO"].ToString();
                }
                if (row["INFOTYPE"] != null)
                {
                    model.INFOTYPE = row["INFOTYPE"].ToString();
                }
                if (row["INFO"] != null)
                {
                    model.INFO = row["INFO"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CASENO,INFOTYPE,INFO ");
            strSql.Append(" FROM CASEOTHERTEXT ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM CASEOTHERTEXT ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.INFOTYPE desc");
            }
            strSql.Append(")AS Row, T.*  from CASEOTHERTEXT T ");
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
			parameters[0].Value = "CASEOTHERTEXT";
			parameters[1].Value = "INFOTYPE";
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

