/**  版本信息模板在安装目录下，可自行修改。
* TRCode_RemindMode.cs
*
* 功 能： N/A
* 类 名： TRCode_RemindMode
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:04   N/A    初版
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
	/// 数据访问类:TRCode_RemindMode
	/// </summary>
	public partial class TRCode_RemindMode
	{
		public TRCode_RemindMode()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TRCode_RemindMode");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TRCode_RemindMode model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TRCode_RemindMode(");
			strSql.Append("g_ID,g_CodeRemindID,s_RemindMode,s_RemindObjectType,s_RemindObjectID,g_RemindTemplateID,s_Title,s_Content)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@g_CodeRemindID,@s_RemindMode,@s_RemindObjectType,@s_RemindObjectID,@g_RemindTemplateID,@s_Title,@s_Content)");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_CodeRemindID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_RemindMode", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RemindObjectType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RemindObjectID", SqlDbType.NVarChar,50),
					new SqlParameter("@g_RemindTemplateID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Title", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Content", SqlDbType.NVarChar,-1)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = model.s_RemindMode;
			parameters[3].Value = model.s_RemindObjectType;
			parameters[4].Value = model.s_RemindObjectID;
			parameters[5].Value = Guid.NewGuid();
			parameters[6].Value = model.s_Title;
			parameters[7].Value = model.s_Content;

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
		public bool Update(IPSP.Model.TRCode_RemindMode model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TRCode_RemindMode set ");
			strSql.Append("g_CodeRemindID=@g_CodeRemindID,");
			strSql.Append("s_RemindMode=@s_RemindMode,");
			strSql.Append("s_RemindObjectType=@s_RemindObjectType,");
			strSql.Append("s_RemindObjectID=@s_RemindObjectID,");
			strSql.Append("g_RemindTemplateID=@g_RemindTemplateID,");
			strSql.Append("s_Title=@s_Title,");
			strSql.Append("s_Content=@s_Content");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_CodeRemindID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_RemindMode", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RemindObjectType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RemindObjectID", SqlDbType.NVarChar,50),
					new SqlParameter("@g_RemindTemplateID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Title", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Content", SqlDbType.NVarChar,-1),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.g_CodeRemindID;
			parameters[1].Value = model.s_RemindMode;
			parameters[2].Value = model.s_RemindObjectType;
			parameters[3].Value = model.s_RemindObjectID;
			parameters[4].Value = model.g_RemindTemplateID;
			parameters[5].Value = model.s_Title;
			parameters[6].Value = model.s_Content;
			parameters[7].Value = model.g_ID;

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
		public bool Delete(Guid g_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TRCode_RemindMode ");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

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
		public bool DeleteList(string g_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TRCode_RemindMode ");
			strSql.Append(" where g_ID in ("+g_IDlist + ")  ");
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
		public IPSP.Model.TRCode_RemindMode GetModel(Guid g_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,g_CodeRemindID,s_RemindMode,s_RemindObjectType,s_RemindObjectID,g_RemindTemplateID,s_Title,s_Content from TRCode_RemindMode ");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			IPSP.Model.TRCode_RemindMode model=new IPSP.Model.TRCode_RemindMode();
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
		public IPSP.Model.TRCode_RemindMode DataRowToModel(DataRow row)
		{
			IPSP.Model.TRCode_RemindMode model=new IPSP.Model.TRCode_RemindMode();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["g_CodeRemindID"]!=null && row["g_CodeRemindID"].ToString()!="")
				{
					model.g_CodeRemindID= new Guid(row["g_CodeRemindID"].ToString());
				}
				if(row["s_RemindMode"]!=null)
				{
					model.s_RemindMode=row["s_RemindMode"].ToString();
				}
				if(row["s_RemindObjectType"]!=null)
				{
					model.s_RemindObjectType=row["s_RemindObjectType"].ToString();
				}
				if(row["s_RemindObjectID"]!=null)
				{
					model.s_RemindObjectID=row["s_RemindObjectID"].ToString();
				}
				if(row["g_RemindTemplateID"]!=null && row["g_RemindTemplateID"].ToString()!="")
				{
					model.g_RemindTemplateID= new Guid(row["g_RemindTemplateID"].ToString());
				}
				if(row["s_Title"]!=null)
				{
					model.s_Title=row["s_Title"].ToString();
				}
				if(row["s_Content"]!=null)
				{
					model.s_Content=row["s_Content"].ToString();
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
			strSql.Append("select g_ID,g_CodeRemindID,s_RemindMode,s_RemindObjectType,s_RemindObjectID,g_RemindTemplateID,s_Title,s_Content ");
			strSql.Append(" FROM TRCode_RemindMode ");
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
			strSql.Append(" g_ID,g_CodeRemindID,s_RemindMode,s_RemindObjectType,s_RemindObjectID,g_RemindTemplateID,s_Title,s_Content ");
			strSql.Append(" FROM TRCode_RemindMode ");
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
			strSql.Append("select count(1) FROM TRCode_RemindMode ");
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
				strSql.Append("order by T.g_ID desc");
			}
			strSql.Append(")AS Row, T.*  from TRCode_RemindMode T ");
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
			parameters[0].Value = "TRCode_RemindMode";
			parameters[1].Value = "g_ID";
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

