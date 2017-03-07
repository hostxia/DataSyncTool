/**  版本信息模板在安装目录下，可自行修改。
* T_CheckOutHistory.cs
*
* 功 能： N/A
* 类 名： T_CheckOutHistory
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:35   N/A    初版
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
	/// 数据访问类:T_CheckOutHistory
	/// </summary>
	public partial class T_CheckOutHistory
	{
		public T_CheckOutHistory()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_CheckOutHistory");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Decimal)
			};
			parameters[0].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(IPSP.Model.T_CheckOutHistory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_CheckOutHistory(");
			strSql.Append("n_FileID,n_MainFileID,s_CheckOutUser,dt_CheckOut,s_Action)");
			strSql.Append(" values (");
			strSql.Append("@n_FileID,@n_MainFileID,@s_CheckOutUser,@dt_CheckOut,@s_Action)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Decimal,9),
					new SqlParameter("@n_MainFileID", SqlDbType.Decimal,9),
					new SqlParameter("@s_CheckOutUser", SqlDbType.NVarChar,10),
					new SqlParameter("@dt_CheckOut", SqlDbType.DateTime),
					new SqlParameter("@s_Action", SqlDbType.NVarChar,10)};
			parameters[0].Value = model.n_FileID;
			parameters[1].Value = model.n_MainFileID;
			parameters[2].Value = model.s_CheckOutUser;
			parameters[3].Value = model.dt_CheckOut;
			parameters[4].Value = model.s_Action;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToDecimal(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(IPSP.Model.T_CheckOutHistory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_CheckOutHistory set ");
			strSql.Append("n_FileID=@n_FileID,");
			strSql.Append("n_MainFileID=@n_MainFileID,");
			strSql.Append("s_CheckOutUser=@s_CheckOutUser,");
			strSql.Append("dt_CheckOut=@dt_CheckOut,");
			strSql.Append("s_Action=@s_Action");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Decimal,9),
					new SqlParameter("@n_MainFileID", SqlDbType.Decimal,9),
					new SqlParameter("@s_CheckOutUser", SqlDbType.NVarChar,10),
					new SqlParameter("@dt_CheckOut", SqlDbType.DateTime),
					new SqlParameter("@s_Action", SqlDbType.NVarChar,10),
					new SqlParameter("@n_ID", SqlDbType.Decimal,9)};
			parameters[0].Value = model.n_FileID;
			parameters[1].Value = model.n_MainFileID;
			parameters[2].Value = model.s_CheckOutUser;
			parameters[3].Value = model.dt_CheckOut;
			parameters[4].Value = model.s_Action;
			parameters[5].Value = model.n_ID;

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
		public bool Delete(decimal n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_CheckOutHistory ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Decimal)
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
			strSql.Append("delete from T_CheckOutHistory ");
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
		public IPSP.Model.T_CheckOutHistory GetModel(decimal n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_FileID,n_MainFileID,s_CheckOutUser,dt_CheckOut,s_Action from T_CheckOutHistory ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Decimal)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_CheckOutHistory model=new IPSP.Model.T_CheckOutHistory();
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
		public IPSP.Model.T_CheckOutHistory DataRowToModel(DataRow row)
		{
			IPSP.Model.T_CheckOutHistory model=new IPSP.Model.T_CheckOutHistory();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=decimal.Parse(row["n_ID"].ToString());
				}
				if(row["n_FileID"]!=null && row["n_FileID"].ToString()!="")
				{
					model.n_FileID=decimal.Parse(row["n_FileID"].ToString());
				}
				if(row["n_MainFileID"]!=null && row["n_MainFileID"].ToString()!="")
				{
					model.n_MainFileID=decimal.Parse(row["n_MainFileID"].ToString());
				}
				if(row["s_CheckOutUser"]!=null)
				{
					model.s_CheckOutUser=row["s_CheckOutUser"].ToString();
				}
				if(row["dt_CheckOut"]!=null && row["dt_CheckOut"].ToString()!="")
				{
					model.dt_CheckOut=DateTime.Parse(row["dt_CheckOut"].ToString());
				}
				if(row["s_Action"]!=null)
				{
					model.s_Action=row["s_Action"].ToString();
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
			strSql.Append("select n_ID,n_FileID,n_MainFileID,s_CheckOutUser,dt_CheckOut,s_Action ");
			strSql.Append(" FROM T_CheckOutHistory ");
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
			strSql.Append(" n_ID,n_FileID,n_MainFileID,s_CheckOutUser,dt_CheckOut,s_Action ");
			strSql.Append(" FROM T_CheckOutHistory ");
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
			strSql.Append("select count(1) FROM T_CheckOutHistory ");
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
			strSql.Append(")AS Row, T.*  from T_CheckOutHistory T ");
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
			parameters[0].Value = "T_CheckOutHistory";
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

