/**  版本信息模板在安装目录下，可自行修改。
* T_CameMoney.cs
*
* 功 能： N/A
* 类 名： T_CameMoney
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:33   N/A    初版
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
	/// 数据访问类:T_CameMoney
	/// </summary>
	public partial class T_CameMoney
	{
		public T_CameMoney()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ClientID", "T_CameMoney"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ClientID,int n_ContractID,int n_CMoneyID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_CameMoney");
			strSql.Append(" where n_ClientID=@n_ClientID and n_ContractID=@n_ContractID and n_CMoneyID=@n_CMoneyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ContractID", SqlDbType.Int,4),
					new SqlParameter("@n_CMoneyID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = n_ContractID;
			parameters[2].Value = n_CMoneyID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_CameMoney model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_CameMoney(");
			strSql.Append("n_ClientID,s_CameMode,s_CMoneyNum,dt_ArriveDate,n_CurrUnitID,n_TotalMoney,n_ExRate,n_Amount,s_Creator,dt_CreateDate,n_DeptID,s_Mark,n_Balance,n_MergeToAccount,s_Note,s_Bank,s_Editor,S_Lock,S_Locker,s_Receipt,dt_ReceiptDate,s_FileInvoicePath,s_Payer,s_Solified,n_CommissionCharge,s_CMHasCommissionCharge,dt_EditDate,n_PayCurrencyID,n_ContractID)");
			strSql.Append(" values (");
			strSql.Append("@n_ClientID,@s_CameMode,@s_CMoneyNum,@dt_ArriveDate,@n_CurrUnitID,@n_TotalMoney,@n_ExRate,@n_Amount,@s_Creator,@dt_CreateDate,@n_DeptID,@s_Mark,@n_Balance,@n_MergeToAccount,@s_Note,@s_Bank,@s_Editor,@S_Lock,@S_Locker,@s_Receipt,@dt_ReceiptDate,@s_FileInvoicePath,@s_Payer,@s_Solified,@n_CommissionCharge,@s_CMHasCommissionCharge,@dt_EditDate,@n_PayCurrencyID,@n_ContractID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@s_CameMode", SqlDbType.NVarChar,30),
					new SqlParameter("@s_CMoneyNum", SqlDbType.NVarChar,18),
					new SqlParameter("@dt_ArriveDate", SqlDbType.DateTime),
					new SqlParameter("@n_CurrUnitID", SqlDbType.Int,4),
					new SqlParameter("@n_TotalMoney", SqlDbType.Decimal,9),
					new SqlParameter("@n_ExRate", SqlDbType.Decimal,5),
					new SqlParameter("@n_Amount", SqlDbType.Decimal,9),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@n_DeptID", SqlDbType.Int,4),
					new SqlParameter("@s_Mark", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Balance", SqlDbType.Decimal,9),
					new SqlParameter("@n_MergeToAccount", SqlDbType.Decimal,9),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,800),
					new SqlParameter("@s_Bank", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@S_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@S_Locker", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Receipt", SqlDbType.NVarChar,100),
					new SqlParameter("@dt_ReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@s_FileInvoicePath", SqlDbType.NVarChar,255),
					new SqlParameter("@s_Payer", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Solified", SqlDbType.NVarChar,1),
					new SqlParameter("@n_CommissionCharge", SqlDbType.Decimal,9),
					new SqlParameter("@s_CMHasCommissionCharge", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_PayCurrencyID", SqlDbType.Int,4),
					new SqlParameter("@n_ContractID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_ClientID;
			parameters[1].Value = model.s_CameMode;
			parameters[2].Value = model.s_CMoneyNum;
			parameters[3].Value = model.dt_ArriveDate;
			parameters[4].Value = model.n_CurrUnitID;
			parameters[5].Value = model.n_TotalMoney;
			parameters[6].Value = model.n_ExRate;
			parameters[7].Value = model.n_Amount;
			parameters[8].Value = model.s_Creator;
			parameters[9].Value = model.dt_CreateDate;
			parameters[10].Value = model.n_DeptID;
			parameters[11].Value = model.s_Mark;
			parameters[12].Value = model.n_Balance;
			parameters[13].Value = model.n_MergeToAccount;
			parameters[14].Value = model.s_Note;
			parameters[15].Value = model.s_Bank;
			parameters[16].Value = model.s_Editor;
			parameters[17].Value = model.S_Lock;
			parameters[18].Value = model.S_Locker;
			parameters[19].Value = model.s_Receipt;
			parameters[20].Value = model.dt_ReceiptDate;
			parameters[21].Value = model.s_FileInvoicePath;
			parameters[22].Value = model.s_Payer;
			parameters[23].Value = model.s_Solified;
			parameters[24].Value = model.n_CommissionCharge;
			parameters[25].Value = model.s_CMHasCommissionCharge;
			parameters[26].Value = model.dt_EditDate;
			parameters[27].Value = model.n_PayCurrencyID;
			parameters[28].Value = model.n_ContractID;

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
		public bool Update(IPSP.Model.T_CameMoney model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_CameMoney set ");
			strSql.Append("s_CameMode=@s_CameMode,");
			strSql.Append("s_CMoneyNum=@s_CMoneyNum,");
			strSql.Append("dt_ArriveDate=@dt_ArriveDate,");
			strSql.Append("n_CurrUnitID=@n_CurrUnitID,");
			strSql.Append("n_TotalMoney=@n_TotalMoney,");
			strSql.Append("n_ExRate=@n_ExRate,");
			strSql.Append("n_Amount=@n_Amount,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("n_DeptID=@n_DeptID,");
			strSql.Append("s_Mark=@s_Mark,");
			strSql.Append("n_Balance=@n_Balance,");
			strSql.Append("n_MergeToAccount=@n_MergeToAccount,");
			strSql.Append("s_Note=@s_Note,");
			strSql.Append("s_Bank=@s_Bank,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("S_Lock=@S_Lock,");
			strSql.Append("S_Locker=@S_Locker,");
			strSql.Append("s_Receipt=@s_Receipt,");
			strSql.Append("dt_ReceiptDate=@dt_ReceiptDate,");
			strSql.Append("s_FileInvoicePath=@s_FileInvoicePath,");
			strSql.Append("s_Payer=@s_Payer,");
			strSql.Append("s_Solified=@s_Solified,");
			strSql.Append("n_CommissionCharge=@n_CommissionCharge,");
			strSql.Append("s_CMHasCommissionCharge=@s_CMHasCommissionCharge,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("n_PayCurrencyID=@n_PayCurrencyID");
			strSql.Append(" where n_CMoneyID=@n_CMoneyID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_CameMode", SqlDbType.NVarChar,30),
					new SqlParameter("@s_CMoneyNum", SqlDbType.NVarChar,18),
					new SqlParameter("@dt_ArriveDate", SqlDbType.DateTime),
					new SqlParameter("@n_CurrUnitID", SqlDbType.Int,4),
					new SqlParameter("@n_TotalMoney", SqlDbType.Decimal,9),
					new SqlParameter("@n_ExRate", SqlDbType.Decimal,5),
					new SqlParameter("@n_Amount", SqlDbType.Decimal,9),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@n_DeptID", SqlDbType.Int,4),
					new SqlParameter("@s_Mark", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Balance", SqlDbType.Decimal,9),
					new SqlParameter("@n_MergeToAccount", SqlDbType.Decimal,9),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,800),
					new SqlParameter("@s_Bank", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@S_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@S_Locker", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Receipt", SqlDbType.NVarChar,100),
					new SqlParameter("@dt_ReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@s_FileInvoicePath", SqlDbType.NVarChar,255),
					new SqlParameter("@s_Payer", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Solified", SqlDbType.NVarChar,1),
					new SqlParameter("@n_CommissionCharge", SqlDbType.Decimal,9),
					new SqlParameter("@s_CMHasCommissionCharge", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_PayCurrencyID", SqlDbType.Int,4),
					new SqlParameter("@n_CMoneyID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ContractID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_CameMode;
			parameters[1].Value = model.s_CMoneyNum;
			parameters[2].Value = model.dt_ArriveDate;
			parameters[3].Value = model.n_CurrUnitID;
			parameters[4].Value = model.n_TotalMoney;
			parameters[5].Value = model.n_ExRate;
			parameters[6].Value = model.n_Amount;
			parameters[7].Value = model.s_Creator;
			parameters[8].Value = model.dt_CreateDate;
			parameters[9].Value = model.n_DeptID;
			parameters[10].Value = model.s_Mark;
			parameters[11].Value = model.n_Balance;
			parameters[12].Value = model.n_MergeToAccount;
			parameters[13].Value = model.s_Note;
			parameters[14].Value = model.s_Bank;
			parameters[15].Value = model.s_Editor;
			parameters[16].Value = model.S_Lock;
			parameters[17].Value = model.S_Locker;
			parameters[18].Value = model.s_Receipt;
			parameters[19].Value = model.dt_ReceiptDate;
			parameters[20].Value = model.s_FileInvoicePath;
			parameters[21].Value = model.s_Payer;
			parameters[22].Value = model.s_Solified;
			parameters[23].Value = model.n_CommissionCharge;
			parameters[24].Value = model.s_CMHasCommissionCharge;
			parameters[25].Value = model.dt_EditDate;
			parameters[26].Value = model.n_PayCurrencyID;
			parameters[27].Value = model.n_CMoneyID;
			parameters[28].Value = model.n_ClientID;
			parameters[29].Value = model.n_ContractID;

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
		public bool Delete(int n_CMoneyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_CameMoney ");
			strSql.Append(" where n_CMoneyID=@n_CMoneyID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CMoneyID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_CMoneyID;

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
		public bool Delete(int n_ClientID,int n_ContractID,int n_CMoneyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_CameMoney ");
			strSql.Append(" where n_ClientID=@n_ClientID and n_ContractID=@n_ContractID and n_CMoneyID=@n_CMoneyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ContractID", SqlDbType.Int,4),
					new SqlParameter("@n_CMoneyID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = n_ContractID;
			parameters[2].Value = n_CMoneyID;

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
		public bool DeleteList(string n_CMoneyIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_CameMoney ");
			strSql.Append(" where n_CMoneyID in ("+n_CMoneyIDlist + ")  ");
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
		public IPSP.Model.T_CameMoney GetModel(int n_CMoneyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_CMoneyID,n_ClientID,s_CameMode,s_CMoneyNum,dt_ArriveDate,n_CurrUnitID,n_TotalMoney,n_ExRate,n_Amount,s_Creator,dt_CreateDate,n_DeptID,s_Mark,n_Balance,n_MergeToAccount,s_Note,s_Bank,s_Editor,S_Lock,S_Locker,s_Receipt,dt_ReceiptDate,s_FileInvoicePath,s_Payer,s_Solified,n_CommissionCharge,s_CMHasCommissionCharge,dt_EditDate,n_PayCurrencyID,n_ContractID from T_CameMoney ");
			strSql.Append(" where n_CMoneyID=@n_CMoneyID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CMoneyID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_CMoneyID;

			IPSP.Model.T_CameMoney model=new IPSP.Model.T_CameMoney();
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
		public IPSP.Model.T_CameMoney DataRowToModel(DataRow row)
		{
			IPSP.Model.T_CameMoney model=new IPSP.Model.T_CameMoney();
			if (row != null)
			{
				if(row["n_CMoneyID"]!=null && row["n_CMoneyID"].ToString()!="")
				{
					model.n_CMoneyID=int.Parse(row["n_CMoneyID"].ToString());
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["s_CameMode"]!=null)
				{
					model.s_CameMode=row["s_CameMode"].ToString();
				}
				if(row["s_CMoneyNum"]!=null)
				{
					model.s_CMoneyNum=row["s_CMoneyNum"].ToString();
				}
				if(row["dt_ArriveDate"]!=null && row["dt_ArriveDate"].ToString()!="")
				{
					model.dt_ArriveDate=DateTime.Parse(row["dt_ArriveDate"].ToString());
				}
				if(row["n_CurrUnitID"]!=null && row["n_CurrUnitID"].ToString()!="")
				{
					model.n_CurrUnitID=int.Parse(row["n_CurrUnitID"].ToString());
				}
				if(row["n_TotalMoney"]!=null && row["n_TotalMoney"].ToString()!="")
				{
					model.n_TotalMoney=decimal.Parse(row["n_TotalMoney"].ToString());
				}
				if(row["n_ExRate"]!=null && row["n_ExRate"].ToString()!="")
				{
					model.n_ExRate=decimal.Parse(row["n_ExRate"].ToString());
				}
				if(row["n_Amount"]!=null && row["n_Amount"].ToString()!="")
				{
					model.n_Amount=decimal.Parse(row["n_Amount"].ToString());
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["n_DeptID"]!=null && row["n_DeptID"].ToString()!="")
				{
					model.n_DeptID=int.Parse(row["n_DeptID"].ToString());
				}
				if(row["s_Mark"]!=null)
				{
					model.s_Mark=row["s_Mark"].ToString();
				}
				if(row["n_Balance"]!=null && row["n_Balance"].ToString()!="")
				{
					model.n_Balance=decimal.Parse(row["n_Balance"].ToString());
				}
				if(row["n_MergeToAccount"]!=null && row["n_MergeToAccount"].ToString()!="")
				{
					model.n_MergeToAccount=decimal.Parse(row["n_MergeToAccount"].ToString());
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
				}
				if(row["s_Bank"]!=null)
				{
					model.s_Bank=row["s_Bank"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["S_Lock"]!=null)
				{
					model.S_Lock=row["S_Lock"].ToString();
				}
				if(row["S_Locker"]!=null)
				{
					model.S_Locker=row["S_Locker"].ToString();
				}
				if(row["s_Receipt"]!=null)
				{
					model.s_Receipt=row["s_Receipt"].ToString();
				}
				if(row["dt_ReceiptDate"]!=null && row["dt_ReceiptDate"].ToString()!="")
				{
					model.dt_ReceiptDate=DateTime.Parse(row["dt_ReceiptDate"].ToString());
				}
				if(row["s_FileInvoicePath"]!=null)
				{
					model.s_FileInvoicePath=row["s_FileInvoicePath"].ToString();
				}
				if(row["s_Payer"]!=null)
				{
					model.s_Payer=row["s_Payer"].ToString();
				}
				if(row["s_Solified"]!=null)
				{
					model.s_Solified=row["s_Solified"].ToString();
				}
				if(row["n_CommissionCharge"]!=null && row["n_CommissionCharge"].ToString()!="")
				{
					model.n_CommissionCharge=decimal.Parse(row["n_CommissionCharge"].ToString());
				}
				if(row["s_CMHasCommissionCharge"]!=null)
				{
					model.s_CMHasCommissionCharge=row["s_CMHasCommissionCharge"].ToString();
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["n_PayCurrencyID"]!=null && row["n_PayCurrencyID"].ToString()!="")
				{
					model.n_PayCurrencyID=int.Parse(row["n_PayCurrencyID"].ToString());
				}
				if(row["n_ContractID"]!=null && row["n_ContractID"].ToString()!="")
				{
					model.n_ContractID=int.Parse(row["n_ContractID"].ToString());
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
			strSql.Append("select n_CMoneyID,n_ClientID,s_CameMode,s_CMoneyNum,dt_ArriveDate,n_CurrUnitID,n_TotalMoney,n_ExRate,n_Amount,s_Creator,dt_CreateDate,n_DeptID,s_Mark,n_Balance,n_MergeToAccount,s_Note,s_Bank,s_Editor,S_Lock,S_Locker,s_Receipt,dt_ReceiptDate,s_FileInvoicePath,s_Payer,s_Solified,n_CommissionCharge,s_CMHasCommissionCharge,dt_EditDate,n_PayCurrencyID,n_ContractID ");
			strSql.Append(" FROM T_CameMoney ");
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
			strSql.Append(" n_CMoneyID,n_ClientID,s_CameMode,s_CMoneyNum,dt_ArriveDate,n_CurrUnitID,n_TotalMoney,n_ExRate,n_Amount,s_Creator,dt_CreateDate,n_DeptID,s_Mark,n_Balance,n_MergeToAccount,s_Note,s_Bank,s_Editor,S_Lock,S_Locker,s_Receipt,dt_ReceiptDate,s_FileInvoicePath,s_Payer,s_Solified,n_CommissionCharge,s_CMHasCommissionCharge,dt_EditDate,n_PayCurrencyID,n_ContractID ");
			strSql.Append(" FROM T_CameMoney ");
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
			strSql.Append("select count(1) FROM T_CameMoney ");
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
				strSql.Append("order by T.n_CMoneyID desc");
			}
			strSql.Append(")AS Row, T.*  from T_CameMoney T ");
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
			parameters[0].Value = "T_CameMoney";
			parameters[1].Value = "n_CMoneyID";
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

