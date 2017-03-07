/**  版本信息模板在安装目录下，可自行修改。
* TCode_Fee.cs
*
* 功 能： N/A
* 类 名： TCode_Fee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:23   N/A    初版
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
	/// 数据访问类:TCode_Fee
	/// </summary>
	public partial class TCode_Fee
	{
		public TCode_Fee()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TCode_Fee"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_Fee");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_Fee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_Fee(");
			strSql.Append("s_IPType,s_TApplyType,s_RegCountry,s_Business,s_PTCType,n_ProcessID,s_Name,s_OtherName,s_OfficialName,n_OfficialFee,n_OfficialCurrency,s_AFeeDisc,s_OFeeDisc,s_UnitPrice,s_Unit,n_ExceedUnit,n_ExceedUnitFee,s_Notes,dt_CreateDate,dt_EditDate,s_IsSystem,s_CodeCameFileID,s_AutoFeeType,s_TimeType,n_Month,n_Day,s_AutoFee,s_DayAndMonthSequence,s_AutoPayDate,s_IsForElectricOnline,s_OfficalFlag,s_FeeRegion,s_IsForPayableBill,s_FeeType,n_EveryUnitCount,s_TranslationFee,s_SysFlowDirection)");
			strSql.Append(" values (");
			strSql.Append("@s_IPType,@s_TApplyType,@s_RegCountry,@s_Business,@s_PTCType,@n_ProcessID,@s_Name,@s_OtherName,@s_OfficialName,@n_OfficialFee,@n_OfficialCurrency,@s_AFeeDisc,@s_OFeeDisc,@s_UnitPrice,@s_Unit,@n_ExceedUnit,@n_ExceedUnitFee,@s_Notes,@dt_CreateDate,@dt_EditDate,@s_IsSystem,@s_CodeCameFileID,@s_AutoFeeType,@s_TimeType,@n_Month,@n_Day,@s_AutoFee,@s_DayAndMonthSequence,@s_AutoPayDate,@s_IsForElectricOnline,@s_OfficalFlag,@s_FeeRegion,@s_IsForPayableBill,@s_FeeType,@n_EveryUnitCount,@s_TranslationFee,@s_SysFlowDirection)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TApplyType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RegCountry", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_Business", SqlDbType.NVarChar,500),
					new SqlParameter("@s_PTCType", SqlDbType.NVarChar,500),
					new SqlParameter("@n_ProcessID", SqlDbType.Int,4),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,500),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_OfficialName", SqlDbType.NVarChar,500),
					new SqlParameter("@n_OfficialFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_OfficialCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_AFeeDisc", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OFeeDisc", SqlDbType.NVarChar,1),
					new SqlParameter("@s_UnitPrice", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ExceedUnit", SqlDbType.Decimal,9),
					new SqlParameter("@n_ExceedUnitFee", SqlDbType.Decimal,9),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IsSystem", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CodeCameFileID", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AutoFeeType", SqlDbType.NVarChar,200),
					new SqlParameter("@s_TimeType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Month", SqlDbType.Int,4),
					new SqlParameter("@n_Day", SqlDbType.Int,4),
					new SqlParameter("@s_AutoFee", SqlDbType.NVarChar,1),
					new SqlParameter("@s_DayAndMonthSequence", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AutoPayDate", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsForElectricOnline", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OfficalFlag", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FeeRegion", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsForPayableBill", SqlDbType.NVarChar,1),
					new SqlParameter("@s_FeeType", SqlDbType.NVarChar,100),
					new SqlParameter("@n_EveryUnitCount", SqlDbType.Money,8),
					new SqlParameter("@s_TranslationFee", SqlDbType.NVarChar,1),
					new SqlParameter("@s_SysFlowDirection", SqlDbType.NVarChar,300)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_TApplyType;
			parameters[2].Value = model.s_RegCountry;
			parameters[3].Value = model.s_Business;
			parameters[4].Value = model.s_PTCType;
			parameters[5].Value = model.n_ProcessID;
			parameters[6].Value = model.s_Name;
			parameters[7].Value = model.s_OtherName;
			parameters[8].Value = model.s_OfficialName;
			parameters[9].Value = model.n_OfficialFee;
			parameters[10].Value = model.n_OfficialCurrency;
			parameters[11].Value = model.s_AFeeDisc;
			parameters[12].Value = model.s_OFeeDisc;
			parameters[13].Value = model.s_UnitPrice;
			parameters[14].Value = model.s_Unit;
			parameters[15].Value = model.n_ExceedUnit;
			parameters[16].Value = model.n_ExceedUnitFee;
			parameters[17].Value = model.s_Notes;
			parameters[18].Value = model.dt_CreateDate;
			parameters[19].Value = model.dt_EditDate;
			parameters[20].Value = model.s_IsSystem;
			parameters[21].Value = model.s_CodeCameFileID;
			parameters[22].Value = model.s_AutoFeeType;
			parameters[23].Value = model.s_TimeType;
			parameters[24].Value = model.n_Month;
			parameters[25].Value = model.n_Day;
			parameters[26].Value = model.s_AutoFee;
			parameters[27].Value = model.s_DayAndMonthSequence;
			parameters[28].Value = model.s_AutoPayDate;
			parameters[29].Value = model.s_IsForElectricOnline;
			parameters[30].Value = model.s_OfficalFlag;
			parameters[31].Value = model.s_FeeRegion;
			parameters[32].Value = model.s_IsForPayableBill;
			parameters[33].Value = model.s_FeeType;
			parameters[34].Value = model.n_EveryUnitCount;
			parameters[35].Value = model.s_TranslationFee;
			parameters[36].Value = model.s_SysFlowDirection;

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
		public bool Update(IPSP.Model.TCode_Fee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_Fee set ");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_TApplyType=@s_TApplyType,");
			strSql.Append("s_RegCountry=@s_RegCountry,");
			strSql.Append("s_Business=@s_Business,");
			strSql.Append("s_PTCType=@s_PTCType,");
			strSql.Append("n_ProcessID=@n_ProcessID,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("s_OfficialName=@s_OfficialName,");
			strSql.Append("n_OfficialFee=@n_OfficialFee,");
			strSql.Append("n_OfficialCurrency=@n_OfficialCurrency,");
			strSql.Append("s_AFeeDisc=@s_AFeeDisc,");
			strSql.Append("s_OFeeDisc=@s_OFeeDisc,");
			strSql.Append("s_UnitPrice=@s_UnitPrice,");
			strSql.Append("s_Unit=@s_Unit,");
			strSql.Append("n_ExceedUnit=@n_ExceedUnit,");
			strSql.Append("n_ExceedUnitFee=@n_ExceedUnitFee,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_IsSystem=@s_IsSystem,");
			strSql.Append("s_CodeCameFileID=@s_CodeCameFileID,");
			strSql.Append("s_AutoFeeType=@s_AutoFeeType,");
			strSql.Append("s_TimeType=@s_TimeType,");
			strSql.Append("n_Month=@n_Month,");
			strSql.Append("n_Day=@n_Day,");
			strSql.Append("s_AutoFee=@s_AutoFee,");
			strSql.Append("s_DayAndMonthSequence=@s_DayAndMonthSequence,");
			strSql.Append("s_AutoPayDate=@s_AutoPayDate,");
			strSql.Append("s_IsForElectricOnline=@s_IsForElectricOnline,");
			strSql.Append("s_OfficalFlag=@s_OfficalFlag,");
			strSql.Append("s_FeeRegion=@s_FeeRegion,");
			strSql.Append("s_IsForPayableBill=@s_IsForPayableBill,");
			strSql.Append("s_FeeType=@s_FeeType,");
			strSql.Append("n_EveryUnitCount=@n_EveryUnitCount,");
			strSql.Append("s_TranslationFee=@s_TranslationFee,");
			strSql.Append("s_SysFlowDirection=@s_SysFlowDirection");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TApplyType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RegCountry", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_Business", SqlDbType.NVarChar,500),
					new SqlParameter("@s_PTCType", SqlDbType.NVarChar,500),
					new SqlParameter("@n_ProcessID", SqlDbType.Int,4),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,500),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_OfficialName", SqlDbType.NVarChar,500),
					new SqlParameter("@n_OfficialFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_OfficialCurrency", SqlDbType.Int,4),
					new SqlParameter("@s_AFeeDisc", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OFeeDisc", SqlDbType.NVarChar,1),
					new SqlParameter("@s_UnitPrice", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ExceedUnit", SqlDbType.Decimal,9),
					new SqlParameter("@n_ExceedUnitFee", SqlDbType.Decimal,9),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IsSystem", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CodeCameFileID", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AutoFeeType", SqlDbType.NVarChar,200),
					new SqlParameter("@s_TimeType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Month", SqlDbType.Int,4),
					new SqlParameter("@n_Day", SqlDbType.Int,4),
					new SqlParameter("@s_AutoFee", SqlDbType.NVarChar,1),
					new SqlParameter("@s_DayAndMonthSequence", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AutoPayDate", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsForElectricOnline", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OfficalFlag", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FeeRegion", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsForPayableBill", SqlDbType.NVarChar,1),
					new SqlParameter("@s_FeeType", SqlDbType.NVarChar,100),
					new SqlParameter("@n_EveryUnitCount", SqlDbType.Money,8),
					new SqlParameter("@s_TranslationFee", SqlDbType.NVarChar,1),
					new SqlParameter("@s_SysFlowDirection", SqlDbType.NVarChar,300),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_TApplyType;
			parameters[2].Value = model.s_RegCountry;
			parameters[3].Value = model.s_Business;
			parameters[4].Value = model.s_PTCType;
			parameters[5].Value = model.n_ProcessID;
			parameters[6].Value = model.s_Name;
			parameters[7].Value = model.s_OtherName;
			parameters[8].Value = model.s_OfficialName;
			parameters[9].Value = model.n_OfficialFee;
			parameters[10].Value = model.n_OfficialCurrency;
			parameters[11].Value = model.s_AFeeDisc;
			parameters[12].Value = model.s_OFeeDisc;
			parameters[13].Value = model.s_UnitPrice;
			parameters[14].Value = model.s_Unit;
			parameters[15].Value = model.n_ExceedUnit;
			parameters[16].Value = model.n_ExceedUnitFee;
			parameters[17].Value = model.s_Notes;
			parameters[18].Value = model.dt_CreateDate;
			parameters[19].Value = model.dt_EditDate;
			parameters[20].Value = model.s_IsSystem;
			parameters[21].Value = model.s_CodeCameFileID;
			parameters[22].Value = model.s_AutoFeeType;
			parameters[23].Value = model.s_TimeType;
			parameters[24].Value = model.n_Month;
			parameters[25].Value = model.n_Day;
			parameters[26].Value = model.s_AutoFee;
			parameters[27].Value = model.s_DayAndMonthSequence;
			parameters[28].Value = model.s_AutoPayDate;
			parameters[29].Value = model.s_IsForElectricOnline;
			parameters[30].Value = model.s_OfficalFlag;
			parameters[31].Value = model.s_FeeRegion;
			parameters[32].Value = model.s_IsForPayableBill;
			parameters[33].Value = model.s_FeeType;
			parameters[34].Value = model.n_EveryUnitCount;
			parameters[35].Value = model.s_TranslationFee;
			parameters[36].Value = model.s_SysFlowDirection;
			parameters[37].Value = model.n_ID;

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
			strSql.Append("delete from TCode_Fee ");
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string n_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_Fee ");
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
		public IPSP.Model.TCode_Fee GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_IPType,s_TApplyType,s_RegCountry,s_Business,s_PTCType,n_ProcessID,s_Name,s_OtherName,s_OfficialName,n_OfficialFee,n_OfficialCurrency,s_AFeeDisc,s_OFeeDisc,s_UnitPrice,s_Unit,n_ExceedUnit,n_ExceedUnitFee,s_Notes,dt_CreateDate,dt_EditDate,s_IsSystem,s_CodeCameFileID,s_AutoFeeType,s_TimeType,n_Month,n_Day,s_AutoFee,s_DayAndMonthSequence,s_AutoPayDate,s_IsForElectricOnline,s_OfficalFlag,s_FeeRegion,s_IsForPayableBill,s_FeeType,n_EveryUnitCount,s_TranslationFee,s_SysFlowDirection from TCode_Fee ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_Fee model=new IPSP.Model.TCode_Fee();
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
		public IPSP.Model.TCode_Fee DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_Fee model=new IPSP.Model.TCode_Fee();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["s_TApplyType"]!=null)
				{
					model.s_TApplyType=row["s_TApplyType"].ToString();
				}
				if(row["s_RegCountry"]!=null)
				{
					model.s_RegCountry=row["s_RegCountry"].ToString();
				}
				if(row["s_Business"]!=null)
				{
					model.s_Business=row["s_Business"].ToString();
				}
				if(row["s_PTCType"]!=null)
				{
					model.s_PTCType=row["s_PTCType"].ToString();
				}
				if(row["n_ProcessID"]!=null && row["n_ProcessID"].ToString()!="")
				{
					model.n_ProcessID=int.Parse(row["n_ProcessID"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_OtherName"]!=null)
				{
					model.s_OtherName=row["s_OtherName"].ToString();
				}
				if(row["s_OfficialName"]!=null)
				{
					model.s_OfficialName=row["s_OfficialName"].ToString();
				}
				if(row["n_OfficialFee"]!=null && row["n_OfficialFee"].ToString()!="")
				{
					model.n_OfficialFee=decimal.Parse(row["n_OfficialFee"].ToString());
				}
				if(row["n_OfficialCurrency"]!=null && row["n_OfficialCurrency"].ToString()!="")
				{
					model.n_OfficialCurrency=int.Parse(row["n_OfficialCurrency"].ToString());
				}
				if(row["s_AFeeDisc"]!=null)
				{
					model.s_AFeeDisc=row["s_AFeeDisc"].ToString();
				}
				if(row["s_OFeeDisc"]!=null)
				{
					model.s_OFeeDisc=row["s_OFeeDisc"].ToString();
				}
				if(row["s_UnitPrice"]!=null)
				{
					model.s_UnitPrice=row["s_UnitPrice"].ToString();
				}
				if(row["s_Unit"]!=null)
				{
					model.s_Unit=row["s_Unit"].ToString();
				}
				if(row["n_ExceedUnit"]!=null && row["n_ExceedUnit"].ToString()!="")
				{
					model.n_ExceedUnit=decimal.Parse(row["n_ExceedUnit"].ToString());
				}
				if(row["n_ExceedUnitFee"]!=null && row["n_ExceedUnitFee"].ToString()!="")
				{
					model.n_ExceedUnitFee=decimal.Parse(row["n_ExceedUnitFee"].ToString());
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_IsSystem"]!=null)
				{
					model.s_IsSystem=row["s_IsSystem"].ToString();
				}
				if(row["s_CodeCameFileID"]!=null)
				{
					model.s_CodeCameFileID=row["s_CodeCameFileID"].ToString();
				}
				if(row["s_AutoFeeType"]!=null)
				{
					model.s_AutoFeeType=row["s_AutoFeeType"].ToString();
				}
				if(row["s_TimeType"]!=null)
				{
					model.s_TimeType=row["s_TimeType"].ToString();
				}
				if(row["n_Month"]!=null && row["n_Month"].ToString()!="")
				{
					model.n_Month=int.Parse(row["n_Month"].ToString());
				}
				if(row["n_Day"]!=null && row["n_Day"].ToString()!="")
				{
					model.n_Day=int.Parse(row["n_Day"].ToString());
				}
				if(row["s_AutoFee"]!=null)
				{
					model.s_AutoFee=row["s_AutoFee"].ToString();
				}
				if(row["s_DayAndMonthSequence"]!=null)
				{
					model.s_DayAndMonthSequence=row["s_DayAndMonthSequence"].ToString();
				}
				if(row["s_AutoPayDate"]!=null)
				{
					model.s_AutoPayDate=row["s_AutoPayDate"].ToString();
				}
				if(row["s_IsForElectricOnline"]!=null)
				{
					model.s_IsForElectricOnline=row["s_IsForElectricOnline"].ToString();
				}
				if(row["s_OfficalFlag"]!=null)
				{
					model.s_OfficalFlag=row["s_OfficalFlag"].ToString();
				}
				if(row["s_FeeRegion"]!=null)
				{
					model.s_FeeRegion=row["s_FeeRegion"].ToString();
				}
				if(row["s_IsForPayableBill"]!=null)
				{
					model.s_IsForPayableBill=row["s_IsForPayableBill"].ToString();
				}
				if(row["s_FeeType"]!=null)
				{
					model.s_FeeType=row["s_FeeType"].ToString();
				}
				if(row["n_EveryUnitCount"]!=null && row["n_EveryUnitCount"].ToString()!="")
				{
					model.n_EveryUnitCount=decimal.Parse(row["n_EveryUnitCount"].ToString());
				}
				if(row["s_TranslationFee"]!=null)
				{
					model.s_TranslationFee=row["s_TranslationFee"].ToString();
				}
				if(row["s_SysFlowDirection"]!=null)
				{
					model.s_SysFlowDirection=row["s_SysFlowDirection"].ToString();
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
			strSql.Append("select n_ID,s_IPType,s_TApplyType,s_RegCountry,s_Business,s_PTCType,n_ProcessID,s_Name,s_OtherName,s_OfficialName,n_OfficialFee,n_OfficialCurrency,s_AFeeDisc,s_OFeeDisc,s_UnitPrice,s_Unit,n_ExceedUnit,n_ExceedUnitFee,s_Notes,dt_CreateDate,dt_EditDate,s_IsSystem,s_CodeCameFileID,s_AutoFeeType,s_TimeType,n_Month,n_Day,s_AutoFee,s_DayAndMonthSequence,s_AutoPayDate,s_IsForElectricOnline,s_OfficalFlag,s_FeeRegion,s_IsForPayableBill,s_FeeType,n_EveryUnitCount,s_TranslationFee,s_SysFlowDirection ");
			strSql.Append(" FROM TCode_Fee ");
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
			strSql.Append(" n_ID,s_IPType,s_TApplyType,s_RegCountry,s_Business,s_PTCType,n_ProcessID,s_Name,s_OtherName,s_OfficialName,n_OfficialFee,n_OfficialCurrency,s_AFeeDisc,s_OFeeDisc,s_UnitPrice,s_Unit,n_ExceedUnit,n_ExceedUnitFee,s_Notes,dt_CreateDate,dt_EditDate,s_IsSystem,s_CodeCameFileID,s_AutoFeeType,s_TimeType,n_Month,n_Day,s_AutoFee,s_DayAndMonthSequence,s_AutoPayDate,s_IsForElectricOnline,s_OfficalFlag,s_FeeRegion,s_IsForPayableBill,s_FeeType,n_EveryUnitCount,s_TranslationFee,s_SysFlowDirection ");
			strSql.Append(" FROM TCode_Fee ");
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
			strSql.Append("select count(1) FROM TCode_Fee ");
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
			strSql.Append(")AS Row, T.*  from TCode_Fee T ");
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
			parameters[0].Value = "TCode_Fee";
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

