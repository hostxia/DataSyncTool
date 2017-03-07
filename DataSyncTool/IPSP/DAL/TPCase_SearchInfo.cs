/**  版本信息模板在安装目录下，可自行修改。
* TPCase_SearchInfo.cs
*
* 功 能： N/A
* 类 名： TPCase_SearchInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:48   N/A    初版
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
	/// 数据访问类:TPCase_SearchInfo
	/// </summary>
	public partial class TPCase_SearchInfo
	{
		public TPCase_SearchInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TPCase_SearchInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPCase_SearchInfo");
			strSql.Append(" where n_CaseID=@n_CaseID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TPCase_SearchInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPCase_SearchInfo(");
			strSql.Append("n_CaseID,s_Property,s_Aim,s_SearchType,s_ReqDesc,s_SearchAppNumber,s_AppNumber,s_SearchAppDate,dt_AppDate,s_SearchApplicant,s_Applicant,s_SearchPatentName,s_PatentName,s_Result,dt_FulFillDate,s_SearchNotes,s_SearchTypeCode)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@s_Property,@s_Aim,@s_SearchType,@s_ReqDesc,@s_SearchAppNumber,@s_AppNumber,@s_SearchAppDate,@dt_AppDate,@s_SearchApplicant,@s_Applicant,@s_SearchPatentName,@s_PatentName,@s_Result,@dt_FulFillDate,@s_SearchNotes,@s_SearchTypeCode)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_Property", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Aim", SqlDbType.NVarChar,200),
					new SqlParameter("@s_SearchType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ReqDesc", SqlDbType.NVarChar,500),
					new SqlParameter("@s_SearchAppNumber", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AppNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@s_SearchAppDate", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_AppDate", SqlDbType.DateTime),
					new SqlParameter("@s_SearchApplicant", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Applicant", SqlDbType.NVarChar,300),
					new SqlParameter("@s_SearchPatentName", SqlDbType.NVarChar,1),
					new SqlParameter("@s_PatentName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Result", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_FulFillDate", SqlDbType.DateTime),
					new SqlParameter("@s_SearchNotes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_SearchTypeCode", SqlDbType.NVarChar,20)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_Property;
			parameters[2].Value = model.s_Aim;
			parameters[3].Value = model.s_SearchType;
			parameters[4].Value = model.s_ReqDesc;
			parameters[5].Value = model.s_SearchAppNumber;
			parameters[6].Value = model.s_AppNumber;
			parameters[7].Value = model.s_SearchAppDate;
			parameters[8].Value = model.dt_AppDate;
			parameters[9].Value = model.s_SearchApplicant;
			parameters[10].Value = model.s_Applicant;
			parameters[11].Value = model.s_SearchPatentName;
			parameters[12].Value = model.s_PatentName;
			parameters[13].Value = model.s_Result;
			parameters[14].Value = model.dt_FulFillDate;
			parameters[15].Value = model.s_SearchNotes;
			parameters[16].Value = model.s_SearchTypeCode;

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
		public bool Update(IPSP.Model.TPCase_SearchInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPCase_SearchInfo set ");
			strSql.Append("s_Property=@s_Property,");
			strSql.Append("s_Aim=@s_Aim,");
			strSql.Append("s_SearchType=@s_SearchType,");
			strSql.Append("s_ReqDesc=@s_ReqDesc,");
			strSql.Append("s_SearchAppNumber=@s_SearchAppNumber,");
			strSql.Append("s_AppNumber=@s_AppNumber,");
			strSql.Append("s_SearchAppDate=@s_SearchAppDate,");
			strSql.Append("dt_AppDate=@dt_AppDate,");
			strSql.Append("s_SearchApplicant=@s_SearchApplicant,");
			strSql.Append("s_Applicant=@s_Applicant,");
			strSql.Append("s_SearchPatentName=@s_SearchPatentName,");
			strSql.Append("s_PatentName=@s_PatentName,");
			strSql.Append("s_Result=@s_Result,");
			strSql.Append("dt_FulFillDate=@dt_FulFillDate,");
			strSql.Append("s_SearchNotes=@s_SearchNotes,");
			strSql.Append("s_SearchTypeCode=@s_SearchTypeCode");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Property", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Aim", SqlDbType.NVarChar,200),
					new SqlParameter("@s_SearchType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ReqDesc", SqlDbType.NVarChar,500),
					new SqlParameter("@s_SearchAppNumber", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AppNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@s_SearchAppDate", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_AppDate", SqlDbType.DateTime),
					new SqlParameter("@s_SearchApplicant", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Applicant", SqlDbType.NVarChar,300),
					new SqlParameter("@s_SearchPatentName", SqlDbType.NVarChar,1),
					new SqlParameter("@s_PatentName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Result", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_FulFillDate", SqlDbType.DateTime),
					new SqlParameter("@s_SearchNotes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_SearchTypeCode", SqlDbType.NVarChar,20),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Property;
			parameters[1].Value = model.s_Aim;
			parameters[2].Value = model.s_SearchType;
			parameters[3].Value = model.s_ReqDesc;
			parameters[4].Value = model.s_SearchAppNumber;
			parameters[5].Value = model.s_AppNumber;
			parameters[6].Value = model.s_SearchAppDate;
			parameters[7].Value = model.dt_AppDate;
			parameters[8].Value = model.s_SearchApplicant;
			parameters[9].Value = model.s_Applicant;
			parameters[10].Value = model.s_SearchPatentName;
			parameters[11].Value = model.s_PatentName;
			parameters[12].Value = model.s_Result;
			parameters[13].Value = model.dt_FulFillDate;
			parameters[14].Value = model.s_SearchNotes;
			parameters[15].Value = model.s_SearchTypeCode;
			parameters[16].Value = model.n_ID;
			parameters[17].Value = model.n_CaseID;

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
			strSql.Append("delete from TPCase_SearchInfo ");
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
		public bool Delete(int n_CaseID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPCase_SearchInfo ");
			strSql.Append(" where n_CaseID=@n_CaseID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
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
			strSql.Append("delete from TPCase_SearchInfo ");
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
		public IPSP.Model.TPCase_SearchInfo GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CaseID,s_Property,s_Aim,s_SearchType,s_ReqDesc,s_SearchAppNumber,s_AppNumber,s_SearchAppDate,dt_AppDate,s_SearchApplicant,s_Applicant,s_SearchPatentName,s_PatentName,s_Result,dt_FulFillDate,s_SearchNotes,s_SearchTypeCode from TPCase_SearchInfo ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TPCase_SearchInfo model=new IPSP.Model.TPCase_SearchInfo();
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
		public IPSP.Model.TPCase_SearchInfo DataRowToModel(DataRow row)
		{
			IPSP.Model.TPCase_SearchInfo model=new IPSP.Model.TPCase_SearchInfo();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["s_Property"]!=null)
				{
					model.s_Property=row["s_Property"].ToString();
				}
				if(row["s_Aim"]!=null)
				{
					model.s_Aim=row["s_Aim"].ToString();
				}
				if(row["s_SearchType"]!=null)
				{
					model.s_SearchType=row["s_SearchType"].ToString();
				}
				if(row["s_ReqDesc"]!=null)
				{
					model.s_ReqDesc=row["s_ReqDesc"].ToString();
				}
				if(row["s_SearchAppNumber"]!=null)
				{
					model.s_SearchAppNumber=row["s_SearchAppNumber"].ToString();
				}
				if(row["s_AppNumber"]!=null)
				{
					model.s_AppNumber=row["s_AppNumber"].ToString();
				}
				if(row["s_SearchAppDate"]!=null)
				{
					model.s_SearchAppDate=row["s_SearchAppDate"].ToString();
				}
				if(row["dt_AppDate"]!=null && row["dt_AppDate"].ToString()!="")
				{
					model.dt_AppDate=DateTime.Parse(row["dt_AppDate"].ToString());
				}
				if(row["s_SearchApplicant"]!=null)
				{
					model.s_SearchApplicant=row["s_SearchApplicant"].ToString();
				}
				if(row["s_Applicant"]!=null)
				{
					model.s_Applicant=row["s_Applicant"].ToString();
				}
				if(row["s_SearchPatentName"]!=null)
				{
					model.s_SearchPatentName=row["s_SearchPatentName"].ToString();
				}
				if(row["s_PatentName"]!=null)
				{
					model.s_PatentName=row["s_PatentName"].ToString();
				}
				if(row["s_Result"]!=null)
				{
					model.s_Result=row["s_Result"].ToString();
				}
				if(row["dt_FulFillDate"]!=null && row["dt_FulFillDate"].ToString()!="")
				{
					model.dt_FulFillDate=DateTime.Parse(row["dt_FulFillDate"].ToString());
				}
				if(row["s_SearchNotes"]!=null)
				{
					model.s_SearchNotes=row["s_SearchNotes"].ToString();
				}
				if(row["s_SearchTypeCode"]!=null)
				{
					model.s_SearchTypeCode=row["s_SearchTypeCode"].ToString();
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
			strSql.Append("select n_ID,n_CaseID,s_Property,s_Aim,s_SearchType,s_ReqDesc,s_SearchAppNumber,s_AppNumber,s_SearchAppDate,dt_AppDate,s_SearchApplicant,s_Applicant,s_SearchPatentName,s_PatentName,s_Result,dt_FulFillDate,s_SearchNotes,s_SearchTypeCode ");
			strSql.Append(" FROM TPCase_SearchInfo ");
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
			strSql.Append(" n_ID,n_CaseID,s_Property,s_Aim,s_SearchType,s_ReqDesc,s_SearchAppNumber,s_AppNumber,s_SearchAppDate,dt_AppDate,s_SearchApplicant,s_Applicant,s_SearchPatentName,s_PatentName,s_Result,dt_FulFillDate,s_SearchNotes,s_SearchTypeCode ");
			strSql.Append(" FROM TPCase_SearchInfo ");
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
			strSql.Append("select count(1) FROM TPCase_SearchInfo ");
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
			strSql.Append(")AS Row, T.*  from TPCase_SearchInfo T ");
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
			parameters[0].Value = "TPCase_SearchInfo";
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

