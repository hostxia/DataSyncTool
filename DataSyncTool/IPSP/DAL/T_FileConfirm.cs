/**  版本信息模板在安装目录下，可自行修改。
* T_FileConfirm.cs
*
* 功 能： N/A
* 类 名： T_FileConfirm
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:47   N/A    初版
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
	/// 数据访问类:T_FileConfirm
	/// </summary>
	public partial class T_FileConfirm
	{
		public T_FileConfirm()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_FilesID", "T_FileConfirm"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_FilesID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_FileConfirm");
			strSql.Append(" where n_FilesID=@n_FilesID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FilesID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FilesID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_FileConfirm model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_FileConfirm(");
			strSql.Append("n_FilesID,n_ConfirmorID,s_Status,dt_ConfirmDate,s_Complete,s_DistributeType,n_DistributerID)");
			strSql.Append(" values (");
			strSql.Append("@n_FilesID,@n_ConfirmorID,@s_Status,@dt_ConfirmDate,@s_Complete,@s_DistributeType,@n_DistributerID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FilesID", SqlDbType.Int,4),
					new SqlParameter("@n_ConfirmorID", SqlDbType.Int,4),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,2),
					new SqlParameter("@dt_ConfirmDate", SqlDbType.DateTime),
					new SqlParameter("@s_Complete", SqlDbType.NVarChar,2),
					new SqlParameter("@s_DistributeType", SqlDbType.NVarChar,2),
					new SqlParameter("@n_DistributerID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_FilesID;
			parameters[1].Value = model.n_ConfirmorID;
			parameters[2].Value = model.s_Status;
			parameters[3].Value = model.dt_ConfirmDate;
			parameters[4].Value = model.s_Complete;
			parameters[5].Value = model.s_DistributeType;
			parameters[6].Value = model.n_DistributerID;

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
		public bool Update(IPSP.Model.T_FileConfirm model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_FileConfirm set ");
			strSql.Append("n_ConfirmorID=@n_ConfirmorID,");
			strSql.Append("s_Status=@s_Status,");
			strSql.Append("dt_ConfirmDate=@dt_ConfirmDate,");
			strSql.Append("s_Complete=@s_Complete,");
			strSql.Append("s_DistributeType=@s_DistributeType,");
			strSql.Append("n_DistributerID=@n_DistributerID");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ConfirmorID", SqlDbType.Int,4),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,2),
					new SqlParameter("@dt_ConfirmDate", SqlDbType.DateTime),
					new SqlParameter("@s_Complete", SqlDbType.NVarChar,2),
					new SqlParameter("@s_DistributeType", SqlDbType.NVarChar,2),
					new SqlParameter("@n_DistributerID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_FilesID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_ConfirmorID;
			parameters[1].Value = model.s_Status;
			parameters[2].Value = model.dt_ConfirmDate;
			parameters[3].Value = model.s_Complete;
			parameters[4].Value = model.s_DistributeType;
			parameters[5].Value = model.n_DistributerID;
			parameters[6].Value = model.n_ID;
			parameters[7].Value = model.n_FilesID;

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
			strSql.Append("delete from T_FileConfirm ");
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(int n_FilesID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_FileConfirm ");
			strSql.Append(" where n_FilesID=@n_FilesID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FilesID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FilesID;
			parameters[1].Value = n_ID;

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
			strSql.Append("delete from T_FileConfirm ");
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
		public IPSP.Model.T_FileConfirm GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_FilesID,n_ConfirmorID,s_Status,dt_ConfirmDate,s_Complete,s_DistributeType,n_DistributerID from T_FileConfirm ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_FileConfirm model=new IPSP.Model.T_FileConfirm();
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
		public IPSP.Model.T_FileConfirm DataRowToModel(DataRow row)
		{
			IPSP.Model.T_FileConfirm model=new IPSP.Model.T_FileConfirm();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_FilesID"]!=null && row["n_FilesID"].ToString()!="")
				{
					model.n_FilesID=int.Parse(row["n_FilesID"].ToString());
				}
				if(row["n_ConfirmorID"]!=null && row["n_ConfirmorID"].ToString()!="")
				{
					model.n_ConfirmorID=int.Parse(row["n_ConfirmorID"].ToString());
				}
				if(row["s_Status"]!=null)
				{
					model.s_Status=row["s_Status"].ToString();
				}
				if(row["dt_ConfirmDate"]!=null && row["dt_ConfirmDate"].ToString()!="")
				{
					model.dt_ConfirmDate=DateTime.Parse(row["dt_ConfirmDate"].ToString());
				}
				if(row["s_Complete"]!=null)
				{
					model.s_Complete=row["s_Complete"].ToString();
				}
				if(row["s_DistributeType"]!=null)
				{
					model.s_DistributeType=row["s_DistributeType"].ToString();
				}
				if(row["n_DistributerID"]!=null && row["n_DistributerID"].ToString()!="")
				{
					model.n_DistributerID=int.Parse(row["n_DistributerID"].ToString());
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
			strSql.Append("select n_ID,n_FilesID,n_ConfirmorID,s_Status,dt_ConfirmDate,s_Complete,s_DistributeType,n_DistributerID ");
			strSql.Append(" FROM T_FileConfirm ");
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
			strSql.Append(" n_ID,n_FilesID,n_ConfirmorID,s_Status,dt_ConfirmDate,s_Complete,s_DistributeType,n_DistributerID ");
			strSql.Append(" FROM T_FileConfirm ");
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
			strSql.Append("select count(1) FROM T_FileConfirm ");
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
			strSql.Append(")AS Row, T.*  from T_FileConfirm T ");
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
			parameters[0].Value = "T_FileConfirm";
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

