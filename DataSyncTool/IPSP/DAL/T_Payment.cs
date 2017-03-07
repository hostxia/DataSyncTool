/**  版本信息模板在安装目录下，可自行修改。
* T_Payment.cs
*
* 功 能： N/A
* 类 名： T_Payment
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:59   N/A    初版
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
	/// 数据访问类:T_Payment
	/// </summary>
	public partial class T_Payment
	{
		public T_Payment()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_BillID", "T_Payment"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_BillID,int n_HedgeID,int n_PaymentID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Payment");
			strSql.Append(" where n_BillID=@n_BillID and n_HedgeID=@n_HedgeID and n_PaymentID=@n_PaymentID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_HedgeID", SqlDbType.Int,4),
					new SqlParameter("@n_PaymentID", SqlDbType.Int,4)			};
			parameters[0].Value = n_BillID;
			parameters[1].Value = n_HedgeID;
			parameters[2].Value = n_PaymentID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_Payment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Payment(");
			strSql.Append("n_BillListID,n_BillID,n_ReceiveID,n_HedgeID,n_PaymentAmount,dt_PaymentDate,n_PaymentUserID,s_Editor,dt_EditTime)");
			strSql.Append(" values (");
			strSql.Append("@n_BillListID,@n_BillID,@n_ReceiveID,@n_HedgeID,@n_PaymentAmount,@dt_PaymentDate,@n_PaymentUserID,@s_Editor,@dt_EditTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillListID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_ReceiveID", SqlDbType.Int,4),
					new SqlParameter("@n_HedgeID", SqlDbType.Int,4),
					new SqlParameter("@n_PaymentAmount", SqlDbType.Money,8),
					new SqlParameter("@dt_PaymentDate", SqlDbType.DateTime),
					new SqlParameter("@n_PaymentUserID", SqlDbType.Int,4),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_EditTime", SqlDbType.DateTime)};
			parameters[0].Value = model.n_BillListID;
			parameters[1].Value = model.n_BillID;
			parameters[2].Value = model.n_ReceiveID;
			parameters[3].Value = model.n_HedgeID;
			parameters[4].Value = model.n_PaymentAmount;
			parameters[5].Value = model.dt_PaymentDate;
			parameters[6].Value = model.n_PaymentUserID;
			parameters[7].Value = model.s_Editor;
			parameters[8].Value = model.dt_EditTime;

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
		public bool Update(IPSP.Model.T_Payment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Payment set ");
			strSql.Append("n_BillListID=@n_BillListID,");
			strSql.Append("n_ReceiveID=@n_ReceiveID,");
			strSql.Append("n_PaymentAmount=@n_PaymentAmount,");
			strSql.Append("dt_PaymentDate=@dt_PaymentDate,");
			strSql.Append("n_PaymentUserID=@n_PaymentUserID,");
			strSql.Append("s_Editor=@s_Editor,");
			strSql.Append("dt_EditTime=@dt_EditTime");
			strSql.Append(" where n_PaymentID=@n_PaymentID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillListID", SqlDbType.Int,4),
					new SqlParameter("@n_ReceiveID", SqlDbType.Int,4),
					new SqlParameter("@n_PaymentAmount", SqlDbType.Money,8),
					new SqlParameter("@dt_PaymentDate", SqlDbType.DateTime),
					new SqlParameter("@n_PaymentUserID", SqlDbType.Int,4),
					new SqlParameter("@s_Editor", SqlDbType.NVarChar,20),
					new SqlParameter("@dt_EditTime", SqlDbType.DateTime),
					new SqlParameter("@n_PaymentID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_HedgeID", SqlDbType.Int,4)};
			parameters[0].Value = model.n_BillListID;
			parameters[1].Value = model.n_ReceiveID;
			parameters[2].Value = model.n_PaymentAmount;
			parameters[3].Value = model.dt_PaymentDate;
			parameters[4].Value = model.n_PaymentUserID;
			parameters[5].Value = model.s_Editor;
			parameters[6].Value = model.dt_EditTime;
			parameters[7].Value = model.n_PaymentID;
			parameters[8].Value = model.n_BillID;
			parameters[9].Value = model.n_HedgeID;

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
		public bool Delete(int n_PaymentID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Payment ");
			strSql.Append(" where n_PaymentID=@n_PaymentID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_PaymentID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_PaymentID;

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
		public bool Delete(int n_BillID,int n_HedgeID,int n_PaymentID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Payment ");
			strSql.Append(" where n_BillID=@n_BillID and n_HedgeID=@n_HedgeID and n_PaymentID=@n_PaymentID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_HedgeID", SqlDbType.Int,4),
					new SqlParameter("@n_PaymentID", SqlDbType.Int,4)			};
			parameters[0].Value = n_BillID;
			parameters[1].Value = n_HedgeID;
			parameters[2].Value = n_PaymentID;

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
		public bool DeleteList(string n_PaymentIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Payment ");
			strSql.Append(" where n_PaymentID in ("+n_PaymentIDlist + ")  ");
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
		public IPSP.Model.T_Payment GetModel(int n_PaymentID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_PaymentID,n_BillListID,n_BillID,n_ReceiveID,n_HedgeID,n_PaymentAmount,dt_PaymentDate,n_PaymentUserID,s_Editor,dt_EditTime from T_Payment ");
			strSql.Append(" where n_PaymentID=@n_PaymentID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_PaymentID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_PaymentID;

			IPSP.Model.T_Payment model=new IPSP.Model.T_Payment();
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
		public IPSP.Model.T_Payment DataRowToModel(DataRow row)
		{
			IPSP.Model.T_Payment model=new IPSP.Model.T_Payment();
			if (row != null)
			{
				if(row["n_PaymentID"]!=null && row["n_PaymentID"].ToString()!="")
				{
					model.n_PaymentID=int.Parse(row["n_PaymentID"].ToString());
				}
				if(row["n_BillListID"]!=null && row["n_BillListID"].ToString()!="")
				{
					model.n_BillListID=int.Parse(row["n_BillListID"].ToString());
				}
				if(row["n_BillID"]!=null && row["n_BillID"].ToString()!="")
				{
					model.n_BillID=int.Parse(row["n_BillID"].ToString());
				}
				if(row["n_ReceiveID"]!=null && row["n_ReceiveID"].ToString()!="")
				{
					model.n_ReceiveID=int.Parse(row["n_ReceiveID"].ToString());
				}
				if(row["n_HedgeID"]!=null && row["n_HedgeID"].ToString()!="")
				{
					model.n_HedgeID=int.Parse(row["n_HedgeID"].ToString());
				}
				if(row["n_PaymentAmount"]!=null && row["n_PaymentAmount"].ToString()!="")
				{
					model.n_PaymentAmount=decimal.Parse(row["n_PaymentAmount"].ToString());
				}
				if(row["dt_PaymentDate"]!=null && row["dt_PaymentDate"].ToString()!="")
				{
					model.dt_PaymentDate=DateTime.Parse(row["dt_PaymentDate"].ToString());
				}
				if(row["n_PaymentUserID"]!=null && row["n_PaymentUserID"].ToString()!="")
				{
					model.n_PaymentUserID=int.Parse(row["n_PaymentUserID"].ToString());
				}
				if(row["s_Editor"]!=null)
				{
					model.s_Editor=row["s_Editor"].ToString();
				}
				if(row["dt_EditTime"]!=null && row["dt_EditTime"].ToString()!="")
				{
					model.dt_EditTime=DateTime.Parse(row["dt_EditTime"].ToString());
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
			strSql.Append("select n_PaymentID,n_BillListID,n_BillID,n_ReceiveID,n_HedgeID,n_PaymentAmount,dt_PaymentDate,n_PaymentUserID,s_Editor,dt_EditTime ");
			strSql.Append(" FROM T_Payment ");
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
			strSql.Append(" n_PaymentID,n_BillListID,n_BillID,n_ReceiveID,n_HedgeID,n_PaymentAmount,dt_PaymentDate,n_PaymentUserID,s_Editor,dt_EditTime ");
			strSql.Append(" FROM T_Payment ");
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
			strSql.Append("select count(1) FROM T_Payment ");
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
				strSql.Append("order by T.n_PaymentID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Payment T ");
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
			parameters[0].Value = "T_Payment";
			parameters[1].Value = "n_PaymentID";
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

