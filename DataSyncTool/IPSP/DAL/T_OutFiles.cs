/**  版本信息模板在安装目录下，可自行修改。
* T_OutFiles.cs
*
* 功 能： N/A
* 类 名： T_OutFiles
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:58   N/A    初版
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
	/// 数据访问类:T_OutFiles
	/// </summary>
	public partial class T_OutFiles
	{
		public T_OutFiles()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_FileID", "T_OutFiles"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_FileID,int n_ClientID,int n_AgencyID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_OutFiles");
			strSql.Append(" where n_FileID=@n_FileID and n_ClientID=@n_ClientID and n_AgencyID=@n_AgencyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;
			parameters[1].Value = n_ClientID;
			parameters[2].Value = n_AgencyID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.T_OutFiles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_OutFiles(");
			strSql.Append("n_FileID,s_Version,s_CheckedOut,n_CheckedOutBy,s_CheckedOutPath,n_ClientID,n_GovOfficeID,s_FileStatus,dt_StatusDate,dt_WriteDate,n_WriterID,dt_SubmitDate,n_SubmiterID,dt_SubmitDueDate,s_OfficialCode,n_PrintNum,n_PageNum,s_Writer,s_Submiter,n_FileListID,n_ReFileID,s_ElectronicCode,n_Count,s_FileType,n_AgencyID,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID)");
			strSql.Append(" values (");
			strSql.Append("@n_FileID,@s_Version,@s_CheckedOut,@n_CheckedOutBy,@s_CheckedOutPath,@n_ClientID,@n_GovOfficeID,@s_FileStatus,@dt_StatusDate,@dt_WriteDate,@n_WriterID,@dt_SubmitDate,@n_SubmiterID,@dt_SubmitDueDate,@s_OfficialCode,@n_PrintNum,@n_PageNum,@s_Writer,@s_Submiter,@n_FileListID,@n_ReFileID,@s_ElectronicCode,@n_Count,@s_FileType,@n_AgencyID,@n_ModuleCheckStatusID,@n_LatestCheckInfoID,@n_AuthorID,@n_CurCheckerID)");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@s_Version", SqlDbType.NVarChar,20),
					new SqlParameter("@s_CheckedOut", SqlDbType.NVarChar,1),
					new SqlParameter("@n_CheckedOutBy", SqlDbType.Int,4),
					new SqlParameter("@s_CheckedOutPath", SqlDbType.NVarChar,500),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_GovOfficeID", SqlDbType.Int,4),
					new SqlParameter("@s_FileStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_StatusDate", SqlDbType.DateTime),
					new SqlParameter("@dt_WriteDate", SqlDbType.DateTime),
					new SqlParameter("@n_WriterID", SqlDbType.Int,4),
					new SqlParameter("@dt_SubmitDate", SqlDbType.DateTime),
					new SqlParameter("@n_SubmiterID", SqlDbType.Int,4),
					new SqlParameter("@dt_SubmitDueDate", SqlDbType.DateTime),
					new SqlParameter("@s_OfficialCode", SqlDbType.NVarChar,50),
					new SqlParameter("@n_PrintNum", SqlDbType.Int,4),
					new SqlParameter("@n_PageNum", SqlDbType.Int,4),
					new SqlParameter("@s_Writer", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Submiter", SqlDbType.NVarChar,50),
					new SqlParameter("@n_FileListID", SqlDbType.Int,4),
					new SqlParameter("@n_ReFileID", SqlDbType.Int,4),
					new SqlParameter("@s_ElectronicCode", SqlDbType.NVarChar,20),
					new SqlParameter("@n_Count", SqlDbType.Int,4),
					new SqlParameter("@s_FileType", SqlDbType.NVarChar,10),
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4),
					new SqlParameter("@n_ModuleCheckStatusID", SqlDbType.Int,4),
					new SqlParameter("@n_LatestCheckInfoID", SqlDbType.Int,4),
					new SqlParameter("@n_AuthorID", SqlDbType.Int,4),
					new SqlParameter("@n_CurCheckerID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_FileID;
			parameters[1].Value = model.s_Version;
			parameters[2].Value = model.s_CheckedOut;
			parameters[3].Value = model.n_CheckedOutBy;
			parameters[4].Value = model.s_CheckedOutPath;
			parameters[5].Value = model.n_ClientID;
			parameters[6].Value = model.n_GovOfficeID;
			parameters[7].Value = model.s_FileStatus;
			parameters[8].Value = model.dt_StatusDate;
			parameters[9].Value = model.dt_WriteDate;
			parameters[10].Value = model.n_WriterID;
			parameters[11].Value = model.dt_SubmitDate;
			parameters[12].Value = model.n_SubmiterID;
			parameters[13].Value = model.dt_SubmitDueDate;
			parameters[14].Value = model.s_OfficialCode;
			parameters[15].Value = model.n_PrintNum;
			parameters[16].Value = model.n_PageNum;
			parameters[17].Value = model.s_Writer;
			parameters[18].Value = model.s_Submiter;
			parameters[19].Value = model.n_FileListID;
			parameters[20].Value = model.n_ReFileID;
			parameters[21].Value = model.s_ElectronicCode;
			parameters[22].Value = model.n_Count;
			parameters[23].Value = model.s_FileType;
			parameters[24].Value = model.n_AgencyID;
			parameters[25].Value = model.n_ModuleCheckStatusID;
			parameters[26].Value = model.n_LatestCheckInfoID;
			parameters[27].Value = model.n_AuthorID;
			parameters[28].Value = model.n_CurCheckerID;

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
		public bool Update(IPSP.Model.T_OutFiles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_OutFiles set ");
			strSql.Append("s_Version=@s_Version,");
			strSql.Append("s_CheckedOut=@s_CheckedOut,");
			strSql.Append("n_CheckedOutBy=@n_CheckedOutBy,");
			strSql.Append("s_CheckedOutPath=@s_CheckedOutPath,");
			strSql.Append("n_GovOfficeID=@n_GovOfficeID,");
			strSql.Append("s_FileStatus=@s_FileStatus,");
			strSql.Append("dt_StatusDate=@dt_StatusDate,");
			strSql.Append("dt_WriteDate=@dt_WriteDate,");
			strSql.Append("n_WriterID=@n_WriterID,");
			strSql.Append("dt_SubmitDate=@dt_SubmitDate,");
			strSql.Append("n_SubmiterID=@n_SubmiterID,");
			strSql.Append("dt_SubmitDueDate=@dt_SubmitDueDate,");
			strSql.Append("s_OfficialCode=@s_OfficialCode,");
			strSql.Append("n_PrintNum=@n_PrintNum,");
			strSql.Append("n_PageNum=@n_PageNum,");
			strSql.Append("s_Writer=@s_Writer,");
			strSql.Append("s_Submiter=@s_Submiter,");
			strSql.Append("n_FileListID=@n_FileListID,");
			strSql.Append("n_ReFileID=@n_ReFileID,");
			strSql.Append("s_ElectronicCode=@s_ElectronicCode,");
			strSql.Append("n_Count=@n_Count,");
			strSql.Append("s_FileType=@s_FileType,");
			strSql.Append("n_ModuleCheckStatusID=@n_ModuleCheckStatusID,");
			strSql.Append("n_LatestCheckInfoID=@n_LatestCheckInfoID,");
			strSql.Append("n_AuthorID=@n_AuthorID,");
			strSql.Append("n_CurCheckerID=@n_CurCheckerID");
			strSql.Append(" where n_FileID=@n_FileID and n_ClientID=@n_ClientID and n_AgencyID=@n_AgencyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Version", SqlDbType.NVarChar,20),
					new SqlParameter("@s_CheckedOut", SqlDbType.NVarChar,1),
					new SqlParameter("@n_CheckedOutBy", SqlDbType.Int,4),
					new SqlParameter("@s_CheckedOutPath", SqlDbType.NVarChar,500),
					new SqlParameter("@n_GovOfficeID", SqlDbType.Int,4),
					new SqlParameter("@s_FileStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_StatusDate", SqlDbType.DateTime),
					new SqlParameter("@dt_WriteDate", SqlDbType.DateTime),
					new SqlParameter("@n_WriterID", SqlDbType.Int,4),
					new SqlParameter("@dt_SubmitDate", SqlDbType.DateTime),
					new SqlParameter("@n_SubmiterID", SqlDbType.Int,4),
					new SqlParameter("@dt_SubmitDueDate", SqlDbType.DateTime),
					new SqlParameter("@s_OfficialCode", SqlDbType.NVarChar,50),
					new SqlParameter("@n_PrintNum", SqlDbType.Int,4),
					new SqlParameter("@n_PageNum", SqlDbType.Int,4),
					new SqlParameter("@s_Writer", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Submiter", SqlDbType.NVarChar,50),
					new SqlParameter("@n_FileListID", SqlDbType.Int,4),
					new SqlParameter("@n_ReFileID", SqlDbType.Int,4),
					new SqlParameter("@s_ElectronicCode", SqlDbType.NVarChar,20),
					new SqlParameter("@n_Count", SqlDbType.Int,4),
					new SqlParameter("@s_FileType", SqlDbType.NVarChar,10),
					new SqlParameter("@n_ModuleCheckStatusID", SqlDbType.Int,4),
					new SqlParameter("@n_LatestCheckInfoID", SqlDbType.Int,4),
					new SqlParameter("@n_AuthorID", SqlDbType.Int,4),
					new SqlParameter("@n_CurCheckerID", SqlDbType.Int,4),
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Version;
			parameters[1].Value = model.s_CheckedOut;
			parameters[2].Value = model.n_CheckedOutBy;
			parameters[3].Value = model.s_CheckedOutPath;
			parameters[4].Value = model.n_GovOfficeID;
			parameters[5].Value = model.s_FileStatus;
			parameters[6].Value = model.dt_StatusDate;
			parameters[7].Value = model.dt_WriteDate;
			parameters[8].Value = model.n_WriterID;
			parameters[9].Value = model.dt_SubmitDate;
			parameters[10].Value = model.n_SubmiterID;
			parameters[11].Value = model.dt_SubmitDueDate;
			parameters[12].Value = model.s_OfficialCode;
			parameters[13].Value = model.n_PrintNum;
			parameters[14].Value = model.n_PageNum;
			parameters[15].Value = model.s_Writer;
			parameters[16].Value = model.s_Submiter;
			parameters[17].Value = model.n_FileListID;
			parameters[18].Value = model.n_ReFileID;
			parameters[19].Value = model.s_ElectronicCode;
			parameters[20].Value = model.n_Count;
			parameters[21].Value = model.s_FileType;
			parameters[22].Value = model.n_ModuleCheckStatusID;
			parameters[23].Value = model.n_LatestCheckInfoID;
			parameters[24].Value = model.n_AuthorID;
			parameters[25].Value = model.n_CurCheckerID;
			parameters[26].Value = model.n_FileID;
			parameters[27].Value = model.n_ClientID;
			parameters[28].Value = model.n_AgencyID;

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
		public bool Delete(int n_FileID,int n_ClientID,int n_AgencyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_OutFiles ");
			strSql.Append(" where n_FileID=@n_FileID and n_ClientID=@n_ClientID and n_AgencyID=@n_AgencyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;
			parameters[1].Value = n_ClientID;
			parameters[2].Value = n_AgencyID;

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
		/// 得到一个对象实体
		/// </summary>
		public IPSP.Model.T_OutFiles GetModel(int n_FileID,int n_ClientID,int n_AgencyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_FileID,s_Version,s_CheckedOut,n_CheckedOutBy,s_CheckedOutPath,n_ClientID,n_GovOfficeID,s_FileStatus,dt_StatusDate,dt_WriteDate,n_WriterID,dt_SubmitDate,n_SubmiterID,dt_SubmitDueDate,s_OfficialCode,n_PrintNum,n_PageNum,s_Writer,s_Submiter,n_FileListID,n_ReFileID,s_ElectronicCode,n_Count,s_FileType,n_AgencyID,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID from T_OutFiles ");
			strSql.Append(" where n_FileID=@n_FileID and n_ClientID=@n_ClientID and n_AgencyID=@n_AgencyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;
			parameters[1].Value = n_ClientID;
			parameters[2].Value = n_AgencyID;

			IPSP.Model.T_OutFiles model=new IPSP.Model.T_OutFiles();
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
		public IPSP.Model.T_OutFiles DataRowToModel(DataRow row)
		{
			IPSP.Model.T_OutFiles model=new IPSP.Model.T_OutFiles();
			if (row != null)
			{
				if(row["n_FileID"]!=null && row["n_FileID"].ToString()!="")
				{
					model.n_FileID=int.Parse(row["n_FileID"].ToString());
				}
				if(row["s_Version"]!=null)
				{
					model.s_Version=row["s_Version"].ToString();
				}
				if(row["s_CheckedOut"]!=null)
				{
					model.s_CheckedOut=row["s_CheckedOut"].ToString();
				}
				if(row["n_CheckedOutBy"]!=null && row["n_CheckedOutBy"].ToString()!="")
				{
					model.n_CheckedOutBy=int.Parse(row["n_CheckedOutBy"].ToString());
				}
				if(row["s_CheckedOutPath"]!=null)
				{
					model.s_CheckedOutPath=row["s_CheckedOutPath"].ToString();
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["n_GovOfficeID"]!=null && row["n_GovOfficeID"].ToString()!="")
				{
					model.n_GovOfficeID=int.Parse(row["n_GovOfficeID"].ToString());
				}
				if(row["s_FileStatus"]!=null)
				{
					model.s_FileStatus=row["s_FileStatus"].ToString();
				}
				if(row["dt_StatusDate"]!=null && row["dt_StatusDate"].ToString()!="")
				{
					model.dt_StatusDate=DateTime.Parse(row["dt_StatusDate"].ToString());
				}
				if(row["dt_WriteDate"]!=null && row["dt_WriteDate"].ToString()!="")
				{
					model.dt_WriteDate=DateTime.Parse(row["dt_WriteDate"].ToString());
				}
				if(row["n_WriterID"]!=null && row["n_WriterID"].ToString()!="")
				{
					model.n_WriterID=int.Parse(row["n_WriterID"].ToString());
				}
				if(row["dt_SubmitDate"]!=null && row["dt_SubmitDate"].ToString()!="")
				{
					model.dt_SubmitDate=DateTime.Parse(row["dt_SubmitDate"].ToString());
				}
				if(row["n_SubmiterID"]!=null && row["n_SubmiterID"].ToString()!="")
				{
					model.n_SubmiterID=int.Parse(row["n_SubmiterID"].ToString());
				}
				if(row["dt_SubmitDueDate"]!=null && row["dt_SubmitDueDate"].ToString()!="")
				{
					model.dt_SubmitDueDate=DateTime.Parse(row["dt_SubmitDueDate"].ToString());
				}
				if(row["s_OfficialCode"]!=null)
				{
					model.s_OfficialCode=row["s_OfficialCode"].ToString();
				}
				if(row["n_PrintNum"]!=null && row["n_PrintNum"].ToString()!="")
				{
					model.n_PrintNum=int.Parse(row["n_PrintNum"].ToString());
				}
				if(row["n_PageNum"]!=null && row["n_PageNum"].ToString()!="")
				{
					model.n_PageNum=int.Parse(row["n_PageNum"].ToString());
				}
				if(row["s_Writer"]!=null)
				{
					model.s_Writer=row["s_Writer"].ToString();
				}
				if(row["s_Submiter"]!=null)
				{
					model.s_Submiter=row["s_Submiter"].ToString();
				}
				if(row["n_FileListID"]!=null && row["n_FileListID"].ToString()!="")
				{
					model.n_FileListID=int.Parse(row["n_FileListID"].ToString());
				}
				if(row["n_ReFileID"]!=null && row["n_ReFileID"].ToString()!="")
				{
					model.n_ReFileID=int.Parse(row["n_ReFileID"].ToString());
				}
				if(row["s_ElectronicCode"]!=null)
				{
					model.s_ElectronicCode=row["s_ElectronicCode"].ToString();
				}
				if(row["n_Count"]!=null && row["n_Count"].ToString()!="")
				{
					model.n_Count=int.Parse(row["n_Count"].ToString());
				}
				if(row["s_FileType"]!=null)
				{
					model.s_FileType=row["s_FileType"].ToString();
				}
				if(row["n_AgencyID"]!=null && row["n_AgencyID"].ToString()!="")
				{
					model.n_AgencyID=int.Parse(row["n_AgencyID"].ToString());
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select n_FileID,s_Version,s_CheckedOut,n_CheckedOutBy,s_CheckedOutPath,n_ClientID,n_GovOfficeID,s_FileStatus,dt_StatusDate,dt_WriteDate,n_WriterID,dt_SubmitDate,n_SubmiterID,dt_SubmitDueDate,s_OfficialCode,n_PrintNum,n_PageNum,s_Writer,s_Submiter,n_FileListID,n_ReFileID,s_ElectronicCode,n_Count,s_FileType,n_AgencyID,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID ");
			strSql.Append(" FROM T_OutFiles ");
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
			strSql.Append(" n_FileID,s_Version,s_CheckedOut,n_CheckedOutBy,s_CheckedOutPath,n_ClientID,n_GovOfficeID,s_FileStatus,dt_StatusDate,dt_WriteDate,n_WriterID,dt_SubmitDate,n_SubmiterID,dt_SubmitDueDate,s_OfficialCode,n_PrintNum,n_PageNum,s_Writer,s_Submiter,n_FileListID,n_ReFileID,s_ElectronicCode,n_Count,s_FileType,n_AgencyID,n_ModuleCheckStatusID,n_LatestCheckInfoID,n_AuthorID,n_CurCheckerID ");
			strSql.Append(" FROM T_OutFiles ");
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
			strSql.Append("select count(1) FROM T_OutFiles ");
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
				strSql.Append("order by T.n_AgencyID desc");
			}
			strSql.Append(")AS Row, T.*  from T_OutFiles T ");
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
			parameters[0].Value = "T_OutFiles";
			parameters[1].Value = "n_AgencyID";
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

