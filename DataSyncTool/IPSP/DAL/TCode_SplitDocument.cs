/**  版本信息模板在安装目录下，可自行修改。
* TCode_SplitDocument.cs
*
* 功 能： N/A
* 类 名： TCode_SplitDocument
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:03   N/A    初版
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
	/// 数据访问类:TCode_SplitDocument
	/// </summary>
	public partial class TCode_SplitDocument
	{
		public TCode_SplitDocument()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_TemplateID", "TCode_SplitDocument"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_TemplateID,int n_SplitID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_SplitDocument");
			strSql.Append(" where n_TemplateID=@n_TemplateID and n_SplitID=@n_SplitID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_TemplateID", SqlDbType.Int,4),
					new SqlParameter("@n_SplitID", SqlDbType.Int,4)			};
			parameters[0].Value = n_TemplateID;
			parameters[1].Value = n_SplitID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_SplitDocument model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_SplitDocument(");
			strSql.Append("s_IPType,s_Name,n_TemplateID,n_Sequence,s_Type)");
			strSql.Append(" values (");
			strSql.Append("@s_IPType,@s_Name,@n_TemplateID,@n_Sequence,@s_Type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@n_TemplateID", SqlDbType.Int,4),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.n_TemplateID;
			parameters[3].Value = model.n_Sequence;
			parameters[4].Value = model.s_Type;

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
		public bool Update(IPSP.Model.TCode_SplitDocument model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_SplitDocument set ");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("n_Sequence=@n_Sequence,");
			strSql.Append("s_Type=@s_Type");
			strSql.Append(" where n_SplitID=@n_SplitID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@n_SplitID", SqlDbType.Int,4),
					new SqlParameter("@n_TemplateID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.n_Sequence;
			parameters[3].Value = model.s_Type;
			parameters[4].Value = model.n_SplitID;
			parameters[5].Value = model.n_TemplateID;

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
		public bool Delete(int n_SplitID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_SplitDocument ");
			strSql.Append(" where n_SplitID=@n_SplitID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_SplitID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_SplitID;

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
		public bool Delete(int n_TemplateID,int n_SplitID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_SplitDocument ");
			strSql.Append(" where n_TemplateID=@n_TemplateID and n_SplitID=@n_SplitID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_TemplateID", SqlDbType.Int,4),
					new SqlParameter("@n_SplitID", SqlDbType.Int,4)			};
			parameters[0].Value = n_TemplateID;
			parameters[1].Value = n_SplitID;

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
		public bool DeleteList(string n_SplitIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_SplitDocument ");
			strSql.Append(" where n_SplitID in ("+n_SplitIDlist + ")  ");
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
		public IPSP.Model.TCode_SplitDocument GetModel(int n_SplitID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_SplitID,s_IPType,s_Name,n_TemplateID,n_Sequence,s_Type from TCode_SplitDocument ");
			strSql.Append(" where n_SplitID=@n_SplitID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_SplitID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_SplitID;

			IPSP.Model.TCode_SplitDocument model=new IPSP.Model.TCode_SplitDocument();
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
		public IPSP.Model.TCode_SplitDocument DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_SplitDocument model=new IPSP.Model.TCode_SplitDocument();
			if (row != null)
			{
				if(row["n_SplitID"]!=null && row["n_SplitID"].ToString()!="")
				{
					model.n_SplitID=int.Parse(row["n_SplitID"].ToString());
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["n_TemplateID"]!=null && row["n_TemplateID"].ToString()!="")
				{
					model.n_TemplateID=int.Parse(row["n_TemplateID"].ToString());
				}
				if(row["n_Sequence"]!=null && row["n_Sequence"].ToString()!="")
				{
					model.n_Sequence=int.Parse(row["n_Sequence"].ToString());
				}
				if(row["s_Type"]!=null)
				{
					model.s_Type=row["s_Type"].ToString();
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
			strSql.Append("select n_SplitID,s_IPType,s_Name,n_TemplateID,n_Sequence,s_Type ");
			strSql.Append(" FROM TCode_SplitDocument ");
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
			strSql.Append(" n_SplitID,s_IPType,s_Name,n_TemplateID,n_Sequence,s_Type ");
			strSql.Append(" FROM TCode_SplitDocument ");
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
			strSql.Append("select count(1) FROM TCode_SplitDocument ");
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
				strSql.Append("order by T.n_SplitID desc");
			}
			strSql.Append(")AS Row, T.*  from TCode_SplitDocument T ");
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
			parameters[0].Value = "TCode_SplitDocument";
			parameters[1].Value = "n_SplitID";
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

