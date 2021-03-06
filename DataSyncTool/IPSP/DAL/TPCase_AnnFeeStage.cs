﻿/**  版本信息模板在安装目录下，可自行修改。
* TPCase_AnnFeeStage.cs
*
* 功 能： N/A
* 类 名： TPCase_AnnFeeStage
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:13   N/A    初版
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
	/// 数据访问类:TPCase_AnnFeeStage
	/// </summary>
	public partial class TPCase_AnnFeeStage
	{
		public TPCase_AnnFeeStage()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TPCase_AnnFeeStage"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPCase_AnnFeeStage");
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
		public int Add(IPSP.Model.TPCase_AnnFeeStage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPCase_AnnFeeStage(");
			strSql.Append("n_CaseID,s_OfficialDiscStyle,n_OfficialDiscount,n_DiscYears,n_FstPayYear,n_LastPayYear,n_AlarmMonths,s_Notes,s_PayMode,s_StatusOrder,s_StatusInit,n_ChargeCurrency,n_OfficialCurrency,s_FeeMode,n_FeeDiscount,n_FixAFee,n_FixFee,n_CountPayYear)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@s_OfficialDiscStyle,@n_OfficialDiscount,@n_DiscYears,@n_FstPayYear,@n_LastPayYear,@n_AlarmMonths,@s_Notes,@s_PayMode,@s_StatusOrder,@s_StatusInit,@n_ChargeCurrency,@n_OfficialCurrency,@s_FeeMode,@n_FeeDiscount,@n_FixAFee,@n_FixFee,@n_CountPayYear)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_OfficialDiscStyle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_OfficialDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@n_DiscYears", SqlDbType.Int,4),
					new SqlParameter("@n_FstPayYear", SqlDbType.Int,4),
					new SqlParameter("@n_LastPayYear", SqlDbType.Int,4),
					new SqlParameter("@n_AlarmMonths", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_PayMode", SqlDbType.NVarChar,2),
					new SqlParameter("@s_StatusOrder", SqlDbType.NVarChar,10),
					new SqlParameter("@s_StatusInit", SqlDbType.NVarChar,10),
					new SqlParameter("@n_ChargeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_OfficialCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_FeeMode", SqlDbType.NVarChar,1),
					new SqlParameter("@n_FeeDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@n_FixAFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_FixFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_CountPayYear", SqlDbType.Int,4)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_OfficialDiscStyle;
			parameters[2].Value = model.n_OfficialDiscount;
			parameters[3].Value = model.n_DiscYears;
			parameters[4].Value = model.n_FstPayYear;
			parameters[5].Value = model.n_LastPayYear;
			parameters[6].Value = model.n_AlarmMonths;
			parameters[7].Value = model.s_Notes;
			parameters[8].Value = model.s_PayMode;
			parameters[9].Value = model.s_StatusOrder;
			parameters[10].Value = model.s_StatusInit;
			parameters[11].Value = model.n_ChargeCurrency;
			parameters[12].Value = model.n_OfficialCurrency;
			parameters[13].Value = model.s_FeeMode;
			parameters[14].Value = model.n_FeeDiscount;
			parameters[15].Value = model.n_FixAFee;
			parameters[16].Value = model.n_FixFee;
			parameters[17].Value = model.n_CountPayYear;

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
		public bool Update(IPSP.Model.TPCase_AnnFeeStage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPCase_AnnFeeStage set ");
			strSql.Append("n_CaseID=@n_CaseID,");
			strSql.Append("s_OfficialDiscStyle=@s_OfficialDiscStyle,");
			strSql.Append("n_OfficialDiscount=@n_OfficialDiscount,");
			strSql.Append("n_DiscYears=@n_DiscYears,");
			strSql.Append("n_FstPayYear=@n_FstPayYear,");
			strSql.Append("n_LastPayYear=@n_LastPayYear,");
			strSql.Append("n_AlarmMonths=@n_AlarmMonths,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("s_PayMode=@s_PayMode,");
			strSql.Append("s_StatusOrder=@s_StatusOrder,");
			strSql.Append("s_StatusInit=@s_StatusInit,");
			strSql.Append("n_ChargeCurrency=@n_ChargeCurrency,");
			strSql.Append("n_OfficialCurrency=@n_OfficialCurrency,");
			strSql.Append("s_FeeMode=@s_FeeMode,");
			strSql.Append("n_FeeDiscount=@n_FeeDiscount,");
			strSql.Append("n_FixAFee=@n_FixAFee,");
			strSql.Append("n_FixFee=@n_FixFee,");
			strSql.Append("n_CountPayYear=@n_CountPayYear");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_OfficialDiscStyle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_OfficialDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@n_DiscYears", SqlDbType.Int,4),
					new SqlParameter("@n_FstPayYear", SqlDbType.Int,4),
					new SqlParameter("@n_LastPayYear", SqlDbType.Int,4),
					new SqlParameter("@n_AlarmMonths", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_PayMode", SqlDbType.NVarChar,2),
					new SqlParameter("@s_StatusOrder", SqlDbType.NVarChar,10),
					new SqlParameter("@s_StatusInit", SqlDbType.NVarChar,10),
					new SqlParameter("@n_ChargeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_OfficialCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_FeeMode", SqlDbType.NVarChar,1),
					new SqlParameter("@n_FeeDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@n_FixAFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_FixFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_CountPayYear", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_OfficialDiscStyle;
			parameters[2].Value = model.n_OfficialDiscount;
			parameters[3].Value = model.n_DiscYears;
			parameters[4].Value = model.n_FstPayYear;
			parameters[5].Value = model.n_LastPayYear;
			parameters[6].Value = model.n_AlarmMonths;
			parameters[7].Value = model.s_Notes;
			parameters[8].Value = model.s_PayMode;
			parameters[9].Value = model.s_StatusOrder;
			parameters[10].Value = model.s_StatusInit;
			parameters[11].Value = model.n_ChargeCurrency;
			parameters[12].Value = model.n_OfficialCurrency;
			parameters[13].Value = model.s_FeeMode;
			parameters[14].Value = model.n_FeeDiscount;
			parameters[15].Value = model.n_FixAFee;
			parameters[16].Value = model.n_FixFee;
			parameters[17].Value = model.n_CountPayYear;
			parameters[18].Value = model.n_ID;

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
			strSql.Append("delete from TPCase_AnnFeeStage ");
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
			strSql.Append("delete from TPCase_AnnFeeStage ");
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
		public IPSP.Model.TPCase_AnnFeeStage GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CaseID,s_OfficialDiscStyle,n_OfficialDiscount,n_DiscYears,n_FstPayYear,n_LastPayYear,n_AlarmMonths,s_Notes,s_PayMode,s_StatusOrder,s_StatusInit,n_ChargeCurrency,n_OfficialCurrency,s_FeeMode,n_FeeDiscount,n_FixAFee,n_FixFee,n_CountPayYear from TPCase_AnnFeeStage ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TPCase_AnnFeeStage model=new IPSP.Model.TPCase_AnnFeeStage();
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
		public IPSP.Model.TPCase_AnnFeeStage DataRowToModel(DataRow row)
		{
			IPSP.Model.TPCase_AnnFeeStage model=new IPSP.Model.TPCase_AnnFeeStage();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["s_OfficialDiscStyle"]!=null)
				{
					model.s_OfficialDiscStyle=row["s_OfficialDiscStyle"].ToString();
				}
				if(row["n_OfficialDiscount"]!=null && row["n_OfficialDiscount"].ToString()!="")
				{
					model.n_OfficialDiscount=decimal.Parse(row["n_OfficialDiscount"].ToString());
				}
				if(row["n_DiscYears"]!=null && row["n_DiscYears"].ToString()!="")
				{
					model.n_DiscYears=int.Parse(row["n_DiscYears"].ToString());
				}
				if(row["n_FstPayYear"]!=null && row["n_FstPayYear"].ToString()!="")
				{
					model.n_FstPayYear=int.Parse(row["n_FstPayYear"].ToString());
				}
				if(row["n_LastPayYear"]!=null && row["n_LastPayYear"].ToString()!="")
				{
					model.n_LastPayYear=int.Parse(row["n_LastPayYear"].ToString());
				}
				if(row["n_AlarmMonths"]!=null && row["n_AlarmMonths"].ToString()!="")
				{
					model.n_AlarmMonths=int.Parse(row["n_AlarmMonths"].ToString());
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["s_PayMode"]!=null)
				{
					model.s_PayMode=row["s_PayMode"].ToString();
				}
				if(row["s_StatusOrder"]!=null)
				{
					model.s_StatusOrder=row["s_StatusOrder"].ToString();
				}
				if(row["s_StatusInit"]!=null)
				{
					model.s_StatusInit=row["s_StatusInit"].ToString();
				}
				if(row["n_ChargeCurrency"]!=null && row["n_ChargeCurrency"].ToString()!="")
				{
					model.n_ChargeCurrency=int.Parse(row["n_ChargeCurrency"].ToString());
				}
				if(row["n_OfficialCurrency"]!=null && row["n_OfficialCurrency"].ToString()!="")
				{
					model.n_OfficialCurrency=int.Parse(row["n_OfficialCurrency"].ToString());
				}
				if(row["s_FeeMode"]!=null)
				{
					model.s_FeeMode=row["s_FeeMode"].ToString();
				}
				if(row["n_FeeDiscount"]!=null && row["n_FeeDiscount"].ToString()!="")
				{
					model.n_FeeDiscount=decimal.Parse(row["n_FeeDiscount"].ToString());
				}
				if(row["n_FixAFee"]!=null && row["n_FixAFee"].ToString()!="")
				{
					model.n_FixAFee=decimal.Parse(row["n_FixAFee"].ToString());
				}
				if(row["n_FixFee"]!=null && row["n_FixFee"].ToString()!="")
				{
					model.n_FixFee=decimal.Parse(row["n_FixFee"].ToString());
				}
				if(row["n_CountPayYear"]!=null && row["n_CountPayYear"].ToString()!="")
				{
					model.n_CountPayYear=int.Parse(row["n_CountPayYear"].ToString());
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
			strSql.Append("select n_ID,n_CaseID,s_OfficialDiscStyle,n_OfficialDiscount,n_DiscYears,n_FstPayYear,n_LastPayYear,n_AlarmMonths,s_Notes,s_PayMode,s_StatusOrder,s_StatusInit,n_ChargeCurrency,n_OfficialCurrency,s_FeeMode,n_FeeDiscount,n_FixAFee,n_FixFee,n_CountPayYear ");
			strSql.Append(" FROM TPCase_AnnFeeStage ");
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
			strSql.Append(" n_ID,n_CaseID,s_OfficialDiscStyle,n_OfficialDiscount,n_DiscYears,n_FstPayYear,n_LastPayYear,n_AlarmMonths,s_Notes,s_PayMode,s_StatusOrder,s_StatusInit,n_ChargeCurrency,n_OfficialCurrency,s_FeeMode,n_FeeDiscount,n_FixAFee,n_FixFee,n_CountPayYear ");
			strSql.Append(" FROM TPCase_AnnFeeStage ");
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
			strSql.Append("select count(1) FROM TPCase_AnnFeeStage ");
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
			strSql.Append(")AS Row, T.*  from TPCase_AnnFeeStage T ");
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
			parameters[0].Value = "TPCase_AnnFeeStage";
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

