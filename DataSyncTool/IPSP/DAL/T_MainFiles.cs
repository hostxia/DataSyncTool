/**  版本信息模板在安装目录下，可自行修改。
* T_MainFiles.cs
*
* 功 能： N/A
* 类 名： T_MainFiles
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:55   N/A    初版
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
	/// 数据访问类:T_MainFiles
	/// </summary>
	public partial class T_MainFiles
	{
		public T_MainFiles()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ObjectType", "T_MainFiles"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ObjectType,int n_ClientID,int n_ApplicantID,int n_FileClientID,int n_FileApplicantID,int n_FileID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_MainFiles");
			strSql.Append(" where ObjectType=@ObjectType and n_ClientID=@n_ClientID and n_ApplicantID=@n_ApplicantID and n_FileClientID=@n_FileClientID and n_FileApplicantID=@n_FileApplicantID and n_FileID=@n_FileID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ApplicantID", SqlDbType.Int,4),
					new SqlParameter("@n_FileClientID", SqlDbType.Int,4),
					new SqlParameter("@n_FileApplicantID", SqlDbType.Int,4),
					new SqlParameter("@n_FileID", SqlDbType.Int,4)			};
			parameters[0].Value = ObjectType;
			parameters[1].Value = n_ClientID;
			parameters[2].Value = n_ApplicantID;
			parameters[3].Value = n_FileClientID;
			parameters[4].Value = n_FileApplicantID;
			parameters[5].Value = n_FileID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_MainFiles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_MainFiles(");
			strSql.Append("s_SendMethod,s_Name,s_Abstact,s_FilePathName,s_IOType,s_ClientGov,n_ProcessID,dt_SendDate,dt_ReceiveDate,dt_CreateDate,dt_EditDate,ObjectType,s_IsActive,n_TemplateID,dt_AppDate,s_PubNo,dt_PubDate,s_CaseSerial,s_AppNo,s_Applicants,s_Introducer,s_Inventors,s_Attorney,s_Creator,s_Editor,n_MainCaseID,s_Status,n_FlowNum,s_InfileFlowNum,s_IsNewCaseInFile,n_NumCount,n_PicCount,s_From,s_To,s_Cc,s_Bc,n_ClientID,s_IPType,n_ApplicantID,n_CreatorID,n_FileClientID,n_FileApplicantID,s_NameForeign,s_ClientType,s_ManualCreateChain,s_sourcetype1)");
			strSql.Append(" values (");
			strSql.Append("@s_SendMethod,@s_Name,@s_Abstact,@s_FilePathName,@s_IOType,@s_ClientGov,@n_ProcessID,@dt_SendDate,@dt_ReceiveDate,@dt_CreateDate,@dt_EditDate,@ObjectType,@s_IsActive,@n_TemplateID,@dt_AppDate,@s_PubNo,@dt_PubDate,@s_CaseSerial,@s_AppNo,@s_Applicants,@s_Introducer,@s_Inventors,@s_Attorney,@s_Creator,@s_Editor,@n_MainCaseID,@s_Status,@n_FlowNum,@s_InfileFlowNum,@s_IsNewCaseInFile,@n_NumCount,@n_PicCount,@s_From,@s_To,@s_Cc,@s_Bc,@n_ClientID,@s_IPType,@n_ApplicantID,@n_CreatorID,@n_FileClientID,@n_FileApplicantID,@s_NameForeign,@s_ClientType,@s_ManualCreateChain,@s_sourcetype1)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_SendMethod", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,400),
					new SqlParameter("@s_Abstact", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_FilePathName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_IOType", SqlDbType.NVarChar,10),
					new SqlParameter("@s_ClientGov", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ProcessID", SqlDbType.Int,4),
					new SqlParameter("@dt_SendDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ReceiveDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@n_TemplateID", SqlDbType.Int,4),
					new SqlParameter("@dt_AppDate", SqlDbType.DateTime),
					new SqlParameter("@s_PubNo", SqlDbType.VarChar,50),
					new SqlParameter("@dt_PubDate", SqlDbType.DateTime),
					new SqlParameter("@s_CaseSerial", SqlDbType.VarChar,100),
					new SqlParameter("@s_AppNo", SqlDbType.VarChar,100),
					new SqlParameter("@s_Applicants", SqlDbType.VarChar,1000),
					new SqlParameter("@s_Introducer", SqlDbType.VarChar,300),
					new SqlParameter("@s_Inventors", SqlDbType.VarChar,1000),
					new SqlParameter("@s_Attorney", SqlDbType.VarChar,200),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,100),
					new SqlParameter("@n_FlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_InfileFlowNum", SqlDbType.NVarChar,100),
					new SqlParameter("@s_IsNewCaseInFile", SqlDbType.NVarChar,100),
					new SqlParameter("@n_NumCount", SqlDbType.Int,4),
					new SqlParameter("@n_PicCount", SqlDbType.Int,4),
					new SqlParameter("@s_From", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_To", SqlDbType.NVarChar,3000),
					new SqlParameter("@s_Cc", SqlDbType.NVarChar,3000),
					new SqlParameter("@s_Bc", SqlDbType.NVarChar,3000),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ApplicantID", SqlDbType.Int,4),
					new SqlParameter("@n_CreatorID", SqlDbType.Int,4),
					new SqlParameter("@n_FileClientID", SqlDbType.Int,4),
					new SqlParameter("@n_FileApplicantID", SqlDbType.Int,4),
					new SqlParameter("@s_NameForeign", SqlDbType.NVarChar,400),
					new SqlParameter("@s_ClientType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ManualCreateChain", SqlDbType.NVarChar,1),
					new SqlParameter("@s_sourcetype1", SqlDbType.VarChar,500)};
			parameters[0].Value = model.s_SendMethod;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_Abstact;
			parameters[3].Value = model.s_FilePathName;
			parameters[4].Value = model.s_IOType;
			parameters[5].Value = model.s_ClientGov;
			parameters[6].Value = model.n_ProcessID;
			parameters[7].Value = model.dt_SendDate;
			parameters[8].Value = model.dt_ReceiveDate;
			parameters[9].Value = model.dt_CreateDate;
			parameters[10].Value = model.dt_EditDate;
			parameters[11].Value = model.ObjectType;
			parameters[12].Value = model.s_IsActive;
			parameters[13].Value = model.n_TemplateID;
			parameters[14].Value = model.dt_AppDate;
			parameters[15].Value = model.s_PubNo;
			parameters[16].Value = model.dt_PubDate;
			parameters[17].Value = model.s_CaseSerial;
			parameters[18].Value = model.s_AppNo;
			parameters[19].Value = model.s_Applicants;
			parameters[20].Value = model.s_Introducer;
			parameters[21].Value = model.s_Inventors;
			parameters[22].Value = model.s_Attorney;
			parameters[23].Value = model.s_Creator;
			parameters[24].Value = model.s_Editor;
			parameters[25].Value = model.n_MainCaseID;
			parameters[26].Value = model.s_Status;
			parameters[27].Value = model.n_FlowNum;
			parameters[28].Value = model.s_InfileFlowNum;
			parameters[29].Value = model.s_IsNewCaseInFile;
			parameters[30].Value = model.n_NumCount;
			parameters[31].Value = model.n_PicCount;
			parameters[32].Value = model.s_From;
			parameters[33].Value = model.s_To;
			parameters[34].Value = model.s_Cc;
			parameters[35].Value = model.s_Bc;
			parameters[36].Value = model.n_ClientID;
			parameters[37].Value = model.s_IPType;
			parameters[38].Value = model.n_ApplicantID;
			parameters[39].Value = model.n_CreatorID;
			parameters[40].Value = model.n_FileClientID;
			parameters[41].Value = model.n_FileApplicantID;
			parameters[42].Value = model.s_NameForeign;
			parameters[43].Value = model.s_ClientType;
			parameters[44].Value = model.s_ManualCreateChain;
			parameters[45].Value = model.s_sourcetype1;

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
		public bool Update(IPSP.Model.T_MainFiles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_MainFiles set ");
			strSql.Append("s_SendMethod=@s_SendMethod,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_Abstact=@s_Abstact,");
			strSql.Append("s_FilePathName=@s_FilePathName,");
			strSql.Append("s_IOType=@s_IOType,");
			strSql.Append("s_ClientGov=@s_ClientGov,");
			strSql.Append("n_ProcessID=@n_ProcessID,");
			strSql.Append("dt_SendDate=@dt_SendDate,");
			strSql.Append("dt_ReceiveDate=@dt_ReceiveDate,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_IsActive=@s_IsActive,");
			strSql.Append("n_TemplateID=@n_TemplateID,");
			strSql.Append("dt_AppDate=@dt_AppDate,");
			strSql.Append("s_PubNo=@s_PubNo,");
			strSql.Append("dt_PubDate=@dt_PubDate,");
			strSql.Append("s_CaseSerial=@s_CaseSerial,");
			strSql.Append("s_AppNo=@s_AppNo,");
			strSql.Append("s_Applicants=@s_Applicants,");
			strSql.Append("s_Introducer=@s_Introducer,");
			strSql.Append("s_Inventors=@s_Inventors,");
			strSql.Append("s_Attorney=@s_Attorney,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("n_MainCaseID=@n_MainCaseID,");
			strSql.Append("s_Status=@s_Status,");
			strSql.Append("n_FlowNum=@n_FlowNum,");
			strSql.Append("s_InfileFlowNum=@s_InfileFlowNum,");
			strSql.Append("s_IsNewCaseInFile=@s_IsNewCaseInFile,");
			strSql.Append("n_NumCount=@n_NumCount,");
			strSql.Append("n_PicCount=@n_PicCount,");
			strSql.Append("s_From=@s_From,");
			strSql.Append("s_To=@s_To,");
			strSql.Append("s_Cc=@s_Cc,");
			strSql.Append("s_Bc=@s_Bc,");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("n_CreatorID=@n_CreatorID,");
			strSql.Append("s_NameForeign=@s_NameForeign,");
			strSql.Append("s_ClientType=@s_ClientType,");
			strSql.Append("s_ManualCreateChain=@s_ManualCreateChain,");
			strSql.Append("s_sourcetype1=@s_sourcetype1");
			strSql.Append(" where n_FileID=@n_FileID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_SendMethod", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,400),
					new SqlParameter("@s_Abstact", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_FilePathName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_IOType", SqlDbType.NVarChar,10),
					new SqlParameter("@s_ClientGov", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ProcessID", SqlDbType.Int,4),
					new SqlParameter("@dt_SendDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ReceiveDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IsActive", SqlDbType.NVarChar,1),
					new SqlParameter("@n_TemplateID", SqlDbType.Int,4),
					new SqlParameter("@dt_AppDate", SqlDbType.DateTime),
					new SqlParameter("@s_PubNo", SqlDbType.VarChar,50),
					new SqlParameter("@dt_PubDate", SqlDbType.DateTime),
					new SqlParameter("@s_CaseSerial", SqlDbType.VarChar,100),
					new SqlParameter("@s_AppNo", SqlDbType.VarChar,100),
					new SqlParameter("@s_Applicants", SqlDbType.VarChar,1000),
					new SqlParameter("@s_Introducer", SqlDbType.VarChar,300),
					new SqlParameter("@s_Inventors", SqlDbType.VarChar,1000),
					new SqlParameter("@s_Attorney", SqlDbType.VarChar,200),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@n_MainCaseID", SqlDbType.Int,4),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,100),
					new SqlParameter("@n_FlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_InfileFlowNum", SqlDbType.NVarChar,100),
					new SqlParameter("@s_IsNewCaseInFile", SqlDbType.NVarChar,100),
					new SqlParameter("@n_NumCount", SqlDbType.Int,4),
					new SqlParameter("@n_PicCount", SqlDbType.Int,4),
					new SqlParameter("@s_From", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_To", SqlDbType.NVarChar,3000),
					new SqlParameter("@s_Cc", SqlDbType.NVarChar,3000),
					new SqlParameter("@s_Bc", SqlDbType.NVarChar,3000),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_CreatorID", SqlDbType.Int,4),
					new SqlParameter("@s_NameForeign", SqlDbType.NVarChar,400),
					new SqlParameter("@s_ClientType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ManualCreateChain", SqlDbType.NVarChar,1),
					new SqlParameter("@s_sourcetype1", SqlDbType.VarChar,500),
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ApplicantID", SqlDbType.Int,4),
					new SqlParameter("@n_FileClientID", SqlDbType.Int,4),
					new SqlParameter("@n_FileApplicantID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_SendMethod;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_Abstact;
			parameters[3].Value = model.s_FilePathName;
			parameters[4].Value = model.s_IOType;
			parameters[5].Value = model.s_ClientGov;
			parameters[6].Value = model.n_ProcessID;
			parameters[7].Value = model.dt_SendDate;
			parameters[8].Value = model.dt_ReceiveDate;
			parameters[9].Value = model.dt_CreateDate;
			parameters[10].Value = model.dt_EditDate;
			parameters[11].Value = model.s_IsActive;
			parameters[12].Value = model.n_TemplateID;
			parameters[13].Value = model.dt_AppDate;
			parameters[14].Value = model.s_PubNo;
			parameters[15].Value = model.dt_PubDate;
			parameters[16].Value = model.s_CaseSerial;
			parameters[17].Value = model.s_AppNo;
			parameters[18].Value = model.s_Applicants;
			parameters[19].Value = model.s_Introducer;
			parameters[20].Value = model.s_Inventors;
			parameters[21].Value = model.s_Attorney;
			parameters[22].Value = model.s_Creator;
			parameters[23].Value = model.s_Editor;
			parameters[24].Value = model.n_MainCaseID;
			parameters[25].Value = model.s_Status;
			parameters[26].Value = model.n_FlowNum;
			parameters[27].Value = model.s_InfileFlowNum;
			parameters[28].Value = model.s_IsNewCaseInFile;
			parameters[29].Value = model.n_NumCount;
			parameters[30].Value = model.n_PicCount;
			parameters[31].Value = model.s_From;
			parameters[32].Value = model.s_To;
			parameters[33].Value = model.s_Cc;
			parameters[34].Value = model.s_Bc;
			parameters[35].Value = model.s_IPType;
			parameters[36].Value = model.n_CreatorID;
			parameters[37].Value = model.s_NameForeign;
			parameters[38].Value = model.s_ClientType;
			parameters[39].Value = model.s_ManualCreateChain;
			parameters[40].Value = model.s_sourcetype1;
			parameters[41].Value = model.n_FileID;
			parameters[42].Value = model.ObjectType;
			parameters[43].Value = model.n_ClientID;
			parameters[44].Value = model.n_ApplicantID;
			parameters[45].Value = model.n_FileClientID;
			parameters[46].Value = model.n_FileApplicantID;

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
		public bool Delete(int n_FileID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_MainFiles ");
			strSql.Append(" where n_FileID=@n_FileID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_FileID;

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
		public bool Delete(int ObjectType,int n_ClientID,int n_ApplicantID,int n_FileClientID,int n_FileApplicantID,int n_FileID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_MainFiles ");
			strSql.Append(" where ObjectType=@ObjectType and n_ClientID=@n_ClientID and n_ApplicantID=@n_ApplicantID and n_FileClientID=@n_FileClientID and n_FileApplicantID=@n_FileApplicantID and n_FileID=@n_FileID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ApplicantID", SqlDbType.Int,4),
					new SqlParameter("@n_FileClientID", SqlDbType.Int,4),
					new SqlParameter("@n_FileApplicantID", SqlDbType.Int,4),
					new SqlParameter("@n_FileID", SqlDbType.Int,4)			};
			parameters[0].Value = ObjectType;
			parameters[1].Value = n_ClientID;
			parameters[2].Value = n_ApplicantID;
			parameters[3].Value = n_FileClientID;
			parameters[4].Value = n_FileApplicantID;
			parameters[5].Value = n_FileID;

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
		public bool DeleteList(string n_FileIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_MainFiles ");
			strSql.Append(" where n_FileID in ("+n_FileIDlist + ")  ");
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
		public IPSP.Model.T_MainFiles GetModel(int n_FileID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_FileID,s_SendMethod,s_Name,s_Abstact,s_FilePathName,s_IOType,s_ClientGov,n_ProcessID,dt_SendDate,dt_ReceiveDate,dt_CreateDate,dt_EditDate,ObjectType,s_IsActive,n_TemplateID,dt_AppDate,s_PubNo,dt_PubDate,s_CaseSerial,s_AppNo,s_Applicants,s_Introducer,s_Inventors,s_Attorney,s_Creator,s_Editor,n_MainCaseID,s_Status,n_FlowNum,s_InfileFlowNum,s_IsNewCaseInFile,n_NumCount,n_PicCount,s_From,s_To,s_Cc,s_Bc,n_ClientID,s_IPType,n_ApplicantID,n_CreatorID,n_FileClientID,n_FileApplicantID,s_NameForeign,s_ClientType,s_ManualCreateChain,s_sourcetype1 from T_MainFiles ");
			strSql.Append(" where n_FileID=@n_FileID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_FileID;

			IPSP.Model.T_MainFiles model=new IPSP.Model.T_MainFiles();
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
		public IPSP.Model.T_MainFiles DataRowToModel(DataRow row)
		{
			IPSP.Model.T_MainFiles model=new IPSP.Model.T_MainFiles();
			if (row != null)
			{
				if(row["n_FileID"]!=null && row["n_FileID"].ToString()!="")
				{
					model.n_FileID=int.Parse(row["n_FileID"].ToString());
				}
				if(row["s_SendMethod"]!=null)
				{
					model.s_SendMethod=row["s_SendMethod"].ToString();
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_Abstact"]!=null)
				{
					model.s_Abstact=row["s_Abstact"].ToString();
				}
				if(row["s_FilePathName"]!=null)
				{
					model.s_FilePathName=row["s_FilePathName"].ToString();
				}
				if(row["s_IOType"]!=null)
				{
					model.s_IOType=row["s_IOType"].ToString();
				}
				if(row["s_ClientGov"]!=null)
				{
					model.s_ClientGov=row["s_ClientGov"].ToString();
				}
				if(row["n_ProcessID"]!=null && row["n_ProcessID"].ToString()!="")
				{
					model.n_ProcessID=int.Parse(row["n_ProcessID"].ToString());
				}
				if(row["dt_SendDate"]!=null && row["dt_SendDate"].ToString()!="")
				{
					model.dt_SendDate=DateTime.Parse(row["dt_SendDate"].ToString());
				}
				if(row["dt_ReceiveDate"]!=null && row["dt_ReceiveDate"].ToString()!="")
				{
					model.dt_ReceiveDate=DateTime.Parse(row["dt_ReceiveDate"].ToString());
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["ObjectType"]!=null && row["ObjectType"].ToString()!="")
				{
					model.ObjectType=int.Parse(row["ObjectType"].ToString());
				}
				if(row["s_IsActive"]!=null)
				{
					model.s_IsActive=row["s_IsActive"].ToString();
				}
				if(row["n_TemplateID"]!=null && row["n_TemplateID"].ToString()!="")
				{
					model.n_TemplateID=int.Parse(row["n_TemplateID"].ToString());
				}
				if(row["dt_AppDate"]!=null && row["dt_AppDate"].ToString()!="")
				{
					model.dt_AppDate=DateTime.Parse(row["dt_AppDate"].ToString());
				}
				if(row["s_PubNo"]!=null)
				{
					model.s_PubNo=row["s_PubNo"].ToString();
				}
				if(row["dt_PubDate"]!=null && row["dt_PubDate"].ToString()!="")
				{
					model.dt_PubDate=DateTime.Parse(row["dt_PubDate"].ToString());
				}
				if(row["s_CaseSerial"]!=null)
				{
					model.s_CaseSerial=row["s_CaseSerial"].ToString();
				}
				if(row["s_AppNo"]!=null)
				{
					model.s_AppNo=row["s_AppNo"].ToString();
				}
				if(row["s_Applicants"]!=null)
				{
					model.s_Applicants=row["s_Applicants"].ToString();
				}
				if(row["s_Introducer"]!=null)
				{
					model.s_Introducer=row["s_Introducer"].ToString();
				}
				if(row["s_Inventors"]!=null)
				{
					model.s_Inventors=row["s_Inventors"].ToString();
				}
				if(row["s_Attorney"]!=null)
				{
					model.s_Attorney=row["s_Attorney"].ToString();
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["n_MainCaseID"]!=null && row["n_MainCaseID"].ToString()!="")
				{
					model.n_MainCaseID=int.Parse(row["n_MainCaseID"].ToString());
				}
				if(row["s_Status"]!=null)
				{
					model.s_Status=row["s_Status"].ToString();
				}
				if(row["n_FlowNum"]!=null && row["n_FlowNum"].ToString()!="")
				{
					model.n_FlowNum=int.Parse(row["n_FlowNum"].ToString());
				}
				if(row["s_InfileFlowNum"]!=null)
				{
					model.s_InfileFlowNum=row["s_InfileFlowNum"].ToString();
				}
				if(row["s_IsNewCaseInFile"]!=null)
				{
					model.s_IsNewCaseInFile=row["s_IsNewCaseInFile"].ToString();
				}
				if(row["n_NumCount"]!=null && row["n_NumCount"].ToString()!="")
				{
					model.n_NumCount=int.Parse(row["n_NumCount"].ToString());
				}
				if(row["n_PicCount"]!=null && row["n_PicCount"].ToString()!="")
				{
					model.n_PicCount=int.Parse(row["n_PicCount"].ToString());
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
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["n_ApplicantID"]!=null && row["n_ApplicantID"].ToString()!="")
				{
					model.n_ApplicantID=int.Parse(row["n_ApplicantID"].ToString());
				}
				if(row["n_CreatorID"]!=null && row["n_CreatorID"].ToString()!="")
				{
					model.n_CreatorID=int.Parse(row["n_CreatorID"].ToString());
				}
				if(row["n_FileClientID"]!=null && row["n_FileClientID"].ToString()!="")
				{
					model.n_FileClientID=int.Parse(row["n_FileClientID"].ToString());
				}
				if(row["n_FileApplicantID"]!=null && row["n_FileApplicantID"].ToString()!="")
				{
					model.n_FileApplicantID=int.Parse(row["n_FileApplicantID"].ToString());
				}
				if(row["s_NameForeign"]!=null)
				{
					model.s_NameForeign=row["s_NameForeign"].ToString();
				}
				if(row["s_ClientType"]!=null)
				{
					model.s_ClientType=row["s_ClientType"].ToString();
				}
				if(row["s_ManualCreateChain"]!=null)
				{
					model.s_ManualCreateChain=row["s_ManualCreateChain"].ToString();
				}
				if(row["s_sourcetype1"]!=null)
				{
					model.s_sourcetype1=row["s_sourcetype1"].ToString();
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
			strSql.Append("select n_FileID,s_SendMethod,s_Name,s_Abstact,s_FilePathName,s_IOType,s_ClientGov,n_ProcessID,dt_SendDate,dt_ReceiveDate,dt_CreateDate,dt_EditDate,ObjectType,s_IsActive,n_TemplateID,dt_AppDate,s_PubNo,dt_PubDate,s_CaseSerial,s_AppNo,s_Applicants,s_Introducer,s_Inventors,s_Attorney,s_Creator,s_Editor,n_MainCaseID,s_Status,n_FlowNum,s_InfileFlowNum,s_IsNewCaseInFile,n_NumCount,n_PicCount,s_From,s_To,s_Cc,s_Bc,n_ClientID,s_IPType,n_ApplicantID,n_CreatorID,n_FileClientID,n_FileApplicantID,s_NameForeign,s_ClientType,s_ManualCreateChain,s_sourcetype1 ");
			strSql.Append(" FROM T_MainFiles ");
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
			strSql.Append(" n_FileID,s_SendMethod,s_Name,s_Abstact,s_FilePathName,s_IOType,s_ClientGov,n_ProcessID,dt_SendDate,dt_ReceiveDate,dt_CreateDate,dt_EditDate,ObjectType,s_IsActive,n_TemplateID,dt_AppDate,s_PubNo,dt_PubDate,s_CaseSerial,s_AppNo,s_Applicants,s_Introducer,s_Inventors,s_Attorney,s_Creator,s_Editor,n_MainCaseID,s_Status,n_FlowNum,s_InfileFlowNum,s_IsNewCaseInFile,n_NumCount,n_PicCount,s_From,s_To,s_Cc,s_Bc,n_ClientID,s_IPType,n_ApplicantID,n_CreatorID,n_FileClientID,n_FileApplicantID,s_NameForeign,s_ClientType,s_ManualCreateChain,s_sourcetype1 ");
			strSql.Append(" FROM T_MainFiles ");
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
			strSql.Append("select count(1) FROM T_MainFiles ");
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
				strSql.Append("order by T.n_FileID desc");
			}
			strSql.Append(")AS Row, T.*  from T_MainFiles T ");
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
			parameters[0].Value = "T_MainFiles";
			parameters[1].Value = "n_FileID";
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

