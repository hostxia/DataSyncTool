/**  版本信息模板在安装目录下，可自行修改。
* T_ClaimMoney.cs
*
* 功 能： N/A
* 类 名： T_ClaimMoney
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:35   N/A    初版
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
	/// 数据访问类:T_ClaimMoney
	/// </summary>
	public partial class T_ClaimMoney
	{
		public T_ClaimMoney()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ClientID", "T_ClaimMoney"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ClientID,int n_OutFileID,int n_EmailOutFileID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_ClaimMoney");
			strSql.Append(" where n_ClientID=@n_ClientID and n_OutFileID=@n_OutFileID and n_EmailOutFileID=@n_EmailOutFileID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_OutFileID", SqlDbType.Int,4),
					new SqlParameter("@n_EmailOutFileID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = n_OutFileID;
			parameters[2].Value = n_EmailOutFileID;
			parameters[3].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_ClaimMoney model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_ClaimMoney(");
			strSql.Append("n_ClientID,n_ClaimCount,n_LetterTemplateID,n_EmailTemplateID,n_OutFileID,s_Note,s_Editor,dt_EditTime,n_EmailOutFileID)");
			strSql.Append(" values (");
			strSql.Append("@n_ClientID,@n_ClaimCount,@n_LetterTemplateID,@n_EmailTemplateID,@n_OutFileID,@s_Note,@s_Editor,@dt_EditTime,@n_EmailOutFileID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_ClaimCount", SqlDbType.Int,4),
					new SqlParameter("@n_LetterTemplateID", SqlDbType.Int,4),
					new SqlParameter("@n_EmailTemplateID", SqlDbType.Int,4),
					new SqlParameter("@n_OutFileID", SqlDbType.Int,4),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_EditTime", SqlDbType.DateTime),
					new SqlParameter("@n_EmailOutFileID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_ClientID;
			parameters[1].Value = model.n_ClaimCount;
			parameters[2].Value = model.n_LetterTemplateID;
			parameters[3].Value = model.n_EmailTemplateID;
			parameters[4].Value = model.n_OutFileID;
			parameters[5].Value = model.s_Note;
			parameters[6].Value = model.s_Editor;
			parameters[7].Value = model.dt_EditTime;
			parameters[8].Value = model.n_EmailOutFileID;

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
		public bool Update(IPSP.Model.T_ClaimMoney model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_ClaimMoney set ");
			strSql.Append("n_ClaimCount=@n_ClaimCount,");
			strSql.Append("n_LetterTemplateID=@n_LetterTemplateID,");
			strSql.Append("n_EmailTemplateID=@n_EmailTemplateID,");
			strSql.Append("s_Note=@s_Note,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("dt_EditTime=@dt_EditTime");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClaimCount", SqlDbType.Int,4),
					new SqlParameter("@n_LetterTemplateID", SqlDbType.Int,4),
					new SqlParameter("@n_EmailTemplateID", SqlDbType.Int,4),
					new SqlParameter("@s_Note", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_EditTime", SqlDbType.DateTime),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_OutFileID", SqlDbType.Int,4),
					new SqlParameter("@n_EmailOutFileID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_ClaimCount;
			parameters[1].Value = model.n_LetterTemplateID;
			parameters[2].Value = model.n_EmailTemplateID;
			parameters[3].Value = model.s_Note;
			parameters[4].Value = model.s_Editor;
			parameters[5].Value = model.dt_EditTime;
			parameters[6].Value = model.n_ID;
			parameters[7].Value = model.n_ClientID;
			parameters[8].Value = model.n_OutFileID;
			parameters[9].Value = model.n_EmailOutFileID;

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
			strSql.Append("delete from T_ClaimMoney ");
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
		public bool Delete(int n_ClientID,int n_OutFileID,int n_EmailOutFileID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_ClaimMoney ");
			strSql.Append(" where n_ClientID=@n_ClientID and n_OutFileID=@n_OutFileID and n_EmailOutFileID=@n_EmailOutFileID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ClientID", SqlDbType.Int,4),
					new SqlParameter("@n_OutFileID", SqlDbType.Int,4),
					new SqlParameter("@n_EmailOutFileID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ClientID;
			parameters[1].Value = n_OutFileID;
			parameters[2].Value = n_EmailOutFileID;
			parameters[3].Value = n_ID;

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
			strSql.Append("delete from T_ClaimMoney ");
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
		public IPSP.Model.T_ClaimMoney GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_ClientID,n_ClaimCount,n_LetterTemplateID,n_EmailTemplateID,n_OutFileID,s_Note,s_Editor,dt_EditTime,n_EmailOutFileID from T_ClaimMoney ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_ClaimMoney model=new IPSP.Model.T_ClaimMoney();
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
		public IPSP.Model.T_ClaimMoney DataRowToModel(DataRow row)
		{
			IPSP.Model.T_ClaimMoney model=new IPSP.Model.T_ClaimMoney();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_ClientID"]!=null && row["n_ClientID"].ToString()!="")
				{
					model.n_ClientID=int.Parse(row["n_ClientID"].ToString());
				}
				if(row["n_ClaimCount"]!=null && row["n_ClaimCount"].ToString()!="")
				{
					model.n_ClaimCount=int.Parse(row["n_ClaimCount"].ToString());
				}
				if(row["n_LetterTemplateID"]!=null && row["n_LetterTemplateID"].ToString()!="")
				{
					model.n_LetterTemplateID=int.Parse(row["n_LetterTemplateID"].ToString());
				}
				if(row["n_EmailTemplateID"]!=null && row["n_EmailTemplateID"].ToString()!="")
				{
					model.n_EmailTemplateID=int.Parse(row["n_EmailTemplateID"].ToString());
				}
				if(row["n_OutFileID"]!=null && row["n_OutFileID"].ToString()!="")
				{
					model.n_OutFileID=int.Parse(row["n_OutFileID"].ToString());
				}
				if(row["s_Note"]!=null)
				{
					model.s_Note=row["s_Note"].ToString();
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["dt_EditTime"]!=null && row["dt_EditTime"].ToString()!="")
				{
					model.dt_EditTime=DateTime.Parse(row["dt_EditTime"].ToString());
				}
				if(row["n_EmailOutFileID"]!=null && row["n_EmailOutFileID"].ToString()!="")
				{
					model.n_EmailOutFileID=int.Parse(row["n_EmailOutFileID"].ToString());
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
			strSql.Append("select n_ID,n_ClientID,n_ClaimCount,n_LetterTemplateID,n_EmailTemplateID,n_OutFileID,s_Note,s_Editor,dt_EditTime,n_EmailOutFileID ");
			strSql.Append(" FROM T_ClaimMoney ");
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
			strSql.Append(" n_ID,n_ClientID,n_ClaimCount,n_LetterTemplateID,n_EmailTemplateID,n_OutFileID,s_Note,s_Editor,dt_EditTime,n_EmailOutFileID ");
			strSql.Append(" FROM T_ClaimMoney ");
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
			strSql.Append("select count(1) FROM T_ClaimMoney ");
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
			strSql.Append(")AS Row, T.*  from T_ClaimMoney T ");
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
			parameters[0].Value = "T_ClaimMoney";
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

