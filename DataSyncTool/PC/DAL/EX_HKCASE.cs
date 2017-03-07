using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:EX_HKCASE
	/// </summary>
	public partial class EX_HKCASE
	{
		public EX_HKCASE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string HK_APP_REF)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from EX_HKCASE");
			strSql.Append(" where HK_APP_REF=:HK_APP_REF ");
			OracleParameter[] parameters = {
					new OracleParameter(":HK_APP_REF", OracleType.VarChar,30)			};
			parameters[0].Value = HK_APP_REF;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.EX_HKCASE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into EX_HKCASE(");
			strSql.Append("HK_APP_REF,HK_APP_NO,HK_PUB_NO,HK_REG1_DATE,HK_PUB1_DATE,MAINTENANCE_DUEDATE,HK_REG2_DATE,NEXT_RENEWAL_DUEDATE,CN_APP_REF,CN_APP_NO,CN_APP_DATE,P4_SENDING_DATE,FIRST_AGENCY_REPORT,TO_PUB,P5_SENDING_DATE,SECOND_AGENCY_REPORT,TO_GRANT,COMMENTS,CLIENT_REF,CLIENT,HK_ANNO_NO,HK_GAZETTE,PARENT_COUNTRY,RECEIVED,ABANDON,PRIORITY,SENDADDRESS,ADDRCHECK,APPLICANT)");
			strSql.Append(" values (");
			strSql.Append(":HK_APP_REF,:HK_APP_NO,:HK_PUB_NO,:HK_REG1_DATE,:HK_PUB1_DATE,:MAINTENANCE_DUEDATE,:HK_REG2_DATE,:NEXT_RENEWAL_DUEDATE,:CN_APP_REF,:CN_APP_NO,:CN_APP_DATE,:P4_SENDING_DATE,:FIRST_AGENCY_REPORT,:TO_PUB,:P5_SENDING_DATE,:SECOND_AGENCY_REPORT,:TO_GRANT,:COMMENTS,:CLIENT_REF,:CLIENT,:HK_ANNO_NO,:HK_GAZETTE,:PARENT_COUNTRY,:RECEIVED,:ABANDON,:PRIORITY,:SENDADDRESS,:ADDRCHECK,:APPLICANT)");
			OracleParameter[] parameters = {
					new OracleParameter(":HK_APP_REF", OracleType.VarChar,30),
					new OracleParameter(":HK_APP_NO", OracleType.VarChar,50),
					new OracleParameter(":HK_PUB_NO", OracleType.VarChar,50),
					new OracleParameter(":HK_REG1_DATE", OracleType.DateTime),
					new OracleParameter(":HK_PUB1_DATE", OracleType.DateTime),
					new OracleParameter(":MAINTENANCE_DUEDATE", OracleType.DateTime),
					new OracleParameter(":HK_REG2_DATE", OracleType.DateTime),
					new OracleParameter(":NEXT_RENEWAL_DUEDATE", OracleType.DateTime),
					new OracleParameter(":CN_APP_REF", OracleType.VarChar,30),
					new OracleParameter(":CN_APP_NO", OracleType.VarChar,30),
					new OracleParameter(":CN_APP_DATE", OracleType.DateTime),
					new OracleParameter(":P4_SENDING_DATE", OracleType.DateTime),
					new OracleParameter(":FIRST_AGENCY_REPORT", OracleType.DateTime),
					new OracleParameter(":TO_PUB", OracleType.DateTime),
					new OracleParameter(":P5_SENDING_DATE", OracleType.DateTime),
					new OracleParameter(":SECOND_AGENCY_REPORT", OracleType.DateTime),
					new OracleParameter(":TO_GRANT", OracleType.DateTime),
					new OracleParameter(":COMMENTS", OracleType.VarChar,1200),
					new OracleParameter(":CLIENT_REF", OracleType.VarChar,80),
					new OracleParameter(":CLIENT", OracleType.VarChar,500),
					new OracleParameter(":HK_ANNO_NO", OracleType.VarChar,50),
					new OracleParameter(":HK_GAZETTE", OracleType.DateTime),
					new OracleParameter(":PARENT_COUNTRY", OracleType.VarChar,10),
					new OracleParameter(":RECEIVED", OracleType.DateTime),
					new OracleParameter(":ABANDON", OracleType.Char,2),
					new OracleParameter(":PRIORITY", OracleType.DateTime),
					new OracleParameter(":SENDADDRESS", OracleType.VarChar,600),
					new OracleParameter(":ADDRCHECK", OracleType.Char,2),
					new OracleParameter(":APPLICANT", OracleType.VarChar,100)};
			parameters[0].Value = model.HK_APP_REF;
			parameters[1].Value = model.HK_APP_NO;
			parameters[2].Value = model.HK_PUB_NO;
			parameters[3].Value = model.HK_REG1_DATE;
			parameters[4].Value = model.HK_PUB1_DATE;
			parameters[5].Value = model.MAINTENANCE_DUEDATE;
			parameters[6].Value = model.HK_REG2_DATE;
			parameters[7].Value = model.NEXT_RENEWAL_DUEDATE;
			parameters[8].Value = model.CN_APP_REF;
			parameters[9].Value = model.CN_APP_NO;
			parameters[10].Value = model.CN_APP_DATE;
			parameters[11].Value = model.P4_SENDING_DATE;
			parameters[12].Value = model.FIRST_AGENCY_REPORT;
			parameters[13].Value = model.TO_PUB;
			parameters[14].Value = model.P5_SENDING_DATE;
			parameters[15].Value = model.SECOND_AGENCY_REPORT;
			parameters[16].Value = model.TO_GRANT;
			parameters[17].Value = model.COMMENTS;
			parameters[18].Value = model.CLIENT_REF;
			parameters[19].Value = model.CLIENT;
			parameters[20].Value = model.HK_ANNO_NO;
			parameters[21].Value = model.HK_GAZETTE;
			parameters[22].Value = model.PARENT_COUNTRY;
			parameters[23].Value = model.RECEIVED;
			parameters[24].Value = model.ABANDON;
			parameters[25].Value = model.PRIORITY;
			parameters[26].Value = model.SENDADDRESS;
			parameters[27].Value = model.ADDRCHECK;
			parameters[28].Value = model.APPLICANT;

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
		public bool Update(Model.EX_HKCASE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update EX_HKCASE set ");
			strSql.Append("HK_APP_REF=:HK_APP_REF,");
			strSql.Append("HK_APP_NO=:HK_APP_NO,");
			strSql.Append("HK_PUB_NO=:HK_PUB_NO,");
			strSql.Append("HK_REG1_DATE=:HK_REG1_DATE,");
			strSql.Append("HK_PUB1_DATE=:HK_PUB1_DATE,");
			strSql.Append("MAINTENANCE_DUEDATE=:MAINTENANCE_DUEDATE,");
			strSql.Append("HK_REG2_DATE=:HK_REG2_DATE,");
			strSql.Append("NEXT_RENEWAL_DUEDATE=:NEXT_RENEWAL_DUEDATE,");
			strSql.Append("CN_APP_REF=:CN_APP_REF,");
			strSql.Append("CN_APP_NO=:CN_APP_NO,");
			strSql.Append("CN_APP_DATE=:CN_APP_DATE,");
			strSql.Append("P4_SENDING_DATE=:P4_SENDING_DATE,");
			strSql.Append("FIRST_AGENCY_REPORT=:FIRST_AGENCY_REPORT,");
			strSql.Append("TO_PUB=:TO_PUB,");
			strSql.Append("P5_SENDING_DATE=:P5_SENDING_DATE,");
			strSql.Append("SECOND_AGENCY_REPORT=:SECOND_AGENCY_REPORT,");
			strSql.Append("TO_GRANT=:TO_GRANT,");
			strSql.Append("COMMENTS=:COMMENTS,");
			strSql.Append("CLIENT_REF=:CLIENT_REF,");
			strSql.Append("CLIENT=:CLIENT,");
			strSql.Append("HK_ANNO_NO=:HK_ANNO_NO,");
			strSql.Append("HK_GAZETTE=:HK_GAZETTE,");
			strSql.Append("PARENT_COUNTRY=:PARENT_COUNTRY,");
			strSql.Append("RECEIVED=:RECEIVED,");
			strSql.Append("ABANDON=:ABANDON,");
			strSql.Append("PRIORITY=:PRIORITY,");
			strSql.Append("SENDADDRESS=:SENDADDRESS,");
			strSql.Append("ADDRCHECK=:ADDRCHECK,");
			strSql.Append("APPLICANT=:APPLICANT");
			strSql.Append(" where HK_APP_REF=:HK_APP_REF ");
			OracleParameter[] parameters = {
					new OracleParameter(":HK_APP_REF", OracleType.VarChar,30),
					new OracleParameter(":HK_APP_NO", OracleType.VarChar,50),
					new OracleParameter(":HK_PUB_NO", OracleType.VarChar,50),
					new OracleParameter(":HK_REG1_DATE", OracleType.DateTime),
					new OracleParameter(":HK_PUB1_DATE", OracleType.DateTime),
					new OracleParameter(":MAINTENANCE_DUEDATE", OracleType.DateTime),
					new OracleParameter(":HK_REG2_DATE", OracleType.DateTime),
					new OracleParameter(":NEXT_RENEWAL_DUEDATE", OracleType.DateTime),
					new OracleParameter(":CN_APP_REF", OracleType.VarChar,30),
					new OracleParameter(":CN_APP_NO", OracleType.VarChar,30),
					new OracleParameter(":CN_APP_DATE", OracleType.DateTime),
					new OracleParameter(":P4_SENDING_DATE", OracleType.DateTime),
					new OracleParameter(":FIRST_AGENCY_REPORT", OracleType.DateTime),
					new OracleParameter(":TO_PUB", OracleType.DateTime),
					new OracleParameter(":P5_SENDING_DATE", OracleType.DateTime),
					new OracleParameter(":SECOND_AGENCY_REPORT", OracleType.DateTime),
					new OracleParameter(":TO_GRANT", OracleType.DateTime),
					new OracleParameter(":COMMENTS", OracleType.VarChar,1200),
					new OracleParameter(":CLIENT_REF", OracleType.VarChar,80),
					new OracleParameter(":CLIENT", OracleType.VarChar,500),
					new OracleParameter(":HK_ANNO_NO", OracleType.VarChar,50),
					new OracleParameter(":HK_GAZETTE", OracleType.DateTime),
					new OracleParameter(":PARENT_COUNTRY", OracleType.VarChar,10),
					new OracleParameter(":RECEIVED", OracleType.DateTime),
					new OracleParameter(":ABANDON", OracleType.Char,2),
					new OracleParameter(":PRIORITY", OracleType.DateTime),
					new OracleParameter(":SENDADDRESS", OracleType.VarChar,600),
					new OracleParameter(":ADDRCHECK", OracleType.Char,2),
					new OracleParameter(":APPLICANT", OracleType.VarChar,100)};
			parameters[0].Value = model.HK_APP_REF;
			parameters[1].Value = model.HK_APP_NO;
			parameters[2].Value = model.HK_PUB_NO;
			parameters[3].Value = model.HK_REG1_DATE;
			parameters[4].Value = model.HK_PUB1_DATE;
			parameters[5].Value = model.MAINTENANCE_DUEDATE;
			parameters[6].Value = model.HK_REG2_DATE;
			parameters[7].Value = model.NEXT_RENEWAL_DUEDATE;
			parameters[8].Value = model.CN_APP_REF;
			parameters[9].Value = model.CN_APP_NO;
			parameters[10].Value = model.CN_APP_DATE;
			parameters[11].Value = model.P4_SENDING_DATE;
			parameters[12].Value = model.FIRST_AGENCY_REPORT;
			parameters[13].Value = model.TO_PUB;
			parameters[14].Value = model.P5_SENDING_DATE;
			parameters[15].Value = model.SECOND_AGENCY_REPORT;
			parameters[16].Value = model.TO_GRANT;
			parameters[17].Value = model.COMMENTS;
			parameters[18].Value = model.CLIENT_REF;
			parameters[19].Value = model.CLIENT;
			parameters[20].Value = model.HK_ANNO_NO;
			parameters[21].Value = model.HK_GAZETTE;
			parameters[22].Value = model.PARENT_COUNTRY;
			parameters[23].Value = model.RECEIVED;
			parameters[24].Value = model.ABANDON;
			parameters[25].Value = model.PRIORITY;
			parameters[26].Value = model.SENDADDRESS;
			parameters[27].Value = model.ADDRCHECK;
			parameters[28].Value = model.APPLICANT;

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
		public bool Delete(string HK_APP_REF)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EX_HKCASE ");
			strSql.Append(" where HK_APP_REF=:HK_APP_REF ");
			OracleParameter[] parameters = {
					new OracleParameter(":HK_APP_REF", OracleType.VarChar,30)			};
			parameters[0].Value = HK_APP_REF;

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
		public bool DeleteList(string HK_APP_REFlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EX_HKCASE ");
			strSql.Append(" where HK_APP_REF in ("+HK_APP_REFlist + ")  ");
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
		public Model.EX_HKCASE GetModel(string HK_APP_REF)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select HK_APP_REF,HK_APP_NO,HK_PUB_NO,HK_REG1_DATE,HK_PUB1_DATE,MAINTENANCE_DUEDATE,HK_REG2_DATE,NEXT_RENEWAL_DUEDATE,CN_APP_REF,CN_APP_NO,CN_APP_DATE,P4_SENDING_DATE,FIRST_AGENCY_REPORT,TO_PUB,P5_SENDING_DATE,SECOND_AGENCY_REPORT,TO_GRANT,COMMENTS,CLIENT_REF,CLIENT,HK_ANNO_NO,HK_GAZETTE,PARENT_COUNTRY,RECEIVED,ABANDON,PRIORITY,SENDADDRESS,ADDRCHECK,APPLICANT from EX_HKCASE ");
			strSql.Append(" where HK_APP_REF=:HK_APP_REF ");
			OracleParameter[] parameters = {
					new OracleParameter(":HK_APP_REF", OracleType.VarChar,30)			};
			parameters[0].Value = HK_APP_REF;

			Model.EX_HKCASE model=new Model.EX_HKCASE();
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
		public Model.EX_HKCASE DataRowToModel(DataRow row)
		{
			Model.EX_HKCASE model=new Model.EX_HKCASE();
			if (row != null)
			{
				if(row["HK_APP_REF"]!=null)
				{
					model.HK_APP_REF=row["HK_APP_REF"].ToString();
				}
				if(row["HK_APP_NO"]!=null)
				{
					model.HK_APP_NO=row["HK_APP_NO"].ToString();
				}
				if(row["HK_PUB_NO"]!=null)
				{
					model.HK_PUB_NO=row["HK_PUB_NO"].ToString();
				}
				if(row["HK_REG1_DATE"]!=null && row["HK_REG1_DATE"].ToString()!="")
				{
					model.HK_REG1_DATE=DateTime.Parse(row["HK_REG1_DATE"].ToString());
				}
				if(row["HK_PUB1_DATE"]!=null && row["HK_PUB1_DATE"].ToString()!="")
				{
					model.HK_PUB1_DATE=DateTime.Parse(row["HK_PUB1_DATE"].ToString());
				}
				if(row["MAINTENANCE_DUEDATE"]!=null && row["MAINTENANCE_DUEDATE"].ToString()!="")
				{
					model.MAINTENANCE_DUEDATE=DateTime.Parse(row["MAINTENANCE_DUEDATE"].ToString());
				}
				if(row["HK_REG2_DATE"]!=null && row["HK_REG2_DATE"].ToString()!="")
				{
					model.HK_REG2_DATE=DateTime.Parse(row["HK_REG2_DATE"].ToString());
				}
				if(row["NEXT_RENEWAL_DUEDATE"]!=null && row["NEXT_RENEWAL_DUEDATE"].ToString()!="")
				{
					model.NEXT_RENEWAL_DUEDATE=DateTime.Parse(row["NEXT_RENEWAL_DUEDATE"].ToString());
				}
				if(row["CN_APP_REF"]!=null)
				{
					model.CN_APP_REF=row["CN_APP_REF"].ToString();
				}
				if(row["CN_APP_NO"]!=null)
				{
					model.CN_APP_NO=row["CN_APP_NO"].ToString();
				}
				if(row["CN_APP_DATE"]!=null && row["CN_APP_DATE"].ToString()!="")
				{
					model.CN_APP_DATE=DateTime.Parse(row["CN_APP_DATE"].ToString());
				}
				if(row["P4_SENDING_DATE"]!=null && row["P4_SENDING_DATE"].ToString()!="")
				{
					model.P4_SENDING_DATE=DateTime.Parse(row["P4_SENDING_DATE"].ToString());
				}
				if(row["FIRST_AGENCY_REPORT"]!=null && row["FIRST_AGENCY_REPORT"].ToString()!="")
				{
					model.FIRST_AGENCY_REPORT=DateTime.Parse(row["FIRST_AGENCY_REPORT"].ToString());
				}
				if(row["TO_PUB"]!=null && row["TO_PUB"].ToString()!="")
				{
					model.TO_PUB=DateTime.Parse(row["TO_PUB"].ToString());
				}
				if(row["P5_SENDING_DATE"]!=null && row["P5_SENDING_DATE"].ToString()!="")
				{
					model.P5_SENDING_DATE=DateTime.Parse(row["P5_SENDING_DATE"].ToString());
				}
				if(row["SECOND_AGENCY_REPORT"]!=null && row["SECOND_AGENCY_REPORT"].ToString()!="")
				{
					model.SECOND_AGENCY_REPORT=DateTime.Parse(row["SECOND_AGENCY_REPORT"].ToString());
				}
				if(row["TO_GRANT"]!=null && row["TO_GRANT"].ToString()!="")
				{
					model.TO_GRANT=DateTime.Parse(row["TO_GRANT"].ToString());
				}
				if(row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
				}
				if(row["CLIENT_REF"]!=null)
				{
					model.CLIENT_REF=row["CLIENT_REF"].ToString();
				}
				if(row["CLIENT"]!=null)
				{
					model.CLIENT=row["CLIENT"].ToString();
				}
				if(row["HK_ANNO_NO"]!=null)
				{
					model.HK_ANNO_NO=row["HK_ANNO_NO"].ToString();
				}
				if(row["HK_GAZETTE"]!=null && row["HK_GAZETTE"].ToString()!="")
				{
					model.HK_GAZETTE=DateTime.Parse(row["HK_GAZETTE"].ToString());
				}
				if(row["PARENT_COUNTRY"]!=null)
				{
					model.PARENT_COUNTRY=row["PARENT_COUNTRY"].ToString();
				}
				if(row["RECEIVED"]!=null && row["RECEIVED"].ToString()!="")
				{
					model.RECEIVED=DateTime.Parse(row["RECEIVED"].ToString());
				}
				if(row["ABANDON"]!=null)
				{
					model.ABANDON=row["ABANDON"].ToString();
				}
				if(row["PRIORITY"]!=null && row["PRIORITY"].ToString()!="")
				{
					model.PRIORITY=DateTime.Parse(row["PRIORITY"].ToString());
				}
				if(row["SENDADDRESS"]!=null)
				{
					model.SENDADDRESS=row["SENDADDRESS"].ToString();
				}
				if(row["ADDRCHECK"]!=null)
				{
					model.ADDRCHECK=row["ADDRCHECK"].ToString();
				}
				if(row["APPLICANT"]!=null)
				{
					model.APPLICANT=row["APPLICANT"].ToString();
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
			strSql.Append("select HK_APP_REF,HK_APP_NO,HK_PUB_NO,HK_REG1_DATE,HK_PUB1_DATE,MAINTENANCE_DUEDATE,HK_REG2_DATE,NEXT_RENEWAL_DUEDATE,CN_APP_REF,CN_APP_NO,CN_APP_DATE,P4_SENDING_DATE,FIRST_AGENCY_REPORT,TO_PUB,P5_SENDING_DATE,SECOND_AGENCY_REPORT,TO_GRANT,COMMENTS,CLIENT_REF,CLIENT,HK_ANNO_NO,HK_GAZETTE,PARENT_COUNTRY,RECEIVED,ABANDON,PRIORITY,SENDADDRESS,ADDRCHECK,APPLICANT ");
			strSql.Append(" FROM EX_HKCASE ");
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
			strSql.Append("select count(1) FROM EX_HKCASE ");
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
				strSql.Append("order by T.HK_APP_REF desc");
			}
			strSql.Append(")AS Row, T.*  from EX_HKCASE T ");
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
			parameters[0].Value = "EX_HKCASE";
			parameters[1].Value = "HK_APP_REF";
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

