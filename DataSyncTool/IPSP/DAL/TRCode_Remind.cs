/**  版本信息模板在安装目录下，可自行修改。
* TRCode_Remind.cs
*
* 功 能： N/A
* 类 名： TRCode_Remind
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:02   N/A    初版
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
	/// 数据访问类:TRCode_Remind
	/// </summary>
	public partial class TRCode_Remind
	{
		public TRCode_Remind()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TRCode_Remind");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TRCode_Remind model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TRCode_Remind(");
			strSql.Append("g_ID,s_TriggerType,s_TriggerConfigID,s_RemindType,s_RemindPara,s_RemindDatePara,s_Description)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@s_TriggerType,@s_TriggerConfigID,@s_RemindType,@s_RemindPara,@s_RemindDatePara,@s_Description)");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_TriggerType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_TriggerConfigID", SqlDbType.NVarChar,50),
					new SqlParameter("@s_RemindType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RemindPara", SqlDbType.NVarChar,200),
					new SqlParameter("@s_RemindDatePara", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.s_TriggerType;
			parameters[2].Value = model.s_TriggerConfigID;
			parameters[3].Value = model.s_RemindType;
			parameters[4].Value = model.s_RemindPara;
			parameters[5].Value = model.s_RemindDatePara;
			parameters[6].Value = model.s_Description;

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
		public bool Update(IPSP.Model.TRCode_Remind model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TRCode_Remind set ");
			strSql.Append("s_TriggerType=@s_TriggerType,");
			strSql.Append("s_TriggerConfigID=@s_TriggerConfigID,");
			strSql.Append("s_RemindType=@s_RemindType,");
			strSql.Append("s_RemindPara=@s_RemindPara,");
			strSql.Append("s_RemindDatePara=@s_RemindDatePara,");
			strSql.Append("s_Description=@s_Description");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_TriggerType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_TriggerConfigID", SqlDbType.NVarChar,50),
					new SqlParameter("@s_RemindType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_RemindPara", SqlDbType.NVarChar,200),
					new SqlParameter("@s_RemindDatePara", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.s_TriggerType;
			parameters[1].Value = model.s_TriggerConfigID;
			parameters[2].Value = model.s_RemindType;
			parameters[3].Value = model.s_RemindPara;
			parameters[4].Value = model.s_RemindDatePara;
			parameters[5].Value = model.s_Description;
			parameters[6].Value = model.g_ID;

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
			strSql.Append("delete from TRCode_Remind ");
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
			strSql.Append("delete from TRCode_Remind ");
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
		public IPSP.Model.TRCode_Remind GetModel(Guid g_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,s_TriggerType,s_TriggerConfigID,s_RemindType,s_RemindPara,s_RemindDatePara,s_Description from TRCode_Remind ");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			IPSP.Model.TRCode_Remind model=new IPSP.Model.TRCode_Remind();
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
		public IPSP.Model.TRCode_Remind DataRowToModel(DataRow row)
		{
			IPSP.Model.TRCode_Remind model=new IPSP.Model.TRCode_Remind();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["s_TriggerType"]!=null)
				{
					model.s_TriggerType=row["s_TriggerType"].ToString();
				}
				if(row["s_TriggerConfigID"]!=null)
				{
					model.s_TriggerConfigID=row["s_TriggerConfigID"].ToString();
				}
				if(row["s_RemindType"]!=null)
				{
					model.s_RemindType=row["s_RemindType"].ToString();
				}
				if(row["s_RemindPara"]!=null)
				{
					model.s_RemindPara=row["s_RemindPara"].ToString();
				}
				if(row["s_RemindDatePara"]!=null)
				{
					model.s_RemindDatePara=row["s_RemindDatePara"].ToString();
				}
				if(row["s_Description"]!=null)
				{
					model.s_Description=row["s_Description"].ToString();
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
			strSql.Append("select g_ID,s_TriggerType,s_TriggerConfigID,s_RemindType,s_RemindPara,s_RemindDatePara,s_Description ");
			strSql.Append(" FROM TRCode_Remind ");
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
			strSql.Append(" g_ID,s_TriggerType,s_TriggerConfigID,s_RemindType,s_RemindPara,s_RemindDatePara,s_Description ");
			strSql.Append(" FROM TRCode_Remind ");
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
			strSql.Append("select count(1) FROM TRCode_Remind ");
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
			strSql.Append(")AS Row, T.*  from TRCode_Remind T ");
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
			parameters[0].Value = "TRCode_Remind";
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

