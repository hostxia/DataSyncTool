/**  版本信息模板在安装目录下，可自行修改。
* TCode_FlowNoRule.cs
*
* 功 能： N/A
* 类 名： TCode_FlowNoRule
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:27   N/A    初版
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
	/// 数据访问类:TCode_FlowNoRule
	/// </summary>
	public partial class TCode_FlowNoRule
	{
		public TCode_FlowNoRule()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TCode_FlowNoRule"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_FlowNoRule");
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
		public int Add(IPSP.Model.TCode_FlowNoRule model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_FlowNoRule(");
			strSql.Append("s_IPType,s_FlowNoRelate1,s_FlowNoRelate2,s_FlowNoRule,s_FlowNoType,n_MaxNo,s_ResetEachYear,n_FlowNoCount,s_OneTrademarkOneFlow)");
			strSql.Append(" values (");
			strSql.Append("@s_IPType,@s_FlowNoRelate1,@s_FlowNoRelate2,@s_FlowNoRule,@s_FlowNoType,@n_MaxNo,@s_ResetEachYear,@n_FlowNoCount,@s_OneTrademarkOneFlow)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_FlowNoRelate1", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FlowNoRelate2", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FlowNoRule", SqlDbType.NVarChar,1),
					new SqlParameter("@s_FlowNoType", SqlDbType.NVarChar,200),
					new SqlParameter("@n_MaxNo", SqlDbType.Int,4),
					new SqlParameter("@s_ResetEachYear", SqlDbType.NVarChar,1),
					new SqlParameter("@n_FlowNoCount", SqlDbType.Int,4),
					new SqlParameter("@s_OneTrademarkOneFlow", SqlDbType.NVarChar,1)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_FlowNoRelate1;
			parameters[2].Value = model.s_FlowNoRelate2;
			parameters[3].Value = model.s_FlowNoRule;
			parameters[4].Value = model.s_FlowNoType;
			parameters[5].Value = model.n_MaxNo;
			parameters[6].Value = model.s_ResetEachYear;
			parameters[7].Value = model.n_FlowNoCount;
			parameters[8].Value = model.s_OneTrademarkOneFlow;

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
		public bool Update(IPSP.Model.TCode_FlowNoRule model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_FlowNoRule set ");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_FlowNoRelate1=@s_FlowNoRelate1,");
			strSql.Append("s_FlowNoRelate2=@s_FlowNoRelate2,");
			strSql.Append("s_FlowNoRule=@s_FlowNoRule,");
			strSql.Append("s_FlowNoType=@s_FlowNoType,");
			strSql.Append("n_MaxNo=@n_MaxNo,");
			strSql.Append("s_ResetEachYear=@s_ResetEachYear,");
			strSql.Append("n_FlowNoCount=@n_FlowNoCount,");
			strSql.Append("s_OneTrademarkOneFlow=@s_OneTrademarkOneFlow");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_FlowNoRelate1", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FlowNoRelate2", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FlowNoRule", SqlDbType.NVarChar,1),
					new SqlParameter("@s_FlowNoType", SqlDbType.NVarChar,200),
					new SqlParameter("@n_MaxNo", SqlDbType.Int,4),
					new SqlParameter("@s_ResetEachYear", SqlDbType.NVarChar,1),
					new SqlParameter("@n_FlowNoCount", SqlDbType.Int,4),
					new SqlParameter("@s_OneTrademarkOneFlow", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_FlowNoRelate1;
			parameters[2].Value = model.s_FlowNoRelate2;
			parameters[3].Value = model.s_FlowNoRule;
			parameters[4].Value = model.s_FlowNoType;
			parameters[5].Value = model.n_MaxNo;
			parameters[6].Value = model.s_ResetEachYear;
			parameters[7].Value = model.n_FlowNoCount;
			parameters[8].Value = model.s_OneTrademarkOneFlow;
			parameters[9].Value = model.n_ID;

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
			strSql.Append("delete from TCode_FlowNoRule ");
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
			strSql.Append("delete from TCode_FlowNoRule ");
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
		public IPSP.Model.TCode_FlowNoRule GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_IPType,s_FlowNoRelate1,s_FlowNoRelate2,s_FlowNoRule,s_FlowNoType,n_MaxNo,s_ResetEachYear,n_FlowNoCount,s_OneTrademarkOneFlow from TCode_FlowNoRule ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_FlowNoRule model=new IPSP.Model.TCode_FlowNoRule();
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
		public IPSP.Model.TCode_FlowNoRule DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_FlowNoRule model=new IPSP.Model.TCode_FlowNoRule();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["s_FlowNoRelate1"]!=null)
				{
					model.s_FlowNoRelate1=row["s_FlowNoRelate1"].ToString();
				}
				if(row["s_FlowNoRelate2"]!=null)
				{
					model.s_FlowNoRelate2=row["s_FlowNoRelate2"].ToString();
				}
				if(row["s_FlowNoRule"]!=null)
				{
					model.s_FlowNoRule=row["s_FlowNoRule"].ToString();
				}
				if(row["s_FlowNoType"]!=null)
				{
					model.s_FlowNoType=row["s_FlowNoType"].ToString();
				}
				if(row["n_MaxNo"]!=null && row["n_MaxNo"].ToString()!="")
				{
					model.n_MaxNo=int.Parse(row["n_MaxNo"].ToString());
				}
				if(row["s_ResetEachYear"]!=null)
				{
					model.s_ResetEachYear=row["s_ResetEachYear"].ToString();
				}
				if(row["n_FlowNoCount"]!=null && row["n_FlowNoCount"].ToString()!="")
				{
					model.n_FlowNoCount=int.Parse(row["n_FlowNoCount"].ToString());
				}
				if(row["s_OneTrademarkOneFlow"]!=null)
				{
					model.s_OneTrademarkOneFlow=row["s_OneTrademarkOneFlow"].ToString();
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
			strSql.Append("select n_ID,s_IPType,s_FlowNoRelate1,s_FlowNoRelate2,s_FlowNoRule,s_FlowNoType,n_MaxNo,s_ResetEachYear,n_FlowNoCount,s_OneTrademarkOneFlow ");
			strSql.Append(" FROM TCode_FlowNoRule ");
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
			strSql.Append(" n_ID,s_IPType,s_FlowNoRelate1,s_FlowNoRelate2,s_FlowNoRule,s_FlowNoType,n_MaxNo,s_ResetEachYear,n_FlowNoCount,s_OneTrademarkOneFlow ");
			strSql.Append(" FROM TCode_FlowNoRule ");
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
			strSql.Append("select count(1) FROM TCode_FlowNoRule ");
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
			strSql.Append(")AS Row, T.*  from TCode_FlowNoRule T ");
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
			parameters[0].Value = "TCode_FlowNoRule";
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

