/**  版本信息模板在安装目录下，可自行修改。
* T_DNRenewalFee.cs
*
* 功 能： N/A
* 类 名： T_DNRenewalFee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:39   N/A    初版
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
	/// 数据访问类:T_DNRenewalFee
	/// </summary>
	public partial class T_DNRenewalFee
	{
		public T_DNRenewalFee()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "T_DNRenewalFee"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_BillID,int n_DRenewalFeeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_DNRenewalFee");
			strSql.Append(" where n_CaseID=@n_CaseID and n_BillID=@n_BillID and n_DRenewalFeeID=@n_DRenewalFeeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_DRenewalFeeID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_BillID;
			parameters[2].Value = n_DRenewalFeeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_DNRenewalFee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_DNRenewalFee(");
			strSql.Append("n_CaseID,s_Status,s_PayMode,s_StatusOrder,n_ChargeCurrency,n_ChargeOFee,n_ChargeAFee,n_ChargeTFee,dt_ChargeShldPayDate,dt_ChargePayDate,n_OfficialCurrency,n_OfficialFee,n_OfficialLateFee,s_IsOfficialDisc,s_OfficialDiscStyle,n_OfficialDiscount,dt_OfficialShldPayDate,dt_OfficialPayDate,s_OfficialReceiptPath,n_PayFeeListID,s_Notes,s_InvoiceNum,dt_AlarmDate,n_Rate,s_IsActive,dt_CreateDate,dt_EditDate,dt_Consign,dt_Effective,dt_End,dt_NextRenewal,s_RenewalStatus,s_FeeReceiveCashStatue,n_ExchangeCurrency,s_FeeReceivedStatus,s_NotifyStatus,s_Creator,s_Editor,n_BillID)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@s_Status,@s_PayMode,@s_StatusOrder,@n_ChargeCurrency,@n_ChargeOFee,@n_ChargeAFee,@n_ChargeTFee,@dt_ChargeShldPayDate,@dt_ChargePayDate,@n_OfficialCurrency,@n_OfficialFee,@n_OfficialLateFee,@s_IsOfficialDisc,@s_OfficialDiscStyle,@n_OfficialDiscount,@dt_OfficialShldPayDate,@dt_OfficialPayDate,@s_OfficialReceiptPath,@n_PayFeeListID,@s_Notes,@s_InvoiceNum,@dt_AlarmDate,@n_Rate,@s_IsActive,@dt_CreateDate,@dt_EditDate,@dt_Consign,@dt_Effective,@dt_End,@dt_NextRenewal,@s_RenewalStatus,@s_FeeReceiveCashStatue,@n_ExchangeCurrency,@s_FeeReceivedStatus,@s_NotifyStatus,@s_Creator,@s_Editor,@n_BillID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PayMode", SqlDbType.NVarChar,2),
					new SqlParameter("@s_StatusOrder", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ChargeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_ChargeOFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_ChargeAFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_ChargeTFee", SqlDbType.Decimal,9),
					new SqlParameter("@dt_ChargeShldPayDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ChargePayDate", SqlDbType.DateTime),
					new SqlParameter("@n_OfficialCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_OfficialFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_OfficialLateFee", SqlDbType.Decimal,9),
					new SqlParameter("@s_IsOfficialDisc", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OfficialDiscStyle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_OfficialDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@dt_OfficialShldPayDate", SqlDbType.DateTime),
					new SqlParameter("@dt_OfficialPayDate", SqlDbType.DateTime),
					new SqlParameter("@s_OfficialReceiptPath", SqlDbType.NVarChar,500),
					new SqlParameter("@n_PayFeeListID", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_InvoiceNum", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_AlarmDate", SqlDbType.DateTime),
					new SqlParameter("@n_Rate", SqlDbType.Decimal,9),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@dt_Consign", SqlDbType.DateTime),
					new SqlParameter("@dt_Effective", SqlDbType.DateTime),
					new SqlParameter("@dt_End", SqlDbType.DateTime),
					new SqlParameter("@dt_NextRenewal", SqlDbType.DateTime),
					new SqlParameter("@s_RenewalStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FeeReceiveCashStatue", SqlDbType.NVarChar,100),
					new SqlParameter("@n_ExchangeCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_FeeReceivedStatus", SqlDbType.NVarChar,100),
					new SqlParameter("@s_NotifyStatus", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_BillID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_Status;
			parameters[2].Value = model.s_PayMode;
			parameters[3].Value = model.s_StatusOrder;
			parameters[4].Value = model.n_ChargeCurrency;
			parameters[5].Value = model.n_ChargeOFee;
			parameters[6].Value = model.n_ChargeAFee;
			parameters[7].Value = model.n_ChargeTFee;
			parameters[8].Value = model.dt_ChargeShldPayDate;
			parameters[9].Value = model.dt_ChargePayDate;
			parameters[10].Value = model.n_OfficialCurrency;
			parameters[11].Value = model.n_OfficialFee;
			parameters[12].Value = model.n_OfficialLateFee;
			parameters[13].Value = model.s_IsOfficialDisc;
			parameters[14].Value = model.s_OfficialDiscStyle;
			parameters[15].Value = model.n_OfficialDiscount;
			parameters[16].Value = model.dt_OfficialShldPayDate;
			parameters[17].Value = model.dt_OfficialPayDate;
			parameters[18].Value = model.s_OfficialReceiptPath;
			parameters[19].Value = model.n_PayFeeListID;
			parameters[20].Value = model.s_Notes;
			parameters[21].Value = model.s_InvoiceNum;
			parameters[22].Value = model.dt_AlarmDate;
			parameters[23].Value = model.n_Rate;
			parameters[24].Value = model.s_IsActive;
			parameters[25].Value = model.dt_CreateDate;
			parameters[26].Value = model.dt_EditDate;
			parameters[27].Value = model.dt_Consign;
			parameters[28].Value = model.dt_Effective;
			parameters[29].Value = model.dt_End;
			parameters[30].Value = model.dt_NextRenewal;
			parameters[31].Value = model.s_RenewalStatus;
			parameters[32].Value = model.s_FeeReceiveCashStatue;
			parameters[33].Value = model.n_ExchangeCurrency;
			parameters[34].Value = model.s_FeeReceivedStatus;
			parameters[35].Value = model.s_NotifyStatus;
			parameters[36].Value = model.s_Creator;
			parameters[37].Value = model.s_Editor;
			parameters[38].Value = model.n_BillID;

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
		public bool Update(IPSP.Model.T_DNRenewalFee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_DNRenewalFee set ");
			strSql.Append("s_Status=@s_Status,");
			strSql.Append("s_PayMode=@s_PayMode,");
			strSql.Append("s_StatusOrder=@s_StatusOrder,");
			strSql.Append("n_ChargeCurrency=@n_ChargeCurrency,");
			strSql.Append("n_ChargeOFee=@n_ChargeOFee,");
			strSql.Append("n_ChargeAFee=@n_ChargeAFee,");
			strSql.Append("n_ChargeTFee=@n_ChargeTFee,");
			strSql.Append("dt_ChargeShldPayDate=@dt_ChargeShldPayDate,");
			strSql.Append("dt_ChargePayDate=@dt_ChargePayDate,");
			strSql.Append("n_OfficialCurrency=@n_OfficialCurrency,");
			strSql.Append("n_OfficialFee=@n_OfficialFee,");
			strSql.Append("n_OfficialLateFee=@n_OfficialLateFee,");
			strSql.Append("s_IsOfficialDisc=@s_IsOfficialDisc,");
			strSql.Append("s_OfficialDiscStyle=@s_OfficialDiscStyle,");
			strSql.Append("n_OfficialDiscount=@n_OfficialDiscount,");
			strSql.Append("dt_OfficialShldPayDate=@dt_OfficialShldPayDate,");
			strSql.Append("dt_OfficialPayDate=@dt_OfficialPayDate,");
			strSql.Append("s_OfficialReceiptPath=@s_OfficialReceiptPath,");
			strSql.Append("n_PayFeeListID=@n_PayFeeListID,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("s_InvoiceNum=@s_InvoiceNum,");
			strSql.Append("dt_AlarmDate=@dt_AlarmDate,");
			strSql.Append("n_Rate=@n_Rate,");
			strSql.Append("s_IsActive=@s_IsActive,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("dt_Consign=@dt_Consign,");
			strSql.Append("dt_Effective=@dt_Effective,");
			strSql.Append("dt_End=@dt_End,");
			strSql.Append("dt_NextRenewal=@dt_NextRenewal,");
			strSql.Append("s_RenewalStatus=@s_RenewalStatus,");
			strSql.Append("s_FeeReceiveCashStatue=@s_FeeReceiveCashStatue,");
			strSql.Append("n_ExchangeCurrency=@n_ExchangeCurrency,");
			strSql.Append("s_FeeReceivedStatus=@s_FeeReceivedStatus,");
			strSql.Append("s_NotifyStatus=@s_NotifyStatus,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor");
			strSql.Append(" where n_DRenewalFeeID=@n_DRenewalFeeID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PayMode", SqlDbType.NVarChar,2),
					new SqlParameter("@s_StatusOrder", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ChargeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_ChargeOFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_ChargeAFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_ChargeTFee", SqlDbType.Decimal,9),
					new SqlParameter("@dt_ChargeShldPayDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ChargePayDate", SqlDbType.DateTime),
					new SqlParameter("@n_OfficialCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_OfficialFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_OfficialLateFee", SqlDbType.Decimal,9),
					new SqlParameter("@s_IsOfficialDisc", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OfficialDiscStyle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_OfficialDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@dt_OfficialShldPayDate", SqlDbType.DateTime),
					new SqlParameter("@dt_OfficialPayDate", SqlDbType.DateTime),
					new SqlParameter("@s_OfficialReceiptPath", SqlDbType.NVarChar,500),
					new SqlParameter("@n_PayFeeListID", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_InvoiceNum", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_AlarmDate", SqlDbType.DateTime),
					new SqlParameter("@n_Rate", SqlDbType.Decimal,9),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@dt_Consign", SqlDbType.DateTime),
					new SqlParameter("@dt_Effective", SqlDbType.DateTime),
					new SqlParameter("@dt_End", SqlDbType.DateTime),
					new SqlParameter("@dt_NextRenewal", SqlDbType.DateTime),
					new SqlParameter("@s_RenewalStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FeeReceiveCashStatue", SqlDbType.NVarChar,100),
					new SqlParameter("@n_ExchangeCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_FeeReceivedStatus", SqlDbType.NVarChar,100),
					new SqlParameter("@s_NotifyStatus", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_DRenewalFeeID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Status;
			parameters[1].Value = model.s_PayMode;
			parameters[2].Value = model.s_StatusOrder;
			parameters[3].Value = model.n_ChargeCurrency;
			parameters[4].Value = model.n_ChargeOFee;
			parameters[5].Value = model.n_ChargeAFee;
			parameters[6].Value = model.n_ChargeTFee;
			parameters[7].Value = model.dt_ChargeShldPayDate;
			parameters[8].Value = model.dt_ChargePayDate;
			parameters[9].Value = model.n_OfficialCurrency;
			parameters[10].Value = model.n_OfficialFee;
			parameters[11].Value = model.n_OfficialLateFee;
			parameters[12].Value = model.s_IsOfficialDisc;
			parameters[13].Value = model.s_OfficialDiscStyle;
			parameters[14].Value = model.n_OfficialDiscount;
			parameters[15].Value = model.dt_OfficialShldPayDate;
			parameters[16].Value = model.dt_OfficialPayDate;
			parameters[17].Value = model.s_OfficialReceiptPath;
			parameters[18].Value = model.n_PayFeeListID;
			parameters[19].Value = model.s_Notes;
			parameters[20].Value = model.s_InvoiceNum;
			parameters[21].Value = model.dt_AlarmDate;
			parameters[22].Value = model.n_Rate;
			parameters[23].Value = model.s_IsActive;
			parameters[24].Value = model.dt_CreateDate;
			parameters[25].Value = model.dt_EditDate;
			parameters[26].Value = model.dt_Consign;
			parameters[27].Value = model.dt_Effective;
			parameters[28].Value = model.dt_End;
			parameters[29].Value = model.dt_NextRenewal;
			parameters[30].Value = model.s_RenewalStatus;
			parameters[31].Value = model.s_FeeReceiveCashStatue;
			parameters[32].Value = model.n_ExchangeCurrency;
			parameters[33].Value = model.s_FeeReceivedStatus;
			parameters[34].Value = model.s_NotifyStatus;
			parameters[35].Value = model.s_Creator;
			parameters[36].Value = model.s_Editor;
			parameters[37].Value = model.n_DRenewalFeeID;
			parameters[38].Value = model.n_CaseID;
			parameters[39].Value = model.n_BillID;

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
		public bool Delete(int n_DRenewalFeeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_DNRenewalFee ");
			strSql.Append(" where n_DRenewalFeeID=@n_DRenewalFeeID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_DRenewalFeeID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_DRenewalFeeID;

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
		public bool Delete(int n_CaseID,int n_BillID,int n_DRenewalFeeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_DNRenewalFee ");
			strSql.Append(" where n_CaseID=@n_CaseID and n_BillID=@n_BillID and n_DRenewalFeeID=@n_DRenewalFeeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_DRenewalFeeID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_BillID;
			parameters[2].Value = n_DRenewalFeeID;

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
		public bool DeleteList(string n_DRenewalFeeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_DNRenewalFee ");
			strSql.Append(" where n_DRenewalFeeID in ("+n_DRenewalFeeIDlist + ")  ");
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
		public IPSP.Model.T_DNRenewalFee GetModel(int n_DRenewalFeeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_DRenewalFeeID,n_CaseID,s_Status,s_PayMode,s_StatusOrder,n_ChargeCurrency,n_ChargeOFee,n_ChargeAFee,n_ChargeTFee,dt_ChargeShldPayDate,dt_ChargePayDate,n_OfficialCurrency,n_OfficialFee,n_OfficialLateFee,s_IsOfficialDisc,s_OfficialDiscStyle,n_OfficialDiscount,dt_OfficialShldPayDate,dt_OfficialPayDate,s_OfficialReceiptPath,n_PayFeeListID,s_Notes,s_InvoiceNum,dt_AlarmDate,n_Rate,s_IsActive,dt_CreateDate,dt_EditDate,dt_Consign,dt_Effective,dt_End,dt_NextRenewal,s_RenewalStatus,s_FeeReceiveCashStatue,n_ExchangeCurrency,s_FeeReceivedStatus,s_NotifyStatus,s_Creator,s_Editor,n_BillID from T_DNRenewalFee ");
			strSql.Append(" where n_DRenewalFeeID=@n_DRenewalFeeID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_DRenewalFeeID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_DRenewalFeeID;

			IPSP.Model.T_DNRenewalFee model=new IPSP.Model.T_DNRenewalFee();
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
		public IPSP.Model.T_DNRenewalFee DataRowToModel(DataRow row)
		{
			IPSP.Model.T_DNRenewalFee model=new IPSP.Model.T_DNRenewalFee();
			if (row != null)
			{
				if(row["n_DRenewalFeeID"]!=null && row["n_DRenewalFeeID"].ToString()!="")
				{
					model.n_DRenewalFeeID=int.Parse(row["n_DRenewalFeeID"].ToString());
				}
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["s_Status"]!=null)
				{
					model.s_Status=row["s_Status"].ToString();
				}
				if(row["s_PayMode"]!=null)
				{
					model.s_PayMode=row["s_PayMode"].ToString();
				}
				if(row["s_StatusOrder"]!=null)
				{
					model.s_StatusOrder=row["s_StatusOrder"].ToString();
				}
				if(row["n_ChargeCurrency"]!=null && row["n_ChargeCurrency"].ToString()!="")
				{
					model.n_ChargeCurrency=int.Parse(row["n_ChargeCurrency"].ToString());
				}
				if(row["n_ChargeOFee"]!=null && row["n_ChargeOFee"].ToString()!="")
				{
					model.n_ChargeOFee=decimal.Parse(row["n_ChargeOFee"].ToString());
				}
				if(row["n_ChargeAFee"]!=null && row["n_ChargeAFee"].ToString()!="")
				{
					model.n_ChargeAFee=decimal.Parse(row["n_ChargeAFee"].ToString());
				}
				if(row["n_ChargeTFee"]!=null && row["n_ChargeTFee"].ToString()!="")
				{
					model.n_ChargeTFee=decimal.Parse(row["n_ChargeTFee"].ToString());
				}
				if(row["dt_ChargeShldPayDate"]!=null && row["dt_ChargeShldPayDate"].ToString()!="")
				{
					model.dt_ChargeShldPayDate=DateTime.Parse(row["dt_ChargeShldPayDate"].ToString());
				}
				if(row["dt_ChargePayDate"]!=null && row["dt_ChargePayDate"].ToString()!="")
				{
					model.dt_ChargePayDate=DateTime.Parse(row["dt_ChargePayDate"].ToString());
				}
				if(row["n_OfficialCurrency"]!=null && row["n_OfficialCurrency"].ToString()!="")
				{
					model.n_OfficialCurrency=int.Parse(row["n_OfficialCurrency"].ToString());
				}
				if(row["n_OfficialFee"]!=null && row["n_OfficialFee"].ToString()!="")
				{
					model.n_OfficialFee=decimal.Parse(row["n_OfficialFee"].ToString());
				}
				if(row["n_OfficialLateFee"]!=null && row["n_OfficialLateFee"].ToString()!="")
				{
					model.n_OfficialLateFee=decimal.Parse(row["n_OfficialLateFee"].ToString());
				}
				if(row["s_IsOfficialDisc"]!=null)
				{
					model.s_IsOfficialDisc=row["s_IsOfficialDisc"].ToString();
				}
				if(row["s_OfficialDiscStyle"]!=null)
				{
					model.s_OfficialDiscStyle=row["s_OfficialDiscStyle"].ToString();
				}
				if(row["n_OfficialDiscount"]!=null && row["n_OfficialDiscount"].ToString()!="")
				{
					model.n_OfficialDiscount=decimal.Parse(row["n_OfficialDiscount"].ToString());
				}
				if(row["dt_OfficialShldPayDate"]!=null && row["dt_OfficialShldPayDate"].ToString()!="")
				{
					model.dt_OfficialShldPayDate=DateTime.Parse(row["dt_OfficialShldPayDate"].ToString());
				}
				if(row["dt_OfficialPayDate"]!=null && row["dt_OfficialPayDate"].ToString()!="")
				{
					model.dt_OfficialPayDate=DateTime.Parse(row["dt_OfficialPayDate"].ToString());
				}
				if(row["s_OfficialReceiptPath"]!=null)
				{
					model.s_OfficialReceiptPath=row["s_OfficialReceiptPath"].ToString();
				}
				if(row["n_PayFeeListID"]!=null && row["n_PayFeeListID"].ToString()!="")
				{
					model.n_PayFeeListID=int.Parse(row["n_PayFeeListID"].ToString());
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["s_InvoiceNum"]!=null)
				{
					model.s_InvoiceNum=row["s_InvoiceNum"].ToString();
				}
				if(row["dt_AlarmDate"]!=null && row["dt_AlarmDate"].ToString()!="")
				{
					model.dt_AlarmDate=DateTime.Parse(row["dt_AlarmDate"].ToString());
				}
				if(row["n_Rate"]!=null && row["n_Rate"].ToString()!="")
				{
					model.n_Rate=decimal.Parse(row["n_Rate"].ToString());
				}
				if(row["s_IsActive"]!=null)
				{
					model.s_IsActive=row["s_IsActive"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["dt_Consign"]!=null && row["dt_Consign"].ToString()!="")
				{
					model.dt_Consign=DateTime.Parse(row["dt_Consign"].ToString());
				}
				if(row["dt_Effective"]!=null && row["dt_Effective"].ToString()!="")
				{
					model.dt_Effective=DateTime.Parse(row["dt_Effective"].ToString());
				}
				if(row["dt_End"]!=null && row["dt_End"].ToString()!="")
				{
					model.dt_End=DateTime.Parse(row["dt_End"].ToString());
				}
				if(row["dt_NextRenewal"]!=null && row["dt_NextRenewal"].ToString()!="")
				{
					model.dt_NextRenewal=DateTime.Parse(row["dt_NextRenewal"].ToString());
				}
				if(row["s_RenewalStatus"]!=null)
				{
					model.s_RenewalStatus=row["s_RenewalStatus"].ToString();
				}
				if(row["s_FeeReceiveCashStatue"]!=null)
				{
					model.s_FeeReceiveCashStatue=row["s_FeeReceiveCashStatue"].ToString();
				}
				if(row["n_ExchangeCurrency"]!=null && row["n_ExchangeCurrency"].ToString()!="")
				{
					model.n_ExchangeCurrency=int.Parse(row["n_ExchangeCurrency"].ToString());
				}
				if(row["s_FeeReceivedStatus"]!=null)
				{
					model.s_FeeReceivedStatus=row["s_FeeReceivedStatus"].ToString();
				}
				if(row["s_NotifyStatus"]!=null)
				{
					model.s_NotifyStatus=row["s_NotifyStatus"].ToString();
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["n_BillID"]!=null && row["n_BillID"].ToString()!="")
				{
					model.n_BillID=int.Parse(row["n_BillID"].ToString());
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
			strSql.Append("select n_DRenewalFeeID,n_CaseID,s_Status,s_PayMode,s_StatusOrder,n_ChargeCurrency,n_ChargeOFee,n_ChargeAFee,n_ChargeTFee,dt_ChargeShldPayDate,dt_ChargePayDate,n_OfficialCurrency,n_OfficialFee,n_OfficialLateFee,s_IsOfficialDisc,s_OfficialDiscStyle,n_OfficialDiscount,dt_OfficialShldPayDate,dt_OfficialPayDate,s_OfficialReceiptPath,n_PayFeeListID,s_Notes,s_InvoiceNum,dt_AlarmDate,n_Rate,s_IsActive,dt_CreateDate,dt_EditDate,dt_Consign,dt_Effective,dt_End,dt_NextRenewal,s_RenewalStatus,s_FeeReceiveCashStatue,n_ExchangeCurrency,s_FeeReceivedStatus,s_NotifyStatus,s_Creator,s_Editor,n_BillID ");
			strSql.Append(" FROM T_DNRenewalFee ");
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
			strSql.Append(" n_DRenewalFeeID,n_CaseID,s_Status,s_PayMode,s_StatusOrder,n_ChargeCurrency,n_ChargeOFee,n_ChargeAFee,n_ChargeTFee,dt_ChargeShldPayDate,dt_ChargePayDate,n_OfficialCurrency,n_OfficialFee,n_OfficialLateFee,s_IsOfficialDisc,s_OfficialDiscStyle,n_OfficialDiscount,dt_OfficialShldPayDate,dt_OfficialPayDate,s_OfficialReceiptPath,n_PayFeeListID,s_Notes,s_InvoiceNum,dt_AlarmDate,n_Rate,s_IsActive,dt_CreateDate,dt_EditDate,dt_Consign,dt_Effective,dt_End,dt_NextRenewal,s_RenewalStatus,s_FeeReceiveCashStatue,n_ExchangeCurrency,s_FeeReceivedStatus,s_NotifyStatus,s_Creator,s_Editor,n_BillID ");
			strSql.Append(" FROM T_DNRenewalFee ");
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
			strSql.Append("select count(1) FROM T_DNRenewalFee ");
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
				strSql.Append("order by T.n_DRenewalFeeID desc");
			}
			strSql.Append(")AS Row, T.*  from T_DNRenewalFee T ");
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
			parameters[0].Value = "T_DNRenewalFee";
			parameters[1].Value = "n_DRenewalFeeID";
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

