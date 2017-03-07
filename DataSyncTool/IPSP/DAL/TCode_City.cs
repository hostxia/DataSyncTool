/**  版本信息模板在安装目录下，可自行修改。
* TCode_City.cs
*
* 功 能： N/A
* 类 名： TCode_City
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:02   N/A    初版
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
	/// 数据访问类:TCode_City
	/// </summary>
	public partial class TCode_City
	{
		public TCode_City()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_StateID", "TCode_City"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_StateID,int n_CityID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_City");
			strSql.Append(" where n_StateID=@n_StateID and n_CityID=@n_CityID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_StateID", SqlDbType.Int,4),
					new SqlParameter("@n_CityID", SqlDbType.Int,4)			};
			parameters[0].Value = n_StateID;
			parameters[1].Value = n_CityID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_City model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_City(");
			strSql.Append("n_StateID,s_CityName,s_OCityName,s_TelAreaCode,s_ZipCode,s_RegionCode)");
			strSql.Append(" values (");
			strSql.Append("@n_StateID,@s_CityName,@s_OCityName,@s_TelAreaCode,@s_ZipCode,@s_RegionCode)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_StateID", SqlDbType.Int,4),
					new SqlParameter("@s_CityName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_OCityName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_TelAreaCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_RegionCode", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.n_StateID;
			parameters[1].Value = model.s_CityName;
			parameters[2].Value = model.s_OCityName;
			parameters[3].Value = model.s_TelAreaCode;
			parameters[4].Value = model.s_ZipCode;
			parameters[5].Value = model.s_RegionCode;

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
		public bool Update(IPSP.Model.TCode_City model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_City set ");
			strSql.Append("s_CityName=@s_CityName,");
			strSql.Append("s_OCityName=@s_OCityName,");
			strSql.Append("s_TelAreaCode=@s_TelAreaCode,");
			strSql.Append("s_ZipCode=@s_ZipCode,");
			strSql.Append("s_RegionCode=@s_RegionCode");
			strSql.Append(" where n_CityID=@n_CityID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_CityName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_OCityName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_TelAreaCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_RegionCode", SqlDbType.NVarChar,100),
					new SqlParameter("@n_CityID", SqlDbType.Int,4),
					new SqlParameter("@n_StateID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_CityName;
			parameters[1].Value = model.s_OCityName;
			parameters[2].Value = model.s_TelAreaCode;
			parameters[3].Value = model.s_ZipCode;
			parameters[4].Value = model.s_RegionCode;
			parameters[5].Value = model.n_CityID;
			parameters[6].Value = model.n_StateID;

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
		public bool Delete(int n_CityID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_City ");
			strSql.Append(" where n_CityID=@n_CityID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CityID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_CityID;

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
		public bool Delete(int n_StateID,int n_CityID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_City ");
			strSql.Append(" where n_StateID=@n_StateID and n_CityID=@n_CityID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_StateID", SqlDbType.Int,4),
					new SqlParameter("@n_CityID", SqlDbType.Int,4)			};
			parameters[0].Value = n_StateID;
			parameters[1].Value = n_CityID;

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
		public bool DeleteList(string n_CityIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_City ");
			strSql.Append(" where n_CityID in ("+n_CityIDlist + ")  ");
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
		public IPSP.Model.TCode_City GetModel(int n_CityID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_CityID,n_StateID,s_CityName,s_OCityName,s_TelAreaCode,s_ZipCode,s_RegionCode from TCode_City ");
			strSql.Append(" where n_CityID=@n_CityID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CityID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_CityID;

			IPSP.Model.TCode_City model=new IPSP.Model.TCode_City();
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
		public IPSP.Model.TCode_City DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_City model=new IPSP.Model.TCode_City();
			if (row != null)
			{
				if(row["n_CityID"]!=null && row["n_CityID"].ToString()!="")
				{
					model.n_CityID=int.Parse(row["n_CityID"].ToString());
				}
				if(row["n_StateID"]!=null && row["n_StateID"].ToString()!="")
				{
					model.n_StateID=int.Parse(row["n_StateID"].ToString());
				}
				if(row["s_CityName"]!=null)
				{
					model.s_CityName=row["s_CityName"].ToString();
				}
				if(row["s_OCityName"]!=null)
				{
					model.s_OCityName=row["s_OCityName"].ToString();
				}
				if(row["s_TelAreaCode"]!=null)
				{
					model.s_TelAreaCode=row["s_TelAreaCode"].ToString();
				}
				if(row["s_ZipCode"]!=null)
				{
					model.s_ZipCode=row["s_ZipCode"].ToString();
				}
				if(row["s_RegionCode"]!=null)
				{
					model.s_RegionCode=row["s_RegionCode"].ToString();
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
			strSql.Append("select n_CityID,n_StateID,s_CityName,s_OCityName,s_TelAreaCode,s_ZipCode,s_RegionCode ");
			strSql.Append(" FROM TCode_City ");
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
			strSql.Append(" n_CityID,n_StateID,s_CityName,s_OCityName,s_TelAreaCode,s_ZipCode,s_RegionCode ");
			strSql.Append(" FROM TCode_City ");
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
			strSql.Append("select count(1) FROM TCode_City ");
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
				strSql.Append("order by T.n_CityID desc");
			}
			strSql.Append(")AS Row, T.*  from TCode_City T ");
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
			parameters[0].Value = "TCode_City";
			parameters[1].Value = "n_CityID";
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

