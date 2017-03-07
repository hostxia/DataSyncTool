/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_AgencyConAddress.cs
*
* 功 能： N/A
* 类 名： TCstmr_AgencyConAddress
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:24   N/A    初版
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
	/// 数据访问类:TCstmr_AgencyConAddress
	/// </summary>
	public partial class TCstmr_AgencyConAddress
	{
		public TCstmr_AgencyConAddress()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ContactID", "TCstmr_AgencyConAddress"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ContactID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCstmr_AgencyConAddress");
			strSql.Append(" where n_ContactID=@n_ContactID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ContactID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ContactID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCstmr_AgencyConAddress model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCstmr_AgencyConAddress(");
			strSql.Append("n_ContactID,n_Country,s_State,s_City,s_Street,s_ZipCode,s_Type,s_Country,s_IsMailingAddress)");
			strSql.Append(" values (");
			strSql.Append("@n_ContactID,@n_Country,@s_State,@s_City,@s_Street,@s_ZipCode,@s_Type,@s_Country,@s_IsMailingAddress)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ContactID", SqlDbType.Int,4),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_State", SqlDbType.NVarChar,100),
					new SqlParameter("@s_City", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Street", SqlDbType.NVarChar,300),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Country", SqlDbType.NVarChar,5),
					new SqlParameter("@s_IsMailingAddress", SqlDbType.NVarChar,1)};
			parameters[0].Value = model.n_ContactID;
			parameters[1].Value = model.n_Country;
			parameters[2].Value = model.s_State;
			parameters[3].Value = model.s_City;
			parameters[4].Value = model.s_Street;
			parameters[5].Value = model.s_ZipCode;
			parameters[6].Value = model.s_Type;
			parameters[7].Value = model.s_Country;
			parameters[8].Value = model.s_IsMailingAddress;

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
		public bool Update(IPSP.Model.TCstmr_AgencyConAddress model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCstmr_AgencyConAddress set ");
			strSql.Append("n_Country=@n_Country,");
			strSql.Append("s_State=@s_State,");
			strSql.Append("s_City=@s_City,");
			strSql.Append("s_Street=@s_Street,");
			strSql.Append("s_ZipCode=@s_ZipCode,");
			strSql.Append("s_Type=@s_Type,");
			strSql.Append("s_Country=@s_Country,");
			strSql.Append("s_IsMailingAddress=@s_IsMailingAddress");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_State", SqlDbType.NVarChar,100),
					new SqlParameter("@s_City", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Street", SqlDbType.NVarChar,300),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Country", SqlDbType.NVarChar,5),
					new SqlParameter("@s_IsMailingAddress", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_ContactID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_Country;
			parameters[1].Value = model.s_State;
			parameters[2].Value = model.s_City;
			parameters[3].Value = model.s_Street;
			parameters[4].Value = model.s_ZipCode;
			parameters[5].Value = model.s_Type;
			parameters[6].Value = model.s_Country;
			parameters[7].Value = model.s_IsMailingAddress;
			parameters[8].Value = model.n_ID;
			parameters[9].Value = model.n_ContactID;

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
			strSql.Append("delete from TCstmr_AgencyConAddress ");
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
		public bool Delete(int n_ContactID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCstmr_AgencyConAddress ");
			strSql.Append(" where n_ContactID=@n_ContactID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ContactID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_ContactID;
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
			strSql.Append("delete from TCstmr_AgencyConAddress ");
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
		public IPSP.Model.TCstmr_AgencyConAddress GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_ContactID,n_Country,s_State,s_City,s_Street,s_ZipCode,s_Type,s_Country,s_IsMailingAddress from TCstmr_AgencyConAddress ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCstmr_AgencyConAddress model=new IPSP.Model.TCstmr_AgencyConAddress();
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
		public IPSP.Model.TCstmr_AgencyConAddress DataRowToModel(DataRow row)
		{
			IPSP.Model.TCstmr_AgencyConAddress model=new IPSP.Model.TCstmr_AgencyConAddress();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_ContactID"]!=null && row["n_ContactID"].ToString()!="")
				{
					model.n_ContactID=int.Parse(row["n_ContactID"].ToString());
				}
				if(row["n_Country"]!=null && row["n_Country"].ToString()!="")
				{
					model.n_Country=int.Parse(row["n_Country"].ToString());
				}
				if(row["s_State"]!=null)
				{
					model.s_State=row["s_State"].ToString();
				}
				if(row["s_City"]!=null)
				{
					model.s_City=row["s_City"].ToString();
				}
				if(row["s_Street"]!=null)
				{
					model.s_Street=row["s_Street"].ToString();
				}
				if(row["s_ZipCode"]!=null)
				{
					model.s_ZipCode=row["s_ZipCode"].ToString();
				}
				if(row["s_Type"]!=null)
				{
					model.s_Type=row["s_Type"].ToString();
				}
				if(row["s_Country"]!=null)
				{
					model.s_Country=row["s_Country"].ToString();
				}
				if(row["s_IsMailingAddress"]!=null)
				{
					model.s_IsMailingAddress=row["s_IsMailingAddress"].ToString();
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
			strSql.Append("select n_ID,n_ContactID,n_Country,s_State,s_City,s_Street,s_ZipCode,s_Type,s_Country,s_IsMailingAddress ");
			strSql.Append(" FROM TCstmr_AgencyConAddress ");
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
			strSql.Append(" n_ID,n_ContactID,n_Country,s_State,s_City,s_Street,s_ZipCode,s_Type,s_Country,s_IsMailingAddress ");
			strSql.Append(" FROM TCstmr_AgencyConAddress ");
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
			strSql.Append("select count(1) FROM TCstmr_AgencyConAddress ");
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
			strSql.Append(")AS Row, T.*  from TCstmr_AgencyConAddress T ");
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
			parameters[0].Value = "TCstmr_AgencyConAddress";
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

