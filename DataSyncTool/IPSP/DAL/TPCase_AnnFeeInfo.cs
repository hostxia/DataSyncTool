/**  版本信息模板在安装目录下，可自行修改。
* TPCase_AnnFeeInfo.cs
*
* 功 能： N/A
* 类 名： TPCase_AnnFeeInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:11   N/A    初版
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
	/// 数据访问类:TPCase_AnnFeeInfo
	/// </summary>
	public partial class TPCase_AnnFeeInfo
	{
		public TPCase_AnnFeeInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TPCase_AnnFeeInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPCase_AnnFeeInfo");
			strSql.Append(" where n_CaseID=@n_CaseID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TPCase_AnnFeeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPCase_AnnFeeInfo(");
			strSql.Append("n_CaseID,s_OfficialDiscStyle,n_OfficialDiscount,n_DiscYears,n_FstPayYear,n_LastPayYear,n_AlarmMonths,dt_FstPayYear,dt_LastPayYear,n_CountPayYear)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@s_OfficialDiscStyle,@n_OfficialDiscount,@n_DiscYears,@n_FstPayYear,@n_LastPayYear,@n_AlarmMonths,@dt_FstPayYear,@dt_LastPayYear,@n_CountPayYear)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_OfficialDiscStyle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_OfficialDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@n_DiscYears", SqlDbType.Int,4),
					new SqlParameter("@n_FstPayYear", SqlDbType.Int,4),
					new SqlParameter("@n_LastPayYear", SqlDbType.Int,4),
					new SqlParameter("@n_AlarmMonths", SqlDbType.Int,4),
					new SqlParameter("@dt_FstPayYear", SqlDbType.DateTime),
					new SqlParameter("@dt_LastPayYear", SqlDbType.DateTime),
					new SqlParameter("@n_CountPayYear", SqlDbType.Int,4)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_OfficialDiscStyle;
			parameters[2].Value = model.n_OfficialDiscount;
			parameters[3].Value = model.n_DiscYears;
			parameters[4].Value = model.n_FstPayYear;
			parameters[5].Value = model.n_LastPayYear;
			parameters[6].Value = model.n_AlarmMonths;
			parameters[7].Value = model.dt_FstPayYear;
			parameters[8].Value = model.dt_LastPayYear;
			parameters[9].Value = model.n_CountPayYear;

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
		public bool Update(IPSP.Model.TPCase_AnnFeeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPCase_AnnFeeInfo set ");
			strSql.Append("s_OfficialDiscStyle=@s_OfficialDiscStyle,");
			strSql.Append("n_OfficialDiscount=@n_OfficialDiscount,");
			strSql.Append("n_DiscYears=@n_DiscYears,");
			strSql.Append("n_FstPayYear=@n_FstPayYear,");
			strSql.Append("n_LastPayYear=@n_LastPayYear,");
			strSql.Append("n_AlarmMonths=@n_AlarmMonths,");
			strSql.Append("dt_FstPayYear=@dt_FstPayYear,");
			strSql.Append("dt_LastPayYear=@dt_LastPayYear,");
			strSql.Append("n_CountPayYear=@n_CountPayYear");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_OfficialDiscStyle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_OfficialDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@n_DiscYears", SqlDbType.Int,4),
					new SqlParameter("@n_FstPayYear", SqlDbType.Int,4),
					new SqlParameter("@n_LastPayYear", SqlDbType.Int,4),
					new SqlParameter("@n_AlarmMonths", SqlDbType.Int,4),
					new SqlParameter("@dt_FstPayYear", SqlDbType.DateTime),
					new SqlParameter("@dt_LastPayYear", SqlDbType.DateTime),
					new SqlParameter("@n_CountPayYear", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_OfficialDiscStyle;
			parameters[1].Value = model.n_OfficialDiscount;
			parameters[2].Value = model.n_DiscYears;
			parameters[3].Value = model.n_FstPayYear;
			parameters[4].Value = model.n_LastPayYear;
			parameters[5].Value = model.n_AlarmMonths;
			parameters[6].Value = model.dt_FstPayYear;
			parameters[7].Value = model.dt_LastPayYear;
			parameters[8].Value = model.n_CountPayYear;
			parameters[9].Value = model.n_ID;
			parameters[10].Value = model.n_CaseID;

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
			strSql.Append("delete from TPCase_AnnFeeInfo ");
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
		public bool Delete(int n_CaseID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPCase_AnnFeeInfo ");
			strSql.Append(" where n_CaseID=@n_CaseID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
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
			strSql.Append("delete from TPCase_AnnFeeInfo ");
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
		public IPSP.Model.TPCase_AnnFeeInfo GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CaseID,s_OfficialDiscStyle,n_OfficialDiscount,n_DiscYears,n_FstPayYear,n_LastPayYear,n_AlarmMonths,dt_FstPayYear,dt_LastPayYear,n_CountPayYear from TPCase_AnnFeeInfo ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TPCase_AnnFeeInfo model=new IPSP.Model.TPCase_AnnFeeInfo();
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
		public IPSP.Model.TPCase_AnnFeeInfo DataRowToModel(DataRow row)
		{
			IPSP.Model.TPCase_AnnFeeInfo model=new IPSP.Model.TPCase_AnnFeeInfo();
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
				if(row["dt_FstPayYear"]!=null && row["dt_FstPayYear"].ToString()!="")
				{
					model.dt_FstPayYear=DateTime.Parse(row["dt_FstPayYear"].ToString());
				}
				if(row["dt_LastPayYear"]!=null && row["dt_LastPayYear"].ToString()!="")
				{
					model.dt_LastPayYear=DateTime.Parse(row["dt_LastPayYear"].ToString());
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
			strSql.Append("select n_ID,n_CaseID,s_OfficialDiscStyle,n_OfficialDiscount,n_DiscYears,n_FstPayYear,n_LastPayYear,n_AlarmMonths,dt_FstPayYear,dt_LastPayYear,n_CountPayYear ");
			strSql.Append(" FROM TPCase_AnnFeeInfo ");
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
			strSql.Append(" n_ID,n_CaseID,s_OfficialDiscStyle,n_OfficialDiscount,n_DiscYears,n_FstPayYear,n_LastPayYear,n_AlarmMonths,dt_FstPayYear,dt_LastPayYear,n_CountPayYear ");
			strSql.Append(" FROM TPCase_AnnFeeInfo ");
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
			strSql.Append("select count(1) FROM TPCase_AnnFeeInfo ");
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
			strSql.Append(")AS Row, T.*  from TPCase_AnnFeeInfo T ");
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
			parameters[0].Value = "TPCase_AnnFeeInfo";
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

