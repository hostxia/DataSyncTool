/**  版本信息模板在安装目录下，可自行修改。
* TCode_AnnualFeeItem.cs
*
* 功 能： N/A
* 类 名： TCode_AnnualFeeItem
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:46   N/A    初版
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
	/// 数据访问类:TCode_AnnualFeeItem
	/// </summary>
	public partial class TCode_AnnualFeeItem
	{
		public TCode_AnnualFeeItem()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_AnnualFeeCodeID", "TCode_AnnualFeeItem"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_AnnualFeeCodeID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_AnnualFeeItem");
			strSql.Append(" where n_AnnualFeeCodeID=@n_AnnualFeeCodeID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AnnualFeeCodeID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_AnnualFeeCodeID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_AnnualFeeItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_AnnualFeeItem(");
			strSql.Append("n_AnnualFeeCodeID,n_ChargeCurrency,n_ChargeOFee,n_ChargeUnitFee,n_ChargeAFee)");
			strSql.Append(" values (");
			strSql.Append("@n_AnnualFeeCodeID,@n_ChargeCurrency,@n_ChargeOFee,@n_ChargeUnitFee,@n_ChargeAFee)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AnnualFeeCodeID", SqlDbType.Int,4),
					new SqlParameter("@n_ChargeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_ChargeOFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_ChargeUnitFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_ChargeAFee", SqlDbType.Decimal,9)};
			parameters[0].Value = model.n_AnnualFeeCodeID;
			parameters[1].Value = model.n_ChargeCurrency;
			parameters[2].Value = model.n_ChargeOFee;
			parameters[3].Value = model.n_ChargeUnitFee;
			parameters[4].Value = model.n_ChargeAFee;

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
		public bool Update(IPSP.Model.TCode_AnnualFeeItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_AnnualFeeItem set ");
			strSql.Append("n_ChargeCurrency=@n_ChargeCurrency,");
			strSql.Append("n_ChargeOFee=@n_ChargeOFee,");
			strSql.Append("n_ChargeUnitFee=@n_ChargeUnitFee,");
			strSql.Append("n_ChargeAFee=@n_ChargeAFee");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ChargeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_ChargeOFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_ChargeUnitFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_ChargeAFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_AnnualFeeCodeID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_ChargeCurrency;
			parameters[1].Value = model.n_ChargeOFee;
			parameters[2].Value = model.n_ChargeUnitFee;
			parameters[3].Value = model.n_ChargeAFee;
			parameters[4].Value = model.n_ID;
			parameters[5].Value = model.n_AnnualFeeCodeID;

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
			strSql.Append("delete from TCode_AnnualFeeItem ");
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(int n_AnnualFeeCodeID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_AnnualFeeItem ");
			strSql.Append(" where n_AnnualFeeCodeID=@n_AnnualFeeCodeID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AnnualFeeCodeID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_AnnualFeeCodeID;
			parameters[1].Value = n_ID;

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
			strSql.Append("delete from TCode_AnnualFeeItem ");
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
		public IPSP.Model.TCode_AnnualFeeItem GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_AnnualFeeCodeID,n_ChargeCurrency,n_ChargeOFee,n_ChargeUnitFee,n_ChargeAFee from TCode_AnnualFeeItem ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_AnnualFeeItem model=new IPSP.Model.TCode_AnnualFeeItem();
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
		public IPSP.Model.TCode_AnnualFeeItem DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_AnnualFeeItem model=new IPSP.Model.TCode_AnnualFeeItem();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_AnnualFeeCodeID"]!=null && row["n_AnnualFeeCodeID"].ToString()!="")
				{
					model.n_AnnualFeeCodeID=int.Parse(row["n_AnnualFeeCodeID"].ToString());
				}
				if(row["n_ChargeCurrency"]!=null && row["n_ChargeCurrency"].ToString()!="")
				{
					model.n_ChargeCurrency=int.Parse(row["n_ChargeCurrency"].ToString());
				}
				if(row["n_ChargeOFee"]!=null && row["n_ChargeOFee"].ToString()!="")
				{
					model.n_ChargeOFee=decimal.Parse(row["n_ChargeOFee"].ToString());
				}
				if(row["n_ChargeUnitFee"]!=null && row["n_ChargeUnitFee"].ToString()!="")
				{
					model.n_ChargeUnitFee=decimal.Parse(row["n_ChargeUnitFee"].ToString());
				}
				if(row["n_ChargeAFee"]!=null && row["n_ChargeAFee"].ToString()!="")
				{
					model.n_ChargeAFee=decimal.Parse(row["n_ChargeAFee"].ToString());
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
			strSql.Append("select n_ID,n_AnnualFeeCodeID,n_ChargeCurrency,n_ChargeOFee,n_ChargeUnitFee,n_ChargeAFee ");
			strSql.Append(" FROM TCode_AnnualFeeItem ");
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
			strSql.Append(" n_ID,n_AnnualFeeCodeID,n_ChargeCurrency,n_ChargeOFee,n_ChargeUnitFee,n_ChargeAFee ");
			strSql.Append(" FROM TCode_AnnualFeeItem ");
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
			strSql.Append("select count(1) FROM TCode_AnnualFeeItem ");
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
			strSql.Append(")AS Row, T.*  from TCode_AnnualFeeItem T ");
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
			parameters[0].Value = "TCode_AnnualFeeItem";
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

