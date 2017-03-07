/**  版本信息模板在安装目录下，可自行修改。
* T_LawItemPara.cs
*
* 功 能： N/A
* 类 名： T_LawItemPara
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:52   N/A    初版
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
	/// 数据访问类:T_LawItemPara
	/// </summary>
	public partial class T_LawItemPara
	{
		public T_LawItemPara()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_LawItemID", "T_LawItemPara"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_LawItemID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_LawItemPara");
			strSql.Append(" where n_LawItemID=@n_LawItemID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_LawItemID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_LawItemID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_LawItemPara model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_LawItemPara(");
			strSql.Append("s_ParaLocationCode,s_ParaType,s_ParaValue,n_LawItemID,byte_ParaValue)");
			strSql.Append(" values (");
			strSql.Append("@s_ParaLocationCode,@s_ParaType,@s_ParaValue,@n_LawItemID,@byte_ParaValue)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ParaLocationCode", SqlDbType.NVarChar,10),
					new SqlParameter("@s_ParaType", SqlDbType.NVarChar,10),
					new SqlParameter("@s_ParaValue", SqlDbType.NVarChar,500),
					new SqlParameter("@n_LawItemID", SqlDbType.Int,4),
					new SqlParameter("@byte_ParaValue", SqlDbType.VarBinary,-1)};
			parameters[0].Value = model.s_ParaLocationCode;
			parameters[1].Value = model.s_ParaType;
			parameters[2].Value = model.s_ParaValue;
			parameters[3].Value = model.n_LawItemID;
			parameters[4].Value = model.byte_ParaValue;

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
		public bool Update(IPSP.Model.T_LawItemPara model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_LawItemPara set ");
			strSql.Append("s_ParaLocationCode=@s_ParaLocationCode,");
			strSql.Append("s_ParaType=@s_ParaType,");
			strSql.Append("s_ParaValue=@s_ParaValue,");
			strSql.Append("byte_ParaValue=@byte_ParaValue");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ParaLocationCode", SqlDbType.NVarChar,10),
					new SqlParameter("@s_ParaType", SqlDbType.NVarChar,10),
					new SqlParameter("@s_ParaValue", SqlDbType.NVarChar,500),
					new SqlParameter("@byte_ParaValue", SqlDbType.VarBinary,-1),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_LawItemID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_ParaLocationCode;
			parameters[1].Value = model.s_ParaType;
			parameters[2].Value = model.s_ParaValue;
			parameters[3].Value = model.byte_ParaValue;
			parameters[4].Value = model.n_ID;
			parameters[5].Value = model.n_LawItemID;

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
			strSql.Append("delete from T_LawItemPara ");
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
		public bool Delete(int n_LawItemID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_LawItemPara ");
			strSql.Append(" where n_LawItemID=@n_LawItemID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_LawItemID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_LawItemID;
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
			strSql.Append("delete from T_LawItemPara ");
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
		public IPSP.Model.T_LawItemPara GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_ParaLocationCode,s_ParaType,s_ParaValue,n_LawItemID,byte_ParaValue from T_LawItemPara ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_LawItemPara model=new IPSP.Model.T_LawItemPara();
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
		public IPSP.Model.T_LawItemPara DataRowToModel(DataRow row)
		{
			IPSP.Model.T_LawItemPara model=new IPSP.Model.T_LawItemPara();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_ParaLocationCode"]!=null)
				{
					model.s_ParaLocationCode=row["s_ParaLocationCode"].ToString();
				}
				if(row["s_ParaType"]!=null)
				{
					model.s_ParaType=row["s_ParaType"].ToString();
				}
				if(row["s_ParaValue"]!=null)
				{
					model.s_ParaValue=row["s_ParaValue"].ToString();
				}
				if(row["n_LawItemID"]!=null && row["n_LawItemID"].ToString()!="")
				{
					model.n_LawItemID=int.Parse(row["n_LawItemID"].ToString());
				}
				if(row["byte_ParaValue"]!=null && row["byte_ParaValue"].ToString()!="")
				{
					model.byte_ParaValue=(byte[])row["byte_ParaValue"];
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
			strSql.Append("select n_ID,s_ParaLocationCode,s_ParaType,s_ParaValue,n_LawItemID,byte_ParaValue ");
			strSql.Append(" FROM T_LawItemPara ");
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
			strSql.Append(" n_ID,s_ParaLocationCode,s_ParaType,s_ParaValue,n_LawItemID,byte_ParaValue ");
			strSql.Append(" FROM T_LawItemPara ");
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
			strSql.Append("select count(1) FROM T_LawItemPara ");
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
			strSql.Append(")AS Row, T.*  from T_LawItemPara T ");
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
			parameters[0].Value = "T_LawItemPara";
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

