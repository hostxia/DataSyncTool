/**  版本信息模板在安装目录下，可自行修改。
* TR_RemindRecord.cs
*
* 功 能： N/A
* 类 名： TR_RemindRecord
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:00   N/A    初版
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
	/// 数据访问类:TR_RemindRecord
	/// </summary>
	public partial class TR_RemindRecord
	{
		public TR_RemindRecord()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TR_RemindRecord");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TR_RemindRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TR_RemindRecord(");
			strSql.Append("g_ID,s_RemindMode,n_EmployeeID,s_State,s_Title,s_Content,dt_StateTime,dt_CreateTime,g_RemindModeID,s_Valid)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@s_RemindMode,@n_EmployeeID,@s_State,@s_Title,@s_Content,@dt_StateTime,@dt_CreateTime,@g_RemindModeID,@s_Valid)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_RemindMode", SqlDbType.NVarChar,1),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@s_State", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Title", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Content", SqlDbType.NVarChar,-1),
					new SqlParameter("@dt_StateTime", SqlDbType.DateTime),
					new SqlParameter("@dt_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@g_RemindModeID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Valid", SqlDbType.NVarChar,1)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.s_RemindMode;
			parameters[2].Value = model.n_EmployeeID;
			parameters[3].Value = model.s_State;
			parameters[4].Value = model.s_Title;
			parameters[5].Value = model.s_Content;
			parameters[6].Value = model.dt_StateTime;
			parameters[7].Value = model.dt_CreateTime;
			parameters[8].Value = Guid.NewGuid();
			parameters[9].Value = model.s_Valid;

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
		public bool Update(IPSP.Model.TR_RemindRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TR_RemindRecord set ");
			strSql.Append("s_RemindMode=@s_RemindMode,");
			strSql.Append("n_EmployeeID=@n_EmployeeID,");
			strSql.Append("s_State=@s_State,");
			strSql.Append("s_Title=@s_Title,");
			strSql.Append("s_Content=@s_Content,");
			strSql.Append("dt_StateTime=@dt_StateTime,");
			strSql.Append("dt_CreateTime=@dt_CreateTime,");
			strSql.Append("g_RemindModeID=@g_RemindModeID,");
			strSql.Append("s_Valid=@s_Valid");
			strSql.Append(" where n_Num=@n_Num");
			SqlParameter[] parameters = {
					new SqlParameter("@s_RemindMode", SqlDbType.NVarChar,1),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@s_State", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Title", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Content", SqlDbType.NVarChar,-1),
					new SqlParameter("@dt_StateTime", SqlDbType.DateTime),
					new SqlParameter("@dt_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@g_RemindModeID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Valid", SqlDbType.NVarChar,1),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_Num", SqlDbType.Int,4)};
			parameters[0].Value = model.s_RemindMode;
			parameters[1].Value = model.n_EmployeeID;
			parameters[2].Value = model.s_State;
			parameters[3].Value = model.s_Title;
			parameters[4].Value = model.s_Content;
			parameters[5].Value = model.dt_StateTime;
			parameters[6].Value = model.dt_CreateTime;
			parameters[7].Value = model.g_RemindModeID;
			parameters[8].Value = model.s_Valid;
			parameters[9].Value = model.g_ID;
			parameters[10].Value = model.n_Num;

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
		public bool Delete(int n_Num)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TR_RemindRecord ");
			strSql.Append(" where n_Num=@n_Num");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Num", SqlDbType.Int,4)
			};
			parameters[0].Value = n_Num;

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
			strSql.Append("delete from TR_RemindRecord ");
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
		public bool DeleteList(string n_Numlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TR_RemindRecord ");
			strSql.Append(" where n_Num in ("+n_Numlist + ")  ");
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
		public IPSP.Model.TR_RemindRecord GetModel(int n_Num)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,s_RemindMode,n_EmployeeID,s_State,s_Title,s_Content,dt_StateTime,dt_CreateTime,g_RemindModeID,s_Valid,n_Num from TR_RemindRecord ");
			strSql.Append(" where n_Num=@n_Num");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Num", SqlDbType.Int,4)
			};
			parameters[0].Value = n_Num;

			IPSP.Model.TR_RemindRecord model=new IPSP.Model.TR_RemindRecord();
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
		public IPSP.Model.TR_RemindRecord DataRowToModel(DataRow row)
		{
			IPSP.Model.TR_RemindRecord model=new IPSP.Model.TR_RemindRecord();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["s_RemindMode"]!=null)
				{
					model.s_RemindMode=row["s_RemindMode"].ToString();
				}
				if(row["n_EmployeeID"]!=null && row["n_EmployeeID"].ToString()!="")
				{
					model.n_EmployeeID=int.Parse(row["n_EmployeeID"].ToString());
				}
				if(row["s_State"]!=null)
				{
					model.s_State=row["s_State"].ToString();
				}
				if(row["s_Title"]!=null)
				{
					model.s_Title=row["s_Title"].ToString();
				}
				if(row["s_Content"]!=null)
				{
					model.s_Content=row["s_Content"].ToString();
				}
				if(row["dt_StateTime"]!=null && row["dt_StateTime"].ToString()!="")
				{
					model.dt_StateTime=DateTime.Parse(row["dt_StateTime"].ToString());
				}
				if(row["dt_CreateTime"]!=null && row["dt_CreateTime"].ToString()!="")
				{
					model.dt_CreateTime=DateTime.Parse(row["dt_CreateTime"].ToString());
				}
				if(row["g_RemindModeID"]!=null && row["g_RemindModeID"].ToString()!="")
				{
					model.g_RemindModeID= new Guid(row["g_RemindModeID"].ToString());
				}
				if(row["s_Valid"]!=null)
				{
					model.s_Valid=row["s_Valid"].ToString();
				}
				if(row["n_Num"]!=null && row["n_Num"].ToString()!="")
				{
					model.n_Num=int.Parse(row["n_Num"].ToString());
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
			strSql.Append("select g_ID,s_RemindMode,n_EmployeeID,s_State,s_Title,s_Content,dt_StateTime,dt_CreateTime,g_RemindModeID,s_Valid,n_Num ");
			strSql.Append(" FROM TR_RemindRecord ");
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
			strSql.Append(" g_ID,s_RemindMode,n_EmployeeID,s_State,s_Title,s_Content,dt_StateTime,dt_CreateTime,g_RemindModeID,s_Valid,n_Num ");
			strSql.Append(" FROM TR_RemindRecord ");
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
			strSql.Append("select count(1) FROM TR_RemindRecord ");
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
				strSql.Append("order by T.n_Num desc");
			}
			strSql.Append(")AS Row, T.*  from TR_RemindRecord T ");
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
			parameters[0].Value = "TR_RemindRecord";
			parameters[1].Value = "n_Num";
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

