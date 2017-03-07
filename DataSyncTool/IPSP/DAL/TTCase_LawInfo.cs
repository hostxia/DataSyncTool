/**  版本信息模板在安装目录下，可自行修改。
* TTCase_LawInfo.cs
*
* 功 能： N/A
* 类 名： TTCase_LawInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:35   N/A    初版
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
	/// 数据访问类:TTCase_LawInfo
	/// </summary>
	public partial class TTCase_LawInfo
	{
		public TTCase_LawInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TTCase_LawInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TTCase_LawInfo");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TTCase_LawInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TTCase_LawInfo(");
			strSql.Append("s_AcceptNO,dt_AppDate,dt_FormalCheckDate,dt_EssCheckDate,s_AppNO,s_PrePubIssue,dt_PrePubDate,dt_RegistrationDate,s_PubIssue,s_RegistrationNO,dt_WithdrawDate,dt_ApprovedDate,s_PrePubNO,dt_BeginDate,dt_EndDate,dt_NextRenewal,s_MadFilingNo,dt_MadFilingDate,s_MadRegNo,dt_MadRegDate,n_MadLan,s_NTrademarkID)");
			strSql.Append(" values (");
			strSql.Append("@s_AcceptNO,@dt_AppDate,@dt_FormalCheckDate,@dt_EssCheckDate,@s_AppNO,@s_PrePubIssue,@dt_PrePubDate,@dt_RegistrationDate,@s_PubIssue,@s_RegistrationNO,@dt_WithdrawDate,@dt_ApprovedDate,@s_PrePubNO,@dt_BeginDate,@dt_EndDate,@dt_NextRenewal,@s_MadFilingNo,@dt_MadFilingDate,@s_MadRegNo,@dt_MadRegDate,@n_MadLan,@s_NTrademarkID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_AcceptNO", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_AppDate", SqlDbType.DateTime),
					new SqlParameter("@dt_FormalCheckDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EssCheckDate", SqlDbType.DateTime),
					new SqlParameter("@s_AppNO", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PrePubIssue", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_PrePubDate", SqlDbType.DateTime),
					new SqlParameter("@dt_RegistrationDate", SqlDbType.DateTime),
					new SqlParameter("@s_PubIssue", SqlDbType.NVarChar,50),
					new SqlParameter("@s_RegistrationNO", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_WithdrawDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ApprovedDate", SqlDbType.DateTime),
					new SqlParameter("@s_PrePubNO", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_BeginDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EndDate", SqlDbType.DateTime),
					new SqlParameter("@dt_NextRenewal", SqlDbType.DateTime),
					new SqlParameter("@s_MadFilingNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_MadFilingDate", SqlDbType.DateTime),
					new SqlParameter("@s_MadRegNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_MadRegDate", SqlDbType.DateTime),
					new SqlParameter("@n_MadLan", SqlDbType.Int,4),
					new SqlParameter("@s_NTrademarkID", SqlDbType.NVarChar,32)};
			parameters[0].Value = model.s_AcceptNO;
			parameters[1].Value = model.dt_AppDate;
			parameters[2].Value = model.dt_FormalCheckDate;
			parameters[3].Value = model.dt_EssCheckDate;
			parameters[4].Value = model.s_AppNO;
			parameters[5].Value = model.s_PrePubIssue;
			parameters[6].Value = model.dt_PrePubDate;
			parameters[7].Value = model.dt_RegistrationDate;
			parameters[8].Value = model.s_PubIssue;
			parameters[9].Value = model.s_RegistrationNO;
			parameters[10].Value = model.dt_WithdrawDate;
			parameters[11].Value = model.dt_ApprovedDate;
			parameters[12].Value = model.s_PrePubNO;
			parameters[13].Value = model.dt_BeginDate;
			parameters[14].Value = model.dt_EndDate;
			parameters[15].Value = model.dt_NextRenewal;
			parameters[16].Value = model.s_MadFilingNo;
			parameters[17].Value = model.dt_MadFilingDate;
			parameters[18].Value = model.s_MadRegNo;
			parameters[19].Value = model.dt_MadRegDate;
			parameters[20].Value = model.n_MadLan;
			parameters[21].Value = model.s_NTrademarkID;

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
		public bool Update(IPSP.Model.TTCase_LawInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TTCase_LawInfo set ");
			strSql.Append("s_AcceptNO=@s_AcceptNO,");
			strSql.Append("dt_AppDate=@dt_AppDate,");
			strSql.Append("dt_FormalCheckDate=@dt_FormalCheckDate,");
			strSql.Append("dt_EssCheckDate=@dt_EssCheckDate,");
			strSql.Append("s_AppNO=@s_AppNO,");
			strSql.Append("s_PrePubIssue=@s_PrePubIssue,");
			strSql.Append("dt_PrePubDate=@dt_PrePubDate,");
			strSql.Append("dt_RegistrationDate=@dt_RegistrationDate,");
			strSql.Append("s_PubIssue=@s_PubIssue,");
			strSql.Append("s_RegistrationNO=@s_RegistrationNO,");
			strSql.Append("dt_WithdrawDate=@dt_WithdrawDate,");
			strSql.Append("dt_ApprovedDate=@dt_ApprovedDate,");
			strSql.Append("s_PrePubNO=@s_PrePubNO,");
			strSql.Append("dt_BeginDate=@dt_BeginDate,");
			strSql.Append("dt_EndDate=@dt_EndDate,");
			strSql.Append("dt_NextRenewal=@dt_NextRenewal,");
			strSql.Append("s_MadFilingNo=@s_MadFilingNo,");
			strSql.Append("dt_MadFilingDate=@dt_MadFilingDate,");
			strSql.Append("s_MadRegNo=@s_MadRegNo,");
			strSql.Append("dt_MadRegDate=@dt_MadRegDate,");
			strSql.Append("n_MadLan=@n_MadLan,");
			strSql.Append("s_NTrademarkID=@s_NTrademarkID");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_AcceptNO", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_AppDate", SqlDbType.DateTime),
					new SqlParameter("@dt_FormalCheckDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EssCheckDate", SqlDbType.DateTime),
					new SqlParameter("@s_AppNO", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PrePubIssue", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_PrePubDate", SqlDbType.DateTime),
					new SqlParameter("@dt_RegistrationDate", SqlDbType.DateTime),
					new SqlParameter("@s_PubIssue", SqlDbType.NVarChar,50),
					new SqlParameter("@s_RegistrationNO", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_WithdrawDate", SqlDbType.DateTime),
					new SqlParameter("@dt_ApprovedDate", SqlDbType.DateTime),
					new SqlParameter("@s_PrePubNO", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_BeginDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EndDate", SqlDbType.DateTime),
					new SqlParameter("@dt_NextRenewal", SqlDbType.DateTime),
					new SqlParameter("@s_MadFilingNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_MadFilingDate", SqlDbType.DateTime),
					new SqlParameter("@s_MadRegNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_MadRegDate", SqlDbType.DateTime),
					new SqlParameter("@n_MadLan", SqlDbType.Int,4),
					new SqlParameter("@s_NTrademarkID", SqlDbType.NVarChar,32),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_AcceptNO;
			parameters[1].Value = model.dt_AppDate;
			parameters[2].Value = model.dt_FormalCheckDate;
			parameters[3].Value = model.dt_EssCheckDate;
			parameters[4].Value = model.s_AppNO;
			parameters[5].Value = model.s_PrePubIssue;
			parameters[6].Value = model.dt_PrePubDate;
			parameters[7].Value = model.dt_RegistrationDate;
			parameters[8].Value = model.s_PubIssue;
			parameters[9].Value = model.s_RegistrationNO;
			parameters[10].Value = model.dt_WithdrawDate;
			parameters[11].Value = model.dt_ApprovedDate;
			parameters[12].Value = model.s_PrePubNO;
			parameters[13].Value = model.dt_BeginDate;
			parameters[14].Value = model.dt_EndDate;
			parameters[15].Value = model.dt_NextRenewal;
			parameters[16].Value = model.s_MadFilingNo;
			parameters[17].Value = model.dt_MadFilingDate;
			parameters[18].Value = model.s_MadRegNo;
			parameters[19].Value = model.dt_MadRegDate;
			parameters[20].Value = model.n_MadLan;
			parameters[21].Value = model.s_NTrademarkID;
			parameters[22].Value = model.n_ID;

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
			strSql.Append("delete from TTCase_LawInfo ");
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string n_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TTCase_LawInfo ");
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
		public IPSP.Model.TTCase_LawInfo GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_AcceptNO,dt_AppDate,dt_FormalCheckDate,dt_EssCheckDate,s_AppNO,s_PrePubIssue,dt_PrePubDate,dt_RegistrationDate,s_PubIssue,s_RegistrationNO,dt_WithdrawDate,dt_ApprovedDate,s_PrePubNO,dt_BeginDate,dt_EndDate,dt_NextRenewal,s_MadFilingNo,dt_MadFilingDate,s_MadRegNo,dt_MadRegDate,n_MadLan,s_NTrademarkID from TTCase_LawInfo ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TTCase_LawInfo model=new IPSP.Model.TTCase_LawInfo();
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
		public IPSP.Model.TTCase_LawInfo DataRowToModel(DataRow row)
		{
			IPSP.Model.TTCase_LawInfo model=new IPSP.Model.TTCase_LawInfo();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_AcceptNO"]!=null)
				{
					model.s_AcceptNO=row["s_AcceptNO"].ToString();
				}
				if(row["dt_AppDate"]!=null && row["dt_AppDate"].ToString()!="")
				{
					model.dt_AppDate=DateTime.Parse(row["dt_AppDate"].ToString());
				}
				if(row["dt_FormalCheckDate"]!=null && row["dt_FormalCheckDate"].ToString()!="")
				{
					model.dt_FormalCheckDate=DateTime.Parse(row["dt_FormalCheckDate"].ToString());
				}
				if(row["dt_EssCheckDate"]!=null && row["dt_EssCheckDate"].ToString()!="")
				{
					model.dt_EssCheckDate=DateTime.Parse(row["dt_EssCheckDate"].ToString());
				}
				if(row["s_AppNO"]!=null)
				{
					model.s_AppNO=row["s_AppNO"].ToString();
				}
				if(row["s_PrePubIssue"]!=null)
				{
					model.s_PrePubIssue=row["s_PrePubIssue"].ToString();
				}
				if(row["dt_PrePubDate"]!=null && row["dt_PrePubDate"].ToString()!="")
				{
					model.dt_PrePubDate=DateTime.Parse(row["dt_PrePubDate"].ToString());
				}
				if(row["dt_RegistrationDate"]!=null && row["dt_RegistrationDate"].ToString()!="")
				{
					model.dt_RegistrationDate=DateTime.Parse(row["dt_RegistrationDate"].ToString());
				}
				if(row["s_PubIssue"]!=null)
				{
					model.s_PubIssue=row["s_PubIssue"].ToString();
				}
				if(row["s_RegistrationNO"]!=null)
				{
					model.s_RegistrationNO=row["s_RegistrationNO"].ToString();
				}
				if(row["dt_WithdrawDate"]!=null && row["dt_WithdrawDate"].ToString()!="")
				{
					model.dt_WithdrawDate=DateTime.Parse(row["dt_WithdrawDate"].ToString());
				}
				if(row["dt_ApprovedDate"]!=null && row["dt_ApprovedDate"].ToString()!="")
				{
					model.dt_ApprovedDate=DateTime.Parse(row["dt_ApprovedDate"].ToString());
				}
				if(row["s_PrePubNO"]!=null)
				{
					model.s_PrePubNO=row["s_PrePubNO"].ToString();
				}
				if(row["dt_BeginDate"]!=null && row["dt_BeginDate"].ToString()!="")
				{
					model.dt_BeginDate=DateTime.Parse(row["dt_BeginDate"].ToString());
				}
				if(row["dt_EndDate"]!=null && row["dt_EndDate"].ToString()!="")
				{
					model.dt_EndDate=DateTime.Parse(row["dt_EndDate"].ToString());
				}
				if(row["dt_NextRenewal"]!=null && row["dt_NextRenewal"].ToString()!="")
				{
					model.dt_NextRenewal=DateTime.Parse(row["dt_NextRenewal"].ToString());
				}
				if(row["s_MadFilingNo"]!=null)
				{
					model.s_MadFilingNo=row["s_MadFilingNo"].ToString();
				}
				if(row["dt_MadFilingDate"]!=null && row["dt_MadFilingDate"].ToString()!="")
				{
					model.dt_MadFilingDate=DateTime.Parse(row["dt_MadFilingDate"].ToString());
				}
				if(row["s_MadRegNo"]!=null)
				{
					model.s_MadRegNo=row["s_MadRegNo"].ToString();
				}
				if(row["dt_MadRegDate"]!=null && row["dt_MadRegDate"].ToString()!="")
				{
					model.dt_MadRegDate=DateTime.Parse(row["dt_MadRegDate"].ToString());
				}
				if(row["n_MadLan"]!=null && row["n_MadLan"].ToString()!="")
				{
					model.n_MadLan=int.Parse(row["n_MadLan"].ToString());
				}
				if(row["s_NTrademarkID"]!=null)
				{
					model.s_NTrademarkID=row["s_NTrademarkID"].ToString();
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
			strSql.Append("select n_ID,s_AcceptNO,dt_AppDate,dt_FormalCheckDate,dt_EssCheckDate,s_AppNO,s_PrePubIssue,dt_PrePubDate,dt_RegistrationDate,s_PubIssue,s_RegistrationNO,dt_WithdrawDate,dt_ApprovedDate,s_PrePubNO,dt_BeginDate,dt_EndDate,dt_NextRenewal,s_MadFilingNo,dt_MadFilingDate,s_MadRegNo,dt_MadRegDate,n_MadLan,s_NTrademarkID ");
			strSql.Append(" FROM TTCase_LawInfo ");
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
			strSql.Append(" n_ID,s_AcceptNO,dt_AppDate,dt_FormalCheckDate,dt_EssCheckDate,s_AppNO,s_PrePubIssue,dt_PrePubDate,dt_RegistrationDate,s_PubIssue,s_RegistrationNO,dt_WithdrawDate,dt_ApprovedDate,s_PrePubNO,dt_BeginDate,dt_EndDate,dt_NextRenewal,s_MadFilingNo,dt_MadFilingDate,s_MadRegNo,dt_MadRegDate,n_MadLan,s_NTrademarkID ");
			strSql.Append(" FROM TTCase_LawInfo ");
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
			strSql.Append("select count(1) FROM TTCase_LawInfo ");
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
			strSql.Append(")AS Row, T.*  from TTCase_LawInfo T ");
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
			parameters[0].Value = "TTCase_LawInfo";
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

