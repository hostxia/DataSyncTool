/**  版本信息模板在安装目录下，可自行修改。
* TPCase_PCTICaseInfo.cs
*
* 功 能： N/A
* 类 名： TPCase_PCTICaseInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:37   N/A    初版
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
	/// 数据访问类:TPCase_PCTICaseInfo
	/// </summary>
	public partial class TPCase_PCTICaseInfo
	{
		public TPCase_PCTICaseInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TPCase_PCTICaseInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int Patent)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPCase_PCTICaseInfo");
			strSql.Append(" where n_CaseID=@n_CaseID and Patent=@Patent ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@Patent", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = Patent;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TPCase_PCTICaseInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPCase_PCTICaseInfo(");
			strSql.Append("n_CaseID,s_ISA,s_ISANum,dt_ISADate,n_ISACountry,Patent)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@s_ISA,@s_ISANum,@dt_ISADate,@n_ISACountry,@Patent)");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_ISA", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ISANum", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_ISADate", SqlDbType.DateTime),
					new SqlParameter("@n_ISACountry", SqlDbType.Int,4),
					new SqlParameter("@Patent", SqlDbType.Int,4)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_ISA;
			parameters[2].Value = model.s_ISANum;
			parameters[3].Value = model.dt_ISADate;
			parameters[4].Value = model.n_ISACountry;
			parameters[5].Value = model.Patent;

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
		public bool Update(IPSP.Model.TPCase_PCTICaseInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPCase_PCTICaseInfo set ");
			strSql.Append("s_ISA=@s_ISA,");
			strSql.Append("s_ISANum=@s_ISANum,");
			strSql.Append("dt_ISADate=@dt_ISADate,");
			strSql.Append("n_ISACountry=@n_ISACountry");
			strSql.Append(" where n_CaseID=@n_CaseID and Patent=@Patent ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ISA", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ISANum", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_ISADate", SqlDbType.DateTime),
					new SqlParameter("@n_ISACountry", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@Patent", SqlDbType.Int,4)};
			parameters[0].Value = model.s_ISA;
			parameters[1].Value = model.s_ISANum;
			parameters[2].Value = model.dt_ISADate;
			parameters[3].Value = model.n_ISACountry;
			parameters[4].Value = model.n_CaseID;
			parameters[5].Value = model.Patent;

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
		public bool Delete(int n_CaseID,int Patent)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPCase_PCTICaseInfo ");
			strSql.Append(" where n_CaseID=@n_CaseID and Patent=@Patent ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@Patent", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = Patent;

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
		/// 得到一个对象实体
		/// </summary>
		public IPSP.Model.TPCase_PCTICaseInfo GetModel(int n_CaseID,int Patent)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_CaseID,s_ISA,s_ISANum,dt_ISADate,n_ISACountry,Patent from TPCase_PCTICaseInfo ");
			strSql.Append(" where n_CaseID=@n_CaseID and Patent=@Patent ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@Patent", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = Patent;

			IPSP.Model.TPCase_PCTICaseInfo model=new IPSP.Model.TPCase_PCTICaseInfo();
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
		public IPSP.Model.TPCase_PCTICaseInfo DataRowToModel(DataRow row)
		{
			IPSP.Model.TPCase_PCTICaseInfo model=new IPSP.Model.TPCase_PCTICaseInfo();
			if (row != null)
			{
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["s_ISA"]!=null)
				{
					model.s_ISA=row["s_ISA"].ToString();
				}
				if(row["s_ISANum"]!=null)
				{
					model.s_ISANum=row["s_ISANum"].ToString();
				}
				if(row["dt_ISADate"]!=null && row["dt_ISADate"].ToString()!="")
				{
					model.dt_ISADate=DateTime.Parse(row["dt_ISADate"].ToString());
				}
				if(row["n_ISACountry"]!=null && row["n_ISACountry"].ToString()!="")
				{
					model.n_ISACountry=int.Parse(row["n_ISACountry"].ToString());
				}
				if(row["Patent"]!=null && row["Patent"].ToString()!="")
				{
					model.Patent=int.Parse(row["Patent"].ToString());
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
			strSql.Append("select n_CaseID,s_ISA,s_ISANum,dt_ISADate,n_ISACountry,Patent ");
			strSql.Append(" FROM TPCase_PCTICaseInfo ");
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
			strSql.Append(" n_CaseID,s_ISA,s_ISANum,dt_ISADate,n_ISACountry,Patent ");
			strSql.Append(" FROM TPCase_PCTICaseInfo ");
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
			strSql.Append("select count(1) FROM TPCase_PCTICaseInfo ");
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
				strSql.Append("order by T.Patent desc");
			}
			strSql.Append(")AS Row, T.*  from TPCase_PCTICaseInfo T ");
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
			parameters[0].Value = "TPCase_PCTICaseInfo";
			parameters[1].Value = "Patent";
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

