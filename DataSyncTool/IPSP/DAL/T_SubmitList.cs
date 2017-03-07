/**  版本信息模板在安装目录下，可自行修改。
* T_SubmitList.cs
*
* 功 能： N/A
* 类 名： T_SubmitList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:04   N/A    初版
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
	/// 数据访问类:T_SubmitList
	/// </summary>
	public partial class T_SubmitList
	{
		public T_SubmitList()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_FileID", "T_SubmitList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_FileID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_SubmitList");
			strSql.Append(" where n_FileID=@n_FileID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.T_SubmitList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_SubmitList(");
			strSql.Append("s_ListSerial,n_FlowNum,s_ListClass,s_IsRegOnline,n_CurrBalance,n_WriterID,n_SubmiterID,n_FileID,s_ReceiveFilePathName)");
			strSql.Append(" values (");
			strSql.Append("@s_ListSerial,@n_FlowNum,@s_ListClass,@s_IsRegOnline,@n_CurrBalance,@n_WriterID,@n_SubmiterID,@n_FileID,@s_ReceiveFilePathName)");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ListSerial", SqlDbType.NVarChar,20),
					new SqlParameter("@n_FlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_ListClass", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsRegOnline", SqlDbType.NVarChar,1),
					new SqlParameter("@n_CurrBalance", SqlDbType.Decimal,9),
					new SqlParameter("@n_WriterID", SqlDbType.Int,4),
					new SqlParameter("@n_SubmiterID", SqlDbType.Int,4),
					new SqlParameter("@n_FileID", SqlDbType.Int,4),
					new SqlParameter("@s_ReceiveFilePathName", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.s_ListSerial;
			parameters[1].Value = model.n_FlowNum;
			parameters[2].Value = model.s_ListClass;
			parameters[3].Value = model.s_IsRegOnline;
			parameters[4].Value = model.n_CurrBalance;
			parameters[5].Value = model.n_WriterID;
			parameters[6].Value = model.n_SubmiterID;
			parameters[7].Value = model.n_FileID;
			parameters[8].Value = model.s_ReceiveFilePathName;

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
		public bool Update(IPSP.Model.T_SubmitList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_SubmitList set ");
			strSql.Append("s_ListSerial=@s_ListSerial,");
			strSql.Append("n_FlowNum=@n_FlowNum,");
			strSql.Append("s_ListClass=@s_ListClass,");
			strSql.Append("s_IsRegOnline=@s_IsRegOnline,");
			strSql.Append("n_CurrBalance=@n_CurrBalance,");
			strSql.Append("n_WriterID=@n_WriterID,");
			strSql.Append("n_SubmiterID=@n_SubmiterID,");
			strSql.Append("s_ReceiveFilePathName=@s_ReceiveFilePathName");
			strSql.Append(" where n_FileID=@n_FileID ");
			SqlParameter[] parameters = {
					new SqlParameter("@s_ListSerial", SqlDbType.NVarChar,20),
					new SqlParameter("@n_FlowNum", SqlDbType.Int,4),
					new SqlParameter("@s_ListClass", SqlDbType.NVarChar,1),
					new SqlParameter("@s_IsRegOnline", SqlDbType.NVarChar,1),
					new SqlParameter("@n_CurrBalance", SqlDbType.Decimal,9),
					new SqlParameter("@n_WriterID", SqlDbType.Int,4),
					new SqlParameter("@n_SubmiterID", SqlDbType.Int,4),
					new SqlParameter("@s_ReceiveFilePathName", SqlDbType.NVarChar,500),
					new SqlParameter("@n_FileID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_ListSerial;
			parameters[1].Value = model.n_FlowNum;
			parameters[2].Value = model.s_ListClass;
			parameters[3].Value = model.s_IsRegOnline;
			parameters[4].Value = model.n_CurrBalance;
			parameters[5].Value = model.n_WriterID;
			parameters[6].Value = model.n_SubmiterID;
			parameters[7].Value = model.s_ReceiveFilePathName;
			parameters[8].Value = model.n_FileID;

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
		public bool Delete(int n_FileID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_SubmitList ");
			strSql.Append(" where n_FileID=@n_FileID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;

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
		public bool DeleteList(string n_FileIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_SubmitList ");
			strSql.Append(" where n_FileID in ("+n_FileIDlist + ")  ");
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
		public IPSP.Model.T_SubmitList GetModel(int n_FileID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 s_ListSerial,n_FlowNum,s_ListClass,s_IsRegOnline,n_CurrBalance,n_WriterID,n_SubmiterID,n_FileID,s_ReceiveFilePathName from T_SubmitList ");
			strSql.Append(" where n_FileID=@n_FileID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_FileID", SqlDbType.Int,4)			};
			parameters[0].Value = n_FileID;

			IPSP.Model.T_SubmitList model=new IPSP.Model.T_SubmitList();
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
		public IPSP.Model.T_SubmitList DataRowToModel(DataRow row)
		{
			IPSP.Model.T_SubmitList model=new IPSP.Model.T_SubmitList();
			if (row != null)
			{
				if(row["s_ListSerial"]!=null)
				{
					model.s_ListSerial=row["s_ListSerial"].ToString();
				}
				if(row["n_FlowNum"]!=null && row["n_FlowNum"].ToString()!="")
				{
					model.n_FlowNum=int.Parse(row["n_FlowNum"].ToString());
				}
				if(row["s_ListClass"]!=null)
				{
					model.s_ListClass=row["s_ListClass"].ToString();
				}
				if(row["s_IsRegOnline"]!=null)
				{
					model.s_IsRegOnline=row["s_IsRegOnline"].ToString();
				}
				if(row["n_CurrBalance"]!=null && row["n_CurrBalance"].ToString()!="")
				{
					model.n_CurrBalance=decimal.Parse(row["n_CurrBalance"].ToString());
				}
				if(row["n_WriterID"]!=null && row["n_WriterID"].ToString()!="")
				{
					model.n_WriterID=int.Parse(row["n_WriterID"].ToString());
				}
				if(row["n_SubmiterID"]!=null && row["n_SubmiterID"].ToString()!="")
				{
					model.n_SubmiterID=int.Parse(row["n_SubmiterID"].ToString());
				}
				if(row["n_FileID"]!=null && row["n_FileID"].ToString()!="")
				{
					model.n_FileID=int.Parse(row["n_FileID"].ToString());
				}
				if(row["s_ReceiveFilePathName"]!=null)
				{
					model.s_ReceiveFilePathName=row["s_ReceiveFilePathName"].ToString();
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
			strSql.Append("select s_ListSerial,n_FlowNum,s_ListClass,s_IsRegOnline,n_CurrBalance,n_WriterID,n_SubmiterID,n_FileID,s_ReceiveFilePathName ");
			strSql.Append(" FROM T_SubmitList ");
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
			strSql.Append(" s_ListSerial,n_FlowNum,s_ListClass,s_IsRegOnline,n_CurrBalance,n_WriterID,n_SubmiterID,n_FileID,s_ReceiveFilePathName ");
			strSql.Append(" FROM T_SubmitList ");
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
			strSql.Append("select count(1) FROM T_SubmitList ");
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
				strSql.Append("order by T.n_FileID desc");
			}
			strSql.Append(")AS Row, T.*  from T_SubmitList T ");
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
			parameters[0].Value = "T_SubmitList";
			parameters[1].Value = "n_FileID";
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

