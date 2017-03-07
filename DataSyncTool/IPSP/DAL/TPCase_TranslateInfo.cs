/**  版本信息模板在安装目录下，可自行修改。
* TPCase_TranslateInfo.cs
*
* 功 能： N/A
* 类 名： TPCase_TranslateInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:52   N/A    初版
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
	/// 数据访问类:TPCase_TranslateInfo
	/// </summary>
	public partial class TPCase_TranslateInfo
	{
		public TPCase_TranslateInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TPCase_TranslateInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPCase_TranslateInfo");
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
		public int Add(IPSP.Model.TPCase_TranslateInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPCase_TranslateInfo(");
			strSql.Append("n_CaseID,n_OrigLan,n_OrigWordsNum,n_DestLan,n_TranslatorID,dt_TransAssignDate,dt_TransLtdDate,dt_TransEndDate,s_TransQuality,n_Collator1ID,n_Collator2ID,dt_CollateAssignDate,dt_CollateLtdDate,dt_CollateEndDate,n_TypeWriteByID)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@n_OrigLan,@n_OrigWordsNum,@n_DestLan,@n_TranslatorID,@dt_TransAssignDate,@dt_TransLtdDate,@dt_TransEndDate,@s_TransQuality,@n_Collator1ID,@n_Collator2ID,@dt_CollateAssignDate,@dt_CollateLtdDate,@dt_CollateEndDate,@n_TypeWriteByID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_OrigLan", SqlDbType.Int,4),
					new SqlParameter("@n_OrigWordsNum", SqlDbType.Int,4),
					new SqlParameter("@n_DestLan", SqlDbType.Int,4),
					new SqlParameter("@n_TranslatorID", SqlDbType.Int,4),
					new SqlParameter("@dt_TransAssignDate", SqlDbType.DateTime),
					new SqlParameter("@dt_TransLtdDate", SqlDbType.DateTime),
					new SqlParameter("@dt_TransEndDate", SqlDbType.DateTime),
					new SqlParameter("@s_TransQuality", SqlDbType.NVarChar,500),
					new SqlParameter("@n_Collator1ID", SqlDbType.Int,4),
					new SqlParameter("@n_Collator2ID", SqlDbType.Int,4),
					new SqlParameter("@dt_CollateAssignDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CollateLtdDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CollateEndDate", SqlDbType.DateTime),
					new SqlParameter("@n_TypeWriteByID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.n_OrigLan;
			parameters[2].Value = model.n_OrigWordsNum;
			parameters[3].Value = model.n_DestLan;
			parameters[4].Value = model.n_TranslatorID;
			parameters[5].Value = model.dt_TransAssignDate;
			parameters[6].Value = model.dt_TransLtdDate;
			parameters[7].Value = model.dt_TransEndDate;
			parameters[8].Value = model.s_TransQuality;
			parameters[9].Value = model.n_Collator1ID;
			parameters[10].Value = model.n_Collator2ID;
			parameters[11].Value = model.dt_CollateAssignDate;
			parameters[12].Value = model.dt_CollateLtdDate;
			parameters[13].Value = model.dt_CollateEndDate;
			parameters[14].Value = model.n_TypeWriteByID;

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
		public bool Update(IPSP.Model.TPCase_TranslateInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPCase_TranslateInfo set ");
			strSql.Append("n_OrigLan=@n_OrigLan,");
			strSql.Append("n_OrigWordsNum=@n_OrigWordsNum,");
			strSql.Append("n_DestLan=@n_DestLan,");
			strSql.Append("n_TranslatorID=@n_TranslatorID,");
			strSql.Append("dt_TransAssignDate=@dt_TransAssignDate,");
			strSql.Append("dt_TransLtdDate=@dt_TransLtdDate,");
			strSql.Append("dt_TransEndDate=@dt_TransEndDate,");
			strSql.Append("s_TransQuality=@s_TransQuality,");
			strSql.Append("n_Collator1ID=@n_Collator1ID,");
			strSql.Append("n_Collator2ID=@n_Collator2ID,");
			strSql.Append("dt_CollateAssignDate=@dt_CollateAssignDate,");
			strSql.Append("dt_CollateLtdDate=@dt_CollateLtdDate,");
			strSql.Append("dt_CollateEndDate=@dt_CollateEndDate,");
			strSql.Append("n_TypeWriteByID=@n_TypeWriteByID");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_OrigLan", SqlDbType.Int,4),
					new SqlParameter("@n_OrigWordsNum", SqlDbType.Int,4),
					new SqlParameter("@n_DestLan", SqlDbType.Int,4),
					new SqlParameter("@n_TranslatorID", SqlDbType.Int,4),
					new SqlParameter("@dt_TransAssignDate", SqlDbType.DateTime),
					new SqlParameter("@dt_TransLtdDate", SqlDbType.DateTime),
					new SqlParameter("@dt_TransEndDate", SqlDbType.DateTime),
					new SqlParameter("@s_TransQuality", SqlDbType.NVarChar,500),
					new SqlParameter("@n_Collator1ID", SqlDbType.Int,4),
					new SqlParameter("@n_Collator2ID", SqlDbType.Int,4),
					new SqlParameter("@dt_CollateAssignDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CollateLtdDate", SqlDbType.DateTime),
					new SqlParameter("@dt_CollateEndDate", SqlDbType.DateTime),
					new SqlParameter("@n_TypeWriteByID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_OrigLan;
			parameters[1].Value = model.n_OrigWordsNum;
			parameters[2].Value = model.n_DestLan;
			parameters[3].Value = model.n_TranslatorID;
			parameters[4].Value = model.dt_TransAssignDate;
			parameters[5].Value = model.dt_TransLtdDate;
			parameters[6].Value = model.dt_TransEndDate;
			parameters[7].Value = model.s_TransQuality;
			parameters[8].Value = model.n_Collator1ID;
			parameters[9].Value = model.n_Collator2ID;
			parameters[10].Value = model.dt_CollateAssignDate;
			parameters[11].Value = model.dt_CollateLtdDate;
			parameters[12].Value = model.dt_CollateEndDate;
			parameters[13].Value = model.n_TypeWriteByID;
			parameters[14].Value = model.n_ID;
			parameters[15].Value = model.n_CaseID;

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
			strSql.Append("delete from TPCase_TranslateInfo ");
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
			strSql.Append("delete from TPCase_TranslateInfo ");
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
			strSql.Append("delete from TPCase_TranslateInfo ");
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
		public IPSP.Model.TPCase_TranslateInfo GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CaseID,n_OrigLan,n_OrigWordsNum,n_DestLan,n_TranslatorID,dt_TransAssignDate,dt_TransLtdDate,dt_TransEndDate,s_TransQuality,n_Collator1ID,n_Collator2ID,dt_CollateAssignDate,dt_CollateLtdDate,dt_CollateEndDate,n_TypeWriteByID from TPCase_TranslateInfo ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TPCase_TranslateInfo model=new IPSP.Model.TPCase_TranslateInfo();
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
		public IPSP.Model.TPCase_TranslateInfo DataRowToModel(DataRow row)
		{
			IPSP.Model.TPCase_TranslateInfo model=new IPSP.Model.TPCase_TranslateInfo();
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
				if(row["n_OrigLan"]!=null && row["n_OrigLan"].ToString()!="")
				{
					model.n_OrigLan=int.Parse(row["n_OrigLan"].ToString());
				}
				if(row["n_OrigWordsNum"]!=null && row["n_OrigWordsNum"].ToString()!="")
				{
					model.n_OrigWordsNum=int.Parse(row["n_OrigWordsNum"].ToString());
				}
				if(row["n_DestLan"]!=null && row["n_DestLan"].ToString()!="")
				{
					model.n_DestLan=int.Parse(row["n_DestLan"].ToString());
				}
				if(row["n_TranslatorID"]!=null && row["n_TranslatorID"].ToString()!="")
				{
					model.n_TranslatorID=int.Parse(row["n_TranslatorID"].ToString());
				}
				if(row["dt_TransAssignDate"]!=null && row["dt_TransAssignDate"].ToString()!="")
				{
					model.dt_TransAssignDate=DateTime.Parse(row["dt_TransAssignDate"].ToString());
				}
				if(row["dt_TransLtdDate"]!=null && row["dt_TransLtdDate"].ToString()!="")
				{
					model.dt_TransLtdDate=DateTime.Parse(row["dt_TransLtdDate"].ToString());
				}
				if(row["dt_TransEndDate"]!=null && row["dt_TransEndDate"].ToString()!="")
				{
					model.dt_TransEndDate=DateTime.Parse(row["dt_TransEndDate"].ToString());
				}
				if(row["s_TransQuality"]!=null)
				{
					model.s_TransQuality=row["s_TransQuality"].ToString();
				}
				if(row["n_Collator1ID"]!=null && row["n_Collator1ID"].ToString()!="")
				{
					model.n_Collator1ID=int.Parse(row["n_Collator1ID"].ToString());
				}
				if(row["n_Collator2ID"]!=null && row["n_Collator2ID"].ToString()!="")
				{
					model.n_Collator2ID=int.Parse(row["n_Collator2ID"].ToString());
				}
				if(row["dt_CollateAssignDate"]!=null && row["dt_CollateAssignDate"].ToString()!="")
				{
					model.dt_CollateAssignDate=DateTime.Parse(row["dt_CollateAssignDate"].ToString());
				}
				if(row["dt_CollateLtdDate"]!=null && row["dt_CollateLtdDate"].ToString()!="")
				{
					model.dt_CollateLtdDate=DateTime.Parse(row["dt_CollateLtdDate"].ToString());
				}
				if(row["dt_CollateEndDate"]!=null && row["dt_CollateEndDate"].ToString()!="")
				{
					model.dt_CollateEndDate=DateTime.Parse(row["dt_CollateEndDate"].ToString());
				}
				if(row["n_TypeWriteByID"]!=null && row["n_TypeWriteByID"].ToString()!="")
				{
					model.n_TypeWriteByID=int.Parse(row["n_TypeWriteByID"].ToString());
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
			strSql.Append("select n_ID,n_CaseID,n_OrigLan,n_OrigWordsNum,n_DestLan,n_TranslatorID,dt_TransAssignDate,dt_TransLtdDate,dt_TransEndDate,s_TransQuality,n_Collator1ID,n_Collator2ID,dt_CollateAssignDate,dt_CollateLtdDate,dt_CollateEndDate,n_TypeWriteByID ");
			strSql.Append(" FROM TPCase_TranslateInfo ");
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
			strSql.Append(" n_ID,n_CaseID,n_OrigLan,n_OrigWordsNum,n_DestLan,n_TranslatorID,dt_TransAssignDate,dt_TransLtdDate,dt_TransEndDate,s_TransQuality,n_Collator1ID,n_Collator2ID,dt_CollateAssignDate,dt_CollateLtdDate,dt_CollateEndDate,n_TypeWriteByID ");
			strSql.Append(" FROM TPCase_TranslateInfo ");
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
			strSql.Append("select count(1) FROM TPCase_TranslateInfo ");
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
			strSql.Append(")AS Row, T.*  from TPCase_TranslateInfo T ");
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
			parameters[0].Value = "TPCase_TranslateInfo";
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

