/**  版本信息模板在安装目录下，可自行修改。
* T_ABillPayment.cs
*
* 功 能： N/A
* 类 名： T_ABillPayment
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
	/// 数据访问类:T_ABillPayment
	/// </summary>
	public partial class T_ABillPayment
	{
		public T_ABillPayment()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_PayListID", "T_ABillPayment"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_PayListID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_ABillPayment");
			strSql.Append(" where n_PayListID=@n_PayListID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_PayListID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_PayListID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_ABillPayment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_ABillPayment(");
			strSql.Append("dt_PayDate,n_PaySum,s_PayBillNo,n_CurrencyID,n_ExchangeCurrency,n_ExRate,s_Dealer,s_Note,s_ReReceiptContent,dt_ReReceiptDate,s_Register,s_Lock,s_Locker,s_Editor,dt_CreateDate,dt_EditDate,s_RegisterNo,s_Creator,n_Balance,n_DealerID)");
			strSql.Append(" values (");
			strSql.Append("@dt_PayDate,@n_PaySum,@s_PayBillNo,@n_CurrencyID,@n_ExchangeCurrency,@n_ExRate,@s_Dealer,@s_Note,@s_ReReceiptContent,@dt_ReReceiptDate,@s_Register,@s_Lock,@s_Locker,@s_Editor,@dt_CreateDate,@dt_EditDate,@s_RegisterNo,@s_Creator,@n_Balance,@n_DealerID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@dt_PayDate", SqlDbType.DateTime),
					new SqlParameter("@n_PaySum", SqlDbType.Money,8),
					new SqlParameter("@s_PayBillNo", SqlDbType.NVarChar,20),
					new SqlParameter("@n_CurrencyID", SqlDbType.Int,4),
					new SqlParameter("@n_ExchangeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_ExRate", SqlDbType.Money,8),
					new SqlParameter("@s_Dealer", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ReReceiptContent", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_ReReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@s_Register", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_RegisterNo", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@n_Balance", SqlDbType.Int,4),
					new SqlParameter("@n_DealerID", SqlDbType.Int,4)};
			parameters[0].Value = model.dt_PayDate;
			parameters[1].Value = model.n_PaySum;
			parameters[2].Value = model.s_PayBillNo;
			parameters[3].Value = model.n_CurrencyID;
			parameters[4].Value = model.n_ExchangeCurrency;
			parameters[5].Value = model.n_ExRate;
			parameters[6].Value = model.s_Dealer;
			parameters[7].Value = model.s_Note;
			parameters[8].Value = model.s_ReReceiptContent;
			parameters[9].Value = model.dt_ReReceiptDate;
			parameters[10].Value = model.s_Register;
			parameters[11].Value = model.s_Lock;
			parameters[12].Value = model.s_Locker;
			parameters[13].Value = model.s_Editor;
			parameters[14].Value = model.dt_CreateDate;
			parameters[15].Value = model.dt_EditDate;
			parameters[16].Value = model.s_RegisterNo;
			parameters[17].Value = model.s_Creator;
			parameters[18].Value = model.n_Balance;
			parameters[19].Value = model.n_DealerID;

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
		public bool Update(IPSP.Model.T_ABillPayment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_ABillPayment set ");
			strSql.Append("dt_PayDate=@dt_PayDate,");
			strSql.Append("n_PaySum=@n_PaySum,");
			strSql.Append("s_PayBillNo=@s_PayBillNo,");
			strSql.Append("n_CurrencyID=@n_CurrencyID,");
			strSql.Append("n_ExchangeCurrency=@n_ExchangeCurrency,");
			strSql.Append("n_ExRate=@n_ExRate,");
			strSql.Append("s_Dealer=@s_Dealer,");
			strSql.Append("s_Note=@s_Note,");
			strSql.Append("s_ReReceiptContent=@s_ReReceiptContent,");
			strSql.Append("dt_ReReceiptDate=@dt_ReReceiptDate,");
			strSql.Append("s_Register=@s_Register,");
			strSql.Append("s_Lock=@s_Lock,");
			strSql.Append("s_Locker=@s_Locker,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_RegisterNo=@s_RegisterNo,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("n_Balance=@n_Balance,");
			strSql.Append("n_DealerID=@n_DealerID");
			strSql.Append(" where n_PayListID=@n_PayListID");
			SqlParameter[] parameters = {
					new SqlParameter("@dt_PayDate", SqlDbType.DateTime),
					new SqlParameter("@n_PaySum", SqlDbType.Money,8),
					new SqlParameter("@s_PayBillNo", SqlDbType.NVarChar,20),
					new SqlParameter("@n_CurrencyID", SqlDbType.Int,4),
					new SqlParameter("@n_ExchangeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_ExRate", SqlDbType.Money,8),
					new SqlParameter("@s_Dealer", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ReReceiptContent", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_ReReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@s_Register", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_RegisterNo", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@n_Balance", SqlDbType.Int,4),
					new SqlParameter("@n_DealerID", SqlDbType.Int,4),
					new SqlParameter("@n_PayListID", SqlDbType.Int,4)};
			parameters[0].Value = model.dt_PayDate;
			parameters[1].Value = model.n_PaySum;
			parameters[2].Value = model.s_PayBillNo;
			parameters[3].Value = model.n_CurrencyID;
			parameters[4].Value = model.n_ExchangeCurrency;
			parameters[5].Value = model.n_ExRate;
			parameters[6].Value = model.s_Dealer;
			parameters[7].Value = model.s_Note;
			parameters[8].Value = model.s_ReReceiptContent;
			parameters[9].Value = model.dt_ReReceiptDate;
			parameters[10].Value = model.s_Register;
			parameters[11].Value = model.s_Lock;
			parameters[12].Value = model.s_Locker;
			parameters[13].Value = model.s_Editor;
			parameters[14].Value = model.dt_CreateDate;
			parameters[15].Value = model.dt_EditDate;
			parameters[16].Value = model.s_RegisterNo;
			parameters[17].Value = model.s_Creator;
			parameters[18].Value = model.n_Balance;
			parameters[19].Value = model.n_DealerID;
			parameters[20].Value = model.n_PayListID;

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
		public bool Delete(int n_PayListID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_ABillPayment ");
			strSql.Append(" where n_PayListID=@n_PayListID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_PayListID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_PayListID;

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
		public bool DeleteList(string n_PayListIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_ABillPayment ");
			strSql.Append(" where n_PayListID in ("+n_PayListIDlist + ")  ");
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
		public IPSP.Model.T_ABillPayment GetModel(int n_PayListID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_PayListID,dt_PayDate,n_PaySum,s_PayBillNo,n_CurrencyID,n_ExchangeCurrency,n_ExRate,s_Dealer,s_Note,s_ReReceiptContent,dt_ReReceiptDate,s_Register,s_Lock,s_Locker,s_Editor,dt_CreateDate,dt_EditDate,s_RegisterNo,s_Creator,n_Balance,n_DealerID from T_ABillPayment ");
			strSql.Append(" where n_PayListID=@n_PayListID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_PayListID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_PayListID;

			IPSP.Model.T_ABillPayment model=new IPSP.Model.T_ABillPayment();
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
		public IPSP.Model.T_ABillPayment DataRowToModel(DataRow row)
		{
			IPSP.Model.T_ABillPayment model=new IPSP.Model.T_ABillPayment();
			if (row != null)
			{
				if(row["n_PayListID"]!=null && row["n_PayListID"].ToString()!="")
				{
					model.n_PayListID=int.Parse(row["n_PayListID"].ToString());
				}
				if(row["dt_PayDate"]!=null && row["dt_PayDate"].ToString()!="")
				{
					model.dt_PayDate=DateTime.Parse(row["dt_PayDate"].ToString());
				}
				if(row["n_PaySum"]!=null && row["n_PaySum"].ToString()!="")
				{
					model.n_PaySum=decimal.Parse(row["n_PaySum"].ToString());
				}
				if(row["s_PayBillNo"]!=null)
				{
					model.s_PayBillNo=row["s_PayBillNo"].ToString();
				}
				if(row["n_CurrencyID"]!=null && row["n_CurrencyID"].ToString()!="")
				{
					model.n_CurrencyID=int.Parse(row["n_CurrencyID"].ToString());
				}
				if(row["n_ExchangeCurrency"]!=null && row["n_ExchangeCurrency"].ToString()!="")
				{
					model.n_ExchangeCurrency=int.Parse(row["n_ExchangeCurrency"].ToString());
				}
				if(row["n_ExRate"]!=null && row["n_ExRate"].ToString()!="")
				{
					model.n_ExRate=decimal.Parse(row["n_ExRate"].ToString());
				}
				if(row["s_Dealer"]!=null)
				{
					model.s_Dealer=row["s_Dealer"].ToString();
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
				}
				if(row["s_ReReceiptContent"]!=null)
				{
					model.s_ReReceiptContent=row["s_ReReceiptContent"].ToString();
				}
				if(row["dt_ReReceiptDate"]!=null && row["dt_ReReceiptDate"].ToString()!="")
				{
					model.dt_ReReceiptDate=DateTime.Parse(row["dt_ReReceiptDate"].ToString());
				}
				if(row["s_Register"]!=null)
				{
					model.s_Register=row["s_Register"].ToString();
				}
				if(row["s_Lock"]!=null)
				{
					model.s_Lock=row["s_Lock"].ToString();
				}
				if(row["s_Locker"]!=null)
				{
					model.s_Locker=row["s_Locker"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_RegisterNo"]!=null)
				{
					model.s_RegisterNo=row["s_RegisterNo"].ToString();
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["n_Balance"]!=null && row["n_Balance"].ToString()!="")
				{
					model.n_Balance=int.Parse(row["n_Balance"].ToString());
				}
				if(row["n_DealerID"]!=null && row["n_DealerID"].ToString()!="")
				{
					model.n_DealerID=int.Parse(row["n_DealerID"].ToString());
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
			strSql.Append("select n_PayListID,dt_PayDate,n_PaySum,s_PayBillNo,n_CurrencyID,n_ExchangeCurrency,n_ExRate,s_Dealer,s_Note,s_ReReceiptContent,dt_ReReceiptDate,s_Register,s_Lock,s_Locker,s_Editor,dt_CreateDate,dt_EditDate,s_RegisterNo,s_Creator,n_Balance,n_DealerID ");
			strSql.Append(" FROM T_ABillPayment ");
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
			strSql.Append(" n_PayListID,dt_PayDate,n_PaySum,s_PayBillNo,n_CurrencyID,n_ExchangeCurrency,n_ExRate,s_Dealer,s_Note,s_ReReceiptContent,dt_ReReceiptDate,s_Register,s_Lock,s_Locker,s_Editor,dt_CreateDate,dt_EditDate,s_RegisterNo,s_Creator,n_Balance,n_DealerID ");
			strSql.Append(" FROM T_ABillPayment ");
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
			strSql.Append("select count(1) FROM T_ABillPayment ");
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
				strSql.Append("order by T.n_PayListID desc");
			}
			strSql.Append(")AS Row, T.*  from T_ABillPayment T ");
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
			parameters[0].Value = "T_ABillPayment";
			parameters[1].Value = "n_PayListID";
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

