/**  版本信息模板在安装目录下，可自行修改。
* TCode_InFileImportConfig.cs
*
* 功 能： N/A
* 类 名： TCode_InFileImportConfig
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:31   N/A    初版
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
	/// 数据访问类:TCode_InFileImportConfig
	/// </summary>
	public partial class TCode_InFileImportConfig
	{
		public TCode_InFileImportConfig()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ConfigID", "TCode_InFileImportConfig"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ConfigID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_InFileImportConfig");
			strSql.Append(" where n_ConfigID=@n_ConfigID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ConfigID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ConfigID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_InFileImportConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_InFileImportConfig(");
			strSql.Append("s_ConfigName,n_FileNameRule,n_Delimiter,n_FileType,s_ImportedFileName,n_CaseMethod,n_FileMethod)");
			strSql.Append(" values (");
			strSql.Append("@s_ConfigName,@n_FileNameRule,@n_Delimiter,@n_FileType,@s_ImportedFileName,@n_CaseMethod,@n_FileMethod)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ConfigName", SqlDbType.NVarChar,100),
					new SqlParameter("@n_FileNameRule", SqlDbType.Int,4),
					new SqlParameter("@n_Delimiter", SqlDbType.Int,4),
					new SqlParameter("@n_FileType", SqlDbType.Int,4),
					new SqlParameter("@s_ImportedFileName", SqlDbType.NVarChar,100),
					new SqlParameter("@n_CaseMethod", SqlDbType.Int,4),
					new SqlParameter("@n_FileMethod", SqlDbType.Int,4)};
			parameters[0].Value = model.s_ConfigName;
			parameters[1].Value = model.n_FileNameRule;
			parameters[2].Value = model.n_Delimiter;
			parameters[3].Value = model.n_FileType;
			parameters[4].Value = model.s_ImportedFileName;
			parameters[5].Value = model.n_CaseMethod;
			parameters[6].Value = model.n_FileMethod;

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
		public bool Update(IPSP.Model.TCode_InFileImportConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_InFileImportConfig set ");
			strSql.Append("s_ConfigName=@s_ConfigName,");
			strSql.Append("n_FileNameRule=@n_FileNameRule,");
			strSql.Append("n_Delimiter=@n_Delimiter,");
			strSql.Append("n_FileType=@n_FileType,");
			strSql.Append("s_ImportedFileName=@s_ImportedFileName,");
			strSql.Append("n_CaseMethod=@n_CaseMethod,");
			strSql.Append("n_FileMethod=@n_FileMethod");
			strSql.Append(" where n_ConfigID=@n_ConfigID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ConfigName", SqlDbType.NVarChar,100),
					new SqlParameter("@n_FileNameRule", SqlDbType.Int,4),
					new SqlParameter("@n_Delimiter", SqlDbType.Int,4),
					new SqlParameter("@n_FileType", SqlDbType.Int,4),
					new SqlParameter("@s_ImportedFileName", SqlDbType.NVarChar,100),
					new SqlParameter("@n_CaseMethod", SqlDbType.Int,4),
					new SqlParameter("@n_FileMethod", SqlDbType.Int,4),
					new SqlParameter("@n_ConfigID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_ConfigName;
			parameters[1].Value = model.n_FileNameRule;
			parameters[2].Value = model.n_Delimiter;
			parameters[3].Value = model.n_FileType;
			parameters[4].Value = model.s_ImportedFileName;
			parameters[5].Value = model.n_CaseMethod;
			parameters[6].Value = model.n_FileMethod;
			parameters[7].Value = model.n_ConfigID;

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
		public bool Delete(int n_ConfigID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_InFileImportConfig ");
			strSql.Append(" where n_ConfigID=@n_ConfigID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ConfigID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ConfigID;

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
		public bool DeleteList(string n_ConfigIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_InFileImportConfig ");
			strSql.Append(" where n_ConfigID in ("+n_ConfigIDlist + ")  ");
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
		public IPSP.Model.TCode_InFileImportConfig GetModel(int n_ConfigID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ConfigID,s_ConfigName,n_FileNameRule,n_Delimiter,n_FileType,s_ImportedFileName,n_CaseMethod,n_FileMethod from TCode_InFileImportConfig ");
			strSql.Append(" where n_ConfigID=@n_ConfigID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ConfigID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ConfigID;

			IPSP.Model.TCode_InFileImportConfig model=new IPSP.Model.TCode_InFileImportConfig();
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
		public IPSP.Model.TCode_InFileImportConfig DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_InFileImportConfig model=new IPSP.Model.TCode_InFileImportConfig();
			if (row != null)
			{
				if(row["n_ConfigID"]!=null && row["n_ConfigID"].ToString()!="")
				{
					model.n_ConfigID=int.Parse(row["n_ConfigID"].ToString());
				}
				if(row["s_ConfigName"]!=null)
				{
					model.s_ConfigName=row["s_ConfigName"].ToString();
				}
				if(row["n_FileNameRule"]!=null && row["n_FileNameRule"].ToString()!="")
				{
					model.n_FileNameRule=int.Parse(row["n_FileNameRule"].ToString());
				}
				if(row["n_Delimiter"]!=null && row["n_Delimiter"].ToString()!="")
				{
					model.n_Delimiter=int.Parse(row["n_Delimiter"].ToString());
				}
				if(row["n_FileType"]!=null && row["n_FileType"].ToString()!="")
				{
					model.n_FileType=int.Parse(row["n_FileType"].ToString());
				}
				if(row["s_ImportedFileName"]!=null)
				{
					model.s_ImportedFileName=row["s_ImportedFileName"].ToString();
				}
				if(row["n_CaseMethod"]!=null && row["n_CaseMethod"].ToString()!="")
				{
					model.n_CaseMethod=int.Parse(row["n_CaseMethod"].ToString());
				}
				if(row["n_FileMethod"]!=null && row["n_FileMethod"].ToString()!="")
				{
					model.n_FileMethod=int.Parse(row["n_FileMethod"].ToString());
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
			strSql.Append("select n_ConfigID,s_ConfigName,n_FileNameRule,n_Delimiter,n_FileType,s_ImportedFileName,n_CaseMethod,n_FileMethod ");
			strSql.Append(" FROM TCode_InFileImportConfig ");
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
			strSql.Append(" n_ConfigID,s_ConfigName,n_FileNameRule,n_Delimiter,n_FileType,s_ImportedFileName,n_CaseMethod,n_FileMethod ");
			strSql.Append(" FROM TCode_InFileImportConfig ");
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
			strSql.Append("select count(1) FROM TCode_InFileImportConfig ");
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
				strSql.Append("order by T.n_ConfigID desc");
			}
			strSql.Append(")AS Row, T.*  from TCode_InFileImportConfig T ");
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
			parameters[0].Value = "TCode_InFileImportConfig";
			parameters[1].Value = "n_ConfigID";
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

