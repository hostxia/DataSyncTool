/**  版本信息模板在安装目录下，可自行修改。
* TF_TaskChain.cs
*
* 功 能： N/A
* 类 名： TF_TaskChain
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:19   N/A    初版
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
	/// 数据访问类:TF_TaskChain
	/// </summary>
	public partial class TF_TaskChain
	{
		public TF_TaskChain()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TF_TaskChain");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TF_TaskChain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TF_TaskChain(");
			strSql.Append("g_ID,g_CodeTaskChainGuid,s_Name,s_Description,s_State,s_TriggerType,s_RelatedObjectType,n_RelatedObjectID,s_RelatedInfo1,s_RelatedInfo2,n_Creator,dt_CreateTime,n_Editor,dt_EditTime,n_TaskChainTypeID)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@g_CodeTaskChainGuid,@s_Name,@s_Description,@s_State,@s_TriggerType,@s_RelatedObjectType,@n_RelatedObjectID,@s_RelatedInfo1,@s_RelatedInfo2,@n_Creator,@dt_CreateTime,@n_Editor,@dt_EditTime,@n_TaskChainTypeID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_CodeTaskChainGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@s_State", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TriggerType", SqlDbType.NVarChar,100),
					new SqlParameter("@s_RelatedObjectType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_RelatedObjectID", SqlDbType.Int,4),
					new SqlParameter("@s_RelatedInfo1", SqlDbType.NVarChar,450),
					new SqlParameter("@s_RelatedInfo2", SqlDbType.NVarChar,450),
					new SqlParameter("@n_Creator", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@n_Editor", SqlDbType.Int,4),
					new SqlParameter("@dt_EditTime", SqlDbType.DateTime),
					new SqlParameter("@n_TaskChainTypeID", SqlDbType.Int,4)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = model.s_Name;
			parameters[3].Value = model.s_Description;
			parameters[4].Value = model.s_State;
			parameters[5].Value = model.s_TriggerType;
			parameters[6].Value = model.s_RelatedObjectType;
			parameters[7].Value = model.n_RelatedObjectID;
			parameters[8].Value = model.s_RelatedInfo1;
			parameters[9].Value = model.s_RelatedInfo2;
			parameters[10].Value = model.n_Creator;
			parameters[11].Value = model.dt_CreateTime;
			parameters[12].Value = model.n_Editor;
			parameters[13].Value = model.dt_EditTime;
			parameters[14].Value = model.n_TaskChainTypeID;

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
		public bool Update(IPSP.Model.TF_TaskChain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TF_TaskChain set ");
			strSql.Append("g_CodeTaskChainGuid=@g_CodeTaskChainGuid,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_Description=@s_Description,");
			strSql.Append("s_State=@s_State,");
			strSql.Append("s_TriggerType=@s_TriggerType,");
			strSql.Append("s_RelatedObjectType=@s_RelatedObjectType,");
			strSql.Append("n_RelatedObjectID=@n_RelatedObjectID,");
			strSql.Append("s_RelatedInfo1=@s_RelatedInfo1,");
			strSql.Append("s_RelatedInfo2=@s_RelatedInfo2,");
			strSql.Append("n_Creator=@n_Creator,");
			strSql.Append("dt_CreateTime=@dt_CreateTime,");
			strSql.Append("n_Editor=@n_Editor,");
			strSql.Append("dt_EditTime=@dt_EditTime,");
			strSql.Append("n_TaskChainTypeID=@n_TaskChainTypeID");
			strSql.Append(" where n_Num=@n_Num");
			SqlParameter[] parameters = {
					new SqlParameter("@g_CodeTaskChainGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@s_State", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TriggerType", SqlDbType.NVarChar,100),
					new SqlParameter("@s_RelatedObjectType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_RelatedObjectID", SqlDbType.Int,4),
					new SqlParameter("@s_RelatedInfo1", SqlDbType.NVarChar,450),
					new SqlParameter("@s_RelatedInfo2", SqlDbType.NVarChar,450),
					new SqlParameter("@n_Creator", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@n_Editor", SqlDbType.Int,4),
					new SqlParameter("@dt_EditTime", SqlDbType.DateTime),
					new SqlParameter("@n_TaskChainTypeID", SqlDbType.Int,4),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_Num", SqlDbType.Int,4)};
			parameters[0].Value = model.g_CodeTaskChainGuid;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_Description;
			parameters[3].Value = model.s_State;
			parameters[4].Value = model.s_TriggerType;
			parameters[5].Value = model.s_RelatedObjectType;
			parameters[6].Value = model.n_RelatedObjectID;
			parameters[7].Value = model.s_RelatedInfo1;
			parameters[8].Value = model.s_RelatedInfo2;
			parameters[9].Value = model.n_Creator;
			parameters[10].Value = model.dt_CreateTime;
			parameters[11].Value = model.n_Editor;
			parameters[12].Value = model.dt_EditTime;
			parameters[13].Value = model.n_TaskChainTypeID;
			parameters[14].Value = model.g_ID;
			parameters[15].Value = model.n_Num;

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
			strSql.Append("delete from TF_TaskChain ");
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
			strSql.Append("delete from TF_TaskChain ");
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
			strSql.Append("delete from TF_TaskChain ");
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
		public IPSP.Model.TF_TaskChain GetModel(int n_Num)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,g_CodeTaskChainGuid,s_Name,s_Description,s_State,s_TriggerType,s_RelatedObjectType,n_RelatedObjectID,s_RelatedInfo1,s_RelatedInfo2,n_Creator,dt_CreateTime,n_Editor,dt_EditTime,n_TaskChainTypeID,n_Num from TF_TaskChain ");
			strSql.Append(" where n_Num=@n_Num");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Num", SqlDbType.Int,4)
			};
			parameters[0].Value = n_Num;

			IPSP.Model.TF_TaskChain model=new IPSP.Model.TF_TaskChain();
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
		public IPSP.Model.TF_TaskChain DataRowToModel(DataRow row)
		{
			IPSP.Model.TF_TaskChain model=new IPSP.Model.TF_TaskChain();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["g_CodeTaskChainGuid"]!=null && row["g_CodeTaskChainGuid"].ToString()!="")
				{
					model.g_CodeTaskChainGuid= new Guid(row["g_CodeTaskChainGuid"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_Description"]!=null)
				{
					model.s_Description=row["s_Description"].ToString();
				}
				if(row["s_State"]!=null)
				{
					model.s_State=row["s_State"].ToString();
				}
				if(row["s_TriggerType"]!=null)
				{
					model.s_TriggerType=row["s_TriggerType"].ToString();
				}
				if(row["s_RelatedObjectType"]!=null)
				{
					model.s_RelatedObjectType=row["s_RelatedObjectType"].ToString();
				}
				if(row["n_RelatedObjectID"]!=null && row["n_RelatedObjectID"].ToString()!="")
				{
					model.n_RelatedObjectID=int.Parse(row["n_RelatedObjectID"].ToString());
				}
				if(row["s_RelatedInfo1"]!=null)
				{
					model.s_RelatedInfo1=row["s_RelatedInfo1"].ToString();
				}
				if(row["s_RelatedInfo2"]!=null)
				{
					model.s_RelatedInfo2=row["s_RelatedInfo2"].ToString();
				}
				if(row["n_Creator"]!=null && row["n_Creator"].ToString()!="")
				{
					model.n_Creator=int.Parse(row["n_Creator"].ToString());
				}
				if(row["dt_CreateTime"]!=null && row["dt_CreateTime"].ToString()!="")
				{
					model.dt_CreateTime=DateTime.Parse(row["dt_CreateTime"].ToString());
				}
				if(row["n_Editor"]!=null && row["n_Editor"].ToString()!="")
				{
					model.n_Editor=int.Parse(row["n_Editor"].ToString());
				}
				if(row["dt_EditTime"]!=null && row["dt_EditTime"].ToString()!="")
				{
					model.dt_EditTime=DateTime.Parse(row["dt_EditTime"].ToString());
				}
				if(row["n_TaskChainTypeID"]!=null && row["n_TaskChainTypeID"].ToString()!="")
				{
					model.n_TaskChainTypeID=int.Parse(row["n_TaskChainTypeID"].ToString());
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
			strSql.Append("select g_ID,g_CodeTaskChainGuid,s_Name,s_Description,s_State,s_TriggerType,s_RelatedObjectType,n_RelatedObjectID,s_RelatedInfo1,s_RelatedInfo2,n_Creator,dt_CreateTime,n_Editor,dt_EditTime,n_TaskChainTypeID,n_Num ");
			strSql.Append(" FROM TF_TaskChain ");
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
			strSql.Append(" g_ID,g_CodeTaskChainGuid,s_Name,s_Description,s_State,s_TriggerType,s_RelatedObjectType,n_RelatedObjectID,s_RelatedInfo1,s_RelatedInfo2,n_Creator,dt_CreateTime,n_Editor,dt_EditTime,n_TaskChainTypeID,n_Num ");
			strSql.Append(" FROM TF_TaskChain ");
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
			strSql.Append("select count(1) FROM TF_TaskChain ");
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
			strSql.Append(")AS Row, T.*  from TF_TaskChain T ");
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
			parameters[0].Value = "TF_TaskChain";
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

