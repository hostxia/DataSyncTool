/**  版本信息模板在安装目录下，可自行修改。
* TCode_Template.cs
*
* 功 能： N/A
* 类 名： TCode_Template
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:14   N/A    初版
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
	/// 数据访问类:TCode_Template
	/// </summary>
	public partial class TCode_Template
	{
		public TCode_Template()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TCode_Template"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_Template");
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
		public int Add(IPSP.Model.TCode_Template model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_Template(");
			strSql.Append("s_IPType,s_TApplyType,s_TemplateType,n_RegCountry,s_Business,s_PTCType,s_ProcessID,n_Language,s_Name,s_OtherName,s_FilePathName,s_OfficialCode,s_NameSpace,s_NeedInFile,s_Notes,dt_CreateDate,dt_EditDate,s_IsSystemDefine,s_OfficialName,s_ExportType)");
			strSql.Append(" values (");
			strSql.Append("@s_IPType,@s_TApplyType,@s_TemplateType,@n_RegCountry,@s_Business,@s_PTCType,@s_ProcessID,@n_Language,@s_Name,@s_OtherName,@s_FilePathName,@s_OfficialCode,@s_NameSpace,@s_NeedInFile,@s_Notes,@dt_CreateDate,@dt_EditDate,@s_IsSystemDefine,@s_OfficialName,@s_ExportType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TApplyType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TemplateType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_RegCountry", SqlDbType.Int,4),
					new SqlParameter("@s_Business", SqlDbType.NVarChar,500),
					new SqlParameter("@s_PTCType", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ProcessID", SqlDbType.NVarChar,500),
					new SqlParameter("@n_Language", SqlDbType.Int,4),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_FilePathName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_OfficialCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_NameSpace", SqlDbType.VarChar,200),
					new SqlParameter("@s_NeedInFile", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IsSystemDefine", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OfficialName", SqlDbType.VarChar,100),
					new SqlParameter("@s_ExportType", SqlDbType.VarChar,1)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_TApplyType;
			parameters[2].Value = model.s_TemplateType;
			parameters[3].Value = model.n_RegCountry;
			parameters[4].Value = model.s_Business;
			parameters[5].Value = model.s_PTCType;
			parameters[6].Value = model.s_ProcessID;
			parameters[7].Value = model.n_Language;
			parameters[8].Value = model.s_Name;
			parameters[9].Value = model.s_OtherName;
			parameters[10].Value = model.s_FilePathName;
			parameters[11].Value = model.s_OfficialCode;
			parameters[12].Value = model.s_NameSpace;
			parameters[13].Value = model.s_NeedInFile;
			parameters[14].Value = model.s_Notes;
			parameters[15].Value = model.dt_CreateDate;
			parameters[16].Value = model.dt_EditDate;
			parameters[17].Value = model.s_IsSystemDefine;
			parameters[18].Value = model.s_OfficialName;
			parameters[19].Value = model.s_ExportType;

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
		public bool Update(IPSP.Model.TCode_Template model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_Template set ");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_TApplyType=@s_TApplyType,");
			strSql.Append("s_TemplateType=@s_TemplateType,");
			strSql.Append("n_RegCountry=@n_RegCountry,");
			strSql.Append("s_Business=@s_Business,");
			strSql.Append("s_PTCType=@s_PTCType,");
			strSql.Append("s_ProcessID=@s_ProcessID,");
			strSql.Append("n_Language=@n_Language,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("s_FilePathName=@s_FilePathName,");
			strSql.Append("s_OfficialCode=@s_OfficialCode,");
			strSql.Append("s_NameSpace=@s_NameSpace,");
			strSql.Append("s_NeedInFile=@s_NeedInFile,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_IsSystemDefine=@s_IsSystemDefine,");
			strSql.Append("s_OfficialName=@s_OfficialName,");
			strSql.Append("s_ExportType=@s_ExportType");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TApplyType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TemplateType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_RegCountry", SqlDbType.Int,4),
					new SqlParameter("@s_Business", SqlDbType.NVarChar,500),
					new SqlParameter("@s_PTCType", SqlDbType.NVarChar,500),
					new SqlParameter("@s_ProcessID", SqlDbType.NVarChar,500),
					new SqlParameter("@n_Language", SqlDbType.Int,4),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_FilePathName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_OfficialCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_NameSpace", SqlDbType.VarChar,200),
					new SqlParameter("@s_NeedInFile", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IsSystemDefine", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OfficialName", SqlDbType.VarChar,100),
					new SqlParameter("@s_ExportType", SqlDbType.VarChar,1),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_TApplyType;
			parameters[2].Value = model.s_TemplateType;
			parameters[3].Value = model.n_RegCountry;
			parameters[4].Value = model.s_Business;
			parameters[5].Value = model.s_PTCType;
			parameters[6].Value = model.s_ProcessID;
			parameters[7].Value = model.n_Language;
			parameters[8].Value = model.s_Name;
			parameters[9].Value = model.s_OtherName;
			parameters[10].Value = model.s_FilePathName;
			parameters[11].Value = model.s_OfficialCode;
			parameters[12].Value = model.s_NameSpace;
			parameters[13].Value = model.s_NeedInFile;
			parameters[14].Value = model.s_Notes;
			parameters[15].Value = model.dt_CreateDate;
			parameters[16].Value = model.dt_EditDate;
			parameters[17].Value = model.s_IsSystemDefine;
			parameters[18].Value = model.s_OfficialName;
			parameters[19].Value = model.s_ExportType;
			parameters[20].Value = model.n_ID;

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
			strSql.Append("delete from TCode_Template ");
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
			strSql.Append("delete from TCode_Template ");
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
		public IPSP.Model.TCode_Template GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_IPType,s_TApplyType,s_TemplateType,n_RegCountry,s_Business,s_PTCType,s_ProcessID,n_Language,s_Name,s_OtherName,s_FilePathName,s_OfficialCode,s_NameSpace,s_NeedInFile,s_Notes,dt_CreateDate,dt_EditDate,s_IsSystemDefine,s_OfficialName,s_ExportType from TCode_Template ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_Template model=new IPSP.Model.TCode_Template();
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
		public IPSP.Model.TCode_Template DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_Template model=new IPSP.Model.TCode_Template();
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
				if(row["s_TemplateType"]!=null)
				{
					model.s_TemplateType=row["s_TemplateType"].ToString();
				}
				if(row["n_RegCountry"]!=null && row["n_RegCountry"].ToString()!="")
				{
					model.n_RegCountry=int.Parse(row["n_RegCountry"].ToString());
				}
				if(row["s_Business"]!=null)
				{
					model.s_Business=row["s_Business"].ToString();
				}
				if(row["s_PTCType"]!=null)
				{
					model.s_PTCType=row["s_PTCType"].ToString();
				}
				if(row["s_ProcessID"]!=null)
				{
					model.s_ProcessID=row["s_ProcessID"].ToString();
				}
				if(row["n_Language"]!=null && row["n_Language"].ToString()!="")
				{
					model.n_Language=int.Parse(row["n_Language"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_OtherName"]!=null)
				{
					model.s_OtherName=row["s_OtherName"].ToString();
				}
				if(row["s_FilePathName"]!=null)
				{
					model.s_FilePathName=row["s_FilePathName"].ToString();
				}
				if(row["s_OfficialCode"]!=null)
				{
					model.s_OfficialCode=row["s_OfficialCode"].ToString();
				}
				if(row["s_NameSpace"]!=null)
				{
					model.s_NameSpace=row["s_NameSpace"].ToString();
				}
				if(row["s_NeedInFile"]!=null)
				{
					model.s_NeedInFile=row["s_NeedInFile"].ToString();
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
				if(row["s_IsSystemDefine"]!=null)
				{
					model.s_IsSystemDefine=row["s_IsSystemDefine"].ToString();
				}
				if(row["s_OfficialName"]!=null)
				{
					model.s_OfficialName=row["s_OfficialName"].ToString();
				}
				if(row["s_ExportType"]!=null)
				{
					model.s_ExportType=row["s_ExportType"].ToString();
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
			strSql.Append("select n_ID,s_IPType,s_TApplyType,s_TemplateType,n_RegCountry,s_Business,s_PTCType,s_ProcessID,n_Language,s_Name,s_OtherName,s_FilePathName,s_OfficialCode,s_NameSpace,s_NeedInFile,s_Notes,dt_CreateDate,dt_EditDate,s_IsSystemDefine,s_OfficialName,s_ExportType ");
			strSql.Append(" FROM TCode_Template ");
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
			strSql.Append(" n_ID,s_IPType,s_TApplyType,s_TemplateType,n_RegCountry,s_Business,s_PTCType,s_ProcessID,n_Language,s_Name,s_OtherName,s_FilePathName,s_OfficialCode,s_NameSpace,s_NeedInFile,s_Notes,dt_CreateDate,dt_EditDate,s_IsSystemDefine,s_OfficialName,s_ExportType ");
			strSql.Append(" FROM TCode_Template ");
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
			strSql.Append("select count(1) FROM TCode_Template ");
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
			strSql.Append(")AS Row, T.*  from TCode_Template T ");
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
			parameters[0].Value = "TCode_Template";
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

