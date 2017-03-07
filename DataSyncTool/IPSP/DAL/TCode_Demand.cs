/**  版本信息模板在安装目录下，可自行修改。
* TCode_Demand.cs
*
* 功 能： N/A
* 类 名： TCode_Demand
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:12   N/A    初版
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
	/// 数据访问类:TCode_Demand
	/// </summary>
	public partial class TCode_Demand
	{
		public TCode_Demand()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CodeDemandTypeID", "TCode_Demand"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CodeDemandTypeID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_Demand");
			strSql.Append(" where n_CodeDemandTypeID=@n_CodeDemandTypeID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CodeDemandTypeID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CodeDemandTypeID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_Demand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_Demand(");
			strSql.Append("s_IPType,s_Type,s_Title,s_Description,n_IsActive,s_Creator,dt_CreateDate,s_Editor,dt_EditDate,s_SysDemand,dt_ReceiptDate,s_Assignor,s_ReceiptMethod,n_CodeDemandTypeID,n_DemadType,n_DemandType)");
			strSql.Append(" values (");
			strSql.Append("@s_IPType,@s_Type,@s_Title,@s_Description,@n_IsActive,@s_Creator,@dt_CreateDate,@s_Editor,@dt_EditDate,@s_SysDemand,@dt_ReceiptDate,@s_Assignor,@s_ReceiptMethod,@n_CodeDemandTypeID,@n_DemadType,@n_DemandType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Title", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,500),
					new SqlParameter("@n_IsActive", SqlDbType.Bit,1),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_SysDemand", SqlDbType.NVarChar,100),
					new SqlParameter("@dt_ReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@s_Assignor", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ReceiptMethod", SqlDbType.NVarChar,100),
					new SqlParameter("@n_CodeDemandTypeID", SqlDbType.Int,4),
					new SqlParameter("@n_DemadType", SqlDbType.Int,4),
					new SqlParameter("@n_DemandType", SqlDbType.Int,4)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_Type;
			parameters[2].Value = model.s_Title;
			parameters[3].Value = model.s_Description;
			parameters[4].Value = model.n_IsActive;
			parameters[5].Value = model.s_Creator;
			parameters[6].Value = model.dt_CreateDate;
			parameters[7].Value = model.s_Editor;
			parameters[8].Value = model.dt_EditDate;
			parameters[9].Value = model.s_SysDemand;
			parameters[10].Value = model.dt_ReceiptDate;
			parameters[11].Value = model.s_Assignor;
			parameters[12].Value = model.s_ReceiptMethod;
			parameters[13].Value = model.n_CodeDemandTypeID;
			parameters[14].Value = model.n_DemadType;
			parameters[15].Value = model.n_DemandType;

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
		public bool Update(IPSP.Model.TCode_Demand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_Demand set ");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_Type=@s_Type,");
			strSql.Append("s_Title=@s_Title,");
			strSql.Append("s_Description=@s_Description,");
			strSql.Append("n_IsActive=@n_IsActive,");
			strSql.Append("s_Creator=@s_Creator,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_SysDemand=@s_SysDemand,");
			strSql.Append("dt_ReceiptDate=@dt_ReceiptDate,");
			strSql.Append("s_Assignor=@s_Assignor,");
			strSql.Append("s_ReceiptMethod=@s_ReceiptMethod,");
			strSql.Append("n_DemadType=@n_DemadType,");
			strSql.Append("n_DemandType=@n_DemandType");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Title", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,500),
					new SqlParameter("@n_IsActive", SqlDbType.Bit,1),
					new SqlParameter("@s_Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_SysDemand", SqlDbType.NVarChar,100),
					new SqlParameter("@dt_ReceiptDate", SqlDbType.DateTime),
					new SqlParameter("@s_Assignor", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ReceiptMethod", SqlDbType.NVarChar,100),
					new SqlParameter("@n_DemadType", SqlDbType.Int,4),
					new SqlParameter("@n_DemandType", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CodeDemandTypeID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_Type;
			parameters[2].Value = model.s_Title;
			parameters[3].Value = model.s_Description;
			parameters[4].Value = model.n_IsActive;
			parameters[5].Value = model.s_Creator;
			parameters[6].Value = model.dt_CreateDate;
			parameters[7].Value = model.s_Editor;
			parameters[8].Value = model.dt_EditDate;
			parameters[9].Value = model.s_SysDemand;
			parameters[10].Value = model.dt_ReceiptDate;
			parameters[11].Value = model.s_Assignor;
			parameters[12].Value = model.s_ReceiptMethod;
			parameters[13].Value = model.n_DemadType;
			parameters[14].Value = model.n_DemandType;
			parameters[15].Value = model.n_ID;
			parameters[16].Value = model.n_CodeDemandTypeID;

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
			strSql.Append("delete from TCode_Demand ");
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
		public bool Delete(int n_CodeDemandTypeID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_Demand ");
			strSql.Append(" where n_CodeDemandTypeID=@n_CodeDemandTypeID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CodeDemandTypeID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CodeDemandTypeID;
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
			strSql.Append("delete from TCode_Demand ");
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
		public IPSP.Model.TCode_Demand GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_IPType,s_Type,s_Title,s_Description,n_IsActive,s_Creator,dt_CreateDate,s_Editor,dt_EditDate,s_SysDemand,dt_ReceiptDate,s_Assignor,s_ReceiptMethod,n_CodeDemandTypeID,n_DemadType,n_DemandType from TCode_Demand ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_Demand model=new IPSP.Model.TCode_Demand();
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
		public IPSP.Model.TCode_Demand DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_Demand model=new IPSP.Model.TCode_Demand();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["s_Type"]!=null)
				{
					model.s_Type=row["s_Type"].ToString();
				}
				if(row["s_Title"]!=null)
				{
					model.s_Title=row["s_Title"].ToString();
				}
				if(row["s_Description"]!=null)
				{
					model.s_Description=row["s_Description"].ToString();
				}
				if(row["n_IsActive"]!=null && row["n_IsActive"].ToString()!="")
				{
					if((row["n_IsActive"].ToString()=="1")||(row["n_IsActive"].ToString().ToLower()=="true"))
					{
						model.n_IsActive=true;
					}
					else
					{
						model.n_IsActive=false;
					}
				}
				if(row["s_Creator"]!=null)
				{
					model.s_Creator=row["s_Creator"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_SysDemand"]!=null)
				{
					model.s_SysDemand=row["s_SysDemand"].ToString();
				}
				if(row["dt_ReceiptDate"]!=null && row["dt_ReceiptDate"].ToString()!="")
				{
					model.dt_ReceiptDate=DateTime.Parse(row["dt_ReceiptDate"].ToString());
				}
				if(row["s_Assignor"]!=null)
				{
					model.s_Assignor=row["s_Assignor"].ToString();
				}
				if(row["s_ReceiptMethod"]!=null)
				{
					model.s_ReceiptMethod=row["s_ReceiptMethod"].ToString();
				}
				if(row["n_CodeDemandTypeID"]!=null && row["n_CodeDemandTypeID"].ToString()!="")
				{
					model.n_CodeDemandTypeID=int.Parse(row["n_CodeDemandTypeID"].ToString());
				}
				if(row["n_DemadType"]!=null && row["n_DemadType"].ToString()!="")
				{
					model.n_DemadType=int.Parse(row["n_DemadType"].ToString());
				}
				if(row["n_DemandType"]!=null && row["n_DemandType"].ToString()!="")
				{
					model.n_DemandType=int.Parse(row["n_DemandType"].ToString());
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
			strSql.Append("select n_ID,s_IPType,s_Type,s_Title,s_Description,n_IsActive,s_Creator,dt_CreateDate,s_Editor,dt_EditDate,s_SysDemand,dt_ReceiptDate,s_Assignor,s_ReceiptMethod,n_CodeDemandTypeID,n_DemadType,n_DemandType ");
			strSql.Append(" FROM TCode_Demand ");
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
			strSql.Append(" n_ID,s_IPType,s_Type,s_Title,s_Description,n_IsActive,s_Creator,dt_CreateDate,s_Editor,dt_EditDate,s_SysDemand,dt_ReceiptDate,s_Assignor,s_ReceiptMethod,n_CodeDemandTypeID,n_DemadType,n_DemandType ");
			strSql.Append(" FROM TCode_Demand ");
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
			strSql.Append("select count(1) FROM TCode_Demand ");
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
			strSql.Append(")AS Row, T.*  from TCode_Demand T ");
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
			parameters[0].Value = "TCode_Demand";
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

