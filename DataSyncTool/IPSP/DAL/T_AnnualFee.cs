/**  版本信息模板在安装目录下，可自行修改。
* T_AnnualFee.cs
*
* 功 能： N/A
* 类 名： T_AnnualFee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:29   N/A    初版
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
	/// 数据访问类:T_AnnualFee
	/// </summary>
	public partial class T_AnnualFee
	{
		public T_AnnualFee()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "T_AnnualFee"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_BillID,int n_AnnualFeeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_AnnualFee");
			strSql.Append(" where n_CaseID=@n_CaseID and n_BillID=@n_BillID and n_AnnualFeeID=@n_AnnualFeeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_AnnualFeeID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_BillID;
			parameters[2].Value = n_AnnualFeeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_AnnualFee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_AnnualFee(");
			strSql.Append("n_CaseID,n_YearNo,s_Status,s_PayMode,s_StatusOrder,n_ChargeCurrency,n_ChargeOFee,n_ChargeAFee,n_ChargeTFee,dt_ChargeShldPayDate,dt_ChargePayDate,n_OfficialCurrency,n_OfficialFee,n_OfficialLateFee,s_IsOfficialDisc,s_OfficialDiscStyle,n_OfficialDiscount,dt_OfficialShldPayDate,dt_OfficialPayDate,s_OfficialReceiptPath,n_PayFeeListID,s_Notes,s_InvoiceNum,dt_AlarmDate,n_Rate,s_IsActive,dt_CreateDate,dt_EditDate,s_FeeReceiveCashStatue,n_ExchangeCurrency,s_Priority,s_Creator,s_Editor,n_BillID,s_ElecPayer,n_AssignAnnualFeeHandler,n_AssignBillHandler,n_ReportStatus,n_FeeApprovalStatus,s_BillApprovalStatus,s_ApprovalNotes,s_CheckStatus,n_Checker,dt_CheckDate,s_ReceiptNo,dt_ReceiptDate,n_OperatorID)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@n_YearNo,@s_Status,@s_PayMode,@s_StatusOrder,@n_ChargeCurrency,@n_ChargeOFee,@n_ChargeAFee,@n_ChargeTFee,@dt_ChargeShldPayDate,@dt_ChargePayDate,@n_OfficialCurrency,@n_OfficialFee,@n_OfficialLateFee,@s_IsOfficialDisc,@s_OfficialDiscStyle,@n_OfficialDiscount,@dt_OfficialShldPayDate,@dt_OfficialPayDate,@s_OfficialReceiptPath,@n_PayFeeListID,@s_Notes,@s_InvoiceNum,@dt_AlarmDate,@n_Rate,@s_IsActive,@dt_CreateDate,@dt_EditDate,@s_FeeReceiveCashStatue,@n_ExchangeCurrency,@s_Priority,@s_Creator,@s_Editor,@n_BillID,@s_ElecPayer,@n_AssignAnnualFeeHandler,@n_AssignBillHandler,@n_ReportStatus,@n_FeeApprovalStatus,@s_BillApprovalStatus,@s_ApprovalNotes,@s_CheckStatus,@n_Checker,@dt_CheckDate,@s_ReceiptNo,@dt_ReceiptDate,@n_OperatorID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_YearNo", SqlDbType.Decimal,9),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,10),
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
					new SqlParameter("@s_FeeReceiveCashStatue", SqlDbType.NVarChar,100),
					new SqlParameter("@n_ExchangeCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_Priority", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@s_ElecPayer", SqlDbType.NVarChar,100),
					new SqlParameter("@n_AssignAnnualFeeHandler", SqlDbType.Int,4),
					new SqlParameter("@n_AssignBillHandler", SqlDbType.Int,4),
					new SqlParameter("@n_ReportStatus", SqlDbType.Int,4),
					new SqlParameter("@n_FeeApprovalStatus", SqlDbType.Int,4),
					new SqlParameter("@s_BillApprovalStatus", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ApprovalNotes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@dt_CheckDate", SqlDbType.DateTime),
					new SqlParameter("@s_ReceiptNo", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_ReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@n_OperatorID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.n_YearNo;
			parameters[2].Value = model.s_Status;
			parameters[3].Value = model.s_PayMode;
			parameters[4].Value = model.s_StatusOrder;
			parameters[5].Value = model.n_ChargeCurrency;
			parameters[6].Value = model.n_ChargeOFee;
			parameters[7].Value = model.n_ChargeAFee;
			parameters[8].Value = model.n_ChargeTFee;
			parameters[9].Value = model.dt_ChargeShldPayDate;
			parameters[10].Value = model.dt_ChargePayDate;
			parameters[11].Value = model.n_OfficialCurrency;
			parameters[12].Value = model.n_OfficialFee;
			parameters[13].Value = model.n_OfficialLateFee;
			parameters[14].Value = model.s_IsOfficialDisc;
			parameters[15].Value = model.s_OfficialDiscStyle;
			parameters[16].Value = model.n_OfficialDiscount;
			parameters[17].Value = model.dt_OfficialShldPayDate;
			parameters[18].Value = model.dt_OfficialPayDate;
			parameters[19].Value = model.s_OfficialReceiptPath;
			parameters[20].Value = model.n_PayFeeListID;
			parameters[21].Value = model.s_Notes;
			parameters[22].Value = model.s_InvoiceNum;
			parameters[23].Value = model.dt_AlarmDate;
			parameters[24].Value = model.n_Rate;
			parameters[25].Value = model.s_IsActive;
			parameters[26].Value = model.dt_CreateDate;
			parameters[27].Value = model.dt_EditDate;
			parameters[28].Value = model.s_FeeReceiveCashStatue;
			parameters[29].Value = model.n_ExchangeCurrency;
			parameters[30].Value = model.s_Priority;
			parameters[31].Value = model.s_Creator;
			parameters[32].Value = model.s_Editor;
			parameters[33].Value = model.n_BillID;
			parameters[34].Value = model.s_ElecPayer;
			parameters[35].Value = model.n_AssignAnnualFeeHandler;
			parameters[36].Value = model.n_AssignBillHandler;
			parameters[37].Value = model.n_ReportStatus;
			parameters[38].Value = model.n_FeeApprovalStatus;
			parameters[39].Value = model.s_BillApprovalStatus;
			parameters[40].Value = model.s_ApprovalNotes;
			parameters[41].Value = model.s_CheckStatus;
			parameters[42].Value = model.n_Checker;
			parameters[43].Value = model.dt_CheckDate;
			parameters[44].Value = model.s_ReceiptNo;
			parameters[45].Value = model.dt_ReceiptDate;
			parameters[46].Value = model.n_OperatorID;

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
		public bool Update(IPSP.Model.T_AnnualFee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_AnnualFee set ");
			strSql.Append("n_YearNo=@n_YearNo,");
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
			strSql.Append("s_FeeReceiveCashStatue=@s_FeeReceiveCashStatue,");
			strSql.Append("n_ExchangeCurrency=@n_ExchangeCurrency,");
			strSql.Append("s_Priority=@s_Priority,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("s_ElecPayer=@s_ElecPayer,");
			strSql.Append("n_AssignAnnualFeeHandler=@n_AssignAnnualFeeHandler,");
			strSql.Append("n_AssignBillHandler=@n_AssignBillHandler,");
			strSql.Append("n_ReportStatus=@n_ReportStatus,");
			strSql.Append("n_FeeApprovalStatus=@n_FeeApprovalStatus,");
			strSql.Append("s_BillApprovalStatus=@s_BillApprovalStatus,");
			strSql.Append("s_ApprovalNotes=@s_ApprovalNotes,");
			strSql.Append("s_CheckStatus=@s_CheckStatus,");
			strSql.Append("n_Checker=@n_Checker,");
			strSql.Append("dt_CheckDate=@dt_CheckDate,");
			strSql.Append("s_ReceiptNo=@s_ReceiptNo,");
			strSql.Append("dt_ReceiptDate=@dt_ReceiptDate,");
			strSql.Append("n_OperatorID=@n_OperatorID");
			strSql.Append(" where n_AnnualFeeID=@n_AnnualFeeID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_YearNo", SqlDbType.Decimal,9),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,10),
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
					new SqlParameter("@s_FeeReceiveCashStatue", SqlDbType.NVarChar,100),
					new SqlParameter("@n_ExchangeCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_Priority", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ElecPayer", SqlDbType.NVarChar,100),
					new SqlParameter("@n_AssignAnnualFeeHandler", SqlDbType.Int,4),
					new SqlParameter("@n_AssignBillHandler", SqlDbType.Int,4),
					new SqlParameter("@n_ReportStatus", SqlDbType.Int,4),
					new SqlParameter("@n_FeeApprovalStatus", SqlDbType.Int,4),
					new SqlParameter("@s_BillApprovalStatus", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ApprovalNotes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@dt_CheckDate", SqlDbType.DateTime),
					new SqlParameter("@s_ReceiptNo", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_ReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@n_OperatorID", SqlDbType.Int,4),
					new SqlParameter("@n_AnnualFeeID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_YearNo;
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
			parameters[27].Value = model.s_FeeReceiveCashStatue;
			parameters[28].Value = model.n_ExchangeCurrency;
			parameters[29].Value = model.s_Priority;
			parameters[30].Value = model.s_Creator;
			parameters[31].Value = model.s_Editor;
			parameters[32].Value = model.s_ElecPayer;
			parameters[33].Value = model.n_AssignAnnualFeeHandler;
			parameters[34].Value = model.n_AssignBillHandler;
			parameters[35].Value = model.n_ReportStatus;
			parameters[36].Value = model.n_FeeApprovalStatus;
			parameters[37].Value = model.s_BillApprovalStatus;
			parameters[38].Value = model.s_ApprovalNotes;
			parameters[39].Value = model.s_CheckStatus;
			parameters[40].Value = model.n_Checker;
			parameters[41].Value = model.dt_CheckDate;
			parameters[42].Value = model.s_ReceiptNo;
			parameters[43].Value = model.dt_ReceiptDate;
			parameters[44].Value = model.n_OperatorID;
			parameters[45].Value = model.n_AnnualFeeID;
			parameters[46].Value = model.n_CaseID;
			parameters[47].Value = model.n_BillID;

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
		public bool Delete(int n_AnnualFeeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_AnnualFee ");
			strSql.Append(" where n_AnnualFeeID=@n_AnnualFeeID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AnnualFeeID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_AnnualFeeID;

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
		public bool Delete(int n_CaseID,int n_BillID,int n_AnnualFeeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_AnnualFee ");
			strSql.Append(" where n_CaseID=@n_CaseID and n_BillID=@n_BillID and n_AnnualFeeID=@n_AnnualFeeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_AnnualFeeID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_BillID;
			parameters[2].Value = n_AnnualFeeID;

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
		public bool DeleteList(string n_AnnualFeeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_AnnualFee ");
			strSql.Append(" where n_AnnualFeeID in ("+n_AnnualFeeIDlist + ")  ");
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
		public IPSP.Model.T_AnnualFee GetModel(int n_AnnualFeeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_AnnualFeeID,n_CaseID,n_YearNo,s_Status,s_PayMode,s_StatusOrder,n_ChargeCurrency,n_ChargeOFee,n_ChargeAFee,n_ChargeTFee,dt_ChargeShldPayDate,dt_ChargePayDate,n_OfficialCurrency,n_OfficialFee,n_OfficialLateFee,s_IsOfficialDisc,s_OfficialDiscStyle,n_OfficialDiscount,dt_OfficialShldPayDate,dt_OfficialPayDate,s_OfficialReceiptPath,n_PayFeeListID,s_Notes,s_InvoiceNum,dt_AlarmDate,n_Rate,s_IsActive,dt_CreateDate,dt_EditDate,s_FeeReceiveCashStatue,n_ExchangeCurrency,s_Priority,s_Creator,s_Editor,n_BillID,s_ElecPayer,n_AssignAnnualFeeHandler,n_AssignBillHandler,n_ReportStatus,n_FeeApprovalStatus,s_BillApprovalStatus,s_ApprovalNotes,s_CheckStatus,n_Checker,dt_CheckDate,s_ReceiptNo,dt_ReceiptDate,n_OperatorID from T_AnnualFee ");
			strSql.Append(" where n_AnnualFeeID=@n_AnnualFeeID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AnnualFeeID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_AnnualFeeID;

			IPSP.Model.T_AnnualFee model=new IPSP.Model.T_AnnualFee();
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
		public IPSP.Model.T_AnnualFee DataRowToModel(DataRow row)
		{
			IPSP.Model.T_AnnualFee model=new IPSP.Model.T_AnnualFee();
			if (row != null)
			{
				if(row["n_AnnualFeeID"]!=null && row["n_AnnualFeeID"].ToString()!="")
				{
					model.n_AnnualFeeID=int.Parse(row["n_AnnualFeeID"].ToString());
				}
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["n_YearNo"]!=null && row["n_YearNo"].ToString()!="")
				{
					model.n_YearNo=decimal.Parse(row["n_YearNo"].ToString());
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
				if(row["s_FeeReceiveCashStatue"]!=null)
				{
					model.s_FeeReceiveCashStatue=row["s_FeeReceiveCashStatue"].ToString();
				}
				if(row["n_ExchangeCurrency"]!=null && row["n_ExchangeCurrency"].ToString()!="")
				{
					model.n_ExchangeCurrency=int.Parse(row["n_ExchangeCurrency"].ToString());
				}
				if(row["s_Priority"]!=null)
				{
					model.s_Priority=row["s_Priority"].ToString();
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
				if(row["s_ElecPayer"]!=null)
				{
					model.s_ElecPayer=row["s_ElecPayer"].ToString();
				}
				if(row["n_AssignAnnualFeeHandler"]!=null && row["n_AssignAnnualFeeHandler"].ToString()!="")
				{
					model.n_AssignAnnualFeeHandler=int.Parse(row["n_AssignAnnualFeeHandler"].ToString());
				}
				if(row["n_AssignBillHandler"]!=null && row["n_AssignBillHandler"].ToString()!="")
				{
					model.n_AssignBillHandler=int.Parse(row["n_AssignBillHandler"].ToString());
				}
				if(row["n_ReportStatus"]!=null && row["n_ReportStatus"].ToString()!="")
				{
					model.n_ReportStatus=int.Parse(row["n_ReportStatus"].ToString());
				}
				if(row["n_FeeApprovalStatus"]!=null && row["n_FeeApprovalStatus"].ToString()!="")
				{
					model.n_FeeApprovalStatus=int.Parse(row["n_FeeApprovalStatus"].ToString());
				}
				if(row["s_BillApprovalStatus"]!=null)
				{
					model.s_BillApprovalStatus=row["s_BillApprovalStatus"].ToString();
				}
				if(row["s_ApprovalNotes"]!=null)
				{
					model.s_ApprovalNotes=row["s_ApprovalNotes"].ToString();
				}
				if(row["s_CheckStatus"]!=null)
				{
					model.s_CheckStatus=row["s_CheckStatus"].ToString();
				}
				if(row["n_Checker"]!=null && row["n_Checker"].ToString()!="")
				{
					model.n_Checker=int.Parse(row["n_Checker"].ToString());
				}
				if(row["dt_CheckDate"]!=null && row["dt_CheckDate"].ToString()!="")
				{
					model.dt_CheckDate=DateTime.Parse(row["dt_CheckDate"].ToString());
				}
				if(row["s_ReceiptNo"]!=null)
				{
					model.s_ReceiptNo=row["s_ReceiptNo"].ToString();
				}
				if(row["dt_ReceiptDate"]!=null && row["dt_ReceiptDate"].ToString()!="")
				{
					model.dt_ReceiptDate=DateTime.Parse(row["dt_ReceiptDate"].ToString());
				}
				if(row["n_OperatorID"]!=null && row["n_OperatorID"].ToString()!="")
				{
					model.n_OperatorID=int.Parse(row["n_OperatorID"].ToString());
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
			strSql.Append("select n_AnnualFeeID,n_CaseID,n_YearNo,s_Status,s_PayMode,s_StatusOrder,n_ChargeCurrency,n_ChargeOFee,n_ChargeAFee,n_ChargeTFee,dt_ChargeShldPayDate,dt_ChargePayDate,n_OfficialCurrency,n_OfficialFee,n_OfficialLateFee,s_IsOfficialDisc,s_OfficialDiscStyle,n_OfficialDiscount,dt_OfficialShldPayDate,dt_OfficialPayDate,s_OfficialReceiptPath,n_PayFeeListID,s_Notes,s_InvoiceNum,dt_AlarmDate,n_Rate,s_IsActive,dt_CreateDate,dt_EditDate,s_FeeReceiveCashStatue,n_ExchangeCurrency,s_Priority,s_Creator,s_Editor,n_BillID,s_ElecPayer,n_AssignAnnualFeeHandler,n_AssignBillHandler,n_ReportStatus,n_FeeApprovalStatus,s_BillApprovalStatus,s_ApprovalNotes,s_CheckStatus,n_Checker,dt_CheckDate,s_ReceiptNo,dt_ReceiptDate,n_OperatorID ");
			strSql.Append(" FROM T_AnnualFee ");
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
			strSql.Append(" n_AnnualFeeID,n_CaseID,n_YearNo,s_Status,s_PayMode,s_StatusOrder,n_ChargeCurrency,n_ChargeOFee,n_ChargeAFee,n_ChargeTFee,dt_ChargeShldPayDate,dt_ChargePayDate,n_OfficialCurrency,n_OfficialFee,n_OfficialLateFee,s_IsOfficialDisc,s_OfficialDiscStyle,n_OfficialDiscount,dt_OfficialShldPayDate,dt_OfficialPayDate,s_OfficialReceiptPath,n_PayFeeListID,s_Notes,s_InvoiceNum,dt_AlarmDate,n_Rate,s_IsActive,dt_CreateDate,dt_EditDate,s_FeeReceiveCashStatue,n_ExchangeCurrency,s_Priority,s_Creator,s_Editor,n_BillID,s_ElecPayer,n_AssignAnnualFeeHandler,n_AssignBillHandler,n_ReportStatus,n_FeeApprovalStatus,s_BillApprovalStatus,s_ApprovalNotes,s_CheckStatus,n_Checker,dt_CheckDate,s_ReceiptNo,dt_ReceiptDate,n_OperatorID ");
			strSql.Append(" FROM T_AnnualFee ");
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
			strSql.Append("select count(1) FROM T_AnnualFee ");
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
				strSql.Append("order by T.n_AnnualFeeID desc");
			}
			strSql.Append(")AS Row, T.*  from T_AnnualFee T ");
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
			parameters[0].Value = "T_AnnualFee";
			parameters[1].Value = "n_AnnualFeeID";
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

