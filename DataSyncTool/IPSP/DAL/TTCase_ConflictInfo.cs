/**  版本信息模板在安装目录下，可自行修改。
* TTCase_ConflictInfo.cs
*
* 功 能： N/A
* 类 名： TTCase_ConflictInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:21   N/A    初版
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
	/// 数据访问类:TTCase_ConflictInfo
	/// </summary>
	public partial class TTCase_ConflictInfo
	{
		public TTCase_ConflictInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TTCase_ConflictInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TTCase_ConflictInfo");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TTCase_ConflictInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TTCase_ConflictInfo(");
			strSql.Append("n_CaseID,s_Name,s_OtherName,s_Address,s_OtherAddress,s_ZipCode,s_Contact,s_Tel,s_Fax,s_Agent,s_Reason,s_OfficeSerial,s_OtherClass,s_NeedProof,s_CitedTMName,s_CitedTMClass,s_CitedTMRegNO)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@s_Name,@s_OtherName,@s_Address,@s_OtherAddress,@s_ZipCode,@s_Contact,@s_Tel,@s_Fax,@s_Agent,@s_Reason,@s_OfficeSerial,@s_OtherClass,@s_NeedProof,@s_CitedTMName,@s_CitedTMClass,@s_CitedTMRegNO)");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Address", SqlDbType.NVarChar,300),
					new SqlParameter("@s_OtherAddress", SqlDbType.NVarChar,300),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Contact", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Tel", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Agent", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Reason", SqlDbType.NVarChar,800),
					new SqlParameter("@s_OfficeSerial", SqlDbType.NVarChar,30),
					new SqlParameter("@s_OtherClass", SqlDbType.NVarChar,300),
					new SqlParameter("@s_NeedProof", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CitedTMName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_CitedTMClass", SqlDbType.NVarChar,200),
					new SqlParameter("@s_CitedTMRegNO", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_Name;
			parameters[2].Value = model.s_OtherName;
			parameters[3].Value = model.s_Address;
			parameters[4].Value = model.s_OtherAddress;
			parameters[5].Value = model.s_ZipCode;
			parameters[6].Value = model.s_Contact;
			parameters[7].Value = model.s_Tel;
			parameters[8].Value = model.s_Fax;
			parameters[9].Value = model.s_Agent;
			parameters[10].Value = model.s_Reason;
			parameters[11].Value = model.s_OfficeSerial;
			parameters[12].Value = model.s_OtherClass;
			parameters[13].Value = model.s_NeedProof;
			parameters[14].Value = model.s_CitedTMName;
			parameters[15].Value = model.s_CitedTMClass;
			parameters[16].Value = model.s_CitedTMRegNO;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(IPSP.Model.TTCase_ConflictInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TTCase_ConflictInfo set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("s_Address=@s_Address,");
			strSql.Append("s_OtherAddress=@s_OtherAddress,");
			strSql.Append("s_ZipCode=@s_ZipCode,");
			strSql.Append("s_Contact=@s_Contact,");
			strSql.Append("s_Tel=@s_Tel,");
			strSql.Append("s_Fax=@s_Fax,");
			strSql.Append("s_Agent=@s_Agent,");
			strSql.Append("s_Reason=@s_Reason,");
			strSql.Append("s_OfficeSerial=@s_OfficeSerial,");
			strSql.Append("s_OtherClass=@s_OtherClass,");
			strSql.Append("s_NeedProof=@s_NeedProof,");
			strSql.Append("s_CitedTMName=@s_CitedTMName,");
			strSql.Append("s_CitedTMClass=@s_CitedTMClass,");
			strSql.Append("s_CitedTMRegNO=@s_CitedTMRegNO");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Address", SqlDbType.NVarChar,300),
					new SqlParameter("@s_OtherAddress", SqlDbType.NVarChar,300),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Contact", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Tel", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Agent", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Reason", SqlDbType.NVarChar,800),
					new SqlParameter("@s_OfficeSerial", SqlDbType.NVarChar,30),
					new SqlParameter("@s_OtherClass", SqlDbType.NVarChar,300),
					new SqlParameter("@s_NeedProof", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CitedTMName", SqlDbType.NVarChar,300),
					new SqlParameter("@s_CitedTMClass", SqlDbType.NVarChar,200),
					new SqlParameter("@s_CitedTMRegNO", SqlDbType.NVarChar,100),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_OtherName;
			parameters[2].Value = model.s_Address;
			parameters[3].Value = model.s_OtherAddress;
			parameters[4].Value = model.s_ZipCode;
			parameters[5].Value = model.s_Contact;
			parameters[6].Value = model.s_Tel;
			parameters[7].Value = model.s_Fax;
			parameters[8].Value = model.s_Agent;
			parameters[9].Value = model.s_Reason;
			parameters[10].Value = model.s_OfficeSerial;
			parameters[11].Value = model.s_OtherClass;
			parameters[12].Value = model.s_NeedProof;
			parameters[13].Value = model.s_CitedTMName;
			parameters[14].Value = model.s_CitedTMClass;
			parameters[15].Value = model.s_CitedTMRegNO;
			parameters[16].Value = model.n_CaseID;

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
		public bool Delete(int n_CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TTCase_ConflictInfo ");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

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
		public bool DeleteList(string n_CaseIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TTCase_ConflictInfo ");
			strSql.Append(" where n_CaseID in ("+n_CaseIDlist + ")  ");
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
		public IPSP.Model.TTCase_ConflictInfo GetModel(int n_CaseID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_CaseID,s_Name,s_OtherName,s_Address,s_OtherAddress,s_ZipCode,s_Contact,s_Tel,s_Fax,s_Agent,s_Reason,s_OfficeSerial,s_OtherClass,s_NeedProof,s_CitedTMName,s_CitedTMClass,s_CitedTMRegNO from TTCase_ConflictInfo ");
			strSql.Append(" where n_CaseID=@n_CaseID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)			};
			parameters[0].Value = n_CaseID;

			IPSP.Model.TTCase_ConflictInfo model=new IPSP.Model.TTCase_ConflictInfo();
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
		public IPSP.Model.TTCase_ConflictInfo DataRowToModel(DataRow row)
		{
			IPSP.Model.TTCase_ConflictInfo model=new IPSP.Model.TTCase_ConflictInfo();
			if (row != null)
			{
				if(row["n_CaseID"]!=null && row["n_CaseID"].ToString()!="")
				{
					model.n_CaseID=int.Parse(row["n_CaseID"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_OtherName"]!=null)
				{
					model.s_OtherName=row["s_OtherName"].ToString();
				}
				if(row["s_Address"]!=null)
				{
					model.s_Address=row["s_Address"].ToString();
				}
				if(row["s_OtherAddress"]!=null)
				{
					model.s_OtherAddress=row["s_OtherAddress"].ToString();
				}
				if(row["s_ZipCode"]!=null)
				{
					model.s_ZipCode=row["s_ZipCode"].ToString();
				}
				if(row["s_Contact"]!=null)
				{
					model.s_Contact=row["s_Contact"].ToString();
				}
				if(row["s_Tel"]!=null)
				{
					model.s_Tel=row["s_Tel"].ToString();
				}
				if(row["s_Fax"]!=null)
				{
					model.s_Fax=row["s_Fax"].ToString();
				}
				if(row["s_Agent"]!=null)
				{
					model.s_Agent=row["s_Agent"].ToString();
				}
				if(row["s_Reason"]!=null)
				{
					model.s_Reason=row["s_Reason"].ToString();
				}
				if(row["s_OfficeSerial"]!=null)
				{
					model.s_OfficeSerial=row["s_OfficeSerial"].ToString();
				}
				if(row["s_OtherClass"]!=null)
				{
					model.s_OtherClass=row["s_OtherClass"].ToString();
				}
				if(row["s_NeedProof"]!=null)
				{
					model.s_NeedProof=row["s_NeedProof"].ToString();
				}
				if(row["s_CitedTMName"]!=null)
				{
					model.s_CitedTMName=row["s_CitedTMName"].ToString();
				}
				if(row["s_CitedTMClass"]!=null)
				{
					model.s_CitedTMClass=row["s_CitedTMClass"].ToString();
				}
				if(row["s_CitedTMRegNO"]!=null)
				{
					model.s_CitedTMRegNO=row["s_CitedTMRegNO"].ToString();
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
			strSql.Append("select n_CaseID,s_Name,s_OtherName,s_Address,s_OtherAddress,s_ZipCode,s_Contact,s_Tel,s_Fax,s_Agent,s_Reason,s_OfficeSerial,s_OtherClass,s_NeedProof,s_CitedTMName,s_CitedTMClass,s_CitedTMRegNO ");
			strSql.Append(" FROM TTCase_ConflictInfo ");
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
			strSql.Append(" n_CaseID,s_Name,s_OtherName,s_Address,s_OtherAddress,s_ZipCode,s_Contact,s_Tel,s_Fax,s_Agent,s_Reason,s_OfficeSerial,s_OtherClass,s_NeedProof,s_CitedTMName,s_CitedTMClass,s_CitedTMRegNO ");
			strSql.Append(" FROM TTCase_ConflictInfo ");
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
			strSql.Append("select count(1) FROM TTCase_ConflictInfo ");
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
				strSql.Append("order by T.n_CaseID desc");
			}
			strSql.Append(")AS Row, T.*  from TTCase_ConflictInfo T ");
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
			parameters[0].Value = "TTCase_ConflictInfo";
			parameters[1].Value = "n_CaseID";
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

