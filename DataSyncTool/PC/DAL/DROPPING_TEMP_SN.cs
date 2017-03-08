﻿using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.PC.DAL
{
	/// <summary>
	/// 数据访问类:DROPPING_TEMP_SN
	/// </summary>
	public partial class DROPPING_TEMP_SN
	{
		public DROPPING_TEMP_SN()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.DROPPING_TEMP_SN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DROPPING_TEMP_SN(");
			strSql.Append("OURNO,SPN,SN,STAT,APPN,APPD,REMARKS,OURNO_ORIG)");
			strSql.Append(" values (");
			strSql.Append(":OURNO,:SPN,:SN,:STAT,:APPN,:APPD,:REMARKS,:OURNO_ORIG)");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":SPN", OracleType.VarChar,30),
					new OracleParameter(":SN", OracleType.VarChar,30),
					new OracleParameter(":STAT", OracleType.VarChar,30),
					new OracleParameter(":APPN", OracleType.VarChar,30),
					new OracleParameter(":APPD", OracleType.DateTime),
					new OracleParameter(":REMARKS", OracleType.VarChar,4000),
					new OracleParameter(":OURNO_ORIG", OracleType.VarChar,30)};
			parameters[0].Value = model.OURNO;
			parameters[1].Value = model.SPN;
			parameters[2].Value = model.SN;
			parameters[3].Value = model.STAT;
			parameters[4].Value = model.APPN;
			parameters[5].Value = model.APPD;
			parameters[6].Value = model.REMARKS;
			parameters[7].Value = model.OURNO_ORIG;

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
		public bool Update(Model.DROPPING_TEMP_SN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DROPPING_TEMP_SN set ");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("SPN=:SPN,");
			strSql.Append("SN=:SN,");
			strSql.Append("STAT=:STAT,");
			strSql.Append("APPN=:APPN,");
			strSql.Append("APPD=:APPD,");
			strSql.Append("REMARKS=:REMARKS,");
			strSql.Append("OURNO_ORIG=:OURNO_ORIG");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,30),
					new OracleParameter(":SPN", OracleType.VarChar,30),
					new OracleParameter(":SN", OracleType.VarChar,30),
					new OracleParameter(":STAT", OracleType.VarChar,30),
					new OracleParameter(":APPN", OracleType.VarChar,30),
					new OracleParameter(":APPD", OracleType.DateTime),
					new OracleParameter(":REMARKS", OracleType.VarChar,4000),
					new OracleParameter(":OURNO_ORIG", OracleType.VarChar,30)};
			parameters[0].Value = model.OURNO;
			parameters[1].Value = model.SPN;
			parameters[2].Value = model.SN;
			parameters[3].Value = model.STAT;
			parameters[4].Value = model.APPN;
			parameters[5].Value = model.APPD;
			parameters[6].Value = model.REMARKS;
			parameters[7].Value = model.OURNO_ORIG;

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
			strSql.Append("delete from DROPPING_TEMP_SN ");
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
		public Model.DROPPING_TEMP_SN GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OURNO,SPN,SN,STAT,APPN,APPD,REMARKS,OURNO_ORIG from DROPPING_TEMP_SN ");
			strSql.Append(" where ");
			OracleParameter[] parameters = {
			};

			Model.DROPPING_TEMP_SN model=new Model.DROPPING_TEMP_SN();
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
		public Model.DROPPING_TEMP_SN DataRowToModel(DataRow row)
		{
			Model.DROPPING_TEMP_SN model=new Model.DROPPING_TEMP_SN();
			if (row != null)
			{
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["SPN"]!=null)
				{
					model.SPN=row["SPN"].ToString();
				}
				if(row["SN"]!=null)
				{
					model.SN=row["SN"].ToString();
				}
				if(row["STAT"]!=null)
				{
					model.STAT=row["STAT"].ToString();
				}
				if(row["APPN"]!=null)
				{
					model.APPN=row["APPN"].ToString();
				}
				if(row["APPD"]!=null && row["APPD"].ToString()!="")
				{
					model.APPD=DateTime.Parse(row["APPD"].ToString());
				}
				if(row["REMARKS"]!=null)
				{
					model.REMARKS=row["REMARKS"].ToString();
				}
				if(row["OURNO_ORIG"]!=null)
				{
					model.OURNO_ORIG=row["OURNO_ORIG"].ToString();
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
			strSql.Append("select OURNO,SPN,SN,STAT,APPN,APPD,REMARKS,OURNO_ORIG ");
			strSql.Append(" FROM DROPPING_TEMP_SN ");
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
			strSql.Append("select count(1) FROM DROPPING_TEMP_SN ");
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
			strSql.Append(")AS Row, T.*  from DROPPING_TEMP_SN T ");
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
			parameters[0].Value = "DROPPING_TEMP_SN";
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
