/**  版本信息模板在安装目录下，可自行修改。
* T_ContactMemo.cs
*
* 功 能： N/A
* 类 名： T_ContactMemo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:36   N/A    初版
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
	/// 数据访问类:T_ContactMemo
	/// </summary>
	public partial class T_ContactMemo
	{
		public T_ContactMemo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "T_ContactMemo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_ContactMemo");
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
		public int Add(IPSP.Model.T_ContactMemo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_ContactMemo(");
			strSql.Append("s_ObjectType,n_ObjectID,n_CaseID,s_Subject,s_CotactWay,s_ContactTime,n_EmployeeID,s_Memo,dt_ContactTime,s_FilePath,s_Creator,s_Editor,dt_CreateDate,dt_EditDate)");
			strSql.Append(" values (");
			strSql.Append("@s_ObjectType,@n_ObjectID,@n_CaseID,@s_Subject,@s_CotactWay,@s_ContactTime,@n_EmployeeID,@s_Memo,@dt_ContactTime,@s_FilePath,@s_Creator,@s_Editor,@dt_CreateDate,@dt_EditDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ObjectType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ObjectID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_Subject", SqlDbType.NVarChar,500),
					new SqlParameter("@s_CotactWay", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ContactTime", SqlDbType.DateTime),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@s_Memo", SqlDbType.NVarChar,2000),
					new SqlParameter("@dt_ContactTime", SqlDbType.DateTime),
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime)};
			parameters[0].Value = model.s_ObjectType;
			parameters[1].Value = model.n_ObjectID;
			parameters[2].Value = model.n_CaseID;
			parameters[3].Value = model.s_Subject;
			parameters[4].Value = model.s_CotactWay;
			parameters[5].Value = model.s_ContactTime;
			parameters[6].Value = model.n_EmployeeID;
			parameters[7].Value = model.s_Memo;
			parameters[8].Value = model.dt_ContactTime;
			parameters[9].Value = model.s_FilePath;
			parameters[10].Value = model.s_Creator;
			parameters[11].Value = model.s_Editor;
			parameters[12].Value = model.dt_CreateDate;
			parameters[13].Value = model.dt_EditDate;

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
		public bool Update(IPSP.Model.T_ContactMemo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_ContactMemo set ");
			strSql.Append("s_ObjectType=@s_ObjectType,");
			strSql.Append("n_ObjectID=@n_ObjectID,");
			strSql.Append("n_CaseID=@n_CaseID,");
			strSql.Append("s_Subject=@s_Subject,");
			strSql.Append("s_CotactWay=@s_CotactWay,");
			strSql.Append("s_ContactTime=@s_ContactTime,");
			strSql.Append("n_EmployeeID=@n_EmployeeID,");
			strSql.Append("s_Memo=@s_Memo,");
			strSql.Append("dt_ContactTime=@dt_ContactTime,");
			strSql.Append("s_FilePath=@s_FilePath,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ObjectType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ObjectID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_Subject", SqlDbType.NVarChar,500),
					new SqlParameter("@s_CotactWay", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ContactTime", SqlDbType.DateTime),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@s_Memo", SqlDbType.NVarChar,2000),
					new SqlParameter("@dt_ContactTime", SqlDbType.DateTime),
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_ObjectType;
			parameters[1].Value = model.n_ObjectID;
			parameters[2].Value = model.n_CaseID;
			parameters[3].Value = model.s_Subject;
			parameters[4].Value = model.s_CotactWay;
			parameters[5].Value = model.s_ContactTime;
			parameters[6].Value = model.n_EmployeeID;
			parameters[7].Value = model.s_Memo;
			parameters[8].Value = model.dt_ContactTime;
			parameters[9].Value = model.s_FilePath;
			parameters[10].Value = model.s_Creator;
			parameters[11].Value = model.s_Editor;
			parameters[12].Value = model.dt_CreateDate;
			parameters[13].Value = model.dt_EditDate;
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
			strSql.Append("delete from T_ContactMemo ");
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
			strSql.Append("delete from T_ContactMemo ");
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
		public IPSP.Model.T_ContactMemo GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_ObjectType,n_ObjectID,n_CaseID,s_Subject,s_CotactWay,s_ContactTime,n_EmployeeID,s_Memo,dt_ContactTime,s_FilePath,s_Creator,s_Editor,dt_CreateDate,dt_EditDate from T_ContactMemo ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_ContactMemo model=new IPSP.Model.T_ContactMemo();
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
		public IPSP.Model.T_ContactMemo DataRowToModel(DataRow row)
		{
			IPSP.Model.T_ContactMemo model=new IPSP.Model.T_ContactMemo();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_ObjectType"]!=null)
				{
					model.s_ObjectType=row["s_ObjectType"].ToString();
				}
				if(row["n_ObjectID"]!=null && row["n_ObjectID"].ToString()!="")
				{
					model.n_ObjectID=int.Parse(row["n_ObjectID"].ToString());
				}
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["s_Subject"]!=null)
				{
					model.s_Subject=row["s_Subject"].ToString();
				}
				if(row["s_CotactWay"]!=null)
				{
					model.s_CotactWay=row["s_CotactWay"].ToString();
				}
				if(row["s_ContactTime"]!=null && row["s_ContactTime"].ToString()!="")
				{
					model.s_ContactTime=DateTime.Parse(row["s_ContactTime"].ToString());
				}
				if(row["n_EmployeeID"]!=null && row["n_EmployeeID"].ToString()!="")
				{
					model.n_EmployeeID=int.Parse(row["n_EmployeeID"].ToString());
				}
				if(row["s_Memo"]!=null)
				{
					model.s_Memo=row["s_Memo"].ToString();
				}
				if(row["dt_ContactTime"]!=null && row["dt_ContactTime"].ToString()!="")
				{
					model.dt_ContactTime=DateTime.Parse(row["dt_ContactTime"].ToString());
				}
				if(row["s_FilePath"]!=null)
				{
					model.s_FilePath=row["s_FilePath"].ToString();
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
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
			strSql.Append("select n_ID,s_ObjectType,n_ObjectID,n_CaseID,s_Subject,s_CotactWay,s_ContactTime,n_EmployeeID,s_Memo,dt_ContactTime,s_FilePath,s_Creator,s_Editor,dt_CreateDate,dt_EditDate ");
			strSql.Append(" FROM T_ContactMemo ");
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
			strSql.Append(" n_ID,s_ObjectType,n_ObjectID,n_CaseID,s_Subject,s_CotactWay,s_ContactTime,n_EmployeeID,s_Memo,dt_ContactTime,s_FilePath,s_Creator,s_Editor,dt_CreateDate,dt_EditDate ");
			strSql.Append(" FROM T_ContactMemo ");
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
			strSql.Append("select count(1) FROM T_ContactMemo ");
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
			strSql.Append(")AS Row, T.*  from T_ContactMemo T ");
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
			parameters[0].Value = "T_ContactMemo";
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

