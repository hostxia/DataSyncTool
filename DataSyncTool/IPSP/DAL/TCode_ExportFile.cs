/**  版本信息模板在安装目录下，可自行修改。
* TCode_ExportFile.cs
*
* 功 能： N/A
* 类 名： TCode_ExportFile
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:22   N/A    初版
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
	/// 数据访问类:TCode_ExportFile
	/// </summary>
	public partial class TCode_ExportFile
	{
		public TCode_ExportFile()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TCode_ExportFile"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_ExportFile");
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
		public int Add(IPSP.Model.TCode_ExportFile model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_ExportFile(");
			strSql.Append("s_ByCase,s_FolderName,s_Element0,s_Description0,s_Element1,s_Description1,s_Element2,s_Description2,s_Element3,s_Description3,s_Element4,s_Description4,s_Element5,s_Description5,s_Element6,s_Description6,s_Element7,s_Description7)");
			strSql.Append(" values (");
			strSql.Append("@s_ByCase,@s_FolderName,@s_Element0,@s_Description0,@s_Element1,@s_Description1,@s_Element2,@s_Description2,@s_Element3,@s_Description3,@s_Element4,@s_Description4,@s_Element5,@s_Description5,@s_Element6,@s_Description6,@s_Element7,@s_Description7)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ByCase", SqlDbType.NVarChar,1),
					new SqlParameter("@s_FolderName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element0", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description0", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element1", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description1", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element2", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description2", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element3", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description3", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element4", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description4", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element5", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description5", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element6", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description6", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element7", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description7", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.s_ByCase;
			parameters[1].Value = model.s_FolderName;
			parameters[2].Value = model.s_Element0;
			parameters[3].Value = model.s_Description0;
			parameters[4].Value = model.s_Element1;
			parameters[5].Value = model.s_Description1;
			parameters[6].Value = model.s_Element2;
			parameters[7].Value = model.s_Description2;
			parameters[8].Value = model.s_Element3;
			parameters[9].Value = model.s_Description3;
			parameters[10].Value = model.s_Element4;
			parameters[11].Value = model.s_Description4;
			parameters[12].Value = model.s_Element5;
			parameters[13].Value = model.s_Description5;
			parameters[14].Value = model.s_Element6;
			parameters[15].Value = model.s_Description6;
			parameters[16].Value = model.s_Element7;
			parameters[17].Value = model.s_Description7;

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
		public bool Update(IPSP.Model.TCode_ExportFile model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_ExportFile set ");
			strSql.Append("s_ByCase=@s_ByCase,");
			strSql.Append("s_FolderName=@s_FolderName,");
			strSql.Append("s_Element0=@s_Element0,");
			strSql.Append("s_Description0=@s_Description0,");
			strSql.Append("s_Element1=@s_Element1,");
			strSql.Append("s_Description1=@s_Description1,");
			strSql.Append("s_Element2=@s_Element2,");
			strSql.Append("s_Description2=@s_Description2,");
			strSql.Append("s_Element3=@s_Element3,");
			strSql.Append("s_Description3=@s_Description3,");
			strSql.Append("s_Element4=@s_Element4,");
			strSql.Append("s_Description4=@s_Description4,");
			strSql.Append("s_Element5=@s_Element5,");
			strSql.Append("s_Description5=@s_Description5,");
			strSql.Append("s_Element6=@s_Element6,");
			strSql.Append("s_Description6=@s_Description6,");
			strSql.Append("s_Element7=@s_Element7,");
			strSql.Append("s_Description7=@s_Description7");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ByCase", SqlDbType.NVarChar,1),
					new SqlParameter("@s_FolderName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element0", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description0", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element1", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description1", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element2", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description2", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element3", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description3", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element4", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description4", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element5", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description5", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element6", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description6", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Element7", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Description7", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_ByCase;
			parameters[1].Value = model.s_FolderName;
			parameters[2].Value = model.s_Element0;
			parameters[3].Value = model.s_Description0;
			parameters[4].Value = model.s_Element1;
			parameters[5].Value = model.s_Description1;
			parameters[6].Value = model.s_Element2;
			parameters[7].Value = model.s_Description2;
			parameters[8].Value = model.s_Element3;
			parameters[9].Value = model.s_Description3;
			parameters[10].Value = model.s_Element4;
			parameters[11].Value = model.s_Description4;
			parameters[12].Value = model.s_Element5;
			parameters[13].Value = model.s_Description5;
			parameters[14].Value = model.s_Element6;
			parameters[15].Value = model.s_Description6;
			parameters[16].Value = model.s_Element7;
			parameters[17].Value = model.s_Description7;
			parameters[18].Value = model.n_ID;

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
			strSql.Append("delete from TCode_ExportFile ");
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
			strSql.Append("delete from TCode_ExportFile ");
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
		public IPSP.Model.TCode_ExportFile GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_ByCase,s_FolderName,s_Element0,s_Description0,s_Element1,s_Description1,s_Element2,s_Description2,s_Element3,s_Description3,s_Element4,s_Description4,s_Element5,s_Description5,s_Element6,s_Description6,s_Element7,s_Description7 from TCode_ExportFile ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_ExportFile model=new IPSP.Model.TCode_ExportFile();
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
		public IPSP.Model.TCode_ExportFile DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_ExportFile model=new IPSP.Model.TCode_ExportFile();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_ByCase"]!=null)
				{
					model.s_ByCase=row["s_ByCase"].ToString();
				}
				if(row["s_FolderName"]!=null)
				{
					model.s_FolderName=row["s_FolderName"].ToString();
				}
				if(row["s_Element0"]!=null)
				{
					model.s_Element0=row["s_Element0"].ToString();
				}
				if(row["s_Description0"]!=null)
				{
					model.s_Description0=row["s_Description0"].ToString();
				}
				if(row["s_Element1"]!=null)
				{
					model.s_Element1=row["s_Element1"].ToString();
				}
				if(row["s_Description1"]!=null)
				{
					model.s_Description1=row["s_Description1"].ToString();
				}
				if(row["s_Element2"]!=null)
				{
					model.s_Element2=row["s_Element2"].ToString();
				}
				if(row["s_Description2"]!=null)
				{
					model.s_Description2=row["s_Description2"].ToString();
				}
				if(row["s_Element3"]!=null)
				{
					model.s_Element3=row["s_Element3"].ToString();
				}
				if(row["s_Description3"]!=null)
				{
					model.s_Description3=row["s_Description3"].ToString();
				}
				if(row["s_Element4"]!=null)
				{
					model.s_Element4=row["s_Element4"].ToString();
				}
				if(row["s_Description4"]!=null)
				{
					model.s_Description4=row["s_Description4"].ToString();
				}
				if(row["s_Element5"]!=null)
				{
					model.s_Element5=row["s_Element5"].ToString();
				}
				if(row["s_Description5"]!=null)
				{
					model.s_Description5=row["s_Description5"].ToString();
				}
				if(row["s_Element6"]!=null)
				{
					model.s_Element6=row["s_Element6"].ToString();
				}
				if(row["s_Description6"]!=null)
				{
					model.s_Description6=row["s_Description6"].ToString();
				}
				if(row["s_Element7"]!=null)
				{
					model.s_Element7=row["s_Element7"].ToString();
				}
				if(row["s_Description7"]!=null)
				{
					model.s_Description7=row["s_Description7"].ToString();
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
			strSql.Append("select n_ID,s_ByCase,s_FolderName,s_Element0,s_Description0,s_Element1,s_Description1,s_Element2,s_Description2,s_Element3,s_Description3,s_Element4,s_Description4,s_Element5,s_Description5,s_Element6,s_Description6,s_Element7,s_Description7 ");
			strSql.Append(" FROM TCode_ExportFile ");
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
			strSql.Append(" n_ID,s_ByCase,s_FolderName,s_Element0,s_Description0,s_Element1,s_Description1,s_Element2,s_Description2,s_Element3,s_Description3,s_Element4,s_Description4,s_Element5,s_Description5,s_Element6,s_Description6,s_Element7,s_Description7 ");
			strSql.Append(" FROM TCode_ExportFile ");
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
			strSql.Append("select count(1) FROM TCode_ExportFile ");
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
			strSql.Append(")AS Row, T.*  from TCode_ExportFile T ");
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
			parameters[0].Value = "TCode_ExportFile";
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

