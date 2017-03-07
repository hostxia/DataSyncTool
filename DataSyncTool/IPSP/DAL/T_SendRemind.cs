/**  版本信息模板在安装目录下，可自行修改。
* T_SendRemind.cs
*
* 功 能： N/A
* 类 名： T_SendRemind
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:03   N/A    初版
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
	/// 数据访问类:T_SendRemind
	/// </summary>
	public partial class T_SendRemind
	{
		public T_SendRemind()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_EmployeeID", "T_SendRemind"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_EmployeeID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_SendRemind");
			strSql.Append(" where n_EmployeeID=@n_EmployeeID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_EmployeeID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_SendRemind model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_SendRemind(");
			strSql.Append("n_EmployeeID,s_RemindType,n_ElementID,s_SendType,b_SendFail,s_GuID,s_RemainingDays)");
			strSql.Append(" values (");
			strSql.Append("@n_EmployeeID,@s_RemindType,@n_ElementID,@s_SendType,@b_SendFail,@s_GuID,@s_RemainingDays)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@s_RemindType", SqlDbType.NVarChar,2),
					new SqlParameter("@n_ElementID", SqlDbType.Int,4),
					new SqlParameter("@s_SendType", SqlDbType.NVarChar,2),
					new SqlParameter("@b_SendFail", SqlDbType.Bit,1),
					new SqlParameter("@s_GuID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_RemainingDays", SqlDbType.NVarChar,10)};
			parameters[0].Value = model.n_EmployeeID;
			parameters[1].Value = model.s_RemindType;
			parameters[2].Value = model.n_ElementID;
			parameters[3].Value = model.s_SendType;
			parameters[4].Value = model.b_SendFail;
			parameters[5].Value = Guid.NewGuid();
			parameters[6].Value = model.s_RemainingDays;

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
		public bool Update(IPSP.Model.T_SendRemind model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_SendRemind set ");
			strSql.Append("s_RemindType=@s_RemindType,");
			strSql.Append("n_ElementID=@n_ElementID,");
			strSql.Append("s_SendType=@s_SendType,");
			strSql.Append("b_SendFail=@b_SendFail,");
			strSql.Append("s_GuID=@s_GuID,");
			strSql.Append("s_RemainingDays=@s_RemainingDays");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_RemindType", SqlDbType.NVarChar,2),
					new SqlParameter("@n_ElementID", SqlDbType.Int,4),
					new SqlParameter("@s_SendType", SqlDbType.NVarChar,2),
					new SqlParameter("@b_SendFail", SqlDbType.Bit,1),
					new SqlParameter("@s_GuID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@s_RemainingDays", SqlDbType.NVarChar,10),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_RemindType;
			parameters[1].Value = model.n_ElementID;
			parameters[2].Value = model.s_SendType;
			parameters[3].Value = model.b_SendFail;
			parameters[4].Value = model.s_GuID;
			parameters[5].Value = model.s_RemainingDays;
			parameters[6].Value = model.n_ID;
			parameters[7].Value = model.n_EmployeeID;

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
			strSql.Append("delete from T_SendRemind ");
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
		public bool Delete(int n_EmployeeID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_SendRemind ");
			strSql.Append(" where n_EmployeeID=@n_EmployeeID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_EmployeeID;
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
			strSql.Append("delete from T_SendRemind ");
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
		public IPSP.Model.T_SendRemind GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_EmployeeID,s_RemindType,n_ElementID,s_SendType,b_SendFail,s_GuID,s_RemainingDays from T_SendRemind ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_SendRemind model=new IPSP.Model.T_SendRemind();
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
		public IPSP.Model.T_SendRemind DataRowToModel(DataRow row)
		{
			IPSP.Model.T_SendRemind model=new IPSP.Model.T_SendRemind();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_EmployeeID"]!=null && row["n_EmployeeID"].ToString()!="")
				{
					model.n_EmployeeID=int.Parse(row["n_EmployeeID"].ToString());
				}
				if(row["s_RemindType"]!=null)
				{
					model.s_RemindType=row["s_RemindType"].ToString();
				}
				if(row["n_ElementID"]!=null && row["n_ElementID"].ToString()!="")
				{
					model.n_ElementID=int.Parse(row["n_ElementID"].ToString());
				}
				if(row["s_SendType"]!=null)
				{
					model.s_SendType=row["s_SendType"].ToString();
				}
				if(row["b_SendFail"]!=null && row["b_SendFail"].ToString()!="")
				{
					if((row["b_SendFail"].ToString()=="1")||(row["b_SendFail"].ToString().ToLower()=="true"))
					{
						model.b_SendFail=true;
					}
					else
					{
						model.b_SendFail=false;
					}
				}
				if(row["s_GuID"]!=null && row["s_GuID"].ToString()!="")
				{
					model.s_GuID= new Guid(row["s_GuID"].ToString());
				}
				if(row["s_RemainingDays"]!=null)
				{
					model.s_RemainingDays=row["s_RemainingDays"].ToString();
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
			strSql.Append("select n_ID,n_EmployeeID,s_RemindType,n_ElementID,s_SendType,b_SendFail,s_GuID,s_RemainingDays ");
			strSql.Append(" FROM T_SendRemind ");
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
			strSql.Append(" n_ID,n_EmployeeID,s_RemindType,n_ElementID,s_SendType,b_SendFail,s_GuID,s_RemainingDays ");
			strSql.Append(" FROM T_SendRemind ");
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
			strSql.Append("select count(1) FROM T_SendRemind ");
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
			strSql.Append(")AS Row, T.*  from T_SendRemind T ");
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
			parameters[0].Value = "T_SendRemind";
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

