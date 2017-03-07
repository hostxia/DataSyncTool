/**  版本信息模板在安装目录下，可自行修改。
* TCode_GridLayout.cs
*
* 功 能： N/A
* 类 名： TCode_GridLayout
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:29   N/A    初版
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
	/// 数据访问类:TCode_GridLayout
	/// </summary>
	public partial class TCode_GridLayout
	{
		public TCode_GridLayout()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TCode_GridLayout"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_GridLayout");
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
		public int Add(IPSP.Model.TCode_GridLayout model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_GridLayout(");
			strSql.Append("s_ModuleName,s_LayoutName,s_LayoutXml,s_IsSystemLayout,dt_CreateDate,dt_EditDate)");
			strSql.Append(" values (");
			strSql.Append("@s_ModuleName,@s_LayoutName,@s_LayoutXml,@s_IsSystemLayout,@dt_CreateDate,@dt_EditDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ModuleName", SqlDbType.NVarChar,20),
					new SqlParameter("@s_LayoutName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_LayoutXml", SqlDbType.NVarChar,-1),
					new SqlParameter("@s_IsSystemLayout", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime)};
			parameters[0].Value = model.s_ModuleName;
			parameters[1].Value = model.s_LayoutName;
			parameters[2].Value = model.s_LayoutXml;
			parameters[3].Value = model.s_IsSystemLayout;
			parameters[4].Value = model.dt_CreateDate;
			parameters[5].Value = model.dt_EditDate;

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
		public bool Update(IPSP.Model.TCode_GridLayout model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_GridLayout set ");
			strSql.Append("s_ModuleName=@s_ModuleName,");
			strSql.Append("s_LayoutName=@s_LayoutName,");
			strSql.Append("s_LayoutXml=@s_LayoutXml,");
			strSql.Append("s_IsSystemLayout=@s_IsSystemLayout,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ModuleName", SqlDbType.NVarChar,20),
					new SqlParameter("@s_LayoutName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_LayoutXml", SqlDbType.NVarChar,-1),
					new SqlParameter("@s_IsSystemLayout", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_ModuleName;
			parameters[1].Value = model.s_LayoutName;
			parameters[2].Value = model.s_LayoutXml;
			parameters[3].Value = model.s_IsSystemLayout;
			parameters[4].Value = model.dt_CreateDate;
			parameters[5].Value = model.dt_EditDate;
			parameters[6].Value = model.n_ID;

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
			strSql.Append("delete from TCode_GridLayout ");
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
			strSql.Append("delete from TCode_GridLayout ");
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
		public IPSP.Model.TCode_GridLayout GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_ModuleName,s_LayoutName,s_LayoutXml,s_IsSystemLayout,dt_CreateDate,dt_EditDate from TCode_GridLayout ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_GridLayout model=new IPSP.Model.TCode_GridLayout();
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
		public IPSP.Model.TCode_GridLayout DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_GridLayout model=new IPSP.Model.TCode_GridLayout();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_ModuleName"]!=null)
				{
					model.s_ModuleName=row["s_ModuleName"].ToString();
				}
				if(row["s_LayoutName"]!=null)
				{
					model.s_LayoutName=row["s_LayoutName"].ToString();
				}
				if(row["s_LayoutXml"]!=null)
				{
					model.s_LayoutXml=row["s_LayoutXml"].ToString();
				}
				if(row["s_IsSystemLayout"]!=null)
				{
					model.s_IsSystemLayout=row["s_IsSystemLayout"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
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
			strSql.Append("select n_ID,s_ModuleName,s_LayoutName,s_LayoutXml,s_IsSystemLayout,dt_CreateDate,dt_EditDate ");
			strSql.Append(" FROM TCode_GridLayout ");
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
			strSql.Append(" n_ID,s_ModuleName,s_LayoutName,s_LayoutXml,s_IsSystemLayout,dt_CreateDate,dt_EditDate ");
			strSql.Append(" FROM TCode_GridLayout ");
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
			strSql.Append("select count(1) FROM TCode_GridLayout ");
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
			strSql.Append(")AS Row, T.*  from TCode_GridLayout T ");
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
			parameters[0].Value = "TCode_GridLayout";
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

