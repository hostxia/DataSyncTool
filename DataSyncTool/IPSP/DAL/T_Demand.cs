/**  版本信息模板在安装目录下，可自行修改。
* T_Demand.cs
*
* 功 能： N/A
* 类 名： T_Demand
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:38   N/A    初版
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
	/// 数据访问类:T_Demand
	/// </summary>
	public partial class T_Demand
	{
		public T_Demand()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ClientID", "T_Demand"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ClientID,int n_ApplicantID,int n_CaseID,int n_AgencyID,int n_CodeDemandID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Demand");
			strSql.Append(" where n_ClientID=@n_ClientID and n_ApplicantID=@n_ApplicantID and n_CaseID=@n_CaseID and n_AgencyID=@n_AgencyID and n_CodeDemandID=@n_CodeDemandID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ApplicantID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4),
					new SqlParameter("@n_CodeDemandID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = n_ApplicantID;
			parameters[2].Value = n_CaseID;
			parameters[3].Value = n_AgencyID;
			parameters[4].Value = n_CodeDemandID;
			parameters[5].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_Demand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Demand(");
			strSql.Append("s_Content,dt_EditDate,s_Type,s_ModuleType,n_EditorID,s_Active,n_Sequence,n_objectID,n_SysDemandID,s_Title,s_Description,s_Creator,dt_CreateDate,s_Editor,s_IPType,n_ClientID,n_ApplicantID,n_CaseID,n_AgencyID,s_DemandPosition,n_CodeDemandID,s_ReceiptMethod,s_Assignor,dt_ReceiptDate,n_CodeDemandTypeID,s_FilePath,s_SysDemand,n_SysOftenDemand,s_Process,s_BussinessType,s_SourceModuleType,n_SourceID,n_DemadType,n_DemandType,s_sourcetype1)");
			strSql.Append(" values (");
			strSql.Append("@s_Content,@dt_EditDate,@s_Type,@s_ModuleType,@n_EditorID,@s_Active,@n_Sequence,@n_objectID,@n_SysDemandID,@s_Title,@s_Description,@s_Creator,@dt_CreateDate,@s_Editor,@s_IPType,@n_ClientID,@n_ApplicantID,@n_CaseID,@n_AgencyID,@s_DemandPosition,@n_CodeDemandID,@s_ReceiptMethod,@s_Assignor,@dt_ReceiptDate,@n_CodeDemandTypeID,@s_FilePath,@s_SysDemand,@n_SysOftenDemand,@s_Process,@s_BussinessType,@s_SourceModuleType,@n_SourceID,@n_DemadType,@n_DemandType,@s_sourcetype1)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Content", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ModuleType", SqlDbType.NVarChar,20),
					new SqlParameter("@n_EditorID", SqlDbType.Int,4),
					new SqlParameter("@s_Active", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@n_objectID", SqlDbType.Int,4),
					new SqlParameter("@n_SysDemandID", SqlDbType.Int,4),
					new SqlParameter("@s_Title", SqlDbType.NVarChar,-1),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,20),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ApplicantID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4),
					new SqlParameter("@s_DemandPosition", SqlDbType.NVarChar,100),
					new SqlParameter("@n_CodeDemandID", SqlDbType.Int,4),
					new SqlParameter("@s_ReceiptMethod", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Assignor", SqlDbType.NVarChar,100),
					new SqlParameter("@dt_ReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@n_CodeDemandTypeID", SqlDbType.Int,4),
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,500),
					new SqlParameter("@s_SysDemand", SqlDbType.NVarChar,100),
					new SqlParameter("@n_SysOftenDemand", SqlDbType.Int,4),
					new SqlParameter("@s_Process", SqlDbType.NVarChar,500),
					new SqlParameter("@s_BussinessType", SqlDbType.NVarChar,500),
					new SqlParameter("@s_SourceModuleType", SqlDbType.NVarChar,20),
					new SqlParameter("@n_SourceID", SqlDbType.Int,4),
					new SqlParameter("@n_DemadType", SqlDbType.Int,4),
					new SqlParameter("@n_DemandType", SqlDbType.Int,4),
					new SqlParameter("@s_sourcetype1", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.s_Content;
			parameters[1].Value = model.dt_EditDate;
			parameters[2].Value = model.s_Type;
			parameters[3].Value = model.s_ModuleType;
			parameters[4].Value = model.n_EditorID;
			parameters[5].Value = model.s_Active;
			parameters[6].Value = model.n_Sequence;
			parameters[7].Value = model.n_objectID;
			parameters[8].Value = model.n_SysDemandID;
			parameters[9].Value = model.s_Title;
			parameters[10].Value = model.s_Description;
			parameters[11].Value = model.s_Creator;
			parameters[12].Value = model.dt_CreateDate;
			parameters[13].Value = model.s_Editor;
			parameters[14].Value = model.s_IPType;
			parameters[15].Value = model.n_ClientID;
			parameters[16].Value = model.n_ApplicantID;
			parameters[17].Value = model.n_CaseID;
			parameters[18].Value = model.n_AgencyID;
			parameters[19].Value = model.s_DemandPosition;
			parameters[20].Value = model.n_CodeDemandID;
			parameters[21].Value = model.s_ReceiptMethod;
			parameters[22].Value = model.s_Assignor;
			parameters[23].Value = model.dt_ReceiptDate;
			parameters[24].Value = model.n_CodeDemandTypeID;
			parameters[25].Value = model.s_FilePath;
			parameters[26].Value = model.s_SysDemand;
			parameters[27].Value = model.n_SysOftenDemand;
			parameters[28].Value = model.s_Process;
			parameters[29].Value = model.s_BussinessType;
			parameters[30].Value = model.s_SourceModuleType;
			parameters[31].Value = model.n_SourceID;
			parameters[32].Value = model.n_DemadType;
			parameters[33].Value = model.n_DemandType;
			parameters[34].Value = model.s_sourcetype1;

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
		public bool Update(IPSP.Model.T_Demand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Demand set ");
			strSql.Append("s_Content=@s_Content,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_Type=@s_Type,");
			strSql.Append("s_ModuleType=@s_ModuleType,");
			strSql.Append("n_EditorID=@n_EditorID,");
			strSql.Append("s_Active=@s_Active,");
			strSql.Append("n_Sequence=@n_Sequence,");
			strSql.Append("n_objectID=@n_objectID,");
			strSql.Append("n_SysDemandID=@n_SysDemandID,");
			strSql.Append("s_Title=@s_Title,");
			strSql.Append("s_Description=@s_Description,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_DemandPosition=@s_DemandPosition,");
			strSql.Append("s_ReceiptMethod=@s_ReceiptMethod,");
			strSql.Append("s_Assignor=@s_Assignor,");
			strSql.Append("dt_ReceiptDate=@dt_ReceiptDate,");
			strSql.Append("n_CodeDemandTypeID=@n_CodeDemandTypeID,");
			strSql.Append("s_FilePath=@s_FilePath,");
			strSql.Append("s_SysDemand=@s_SysDemand,");
			strSql.Append("n_SysOftenDemand=@n_SysOftenDemand,");
			strSql.Append("s_Process=@s_Process,");
			strSql.Append("s_BussinessType=@s_BussinessType,");
			strSql.Append("s_SourceModuleType=@s_SourceModuleType,");
			strSql.Append("n_SourceID=@n_SourceID,");
			strSql.Append("n_DemadType=@n_DemadType,");
			strSql.Append("n_DemandType=@n_DemandType,");
			strSql.Append("s_sourcetype1=@s_sourcetype1");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Content", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ModuleType", SqlDbType.NVarChar,20),
					new SqlParameter("@n_EditorID", SqlDbType.Int,4),
					new SqlParameter("@s_Active", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@n_objectID", SqlDbType.Int,4),
					new SqlParameter("@n_SysDemandID", SqlDbType.Int,4),
					new SqlParameter("@s_Title", SqlDbType.NVarChar,-1),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,20),
					new SqlParameter("@s_DemandPosition", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ReceiptMethod", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Assignor", SqlDbType.NVarChar,100),
					new SqlParameter("@dt_ReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@n_CodeDemandTypeID", SqlDbType.Int,4),
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,500),
					new SqlParameter("@s_SysDemand", SqlDbType.NVarChar,100),
					new SqlParameter("@n_SysOftenDemand", SqlDbType.Int,4),
					new SqlParameter("@s_Process", SqlDbType.NVarChar,500),
					new SqlParameter("@s_BussinessType", SqlDbType.NVarChar,500),
					new SqlParameter("@s_SourceModuleType", SqlDbType.NVarChar,20),
					new SqlParameter("@n_SourceID", SqlDbType.Int,4),
					new SqlParameter("@n_DemadType", SqlDbType.Int,4),
					new SqlParameter("@n_DemandType", SqlDbType.Int,4),
					new SqlParameter("@s_sourcetype1", SqlDbType.NVarChar,100),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ApplicantID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4),
					new SqlParameter("@n_CodeDemandID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Content;
			parameters[1].Value = model.dt_EditDate;
			parameters[2].Value = model.s_Type;
			parameters[3].Value = model.s_ModuleType;
			parameters[4].Value = model.n_EditorID;
			parameters[5].Value = model.s_Active;
			parameters[6].Value = model.n_Sequence;
			parameters[7].Value = model.n_objectID;
			parameters[8].Value = model.n_SysDemandID;
			parameters[9].Value = model.s_Title;
			parameters[10].Value = model.s_Description;
			parameters[11].Value = model.s_Creator;
			parameters[12].Value = model.dt_CreateDate;
			parameters[13].Value = model.s_Editor;
			parameters[14].Value = model.s_IPType;
			parameters[15].Value = model.s_DemandPosition;
			parameters[16].Value = model.s_ReceiptMethod;
			parameters[17].Value = model.s_Assignor;
			parameters[18].Value = model.dt_ReceiptDate;
			parameters[19].Value = model.n_CodeDemandTypeID;
			parameters[20].Value = model.s_FilePath;
			parameters[21].Value = model.s_SysDemand;
			parameters[22].Value = model.n_SysOftenDemand;
			parameters[23].Value = model.s_Process;
			parameters[24].Value = model.s_BussinessType;
			parameters[25].Value = model.s_SourceModuleType;
			parameters[26].Value = model.n_SourceID;
			parameters[27].Value = model.n_DemadType;
			parameters[28].Value = model.n_DemandType;
			parameters[29].Value = model.s_sourcetype1;
			parameters[30].Value = model.n_ID;
			parameters[31].Value = model.n_ClientID;
			parameters[32].Value = model.n_ApplicantID;
			parameters[33].Value = model.n_CaseID;
			parameters[34].Value = model.n_AgencyID;
			parameters[35].Value = model.n_CodeDemandID;

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
			strSql.Append("delete from T_Demand ");
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(int n_ClientID,int n_ApplicantID,int n_CaseID,int n_AgencyID,int n_CodeDemandID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Demand ");
			strSql.Append(" where n_ClientID=@n_ClientID and n_ApplicantID=@n_ApplicantID and n_CaseID=@n_CaseID and n_AgencyID=@n_AgencyID and n_CodeDemandID=@n_CodeDemandID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ApplicantID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_AgencyID", SqlDbType.Int,4),
					new SqlParameter("@n_CodeDemandID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = n_ApplicantID;
			parameters[2].Value = n_CaseID;
			parameters[3].Value = n_AgencyID;
			parameters[4].Value = n_CodeDemandID;
			parameters[5].Value = n_ID;

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
			strSql.Append("delete from T_Demand ");
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
		public IPSP.Model.T_Demand GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_Content,dt_EditDate,s_Type,s_ModuleType,n_EditorID,s_Active,n_Sequence,n_objectID,n_SysDemandID,s_Title,s_Description,s_Creator,dt_CreateDate,s_Editor,s_IPType,n_ClientID,n_ApplicantID,n_CaseID,n_AgencyID,s_DemandPosition,n_CodeDemandID,s_ReceiptMethod,s_Assignor,dt_ReceiptDate,n_CodeDemandTypeID,s_FilePath,s_SysDemand,n_SysOftenDemand,s_Process,s_BussinessType,s_SourceModuleType,n_SourceID,n_DemadType,n_DemandType,s_sourcetype1 from T_Demand ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_Demand model=new IPSP.Model.T_Demand();
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
		public IPSP.Model.T_Demand DataRowToModel(DataRow row)
		{
			IPSP.Model.T_Demand model=new IPSP.Model.T_Demand();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_Content"]!=null)
				{
					model.s_Content=row["s_Content"].ToString();
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_Type"]!=null)
				{
					model.s_Type=row["s_Type"].ToString();
				}
				if(row["s_ModuleType"]!=null)
				{
					model.s_ModuleType=row["s_ModuleType"].ToString();
				}
				if(row["n_EditorID"]!=null && row["n_EditorID"].ToString()!="")
				{
					model.n_EditorID=int.Parse(row["n_EditorID"].ToString());
				}
				if(row["s_Active"]!=null)
				{
					model.s_Active=row["s_Active"].ToString();
				}
				if(row["n_Sequence"]!=null && row["n_Sequence"].ToString()!="")
				{
					model.n_Sequence=int.Parse(row["n_Sequence"].ToString());
				}
				if(row["n_objectID"]!=null && row["n_objectID"].ToString()!="")
				{
					model.n_objectID=int.Parse(row["n_objectID"].ToString());
				}
				if(row["n_SysDemandID"]!=null && row["n_SysDemandID"].ToString()!="")
				{
					model.n_SysDemandID=int.Parse(row["n_SysDemandID"].ToString());
				}
				if(row["s_Title"]!=null)
				{
					model.s_Title=row["s_Title"].ToString();
				}
				if(row["s_Description"]!=null)
				{
					model.s_Description=row["s_Description"].ToString();
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["n_ApplicantID"]!=null && row["n_ApplicantID"].ToString()!="")
				{
					model.n_ApplicantID=int.Parse(row["n_ApplicantID"].ToString());
				}
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["n_AgencyID"]!=null && row["n_AgencyID"].ToString()!="")
				{
					model.n_AgencyID=int.Parse(row["n_AgencyID"].ToString());
				}
				if(row["s_DemandPosition"]!=null)
				{
					model.s_DemandPosition=row["s_DemandPosition"].ToString();
				}
				if(row["n_CodeDemandID"]!=null && row["n_CodeDemandID"].ToString()!="")
				{
					model.n_CodeDemandID=int.Parse(row["n_CodeDemandID"].ToString());
				}
				if(row["s_ReceiptMethod"]!=null)
				{
					model.s_ReceiptMethod=row["s_ReceiptMethod"].ToString();
				}
				if(row["s_Assignor"]!=null)
				{
					model.s_Assignor=row["s_Assignor"].ToString();
				}
				if(row["dt_ReceiptDate"]!=null && row["dt_ReceiptDate"].ToString()!="")
				{
					model.dt_ReceiptDate=DateTime.Parse(row["dt_ReceiptDate"].ToString());
				}
				if(row["n_CodeDemandTypeID"]!=null && row["n_CodeDemandTypeID"].ToString()!="")
				{
					model.n_CodeDemandTypeID=int.Parse(row["n_CodeDemandTypeID"].ToString());
				}
				if(row["s_FilePath"]!=null)
				{
					model.s_FilePath=row["s_FilePath"].ToString();
				}
				if(row["s_SysDemand"]!=null)
				{
					model.s_SysDemand=row["s_SysDemand"].ToString();
				}
				if(row["n_SysOftenDemand"]!=null && row["n_SysOftenDemand"].ToString()!="")
				{
					model.n_SysOftenDemand=int.Parse(row["n_SysOftenDemand"].ToString());
				}
				if(row["s_Process"]!=null)
				{
					model.s_Process=row["s_Process"].ToString();
				}
				if(row["s_BussinessType"]!=null)
				{
					model.s_BussinessType=row["s_BussinessType"].ToString();
				}
				if(row["s_SourceModuleType"]!=null)
				{
					model.s_SourceModuleType=row["s_SourceModuleType"].ToString();
				}
				if(row["n_SourceID"]!=null && row["n_SourceID"].ToString()!="")
				{
					model.n_SourceID=int.Parse(row["n_SourceID"].ToString());
				}
				if(row["n_DemadType"]!=null && row["n_DemadType"].ToString()!="")
				{
					model.n_DemadType=int.Parse(row["n_DemadType"].ToString());
				}
				if(row["n_DemandType"]!=null && row["n_DemandType"].ToString()!="")
				{
					model.n_DemandType=int.Parse(row["n_DemandType"].ToString());
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
			strSql.Append("select n_ID,s_Content,dt_EditDate,s_Type,s_ModuleType,n_EditorID,s_Active,n_Sequence,n_objectID,n_SysDemandID,s_Title,s_Description,s_Creator,dt_CreateDate,s_Editor,s_IPType,n_ClientID,n_ApplicantID,n_CaseID,n_AgencyID,s_DemandPosition,n_CodeDemandID,s_ReceiptMethod,s_Assignor,dt_ReceiptDate,n_CodeDemandTypeID,s_FilePath,s_SysDemand,n_SysOftenDemand,s_Process,s_BussinessType,s_SourceModuleType,n_SourceID,n_DemadType,n_DemandType,s_sourcetype1 ");
			strSql.Append(" FROM T_Demand ");
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
			strSql.Append(" n_ID,s_Content,dt_EditDate,s_Type,s_ModuleType,n_EditorID,s_Active,n_Sequence,n_objectID,n_SysDemandID,s_Title,s_Description,s_Creator,dt_CreateDate,s_Editor,s_IPType,n_ClientID,n_ApplicantID,n_CaseID,n_AgencyID,s_DemandPosition,n_CodeDemandID,s_ReceiptMethod,s_Assignor,dt_ReceiptDate,n_CodeDemandTypeID,s_FilePath,s_SysDemand,n_SysOftenDemand,s_Process,s_BussinessType,s_SourceModuleType,n_SourceID,n_DemadType,n_DemandType,s_sourcetype1 ");
			strSql.Append(" FROM T_Demand ");
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
			strSql.Append("select count(1) FROM T_Demand ");
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
			strSql.Append(")AS Row, T.*  from T_Demand T ");
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
			parameters[0].Value = "T_Demand";
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

