﻿/**  版本信息模板在安装目录下，可自行修改。
* TCode_PreferentialPolicy.cs
*
* 功 能： N/A
* 类 名： TCode_PreferentialPolicy
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:44   N/A    初版
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
	/// 数据访问类:TCode_PreferentialPolicy
	/// </summary>
	public partial class TCode_PreferentialPolicy
	{
		public TCode_PreferentialPolicy()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TCode_PreferentialPolicy"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_PreferentialPolicy");
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
		public int Add(IPSP.Model.TCode_PreferentialPolicy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_PreferentialPolicy(");
			strSql.Append("s_IPType,s_Name,s_PreferentialPolicyType,n_PreferentialPolicySubType,s_DiscountType,n_Discount,n_Currency,s_Notes,dt_CreateDate,dt_EditDate,s_Creator,s_Editor,s_PreferentialPolicySubType)");
			strSql.Append(" values (");
			strSql.Append("@s_IPType,@s_Name,@s_PreferentialPolicyType,@n_PreferentialPolicySubType,@s_DiscountType,@n_Discount,@n_Currency,@s_Notes,@dt_CreateDate,@dt_EditDate,@s_Creator,@s_Editor,@s_PreferentialPolicySubType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,500),
					new SqlParameter("@s_PreferentialPolicyType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_PreferentialPolicySubType", SqlDbType.Int,4),
					new SqlParameter("@s_DiscountType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Discount", SqlDbType.Money,8),
					new SqlParameter("@n_Currency", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PreferentialPolicySubType", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_PreferentialPolicyType;
			parameters[3].Value = model.n_PreferentialPolicySubType;
			parameters[4].Value = model.s_DiscountType;
			parameters[5].Value = model.n_Discount;
			parameters[6].Value = model.n_Currency;
			parameters[7].Value = model.s_Notes;
			parameters[8].Value = model.dt_CreateDate;
			parameters[9].Value = model.dt_EditDate;
			parameters[10].Value = model.s_Creator;
			parameters[11].Value = model.s_Editor;
			parameters[12].Value = model.s_PreferentialPolicySubType;

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
		public bool Update(IPSP.Model.TCode_PreferentialPolicy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_PreferentialPolicy set ");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_PreferentialPolicyType=@s_PreferentialPolicyType,");
			strSql.Append("n_PreferentialPolicySubType=@n_PreferentialPolicySubType,");
			strSql.Append("s_DiscountType=@s_DiscountType,");
			strSql.Append("n_Discount=@n_Discount,");
			strSql.Append("n_Currency=@n_Currency,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("s_PreferentialPolicySubType=@s_PreferentialPolicySubType");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,500),
					new SqlParameter("@s_PreferentialPolicyType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_PreferentialPolicySubType", SqlDbType.Int,4),
					new SqlParameter("@s_DiscountType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Discount", SqlDbType.Money,8),
					new SqlParameter("@n_Currency", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PreferentialPolicySubType", SqlDbType.NVarChar,200),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_PreferentialPolicyType;
			parameters[3].Value = model.n_PreferentialPolicySubType;
			parameters[4].Value = model.s_DiscountType;
			parameters[5].Value = model.n_Discount;
			parameters[6].Value = model.n_Currency;
			parameters[7].Value = model.s_Notes;
			parameters[8].Value = model.dt_CreateDate;
			parameters[9].Value = model.dt_EditDate;
			parameters[10].Value = model.s_Creator;
			parameters[11].Value = model.s_Editor;
			parameters[12].Value = model.s_PreferentialPolicySubType;
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
			strSql.Append("delete from TCode_PreferentialPolicy ");
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
			strSql.Append("delete from TCode_PreferentialPolicy ");
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
		public IPSP.Model.TCode_PreferentialPolicy GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_IPType,s_Name,s_PreferentialPolicyType,n_PreferentialPolicySubType,s_DiscountType,n_Discount,n_Currency,s_Notes,dt_CreateDate,dt_EditDate,s_Creator,s_Editor,s_PreferentialPolicySubType from TCode_PreferentialPolicy ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_PreferentialPolicy model=new IPSP.Model.TCode_PreferentialPolicy();
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
		public IPSP.Model.TCode_PreferentialPolicy DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_PreferentialPolicy model=new IPSP.Model.TCode_PreferentialPolicy();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_PreferentialPolicyType"]!=null)
				{
					model.s_PreferentialPolicyType=row["s_PreferentialPolicyType"].ToString();
				}
				if(row["n_PreferentialPolicySubType"]!=null && row["n_PreferentialPolicySubType"].ToString()!="")
				{
					model.n_PreferentialPolicySubType=int.Parse(row["n_PreferentialPolicySubType"].ToString());
				}
				if(row["s_DiscountType"]!=null)
				{
					model.s_DiscountType=row["s_DiscountType"].ToString();
				}
				if(row["n_Discount"]!=null && row["n_Discount"].ToString()!="")
				{
					model.n_Discount=decimal.Parse(row["n_Discount"].ToString());
				}
				if(row["n_Currency"]!=null && row["n_Currency"].ToString()!="")
				{
					model.n_Currency=int.Parse(row["n_Currency"].ToString());
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
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["s_PreferentialPolicySubType"]!=null)
				{
					model.s_PreferentialPolicySubType=row["s_PreferentialPolicySubType"].ToString();
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
			strSql.Append("select n_ID,s_IPType,s_Name,s_PreferentialPolicyType,n_PreferentialPolicySubType,s_DiscountType,n_Discount,n_Currency,s_Notes,dt_CreateDate,dt_EditDate,s_Creator,s_Editor,s_PreferentialPolicySubType ");
			strSql.Append(" FROM TCode_PreferentialPolicy ");
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
			strSql.Append(" n_ID,s_IPType,s_Name,s_PreferentialPolicyType,n_PreferentialPolicySubType,s_DiscountType,n_Discount,n_Currency,s_Notes,dt_CreateDate,dt_EditDate,s_Creator,s_Editor,s_PreferentialPolicySubType ");
			strSql.Append(" FROM TCode_PreferentialPolicy ");
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
			strSql.Append("select count(1) FROM TCode_PreferentialPolicy ");
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
			strSql.Append(")AS Row, T.*  from TCode_PreferentialPolicy T ");
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
			parameters[0].Value = "TCode_PreferentialPolicy";
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

