/**  版本信息模板在安装目录下，可自行修改。
* TCode_TRenewalFee.cs
*
* 功 能： N/A
* 类 名： TCode_TRenewalFee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:18   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/

using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.IPSP.DAL
{
	/// <summary>
	/// 数据访问类:TCode_TRenewalFee
	/// </summary>
	public partial class TCode_TRenewalFee
	{
		public TCode_TRenewalFee()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TCode_TRenewalFee"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_TRenewalFee");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_TRenewalFee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_TRenewalFee(");
			strSql.Append("s_TApplyType,n_RegCountry,n_OfficialFee,n_OfficialCurrency,s_UnitPrice,s_Unit,n_ExceedUnit,n_ExceedUnitFee,s_InitialDateType,n_RenewalYear,s_Notes,dt_CreateDate,dt_EditDate)");
			strSql.Append(" values (");
			strSql.Append("@s_TApplyType,@n_RegCountry,@n_OfficialFee,@n_OfficialCurrency,@s_UnitPrice,@s_Unit,@n_ExceedUnit,@n_ExceedUnitFee,@s_InitialDateType,@n_RenewalYear,@s_Notes,@dt_CreateDate,@dt_EditDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_TApplyType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_RegCountry", SqlDbType.Int,4),
					new SqlParameter("@n_OfficialFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_OfficialCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_UnitPrice", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ExceedUnit", SqlDbType.Int,4),
					new SqlParameter("@n_ExceedUnitFee", SqlDbType.Decimal,9),
					new SqlParameter("@s_InitialDateType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_RenewalYear", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime)};
			parameters[0].Value = model.s_TApplyType;
			parameters[1].Value = model.n_RegCountry;
			parameters[2].Value = model.n_OfficialFee;
			parameters[3].Value = model.n_OfficialCurrency;
			parameters[4].Value = model.s_UnitPrice;
			parameters[5].Value = model.s_Unit;
			parameters[6].Value = model.n_ExceedUnit;
			parameters[7].Value = model.n_ExceedUnitFee;
			parameters[8].Value = model.s_InitialDateType;
			parameters[9].Value = model.n_RenewalYear;
			parameters[10].Value = model.s_Notes;
			parameters[11].Value = model.dt_CreateDate;
			parameters[12].Value = model.dt_EditDate;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(IPSP.Model.TCode_TRenewalFee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_TRenewalFee set ");
			strSql.Append("s_TApplyType=@s_TApplyType,");
			strSql.Append("n_RegCountry=@n_RegCountry,");
			strSql.Append("n_OfficialFee=@n_OfficialFee,");
			strSql.Append("n_OfficialCurrency=@n_OfficialCurrency,");
			strSql.Append("s_UnitPrice=@s_UnitPrice,");
			strSql.Append("s_Unit=@s_Unit,");
			strSql.Append("n_ExceedUnit=@n_ExceedUnit,");
			strSql.Append("n_ExceedUnitFee=@n_ExceedUnitFee,");
			strSql.Append("s_InitialDateType=@s_InitialDateType,");
			strSql.Append("n_RenewalYear=@n_RenewalYear,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_TApplyType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_RegCountry", SqlDbType.Int,4),
					new SqlParameter("@n_OfficialFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_OfficialCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_UnitPrice", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ExceedUnit", SqlDbType.Int,4),
					new SqlParameter("@n_ExceedUnitFee", SqlDbType.Decimal,9),
					new SqlParameter("@s_InitialDateType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_RenewalYear", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_TApplyType;
			parameters[1].Value = model.n_RegCountry;
			parameters[2].Value = model.n_OfficialFee;
			parameters[3].Value = model.n_OfficialCurrency;
			parameters[4].Value = model.s_UnitPrice;
			parameters[5].Value = model.s_Unit;
			parameters[6].Value = model.n_ExceedUnit;
			parameters[7].Value = model.n_ExceedUnitFee;
			parameters[8].Value = model.s_InitialDateType;
			parameters[9].Value = model.n_RenewalYear;
			parameters[10].Value = model.s_Notes;
			parameters[11].Value = model.dt_CreateDate;
			parameters[12].Value = model.dt_EditDate;
			parameters[13].Value = model.n_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_TRenewalFee ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string n_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_TRenewalFee ");
			strSql.Append(" where n_ID in ("+n_IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public IPSP.Model.TCode_TRenewalFee GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_TApplyType,n_RegCountry,n_OfficialFee,n_OfficialCurrency,s_UnitPrice,s_Unit,n_ExceedUnit,n_ExceedUnitFee,s_InitialDateType,n_RenewalYear,s_Notes,dt_CreateDate,dt_EditDate from TCode_TRenewalFee ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_TRenewalFee model=new IPSP.Model.TCode_TRenewalFee();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
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
		public IPSP.Model.TCode_TRenewalFee DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_TRenewalFee model=new IPSP.Model.TCode_TRenewalFee();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_TApplyType"]!=null)
				{
					model.s_TApplyType=row["s_TApplyType"].ToString();
				}
				if(row["n_RegCountry"]!=null && row["n_RegCountry"].ToString()!="")
				{
					model.n_RegCountry=int.Parse(row["n_RegCountry"].ToString());
				}
				if(row["n_OfficialFee"]!=null && row["n_OfficialFee"].ToString()!="")
				{
					model.n_OfficialFee=decimal.Parse(row["n_OfficialFee"].ToString());
				}
				if(row["n_OfficialCurrency"]!=null && row["n_OfficialCurrency"].ToString()!="")
				{
					model.n_OfficialCurrency=int.Parse(row["n_OfficialCurrency"].ToString());
				}
				if(row["s_UnitPrice"]!=null)
				{
					model.s_UnitPrice=row["s_UnitPrice"].ToString();
				}
				if(row["s_Unit"]!=null)
				{
					model.s_Unit=row["s_Unit"].ToString();
				}
				if(row["n_ExceedUnit"]!=null && row["n_ExceedUnit"].ToString()!="")
				{
					model.n_ExceedUnit=int.Parse(row["n_ExceedUnit"].ToString());
				}
				if(row["n_ExceedUnitFee"]!=null && row["n_ExceedUnitFee"].ToString()!="")
				{
					model.n_ExceedUnitFee=decimal.Parse(row["n_ExceedUnitFee"].ToString());
				}
				if(row["s_InitialDateType"]!=null)
				{
					model.s_InitialDateType=row["s_InitialDateType"].ToString();
				}
				if(row["n_RenewalYear"]!=null && row["n_RenewalYear"].ToString()!="")
				{
					model.n_RenewalYear=int.Parse(row["n_RenewalYear"].ToString());
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
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
			strSql.Append("select n_ID,s_TApplyType,n_RegCountry,n_OfficialFee,n_OfficialCurrency,s_UnitPrice,s_Unit,n_ExceedUnit,n_ExceedUnitFee,s_InitialDateType,n_RenewalYear,s_Notes,dt_CreateDate,dt_EditDate ");
			strSql.Append(" FROM TCode_TRenewalFee ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" n_ID,s_TApplyType,n_RegCountry,n_OfficialFee,n_OfficialCurrency,s_UnitPrice,s_Unit,n_ExceedUnit,n_ExceedUnitFee,s_InitialDateType,n_RenewalYear,s_Notes,dt_CreateDate,dt_EditDate ");
			strSql.Append(" FROM TCode_TRenewalFee ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TCode_TRenewalFee ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.n_ID desc");
			}
			strSql.Append(")AS Row, T.*  from TCode_TRenewalFee T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "TCode_TRenewalFee";
			parameters[1].Value = "n_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

