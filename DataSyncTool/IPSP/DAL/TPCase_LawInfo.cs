/**  版本信息模板在安装目录下，可自行修改。
* TPCase_LawInfo.cs
*
* 功 能： N/A
* 类 名： TPCase_LawInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:25   N/A    初版
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
	/// 数据访问类:TPCase_LawInfo
	/// </summary>
	public partial class TPCase_LawInfo
	{
		public TPCase_LawInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_ID", "TPCase_LawInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TPCase_LawInfo");
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
		public int Add(IPSP.Model.TPCase_LawInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TPCase_LawInfo(");
			strSql.Append("s_AppNo,dt_AppDate,n_ClaimCount,s_PubNo,dt_PubDate,s_PubVolume,s_PubGazette,s_PubClass1,s_PubClass2,dt_SubstantiveExamDate,s_IssuedPubNo,dt_IssuedPubDate,s_IssuedPubVolume,s_IssuedPubGazette,s_IssuedPubClass1,s_IssuedPubClass2,s_CertfNo,dt_CertfDate,s_PCTAppNo,dt_PctAppDate,s_PCTPubNo,dt_PctPubDate,dt_PctInNationDate,n_PCTPubLan,n_ManualPages,n_ProtectionDuration,dt_ExpirationDate,s_PCTSearchBureau,dt_FirstCheckDate,s_ReviewNo)");
			strSql.Append(" values (");
			strSql.Append("@s_AppNo,@dt_AppDate,@n_ClaimCount,@s_PubNo,@dt_PubDate,@s_PubVolume,@s_PubGazette,@s_PubClass1,@s_PubClass2,@dt_SubstantiveExamDate,@s_IssuedPubNo,@dt_IssuedPubDate,@s_IssuedPubVolume,@s_IssuedPubGazette,@s_IssuedPubClass1,@s_IssuedPubClass2,@s_CertfNo,@dt_CertfDate,@s_PCTAppNo,@dt_PctAppDate,@s_PCTPubNo,@dt_PctPubDate,@dt_PctInNationDate,@n_PCTPubLan,@n_ManualPages,@n_ProtectionDuration,@dt_ExpirationDate,@s_PCTSearchBureau,@dt_FirstCheckDate,@s_ReviewNo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@s_AppNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_AppDate", SqlDbType.DateTime),
					new SqlParameter("@n_ClaimCount", SqlDbType.Int,4),
					new SqlParameter("@s_PubNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_PubDate", SqlDbType.DateTime),
					new SqlParameter("@s_PubVolume", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PubGazette", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PubClass1", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PubClass2", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_SubstantiveExamDate", SqlDbType.DateTime),
					new SqlParameter("@s_IssuedPubNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_IssuedPubDate", SqlDbType.DateTime),
					new SqlParameter("@s_IssuedPubVolume", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IssuedPubGazette", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IssuedPubClass1", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IssuedPubClass2", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CertfNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CertfDate", SqlDbType.DateTime),
					new SqlParameter("@s_PCTAppNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_PctAppDate", SqlDbType.DateTime),
					new SqlParameter("@s_PCTPubNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_PctPubDate", SqlDbType.DateTime),
					new SqlParameter("@dt_PctInNationDate", SqlDbType.DateTime),
					new SqlParameter("@n_PCTPubLan", SqlDbType.Int,4),
					new SqlParameter("@n_ManualPages", SqlDbType.Int,4),
					new SqlParameter("@n_ProtectionDuration", SqlDbType.Decimal,9),
					new SqlParameter("@dt_ExpirationDate", SqlDbType.DateTime),
					new SqlParameter("@s_PCTSearchBureau", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_FirstCheckDate", SqlDbType.DateTime),
					new SqlParameter("@s_ReviewNo", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.s_AppNo;
			parameters[1].Value = model.dt_AppDate;
			parameters[2].Value = model.n_ClaimCount;
			parameters[3].Value = model.s_PubNo;
			parameters[4].Value = model.dt_PubDate;
			parameters[5].Value = model.s_PubVolume;
			parameters[6].Value = model.s_PubGazette;
			parameters[7].Value = model.s_PubClass1;
			parameters[8].Value = model.s_PubClass2;
			parameters[9].Value = model.dt_SubstantiveExamDate;
			parameters[10].Value = model.s_IssuedPubNo;
			parameters[11].Value = model.dt_IssuedPubDate;
			parameters[12].Value = model.s_IssuedPubVolume;
			parameters[13].Value = model.s_IssuedPubGazette;
			parameters[14].Value = model.s_IssuedPubClass1;
			parameters[15].Value = model.s_IssuedPubClass2;
			parameters[16].Value = model.s_CertfNo;
			parameters[17].Value = model.dt_CertfDate;
			parameters[18].Value = model.s_PCTAppNo;
			parameters[19].Value = model.dt_PctAppDate;
			parameters[20].Value = model.s_PCTPubNo;
			parameters[21].Value = model.dt_PctPubDate;
			parameters[22].Value = model.dt_PctInNationDate;
			parameters[23].Value = model.n_PCTPubLan;
			parameters[24].Value = model.n_ManualPages;
			parameters[25].Value = model.n_ProtectionDuration;
			parameters[26].Value = model.dt_ExpirationDate;
			parameters[27].Value = model.s_PCTSearchBureau;
			parameters[28].Value = model.dt_FirstCheckDate;
			parameters[29].Value = model.s_ReviewNo;

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
		public bool Update(IPSP.Model.TPCase_LawInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TPCase_LawInfo set ");
			strSql.Append("s_AppNo=@s_AppNo,");
			strSql.Append("dt_AppDate=@dt_AppDate,");
			strSql.Append("n_ClaimCount=@n_ClaimCount,");
			strSql.Append("s_PubNo=@s_PubNo,");
			strSql.Append("dt_PubDate=@dt_PubDate,");
			strSql.Append("s_PubVolume=@s_PubVolume,");
			strSql.Append("s_PubGazette=@s_PubGazette,");
			strSql.Append("s_PubClass1=@s_PubClass1,");
			strSql.Append("s_PubClass2=@s_PubClass2,");
			strSql.Append("dt_SubstantiveExamDate=@dt_SubstantiveExamDate,");
			strSql.Append("s_IssuedPubNo=@s_IssuedPubNo,");
			strSql.Append("dt_IssuedPubDate=@dt_IssuedPubDate,");
			strSql.Append("s_IssuedPubVolume=@s_IssuedPubVolume,");
			strSql.Append("s_IssuedPubGazette=@s_IssuedPubGazette,");
			strSql.Append("s_IssuedPubClass1=@s_IssuedPubClass1,");
			strSql.Append("s_IssuedPubClass2=@s_IssuedPubClass2,");
			strSql.Append("s_CertfNo=@s_CertfNo,");
			strSql.Append("dt_CertfDate=@dt_CertfDate,");
			strSql.Append("s_PCTAppNo=@s_PCTAppNo,");
			strSql.Append("dt_PctAppDate=@dt_PctAppDate,");
			strSql.Append("s_PCTPubNo=@s_PCTPubNo,");
			strSql.Append("dt_PctPubDate=@dt_PctPubDate,");
			strSql.Append("dt_PctInNationDate=@dt_PctInNationDate,");
			strSql.Append("n_PCTPubLan=@n_PCTPubLan,");
			strSql.Append("n_ManualPages=@n_ManualPages,");
			strSql.Append("n_ProtectionDuration=@n_ProtectionDuration,");
			strSql.Append("dt_ExpirationDate=@dt_ExpirationDate,");
			strSql.Append("s_PCTSearchBureau=@s_PCTSearchBureau,");
			strSql.Append("dt_FirstCheckDate=@dt_FirstCheckDate,");
			strSql.Append("s_ReviewNo=@s_ReviewNo");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@s_AppNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_AppDate", SqlDbType.DateTime),
					new SqlParameter("@n_ClaimCount", SqlDbType.Int,4),
					new SqlParameter("@s_PubNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_PubDate", SqlDbType.DateTime),
					new SqlParameter("@s_PubVolume", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PubGazette", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PubClass1", SqlDbType.NVarChar,50),
					new SqlParameter("@s_PubClass2", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_SubstantiveExamDate", SqlDbType.DateTime),
					new SqlParameter("@s_IssuedPubNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_IssuedPubDate", SqlDbType.DateTime),
					new SqlParameter("@s_IssuedPubVolume", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IssuedPubGazette", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IssuedPubClass1", SqlDbType.NVarChar,50),
					new SqlParameter("@s_IssuedPubClass2", SqlDbType.NVarChar,50),
					new SqlParameter("@s_CertfNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_CertfDate", SqlDbType.DateTime),
					new SqlParameter("@s_PCTAppNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_PctAppDate", SqlDbType.DateTime),
					new SqlParameter("@s_PCTPubNo", SqlDbType.NVarChar,50),
					new SqlParameter("@dt_PctPubDate", SqlDbType.DateTime),
					new SqlParameter("@dt_PctInNationDate", SqlDbType.DateTime),
					new SqlParameter("@n_PCTPubLan", SqlDbType.Int,4),
					new SqlParameter("@n_ManualPages", SqlDbType.Int,4),
					new SqlParameter("@n_ProtectionDuration", SqlDbType.Decimal,9),
					new SqlParameter("@dt_ExpirationDate", SqlDbType.DateTime),
					new SqlParameter("@s_PCTSearchBureau", SqlDbType.NVarChar,200),
					new SqlParameter("@dt_FirstCheckDate", SqlDbType.DateTime),
					new SqlParameter("@s_ReviewNo", SqlDbType.NVarChar,50),
					new SqlParameter("@n_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.s_AppNo;
			parameters[1].Value = model.dt_AppDate;
			parameters[2].Value = model.n_ClaimCount;
			parameters[3].Value = model.s_PubNo;
			parameters[4].Value = model.dt_PubDate;
			parameters[5].Value = model.s_PubVolume;
			parameters[6].Value = model.s_PubGazette;
			parameters[7].Value = model.s_PubClass1;
			parameters[8].Value = model.s_PubClass2;
			parameters[9].Value = model.dt_SubstantiveExamDate;
			parameters[10].Value = model.s_IssuedPubNo;
			parameters[11].Value = model.dt_IssuedPubDate;
			parameters[12].Value = model.s_IssuedPubVolume;
			parameters[13].Value = model.s_IssuedPubGazette;
			parameters[14].Value = model.s_IssuedPubClass1;
			parameters[15].Value = model.s_IssuedPubClass2;
			parameters[16].Value = model.s_CertfNo;
			parameters[17].Value = model.dt_CertfDate;
			parameters[18].Value = model.s_PCTAppNo;
			parameters[19].Value = model.dt_PctAppDate;
			parameters[20].Value = model.s_PCTPubNo;
			parameters[21].Value = model.dt_PctPubDate;
			parameters[22].Value = model.dt_PctInNationDate;
			parameters[23].Value = model.n_PCTPubLan;
			parameters[24].Value = model.n_ManualPages;
			parameters[25].Value = model.n_ProtectionDuration;
			parameters[26].Value = model.dt_ExpirationDate;
			parameters[27].Value = model.s_PCTSearchBureau;
			parameters[28].Value = model.dt_FirstCheckDate;
			parameters[29].Value = model.s_ReviewNo;
			parameters[30].Value = model.n_ID;

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
			strSql.Append("delete from TPCase_LawInfo ");
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
			strSql.Append("delete from TPCase_LawInfo ");
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
		public IPSP.Model.TPCase_LawInfo GetModel(int n_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_ID,s_AppNo,dt_AppDate,n_ClaimCount,s_PubNo,dt_PubDate,s_PubVolume,s_PubGazette,s_PubClass1,s_PubClass2,dt_SubstantiveExamDate,s_IssuedPubNo,dt_IssuedPubDate,s_IssuedPubVolume,s_IssuedPubGazette,s_IssuedPubClass1,s_IssuedPubClass2,s_CertfNo,dt_CertfDate,s_PCTAppNo,dt_PctAppDate,s_PCTPubNo,dt_PctPubDate,dt_PctInNationDate,n_PCTPubLan,n_ManualPages,n_ProtectionDuration,dt_ExpirationDate,s_PCTSearchBureau,dt_FirstCheckDate,s_ReviewNo from TPCase_LawInfo ");
			strSql.Append(" where n_ID=@n_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@n_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = n_ID;

			IPSP.Model.TPCase_LawInfo model=new IPSP.Model.TPCase_LawInfo();
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
		public IPSP.Model.TPCase_LawInfo DataRowToModel(DataRow row)
		{
			IPSP.Model.TPCase_LawInfo model=new IPSP.Model.TPCase_LawInfo();
			if (row != null)
			{
				if(row["n_ID"]!=null && row["n_ID"].ToString()!="")
				{
					model.n_ID=int.Parse(row["n_ID"].ToString());
				}
				if(row["s_AppNo"]!=null)
				{
					model.s_AppNo=row["s_AppNo"].ToString();
				}
				if(row["dt_AppDate"]!=null && row["dt_AppDate"].ToString()!="")
				{
					model.dt_AppDate=DateTime.Parse(row["dt_AppDate"].ToString());
				}
				if(row["n_ClaimCount"]!=null && row["n_ClaimCount"].ToString()!="")
				{
					model.n_ClaimCount=int.Parse(row["n_ClaimCount"].ToString());
				}
				if(row["s_PubNo"]!=null)
				{
					model.s_PubNo=row["s_PubNo"].ToString();
				}
				if(row["dt_PubDate"]!=null && row["dt_PubDate"].ToString()!="")
				{
					model.dt_PubDate=DateTime.Parse(row["dt_PubDate"].ToString());
				}
				if(row["s_PubVolume"]!=null)
				{
					model.s_PubVolume=row["s_PubVolume"].ToString();
				}
				if(row["s_PubGazette"]!=null)
				{
					model.s_PubGazette=row["s_PubGazette"].ToString();
				}
				if(row["s_PubClass1"]!=null)
				{
					model.s_PubClass1=row["s_PubClass1"].ToString();
				}
				if(row["s_PubClass2"]!=null)
				{
					model.s_PubClass2=row["s_PubClass2"].ToString();
				}
				if(row["dt_SubstantiveExamDate"]!=null && row["dt_SubstantiveExamDate"].ToString()!="")
				{
					model.dt_SubstantiveExamDate=DateTime.Parse(row["dt_SubstantiveExamDate"].ToString());
				}
				if(row["s_IssuedPubNo"]!=null)
				{
					model.s_IssuedPubNo=row["s_IssuedPubNo"].ToString();
				}
				if(row["dt_IssuedPubDate"]!=null && row["dt_IssuedPubDate"].ToString()!="")
				{
					model.dt_IssuedPubDate=DateTime.Parse(row["dt_IssuedPubDate"].ToString());
				}
				if(row["s_IssuedPubVolume"]!=null)
				{
					model.s_IssuedPubVolume=row["s_IssuedPubVolume"].ToString();
				}
				if(row["s_IssuedPubGazette"]!=null)
				{
					model.s_IssuedPubGazette=row["s_IssuedPubGazette"].ToString();
				}
				if(row["s_IssuedPubClass1"]!=null)
				{
					model.s_IssuedPubClass1=row["s_IssuedPubClass1"].ToString();
				}
				if(row["s_IssuedPubClass2"]!=null)
				{
					model.s_IssuedPubClass2=row["s_IssuedPubClass2"].ToString();
				}
				if(row["s_CertfNo"]!=null)
				{
					model.s_CertfNo=row["s_CertfNo"].ToString();
				}
				if(row["dt_CertfDate"]!=null && row["dt_CertfDate"].ToString()!="")
				{
					model.dt_CertfDate=DateTime.Parse(row["dt_CertfDate"].ToString());
				}
				if(row["s_PCTAppNo"]!=null)
				{
					model.s_PCTAppNo=row["s_PCTAppNo"].ToString();
				}
				if(row["dt_PctAppDate"]!=null && row["dt_PctAppDate"].ToString()!="")
				{
					model.dt_PctAppDate=DateTime.Parse(row["dt_PctAppDate"].ToString());
				}
				if(row["s_PCTPubNo"]!=null)
				{
					model.s_PCTPubNo=row["s_PCTPubNo"].ToString();
				}
				if(row["dt_PctPubDate"]!=null && row["dt_PctPubDate"].ToString()!="")
				{
					model.dt_PctPubDate=DateTime.Parse(row["dt_PctPubDate"].ToString());
				}
				if(row["dt_PctInNationDate"]!=null && row["dt_PctInNationDate"].ToString()!="")
				{
					model.dt_PctInNationDate=DateTime.Parse(row["dt_PctInNationDate"].ToString());
				}
				if(row["n_PCTPubLan"]!=null && row["n_PCTPubLan"].ToString()!="")
				{
					model.n_PCTPubLan=int.Parse(row["n_PCTPubLan"].ToString());
				}
				if(row["n_ManualPages"]!=null && row["n_ManualPages"].ToString()!="")
				{
					model.n_ManualPages=int.Parse(row["n_ManualPages"].ToString());
				}
				if(row["n_ProtectionDuration"]!=null && row["n_ProtectionDuration"].ToString()!="")
				{
					model.n_ProtectionDuration=decimal.Parse(row["n_ProtectionDuration"].ToString());
				}
				if(row["dt_ExpirationDate"]!=null && row["dt_ExpirationDate"].ToString()!="")
				{
					model.dt_ExpirationDate=DateTime.Parse(row["dt_ExpirationDate"].ToString());
				}
				if(row["s_PCTSearchBureau"]!=null)
				{
					model.s_PCTSearchBureau=row["s_PCTSearchBureau"].ToString();
				}
				if(row["dt_FirstCheckDate"]!=null && row["dt_FirstCheckDate"].ToString()!="")
				{
					model.dt_FirstCheckDate=DateTime.Parse(row["dt_FirstCheckDate"].ToString());
				}
				if(row["s_ReviewNo"]!=null)
				{
					model.s_ReviewNo=row["s_ReviewNo"].ToString();
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
			strSql.Append("select n_ID,s_AppNo,dt_AppDate,n_ClaimCount,s_PubNo,dt_PubDate,s_PubVolume,s_PubGazette,s_PubClass1,s_PubClass2,dt_SubstantiveExamDate,s_IssuedPubNo,dt_IssuedPubDate,s_IssuedPubVolume,s_IssuedPubGazette,s_IssuedPubClass1,s_IssuedPubClass2,s_CertfNo,dt_CertfDate,s_PCTAppNo,dt_PctAppDate,s_PCTPubNo,dt_PctPubDate,dt_PctInNationDate,n_PCTPubLan,n_ManualPages,n_ProtectionDuration,dt_ExpirationDate,s_PCTSearchBureau,dt_FirstCheckDate,s_ReviewNo ");
			strSql.Append(" FROM TPCase_LawInfo ");
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
			strSql.Append(" n_ID,s_AppNo,dt_AppDate,n_ClaimCount,s_PubNo,dt_PubDate,s_PubVolume,s_PubGazette,s_PubClass1,s_PubClass2,dt_SubstantiveExamDate,s_IssuedPubNo,dt_IssuedPubDate,s_IssuedPubVolume,s_IssuedPubGazette,s_IssuedPubClass1,s_IssuedPubClass2,s_CertfNo,dt_CertfDate,s_PCTAppNo,dt_PctAppDate,s_PCTPubNo,dt_PctPubDate,dt_PctInNationDate,n_PCTPubLan,n_ManualPages,n_ProtectionDuration,dt_ExpirationDate,s_PCTSearchBureau,dt_FirstCheckDate,s_ReviewNo ");
			strSql.Append(" FROM TPCase_LawInfo ");
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
			strSql.Append("select count(1) FROM TPCase_LawInfo ");
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
			strSql.Append(")AS Row, T.*  from TPCase_LawInfo T ");
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
			parameters[0].Value = "TPCase_LawInfo";
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

