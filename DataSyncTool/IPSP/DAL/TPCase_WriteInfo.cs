/**  版本信息模板在安装目录下，可自行修改。
* TPCase_WriteInfo.cs
*
* 功 能： N/A
* 类 名： TPCase_WriteInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:54   N/A    初版
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
	/// 数据访问类:TPCase_WriteInfo
	/// </summary>
	public partial class TPCase_WriteInfo
	{
		public TPCase_WriteInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TPCase_WriteInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPCase_WriteInfo");
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
		public int Add(IPSP.Model.TPCase_WriteInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPCase_WriteInfo(");
			strSql.Append("n_CaseID,s_OrigCaseSerial,n_WriterID,dt_WriteAssignDate,dt_WriteLtdDate,dt_WriteEndDate,n_DescPageNum,n_ImgNum,n_PowerItemNum,s_WriteQuality,n_TypewriteID,n_TypeWritePageNum)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@s_OrigCaseSerial,@n_WriterID,@dt_WriteAssignDate,@dt_WriteLtdDate,@dt_WriteEndDate,@n_DescPageNum,@n_ImgNum,@n_PowerItemNum,@s_WriteQuality,@n_TypewriteID,@n_TypeWritePageNum)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_OrigCaseSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@n_WriterID", SqlDbType.Int,4),
					new SqlParameter("@dt_WriteAssignDate", SqlDbType.DateTime),
					new SqlParameter("@dt_WriteLtdDate", SqlDbType.DateTime),
					new SqlParameter("@dt_WriteEndDate", SqlDbType.DateTime),
					new SqlParameter("@n_DescPageNum", SqlDbType.Int,4),
					new SqlParameter("@n_ImgNum", SqlDbType.Int,4),
					new SqlParameter("@n_PowerItemNum", SqlDbType.Int,4),
					new SqlParameter("@s_WriteQuality", SqlDbType.NVarChar,300),
					new SqlParameter("@n_TypewriteID", SqlDbType.Int,4),
					new SqlParameter("@n_TypeWritePageNum", SqlDbType.Int,4)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_OrigCaseSerial;
			parameters[2].Value = model.n_WriterID;
			parameters[3].Value = model.dt_WriteAssignDate;
			parameters[4].Value = model.dt_WriteLtdDate;
			parameters[5].Value = model.dt_WriteEndDate;
			parameters[6].Value = model.n_DescPageNum;
			parameters[7].Value = model.n_ImgNum;
			parameters[8].Value = model.n_PowerItemNum;
			parameters[9].Value = model.s_WriteQuality;
			parameters[10].Value = model.n_TypewriteID;
			parameters[11].Value = model.n_TypeWritePageNum;

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
		public bool Update(IPSP.Model.TPCase_WriteInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPCase_WriteInfo set ");
			strSql.Append("s_OrigCaseSerial=@s_OrigCaseSerial,");
			strSql.Append("n_WriterID=@n_WriterID,");
			strSql.Append("dt_WriteAssignDate=@dt_WriteAssignDate,");
			strSql.Append("dt_WriteLtdDate=@dt_WriteLtdDate,");
			strSql.Append("dt_WriteEndDate=@dt_WriteEndDate,");
			strSql.Append("n_DescPageNum=@n_DescPageNum,");
			strSql.Append("n_ImgNum=@n_ImgNum,");
			strSql.Append("n_PowerItemNum=@n_PowerItemNum,");
			strSql.Append("s_WriteQuality=@s_WriteQuality,");
			strSql.Append("n_TypewriteID=@n_TypewriteID,");
			strSql.Append("n_TypeWritePageNum=@n_TypeWritePageNum");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_OrigCaseSerial", SqlDbType.NVarChar,50),
					new SqlParameter("@n_WriterID", SqlDbType.Int,4),
					new SqlParameter("@dt_WriteAssignDate", SqlDbType.DateTime),
					new SqlParameter("@dt_WriteLtdDate", SqlDbType.DateTime),
					new SqlParameter("@dt_WriteEndDate", SqlDbType.DateTime),
					new SqlParameter("@n_DescPageNum", SqlDbType.Int,4),
					new SqlParameter("@n_ImgNum", SqlDbType.Int,4),
					new SqlParameter("@n_PowerItemNum", SqlDbType.Int,4),
					new SqlParameter("@s_WriteQuality", SqlDbType.NVarChar,300),
					new SqlParameter("@n_TypewriteID", SqlDbType.Int,4),
					new SqlParameter("@n_TypeWritePageNum", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_OrigCaseSerial;
			parameters[1].Value = model.n_WriterID;
			parameters[2].Value = model.dt_WriteAssignDate;
			parameters[3].Value = model.dt_WriteLtdDate;
			parameters[4].Value = model.dt_WriteEndDate;
			parameters[5].Value = model.n_DescPageNum;
			parameters[6].Value = model.n_ImgNum;
			parameters[7].Value = model.n_PowerItemNum;
			parameters[8].Value = model.s_WriteQuality;
			parameters[9].Value = model.n_TypewriteID;
			parameters[10].Value = model.n_TypeWritePageNum;
			parameters[11].Value = model.n_ID;
			parameters[12].Value = model.n_CaseID;

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
			strSql.Append("delete from TPCase_WriteInfo ");
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
			strSql.Append("delete from TPCase_WriteInfo ");
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
			strSql.Append("delete from TPCase_WriteInfo ");
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
		public IPSP.Model.TPCase_WriteInfo GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CaseID,s_OrigCaseSerial,n_WriterID,dt_WriteAssignDate,dt_WriteLtdDate,dt_WriteEndDate,n_DescPageNum,n_ImgNum,n_PowerItemNum,s_WriteQuality,n_TypewriteID,n_TypeWritePageNum from TPCase_WriteInfo ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TPCase_WriteInfo model=new IPSP.Model.TPCase_WriteInfo();
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
		public IPSP.Model.TPCase_WriteInfo DataRowToModel(DataRow row)
		{
			IPSP.Model.TPCase_WriteInfo model=new IPSP.Model.TPCase_WriteInfo();
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
				if(row["s_OrigCaseSerial"]!=null)
				{
					model.s_OrigCaseSerial=row["s_OrigCaseSerial"].ToString();
				}
				if(row["n_WriterID"]!=null && row["n_WriterID"].ToString()!="")
				{
					model.n_WriterID=int.Parse(row["n_WriterID"].ToString());
				}
				if(row["dt_WriteAssignDate"]!=null && row["dt_WriteAssignDate"].ToString()!="")
				{
					model.dt_WriteAssignDate=DateTime.Parse(row["dt_WriteAssignDate"].ToString());
				}
				if(row["dt_WriteLtdDate"]!=null && row["dt_WriteLtdDate"].ToString()!="")
				{
					model.dt_WriteLtdDate=DateTime.Parse(row["dt_WriteLtdDate"].ToString());
				}
				if(row["dt_WriteEndDate"]!=null && row["dt_WriteEndDate"].ToString()!="")
				{
					model.dt_WriteEndDate=DateTime.Parse(row["dt_WriteEndDate"].ToString());
				}
				if(row["n_DescPageNum"]!=null && row["n_DescPageNum"].ToString()!="")
				{
					model.n_DescPageNum=int.Parse(row["n_DescPageNum"].ToString());
				}
				if(row["n_ImgNum"]!=null && row["n_ImgNum"].ToString()!="")
				{
					model.n_ImgNum=int.Parse(row["n_ImgNum"].ToString());
				}
				if(row["n_PowerItemNum"]!=null && row["n_PowerItemNum"].ToString()!="")
				{
					model.n_PowerItemNum=int.Parse(row["n_PowerItemNum"].ToString());
				}
				if(row["s_WriteQuality"]!=null)
				{
					model.s_WriteQuality=row["s_WriteQuality"].ToString();
				}
				if(row["n_TypewriteID"]!=null && row["n_TypewriteID"].ToString()!="")
				{
					model.n_TypewriteID=int.Parse(row["n_TypewriteID"].ToString());
				}
				if(row["n_TypeWritePageNum"]!=null && row["n_TypeWritePageNum"].ToString()!="")
				{
					model.n_TypeWritePageNum=int.Parse(row["n_TypeWritePageNum"].ToString());
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
			strSql.Append("select n_ID,n_CaseID,s_OrigCaseSerial,n_WriterID,dt_WriteAssignDate,dt_WriteLtdDate,dt_WriteEndDate,n_DescPageNum,n_ImgNum,n_PowerItemNum,s_WriteQuality,n_TypewriteID,n_TypeWritePageNum ");
			strSql.Append(" FROM TPCase_WriteInfo ");
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
			strSql.Append(" n_ID,n_CaseID,s_OrigCaseSerial,n_WriterID,dt_WriteAssignDate,dt_WriteLtdDate,dt_WriteEndDate,n_DescPageNum,n_ImgNum,n_PowerItemNum,s_WriteQuality,n_TypewriteID,n_TypeWritePageNum ");
			strSql.Append(" FROM TPCase_WriteInfo ");
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
			strSql.Append("select count(1) FROM TPCase_WriteInfo ");
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
			strSql.Append(")AS Row, T.*  from TPCase_WriteInfo T ");
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
			parameters[0].Value = "TPCase_WriteInfo";
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

