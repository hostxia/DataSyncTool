/**  版本信息模板在安装目录下，可自行修改。
* TTCase_Trademark.cs
*
* 功 能： N/A
* 类 名： TTCase_Trademark
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:51:10   N/A    初版
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
	/// 数据访问类:TTCase_Trademark
	/// </summary>
	public partial class TTCase_Trademark
	{
		public TTCase_Trademark()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TTCase_Trademark"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_LawID,int ObjectType)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TTCase_Trademark");
			strSql.Append(" where n_CaseID=@n_CaseID and n_LawID=@n_LawID and ObjectType=@ObjectType ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_LawID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_LawID;
			parameters[2].Value = ObjectType;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TTCase_Trademark model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TTCase_Trademark(");
			strSql.Append("n_CaseID,n_GroupID,n_LawID,n_TFlowNum,s_TrademarkDesc,s_TrademarkType,s_TrademarkClass,s_IsMultClass,s_CollectiveApp,img_MainOrigImg,img_MainThumbnail,s_ApplyType,n_MadBasicCountry,s_MadBasicType,ObjectType,s_Notes,s_TrademarkStatus,s_OldSerial,s_GooodsNames,b_DivisionalCaseFlag,s_OrigAppNo,dt_OrigAppDate,s_OrigCaseNo,dt_DivSubmitDate,s_PriorityFileBackup)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@n_GroupID,@n_LawID,@n_TFlowNum,@s_TrademarkDesc,@s_TrademarkType,@s_TrademarkClass,@s_IsMultClass,@s_CollectiveApp,@img_MainOrigImg,@img_MainThumbnail,@s_ApplyType,@n_MadBasicCountry,@s_MadBasicType,@ObjectType,@s_Notes,@s_TrademarkStatus,@s_OldSerial,@s_GooodsNames,@b_DivisionalCaseFlag,@s_OrigAppNo,@dt_OrigAppDate,@s_OrigCaseNo,@dt_DivSubmitDate,@s_PriorityFileBackup)");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_GroupID", SqlDbType.Int,4),
					new SqlParameter("@n_LawID", SqlDbType.Int,4),
					new SqlParameter("@n_TFlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_TrademarkDesc", SqlDbType.NVarChar,500),
					new SqlParameter("@s_TrademarkType", SqlDbType.NVarChar,100),
					new SqlParameter("@s_TrademarkClass", SqlDbType.NVarChar,200),
					new SqlParameter("@s_IsMultClass", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CollectiveApp", SqlDbType.NVarChar,1),
					new SqlParameter("@img_MainOrigImg", SqlDbType.VarBinary,-1),
					new SqlParameter("@img_MainThumbnail", SqlDbType.VarBinary,-1),
					new SqlParameter("@s_ApplyType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_MadBasicCountry", SqlDbType.Int,4),
					new SqlParameter("@s_MadBasicType", SqlDbType.NVarChar,1),
					new SqlParameter("@ObjectType", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_TrademarkStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OldSerial", SqlDbType.NVarChar,100),
					new SqlParameter("@s_GooodsNames", SqlDbType.NVarChar,-1),
					new SqlParameter("@b_DivisionalCaseFlag", SqlDbType.Bit,1),
					new SqlParameter("@s_OrigAppNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_OrigAppDate", SqlDbType.DateTime),
					new SqlParameter("@s_OrigCaseNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_DivSubmitDate", SqlDbType.DateTime),
					new SqlParameter("@s_PriorityFileBackup", SqlDbType.NVarChar,1)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.n_GroupID;
			parameters[2].Value = model.n_LawID;
			parameters[3].Value = model.n_TFlowNum;
			parameters[4].Value = model.s_TrademarkDesc;
			parameters[5].Value = model.s_TrademarkType;
			parameters[6].Value = model.s_TrademarkClass;
			parameters[7].Value = model.s_IsMultClass;
			parameters[8].Value = model.s_CollectiveApp;
			parameters[9].Value = model.img_MainOrigImg;
			parameters[10].Value = model.img_MainThumbnail;
			parameters[11].Value = model.s_ApplyType;
			parameters[12].Value = model.n_MadBasicCountry;
			parameters[13].Value = model.s_MadBasicType;
			parameters[14].Value = model.ObjectType;
			parameters[15].Value = model.s_Notes;
			parameters[16].Value = model.s_TrademarkStatus;
			parameters[17].Value = model.s_OldSerial;
			parameters[18].Value = model.s_GooodsNames;
			parameters[19].Value = model.b_DivisionalCaseFlag;
			parameters[20].Value = model.s_OrigAppNo;
			parameters[21].Value = model.dt_OrigAppDate;
			parameters[22].Value = model.s_OrigCaseNo;
			parameters[23].Value = model.dt_DivSubmitDate;
			parameters[24].Value = model.s_PriorityFileBackup;

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
		public bool Update(IPSP.Model.TTCase_Trademark model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TTCase_Trademark set ");
			strSql.Append("n_GroupID=@n_GroupID,");
			strSql.Append("n_TFlowNum=@n_TFlowNum,");
			strSql.Append("s_TrademarkDesc=@s_TrademarkDesc,");
			strSql.Append("s_TrademarkType=@s_TrademarkType,");
			strSql.Append("s_TrademarkClass=@s_TrademarkClass,");
			strSql.Append("s_IsMultClass=@s_IsMultClass,");
			strSql.Append("s_CollectiveApp=@s_CollectiveApp,");
			strSql.Append("img_MainOrigImg=@img_MainOrigImg,");
			strSql.Append("img_MainThumbnail=@img_MainThumbnail,");
			strSql.Append("s_ApplyType=@s_ApplyType,");
			strSql.Append("n_MadBasicCountry=@n_MadBasicCountry,");
			strSql.Append("s_MadBasicType=@s_MadBasicType,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("s_TrademarkStatus=@s_TrademarkStatus,");
			strSql.Append("s_OldSerial=@s_OldSerial,");
			strSql.Append("s_GooodsNames=@s_GooodsNames,");
			strSql.Append("b_DivisionalCaseFlag=@b_DivisionalCaseFlag,");
			strSql.Append("s_OrigAppNo=@s_OrigAppNo,");
			strSql.Append("dt_OrigAppDate=@dt_OrigAppDate,");
			strSql.Append("s_OrigCaseNo=@s_OrigCaseNo,");
			strSql.Append("dt_DivSubmitDate=@dt_DivSubmitDate,");
			strSql.Append("s_PriorityFileBackup=@s_PriorityFileBackup");
			strSql.Append(" where n_CaseID=@n_CaseID and n_LawID=@n_LawID and ObjectType=@ObjectType ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_GroupID", SqlDbType.Int,4),
					new SqlParameter("@n_TFlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_TrademarkDesc", SqlDbType.NVarChar,500),
					new SqlParameter("@s_TrademarkType", SqlDbType.NVarChar,100),
					new SqlParameter("@s_TrademarkClass", SqlDbType.NVarChar,200),
					new SqlParameter("@s_IsMultClass", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CollectiveApp", SqlDbType.NVarChar,1),
					new SqlParameter("@img_MainOrigImg", SqlDbType.VarBinary,-1),
					new SqlParameter("@img_MainThumbnail", SqlDbType.VarBinary,-1),
					new SqlParameter("@s_ApplyType", SqlDbType.NVarChar,1),
					new SqlParameter("@n_MadBasicCountry", SqlDbType.Int,4),
					new SqlParameter("@s_MadBasicType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@s_TrademarkStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OldSerial", SqlDbType.NVarChar,100),
					new SqlParameter("@s_GooodsNames", SqlDbType.NVarChar,-1),
					new SqlParameter("@b_DivisionalCaseFlag", SqlDbType.Bit,1),
					new SqlParameter("@s_OrigAppNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_OrigAppDate", SqlDbType.DateTime),
					new SqlParameter("@s_OrigCaseNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_DivSubmitDate", SqlDbType.DateTime),
					new SqlParameter("@s_PriorityFileBackup", SqlDbType.NVarChar,1),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_LawID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.Int,4)};
			parameters[0].Value = model.n_GroupID;
			parameters[1].Value = model.n_TFlowNum;
			parameters[2].Value = model.s_TrademarkDesc;
			parameters[3].Value = model.s_TrademarkType;
			parameters[4].Value = model.s_TrademarkClass;
			parameters[5].Value = model.s_IsMultClass;
			parameters[6].Value = model.s_CollectiveApp;
			parameters[7].Value = model.img_MainOrigImg;
			parameters[8].Value = model.img_MainThumbnail;
			parameters[9].Value = model.s_ApplyType;
			parameters[10].Value = model.n_MadBasicCountry;
			parameters[11].Value = model.s_MadBasicType;
			parameters[12].Value = model.s_Notes;
			parameters[13].Value = model.s_TrademarkStatus;
			parameters[14].Value = model.s_OldSerial;
			parameters[15].Value = model.s_GooodsNames;
			parameters[16].Value = model.b_DivisionalCaseFlag;
			parameters[17].Value = model.s_OrigAppNo;
			parameters[18].Value = model.dt_OrigAppDate;
			parameters[19].Value = model.s_OrigCaseNo;
			parameters[20].Value = model.dt_DivSubmitDate;
			parameters[21].Value = model.s_PriorityFileBackup;
			parameters[22].Value = model.n_CaseID;
			parameters[23].Value = model.n_LawID;
			parameters[24].Value = model.ObjectType;

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
		public bool Delete(int n_CaseID,int n_LawID,int ObjectType)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TTCase_Trademark ");
			strSql.Append(" where n_CaseID=@n_CaseID and n_LawID=@n_LawID and ObjectType=@ObjectType ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_LawID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_LawID;
			parameters[2].Value = ObjectType;

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
		public IPSP.Model.TTCase_Trademark GetModel(int n_CaseID,int n_LawID,int ObjectType)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_CaseID,n_GroupID,n_LawID,n_TFlowNum,s_TrademarkDesc,s_TrademarkType,s_TrademarkClass,s_IsMultClass,s_CollectiveApp,img_MainOrigImg,img_MainThumbnail,s_ApplyType,n_MadBasicCountry,s_MadBasicType,ObjectType,s_Notes,s_TrademarkStatus,s_OldSerial,s_GooodsNames,b_DivisionalCaseFlag,s_OrigAppNo,dt_OrigAppDate,s_OrigCaseNo,dt_DivSubmitDate,s_PriorityFileBackup from TTCase_Trademark ");
			strSql.Append(" where n_CaseID=@n_CaseID and n_LawID=@n_LawID and ObjectType=@ObjectType ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_LawID", SqlDbType.Int,4),
					new SqlParameter("@ObjectType", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_LawID;
			parameters[2].Value = ObjectType;

			IPSP.Model.TTCase_Trademark model=new IPSP.Model.TTCase_Trademark();
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
		public IPSP.Model.TTCase_Trademark DataRowToModel(DataRow row)
		{
			IPSP.Model.TTCase_Trademark model=new IPSP.Model.TTCase_Trademark();
			if (row != null)
			{
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["n_GroupID"]!=null && row["n_GroupID"].ToString()!="")
				{
					model.n_GroupID=int.Parse(row["n_GroupID"].ToString());
				}
				if(row["n_LawID"]!=null && row["n_LawID"].ToString()!="")
				{
					model.n_LawID=int.Parse(row["n_LawID"].ToString());
				}
				if(row["n_TFlowNum"]!=null && row["n_TFlowNum"].ToString()!="")
				{
					model.n_TFlowNum=int.Parse(row["n_TFlowNum"].ToString());
				}
				if(row["s_TrademarkDesc"]!=null)
				{
					model.s_TrademarkDesc=row["s_TrademarkDesc"].ToString();
				}
				if(row["s_TrademarkType"]!=null)
				{
					model.s_TrademarkType=row["s_TrademarkType"].ToString();
				}
				if(row["s_TrademarkClass"]!=null)
				{
					model.s_TrademarkClass=row["s_TrademarkClass"].ToString();
				}
				if(row["s_IsMultClass"]!=null)
				{
					model.s_IsMultClass=row["s_IsMultClass"].ToString();
				}
				if(row["s_CollectiveApp"]!=null)
				{
					model.s_CollectiveApp=row["s_CollectiveApp"].ToString();
				}
				if(row["img_MainOrigImg"]!=null && row["img_MainOrigImg"].ToString()!="")
				{
					model.img_MainOrigImg=(byte[])row["img_MainOrigImg"];
				}
				if(row["img_MainThumbnail"]!=null && row["img_MainThumbnail"].ToString()!="")
				{
					model.img_MainThumbnail=(byte[])row["img_MainThumbnail"];
				}
				if(row["s_ApplyType"]!=null)
				{
					model.s_ApplyType=row["s_ApplyType"].ToString();
				}
				if(row["n_MadBasicCountry"]!=null && row["n_MadBasicCountry"].ToString()!="")
				{
					model.n_MadBasicCountry=int.Parse(row["n_MadBasicCountry"].ToString());
				}
				if(row["s_MadBasicType"]!=null)
				{
					model.s_MadBasicType=row["s_MadBasicType"].ToString();
				}
				if(row["ObjectType"]!=null && row["ObjectType"].ToString()!="")
				{
					model.ObjectType=int.Parse(row["ObjectType"].ToString());
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["s_TrademarkStatus"]!=null)
				{
					model.s_TrademarkStatus=row["s_TrademarkStatus"].ToString();
				}
				if(row["s_OldSerial"]!=null)
				{
					model.s_OldSerial=row["s_OldSerial"].ToString();
				}
				if(row["s_GooodsNames"]!=null)
				{
					model.s_GooodsNames=row["s_GooodsNames"].ToString();
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
				if(row["s_OrigAppNo"]!=null)
				{
					model.s_OrigAppNo=row["s_OrigAppNo"].ToString();
				}
				if(row["dt_OrigAppDate"]!=null && row["dt_OrigAppDate"].ToString()!="")
				{
					model.dt_OrigAppDate=DateTime.Parse(row["dt_OrigAppDate"].ToString());
				}
				if(row["s_OrigCaseNo"]!=null)
				{
					model.s_OrigCaseNo=row["s_OrigCaseNo"].ToString();
				}
				if(row["dt_DivSubmitDate"]!=null && row["dt_DivSubmitDate"].ToString()!="")
				{
					model.dt_DivSubmitDate=DateTime.Parse(row["dt_DivSubmitDate"].ToString());
				}
				if(row["s_PriorityFileBackup"]!=null)
				{
					model.s_PriorityFileBackup=row["s_PriorityFileBackup"].ToString();
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
			strSql.Append("select n_CaseID,n_GroupID,n_LawID,n_TFlowNum,s_TrademarkDesc,s_TrademarkType,s_TrademarkClass,s_IsMultClass,s_CollectiveApp,img_MainOrigImg,img_MainThumbnail,s_ApplyType,n_MadBasicCountry,s_MadBasicType,ObjectType,s_Notes,s_TrademarkStatus,s_OldSerial,s_GooodsNames,b_DivisionalCaseFlag,s_OrigAppNo,dt_OrigAppDate,s_OrigCaseNo,dt_DivSubmitDate,s_PriorityFileBackup ");
			strSql.Append(" FROM TTCase_Trademark ");
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
			strSql.Append(" n_CaseID,n_GroupID,n_LawID,n_TFlowNum,s_TrademarkDesc,s_TrademarkType,s_TrademarkClass,s_IsMultClass,s_CollectiveApp,img_MainOrigImg,img_MainThumbnail,s_ApplyType,n_MadBasicCountry,s_MadBasicType,ObjectType,s_Notes,s_TrademarkStatus,s_OldSerial,s_GooodsNames,b_DivisionalCaseFlag,s_OrigAppNo,dt_OrigAppDate,s_OrigCaseNo,dt_DivSubmitDate,s_PriorityFileBackup ");
			strSql.Append(" FROM TTCase_Trademark ");
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
			strSql.Append("select count(1) FROM TTCase_Trademark ");
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
				strSql.Append("order by T.ObjectType desc");
			}
			strSql.Append(")AS Row, T.*  from TTCase_Trademark T ");
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
			parameters[0].Value = "TTCase_Trademark";
			parameters[1].Value = "ObjectType";
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

