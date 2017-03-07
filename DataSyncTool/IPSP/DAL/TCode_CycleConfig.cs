/**  版本信息模板在安装目录下，可自行修改。
* TCode_CycleConfig.cs
*
* 功 能： N/A
* 类 名： TCode_CycleConfig
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:10   N/A    初版
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
	/// 数据访问类:TCode_CycleConfig
	/// </summary>
	public partial class TCode_CycleConfig
	{
		public TCode_CycleConfig()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ClientID", "TCode_CycleConfig"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ClientID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_CycleConfig");
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
		public int Add(IPSP.Model.TCode_CycleConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_CycleConfig(");
			strSql.Append("n_PaymentCycle,n_LetterTemplateID,n_EmailTemplateID,n_ClientID,n_Sequence,s_GlobalConfig)");
			strSql.Append(" values (");
			strSql.Append("@n_PaymentCycle,@n_LetterTemplateID,@n_EmailTemplateID,@n_ClientID,@n_Sequence,@s_GlobalConfig)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_PaymentCycle", SqlDbType.Int,4),
					new SqlParameter("@n_LetterTemplateID", SqlDbType.Int,4),
					new SqlParameter("@n_EmailTemplateID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@s_GlobalConfig", SqlDbType.NVarChar,2)};
			parameters[0].Value = model.n_PaymentCycle;
			parameters[1].Value = model.n_LetterTemplateID;
			parameters[2].Value = model.n_EmailTemplateID;
			parameters[3].Value = model.n_ClientID;
			parameters[4].Value = model.n_Sequence;
			parameters[5].Value = model.s_GlobalConfig;

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
		public bool Update(IPSP.Model.TCode_CycleConfig model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_CycleConfig set ");
			strSql.Append("n_PaymentCycle=@n_PaymentCycle,");
			strSql.Append("n_LetterTemplateID=@n_LetterTemplateID,");
			strSql.Append("n_EmailTemplateID=@n_EmailTemplateID,");
			strSql.Append("n_Sequence=@n_Sequence,");
			strSql.Append("s_GlobalConfig=@s_GlobalConfig");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_PaymentCycle", SqlDbType.Int,4),
					new SqlParameter("@n_LetterTemplateID", SqlDbType.Int,4),
					new SqlParameter("@n_EmailTemplateID", SqlDbType.Int,4),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@s_GlobalConfig", SqlDbType.NVarChar,2),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_PaymentCycle;
			parameters[1].Value = model.n_LetterTemplateID;
			parameters[2].Value = model.n_EmailTemplateID;
			parameters[3].Value = model.n_Sequence;
			parameters[4].Value = model.s_GlobalConfig;
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
			strSql.Append("delete from TCode_CycleConfig ");
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
			strSql.Append("delete from TCode_CycleConfig ");
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
			strSql.Append("delete from TCode_CycleConfig ");
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
		public IPSP.Model.TCode_CycleConfig GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_PaymentCycle,n_LetterTemplateID,n_EmailTemplateID,n_ClientID,n_Sequence,s_GlobalConfig from TCode_CycleConfig ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_CycleConfig model=new IPSP.Model.TCode_CycleConfig();
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
		public IPSP.Model.TCode_CycleConfig DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_CycleConfig model=new IPSP.Model.TCode_CycleConfig();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_PaymentCycle"]!=null && row["n_PaymentCycle"].ToString()!="")
				{
					model.n_PaymentCycle=int.Parse(row["n_PaymentCycle"].ToString());
				}
				if(row["n_LetterTemplateID"]!=null && row["n_LetterTemplateID"].ToString()!="")
				{
					model.n_LetterTemplateID=int.Parse(row["n_LetterTemplateID"].ToString());
				}
				if(row["n_EmailTemplateID"]!=null && row["n_EmailTemplateID"].ToString()!="")
				{
					model.n_EmailTemplateID=int.Parse(row["n_EmailTemplateID"].ToString());
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["n_Sequence"]!=null && row["n_Sequence"].ToString()!="")
				{
					model.n_Sequence=int.Parse(row["n_Sequence"].ToString());
				}
				if(row["s_GlobalConfig"]!=null)
				{
					model.s_GlobalConfig=row["s_GlobalConfig"].ToString();
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
			strSql.Append("select n_ID,n_PaymentCycle,n_LetterTemplateID,n_EmailTemplateID,n_ClientID,n_Sequence,s_GlobalConfig ");
			strSql.Append(" FROM TCode_CycleConfig ");
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
			strSql.Append(" n_ID,n_PaymentCycle,n_LetterTemplateID,n_EmailTemplateID,n_ClientID,n_Sequence,s_GlobalConfig ");
			strSql.Append(" FROM TCode_CycleConfig ");
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
			strSql.Append("select count(1) FROM TCode_CycleConfig ");
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
			strSql.Append(")AS Row, T.*  from TCode_CycleConfig T ");
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
			parameters[0].Value = "TCode_CycleConfig";
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

