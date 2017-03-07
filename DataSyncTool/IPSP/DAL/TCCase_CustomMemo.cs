/**  版本信息模板在安装目录下，可自行修改。
* TCCase_CustomMemo.cs
*
* 功 能： N/A
* 类 名： TCCase_CustomMemo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:42   N/A    初版
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
	/// 数据访问类:TCCase_CustomMemo
	/// </summary>
	public partial class TCCase_CustomMemo
	{
		public TCCase_CustomMemo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TCCase_CustomMemo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCCase_CustomMemo");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCCase_CustomMemo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCCase_CustomMemo(");
			strSql.Append("n_CaseID,s_Name,s_LicenseNum,dt_ExpiredDate,s_Note,s_AttachedFiles,s_OtherClaim,s_AppNum,dt_ReceiveDate,s_MemoName,dt_CheckDate,dt_ConfirmDate,s_MemoNum,dt_MemoExpireDate)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@s_Name,@s_LicenseNum,@dt_ExpiredDate,@s_Note,@s_AttachedFiles,@s_OtherClaim,@s_AppNum,@dt_ReceiveDate,@s_MemoName,@dt_CheckDate,@dt_ConfirmDate,@s_MemoNum,@dt_MemoExpireDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_LicenseNum", SqlDbType.NVarChar,30),
					new SqlParameter("@dt_ExpiredDate", SqlDbType.DateTime),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,600),
					new SqlParameter("@s_AttachedFiles", SqlDbType.NVarChar,15),
					new SqlParameter("@s_OtherClaim", SqlDbType.NVarChar,600),
					new SqlParameter("@s_AppNum", SqlDbType.NVarChar,60),
					new SqlParameter("@dt_ReceiveDate", SqlDbType.DateTime),
					new SqlParameter("@s_MemoName", SqlDbType.NVarChar,300),
					new SqlParameter("@dt_CheckDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ConfirmDate", SqlDbType.DateTime),
					new SqlParameter("@s_MemoNum", SqlDbType.NVarChar,30),
					new SqlParameter("@dt_MemoExpireDate", SqlDbType.DateTime)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_LicenseNum;
			parameters[3].Value = model.dt_ExpiredDate;
			parameters[4].Value = model.s_Note;
			parameters[5].Value = model.s_AttachedFiles;
			parameters[6].Value = model.s_OtherClaim;
			parameters[7].Value = model.s_AppNum;
			parameters[8].Value = model.dt_ReceiveDate;
			parameters[9].Value = model.s_MemoName;
			parameters[10].Value = model.dt_CheckDate;
			parameters[11].Value = model.dt_ConfirmDate;
			parameters[12].Value = model.s_MemoNum;
			parameters[13].Value = model.dt_MemoExpireDate;

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
		public bool Update(IPSP.Model.TCCase_CustomMemo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCCase_CustomMemo set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_LicenseNum=@s_LicenseNum,");
			strSql.Append("dt_ExpiredDate=@dt_ExpiredDate,");
			strSql.Append("s_Note=@s_Note,");
			strSql.Append("s_AttachedFiles=@s_AttachedFiles,");
			strSql.Append("s_OtherClaim=@s_OtherClaim,");
			strSql.Append("s_AppNum=@s_AppNum,");
			strSql.Append("dt_ReceiveDate=@dt_ReceiveDate,");
			strSql.Append("s_MemoName=@s_MemoName,");
			strSql.Append("dt_CheckDate=@dt_CheckDate,");
			strSql.Append("dt_ConfirmDate=@dt_ConfirmDate,");
			strSql.Append("s_MemoNum=@s_MemoNum,");
			strSql.Append("dt_MemoExpireDate=@dt_MemoExpireDate");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_LicenseNum", SqlDbType.NVarChar,30),
					new SqlParameter("@dt_ExpiredDate", SqlDbType.DateTime),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,600),
					new SqlParameter("@s_AttachedFiles", SqlDbType.NVarChar,15),
					new SqlParameter("@s_OtherClaim", SqlDbType.NVarChar,600),
					new SqlParameter("@s_AppNum", SqlDbType.NVarChar,60),
					new SqlParameter("@dt_ReceiveDate", SqlDbType.DateTime),
					new SqlParameter("@s_MemoName", SqlDbType.NVarChar,300),
					new SqlParameter("@dt_CheckDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ConfirmDate", SqlDbType.DateTime),
					new SqlParameter("@s_MemoNum", SqlDbType.NVarChar,30),
					new SqlParameter("@dt_MemoExpireDate", SqlDbType.DateTime),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_LicenseNum;
			parameters[2].Value = model.dt_ExpiredDate;
			parameters[3].Value = model.s_Note;
			parameters[4].Value = model.s_AttachedFiles;
			parameters[5].Value = model.s_OtherClaim;
			parameters[6].Value = model.s_AppNum;
			parameters[7].Value = model.dt_ReceiveDate;
			parameters[8].Value = model.s_MemoName;
			parameters[9].Value = model.dt_CheckDate;
			parameters[10].Value = model.dt_ConfirmDate;
			parameters[11].Value = model.s_MemoNum;
			parameters[12].Value = model.dt_MemoExpireDate;
			parameters[13].Value = model.n_CaseID;
			parameters[14].Value = model.n_ID;

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
		public bool Delete(int n_CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCCase_CustomMemo ");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

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
			strSql.Append("delete from TCCase_CustomMemo ");
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
		public IPSP.Model.TCCase_CustomMemo GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_CaseID,s_Name,s_LicenseNum,dt_ExpiredDate,s_Note,s_AttachedFiles,s_OtherClaim,s_AppNum,dt_ReceiveDate,s_MemoName,dt_CheckDate,dt_ConfirmDate,s_MemoNum,dt_MemoExpireDate,n_ID from TCCase_CustomMemo ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCCase_CustomMemo model=new IPSP.Model.TCCase_CustomMemo();
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
		public IPSP.Model.TCCase_CustomMemo DataRowToModel(DataRow row)
		{
			IPSP.Model.TCCase_CustomMemo model=new IPSP.Model.TCCase_CustomMemo();
			if (row != null)
			{
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_LicenseNum"]!=null)
				{
					model.s_LicenseNum=row["s_LicenseNum"].ToString();
				}
				if(row["dt_ExpiredDate"]!=null && row["dt_ExpiredDate"].ToString()!="")
				{
					model.dt_ExpiredDate=DateTime.Parse(row["dt_ExpiredDate"].ToString());
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
				}
				if(row["s_AttachedFiles"]!=null)
				{
					model.s_AttachedFiles=row["s_AttachedFiles"].ToString();
				}
				if(row["s_OtherClaim"]!=null)
				{
					model.s_OtherClaim=row["s_OtherClaim"].ToString();
				}
				if(row["s_AppNum"]!=null)
				{
					model.s_AppNum=row["s_AppNum"].ToString();
				}
				if(row["dt_ReceiveDate"]!=null && row["dt_ReceiveDate"].ToString()!="")
				{
					model.dt_ReceiveDate=DateTime.Parse(row["dt_ReceiveDate"].ToString());
				}
				if(row["s_MemoName"]!=null)
				{
					model.s_MemoName=row["s_MemoName"].ToString();
				}
				if(row["dt_CheckDate"]!=null && row["dt_CheckDate"].ToString()!="")
				{
					model.dt_CheckDate=DateTime.Parse(row["dt_CheckDate"].ToString());
				}
				if(row["dt_ConfirmDate"]!=null && row["dt_ConfirmDate"].ToString()!="")
				{
					model.dt_ConfirmDate=DateTime.Parse(row["dt_ConfirmDate"].ToString());
				}
				if(row["s_MemoNum"]!=null)
				{
					model.s_MemoNum=row["s_MemoNum"].ToString();
				}
				if(row["dt_MemoExpireDate"]!=null && row["dt_MemoExpireDate"].ToString()!="")
				{
					model.dt_MemoExpireDate=DateTime.Parse(row["dt_MemoExpireDate"].ToString());
				}
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
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
			strSql.Append("select n_CaseID,s_Name,s_LicenseNum,dt_ExpiredDate,s_Note,s_AttachedFiles,s_OtherClaim,s_AppNum,dt_ReceiveDate,s_MemoName,dt_CheckDate,dt_ConfirmDate,s_MemoNum,dt_MemoExpireDate,n_ID ");
			strSql.Append(" FROM TCCase_CustomMemo ");
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
			strSql.Append(" n_CaseID,s_Name,s_LicenseNum,dt_ExpiredDate,s_Note,s_AttachedFiles,s_OtherClaim,s_AppNum,dt_ReceiveDate,s_MemoName,dt_CheckDate,dt_ConfirmDate,s_MemoNum,dt_MemoExpireDate,n_ID ");
			strSql.Append(" FROM TCCase_CustomMemo ");
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
			strSql.Append("select count(1) FROM TCCase_CustomMemo ");
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
			strSql.Append(")AS Row, T.*  from TCCase_CustomMemo T ");
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
			parameters[0].Value = "TCCase_CustomMemo";
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

