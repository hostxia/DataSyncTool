/**  版本信息模板在安装目录下，可自行修改。
* TCode_SecurityConfig.cs
*
* 功 能： N/A
* 类 名： TCode_SecurityConfig
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:59   N/A    初版
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
	/// 数据访问类:TCode_SecurityConfig
	/// </summary>
	public partial class TCode_SecurityConfig
	{
		public TCode_SecurityConfig()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TCode_SecurityConfig"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_SecurityConfig");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_SecurityConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_SecurityConfig(");
			strSql.Append("s_PwdComplexity,n_PwdMinLength,s_PwdRegular,s_PwdCycle,n_PwdYear,n_PwdMonth,n_PwdDay,s_Idle,n_TimeoutDay,n_TimeoutHour,n_TimeoutMinute,s_FailureTry,n_LockHour,n_LockMinute,n_Retry,s_AccessControl,s_IP)");
			strSql.Append(" values (");
			strSql.Append("@s_PwdComplexity,@n_PwdMinLength,@s_PwdRegular,@s_PwdCycle,@n_PwdYear,@n_PwdMonth,@n_PwdDay,@s_Idle,@n_TimeoutDay,@n_TimeoutHour,@n_TimeoutMinute,@s_FailureTry,@n_LockHour,@n_LockMinute,@n_Retry,@s_AccessControl,@s_IP)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_PwdComplexity", SqlDbType.NVarChar,1),
					new SqlParameter("@n_PwdMinLength", SqlDbType.Int,4),
					new SqlParameter("@s_PwdRegular", SqlDbType.NVarChar,20),
					new SqlParameter("@s_PwdCycle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_PwdYear", SqlDbType.Int,4),
					new SqlParameter("@n_PwdMonth", SqlDbType.Int,4),
					new SqlParameter("@n_PwdDay", SqlDbType.Int,4),
					new SqlParameter("@s_Idle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_TimeoutDay", SqlDbType.Int,4),
					new SqlParameter("@n_TimeoutHour", SqlDbType.Int,4),
					new SqlParameter("@n_TimeoutMinute", SqlDbType.Int,4),
					new SqlParameter("@s_FailureTry", SqlDbType.NVarChar,1),
					new SqlParameter("@n_LockHour", SqlDbType.Int,4),
					new SqlParameter("@n_LockMinute", SqlDbType.Int,4),
					new SqlParameter("@n_Retry", SqlDbType.Int,4),
					new SqlParameter("@s_AccessControl", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IP", SqlDbType.NVarChar,-1)};
			parameters[0].Value = model.s_PwdComplexity;
			parameters[1].Value = model.n_PwdMinLength;
			parameters[2].Value = model.s_PwdRegular;
			parameters[3].Value = model.s_PwdCycle;
			parameters[4].Value = model.n_PwdYear;
			parameters[5].Value = model.n_PwdMonth;
			parameters[6].Value = model.n_PwdDay;
			parameters[7].Value = model.s_Idle;
			parameters[8].Value = model.n_TimeoutDay;
			parameters[9].Value = model.n_TimeoutHour;
			parameters[10].Value = model.n_TimeoutMinute;
			parameters[11].Value = model.s_FailureTry;
			parameters[12].Value = model.n_LockHour;
			parameters[13].Value = model.n_LockMinute;
			parameters[14].Value = model.n_Retry;
			parameters[15].Value = model.s_AccessControl;
			parameters[16].Value = model.s_IP;

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
		public bool Update(IPSP.Model.TCode_SecurityConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_SecurityConfig set ");
			strSql.Append("s_PwdComplexity=@s_PwdComplexity,");
			strSql.Append("n_PwdMinLength=@n_PwdMinLength,");
			strSql.Append("s_PwdRegular=@s_PwdRegular,");
			strSql.Append("s_PwdCycle=@s_PwdCycle,");
			strSql.Append("n_PwdYear=@n_PwdYear,");
			strSql.Append("n_PwdMonth=@n_PwdMonth,");
			strSql.Append("n_PwdDay=@n_PwdDay,");
			strSql.Append("s_Idle=@s_Idle,");
			strSql.Append("n_TimeoutDay=@n_TimeoutDay,");
			strSql.Append("n_TimeoutHour=@n_TimeoutHour,");
			strSql.Append("n_TimeoutMinute=@n_TimeoutMinute,");
			strSql.Append("s_FailureTry=@s_FailureTry,");
			strSql.Append("n_LockHour=@n_LockHour,");
			strSql.Append("n_LockMinute=@n_LockMinute,");
			strSql.Append("n_Retry=@n_Retry,");
			strSql.Append("s_AccessControl=@s_AccessControl,");
			strSql.Append("s_IP=@s_IP");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_PwdComplexity", SqlDbType.NVarChar,1),
					new SqlParameter("@n_PwdMinLength", SqlDbType.Int,4),
					new SqlParameter("@s_PwdRegular", SqlDbType.NVarChar,20),
					new SqlParameter("@s_PwdCycle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_PwdYear", SqlDbType.Int,4),
					new SqlParameter("@n_PwdMonth", SqlDbType.Int,4),
					new SqlParameter("@n_PwdDay", SqlDbType.Int,4),
					new SqlParameter("@s_Idle", SqlDbType.NVarChar,1),
					new SqlParameter("@n_TimeoutDay", SqlDbType.Int,4),
					new SqlParameter("@n_TimeoutHour", SqlDbType.Int,4),
					new SqlParameter("@n_TimeoutMinute", SqlDbType.Int,4),
					new SqlParameter("@s_FailureTry", SqlDbType.NVarChar,1),
					new SqlParameter("@n_LockHour", SqlDbType.Int,4),
					new SqlParameter("@n_LockMinute", SqlDbType.Int,4),
					new SqlParameter("@n_Retry", SqlDbType.Int,4),
					new SqlParameter("@s_AccessControl", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IP", SqlDbType.NVarChar,-1),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_PwdComplexity;
			parameters[1].Value = model.n_PwdMinLength;
			parameters[2].Value = model.s_PwdRegular;
			parameters[3].Value = model.s_PwdCycle;
			parameters[4].Value = model.n_PwdYear;
			parameters[5].Value = model.n_PwdMonth;
			parameters[6].Value = model.n_PwdDay;
			parameters[7].Value = model.s_Idle;
			parameters[8].Value = model.n_TimeoutDay;
			parameters[9].Value = model.n_TimeoutHour;
			parameters[10].Value = model.n_TimeoutMinute;
			parameters[11].Value = model.s_FailureTry;
			parameters[12].Value = model.n_LockHour;
			parameters[13].Value = model.n_LockMinute;
			parameters[14].Value = model.n_Retry;
			parameters[15].Value = model.s_AccessControl;
			parameters[16].Value = model.s_IP;
			parameters[17].Value = model.n_ID;

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
			strSql.Append("delete from TCode_SecurityConfig ");
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string n_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_SecurityConfig ");
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
		public IPSP.Model.TCode_SecurityConfig GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_PwdComplexity,n_PwdMinLength,s_PwdRegular,s_PwdCycle,n_PwdYear,n_PwdMonth,n_PwdDay,s_Idle,n_TimeoutDay,n_TimeoutHour,n_TimeoutMinute,s_FailureTry,n_LockHour,n_LockMinute,n_Retry,s_AccessControl,s_IP from TCode_SecurityConfig ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_SecurityConfig model=new IPSP.Model.TCode_SecurityConfig();
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
		public IPSP.Model.TCode_SecurityConfig DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_SecurityConfig model=new IPSP.Model.TCode_SecurityConfig();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_PwdComplexity"]!=null)
				{
					model.s_PwdComplexity=row["s_PwdComplexity"].ToString();
				}
				if(row["n_PwdMinLength"]!=null && row["n_PwdMinLength"].ToString()!="")
				{
					model.n_PwdMinLength=int.Parse(row["n_PwdMinLength"].ToString());
				}
				if(row["s_PwdRegular"]!=null)
				{
					model.s_PwdRegular=row["s_PwdRegular"].ToString();
				}
				if(row["s_PwdCycle"]!=null)
				{
					model.s_PwdCycle=row["s_PwdCycle"].ToString();
				}
				if(row["n_PwdYear"]!=null && row["n_PwdYear"].ToString()!="")
				{
					model.n_PwdYear=int.Parse(row["n_PwdYear"].ToString());
				}
				if(row["n_PwdMonth"]!=null && row["n_PwdMonth"].ToString()!="")
				{
					model.n_PwdMonth=int.Parse(row["n_PwdMonth"].ToString());
				}
				if(row["n_PwdDay"]!=null && row["n_PwdDay"].ToString()!="")
				{
					model.n_PwdDay=int.Parse(row["n_PwdDay"].ToString());
				}
				if(row["s_Idle"]!=null)
				{
					model.s_Idle=row["s_Idle"].ToString();
				}
				if(row["n_TimeoutDay"]!=null && row["n_TimeoutDay"].ToString()!="")
				{
					model.n_TimeoutDay=int.Parse(row["n_TimeoutDay"].ToString());
				}
				if(row["n_TimeoutHour"]!=null && row["n_TimeoutHour"].ToString()!="")
				{
					model.n_TimeoutHour=int.Parse(row["n_TimeoutHour"].ToString());
				}
				if(row["n_TimeoutMinute"]!=null && row["n_TimeoutMinute"].ToString()!="")
				{
					model.n_TimeoutMinute=int.Parse(row["n_TimeoutMinute"].ToString());
				}
				if(row["s_FailureTry"]!=null)
				{
					model.s_FailureTry=row["s_FailureTry"].ToString();
				}
				if(row["n_LockHour"]!=null && row["n_LockHour"].ToString()!="")
				{
					model.n_LockHour=int.Parse(row["n_LockHour"].ToString());
				}
				if(row["n_LockMinute"]!=null && row["n_LockMinute"].ToString()!="")
				{
					model.n_LockMinute=int.Parse(row["n_LockMinute"].ToString());
				}
				if(row["n_Retry"]!=null && row["n_Retry"].ToString()!="")
				{
					model.n_Retry=int.Parse(row["n_Retry"].ToString());
				}
				if(row["s_AccessControl"]!=null)
				{
					model.s_AccessControl=row["s_AccessControl"].ToString();
				}
				if(row["s_IP"]!=null)
				{
					model.s_IP=row["s_IP"].ToString();
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
			strSql.Append("select n_ID,s_PwdComplexity,n_PwdMinLength,s_PwdRegular,s_PwdCycle,n_PwdYear,n_PwdMonth,n_PwdDay,s_Idle,n_TimeoutDay,n_TimeoutHour,n_TimeoutMinute,s_FailureTry,n_LockHour,n_LockMinute,n_Retry,s_AccessControl,s_IP ");
			strSql.Append(" FROM TCode_SecurityConfig ");
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
			strSql.Append(" n_ID,s_PwdComplexity,n_PwdMinLength,s_PwdRegular,s_PwdCycle,n_PwdYear,n_PwdMonth,n_PwdDay,s_Idle,n_TimeoutDay,n_TimeoutHour,n_TimeoutMinute,s_FailureTry,n_LockHour,n_LockMinute,n_Retry,s_AccessControl,s_IP ");
			strSql.Append(" FROM TCode_SecurityConfig ");
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
			strSql.Append("select count(1) FROM TCode_SecurityConfig ");
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
			strSql.Append(")AS Row, T.*  from TCode_SecurityConfig T ");
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
			parameters[0].Value = "TCode_SecurityConfig";
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

