/**  版本信息模板在安装目录下，可自行修改。
* T_Contract.cs
*
* 功 能： N/A
* 类 名： T_Contract
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:37   N/A    初版
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
	/// 数据访问类:T_Contract
	/// </summary>
	public partial class T_Contract
	{
		public T_Contract()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ClientID", "T_Contract"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ClientID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Contract");
			strSql.Append(" where n_ClientID=@n_ClientID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_Contract model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Contract(");
			strSql.Append("dt_ContractDate,s_CNO,s_CState,n_ClientID,s_Note,s_FilePath,s_Creator,dt_CreateDate,s_Editor,dt_EditDate)");
			strSql.Append(" values (");
			strSql.Append("@dt_ContractDate,@s_CNO,@s_CState,@n_ClientID,@s_Note,@s_FilePath,@s_Creator,@dt_CreateDate,@s_Editor,@dt_EditDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@dt_ContractDate", SqlDbType.DateTime),
					new SqlParameter("@s_CNO", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CState", SqlDbType.NVarChar,100),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime)};
			parameters[0].Value = model.dt_ContractDate;
			parameters[1].Value = model.s_CNO;
			parameters[2].Value = model.s_CState;
			parameters[3].Value = model.n_ClientID;
			parameters[4].Value = model.s_Note;
			parameters[5].Value = model.s_FilePath;
			parameters[6].Value = model.s_Creator;
			parameters[7].Value = model.dt_CreateDate;
			parameters[8].Value = model.s_Editor;
			parameters[9].Value = model.dt_EditDate;

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
		public bool Update(IPSP.Model.T_Contract model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Contract set ");
			strSql.Append("dt_ContractDate=@dt_ContractDate,");
			strSql.Append("s_CNO=@s_CNO,");
			strSql.Append("s_CState=@s_CState,");
			strSql.Append("s_Note=@s_Note,");
			strSql.Append("s_FilePath=@s_FilePath,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("dt_EditDate=@dt_EditDate");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@dt_ContractDate", SqlDbType.DateTime),
					new SqlParameter("@s_CNO", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CState", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_FilePath", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)};
			parameters[0].Value = model.dt_ContractDate;
			parameters[1].Value = model.s_CNO;
			parameters[2].Value = model.s_CState;
			parameters[3].Value = model.s_Note;
			parameters[4].Value = model.s_FilePath;
			parameters[5].Value = model.s_Creator;
			parameters[6].Value = model.dt_CreateDate;
			parameters[7].Value = model.s_Editor;
			parameters[8].Value = model.dt_EditDate;
			parameters[9].Value = model.n_ID;
			parameters[10].Value = model.n_ClientID;

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
			strSql.Append("delete from T_Contract ");
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
		public bool Delete(int n_ClientID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Contract ");
			strSql.Append(" where n_ClientID=@n_ClientID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
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
			strSql.Append("delete from T_Contract ");
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
		public IPSP.Model.T_Contract GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,dt_ContractDate,s_CNO,s_CState,n_ClientID,s_Note,s_FilePath,s_Creator,dt_CreateDate,s_Editor,dt_EditDate from T_Contract ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_Contract model=new IPSP.Model.T_Contract();
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
		public IPSP.Model.T_Contract DataRowToModel(DataRow row)
		{
			IPSP.Model.T_Contract model=new IPSP.Model.T_Contract();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["dt_ContractDate"]!=null && row["dt_ContractDate"].ToString()!="")
				{
					model.dt_ContractDate=DateTime.Parse(row["dt_ContractDate"].ToString());
				}
				if(row["s_CNO"]!=null)
				{
					model.s_CNO=row["s_CNO"].ToString();
				}
				if(row["s_CState"]!=null)
				{
					model.s_CState=row["s_CState"].ToString();
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
				}
				if(row["s_FilePath"]!=null)
				{
					model.s_FilePath=row["s_FilePath"].ToString();
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
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
			strSql.Append("select n_ID,dt_ContractDate,s_CNO,s_CState,n_ClientID,s_Note,s_FilePath,s_Creator,dt_CreateDate,s_Editor,dt_EditDate ");
			strSql.Append(" FROM T_Contract ");
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
			strSql.Append(" n_ID,dt_ContractDate,s_CNO,s_CState,n_ClientID,s_Note,s_FilePath,s_Creator,dt_CreateDate,s_Editor,dt_EditDate ");
			strSql.Append(" FROM T_Contract ");
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
			strSql.Append("select count(1) FROM T_Contract ");
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
			strSql.Append(")AS Row, T.*  from T_Contract T ");
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
			parameters[0].Value = "T_Contract";
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

