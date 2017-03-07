/**  版本信息模板在安装目录下，可自行修改。
* T_Bill.cs
*
* 功 能： N/A
* 类 名： T_Bill
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:30   N/A    初版
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
	/// 数据访问类:T_Bill
	/// </summary>
	public partial class T_Bill
	{
		public T_Bill()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ClientID", "T_Bill"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ClientID,int n_BillID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Bill");
			strSql.Append(" where n_ClientID=@n_ClientID and n_BillID=@n_BillID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = n_BillID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_Bill model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Bill(");
			strSql.Append("s_BillNum,n_FlowNum,s_Status,dt_ShldPayDate,dt_ConfirmDate,n_ClientID,s_Reason,s_BillTo,s_BillToName,s_Street,s_City,s_State,n_Country,s_ZipCode,n_InvoiceTemplate,n_BillCurrency,n_Rate,n_ExchangeCurrency,s_FilePath,dt_CreateDate,dt_EditDate,s_IsAnnBill,s_BillType,s_ShowZero,n_FeeSum,s_Creator,s_Editor,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,n_MainCaseID,n_RemindCount,dt_RecentRemindDate,s_CaseSerial,s_AppNo,s_InvoiceNum,s_Language,n_OFeeSum,n_AFeeSum,n_TFeeSum,dt_BillDate,s_ClientSerial,s_Applicants,n_Rate2,n_FeeSum2,n_BillCurrency2,n_PayerID,s_PayerType,s_Notes,dt_SendOutDate,n_PreferentialCombineID,s_Email,s_CheckStatus,n_Checker,dt_CheckDate,s_Flag)");
			strSql.Append(" values (");
			strSql.Append("@s_BillNum,@n_FlowNum,@s_Status,@dt_ShldPayDate,@dt_ConfirmDate,@n_ClientID,@s_Reason,@s_BillTo,@s_BillToName,@s_Street,@s_City,@s_State,@n_Country,@s_ZipCode,@n_InvoiceTemplate,@n_BillCurrency,@n_Rate,@n_ExchangeCurrency,@s_FilePath,@dt_CreateDate,@dt_EditDate,@s_IsAnnBill,@s_BillType,@s_ShowZero,@n_FeeSum,@s_Creator,@s_Editor,@n_ModuleCheckStatusID,@n_LatestCheckInfoID,@n_AuthorID,@n_CurCheckerID,@n_MainCaseID,@n_RemindCount,@dt_RecentRemindDate,@s_CaseSerial,@s_AppNo,@s_InvoiceNum,@s_Language,@n_OFeeSum,@n_AFeeSum,@n_TFeeSum,@dt_BillDate,@s_ClientSerial,@s_Applicants,@n_Rate2,@n_FeeSum2,@n_BillCurrency2,@n_PayerID,@s_PayerType,@s_Notes,@dt_SendOutDate,@n_PreferentialCombineID,@s_Email,@s_CheckStatus,@n_Checker,@dt_CheckDate,@s_Flag)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_BillNum", SqlDbType.NVarChar,50),
					new SqlParameter("@n_FlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_ShldPayDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ConfirmDate", SqlDbType.DateTime),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@s_Reason", SqlDbType.NVarChar,800),
					new SqlParameter("@s_BillTo", SqlDbType.NVarChar,300),
					new SqlParameter("@s_BillToName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Street", SqlDbType.NVarChar,300),
					new SqlParameter("@s_City", SqlDbType.NVarChar,100),
					new SqlParameter("@s_State", SqlDbType.NVarChar,100),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@n_InvoiceTemplate", SqlDbType.Int,4),
					new SqlParameter("@n_BillCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_Rate", SqlDbType.Decimal,9),
					new SqlParameter("@n_ExchangeCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IsAnnBill", SqlDbType.NVarChar,1),
					new SqlParameter("@s_BillType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ShowZero", SqlDbType.NVarChar,50),
					new SqlParameter("@n_FeeSum", SqlDbType.Decimal,9),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ModuleCheckStatusID", SqlDbType.Int,4),
					new SqlParameter("@n_LatestCheckInfoID", SqlDbType.Int,4),
					new SqlParameter("@n_AuthorID", SqlDbType.Int,4),
					new SqlParameter("@n_CurCheckerID", SqlDbType.Int,4),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@n_RemindCount", SqlDbType.Int,4),
					new SqlParameter("@dt_RecentRemindDate", SqlDbType.DateTime),
					new SqlParameter("@s_CaseSerial", SqlDbType.NVarChar,500),
					new SqlParameter("@s_AppNo", SqlDbType.NVarChar,500),
					new SqlParameter("@s_InvoiceNum", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Language", SqlDbType.NVarChar,2),
					new SqlParameter("@n_OFeeSum", SqlDbType.Decimal,9),
					new SqlParameter("@n_AFeeSum", SqlDbType.Decimal,9),
					new SqlParameter("@n_TFeeSum", SqlDbType.Decimal,9),
					new SqlParameter("@dt_BillDate", SqlDbType.DateTime),
					new SqlParameter("@s_ClientSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Applicants", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_Rate2", SqlDbType.Decimal,9),
					new SqlParameter("@n_FeeSum2", SqlDbType.Decimal,9),
					new SqlParameter("@n_BillCurrency2", SqlDbType.Int,4),
					new SqlParameter("@n_PayerID", SqlDbType.Int,4),
					new SqlParameter("@s_PayerType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_SendOutDate", SqlDbType.DateTime),
					new SqlParameter("@n_PreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@dt_CheckDate", SqlDbType.DateTime),
					new SqlParameter("@s_Flag", SqlDbType.NVarChar,1)};
			parameters[0].Value = model.s_BillNum;
			parameters[1].Value = model.n_FlowNum;
			parameters[2].Value = model.s_Status;
			parameters[3].Value = model.dt_ShldPayDate;
			parameters[4].Value = model.dt_ConfirmDate;
			parameters[5].Value = model.n_ClientID;
			parameters[6].Value = model.s_Reason;
			parameters[7].Value = model.s_BillTo;
			parameters[8].Value = model.s_BillToName;
			parameters[9].Value = model.s_Street;
			parameters[10].Value = model.s_City;
			parameters[11].Value = model.s_State;
			parameters[12].Value = model.n_Country;
			parameters[13].Value = model.s_ZipCode;
			parameters[14].Value = model.n_InvoiceTemplate;
			parameters[15].Value = model.n_BillCurrency;
			parameters[16].Value = model.n_Rate;
			parameters[17].Value = model.n_ExchangeCurrency;
			parameters[18].Value = model.s_FilePath;
			parameters[19].Value = model.dt_CreateDate;
			parameters[20].Value = model.dt_EditDate;
			parameters[21].Value = model.s_IsAnnBill;
			parameters[22].Value = model.s_BillType;
			parameters[23].Value = model.s_ShowZero;
			parameters[24].Value = model.n_FeeSum;
			parameters[25].Value = model.s_Creator;
			parameters[26].Value = model.s_Editor;
			parameters[27].Value = model.n_ModuleCheckStatusID;
			parameters[28].Value = model.n_LatestCheckInfoID;
			parameters[29].Value = model.n_AuthorID;
			parameters[30].Value = model.n_CurCheckerID;
			parameters[31].Value = model.n_MainCaseID;
			parameters[32].Value = model.n_RemindCount;
			parameters[33].Value = model.dt_RecentRemindDate;
			parameters[34].Value = model.s_CaseSerial;
			parameters[35].Value = model.s_AppNo;
			parameters[36].Value = model.s_InvoiceNum;
			parameters[37].Value = model.s_Language;
			parameters[38].Value = model.n_OFeeSum;
			parameters[39].Value = model.n_AFeeSum;
			parameters[40].Value = model.n_TFeeSum;
			parameters[41].Value = model.dt_BillDate;
			parameters[42].Value = model.s_ClientSerial;
			parameters[43].Value = model.s_Applicants;
			parameters[44].Value = model.n_Rate2;
			parameters[45].Value = model.n_FeeSum2;
			parameters[46].Value = model.n_BillCurrency2;
			parameters[47].Value = model.n_PayerID;
			parameters[48].Value = model.s_PayerType;
			parameters[49].Value = model.s_Notes;
			parameters[50].Value = model.dt_SendOutDate;
			parameters[51].Value = model.n_PreferentialCombineID;
			parameters[52].Value = model.s_Email;
			parameters[53].Value = model.s_CheckStatus;
			parameters[54].Value = model.n_Checker;
			parameters[55].Value = model.dt_CheckDate;
			parameters[56].Value = model.s_Flag;

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
		public bool Update(IPSP.Model.T_Bill model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Bill set ");
			strSql.Append("s_BillNum=@s_BillNum,");
			strSql.Append("n_FlowNum=@n_FlowNum,");
			strSql.Append("s_Status=@s_Status,");
			strSql.Append("dt_ShldPayDate=@dt_ShldPayDate,");
			strSql.Append("dt_ConfirmDate=@dt_ConfirmDate,");
			strSql.Append("s_Reason=@s_Reason,");
			strSql.Append("s_BillTo=@s_BillTo,");
			strSql.Append("s_BillToName=@s_BillToName,");
			strSql.Append("s_Street=@s_Street,");
			strSql.Append("s_City=@s_City,");
			strSql.Append("s_State=@s_State,");
			strSql.Append("n_Country=@n_Country,");
			strSql.Append("s_ZipCode=@s_ZipCode,");
			strSql.Append("n_InvoiceTemplate=@n_InvoiceTemplate,");
			strSql.Append("n_BillCurrency=@n_BillCurrency,");
			strSql.Append("n_Rate=@n_Rate,");
			strSql.Append("n_ExchangeCurrency=@n_ExchangeCurrency,");
			strSql.Append("s_FilePath=@s_FilePath,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_IsAnnBill=@s_IsAnnBill,");
			strSql.Append("s_BillType=@s_BillType,");
			strSql.Append("s_ShowZero=@s_ShowZero,");
			strSql.Append("n_FeeSum=@n_FeeSum,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("n_ModuleCheckStatusID=@n_ModuleCheckStatusID,");
			strSql.Append("n_LatestCheckInfoID=@n_LatestCheckInfoID,");
			strSql.Append("n_AuthorID=@n_AuthorID,");
			strSql.Append("n_CurCheckerID=@n_CurCheckerID,");
			strSql.Append("n_MainCaseID=@n_MainCaseID,");
			strSql.Append("n_RemindCount=@n_RemindCount,");
			strSql.Append("dt_RecentRemindDate=@dt_RecentRemindDate,");
			strSql.Append("s_CaseSerial=@s_CaseSerial,");
			strSql.Append("s_AppNo=@s_AppNo,");
			strSql.Append("s_InvoiceNum=@s_InvoiceNum,");
			strSql.Append("s_Language=@s_Language,");
			strSql.Append("n_OFeeSum=@n_OFeeSum,");
			strSql.Append("n_AFeeSum=@n_AFeeSum,");
			strSql.Append("n_TFeeSum=@n_TFeeSum,");
			strSql.Append("dt_BillDate=@dt_BillDate,");
			strSql.Append("s_ClientSerial=@s_ClientSerial,");
			strSql.Append("s_Applicants=@s_Applicants,");
			strSql.Append("n_Rate2=@n_Rate2,");
			strSql.Append("n_FeeSum2=@n_FeeSum2,");
			strSql.Append("n_BillCurrency2=@n_BillCurrency2,");
			strSql.Append("n_PayerID=@n_PayerID,");
			strSql.Append("s_PayerType=@s_PayerType,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("dt_SendOutDate=@dt_SendOutDate,");
			strSql.Append("n_PreferentialCombineID=@n_PreferentialCombineID,");
			strSql.Append("s_Email=@s_Email,");
			strSql.Append("s_CheckStatus=@s_CheckStatus,");
			strSql.Append("n_Checker=@n_Checker,");
			strSql.Append("dt_CheckDate=@dt_CheckDate,");
			strSql.Append("s_Flag=@s_Flag");
			strSql.Append(" where n_BillID=@n_BillID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_BillNum", SqlDbType.NVarChar,50),
					new SqlParameter("@n_FlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_ShldPayDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ConfirmDate", SqlDbType.DateTime),
					new SqlParameter("@s_Reason", SqlDbType.NVarChar,800),
					new SqlParameter("@s_BillTo", SqlDbType.NVarChar,300),
					new SqlParameter("@s_BillToName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Street", SqlDbType.NVarChar,300),
					new SqlParameter("@s_City", SqlDbType.NVarChar,100),
					new SqlParameter("@s_State", SqlDbType.NVarChar,100),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@n_InvoiceTemplate", SqlDbType.Int,4),
					new SqlParameter("@n_BillCurrency", SqlDbType.Int,4),
					new SqlParameter("@n_Rate", SqlDbType.Decimal,9),
					new SqlParameter("@n_ExchangeCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IsAnnBill", SqlDbType.NVarChar,1),
					new SqlParameter("@s_BillType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ShowZero", SqlDbType.NVarChar,50),
					new SqlParameter("@n_FeeSum", SqlDbType.Decimal,9),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ModuleCheckStatusID", SqlDbType.Int,4),
					new SqlParameter("@n_LatestCheckInfoID", SqlDbType.Int,4),
					new SqlParameter("@n_AuthorID", SqlDbType.Int,4),
					new SqlParameter("@n_CurCheckerID", SqlDbType.Int,4),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@n_RemindCount", SqlDbType.Int,4),
					new SqlParameter("@dt_RecentRemindDate", SqlDbType.DateTime),
					new SqlParameter("@s_CaseSerial", SqlDbType.NVarChar,500),
					new SqlParameter("@s_AppNo", SqlDbType.NVarChar,500),
					new SqlParameter("@s_InvoiceNum", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Language", SqlDbType.NVarChar,2),
					new SqlParameter("@n_OFeeSum", SqlDbType.Decimal,9),
					new SqlParameter("@n_AFeeSum", SqlDbType.Decimal,9),
					new SqlParameter("@n_TFeeSum", SqlDbType.Decimal,9),
					new SqlParameter("@dt_BillDate", SqlDbType.DateTime),
					new SqlParameter("@s_ClientSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Applicants", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_Rate2", SqlDbType.Decimal,9),
					new SqlParameter("@n_FeeSum2", SqlDbType.Decimal,9),
					new SqlParameter("@n_BillCurrency2", SqlDbType.Int,4),
					new SqlParameter("@n_PayerID", SqlDbType.Int,4),
					new SqlParameter("@s_PayerType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_SendOutDate", SqlDbType.DateTime),
					new SqlParameter("@n_PreferentialCombineID", SqlDbType.Int,4),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@dt_CheckDate", SqlDbType.DateTime),
					new SqlParameter("@s_Flag", SqlDbType.NVarChar,1),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_BillNum;
			parameters[1].Value = model.n_FlowNum;
			parameters[2].Value = model.s_Status;
			parameters[3].Value = model.dt_ShldPayDate;
			parameters[4].Value = model.dt_ConfirmDate;
			parameters[5].Value = model.s_Reason;
			parameters[6].Value = model.s_BillTo;
			parameters[7].Value = model.s_BillToName;
			parameters[8].Value = model.s_Street;
			parameters[9].Value = model.s_City;
			parameters[10].Value = model.s_State;
			parameters[11].Value = model.n_Country;
			parameters[12].Value = model.s_ZipCode;
			parameters[13].Value = model.n_InvoiceTemplate;
			parameters[14].Value = model.n_BillCurrency;
			parameters[15].Value = model.n_Rate;
			parameters[16].Value = model.n_ExchangeCurrency;
			parameters[17].Value = model.s_FilePath;
			parameters[18].Value = model.dt_CreateDate;
			parameters[19].Value = model.dt_EditDate;
			parameters[20].Value = model.s_IsAnnBill;
			parameters[21].Value = model.s_BillType;
			parameters[22].Value = model.s_ShowZero;
			parameters[23].Value = model.n_FeeSum;
			parameters[24].Value = model.s_Creator;
			parameters[25].Value = model.s_Editor;
			parameters[26].Value = model.n_ModuleCheckStatusID;
			parameters[27].Value = model.n_LatestCheckInfoID;
			parameters[28].Value = model.n_AuthorID;
			parameters[29].Value = model.n_CurCheckerID;
			parameters[30].Value = model.n_MainCaseID;
			parameters[31].Value = model.n_RemindCount;
			parameters[32].Value = model.dt_RecentRemindDate;
			parameters[33].Value = model.s_CaseSerial;
			parameters[34].Value = model.s_AppNo;
			parameters[35].Value = model.s_InvoiceNum;
			parameters[36].Value = model.s_Language;
			parameters[37].Value = model.n_OFeeSum;
			parameters[38].Value = model.n_AFeeSum;
			parameters[39].Value = model.n_TFeeSum;
			parameters[40].Value = model.dt_BillDate;
			parameters[41].Value = model.s_ClientSerial;
			parameters[42].Value = model.s_Applicants;
			parameters[43].Value = model.n_Rate2;
			parameters[44].Value = model.n_FeeSum2;
			parameters[45].Value = model.n_BillCurrency2;
			parameters[46].Value = model.n_PayerID;
			parameters[47].Value = model.s_PayerType;
			parameters[48].Value = model.s_Notes;
			parameters[49].Value = model.dt_SendOutDate;
			parameters[50].Value = model.n_PreferentialCombineID;
			parameters[51].Value = model.s_Email;
			parameters[52].Value = model.s_CheckStatus;
			parameters[53].Value = model.n_Checker;
			parameters[54].Value = model.dt_CheckDate;
			parameters[55].Value = model.s_Flag;
			parameters[56].Value = model.n_BillID;
			parameters[57].Value = model.n_ClientID;

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
		public bool Delete(int n_BillID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Bill ");
			strSql.Append(" where n_BillID=@n_BillID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_BillID;

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
		public bool Delete(int n_ClientID,int n_BillID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Bill ");
			strSql.Append(" where n_ClientID=@n_ClientID and n_BillID=@n_BillID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = n_BillID;

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
		public bool DeleteList(string n_BillIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Bill ");
			strSql.Append(" where n_BillID in ("+n_BillIDlist + ")  ");
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
		public IPSP.Model.T_Bill GetModel(int n_BillID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_BillID,s_BillNum,n_FlowNum,s_Status,dt_ShldPayDate,dt_ConfirmDate,n_ClientID,s_Reason,s_BillTo,s_BillToName,s_Street,s_City,s_State,n_Country,s_ZipCode,n_InvoiceTemplate,n_BillCurrency,n_Rate,n_ExchangeCurrency,s_FilePath,dt_CreateDate,dt_EditDate,s_IsAnnBill,s_BillType,s_ShowZero,n_FeeSum,s_Creator,s_Editor,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,n_MainCaseID,n_RemindCount,dt_RecentRemindDate,s_CaseSerial,s_AppNo,s_InvoiceNum,s_Language,n_OFeeSum,n_AFeeSum,n_TFeeSum,dt_BillDate,s_ClientSerial,s_Applicants,n_Rate2,n_FeeSum2,n_BillCurrency2,n_PayerID,s_PayerType,s_Notes,dt_SendOutDate,n_PreferentialCombineID,s_Email,s_CheckStatus,n_Checker,dt_CheckDate,s_Flag from T_Bill ");
			strSql.Append(" where n_BillID=@n_BillID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_BillID;

			IPSP.Model.T_Bill model=new IPSP.Model.T_Bill();
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
		public IPSP.Model.T_Bill DataRowToModel(DataRow row)
		{
			IPSP.Model.T_Bill model=new IPSP.Model.T_Bill();
			if (row != null)
			{
				if(row["n_BillID"]!=null && row["n_BillID"].ToString()!="")
				{
					model.n_BillID=int.Parse(row["n_BillID"].ToString());
				}
				if(row["s_BillNum"]!=null)
				{
					model.s_BillNum=row["s_BillNum"].ToString();
				}
				if(row["n_FlowNum"]!=null && row["n_FlowNum"].ToString()!="")
				{
					model.n_FlowNum=int.Parse(row["n_FlowNum"].ToString());
				}
				if(row["s_Status"]!=null)
				{
					model.s_Status=row["s_Status"].ToString();
				}
				if(row["dt_ShldPayDate"]!=null && row["dt_ShldPayDate"].ToString()!="")
				{
					model.dt_ShldPayDate=DateTime.Parse(row["dt_ShldPayDate"].ToString());
				}
				if(row["dt_ConfirmDate"]!=null && row["dt_ConfirmDate"].ToString()!="")
				{
					model.dt_ConfirmDate=DateTime.Parse(row["dt_ConfirmDate"].ToString());
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["s_Reason"]!=null)
				{
					model.s_Reason=row["s_Reason"].ToString();
				}
				if(row["s_BillTo"]!=null)
				{
					model.s_BillTo=row["s_BillTo"].ToString();
				}
				if(row["s_BillToName"]!=null)
				{
					model.s_BillToName=row["s_BillToName"].ToString();
				}
				if(row["s_Street"]!=null)
				{
					model.s_Street=row["s_Street"].ToString();
				}
				if(row["s_City"]!=null)
				{
					model.s_City=row["s_City"].ToString();
				}
				if(row["s_State"]!=null)
				{
					model.s_State=row["s_State"].ToString();
				}
				if(row["n_Country"]!=null && row["n_Country"].ToString()!="")
				{
					model.n_Country=int.Parse(row["n_Country"].ToString());
				}
				if(row["s_ZipCode"]!=null)
				{
					model.s_ZipCode=row["s_ZipCode"].ToString();
				}
				if(row["n_InvoiceTemplate"]!=null && row["n_InvoiceTemplate"].ToString()!="")
				{
					model.n_InvoiceTemplate=int.Parse(row["n_InvoiceTemplate"].ToString());
				}
				if(row["n_BillCurrency"]!=null && row["n_BillCurrency"].ToString()!="")
				{
					model.n_BillCurrency=int.Parse(row["n_BillCurrency"].ToString());
				}
				if(row["n_Rate"]!=null && row["n_Rate"].ToString()!="")
				{
					model.n_Rate=decimal.Parse(row["n_Rate"].ToString());
				}
				if(row["n_ExchangeCurrency"]!=null && row["n_ExchangeCurrency"].ToString()!="")
				{
					model.n_ExchangeCurrency=int.Parse(row["n_ExchangeCurrency"].ToString());
				}
				if(row["s_FilePath"]!=null)
				{
					model.s_FilePath=row["s_FilePath"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_IsAnnBill"]!=null)
				{
					model.s_IsAnnBill=row["s_IsAnnBill"].ToString();
				}
				if(row["s_BillType"]!=null)
				{
					model.s_BillType=row["s_BillType"].ToString();
				}
				if(row["s_ShowZero"]!=null)
				{
					model.s_ShowZero=row["s_ShowZero"].ToString();
				}
				if(row["n_FeeSum"]!=null && row["n_FeeSum"].ToString()!="")
				{
					model.n_FeeSum=decimal.Parse(row["n_FeeSum"].ToString());
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["n_ModuleCheckStatusID"]!=null && row["n_ModuleCheckStatusID"].ToString()!="")
				{
					model.n_ModuleCheckStatusID=int.Parse(row["n_ModuleCheckStatusID"].ToString());
				}
				if(row["n_LatestCheckInfoID"]!=null && row["n_LatestCheckInfoID"].ToString()!="")
				{
					model.n_LatestCheckInfoID=int.Parse(row["n_LatestCheckInfoID"].ToString());
				}
				if(row["n_AuthorID"]!=null && row["n_AuthorID"].ToString()!="")
				{
					model.n_AuthorID=int.Parse(row["n_AuthorID"].ToString());
				}
				if(row["n_CurCheckerID"]!=null && row["n_CurCheckerID"].ToString()!="")
				{
					model.n_CurCheckerID=int.Parse(row["n_CurCheckerID"].ToString());
				}
				if(row["n_MainCaseID"]!=null && row["n_MainCaseID"].ToString()!="")
				{
					model.n_MainCaseID=int.Parse(row["n_MainCaseID"].ToString());
				}
				if(row["n_RemindCount"]!=null && row["n_RemindCount"].ToString()!="")
				{
					model.n_RemindCount=int.Parse(row["n_RemindCount"].ToString());
				}
				if(row["dt_RecentRemindDate"]!=null && row["dt_RecentRemindDate"].ToString()!="")
				{
					model.dt_RecentRemindDate=DateTime.Parse(row["dt_RecentRemindDate"].ToString());
				}
				if(row["s_CaseSerial"]!=null)
				{
					model.s_CaseSerial=row["s_CaseSerial"].ToString();
				}
				if(row["s_AppNo"]!=null)
				{
					model.s_AppNo=row["s_AppNo"].ToString();
				}
				if(row["s_InvoiceNum"]!=null)
				{
					model.s_InvoiceNum=row["s_InvoiceNum"].ToString();
				}
				if(row["s_Language"]!=null)
				{
					model.s_Language=row["s_Language"].ToString();
				}
				if(row["n_OFeeSum"]!=null && row["n_OFeeSum"].ToString()!="")
				{
					model.n_OFeeSum=decimal.Parse(row["n_OFeeSum"].ToString());
				}
				if(row["n_AFeeSum"]!=null && row["n_AFeeSum"].ToString()!="")
				{
					model.n_AFeeSum=decimal.Parse(row["n_AFeeSum"].ToString());
				}
				if(row["n_TFeeSum"]!=null && row["n_TFeeSum"].ToString()!="")
				{
					model.n_TFeeSum=decimal.Parse(row["n_TFeeSum"].ToString());
				}
				if(row["dt_BillDate"]!=null && row["dt_BillDate"].ToString()!="")
				{
					model.dt_BillDate=DateTime.Parse(row["dt_BillDate"].ToString());
				}
				if(row["s_ClientSerial"]!=null)
				{
					model.s_ClientSerial=row["s_ClientSerial"].ToString();
				}
				if(row["s_Applicants"]!=null)
				{
					model.s_Applicants=row["s_Applicants"].ToString();
				}
				if(row["n_Rate2"]!=null && row["n_Rate2"].ToString()!="")
				{
					model.n_Rate2=decimal.Parse(row["n_Rate2"].ToString());
				}
				if(row["n_FeeSum2"]!=null && row["n_FeeSum2"].ToString()!="")
				{
					model.n_FeeSum2=decimal.Parse(row["n_FeeSum2"].ToString());
				}
				if(row["n_BillCurrency2"]!=null && row["n_BillCurrency2"].ToString()!="")
				{
					model.n_BillCurrency2=int.Parse(row["n_BillCurrency2"].ToString());
				}
				if(row["n_PayerID"]!=null && row["n_PayerID"].ToString()!="")
				{
					model.n_PayerID=int.Parse(row["n_PayerID"].ToString());
				}
				if(row["s_PayerType"]!=null)
				{
					model.s_PayerType=row["s_PayerType"].ToString();
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["dt_SendOutDate"]!=null && row["dt_SendOutDate"].ToString()!="")
				{
					model.dt_SendOutDate=DateTime.Parse(row["dt_SendOutDate"].ToString());
				}
				if(row["n_PreferentialCombineID"]!=null && row["n_PreferentialCombineID"].ToString()!="")
				{
					model.n_PreferentialCombineID=int.Parse(row["n_PreferentialCombineID"].ToString());
				}
				if(row["s_Email"]!=null)
				{
					model.s_Email=row["s_Email"].ToString();
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
				if(row["s_Flag"]!=null)
				{
					model.s_Flag=row["s_Flag"].ToString();
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
			strSql.Append("select n_BillID,s_BillNum,n_FlowNum,s_Status,dt_ShldPayDate,dt_ConfirmDate,n_ClientID,s_Reason,s_BillTo,s_BillToName,s_Street,s_City,s_State,n_Country,s_ZipCode,n_InvoiceTemplate,n_BillCurrency,n_Rate,n_ExchangeCurrency,s_FilePath,dt_CreateDate,dt_EditDate,s_IsAnnBill,s_BillType,s_ShowZero,n_FeeSum,s_Creator,s_Editor,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,n_MainCaseID,n_RemindCount,dt_RecentRemindDate,s_CaseSerial,s_AppNo,s_InvoiceNum,s_Language,n_OFeeSum,n_AFeeSum,n_TFeeSum,dt_BillDate,s_ClientSerial,s_Applicants,n_Rate2,n_FeeSum2,n_BillCurrency2,n_PayerID,s_PayerType,s_Notes,dt_SendOutDate,n_PreferentialCombineID,s_Email,s_CheckStatus,n_Checker,dt_CheckDate,s_Flag ");
			strSql.Append(" FROM T_Bill ");
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
			strSql.Append(" n_BillID,s_BillNum,n_FlowNum,s_Status,dt_ShldPayDate,dt_ConfirmDate,n_ClientID,s_Reason,s_BillTo,s_BillToName,s_Street,s_City,s_State,n_Country,s_ZipCode,n_InvoiceTemplate,n_BillCurrency,n_Rate,n_ExchangeCurrency,s_FilePath,dt_CreateDate,dt_EditDate,s_IsAnnBill,s_BillType,s_ShowZero,n_FeeSum,s_Creator,s_Editor,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,n_MainCaseID,n_RemindCount,dt_RecentRemindDate,s_CaseSerial,s_AppNo,s_InvoiceNum,s_Language,n_OFeeSum,n_AFeeSum,n_TFeeSum,dt_BillDate,s_ClientSerial,s_Applicants,n_Rate2,n_FeeSum2,n_BillCurrency2,n_PayerID,s_PayerType,s_Notes,dt_SendOutDate,n_PreferentialCombineID,s_Email,s_CheckStatus,n_Checker,dt_CheckDate,s_Flag ");
			strSql.Append(" FROM T_Bill ");
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
			strSql.Append("select count(1) FROM T_Bill ");
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
				strSql.Append("order by T.n_BillID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Bill T ");
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
			parameters[0].Value = "T_Bill";
			parameters[1].Value = "n_BillID";
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

