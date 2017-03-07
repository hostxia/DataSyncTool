/**  版本信息模板在安装目录下，可自行修改。
* TDCase_Domain.cs
*
* 功 能： N/A
* 类 名： TDCase_Domain
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:06   N/A    初版
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
	/// 数据访问类:TDCase_Domain
	/// </summary>
	public partial class TDCase_Domain
	{
		public TDCase_Domain()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TDCase_Domain"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TDCase_Domain");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TDCase_Domain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TDCase_Domain(");
			strSql.Append("n_CaseID,n_DFlowNum,s_ApplyPurpose,s_Manager,s_MainServerInfo,s_SecondaryServerInfo,dt_Apply,dt_Approve,s_DomainStatus,dt_NextRenewal)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@n_DFlowNum,@s_ApplyPurpose,@s_Manager,@s_MainServerInfo,@s_SecondaryServerInfo,@dt_Apply,@dt_Approve,@s_DomainStatus,@dt_NextRenewal)");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_DFlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_ApplyPurpose", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Manager", SqlDbType.NVarChar,50),
					new SqlParameter("@s_MainServerInfo", SqlDbType.NVarChar,500),
					new SqlParameter("@s_SecondaryServerInfo", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_Apply", SqlDbType.DateTime),
					new SqlParameter("@dt_Approve", SqlDbType.DateTime),
					new SqlParameter("@s_DomainStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_NextRenewal", SqlDbType.DateTime)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.n_DFlowNum;
			parameters[2].Value = model.s_ApplyPurpose;
			parameters[3].Value = model.s_Manager;
			parameters[4].Value = model.s_MainServerInfo;
			parameters[5].Value = model.s_SecondaryServerInfo;
			parameters[6].Value = model.dt_Apply;
			parameters[7].Value = model.dt_Approve;
			parameters[8].Value = model.s_DomainStatus;
			parameters[9].Value = model.dt_NextRenewal;

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
		public bool Update(IPSP.Model.TDCase_Domain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TDCase_Domain set ");
			strSql.Append("n_DFlowNum=@n_DFlowNum,");
			strSql.Append("s_ApplyPurpose=@s_ApplyPurpose,");
			strSql.Append("s_Manager=@s_Manager,");
			strSql.Append("s_MainServerInfo=@s_MainServerInfo,");
			strSql.Append("s_SecondaryServerInfo=@s_SecondaryServerInfo,");
			strSql.Append("dt_Apply=@dt_Apply,");
			strSql.Append("dt_Approve=@dt_Approve,");
			strSql.Append("s_DomainStatus=@s_DomainStatus,");
			strSql.Append("dt_NextRenewal=@dt_NextRenewal");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_DFlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_ApplyPurpose", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Manager", SqlDbType.NVarChar,50),
					new SqlParameter("@s_MainServerInfo", SqlDbType.NVarChar,500),
					new SqlParameter("@s_SecondaryServerInfo", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_Apply", SqlDbType.DateTime),
					new SqlParameter("@dt_Approve", SqlDbType.DateTime),
					new SqlParameter("@s_DomainStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_NextRenewal", SqlDbType.DateTime),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_DFlowNum;
			parameters[1].Value = model.s_ApplyPurpose;
			parameters[2].Value = model.s_Manager;
			parameters[3].Value = model.s_MainServerInfo;
			parameters[4].Value = model.s_SecondaryServerInfo;
			parameters[5].Value = model.dt_Apply;
			parameters[6].Value = model.dt_Approve;
			parameters[7].Value = model.s_DomainStatus;
			parameters[8].Value = model.dt_NextRenewal;
			parameters[9].Value = model.n_CaseID;

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
		public bool Delete(int n_CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TDCase_Domain ");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

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
		public bool DeleteList(string n_CaseIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TDCase_Domain ");
			strSql.Append(" where n_CaseID in ("+n_CaseIDlist + ")  ");
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
		public IPSP.Model.TDCase_Domain GetModel(int n_CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_CaseID,n_DFlowNum,s_ApplyPurpose,s_Manager,s_MainServerInfo,s_SecondaryServerInfo,dt_Apply,dt_Approve,s_DomainStatus,dt_NextRenewal from TDCase_Domain ");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

			IPSP.Model.TDCase_Domain model=new IPSP.Model.TDCase_Domain();
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
		public IPSP.Model.TDCase_Domain DataRowToModel(DataRow row)
		{
			IPSP.Model.TDCase_Domain model=new IPSP.Model.TDCase_Domain();
			if (row != null)
			{
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["n_DFlowNum"]!=null && row["n_DFlowNum"].ToString()!="")
				{
					model.n_DFlowNum=int.Parse(row["n_DFlowNum"].ToString());
				}
				if(row["s_ApplyPurpose"]!=null)
				{
					model.s_ApplyPurpose=row["s_ApplyPurpose"].ToString();
				}
				if(row["s_Manager"]!=null)
				{
					model.s_Manager=row["s_Manager"].ToString();
				}
				if(row["s_MainServerInfo"]!=null)
				{
					model.s_MainServerInfo=row["s_MainServerInfo"].ToString();
				}
				if(row["s_SecondaryServerInfo"]!=null)
				{
					model.s_SecondaryServerInfo=row["s_SecondaryServerInfo"].ToString();
				}
				if(row["dt_Apply"]!=null && row["dt_Apply"].ToString()!="")
				{
					model.dt_Apply=DateTime.Parse(row["dt_Apply"].ToString());
				}
				if(row["dt_Approve"]!=null && row["dt_Approve"].ToString()!="")
				{
					model.dt_Approve=DateTime.Parse(row["dt_Approve"].ToString());
				}
				if(row["s_DomainStatus"]!=null)
				{
					model.s_DomainStatus=row["s_DomainStatus"].ToString();
				}
				if(row["dt_NextRenewal"]!=null && row["dt_NextRenewal"].ToString()!="")
				{
					model.dt_NextRenewal=DateTime.Parse(row["dt_NextRenewal"].ToString());
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
			strSql.Append("select n_CaseID,n_DFlowNum,s_ApplyPurpose,s_Manager,s_MainServerInfo,s_SecondaryServerInfo,dt_Apply,dt_Approve,s_DomainStatus,dt_NextRenewal ");
			strSql.Append(" FROM TDCase_Domain ");
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
			strSql.Append(" n_CaseID,n_DFlowNum,s_ApplyPurpose,s_Manager,s_MainServerInfo,s_SecondaryServerInfo,dt_Apply,dt_Approve,s_DomainStatus,dt_NextRenewal ");
			strSql.Append(" FROM TDCase_Domain ");
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
			strSql.Append("select count(1) FROM TDCase_Domain ");
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
				strSql.Append("order by T.n_CaseID desc");
			}
			strSql.Append(")AS Row, T.*  from TDCase_Domain T ");
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
			parameters[0].Value = "TDCase_Domain";
			parameters[1].Value = "n_CaseID";
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

