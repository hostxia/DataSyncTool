﻿using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:CUX_FCASE_ENT_REL_BK_20130913
	/// </summary>
	public partial class CUX_FCASE_ENT_REL_BK_20130913
	{
		public CUX_FCASE_ENT_REL_BK_20130913()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.CUX_FCASE_ENT_REL_BK_20130913 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CUX_FCASE_ENT_REL_BK_20130913(");
			strSql.Append("PID,OURNO,EID,ROLE,NATIONALITY,COUNTRY,PROVINCE,ADDR,ENT_ORDER,ENT_REF,ORIG_NAME,TRAN_NAME)");
			strSql.Append(" values (");
			strSql.Append(":PID,:OURNO,:EID,:ROLE,:NATIONALITY,:COUNTRY,:PROVINCE,:ADDR,:ENT_ORDER,:ENT_REF,:ORIG_NAME,:TRAN_NAME)");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,20),
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":EID", OracleType.VarChar,20),
					new OracleParameter(":ROLE", OracleType.VarChar,20),
					new OracleParameter(":NATIONALITY", OracleType.VarChar,5),
					new OracleParameter(":COUNTRY", OracleType.VarChar,5),
					new OracleParameter(":PROVINCE", OracleType.VarChar,50),
					new OracleParameter(":ADDR", OracleType.VarChar,500),
					new OracleParameter(":ENT_ORDER", OracleType.Number,4),
					new OracleParameter(":ENT_REF", OracleType.VarChar,40),
					new OracleParameter(":ORIG_NAME", OracleType.VarChar,100),
					new OracleParameter(":TRAN_NAME", OracleType.VarChar,100)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.OURNO;
			parameters[2].Value = model.EID;
			parameters[3].Value = model.ROLE;
			parameters[4].Value = model.NATIONALITY;
			parameters[5].Value = model.COUNTRY;
			parameters[6].Value = model.PROVINCE;
			parameters[7].Value = model.ADDR;
			parameters[8].Value = model.ENT_ORDER;
			parameters[9].Value = model.ENT_REF;
			parameters[10].Value = model.ORIG_NAME;
			parameters[11].Value = model.TRAN_NAME;

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
		public bool Update(Model.CUX_FCASE_ENT_REL_BK_20130913 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CUX_FCASE_ENT_REL_BK_20130913 set ");
			strSql.Append("PID=:PID,");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("EID=:EID,");
			strSql.Append("ROLE=:ROLE,");
			strSql.Append("NATIONALITY=:NATIONALITY,");
			strSql.Append("COUNTRY=:COUNTRY,");
			strSql.Append("PROVINCE=:PROVINCE,");
			strSql.Append("ADDR=:ADDR,");
			strSql.Append("ENT_ORDER=:ENT_ORDER,");
			strSql.Append("ENT_REF=:ENT_REF,");
			strSql.Append("ORIG_NAME=:ORIG_NAME,");
			strSql.Append("TRAN_NAME=:TRAN_NAME");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":PID", OracleType.VarChar,20),
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":EID", OracleType.VarChar,20),
					new OracleParameter(":ROLE", OracleType.VarChar,20),
					new OracleParameter(":NATIONALITY", OracleType.VarChar,5),
					new OracleParameter(":COUNTRY", OracleType.VarChar,5),
					new OracleParameter(":PROVINCE", OracleType.VarChar,50),
					new OracleParameter(":ADDR", OracleType.VarChar,500),
					new OracleParameter(":ENT_ORDER", OracleType.Number,4),
					new OracleParameter(":ENT_REF", OracleType.VarChar,40),
					new OracleParameter(":ORIG_NAME", OracleType.VarChar,100),
					new OracleParameter(":TRAN_NAME", OracleType.VarChar,100)};
			parameters[0].Value = model.PID;
			parameters[1].Value = model.OURNO;
			parameters[2].Value = model.EID;
			parameters[3].Value = model.ROLE;
			parameters[4].Value = model.NATIONALITY;
			parameters[5].Value = model.COUNTRY;
			parameters[6].Value = model.PROVINCE;
			parameters[7].Value = model.ADDR;
			parameters[8].Value = model.ENT_ORDER;
			parameters[9].Value = model.ENT_REF;
			parameters[10].Value = model.ORIG_NAME;
			parameters[11].Value = model.TRAN_NAME;

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
			strSql.Append("delete from CUX_FCASE_ENT_REL_BK_20130913 ");
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
		public Model.CUX_FCASE_ENT_REL_BK_20130913 GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PID,OURNO,EID,ROLE,NATIONALITY,COUNTRY,PROVINCE,ADDR,ENT_ORDER,ENT_REF,ORIG_NAME,TRAN_NAME from CUX_FCASE_ENT_REL_BK_20130913 ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Model.CUX_FCASE_ENT_REL_BK_20130913 model=new Model.CUX_FCASE_ENT_REL_BK_20130913();
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
		public Model.CUX_FCASE_ENT_REL_BK_20130913 DataRowToModel(DataRow row)
		{
			Model.CUX_FCASE_ENT_REL_BK_20130913 model=new Model.CUX_FCASE_ENT_REL_BK_20130913();
			if (row != null)
			{
				if(row["PID"]!=null)
				{
					model.PID=row["PID"].ToString();
				}
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["EID"]!=null)
				{
					model.EID=row["EID"].ToString();
				}
				if(row["ROLE"]!=null)
				{
					model.ROLE=row["ROLE"].ToString();
				}
				if(row["NATIONALITY"]!=null)
				{
					model.NATIONALITY=row["NATIONALITY"].ToString();
				}
				if(row["COUNTRY"]!=null)
				{
					model.COUNTRY=row["COUNTRY"].ToString();
				}
				if(row["PROVINCE"]!=null)
				{
					model.PROVINCE=row["PROVINCE"].ToString();
				}
				if(row["ADDR"]!=null)
				{
					model.ADDR=row["ADDR"].ToString();
				}
				if(row["ENT_ORDER"]!=null && row["ENT_ORDER"].ToString()!="")
				{
					model.ENT_ORDER=decimal.Parse(row["ENT_ORDER"].ToString());
				}
				if(row["ENT_REF"]!=null)
				{
					model.ENT_REF=row["ENT_REF"].ToString();
				}
				if(row["ORIG_NAME"]!=null)
				{
					model.ORIG_NAME=row["ORIG_NAME"].ToString();
				}
				if(row["TRAN_NAME"]!=null)
				{
					model.TRAN_NAME=row["TRAN_NAME"].ToString();
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
			strSql.Append("select PID,OURNO,EID,ROLE,NATIONALITY,COUNTRY,PROVINCE,ADDR,ENT_ORDER,ENT_REF,ORIG_NAME,TRAN_NAME ");
			strSql.Append(" FROM CUX_FCASE_ENT_REL_BK_20130913 ");
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
			strSql.Append("select count(1) FROM CUX_FCASE_ENT_REL_BK_20130913 ");
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
			strSql.Append(")AS Row, T.*  from CUX_FCASE_ENT_REL_BK_20130913 T ");
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
			parameters[0].Value = "CUX_FCASE_ENT_REL_BK_20130913";
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

