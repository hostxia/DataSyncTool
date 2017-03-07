/**  版本信息模板在安装目录下，可自行修改。
* TF_WorkItemInTaskChain.cs
*
* 功 能： N/A
* 类 名： TF_WorkItemInTaskChain
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:25   N/A    初版
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
	/// 数据访问类:TF_WorkItemInTaskChain
	/// </summary>
	public partial class TF_WorkItemInTaskChain
	{
		public TF_WorkItemInTaskChain()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TF_WorkItemInTaskChain");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TF_WorkItemInTaskChain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TF_WorkItemInTaskChain(");
			strSql.Append("g_ID,g_TaskChainGuid,n_CodeWorkItemID,s_Description,s_Note,n_RelatedFileID,n_EstimateValue,n_EstimateValueRecorder,s_EstimateValueNote,dt_EstimateValueTime,n_ActualValue,n_ActualValueRecorder,s_ActualValueNote,dt_ActualValueTime,n_Status,n_ActualServiceValue,n_HasCharge,dt_ChargeTime,n_ChargeRecorder,n_HasOfeeCharge,dt_OfeeChargeTime,n_OfeeChargeRecorder,g_TaskGuid)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@g_TaskChainGuid,@n_CodeWorkItemID,@s_Description,@s_Note,@n_RelatedFileID,@n_EstimateValue,@n_EstimateValueRecorder,@s_EstimateValueNote,@dt_EstimateValueTime,@n_ActualValue,@n_ActualValueRecorder,@s_ActualValueNote,@dt_ActualValueTime,@n_Status,@n_ActualServiceValue,@n_HasCharge,@dt_ChargeTime,@n_ChargeRecorder,@n_HasOfeeCharge,@dt_OfeeChargeTime,@n_OfeeChargeRecorder,@g_TaskGuid)");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_TaskChainGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_CodeWorkItemID", SqlDbType.Int,4),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_RelatedFileID", SqlDbType.Int,4),
					new SqlParameter("@n_EstimateValue", SqlDbType.Decimal,5),
					new SqlParameter("@n_EstimateValueRecorder", SqlDbType.Int,4),
					new SqlParameter("@s_EstimateValueNote", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_EstimateValueTime", SqlDbType.DateTime),
					new SqlParameter("@n_ActualValue", SqlDbType.Decimal,5),
					new SqlParameter("@n_ActualValueRecorder", SqlDbType.Int,4),
					new SqlParameter("@s_ActualValueNote", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_ActualValueTime", SqlDbType.DateTime),
					new SqlParameter("@n_Status", SqlDbType.Int,4),
					new SqlParameter("@n_ActualServiceValue", SqlDbType.Decimal,9),
					new SqlParameter("@n_HasCharge", SqlDbType.Int,4),
					new SqlParameter("@dt_ChargeTime", SqlDbType.DateTime),
					new SqlParameter("@n_ChargeRecorder", SqlDbType.Int,4),
					new SqlParameter("@n_HasOfeeCharge", SqlDbType.Int,4),
					new SqlParameter("@dt_OfeeChargeTime", SqlDbType.DateTime),
					new SqlParameter("@n_OfeeChargeRecorder", SqlDbType.Int,4),
					new SqlParameter("@g_TaskGuid", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = Guid.NewGuid();
			parameters[2].Value = model.n_CodeWorkItemID;
			parameters[3].Value = model.s_Description;
			parameters[4].Value = model.s_Note;
			parameters[5].Value = model.n_RelatedFileID;
			parameters[6].Value = model.n_EstimateValue;
			parameters[7].Value = model.n_EstimateValueRecorder;
			parameters[8].Value = model.s_EstimateValueNote;
			parameters[9].Value = model.dt_EstimateValueTime;
			parameters[10].Value = model.n_ActualValue;
			parameters[11].Value = model.n_ActualValueRecorder;
			parameters[12].Value = model.s_ActualValueNote;
			parameters[13].Value = model.dt_ActualValueTime;
			parameters[14].Value = model.n_Status;
			parameters[15].Value = model.n_ActualServiceValue;
			parameters[16].Value = model.n_HasCharge;
			parameters[17].Value = model.dt_ChargeTime;
			parameters[18].Value = model.n_ChargeRecorder;
			parameters[19].Value = model.n_HasOfeeCharge;
			parameters[20].Value = model.dt_OfeeChargeTime;
			parameters[21].Value = model.n_OfeeChargeRecorder;
			parameters[22].Value = Guid.NewGuid();

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
		public bool Update(IPSP.Model.TF_WorkItemInTaskChain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TF_WorkItemInTaskChain set ");
			strSql.Append("g_TaskChainGuid=@g_TaskChainGuid,");
			strSql.Append("n_CodeWorkItemID=@n_CodeWorkItemID,");
			strSql.Append("s_Description=@s_Description,");
			strSql.Append("s_Note=@s_Note,");
			strSql.Append("n_RelatedFileID=@n_RelatedFileID,");
			strSql.Append("n_EstimateValue=@n_EstimateValue,");
			strSql.Append("n_EstimateValueRecorder=@n_EstimateValueRecorder,");
			strSql.Append("s_EstimateValueNote=@s_EstimateValueNote,");
			strSql.Append("dt_EstimateValueTime=@dt_EstimateValueTime,");
			strSql.Append("n_ActualValue=@n_ActualValue,");
			strSql.Append("n_ActualValueRecorder=@n_ActualValueRecorder,");
			strSql.Append("s_ActualValueNote=@s_ActualValueNote,");
			strSql.Append("dt_ActualValueTime=@dt_ActualValueTime,");
			strSql.Append("n_Status=@n_Status,");
			strSql.Append("n_ActualServiceValue=@n_ActualServiceValue,");
			strSql.Append("n_HasCharge=@n_HasCharge,");
			strSql.Append("dt_ChargeTime=@dt_ChargeTime,");
			strSql.Append("n_ChargeRecorder=@n_ChargeRecorder,");
			strSql.Append("n_HasOfeeCharge=@n_HasOfeeCharge,");
			strSql.Append("dt_OfeeChargeTime=@dt_OfeeChargeTime,");
			strSql.Append("n_OfeeChargeRecorder=@n_OfeeChargeRecorder,");
			strSql.Append("g_TaskGuid=@g_TaskGuid");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_TaskChainGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_CodeWorkItemID", SqlDbType.Int,4),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_RelatedFileID", SqlDbType.Int,4),
					new SqlParameter("@n_EstimateValue", SqlDbType.Decimal,5),
					new SqlParameter("@n_EstimateValueRecorder", SqlDbType.Int,4),
					new SqlParameter("@s_EstimateValueNote", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_EstimateValueTime", SqlDbType.DateTime),
					new SqlParameter("@n_ActualValue", SqlDbType.Decimal,5),
					new SqlParameter("@n_ActualValueRecorder", SqlDbType.Int,4),
					new SqlParameter("@s_ActualValueNote", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_ActualValueTime", SqlDbType.DateTime),
					new SqlParameter("@n_Status", SqlDbType.Int,4),
					new SqlParameter("@n_ActualServiceValue", SqlDbType.Decimal,9),
					new SqlParameter("@n_HasCharge", SqlDbType.Int,4),
					new SqlParameter("@dt_ChargeTime", SqlDbType.DateTime),
					new SqlParameter("@n_ChargeRecorder", SqlDbType.Int,4),
					new SqlParameter("@n_HasOfeeCharge", SqlDbType.Int,4),
					new SqlParameter("@dt_OfeeChargeTime", SqlDbType.DateTime),
					new SqlParameter("@n_OfeeChargeRecorder", SqlDbType.Int,4),
					new SqlParameter("@g_TaskGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.g_TaskChainGuid;
			parameters[1].Value = model.n_CodeWorkItemID;
			parameters[2].Value = model.s_Description;
			parameters[3].Value = model.s_Note;
			parameters[4].Value = model.n_RelatedFileID;
			parameters[5].Value = model.n_EstimateValue;
			parameters[6].Value = model.n_EstimateValueRecorder;
			parameters[7].Value = model.s_EstimateValueNote;
			parameters[8].Value = model.dt_EstimateValueTime;
			parameters[9].Value = model.n_ActualValue;
			parameters[10].Value = model.n_ActualValueRecorder;
			parameters[11].Value = model.s_ActualValueNote;
			parameters[12].Value = model.dt_ActualValueTime;
			parameters[13].Value = model.n_Status;
			parameters[14].Value = model.n_ActualServiceValue;
			parameters[15].Value = model.n_HasCharge;
			parameters[16].Value = model.dt_ChargeTime;
			parameters[17].Value = model.n_ChargeRecorder;
			parameters[18].Value = model.n_HasOfeeCharge;
			parameters[19].Value = model.dt_OfeeChargeTime;
			parameters[20].Value = model.n_OfeeChargeRecorder;
			parameters[21].Value = model.g_TaskGuid;
			parameters[22].Value = model.g_ID;

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
			strSql.Append("delete from TF_WorkItemInTaskChain ");
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
		public bool DeleteList(string g_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TF_WorkItemInTaskChain ");
			strSql.Append(" where g_ID in ("+g_IDlist + ")  ");
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
		public IPSP.Model.TF_WorkItemInTaskChain GetModel(Guid g_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,g_TaskChainGuid,n_CodeWorkItemID,s_Description,s_Note,n_RelatedFileID,n_EstimateValue,n_EstimateValueRecorder,s_EstimateValueNote,dt_EstimateValueTime,n_ActualValue,n_ActualValueRecorder,s_ActualValueNote,dt_ActualValueTime,n_Status,n_ActualServiceValue,n_HasCharge,dt_ChargeTime,n_ChargeRecorder,n_HasOfeeCharge,dt_OfeeChargeTime,n_OfeeChargeRecorder,g_TaskGuid from TF_WorkItemInTaskChain ");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			IPSP.Model.TF_WorkItemInTaskChain model=new IPSP.Model.TF_WorkItemInTaskChain();
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
		public IPSP.Model.TF_WorkItemInTaskChain DataRowToModel(DataRow row)
		{
			IPSP.Model.TF_WorkItemInTaskChain model=new IPSP.Model.TF_WorkItemInTaskChain();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["g_TaskChainGuid"]!=null && row["g_TaskChainGuid"].ToString()!="")
				{
					model.g_TaskChainGuid= new Guid(row["g_TaskChainGuid"].ToString());
				}
				if(row["n_CodeWorkItemID"]!=null && row["n_CodeWorkItemID"].ToString()!="")
				{
					model.n_CodeWorkItemID=int.Parse(row["n_CodeWorkItemID"].ToString());
				}
				if(row["s_Description"]!=null)
				{
					model.s_Description=row["s_Description"].ToString();
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
				}
				if(row["n_RelatedFileID"]!=null && row["n_RelatedFileID"].ToString()!="")
				{
					model.n_RelatedFileID=int.Parse(row["n_RelatedFileID"].ToString());
				}
				if(row["n_EstimateValue"]!=null && row["n_EstimateValue"].ToString()!="")
				{
					model.n_EstimateValue=decimal.Parse(row["n_EstimateValue"].ToString());
				}
				if(row["n_EstimateValueRecorder"]!=null && row["n_EstimateValueRecorder"].ToString()!="")
				{
					model.n_EstimateValueRecorder=int.Parse(row["n_EstimateValueRecorder"].ToString());
				}
				if(row["s_EstimateValueNote"]!=null)
				{
					model.s_EstimateValueNote=row["s_EstimateValueNote"].ToString();
				}
				if(row["dt_EstimateValueTime"]!=null && row["dt_EstimateValueTime"].ToString()!="")
				{
					model.dt_EstimateValueTime=DateTime.Parse(row["dt_EstimateValueTime"].ToString());
				}
				if(row["n_ActualValue"]!=null && row["n_ActualValue"].ToString()!="")
				{
					model.n_ActualValue=decimal.Parse(row["n_ActualValue"].ToString());
				}
				if(row["n_ActualValueRecorder"]!=null && row["n_ActualValueRecorder"].ToString()!="")
				{
					model.n_ActualValueRecorder=int.Parse(row["n_ActualValueRecorder"].ToString());
				}
				if(row["s_ActualValueNote"]!=null)
				{
					model.s_ActualValueNote=row["s_ActualValueNote"].ToString();
				}
				if(row["dt_ActualValueTime"]!=null && row["dt_ActualValueTime"].ToString()!="")
				{
					model.dt_ActualValueTime=DateTime.Parse(row["dt_ActualValueTime"].ToString());
				}
				if(row["n_Status"]!=null && row["n_Status"].ToString()!="")
				{
					model.n_Status=int.Parse(row["n_Status"].ToString());
				}
				if(row["n_ActualServiceValue"]!=null && row["n_ActualServiceValue"].ToString()!="")
				{
					model.n_ActualServiceValue=decimal.Parse(row["n_ActualServiceValue"].ToString());
				}
				if(row["n_HasCharge"]!=null && row["n_HasCharge"].ToString()!="")
				{
					model.n_HasCharge=int.Parse(row["n_HasCharge"].ToString());
				}
				if(row["dt_ChargeTime"]!=null && row["dt_ChargeTime"].ToString()!="")
				{
					model.dt_ChargeTime=DateTime.Parse(row["dt_ChargeTime"].ToString());
				}
				if(row["n_ChargeRecorder"]!=null && row["n_ChargeRecorder"].ToString()!="")
				{
					model.n_ChargeRecorder=int.Parse(row["n_ChargeRecorder"].ToString());
				}
				if(row["n_HasOfeeCharge"]!=null && row["n_HasOfeeCharge"].ToString()!="")
				{
					model.n_HasOfeeCharge=int.Parse(row["n_HasOfeeCharge"].ToString());
				}
				if(row["dt_OfeeChargeTime"]!=null && row["dt_OfeeChargeTime"].ToString()!="")
				{
					model.dt_OfeeChargeTime=DateTime.Parse(row["dt_OfeeChargeTime"].ToString());
				}
				if(row["n_OfeeChargeRecorder"]!=null && row["n_OfeeChargeRecorder"].ToString()!="")
				{
					model.n_OfeeChargeRecorder=int.Parse(row["n_OfeeChargeRecorder"].ToString());
				}
				if(row["g_TaskGuid"]!=null && row["g_TaskGuid"].ToString()!="")
				{
					model.g_TaskGuid= new Guid(row["g_TaskGuid"].ToString());
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
			strSql.Append("select g_ID,g_TaskChainGuid,n_CodeWorkItemID,s_Description,s_Note,n_RelatedFileID,n_EstimateValue,n_EstimateValueRecorder,s_EstimateValueNote,dt_EstimateValueTime,n_ActualValue,n_ActualValueRecorder,s_ActualValueNote,dt_ActualValueTime,n_Status,n_ActualServiceValue,n_HasCharge,dt_ChargeTime,n_ChargeRecorder,n_HasOfeeCharge,dt_OfeeChargeTime,n_OfeeChargeRecorder,g_TaskGuid ");
			strSql.Append(" FROM TF_WorkItemInTaskChain ");
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
			strSql.Append(" g_ID,g_TaskChainGuid,n_CodeWorkItemID,s_Description,s_Note,n_RelatedFileID,n_EstimateValue,n_EstimateValueRecorder,s_EstimateValueNote,dt_EstimateValueTime,n_ActualValue,n_ActualValueRecorder,s_ActualValueNote,dt_ActualValueTime,n_Status,n_ActualServiceValue,n_HasCharge,dt_ChargeTime,n_ChargeRecorder,n_HasOfeeCharge,dt_OfeeChargeTime,n_OfeeChargeRecorder,g_TaskGuid ");
			strSql.Append(" FROM TF_WorkItemInTaskChain ");
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
			strSql.Append("select count(1) FROM TF_WorkItemInTaskChain ");
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
				strSql.Append("order by T.g_ID desc");
			}
			strSql.Append(")AS Row, T.*  from TF_WorkItemInTaskChain T ");
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
			parameters[0].Value = "TF_WorkItemInTaskChain";
			parameters[1].Value = "g_ID";
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

