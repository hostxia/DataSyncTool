/**  版本信息模板在安装目录下，可自行修改。
* TCase_BaseCases_T_MainFilesFiles.cs
*
* 功 能： N/A
* 类 名： TCase_BaseCases_T_MainFilesFiles
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:27   N/A    初版
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
	/// 数据访问类:TCase_BaseCases_T_MainFilesFiles
	/// </summary>
	public partial class TCase_BaseCases_T_MainFilesFiles
	{
		public TCase_BaseCases_T_MainFilesFiles()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Files", "TCase_BaseCases_T_MainFilesFiles"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Files,int Cases,int OID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCase_BaseCases_T_MainFilesFiles");
			strSql.Append(" where Files=@Files and Cases=@Cases and OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Files", SqlDbType.Int,4),
					new SqlParameter("@Cases", SqlDbType.Int,4),
					new SqlParameter("@OID", SqlDbType.Int,4)			};
			parameters[0].Value = Files;
			parameters[1].Value = Cases;
			parameters[2].Value = OID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCase_BaseCases_T_MainFilesFiles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCase_BaseCases_T_MainFilesFiles(");
			strSql.Append("Files,Cases,OptimisticLockField)");
			strSql.Append(" values (");
			strSql.Append("@Files,@Cases,@OptimisticLockField)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Files", SqlDbType.Int,4),
					new SqlParameter("@Cases", SqlDbType.Int,4),
					new SqlParameter("@OptimisticLockField", SqlDbType.Int,4)};
			parameters[0].Value = model.Files;
			parameters[1].Value = model.Cases;
			parameters[2].Value = model.OptimisticLockField;

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
		public bool Update(IPSP.Model.TCase_BaseCases_T_MainFilesFiles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCase_BaseCases_T_MainFilesFiles set ");
			strSql.Append("OptimisticLockField=@OptimisticLockField");
			strSql.Append(" where OID=@OID");
			SqlParameter[] parameters = {
					new SqlParameter("@OptimisticLockField", SqlDbType.Int,4),
					new SqlParameter("@Files", SqlDbType.Int,4),
					new SqlParameter("@Cases", SqlDbType.Int,4),
					new SqlParameter("@OID", SqlDbType.Int,4)};
			parameters[0].Value = model.OptimisticLockField;
			parameters[1].Value = model.Files;
			parameters[2].Value = model.Cases;
			parameters[3].Value = model.OID;

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
		public bool Delete(int OID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCase_BaseCases_T_MainFilesFiles ");
			strSql.Append(" where OID=@OID");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.Int,4)
			};
			parameters[0].Value = OID;

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
		public bool Delete(int Files,int Cases,int OID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCase_BaseCases_T_MainFilesFiles ");
			strSql.Append(" where Files=@Files and Cases=@Cases and OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Files", SqlDbType.Int,4),
					new SqlParameter("@Cases", SqlDbType.Int,4),
					new SqlParameter("@OID", SqlDbType.Int,4)			};
			parameters[0].Value = Files;
			parameters[1].Value = Cases;
			parameters[2].Value = OID;

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
		public bool DeleteList(string OIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCase_BaseCases_T_MainFilesFiles ");
			strSql.Append(" where OID in ("+OIDlist + ")  ");
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
		public IPSP.Model.TCase_BaseCases_T_MainFilesFiles GetModel(int OID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Files,Cases,OID,OptimisticLockField from TCase_BaseCases_T_MainFilesFiles ");
			strSql.Append(" where OID=@OID");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.Int,4)
			};
			parameters[0].Value = OID;

			IPSP.Model.TCase_BaseCases_T_MainFilesFiles model=new IPSP.Model.TCase_BaseCases_T_MainFilesFiles();
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
		public IPSP.Model.TCase_BaseCases_T_MainFilesFiles DataRowToModel(DataRow row)
		{
			IPSP.Model.TCase_BaseCases_T_MainFilesFiles model=new IPSP.Model.TCase_BaseCases_T_MainFilesFiles();
			if (row != null)
			{
				if(row["Files"]!=null && row["Files"].ToString()!="")
				{
					model.Files=int.Parse(row["Files"].ToString());
				}
				if(row["Cases"]!=null && row["Cases"].ToString()!="")
				{
					model.Cases=int.Parse(row["Cases"].ToString());
				}
				if(row["OID"]!=null && row["OID"].ToString()!="")
				{
					model.OID=int.Parse(row["OID"].ToString());
				}
				if(row["OptimisticLockField"]!=null && row["OptimisticLockField"].ToString()!="")
				{
					model.OptimisticLockField=int.Parse(row["OptimisticLockField"].ToString());
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
			strSql.Append("select Files,Cases,OID,OptimisticLockField ");
			strSql.Append(" FROM TCase_BaseCases_T_MainFilesFiles ");
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
			strSql.Append(" Files,Cases,OID,OptimisticLockField ");
			strSql.Append(" FROM TCase_BaseCases_T_MainFilesFiles ");
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
			strSql.Append("select count(1) FROM TCase_BaseCases_T_MainFilesFiles ");
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
				strSql.Append("order by T.OID desc");
			}
			strSql.Append(")AS Row, T.*  from TCase_BaseCases_T_MainFilesFiles T ");
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
			parameters[0].Value = "TCase_BaseCases_T_MainFilesFiles";
			parameters[1].Value = "OID";
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

