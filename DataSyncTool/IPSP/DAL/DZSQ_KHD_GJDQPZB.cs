/**  版本信息模板在安装目录下，可自行修改。
* DZSQ_KHD_GJDQPZB.cs
*
* 功 能： N/A
* 类 名： DZSQ_KHD_GJDQPZB
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:26   N/A    初版
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
	/// 数据访问类:DZSQ_KHD_GJDQPZB
	/// </summary>
	public partial class DZSQ_KHD_GJDQPZB
	{
		public DZSQ_KHD_GJDQPZB()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string GUOJIADQID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DZSQ_KHD_GJDQPZB");
			strSql.Append(" where GUOJIADQID=@GUOJIADQID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GUOJIADQID", SqlDbType.NVarChar,100)			};
			parameters[0].Value = GUOJIADQID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.DZSQ_KHD_GJDQPZB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DZSQ_KHD_GJDQPZB(");
			strSql.Append("GUOJIADQID,GUOJIADQDM,GUOJIADQMC)");
			strSql.Append(" values (");
			strSql.Append("@GUOJIADQID,@GUOJIADQDM,@GUOJIADQMC)");
			SqlParameter[] parameters = {
					new SqlParameter("@GUOJIADQID", SqlDbType.NVarChar,100),
					new SqlParameter("@GUOJIADQDM", SqlDbType.NVarChar,16),
					new SqlParameter("@GUOJIADQMC", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.GUOJIADQID;
			parameters[1].Value = model.GUOJIADQDM;
			parameters[2].Value = model.GUOJIADQMC;

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
		public bool Update(IPSP.Model.DZSQ_KHD_GJDQPZB model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DZSQ_KHD_GJDQPZB set ");
			strSql.Append("GUOJIADQDM=@GUOJIADQDM,");
			strSql.Append("GUOJIADQMC=@GUOJIADQMC");
			strSql.Append(" where GUOJIADQID=@GUOJIADQID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GUOJIADQDM", SqlDbType.NVarChar,16),
					new SqlParameter("@GUOJIADQMC", SqlDbType.NVarChar,255),
					new SqlParameter("@GUOJIADQID", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.GUOJIADQDM;
			parameters[1].Value = model.GUOJIADQMC;
			parameters[2].Value = model.GUOJIADQID;

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
		public bool Delete(string GUOJIADQID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DZSQ_KHD_GJDQPZB ");
			strSql.Append(" where GUOJIADQID=@GUOJIADQID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GUOJIADQID", SqlDbType.NVarChar,100)			};
			parameters[0].Value = GUOJIADQID;

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
		public bool DeleteList(string GUOJIADQIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DZSQ_KHD_GJDQPZB ");
			strSql.Append(" where GUOJIADQID in ("+GUOJIADQIDlist + ")  ");
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
		public IPSP.Model.DZSQ_KHD_GJDQPZB GetModel(string GUOJIADQID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 GUOJIADQID,GUOJIADQDM,GUOJIADQMC from DZSQ_KHD_GJDQPZB ");
			strSql.Append(" where GUOJIADQID=@GUOJIADQID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GUOJIADQID", SqlDbType.NVarChar,100)			};
			parameters[0].Value = GUOJIADQID;

			IPSP.Model.DZSQ_KHD_GJDQPZB model=new IPSP.Model.DZSQ_KHD_GJDQPZB();
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
		public IPSP.Model.DZSQ_KHD_GJDQPZB DataRowToModel(DataRow row)
		{
			IPSP.Model.DZSQ_KHD_GJDQPZB model=new IPSP.Model.DZSQ_KHD_GJDQPZB();
			if (row != null)
			{
				if(row["GUOJIADQID"]!=null)
				{
					model.GUOJIADQID=row["GUOJIADQID"].ToString();
				}
				if(row["GUOJIADQDM"]!=null)
				{
					model.GUOJIADQDM=row["GUOJIADQDM"].ToString();
				}
				if(row["GUOJIADQMC"]!=null)
				{
					model.GUOJIADQMC=row["GUOJIADQMC"].ToString();
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
			strSql.Append("select GUOJIADQID,GUOJIADQDM,GUOJIADQMC ");
			strSql.Append(" FROM DZSQ_KHD_GJDQPZB ");
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
			strSql.Append(" GUOJIADQID,GUOJIADQDM,GUOJIADQMC ");
			strSql.Append(" FROM DZSQ_KHD_GJDQPZB ");
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
			strSql.Append("select count(1) FROM DZSQ_KHD_GJDQPZB ");
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
				strSql.Append("order by T.GUOJIADQID desc");
			}
			strSql.Append(")AS Row, T.*  from DZSQ_KHD_GJDQPZB T ");
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
			parameters[0].Value = "DZSQ_KHD_GJDQPZB";
			parameters[1].Value = "GUOJIADQID";
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

