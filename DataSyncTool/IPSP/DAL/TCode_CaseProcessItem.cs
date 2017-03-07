/**  版本信息模板在安装目录下，可自行修改。
* TCode_CaseProcessItem.cs
*
* 功 能： N/A
* 类 名： TCode_CaseProcessItem
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:55   N/A    初版
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
	/// 数据访问类:TCode_CaseProcessItem
	/// </summary>
	public partial class TCode_CaseProcessItem
	{
		public TCode_CaseProcessItem()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_MasterID", "TCode_CaseProcessItem"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_MasterID,int n_ProcessNameID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_CaseProcessItem");
			strSql.Append(" where n_MasterID=@n_MasterID and n_ProcessNameID=@n_ProcessNameID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_MasterID", SqlDbType.Int,4),
					new SqlParameter("@n_ProcessNameID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_MasterID;
			parameters[1].Value = n_ProcessNameID;
			parameters[2].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_CaseProcessItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_CaseProcessItem(");
			strSql.Append("n_MasterID,n_ProcessNameID,n_PatentID,n_OrderNum,s_AutoCreate,s_AllowRepeat,n_EMinTimeValue,s_EMinTimeUnit,n_EMaxTimeValue,s_EMaxTimeUnit,s_Note,s_BaseDate)");
			strSql.Append(" values (");
			strSql.Append("@n_MasterID,@n_ProcessNameID,@n_PatentID,@n_OrderNum,@s_AutoCreate,@s_AllowRepeat,@n_EMinTimeValue,@s_EMinTimeUnit,@n_EMaxTimeValue,@s_EMaxTimeUnit,@s_Note,@s_BaseDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_MasterID", SqlDbType.Int,4),
					new SqlParameter("@n_ProcessNameID", SqlDbType.Int,4),
					new SqlParameter("@n_PatentID", SqlDbType.Int,4),
					new SqlParameter("@n_OrderNum", SqlDbType.Int,4),
					new SqlParameter("@s_AutoCreate", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AllowRepeat", SqlDbType.NVarChar,50),
					new SqlParameter("@n_EMinTimeValue", SqlDbType.Decimal,5),
					new SqlParameter("@s_EMinTimeUnit", SqlDbType.NVarChar,5),
					new SqlParameter("@n_EMaxTimeValue", SqlDbType.Decimal,5),
					new SqlParameter("@s_EMaxTimeUnit", SqlDbType.NVarChar,5),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,50),
					new SqlParameter("@s_BaseDate", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.n_MasterID;
			parameters[1].Value = model.n_ProcessNameID;
			parameters[2].Value = model.n_PatentID;
			parameters[3].Value = model.n_OrderNum;
			parameters[4].Value = model.s_AutoCreate;
			parameters[5].Value = model.s_AllowRepeat;
			parameters[6].Value = model.n_EMinTimeValue;
			parameters[7].Value = model.s_EMinTimeUnit;
			parameters[8].Value = model.n_EMaxTimeValue;
			parameters[9].Value = model.s_EMaxTimeUnit;
			parameters[10].Value = model.s_Note;
			parameters[11].Value = model.s_BaseDate;

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
		public bool Update(IPSP.Model.TCode_CaseProcessItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_CaseProcessItem set ");
			strSql.Append("n_PatentID=@n_PatentID,");
			strSql.Append("n_OrderNum=@n_OrderNum,");
			strSql.Append("s_AutoCreate=@s_AutoCreate,");
			strSql.Append("s_AllowRepeat=@s_AllowRepeat,");
			strSql.Append("n_EMinTimeValue=@n_EMinTimeValue,");
			strSql.Append("s_EMinTimeUnit=@s_EMinTimeUnit,");
			strSql.Append("n_EMaxTimeValue=@n_EMaxTimeValue,");
			strSql.Append("s_EMaxTimeUnit=@s_EMaxTimeUnit,");
			strSql.Append("s_Note=@s_Note,");
			strSql.Append("s_BaseDate=@s_BaseDate");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_PatentID", SqlDbType.Int,4),
					new SqlParameter("@n_OrderNum", SqlDbType.Int,4),
					new SqlParameter("@s_AutoCreate", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AllowRepeat", SqlDbType.NVarChar,50),
					new SqlParameter("@n_EMinTimeValue", SqlDbType.Decimal,5),
					new SqlParameter("@s_EMinTimeUnit", SqlDbType.NVarChar,5),
					new SqlParameter("@n_EMaxTimeValue", SqlDbType.Decimal,5),
					new SqlParameter("@s_EMaxTimeUnit", SqlDbType.NVarChar,5),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,50),
					new SqlParameter("@s_BaseDate", SqlDbType.NVarChar,200),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_MasterID", SqlDbType.Int,4),
					new SqlParameter("@n_ProcessNameID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_PatentID;
			parameters[1].Value = model.n_OrderNum;
			parameters[2].Value = model.s_AutoCreate;
			parameters[3].Value = model.s_AllowRepeat;
			parameters[4].Value = model.n_EMinTimeValue;
			parameters[5].Value = model.s_EMinTimeUnit;
			parameters[6].Value = model.n_EMaxTimeValue;
			parameters[7].Value = model.s_EMaxTimeUnit;
			parameters[8].Value = model.s_Note;
			parameters[9].Value = model.s_BaseDate;
			parameters[10].Value = model.n_ID;
			parameters[11].Value = model.n_MasterID;
			parameters[12].Value = model.n_ProcessNameID;

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
			strSql.Append("delete from TCode_CaseProcessItem ");
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
		public bool Delete(int n_MasterID,int n_ProcessNameID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_CaseProcessItem ");
			strSql.Append(" where n_MasterID=@n_MasterID and n_ProcessNameID=@n_ProcessNameID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_MasterID", SqlDbType.Int,4),
					new SqlParameter("@n_ProcessNameID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_MasterID;
			parameters[1].Value = n_ProcessNameID;
			parameters[2].Value = n_ID;

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
			strSql.Append("delete from TCode_CaseProcessItem ");
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
		public IPSP.Model.TCode_CaseProcessItem GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_MasterID,n_ProcessNameID,n_PatentID,n_OrderNum,s_AutoCreate,s_AllowRepeat,n_EMinTimeValue,s_EMinTimeUnit,n_EMaxTimeValue,s_EMaxTimeUnit,s_Note,s_BaseDate from TCode_CaseProcessItem ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_CaseProcessItem model=new IPSP.Model.TCode_CaseProcessItem();
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
		public IPSP.Model.TCode_CaseProcessItem DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_CaseProcessItem model=new IPSP.Model.TCode_CaseProcessItem();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_MasterID"]!=null && row["n_MasterID"].ToString()!="")
				{
					model.n_MasterID=int.Parse(row["n_MasterID"].ToString());
				}
				if(row["n_ProcessNameID"]!=null && row["n_ProcessNameID"].ToString()!="")
				{
					model.n_ProcessNameID=int.Parse(row["n_ProcessNameID"].ToString());
				}
				if(row["n_PatentID"]!=null && row["n_PatentID"].ToString()!="")
				{
					model.n_PatentID=int.Parse(row["n_PatentID"].ToString());
				}
				if(row["n_OrderNum"]!=null && row["n_OrderNum"].ToString()!="")
				{
					model.n_OrderNum=int.Parse(row["n_OrderNum"].ToString());
				}
				if(row["s_AutoCreate"]!=null)
				{
					model.s_AutoCreate=row["s_AutoCreate"].ToString();
				}
				if(row["s_AllowRepeat"]!=null)
				{
					model.s_AllowRepeat=row["s_AllowRepeat"].ToString();
				}
				if(row["n_EMinTimeValue"]!=null && row["n_EMinTimeValue"].ToString()!="")
				{
					model.n_EMinTimeValue=decimal.Parse(row["n_EMinTimeValue"].ToString());
				}
				if(row["s_EMinTimeUnit"]!=null)
				{
					model.s_EMinTimeUnit=row["s_EMinTimeUnit"].ToString();
				}
				if(row["n_EMaxTimeValue"]!=null && row["n_EMaxTimeValue"].ToString()!="")
				{
					model.n_EMaxTimeValue=decimal.Parse(row["n_EMaxTimeValue"].ToString());
				}
				if(row["s_EMaxTimeUnit"]!=null)
				{
					model.s_EMaxTimeUnit=row["s_EMaxTimeUnit"].ToString();
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
				}
				if(row["s_BaseDate"]!=null)
				{
					model.s_BaseDate=row["s_BaseDate"].ToString();
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
			strSql.Append("select n_ID,n_MasterID,n_ProcessNameID,n_PatentID,n_OrderNum,s_AutoCreate,s_AllowRepeat,n_EMinTimeValue,s_EMinTimeUnit,n_EMaxTimeValue,s_EMaxTimeUnit,s_Note,s_BaseDate ");
			strSql.Append(" FROM TCode_CaseProcessItem ");
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
			strSql.Append(" n_ID,n_MasterID,n_ProcessNameID,n_PatentID,n_OrderNum,s_AutoCreate,s_AllowRepeat,n_EMinTimeValue,s_EMinTimeUnit,n_EMaxTimeValue,s_EMaxTimeUnit,s_Note,s_BaseDate ");
			strSql.Append(" FROM TCode_CaseProcessItem ");
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
			strSql.Append("select count(1) FROM TCode_CaseProcessItem ");
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
			strSql.Append(")AS Row, T.*  from TCode_CaseProcessItem T ");
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
			parameters[0].Value = "TCode_CaseProcessItem";
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

