/**  版本信息模板在安装目录下，可自行修改。
* TFCode_Task.cs
*
* 功 能： N/A
* 类 名： TFCode_Task
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:49   N/A    初版
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
	/// 数据访问类:TFCode_Task
	/// </summary>
	public partial class TFCode_Task
	{
		public TFCode_Task()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TFCode_Task");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TFCode_Task model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TFCode_Task(");
			strSql.Append("g_ID,s_Name,s_Description,n_TaskTypeID,n_DemandTypeID,n_Level,s_ExecutorType,s_ExecutorValue,s_FinishCondition,s_StartDateCalcRule,s_StartDateTaskCode,s_StartDateTaskDateType,g_StartCodeDeadlineGuid,n_StartDateValue1,s_StartDateType1,n_StartDateValue2,s_StartDateType2,s_EndDateCalcRule,s_EndDateTaskCode,s_EndDateTaskDateType,g_EndCodeDeadlineGuid,n_EndDateValue1,s_EndDateType1,n_EndDateValue2,s_EndDateType2,g_EndFinallyCodeDeadlineGuid)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@s_Name,@s_Description,@n_TaskTypeID,@n_DemandTypeID,@n_Level,@s_ExecutorType,@s_ExecutorValue,@s_FinishCondition,@s_StartDateCalcRule,@s_StartDateTaskCode,@s_StartDateTaskDateType,@g_StartCodeDeadlineGuid,@n_StartDateValue1,@s_StartDateType1,@n_StartDateValue2,@s_StartDateType2,@s_EndDateCalcRule,@s_EndDateTaskCode,@s_EndDateTaskDateType,@g_EndCodeDeadlineGuid,@n_EndDateValue1,@s_EndDateType1,@n_EndDateValue2,@s_EndDateType2,@g_EndFinallyCodeDeadlineGuid)");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,500),
					new SqlParameter("@n_TaskTypeID", SqlDbType.Int,4),
					new SqlParameter("@n_DemandTypeID", SqlDbType.Int,4),
					new SqlParameter("@n_Level", SqlDbType.Int,4),
					new SqlParameter("@s_ExecutorType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ExecutorValue", SqlDbType.NVarChar,500),
					new SqlParameter("@s_FinishCondition", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_StartDateCalcRule", SqlDbType.NVarChar,50),
					new SqlParameter("@s_StartDateTaskCode", SqlDbType.NVarChar,21),
					new SqlParameter("@s_StartDateTaskDateType", SqlDbType.NVarChar,50),
					new SqlParameter("@g_StartCodeDeadlineGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_StartDateValue1", SqlDbType.Int,4),
					new SqlParameter("@s_StartDateType1", SqlDbType.NVarChar,50),
					new SqlParameter("@n_StartDateValue2", SqlDbType.Int,4),
					new SqlParameter("@s_StartDateType2", SqlDbType.NVarChar,50),
					new SqlParameter("@s_EndDateCalcRule", SqlDbType.NVarChar,50),
					new SqlParameter("@s_EndDateTaskCode", SqlDbType.NVarChar,21),
					new SqlParameter("@s_EndDateTaskDateType", SqlDbType.NVarChar,50),
					new SqlParameter("@g_EndCodeDeadlineGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_EndDateValue1", SqlDbType.Int,4),
					new SqlParameter("@s_EndDateType1", SqlDbType.NVarChar,50),
					new SqlParameter("@n_EndDateValue2", SqlDbType.Int,4),
					new SqlParameter("@s_EndDateType2", SqlDbType.NVarChar,50),
					new SqlParameter("@g_EndFinallyCodeDeadlineGuid", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_Description;
			parameters[3].Value = model.n_TaskTypeID;
			parameters[4].Value = model.n_DemandTypeID;
			parameters[5].Value = model.n_Level;
			parameters[6].Value = model.s_ExecutorType;
			parameters[7].Value = model.s_ExecutorValue;
			parameters[8].Value = model.s_FinishCondition;
			parameters[9].Value = model.s_StartDateCalcRule;
			parameters[10].Value = model.s_StartDateTaskCode;
			parameters[11].Value = model.s_StartDateTaskDateType;
			parameters[12].Value = Guid.NewGuid();
			parameters[13].Value = model.n_StartDateValue1;
			parameters[14].Value = model.s_StartDateType1;
			parameters[15].Value = model.n_StartDateValue2;
			parameters[16].Value = model.s_StartDateType2;
			parameters[17].Value = model.s_EndDateCalcRule;
			parameters[18].Value = model.s_EndDateTaskCode;
			parameters[19].Value = model.s_EndDateTaskDateType;
			parameters[20].Value = Guid.NewGuid();
			parameters[21].Value = model.n_EndDateValue1;
			parameters[22].Value = model.s_EndDateType1;
			parameters[23].Value = model.n_EndDateValue2;
			parameters[24].Value = model.s_EndDateType2;
			parameters[25].Value = Guid.NewGuid();

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
		public bool Update(IPSP.Model.TFCode_Task model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TFCode_Task set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_Description=@s_Description,");
			strSql.Append("n_TaskTypeID=@n_TaskTypeID,");
			strSql.Append("n_DemandTypeID=@n_DemandTypeID,");
			strSql.Append("n_Level=@n_Level,");
			strSql.Append("s_ExecutorType=@s_ExecutorType,");
			strSql.Append("s_ExecutorValue=@s_ExecutorValue,");
			strSql.Append("s_FinishCondition=@s_FinishCondition,");
			strSql.Append("s_StartDateCalcRule=@s_StartDateCalcRule,");
			strSql.Append("s_StartDateTaskCode=@s_StartDateTaskCode,");
			strSql.Append("s_StartDateTaskDateType=@s_StartDateTaskDateType,");
			strSql.Append("g_StartCodeDeadlineGuid=@g_StartCodeDeadlineGuid,");
			strSql.Append("n_StartDateValue1=@n_StartDateValue1,");
			strSql.Append("s_StartDateType1=@s_StartDateType1,");
			strSql.Append("n_StartDateValue2=@n_StartDateValue2,");
			strSql.Append("s_StartDateType2=@s_StartDateType2,");
			strSql.Append("s_EndDateCalcRule=@s_EndDateCalcRule,");
			strSql.Append("s_EndDateTaskCode=@s_EndDateTaskCode,");
			strSql.Append("s_EndDateTaskDateType=@s_EndDateTaskDateType,");
			strSql.Append("g_EndCodeDeadlineGuid=@g_EndCodeDeadlineGuid,");
			strSql.Append("n_EndDateValue1=@n_EndDateValue1,");
			strSql.Append("s_EndDateType1=@s_EndDateType1,");
			strSql.Append("n_EndDateValue2=@n_EndDateValue2,");
			strSql.Append("s_EndDateType2=@s_EndDateType2,");
			strSql.Append("g_EndFinallyCodeDeadlineGuid=@g_EndFinallyCodeDeadlineGuid");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,500),
					new SqlParameter("@n_TaskTypeID", SqlDbType.Int,4),
					new SqlParameter("@n_DemandTypeID", SqlDbType.Int,4),
					new SqlParameter("@n_Level", SqlDbType.Int,4),
					new SqlParameter("@s_ExecutorType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ExecutorValue", SqlDbType.NVarChar,500),
					new SqlParameter("@s_FinishCondition", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_StartDateCalcRule", SqlDbType.NVarChar,50),
					new SqlParameter("@s_StartDateTaskCode", SqlDbType.NVarChar,21),
					new SqlParameter("@s_StartDateTaskDateType", SqlDbType.NVarChar,50),
					new SqlParameter("@g_StartCodeDeadlineGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_StartDateValue1", SqlDbType.Int,4),
					new SqlParameter("@s_StartDateType1", SqlDbType.NVarChar,50),
					new SqlParameter("@n_StartDateValue2", SqlDbType.Int,4),
					new SqlParameter("@s_StartDateType2", SqlDbType.NVarChar,50),
					new SqlParameter("@s_EndDateCalcRule", SqlDbType.NVarChar,50),
					new SqlParameter("@s_EndDateTaskCode", SqlDbType.NVarChar,21),
					new SqlParameter("@s_EndDateTaskDateType", SqlDbType.NVarChar,50),
					new SqlParameter("@g_EndCodeDeadlineGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@n_EndDateValue1", SqlDbType.Int,4),
					new SqlParameter("@s_EndDateType1", SqlDbType.NVarChar,50),
					new SqlParameter("@n_EndDateValue2", SqlDbType.Int,4),
					new SqlParameter("@s_EndDateType2", SqlDbType.NVarChar,50),
					new SqlParameter("@g_EndFinallyCodeDeadlineGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_Description;
			parameters[2].Value = model.n_TaskTypeID;
			parameters[3].Value = model.n_DemandTypeID;
			parameters[4].Value = model.n_Level;
			parameters[5].Value = model.s_ExecutorType;
			parameters[6].Value = model.s_ExecutorValue;
			parameters[7].Value = model.s_FinishCondition;
			parameters[8].Value = model.s_StartDateCalcRule;
			parameters[9].Value = model.s_StartDateTaskCode;
			parameters[10].Value = model.s_StartDateTaskDateType;
			parameters[11].Value = model.g_StartCodeDeadlineGuid;
			parameters[12].Value = model.n_StartDateValue1;
			parameters[13].Value = model.s_StartDateType1;
			parameters[14].Value = model.n_StartDateValue2;
			parameters[15].Value = model.s_StartDateType2;
			parameters[16].Value = model.s_EndDateCalcRule;
			parameters[17].Value = model.s_EndDateTaskCode;
			parameters[18].Value = model.s_EndDateTaskDateType;
			parameters[19].Value = model.g_EndCodeDeadlineGuid;
			parameters[20].Value = model.n_EndDateValue1;
			parameters[21].Value = model.s_EndDateType1;
			parameters[22].Value = model.n_EndDateValue2;
			parameters[23].Value = model.s_EndDateType2;
			parameters[24].Value = model.g_EndFinallyCodeDeadlineGuid;
			parameters[25].Value = model.g_ID;

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
			strSql.Append("delete from TFCode_Task ");
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
			strSql.Append("delete from TFCode_Task ");
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
		public IPSP.Model.TFCode_Task GetModel(Guid g_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,s_Name,s_Description,n_TaskTypeID,n_DemandTypeID,n_Level,s_ExecutorType,s_ExecutorValue,s_FinishCondition,s_StartDateCalcRule,s_StartDateTaskCode,s_StartDateTaskDateType,g_StartCodeDeadlineGuid,n_StartDateValue1,s_StartDateType1,n_StartDateValue2,s_StartDateType2,s_EndDateCalcRule,s_EndDateTaskCode,s_EndDateTaskDateType,g_EndCodeDeadlineGuid,n_EndDateValue1,s_EndDateType1,n_EndDateValue2,s_EndDateType2,g_EndFinallyCodeDeadlineGuid from TFCode_Task ");
			strSql.Append(" where g_ID=@g_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;

			IPSP.Model.TFCode_Task model=new IPSP.Model.TFCode_Task();
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
		public IPSP.Model.TFCode_Task DataRowToModel(DataRow row)
		{
			IPSP.Model.TFCode_Task model=new IPSP.Model.TFCode_Task();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_Description"]!=null)
				{
					model.s_Description=row["s_Description"].ToString();
				}
				if(row["n_TaskTypeID"]!=null && row["n_TaskTypeID"].ToString()!="")
				{
					model.n_TaskTypeID=int.Parse(row["n_TaskTypeID"].ToString());
				}
				if(row["n_DemandTypeID"]!=null && row["n_DemandTypeID"].ToString()!="")
				{
					model.n_DemandTypeID=int.Parse(row["n_DemandTypeID"].ToString());
				}
				if(row["n_Level"]!=null && row["n_Level"].ToString()!="")
				{
					model.n_Level=int.Parse(row["n_Level"].ToString());
				}
				if(row["s_ExecutorType"]!=null)
				{
					model.s_ExecutorType=row["s_ExecutorType"].ToString();
				}
				if(row["s_ExecutorValue"]!=null)
				{
					model.s_ExecutorValue=row["s_ExecutorValue"].ToString();
				}
				if(row["s_FinishCondition"]!=null)
				{
					model.s_FinishCondition=row["s_FinishCondition"].ToString();
				}
				if(row["s_StartDateCalcRule"]!=null)
				{
					model.s_StartDateCalcRule=row["s_StartDateCalcRule"].ToString();
				}
				if(row["s_StartDateTaskCode"]!=null)
				{
					model.s_StartDateTaskCode=row["s_StartDateTaskCode"].ToString();
				}
				if(row["s_StartDateTaskDateType"]!=null)
				{
					model.s_StartDateTaskDateType=row["s_StartDateTaskDateType"].ToString();
				}
				if(row["g_StartCodeDeadlineGuid"]!=null && row["g_StartCodeDeadlineGuid"].ToString()!="")
				{
					model.g_StartCodeDeadlineGuid= new Guid(row["g_StartCodeDeadlineGuid"].ToString());
				}
				if(row["n_StartDateValue1"]!=null && row["n_StartDateValue1"].ToString()!="")
				{
					model.n_StartDateValue1=int.Parse(row["n_StartDateValue1"].ToString());
				}
				if(row["s_StartDateType1"]!=null)
				{
					model.s_StartDateType1=row["s_StartDateType1"].ToString();
				}
				if(row["n_StartDateValue2"]!=null && row["n_StartDateValue2"].ToString()!="")
				{
					model.n_StartDateValue2=int.Parse(row["n_StartDateValue2"].ToString());
				}
				if(row["s_StartDateType2"]!=null)
				{
					model.s_StartDateType2=row["s_StartDateType2"].ToString();
				}
				if(row["s_EndDateCalcRule"]!=null)
				{
					model.s_EndDateCalcRule=row["s_EndDateCalcRule"].ToString();
				}
				if(row["s_EndDateTaskCode"]!=null)
				{
					model.s_EndDateTaskCode=row["s_EndDateTaskCode"].ToString();
				}
				if(row["s_EndDateTaskDateType"]!=null)
				{
					model.s_EndDateTaskDateType=row["s_EndDateTaskDateType"].ToString();
				}
				if(row["g_EndCodeDeadlineGuid"]!=null && row["g_EndCodeDeadlineGuid"].ToString()!="")
				{
					model.g_EndCodeDeadlineGuid= new Guid(row["g_EndCodeDeadlineGuid"].ToString());
				}
				if(row["n_EndDateValue1"]!=null && row["n_EndDateValue1"].ToString()!="")
				{
					model.n_EndDateValue1=int.Parse(row["n_EndDateValue1"].ToString());
				}
				if(row["s_EndDateType1"]!=null)
				{
					model.s_EndDateType1=row["s_EndDateType1"].ToString();
				}
				if(row["n_EndDateValue2"]!=null && row["n_EndDateValue2"].ToString()!="")
				{
					model.n_EndDateValue2=int.Parse(row["n_EndDateValue2"].ToString());
				}
				if(row["s_EndDateType2"]!=null)
				{
					model.s_EndDateType2=row["s_EndDateType2"].ToString();
				}
				if(row["g_EndFinallyCodeDeadlineGuid"]!=null && row["g_EndFinallyCodeDeadlineGuid"].ToString()!="")
				{
					model.g_EndFinallyCodeDeadlineGuid= new Guid(row["g_EndFinallyCodeDeadlineGuid"].ToString());
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
			strSql.Append("select g_ID,s_Name,s_Description,n_TaskTypeID,n_DemandTypeID,n_Level,s_ExecutorType,s_ExecutorValue,s_FinishCondition,s_StartDateCalcRule,s_StartDateTaskCode,s_StartDateTaskDateType,g_StartCodeDeadlineGuid,n_StartDateValue1,s_StartDateType1,n_StartDateValue2,s_StartDateType2,s_EndDateCalcRule,s_EndDateTaskCode,s_EndDateTaskDateType,g_EndCodeDeadlineGuid,n_EndDateValue1,s_EndDateType1,n_EndDateValue2,s_EndDateType2,g_EndFinallyCodeDeadlineGuid ");
			strSql.Append(" FROM TFCode_Task ");
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
			strSql.Append(" g_ID,s_Name,s_Description,n_TaskTypeID,n_DemandTypeID,n_Level,s_ExecutorType,s_ExecutorValue,s_FinishCondition,s_StartDateCalcRule,s_StartDateTaskCode,s_StartDateTaskDateType,g_StartCodeDeadlineGuid,n_StartDateValue1,s_StartDateType1,n_StartDateValue2,s_StartDateType2,s_EndDateCalcRule,s_EndDateTaskCode,s_EndDateTaskDateType,g_EndCodeDeadlineGuid,n_EndDateValue1,s_EndDateType1,n_EndDateValue2,s_EndDateType2,g_EndFinallyCodeDeadlineGuid ");
			strSql.Append(" FROM TFCode_Task ");
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
			strSql.Append("select count(1) FROM TFCode_Task ");
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
			strSql.Append(")AS Row, T.*  from TFCode_Task T ");
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
			parameters[0].Value = "TFCode_Task";
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

