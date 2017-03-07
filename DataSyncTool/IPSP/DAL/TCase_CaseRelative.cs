/**  版本信息模板在安装目录下，可自行修改。
* TCase_CaseRelative.cs
*
* 功 能： N/A
* 类 名： TCase_CaseRelative
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:28   N/A    初版
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
	/// 数据访问类:TCase_CaseRelative
	/// </summary>
	public partial class TCase_CaseRelative
	{
		public TCase_CaseRelative()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseIDA", "TCase_CaseRelative"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseIDA,int n_CaseIDB,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCase_CaseRelative");
			strSql.Append(" where n_CaseIDA=@n_CaseIDA and n_CaseIDB=@n_CaseIDB and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseIDA", SqlDbType.Int,4),
					new SqlParameter("@n_CaseIDB", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseIDA;
			parameters[1].Value = n_CaseIDB;
			parameters[2].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCase_CaseRelative model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCase_CaseRelative(");
			strSql.Append("n_CaseIDA,n_CaseIDB,s_Notes,dt_CreateDate,dt_EditDate,s_CaseRelation,s_MasterSlaveRelation,n_CodeRelativeID)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseIDA,@n_CaseIDB,@s_Notes,@dt_CreateDate,@dt_EditDate,@s_CaseRelation,@s_MasterSlaveRelation,@n_CodeRelativeID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseIDA", SqlDbType.Int,4),
					new SqlParameter("@n_CaseIDB", SqlDbType.Int,4),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_CaseRelation", SqlDbType.NVarChar,100),
					new SqlParameter("@s_MasterSlaveRelation", SqlDbType.NVarChar,100),
					new SqlParameter("@n_CodeRelativeID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_CaseIDA;
			parameters[1].Value = model.n_CaseIDB;
			parameters[2].Value = model.s_Notes;
			parameters[3].Value = model.dt_CreateDate;
			parameters[4].Value = model.dt_EditDate;
			parameters[5].Value = model.s_CaseRelation;
			parameters[6].Value = model.s_MasterSlaveRelation;
			parameters[7].Value = model.n_CodeRelativeID;

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
		public bool Update(IPSP.Model.TCase_CaseRelative model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCase_CaseRelative set ");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_CaseRelation=@s_CaseRelation,");
			strSql.Append("s_MasterSlaveRelation=@s_MasterSlaveRelation,");
			strSql.Append("n_CodeRelativeID=@n_CodeRelativeID");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,1000),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_CaseRelation", SqlDbType.NVarChar,100),
					new SqlParameter("@s_MasterSlaveRelation", SqlDbType.NVarChar,100),
					new SqlParameter("@n_CodeRelativeID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseIDA", SqlDbType.Int,4),
					new SqlParameter("@n_CaseIDB", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Notes;
			parameters[1].Value = model.dt_CreateDate;
			parameters[2].Value = model.dt_EditDate;
			parameters[3].Value = model.s_CaseRelation;
			parameters[4].Value = model.s_MasterSlaveRelation;
			parameters[5].Value = model.n_CodeRelativeID;
			parameters[6].Value = model.n_ID;
			parameters[7].Value = model.n_CaseIDA;
			parameters[8].Value = model.n_CaseIDB;

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
			strSql.Append("delete from TCase_CaseRelative ");
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
		public bool Delete(int n_CaseIDA,int n_CaseIDB,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCase_CaseRelative ");
			strSql.Append(" where n_CaseIDA=@n_CaseIDA and n_CaseIDB=@n_CaseIDB and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseIDA", SqlDbType.Int,4),
					new SqlParameter("@n_CaseIDB", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseIDA;
			parameters[1].Value = n_CaseIDB;
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
			strSql.Append("delete from TCase_CaseRelative ");
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
		public IPSP.Model.TCase_CaseRelative GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CaseIDA,n_CaseIDB,s_Notes,dt_CreateDate,dt_EditDate,s_CaseRelation,s_MasterSlaveRelation,n_CodeRelativeID from TCase_CaseRelative ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCase_CaseRelative model=new IPSP.Model.TCase_CaseRelative();
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
		public IPSP.Model.TCase_CaseRelative DataRowToModel(DataRow row)
		{
			IPSP.Model.TCase_CaseRelative model=new IPSP.Model.TCase_CaseRelative();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_CaseIDA"]!=null && row["n_CaseIDA"].ToString()!="")
				{
					model.n_CaseIDA=int.Parse(row["n_CaseIDA"].ToString());
				}
				if(row["n_CaseIDB"]!=null && row["n_CaseIDB"].ToString()!="")
				{
					model.n_CaseIDB=int.Parse(row["n_CaseIDB"].ToString());
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_CaseRelation"]!=null)
				{
					model.s_CaseRelation=row["s_CaseRelation"].ToString();
				}
				if(row["s_MasterSlaveRelation"]!=null)
				{
					model.s_MasterSlaveRelation=row["s_MasterSlaveRelation"].ToString();
				}
				if(row["n_CodeRelativeID"]!=null && row["n_CodeRelativeID"].ToString()!="")
				{
					model.n_CodeRelativeID=int.Parse(row["n_CodeRelativeID"].ToString());
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
			strSql.Append("select n_ID,n_CaseIDA,n_CaseIDB,s_Notes,dt_CreateDate,dt_EditDate,s_CaseRelation,s_MasterSlaveRelation,n_CodeRelativeID ");
			strSql.Append(" FROM TCase_CaseRelative ");
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
			strSql.Append(" n_ID,n_CaseIDA,n_CaseIDB,s_Notes,dt_CreateDate,dt_EditDate,s_CaseRelation,s_MasterSlaveRelation,n_CodeRelativeID ");
			strSql.Append(" FROM TCase_CaseRelative ");
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
			strSql.Append("select count(1) FROM TCase_CaseRelative ");
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
			strSql.Append(")AS Row, T.*  from TCase_CaseRelative T ");
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
			parameters[0].Value = "TCase_CaseRelative";
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

