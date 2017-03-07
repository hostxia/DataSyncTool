/**  版本信息模板在安装目录下，可自行修改。
* T_InFiles.cs
*
* 功 能： N/A
* 类 名： T_InFiles
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:51   N/A    初版
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
	/// 数据访问类:T_InFiles
	/// </summary>
	public partial class T_InFiles
	{
		public T_InFiles()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_FileID", "T_InFiles"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_FileID,int n_ClientID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_InFiles");
			strSql.Append(" where n_FileID=@n_FileID and n_ClientID=@n_ClientID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;
			parameters[1].Value = n_ClientID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.T_InFiles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_InFiles(");
			strSql.Append("n_FileID,n_FileCodeID,s_FileType,n_ClientID,n_GovOfficeID,s_Officer,s_OfficialNO,s_OFileStatus,s_NeedTransfer,s_Lock,s_Locker,n_AgencyOfficeID,dt_TransmitDate,s_GetCertificater,dt_GetCertificatedate,s_Distribute,s_Note,s_Urgent,n_ParentID,s_IsPreChange)");
			strSql.Append(" values (");
			strSql.Append("@n_FileID,@n_FileCodeID,@s_FileType,@n_ClientID,@n_GovOfficeID,@s_Officer,@s_OfficialNO,@s_OFileStatus,@s_NeedTransfer,@s_Lock,@s_Locker,@n_AgencyOfficeID,@dt_TransmitDate,@s_GetCertificater,@dt_GetCertificatedate,@s_Distribute,@s_Note,@s_Urgent,@n_ParentID,@s_IsPreChange)");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@n_FileCodeID", SqlDbType.Int,4),
					new SqlParameter("@s_FileType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_GovOfficeID", SqlDbType.Int,4),
					new SqlParameter("@s_Officer", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OfficialNO", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OFileStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@s_NeedTransfer", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,50),
					new SqlParameter("@n_AgencyOfficeID", SqlDbType.Int,4),
					new SqlParameter("@dt_TransmitDate", SqlDbType.DateTime),
					new SqlParameter("@s_GetCertificater", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_GetCertificatedate", SqlDbType.DateTime),
					new SqlParameter("@s_Distribute", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Urgent", SqlDbType.NVarChar,2),
					new SqlParameter("@n_ParentID", SqlDbType.Int,4),
					new SqlParameter("@s_IsPreChange", SqlDbType.NVarChar,1)};
			parameters[0].Value = model.n_FileID;
			parameters[1].Value = model.n_FileCodeID;
			parameters[2].Value = model.s_FileType;
			parameters[3].Value = model.n_ClientID;
			parameters[4].Value = model.n_GovOfficeID;
			parameters[5].Value = model.s_Officer;
			parameters[6].Value = model.s_OfficialNO;
			parameters[7].Value = model.s_OFileStatus;
			parameters[8].Value = model.s_NeedTransfer;
			parameters[9].Value = model.s_Lock;
			parameters[10].Value = model.s_Locker;
			parameters[11].Value = model.n_AgencyOfficeID;
			parameters[12].Value = model.dt_TransmitDate;
			parameters[13].Value = model.s_GetCertificater;
			parameters[14].Value = model.dt_GetCertificatedate;
			parameters[15].Value = model.s_Distribute;
			parameters[16].Value = model.s_Note;
			parameters[17].Value = model.s_Urgent;
			parameters[18].Value = model.n_ParentID;
			parameters[19].Value = model.s_IsPreChange;

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
		public bool Update(IPSP.Model.T_InFiles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_InFiles set ");
			strSql.Append("n_FileCodeID=@n_FileCodeID,");
			strSql.Append("s_FileType=@s_FileType,");
			strSql.Append("n_GovOfficeID=@n_GovOfficeID,");
			strSql.Append("s_Officer=@s_Officer,");
			strSql.Append("s_OfficialNO=@s_OfficialNO,");
			strSql.Append("s_OFileStatus=@s_OFileStatus,");
			strSql.Append("s_NeedTransfer=@s_NeedTransfer,");
			strSql.Append("s_Lock=@s_Lock,");
			strSql.Append("s_Locker=@s_Locker,");
			strSql.Append("n_AgencyOfficeID=@n_AgencyOfficeID,");
			strSql.Append("dt_TransmitDate=@dt_TransmitDate,");
			strSql.Append("s_GetCertificater=@s_GetCertificater,");
			strSql.Append("dt_GetCertificatedate=@dt_GetCertificatedate,");
			strSql.Append("s_Distribute=@s_Distribute,");
			strSql.Append("s_Note=@s_Note,");
			strSql.Append("s_Urgent=@s_Urgent,");
			strSql.Append("n_ParentID=@n_ParentID,");
			strSql.Append("s_IsPreChange=@s_IsPreChange");
			strSql.Append(" where n_FileID=@n_FileID and n_ClientID=@n_ClientID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileCodeID", SqlDbType.Int,4),
					new SqlParameter("@s_FileType", SqlDbType.NVarChar,50),
					new SqlParameter("@n_GovOfficeID", SqlDbType.Int,4),
					new SqlParameter("@s_Officer", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OfficialNO", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OFileStatus", SqlDbType.NVarChar,1),
					new SqlParameter("@s_NeedTransfer", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Lock", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Locker", SqlDbType.NVarChar,50),
					new SqlParameter("@n_AgencyOfficeID", SqlDbType.Int,4),
					new SqlParameter("@dt_TransmitDate", SqlDbType.DateTime),
					new SqlParameter("@s_GetCertificater", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_GetCertificatedate", SqlDbType.DateTime),
					new SqlParameter("@s_Distribute", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Urgent", SqlDbType.NVarChar,2),
					new SqlParameter("@n_ParentID", SqlDbType.Int,4),
					new SqlParameter("@s_IsPreChange", SqlDbType.NVarChar,1),
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_FileCodeID;
			parameters[1].Value = model.s_FileType;
			parameters[2].Value = model.n_GovOfficeID;
			parameters[3].Value = model.s_Officer;
			parameters[4].Value = model.s_OfficialNO;
			parameters[5].Value = model.s_OFileStatus;
			parameters[6].Value = model.s_NeedTransfer;
			parameters[7].Value = model.s_Lock;
			parameters[8].Value = model.s_Locker;
			parameters[9].Value = model.n_AgencyOfficeID;
			parameters[10].Value = model.dt_TransmitDate;
			parameters[11].Value = model.s_GetCertificater;
			parameters[12].Value = model.dt_GetCertificatedate;
			parameters[13].Value = model.s_Distribute;
			parameters[14].Value = model.s_Note;
			parameters[15].Value = model.s_Urgent;
			parameters[16].Value = model.n_ParentID;
			parameters[17].Value = model.s_IsPreChange;
			parameters[18].Value = model.n_FileID;
			parameters[19].Value = model.n_ClientID;

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
		public bool Delete(int n_FileID,int n_ClientID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_InFiles ");
			strSql.Append(" where n_FileID=@n_FileID and n_ClientID=@n_ClientID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;
			parameters[1].Value = n_ClientID;

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
		public IPSP.Model.T_InFiles GetModel(int n_FileID,int n_ClientID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_FileID,n_FileCodeID,s_FileType,n_ClientID,n_GovOfficeID,s_Officer,s_OfficialNO,s_OFileStatus,s_NeedTransfer,s_Lock,s_Locker,n_AgencyOfficeID,dt_TransmitDate,s_GetCertificater,dt_GetCertificatedate,s_Distribute,s_Note,s_Urgent,n_ParentID,s_IsPreChange from T_InFiles ");
			strSql.Append(" where n_FileID=@n_FileID and n_ClientID=@n_ClientID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;
			parameters[1].Value = n_ClientID;

			IPSP.Model.T_InFiles model=new IPSP.Model.T_InFiles();
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
		public IPSP.Model.T_InFiles DataRowToModel(DataRow row)
		{
			IPSP.Model.T_InFiles model=new IPSP.Model.T_InFiles();
			if (row != null)
			{
				if(row["n_FileID"]!=null && row["n_FileID"].ToString()!="")
				{
					model.n_FileID=int.Parse(row["n_FileID"].ToString());
				}
				if(row["n_FileCodeID"]!=null && row["n_FileCodeID"].ToString()!="")
				{
					model.n_FileCodeID=int.Parse(row["n_FileCodeID"].ToString());
				}
				if(row["s_FileType"]!=null)
				{
					model.s_FileType=row["s_FileType"].ToString();
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["n_GovOfficeID"]!=null && row["n_GovOfficeID"].ToString()!="")
				{
					model.n_GovOfficeID=int.Parse(row["n_GovOfficeID"].ToString());
				}
				if(row["s_Officer"]!=null)
				{
					model.s_Officer=row["s_Officer"].ToString();
				}
				if(row["s_OfficialNO"]!=null)
				{
					model.s_OfficialNO=row["s_OfficialNO"].ToString();
				}
				if(row["s_OFileStatus"]!=null)
				{
					model.s_OFileStatus=row["s_OFileStatus"].ToString();
				}
				if(row["s_NeedTransfer"]!=null)
				{
					model.s_NeedTransfer=row["s_NeedTransfer"].ToString();
				}
				if(row["s_Lock"]!=null)
				{
					model.s_Lock=row["s_Lock"].ToString();
				}
				if(row["s_Locker"]!=null)
				{
					model.s_Locker=row["s_Locker"].ToString();
				}
				if(row["n_AgencyOfficeID"]!=null && row["n_AgencyOfficeID"].ToString()!="")
				{
					model.n_AgencyOfficeID=int.Parse(row["n_AgencyOfficeID"].ToString());
				}
				if(row["dt_TransmitDate"]!=null && row["dt_TransmitDate"].ToString()!="")
				{
					model.dt_TransmitDate=DateTime.Parse(row["dt_TransmitDate"].ToString());
				}
				if(row["s_GetCertificater"]!=null)
				{
					model.s_GetCertificater=row["s_GetCertificater"].ToString();
				}
				if(row["dt_GetCertificatedate"]!=null && row["dt_GetCertificatedate"].ToString()!="")
				{
					model.dt_GetCertificatedate=DateTime.Parse(row["dt_GetCertificatedate"].ToString());
				}
				if(row["s_Distribute"]!=null)
				{
					model.s_Distribute=row["s_Distribute"].ToString();
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
				}
				if(row["s_Urgent"]!=null)
				{
					model.s_Urgent=row["s_Urgent"].ToString();
				}
				if(row["n_ParentID"]!=null && row["n_ParentID"].ToString()!="")
				{
					model.n_ParentID=int.Parse(row["n_ParentID"].ToString());
				}
				if(row["s_IsPreChange"]!=null)
				{
					model.s_IsPreChange=row["s_IsPreChange"].ToString();
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
			strSql.Append("select n_FileID,n_FileCodeID,s_FileType,n_ClientID,n_GovOfficeID,s_Officer,s_OfficialNO,s_OFileStatus,s_NeedTransfer,s_Lock,s_Locker,n_AgencyOfficeID,dt_TransmitDate,s_GetCertificater,dt_GetCertificatedate,s_Distribute,s_Note,s_Urgent,n_ParentID,s_IsPreChange ");
			strSql.Append(" FROM T_InFiles ");
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
			strSql.Append(" n_FileID,n_FileCodeID,s_FileType,n_ClientID,n_GovOfficeID,s_Officer,s_OfficialNO,s_OFileStatus,s_NeedTransfer,s_Lock,s_Locker,n_AgencyOfficeID,dt_TransmitDate,s_GetCertificater,dt_GetCertificatedate,s_Distribute,s_Note,s_Urgent,n_ParentID,s_IsPreChange ");
			strSql.Append(" FROM T_InFiles ");
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
			strSql.Append("select count(1) FROM T_InFiles ");
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
				strSql.Append("order by T.n_ClientID desc");
			}
			strSql.Append(")AS Row, T.*  from T_InFiles T ");
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
			parameters[0].Value = "T_InFiles";
			parameters[1].Value = "n_ClientID";
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

