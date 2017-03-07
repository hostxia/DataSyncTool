/**  版本信息模板在安装目录下，可自行修改。
* TFCode_Action.cs
*
* 功 能： N/A
* 类 名： TFCode_Action
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:26   N/A    初版
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
	/// 数据访问类:TFCode_Action
	/// </summary>
	public partial class TFCode_Action
	{
		public TFCode_Action()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TFCode_Action"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TFCode_Action");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TFCode_Action model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TFCode_Action(");
			strSql.Append("s_Name,s_Type,s_FuncNameSpace,s_FuncName,s_DefaultParamIn,s_Description)");
			strSql.Append(" values (");
			strSql.Append("@s_Name,@s_Type,@s_FuncNameSpace,@s_FuncName,@s_DefaultParamIn,@s_Description)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FuncNameSpace", SqlDbType.NVarChar,500),
					new SqlParameter("@s_FuncName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_DefaultParamIn", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_Type;
			parameters[2].Value = model.s_FuncNameSpace;
			parameters[3].Value = model.s_FuncName;
			parameters[4].Value = model.s_DefaultParamIn;
			parameters[5].Value = model.s_Description;

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
		public bool Update(IPSP.Model.TFCode_Action model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TFCode_Action set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_Type=@s_Type,");
			strSql.Append("s_FuncNameSpace=@s_FuncNameSpace,");
			strSql.Append("s_FuncName=@s_FuncName,");
			strSql.Append("s_DefaultParamIn=@s_DefaultParamIn,");
			strSql.Append("s_Description=@s_Description");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@s_FuncNameSpace", SqlDbType.NVarChar,500),
					new SqlParameter("@s_FuncName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_DefaultParamIn", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_Type;
			parameters[2].Value = model.s_FuncNameSpace;
			parameters[3].Value = model.s_FuncName;
			parameters[4].Value = model.s_DefaultParamIn;
			parameters[5].Value = model.s_Description;
			parameters[6].Value = model.n_ID;

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
			strSql.Append("delete from TFCode_Action ");
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string n_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TFCode_Action ");
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
		public IPSP.Model.TFCode_Action GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_Name,s_Type,s_FuncNameSpace,s_FuncName,s_DefaultParamIn,s_Description from TFCode_Action ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TFCode_Action model=new IPSP.Model.TFCode_Action();
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
		public IPSP.Model.TFCode_Action DataRowToModel(DataRow row)
		{
			IPSP.Model.TFCode_Action model=new IPSP.Model.TFCode_Action();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_Type"]!=null)
				{
					model.s_Type=row["s_Type"].ToString();
				}
				if(row["s_FuncNameSpace"]!=null)
				{
					model.s_FuncNameSpace=row["s_FuncNameSpace"].ToString();
				}
				if(row["s_FuncName"]!=null)
				{
					model.s_FuncName=row["s_FuncName"].ToString();
				}
				if(row["s_DefaultParamIn"]!=null)
				{
					model.s_DefaultParamIn=row["s_DefaultParamIn"].ToString();
				}
				if(row["s_Description"]!=null)
				{
					model.s_Description=row["s_Description"].ToString();
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
			strSql.Append("select n_ID,s_Name,s_Type,s_FuncNameSpace,s_FuncName,s_DefaultParamIn,s_Description ");
			strSql.Append(" FROM TFCode_Action ");
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
			strSql.Append(" n_ID,s_Name,s_Type,s_FuncNameSpace,s_FuncName,s_DefaultParamIn,s_Description ");
			strSql.Append(" FROM TFCode_Action ");
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
			strSql.Append("select count(1) FROM TFCode_Action ");
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
			strSql.Append(")AS Row, T.*  from TFCode_Action T ");
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
			parameters[0].Value = "TFCode_Action";
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

