/**  版本信息模板在安装目录下，可自行修改。
* TCode_AgencyInfo.cs
*
* 功 能： N/A
* 类 名： TCode_AgencyInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:44   N/A    初版
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
	/// 数据访问类:TCode_AgencyInfo
	/// </summary>
	public partial class TCode_AgencyInfo
	{
		public TCode_AgencyInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TCode_AgencyInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TCode_AgencyInfo");
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
		public int Add(IPSP.Model.TCode_AgencyInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TCode_AgencyInfo(");
			strSql.Append("s_Name,s_OtherName,s_Contact,s_OtherContact,s_Password,s_AgentCode,s_Tel,s_Fax,n_Country,s_State,s_City,s_Street,s_ZipCode,s_OtherAddress,s_Notes,s_EmailName,s_EmailServer,s_Port,s_EmailUser,s_EmailPwd,s_Signature,dt_CreateDate,dt_EditDate,n_DefaultCurr,n_DefaultLan,n_GSTAgent,n_GSTDisb,s_GSTForNativeClient,s_TmOtherName,s_ClientCodeRule,n_ClientCodeFlowNumCount,n_TaxCN,s_NationalDefense,s_UnifiedSend,s_WeekEndForeColor,s_WeekEndBackColor,s_WorkWeekEndForeColor,s_WorkWeekEndBackColor,s_CorpID,s_Secret,s_CustomizeCode,s_UseHolidayConfig,s_UseOldConsole,img_Logo,n_AnnualFeeNotificationDay)");
			strSql.Append(" values (");
			strSql.Append("@s_Name,@s_OtherName,@s_Contact,@s_OtherContact,@s_Password,@s_AgentCode,@s_Tel,@s_Fax,@n_Country,@s_State,@s_City,@s_Street,@s_ZipCode,@s_OtherAddress,@s_Notes,@s_EmailName,@s_EmailServer,@s_Port,@s_EmailUser,@s_EmailPwd,@s_Signature,@dt_CreateDate,@dt_EditDate,@n_DefaultCurr,@n_DefaultLan,@n_GSTAgent,@n_GSTDisb,@s_GSTForNativeClient,@s_TmOtherName,@s_ClientCodeRule,@n_ClientCodeFlowNumCount,@n_TaxCN,@s_NationalDefense,@s_UnifiedSend,@s_WeekEndForeColor,@s_WeekEndBackColor,@s_WorkWeekEndForeColor,@s_WorkWeekEndBackColor,@s_CorpID,@s_Secret,@s_CustomizeCode,@s_UseHolidayConfig,@s_UseOldConsole,@img_Logo,@n_AnnualFeeNotificationDay)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,600),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,400),
					new SqlParameter("@s_Contact", SqlDbType.NVarChar,400),
					new SqlParameter("@s_OtherContact", SqlDbType.NVarChar,400),
					new SqlParameter("@s_Password", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AgentCode", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Tel", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,300),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_State", SqlDbType.NVarChar,200),
					new SqlParameter("@s_City", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Street", SqlDbType.NVarChar,600),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,100),
					new SqlParameter("@s_OtherAddress", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,1600),
					new SqlParameter("@s_EmailName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_EmailServer", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Port", SqlDbType.NVarChar,100),
					new SqlParameter("@s_EmailUser", SqlDbType.NVarChar,100),
					new SqlParameter("@s_EmailPwd", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Signature", SqlDbType.VarBinary,-1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_DefaultCurr", SqlDbType.Int,4),
					new SqlParameter("@n_DefaultLan", SqlDbType.Int,4),
					new SqlParameter("@n_GSTAgent", SqlDbType.Decimal,9),
					new SqlParameter("@n_GSTDisb", SqlDbType.Decimal,9),
					new SqlParameter("@s_GSTForNativeClient", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TmOtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ClientCodeRule", SqlDbType.NVarChar,100),
					new SqlParameter("@n_ClientCodeFlowNumCount", SqlDbType.Int,4),
					new SqlParameter("@n_TaxCN", SqlDbType.Money,8),
					new SqlParameter("@s_NationalDefense", SqlDbType.NVarChar,100),
					new SqlParameter("@s_UnifiedSend", SqlDbType.NVarChar,100),
					new SqlParameter("@s_WeekEndForeColor", SqlDbType.NVarChar,20),
					new SqlParameter("@s_WeekEndBackColor", SqlDbType.NVarChar,20),
					new SqlParameter("@s_WorkWeekEndForeColor", SqlDbType.NVarChar,20),
					new SqlParameter("@s_WorkWeekEndBackColor", SqlDbType.NVarChar,20),
					new SqlParameter("@s_CorpID", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Secret", SqlDbType.NVarChar,200),
					new SqlParameter("@s_CustomizeCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_UseHolidayConfig", SqlDbType.NVarChar,1),
					new SqlParameter("@s_UseOldConsole", SqlDbType.NVarChar,1),
					new SqlParameter("@img_Logo", SqlDbType.VarBinary,-1),
					new SqlParameter("@n_AnnualFeeNotificationDay", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_OtherName;
			parameters[2].Value = model.s_Contact;
			parameters[3].Value = model.s_OtherContact;
			parameters[4].Value = model.s_Password;
			parameters[5].Value = model.s_AgentCode;
			parameters[6].Value = model.s_Tel;
			parameters[7].Value = model.s_Fax;
			parameters[8].Value = model.n_Country;
			parameters[9].Value = model.s_State;
			parameters[10].Value = model.s_City;
			parameters[11].Value = model.s_Street;
			parameters[12].Value = model.s_ZipCode;
			parameters[13].Value = model.s_OtherAddress;
			parameters[14].Value = model.s_Notes;
			parameters[15].Value = model.s_EmailName;
			parameters[16].Value = model.s_EmailServer;
			parameters[17].Value = model.s_Port;
			parameters[18].Value = model.s_EmailUser;
			parameters[19].Value = model.s_EmailPwd;
			parameters[20].Value = model.s_Signature;
			parameters[21].Value = model.dt_CreateDate;
			parameters[22].Value = model.dt_EditDate;
			parameters[23].Value = model.n_DefaultCurr;
			parameters[24].Value = model.n_DefaultLan;
			parameters[25].Value = model.n_GSTAgent;
			parameters[26].Value = model.n_GSTDisb;
			parameters[27].Value = model.s_GSTForNativeClient;
			parameters[28].Value = model.s_TmOtherName;
			parameters[29].Value = model.s_ClientCodeRule;
			parameters[30].Value = model.n_ClientCodeFlowNumCount;
			parameters[31].Value = model.n_TaxCN;
			parameters[32].Value = model.s_NationalDefense;
			parameters[33].Value = model.s_UnifiedSend;
			parameters[34].Value = model.s_WeekEndForeColor;
			parameters[35].Value = model.s_WeekEndBackColor;
			parameters[36].Value = model.s_WorkWeekEndForeColor;
			parameters[37].Value = model.s_WorkWeekEndBackColor;
			parameters[38].Value = model.s_CorpID;
			parameters[39].Value = model.s_Secret;
			parameters[40].Value = model.s_CustomizeCode;
			parameters[41].Value = model.s_UseHolidayConfig;
			parameters[42].Value = model.s_UseOldConsole;
			parameters[43].Value = model.img_Logo;
			parameters[44].Value = model.n_AnnualFeeNotificationDay;

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
		public bool Update(IPSP.Model.TCode_AgencyInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TCode_AgencyInfo set ");
			strSql.Append("s_Name=@s_Name,");
			strSql.Append("s_OtherName=@s_OtherName,");
			strSql.Append("s_Contact=@s_Contact,");
			strSql.Append("s_OtherContact=@s_OtherContact,");
			strSql.Append("s_Password=@s_Password,");
			strSql.Append("s_AgentCode=@s_AgentCode,");
			strSql.Append("s_Tel=@s_Tel,");
			strSql.Append("s_Fax=@s_Fax,");
			strSql.Append("n_Country=@n_Country,");
			strSql.Append("s_State=@s_State,");
			strSql.Append("s_City=@s_City,");
			strSql.Append("s_Street=@s_Street,");
			strSql.Append("s_ZipCode=@s_ZipCode,");
			strSql.Append("s_OtherAddress=@s_OtherAddress,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("s_EmailName=@s_EmailName,");
			strSql.Append("s_EmailServer=@s_EmailServer,");
			strSql.Append("s_Port=@s_Port,");
			strSql.Append("s_EmailUser=@s_EmailUser,");
			strSql.Append("s_EmailPwd=@s_EmailPwd,");
			strSql.Append("s_Signature=@s_Signature,");
			strSql.Append("dt_CreateDate=@dt_CreateDate,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("n_DefaultCurr=@n_DefaultCurr,");
			strSql.Append("n_DefaultLan=@n_DefaultLan,");
			strSql.Append("n_GSTAgent=@n_GSTAgent,");
			strSql.Append("n_GSTDisb=@n_GSTDisb,");
			strSql.Append("s_GSTForNativeClient=@s_GSTForNativeClient,");
			strSql.Append("s_TmOtherName=@s_TmOtherName,");
			strSql.Append("s_ClientCodeRule=@s_ClientCodeRule,");
			strSql.Append("n_ClientCodeFlowNumCount=@n_ClientCodeFlowNumCount,");
			strSql.Append("n_TaxCN=@n_TaxCN,");
			strSql.Append("s_NationalDefense=@s_NationalDefense,");
			strSql.Append("s_UnifiedSend=@s_UnifiedSend,");
			strSql.Append("s_WeekEndForeColor=@s_WeekEndForeColor,");
			strSql.Append("s_WeekEndBackColor=@s_WeekEndBackColor,");
			strSql.Append("s_WorkWeekEndForeColor=@s_WorkWeekEndForeColor,");
			strSql.Append("s_WorkWeekEndBackColor=@s_WorkWeekEndBackColor,");
			strSql.Append("s_CorpID=@s_CorpID,");
			strSql.Append("s_Secret=@s_Secret,");
			strSql.Append("s_CustomizeCode=@s_CustomizeCode,");
			strSql.Append("s_UseHolidayConfig=@s_UseHolidayConfig,");
			strSql.Append("s_UseOldConsole=@s_UseOldConsole,");
			strSql.Append("img_Logo=@img_Logo,");
			strSql.Append("n_AnnualFeeNotificationDay=@n_AnnualFeeNotificationDay");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_Name", SqlDbType.NVarChar,600),
					new SqlParameter("@s_OtherName", SqlDbType.NVarChar,400),
					new SqlParameter("@s_Contact", SqlDbType.NVarChar,400),
					new SqlParameter("@s_OtherContact", SqlDbType.NVarChar,400),
					new SqlParameter("@s_Password", SqlDbType.NVarChar,200),
					new SqlParameter("@s_AgentCode", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Tel", SqlDbType.NVarChar,300),
					new SqlParameter("@s_Fax", SqlDbType.NVarChar,300),
					new SqlParameter("@n_Country", SqlDbType.Int,4),
					new SqlParameter("@s_State", SqlDbType.NVarChar,200),
					new SqlParameter("@s_City", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Street", SqlDbType.NVarChar,600),
					new SqlParameter("@s_ZipCode", SqlDbType.NVarChar,100),
					new SqlParameter("@s_OtherAddress", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,1600),
					new SqlParameter("@s_EmailName", SqlDbType.NVarChar,100),
					new SqlParameter("@s_EmailServer", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Port", SqlDbType.NVarChar,100),
					new SqlParameter("@s_EmailUser", SqlDbType.NVarChar,100),
					new SqlParameter("@s_EmailPwd", SqlDbType.NVarChar,200),
					new SqlParameter("@s_Signature", SqlDbType.VarBinary,-1),
					new SqlParameter("@dt_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@n_DefaultCurr", SqlDbType.Int,4),
					new SqlParameter("@n_DefaultLan", SqlDbType.Int,4),
					new SqlParameter("@n_GSTAgent", SqlDbType.Decimal,9),
					new SqlParameter("@n_GSTDisb", SqlDbType.Decimal,9),
					new SqlParameter("@s_GSTForNativeClient", SqlDbType.NVarChar,1),
					new SqlParameter("@s_TmOtherName", SqlDbType.NVarChar,200),
					new SqlParameter("@s_ClientCodeRule", SqlDbType.NVarChar,100),
					new SqlParameter("@n_ClientCodeFlowNumCount", SqlDbType.Int,4),
					new SqlParameter("@n_TaxCN", SqlDbType.Money,8),
					new SqlParameter("@s_NationalDefense", SqlDbType.NVarChar,100),
					new SqlParameter("@s_UnifiedSend", SqlDbType.NVarChar,100),
					new SqlParameter("@s_WeekEndForeColor", SqlDbType.NVarChar,20),
					new SqlParameter("@s_WeekEndBackColor", SqlDbType.NVarChar,20),
					new SqlParameter("@s_WorkWeekEndForeColor", SqlDbType.NVarChar,20),
					new SqlParameter("@s_WorkWeekEndBackColor", SqlDbType.NVarChar,20),
					new SqlParameter("@s_CorpID", SqlDbType.NVarChar,50),
					new SqlParameter("@s_Secret", SqlDbType.NVarChar,200),
					new SqlParameter("@s_CustomizeCode", SqlDbType.NVarChar,50),
					new SqlParameter("@s_UseHolidayConfig", SqlDbType.NVarChar,1),
					new SqlParameter("@s_UseOldConsole", SqlDbType.NVarChar,1),
					new SqlParameter("@img_Logo", SqlDbType.VarBinary,-1),
					new SqlParameter("@n_AnnualFeeNotificationDay", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_Name;
			parameters[1].Value = model.s_OtherName;
			parameters[2].Value = model.s_Contact;
			parameters[3].Value = model.s_OtherContact;
			parameters[4].Value = model.s_Password;
			parameters[5].Value = model.s_AgentCode;
			parameters[6].Value = model.s_Tel;
			parameters[7].Value = model.s_Fax;
			parameters[8].Value = model.n_Country;
			parameters[9].Value = model.s_State;
			parameters[10].Value = model.s_City;
			parameters[11].Value = model.s_Street;
			parameters[12].Value = model.s_ZipCode;
			parameters[13].Value = model.s_OtherAddress;
			parameters[14].Value = model.s_Notes;
			parameters[15].Value = model.s_EmailName;
			parameters[16].Value = model.s_EmailServer;
			parameters[17].Value = model.s_Port;
			parameters[18].Value = model.s_EmailUser;
			parameters[19].Value = model.s_EmailPwd;
			parameters[20].Value = model.s_Signature;
			parameters[21].Value = model.dt_CreateDate;
			parameters[22].Value = model.dt_EditDate;
			parameters[23].Value = model.n_DefaultCurr;
			parameters[24].Value = model.n_DefaultLan;
			parameters[25].Value = model.n_GSTAgent;
			parameters[26].Value = model.n_GSTDisb;
			parameters[27].Value = model.s_GSTForNativeClient;
			parameters[28].Value = model.s_TmOtherName;
			parameters[29].Value = model.s_ClientCodeRule;
			parameters[30].Value = model.n_ClientCodeFlowNumCount;
			parameters[31].Value = model.n_TaxCN;
			parameters[32].Value = model.s_NationalDefense;
			parameters[33].Value = model.s_UnifiedSend;
			parameters[34].Value = model.s_WeekEndForeColor;
			parameters[35].Value = model.s_WeekEndBackColor;
			parameters[36].Value = model.s_WorkWeekEndForeColor;
			parameters[37].Value = model.s_WorkWeekEndBackColor;
			parameters[38].Value = model.s_CorpID;
			parameters[39].Value = model.s_Secret;
			parameters[40].Value = model.s_CustomizeCode;
			parameters[41].Value = model.s_UseHolidayConfig;
			parameters[42].Value = model.s_UseOldConsole;
			parameters[43].Value = model.img_Logo;
			parameters[44].Value = model.n_AnnualFeeNotificationDay;
			parameters[45].Value = model.n_ID;

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
			strSql.Append("delete from TCode_AgencyInfo ");
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
			strSql.Append("delete from TCode_AgencyInfo ");
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
		public IPSP.Model.TCode_AgencyInfo GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_Name,s_OtherName,s_Contact,s_OtherContact,s_Password,s_AgentCode,s_Tel,s_Fax,n_Country,s_State,s_City,s_Street,s_ZipCode,s_OtherAddress,s_Notes,s_EmailName,s_EmailServer,s_Port,s_EmailUser,s_EmailPwd,s_Signature,dt_CreateDate,dt_EditDate,n_DefaultCurr,n_DefaultLan,n_GSTAgent,n_GSTDisb,s_GSTForNativeClient,s_TmOtherName,s_ClientCodeRule,n_ClientCodeFlowNumCount,n_TaxCN,s_NationalDefense,s_UnifiedSend,s_WeekEndForeColor,s_WeekEndBackColor,s_WorkWeekEndForeColor,s_WorkWeekEndBackColor,s_CorpID,s_Secret,s_CustomizeCode,s_UseHolidayConfig,s_UseOldConsole,img_Logo,n_AnnualFeeNotificationDay from TCode_AgencyInfo ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TCode_AgencyInfo model=new IPSP.Model.TCode_AgencyInfo();
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
		public IPSP.Model.TCode_AgencyInfo DataRowToModel(DataRow row)
		{
			IPSP.Model.TCode_AgencyInfo model=new IPSP.Model.TCode_AgencyInfo();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_Name"]!=null)
				{
					model.s_Name=row["s_Name"].ToString();
				}
				if(row["s_OtherName"]!=null)
				{
					model.s_OtherName=row["s_OtherName"].ToString();
				}
				if(row["s_Contact"]!=null)
				{
					model.s_Contact=row["s_Contact"].ToString();
				}
				if(row["s_OtherContact"]!=null)
				{
					model.s_OtherContact=row["s_OtherContact"].ToString();
				}
				if(row["s_Password"]!=null)
				{
					model.s_Password=row["s_Password"].ToString();
				}
				if(row["s_AgentCode"]!=null)
				{
					model.s_AgentCode=row["s_AgentCode"].ToString();
				}
				if(row["s_Tel"]!=null)
				{
					model.s_Tel=row["s_Tel"].ToString();
				}
				if(row["s_Fax"]!=null)
				{
					model.s_Fax=row["s_Fax"].ToString();
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
				if(row["s_OtherAddress"]!=null)
				{
					model.s_OtherAddress=row["s_OtherAddress"].ToString();
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
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
				if(row["dt_CreateDate"]!=null && row["dt_CreateDate"].ToString()!="")
				{
					model.dt_CreateDate=DateTime.Parse(row["dt_CreateDate"].ToString());
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["n_DefaultCurr"]!=null && row["n_DefaultCurr"].ToString()!="")
				{
					model.n_DefaultCurr=int.Parse(row["n_DefaultCurr"].ToString());
				}
				if(row["n_DefaultLan"]!=null && row["n_DefaultLan"].ToString()!="")
				{
					model.n_DefaultLan=int.Parse(row["n_DefaultLan"].ToString());
				}
				if(row["n_GSTAgent"]!=null && row["n_GSTAgent"].ToString()!="")
				{
					model.n_GSTAgent=decimal.Parse(row["n_GSTAgent"].ToString());
				}
				if(row["n_GSTDisb"]!=null && row["n_GSTDisb"].ToString()!="")
				{
					model.n_GSTDisb=decimal.Parse(row["n_GSTDisb"].ToString());
				}
				if(row["s_GSTForNativeClient"]!=null)
				{
					model.s_GSTForNativeClient=row["s_GSTForNativeClient"].ToString();
				}
				if(row["s_TmOtherName"]!=null)
				{
					model.s_TmOtherName=row["s_TmOtherName"].ToString();
				}
				if(row["s_ClientCodeRule"]!=null)
				{
					model.s_ClientCodeRule=row["s_ClientCodeRule"].ToString();
				}
				if(row["n_ClientCodeFlowNumCount"]!=null && row["n_ClientCodeFlowNumCount"].ToString()!="")
				{
					model.n_ClientCodeFlowNumCount=int.Parse(row["n_ClientCodeFlowNumCount"].ToString());
				}
				if(row["n_TaxCN"]!=null && row["n_TaxCN"].ToString()!="")
				{
					model.n_TaxCN=decimal.Parse(row["n_TaxCN"].ToString());
				}
				if(row["s_NationalDefense"]!=null)
				{
					model.s_NationalDefense=row["s_NationalDefense"].ToString();
				}
				if(row["s_UnifiedSend"]!=null)
				{
					model.s_UnifiedSend=row["s_UnifiedSend"].ToString();
				}
				if(row["s_WeekEndForeColor"]!=null)
				{
					model.s_WeekEndForeColor=row["s_WeekEndForeColor"].ToString();
				}
				if(row["s_WeekEndBackColor"]!=null)
				{
					model.s_WeekEndBackColor=row["s_WeekEndBackColor"].ToString();
				}
				if(row["s_WorkWeekEndForeColor"]!=null)
				{
					model.s_WorkWeekEndForeColor=row["s_WorkWeekEndForeColor"].ToString();
				}
				if(row["s_WorkWeekEndBackColor"]!=null)
				{
					model.s_WorkWeekEndBackColor=row["s_WorkWeekEndBackColor"].ToString();
				}
				if(row["s_CorpID"]!=null)
				{
					model.s_CorpID=row["s_CorpID"].ToString();
				}
				if(row["s_Secret"]!=null)
				{
					model.s_Secret=row["s_Secret"].ToString();
				}
				if(row["s_CustomizeCode"]!=null)
				{
					model.s_CustomizeCode=row["s_CustomizeCode"].ToString();
				}
				if(row["s_UseHolidayConfig"]!=null)
				{
					model.s_UseHolidayConfig=row["s_UseHolidayConfig"].ToString();
				}
				if(row["s_UseOldConsole"]!=null)
				{
					model.s_UseOldConsole=row["s_UseOldConsole"].ToString();
				}
				if(row["img_Logo"]!=null && row["img_Logo"].ToString()!="")
				{
					model.img_Logo=(byte[])row["img_Logo"];
				}
				if(row["n_AnnualFeeNotificationDay"]!=null && row["n_AnnualFeeNotificationDay"].ToString()!="")
				{
					model.n_AnnualFeeNotificationDay=int.Parse(row["n_AnnualFeeNotificationDay"].ToString());
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
			strSql.Append("select n_ID,s_Name,s_OtherName,s_Contact,s_OtherContact,s_Password,s_AgentCode,s_Tel,s_Fax,n_Country,s_State,s_City,s_Street,s_ZipCode,s_OtherAddress,s_Notes,s_EmailName,s_EmailServer,s_Port,s_EmailUser,s_EmailPwd,s_Signature,dt_CreateDate,dt_EditDate,n_DefaultCurr,n_DefaultLan,n_GSTAgent,n_GSTDisb,s_GSTForNativeClient,s_TmOtherName,s_ClientCodeRule,n_ClientCodeFlowNumCount,n_TaxCN,s_NationalDefense,s_UnifiedSend,s_WeekEndForeColor,s_WeekEndBackColor,s_WorkWeekEndForeColor,s_WorkWeekEndBackColor,s_CorpID,s_Secret,s_CustomizeCode,s_UseHolidayConfig,s_UseOldConsole,img_Logo,n_AnnualFeeNotificationDay ");
			strSql.Append(" FROM TCode_AgencyInfo ");
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
			strSql.Append(" n_ID,s_Name,s_OtherName,s_Contact,s_OtherContact,s_Password,s_AgentCode,s_Tel,s_Fax,n_Country,s_State,s_City,s_Street,s_ZipCode,s_OtherAddress,s_Notes,s_EmailName,s_EmailServer,s_Port,s_EmailUser,s_EmailPwd,s_Signature,dt_CreateDate,dt_EditDate,n_DefaultCurr,n_DefaultLan,n_GSTAgent,n_GSTDisb,s_GSTForNativeClient,s_TmOtherName,s_ClientCodeRule,n_ClientCodeFlowNumCount,n_TaxCN,s_NationalDefense,s_UnifiedSend,s_WeekEndForeColor,s_WeekEndBackColor,s_WorkWeekEndForeColor,s_WorkWeekEndBackColor,s_CorpID,s_Secret,s_CustomizeCode,s_UseHolidayConfig,s_UseOldConsole,img_Logo,n_AnnualFeeNotificationDay ");
			strSql.Append(" FROM TCode_AgencyInfo ");
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
			strSql.Append("select count(1) FROM TCode_AgencyInfo ");
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
			strSql.Append(")AS Row, T.*  from TCode_AgencyInfo T ");
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
			parameters[0].Value = "TCode_AgencyInfo";
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

