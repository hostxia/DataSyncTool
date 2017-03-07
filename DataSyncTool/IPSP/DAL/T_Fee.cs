/**  版本信息模板在安装目录下，可自行修改。
* T_Fee.cs
*
* 功 能： N/A
* 类 名： T_Fee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:44   N/A    初版
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
	/// 数据访问类:T_Fee
	/// </summary>
	public partial class T_Fee
	{
		public T_Fee()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_BillID", "T_Fee"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_BillID,int n_FeeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Fee");
			strSql.Append(" where n_BillID=@n_BillID and n_FeeID=@n_FeeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_FeeID", SqlDbType.Int,4)			};
			parameters[0].Value = n_BillID;
			parameters[1].Value = n_FeeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_Fee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Fee(");
			strSql.Append("n_FeeCodeID,s_Status,s_PayMode,s_StatusOrder,n_ChargeCurrency,n_ChargeOFee,n_ChargeAFee,n_ChargeTFee,dt_ChargeShldPayDate,dt_ChargePayDate,n_OfficialCurrency,n_OfficialFee,s_OfficialDiscMark,s_OfficialDiscStyle,n_OfficialDiscount,dt_OfficialShldPayDate,dt_OfficialPayDate,s_OfficialReceiptPath,n_PayFeeListID,s_Notes,s_InvoiceNum,n_Rate,s_IsActive,dt_CreateDate,dt_EditDate,s_FeePaymentStatue,s_FeeReceiveCashStatue,n_ExchangeCurrency,n_CameFileID,s_ChargeFeeName,s_OfficialFeeName,s_FeeName,s_ProcessMark,n_Asker,dt_AskDate,n_Checker,dt_CheckDate,n_Payer,dt_PayDate,n_Receipter,dt_ReceiptDate,s_ReceiptNo,s_ProcessNote,s_CaseSerial,s_ClientContacts,s_AppNo,dt_AppDate,s_Applicants,s_Introducer,s_Attorney,n_PatentTypeID,n_FBillListID,n_BonusCalced,s_Creator,s_Editor,n_ExpenseID,s_BonusFeeType,n_MainCaseID,s_ChargeNativeName,s_OfficialNativeName,s_ReviewStatus,n_moreUnitCount,s_feeBeyondItemUnit,n_ChargeDiscountAFeeRate,n_OriAgencyFee,s_TransLateFeeDiscountType,n_OriTransLateCount,n_CreatorID,s_CheckStatus,n_BillID,s_FeeMode,s_ElecPayer,s_ChargingCheckStatus,n_ChargingChecker,dt_ChargingCheckDate,s_ChargingNotes)");
			strSql.Append(" values (");
			strSql.Append("@n_FeeCodeID,@s_Status,@s_PayMode,@s_StatusOrder,@n_ChargeCurrency,@n_ChargeOFee,@n_ChargeAFee,@n_ChargeTFee,@dt_ChargeShldPayDate,@dt_ChargePayDate,@n_OfficialCurrency,@n_OfficialFee,@s_OfficialDiscMark,@s_OfficialDiscStyle,@n_OfficialDiscount,@dt_OfficialShldPayDate,@dt_OfficialPayDate,@s_OfficialReceiptPath,@n_PayFeeListID,@s_Notes,@s_InvoiceNum,@n_Rate,@s_IsActive,@dt_CreateDate,@dt_EditDate,@s_FeePaymentStatue,@s_FeeReceiveCashStatue,@n_ExchangeCurrency,@n_CameFileID,@s_ChargeFeeName,@s_OfficialFeeName,@s_FeeName,@s_ProcessMark,@n_Asker,@dt_AskDate,@n_Checker,@dt_CheckDate,@n_Payer,@dt_PayDate,@n_Receipter,@dt_ReceiptDate,@s_ReceiptNo,@s_ProcessNote,@s_CaseSerial,@s_ClientContacts,@s_AppNo,@dt_AppDate,@s_Applicants,@s_Introducer,@s_Attorney,@n_PatentTypeID,@n_FBillListID,@n_BonusCalced,@s_Creator,@s_Editor,@n_ExpenseID,@s_BonusFeeType,@n_MainCaseID,@s_ChargeNativeName,@s_OfficialNativeName,@s_ReviewStatus,@n_moreUnitCount,@s_feeBeyondItemUnit,@n_ChargeDiscountAFeeRate,@n_OriAgencyFee,@s_TransLateFeeDiscountType,@n_OriTransLateCount,@n_CreatorID,@s_CheckStatus,@n_BillID,@s_FeeMode,@s_ElecPayer,@s_ChargingCheckStatus,@n_ChargingChecker,@dt_ChargingCheckDate,@s_ChargingNotes)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FeeCodeID", SqlDbType.Int,4),
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
					new SqlParameter("@s_OfficialDiscMark", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OfficialDiscStyle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_OfficialDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@dt_OfficialShldPayDate", SqlDbType.DateTime),
					new SqlParameter("@dt_OfficialPayDate", SqlDbType.DateTime),
					new SqlParameter("@s_OfficialReceiptPath", SqlDbType.NVarChar,500),
					new SqlParameter("@n_PayFeeListID", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_InvoiceNum", SqlDbType.NVarChar,50),
					new SqlParameter("@n_Rate", SqlDbType.Decimal,9),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_FeePaymentStatue", SqlDbType.NVarChar,100),
					new SqlParameter("@s_FeeReceiveCashStatue", SqlDbType.NVarChar,100),
					new SqlParameter("@n_ExchangeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_CameFileID", SqlDbType.Int,4),
					new SqlParameter("@s_ChargeFeeName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_OfficialFeeName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_FeeName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ProcessMark", SqlDbType.NVarChar,10),
					new SqlParameter("@n_Asker", SqlDbType.Int,4),
					new SqlParameter("@dt_AskDate", SqlDbType.DateTime),
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@dt_CheckDate", SqlDbType.DateTime),
					new SqlParameter("@n_Payer", SqlDbType.Int,4),
					new SqlParameter("@dt_PayDate", SqlDbType.DateTime),
					new SqlParameter("@n_Receipter", SqlDbType.Int,4),
					new SqlParameter("@dt_ReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@s_ReceiptNo", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ProcessNote", SqlDbType.NVarChar,800),
					new SqlParameter("@s_CaseSerial", SqlDbType.VarChar,100),
					new SqlParameter("@s_ClientContacts", SqlDbType.VarChar,1000),
					new SqlParameter("@s_AppNo", SqlDbType.VarChar,100),
					new SqlParameter("@dt_AppDate", SqlDbType.DateTime),
					new SqlParameter("@s_Applicants", SqlDbType.VarChar,1000),
					new SqlParameter("@s_Introducer", SqlDbType.VarChar,300),
					new SqlParameter("@s_Attorney", SqlDbType.VarChar,200),
					new SqlParameter("@n_PatentTypeID", SqlDbType.Int,4),
					new SqlParameter("@n_FBillListID", SqlDbType.Int,4),
					new SqlParameter("@n_BonusCalced", SqlDbType.Bit,1),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ExpenseID", SqlDbType.Int,4),
					new SqlParameter("@s_BonusFeeType", SqlDbType.NChar,1),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@s_ChargeNativeName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_OfficialNativeName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ReviewStatus", SqlDbType.NVarChar,2),
					new SqlParameter("@n_moreUnitCount", SqlDbType.Money,8),
					new SqlParameter("@s_feeBeyondItemUnit", SqlDbType.NVarChar,10),
					new SqlParameter("@n_ChargeDiscountAFeeRate", SqlDbType.Money,8),
					new SqlParameter("@n_OriAgencyFee", SqlDbType.Money,8),
					new SqlParameter("@s_TransLateFeeDiscountType", SqlDbType.NVarChar,100),
					new SqlParameter("@n_OriTransLateCount", SqlDbType.Money,8),
					new SqlParameter("@n_CreatorID", SqlDbType.Int,4),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@s_FeeMode", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ElecPayer", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ChargingCheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ChargingChecker", SqlDbType.Int,4),
					new SqlParameter("@dt_ChargingCheckDate", SqlDbType.DateTime),
					new SqlParameter("@s_ChargingNotes", SqlDbType.NVarChar,800)};
			parameters[0].Value = model.n_FeeCodeID;
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
			parameters[12].Value = model.s_OfficialDiscMark;
			parameters[13].Value = model.s_OfficialDiscStyle;
			parameters[14].Value = model.n_OfficialDiscount;
			parameters[15].Value = model.dt_OfficialShldPayDate;
			parameters[16].Value = model.dt_OfficialPayDate;
			parameters[17].Value = model.s_OfficialReceiptPath;
			parameters[18].Value = model.n_PayFeeListID;
			parameters[19].Value = model.s_Notes;
			parameters[20].Value = model.s_InvoiceNum;
			parameters[21].Value = model.n_Rate;
			parameters[22].Value = model.s_IsActive;
			parameters[23].Value = model.dt_CreateDate;
			parameters[24].Value = model.dt_EditDate;
			parameters[25].Value = model.s_FeePaymentStatue;
			parameters[26].Value = model.s_FeeReceiveCashStatue;
			parameters[27].Value = model.n_ExchangeCurrency;
			parameters[28].Value = model.n_CameFileID;
			parameters[29].Value = model.s_ChargeFeeName;
			parameters[30].Value = model.s_OfficialFeeName;
			parameters[31].Value = model.s_FeeName;
			parameters[32].Value = model.s_ProcessMark;
			parameters[33].Value = model.n_Asker;
			parameters[34].Value = model.dt_AskDate;
			parameters[35].Value = model.n_Checker;
			parameters[36].Value = model.dt_CheckDate;
			parameters[37].Value = model.n_Payer;
			parameters[38].Value = model.dt_PayDate;
			parameters[39].Value = model.n_Receipter;
			parameters[40].Value = model.dt_ReceiptDate;
			parameters[41].Value = model.s_ReceiptNo;
			parameters[42].Value = model.s_ProcessNote;
			parameters[43].Value = model.s_CaseSerial;
			parameters[44].Value = model.s_ClientContacts;
			parameters[45].Value = model.s_AppNo;
			parameters[46].Value = model.dt_AppDate;
			parameters[47].Value = model.s_Applicants;
			parameters[48].Value = model.s_Introducer;
			parameters[49].Value = model.s_Attorney;
			parameters[50].Value = model.n_PatentTypeID;
			parameters[51].Value = model.n_FBillListID;
			parameters[52].Value = model.n_BonusCalced;
			parameters[53].Value = model.s_Creator;
			parameters[54].Value = model.s_Editor;
			parameters[55].Value = model.n_ExpenseID;
			parameters[56].Value = model.s_BonusFeeType;
			parameters[57].Value = model.n_MainCaseID;
			parameters[58].Value = model.s_ChargeNativeName;
			parameters[59].Value = model.s_OfficialNativeName;
			parameters[60].Value = model.s_ReviewStatus;
			parameters[61].Value = model.n_moreUnitCount;
			parameters[62].Value = model.s_feeBeyondItemUnit;
			parameters[63].Value = model.n_ChargeDiscountAFeeRate;
			parameters[64].Value = model.n_OriAgencyFee;
			parameters[65].Value = model.s_TransLateFeeDiscountType;
			parameters[66].Value = model.n_OriTransLateCount;
			parameters[67].Value = model.n_CreatorID;
			parameters[68].Value = model.s_CheckStatus;
			parameters[69].Value = model.n_BillID;
			parameters[70].Value = model.s_FeeMode;
			parameters[71].Value = model.s_ElecPayer;
			parameters[72].Value = model.s_ChargingCheckStatus;
			parameters[73].Value = model.n_ChargingChecker;
			parameters[74].Value = model.dt_ChargingCheckDate;
			parameters[75].Value = model.s_ChargingNotes;

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
		public bool Update(IPSP.Model.T_Fee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Fee set ");
			strSql.Append("n_FeeCodeID=@n_FeeCodeID,");
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
			strSql.Append("s_OfficialDiscMark=@s_OfficialDiscMark,");
			strSql.Append("s_OfficialDiscStyle=@s_OfficialDiscStyle,");
			strSql.Append("n_OfficialDiscount=@n_OfficialDiscount,");
			strSql.Append("dt_OfficialShldPayDate=@dt_OfficialShldPayDate,");
			strSql.Append("dt_OfficialPayDate=@dt_OfficialPayDate,");
			strSql.Append("s_OfficialReceiptPath=@s_OfficialReceiptPath,");
			strSql.Append("n_PayFeeListID=@n_PayFeeListID,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("s_InvoiceNum=@s_InvoiceNum,");
			strSql.Append("n_Rate=@n_Rate,");
			strSql.Append("s_IsActive=@s_IsActive,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_FeePaymentStatue=@s_FeePaymentStatue,");
			strSql.Append("s_FeeReceiveCashStatue=@s_FeeReceiveCashStatue,");
			strSql.Append("n_ExchangeCurrency=@n_ExchangeCurrency,");
			strSql.Append("n_CameFileID=@n_CameFileID,");
			strSql.Append("s_ChargeFeeName=@s_ChargeFeeName,");
			strSql.Append("s_OfficialFeeName=@s_OfficialFeeName,");
			strSql.Append("s_FeeName=@s_FeeName,");
			strSql.Append("s_ProcessMark=@s_ProcessMark,");
			strSql.Append("n_Asker=@n_Asker,");
			strSql.Append("dt_AskDate=@dt_AskDate,");
			strSql.Append("n_Checker=@n_Checker,");
			strSql.Append("dt_CheckDate=@dt_CheckDate,");
			strSql.Append("n_Payer=@n_Payer,");
			strSql.Append("dt_PayDate=@dt_PayDate,");
			strSql.Append("n_Receipter=@n_Receipter,");
			strSql.Append("dt_ReceiptDate=@dt_ReceiptDate,");
			strSql.Append("s_ReceiptNo=@s_ReceiptNo,");
			strSql.Append("s_ProcessNote=@s_ProcessNote,");
			strSql.Append("s_CaseSerial=@s_CaseSerial,");
			strSql.Append("s_ClientContacts=@s_ClientContacts,");
			strSql.Append("s_AppNo=@s_AppNo,");
			strSql.Append("dt_AppDate=@dt_AppDate,");
			strSql.Append("s_Applicants=@s_Applicants,");
			strSql.Append("s_Introducer=@s_Introducer,");
			strSql.Append("s_Attorney=@s_Attorney,");
			strSql.Append("n_PatentTypeID=@n_PatentTypeID,");
			strSql.Append("n_FBillListID=@n_FBillListID,");
			strSql.Append("n_BonusCalced=@n_BonusCalced,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("n_ExpenseID=@n_ExpenseID,");
			strSql.Append("s_BonusFeeType=@s_BonusFeeType,");
			strSql.Append("n_MainCaseID=@n_MainCaseID,");
			strSql.Append("s_ChargeNativeName=@s_ChargeNativeName,");
			strSql.Append("s_OfficialNativeName=@s_OfficialNativeName,");
			strSql.Append("s_ReviewStatus=@s_ReviewStatus,");
			strSql.Append("n_moreUnitCount=@n_moreUnitCount,");
			strSql.Append("s_feeBeyondItemUnit=@s_feeBeyondItemUnit,");
			strSql.Append("n_ChargeDiscountAFeeRate=@n_ChargeDiscountAFeeRate,");
			strSql.Append("n_OriAgencyFee=@n_OriAgencyFee,");
			strSql.Append("s_TransLateFeeDiscountType=@s_TransLateFeeDiscountType,");
			strSql.Append("n_OriTransLateCount=@n_OriTransLateCount,");
			strSql.Append("n_CreatorID=@n_CreatorID,");
			strSql.Append("s_CheckStatus=@s_CheckStatus,");
			strSql.Append("s_FeeMode=@s_FeeMode,");
			strSql.Append("s_ElecPayer=@s_ElecPayer,");
			strSql.Append("s_ChargingCheckStatus=@s_ChargingCheckStatus,");
			strSql.Append("n_ChargingChecker=@n_ChargingChecker,");
			strSql.Append("dt_ChargingCheckDate=@dt_ChargingCheckDate,");
			strSql.Append("s_ChargingNotes=@s_ChargingNotes");
			strSql.Append(" where n_FeeID=@n_FeeID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FeeCodeID", SqlDbType.Int,4),
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
					new SqlParameter("@s_OfficialDiscMark", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OfficialDiscStyle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_OfficialDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@dt_OfficialShldPayDate", SqlDbType.DateTime),
					new SqlParameter("@dt_OfficialPayDate", SqlDbType.DateTime),
					new SqlParameter("@s_OfficialReceiptPath", SqlDbType.NVarChar,500),
					new SqlParameter("@n_PayFeeListID", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_InvoiceNum", SqlDbType.NVarChar,50),
					new SqlParameter("@n_Rate", SqlDbType.Decimal,9),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_FeePaymentStatue", SqlDbType.NVarChar,100),
					new SqlParameter("@s_FeeReceiveCashStatue", SqlDbType.NVarChar,100),
					new SqlParameter("@n_ExchangeCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_CameFileID", SqlDbType.Int,4),
					new SqlParameter("@s_ChargeFeeName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_OfficialFeeName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_FeeName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ProcessMark", SqlDbType.NVarChar,10),
					new SqlParameter("@n_Asker", SqlDbType.Int,4),
					new SqlParameter("@dt_AskDate", SqlDbType.DateTime),
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@dt_CheckDate", SqlDbType.DateTime),
					new SqlParameter("@n_Payer", SqlDbType.Int,4),
					new SqlParameter("@dt_PayDate", SqlDbType.DateTime),
					new SqlParameter("@n_Receipter", SqlDbType.Int,4),
					new SqlParameter("@dt_ReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@s_ReceiptNo", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ProcessNote", SqlDbType.NVarChar,800),
					new SqlParameter("@s_CaseSerial", SqlDbType.VarChar,100),
					new SqlParameter("@s_ClientContacts", SqlDbType.VarChar,1000),
					new SqlParameter("@s_AppNo", SqlDbType.VarChar,100),
					new SqlParameter("@dt_AppDate", SqlDbType.DateTime),
					new SqlParameter("@s_Applicants", SqlDbType.VarChar,1000),
					new SqlParameter("@s_Introducer", SqlDbType.VarChar,300),
					new SqlParameter("@s_Attorney", SqlDbType.VarChar,200),
					new SqlParameter("@n_PatentTypeID", SqlDbType.Int,4),
					new SqlParameter("@n_FBillListID", SqlDbType.Int,4),
					new SqlParameter("@n_BonusCalced", SqlDbType.Bit,1),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ExpenseID", SqlDbType.Int,4),
					new SqlParameter("@s_BonusFeeType", SqlDbType.NChar,1),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@s_ChargeNativeName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_OfficialNativeName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ReviewStatus", SqlDbType.NVarChar,2),
					new SqlParameter("@n_moreUnitCount", SqlDbType.Money,8),
					new SqlParameter("@s_feeBeyondItemUnit", SqlDbType.NVarChar,10),
					new SqlParameter("@n_ChargeDiscountAFeeRate", SqlDbType.Money,8),
					new SqlParameter("@n_OriAgencyFee", SqlDbType.Money,8),
					new SqlParameter("@s_TransLateFeeDiscountType", SqlDbType.NVarChar,100),
					new SqlParameter("@n_OriTransLateCount", SqlDbType.Money,8),
					new SqlParameter("@n_CreatorID", SqlDbType.Int,4),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@s_FeeMode", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ElecPayer", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ChargingCheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ChargingChecker", SqlDbType.Int,4),
					new SqlParameter("@dt_ChargingCheckDate", SqlDbType.DateTime),
					new SqlParameter("@s_ChargingNotes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_FeeID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_FeeCodeID;
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
			parameters[12].Value = model.s_OfficialDiscMark;
			parameters[13].Value = model.s_OfficialDiscStyle;
			parameters[14].Value = model.n_OfficialDiscount;
			parameters[15].Value = model.dt_OfficialShldPayDate;
			parameters[16].Value = model.dt_OfficialPayDate;
			parameters[17].Value = model.s_OfficialReceiptPath;
			parameters[18].Value = model.n_PayFeeListID;
			parameters[19].Value = model.s_Notes;
			parameters[20].Value = model.s_InvoiceNum;
			parameters[21].Value = model.n_Rate;
			parameters[22].Value = model.s_IsActive;
			parameters[23].Value = model.dt_CreateDate;
			parameters[24].Value = model.dt_EditDate;
			parameters[25].Value = model.s_FeePaymentStatue;
			parameters[26].Value = model.s_FeeReceiveCashStatue;
			parameters[27].Value = model.n_ExchangeCurrency;
			parameters[28].Value = model.n_CameFileID;
			parameters[29].Value = model.s_ChargeFeeName;
			parameters[30].Value = model.s_OfficialFeeName;
			parameters[31].Value = model.s_FeeName;
			parameters[32].Value = model.s_ProcessMark;
			parameters[33].Value = model.n_Asker;
			parameters[34].Value = model.dt_AskDate;
			parameters[35].Value = model.n_Checker;
			parameters[36].Value = model.dt_CheckDate;
			parameters[37].Value = model.n_Payer;
			parameters[38].Value = model.dt_PayDate;
			parameters[39].Value = model.n_Receipter;
			parameters[40].Value = model.dt_ReceiptDate;
			parameters[41].Value = model.s_ReceiptNo;
			parameters[42].Value = model.s_ProcessNote;
			parameters[43].Value = model.s_CaseSerial;
			parameters[44].Value = model.s_ClientContacts;
			parameters[45].Value = model.s_AppNo;
			parameters[46].Value = model.dt_AppDate;
			parameters[47].Value = model.s_Applicants;
			parameters[48].Value = model.s_Introducer;
			parameters[49].Value = model.s_Attorney;
			parameters[50].Value = model.n_PatentTypeID;
			parameters[51].Value = model.n_FBillListID;
			parameters[52].Value = model.n_BonusCalced;
			parameters[53].Value = model.s_Creator;
			parameters[54].Value = model.s_Editor;
			parameters[55].Value = model.n_ExpenseID;
			parameters[56].Value = model.s_BonusFeeType;
			parameters[57].Value = model.n_MainCaseID;
			parameters[58].Value = model.s_ChargeNativeName;
			parameters[59].Value = model.s_OfficialNativeName;
			parameters[60].Value = model.s_ReviewStatus;
			parameters[61].Value = model.n_moreUnitCount;
			parameters[62].Value = model.s_feeBeyondItemUnit;
			parameters[63].Value = model.n_ChargeDiscountAFeeRate;
			parameters[64].Value = model.n_OriAgencyFee;
			parameters[65].Value = model.s_TransLateFeeDiscountType;
			parameters[66].Value = model.n_OriTransLateCount;
			parameters[67].Value = model.n_CreatorID;
			parameters[68].Value = model.s_CheckStatus;
			parameters[69].Value = model.s_FeeMode;
			parameters[70].Value = model.s_ElecPayer;
			parameters[71].Value = model.s_ChargingCheckStatus;
			parameters[72].Value = model.n_ChargingChecker;
			parameters[73].Value = model.dt_ChargingCheckDate;
			parameters[74].Value = model.s_ChargingNotes;
			parameters[75].Value = model.n_FeeID;
			parameters[76].Value = model.n_BillID;

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
		public bool Delete(int n_FeeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Fee ");
			strSql.Append(" where n_FeeID=@n_FeeID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FeeID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_FeeID;

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
		public bool Delete(int n_BillID,int n_FeeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Fee ");
			strSql.Append(" where n_BillID=@n_BillID and n_FeeID=@n_FeeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_FeeID", SqlDbType.Int,4)			};
			parameters[0].Value = n_BillID;
			parameters[1].Value = n_FeeID;

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
		public bool DeleteList(string n_FeeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Fee ");
			strSql.Append(" where n_FeeID in ("+n_FeeIDlist + ")  ");
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
		public IPSP.Model.T_Fee GetModel(int n_FeeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_FeeID,n_FeeCodeID,s_Status,s_PayMode,s_StatusOrder,n_ChargeCurrency,n_ChargeOFee,n_ChargeAFee,n_ChargeTFee,dt_ChargeShldPayDate,dt_ChargePayDate,n_OfficialCurrency,n_OfficialFee,s_OfficialDiscMark,s_OfficialDiscStyle,n_OfficialDiscount,dt_OfficialShldPayDate,dt_OfficialPayDate,s_OfficialReceiptPath,n_PayFeeListID,s_Notes,s_InvoiceNum,n_Rate,s_IsActive,dt_CreateDate,dt_EditDate,s_FeePaymentStatue,s_FeeReceiveCashStatue,n_ExchangeCurrency,n_CameFileID,s_ChargeFeeName,s_OfficialFeeName,s_FeeName,s_ProcessMark,n_Asker,dt_AskDate,n_Checker,dt_CheckDate,n_Payer,dt_PayDate,n_Receipter,dt_ReceiptDate,s_ReceiptNo,s_ProcessNote,s_CaseSerial,s_ClientContacts,s_AppNo,dt_AppDate,s_Applicants,s_Introducer,s_Attorney,n_PatentTypeID,n_FBillListID,n_BonusCalced,s_Creator,s_Editor,n_ExpenseID,s_BonusFeeType,n_MainCaseID,s_ChargeNativeName,s_OfficialNativeName,s_ReviewStatus,n_moreUnitCount,s_feeBeyondItemUnit,n_ChargeDiscountAFeeRate,n_OriAgencyFee,s_TransLateFeeDiscountType,n_OriTransLateCount,n_CreatorID,s_CheckStatus,n_BillID,s_FeeMode,s_ElecPayer,s_ChargingCheckStatus,n_ChargingChecker,dt_ChargingCheckDate,s_ChargingNotes from T_Fee ");
			strSql.Append(" where n_FeeID=@n_FeeID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FeeID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_FeeID;

			IPSP.Model.T_Fee model=new IPSP.Model.T_Fee();
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
		public IPSP.Model.T_Fee DataRowToModel(DataRow row)
		{
			IPSP.Model.T_Fee model=new IPSP.Model.T_Fee();
			if (row != null)
			{
				if(row["n_FeeID"]!=null && row["n_FeeID"].ToString()!="")
				{
					model.n_FeeID=int.Parse(row["n_FeeID"].ToString());
				}
				if(row["n_FeeCodeID"]!=null && row["n_FeeCodeID"].ToString()!="")
				{
					model.n_FeeCodeID=int.Parse(row["n_FeeCodeID"].ToString());
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
				if(row["s_OfficialDiscMark"]!=null)
				{
					model.s_OfficialDiscMark=row["s_OfficialDiscMark"].ToString();
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
				if(row["s_FeePaymentStatue"]!=null)
				{
					model.s_FeePaymentStatue=row["s_FeePaymentStatue"].ToString();
				}
				if(row["s_FeeReceiveCashStatue"]!=null)
				{
					model.s_FeeReceiveCashStatue=row["s_FeeReceiveCashStatue"].ToString();
				}
				if(row["n_ExchangeCurrency"]!=null && row["n_ExchangeCurrency"].ToString()!="")
				{
					model.n_ExchangeCurrency=int.Parse(row["n_ExchangeCurrency"].ToString());
				}
				if(row["n_CameFileID"]!=null && row["n_CameFileID"].ToString()!="")
				{
					model.n_CameFileID=int.Parse(row["n_CameFileID"].ToString());
				}
				if(row["s_ChargeFeeName"]!=null)
				{
					model.s_ChargeFeeName=row["s_ChargeFeeName"].ToString();
				}
				if(row["s_OfficialFeeName"]!=null)
				{
					model.s_OfficialFeeName=row["s_OfficialFeeName"].ToString();
				}
				if(row["s_FeeName"]!=null)
				{
					model.s_FeeName=row["s_FeeName"].ToString();
				}
				if(row["s_ProcessMark"]!=null)
				{
					model.s_ProcessMark=row["s_ProcessMark"].ToString();
				}
				if(row["n_Asker"]!=null && row["n_Asker"].ToString()!="")
				{
					model.n_Asker=int.Parse(row["n_Asker"].ToString());
				}
				if(row["dt_AskDate"]!=null && row["dt_AskDate"].ToString()!="")
				{
					model.dt_AskDate=DateTime.Parse(row["dt_AskDate"].ToString());
				}
				if(row["n_Checker"]!=null && row["n_Checker"].ToString()!="")
				{
					model.n_Checker=int.Parse(row["n_Checker"].ToString());
				}
				if(row["dt_CheckDate"]!=null && row["dt_CheckDate"].ToString()!="")
				{
					model.dt_CheckDate=DateTime.Parse(row["dt_CheckDate"].ToString());
				}
				if(row["n_Payer"]!=null && row["n_Payer"].ToString()!="")
				{
					model.n_Payer=int.Parse(row["n_Payer"].ToString());
				}
				if(row["dt_PayDate"]!=null && row["dt_PayDate"].ToString()!="")
				{
					model.dt_PayDate=DateTime.Parse(row["dt_PayDate"].ToString());
				}
				if(row["n_Receipter"]!=null && row["n_Receipter"].ToString()!="")
				{
					model.n_Receipter=int.Parse(row["n_Receipter"].ToString());
				}
				if(row["dt_ReceiptDate"]!=null && row["dt_ReceiptDate"].ToString()!="")
				{
					model.dt_ReceiptDate=DateTime.Parse(row["dt_ReceiptDate"].ToString());
				}
				if(row["s_ReceiptNo"]!=null)
				{
					model.s_ReceiptNo=row["s_ReceiptNo"].ToString();
				}
				if(row["s_ProcessNote"]!=null)
				{
					model.s_ProcessNote=row["s_ProcessNote"].ToString();
				}
				if(row["s_CaseSerial"]!=null)
				{
					model.s_CaseSerial=row["s_CaseSerial"].ToString();
				}
				if(row["s_ClientContacts"]!=null)
				{
					model.s_ClientContacts=row["s_ClientContacts"].ToString();
				}
				if(row["s_AppNo"]!=null)
				{
					model.s_AppNo=row["s_AppNo"].ToString();
				}
				if(row["dt_AppDate"]!=null && row["dt_AppDate"].ToString()!="")
				{
					model.dt_AppDate=DateTime.Parse(row["dt_AppDate"].ToString());
				}
				if(row["s_Applicants"]!=null)
				{
					model.s_Applicants=row["s_Applicants"].ToString();
				}
				if(row["s_Introducer"]!=null)
				{
					model.s_Introducer=row["s_Introducer"].ToString();
				}
				if(row["s_Attorney"]!=null)
				{
					model.s_Attorney=row["s_Attorney"].ToString();
				}
				if(row["n_PatentTypeID"]!=null && row["n_PatentTypeID"].ToString()!="")
				{
					model.n_PatentTypeID=int.Parse(row["n_PatentTypeID"].ToString());
				}
				if(row["n_FBillListID"]!=null && row["n_FBillListID"].ToString()!="")
				{
					model.n_FBillListID=int.Parse(row["n_FBillListID"].ToString());
				}
				if(row["n_BonusCalced"]!=null && row["n_BonusCalced"].ToString()!="")
				{
					if((row["n_BonusCalced"].ToString()=="1")||(row["n_BonusCalced"].ToString().ToLower()=="true"))
					{
						model.n_BonusCalced=true;
					}
					else
					{
						model.n_BonusCalced=false;
					}
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["n_ExpenseID"]!=null && row["n_ExpenseID"].ToString()!="")
				{
					model.n_ExpenseID=int.Parse(row["n_ExpenseID"].ToString());
				}
				if(row["s_BonusFeeType"]!=null)
				{
					model.s_BonusFeeType=row["s_BonusFeeType"].ToString();
				}
				if(row["n_MainCaseID"]!=null && row["n_MainCaseID"].ToString()!="")
				{
					model.n_MainCaseID=int.Parse(row["n_MainCaseID"].ToString());
				}
				if(row["s_ChargeNativeName"]!=null)
				{
					model.s_ChargeNativeName=row["s_ChargeNativeName"].ToString();
				}
				if(row["s_OfficialNativeName"]!=null)
				{
					model.s_OfficialNativeName=row["s_OfficialNativeName"].ToString();
				}
				if(row["s_ReviewStatus"]!=null)
				{
					model.s_ReviewStatus=row["s_ReviewStatus"].ToString();
				}
				if(row["n_moreUnitCount"]!=null && row["n_moreUnitCount"].ToString()!="")
				{
					model.n_moreUnitCount=decimal.Parse(row["n_moreUnitCount"].ToString());
				}
				if(row["s_feeBeyondItemUnit"]!=null)
				{
					model.s_feeBeyondItemUnit=row["s_feeBeyondItemUnit"].ToString();
				}
				if(row["n_ChargeDiscountAFeeRate"]!=null && row["n_ChargeDiscountAFeeRate"].ToString()!="")
				{
					model.n_ChargeDiscountAFeeRate=decimal.Parse(row["n_ChargeDiscountAFeeRate"].ToString());
				}
				if(row["n_OriAgencyFee"]!=null && row["n_OriAgencyFee"].ToString()!="")
				{
					model.n_OriAgencyFee=decimal.Parse(row["n_OriAgencyFee"].ToString());
				}
				if(row["s_TransLateFeeDiscountType"]!=null)
				{
					model.s_TransLateFeeDiscountType=row["s_TransLateFeeDiscountType"].ToString();
				}
				if(row["n_OriTransLateCount"]!=null && row["n_OriTransLateCount"].ToString()!="")
				{
					model.n_OriTransLateCount=decimal.Parse(row["n_OriTransLateCount"].ToString());
				}
				if(row["n_CreatorID"]!=null && row["n_CreatorID"].ToString()!="")
				{
					model.n_CreatorID=int.Parse(row["n_CreatorID"].ToString());
				}
				if(row["s_CheckStatus"]!=null)
				{
					model.s_CheckStatus=row["s_CheckStatus"].ToString();
				}
				if(row["n_BillID"]!=null && row["n_BillID"].ToString()!="")
				{
					model.n_BillID=int.Parse(row["n_BillID"].ToString());
				}
				if(row["s_FeeMode"]!=null)
				{
					model.s_FeeMode=row["s_FeeMode"].ToString();
				}
				if(row["s_ElecPayer"]!=null)
				{
					model.s_ElecPayer=row["s_ElecPayer"].ToString();
				}
				if(row["s_ChargingCheckStatus"]!=null)
				{
					model.s_ChargingCheckStatus=row["s_ChargingCheckStatus"].ToString();
				}
				if(row["n_ChargingChecker"]!=null && row["n_ChargingChecker"].ToString()!="")
				{
					model.n_ChargingChecker=int.Parse(row["n_ChargingChecker"].ToString());
				}
				if(row["dt_ChargingCheckDate"]!=null && row["dt_ChargingCheckDate"].ToString()!="")
				{
					model.dt_ChargingCheckDate=DateTime.Parse(row["dt_ChargingCheckDate"].ToString());
				}
				if(row["s_ChargingNotes"]!=null)
				{
					model.s_ChargingNotes=row["s_ChargingNotes"].ToString();
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
			strSql.Append("select n_FeeID,n_FeeCodeID,s_Status,s_PayMode,s_StatusOrder,n_ChargeCurrency,n_ChargeOFee,n_ChargeAFee,n_ChargeTFee,dt_ChargeShldPayDate,dt_ChargePayDate,n_OfficialCurrency,n_OfficialFee,s_OfficialDiscMark,s_OfficialDiscStyle,n_OfficialDiscount,dt_OfficialShldPayDate,dt_OfficialPayDate,s_OfficialReceiptPath,n_PayFeeListID,s_Notes,s_InvoiceNum,n_Rate,s_IsActive,dt_CreateDate,dt_EditDate,s_FeePaymentStatue,s_FeeReceiveCashStatue,n_ExchangeCurrency,n_CameFileID,s_ChargeFeeName,s_OfficialFeeName,s_FeeName,s_ProcessMark,n_Asker,dt_AskDate,n_Checker,dt_CheckDate,n_Payer,dt_PayDate,n_Receipter,dt_ReceiptDate,s_ReceiptNo,s_ProcessNote,s_CaseSerial,s_ClientContacts,s_AppNo,dt_AppDate,s_Applicants,s_Introducer,s_Attorney,n_PatentTypeID,n_FBillListID,n_BonusCalced,s_Creator,s_Editor,n_ExpenseID,s_BonusFeeType,n_MainCaseID,s_ChargeNativeName,s_OfficialNativeName,s_ReviewStatus,n_moreUnitCount,s_feeBeyondItemUnit,n_ChargeDiscountAFeeRate,n_OriAgencyFee,s_TransLateFeeDiscountType,n_OriTransLateCount,n_CreatorID,s_CheckStatus,n_BillID,s_FeeMode,s_ElecPayer,s_ChargingCheckStatus,n_ChargingChecker,dt_ChargingCheckDate,s_ChargingNotes ");
			strSql.Append(" FROM T_Fee ");
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
			strSql.Append(" n_FeeID,n_FeeCodeID,s_Status,s_PayMode,s_StatusOrder,n_ChargeCurrency,n_ChargeOFee,n_ChargeAFee,n_ChargeTFee,dt_ChargeShldPayDate,dt_ChargePayDate,n_OfficialCurrency,n_OfficialFee,s_OfficialDiscMark,s_OfficialDiscStyle,n_OfficialDiscount,dt_OfficialShldPayDate,dt_OfficialPayDate,s_OfficialReceiptPath,n_PayFeeListID,s_Notes,s_InvoiceNum,n_Rate,s_IsActive,dt_CreateDate,dt_EditDate,s_FeePaymentStatue,s_FeeReceiveCashStatue,n_ExchangeCurrency,n_CameFileID,s_ChargeFeeName,s_OfficialFeeName,s_FeeName,s_ProcessMark,n_Asker,dt_AskDate,n_Checker,dt_CheckDate,n_Payer,dt_PayDate,n_Receipter,dt_ReceiptDate,s_ReceiptNo,s_ProcessNote,s_CaseSerial,s_ClientContacts,s_AppNo,dt_AppDate,s_Applicants,s_Introducer,s_Attorney,n_PatentTypeID,n_FBillListID,n_BonusCalced,s_Creator,s_Editor,n_ExpenseID,s_BonusFeeType,n_MainCaseID,s_ChargeNativeName,s_OfficialNativeName,s_ReviewStatus,n_moreUnitCount,s_feeBeyondItemUnit,n_ChargeDiscountAFeeRate,n_OriAgencyFee,s_TransLateFeeDiscountType,n_OriTransLateCount,n_CreatorID,s_CheckStatus,n_BillID,s_FeeMode,s_ElecPayer,s_ChargingCheckStatus,n_ChargingChecker,dt_ChargingCheckDate,s_ChargingNotes ");
			strSql.Append(" FROM T_Fee ");
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
			strSql.Append("select count(1) FROM T_Fee ");
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
				strSql.Append("order by T.n_FeeID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Fee T ");
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
			parameters[0].Value = "T_Fee";
			parameters[1].Value = "n_FeeID";
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

