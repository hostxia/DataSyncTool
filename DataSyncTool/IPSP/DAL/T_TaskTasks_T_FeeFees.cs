/**  版本信息模板在安装目录下，可自行修改。
* T_TaskTasks_T_FeeFees.cs
*
* 功 能： N/A
* 类 名： T_TaskTasks_T_FeeFees
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:09   N/A    初版
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
	/// 数据访问类:T_TaskTasks_T_FeeFees
	/// </summary>
	public partial class T_TaskTasks_T_FeeFees
	{
		public T_TaskTasks_T_FeeFees()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Fees", "T_TaskTasks_T_FeeFees"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Fees,int Tasks,int OID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_TaskTasks_T_FeeFees");
			strSql.Append(" where Fees=@Fees and Tasks=@Tasks and OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Fees", SqlDbType.Int,4),
					new SqlParameter("@Tasks", SqlDbType.Int,4),
					new SqlParameter("@OID", SqlDbType.Int,4)			};
			parameters[0].Value = Fees;
			parameters[1].Value = Tasks;
			parameters[2].Value = OID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_TaskTasks_T_FeeFees model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_TaskTasks_T_FeeFees(");
			strSql.Append("Fees,Tasks,OptimisticLockField)");
			strSql.Append(" values (");
			strSql.Append("@Fees,@Tasks,@OptimisticLockField)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Fees", SqlDbType.Int,4),
					new SqlParameter("@Tasks", SqlDbType.Int,4),
					new SqlParameter("@OptimisticLockField", SqlDbType.Int,4)};
			parameters[0].Value = model.Fees;
			parameters[1].Value = model.Tasks;
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
		public bool Update(IPSP.Model.T_TaskTasks_T_FeeFees model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_TaskTasks_T_FeeFees set ");
			strSql.Append("OptimisticLockField=@OptimisticLockField");
			strSql.Append(" where OID=@OID");
			SqlParameter[] parameters = {
					new SqlParameter("@OptimisticLockField", SqlDbType.Int,4),
					new SqlParameter("@Fees", SqlDbType.Int,4),
					new SqlParameter("@Tasks", SqlDbType.Int,4),
					new SqlParameter("@OID", SqlDbType.Int,4)};
			parameters[0].Value = model.OptimisticLockField;
			parameters[1].Value = model.Fees;
			parameters[2].Value = model.Tasks;
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
			strSql.Append("delete from T_TaskTasks_T_FeeFees ");
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
		public bool Delete(int Fees,int Tasks,int OID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_TaskTasks_T_FeeFees ");
			strSql.Append(" where Fees=@Fees and Tasks=@Tasks and OID=@OID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Fees", SqlDbType.Int,4),
					new SqlParameter("@Tasks", SqlDbType.Int,4),
					new SqlParameter("@OID", SqlDbType.Int,4)			};
			parameters[0].Value = Fees;
			parameters[1].Value = Tasks;
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
			strSql.Append("delete from T_TaskTasks_T_FeeFees ");
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
		public IPSP.Model.T_TaskTasks_T_FeeFees GetModel(int OID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Fees,Tasks,OID,OptimisticLockField from T_TaskTasks_T_FeeFees ");
			strSql.Append(" where OID=@OID");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.Int,4)
			};
			parameters[0].Value = OID;

			IPSP.Model.T_TaskTasks_T_FeeFees model=new IPSP.Model.T_TaskTasks_T_FeeFees();
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
		public IPSP.Model.T_TaskTasks_T_FeeFees DataRowToModel(DataRow row)
		{
			IPSP.Model.T_TaskTasks_T_FeeFees model=new IPSP.Model.T_TaskTasks_T_FeeFees();
			if (row != null)
			{
				if(row["Fees"]!=null && row["Fees"].ToString()!="")
				{
					model.Fees=int.Parse(row["Fees"].ToString());
				}
				if(row["Tasks"]!=null && row["Tasks"].ToString()!="")
				{
					model.Tasks=int.Parse(row["Tasks"].ToString());
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
			strSql.Append("select Fees,Tasks,OID,OptimisticLockField ");
			strSql.Append(" FROM T_TaskTasks_T_FeeFees ");
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
			strSql.Append(" Fees,Tasks,OID,OptimisticLockField ");
			strSql.Append(" FROM T_TaskTasks_T_FeeFees ");
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
			strSql.Append("select count(1) FROM T_TaskTasks_T_FeeFees ");
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
			strSql.Append(")AS Row, T.*  from T_TaskTasks_T_FeeFees T ");
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
			parameters[0].Value = "T_TaskTasks_T_FeeFees";
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

