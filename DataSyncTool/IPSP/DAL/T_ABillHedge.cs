/**  版本信息模板在安装目录下，可自行修改。
* T_ABillHedge.cs
*
* 功 能： N/A
* 类 名： T_ABillHedge
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:27   N/A    初版
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
	/// 数据访问类:T_ABillHedge
	/// </summary>
	public partial class T_ABillHedge
	{
		public T_ABillHedge()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_AgencyID", "T_ABillHedge"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_AgencyID,int n_ClientID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_ABillHedge");
			strSql.Append(" where n_AgencyID=@n_AgencyID and n_ClientID=@n_ClientID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_AgencyID;
			parameters[1].Value = n_ClientID;
			parameters[2].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_ABillHedge model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_ABillHedge(");
			strSql.Append("n_AgencyID,n_ClientID,s_HedgeNo,dt_Hedge,n_Amount,n_CurrencyID,s_BalanceAmount,s_Editor,dt_EditTime,IsPutIntoWallet,dt_CreateDate,dt_EditDate,s_Creator)");
			strSql.Append(" values (");
			strSql.Append("@n_AgencyID,@n_ClientID,@s_HedgeNo,@dt_Hedge,@n_Amount,@n_CurrencyID,@s_BalanceAmount,@s_Editor,@dt_EditTime,@IsPutIntoWallet,@dt_CreateDate,@dt_EditDate,@s_Creator)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@s_HedgeNo", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_Hedge", SqlDbType.DateTime),
					new SqlParameter("@n_Amount", SqlDbType.Money,8),
					new SqlParameter("@n_CurrencyID", SqlDbType.Int,4),
					new SqlParameter("@s_BalanceAmount", SqlDbType.Money,8),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_EditTime", SqlDbType.DateTime),
					new SqlParameter("@IsPutIntoWallet", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.n_AgencyID;
			parameters[1].Value = model.n_ClientID;
			parameters[2].Value = model.s_HedgeNo;
			parameters[3].Value = model.dt_Hedge;
			parameters[4].Value = model.n_Amount;
			parameters[5].Value = model.n_CurrencyID;
			parameters[6].Value = model.s_BalanceAmount;
			parameters[7].Value = model.s_Editor;
			parameters[8].Value = model.dt_EditTime;
			parameters[9].Value = model.IsPutIntoWallet;
			parameters[10].Value = model.dt_CreateDate;
			parameters[11].Value = model.dt_EditDate;
			parameters[12].Value = model.s_Creator;

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
		public bool Update(IPSP.Model.T_ABillHedge model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_ABillHedge set ");
			strSql.Append("s_HedgeNo=@s_HedgeNo,");
			strSql.Append("dt_Hedge=@dt_Hedge,");
			strSql.Append("n_Amount=@n_Amount,");
			strSql.Append("n_CurrencyID=@n_CurrencyID,");
			strSql.Append("s_BalanceAmount=@s_BalanceAmount,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("dt_EditTime=@dt_EditTime,");
			strSql.Append("IsPutIntoWallet=@IsPutIntoWallet,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_Creator=@s_Creator");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_HedgeNo", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_Hedge", SqlDbType.DateTime),
					new SqlParameter("@n_Amount", SqlDbType.Money,8),
					new SqlParameter("@n_CurrencyID", SqlDbType.Int,4),
					new SqlParameter("@s_BalanceAmount", SqlDbType.Money,8),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_EditTime", SqlDbType.DateTime),
					new SqlParameter("@IsPutIntoWallet", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_HedgeNo;
			parameters[1].Value = model.dt_Hedge;
			parameters[2].Value = model.n_Amount;
			parameters[3].Value = model.n_CurrencyID;
			parameters[4].Value = model.s_BalanceAmount;
			parameters[5].Value = model.s_Editor;
			parameters[6].Value = model.dt_EditTime;
			parameters[7].Value = model.IsPutIntoWallet;
			parameters[8].Value = model.dt_CreateDate;
			parameters[9].Value = model.dt_EditDate;
			parameters[10].Value = model.s_Creator;
			parameters[11].Value = model.n_ID;
			parameters[12].Value = model.n_AgencyID;
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
			strSql.Append("delete from T_ABillHedge ");
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
		public bool Delete(int n_AgencyID,int n_ClientID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_ABillHedge ");
			strSql.Append(" where n_AgencyID=@n_AgencyID and n_ClientID=@n_ClientID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_AgencyID;
			parameters[1].Value = n_ClientID;
			parameters[2].Value = n_ID;

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
			strSql.Append("delete from T_ABillHedge ");
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
		public IPSP.Model.T_ABillHedge GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_AgencyID,n_ClientID,s_HedgeNo,dt_Hedge,n_Amount,n_CurrencyID,s_BalanceAmount,s_Editor,dt_EditTime,IsPutIntoWallet,dt_CreateDate,dt_EditDate,s_Creator from T_ABillHedge ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_ABillHedge model=new IPSP.Model.T_ABillHedge();
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
		public IPSP.Model.T_ABillHedge DataRowToModel(DataRow row)
		{
			IPSP.Model.T_ABillHedge model=new IPSP.Model.T_ABillHedge();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_AgencyID"]!=null && row["n_AgencyID"].ToString()!="")
				{
					model.n_AgencyID=int.Parse(row["n_AgencyID"].ToString());
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["s_HedgeNo"]!=null)
				{
					model.s_HedgeNo=row["s_HedgeNo"].ToString();
				}
				if(row["dt_Hedge"]!=null && row["dt_Hedge"].ToString()!="")
				{
					model.dt_Hedge=DateTime.Parse(row["dt_Hedge"].ToString());
				}
				if(row["n_Amount"]!=null && row["n_Amount"].ToString()!="")
				{
					model.n_Amount=decimal.Parse(row["n_Amount"].ToString());
				}
				if(row["n_CurrencyID"]!=null && row["n_CurrencyID"].ToString()!="")
				{
					model.n_CurrencyID=int.Parse(row["n_CurrencyID"].ToString());
				}
				if(row["s_BalanceAmount"]!=null && row["s_BalanceAmount"].ToString()!="")
				{
					model.s_BalanceAmount=decimal.Parse(row["s_BalanceAmount"].ToString());
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["dt_EditTime"]!=null && row["dt_EditTime"].ToString()!="")
				{
					model.dt_EditTime=DateTime.Parse(row["dt_EditTime"].ToString());
				}
				if(row["IsPutIntoWallet"]!=null)
				{
					model.IsPutIntoWallet=row["IsPutIntoWallet"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select n_ID,n_AgencyID,n_ClientID,s_HedgeNo,dt_Hedge,n_Amount,n_CurrencyID,s_BalanceAmount,s_Editor,dt_EditTime,IsPutIntoWallet,dt_CreateDate,dt_EditDate,s_Creator ");
			strSql.Append(" FROM T_ABillHedge ");
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
			strSql.Append(" n_ID,n_AgencyID,n_ClientID,s_HedgeNo,dt_Hedge,n_Amount,n_CurrencyID,s_BalanceAmount,s_Editor,dt_EditTime,IsPutIntoWallet,dt_CreateDate,dt_EditDate,s_Creator ");
			strSql.Append(" FROM T_ABillHedge ");
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
			strSql.Append("select count(1) FROM T_ABillHedge ");
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
			strSql.Append(")AS Row, T.*  from T_ABillHedge T ");
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
			parameters[0].Value = "T_ABillHedge";
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

