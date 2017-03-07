/**  版本信息模板在安装目录下，可自行修改。
* TCode_RemindInEmployee.cs
*
* 功 能： N/A
* 类 名： TCode_RemindInEmployee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:54   N/A    初版
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
	/// 数据访问类:TCode_RemindInEmployee
	/// </summary>
	public partial class TCode_RemindInEmployee
	{
		public TCode_RemindInEmployee()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_EmployeeID", "TCode_RemindInEmployee"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_EmployeeID,int n_RemindID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_RemindInEmployee");
			strSql.Append(" where n_EmployeeID=@n_EmployeeID and n_RemindID=@n_RemindID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@n_RemindID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_EmployeeID;
			parameters[1].Value = n_RemindID;
			parameters[2].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_RemindInEmployee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_RemindInEmployee(");
			strSql.Append("n_EmployeeID,n_RemindID,b_Mail,b_WeiXin)");
			strSql.Append(" values (");
			strSql.Append("@n_EmployeeID,@n_RemindID,@b_Mail,@b_WeiXin)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@n_RemindID", SqlDbType.Int,4),
					new SqlParameter("@b_Mail", SqlDbType.Bit,1),
					new SqlParameter("@b_WeiXin", SqlDbType.Bit,1)};
			parameters[0].Value = model.n_EmployeeID;
			parameters[1].Value = model.n_RemindID;
			parameters[2].Value = model.b_Mail;
			parameters[3].Value = model.b_WeiXin;

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
		public bool Update(IPSP.Model.TCode_RemindInEmployee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_RemindInEmployee set ");
			strSql.Append("b_Mail=@b_Mail,");
			strSql.Append("b_WeiXin=@b_WeiXin");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@b_Mail", SqlDbType.Bit,1),
					new SqlParameter("@b_WeiXin", SqlDbType.Bit,1),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@n_RemindID", SqlDbType.Int,4)};
			parameters[0].Value = model.b_Mail;
			parameters[1].Value = model.b_WeiXin;
			parameters[2].Value = model.n_ID;
			parameters[3].Value = model.n_EmployeeID;
			parameters[4].Value = model.n_RemindID;

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
			strSql.Append("delete from TCode_RemindInEmployee ");
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
		public bool Delete(int n_EmployeeID,int n_RemindID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_RemindInEmployee ");
			strSql.Append(" where n_EmployeeID=@n_EmployeeID and n_RemindID=@n_RemindID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@n_RemindID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_EmployeeID;
			parameters[1].Value = n_RemindID;
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
			strSql.Append("delete from TCode_RemindInEmployee ");
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
		public IPSP.Model.TCode_RemindInEmployee GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_EmployeeID,n_RemindID,b_Mail,b_WeiXin from TCode_RemindInEmployee ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_RemindInEmployee model=new IPSP.Model.TCode_RemindInEmployee();
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
		public IPSP.Model.TCode_RemindInEmployee DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_RemindInEmployee model=new IPSP.Model.TCode_RemindInEmployee();
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
				if(row["n_RemindID"]!=null && row["n_RemindID"].ToString()!="")
				{
					model.n_RemindID=int.Parse(row["n_RemindID"].ToString());
				}
				if(row["b_Mail"]!=null && row["b_Mail"].ToString()!="")
				{
					if((row["b_Mail"].ToString()=="1")||(row["b_Mail"].ToString().ToLower()=="true"))
					{
						model.b_Mail=true;
					}
					else
					{
						model.b_Mail=false;
					}
				}
				if(row["b_WeiXin"]!=null && row["b_WeiXin"].ToString()!="")
				{
					if((row["b_WeiXin"].ToString()=="1")||(row["b_WeiXin"].ToString().ToLower()=="true"))
					{
						model.b_WeiXin=true;
					}
					else
					{
						model.b_WeiXin=false;
					}
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
			strSql.Append("select n_ID,n_EmployeeID,n_RemindID,b_Mail,b_WeiXin ");
			strSql.Append(" FROM TCode_RemindInEmployee ");
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
			strSql.Append(" n_ID,n_EmployeeID,n_RemindID,b_Mail,b_WeiXin ");
			strSql.Append(" FROM TCode_RemindInEmployee ");
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
			strSql.Append("select count(1) FROM TCode_RemindInEmployee ");
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
			strSql.Append(")AS Row, T.*  from TCode_RemindInEmployee T ");
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
			parameters[0].Value = "TCode_RemindInEmployee";
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

