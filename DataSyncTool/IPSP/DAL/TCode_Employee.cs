/**  版本信息模板在安装目录下，可自行修改。
* TCode_Employee.cs
*
* 功 能： N/A
* 类 名： TCode_Employee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:21   N/A    初版
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
	/// 数据访问类:TCode_Employee
	/// </summary>
	public partial class TCode_Employee
	{
		public TCode_Employee()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_SecurityLevelID", "TCode_Employee"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_SecurityLevelID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_Employee");
			strSql.Append(" where n_SecurityLevelID=@n_SecurityLevelID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_SecurityLevelID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.TCode_Employee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_Employee(");
			strSql.Append("s_Role,s_IPType,s_Name,s_OtherName,s_InternalCode,s_CertificateNo,s_Phone,s_Mobile,s_Fax,s_Email,s_IMAddress,s_Facebook,s_Twitter,s_Notes,n_ChargeRate1,n_Currency1,n_ChargeRate2,n_Currency2,dt_CreateDate,dt_EditDate,s_UserName,s_Password,s_EmailName,s_EmailServer,s_Port,s_EmailUser,s_EmailPwd,s_Signature,n_AttorneyPer,s_DataRight,s_AllowViewDepartData,s_CanCC,s_CC,s_AllowCaseConsoleMyData,s_AllowCaseConsoleDepartmentData,s_AllowCaseConsoleAllData,n_Valid,s_Contact,dt_ModifyPassword,dt_Lock,n_SecurityLevelID,img_MainOrigImg,img_MainThumbnail,s_DefaultIPType,s_AllowCustomEmail)");
			strSql.Append(" values (");
			strSql.Append("@s_Role,@s_IPType,@s_Name,@s_OtherName,@s_InternalCode,@s_CertificateNo,@s_Phone,@s_Mobile,@s_Fax,@s_Email,@s_IMAddress,@s_Facebook,@s_Twitter,@s_Notes,@n_ChargeRate1,@n_Currency1,@n_ChargeRate2,@n_Currency2,@dt_CreateDate,@dt_EditDate,@s_UserName,@s_Password,@s_EmailName,@s_EmailServer,@s_Port,@s_EmailUser,@s_EmailPwd,@s_Signature,@n_AttorneyPer,@s_DataRight,@s_AllowViewDepartData,@s_CanCC,@s_CC,@s_AllowCaseConsoleMyData,@s_AllowCaseConsoleDepartmentData,@s_AllowCaseConsoleAllData,@n_Valid,@s_Contact,@dt_ModifyPassword,@dt_Lock,@n_SecurityLevelID,@img_MainOrigImg,@img_MainThumbnail,@s_DefaultIPType,@s_AllowCustomEmail)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Role", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_InternalCode", SqlDbType.NVarChar,4),
					new SqlParameter("@s_CertificateNo", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IMAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Facebook", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Twitter", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_ChargeRate1", SqlDbType.Decimal,9),
					new SqlParameter("@n_Currency1", SqlDbType.Int,4),
					new SqlParameter("@n_ChargeRate2", SqlDbType.Decimal,9),
					new SqlParameter("@n_Currency2", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Password", SqlDbType.NVarChar,50),
					new SqlParameter("@s_EmailName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_EmailServer", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Port", SqlDbType.NVarChar,100),
					new SqlParameter("@s_EmailUser", SqlDbType.NVarChar,100),
					new SqlParameter("@s_EmailPwd", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Signature", SqlDbType.VarBinary,-1),
					new SqlParameter("@n_AttorneyPer", SqlDbType.Decimal,9),
					new SqlParameter("@s_DataRight", SqlDbType.NVarChar,50),
					new SqlParameter("@s_AllowViewDepartData", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CanCC", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CC", SqlDbType.NVarChar,500),
					new SqlParameter("@s_AllowCaseConsoleMyData", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AllowCaseConsoleDepartmentData", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AllowCaseConsoleAllData", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Valid", SqlDbType.Bit,1),
					new SqlParameter("@s_Contact", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_ModifyPassword", SqlDbType.DateTime),
					new SqlParameter("@dt_Lock", SqlDbType.DateTime),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@img_MainOrigImg", SqlDbType.VarBinary,-1),
					new SqlParameter("@img_MainThumbnail", SqlDbType.VarBinary,-1),
					new SqlParameter("@s_DefaultIPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AllowCustomEmail", SqlDbType.NVarChar,1)};
			parameters[0].Value = model.s_Role;
			parameters[1].Value = model.s_IPType;
			parameters[2].Value = model.s_Name;
			parameters[3].Value = model.s_OtherName;
			parameters[4].Value = model.s_InternalCode;
			parameters[5].Value = model.s_CertificateNo;
			parameters[6].Value = model.s_Phone;
			parameters[7].Value = model.s_Mobile;
			parameters[8].Value = model.s_Fax;
			parameters[9].Value = model.s_Email;
			parameters[10].Value = model.s_IMAddress;
			parameters[11].Value = model.s_Facebook;
			parameters[12].Value = model.s_Twitter;
			parameters[13].Value = model.s_Notes;
			parameters[14].Value = model.n_ChargeRate1;
			parameters[15].Value = model.n_Currency1;
			parameters[16].Value = model.n_ChargeRate2;
			parameters[17].Value = model.n_Currency2;
			parameters[18].Value = model.dt_CreateDate;
			parameters[19].Value = model.dt_EditDate;
			parameters[20].Value = model.s_UserName;
			parameters[21].Value = model.s_Password;
			parameters[22].Value = model.s_EmailName;
			parameters[23].Value = model.s_EmailServer;
			parameters[24].Value = model.s_Port;
			parameters[25].Value = model.s_EmailUser;
			parameters[26].Value = model.s_EmailPwd;
			parameters[27].Value = model.s_Signature;
			parameters[28].Value = model.n_AttorneyPer;
			parameters[29].Value = model.s_DataRight;
			parameters[30].Value = model.s_AllowViewDepartData;
			parameters[31].Value = model.s_CanCC;
			parameters[32].Value = model.s_CC;
			parameters[33].Value = model.s_AllowCaseConsoleMyData;
			parameters[34].Value = model.s_AllowCaseConsoleDepartmentData;
			parameters[35].Value = model.s_AllowCaseConsoleAllData;
			parameters[36].Value = model.n_Valid;
			parameters[37].Value = model.s_Contact;
			parameters[38].Value = model.dt_ModifyPassword;
			parameters[39].Value = model.dt_Lock;
			parameters[40].Value = model.n_SecurityLevelID;
			parameters[41].Value = model.img_MainOrigImg;
			parameters[42].Value = model.img_MainThumbnail;
			parameters[43].Value = model.s_DefaultIPType;
			parameters[44].Value = model.s_AllowCustomEmail;

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
		public bool Update(IPSP.Model.TCode_Employee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_Employee set ");
			strSql.Append("s_Role=@s_Role,");
			strSql.Append("s_IPType=@s_IPType,");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("s_InternalCode=@s_InternalCode,");
			strSql.Append("s_CertificateNo=@s_CertificateNo,");
			strSql.Append("s_Phone=@s_Phone,");
			strSql.Append("s_Mobile=@s_Mobile,");
			strSql.Append("s_Fax=@s_Fax,");
			strSql.Append("s_Email=@s_Email,");
			strSql.Append("s_IMAddress=@s_IMAddress,");
			strSql.Append("s_Facebook=@s_Facebook,");
			strSql.Append("s_Twitter=@s_Twitter,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("n_ChargeRate1=@n_ChargeRate1,");
			strSql.Append("n_Currency1=@n_Currency1,");
			strSql.Append("n_ChargeRate2=@n_ChargeRate2,");
			strSql.Append("n_Currency2=@n_Currency2,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_UserName=@s_UserName,");
			strSql.Append("s_Password=@s_Password,");
			strSql.Append("s_EmailName=@s_EmailName,");
			strSql.Append("s_EmailServer=@s_EmailServer,");
			strSql.Append("s_Port=@s_Port,");
			strSql.Append("s_EmailUser=@s_EmailUser,");
			strSql.Append("s_EmailPwd=@s_EmailPwd,");
			strSql.Append("s_Signature=@s_Signature,");
			strSql.Append("n_AttorneyPer=@n_AttorneyPer,");
			strSql.Append("s_DataRight=@s_DataRight,");
			strSql.Append("s_AllowViewDepartData=@s_AllowViewDepartData,");
			strSql.Append("s_CanCC=@s_CanCC,");
			strSql.Append("s_CC=@s_CC,");
			strSql.Append("s_AllowCaseConsoleMyData=@s_AllowCaseConsoleMyData,");
			strSql.Append("s_AllowCaseConsoleDepartmentData=@s_AllowCaseConsoleDepartmentData,");
			strSql.Append("s_AllowCaseConsoleAllData=@s_AllowCaseConsoleAllData,");
			strSql.Append("n_Valid=@n_Valid,");
			strSql.Append("s_Contact=@s_Contact,");
			strSql.Append("dt_ModifyPassword=@dt_ModifyPassword,");
			strSql.Append("dt_Lock=@dt_Lock,");
			strSql.Append("img_MainOrigImg=@img_MainOrigImg,");
			strSql.Append("img_MainThumbnail=@img_MainThumbnail,");
			strSql.Append("s_DefaultIPType=@s_DefaultIPType,");
			strSql.Append("s_AllowCustomEmail=@s_AllowCustomEmail");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Role", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IPType", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_InternalCode", SqlDbType.NVarChar,4),
					new SqlParameter("@s_CertificateNo", SqlDbType.NVarChar,20),
					new SqlParameter("@s_Phone", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Mobile", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,150),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,300),
					new SqlParameter("@s_IMAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Facebook", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Twitter", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,800),
					new SqlParameter("@n_ChargeRate1", SqlDbType.Decimal,9),
					new SqlParameter("@n_Currency1", SqlDbType.Int,4),
					new SqlParameter("@n_ChargeRate2", SqlDbType.Decimal,9),
					new SqlParameter("@n_Currency2", SqlDbType.Int,4),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Password", SqlDbType.NVarChar,50),
					new SqlParameter("@s_EmailName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_EmailServer", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Port", SqlDbType.NVarChar,100),
					new SqlParameter("@s_EmailUser", SqlDbType.NVarChar,100),
					new SqlParameter("@s_EmailPwd", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Signature", SqlDbType.VarBinary,-1),
					new SqlParameter("@n_AttorneyPer", SqlDbType.Decimal,9),
					new SqlParameter("@s_DataRight", SqlDbType.NVarChar,50),
					new SqlParameter("@s_AllowViewDepartData", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CanCC", SqlDbType.NVarChar,1),
					new SqlParameter("@s_CC", SqlDbType.NVarChar,500),
					new SqlParameter("@s_AllowCaseConsoleMyData", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AllowCaseConsoleDepartmentData", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AllowCaseConsoleAllData", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Valid", SqlDbType.Bit,1),
					new SqlParameter("@s_Contact", SqlDbType.NVarChar,500),
					new SqlParameter("@dt_ModifyPassword", SqlDbType.DateTime),
					new SqlParameter("@dt_Lock", SqlDbType.DateTime),
					new SqlParameter("@img_MainOrigImg", SqlDbType.VarBinary,-1),
					new SqlParameter("@img_MainThumbnail", SqlDbType.VarBinary,-1),
					new SqlParameter("@s_DefaultIPType", SqlDbType.NVarChar,1),
					new SqlParameter("@s_AllowCustomEmail", SqlDbType.NVarChar,1),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Role;
			parameters[1].Value = model.s_IPType;
			parameters[2].Value = model.s_Name;
			parameters[3].Value = model.s_OtherName;
			parameters[4].Value = model.s_InternalCode;
			parameters[5].Value = model.s_CertificateNo;
			parameters[6].Value = model.s_Phone;
			parameters[7].Value = model.s_Mobile;
			parameters[8].Value = model.s_Fax;
			parameters[9].Value = model.s_Email;
			parameters[10].Value = model.s_IMAddress;
			parameters[11].Value = model.s_Facebook;
			parameters[12].Value = model.s_Twitter;
			parameters[13].Value = model.s_Notes;
			parameters[14].Value = model.n_ChargeRate1;
			parameters[15].Value = model.n_Currency1;
			parameters[16].Value = model.n_ChargeRate2;
			parameters[17].Value = model.n_Currency2;
			parameters[18].Value = model.dt_CreateDate;
			parameters[19].Value = model.dt_EditDate;
			parameters[20].Value = model.s_UserName;
			parameters[21].Value = model.s_Password;
			parameters[22].Value = model.s_EmailName;
			parameters[23].Value = model.s_EmailServer;
			parameters[24].Value = model.s_Port;
			parameters[25].Value = model.s_EmailUser;
			parameters[26].Value = model.s_EmailPwd;
			parameters[27].Value = model.s_Signature;
			parameters[28].Value = model.n_AttorneyPer;
			parameters[29].Value = model.s_DataRight;
			parameters[30].Value = model.s_AllowViewDepartData;
			parameters[31].Value = model.s_CanCC;
			parameters[32].Value = model.s_CC;
			parameters[33].Value = model.s_AllowCaseConsoleMyData;
			parameters[34].Value = model.s_AllowCaseConsoleDepartmentData;
			parameters[35].Value = model.s_AllowCaseConsoleAllData;
			parameters[36].Value = model.n_Valid;
			parameters[37].Value = model.s_Contact;
			parameters[38].Value = model.dt_ModifyPassword;
			parameters[39].Value = model.dt_Lock;
			parameters[40].Value = model.img_MainOrigImg;
			parameters[41].Value = model.img_MainThumbnail;
			parameters[42].Value = model.s_DefaultIPType;
			parameters[43].Value = model.s_AllowCustomEmail;
			parameters[44].Value = model.n_ID;
			parameters[45].Value = model.n_SecurityLevelID;

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
			strSql.Append("delete from TCode_Employee ");
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
		public bool Delete(int n_SecurityLevelID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TCode_Employee ");
			strSql.Append(" where n_SecurityLevelID=@n_SecurityLevelID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_SecurityLevelID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_SecurityLevelID;
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
			strSql.Append("delete from TCode_Employee ");
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
		public IPSP.Model.TCode_Employee GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_Role,s_IPType,s_Name,s_OtherName,s_InternalCode,s_CertificateNo,s_Phone,s_Mobile,s_Fax,s_Email,s_IMAddress,s_Facebook,s_Twitter,s_Notes,n_ChargeRate1,n_Currency1,n_ChargeRate2,n_Currency2,dt_CreateDate,dt_EditDate,s_UserName,s_Password,s_EmailName,s_EmailServer,s_Port,s_EmailUser,s_EmailPwd,s_Signature,n_AttorneyPer,s_DataRight,s_AllowViewDepartData,s_CanCC,s_CC,s_AllowCaseConsoleMyData,s_AllowCaseConsoleDepartmentData,s_AllowCaseConsoleAllData,n_Valid,s_Contact,dt_ModifyPassword,dt_Lock,n_SecurityLevelID,img_MainOrigImg,img_MainThumbnail,s_DefaultIPType,s_AllowCustomEmail from TCode_Employee ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_Employee model=new IPSP.Model.TCode_Employee();
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
		public IPSP.Model.TCode_Employee DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_Employee model=new IPSP.Model.TCode_Employee();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_Role"]!=null)
				{
					model.s_Role=row["s_Role"].ToString();
				}
				if(row["s_IPType"]!=null)
				{
					model.s_IPType=row["s_IPType"].ToString();
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_OtherName"]!=null)
				{
					model.s_OtherName=row["s_OtherName"].ToString();
				}
				if(row["s_InternalCode"]!=null)
				{
					model.s_InternalCode=row["s_InternalCode"].ToString();
				}
				if(row["s_CertificateNo"]!=null)
				{
					model.s_CertificateNo=row["s_CertificateNo"].ToString();
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
				if(row["s_IMAddress"]!=null)
				{
					model.s_IMAddress=row["s_IMAddress"].ToString();
				}
				if(row["s_Facebook"]!=null)
				{
					model.s_Facebook=row["s_Facebook"].ToString();
				}
				if(row["s_Twitter"]!=null)
				{
					model.s_Twitter=row["s_Twitter"].ToString();
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["n_ChargeRate1"]!=null && row["n_ChargeRate1"].ToString()!="")
				{
					model.n_ChargeRate1=decimal.Parse(row["n_ChargeRate1"].ToString());
				}
				if(row["n_Currency1"]!=null && row["n_Currency1"].ToString()!="")
				{
					model.n_Currency1=int.Parse(row["n_Currency1"].ToString());
				}
				if(row["n_ChargeRate2"]!=null && row["n_ChargeRate2"].ToString()!="")
				{
					model.n_ChargeRate2=decimal.Parse(row["n_ChargeRate2"].ToString());
				}
				if(row["n_Currency2"]!=null && row["n_Currency2"].ToString()!="")
				{
					model.n_Currency2=int.Parse(row["n_Currency2"].ToString());
				}
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_UserName"]!=null)
				{
					model.s_UserName=row["s_UserName"].ToString();
				}
				if(row["s_Password"]!=null)
				{
					model.s_Password=row["s_Password"].ToString();
				}
				if(row["s_EmailName"]!=null)
				{
					model.s_EmailName=row["s_EmailName"].ToString();
				}
				if(row["s_EmailServer"]!=null)
				{
					model.s_EmailServer=row["s_EmailServer"].ToString();
				}
				if(row["s_Port"]!=null)
				{
					model.s_Port=row["s_Port"].ToString();
				}
				if(row["s_EmailUser"]!=null)
				{
					model.s_EmailUser=row["s_EmailUser"].ToString();
				}
				if(row["s_EmailPwd"]!=null)
				{
					model.s_EmailPwd=row["s_EmailPwd"].ToString();
				}
				if(row["s_Signature"]!=null && row["s_Signature"].ToString()!="")
				{
					model.s_Signature=(byte[])row["s_Signature"];
				}
				if(row["n_AttorneyPer"]!=null && row["n_AttorneyPer"].ToString()!="")
				{
					model.n_AttorneyPer=decimal.Parse(row["n_AttorneyPer"].ToString());
				}
				if(row["s_DataRight"]!=null)
				{
					model.s_DataRight=row["s_DataRight"].ToString();
				}
				if(row["s_AllowViewDepartData"]!=null)
				{
					model.s_AllowViewDepartData=row["s_AllowViewDepartData"].ToString();
				}
				if(row["s_CanCC"]!=null)
				{
					model.s_CanCC=row["s_CanCC"].ToString();
				}
				if(row["s_CC"]!=null)
				{
					model.s_CC=row["s_CC"].ToString();
				}
				if(row["s_AllowCaseConsoleMyData"]!=null)
				{
					model.s_AllowCaseConsoleMyData=row["s_AllowCaseConsoleMyData"].ToString();
				}
				if(row["s_AllowCaseConsoleDepartmentData"]!=null)
				{
					model.s_AllowCaseConsoleDepartmentData=row["s_AllowCaseConsoleDepartmentData"].ToString();
				}
				if(row["s_AllowCaseConsoleAllData"]!=null)
				{
					model.s_AllowCaseConsoleAllData=row["s_AllowCaseConsoleAllData"].ToString();
				}
				if(row["n_Valid"]!=null && row["n_Valid"].ToString()!="")
				{
					if((row["n_Valid"].ToString()=="1")||(row["n_Valid"].ToString().ToLower()=="true"))
					{
						model.n_Valid=true;
					}
					else
					{
						model.n_Valid=false;
					}
				}
				if(row["s_Contact"]!=null)
				{
					model.s_Contact=row["s_Contact"].ToString();
				}
				if(row["dt_ModifyPassword"]!=null && row["dt_ModifyPassword"].ToString()!="")
				{
					model.dt_ModifyPassword=DateTime.Parse(row["dt_ModifyPassword"].ToString());
				}
				if(row["dt_Lock"]!=null && row["dt_Lock"].ToString()!="")
				{
					model.dt_Lock=DateTime.Parse(row["dt_Lock"].ToString());
				}
				if(row["n_SecurityLevelID"]!=null && row["n_SecurityLevelID"].ToString()!="")
				{
					model.n_SecurityLevelID=int.Parse(row["n_SecurityLevelID"].ToString());
				}
				if(row["img_MainOrigImg"]!=null && row["img_MainOrigImg"].ToString()!="")
				{
					model.img_MainOrigImg=(byte[])row["img_MainOrigImg"];
				}
				if(row["img_MainThumbnail"]!=null && row["img_MainThumbnail"].ToString()!="")
				{
					model.img_MainThumbnail=(byte[])row["img_MainThumbnail"];
				}
				if(row["s_DefaultIPType"]!=null)
				{
					model.s_DefaultIPType=row["s_DefaultIPType"].ToString();
				}
				if(row["s_AllowCustomEmail"]!=null)
				{
					model.s_AllowCustomEmail=row["s_AllowCustomEmail"].ToString();
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
			strSql.Append("select n_ID,s_Role,s_IPType,s_Name,s_OtherName,s_InternalCode,s_CertificateNo,s_Phone,s_Mobile,s_Fax,s_Email,s_IMAddress,s_Facebook,s_Twitter,s_Notes,n_ChargeRate1,n_Currency1,n_ChargeRate2,n_Currency2,dt_CreateDate,dt_EditDate,s_UserName,s_Password,s_EmailName,s_EmailServer,s_Port,s_EmailUser,s_EmailPwd,s_Signature,n_AttorneyPer,s_DataRight,s_AllowViewDepartData,s_CanCC,s_CC,s_AllowCaseConsoleMyData,s_AllowCaseConsoleDepartmentData,s_AllowCaseConsoleAllData,n_Valid,s_Contact,dt_ModifyPassword,dt_Lock,n_SecurityLevelID,img_MainOrigImg,img_MainThumbnail,s_DefaultIPType,s_AllowCustomEmail ");
			strSql.Append(" FROM TCode_Employee ");
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
			strSql.Append(" n_ID,s_Role,s_IPType,s_Name,s_OtherName,s_InternalCode,s_CertificateNo,s_Phone,s_Mobile,s_Fax,s_Email,s_IMAddress,s_Facebook,s_Twitter,s_Notes,n_ChargeRate1,n_Currency1,n_ChargeRate2,n_Currency2,dt_CreateDate,dt_EditDate,s_UserName,s_Password,s_EmailName,s_EmailServer,s_Port,s_EmailUser,s_EmailPwd,s_Signature,n_AttorneyPer,s_DataRight,s_AllowViewDepartData,s_CanCC,s_CC,s_AllowCaseConsoleMyData,s_AllowCaseConsoleDepartmentData,s_AllowCaseConsoleAllData,n_Valid,s_Contact,dt_ModifyPassword,dt_Lock,n_SecurityLevelID,img_MainOrigImg,img_MainThumbnail,s_DefaultIPType,s_AllowCustomEmail ");
			strSql.Append(" FROM TCode_Employee ");
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
			strSql.Append("select count(1) FROM TCode_Employee ");
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
			strSql.Append(")AS Row, T.*  from TCode_Employee T ");
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
			parameters[0].Value = "TCode_Employee";
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

