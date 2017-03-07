/**  版本信息模板在安装目录下，可自行修改。
* TTCase_LawsuitInfo.cs
*
* 功 能： N/A
* 类 名： TTCase_LawsuitInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:38   N/A    初版
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
	/// 数据访问类:TTCase_LawsuitInfo
	/// </summary>
	public partial class TTCase_LawsuitInfo
	{
		public TTCase_LawsuitInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TTCase_LawsuitInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TTCase_LawsuitInfo");
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
		public int Add(IPSP.Model.TTCase_LawsuitInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TTCase_LawsuitInfo(");
			strSql.Append("n_CaseID,s_CaseBrief,s_CourtName,s_CourtAddr,s_CourtZipCode,s_CourtContact,s_CourtTel,s_CourtFax,s_CourtEmail,s_CourtSerial,dt_CourtRegDate,dt_CourtNoticeDate,s_Judge,s_CourtOfficer,s_AcceptCourt,s_CheckLevel,dt_PubProofDate,dt_CourtDate,dt_SubpoenaDate,dt_ReplyDate)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@s_CaseBrief,@s_CourtName,@s_CourtAddr,@s_CourtZipCode,@s_CourtContact,@s_CourtTel,@s_CourtFax,@s_CourtEmail,@s_CourtSerial,@dt_CourtRegDate,@dt_CourtNoticeDate,@s_Judge,@s_CourtOfficer,@s_AcceptCourt,@s_CheckLevel,@dt_PubProofDate,@dt_CourtDate,@dt_SubpoenaDate,@dt_ReplyDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_CaseBrief", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_CourtName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_CourtAddr", SqlDbType.NVarChar,300),
					new SqlParameter("@s_CourtZipCode", SqlDbType.NVarChar,10),
					new SqlParameter("@s_CourtContact", SqlDbType.NVarChar,200),
					new SqlParameter("@s_CourtTel", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CourtFax", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CourtEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CourtSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CourtRegDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CourtNoticeDate", SqlDbType.DateTime),
					new SqlParameter("@s_Judge", SqlDbType.NVarChar,200),
					new SqlParameter("@s_CourtOfficer", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AcceptCourt", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CheckLevel", SqlDbType.NVarChar,100),
					new SqlParameter("@dt_PubProofDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CourtDate", SqlDbType.DateTime),
					new SqlParameter("@dt_SubpoenaDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ReplyDate", SqlDbType.DateTime)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_CaseBrief;
			parameters[2].Value = model.s_CourtName;
			parameters[3].Value = model.s_CourtAddr;
			parameters[4].Value = model.s_CourtZipCode;
			parameters[5].Value = model.s_CourtContact;
			parameters[6].Value = model.s_CourtTel;
			parameters[7].Value = model.s_CourtFax;
			parameters[8].Value = model.s_CourtEmail;
			parameters[9].Value = model.s_CourtSerial;
			parameters[10].Value = model.dt_CourtRegDate;
			parameters[11].Value = model.dt_CourtNoticeDate;
			parameters[12].Value = model.s_Judge;
			parameters[13].Value = model.s_CourtOfficer;
			parameters[14].Value = model.s_AcceptCourt;
			parameters[15].Value = model.s_CheckLevel;
			parameters[16].Value = model.dt_PubProofDate;
			parameters[17].Value = model.dt_CourtDate;
			parameters[18].Value = model.dt_SubpoenaDate;
			parameters[19].Value = model.dt_ReplyDate;

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
		public bool Update(IPSP.Model.TTCase_LawsuitInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TTCase_LawsuitInfo set ");
			strSql.Append("s_CaseBrief=@s_CaseBrief,");
			strSql.Append("s_CourtName=@s_CourtName,");
			strSql.Append("s_CourtAddr=@s_CourtAddr,");
			strSql.Append("s_CourtZipCode=@s_CourtZipCode,");
			strSql.Append("s_CourtContact=@s_CourtContact,");
			strSql.Append("s_CourtTel=@s_CourtTel,");
			strSql.Append("s_CourtFax=@s_CourtFax,");
			strSql.Append("s_CourtEmail=@s_CourtEmail,");
			strSql.Append("s_CourtSerial=@s_CourtSerial,");
			strSql.Append("dt_CourtRegDate=@dt_CourtRegDate,");
			strSql.Append("dt_CourtNoticeDate=@dt_CourtNoticeDate,");
			strSql.Append("s_Judge=@s_Judge,");
			strSql.Append("s_CourtOfficer=@s_CourtOfficer,");
			strSql.Append("s_AcceptCourt=@s_AcceptCourt,");
			strSql.Append("s_CheckLevel=@s_CheckLevel,");
			strSql.Append("dt_PubProofDate=@dt_PubProofDate,");
			strSql.Append("dt_CourtDate=@dt_CourtDate,");
			strSql.Append("dt_SubpoenaDate=@dt_SubpoenaDate,");
			strSql.Append("dt_ReplyDate=@dt_ReplyDate");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_CaseBrief", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_CourtName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_CourtAddr", SqlDbType.NVarChar,300),
					new SqlParameter("@s_CourtZipCode", SqlDbType.NVarChar,10),
					new SqlParameter("@s_CourtContact", SqlDbType.NVarChar,200),
					new SqlParameter("@s_CourtTel", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CourtFax", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CourtEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CourtSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CourtRegDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CourtNoticeDate", SqlDbType.DateTime),
					new SqlParameter("@s_Judge", SqlDbType.NVarChar,200),
					new SqlParameter("@s_CourtOfficer", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AcceptCourt", SqlDbType.NVarChar,100),
					new SqlParameter("@s_CheckLevel", SqlDbType.NVarChar,100),
					new SqlParameter("@dt_PubProofDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CourtDate", SqlDbType.DateTime),
					new SqlParameter("@dt_SubpoenaDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ReplyDate", SqlDbType.DateTime),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_CaseBrief;
			parameters[1].Value = model.s_CourtName;
			parameters[2].Value = model.s_CourtAddr;
			parameters[3].Value = model.s_CourtZipCode;
			parameters[4].Value = model.s_CourtContact;
			parameters[5].Value = model.s_CourtTel;
			parameters[6].Value = model.s_CourtFax;
			parameters[7].Value = model.s_CourtEmail;
			parameters[8].Value = model.s_CourtSerial;
			parameters[9].Value = model.dt_CourtRegDate;
			parameters[10].Value = model.dt_CourtNoticeDate;
			parameters[11].Value = model.s_Judge;
			parameters[12].Value = model.s_CourtOfficer;
			parameters[13].Value = model.s_AcceptCourt;
			parameters[14].Value = model.s_CheckLevel;
			parameters[15].Value = model.dt_PubProofDate;
			parameters[16].Value = model.dt_CourtDate;
			parameters[17].Value = model.dt_SubpoenaDate;
			parameters[18].Value = model.dt_ReplyDate;
			parameters[19].Value = model.n_ID;
			parameters[20].Value = model.n_CaseID;

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
			strSql.Append("delete from TTCase_LawsuitInfo ");
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
			strSql.Append("delete from TTCase_LawsuitInfo ");
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
			strSql.Append("delete from TTCase_LawsuitInfo ");
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
		public IPSP.Model.TTCase_LawsuitInfo GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CaseID,s_CaseBrief,s_CourtName,s_CourtAddr,s_CourtZipCode,s_CourtContact,s_CourtTel,s_CourtFax,s_CourtEmail,s_CourtSerial,dt_CourtRegDate,dt_CourtNoticeDate,s_Judge,s_CourtOfficer,s_AcceptCourt,s_CheckLevel,dt_PubProofDate,dt_CourtDate,dt_SubpoenaDate,dt_ReplyDate from TTCase_LawsuitInfo ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TTCase_LawsuitInfo model=new IPSP.Model.TTCase_LawsuitInfo();
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
		public IPSP.Model.TTCase_LawsuitInfo DataRowToModel(DataRow row)
		{
			IPSP.Model.TTCase_LawsuitInfo model=new IPSP.Model.TTCase_LawsuitInfo();
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
				if(row["s_CaseBrief"]!=null)
				{
					model.s_CaseBrief=row["s_CaseBrief"].ToString();
				}
				if(row["s_CourtName"]!=null)
				{
					model.s_CourtName=row["s_CourtName"].ToString();
				}
				if(row["s_CourtAddr"]!=null)
				{
					model.s_CourtAddr=row["s_CourtAddr"].ToString();
				}
				if(row["s_CourtZipCode"]!=null)
				{
					model.s_CourtZipCode=row["s_CourtZipCode"].ToString();
				}
				if(row["s_CourtContact"]!=null)
				{
					model.s_CourtContact=row["s_CourtContact"].ToString();
				}
				if(row["s_CourtTel"]!=null)
				{
					model.s_CourtTel=row["s_CourtTel"].ToString();
				}
				if(row["s_CourtFax"]!=null)
				{
					model.s_CourtFax=row["s_CourtFax"].ToString();
				}
				if(row["s_CourtEmail"]!=null)
				{
					model.s_CourtEmail=row["s_CourtEmail"].ToString();
				}
				if(row["s_CourtSerial"]!=null)
				{
					model.s_CourtSerial=row["s_CourtSerial"].ToString();
				}
				if(row["dt_CourtRegDate"]!=null && row["dt_CourtRegDate"].ToString()!="")
				{
					model.dt_CourtRegDate=DateTime.Parse(row["dt_CourtRegDate"].ToString());
				}
				if(row["dt_CourtNoticeDate"]!=null && row["dt_CourtNoticeDate"].ToString()!="")
				{
					model.dt_CourtNoticeDate=DateTime.Parse(row["dt_CourtNoticeDate"].ToString());
				}
				if(row["s_Judge"]!=null)
				{
					model.s_Judge=row["s_Judge"].ToString();
				}
				if(row["s_CourtOfficer"]!=null)
				{
					model.s_CourtOfficer=row["s_CourtOfficer"].ToString();
				}
				if(row["s_AcceptCourt"]!=null)
				{
					model.s_AcceptCourt=row["s_AcceptCourt"].ToString();
				}
				if(row["s_CheckLevel"]!=null)
				{
					model.s_CheckLevel=row["s_CheckLevel"].ToString();
				}
				if(row["dt_PubProofDate"]!=null && row["dt_PubProofDate"].ToString()!="")
				{
					model.dt_PubProofDate=DateTime.Parse(row["dt_PubProofDate"].ToString());
				}
				if(row["dt_CourtDate"]!=null && row["dt_CourtDate"].ToString()!="")
				{
					model.dt_CourtDate=DateTime.Parse(row["dt_CourtDate"].ToString());
				}
				if(row["dt_SubpoenaDate"]!=null && row["dt_SubpoenaDate"].ToString()!="")
				{
					model.dt_SubpoenaDate=DateTime.Parse(row["dt_SubpoenaDate"].ToString());
				}
				if(row["dt_ReplyDate"]!=null && row["dt_ReplyDate"].ToString()!="")
				{
					model.dt_ReplyDate=DateTime.Parse(row["dt_ReplyDate"].ToString());
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
			strSql.Append("select n_ID,n_CaseID,s_CaseBrief,s_CourtName,s_CourtAddr,s_CourtZipCode,s_CourtContact,s_CourtTel,s_CourtFax,s_CourtEmail,s_CourtSerial,dt_CourtRegDate,dt_CourtNoticeDate,s_Judge,s_CourtOfficer,s_AcceptCourt,s_CheckLevel,dt_PubProofDate,dt_CourtDate,dt_SubpoenaDate,dt_ReplyDate ");
			strSql.Append(" FROM TTCase_LawsuitInfo ");
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
			strSql.Append(" n_ID,n_CaseID,s_CaseBrief,s_CourtName,s_CourtAddr,s_CourtZipCode,s_CourtContact,s_CourtTel,s_CourtFax,s_CourtEmail,s_CourtSerial,dt_CourtRegDate,dt_CourtNoticeDate,s_Judge,s_CourtOfficer,s_AcceptCourt,s_CheckLevel,dt_PubProofDate,dt_CourtDate,dt_SubpoenaDate,dt_ReplyDate ");
			strSql.Append(" FROM TTCase_LawsuitInfo ");
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
			strSql.Append("select count(1) FROM TTCase_LawsuitInfo ");
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
			strSql.Append(")AS Row, T.*  from TTCase_LawsuitInfo T ");
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
			parameters[0].Value = "TTCase_LawsuitInfo";
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

