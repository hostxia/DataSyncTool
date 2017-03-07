/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_ClientFeePolicy.cs
*
* 功 能： N/A
* 类 名： TCstmr_ClientFeePolicy
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:48   N/A    初版
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
	/// 数据访问类:TCstmr_ClientFeePolicy
	/// </summary>
	public partial class TCstmr_ClientFeePolicy
	{
		public TCstmr_ClientFeePolicy()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ClientID", "TCstmr_ClientFeePolicy"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ClientID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCstmr_ClientFeePolicy");
			strSql.Append(" where n_ClientID=@n_ClientID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCstmr_ClientFeePolicy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCstmr_ClientFeePolicy(");
			strSql.Append("n_ClientID,n_ChargeCurrency,s_IPType,s_FeeMode,n_Value,s_Note,dt_EditDate,n_PayUnit,s_IPRole,s_FeeType,n_EndProcess,s_BusinessType,s_PTCType)");
			strSql.Append(" values (");
			strSql.Append("@n_ClientID,@n_ChargeCurrency,@s_IPType,@s_FeeMode,@n_Value,@s_Note,@dt_EditDate,@n_PayUnit,@s_IPRole,@s_FeeType,@n_EndProcess,@s_BusinessType,@s_PTCType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ChargeCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FeeMode", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Value", SqlDbType.Decimal,9),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,300),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_PayUnit", SqlDbType.Int,4),
					new SqlParameter("@s_IPRole", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FeeType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_EndProcess", SqlDbType.Int,4),
					new SqlParameter("@s_BusinessType", SqlDbType.VarChar,200),
					new SqlParameter("@s_PTCType", SqlDbType.VarChar,50)};
			parameters[0].Value = model.n_ClientID;
			parameters[1].Value = model.n_ChargeCurrency;
			parameters[2].Value = model.s_IPType;
			parameters[3].Value = model.s_FeeMode;
			parameters[4].Value = model.n_Value;
			parameters[5].Value = model.s_Note;
			parameters[6].Value = model.dt_EditDate;
			parameters[7].Value = model.n_PayUnit;
			parameters[8].Value = model.s_IPRole;
			parameters[9].Value = model.s_FeeType;
			parameters[10].Value = model.n_EndProcess;
			parameters[11].Value = model.s_BusinessType;
			parameters[12].Value = model.s_PTCType;

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
		public bool Update(IPSP.Model.TCstmr_ClientFeePolicy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCstmr_ClientFeePolicy set ");
			strSql.Append("n_ChargeCurrency=@n_ChargeCurrency,");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_FeeMode=@s_FeeMode,");
			strSql.Append("n_Value=@n_Value,");
			strSql.Append("s_Note=@s_Note,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("n_PayUnit=@n_PayUnit,");
			strSql.Append("s_IPRole=@s_IPRole,");
			strSql.Append("s_FeeType=@s_FeeType,");
			strSql.Append("n_EndProcess=@n_EndProcess,");
			strSql.Append("s_BusinessType=@s_BusinessType,");
			strSql.Append("s_PTCType=@s_PTCType");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ChargeCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FeeMode", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Value", SqlDbType.Decimal,9),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,300),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_PayUnit", SqlDbType.Int,4),
					new SqlParameter("@s_IPRole", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FeeType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_EndProcess", SqlDbType.Int,4),
					new SqlParameter("@s_BusinessType", SqlDbType.VarChar,200),
					new SqlParameter("@s_PTCType", SqlDbType.VarChar,50),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_ChargeCurrency;
			parameters[1].Value = model.s_IPType;
			parameters[2].Value = model.s_FeeMode;
			parameters[3].Value = model.n_Value;
			parameters[4].Value = model.s_Note;
			parameters[5].Value = model.dt_EditDate;
			parameters[6].Value = model.n_PayUnit;
			parameters[7].Value = model.s_IPRole;
			parameters[8].Value = model.s_FeeType;
			parameters[9].Value = model.n_EndProcess;
			parameters[10].Value = model.s_BusinessType;
			parameters[11].Value = model.s_PTCType;
			parameters[12].Value = model.n_ID;
			parameters[13].Value = model.n_ClientID;

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
			strSql.Append("delete from TCstmr_ClientFeePolicy ");
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
		public bool Delete(int n_ClientID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_ClientFeePolicy ");
			strSql.Append(" where n_ClientID=@n_ClientID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
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
			strSql.Append("delete from TCstmr_ClientFeePolicy ");
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
		public IPSP.Model.TCstmr_ClientFeePolicy GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_ClientID,n_ChargeCurrency,s_IPType,s_FeeMode,n_Value,s_Note,dt_EditDate,n_PayUnit,s_IPRole,s_FeeType,n_EndProcess,s_BusinessType,s_PTCType from TCstmr_ClientFeePolicy ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCstmr_ClientFeePolicy model=new IPSP.Model.TCstmr_ClientFeePolicy();
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
		public IPSP.Model.TCstmr_ClientFeePolicy DataRowToModel(DataRow row)
		{
			IPSP.Model.TCstmr_ClientFeePolicy model=new IPSP.Model.TCstmr_ClientFeePolicy();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["n_ChargeCurrency"]!=null && row["n_ChargeCurrency"].ToString()!="")
				{
					model.n_ChargeCurrency=int.Parse(row["n_ChargeCurrency"].ToString());
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["s_FeeMode"]!=null)
				{
					model.s_FeeMode=row["s_FeeMode"].ToString();
				}
				if(row["n_Value"]!=null && row["n_Value"].ToString()!="")
				{
					model.n_Value=decimal.Parse(row["n_Value"].ToString());
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["n_PayUnit"]!=null && row["n_PayUnit"].ToString()!="")
				{
					model.n_PayUnit=int.Parse(row["n_PayUnit"].ToString());
				}
				if(row["s_IPRole"]!=null)
				{
					model.s_IPRole=row["s_IPRole"].ToString();
				}
				if(row["s_FeeType"]!=null)
				{
					model.s_FeeType=row["s_FeeType"].ToString();
				}
				if(row["n_EndProcess"]!=null && row["n_EndProcess"].ToString()!="")
				{
					model.n_EndProcess=int.Parse(row["n_EndProcess"].ToString());
				}
				if(row["s_BusinessType"]!=null)
				{
					model.s_BusinessType=row["s_BusinessType"].ToString();
				}
				if(row["s_PTCType"]!=null)
				{
					model.s_PTCType=row["s_PTCType"].ToString();
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
			strSql.Append("select n_ID,n_ClientID,n_ChargeCurrency,s_IPType,s_FeeMode,n_Value,s_Note,dt_EditDate,n_PayUnit,s_IPRole,s_FeeType,n_EndProcess,s_BusinessType,s_PTCType ");
			strSql.Append(" FROM TCstmr_ClientFeePolicy ");
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
			strSql.Append(" n_ID,n_ClientID,n_ChargeCurrency,s_IPType,s_FeeMode,n_Value,s_Note,dt_EditDate,n_PayUnit,s_IPRole,s_FeeType,n_EndProcess,s_BusinessType,s_PTCType ");
			strSql.Append(" FROM TCstmr_ClientFeePolicy ");
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
			strSql.Append("select count(1) FROM TCstmr_ClientFeePolicy ");
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
			strSql.Append(")AS Row, T.*  from TCstmr_ClientFeePolicy T ");
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
			parameters[0].Value = "TCstmr_ClientFeePolicy";
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

