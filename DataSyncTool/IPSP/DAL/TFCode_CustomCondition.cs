/**  版本信息模板在安装目录下，可自行修改。
* TFCode_CustomCondition.cs
*
* 功 能： N/A
* 类 名： TFCode_CustomCondition
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:34   N/A    初版
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
	/// 数据访问类:TFCode_CustomCondition
	/// </summary>
	public partial class TFCode_CustomCondition
	{
		public TFCode_CustomCondition()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TFCode_CustomCondition"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TFCode_CustomCondition");
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
		public int Add(IPSP.Model.TFCode_CustomCondition model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TFCode_CustomCondition(");
			strSql.Append("s_Code,s_Name,s_Values,s_MultiSelect,s_Description)");
			strSql.Append(" values (");
			strSql.Append("@s_Code,@s_Name,@s_Values,@s_MultiSelect,@s_Description)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Code", SqlDbType.NVarChar,21),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Values", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_MultiSelect", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000)};
			parameters[0].Value = model.s_Code;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_Values;
			parameters[3].Value = model.s_MultiSelect;
			parameters[4].Value = model.s_Description;

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
		public bool Update(IPSP.Model.TFCode_CustomCondition model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TFCode_CustomCondition set ");
			strSql.Append("s_Code=@s_Code,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_Values=@s_Values,");
			strSql.Append("s_MultiSelect=@s_MultiSelect,");
			strSql.Append("s_Description=@s_Description");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Code", SqlDbType.NVarChar,21),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Values", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_MultiSelect", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Code;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_Values;
			parameters[3].Value = model.s_MultiSelect;
			parameters[4].Value = model.s_Description;
			parameters[5].Value = model.n_ID;

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
			strSql.Append("delete from TFCode_CustomCondition ");
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
			strSql.Append("delete from TFCode_CustomCondition ");
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
		public IPSP.Model.TFCode_CustomCondition GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_Code,s_Name,s_Values,s_MultiSelect,s_Description from TFCode_CustomCondition ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TFCode_CustomCondition model=new IPSP.Model.TFCode_CustomCondition();
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
		public IPSP.Model.TFCode_CustomCondition DataRowToModel(DataRow row)
		{
			IPSP.Model.TFCode_CustomCondition model=new IPSP.Model.TFCode_CustomCondition();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_Code"]!=null)
				{
					model.s_Code=row["s_Code"].ToString();
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_Values"]!=null)
				{
					model.s_Values=row["s_Values"].ToString();
				}
				if(row["s_MultiSelect"]!=null)
				{
					model.s_MultiSelect=row["s_MultiSelect"].ToString();
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
			strSql.Append("select n_ID,s_Code,s_Name,s_Values,s_MultiSelect,s_Description ");
			strSql.Append(" FROM TFCode_CustomCondition ");
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
			strSql.Append(" n_ID,s_Code,s_Name,s_Values,s_MultiSelect,s_Description ");
			strSql.Append(" FROM TFCode_CustomCondition ");
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
			strSql.Append("select count(1) FROM TFCode_CustomCondition ");
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
			strSql.Append(")AS Row, T.*  from TFCode_CustomCondition T ");
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
			parameters[0].Value = "TFCode_CustomCondition";
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

