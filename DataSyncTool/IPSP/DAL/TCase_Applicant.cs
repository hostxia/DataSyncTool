/**  版本信息模板在安装目录下，可自行修改。
* TCase_Applicant.cs
*
* 功 能： N/A
* 类 名： TCase_Applicant
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:23   N/A    初版
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
	/// 数据访问类:TCase_Applicant
	/// </summary>
	public partial class TCase_Applicant
	{
		public TCase_Applicant()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_CaseID", "TCase_Applicant"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCase_Applicant");
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
		public int Add(IPSP.Model.TCase_Applicant model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCase_Applicant(");
			strSql.Append("n_CaseID,s_IsDelegacy,n_Sequence,n_ApplicantID,s_Name,s_NativeName,s_OtherName,s_Phone,s_Mobile,s_Fax,s_Email,n_Country,s_State,s_City,s_Street,s_ZipCode,s_IsApplicant,s_IsAppInv,s_IsInventor,s_ForAllCountries,s_ForNonUS,s_ForUS,s_ForSpecCountries,s_EFilingApplicantType,s_ApplicantTypeContent,s_OtherAddress,s_CardNumber,s_ElecPayer,s_TrustDeedNo,s_AppSerial,n_IsReceipt)");
			strSql.Append(" values (");
			strSql.Append("@n_CaseID,@s_IsDelegacy,@n_Sequence,@n_ApplicantID,@s_Name,@s_NativeName,@s_OtherName,@s_Phone,@s_Mobile,@s_Fax,@s_Email,@n_Country,@s_State,@s_City,@s_Street,@s_ZipCode,@s_IsApplicant,@s_IsAppInv,@s_IsInventor,@s_ForAllCountries,@s_ForNonUS,@s_ForUS,@s_ForSpecCountries,@s_EFilingApplicantType,@s_ApplicantTypeContent,@s_OtherAddress,@s_CardNumber,@s_ElecPayer,@s_TrustDeedNo,@s_AppSerial,@n_IsReceipt)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_CaseID", SqlDbType.Int,4),
					new SqlParameter("@s_IsDelegacy", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@n_ApplicantID", SqlDbType.Int,4),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_State", SqlDbType.NVarChar,100),
					new SqlParameter("@s_City", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Street", SqlDbType.NVarChar,300),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IsApplicant", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsAppInv", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsInventor", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ForAllCountries", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ForNonUS", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ForUS", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ForSpecCountries", SqlDbType.NVarChar,1),
					new SqlParameter("@s_EFilingApplicantType", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ApplicantTypeContent", SqlDbType.NVarChar,100),
					new SqlParameter("@s_OtherAddress", SqlDbType.NVarChar,800),
					new SqlParameter("@s_CardNumber", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ElecPayer", SqlDbType.NVarChar,200),
					new SqlParameter("@s_TrustDeedNo", SqlDbType.NVarChar,30),
					new SqlParameter("@s_AppSerial", SqlDbType.NVarChar,100),
					new SqlParameter("@n_IsReceipt", SqlDbType.NVarChar,1)};
			parameters[0].Value = model.n_CaseID;
			parameters[1].Value = model.s_IsDelegacy;
			parameters[2].Value = model.n_Sequence;
			parameters[3].Value = model.n_ApplicantID;
			parameters[4].Value = model.s_Name;
			parameters[5].Value = model.s_NativeName;
			parameters[6].Value = model.s_OtherName;
			parameters[7].Value = model.s_Phone;
			parameters[8].Value = model.s_Mobile;
			parameters[9].Value = model.s_Fax;
			parameters[10].Value = model.s_Email;
			parameters[11].Value = model.n_Country;
			parameters[12].Value = model.s_State;
			parameters[13].Value = model.s_City;
			parameters[14].Value = model.s_Street;
			parameters[15].Value = model.s_ZipCode;
			parameters[16].Value = model.s_IsApplicant;
			parameters[17].Value = model.s_IsAppInv;
			parameters[18].Value = model.s_IsInventor;
			parameters[19].Value = model.s_ForAllCountries;
			parameters[20].Value = model.s_ForNonUS;
			parameters[21].Value = model.s_ForUS;
			parameters[22].Value = model.s_ForSpecCountries;
			parameters[23].Value = model.s_EFilingApplicantType;
			parameters[24].Value = model.s_ApplicantTypeContent;
			parameters[25].Value = model.s_OtherAddress;
			parameters[26].Value = model.s_CardNumber;
			parameters[27].Value = model.s_ElecPayer;
			parameters[28].Value = model.s_TrustDeedNo;
			parameters[29].Value = model.s_AppSerial;
			parameters[30].Value = model.n_IsReceipt;

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
		public bool Update(IPSP.Model.TCase_Applicant model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCase_Applicant set ");
			strSql.Append("s_IsDelegacy=@s_IsDelegacy,");
			strSql.Append("n_Sequence=@n_Sequence,");
			strSql.Append("n_ApplicantID=@n_ApplicantID,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_NativeName=@s_NativeName,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("s_Phone=@s_Phone,");
			strSql.Append("s_Mobile=@s_Mobile,");
			strSql.Append("s_Fax=@s_Fax,");
			strSql.Append("s_Email=@s_Email,");
			strSql.Append("n_Country=@n_Country,");
			strSql.Append("s_State=@s_State,");
			strSql.Append("s_City=@s_City,");
			strSql.Append("s_Street=@s_Street,");
			strSql.Append("s_ZipCode=@s_ZipCode,");
			strSql.Append("s_IsApplicant=@s_IsApplicant,");
			strSql.Append("s_IsAppInv=@s_IsAppInv,");
			strSql.Append("s_IsInventor=@s_IsInventor,");
			strSql.Append("s_ForAllCountries=@s_ForAllCountries,");
			strSql.Append("s_ForNonUS=@s_ForNonUS,");
			strSql.Append("s_ForUS=@s_ForUS,");
			strSql.Append("s_ForSpecCountries=@s_ForSpecCountries,");
			strSql.Append("s_EFilingApplicantType=@s_EFilingApplicantType,");
			strSql.Append("s_ApplicantTypeContent=@s_ApplicantTypeContent,");
			strSql.Append("s_OtherAddress=@s_OtherAddress,");
			strSql.Append("s_CardNumber=@s_CardNumber,");
			strSql.Append("s_ElecPayer=@s_ElecPayer,");
			strSql.Append("s_TrustDeedNo=@s_TrustDeedNo,");
			strSql.Append("s_AppSerial=@s_AppSerial,");
			strSql.Append("n_IsReceipt=@n_IsReceipt");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_IsDelegacy", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@n_ApplicantID", SqlDbType.Int,4),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,300),
					new SqlParameter("@s_NativeName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_State", SqlDbType.NVarChar,100),
					new SqlParameter("@s_City", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Street", SqlDbType.NVarChar,300),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IsApplicant", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsAppInv", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsInventor", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ForAllCountries", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ForNonUS", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ForUS", SqlDbType.NVarChar,1),
					new SqlParameter("@s_ForSpecCountries", SqlDbType.NVarChar,1),
					new SqlParameter("@s_EFilingApplicantType", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ApplicantTypeContent", SqlDbType.NVarChar,100),
					new SqlParameter("@s_OtherAddress", SqlDbType.NVarChar,800),
					new SqlParameter("@s_CardNumber", SqlDbType.NVarChar,100),
					new SqlParameter("@s_ElecPayer", SqlDbType.NVarChar,200),
					new SqlParameter("@s_TrustDeedNo", SqlDbType.NVarChar,30),
					new SqlParameter("@s_AppSerial", SqlDbType.NVarChar,100),
					new SqlParameter("@n_IsReceipt", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_CaseID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_IsDelegacy;
			parameters[1].Value = model.n_Sequence;
			parameters[2].Value = model.n_ApplicantID;
			parameters[3].Value = model.s_Name;
			parameters[4].Value = model.s_NativeName;
			parameters[5].Value = model.s_OtherName;
			parameters[6].Value = model.s_Phone;
			parameters[7].Value = model.s_Mobile;
			parameters[8].Value = model.s_Fax;
			parameters[9].Value = model.s_Email;
			parameters[10].Value = model.n_Country;
			parameters[11].Value = model.s_State;
			parameters[12].Value = model.s_City;
			parameters[13].Value = model.s_Street;
			parameters[14].Value = model.s_ZipCode;
			parameters[15].Value = model.s_IsApplicant;
			parameters[16].Value = model.s_IsAppInv;
			parameters[17].Value = model.s_IsInventor;
			parameters[18].Value = model.s_ForAllCountries;
			parameters[19].Value = model.s_ForNonUS;
			parameters[20].Value = model.s_ForUS;
			parameters[21].Value = model.s_ForSpecCountries;
			parameters[22].Value = model.s_EFilingApplicantType;
			parameters[23].Value = model.s_ApplicantTypeContent;
			parameters[24].Value = model.s_OtherAddress;
			parameters[25].Value = model.s_CardNumber;
			parameters[26].Value = model.s_ElecPayer;
			parameters[27].Value = model.s_TrustDeedNo;
			parameters[28].Value = model.s_AppSerial;
			parameters[29].Value = model.n_IsReceipt;
			parameters[30].Value = model.n_ID;
			parameters[31].Value = model.n_CaseID;

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
			strSql.Append("delete from TCase_Applicant ");
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
			strSql.Append("delete from TCase_Applicant ");
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
			strSql.Append("delete from TCase_Applicant ");
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
		public IPSP.Model.TCase_Applicant GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_CaseID,s_IsDelegacy,n_Sequence,n_ApplicantID,s_Name,s_NativeName,s_OtherName,s_Phone,s_Mobile,s_Fax,s_Email,n_Country,s_State,s_City,s_Street,s_ZipCode,s_IsApplicant,s_IsAppInv,s_IsInventor,s_ForAllCountries,s_ForNonUS,s_ForUS,s_ForSpecCountries,s_EFilingApplicantType,s_ApplicantTypeContent,s_OtherAddress,s_CardNumber,s_ElecPayer,s_TrustDeedNo,s_AppSerial,n_IsReceipt from TCase_Applicant ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCase_Applicant model=new IPSP.Model.TCase_Applicant();
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
		public IPSP.Model.TCase_Applicant DataRowToModel(DataRow row)
		{
			IPSP.Model.TCase_Applicant model=new IPSP.Model.TCase_Applicant();
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
				if(row["s_IsDelegacy"]!=null)
				{
					model.s_IsDelegacy=row["s_IsDelegacy"].ToString();
				}
				if(row["n_Sequence"]!=null && row["n_Sequence"].ToString()!="")
				{
					model.n_Sequence=int.Parse(row["n_Sequence"].ToString());
				}
				if(row["n_ApplicantID"]!=null && row["n_ApplicantID"].ToString()!="")
				{
					model.n_ApplicantID=int.Parse(row["n_ApplicantID"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_NativeName"]!=null)
				{
					model.s_NativeName=row["s_NativeName"].ToString();
				}
				if(row["s_OtherName"]!=null)
				{
					model.s_OtherName=row["s_OtherName"].ToString();
				}
				if(row["s_Phone"]!=null)
				{
					model.s_Phone=row["s_Phone"].ToString();
				}
				if(row["s_Mobile"]!=null)
				{
					model.s_Mobile=row["s_Mobile"].ToString();
				}
				if(row["s_Fax"]!=null)
				{
					model.s_Fax=row["s_Fax"].ToString();
				}
				if(row["s_Email"]!=null)
				{
					model.s_Email=row["s_Email"].ToString();
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
				if(row["s_IsApplicant"]!=null)
				{
					model.s_IsApplicant=row["s_IsApplicant"].ToString();
				}
				if(row["s_IsAppInv"]!=null)
				{
					model.s_IsAppInv=row["s_IsAppInv"].ToString();
				}
				if(row["s_IsInventor"]!=null)
				{
					model.s_IsInventor=row["s_IsInventor"].ToString();
				}
				if(row["s_ForAllCountries"]!=null)
				{
					model.s_ForAllCountries=row["s_ForAllCountries"].ToString();
				}
				if(row["s_ForNonUS"]!=null)
				{
					model.s_ForNonUS=row["s_ForNonUS"].ToString();
				}
				if(row["s_ForUS"]!=null)
				{
					model.s_ForUS=row["s_ForUS"].ToString();
				}
				if(row["s_ForSpecCountries"]!=null)
				{
					model.s_ForSpecCountries=row["s_ForSpecCountries"].ToString();
				}
				if(row["s_EFilingApplicantType"]!=null)
				{
					model.s_EFilingApplicantType=row["s_EFilingApplicantType"].ToString();
				}
				if(row["s_ApplicantTypeContent"]!=null)
				{
					model.s_ApplicantTypeContent=row["s_ApplicantTypeContent"].ToString();
				}
				if(row["s_OtherAddress"]!=null)
				{
					model.s_OtherAddress=row["s_OtherAddress"].ToString();
				}
				if(row["s_CardNumber"]!=null)
				{
					model.s_CardNumber=row["s_CardNumber"].ToString();
				}
				if(row["s_ElecPayer"]!=null)
				{
					model.s_ElecPayer=row["s_ElecPayer"].ToString();
				}
				if(row["s_TrustDeedNo"]!=null)
				{
					model.s_TrustDeedNo=row["s_TrustDeedNo"].ToString();
				}
				if(row["s_AppSerial"]!=null)
				{
					model.s_AppSerial=row["s_AppSerial"].ToString();
				}
				if(row["n_IsReceipt"]!=null)
				{
					model.n_IsReceipt=row["n_IsReceipt"].ToString();
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
			strSql.Append("select n_ID,n_CaseID,s_IsDelegacy,n_Sequence,n_ApplicantID,s_Name,s_NativeName,s_OtherName,s_Phone,s_Mobile,s_Fax,s_Email,n_Country,s_State,s_City,s_Street,s_ZipCode,s_IsApplicant,s_IsAppInv,s_IsInventor,s_ForAllCountries,s_ForNonUS,s_ForUS,s_ForSpecCountries,s_EFilingApplicantType,s_ApplicantTypeContent,s_OtherAddress,s_CardNumber,s_ElecPayer,s_TrustDeedNo,s_AppSerial,n_IsReceipt ");
			strSql.Append(" FROM TCase_Applicant ");
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
			strSql.Append(" n_ID,n_CaseID,s_IsDelegacy,n_Sequence,n_ApplicantID,s_Name,s_NativeName,s_OtherName,s_Phone,s_Mobile,s_Fax,s_Email,n_Country,s_State,s_City,s_Street,s_ZipCode,s_IsApplicant,s_IsAppInv,s_IsInventor,s_ForAllCountries,s_ForNonUS,s_ForUS,s_ForSpecCountries,s_EFilingApplicantType,s_ApplicantTypeContent,s_OtherAddress,s_CardNumber,s_ElecPayer,s_TrustDeedNo,s_AppSerial,n_IsReceipt ");
			strSql.Append(" FROM TCase_Applicant ");
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
			strSql.Append("select count(1) FROM TCase_Applicant ");
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
			strSql.Append(")AS Row, T.*  from TCase_Applicant T ");
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
			parameters[0].Value = "TCase_Applicant";
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

