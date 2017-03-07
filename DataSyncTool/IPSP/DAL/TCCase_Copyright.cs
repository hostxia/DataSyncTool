/**  版本信息模板在安装目录下，可自行修改。
* TCCase_Copyright.cs
*
* 功 能： N/A
* 类 名： TCCase_Copyright
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:41   N/A    初版
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
	/// 数据访问类:TCCase_Copyright
	/// </summary>
	public partial class TCCase_Copyright
	{
		public TCCase_Copyright()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TCCase_Copyright"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCCase_Copyright");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TCCase_Copyright model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCCase_Copyright(");
			strSql.Append("n_CaseID,n_CFlowNum,s_SignName,n_CopyrightType,dt_CreationStart,dt_CreationEnd,n_Wordage,s_CompleteType,s_Published,dt_FirstPublished,s_FirstPublishAddr,s_ApplyAim,s_RightRange,dt_Apply,s_Register,dt_Register,s_AcceptNo,s_ReceiptNo,s_StoreNo,dt_Store,s_CopyrightStatus)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@n_CFlowNum,@s_SignName,@n_CopyrightType,@dt_CreationStart,@dt_CreationEnd,@n_Wordage,@s_CompleteType,@s_Published,@dt_FirstPublished,@s_FirstPublishAddr,@s_ApplyAim,@s_RightRange,@dt_Apply,@s_Register,@dt_Register,@s_AcceptNo,@s_ReceiptNo,@s_StoreNo,@dt_Store,@s_CopyrightStatus)");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_CFlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_SignName", SqlDbType.NVarChar,50),
					new SqlParameter("@n_CopyrightType", SqlDbType.Int,4),
					new SqlParameter("@dt_CreationStart", SqlDbType.DateTime),
					new SqlParameter("@dt_CreationEnd", SqlDbType.DateTime),
					new SqlParameter("@n_Wordage", SqlDbType.Int,4),
					new SqlParameter("@s_CompleteType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Published", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_FirstPublished", SqlDbType.DateTime),
					new SqlParameter("@s_FirstPublishAddr", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ApplyAim", SqlDbType.NVarChar,500),
					new SqlParameter("@s_RightRange", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_Apply", SqlDbType.DateTime),
					new SqlParameter("@s_Register", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_Register", SqlDbType.DateTime),
					new SqlParameter("@s_AcceptNo", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ReceiptNo", SqlDbType.NVarChar,50),
					new SqlParameter("@s_StoreNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_Store", SqlDbType.DateTime),
					new SqlParameter("@s_CopyrightStatus", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.n_CFlowNum;
			parameters[2].Value = model.s_SignName;
			parameters[3].Value = model.n_CopyrightType;
			parameters[4].Value = model.dt_CreationStart;
			parameters[5].Value = model.dt_CreationEnd;
			parameters[6].Value = model.n_Wordage;
			parameters[7].Value = model.s_CompleteType;
			parameters[8].Value = model.s_Published;
			parameters[9].Value = model.dt_FirstPublished;
			parameters[10].Value = model.s_FirstPublishAddr;
			parameters[11].Value = model.s_ApplyAim;
			parameters[12].Value = model.s_RightRange;
			parameters[13].Value = model.dt_Apply;
			parameters[14].Value = model.s_Register;
			parameters[15].Value = model.dt_Register;
			parameters[16].Value = model.s_AcceptNo;
			parameters[17].Value = model.s_ReceiptNo;
			parameters[18].Value = model.s_StoreNo;
			parameters[19].Value = model.dt_Store;
			parameters[20].Value = model.s_CopyrightStatus;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(IPSP.Model.TCCase_Copyright model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCCase_Copyright set ");
			strSql.Append("n_CFlowNum=@n_CFlowNum,");
			strSql.Append("s_SignName=@s_SignName,");
			strSql.Append("n_CopyrightType=@n_CopyrightType,");
			strSql.Append("dt_CreationStart=@dt_CreationStart,");
			strSql.Append("dt_CreationEnd=@dt_CreationEnd,");
			strSql.Append("n_Wordage=@n_Wordage,");
			strSql.Append("s_CompleteType=@s_CompleteType,");
			strSql.Append("s_Published=@s_Published,");
			strSql.Append("dt_FirstPublished=@dt_FirstPublished,");
			strSql.Append("s_FirstPublishAddr=@s_FirstPublishAddr,");
			strSql.Append("s_ApplyAim=@s_ApplyAim,");
			strSql.Append("s_RightRange=@s_RightRange,");
			strSql.Append("dt_Apply=@dt_Apply,");
			strSql.Append("s_Register=@s_Register,");
			strSql.Append("dt_Register=@dt_Register,");
			strSql.Append("s_AcceptNo=@s_AcceptNo,");
			strSql.Append("s_ReceiptNo=@s_ReceiptNo,");
			strSql.Append("s_StoreNo=@s_StoreNo,");
			strSql.Append("dt_Store=@dt_Store,");
			strSql.Append("s_CopyrightStatus=@s_CopyrightStatus");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CFlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_SignName", SqlDbType.NVarChar,50),
					new SqlParameter("@n_CopyrightType", SqlDbType.Int,4),
					new SqlParameter("@dt_CreationStart", SqlDbType.DateTime),
					new SqlParameter("@dt_CreationEnd", SqlDbType.DateTime),
					new SqlParameter("@n_Wordage", SqlDbType.Int,4),
					new SqlParameter("@s_CompleteType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Published", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_FirstPublished", SqlDbType.DateTime),
					new SqlParameter("@s_FirstPublishAddr", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ApplyAim", SqlDbType.NVarChar,500),
					new SqlParameter("@s_RightRange", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_Apply", SqlDbType.DateTime),
					new SqlParameter("@s_Register", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_Register", SqlDbType.DateTime),
					new SqlParameter("@s_AcceptNo", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ReceiptNo", SqlDbType.NVarChar,50),
					new SqlParameter("@s_StoreNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_Store", SqlDbType.DateTime),
					new SqlParameter("@s_CopyrightStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_CFlowNum;
			parameters[1].Value = model.s_SignName;
			parameters[2].Value = model.n_CopyrightType;
			parameters[3].Value = model.dt_CreationStart;
			parameters[4].Value = model.dt_CreationEnd;
			parameters[5].Value = model.n_Wordage;
			parameters[6].Value = model.s_CompleteType;
			parameters[7].Value = model.s_Published;
			parameters[8].Value = model.dt_FirstPublished;
			parameters[9].Value = model.s_FirstPublishAddr;
			parameters[10].Value = model.s_ApplyAim;
			parameters[11].Value = model.s_RightRange;
			parameters[12].Value = model.dt_Apply;
			parameters[13].Value = model.s_Register;
			parameters[14].Value = model.dt_Register;
			parameters[15].Value = model.s_AcceptNo;
			parameters[16].Value = model.s_ReceiptNo;
			parameters[17].Value = model.s_StoreNo;
			parameters[18].Value = model.dt_Store;
			parameters[19].Value = model.s_CopyrightStatus;
			parameters[20].Value = model.n_CaseID;

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
			strSql.Append("delete from TCCase_Copyright ");
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
		public bool DeleteList(string n_CaseIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCCase_Copyright ");
			strSql.Append(" where n_CaseID in ("+n_CaseIDlist + ")  ");
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
		public IPSP.Model.TCCase_Copyright GetModel(int n_CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_CaseID,n_CFlowNum,s_SignName,n_CopyrightType,dt_CreationStart,dt_CreationEnd,n_Wordage,s_CompleteType,s_Published,dt_FirstPublished,s_FirstPublishAddr,s_ApplyAim,s_RightRange,dt_Apply,s_Register,dt_Register,s_AcceptNo,s_ReceiptNo,s_StoreNo,dt_Store,s_CopyrightStatus from TCCase_Copyright ");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

			IPSP.Model.TCCase_Copyright model=new IPSP.Model.TCCase_Copyright();
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
		public IPSP.Model.TCCase_Copyright DataRowToModel(DataRow row)
		{
			IPSP.Model.TCCase_Copyright model=new IPSP.Model.TCCase_Copyright();
			if (row != null)
			{
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["n_CFlowNum"]!=null && row["n_CFlowNum"].ToString()!="")
				{
					model.n_CFlowNum=int.Parse(row["n_CFlowNum"].ToString());
				}
				if(row["s_SignName"]!=null)
				{
					model.s_SignName=row["s_SignName"].ToString();
				}
				if(row["n_CopyrightType"]!=null && row["n_CopyrightType"].ToString()!="")
				{
					model.n_CopyrightType=int.Parse(row["n_CopyrightType"].ToString());
				}
				if(row["dt_CreationStart"]!=null && row["dt_CreationStart"].ToString()!="")
				{
					model.dt_CreationStart=DateTime.Parse(row["dt_CreationStart"].ToString());
				}
				if(row["dt_CreationEnd"]!=null && row["dt_CreationEnd"].ToString()!="")
				{
					model.dt_CreationEnd=DateTime.Parse(row["dt_CreationEnd"].ToString());
				}
				if(row["n_Wordage"]!=null && row["n_Wordage"].ToString()!="")
				{
					model.n_Wordage=int.Parse(row["n_Wordage"].ToString());
				}
				if(row["s_CompleteType"]!=null)
				{
					model.s_CompleteType=row["s_CompleteType"].ToString();
				}
				if(row["s_Published"]!=null)
				{
					model.s_Published=row["s_Published"].ToString();
				}
				if(row["dt_FirstPublished"]!=null && row["dt_FirstPublished"].ToString()!="")
				{
					model.dt_FirstPublished=DateTime.Parse(row["dt_FirstPublished"].ToString());
				}
				if(row["s_FirstPublishAddr"]!=null)
				{
					model.s_FirstPublishAddr=row["s_FirstPublishAddr"].ToString();
				}
				if(row["s_ApplyAim"]!=null)
				{
					model.s_ApplyAim=row["s_ApplyAim"].ToString();
				}
				if(row["s_RightRange"]!=null)
				{
					model.s_RightRange=row["s_RightRange"].ToString();
				}
				if(row["dt_Apply"]!=null && row["dt_Apply"].ToString()!="")
				{
					model.dt_Apply=DateTime.Parse(row["dt_Apply"].ToString());
				}
				if(row["s_Register"]!=null)
				{
					model.s_Register=row["s_Register"].ToString();
				}
				if(row["dt_Register"]!=null && row["dt_Register"].ToString()!="")
				{
					model.dt_Register=DateTime.Parse(row["dt_Register"].ToString());
				}
				if(row["s_AcceptNo"]!=null)
				{
					model.s_AcceptNo=row["s_AcceptNo"].ToString();
				}
				if(row["s_ReceiptNo"]!=null)
				{
					model.s_ReceiptNo=row["s_ReceiptNo"].ToString();
				}
				if(row["s_StoreNo"]!=null)
				{
					model.s_StoreNo=row["s_StoreNo"].ToString();
				}
				if(row["dt_Store"]!=null && row["dt_Store"].ToString()!="")
				{
					model.dt_Store=DateTime.Parse(row["dt_Store"].ToString());
				}
				if(row["s_CopyrightStatus"]!=null)
				{
					model.s_CopyrightStatus=row["s_CopyrightStatus"].ToString();
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
			strSql.Append("select n_CaseID,n_CFlowNum,s_SignName,n_CopyrightType,dt_CreationStart,dt_CreationEnd,n_Wordage,s_CompleteType,s_Published,dt_FirstPublished,s_FirstPublishAddr,s_ApplyAim,s_RightRange,dt_Apply,s_Register,dt_Register,s_AcceptNo,s_ReceiptNo,s_StoreNo,dt_Store,s_CopyrightStatus ");
			strSql.Append(" FROM TCCase_Copyright ");
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
			strSql.Append(" n_CaseID,n_CFlowNum,s_SignName,n_CopyrightType,dt_CreationStart,dt_CreationEnd,n_Wordage,s_CompleteType,s_Published,dt_FirstPublished,s_FirstPublishAddr,s_ApplyAim,s_RightRange,dt_Apply,s_Register,dt_Register,s_AcceptNo,s_ReceiptNo,s_StoreNo,dt_Store,s_CopyrightStatus ");
			strSql.Append(" FROM TCCase_Copyright ");
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
			strSql.Append("select count(1) FROM TCCase_Copyright ");
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
				strSql.Append("order by T.n_CaseID desc");
			}
			strSql.Append(")AS Row, T.*  from TCCase_Copyright T ");
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
			parameters[0].Value = "TCCase_Copyright";
			parameters[1].Value = "n_CaseID";
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

