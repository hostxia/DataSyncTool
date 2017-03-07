/**  版本信息模板在安装目录下，可自行修改。
* T_BizSolutionInfo.cs
*
* 功 能： N/A
* 类 名： T_BizSolutionInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:33   N/A    初版
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
	/// 数据访问类:T_BizSolutionInfo
	/// </summary>
	public partial class T_BizSolutionInfo
	{
		public T_BizSolutionInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string s_ItemName)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_BizSolutionInfo");
			strSql.Append(" where s_ItemName=@s_ItemName ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ItemName", SqlDbType.NVarChar,50)			};
			parameters[0].Value = s_ItemName;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.T_BizSolutionInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_BizSolutionInfo(");
			strSql.Append("s_ItemName,s_ItemValue)");
			strSql.Append(" values (");
			strSql.Append("@s_ItemName,@s_ItemValue)");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ItemName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ItemValue", SqlDbType.NVarChar,4000)};
			parameters[0].Value = model.s_ItemName;
			parameters[1].Value = model.s_ItemValue;

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
		public bool Update(IPSP.Model.T_BizSolutionInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_BizSolutionInfo set ");
			strSql.Append("s_ItemValue=@s_ItemValue");
			strSql.Append(" where s_ItemName=@s_ItemName ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ItemValue", SqlDbType.NVarChar,4000),
					new SqlParameter("@s_ItemName", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.s_ItemValue;
			parameters[1].Value = model.s_ItemName;

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
		public bool Delete(string s_ItemName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_BizSolutionInfo ");
			strSql.Append(" where s_ItemName=@s_ItemName ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ItemName", SqlDbType.NVarChar,50)			};
			parameters[0].Value = s_ItemName;

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
		public bool DeleteList(string s_ItemNamelist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_BizSolutionInfo ");
			strSql.Append(" where s_ItemName in ("+s_ItemNamelist + ")  ");
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
		public IPSP.Model.T_BizSolutionInfo GetModel(string s_ItemName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 s_ItemName,s_ItemValue from T_BizSolutionInfo ");
			strSql.Append(" where s_ItemName=@s_ItemName ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ItemName", SqlDbType.NVarChar,50)			};
			parameters[0].Value = s_ItemName;

			IPSP.Model.T_BizSolutionInfo model=new IPSP.Model.T_BizSolutionInfo();
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
		public IPSP.Model.T_BizSolutionInfo DataRowToModel(DataRow row)
		{
			IPSP.Model.T_BizSolutionInfo model=new IPSP.Model.T_BizSolutionInfo();
			if (row != null)
			{
				if(row["s_ItemName"]!=null)
				{
					model.s_ItemName=row["s_ItemName"].ToString();
				}
				if(row["s_ItemValue"]!=null)
				{
					model.s_ItemValue=row["s_ItemValue"].ToString();
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
			strSql.Append("select s_ItemName,s_ItemValue ");
			strSql.Append(" FROM T_BizSolutionInfo ");
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
			strSql.Append(" s_ItemName,s_ItemValue ");
			strSql.Append(" FROM T_BizSolutionInfo ");
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
			strSql.Append("select count(1) FROM T_BizSolutionInfo ");
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
				strSql.Append("order by T.s_ItemName desc");
			}
			strSql.Append(")AS Row, T.*  from T_BizSolutionInfo T ");
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
			parameters[0].Value = "T_BizSolutionInfo";
			parameters[1].Value = "s_ItemName";
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

