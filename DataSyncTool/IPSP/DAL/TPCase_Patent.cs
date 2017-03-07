/**  版本信息模板在安装目录下，可自行修改。
* TPCase_Patent.cs
*
* 功 能： N/A
* 类 名： TPCase_Patent
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:34   N/A    初版
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
	/// 数据访问类:TPCase_Patent
	/// </summary>
	public partial class TPCase_Patent
	{
		public TPCase_Patent()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TPCase_Patent"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_LawID,int n_OrigPatInfoID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPCase_Patent");
			strSql.Append(" where n_CaseID=@n_CaseID and n_LawID=@n_LawID and n_OrigPatInfoID=@n_OrigPatInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_LawID", SqlDbType.Int,4),
					new SqlParameter("@n_OrigPatInfoID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_LawID;
			parameters[2].Value = n_OrigPatInfoID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TPCase_Patent model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPCase_Patent(");
			strSql.Append("n_CaseID,n_PFlowNum,n_LawID,n_PatentTypeID,s_TechnologyType,s_OldSerial,s_NPatentID,s_OrigCaseSerial,s_OrigAppNo,dt_OrigAppDate,s_PatentStatus,s_Notes,n_OrigPatInfoID,s_Inventors,dt_RequestSubmitDate,b_DivisionalCaseFlag,s_OrigCaseNo,s_AllInventorAddress,s_FristPriority,s_FirstPriorityNo,dt_FirstPriorityDate,s_FirstInventor,s_PriorityStatus,dt_PriorityStatusDate,dt_DivSubmitDate,s_DivisionAppNo,s_DivisionCaseNo)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@n_PFlowNum,@n_LawID,@n_PatentTypeID,@s_TechnologyType,@s_OldSerial,@s_NPatentID,@s_OrigCaseSerial,@s_OrigAppNo,@dt_OrigAppDate,@s_PatentStatus,@s_Notes,@n_OrigPatInfoID,@s_Inventors,@dt_RequestSubmitDate,@b_DivisionalCaseFlag,@s_OrigCaseNo,@s_AllInventorAddress,@s_FristPriority,@s_FirstPriorityNo,@dt_FirstPriorityDate,@s_FirstInventor,@s_PriorityStatus,@dt_PriorityStatusDate,@dt_DivSubmitDate,@s_DivisionAppNo,@s_DivisionCaseNo)");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_PFlowNum", SqlDbType.Int,4),
					new SqlParameter("@n_LawID", SqlDbType.Int,4),
					new SqlParameter("@n_PatentTypeID", SqlDbType.Int,4),
					new SqlParameter("@s_TechnologyType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OldSerial", SqlDbType.NVarChar,20),
					new SqlParameter("@s_NPatentID", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OrigCaseSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OrigAppNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_OrigAppDate", SqlDbType.DateTime),
					new SqlParameter("@s_PatentStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_OrigPatInfoID", SqlDbType.Int,4),
					new SqlParameter("@s_Inventors", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_RequestSubmitDate", SqlDbType.DateTime),
					new SqlParameter("@b_DivisionalCaseFlag", SqlDbType.Bit,1),
					new SqlParameter("@s_OrigCaseNo", SqlDbType.NVarChar,50),
					new SqlParameter("@s_AllInventorAddress", SqlDbType.NVarChar,500),
					new SqlParameter("@s_FristPriority", SqlDbType.NVarChar,500),
					new SqlParameter("@s_FirstPriorityNo", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_FirstPriorityDate", SqlDbType.DateTime),
					new SqlParameter("@s_FirstInventor", SqlDbType.NVarChar,200),
					new SqlParameter("@s_PriorityStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_PriorityStatusDate", SqlDbType.DateTime),
					new SqlParameter("@dt_DivSubmitDate", SqlDbType.DateTime),
					new SqlParameter("@s_DivisionAppNo", SqlDbType.NVarChar,50),
					new SqlParameter("@s_DivisionCaseNo", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.n_PFlowNum;
			parameters[2].Value = model.n_LawID;
			parameters[3].Value = model.n_PatentTypeID;
			parameters[4].Value = model.s_TechnologyType;
			parameters[5].Value = model.s_OldSerial;
			parameters[6].Value = model.s_NPatentID;
			parameters[7].Value = model.s_OrigCaseSerial;
			parameters[8].Value = model.s_OrigAppNo;
			parameters[9].Value = model.dt_OrigAppDate;
			parameters[10].Value = model.s_PatentStatus;
			parameters[11].Value = model.s_Notes;
			parameters[12].Value = model.n_OrigPatInfoID;
			parameters[13].Value = model.s_Inventors;
			parameters[14].Value = model.dt_RequestSubmitDate;
			parameters[15].Value = model.b_DivisionalCaseFlag;
			parameters[16].Value = model.s_OrigCaseNo;
			parameters[17].Value = model.s_AllInventorAddress;
			parameters[18].Value = model.s_FristPriority;
			parameters[19].Value = model.s_FirstPriorityNo;
			parameters[20].Value = model.dt_FirstPriorityDate;
			parameters[21].Value = model.s_FirstInventor;
			parameters[22].Value = model.s_PriorityStatus;
			parameters[23].Value = model.dt_PriorityStatusDate;
			parameters[24].Value = model.dt_DivSubmitDate;
			parameters[25].Value = model.s_DivisionAppNo;
			parameters[26].Value = model.s_DivisionCaseNo;

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
		public bool Update(IPSP.Model.TPCase_Patent model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPCase_Patent set ");
			strSql.Append("n_PFlowNum=@n_PFlowNum,");
			strSql.Append("n_PatentTypeID=@n_PatentTypeID,");
			strSql.Append("s_TechnologyType=@s_TechnologyType,");
			strSql.Append("s_OldSerial=@s_OldSerial,");
			strSql.Append("s_NPatentID=@s_NPatentID,");
			strSql.Append("s_OrigCaseSerial=@s_OrigCaseSerial,");
			strSql.Append("s_OrigAppNo=@s_OrigAppNo,");
			strSql.Append("dt_OrigAppDate=@dt_OrigAppDate,");
			strSql.Append("s_PatentStatus=@s_PatentStatus,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("s_Inventors=@s_Inventors,");
			strSql.Append("dt_RequestSubmitDate=@dt_RequestSubmitDate,");
			strSql.Append("b_DivisionalCaseFlag=@b_DivisionalCaseFlag,");
			strSql.Append("s_OrigCaseNo=@s_OrigCaseNo,");
			strSql.Append("s_AllInventorAddress=@s_AllInventorAddress,");
			strSql.Append("s_FristPriority=@s_FristPriority,");
			strSql.Append("s_FirstPriorityNo=@s_FirstPriorityNo,");
			strSql.Append("dt_FirstPriorityDate=@dt_FirstPriorityDate,");
			strSql.Append("s_FirstInventor=@s_FirstInventor,");
			strSql.Append("s_PriorityStatus=@s_PriorityStatus,");
			strSql.Append("dt_PriorityStatusDate=@dt_PriorityStatusDate,");
			strSql.Append("dt_DivSubmitDate=@dt_DivSubmitDate,");
			strSql.Append("s_DivisionAppNo=@s_DivisionAppNo,");
			strSql.Append("s_DivisionCaseNo=@s_DivisionCaseNo");
			strSql.Append(" where n_CaseID=@n_CaseID and n_LawID=@n_LawID and n_OrigPatInfoID=@n_OrigPatInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_PFlowNum", SqlDbType.Int,4),
					new SqlParameter("@n_PatentTypeID", SqlDbType.Int,4),
					new SqlParameter("@s_TechnologyType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OldSerial", SqlDbType.NVarChar,20),
					new SqlParameter("@s_NPatentID", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OrigCaseSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OrigAppNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_OrigAppDate", SqlDbType.DateTime),
					new SqlParameter("@s_PatentStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_Inventors", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_RequestSubmitDate", SqlDbType.DateTime),
					new SqlParameter("@b_DivisionalCaseFlag", SqlDbType.Bit,1),
					new SqlParameter("@s_OrigCaseNo", SqlDbType.NVarChar,50),
					new SqlParameter("@s_AllInventorAddress", SqlDbType.NVarChar,500),
					new SqlParameter("@s_FristPriority", SqlDbType.NVarChar,500),
					new SqlParameter("@s_FirstPriorityNo", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_FirstPriorityDate", SqlDbType.DateTime),
					new SqlParameter("@s_FirstInventor", SqlDbType.NVarChar,200),
					new SqlParameter("@s_PriorityStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@dt_PriorityStatusDate", SqlDbType.DateTime),
					new SqlParameter("@dt_DivSubmitDate", SqlDbType.DateTime),
					new SqlParameter("@s_DivisionAppNo", SqlDbType.NVarChar,50),
					new SqlParameter("@s_DivisionCaseNo", SqlDbType.NVarChar,50),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_LawID", SqlDbType.Int,4),
					new SqlParameter("@n_OrigPatInfoID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_PFlowNum;
			parameters[1].Value = model.n_PatentTypeID;
			parameters[2].Value = model.s_TechnologyType;
			parameters[3].Value = model.s_OldSerial;
			parameters[4].Value = model.s_NPatentID;
			parameters[5].Value = model.s_OrigCaseSerial;
			parameters[6].Value = model.s_OrigAppNo;
			parameters[7].Value = model.dt_OrigAppDate;
			parameters[8].Value = model.s_PatentStatus;
			parameters[9].Value = model.s_Notes;
			parameters[10].Value = model.s_Inventors;
			parameters[11].Value = model.dt_RequestSubmitDate;
			parameters[12].Value = model.b_DivisionalCaseFlag;
			parameters[13].Value = model.s_OrigCaseNo;
			parameters[14].Value = model.s_AllInventorAddress;
			parameters[15].Value = model.s_FristPriority;
			parameters[16].Value = model.s_FirstPriorityNo;
			parameters[17].Value = model.dt_FirstPriorityDate;
			parameters[18].Value = model.s_FirstInventor;
			parameters[19].Value = model.s_PriorityStatus;
			parameters[20].Value = model.dt_PriorityStatusDate;
			parameters[21].Value = model.dt_DivSubmitDate;
			parameters[22].Value = model.s_DivisionAppNo;
			parameters[23].Value = model.s_DivisionCaseNo;
			parameters[24].Value = model.n_CaseID;
			parameters[25].Value = model.n_LawID;
			parameters[26].Value = model.n_OrigPatInfoID;

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
		public bool Delete(int n_CaseID,int n_LawID,int n_OrigPatInfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPCase_Patent ");
			strSql.Append(" where n_CaseID=@n_CaseID and n_LawID=@n_LawID and n_OrigPatInfoID=@n_OrigPatInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_LawID", SqlDbType.Int,4),
					new SqlParameter("@n_OrigPatInfoID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_LawID;
			parameters[2].Value = n_OrigPatInfoID;

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
		public IPSP.Model.TPCase_Patent GetModel(int n_CaseID,int n_LawID,int n_OrigPatInfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_CaseID,n_PFlowNum,n_LawID,n_PatentTypeID,s_TechnologyType,s_OldSerial,s_NPatentID,s_OrigCaseSerial,s_OrigAppNo,dt_OrigAppDate,s_PatentStatus,s_Notes,n_OrigPatInfoID,s_Inventors,dt_RequestSubmitDate,b_DivisionalCaseFlag,s_OrigCaseNo,s_AllInventorAddress,s_FristPriority,s_FirstPriorityNo,dt_FirstPriorityDate,s_FirstInventor,s_PriorityStatus,dt_PriorityStatusDate,dt_DivSubmitDate,s_DivisionAppNo,s_DivisionCaseNo from TPCase_Patent ");
			strSql.Append(" where n_CaseID=@n_CaseID and n_LawID=@n_LawID and n_OrigPatInfoID=@n_OrigPatInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_LawID", SqlDbType.Int,4),
					new SqlParameter("@n_OrigPatInfoID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_LawID;
			parameters[2].Value = n_OrigPatInfoID;

			IPSP.Model.TPCase_Patent model=new IPSP.Model.TPCase_Patent();
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
		public IPSP.Model.TPCase_Patent DataRowToModel(DataRow row)
		{
			IPSP.Model.TPCase_Patent model=new IPSP.Model.TPCase_Patent();
			if (row != null)
			{
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["n_PFlowNum"]!=null && row["n_PFlowNum"].ToString()!="")
				{
					model.n_PFlowNum=int.Parse(row["n_PFlowNum"].ToString());
				}
				if(row["n_LawID"]!=null && row["n_LawID"].ToString()!="")
				{
					model.n_LawID=int.Parse(row["n_LawID"].ToString());
				}
				if(row["n_PatentTypeID"]!=null && row["n_PatentTypeID"].ToString()!="")
				{
					model.n_PatentTypeID=int.Parse(row["n_PatentTypeID"].ToString());
				}
				if(row["s_TechnologyType"]!=null)
				{
					model.s_TechnologyType=row["s_TechnologyType"].ToString();
				}
				if(row["s_OldSerial"]!=null)
				{
					model.s_OldSerial=row["s_OldSerial"].ToString();
				}
				if(row["s_NPatentID"]!=null)
				{
					model.s_NPatentID=row["s_NPatentID"].ToString();
				}
				if(row["s_OrigCaseSerial"]!=null)
				{
					model.s_OrigCaseSerial=row["s_OrigCaseSerial"].ToString();
				}
				if(row["s_OrigAppNo"]!=null)
				{
					model.s_OrigAppNo=row["s_OrigAppNo"].ToString();
				}
				if(row["dt_OrigAppDate"]!=null && row["dt_OrigAppDate"].ToString()!="")
				{
					model.dt_OrigAppDate=DateTime.Parse(row["dt_OrigAppDate"].ToString());
				}
				if(row["s_PatentStatus"]!=null)
				{
					model.s_PatentStatus=row["s_PatentStatus"].ToString();
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["n_OrigPatInfoID"]!=null && row["n_OrigPatInfoID"].ToString()!="")
				{
					model.n_OrigPatInfoID=int.Parse(row["n_OrigPatInfoID"].ToString());
				}
				if(row["s_Inventors"]!=null)
				{
					model.s_Inventors=row["s_Inventors"].ToString();
				}
				if(row["dt_RequestSubmitDate"]!=null && row["dt_RequestSubmitDate"].ToString()!="")
				{
					model.dt_RequestSubmitDate=DateTime.Parse(row["dt_RequestSubmitDate"].ToString());
				}
				if(row["b_DivisionalCaseFlag"]!=null && row["b_DivisionalCaseFlag"].ToString()!="")
				{
					if((row["b_DivisionalCaseFlag"].ToString()=="1")||(row["b_DivisionalCaseFlag"].ToString().ToLower()=="true"))
					{
						model.b_DivisionalCaseFlag=true;
					}
					else
					{
						model.b_DivisionalCaseFlag=false;
					}
				}
				if(row["s_OrigCaseNo"]!=null)
				{
					model.s_OrigCaseNo=row["s_OrigCaseNo"].ToString();
				}
				if(row["s_AllInventorAddress"]!=null)
				{
					model.s_AllInventorAddress=row["s_AllInventorAddress"].ToString();
				}
				if(row["s_FristPriority"]!=null)
				{
					model.s_FristPriority=row["s_FristPriority"].ToString();
				}
				if(row["s_FirstPriorityNo"]!=null)
				{
					model.s_FirstPriorityNo=row["s_FirstPriorityNo"].ToString();
				}
				if(row["dt_FirstPriorityDate"]!=null && row["dt_FirstPriorityDate"].ToString()!="")
				{
					model.dt_FirstPriorityDate=DateTime.Parse(row["dt_FirstPriorityDate"].ToString());
				}
				if(row["s_FirstInventor"]!=null)
				{
					model.s_FirstInventor=row["s_FirstInventor"].ToString();
				}
				if(row["s_PriorityStatus"]!=null)
				{
					model.s_PriorityStatus=row["s_PriorityStatus"].ToString();
				}
				if(row["dt_PriorityStatusDate"]!=null && row["dt_PriorityStatusDate"].ToString()!="")
				{
					model.dt_PriorityStatusDate=DateTime.Parse(row["dt_PriorityStatusDate"].ToString());
				}
				if(row["dt_DivSubmitDate"]!=null && row["dt_DivSubmitDate"].ToString()!="")
				{
					model.dt_DivSubmitDate=DateTime.Parse(row["dt_DivSubmitDate"].ToString());
				}
				if(row["s_DivisionAppNo"]!=null)
				{
					model.s_DivisionAppNo=row["s_DivisionAppNo"].ToString();
				}
				if(row["s_DivisionCaseNo"]!=null)
				{
					model.s_DivisionCaseNo=row["s_DivisionCaseNo"].ToString();
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
			strSql.Append("select n_CaseID,n_PFlowNum,n_LawID,n_PatentTypeID,s_TechnologyType,s_OldSerial,s_NPatentID,s_OrigCaseSerial,s_OrigAppNo,dt_OrigAppDate,s_PatentStatus,s_Notes,n_OrigPatInfoID,s_Inventors,dt_RequestSubmitDate,b_DivisionalCaseFlag,s_OrigCaseNo,s_AllInventorAddress,s_FristPriority,s_FirstPriorityNo,dt_FirstPriorityDate,s_FirstInventor,s_PriorityStatus,dt_PriorityStatusDate,dt_DivSubmitDate,s_DivisionAppNo,s_DivisionCaseNo ");
			strSql.Append(" FROM TPCase_Patent ");
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
			strSql.Append(" n_CaseID,n_PFlowNum,n_LawID,n_PatentTypeID,s_TechnologyType,s_OldSerial,s_NPatentID,s_OrigCaseSerial,s_OrigAppNo,dt_OrigAppDate,s_PatentStatus,s_Notes,n_OrigPatInfoID,s_Inventors,dt_RequestSubmitDate,b_DivisionalCaseFlag,s_OrigCaseNo,s_AllInventorAddress,s_FristPriority,s_FirstPriorityNo,dt_FirstPriorityDate,s_FirstInventor,s_PriorityStatus,dt_PriorityStatusDate,dt_DivSubmitDate,s_DivisionAppNo,s_DivisionCaseNo ");
			strSql.Append(" FROM TPCase_Patent ");
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
			strSql.Append("select count(1) FROM TPCase_Patent ");
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
				strSql.Append("order by T.n_OrigPatInfoID desc");
			}
			strSql.Append(")AS Row, T.*  from TPCase_Patent T ");
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
			parameters[0].Value = "TPCase_Patent";
			parameters[1].Value = "n_OrigPatInfoID";
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

