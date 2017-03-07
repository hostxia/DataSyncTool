/**  版本信息模板在安装目录下，可自行修改。
* TFCode_NodeRelation.cs
*
* 功 能： N/A
* 类 名： TFCode_NodeRelation
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:47   N/A    初版
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
	/// 数据访问类:TFCode_NodeRelation
	/// </summary>
	public partial class TFCode_NodeRelation
	{
		public TFCode_NodeRelation()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID,Guid g_CodeTaskChainGuid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TFCode_NodeRelation");
			strSql.Append(" where g_ID=@g_ID and g_CodeTaskChainGuid=@g_CodeTaskChainGuid ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_CodeTaskChainGuid", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;
			parameters[1].Value = g_CodeTaskChainGuid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TFCode_NodeRelation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TFCode_NodeRelation(");
			strSql.Append("g_ID,s_Name,s_Description,g_CodeTaskChainGuid,g_FromNodeGuid,g_ToNodeGuid,s_Condition,s_Reopen)");
			strSql.Append(" values (");
			strSql.Append("@g_ID,@s_Name,@s_Description,@g_CodeTaskChainGuid,@g_FromNodeGuid,@g_ToNodeGuid,@s_Condition,@s_Reopen)");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@g_CodeTaskChainGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_FromNodeGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_ToNodeGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Condition", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_Reopen", SqlDbType.NVarChar,1)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_Description;
			parameters[3].Value = Guid.NewGuid();
			parameters[4].Value = Guid.NewGuid();
			parameters[5].Value = Guid.NewGuid();
			parameters[6].Value = model.s_Condition;
			parameters[7].Value = model.s_Reopen;

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
		public bool Update(IPSP.Model.TFCode_NodeRelation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TFCode_NodeRelation set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_Description=@s_Description,");
			strSql.Append("g_FromNodeGuid=@g_FromNodeGuid,");
			strSql.Append("g_ToNodeGuid=@g_ToNodeGuid,");
			strSql.Append("s_Condition=@s_Condition,");
			strSql.Append("s_Reopen=@s_Reopen");
			strSql.Append(" where g_ID=@g_ID and g_CodeTaskChainGuid=@g_CodeTaskChainGuid ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@g_FromNodeGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_ToNodeGuid", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_Condition", SqlDbType.NVarChar,2000),
					new SqlParameter("@s_Reopen", SqlDbType.NVarChar,1),
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_CodeTaskChainGuid", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_Description;
			parameters[2].Value = model.g_FromNodeGuid;
			parameters[3].Value = model.g_ToNodeGuid;
			parameters[4].Value = model.s_Condition;
			parameters[5].Value = model.s_Reopen;
			parameters[6].Value = model.g_ID;
			parameters[7].Value = model.g_CodeTaskChainGuid;

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
		public bool Delete(Guid g_ID,Guid g_CodeTaskChainGuid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TFCode_NodeRelation ");
			strSql.Append(" where g_ID=@g_ID and g_CodeTaskChainGuid=@g_CodeTaskChainGuid ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_CodeTaskChainGuid", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;
			parameters[1].Value = g_CodeTaskChainGuid;

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
		public IPSP.Model.TFCode_NodeRelation GetModel(Guid g_ID,Guid g_CodeTaskChainGuid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 g_ID,s_Name,s_Description,g_CodeTaskChainGuid,g_FromNodeGuid,g_ToNodeGuid,s_Condition,s_Reopen from TFCode_NodeRelation ");
			strSql.Append(" where g_ID=@g_ID and g_CodeTaskChainGuid=@g_CodeTaskChainGuid ");
			SqlParameter[] parameters = {
					new SqlParameter("@g_ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@g_CodeTaskChainGuid", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = g_ID;
			parameters[1].Value = g_CodeTaskChainGuid;

			IPSP.Model.TFCode_NodeRelation model=new IPSP.Model.TFCode_NodeRelation();
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
		public IPSP.Model.TFCode_NodeRelation DataRowToModel(DataRow row)
		{
			IPSP.Model.TFCode_NodeRelation model=new IPSP.Model.TFCode_NodeRelation();
			if (row != null)
			{
				if(row["g_ID"]!=null && row["g_ID"].ToString()!="")
				{
					model.g_ID= new Guid(row["g_ID"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_Description"]!=null)
				{
					model.s_Description=row["s_Description"].ToString();
				}
				if(row["g_CodeTaskChainGuid"]!=null && row["g_CodeTaskChainGuid"].ToString()!="")
				{
					model.g_CodeTaskChainGuid= new Guid(row["g_CodeTaskChainGuid"].ToString());
				}
				if(row["g_FromNodeGuid"]!=null && row["g_FromNodeGuid"].ToString()!="")
				{
					model.g_FromNodeGuid= new Guid(row["g_FromNodeGuid"].ToString());
				}
				if(row["g_ToNodeGuid"]!=null && row["g_ToNodeGuid"].ToString()!="")
				{
					model.g_ToNodeGuid= new Guid(row["g_ToNodeGuid"].ToString());
				}
				if(row["s_Condition"]!=null)
				{
					model.s_Condition=row["s_Condition"].ToString();
				}
				if(row["s_Reopen"]!=null)
				{
					model.s_Reopen=row["s_Reopen"].ToString();
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
			strSql.Append("select g_ID,s_Name,s_Description,g_CodeTaskChainGuid,g_FromNodeGuid,g_ToNodeGuid,s_Condition,s_Reopen ");
			strSql.Append(" FROM TFCode_NodeRelation ");
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
			strSql.Append(" g_ID,s_Name,s_Description,g_CodeTaskChainGuid,g_FromNodeGuid,g_ToNodeGuid,s_Condition,s_Reopen ");
			strSql.Append(" FROM TFCode_NodeRelation ");
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
			strSql.Append("select count(1) FROM TFCode_NodeRelation ");
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
				strSql.Append("order by T.g_CodeTaskChainGuid desc");
			}
			strSql.Append(")AS Row, T.*  from TFCode_NodeRelation T ");
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
			parameters[0].Value = "TFCode_NodeRelation";
			parameters[1].Value = "g_CodeTaskChainGuid";
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

