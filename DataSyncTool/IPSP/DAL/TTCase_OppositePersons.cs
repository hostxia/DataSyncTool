/**  版本信息模板在安装目录下，可自行修改。
* TTCase_OppositePersons.cs
*
* 功 能： N/A
* 类 名： TTCase_OppositePersons
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:47   N/A    初版
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
	/// 数据访问类:TTCase_OppositePersons
	/// </summary>
	public partial class TTCase_OppositePersons
	{
		public TTCase_OppositePersons()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TTCase_OppositePersons"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TTCase_OppositePersons");
			strSql.Append(" where n_CaseID=@n_CaseID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TTCase_OppositePersons model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TTCase_OppositePersons(");
			strSql.Append("n_CaseID,s_Role,s_Name,s_OtherName,s_Addr,s_OtherAddr,s_ZipCode,s_Tel,s_Fax,s_Email,s_LawDeputy,s_Contact,s_IsDelegacy,n_RegCountry)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@s_Role,@s_Name,@s_OtherName,@s_Addr,@s_OtherAddr,@s_ZipCode,@s_Tel,@s_Fax,@s_Email,@s_LawDeputy,@s_Contact,@s_IsDelegacy,@n_RegCountry)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_Role", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Addr", SqlDbType.NVarChar,300),
					new SqlParameter("@s_OtherAddr", SqlDbType.NVarChar,300),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Tel", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,50),
					new SqlParameter("@s_LawDeputy", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Contact", SqlDbType.NVarChar,200),
					new SqlParameter("@s_IsDelegacy", SqlDbType.NVarChar,1),
					new SqlParameter("@n_RegCountry", SqlDbType.Int,4)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_Role;
			parameters[2].Value = model.s_Name;
			parameters[3].Value = model.s_OtherName;
			parameters[4].Value = model.s_Addr;
			parameters[5].Value = model.s_OtherAddr;
			parameters[6].Value = model.s_ZipCode;
			parameters[7].Value = model.s_Tel;
			parameters[8].Value = model.s_Fax;
			parameters[9].Value = model.s_Email;
			parameters[10].Value = model.s_LawDeputy;
			parameters[11].Value = model.s_Contact;
			parameters[12].Value = model.s_IsDelegacy;
			parameters[13].Value = model.n_RegCountry;

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
		public bool Update(IPSP.Model.TTCase_OppositePersons model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TTCase_OppositePersons set ");
			strSql.Append("s_Role=@s_Role,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("s_Addr=@s_Addr,");
			strSql.Append("s_OtherAddr=@s_OtherAddr,");
			strSql.Append("s_ZipCode=@s_ZipCode,");
			strSql.Append("s_Tel=@s_Tel,");
			strSql.Append("s_Fax=@s_Fax,");
			strSql.Append("s_Email=@s_Email,");
			strSql.Append("s_LawDeputy=@s_LawDeputy,");
			strSql.Append("s_Contact=@s_Contact,");
			strSql.Append("s_IsDelegacy=@s_IsDelegacy,");
			strSql.Append("n_RegCountry=@n_RegCountry");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Role", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Addr", SqlDbType.NVarChar,300),
					new SqlParameter("@s_OtherAddr", SqlDbType.NVarChar,300),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Tel", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,50),
					new SqlParameter("@s_LawDeputy", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Contact", SqlDbType.NVarChar,200),
					new SqlParameter("@s_IsDelegacy", SqlDbType.NVarChar,1),
					new SqlParameter("@n_RegCountry", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Role;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_OtherName;
			parameters[3].Value = model.s_Addr;
			parameters[4].Value = model.s_OtherAddr;
			parameters[5].Value = model.s_ZipCode;
			parameters[6].Value = model.s_Tel;
			parameters[7].Value = model.s_Fax;
			parameters[8].Value = model.s_Email;
			parameters[9].Value = model.s_LawDeputy;
			parameters[10].Value = model.s_Contact;
			parameters[11].Value = model.s_IsDelegacy;
			parameters[12].Value = model.n_RegCountry;
			parameters[13].Value = model.n_ID;
			parameters[14].Value = model.n_CaseID;

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
			strSql.Append("delete from TTCase_OppositePersons ");
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
		public bool Delete(int n_CaseID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TTCase_OppositePersons ");
			strSql.Append(" where n_CaseID=@n_CaseID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
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
			strSql.Append("delete from TTCase_OppositePersons ");
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
		public IPSP.Model.TTCase_OppositePersons GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CaseID,s_Role,s_Name,s_OtherName,s_Addr,s_OtherAddr,s_ZipCode,s_Tel,s_Fax,s_Email,s_LawDeputy,s_Contact,s_IsDelegacy,n_RegCountry from TTCase_OppositePersons ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TTCase_OppositePersons model=new IPSP.Model.TTCase_OppositePersons();
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
		public IPSP.Model.TTCase_OppositePersons DataRowToModel(DataRow row)
		{
			IPSP.Model.TTCase_OppositePersons model=new IPSP.Model.TTCase_OppositePersons();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["s_Role"]!=null)
				{
					model.s_Role=row["s_Role"].ToString();
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_OtherName"]!=null)
				{
					model.s_OtherName=row["s_OtherName"].ToString();
				}
				if(row["s_Addr"]!=null)
				{
					model.s_Addr=row["s_Addr"].ToString();
				}
				if(row["s_OtherAddr"]!=null)
				{
					model.s_OtherAddr=row["s_OtherAddr"].ToString();
				}
				if(row["s_ZipCode"]!=null)
				{
					model.s_ZipCode=row["s_ZipCode"].ToString();
				}
				if(row["s_Tel"]!=null)
				{
					model.s_Tel=row["s_Tel"].ToString();
				}
				if(row["s_Fax"]!=null)
				{
					model.s_Fax=row["s_Fax"].ToString();
				}
				if(row["s_Email"]!=null)
				{
					model.s_Email=row["s_Email"].ToString();
				}
				if(row["s_LawDeputy"]!=null)
				{
					model.s_LawDeputy=row["s_LawDeputy"].ToString();
				}
				if(row["s_Contact"]!=null)
				{
					model.s_Contact=row["s_Contact"].ToString();
				}
				if(row["s_IsDelegacy"]!=null)
				{
					model.s_IsDelegacy=row["s_IsDelegacy"].ToString();
				}
				if(row["n_RegCountry"]!=null && row["n_RegCountry"].ToString()!="")
				{
					model.n_RegCountry=int.Parse(row["n_RegCountry"].ToString());
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
			strSql.Append("select n_ID,n_CaseID,s_Role,s_Name,s_OtherName,s_Addr,s_OtherAddr,s_ZipCode,s_Tel,s_Fax,s_Email,s_LawDeputy,s_Contact,s_IsDelegacy,n_RegCountry ");
			strSql.Append(" FROM TTCase_OppositePersons ");
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
			strSql.Append(" n_ID,n_CaseID,s_Role,s_Name,s_OtherName,s_Addr,s_OtherAddr,s_ZipCode,s_Tel,s_Fax,s_Email,s_LawDeputy,s_Contact,s_IsDelegacy,n_RegCountry ");
			strSql.Append(" FROM TTCase_OppositePersons ");
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
			strSql.Append("select count(1) FROM TTCase_OppositePersons ");
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
			strSql.Append(")AS Row, T.*  from TTCase_OppositePersons T ");
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
			parameters[0].Value = "TTCase_OppositePersons";
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

