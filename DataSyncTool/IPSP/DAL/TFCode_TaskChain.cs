/**  版本信息模板在安装目录下，可自行修改。
* TFCode_TaskChain.cs
*
* 功 能： N/A
* 类 名： TFCode_TaskChain
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:51   N/A    初版
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
	/// 数据访问类:TFCode_TaskChain
	/// </summary>
	public partial class TFCode_TaskChain
	{
		public TFCode_TaskChain()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ObjectType", "TFCode_TaskChain"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID,int ObjectType)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TFCode_TaskChain");
			strSql.Append(" where g_ID=@g_ID and ObjectType=@ObjectType ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ObjectType", SqlDbType.Int,4)			};
			parameters[0].Value = g_ID;
			parameters[1].Value = ObjectType;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TFCode_TaskChain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TFCode_TaskChain(");
			strSql.Append("g_ID,s_Code,s_Name,s_Description,s_State,n_TaskChainTypeID,s_TriggerType,s_TriggerCaseIPType,s_TriggerCameFileIDs,n_Creator,dt_CreateTime,n_Editor,dt_EditTime,s_FinishCondition,ObjectType,s_TriggerScope)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@s_Code,@s_Name,@s_Description,@s_State,@n_TaskChainTypeID,@s_TriggerType,@s_TriggerCaseIPType,@s_TriggerCameFileIDs,@n_Creator,@dt_CreateTime,@n_Editor,@dt_EditTime,@s_FinishCondition,@ObjectType,@s_TriggerScope)");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Code", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_State", SqlDbType.NVarChar,1),
					new SqlParameter("@n_TaskChainTypeID", SqlDbType.Int,4),
					new SqlParameter("@s_TriggerType", SqlDbType.NVarChar,100),
					new SqlParameter("@s_TriggerCaseIPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TriggerCameFileIDs", SqlDbType.NVarChar,-1),
					new SqlParameter("@n_Creator", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@n_Editor", SqlDbType.Int,4),
					new SqlParameter("@dt_EditTime", SqlDbType.DateTime),
					new SqlParameter("@s_FinishCondition", SqlDbType.NVarChar,1000),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@s_TriggerScope", SqlDbType.NVarChar,1)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.s_Code;
			parameters[2].Value = model.s_Name;
			parameters[3].Value = model.s_Description;
			parameters[4].Value = model.s_State;
			parameters[5].Value = model.n_TaskChainTypeID;
			parameters[6].Value = model.s_TriggerType;
			parameters[7].Value = model.s_TriggerCaseIPType;
			parameters[8].Value = model.s_TriggerCameFileIDs;
			parameters[9].Value = model.n_Creator;
			parameters[10].Value = model.dt_CreateTime;
			parameters[11].Value = model.n_Editor;
			parameters[12].Value = model.dt_EditTime;
			parameters[13].Value = model.s_FinishCondition;
			parameters[14].Value = model.ObjectType;
			parameters[15].Value = model.s_TriggerScope;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(IPSP.Model.TFCode_TaskChain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TFCode_TaskChain set ");
			strSql.Append("s_Code=@s_Code,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_Description=@s_Description,");
			strSql.Append("s_State=@s_State,");
			strSql.Append("n_TaskChainTypeID=@n_TaskChainTypeID,");
			strSql.Append("s_TriggerType=@s_TriggerType,");
			strSql.Append("s_TriggerCaseIPType=@s_TriggerCaseIPType,");
			strSql.Append("s_TriggerCameFileIDs=@s_TriggerCameFileIDs,");
			strSql.Append("n_Creator=@n_Creator,");
			strSql.Append("dt_CreateTime=@dt_CreateTime,");
			strSql.Append("n_Editor=@n_Editor,");
			strSql.Append("dt_EditTime=@dt_EditTime,");
			strSql.Append("s_FinishCondition=@s_FinishCondition,");
			strSql.Append("s_TriggerScope=@s_TriggerScope");
			strSql.Append(" where g_ID=@g_ID and ObjectType=@ObjectType ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Code", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_State", SqlDbType.NVarChar,1),
					new SqlParameter("@n_TaskChainTypeID", SqlDbType.Int,4),
					new SqlParameter("@s_TriggerType", SqlDbType.NVarChar,100),
					new SqlParameter("@s_TriggerCaseIPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TriggerCameFileIDs", SqlDbType.NVarChar,-1),
					new SqlParameter("@n_Creator", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateTime", SqlDbType.DateTime),
					new SqlParameter("@n_Editor", SqlDbType.Int,4),
					new SqlParameter("@dt_EditTime", SqlDbType.DateTime),
					new SqlParameter("@s_FinishCondition", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_TriggerScope", SqlDbType.NVarChar,1),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ObjectType", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Code;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_Description;
			parameters[3].Value = model.s_State;
			parameters[4].Value = model.n_TaskChainTypeID;
			parameters[5].Value = model.s_TriggerType;
			parameters[6].Value = model.s_TriggerCaseIPType;
			parameters[7].Value = model.s_TriggerCameFileIDs;
			parameters[8].Value = model.n_Creator;
			parameters[9].Value = model.dt_CreateTime;
			parameters[10].Value = model.n_Editor;
			parameters[11].Value = model.dt_EditTime;
			parameters[12].Value = model.s_FinishCondition;
			parameters[13].Value = model.s_TriggerScope;
			parameters[14].Value = model.g_ID;
			parameters[15].Value = model.ObjectType;

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
		public bool Delete(Guid g_ID,int ObjectType)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TFCode_TaskChain ");
			strSql.Append(" where g_ID=@g_ID and ObjectType=@ObjectType ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ObjectType", SqlDbType.Int,4)			};
			parameters[0].Value = g_ID;
			parameters[1].Value = ObjectType;

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
		/// 得到一个对象实体
		/// </summary>
		public IPSP.Model.TFCode_TaskChain GetModel(Guid g_ID,int ObjectType)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,s_Code,s_Name,s_Description,s_State,n_TaskChainTypeID,s_TriggerType,s_TriggerCaseIPType,s_TriggerCameFileIDs,n_Creator,dt_CreateTime,n_Editor,dt_EditTime,s_FinishCondition,ObjectType,s_TriggerScope from TFCode_TaskChain ");
			strSql.Append(" where g_ID=@g_ID and ObjectType=@ObjectType ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ObjectType", SqlDbType.Int,4)			};
			parameters[0].Value = g_ID;
			parameters[1].Value = ObjectType;

			IPSP.Model.TFCode_TaskChain model=new IPSP.Model.TFCode_TaskChain();
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
		public IPSP.Model.TFCode_TaskChain DataRowToModel(DataRow row)
		{
			IPSP.Model.TFCode_TaskChain model=new IPSP.Model.TFCode_TaskChain();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["s_Code"]!=null)
				{
					model.s_Code=row["s_Code"].ToString();
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
				if(row["n_TaskChainTypeID"]!=null && row["n_TaskChainTypeID"].ToString()!="")
				{
					model.n_TaskChainTypeID=int.Parse(row["n_TaskChainTypeID"].ToString());
				}
				if(row["s_TriggerType"]!=null)
				{
					model.s_TriggerType=row["s_TriggerType"].ToString();
				}
				if(row["s_TriggerCaseIPType"]!=null)
				{
					model.s_TriggerCaseIPType=row["s_TriggerCaseIPType"].ToString();
				}
				if(row["s_TriggerCameFileIDs"]!=null)
				{
					model.s_TriggerCameFileIDs=row["s_TriggerCameFileIDs"].ToString();
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
				if(row["s_FinishCondition"]!=null)
				{
					model.s_FinishCondition=row["s_FinishCondition"].ToString();
				}
				if(row["ObjectType"]!=null && row["ObjectType"].ToString()!="")
				{
					model.ObjectType=int.Parse(row["ObjectType"].ToString());
				}
				if(row["s_TriggerScope"]!=null)
				{
					model.s_TriggerScope=row["s_TriggerScope"].ToString();
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
			strSql.Append("select g_ID,s_Code,s_Name,s_Description,s_State,n_TaskChainTypeID,s_TriggerType,s_TriggerCaseIPType,s_TriggerCameFileIDs,n_Creator,dt_CreateTime,n_Editor,dt_EditTime,s_FinishCondition,ObjectType,s_TriggerScope ");
			strSql.Append(" FROM TFCode_TaskChain ");
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
			strSql.Append(" g_ID,s_Code,s_Name,s_Description,s_State,n_TaskChainTypeID,s_TriggerType,s_TriggerCaseIPType,s_TriggerCameFileIDs,n_Creator,dt_CreateTime,n_Editor,dt_EditTime,s_FinishCondition,ObjectType,s_TriggerScope ");
			strSql.Append(" FROM TFCode_TaskChain ");
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
			strSql.Append("select count(1) FROM TFCode_TaskChain ");
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
				strSql.Append("order by T.ObjectType desc");
			}
			strSql.Append(")AS Row, T.*  from TFCode_TaskChain T ");
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
			parameters[0].Value = "TFCode_TaskChain";
			parameters[1].Value = "ObjectType";
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

