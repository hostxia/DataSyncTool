/**  版本信息模板在安装目录下，可自行修改。
* T_AbroadBill.cs
*
* 功 能： N/A
* 类 名： T_AbroadBill
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:28   N/A    初版
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
	/// 数据访问类:T_AbroadBill
	/// </summary>
	public partial class T_AbroadBill
	{
		public T_AbroadBill()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_VendorID", "T_AbroadBill"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_VendorID,int n_PayListID,int n_HedgeID,int n_BillID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_AbroadBill");
			strSql.Append(" where n_VendorID=@n_VendorID and n_PayListID=@n_PayListID and n_HedgeID=@n_HedgeID and n_BillID=@n_BillID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_VendorID", SqlDbType.Int,4),
					new SqlParameter("@n_PayListID", SqlDbType.Int,4),
					new SqlParameter("@n_HedgeID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4)			};
			parameters[0].Value = n_VendorID;
			parameters[1].Value = n_PayListID;
			parameters[2].Value = n_HedgeID;
			parameters[3].Value = n_BillID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_AbroadBill model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_AbroadBill(");
			strSql.Append("n_VendorID,n_PayListID,s_OppID,s_Reason,dt_ShldPayDate,n_CurrencyID,dt_ReceiveBill,s_PayMark,s_Payer,dt_PayDate,n_FeePayed,s_CheckMark,dt_CheckDate,s_Checker,s_Note,s_FilePath,s_Lock,s_Locker,s_Editor,dt_CreateDate,dt_EditDate,n_APaymentID,n_HedgeID,s_Creator,dt_Billing,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,s_CheckStatus,n_Checker,n_PayerID)");
			strSql.Append(" values (");
			strSql.Append("@n_VendorID,@n_PayListID,@s_OppID,@s_Reason,@dt_ShldPayDate,@n_CurrencyID,@dt_ReceiveBill,@s_PayMark,@s_Payer,@dt_PayDate,@n_FeePayed,@s_CheckMark,@dt_CheckDate,@s_Checker,@s_Note,@s_FilePath,@s_Lock,@s_Locker,@s_Editor,@dt_CreateDate,@dt_EditDate,@n_APaymentID,@n_HedgeID,@s_Creator,@dt_Billing,@n_ModuleCheckStatusID,@n_LatestCheckInfoID,@n_AuthorID,@n_CurCheckerID,@s_CheckStatus,@n_Checker,@n_PayerID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_VendorID", SqlDbType.Int,4),
					new SqlParameter("@n_PayListID", SqlDbType.Int,4),
					new SqlParameter("@s_OppID", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Reason", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_ShldPayDate", SqlDbType.DateTime),
					new SqlParameter("@n_CurrencyID", SqlDbType.Int,4),
					new SqlParameter("@dt_ReceiveBill", SqlDbType.DateTime),
					new SqlParameter("@s_PayMark", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Payer", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_PayDate", SqlDbType.DateTime),
					new SqlParameter("@n_FeePayed", SqlDbType.Money,8),
					new SqlParameter("@s_CheckMark", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CheckDate", SqlDbType.DateTime),
					new SqlParameter("@s_Checker", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,300),
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_APaymentID", SqlDbType.Int,4),
					new SqlParameter("@n_HedgeID", SqlDbType.Int,4),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_Billing", SqlDbType.DateTime),
					new SqlParameter("@n_ModuleCheckStatusID", SqlDbType.Int,4),
					new SqlParameter("@n_LatestCheckInfoID", SqlDbType.Int,4),
					new SqlParameter("@n_AuthorID", SqlDbType.Int,4),
					new SqlParameter("@n_CurCheckerID", SqlDbType.Int,4),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@n_PayerID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_VendorID;
			parameters[1].Value = model.n_PayListID;
			parameters[2].Value = model.s_OppID;
			parameters[3].Value = model.s_Reason;
			parameters[4].Value = model.dt_ShldPayDate;
			parameters[5].Value = model.n_CurrencyID;
			parameters[6].Value = model.dt_ReceiveBill;
			parameters[7].Value = model.s_PayMark;
			parameters[8].Value = model.s_Payer;
			parameters[9].Value = model.dt_PayDate;
			parameters[10].Value = model.n_FeePayed;
			parameters[11].Value = model.s_CheckMark;
			parameters[12].Value = model.dt_CheckDate;
			parameters[13].Value = model.s_Checker;
			parameters[14].Value = model.s_Note;
			parameters[15].Value = model.s_FilePath;
			parameters[16].Value = model.s_Lock;
			parameters[17].Value = model.s_Locker;
			parameters[18].Value = model.s_Editor;
			parameters[19].Value = model.dt_CreateDate;
			parameters[20].Value = model.dt_EditDate;
			parameters[21].Value = model.n_APaymentID;
			parameters[22].Value = model.n_HedgeID;
			parameters[23].Value = model.s_Creator;
			parameters[24].Value = model.dt_Billing;
			parameters[25].Value = model.n_ModuleCheckStatusID;
			parameters[26].Value = model.n_LatestCheckInfoID;
			parameters[27].Value = model.n_AuthorID;
			parameters[28].Value = model.n_CurCheckerID;
			parameters[29].Value = model.s_CheckStatus;
			parameters[30].Value = model.n_Checker;
			parameters[31].Value = model.n_PayerID;

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
		public bool Update(IPSP.Model.T_AbroadBill model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_AbroadBill set ");
			strSql.Append("s_OppID=@s_OppID,");
			strSql.Append("s_Reason=@s_Reason,");
			strSql.Append("dt_ShldPayDate=@dt_ShldPayDate,");
			strSql.Append("n_CurrencyID=@n_CurrencyID,");
			strSql.Append("dt_ReceiveBill=@dt_ReceiveBill,");
			strSql.Append("s_PayMark=@s_PayMark,");
			strSql.Append("s_Payer=@s_Payer,");
			strSql.Append("dt_PayDate=@dt_PayDate,");
			strSql.Append("n_FeePayed=@n_FeePayed,");
			strSql.Append("s_CheckMark=@s_CheckMark,");
			strSql.Append("dt_CheckDate=@dt_CheckDate,");
			strSql.Append("s_Checker=@s_Checker,");
			strSql.Append("s_Note=@s_Note,");
			strSql.Append("s_FilePath=@s_FilePath,");
			strSql.Append("s_Lock=@s_Lock,");
			strSql.Append("s_Locker=@s_Locker,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("n_APaymentID=@n_APaymentID,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("dt_Billing=@dt_Billing,");
			strSql.Append("n_ModuleCheckStatusID=@n_ModuleCheckStatusID,");
			strSql.Append("n_LatestCheckInfoID=@n_LatestCheckInfoID,");
			strSql.Append("n_AuthorID=@n_AuthorID,");
			strSql.Append("n_CurCheckerID=@n_CurCheckerID,");
			strSql.Append("s_CheckStatus=@s_CheckStatus,");
			strSql.Append("n_Checker=@n_Checker,");
			strSql.Append("n_PayerID=@n_PayerID");
			strSql.Append(" where n_BillID=@n_BillID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_OppID", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Reason", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_ShldPayDate", SqlDbType.DateTime),
					new SqlParameter("@n_CurrencyID", SqlDbType.Int,4),
					new SqlParameter("@dt_ReceiveBill", SqlDbType.DateTime),
					new SqlParameter("@s_PayMark", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Payer", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_PayDate", SqlDbType.DateTime),
					new SqlParameter("@n_FeePayed", SqlDbType.Money,8),
					new SqlParameter("@s_CheckMark", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CheckDate", SqlDbType.DateTime),
					new SqlParameter("@s_Checker", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,300),
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_APaymentID", SqlDbType.Int,4),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_Billing", SqlDbType.DateTime),
					new SqlParameter("@n_ModuleCheckStatusID", SqlDbType.Int,4),
					new SqlParameter("@n_LatestCheckInfoID", SqlDbType.Int,4),
					new SqlParameter("@n_AuthorID", SqlDbType.Int,4),
					new SqlParameter("@n_CurCheckerID", SqlDbType.Int,4),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@n_PayerID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_VendorID", SqlDbType.Int,4),
					new SqlParameter("@n_PayListID", SqlDbType.Int,4),
					new SqlParameter("@n_HedgeID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_OppID;
			parameters[1].Value = model.s_Reason;
			parameters[2].Value = model.dt_ShldPayDate;
			parameters[3].Value = model.n_CurrencyID;
			parameters[4].Value = model.dt_ReceiveBill;
			parameters[5].Value = model.s_PayMark;
			parameters[6].Value = model.s_Payer;
			parameters[7].Value = model.dt_PayDate;
			parameters[8].Value = model.n_FeePayed;
			parameters[9].Value = model.s_CheckMark;
			parameters[10].Value = model.dt_CheckDate;
			parameters[11].Value = model.s_Checker;
			parameters[12].Value = model.s_Note;
			parameters[13].Value = model.s_FilePath;
			parameters[14].Value = model.s_Lock;
			parameters[15].Value = model.s_Locker;
			parameters[16].Value = model.s_Editor;
			parameters[17].Value = model.dt_CreateDate;
			parameters[18].Value = model.dt_EditDate;
			parameters[19].Value = model.n_APaymentID;
			parameters[20].Value = model.s_Creator;
			parameters[21].Value = model.dt_Billing;
			parameters[22].Value = model.n_ModuleCheckStatusID;
			parameters[23].Value = model.n_LatestCheckInfoID;
			parameters[24].Value = model.n_AuthorID;
			parameters[25].Value = model.n_CurCheckerID;
			parameters[26].Value = model.s_CheckStatus;
			parameters[27].Value = model.n_Checker;
			parameters[28].Value = model.n_PayerID;
			parameters[29].Value = model.n_BillID;
			parameters[30].Value = model.n_VendorID;
			parameters[31].Value = model.n_PayListID;
			parameters[32].Value = model.n_HedgeID;

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
			strSql.Append("delete from T_AbroadBill ");
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
		public bool Delete(int n_VendorID,int n_PayListID,int n_HedgeID,int n_BillID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_AbroadBill ");
			strSql.Append(" where n_VendorID=@n_VendorID and n_PayListID=@n_PayListID and n_HedgeID=@n_HedgeID and n_BillID=@n_BillID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_VendorID", SqlDbType.Int,4),
					new SqlParameter("@n_PayListID", SqlDbType.Int,4),
					new SqlParameter("@n_HedgeID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4)			};
			parameters[0].Value = n_VendorID;
			parameters[1].Value = n_PayListID;
			parameters[2].Value = n_HedgeID;
			parameters[3].Value = n_BillID;

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
			strSql.Append("delete from T_AbroadBill ");
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
		public IPSP.Model.T_AbroadBill GetModel(int n_BillID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_BillID,n_VendorID,n_PayListID,s_OppID,s_Reason,dt_ShldPayDate,n_CurrencyID,dt_ReceiveBill,s_PayMark,s_Payer,dt_PayDate,n_FeePayed,s_CheckMark,dt_CheckDate,s_Checker,s_Note,s_FilePath,s_Lock,s_Locker,s_Editor,dt_CreateDate,dt_EditDate,n_APaymentID,n_HedgeID,s_Creator,dt_Billing,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,s_CheckStatus,n_Checker,n_PayerID from T_AbroadBill ");
			strSql.Append(" where n_BillID=@n_BillID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_BillID;

			IPSP.Model.T_AbroadBill model=new IPSP.Model.T_AbroadBill();
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
		public IPSP.Model.T_AbroadBill DataRowToModel(DataRow row)
		{
			IPSP.Model.T_AbroadBill model=new IPSP.Model.T_AbroadBill();
			if (row != null)
			{
				if(row["n_BillID"]!=null && row["n_BillID"].ToString()!="")
				{
					model.n_BillID=int.Parse(row["n_BillID"].ToString());
				}
				if(row["n_VendorID"]!=null && row["n_VendorID"].ToString()!="")
				{
					model.n_VendorID=int.Parse(row["n_VendorID"].ToString());
				}
				if(row["n_PayListID"]!=null && row["n_PayListID"].ToString()!="")
				{
					model.n_PayListID=int.Parse(row["n_PayListID"].ToString());
				}
				if(row["s_OppID"]!=null)
				{
					model.s_OppID=row["s_OppID"].ToString();
				}
				if(row["s_Reason"]!=null)
				{
					model.s_Reason=row["s_Reason"].ToString();
				}
				if(row["dt_ShldPayDate"]!=null && row["dt_ShldPayDate"].ToString()!="")
				{
					model.dt_ShldPayDate=DateTime.Parse(row["dt_ShldPayDate"].ToString());
				}
				if(row["n_CurrencyID"]!=null && row["n_CurrencyID"].ToString()!="")
				{
					model.n_CurrencyID=int.Parse(row["n_CurrencyID"].ToString());
				}
				if(row["dt_ReceiveBill"]!=null && row["dt_ReceiveBill"].ToString()!="")
				{
					model.dt_ReceiveBill=DateTime.Parse(row["dt_ReceiveBill"].ToString());
				}
				if(row["s_PayMark"]!=null)
				{
					model.s_PayMark=row["s_PayMark"].ToString();
				}
				if(row["s_Payer"]!=null)
				{
					model.s_Payer=row["s_Payer"].ToString();
				}
				if(row["dt_PayDate"]!=null && row["dt_PayDate"].ToString()!="")
				{
					model.dt_PayDate=DateTime.Parse(row["dt_PayDate"].ToString());
				}
				if(row["n_FeePayed"]!=null && row["n_FeePayed"].ToString()!="")
				{
					model.n_FeePayed=decimal.Parse(row["n_FeePayed"].ToString());
				}
				if(row["s_CheckMark"]!=null)
				{
					model.s_CheckMark=row["s_CheckMark"].ToString();
				}
				if(row["dt_CheckDate"]!=null && row["dt_CheckDate"].ToString()!="")
				{
					model.dt_CheckDate=DateTime.Parse(row["dt_CheckDate"].ToString());
				}
				if(row["s_Checker"]!=null)
				{
					model.s_Checker=row["s_Checker"].ToString();
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
				}
				if(row["s_FilePath"]!=null)
				{
					model.s_FilePath=row["s_FilePath"].ToString();
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
				if(row["n_APaymentID"]!=null && row["n_APaymentID"].ToString()!="")
				{
					model.n_APaymentID=int.Parse(row["n_APaymentID"].ToString());
				}
				if(row["n_HedgeID"]!=null && row["n_HedgeID"].ToString()!="")
				{
					model.n_HedgeID=int.Parse(row["n_HedgeID"].ToString());
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["dt_Billing"]!=null && row["dt_Billing"].ToString()!="")
				{
					model.dt_Billing=DateTime.Parse(row["dt_Billing"].ToString());
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
				if(row["s_CheckStatus"]!=null)
				{
					model.s_CheckStatus=row["s_CheckStatus"].ToString();
				}
				if(row["n_Checker"]!=null && row["n_Checker"].ToString()!="")
				{
					model.n_Checker=int.Parse(row["n_Checker"].ToString());
				}
				if(row["n_PayerID"]!=null && row["n_PayerID"].ToString()!="")
				{
					model.n_PayerID=int.Parse(row["n_PayerID"].ToString());
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
			strSql.Append("select n_BillID,n_VendorID,n_PayListID,s_OppID,s_Reason,dt_ShldPayDate,n_CurrencyID,dt_ReceiveBill,s_PayMark,s_Payer,dt_PayDate,n_FeePayed,s_CheckMark,dt_CheckDate,s_Checker,s_Note,s_FilePath,s_Lock,s_Locker,s_Editor,dt_CreateDate,dt_EditDate,n_APaymentID,n_HedgeID,s_Creator,dt_Billing,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,s_CheckStatus,n_Checker,n_PayerID ");
			strSql.Append(" FROM T_AbroadBill ");
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
			strSql.Append(" n_BillID,n_VendorID,n_PayListID,s_OppID,s_Reason,dt_ShldPayDate,n_CurrencyID,dt_ReceiveBill,s_PayMark,s_Payer,dt_PayDate,n_FeePayed,s_CheckMark,dt_CheckDate,s_Checker,s_Note,s_FilePath,s_Lock,s_Locker,s_Editor,dt_CreateDate,dt_EditDate,n_APaymentID,n_HedgeID,s_Creator,dt_Billing,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,s_CheckStatus,n_Checker,n_PayerID ");
			strSql.Append(" FROM T_AbroadBill ");
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
			strSql.Append("select count(1) FROM T_AbroadBill ");
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
			strSql.Append(")AS Row, T.*  from T_AbroadBill T ");
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
			parameters[0].Value = "T_AbroadBill";
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

