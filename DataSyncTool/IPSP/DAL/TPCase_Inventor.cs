/**  版本信息模板在安装目录下，可自行修改。
* TPCase_Inventor.cs
*
* 功 能： N/A
* 类 名： TPCase_Inventor
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:23   N/A    初版
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
	/// 数据访问类:TPCase_Inventor
	/// </summary>
	public partial class TPCase_Inventor
	{
		public TPCase_Inventor()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TPCase_Inventor"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int Patent,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPCase_Inventor");
			strSql.Append(" where n_CaseID=@n_CaseID and Patent=@Patent and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@Patent", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = Patent;
			parameters[2].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TPCase_Inventor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPCase_Inventor(");
			strSql.Append("n_CaseID,n_Sequence,s_Name,s_NativeName,n_Country,s_Address,s_NativeAddress,s_IDCard,Patent,s_SecretName,s_OtherName,s_OtherAddr,s_Notes)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@n_Sequence,@s_Name,@s_NativeName,@n_Country,@s_Address,@s_NativeAddress,@s_IDCard,@Patent,@s_SecretName,@s_OtherName,@s_OtherAddr,@s_Notes)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,300),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_Address", SqlDbType.NVarChar,300),
					new SqlParameter("@s_NativeAddress", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IDCard", SqlDbType.NVarChar,50),
					new SqlParameter("@Patent", SqlDbType.Int,4),
					new SqlParameter("@s_SecretName", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_OtherAddr", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.n_Sequence;
			parameters[2].Value = model.s_Name;
			parameters[3].Value = model.s_NativeName;
			parameters[4].Value = model.n_Country;
			parameters[5].Value = model.s_Address;
			parameters[6].Value = model.s_NativeAddress;
			parameters[7].Value = model.s_IDCard;
			parameters[8].Value = model.Patent;
			parameters[9].Value = model.s_SecretName;
			parameters[10].Value = model.s_OtherName;
			parameters[11].Value = model.s_OtherAddr;
			parameters[12].Value = model.s_Notes;

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
		public bool Update(IPSP.Model.TPCase_Inventor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPCase_Inventor set ");
			strSql.Append("n_Sequence=@n_Sequence,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_NativeName=@s_NativeName,");
			strSql.Append("n_Country=@n_Country,");
			strSql.Append("s_Address=@s_Address,");
			strSql.Append("s_NativeAddress=@s_NativeAddress,");
			strSql.Append("s_IDCard=@s_IDCard,");
			strSql.Append("s_SecretName=@s_SecretName,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("s_OtherAddr=@s_OtherAddr,");
			strSql.Append("s_Notes=@s_Notes");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,300),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_Address", SqlDbType.NVarChar,300),
					new SqlParameter("@s_NativeAddress", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IDCard", SqlDbType.NVarChar,50),
					new SqlParameter("@s_SecretName", SqlDbType.NVarChar,1),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_OtherAddr", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,500),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@Patent", SqlDbType.Int,4)};
			parameters[0].Value = model.n_Sequence;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_NativeName;
			parameters[3].Value = model.n_Country;
			parameters[4].Value = model.s_Address;
			parameters[5].Value = model.s_NativeAddress;
			parameters[6].Value = model.s_IDCard;
			parameters[7].Value = model.s_SecretName;
			parameters[8].Value = model.s_OtherName;
			parameters[9].Value = model.s_OtherAddr;
			parameters[10].Value = model.s_Notes;
			parameters[11].Value = model.n_ID;
			parameters[12].Value = model.n_CaseID;
			parameters[13].Value = model.Patent;

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
			strSql.Append("delete from TPCase_Inventor ");
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
		public bool Delete(int n_CaseID,int Patent,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TPCase_Inventor ");
			strSql.Append(" where n_CaseID=@n_CaseID and Patent=@Patent and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@Patent", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;
			parameters[1].Value = Patent;
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
			strSql.Append("delete from TPCase_Inventor ");
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
		public IPSP.Model.TPCase_Inventor GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CaseID,n_Sequence,s_Name,s_NativeName,n_Country,s_Address,s_NativeAddress,s_IDCard,Patent,s_SecretName,s_OtherName,s_OtherAddr,s_Notes from TPCase_Inventor ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TPCase_Inventor model=new IPSP.Model.TPCase_Inventor();
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
		public IPSP.Model.TPCase_Inventor DataRowToModel(DataRow row)
		{
			IPSP.Model.TPCase_Inventor model=new IPSP.Model.TPCase_Inventor();
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
				if(row["n_Sequence"]!=null && row["n_Sequence"].ToString()!="")
				{
					model.n_Sequence=int.Parse(row["n_Sequence"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_NativeName"]!=null)
				{
					model.s_NativeName=row["s_NativeName"].ToString();
				}
				if(row["n_Country"]!=null && row["n_Country"].ToString()!="")
				{
					model.n_Country=int.Parse(row["n_Country"].ToString());
				}
				if(row["s_Address"]!=null)
				{
					model.s_Address=row["s_Address"].ToString();
				}
				if(row["s_NativeAddress"]!=null)
				{
					model.s_NativeAddress=row["s_NativeAddress"].ToString();
				}
				if(row["s_IDCard"]!=null)
				{
					model.s_IDCard=row["s_IDCard"].ToString();
				}
				if(row["Patent"]!=null && row["Patent"].ToString()!="")
				{
					model.Patent=int.Parse(row["Patent"].ToString());
				}
				if(row["s_SecretName"]!=null)
				{
					model.s_SecretName=row["s_SecretName"].ToString();
				}
				if(row["s_OtherName"]!=null)
				{
					model.s_OtherName=row["s_OtherName"].ToString();
				}
				if(row["s_OtherAddr"]!=null)
				{
					model.s_OtherAddr=row["s_OtherAddr"].ToString();
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
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
			strSql.Append("select n_ID,n_CaseID,n_Sequence,s_Name,s_NativeName,n_Country,s_Address,s_NativeAddress,s_IDCard,Patent,s_SecretName,s_OtherName,s_OtherAddr,s_Notes ");
			strSql.Append(" FROM TPCase_Inventor ");
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
			strSql.Append(" n_ID,n_CaseID,n_Sequence,s_Name,s_NativeName,n_Country,s_Address,s_NativeAddress,s_IDCard,Patent,s_SecretName,s_OtherName,s_OtherAddr,s_Notes ");
			strSql.Append(" FROM TPCase_Inventor ");
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
			strSql.Append("select count(1) FROM TPCase_Inventor ");
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
			strSql.Append(")AS Row, T.*  from TPCase_Inventor T ");
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
			parameters[0].Value = "TPCase_Inventor";
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

