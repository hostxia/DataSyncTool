using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:PATENTBILLITEMTYPE_V2
	/// </summary>
	public partial class PATENTBILLITEMTYPE_V2
	{
		public PATENTBILLITEMTYPE_V2()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string BILLCODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PATENTBILLITEMTYPE_V2");
			strSql.Append(" where BILLCODE=:BILLCODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLCODE", OracleType.VarChar,30)			};
			parameters[0].Value = BILLCODE;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.PATENTBILLITEMTYPE_V2 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PATENTBILLITEMTYPE_V2(");
			strSql.Append("BILLCODE,BILLTEXT,PATENTCASETYPE,HASQUANTITY,UNIT,DEFOFFICIALFEE,DEFNONOFFICIALFEE,ALGORITHM,F0,F1,F2,F3,F4,F5,COMMENTS)");
			strSql.Append(" values (");
			strSql.Append(":BILLCODE,:BILLTEXT,:PATENTCASETYPE,:HASQUANTITY,:UNIT,:DEFOFFICIALFEE,:DEFNONOFFICIALFEE,:ALGORITHM,:F0,:F1,:F2,:F3,:F4,:F5,:COMMENTS)");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLCODE", OracleType.VarChar,30),
					new OracleParameter(":BILLTEXT", OracleType.VarChar,100),
					new OracleParameter(":PATENTCASETYPE", OracleType.Char,8),
					new OracleParameter(":HASQUANTITY", OracleType.Char,1),
					new OracleParameter(":UNIT", OracleType.Char,20),
					new OracleParameter(":DEFOFFICIALFEE", OracleType.Number,4),
					new OracleParameter(":DEFNONOFFICIALFEE", OracleType.Number,4),
					new OracleParameter(":ALGORITHM", OracleType.VarChar,15),
					new OracleParameter(":F0", OracleType.Number,4),
					new OracleParameter(":F1", OracleType.Number,4),
					new OracleParameter(":F2", OracleType.Number,4),
					new OracleParameter(":F3", OracleType.Number,4),
					new OracleParameter(":F4", OracleType.Number,4),
					new OracleParameter(":F5", OracleType.Number,4),
					new OracleParameter(":COMMENTS", OracleType.VarChar,2000)};
			parameters[0].Value = model.BILLCODE;
			parameters[1].Value = model.BILLTEXT;
			parameters[2].Value = model.PATENTCASETYPE;
			parameters[3].Value = model.HASQUANTITY;
			parameters[4].Value = model.UNIT;
			parameters[5].Value = model.DEFOFFICIALFEE;
			parameters[6].Value = model.DEFNONOFFICIALFEE;
			parameters[7].Value = model.ALGORITHM;
			parameters[8].Value = model.F0;
			parameters[9].Value = model.F1;
			parameters[10].Value = model.F2;
			parameters[11].Value = model.F3;
			parameters[12].Value = model.F4;
			parameters[13].Value = model.F5;
			parameters[14].Value = model.COMMENTS;

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
		public bool Update(Model.PATENTBILLITEMTYPE_V2 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PATENTBILLITEMTYPE_V2 set ");
			strSql.Append("BILLCODE=:BILLCODE,");
			strSql.Append("BILLTEXT=:BILLTEXT,");
			strSql.Append("PATENTCASETYPE=:PATENTCASETYPE,");
			strSql.Append("HASQUANTITY=:HASQUANTITY,");
			strSql.Append("UNIT=:UNIT,");
			strSql.Append("DEFOFFICIALFEE=:DEFOFFICIALFEE,");
			strSql.Append("DEFNONOFFICIALFEE=:DEFNONOFFICIALFEE,");
			strSql.Append("ALGORITHM=:ALGORITHM,");
			strSql.Append("F0=:F0,");
			strSql.Append("F1=:F1,");
			strSql.Append("F2=:F2,");
			strSql.Append("F3=:F3,");
			strSql.Append("F4=:F4,");
			strSql.Append("F5=:F5,");
			strSql.Append("COMMENTS=:COMMENTS");
			strSql.Append(" where BILLCODE=:BILLCODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLCODE", OracleType.VarChar,30),
					new OracleParameter(":BILLTEXT", OracleType.VarChar,100),
					new OracleParameter(":PATENTCASETYPE", OracleType.Char,8),
					new OracleParameter(":HASQUANTITY", OracleType.Char,1),
					new OracleParameter(":UNIT", OracleType.Char,20),
					new OracleParameter(":DEFOFFICIALFEE", OracleType.Number,4),
					new OracleParameter(":DEFNONOFFICIALFEE", OracleType.Number,4),
					new OracleParameter(":ALGORITHM", OracleType.VarChar,15),
					new OracleParameter(":F0", OracleType.Number,4),
					new OracleParameter(":F1", OracleType.Number,4),
					new OracleParameter(":F2", OracleType.Number,4),
					new OracleParameter(":F3", OracleType.Number,4),
					new OracleParameter(":F4", OracleType.Number,4),
					new OracleParameter(":F5", OracleType.Number,4),
					new OracleParameter(":COMMENTS", OracleType.VarChar,2000)};
			parameters[0].Value = model.BILLCODE;
			parameters[1].Value = model.BILLTEXT;
			parameters[2].Value = model.PATENTCASETYPE;
			parameters[3].Value = model.HASQUANTITY;
			parameters[4].Value = model.UNIT;
			parameters[5].Value = model.DEFOFFICIALFEE;
			parameters[6].Value = model.DEFNONOFFICIALFEE;
			parameters[7].Value = model.ALGORITHM;
			parameters[8].Value = model.F0;
			parameters[9].Value = model.F1;
			parameters[10].Value = model.F2;
			parameters[11].Value = model.F3;
			parameters[12].Value = model.F4;
			parameters[13].Value = model.F5;
			parameters[14].Value = model.COMMENTS;

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
		public bool Delete(string BILLCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PATENTBILLITEMTYPE_V2 ");
			strSql.Append(" where BILLCODE=:BILLCODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLCODE", OracleType.VarChar,30)			};
			parameters[0].Value = BILLCODE;

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
		public bool DeleteList(string BILLCODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PATENTBILLITEMTYPE_V2 ");
			strSql.Append(" where BILLCODE in ("+BILLCODElist + ")  ");
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
		public Model.PATENTBILLITEMTYPE_V2 GetModel(string BILLCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select BILLCODE,BILLTEXT,PATENTCASETYPE,HASQUANTITY,UNIT,DEFOFFICIALFEE,DEFNONOFFICIALFEE,ALGORITHM,F0,F1,F2,F3,F4,F5,COMMENTS from PATENTBILLITEMTYPE_V2 ");
			strSql.Append(" where BILLCODE=:BILLCODE ");
			OracleParameter[] parameters = {
					new OracleParameter(":BILLCODE", OracleType.VarChar,30)			};
			parameters[0].Value = BILLCODE;

			Model.PATENTBILLITEMTYPE_V2 model=new Model.PATENTBILLITEMTYPE_V2();
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
		public Model.PATENTBILLITEMTYPE_V2 DataRowToModel(DataRow row)
		{
			Model.PATENTBILLITEMTYPE_V2 model=new Model.PATENTBILLITEMTYPE_V2();
			if (row != null)
			{
				if(row["BILLCODE"]!=null)
				{
					model.BILLCODE=row["BILLCODE"].ToString();
				}
				if(row["BILLTEXT"]!=null)
				{
					model.BILLTEXT=row["BILLTEXT"].ToString();
				}
				if(row["PATENTCASETYPE"]!=null)
				{
					model.PATENTCASETYPE=row["PATENTCASETYPE"].ToString();
				}
				if(row["HASQUANTITY"]!=null)
				{
					model.HASQUANTITY=row["HASQUANTITY"].ToString();
				}
				if(row["UNIT"]!=null)
				{
					model.UNIT=row["UNIT"].ToString();
				}
				if(row["DEFOFFICIALFEE"]!=null && row["DEFOFFICIALFEE"].ToString()!="")
				{
					model.DEFOFFICIALFEE=decimal.Parse(row["DEFOFFICIALFEE"].ToString());
				}
				if(row["DEFNONOFFICIALFEE"]!=null && row["DEFNONOFFICIALFEE"].ToString()!="")
				{
					model.DEFNONOFFICIALFEE=decimal.Parse(row["DEFNONOFFICIALFEE"].ToString());
				}
				if(row["ALGORITHM"]!=null)
				{
					model.ALGORITHM=row["ALGORITHM"].ToString();
				}
				if(row["F0"]!=null && row["F0"].ToString()!="")
				{
					model.F0=decimal.Parse(row["F0"].ToString());
				}
				if(row["F1"]!=null && row["F1"].ToString()!="")
				{
					model.F1=decimal.Parse(row["F1"].ToString());
				}
				if(row["F2"]!=null && row["F2"].ToString()!="")
				{
					model.F2=decimal.Parse(row["F2"].ToString());
				}
				if(row["F3"]!=null && row["F3"].ToString()!="")
				{
					model.F3=decimal.Parse(row["F3"].ToString());
				}
				if(row["F4"]!=null && row["F4"].ToString()!="")
				{
					model.F4=decimal.Parse(row["F4"].ToString());
				}
				if(row["F5"]!=null && row["F5"].ToString()!="")
				{
					model.F5=decimal.Parse(row["F5"].ToString());
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
			strSql.Append("select BILLCODE,BILLTEXT,PATENTCASETYPE,HASQUANTITY,UNIT,DEFOFFICIALFEE,DEFNONOFFICIALFEE,ALGORITHM,F0,F1,F2,F3,F4,F5,COMMENTS ");
			strSql.Append(" FROM PATENTBILLITEMTYPE_V2 ");
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
			strSql.Append("select count(1) FROM PATENTBILLITEMTYPE_V2 ");
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
				strSql.Append("order by T.BILLCODE desc");
			}
			strSql.Append(")AS Row, T.*  from PATENTBILLITEMTYPE_V2 T ");
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
			parameters[0].Value = "PATENTBILLITEMTYPE_V2";
			parameters[1].Value = "BILLCODE";
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

