/**  版本信息模板在安装目录下，可自行修改。
* TPCase_PermitMemo.cs
*
* 功 能： N/A
* 类 名： TPCase_PermitMemo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:40   N/A    初版
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
	/// 数据访问类:TPCase_PermitMemo
	/// </summary>
	public partial class TPCase_PermitMemo
	{
		public TPCase_PermitMemo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TPCase_PermitMemo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPCase_PermitMemo");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TPCase_PermitMemo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPCase_PermitMemo(");
			strSql.Append("n_CaseID,s_MemoNum,dt_MemoDate,dt_MemoBeginDate,dt_MemoEndDate,s_Type,s_FulFilAddr,dt_ContractDate,n_UseFee,n_UseFeeCurrency,s_Property)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@s_MemoNum,@dt_MemoDate,@dt_MemoBeginDate,@dt_MemoEndDate,@s_Type,@s_FulFilAddr,@dt_ContractDate,@n_UseFee,@n_UseFeeCurrency,@s_Property)");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_MemoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_MemoDate", SqlDbType.DateTime),
					new SqlParameter("@dt_MemoBeginDate", SqlDbType.DateTime),
					new SqlParameter("@dt_MemoEndDate", SqlDbType.DateTime),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FulFilAddr", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_ContractDate", SqlDbType.DateTime),
					new SqlParameter("@n_UseFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_UseFeeCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_Property", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_MemoNum;
			parameters[2].Value = model.dt_MemoDate;
			parameters[3].Value = model.dt_MemoBeginDate;
			parameters[4].Value = model.dt_MemoEndDate;
			parameters[5].Value = model.s_Type;
			parameters[6].Value = model.s_FulFilAddr;
			parameters[7].Value = model.dt_ContractDate;
			parameters[8].Value = model.n_UseFee;
			parameters[9].Value = model.n_UseFeeCurrency;
			parameters[10].Value = model.s_Property;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(IPSP.Model.TPCase_PermitMemo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPCase_PermitMemo set ");
			strSql.Append("s_MemoNum=@s_MemoNum,");
			strSql.Append("dt_MemoDate=@dt_MemoDate,");
			strSql.Append("dt_MemoBeginDate=@dt_MemoBeginDate,");
			strSql.Append("dt_MemoEndDate=@dt_MemoEndDate,");
			strSql.Append("s_Type=@s_Type,");
			strSql.Append("s_FulFilAddr=@s_FulFilAddr,");
			strSql.Append("dt_ContractDate=@dt_ContractDate,");
			strSql.Append("n_UseFee=@n_UseFee,");
			strSql.Append("n_UseFeeCurrency=@n_UseFeeCurrency,");
			strSql.Append("s_Property=@s_Property");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_MemoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_MemoDate", SqlDbType.DateTime),
					new SqlParameter("@dt_MemoBeginDate", SqlDbType.DateTime),
					new SqlParameter("@dt_MemoEndDate", SqlDbType.DateTime),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FulFilAddr", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_ContractDate", SqlDbType.DateTime),
					new SqlParameter("@n_UseFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_UseFeeCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_Property", SqlDbType.NVarChar,50),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_MemoNum;
			parameters[1].Value = model.dt_MemoDate;
			parameters[2].Value = model.dt_MemoBeginDate;
			parameters[3].Value = model.dt_MemoEndDate;
			parameters[4].Value = model.s_Type;
			parameters[5].Value = model.s_FulFilAddr;
			parameters[6].Value = model.dt_ContractDate;
			parameters[7].Value = model.n_UseFee;
			parameters[8].Value = model.n_UseFeeCurrency;
			parameters[9].Value = model.s_Property;
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
		public bool Delete(int n_CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPCase_PermitMemo ");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

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
		public bool DeleteList(string n_CaseIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPCase_PermitMemo ");
			strSql.Append(" where n_CaseID in ("+n_CaseIDlist + ")  ");
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
		public IPSP.Model.TPCase_PermitMemo GetModel(int n_CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_CaseID,s_MemoNum,dt_MemoDate,dt_MemoBeginDate,dt_MemoEndDate,s_Type,s_FulFilAddr,dt_ContractDate,n_UseFee,n_UseFeeCurrency,s_Property from TPCase_PermitMemo ");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

			IPSP.Model.TPCase_PermitMemo model=new IPSP.Model.TPCase_PermitMemo();
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
		public IPSP.Model.TPCase_PermitMemo DataRowToModel(DataRow row)
		{
			IPSP.Model.TPCase_PermitMemo model=new IPSP.Model.TPCase_PermitMemo();
			if (row != null)
			{
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["s_MemoNum"]!=null)
				{
					model.s_MemoNum=row["s_MemoNum"].ToString();
				}
				if(row["dt_MemoDate"]!=null && row["dt_MemoDate"].ToString()!="")
				{
					model.dt_MemoDate=DateTime.Parse(row["dt_MemoDate"].ToString());
				}
				if(row["dt_MemoBeginDate"]!=null && row["dt_MemoBeginDate"].ToString()!="")
				{
					model.dt_MemoBeginDate=DateTime.Parse(row["dt_MemoBeginDate"].ToString());
				}
				if(row["dt_MemoEndDate"]!=null && row["dt_MemoEndDate"].ToString()!="")
				{
					model.dt_MemoEndDate=DateTime.Parse(row["dt_MemoEndDate"].ToString());
				}
				if(row["s_Type"]!=null)
				{
					model.s_Type=row["s_Type"].ToString();
				}
				if(row["s_FulFilAddr"]!=null)
				{
					model.s_FulFilAddr=row["s_FulFilAddr"].ToString();
				}
				if(row["dt_ContractDate"]!=null && row["dt_ContractDate"].ToString()!="")
				{
					model.dt_ContractDate=DateTime.Parse(row["dt_ContractDate"].ToString());
				}
				if(row["n_UseFee"]!=null && row["n_UseFee"].ToString()!="")
				{
					model.n_UseFee=decimal.Parse(row["n_UseFee"].ToString());
				}
				if(row["n_UseFeeCurrency"]!=null && row["n_UseFeeCurrency"].ToString()!="")
				{
					model.n_UseFeeCurrency=int.Parse(row["n_UseFeeCurrency"].ToString());
				}
				if(row["s_Property"]!=null)
				{
					model.s_Property=row["s_Property"].ToString();
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
			strSql.Append("select n_CaseID,s_MemoNum,dt_MemoDate,dt_MemoBeginDate,dt_MemoEndDate,s_Type,s_FulFilAddr,dt_ContractDate,n_UseFee,n_UseFeeCurrency,s_Property ");
			strSql.Append(" FROM TPCase_PermitMemo ");
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
			strSql.Append(" n_CaseID,s_MemoNum,dt_MemoDate,dt_MemoBeginDate,dt_MemoEndDate,s_Type,s_FulFilAddr,dt_ContractDate,n_UseFee,n_UseFeeCurrency,s_Property ");
			strSql.Append(" FROM TPCase_PermitMemo ");
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
			strSql.Append("select count(1) FROM TPCase_PermitMemo ");
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
				strSql.Append("order by T.n_CaseID desc");
			}
			strSql.Append(")AS Row, T.*  from TPCase_PermitMemo T ");
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
			parameters[0].Value = "TPCase_PermitMemo";
			parameters[1].Value = "n_CaseID";
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

