/**  版本信息模板在安装目录下，可自行修改。
* TCode_State.cs
*
* 功 能： N/A
* 类 名： TCode_State
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:04   N/A    初版
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
	/// 数据访问类:TCode_State
	/// </summary>
	public partial class TCode_State
	{
		public TCode_State()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_Country", "TCode_State"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_Country,int n_StateID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_State");
			strSql.Append(" where n_Country=@n_Country and n_StateID=@n_StateID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@n_StateID", SqlDbType.Int,4)			};
			parameters[0].Value = n_Country;
			parameters[1].Value = n_StateID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_State model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_State(");
			strSql.Append("n_Country,s_StateName,s_OStateName,s_RegionCode)");
			strSql.Append(" values (");
			strSql.Append("@n_Country,@s_StateName,@s_OStateName,@s_RegionCode)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_StateName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_OStateName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_RegionCode", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.n_Country;
			parameters[1].Value = model.s_StateName;
			parameters[2].Value = model.s_OStateName;
			parameters[3].Value = model.s_RegionCode;

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
		public bool Update(IPSP.Model.TCode_State model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_State set ");
			strSql.Append("s_StateName=@s_StateName,");
			strSql.Append("s_OStateName=@s_OStateName,");
			strSql.Append("s_RegionCode=@s_RegionCode");
			strSql.Append(" where n_StateID=@n_StateID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_StateName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_OStateName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_RegionCode", SqlDbType.NVarChar,100),
					new SqlParameter("@n_StateID", SqlDbType.Int,4),
					new SqlParameter("@n_Country", SqlDbType.Int,4)};
			parameters[0].Value = model.s_StateName;
			parameters[1].Value = model.s_OStateName;
			parameters[2].Value = model.s_RegionCode;
			parameters[3].Value = model.n_StateID;
			parameters[4].Value = model.n_Country;

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
		public bool Delete(int n_StateID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_State ");
			strSql.Append(" where n_StateID=@n_StateID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_StateID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_StateID;

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
		public bool Delete(int n_Country,int n_StateID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_State ");
			strSql.Append(" where n_Country=@n_Country and n_StateID=@n_StateID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@n_StateID", SqlDbType.Int,4)			};
			parameters[0].Value = n_Country;
			parameters[1].Value = n_StateID;

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
		public bool DeleteList(string n_StateIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_State ");
			strSql.Append(" where n_StateID in ("+n_StateIDlist + ")  ");
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
		public IPSP.Model.TCode_State GetModel(int n_StateID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_StateID,n_Country,s_StateName,s_OStateName,s_RegionCode from TCode_State ");
			strSql.Append(" where n_StateID=@n_StateID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_StateID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_StateID;

			IPSP.Model.TCode_State model=new IPSP.Model.TCode_State();
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
		public IPSP.Model.TCode_State DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_State model=new IPSP.Model.TCode_State();
			if (row != null)
			{
				if(row["n_StateID"]!=null && row["n_StateID"].ToString()!="")
				{
					model.n_StateID=int.Parse(row["n_StateID"].ToString());
				}
				if(row["n_Country"]!=null && row["n_Country"].ToString()!="")
				{
					model.n_Country=int.Parse(row["n_Country"].ToString());
				}
				if(row["s_StateName"]!=null)
				{
					model.s_StateName=row["s_StateName"].ToString();
				}
				if(row["s_OStateName"]!=null)
				{
					model.s_OStateName=row["s_OStateName"].ToString();
				}
				if(row["s_RegionCode"]!=null)
				{
					model.s_RegionCode=row["s_RegionCode"].ToString();
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
			strSql.Append("select n_StateID,n_Country,s_StateName,s_OStateName,s_RegionCode ");
			strSql.Append(" FROM TCode_State ");
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
			strSql.Append(" n_StateID,n_Country,s_StateName,s_OStateName,s_RegionCode ");
			strSql.Append(" FROM TCode_State ");
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
			strSql.Append("select count(1) FROM TCode_State ");
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
				strSql.Append("order by T.n_StateID desc");
			}
			strSql.Append(")AS Row, T.*  from TCode_State T ");
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
			parameters[0].Value = "TCode_State";
			parameters[1].Value = "n_StateID";
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

