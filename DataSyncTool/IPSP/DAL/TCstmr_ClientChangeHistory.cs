/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_ClientChangeHistory.cs
*
* 功 能： N/A
* 类 名： TCstmr_ClientChangeHistory
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:42   N/A    初版
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
	/// 数据访问类:TCstmr_ClientChangeHistory
	/// </summary>
	public partial class TCstmr_ClientChangeHistory
	{
		public TCstmr_ClientChangeHistory()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ClientID", "TCstmr_ClientChangeHistory"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ClientID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCstmr_ClientChangeHistory");
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
		public int Add(IPSP.Model.TCstmr_ClientChangeHistory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCstmr_ClientChangeHistory(");
			strSql.Append("n_ClientID,s_ChangeProject,s_ChangeFrom,s_ChangeTo,dt_ChangeDate,s_Notes)");
			strSql.Append(" values (");
			strSql.Append("@n_ClientID,@s_ChangeProject,@s_ChangeFrom,@s_ChangeTo,@dt_ChangeDate,@s_Notes)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@s_ChangeProject", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ChangeFrom", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_ChangeTo", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_ChangeDate", SqlDbType.DateTime),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800)};
			parameters[0].Value = model.n_ClientID;
			parameters[1].Value = model.s_ChangeProject;
			parameters[2].Value = model.s_ChangeFrom;
			parameters[3].Value = model.s_ChangeTo;
			parameters[4].Value = model.dt_ChangeDate;
			parameters[5].Value = model.s_Notes;

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
		public bool Update(IPSP.Model.TCstmr_ClientChangeHistory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCstmr_ClientChangeHistory set ");
			strSql.Append("s_ChangeProject=@s_ChangeProject,");
			strSql.Append("s_ChangeFrom=@s_ChangeFrom,");
			strSql.Append("s_ChangeTo=@s_ChangeTo,");
			strSql.Append("dt_ChangeDate=@dt_ChangeDate,");
			strSql.Append("s_Notes=@s_Notes");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ChangeProject", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ChangeFrom", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_ChangeTo", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_ChangeDate", SqlDbType.DateTime),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_ChangeProject;
			parameters[1].Value = model.s_ChangeFrom;
			parameters[2].Value = model.s_ChangeTo;
			parameters[3].Value = model.dt_ChangeDate;
			parameters[4].Value = model.s_Notes;
			parameters[5].Value = model.n_ID;
			parameters[6].Value = model.n_ClientID;

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
			strSql.Append("delete from TCstmr_ClientChangeHistory ");
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
			strSql.Append("delete from TCstmr_ClientChangeHistory ");
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
			strSql.Append("delete from TCstmr_ClientChangeHistory ");
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
		public IPSP.Model.TCstmr_ClientChangeHistory GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_ClientID,s_ChangeProject,s_ChangeFrom,s_ChangeTo,dt_ChangeDate,s_Notes from TCstmr_ClientChangeHistory ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCstmr_ClientChangeHistory model=new IPSP.Model.TCstmr_ClientChangeHistory();
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
		public IPSP.Model.TCstmr_ClientChangeHistory DataRowToModel(DataRow row)
		{
			IPSP.Model.TCstmr_ClientChangeHistory model=new IPSP.Model.TCstmr_ClientChangeHistory();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["s_ChangeProject"]!=null)
				{
					model.s_ChangeProject=row["s_ChangeProject"].ToString();
				}
				if(row["s_ChangeFrom"]!=null)
				{
					model.s_ChangeFrom=row["s_ChangeFrom"].ToString();
				}
				if(row["s_ChangeTo"]!=null)
				{
					model.s_ChangeTo=row["s_ChangeTo"].ToString();
				}
				if(row["dt_ChangeDate"]!=null && row["dt_ChangeDate"].ToString()!="")
				{
					model.dt_ChangeDate=DateTime.Parse(row["dt_ChangeDate"].ToString());
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
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
			strSql.Append("select n_ID,n_ClientID,s_ChangeProject,s_ChangeFrom,s_ChangeTo,dt_ChangeDate,s_Notes ");
			strSql.Append(" FROM TCstmr_ClientChangeHistory ");
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
			strSql.Append(" n_ID,n_ClientID,s_ChangeProject,s_ChangeFrom,s_ChangeTo,dt_ChangeDate,s_Notes ");
			strSql.Append(" FROM TCstmr_ClientChangeHistory ");
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
			strSql.Append("select count(1) FROM TCstmr_ClientChangeHistory ");
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
			strSql.Append(")AS Row, T.*  from TCstmr_ClientChangeHistory T ");
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
			parameters[0].Value = "TCstmr_ClientChangeHistory";
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

