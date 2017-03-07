/**  版本信息模板在安装目录下，可自行修改。
* T_User.cs
*
* 功 能： N/A
* 类 名： T_User
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:15   N/A    初版
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
	/// 数据访问类:T_User
	/// </summary>
	public partial class T_User
	{
		public T_User()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal n_UserID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_User");
			strSql.Append(" where n_UserID=@n_UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_UserID", SqlDbType.Decimal)
			};
			parameters[0].Value = n_UserID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(IPSP.Model.T_User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_User(");
			strSql.Append("s_CName,s_EName,s_UserCode,s_Telephone,s_Email,s_IsAttorney,s_MailServer,s_MailServerPort,s_NeedAuth,s_MailAccount,s_MailPassword,s_Valid,s_LoginName,s_LoginPassword,dt_EditDate,s_Editor,s_Notes,s_Login,s_LifeSpan,n_DeptID,s_IP,n_InventorID,n_AgentLoginId,s_IfNeedIP,s_LoginIP)");
			strSql.Append(" values (");
			strSql.Append("@s_CName,@s_EName,@s_UserCode,@s_Telephone,@s_Email,@s_IsAttorney,@s_MailServer,@s_MailServerPort,@s_NeedAuth,@s_MailAccount,@s_MailPassword,@s_Valid,@s_LoginName,@s_LoginPassword,@dt_EditDate,@s_Editor,@s_Notes,@s_Login,@s_LifeSpan,@n_DeptID,@s_IP,@n_InventorID,@n_AgentLoginId,@s_IfNeedIP,@s_LoginIP)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_CName", SqlDbType.NVarChar,10),
					new SqlParameter("@s_EName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_UserCode", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Telephone", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,100),
					new SqlParameter("@s_IsAttorney", SqlDbType.NVarChar,1),
					new SqlParameter("@s_MailServer", SqlDbType.NVarChar,100),
					new SqlParameter("@s_MailServerPort", SqlDbType.NVarChar,8),
					new SqlParameter("@s_NeedAuth", SqlDbType.NVarChar,1),
					new SqlParameter("@s_MailAccount", SqlDbType.NVarChar,100),
					new SqlParameter("@s_MailPassword", SqlDbType.NVarChar,30),
					new SqlParameter("@s_Valid", SqlDbType.NVarChar,1),
					new SqlParameter("@s_LoginName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_LoginPassword", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Login", SqlDbType.NVarChar,1),
					new SqlParameter("@s_LifeSpan", SqlDbType.NVarChar,200),
					new SqlParameter("@n_DeptID", SqlDbType.Decimal,9),
					new SqlParameter("@s_IP", SqlDbType.NVarChar,50),
					new SqlParameter("@n_InventorID", SqlDbType.Decimal,9),
					new SqlParameter("@n_AgentLoginId", SqlDbType.Decimal,9),
					new SqlParameter("@s_IfNeedIP", SqlDbType.NVarChar,2),
					new SqlParameter("@s_LoginIP", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.s_CName;
			parameters[1].Value = model.s_EName;
			parameters[2].Value = model.s_UserCode;
			parameters[3].Value = model.s_Telephone;
			parameters[4].Value = model.s_Email;
			parameters[5].Value = model.s_IsAttorney;
			parameters[6].Value = model.s_MailServer;
			parameters[7].Value = model.s_MailServerPort;
			parameters[8].Value = model.s_NeedAuth;
			parameters[9].Value = model.s_MailAccount;
			parameters[10].Value = model.s_MailPassword;
			parameters[11].Value = model.s_Valid;
			parameters[12].Value = model.s_LoginName;
			parameters[13].Value = model.s_LoginPassword;
			parameters[14].Value = model.dt_EditDate;
			parameters[15].Value = model.s_Editor;
			parameters[16].Value = model.s_Notes;
			parameters[17].Value = model.s_Login;
			parameters[18].Value = model.s_LifeSpan;
			parameters[19].Value = model.n_DeptID;
			parameters[20].Value = model.s_IP;
			parameters[21].Value = model.n_InventorID;
			parameters[22].Value = model.n_AgentLoginId;
			parameters[23].Value = model.s_IfNeedIP;
			parameters[24].Value = model.s_LoginIP;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToDecimal(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(IPSP.Model.T_User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_User set ");
			strSql.Append("s_CName=@s_CName,");
			strSql.Append("s_EName=@s_EName,");
			strSql.Append("s_UserCode=@s_UserCode,");
			strSql.Append("s_Telephone=@s_Telephone,");
			strSql.Append("s_Email=@s_Email,");
			strSql.Append("s_IsAttorney=@s_IsAttorney,");
			strSql.Append("s_MailServer=@s_MailServer,");
			strSql.Append("s_MailServerPort=@s_MailServerPort,");
			strSql.Append("s_NeedAuth=@s_NeedAuth,");
			strSql.Append("s_MailAccount=@s_MailAccount,");
			strSql.Append("s_MailPassword=@s_MailPassword,");
			strSql.Append("s_Valid=@s_Valid,");
			strSql.Append("s_LoginName=@s_LoginName,");
			strSql.Append("s_LoginPassword=@s_LoginPassword,");
			strSql.Append("dt_EditDate=@dt_EditDate,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("s_Notes=@s_Notes,");
			strSql.Append("s_Login=@s_Login,");
			strSql.Append("s_LifeSpan=@s_LifeSpan,");
			strSql.Append("n_DeptID=@n_DeptID,");
			strSql.Append("s_IP=@s_IP,");
			strSql.Append("n_InventorID=@n_InventorID,");
			strSql.Append("n_AgentLoginId=@n_AgentLoginId,");
			strSql.Append("s_IfNeedIP=@s_IfNeedIP,");
			strSql.Append("s_LoginIP=@s_LoginIP");
			strSql.Append(" where n_UserID=@n_UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_CName", SqlDbType.NVarChar,10),
					new SqlParameter("@s_EName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_UserCode", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Telephone", SqlDbType.NVarChar,100),
					new SqlParameter("@s_Email", SqlDbType.NVarChar,100),
					new SqlParameter("@s_IsAttorney", SqlDbType.NVarChar,1),
					new SqlParameter("@s_MailServer", SqlDbType.NVarChar,100),
					new SqlParameter("@s_MailServerPort", SqlDbType.NVarChar,8),
					new SqlParameter("@s_NeedAuth", SqlDbType.NVarChar,1),
					new SqlParameter("@s_MailAccount", SqlDbType.NVarChar,100),
					new SqlParameter("@s_MailPassword", SqlDbType.NVarChar,30),
					new SqlParameter("@s_Valid", SqlDbType.NVarChar,1),
					new SqlParameter("@s_LoginName", SqlDbType.NVarChar,50),
					new SqlParameter("@s_LoginPassword", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_EditDate", SqlDbType.DateTime),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,10),
					new SqlParameter("@s_Notes", SqlDbType.NVarChar,1000),
					new SqlParameter("@s_Login", SqlDbType.NVarChar,1),
					new SqlParameter("@s_LifeSpan", SqlDbType.NVarChar,200),
					new SqlParameter("@n_DeptID", SqlDbType.Decimal,9),
					new SqlParameter("@s_IP", SqlDbType.NVarChar,50),
					new SqlParameter("@n_InventorID", SqlDbType.Decimal,9),
					new SqlParameter("@n_AgentLoginId", SqlDbType.Decimal,9),
					new SqlParameter("@s_IfNeedIP", SqlDbType.NVarChar,2),
					new SqlParameter("@s_LoginIP", SqlDbType.NVarChar,50),
					new SqlParameter("@n_UserID", SqlDbType.Decimal,9)};
			parameters[0].Value = model.s_CName;
			parameters[1].Value = model.s_EName;
			parameters[2].Value = model.s_UserCode;
			parameters[3].Value = model.s_Telephone;
			parameters[4].Value = model.s_Email;
			parameters[5].Value = model.s_IsAttorney;
			parameters[6].Value = model.s_MailServer;
			parameters[7].Value = model.s_MailServerPort;
			parameters[8].Value = model.s_NeedAuth;
			parameters[9].Value = model.s_MailAccount;
			parameters[10].Value = model.s_MailPassword;
			parameters[11].Value = model.s_Valid;
			parameters[12].Value = model.s_LoginName;
			parameters[13].Value = model.s_LoginPassword;
			parameters[14].Value = model.dt_EditDate;
			parameters[15].Value = model.s_Editor;
			parameters[16].Value = model.s_Notes;
			parameters[17].Value = model.s_Login;
			parameters[18].Value = model.s_LifeSpan;
			parameters[19].Value = model.n_DeptID;
			parameters[20].Value = model.s_IP;
			parameters[21].Value = model.n_InventorID;
			parameters[22].Value = model.n_AgentLoginId;
			parameters[23].Value = model.s_IfNeedIP;
			parameters[24].Value = model.s_LoginIP;
			parameters[25].Value = model.n_UserID;

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
		public bool Delete(decimal n_UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_User ");
			strSql.Append(" where n_UserID=@n_UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_UserID", SqlDbType.Decimal)
			};
			parameters[0].Value = n_UserID;

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
		public bool DeleteList(string n_UserIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_User ");
			strSql.Append(" where n_UserID in ("+n_UserIDlist + ")  ");
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
		public IPSP.Model.T_User GetModel(decimal n_UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_UserID,s_CName,s_EName,s_UserCode,s_Telephone,s_Email,s_IsAttorney,s_MailServer,s_MailServerPort,s_NeedAuth,s_MailAccount,s_MailPassword,s_Valid,s_LoginName,s_LoginPassword,dt_EditDate,s_Editor,s_Notes,s_Login,s_LifeSpan,n_DeptID,s_IP,n_InventorID,n_AgentLoginId,s_IfNeedIP,s_LoginIP from T_User ");
			strSql.Append(" where n_UserID=@n_UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_UserID", SqlDbType.Decimal)
			};
			parameters[0].Value = n_UserID;

			IPSP.Model.T_User model=new IPSP.Model.T_User();
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
		public IPSP.Model.T_User DataRowToModel(DataRow row)
		{
			IPSP.Model.T_User model=new IPSP.Model.T_User();
			if (row != null)
			{
				if(row["n_UserID"]!=null && row["n_UserID"].ToString()!="")
				{
					model.n_UserID=decimal.Parse(row["n_UserID"].ToString());
				}
				if(row["s_CName"]!=null)
				{
					model.s_CName=row["s_CName"].ToString();
				}
				if(row["s_EName"]!=null)
				{
					model.s_EName=row["s_EName"].ToString();
				}
				if(row["s_UserCode"]!=null)
				{
					model.s_UserCode=row["s_UserCode"].ToString();
				}
				if(row["s_Telephone"]!=null)
				{
					model.s_Telephone=row["s_Telephone"].ToString();
				}
				if(row["s_Email"]!=null)
				{
					model.s_Email=row["s_Email"].ToString();
				}
				if(row["s_IsAttorney"]!=null)
				{
					model.s_IsAttorney=row["s_IsAttorney"].ToString();
				}
				if(row["s_MailServer"]!=null)
				{
					model.s_MailServer=row["s_MailServer"].ToString();
				}
				if(row["s_MailServerPort"]!=null)
				{
					model.s_MailServerPort=row["s_MailServerPort"].ToString();
				}
				if(row["s_NeedAuth"]!=null)
				{
					model.s_NeedAuth=row["s_NeedAuth"].ToString();
				}
				if(row["s_MailAccount"]!=null)
				{
					model.s_MailAccount=row["s_MailAccount"].ToString();
				}
				if(row["s_MailPassword"]!=null)
				{
					model.s_MailPassword=row["s_MailPassword"].ToString();
				}
				if(row["s_Valid"]!=null)
				{
					model.s_Valid=row["s_Valid"].ToString();
				}
				if(row["s_LoginName"]!=null)
				{
					model.s_LoginName=row["s_LoginName"].ToString();
				}
				if(row["s_LoginPassword"]!=null)
				{
					model.s_LoginPassword=row["s_LoginPassword"].ToString();
				}
				if(row["dt_EditDate"]!=null && row["dt_EditDate"].ToString()!="")
				{
					model.dt_EditDate=DateTime.Parse(row["dt_EditDate"].ToString());
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["s_Notes"]!=null)
				{
					model.s_Notes=row["s_Notes"].ToString();
				}
				if(row["s_Login"]!=null)
				{
					model.s_Login=row["s_Login"].ToString();
				}
				if(row["s_LifeSpan"]!=null)
				{
					model.s_LifeSpan=row["s_LifeSpan"].ToString();
				}
				if(row["n_DeptID"]!=null && row["n_DeptID"].ToString()!="")
				{
					model.n_DeptID=decimal.Parse(row["n_DeptID"].ToString());
				}
				if(row["s_IP"]!=null)
				{
					model.s_IP=row["s_IP"].ToString();
				}
				if(row["n_InventorID"]!=null && row["n_InventorID"].ToString()!="")
				{
					model.n_InventorID=decimal.Parse(row["n_InventorID"].ToString());
				}
				if(row["n_AgentLoginId"]!=null && row["n_AgentLoginId"].ToString()!="")
				{
					model.n_AgentLoginId=decimal.Parse(row["n_AgentLoginId"].ToString());
				}
				if(row["s_IfNeedIP"]!=null)
				{
					model.s_IfNeedIP=row["s_IfNeedIP"].ToString();
				}
				if(row["s_LoginIP"]!=null)
				{
					model.s_LoginIP=row["s_LoginIP"].ToString();
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
			strSql.Append("select n_UserID,s_CName,s_EName,s_UserCode,s_Telephone,s_Email,s_IsAttorney,s_MailServer,s_MailServerPort,s_NeedAuth,s_MailAccount,s_MailPassword,s_Valid,s_LoginName,s_LoginPassword,dt_EditDate,s_Editor,s_Notes,s_Login,s_LifeSpan,n_DeptID,s_IP,n_InventorID,n_AgentLoginId,s_IfNeedIP,s_LoginIP ");
			strSql.Append(" FROM T_User ");
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
			strSql.Append(" n_UserID,s_CName,s_EName,s_UserCode,s_Telephone,s_Email,s_IsAttorney,s_MailServer,s_MailServerPort,s_NeedAuth,s_MailAccount,s_MailPassword,s_Valid,s_LoginName,s_LoginPassword,dt_EditDate,s_Editor,s_Notes,s_Login,s_LifeSpan,n_DeptID,s_IP,n_InventorID,n_AgentLoginId,s_IfNeedIP,s_LoginIP ");
			strSql.Append(" FROM T_User ");
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
			strSql.Append("select count(1) FROM T_User ");
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
				strSql.Append("order by T.n_UserID desc");
			}
			strSql.Append(")AS Row, T.*  from T_User T ");
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
			parameters[0].Value = "T_User";
			parameters[1].Value = "n_UserID";
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

