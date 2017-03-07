/**  版本信息模板在安装目录下，可自行修改。
* TTB_Deposit.cs
*
* 功 能： N/A
* 类 名： TTB_Deposit
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:09   N/A    初版
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
	/// 数据访问类:TTB_Deposit
	/// </summary>
	public partial class TTB_Deposit
	{
		public TTB_Deposit()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_DepositID", "TTB_Deposit"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_DepositID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TTB_Deposit");
			strSql.Append(" where n_DepositID=@n_DepositID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_DepositID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_DepositID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TTB_Deposit model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TTB_Deposit(");
			strSql.Append("s_Class,dt_Date,n_Money,s_SheetNo,s_Bank,s_Account,dt_CreateDate,s_Creator,dt_EditDate,s_Editor,s_Note)");
			strSql.Append(" values (");
			strSql.Append("@s_Class,@dt_Date,@n_Money,@s_SheetNo,@s_Bank,@s_Account,@dt_CreateDate,@s_Creator,@dt_EditDate,@s_Editor,@s_Note)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Class", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_Date", SqlDbType.DateTime),
					new SqlParameter("@n_Money", SqlDbType.Money,8),
					new SqlParameter("@s_SheetNo", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Bank", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Account", SqlDbType.NVarChar,30),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,300)};
			parameters[0].Value = model.s_Class;
			parameters[1].Value = model.dt_Date;
			parameters[2].Value = model.n_Money;
			parameters[3].Value = model.s_SheetNo;
			parameters[4].Value = model.s_Bank;
			parameters[5].Value = model.s_Account;
			parameters[6].Value = model.dt_CreateDate;
			parameters[7].Value = model.s_Creator;
			parameters[8].Value = model.dt_EditDate;
			parameters[9].Value = model.s_Editor;
			parameters[10].Value = model.s_Note;

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
		public bool Update(IPSP.Model.TTB_Deposit model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TTB_Deposit set ");
			strSql.Append("s_Class=@s_Class,");
			strSql.Append("dt_Date=@dt_Date,");
			strSql.Append("n_Money=@n_Money,");
			strSql.Append("s_SheetNo=@s_SheetNo,");
			strSql.Append("s_Bank=@s_Bank,");
			strSql.Append("s_Account=@s_Account,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("s_Note=@s_Note");
			strSql.Append(" where n_DepositID=@n_DepositID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Class", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_Date", SqlDbType.DateTime),
					new SqlParameter("@n_Money", SqlDbType.Money,8),
					new SqlParameter("@s_SheetNo", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Bank", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Account", SqlDbType.NVarChar,30),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,300),
					new SqlParameter("@n_DepositID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Class;
			parameters[1].Value = model.dt_Date;
			parameters[2].Value = model.n_Money;
			parameters[3].Value = model.s_SheetNo;
			parameters[4].Value = model.s_Bank;
			parameters[5].Value = model.s_Account;
			parameters[6].Value = model.dt_CreateDate;
			parameters[7].Value = model.s_Creator;
			parameters[8].Value = model.dt_EditDate;
			parameters[9].Value = model.s_Editor;
			parameters[10].Value = model.s_Note;
			parameters[11].Value = model.n_DepositID;

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
		public bool Delete(int n_DepositID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TTB_Deposit ");
			strSql.Append(" where n_DepositID=@n_DepositID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_DepositID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_DepositID;

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
		public bool DeleteList(string n_DepositIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TTB_Deposit ");
			strSql.Append(" where n_DepositID in ("+n_DepositIDlist + ")  ");
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
		public IPSP.Model.TTB_Deposit GetModel(int n_DepositID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_DepositID,s_Class,dt_Date,n_Money,s_SheetNo,s_Bank,s_Account,dt_CreateDate,s_Creator,dt_EditDate,s_Editor,s_Note from TTB_Deposit ");
			strSql.Append(" where n_DepositID=@n_DepositID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_DepositID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_DepositID;

			IPSP.Model.TTB_Deposit model=new IPSP.Model.TTB_Deposit();
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
		public IPSP.Model.TTB_Deposit DataRowToModel(DataRow row)
		{
			IPSP.Model.TTB_Deposit model=new IPSP.Model.TTB_Deposit();
			if (row != null)
			{
				if(row["n_DepositID"]!=null && row["n_DepositID"].ToString()!="")
				{
					model.n_DepositID=int.Parse(row["n_DepositID"].ToString());
				}
				if(row["s_Class"]!=null)
				{
					model.s_Class=row["s_Class"].ToString();
				}
				if(row["dt_Date"]!=null && row["dt_Date"].ToString()!="")
				{
					model.dt_Date=DateTime.Parse(row["dt_Date"].ToString());
				}
				if(row["n_Money"]!=null && row["n_Money"].ToString()!="")
				{
					model.n_Money=decimal.Parse(row["n_Money"].ToString());
				}
				if(row["s_SheetNo"]!=null)
				{
					model.s_SheetNo=row["s_SheetNo"].ToString();
				}
				if(row["s_Bank"]!=null)
				{
					model.s_Bank=row["s_Bank"].ToString();
				}
				if(row["s_Account"]!=null)
				{
					model.s_Account=row["s_Account"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
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
			strSql.Append("select n_DepositID,s_Class,dt_Date,n_Money,s_SheetNo,s_Bank,s_Account,dt_CreateDate,s_Creator,dt_EditDate,s_Editor,s_Note ");
			strSql.Append(" FROM TTB_Deposit ");
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
			strSql.Append(" n_DepositID,s_Class,dt_Date,n_Money,s_SheetNo,s_Bank,s_Account,dt_CreateDate,s_Creator,dt_EditDate,s_Editor,s_Note ");
			strSql.Append(" FROM TTB_Deposit ");
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
			strSql.Append("select count(1) FROM TTB_Deposit ");
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
				strSql.Append("order by T.n_DepositID desc");
			}
			strSql.Append(")AS Row, T.*  from TTB_Deposit T ");
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
			parameters[0].Value = "TTB_Deposit";
			parameters[1].Value = "n_DepositID";
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

