/**  版本信息模板在安装目录下，可自行修改。
* T_UserOnline.cs
*
* 功 能： N/A
* 类 名： T_UserOnline
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:18   N/A    初版
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
	/// 数据访问类:T_UserOnline
	/// </summary>
	public partial class T_UserOnline
	{
		public T_UserOnline()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_UserOnline");
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
		public decimal Add(IPSP.Model.T_UserOnline model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_UserOnline(");
			strSql.Append("s_LoginName,s_PCName,s_IP,dt_LoginTime,s_SoftwareName)");
			strSql.Append(" values (");
			strSql.Append("@s_LoginName,@s_PCName,@s_IP,@dt_LoginTime,@s_SoftwareName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_LoginName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PCName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_IP", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_LoginTime", SqlDbType.DateTime),
					new SqlParameter("@s_SoftwareName", SqlDbType.NVarChar,3)};
			parameters[0].Value = model.s_LoginName;
			parameters[1].Value = model.s_PCName;
			parameters[2].Value = model.s_IP;
			parameters[3].Value = model.dt_LoginTime;
			parameters[4].Value = model.s_SoftwareName;

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
		public bool Update(IPSP.Model.T_UserOnline model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_UserOnline set ");
			strSql.Append("s_LoginName=@s_LoginName,");
			strSql.Append("s_PCName=@s_PCName,");
			strSql.Append("s_IP=@s_IP,");
			strSql.Append("dt_LoginTime=@dt_LoginTime,");
			strSql.Append("s_SoftwareName=@s_SoftwareName");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_LoginName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PCName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_IP", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_LoginTime", SqlDbType.DateTime),
					new SqlParameter("@s_SoftwareName", SqlDbType.NVarChar,3),
					new SqlParameter("@n_ID", SqlDbType.Decimal,9)};
			parameters[0].Value = model.s_LoginName;
			parameters[1].Value = model.s_PCName;
			parameters[2].Value = model.s_IP;
			parameters[3].Value = model.dt_LoginTime;
			parameters[4].Value = model.s_SoftwareName;
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
			strSql.Append("delete from T_UserOnline ");
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
			strSql.Append("delete from T_UserOnline ");
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
		public IPSP.Model.T_UserOnline GetModel(decimal n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_LoginName,s_PCName,s_IP,dt_LoginTime,s_SoftwareName from T_UserOnline ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Decimal)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_UserOnline model=new IPSP.Model.T_UserOnline();
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
		public IPSP.Model.T_UserOnline DataRowToModel(DataRow row)
		{
			IPSP.Model.T_UserOnline model=new IPSP.Model.T_UserOnline();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=decimal.Parse(row["n_ID"].ToString());
				}
				if(row["s_LoginName"]!=null)
				{
					model.s_LoginName=row["s_LoginName"].ToString();
				}
				if(row["s_PCName"]!=null)
				{
					model.s_PCName=row["s_PCName"].ToString();
				}
				if(row["s_IP"]!=null)
				{
					model.s_IP=row["s_IP"].ToString();
				}
				if(row["dt_LoginTime"]!=null && row["dt_LoginTime"].ToString()!="")
				{
					model.dt_LoginTime=DateTime.Parse(row["dt_LoginTime"].ToString());
				}
				if(row["s_SoftwareName"]!=null)
				{
					model.s_SoftwareName=row["s_SoftwareName"].ToString();
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
			strSql.Append("select n_ID,s_LoginName,s_PCName,s_IP,dt_LoginTime,s_SoftwareName ");
			strSql.Append(" FROM T_UserOnline ");
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
			strSql.Append(" n_ID,s_LoginName,s_PCName,s_IP,dt_LoginTime,s_SoftwareName ");
			strSql.Append(" FROM T_UserOnline ");
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
			strSql.Append("select count(1) FROM T_UserOnline ");
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
			strSql.Append(")AS Row, T.*  from T_UserOnline T ");
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
			parameters[0].Value = "T_UserOnline";
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

