/**  版本信息模板在安装目录下，可自行修改。
* T_Expense.cs
*
* 功 能： N/A
* 类 名： T_Expense
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:42   N/A    初版
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
	/// 数据访问类:T_Expense
	/// </summary>
	public partial class T_Expense
	{
		public T_Expense()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ExpenseID", "T_Expense"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ExpenseID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Expense");
			strSql.Append(" where n_ExpenseID=@n_ExpenseID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ExpenseID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ExpenseID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_Expense model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Expense(");
			strSql.Append("s_Type,s_Name,s_Object,s_Content,n_Currency,n_Account,dt_ShldPayDate,n_Creator,s_PayStatus,s_PayBillNo,dt_PayDate,n_Payer,s_CheckStatus,dt_CheckDate,n_Checker,dt_EditDate,dt_CreateDate,s_Creator,s_Editor,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,n_MainCaseID,s_Notes)");
			strSql.Append(" values (");
			strSql.Append("@s_Type,@s_Name,@s_Object,@s_Content,@n_Currency,@n_Account,@dt_ShldPayDate,@n_Creator,@s_PayStatus,@s_PayBillNo,@dt_PayDate,@n_Payer,@s_CheckStatus,@dt_CheckDate,@n_Checker,@dt_EditDate,@dt_CreateDate,@s_Creator,@s_Editor,@n_ModuleCheckStatusID,@n_LatestCheckInfoID,@n_AuthorID,@n_CurCheckerID,@n_MainCaseID,@s_Notes)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Object", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Content", SqlDbType.NVarChar,800),
					new SqlParameter("@n_Currency", SqlDbType.Int,4),
					new SqlParameter("@n_Account", SqlDbType.Decimal,9),
					new SqlParameter("@dt_ShldPayDate", SqlDbType.DateTime),
					new SqlParameter("@n_Creator", SqlDbType.Int,4),
					new SqlParameter("@s_PayStatus", SqlDbType.NVarChar,2),
					new SqlParameter("@s_PayBillNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_PayDate", SqlDbType.DateTime),
					new SqlParameter("@n_Payer", SqlDbType.Int,4),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CheckDate", SqlDbType.DateTime),
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ModuleCheckStatusID", SqlDbType.Int,4),
					new SqlParameter("@n_LatestCheckInfoID", SqlDbType.Int,4),
					new SqlParameter("@n_AuthorID", SqlDbType.Int,4),
					new SqlParameter("@n_CurCheckerID", SqlDbType.Int,4),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800)};
			parameters[0].Value = model.s_Type;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_Object;
			parameters[3].Value = model.s_Content;
			parameters[4].Value = model.n_Currency;
			parameters[5].Value = model.n_Account;
			parameters[6].Value = model.dt_ShldPayDate;
			parameters[7].Value = model.n_Creator;
			parameters[8].Value = model.s_PayStatus;
			parameters[9].Value = model.s_PayBillNo;
			parameters[10].Value = model.dt_PayDate;
			parameters[11].Value = model.n_Payer;
			parameters[12].Value = model.s_CheckStatus;
			parameters[13].Value = model.dt_CheckDate;
			parameters[14].Value = model.n_Checker;
			parameters[15].Value = model.dt_EditDate;
			parameters[16].Value = model.dt_CreateDate;
			parameters[17].Value = model.s_Creator;
			parameters[18].Value = model.s_Editor;
			parameters[19].Value = model.n_ModuleCheckStatusID;
			parameters[20].Value = model.n_LatestCheckInfoID;
			parameters[21].Value = model.n_AuthorID;
			parameters[22].Value = model.n_CurCheckerID;
			parameters[23].Value = model.n_MainCaseID;
			parameters[24].Value = model.s_Notes;

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
		public bool Update(IPSP.Model.T_Expense model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Expense set ");
			strSql.Append("s_Type=@s_Type,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_Object=@s_Object,");
			strSql.Append("s_Content=@s_Content,");
			strSql.Append("n_Currency=@n_Currency,");
			strSql.Append("n_Account=@n_Account,");
			strSql.Append("dt_ShldPayDate=@dt_ShldPayDate,");
			strSql.Append("n_Creator=@n_Creator,");
			strSql.Append("s_PayStatus=@s_PayStatus,");
			strSql.Append("s_PayBillNo=@s_PayBillNo,");
			strSql.Append("dt_PayDate=@dt_PayDate,");
			strSql.Append("n_Payer=@n_Payer,");
			strSql.Append("s_CheckStatus=@s_CheckStatus,");
			strSql.Append("dt_CheckDate=@dt_CheckDate,");
			strSql.Append("n_Checker=@n_Checker,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("n_ModuleCheckStatusID=@n_ModuleCheckStatusID,");
			strSql.Append("n_LatestCheckInfoID=@n_LatestCheckInfoID,");
			strSql.Append("n_AuthorID=@n_AuthorID,");
			strSql.Append("n_CurCheckerID=@n_CurCheckerID,");
			strSql.Append("n_MainCaseID=@n_MainCaseID,");
			strSql.Append("s_Notes=@s_Notes");
			strSql.Append(" where n_ExpenseID=@n_ExpenseID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Object", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Content", SqlDbType.NVarChar,800),
					new SqlParameter("@n_Currency", SqlDbType.Int,4),
					new SqlParameter("@n_Account", SqlDbType.Decimal,9),
					new SqlParameter("@dt_ShldPayDate", SqlDbType.DateTime),
					new SqlParameter("@n_Creator", SqlDbType.Int,4),
					new SqlParameter("@s_PayStatus", SqlDbType.NVarChar,2),
					new SqlParameter("@s_PayBillNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_PayDate", SqlDbType.DateTime),
					new SqlParameter("@n_Payer", SqlDbType.Int,4),
					new SqlParameter("@s_CheckStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CheckDate", SqlDbType.DateTime),
					new SqlParameter("@n_Checker", SqlDbType.Int,4),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ModuleCheckStatusID", SqlDbType.Int,4),
					new SqlParameter("@n_LatestCheckInfoID", SqlDbType.Int,4),
					new SqlParameter("@n_AuthorID", SqlDbType.Int,4),
					new SqlParameter("@n_CurCheckerID", SqlDbType.Int,4),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_ExpenseID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Type;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_Object;
			parameters[3].Value = model.s_Content;
			parameters[4].Value = model.n_Currency;
			parameters[5].Value = model.n_Account;
			parameters[6].Value = model.dt_ShldPayDate;
			parameters[7].Value = model.n_Creator;
			parameters[8].Value = model.s_PayStatus;
			parameters[9].Value = model.s_PayBillNo;
			parameters[10].Value = model.dt_PayDate;
			parameters[11].Value = model.n_Payer;
			parameters[12].Value = model.s_CheckStatus;
			parameters[13].Value = model.dt_CheckDate;
			parameters[14].Value = model.n_Checker;
			parameters[15].Value = model.dt_EditDate;
			parameters[16].Value = model.dt_CreateDate;
			parameters[17].Value = model.s_Creator;
			parameters[18].Value = model.s_Editor;
			parameters[19].Value = model.n_ModuleCheckStatusID;
			parameters[20].Value = model.n_LatestCheckInfoID;
			parameters[21].Value = model.n_AuthorID;
			parameters[22].Value = model.n_CurCheckerID;
			parameters[23].Value = model.n_MainCaseID;
			parameters[24].Value = model.s_Notes;
			parameters[25].Value = model.n_ExpenseID;

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
		public bool Delete(int n_ExpenseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Expense ");
			strSql.Append(" where n_ExpenseID=@n_ExpenseID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ExpenseID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ExpenseID;

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
		public bool DeleteList(string n_ExpenseIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Expense ");
			strSql.Append(" where n_ExpenseID in ("+n_ExpenseIDlist + ")  ");
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
		public IPSP.Model.T_Expense GetModel(int n_ExpenseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ExpenseID,s_Type,s_Name,s_Object,s_Content,n_Currency,n_Account,dt_ShldPayDate,n_Creator,s_PayStatus,s_PayBillNo,dt_PayDate,n_Payer,s_CheckStatus,dt_CheckDate,n_Checker,dt_EditDate,dt_CreateDate,s_Creator,s_Editor,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,n_MainCaseID,s_Notes from T_Expense ");
			strSql.Append(" where n_ExpenseID=@n_ExpenseID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ExpenseID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ExpenseID;

			IPSP.Model.T_Expense model=new IPSP.Model.T_Expense();
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
		public IPSP.Model.T_Expense DataRowToModel(DataRow row)
		{
			IPSP.Model.T_Expense model=new IPSP.Model.T_Expense();
			if (row != null)
			{
				if(row["n_ExpenseID"]!=null && row["n_ExpenseID"].ToString()!="")
				{
					model.n_ExpenseID=int.Parse(row["n_ExpenseID"].ToString());
				}
				if(row["s_Type"]!=null)
				{
					model.s_Type=row["s_Type"].ToString();
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_Object"]!=null)
				{
					model.s_Object=row["s_Object"].ToString();
				}
				if(row["s_Content"]!=null)
				{
					model.s_Content=row["s_Content"].ToString();
				}
				if(row["n_Currency"]!=null && row["n_Currency"].ToString()!="")
				{
					model.n_Currency=int.Parse(row["n_Currency"].ToString());
				}
				if(row["n_Account"]!=null && row["n_Account"].ToString()!="")
				{
					model.n_Account=decimal.Parse(row["n_Account"].ToString());
				}
				if(row["dt_ShldPayDate"]!=null && row["dt_ShldPayDate"].ToString()!="")
				{
					model.dt_ShldPayDate=DateTime.Parse(row["dt_ShldPayDate"].ToString());
				}
				if(row["n_Creator"]!=null && row["n_Creator"].ToString()!="")
				{
					model.n_Creator=int.Parse(row["n_Creator"].ToString());
				}
				if(row["s_PayStatus"]!=null)
				{
					model.s_PayStatus=row["s_PayStatus"].ToString();
				}
				if(row["s_PayBillNo"]!=null)
				{
					model.s_PayBillNo=row["s_PayBillNo"].ToString();
				}
				if(row["dt_PayDate"]!=null && row["dt_PayDate"].ToString()!="")
				{
					model.dt_PayDate=DateTime.Parse(row["dt_PayDate"].ToString());
				}
				if(row["n_Payer"]!=null && row["n_Payer"].ToString()!="")
				{
					model.n_Payer=int.Parse(row["n_Payer"].ToString());
				}
				if(row["s_CheckStatus"]!=null)
				{
					model.s_CheckStatus=row["s_CheckStatus"].ToString();
				}
				if(row["dt_CheckDate"]!=null && row["dt_CheckDate"].ToString()!="")
				{
					model.dt_CheckDate=DateTime.Parse(row["dt_CheckDate"].ToString());
				}
				if(row["n_Checker"]!=null && row["n_Checker"].ToString()!="")
				{
					model.n_Checker=int.Parse(row["n_Checker"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
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
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
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
			strSql.Append("select n_ExpenseID,s_Type,s_Name,s_Object,s_Content,n_Currency,n_Account,dt_ShldPayDate,n_Creator,s_PayStatus,s_PayBillNo,dt_PayDate,n_Payer,s_CheckStatus,dt_CheckDate,n_Checker,dt_EditDate,dt_CreateDate,s_Creator,s_Editor,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,n_MainCaseID,s_Notes ");
			strSql.Append(" FROM T_Expense ");
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
			strSql.Append(" n_ExpenseID,s_Type,s_Name,s_Object,s_Content,n_Currency,n_Account,dt_ShldPayDate,n_Creator,s_PayStatus,s_PayBillNo,dt_PayDate,n_Payer,s_CheckStatus,dt_CheckDate,n_Checker,dt_EditDate,dt_CreateDate,s_Creator,s_Editor,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,n_MainCaseID,s_Notes ");
			strSql.Append(" FROM T_Expense ");
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
			strSql.Append("select count(1) FROM T_Expense ");
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
				strSql.Append("order by T.n_ExpenseID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Expense T ");
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
			parameters[0].Value = "T_Expense";
			parameters[1].Value = "n_ExpenseID";
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

