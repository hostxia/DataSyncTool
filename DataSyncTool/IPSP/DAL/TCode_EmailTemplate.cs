/**  版本信息模板在安装目录下，可自行修改。
* TCode_EmailTemplate.cs
*
* 功 能： N/A
* 类 名： TCode_EmailTemplate
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:19   N/A    初版
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
	/// 数据访问类:TCode_EmailTemplate
	/// </summary>
	public partial class TCode_EmailTemplate
	{
		public TCode_EmailTemplate()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TCode_EmailTemplate"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_EmailTemplate");
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
		public int Add(IPSP.Model.TCode_EmailTemplate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_EmailTemplate(");
			strSql.Append("s_Name,s_Subject,s_FilePathName,s_Notes,dt_CreateDate,dt_EditDate,s_Type,s_TemplateType,n_CodeEmailServerID,n_LanguageID,s_CaseType,s_Default,n_Language,s_OtherName)");
			strSql.Append(" values (");
			strSql.Append("@s_Name,@s_Subject,@s_FilePathName,@s_Notes,@dt_CreateDate,@dt_EditDate,@s_Type,@s_TemplateType,@n_CodeEmailServerID,@n_LanguageID,@s_CaseType,@s_Default,@n_Language,@s_OtherName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Subject", SqlDbType.NVarChar,200),
					new SqlParameter("@s_FilePathName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,5),
					new SqlParameter("@s_TemplateType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_CodeEmailServerID", SqlDbType.Int,4),
					new SqlParameter("@n_LanguageID", SqlDbType.Int,4),
					new SqlParameter("@s_CaseType", SqlDbType.NVarChar,5),
					new SqlParameter("@s_Default", SqlDbType.NVarChar,2),
					new SqlParameter("@n_Language", SqlDbType.Int,4),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_Subject;
			parameters[2].Value = model.s_FilePathName;
			parameters[3].Value = model.s_Notes;
			parameters[4].Value = model.dt_CreateDate;
			parameters[5].Value = model.dt_EditDate;
			parameters[6].Value = model.s_Type;
			parameters[7].Value = model.s_TemplateType;
			parameters[8].Value = model.n_CodeEmailServerID;
			parameters[9].Value = model.n_LanguageID;
			parameters[10].Value = model.s_CaseType;
			parameters[11].Value = model.s_Default;
			parameters[12].Value = model.n_Language;
			parameters[13].Value = model.s_OtherName;

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
		public bool Update(IPSP.Model.TCode_EmailTemplate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_EmailTemplate set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_Subject=@s_Subject,");
			strSql.Append("s_FilePathName=@s_FilePathName,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_Type=@s_Type,");
			strSql.Append("s_TemplateType=@s_TemplateType,");
			strSql.Append("n_CodeEmailServerID=@n_CodeEmailServerID,");
			strSql.Append("n_LanguageID=@n_LanguageID,");
			strSql.Append("s_CaseType=@s_CaseType,");
			strSql.Append("s_Default=@s_Default,");
			strSql.Append("n_Language=@n_Language,");
			strSql.Append("s_OtherName=@s_OtherName");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Subject", SqlDbType.NVarChar,200),
					new SqlParameter("@s_FilePathName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,5),
					new SqlParameter("@s_TemplateType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_CodeEmailServerID", SqlDbType.Int,4),
					new SqlParameter("@n_LanguageID", SqlDbType.Int,4),
					new SqlParameter("@s_CaseType", SqlDbType.NVarChar,5),
					new SqlParameter("@s_Default", SqlDbType.NVarChar,2),
					new SqlParameter("@n_Language", SqlDbType.Int,4),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_Subject;
			parameters[2].Value = model.s_FilePathName;
			parameters[3].Value = model.s_Notes;
			parameters[4].Value = model.dt_CreateDate;
			parameters[5].Value = model.dt_EditDate;
			parameters[6].Value = model.s_Type;
			parameters[7].Value = model.s_TemplateType;
			parameters[8].Value = model.n_CodeEmailServerID;
			parameters[9].Value = model.n_LanguageID;
			parameters[10].Value = model.s_CaseType;
			parameters[11].Value = model.s_Default;
			parameters[12].Value = model.n_Language;
			parameters[13].Value = model.s_OtherName;
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
		public bool Delete(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_EmailTemplate ");
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
			strSql.Append("delete from TCode_EmailTemplate ");
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
		public IPSP.Model.TCode_EmailTemplate GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_Name,s_Subject,s_FilePathName,s_Notes,dt_CreateDate,dt_EditDate,s_Type,s_TemplateType,n_CodeEmailServerID,n_LanguageID,s_CaseType,s_Default,n_Language,s_OtherName from TCode_EmailTemplate ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_EmailTemplate model=new IPSP.Model.TCode_EmailTemplate();
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
		public IPSP.Model.TCode_EmailTemplate DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_EmailTemplate model=new IPSP.Model.TCode_EmailTemplate();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_Subject"]!=null)
				{
					model.s_Subject=row["s_Subject"].ToString();
				}
				if(row["s_FilePathName"]!=null)
				{
					model.s_FilePathName=row["s_FilePathName"].ToString();
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
				if(row["s_Type"]!=null)
				{
					model.s_Type=row["s_Type"].ToString();
				}
				if(row["s_TemplateType"]!=null)
				{
					model.s_TemplateType=row["s_TemplateType"].ToString();
				}
				if(row["n_CodeEmailServerID"]!=null && row["n_CodeEmailServerID"].ToString()!="")
				{
					model.n_CodeEmailServerID=int.Parse(row["n_CodeEmailServerID"].ToString());
				}
				if(row["n_LanguageID"]!=null && row["n_LanguageID"].ToString()!="")
				{
					model.n_LanguageID=int.Parse(row["n_LanguageID"].ToString());
				}
				if(row["s_CaseType"]!=null)
				{
					model.s_CaseType=row["s_CaseType"].ToString();
				}
				if(row["s_Default"]!=null)
				{
					model.s_Default=row["s_Default"].ToString();
				}
				if(row["n_Language"]!=null && row["n_Language"].ToString()!="")
				{
					model.n_Language=int.Parse(row["n_Language"].ToString());
				}
				if(row["s_OtherName"]!=null)
				{
					model.s_OtherName=row["s_OtherName"].ToString();
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
			strSql.Append("select n_ID,s_Name,s_Subject,s_FilePathName,s_Notes,dt_CreateDate,dt_EditDate,s_Type,s_TemplateType,n_CodeEmailServerID,n_LanguageID,s_CaseType,s_Default,n_Language,s_OtherName ");
			strSql.Append(" FROM TCode_EmailTemplate ");
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
			strSql.Append(" n_ID,s_Name,s_Subject,s_FilePathName,s_Notes,dt_CreateDate,dt_EditDate,s_Type,s_TemplateType,n_CodeEmailServerID,n_LanguageID,s_CaseType,s_Default,n_Language,s_OtherName ");
			strSql.Append(" FROM TCode_EmailTemplate ");
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
			strSql.Append("select count(1) FROM TCode_EmailTemplate ");
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
			strSql.Append(")AS Row, T.*  from TCode_EmailTemplate T ");
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
			parameters[0].Value = "TCode_EmailTemplate";
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

