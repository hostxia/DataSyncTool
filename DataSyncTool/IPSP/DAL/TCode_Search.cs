/**  版本信息模板在安装目录下，可自行修改。
* TCode_Search.cs
*
* 功 能： N/A
* 类 名： TCode_Search
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:55   N/A    初版
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
	/// 数据访问类:TCode_Search
	/// </summary>
	public partial class TCode_Search
	{
		public TCode_Search()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_SearchID", "TCode_Search"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_SearchID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_Search");
			strSql.Append(" where n_SearchID=@n_SearchID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_SearchID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_SearchID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_Search model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_Search(");
			strSql.Append("s_SearchCondition,s_OrderBy,s_SearchName,s_IsSystemSearch,s_ModuleName,n_Sequence,dt_CreateDate,dt_EditDate,s_Description,s_IPType,n_EmployeeID)");
			strSql.Append(" values (");
			strSql.Append("@s_SearchCondition,@s_OrderBy,@s_SearchName,@s_IsSystemSearch,@s_ModuleName,@n_Sequence,@dt_CreateDate,@dt_EditDate,@s_Description,@s_IPType,@n_EmployeeID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_SearchCondition", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_OrderBy", SqlDbType.NVarChar,200),
					new SqlParameter("@s_SearchName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_IsSystemSearch", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ModuleName", SqlDbType.NVarChar,20),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,800),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,100),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_SearchCondition;
			parameters[1].Value = model.s_OrderBy;
			parameters[2].Value = model.s_SearchName;
			parameters[3].Value = model.s_IsSystemSearch;
			parameters[4].Value = model.s_ModuleName;
			parameters[5].Value = model.n_Sequence;
			parameters[6].Value = model.dt_CreateDate;
			parameters[7].Value = model.dt_EditDate;
			parameters[8].Value = model.s_Description;
			parameters[9].Value = model.s_IPType;
			parameters[10].Value = model.n_EmployeeID;

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
		public bool Update(IPSP.Model.TCode_Search model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_Search set ");
			strSql.Append("s_SearchCondition=@s_SearchCondition,");
			strSql.Append("s_OrderBy=@s_OrderBy,");
			strSql.Append("s_SearchName=@s_SearchName,");
			strSql.Append("s_IsSystemSearch=@s_IsSystemSearch,");
			strSql.Append("s_ModuleName=@s_ModuleName,");
			strSql.Append("n_Sequence=@n_Sequence,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_Description=@s_Description,");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("n_EmployeeID=@n_EmployeeID");
			strSql.Append(" where n_SearchID=@n_SearchID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_SearchCondition", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_OrderBy", SqlDbType.NVarChar,200),
					new SqlParameter("@s_SearchName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_IsSystemSearch", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ModuleName", SqlDbType.NVarChar,20),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,800),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,100),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@n_SearchID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_SearchCondition;
			parameters[1].Value = model.s_OrderBy;
			parameters[2].Value = model.s_SearchName;
			parameters[3].Value = model.s_IsSystemSearch;
			parameters[4].Value = model.s_ModuleName;
			parameters[5].Value = model.n_Sequence;
			parameters[6].Value = model.dt_CreateDate;
			parameters[7].Value = model.dt_EditDate;
			parameters[8].Value = model.s_Description;
			parameters[9].Value = model.s_IPType;
			parameters[10].Value = model.n_EmployeeID;
			parameters[11].Value = model.n_SearchID;

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
		public bool Delete(int n_SearchID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_Search ");
			strSql.Append(" where n_SearchID=@n_SearchID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_SearchID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_SearchID;

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
		public bool DeleteList(string n_SearchIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_Search ");
			strSql.Append(" where n_SearchID in ("+n_SearchIDlist + ")  ");
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
		public IPSP.Model.TCode_Search GetModel(int n_SearchID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_SearchID,s_SearchCondition,s_OrderBy,s_SearchName,s_IsSystemSearch,s_ModuleName,n_Sequence,dt_CreateDate,dt_EditDate,s_Description,s_IPType,n_EmployeeID from TCode_Search ");
			strSql.Append(" where n_SearchID=@n_SearchID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_SearchID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_SearchID;

			IPSP.Model.TCode_Search model=new IPSP.Model.TCode_Search();
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
		public IPSP.Model.TCode_Search DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_Search model=new IPSP.Model.TCode_Search();
			if (row != null)
			{
				if(row["n_SearchID"]!=null && row["n_SearchID"].ToString()!="")
				{
					model.n_SearchID=int.Parse(row["n_SearchID"].ToString());
				}
				if(row["s_SearchCondition"]!=null)
				{
					model.s_SearchCondition=row["s_SearchCondition"].ToString();
				}
				if(row["s_OrderBy"]!=null)
				{
					model.s_OrderBy=row["s_OrderBy"].ToString();
				}
				if(row["s_SearchName"]!=null)
				{
					model.s_SearchName=row["s_SearchName"].ToString();
				}
				if(row["s_IsSystemSearch"]!=null)
				{
					model.s_IsSystemSearch=row["s_IsSystemSearch"].ToString();
				}
				if(row["s_ModuleName"]!=null)
				{
					model.s_ModuleName=row["s_ModuleName"].ToString();
				}
				if(row["n_Sequence"]!=null && row["n_Sequence"].ToString()!="")
				{
					model.n_Sequence=int.Parse(row["n_Sequence"].ToString());
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_Description"]!=null)
				{
					model.s_Description=row["s_Description"].ToString();
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["n_EmployeeID"]!=null && row["n_EmployeeID"].ToString()!="")
				{
					model.n_EmployeeID=int.Parse(row["n_EmployeeID"].ToString());
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
			strSql.Append("select n_SearchID,s_SearchCondition,s_OrderBy,s_SearchName,s_IsSystemSearch,s_ModuleName,n_Sequence,dt_CreateDate,dt_EditDate,s_Description,s_IPType,n_EmployeeID ");
			strSql.Append(" FROM TCode_Search ");
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
			strSql.Append(" n_SearchID,s_SearchCondition,s_OrderBy,s_SearchName,s_IsSystemSearch,s_ModuleName,n_Sequence,dt_CreateDate,dt_EditDate,s_Description,s_IPType,n_EmployeeID ");
			strSql.Append(" FROM TCode_Search ");
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
			strSql.Append("select count(1) FROM TCode_Search ");
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
				strSql.Append("order by T.n_SearchID desc");
			}
			strSql.Append(")AS Row, T.*  from TCode_Search T ");
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
			parameters[0].Value = "TCode_Search";
			parameters[1].Value = "n_SearchID";
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

