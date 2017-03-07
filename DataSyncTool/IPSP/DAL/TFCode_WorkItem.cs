/**  版本信息模板在安装目录下，可自行修改。
* TFCode_WorkItem.cs
*
* 功 能： N/A
* 类 名： TFCode_WorkItem
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:02   N/A    初版
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
	/// 数据访问类:TFCode_WorkItem
	/// </summary>
	public partial class TFCode_WorkItem
	{
		public TFCode_WorkItem()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TFCode_WorkItem"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TFCode_WorkItem");
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
		public int Add(IPSP.Model.TFCode_WorkItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TFCode_WorkItem(");
			strSql.Append("s_Name,s_Unit,s_Description,n_TypeID,n_CodeFeeID,s_ConvertToFeeMethod)");
			strSql.Append(" values (");
			strSql.Append("@s_Name,@s_Unit,@s_Description,@n_TypeID,@n_CodeFeeID,@s_ConvertToFeeMethod)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Unit", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_TypeID", SqlDbType.Int,4),
					new SqlParameter("@n_CodeFeeID", SqlDbType.Int,4),
					new SqlParameter("@s_ConvertToFeeMethod", SqlDbType.NVarChar,1)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_Unit;
			parameters[2].Value = model.s_Description;
			parameters[3].Value = model.n_TypeID;
			parameters[4].Value = model.n_CodeFeeID;
			parameters[5].Value = model.s_ConvertToFeeMethod;

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
		public bool Update(IPSP.Model.TFCode_WorkItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TFCode_WorkItem set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_Unit=@s_Unit,");
			strSql.Append("s_Description=@s_Description,");
			strSql.Append("n_TypeID=@n_TypeID,");
			strSql.Append("n_CodeFeeID=@n_CodeFeeID,");
			strSql.Append("s_ConvertToFeeMethod=@s_ConvertToFeeMethod");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Unit", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_TypeID", SqlDbType.Int,4),
					new SqlParameter("@n_CodeFeeID", SqlDbType.Int,4),
					new SqlParameter("@s_ConvertToFeeMethod", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_Unit;
			parameters[2].Value = model.s_Description;
			parameters[3].Value = model.n_TypeID;
			parameters[4].Value = model.n_CodeFeeID;
			parameters[5].Value = model.s_ConvertToFeeMethod;
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
			strSql.Append("delete from TFCode_WorkItem ");
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
			strSql.Append("delete from TFCode_WorkItem ");
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
		public IPSP.Model.TFCode_WorkItem GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_Name,s_Unit,s_Description,n_TypeID,n_CodeFeeID,s_ConvertToFeeMethod from TFCode_WorkItem ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TFCode_WorkItem model=new IPSP.Model.TFCode_WorkItem();
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
		public IPSP.Model.TFCode_WorkItem DataRowToModel(DataRow row)
		{
			IPSP.Model.TFCode_WorkItem model=new IPSP.Model.TFCode_WorkItem();
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
				if(row["s_Unit"]!=null)
				{
					model.s_Unit=row["s_Unit"].ToString();
				}
				if(row["s_Description"]!=null)
				{
					model.s_Description=row["s_Description"].ToString();
				}
				if(row["n_TypeID"]!=null && row["n_TypeID"].ToString()!="")
				{
					model.n_TypeID=int.Parse(row["n_TypeID"].ToString());
				}
				if(row["n_CodeFeeID"]!=null && row["n_CodeFeeID"].ToString()!="")
				{
					model.n_CodeFeeID=int.Parse(row["n_CodeFeeID"].ToString());
				}
				if(row["s_ConvertToFeeMethod"]!=null)
				{
					model.s_ConvertToFeeMethod=row["s_ConvertToFeeMethod"].ToString();
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
			strSql.Append("select n_ID,s_Name,s_Unit,s_Description,n_TypeID,n_CodeFeeID,s_ConvertToFeeMethod ");
			strSql.Append(" FROM TFCode_WorkItem ");
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
			strSql.Append(" n_ID,s_Name,s_Unit,s_Description,n_TypeID,n_CodeFeeID,s_ConvertToFeeMethod ");
			strSql.Append(" FROM TFCode_WorkItem ");
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
			strSql.Append("select count(1) FROM TFCode_WorkItem ");
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
			strSql.Append(")AS Row, T.*  from TFCode_WorkItem T ");
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
			parameters[0].Value = "TFCode_WorkItem";
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

