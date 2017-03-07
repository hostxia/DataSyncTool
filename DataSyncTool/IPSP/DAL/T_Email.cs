/**  版本信息模板在安装目录下，可自行修改。
* T_Email.cs
*
* 功 能： N/A
* 类 名： T_Email
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
	/// 数据访问类:T_Email
	/// </summary>
	public partial class T_Email
	{
		public T_Email()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_EmailClass", "T_Email"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_EmailClass,int n_UserID,int n_EmailID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Email");
			strSql.Append(" where n_EmailClass=@n_EmailClass and n_UserID=@n_UserID and n_EmailID=@n_EmailID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_EmailClass", SqlDbType.Int,4),
					new SqlParameter("@n_UserID", SqlDbType.Int,4),
					new SqlParameter("@n_EmailID", SqlDbType.Int,4)			};
			parameters[0].Value = n_EmailClass;
			parameters[1].Value = n_UserID;
			parameters[2].Value = n_EmailID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_Email model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Email(");
			strSql.Append("s_EmailPath,s_From,s_To,s_Cc,s_Bc,s_Subject,s_EmailBody,dt_SendTime,dt_ReceiveTime,s_Type,n_EmailClass,s_Important,dt_CreateDate,dt_EditDate,s_IO,s_ReadMark,n_UserID,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,n_MainCaseID,n_AttachCounts,s_FolderID,s_Abstact)");
			strSql.Append(" values (");
			strSql.Append("@s_EmailPath,@s_From,@s_To,@s_Cc,@s_Bc,@s_Subject,@s_EmailBody,@dt_SendTime,@dt_ReceiveTime,@s_Type,@n_EmailClass,@s_Important,@dt_CreateDate,@dt_EditDate,@s_IO,@s_ReadMark,@n_UserID,@n_ModuleCheckStatusID,@n_LatestCheckInfoID,@n_AuthorID,@n_CurCheckerID,@n_MainCaseID,@n_AttachCounts,@s_FolderID,@s_Abstact)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_EmailPath", SqlDbType.NVarChar,500),
					new SqlParameter("@s_From", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_To", SqlDbType.NVarChar,3000),
					new SqlParameter("@s_Cc", SqlDbType.NVarChar,3000),
					new SqlParameter("@s_Bc", SqlDbType.NVarChar,3000),
					new SqlParameter("@s_Subject", SqlDbType.NVarChar,500),
					new SqlParameter("@s_EmailBody", SqlDbType.VarBinary,-1),
					new SqlParameter("@dt_SendTime", SqlDbType.DateTime),
					new SqlParameter("@dt_ReceiveTime", SqlDbType.DateTime),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,500),
					new SqlParameter("@n_EmailClass", SqlDbType.Int,4),
					new SqlParameter("@s_Important", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IO", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ReadMark", SqlDbType.NVarChar,1),
					new SqlParameter("@n_UserID", SqlDbType.Int,4),
					new SqlParameter("@n_ModuleCheckStatusID", SqlDbType.Int,4),
					new SqlParameter("@n_LatestCheckInfoID", SqlDbType.Int,4),
					new SqlParameter("@n_AuthorID", SqlDbType.Int,4),
					new SqlParameter("@n_CurCheckerID", SqlDbType.Int,4),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@n_AttachCounts", SqlDbType.Int,4),
					new SqlParameter("@s_FolderID", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_Abstact", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.s_EmailPath;
			parameters[1].Value = model.s_From;
			parameters[2].Value = model.s_To;
			parameters[3].Value = model.s_Cc;
			parameters[4].Value = model.s_Bc;
			parameters[5].Value = model.s_Subject;
			parameters[6].Value = model.s_EmailBody;
			parameters[7].Value = model.dt_SendTime;
			parameters[8].Value = model.dt_ReceiveTime;
			parameters[9].Value = model.s_Type;
			parameters[10].Value = model.n_EmailClass;
			parameters[11].Value = model.s_Important;
			parameters[12].Value = model.dt_CreateDate;
			parameters[13].Value = model.dt_EditDate;
			parameters[14].Value = model.s_IO;
			parameters[15].Value = model.s_ReadMark;
			parameters[16].Value = model.n_UserID;
			parameters[17].Value = model.n_ModuleCheckStatusID;
			parameters[18].Value = model.n_LatestCheckInfoID;
			parameters[19].Value = model.n_AuthorID;
			parameters[20].Value = model.n_CurCheckerID;
			parameters[21].Value = model.n_MainCaseID;
			parameters[22].Value = model.n_AttachCounts;
			parameters[23].Value = model.s_FolderID;
			parameters[24].Value = model.s_Abstact;

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
		public bool Update(IPSP.Model.T_Email model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Email set ");
			strSql.Append("s_EmailPath=@s_EmailPath,");
			strSql.Append("s_From=@s_From,");
			strSql.Append("s_To=@s_To,");
			strSql.Append("s_Cc=@s_Cc,");
			strSql.Append("s_Bc=@s_Bc,");
			strSql.Append("s_Subject=@s_Subject,");
			strSql.Append("s_EmailBody=@s_EmailBody,");
			strSql.Append("dt_SendTime=@dt_SendTime,");
			strSql.Append("dt_ReceiveTime=@dt_ReceiveTime,");
			strSql.Append("s_Type=@s_Type,");
			strSql.Append("s_Important=@s_Important,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_IO=@s_IO,");
			strSql.Append("s_ReadMark=@s_ReadMark,");
			strSql.Append("n_ModuleCheckStatusID=@n_ModuleCheckStatusID,");
			strSql.Append("n_LatestCheckInfoID=@n_LatestCheckInfoID,");
			strSql.Append("n_AuthorID=@n_AuthorID,");
			strSql.Append("n_CurCheckerID=@n_CurCheckerID,");
			strSql.Append("n_MainCaseID=@n_MainCaseID,");
			strSql.Append("n_AttachCounts=@n_AttachCounts,");
			strSql.Append("s_FolderID=@s_FolderID,");
			strSql.Append("s_Abstact=@s_Abstact");
			strSql.Append(" where n_EmailID=@n_EmailID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_EmailPath", SqlDbType.NVarChar,500),
					new SqlParameter("@s_From", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_To", SqlDbType.NVarChar,3000),
					new SqlParameter("@s_Cc", SqlDbType.NVarChar,3000),
					new SqlParameter("@s_Bc", SqlDbType.NVarChar,3000),
					new SqlParameter("@s_Subject", SqlDbType.NVarChar,500),
					new SqlParameter("@s_EmailBody", SqlDbType.VarBinary,-1),
					new SqlParameter("@dt_SendTime", SqlDbType.DateTime),
					new SqlParameter("@dt_ReceiveTime", SqlDbType.DateTime),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Important", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IO", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ReadMark", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ModuleCheckStatusID", SqlDbType.Int,4),
					new SqlParameter("@n_LatestCheckInfoID", SqlDbType.Int,4),
					new SqlParameter("@n_AuthorID", SqlDbType.Int,4),
					new SqlParameter("@n_CurCheckerID", SqlDbType.Int,4),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@n_AttachCounts", SqlDbType.Int,4),
					new SqlParameter("@s_FolderID", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_Abstact", SqlDbType.NVarChar,200),
					new SqlParameter("@n_EmailID", SqlDbType.Int,4),
					new SqlParameter("@n_EmailClass", SqlDbType.Int,4),
					new SqlParameter("@n_UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_EmailPath;
			parameters[1].Value = model.s_From;
			parameters[2].Value = model.s_To;
			parameters[3].Value = model.s_Cc;
			parameters[4].Value = model.s_Bc;
			parameters[5].Value = model.s_Subject;
			parameters[6].Value = model.s_EmailBody;
			parameters[7].Value = model.dt_SendTime;
			parameters[8].Value = model.dt_ReceiveTime;
			parameters[9].Value = model.s_Type;
			parameters[10].Value = model.s_Important;
			parameters[11].Value = model.dt_CreateDate;
			parameters[12].Value = model.dt_EditDate;
			parameters[13].Value = model.s_IO;
			parameters[14].Value = model.s_ReadMark;
			parameters[15].Value = model.n_ModuleCheckStatusID;
			parameters[16].Value = model.n_LatestCheckInfoID;
			parameters[17].Value = model.n_AuthorID;
			parameters[18].Value = model.n_CurCheckerID;
			parameters[19].Value = model.n_MainCaseID;
			parameters[20].Value = model.n_AttachCounts;
			parameters[21].Value = model.s_FolderID;
			parameters[22].Value = model.s_Abstact;
			parameters[23].Value = model.n_EmailID;
			parameters[24].Value = model.n_EmailClass;
			parameters[25].Value = model.n_UserID;

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
		public bool Delete(int n_EmailID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Email ");
			strSql.Append(" where n_EmailID=@n_EmailID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_EmailID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_EmailID;

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
		public bool Delete(int n_EmailClass,int n_UserID,int n_EmailID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Email ");
			strSql.Append(" where n_EmailClass=@n_EmailClass and n_UserID=@n_UserID and n_EmailID=@n_EmailID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_EmailClass", SqlDbType.Int,4),
					new SqlParameter("@n_UserID", SqlDbType.Int,4),
					new SqlParameter("@n_EmailID", SqlDbType.Int,4)			};
			parameters[0].Value = n_EmailClass;
			parameters[1].Value = n_UserID;
			parameters[2].Value = n_EmailID;

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
		public bool DeleteList(string n_EmailIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Email ");
			strSql.Append(" where n_EmailID in ("+n_EmailIDlist + ")  ");
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
		public IPSP.Model.T_Email GetModel(int n_EmailID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_EmailID,s_EmailPath,s_From,s_To,s_Cc,s_Bc,s_Subject,s_EmailBody,dt_SendTime,dt_ReceiveTime,s_Type,n_EmailClass,s_Important,dt_CreateDate,dt_EditDate,s_IO,s_ReadMark,n_UserID,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,n_MainCaseID,n_AttachCounts,s_FolderID,s_Abstact from T_Email ");
			strSql.Append(" where n_EmailID=@n_EmailID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_EmailID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_EmailID;

			IPSP.Model.T_Email model=new IPSP.Model.T_Email();
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
		public IPSP.Model.T_Email DataRowToModel(DataRow row)
		{
			IPSP.Model.T_Email model=new IPSP.Model.T_Email();
			if (row != null)
			{
				if(row["n_EmailID"]!=null && row["n_EmailID"].ToString()!="")
				{
					model.n_EmailID=int.Parse(row["n_EmailID"].ToString());
				}
				if(row["s_EmailPath"]!=null)
				{
					model.s_EmailPath=row["s_EmailPath"].ToString();
				}
				if(row["s_From"]!=null)
				{
					model.s_From=row["s_From"].ToString();
				}
				if(row["s_To"]!=null)
				{
					model.s_To=row["s_To"].ToString();
				}
				if(row["s_Cc"]!=null)
				{
					model.s_Cc=row["s_Cc"].ToString();
				}
				if(row["s_Bc"]!=null)
				{
					model.s_Bc=row["s_Bc"].ToString();
				}
				if(row["s_Subject"]!=null)
				{
					model.s_Subject=row["s_Subject"].ToString();
				}
				if(row["s_EmailBody"]!=null && row["s_EmailBody"].ToString()!="")
				{
					model.s_EmailBody=(byte[])row["s_EmailBody"];
				}
				if(row["dt_SendTime"]!=null && row["dt_SendTime"].ToString()!="")
				{
					model.dt_SendTime=DateTime.Parse(row["dt_SendTime"].ToString());
				}
				if(row["dt_ReceiveTime"]!=null && row["dt_ReceiveTime"].ToString()!="")
				{
					model.dt_ReceiveTime=DateTime.Parse(row["dt_ReceiveTime"].ToString());
				}
				if(row["s_Type"]!=null)
				{
					model.s_Type=row["s_Type"].ToString();
				}
				if(row["n_EmailClass"]!=null && row["n_EmailClass"].ToString()!="")
				{
					model.n_EmailClass=int.Parse(row["n_EmailClass"].ToString());
				}
				if(row["s_Important"]!=null)
				{
					model.s_Important=row["s_Important"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_IO"]!=null)
				{
					model.s_IO=row["s_IO"].ToString();
				}
				if(row["s_ReadMark"]!=null)
				{
					model.s_ReadMark=row["s_ReadMark"].ToString();
				}
				if(row["n_UserID"]!=null && row["n_UserID"].ToString()!="")
				{
					model.n_UserID=int.Parse(row["n_UserID"].ToString());
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
				if(row["n_AttachCounts"]!=null && row["n_AttachCounts"].ToString()!="")
				{
					model.n_AttachCounts=int.Parse(row["n_AttachCounts"].ToString());
				}
				if(row["s_FolderID"]!=null)
				{
					model.s_FolderID=row["s_FolderID"].ToString();
				}
				if(row["s_Abstact"]!=null)
				{
					model.s_Abstact=row["s_Abstact"].ToString();
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
			strSql.Append("select n_EmailID,s_EmailPath,s_From,s_To,s_Cc,s_Bc,s_Subject,s_EmailBody,dt_SendTime,dt_ReceiveTime,s_Type,n_EmailClass,s_Important,dt_CreateDate,dt_EditDate,s_IO,s_ReadMark,n_UserID,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,n_MainCaseID,n_AttachCounts,s_FolderID,s_Abstact ");
			strSql.Append(" FROM T_Email ");
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
			strSql.Append(" n_EmailID,s_EmailPath,s_From,s_To,s_Cc,s_Bc,s_Subject,s_EmailBody,dt_SendTime,dt_ReceiveTime,s_Type,n_EmailClass,s_Important,dt_CreateDate,dt_EditDate,s_IO,s_ReadMark,n_UserID,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID,n_MainCaseID,n_AttachCounts,s_FolderID,s_Abstact ");
			strSql.Append(" FROM T_Email ");
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
			strSql.Append("select count(1) FROM T_Email ");
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
				strSql.Append("order by T.n_EmailID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Email T ");
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
			parameters[0].Value = "T_Email";
			parameters[1].Value = "n_EmailID";
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

