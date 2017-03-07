/**  版本信息模板在安装目录下，可自行修改。
* TCode_Official.cs
*
* 功 能： N/A
* 类 名： TCode_Official
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:39   N/A    初版
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
	/// 数据访问类:TCode_Official
	/// </summary>
	public partial class TCode_Official
	{
		public TCode_Official()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TCode_Official"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_Official");
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
		public int Add(IPSP.Model.TCode_Official model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_Official(");
			strSql.Append("s_IPType,s_OfficialCode,s_Name,s_OtherName,n_Language,s_Phone,s_Fax,s_Email,s_Website,n_Country,s_State,s_City,s_Street,s_ZipCode,s_Notes,dt_CreateDate,dt_EditDate,s_IPRole,s_IsSystem,s_Charger,s_ChargerPhone,s_ChargerEmail)");
			strSql.Append(" values (");
			strSql.Append("@s_IPType,@s_OfficialCode,@s_Name,@s_OtherName,@n_Language,@s_Phone,@s_Fax,@s_Email,@s_Website,@n_Country,@s_State,@s_City,@s_Street,@s_ZipCode,@s_Notes,@dt_CreateDate,@dt_EditDate,@s_IPRole,@s_IsSystem,@s_Charger,@s_ChargerPhone,@s_ChargerEmail)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OfficialCode", SqlDbType.NVarChar,40),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@n_Language", SqlDbType.Int,4),
					new SqlParameter("@s_Phone", SqlDbType.VarChar,300),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Website", SqlDbType.NVarChar,300),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_State", SqlDbType.NVarChar,100),
					new SqlParameter("@s_City", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Street", SqlDbType.NVarChar,300),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IPRole", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IsSystem", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Charger", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ChargerPhone", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ChargerEmail", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_OfficialCode;
			parameters[2].Value = model.s_Name;
			parameters[3].Value = model.s_OtherName;
			parameters[4].Value = model.n_Language;
			parameters[5].Value = model.s_Phone;
			parameters[6].Value = model.s_Fax;
			parameters[7].Value = model.s_Email;
			parameters[8].Value = model.s_Website;
			parameters[9].Value = model.n_Country;
			parameters[10].Value = model.s_State;
			parameters[11].Value = model.s_City;
			parameters[12].Value = model.s_Street;
			parameters[13].Value = model.s_ZipCode;
			parameters[14].Value = model.s_Notes;
			parameters[15].Value = model.dt_CreateDate;
			parameters[16].Value = model.dt_EditDate;
			parameters[17].Value = model.s_IPRole;
			parameters[18].Value = model.s_IsSystem;
			parameters[19].Value = model.s_Charger;
			parameters[20].Value = model.s_ChargerPhone;
			parameters[21].Value = model.s_ChargerEmail;

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
		public bool Update(IPSP.Model.TCode_Official model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_Official set ");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_OfficialCode=@s_OfficialCode,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("n_Language=@n_Language,");
			strSql.Append("s_Phone=@s_Phone,");
			strSql.Append("s_Fax=@s_Fax,");
			strSql.Append("s_Email=@s_Email,");
			strSql.Append("s_Website=@s_Website,");
			strSql.Append("n_Country=@n_Country,");
			strSql.Append("s_State=@s_State,");
			strSql.Append("s_City=@s_City,");
			strSql.Append("s_Street=@s_Street,");
			strSql.Append("s_ZipCode=@s_ZipCode,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_IPRole=@s_IPRole,");
			strSql.Append("s_IsSystem=@s_IsSystem,");
			strSql.Append("s_Charger=@s_Charger,");
			strSql.Append("s_ChargerPhone=@s_ChargerPhone,");
			strSql.Append("s_ChargerEmail=@s_ChargerEmail");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OfficialCode", SqlDbType.NVarChar,40),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@n_Language", SqlDbType.Int,4),
					new SqlParameter("@s_Phone", SqlDbType.VarChar,300),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Website", SqlDbType.NVarChar,300),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_State", SqlDbType.NVarChar,100),
					new SqlParameter("@s_City", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Street", SqlDbType.NVarChar,300),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_IPRole", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IsSystem", SqlDbType.NVarChar,1),
					new SqlParameter("@s_Charger", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ChargerPhone", SqlDbType.NVarChar,50),
					new SqlParameter("@s_ChargerEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_IPType;
			parameters[1].Value = model.s_OfficialCode;
			parameters[2].Value = model.s_Name;
			parameters[3].Value = model.s_OtherName;
			parameters[4].Value = model.n_Language;
			parameters[5].Value = model.s_Phone;
			parameters[6].Value = model.s_Fax;
			parameters[7].Value = model.s_Email;
			parameters[8].Value = model.s_Website;
			parameters[9].Value = model.n_Country;
			parameters[10].Value = model.s_State;
			parameters[11].Value = model.s_City;
			parameters[12].Value = model.s_Street;
			parameters[13].Value = model.s_ZipCode;
			parameters[14].Value = model.s_Notes;
			parameters[15].Value = model.dt_CreateDate;
			parameters[16].Value = model.dt_EditDate;
			parameters[17].Value = model.s_IPRole;
			parameters[18].Value = model.s_IsSystem;
			parameters[19].Value = model.s_Charger;
			parameters[20].Value = model.s_ChargerPhone;
			parameters[21].Value = model.s_ChargerEmail;
			parameters[22].Value = model.n_ID;

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
			strSql.Append("delete from TCode_Official ");
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
			strSql.Append("delete from TCode_Official ");
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
		public IPSP.Model.TCode_Official GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_IPType,s_OfficialCode,s_Name,s_OtherName,n_Language,s_Phone,s_Fax,s_Email,s_Website,n_Country,s_State,s_City,s_Street,s_ZipCode,s_Notes,dt_CreateDate,dt_EditDate,s_IPRole,s_IsSystem,s_Charger,s_ChargerPhone,s_ChargerEmail from TCode_Official ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_Official model=new IPSP.Model.TCode_Official();
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
		public IPSP.Model.TCode_Official DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_Official model=new IPSP.Model.TCode_Official();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["s_OfficialCode"]!=null)
				{
					model.s_OfficialCode=row["s_OfficialCode"].ToString();
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_OtherName"]!=null)
				{
					model.s_OtherName=row["s_OtherName"].ToString();
				}
				if(row["n_Language"]!=null && row["n_Language"].ToString()!="")
				{
					model.n_Language=int.Parse(row["n_Language"].ToString());
				}
				if(row["s_Phone"]!=null)
				{
					model.s_Phone=row["s_Phone"].ToString();
				}
				if(row["s_Fax"]!=null)
				{
					model.s_Fax=row["s_Fax"].ToString();
				}
				if(row["s_Email"]!=null)
				{
					model.s_Email=row["s_Email"].ToString();
				}
				if(row["s_Website"]!=null)
				{
					model.s_Website=row["s_Website"].ToString();
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
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_IPRole"]!=null)
				{
					model.s_IPRole=row["s_IPRole"].ToString();
				}
				if(row["s_IsSystem"]!=null)
				{
					model.s_IsSystem=row["s_IsSystem"].ToString();
				}
				if(row["s_Charger"]!=null)
				{
					model.s_Charger=row["s_Charger"].ToString();
				}
				if(row["s_ChargerPhone"]!=null)
				{
					model.s_ChargerPhone=row["s_ChargerPhone"].ToString();
				}
				if(row["s_ChargerEmail"]!=null)
				{
					model.s_ChargerEmail=row["s_ChargerEmail"].ToString();
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
			strSql.Append("select n_ID,s_IPType,s_OfficialCode,s_Name,s_OtherName,n_Language,s_Phone,s_Fax,s_Email,s_Website,n_Country,s_State,s_City,s_Street,s_ZipCode,s_Notes,dt_CreateDate,dt_EditDate,s_IPRole,s_IsSystem,s_Charger,s_ChargerPhone,s_ChargerEmail ");
			strSql.Append(" FROM TCode_Official ");
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
			strSql.Append(" n_ID,s_IPType,s_OfficialCode,s_Name,s_OtherName,n_Language,s_Phone,s_Fax,s_Email,s_Website,n_Country,s_State,s_City,s_Street,s_ZipCode,s_Notes,dt_CreateDate,dt_EditDate,s_IPRole,s_IsSystem,s_Charger,s_ChargerPhone,s_ChargerEmail ");
			strSql.Append(" FROM TCode_Official ");
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
			strSql.Append("select count(1) FROM TCode_Official ");
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
			strSql.Append(")AS Row, T.*  from TCode_Official T ");
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
			parameters[0].Value = "TCode_Official";
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

