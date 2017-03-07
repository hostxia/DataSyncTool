/**  版本信息模板在安装目录下，可自行修改。
* T_BillList.cs
*
* 功 能： N/A
* 类 名： T_BillList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:31   N/A    初版
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
	/// 数据访问类:T_BillList
	/// </summary>
	public partial class T_BillList
	{
		public T_BillList()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_BillID", "T_BillList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_BillID,int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_BillList");
			strSql.Append(" where n_BillID=@n_BillID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_BillID;
			parameters[1].Value = n_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(IPSP.Model.T_BillList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_BillList(");
			strSql.Append("n_BillID,s_FeeName,s_Type,n_SourceID,n_OFee,n_AttrFee,n_OtherFee,s_Status,n_Sequence,n_FeeID,n_FeeCodeID,n_AttrFeeTaxRate,n_OFeeTaxRate,n_DisbFeeTaxRate,n_OrginalAttrFee,n_OrignalOtherFee,n_DiscountAttrFeeRate,n_DiscountOtherFeeRate,n_PreferentialPolicyID,n_moreUnitCount,s_FeeNotes)");
			strSql.Append(" values (");
			strSql.Append("@n_BillID,@s_FeeName,@s_Type,@n_SourceID,@n_OFee,@n_AttrFee,@n_OtherFee,@s_Status,@n_Sequence,@n_FeeID,@n_FeeCodeID,@n_AttrFeeTaxRate,@n_OFeeTaxRate,@n_DisbFeeTaxRate,@n_OrginalAttrFee,@n_OrignalOtherFee,@n_DiscountAttrFeeRate,@n_DiscountOtherFeeRate,@n_PreferentialPolicyID,@n_moreUnitCount,@s_FeeNotes)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@s_FeeName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,1),
					new SqlParameter("@n_SourceID", SqlDbType.Int,4),
					new SqlParameter("@n_OFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_AttrFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_OtherFee", SqlDbType.Decimal,9),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@n_FeeID", SqlDbType.Int,4),
					new SqlParameter("@n_FeeCodeID", SqlDbType.Int,4),
					new SqlParameter("@n_AttrFeeTaxRate", SqlDbType.Decimal,9),
					new SqlParameter("@n_OFeeTaxRate", SqlDbType.Decimal,9),
					new SqlParameter("@n_DisbFeeTaxRate", SqlDbType.Decimal,9),
					new SqlParameter("@n_OrginalAttrFee", SqlDbType.Money,8),
					new SqlParameter("@n_OrignalOtherFee", SqlDbType.Money,8),
					new SqlParameter("@n_DiscountAttrFeeRate", SqlDbType.Money,8),
					new SqlParameter("@n_DiscountOtherFeeRate", SqlDbType.Money,8),
					new SqlParameter("@n_PreferentialPolicyID", SqlDbType.Int,4),
					new SqlParameter("@n_moreUnitCount", SqlDbType.Money,8),
					new SqlParameter("@s_FeeNotes", SqlDbType.NVarChar,1000)};
			parameters[0].Value = model.n_BillID;
			parameters[1].Value = model.s_FeeName;
			parameters[2].Value = model.s_Type;
			parameters[3].Value = model.n_SourceID;
			parameters[4].Value = model.n_OFee;
			parameters[5].Value = model.n_AttrFee;
			parameters[6].Value = model.n_OtherFee;
			parameters[7].Value = model.s_Status;
			parameters[8].Value = model.n_Sequence;
			parameters[9].Value = model.n_FeeID;
			parameters[10].Value = model.n_FeeCodeID;
			parameters[11].Value = model.n_AttrFeeTaxRate;
			parameters[12].Value = model.n_OFeeTaxRate;
			parameters[13].Value = model.n_DisbFeeTaxRate;
			parameters[14].Value = model.n_OrginalAttrFee;
			parameters[15].Value = model.n_OrignalOtherFee;
			parameters[16].Value = model.n_DiscountAttrFeeRate;
			parameters[17].Value = model.n_DiscountOtherFeeRate;
			parameters[18].Value = model.n_PreferentialPolicyID;
			parameters[19].Value = model.n_moreUnitCount;
			parameters[20].Value = model.s_FeeNotes;

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
		public bool Update(IPSP.Model.T_BillList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_BillList set ");
			strSql.Append("s_FeeName=@s_FeeName,");
			strSql.Append("s_Type=@s_Type,");
			strSql.Append("n_SourceID=@n_SourceID,");
			strSql.Append("n_OFee=@n_OFee,");
			strSql.Append("n_AttrFee=@n_AttrFee,");
			strSql.Append("n_OtherFee=@n_OtherFee,");
			strSql.Append("s_Status=@s_Status,");
			strSql.Append("n_Sequence=@n_Sequence,");
			strSql.Append("n_FeeID=@n_FeeID,");
			strSql.Append("n_FeeCodeID=@n_FeeCodeID,");
			strSql.Append("n_AttrFeeTaxRate=@n_AttrFeeTaxRate,");
			strSql.Append("n_OFeeTaxRate=@n_OFeeTaxRate,");
			strSql.Append("n_DisbFeeTaxRate=@n_DisbFeeTaxRate,");
			strSql.Append("n_OrginalAttrFee=@n_OrginalAttrFee,");
			strSql.Append("n_OrignalOtherFee=@n_OrignalOtherFee,");
			strSql.Append("n_DiscountAttrFeeRate=@n_DiscountAttrFeeRate,");
			strSql.Append("n_DiscountOtherFeeRate=@n_DiscountOtherFeeRate,");
			strSql.Append("n_PreferentialPolicyID=@n_PreferentialPolicyID,");
			strSql.Append("n_moreUnitCount=@n_moreUnitCount,");
			strSql.Append("s_FeeNotes=@s_FeeNotes");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_FeeName", SqlDbType.NVarChar,500),
					new SqlParameter("@s_Type", SqlDbType.NVarChar,1),
					new SqlParameter("@n_SourceID", SqlDbType.Int,4),
					new SqlParameter("@n_OFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_AttrFee", SqlDbType.Decimal,9),
					new SqlParameter("@n_OtherFee", SqlDbType.Decimal,9),
					new SqlParameter("@s_Status", SqlDbType.NVarChar,1),
					new SqlParameter("@n_Sequence", SqlDbType.Int,4),
					new SqlParameter("@n_FeeID", SqlDbType.Int,4),
					new SqlParameter("@n_FeeCodeID", SqlDbType.Int,4),
					new SqlParameter("@n_AttrFeeTaxRate", SqlDbType.Decimal,9),
					new SqlParameter("@n_OFeeTaxRate", SqlDbType.Decimal,9),
					new SqlParameter("@n_DisbFeeTaxRate", SqlDbType.Decimal,9),
					new SqlParameter("@n_OrginalAttrFee", SqlDbType.Money,8),
					new SqlParameter("@n_OrignalOtherFee", SqlDbType.Money,8),
					new SqlParameter("@n_DiscountAttrFeeRate", SqlDbType.Money,8),
					new SqlParameter("@n_DiscountOtherFeeRate", SqlDbType.Money,8),
					new SqlParameter("@n_PreferentialPolicyID", SqlDbType.Int,4),
					new SqlParameter("@n_moreUnitCount", SqlDbType.Money,8),
					new SqlParameter("@s_FeeNotes", SqlDbType.NVarChar,1000),
					new SqlParameter("@n_ID", SqlDbType.Int,4),
					new SqlParameter("@n_BillID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_FeeName;
			parameters[1].Value = model.s_Type;
			parameters[2].Value = model.n_SourceID;
			parameters[3].Value = model.n_OFee;
			parameters[4].Value = model.n_AttrFee;
			parameters[5].Value = model.n_OtherFee;
			parameters[6].Value = model.s_Status;
			parameters[7].Value = model.n_Sequence;
			parameters[8].Value = model.n_FeeID;
			parameters[9].Value = model.n_FeeCodeID;
			parameters[10].Value = model.n_AttrFeeTaxRate;
			parameters[11].Value = model.n_OFeeTaxRate;
			parameters[12].Value = model.n_DisbFeeTaxRate;
			parameters[13].Value = model.n_OrginalAttrFee;
			parameters[14].Value = model.n_OrignalOtherFee;
			parameters[15].Value = model.n_DiscountAttrFeeRate;
			parameters[16].Value = model.n_DiscountOtherFeeRate;
			parameters[17].Value = model.n_PreferentialPolicyID;
			parameters[18].Value = model.n_moreUnitCount;
			parameters[19].Value = model.s_FeeNotes;
			parameters[20].Value = model.n_ID;
			parameters[21].Value = model.n_BillID;

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
			strSql.Append("delete from T_BillList ");
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
		public bool Delete(int n_BillID,int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_BillList ");
			strSql.Append(" where n_BillID=@n_BillID and n_ID=@n_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@n_BillID", SqlDbType.Int,4),
					new SqlParameter("@n_ID", SqlDbType.Int,4)			};
			parameters[0].Value = n_BillID;
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
			strSql.Append("delete from T_BillList ");
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
		public IPSP.Model.T_BillList GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,n_BillID,s_FeeName,s_Type,n_SourceID,n_OFee,n_AttrFee,n_OtherFee,s_Status,n_Sequence,n_FeeID,n_FeeCodeID,n_AttrFeeTaxRate,n_OFeeTaxRate,n_DisbFeeTaxRate,n_OrginalAttrFee,n_OrignalOtherFee,n_DiscountAttrFeeRate,n_DiscountOtherFeeRate,n_PreferentialPolicyID,n_moreUnitCount,s_FeeNotes from T_BillList ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.T_BillList model=new IPSP.Model.T_BillList();
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
		public IPSP.Model.T_BillList DataRowToModel(DataRow row)
		{
			IPSP.Model.T_BillList model=new IPSP.Model.T_BillList();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["n_BillID"]!=null && row["n_BillID"].ToString()!="")
				{
					model.n_BillID=int.Parse(row["n_BillID"].ToString());
				}
				if(row["s_FeeName"]!=null)
				{
					model.s_FeeName=row["s_FeeName"].ToString();
				}
				if(row["s_Type"]!=null)
				{
					model.s_Type=row["s_Type"].ToString();
				}
				if(row["n_SourceID"]!=null && row["n_SourceID"].ToString()!="")
				{
					model.n_SourceID=int.Parse(row["n_SourceID"].ToString());
				}
				if(row["n_OFee"]!=null && row["n_OFee"].ToString()!="")
				{
					model.n_OFee=decimal.Parse(row["n_OFee"].ToString());
				}
				if(row["n_AttrFee"]!=null && row["n_AttrFee"].ToString()!="")
				{
					model.n_AttrFee=decimal.Parse(row["n_AttrFee"].ToString());
				}
				if(row["n_OtherFee"]!=null && row["n_OtherFee"].ToString()!="")
				{
					model.n_OtherFee=decimal.Parse(row["n_OtherFee"].ToString());
				}
				if(row["s_Status"]!=null)
				{
					model.s_Status=row["s_Status"].ToString();
				}
				if(row["n_Sequence"]!=null && row["n_Sequence"].ToString()!="")
				{
					model.n_Sequence=int.Parse(row["n_Sequence"].ToString());
				}
				if(row["n_FeeID"]!=null && row["n_FeeID"].ToString()!="")
				{
					model.n_FeeID=int.Parse(row["n_FeeID"].ToString());
				}
				if(row["n_FeeCodeID"]!=null && row["n_FeeCodeID"].ToString()!="")
				{
					model.n_FeeCodeID=int.Parse(row["n_FeeCodeID"].ToString());
				}
				if(row["n_AttrFeeTaxRate"]!=null && row["n_AttrFeeTaxRate"].ToString()!="")
				{
					model.n_AttrFeeTaxRate=decimal.Parse(row["n_AttrFeeTaxRate"].ToString());
				}
				if(row["n_OFeeTaxRate"]!=null && row["n_OFeeTaxRate"].ToString()!="")
				{
					model.n_OFeeTaxRate=decimal.Parse(row["n_OFeeTaxRate"].ToString());
				}
				if(row["n_DisbFeeTaxRate"]!=null && row["n_DisbFeeTaxRate"].ToString()!="")
				{
					model.n_DisbFeeTaxRate=decimal.Parse(row["n_DisbFeeTaxRate"].ToString());
				}
				if(row["n_OrginalAttrFee"]!=null && row["n_OrginalAttrFee"].ToString()!="")
				{
					model.n_OrginalAttrFee=decimal.Parse(row["n_OrginalAttrFee"].ToString());
				}
				if(row["n_OrignalOtherFee"]!=null && row["n_OrignalOtherFee"].ToString()!="")
				{
					model.n_OrignalOtherFee=decimal.Parse(row["n_OrignalOtherFee"].ToString());
				}
				if(row["n_DiscountAttrFeeRate"]!=null && row["n_DiscountAttrFeeRate"].ToString()!="")
				{
					model.n_DiscountAttrFeeRate=decimal.Parse(row["n_DiscountAttrFeeRate"].ToString());
				}
				if(row["n_DiscountOtherFeeRate"]!=null && row["n_DiscountOtherFeeRate"].ToString()!="")
				{
					model.n_DiscountOtherFeeRate=decimal.Parse(row["n_DiscountOtherFeeRate"].ToString());
				}
				if(row["n_PreferentialPolicyID"]!=null && row["n_PreferentialPolicyID"].ToString()!="")
				{
					model.n_PreferentialPolicyID=int.Parse(row["n_PreferentialPolicyID"].ToString());
				}
				if(row["n_moreUnitCount"]!=null && row["n_moreUnitCount"].ToString()!="")
				{
					model.n_moreUnitCount=decimal.Parse(row["n_moreUnitCount"].ToString());
				}
				if(row["s_FeeNotes"]!=null)
				{
					model.s_FeeNotes=row["s_FeeNotes"].ToString();
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
			strSql.Append("select n_ID,n_BillID,s_FeeName,s_Type,n_SourceID,n_OFee,n_AttrFee,n_OtherFee,s_Status,n_Sequence,n_FeeID,n_FeeCodeID,n_AttrFeeTaxRate,n_OFeeTaxRate,n_DisbFeeTaxRate,n_OrginalAttrFee,n_OrignalOtherFee,n_DiscountAttrFeeRate,n_DiscountOtherFeeRate,n_PreferentialPolicyID,n_moreUnitCount,s_FeeNotes ");
			strSql.Append(" FROM T_BillList ");
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
			strSql.Append(" n_ID,n_BillID,s_FeeName,s_Type,n_SourceID,n_OFee,n_AttrFee,n_OtherFee,s_Status,n_Sequence,n_FeeID,n_FeeCodeID,n_AttrFeeTaxRate,n_OFeeTaxRate,n_DisbFeeTaxRate,n_OrginalAttrFee,n_OrignalOtherFee,n_DiscountAttrFeeRate,n_DiscountOtherFeeRate,n_PreferentialPolicyID,n_moreUnitCount,s_FeeNotes ");
			strSql.Append(" FROM T_BillList ");
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
			strSql.Append("select count(1) FROM T_BillList ");
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
			strSql.Append(")AS Row, T.*  from T_BillList T ");
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
			parameters[0].Value = "T_BillList";
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

