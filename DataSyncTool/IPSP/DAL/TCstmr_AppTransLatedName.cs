/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_AppTransLatedName.cs
*
* 功 能： N/A
* 类 名： TCstmr_AppTransLatedName
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:38   N/A    初版
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
	/// 数据访问类:TCstmr_AppTransLatedName
	/// </summary>
	public partial class TCstmr_AppTransLatedName
	{
		public TCstmr_AppTransLatedName()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_AppID", "TCstmr_AppTransLatedName"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_AppID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCstmr_AppTransLatedName");
			strSql.Append(" where n_AppID=@n_AppID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AppID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_AppID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCstmr_AppTransLatedName model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCstmr_AppTransLatedName(");
			strSql.Append("s_AppTransLatedName,s_TrustdeedNum,s_AppTransLatedNameUse,n_AppID)");
			strSql.Append(" values (");
			strSql.Append("@s_AppTransLatedName,@s_TrustdeedNum,@s_AppTransLatedNameUse,@n_AppID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_AppTransLatedName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_TrustdeedNum", SqlDbType.NVarChar,100),
					new SqlParameter("@s_AppTransLatedNameUse", SqlDbType.NVarChar,100),
					new SqlParameter("@n_AppID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_AppTransLatedName;
			parameters[1].Value = model.s_TrustdeedNum;
			parameters[2].Value = model.s_AppTransLatedNameUse;
			parameters[3].Value = model.n_AppID;

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
		public bool Update(IPSP.Model.TCstmr_AppTransLatedName model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCstmr_AppTransLatedName set ");
			strSql.Append("s_AppTransLatedName=@s_AppTransLatedName,");
			strSql.Append("s_TrustdeedNum=@s_TrustdeedNum,");
			strSql.Append("s_AppTransLatedNameUse=@s_AppTransLatedNameUse");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_AppTransLatedName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_TrustdeedNum", SqlDbType.NVarChar,100),
					new SqlParameter("@s_AppTransLatedNameUse", SqlDbType.NVarChar,100),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_AppID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_AppTransLatedName;
			parameters[1].Value = model.s_TrustdeedNum;
			parameters[2].Value = model.s_AppTransLatedNameUse;
			parameters[3].Value = model.n_ID;
			parameters[4].Value = model.n_AppID;

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
			strSql.Append("delete from TCstmr_AppTransLatedName ");
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
		public bool Delete(int n_AppID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_AppTransLatedName ");
			strSql.Append(" where n_AppID=@n_AppID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_AppID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_AppID;
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
			strSql.Append("delete from TCstmr_AppTransLatedName ");
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
		public IPSP.Model.TCstmr_AppTransLatedName GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_AppTransLatedName,s_TrustdeedNum,s_AppTransLatedNameUse,n_AppID from TCstmr_AppTransLatedName ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCstmr_AppTransLatedName model=new IPSP.Model.TCstmr_AppTransLatedName();
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
		public IPSP.Model.TCstmr_AppTransLatedName DataRowToModel(DataRow row)
		{
			IPSP.Model.TCstmr_AppTransLatedName model=new IPSP.Model.TCstmr_AppTransLatedName();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_AppTransLatedName"]!=null)
				{
					model.s_AppTransLatedName=row["s_AppTransLatedName"].ToString();
				}
				if(row["s_TrustdeedNum"]!=null)
				{
					model.s_TrustdeedNum=row["s_TrustdeedNum"].ToString();
				}
				if(row["s_AppTransLatedNameUse"]!=null)
				{
					model.s_AppTransLatedNameUse=row["s_AppTransLatedNameUse"].ToString();
				}
				if(row["n_AppID"]!=null && row["n_AppID"].ToString()!="")
				{
					model.n_AppID=int.Parse(row["n_AppID"].ToString());
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
			strSql.Append("select n_ID,s_AppTransLatedName,s_TrustdeedNum,s_AppTransLatedNameUse,n_AppID ");
			strSql.Append(" FROM TCstmr_AppTransLatedName ");
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
			strSql.Append(" n_ID,s_AppTransLatedName,s_TrustdeedNum,s_AppTransLatedNameUse,n_AppID ");
			strSql.Append(" FROM TCstmr_AppTransLatedName ");
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
			strSql.Append("select count(1) FROM TCstmr_AppTransLatedName ");
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
			strSql.Append(")AS Row, T.*  from TCstmr_AppTransLatedName T ");
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
			parameters[0].Value = "TCstmr_AppTransLatedName";
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

