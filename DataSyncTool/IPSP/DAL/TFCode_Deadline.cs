/**  版本信息模板在安装目录下，可自行修改。
* TFCode_Deadline.cs
*
* 功 能： N/A
* 类 名： TFCode_Deadline
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:36   N/A    初版
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
	/// 数据访问类:TFCode_Deadline
	/// </summary>
	public partial class TFCode_Deadline
	{
		public TFCode_Deadline()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TFCode_Deadline");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TFCode_Deadline model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TFCode_Deadline(");
			strSql.Append("g_ID,s_Name,s_Type,s_ValueRule,s_Description,s_Classification,s_AllowEdit,s_StoredProcedure)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@s_Name,@s_Type,@s_ValueRule,@s_Description,@s_Classification,@s_AllowEdit,@s_StoredProcedure)");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ValueRule", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Classification", SqlDbType.NVarChar,50),
					new SqlParameter("@s_AllowEdit", SqlDbType.NVarChar,1),
					new SqlParameter("@s_StoredProcedure", SqlDbType.NVarChar,500)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_Type;
			parameters[3].Value = model.s_ValueRule;
			parameters[4].Value = model.s_Description;
			parameters[5].Value = model.s_Classification;
			parameters[6].Value = model.s_AllowEdit;
			parameters[7].Value = model.s_StoredProcedure;

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
		public bool Update(IPSP.Model.TFCode_Deadline model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TFCode_Deadline set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_Type=@s_Type,");
			strSql.Append("s_ValueRule=@s_ValueRule,");
			strSql.Append("s_Description=@s_Description,");
			strSql.Append("s_Classification=@s_Classification,");
			strSql.Append("s_AllowEdit=@s_AllowEdit,");
			strSql.Append("s_StoredProcedure=@s_StoredProcedure");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ValueRule", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Classification", SqlDbType.NVarChar,50),
					new SqlParameter("@s_AllowEdit", SqlDbType.NVarChar,1),
					new SqlParameter("@s_StoredProcedure", SqlDbType.NVarChar,500),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_Type;
			parameters[2].Value = model.s_ValueRule;
			parameters[3].Value = model.s_Description;
			parameters[4].Value = model.s_Classification;
			parameters[5].Value = model.s_AllowEdit;
			parameters[6].Value = model.s_StoredProcedure;
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
			strSql.Append("delete from TFCode_Deadline ");
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
			strSql.Append("delete from TFCode_Deadline ");
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
		public IPSP.Model.TFCode_Deadline GetModel(Guid g_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,s_Name,s_Type,s_ValueRule,s_Description,s_Classification,s_AllowEdit,s_StoredProcedure from TFCode_Deadline ");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			IPSP.Model.TFCode_Deadline model=new IPSP.Model.TFCode_Deadline();
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
		public IPSP.Model.TFCode_Deadline DataRowToModel(DataRow row)
		{
			IPSP.Model.TFCode_Deadline model=new IPSP.Model.TFCode_Deadline();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_Type"]!=null)
				{
					model.s_Type=row["s_Type"].ToString();
				}
				if(row["s_ValueRule"]!=null)
				{
					model.s_ValueRule=row["s_ValueRule"].ToString();
				}
				if(row["s_Description"]!=null)
				{
					model.s_Description=row["s_Description"].ToString();
				}
				if(row["s_Classification"]!=null)
				{
					model.s_Classification=row["s_Classification"].ToString();
				}
				if(row["s_AllowEdit"]!=null)
				{
					model.s_AllowEdit=row["s_AllowEdit"].ToString();
				}
				if(row["s_StoredProcedure"]!=null)
				{
					model.s_StoredProcedure=row["s_StoredProcedure"].ToString();
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
			strSql.Append("select g_ID,s_Name,s_Type,s_ValueRule,s_Description,s_Classification,s_AllowEdit,s_StoredProcedure ");
			strSql.Append(" FROM TFCode_Deadline ");
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
			strSql.Append(" g_ID,s_Name,s_Type,s_ValueRule,s_Description,s_Classification,s_AllowEdit,s_StoredProcedure ");
			strSql.Append(" FROM TFCode_Deadline ");
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
			strSql.Append("select count(1) FROM TFCode_Deadline ");
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
			strSql.Append(")AS Row, T.*  from TFCode_Deadline T ");
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
			parameters[0].Value = "TFCode_Deadline";
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

