/**  版本信息模板在安装目录下，可自行修改。
* T_BillPay.cs
*
* 功 能： N/A
* 类 名： T_BillPay
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:32   N/A    初版
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
	/// 数据访问类:T_BillPay
	/// </summary>
	public partial class T_BillPay
	{
		public T_BillPay()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CMoneyID", "T_BillPay"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CMoneyID,int n_ClientID,int n_BillID,int n_BillPayID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_BillPay");
			strSql.Append(" where n_CMoneyID=@n_CMoneyID and n_ClientID=@n_ClientID and n_BillID=@n_BillID and n_BillPayID=@n_BillPayID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CMoneyID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_BillPayID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CMoneyID;
			parameters[1].Value = n_ClientID;
			parameters[2].Value = n_BillID;
			parameters[3].Value = n_BillPayID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_BillPay model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_BillPay(");
			strSql.Append("n_CMoneyID,n_ClientID,n_BillID,n_PayCurrencyID)");
			strSql.Append(" values (");
			strSql.Append("@n_CMoneyID,@n_ClientID,@n_BillID,@n_PayCurrencyID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CMoneyID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_PayCurrencyID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_CMoneyID;
			parameters[1].Value = model.n_ClientID;
			parameters[2].Value = model.n_BillID;
			parameters[3].Value = model.n_PayCurrencyID;

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
		public bool Update(IPSP.Model.T_BillPay model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_BillPay set ");
			strSql.Append("n_PayCurrencyID=@n_PayCurrencyID");
			strSql.Append(" where n_BillPayID=@n_BillPayID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_PayCurrencyID", SqlDbType.Int,4),
					new SqlParameter("@n_BillPayID", SqlDbType.Int,4),
					new SqlParameter("@n_CMoneyID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_PayCurrencyID;
			parameters[1].Value = model.n_BillPayID;
			parameters[2].Value = model.n_CMoneyID;
			parameters[3].Value = model.n_ClientID;
			parameters[4].Value = model.n_BillID;

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
		public bool Delete(int n_BillPayID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_BillPay ");
			strSql.Append(" where n_BillPayID=@n_BillPayID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillPayID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_BillPayID;

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
		public bool Delete(int n_CMoneyID,int n_ClientID,int n_BillID,int n_BillPayID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_BillPay ");
			strSql.Append(" where n_CMoneyID=@n_CMoneyID and n_ClientID=@n_ClientID and n_BillID=@n_BillID and n_BillPayID=@n_BillPayID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CMoneyID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_BillPayID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CMoneyID;
			parameters[1].Value = n_ClientID;
			parameters[2].Value = n_BillID;
			parameters[3].Value = n_BillPayID;

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
		public bool DeleteList(string n_BillPayIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_BillPay ");
			strSql.Append(" where n_BillPayID in ("+n_BillPayIDlist + ")  ");
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
		public IPSP.Model.T_BillPay GetModel(int n_BillPayID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_BillPayID,n_CMoneyID,n_ClientID,n_BillID,n_PayCurrencyID from T_BillPay ");
			strSql.Append(" where n_BillPayID=@n_BillPayID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillPayID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_BillPayID;

			IPSP.Model.T_BillPay model=new IPSP.Model.T_BillPay();
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
		public IPSP.Model.T_BillPay DataRowToModel(DataRow row)
		{
			IPSP.Model.T_BillPay model=new IPSP.Model.T_BillPay();
			if (row != null)
			{
				if(row["n_BillPayID"]!=null && row["n_BillPayID"].ToString()!="")
				{
					model.n_BillPayID=int.Parse(row["n_BillPayID"].ToString());
				}
				if(row["n_CMoneyID"]!=null && row["n_CMoneyID"].ToString()!="")
				{
					model.n_CMoneyID=int.Parse(row["n_CMoneyID"].ToString());
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["n_BillID"]!=null && row["n_BillID"].ToString()!="")
				{
					model.n_BillID=int.Parse(row["n_BillID"].ToString());
				}
				if(row["n_PayCurrencyID"]!=null && row["n_PayCurrencyID"].ToString()!="")
				{
					model.n_PayCurrencyID=int.Parse(row["n_PayCurrencyID"].ToString());
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
			strSql.Append("select n_BillPayID,n_CMoneyID,n_ClientID,n_BillID,n_PayCurrencyID ");
			strSql.Append(" FROM T_BillPay ");
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
			strSql.Append(" n_BillPayID,n_CMoneyID,n_ClientID,n_BillID,n_PayCurrencyID ");
			strSql.Append(" FROM T_BillPay ");
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
			strSql.Append("select count(1) FROM T_BillPay ");
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
				strSql.Append("order by T.n_BillPayID desc");
			}
			strSql.Append(")AS Row, T.*  from T_BillPay T ");
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
			parameters[0].Value = "T_BillPay";
			parameters[1].Value = "n_BillPayID";
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

