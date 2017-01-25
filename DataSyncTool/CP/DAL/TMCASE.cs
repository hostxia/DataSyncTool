using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:TMCASE
	/// </summary>
	public partial class TMCASE
	{
		public TMCASE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string OURNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TMCASE");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,18)			};
			parameters[0].Value = OURNO;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.TMCASE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TMCASE(");
			strSql.Append("WITHDREW,CLIENT,CLIENT_NUMBER,RECEIVED,FILING_DATE,PRIORITY,CERT_FILED,APPLICATION_NO,AM_RCVD,AM_FILED,AM_REFUSAL_RCVD,AM_RW_CON_NATURE,OA_RCVD,OA_FILED,OA_REFUSAL_RCVD,OA_REFUSAL_EXT,OA_RW_FILED,OA_RW_CON_RCVD,OA_RW_CON_NATURE,PRE_PUBLISHED,OP_RCVD,OP_FILED,OP_CON_RCVD,OP_CON_NATURE,OP_RW_FILED,OP_RW_CON_RCVD,OP_RW_CON_NATURE,CERTIFICATION,DISP_RCVD,DISP_FILED,DISP_CON_RCVD,DISP_CON_NATURE,UNDER_LITIGATION,AGENT,OURNO,OP_CON_EXT,CLIENT2,CLIENT3,CLIENT4,CLIENT5,APPL_CODE1,APPL_CODE2,APPL_CODE3,DIARY,STATUSMARKS,BASICINFO)");
			strSql.Append(" values (");
			strSql.Append(":WITHDREW,:CLIENT,:CLIENT_NUMBER,:RECEIVED,:FILING_DATE,:PRIORITY,:CERT_FILED,:APPLICATION_NO,:AM_RCVD,:AM_FILED,:AM_REFUSAL_RCVD,:AM_RW_CON_NATURE,:OA_RCVD,:OA_FILED,:OA_REFUSAL_RCVD,:OA_REFUSAL_EXT,:OA_RW_FILED,:OA_RW_CON_RCVD,:OA_RW_CON_NATURE,:PRE_PUBLISHED,:OP_RCVD,:OP_FILED,:OP_CON_RCVD,:OP_CON_NATURE,:OP_RW_FILED,:OP_RW_CON_RCVD,:OP_RW_CON_NATURE,:CERTIFICATION,:DISP_RCVD,:DISP_FILED,:DISP_CON_RCVD,:DISP_CON_NATURE,:UNDER_LITIGATION,:AGENT,:OURNO,:OP_CON_EXT,:CLIENT2,:CLIENT3,:CLIENT4,:CLIENT5,:APPL_CODE1,:APPL_CODE2,:APPL_CODE3,:DIARY,:STATUSMARKS,:BASICINFO)");
			OracleParameter[] parameters = {
					new OracleParameter(":WITHDREW", OracleType.Char,1),
					new OracleParameter(":CLIENT", OracleType.Char,4),
					new OracleParameter(":CLIENT_NUMBER", OracleType.VarChar,30),
					new OracleParameter(":RECEIVED", OracleType.DateTime),
					new OracleParameter(":FILING_DATE", OracleType.DateTime),
					new OracleParameter(":PRIORITY", OracleType.DateTime),
					new OracleParameter(":CERT_FILED", OracleType.Char,1),
					new OracleParameter(":APPLICATION_NO", OracleType.VarChar,15),
					new OracleParameter(":AM_RCVD", OracleType.DateTime),
					new OracleParameter(":AM_FILED", OracleType.DateTime),
					new OracleParameter(":AM_REFUSAL_RCVD", OracleType.DateTime),
					new OracleParameter(":AM_RW_CON_NATURE", OracleType.Char,1),
					new OracleParameter(":OA_RCVD", OracleType.DateTime),
					new OracleParameter(":OA_FILED", OracleType.DateTime),
					new OracleParameter(":OA_REFUSAL_RCVD", OracleType.DateTime),
					new OracleParameter(":OA_REFUSAL_EXT", OracleType.Char,1),
					new OracleParameter(":OA_RW_FILED", OracleType.DateTime),
					new OracleParameter(":OA_RW_CON_RCVD", OracleType.DateTime),
					new OracleParameter(":OA_RW_CON_NATURE", OracleType.Char,1),
					new OracleParameter(":PRE_PUBLISHED", OracleType.DateTime),
					new OracleParameter(":OP_RCVD", OracleType.DateTime),
					new OracleParameter(":OP_FILED", OracleType.DateTime),
					new OracleParameter(":OP_CON_RCVD", OracleType.DateTime),
					new OracleParameter(":OP_CON_NATURE", OracleType.Char,1),
					new OracleParameter(":OP_RW_FILED", OracleType.DateTime),
					new OracleParameter(":OP_RW_CON_RCVD", OracleType.DateTime),
					new OracleParameter(":OP_RW_CON_NATURE", OracleType.Char,1),
					new OracleParameter(":CERTIFICATION", OracleType.DateTime),
					new OracleParameter(":DISP_RCVD", OracleType.DateTime),
					new OracleParameter(":DISP_FILED", OracleType.DateTime),
					new OracleParameter(":DISP_CON_RCVD", OracleType.DateTime),
					new OracleParameter(":DISP_CON_NATURE", OracleType.Char,1),
					new OracleParameter(":UNDER_LITIGATION", OracleType.Char,1),
					new OracleParameter(":AGENT", OracleType.Char,3),
					new OracleParameter(":OURNO", OracleType.VarChar,18),
					new OracleParameter(":OP_CON_EXT", OracleType.Char,1),
					new OracleParameter(":CLIENT2", OracleType.Char,4),
					new OracleParameter(":CLIENT3", OracleType.Char,4),
					new OracleParameter(":CLIENT4", OracleType.Char,4),
					new OracleParameter(":CLIENT5", OracleType.Char,4),
					new OracleParameter(":APPL_CODE1", OracleType.Char,4),
					new OracleParameter(":APPL_CODE2", OracleType.Char,4),
					new OracleParameter(":APPL_CODE3", OracleType.Char,4),
					new OracleParameter(":DIARY", OracleType.VarChar,4000),
					new OracleParameter(":STATUSMARKS", OracleType.VarChar,20),
					new OracleParameter(":BASICINFO", OracleType.VarChar,500)};
			parameters[0].Value = model.WITHDREW;
			parameters[1].Value = model.CLIENT;
			parameters[2].Value = model.CLIENT_NUMBER;
			parameters[3].Value = model.RECEIVED;
			parameters[4].Value = model.FILING_DATE;
			parameters[5].Value = model.PRIORITY;
			parameters[6].Value = model.CERT_FILED;
			parameters[7].Value = model.APPLICATION_NO;
			parameters[8].Value = model.AM_RCVD;
			parameters[9].Value = model.AM_FILED;
			parameters[10].Value = model.AM_REFUSAL_RCVD;
			parameters[11].Value = model.AM_RW_CON_NATURE;
			parameters[12].Value = model.OA_RCVD;
			parameters[13].Value = model.OA_FILED;
			parameters[14].Value = model.OA_REFUSAL_RCVD;
			parameters[15].Value = model.OA_REFUSAL_EXT;
			parameters[16].Value = model.OA_RW_FILED;
			parameters[17].Value = model.OA_RW_CON_RCVD;
			parameters[18].Value = model.OA_RW_CON_NATURE;
			parameters[19].Value = model.PRE_PUBLISHED;
			parameters[20].Value = model.OP_RCVD;
			parameters[21].Value = model.OP_FILED;
			parameters[22].Value = model.OP_CON_RCVD;
			parameters[23].Value = model.OP_CON_NATURE;
			parameters[24].Value = model.OP_RW_FILED;
			parameters[25].Value = model.OP_RW_CON_RCVD;
			parameters[26].Value = model.OP_RW_CON_NATURE;
			parameters[27].Value = model.CERTIFICATION;
			parameters[28].Value = model.DISP_RCVD;
			parameters[29].Value = model.DISP_FILED;
			parameters[30].Value = model.DISP_CON_RCVD;
			parameters[31].Value = model.DISP_CON_NATURE;
			parameters[32].Value = model.UNDER_LITIGATION;
			parameters[33].Value = model.AGENT;
			parameters[34].Value = model.OURNO;
			parameters[35].Value = model.OP_CON_EXT;
			parameters[36].Value = model.CLIENT2;
			parameters[37].Value = model.CLIENT3;
			parameters[38].Value = model.CLIENT4;
			parameters[39].Value = model.CLIENT5;
			parameters[40].Value = model.APPL_CODE1;
			parameters[41].Value = model.APPL_CODE2;
			parameters[42].Value = model.APPL_CODE3;
			parameters[43].Value = model.DIARY;
			parameters[44].Value = model.STATUSMARKS;
			parameters[45].Value = model.BASICINFO;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Model.TMCASE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TMCASE set ");
			strSql.Append("WITHDREW=:WITHDREW,");
			strSql.Append("CLIENT=:CLIENT,");
			strSql.Append("CLIENT_NUMBER=:CLIENT_NUMBER,");
			strSql.Append("RECEIVED=:RECEIVED,");
			strSql.Append("FILING_DATE=:FILING_DATE,");
			strSql.Append("PRIORITY=:PRIORITY,");
			strSql.Append("CERT_FILED=:CERT_FILED,");
			strSql.Append("APPLICATION_NO=:APPLICATION_NO,");
			strSql.Append("AM_RCVD=:AM_RCVD,");
			strSql.Append("AM_FILED=:AM_FILED,");
			strSql.Append("AM_REFUSAL_RCVD=:AM_REFUSAL_RCVD,");
			strSql.Append("AM_RW_CON_NATURE=:AM_RW_CON_NATURE,");
			strSql.Append("OA_RCVD=:OA_RCVD,");
			strSql.Append("OA_FILED=:OA_FILED,");
			strSql.Append("OA_REFUSAL_RCVD=:OA_REFUSAL_RCVD,");
			strSql.Append("OA_REFUSAL_EXT=:OA_REFUSAL_EXT,");
			strSql.Append("OA_RW_FILED=:OA_RW_FILED,");
			strSql.Append("OA_RW_CON_RCVD=:OA_RW_CON_RCVD,");
			strSql.Append("OA_RW_CON_NATURE=:OA_RW_CON_NATURE,");
			strSql.Append("PRE_PUBLISHED=:PRE_PUBLISHED,");
			strSql.Append("OP_RCVD=:OP_RCVD,");
			strSql.Append("OP_FILED=:OP_FILED,");
			strSql.Append("OP_CON_RCVD=:OP_CON_RCVD,");
			strSql.Append("OP_CON_NATURE=:OP_CON_NATURE,");
			strSql.Append("OP_RW_FILED=:OP_RW_FILED,");
			strSql.Append("OP_RW_CON_RCVD=:OP_RW_CON_RCVD,");
			strSql.Append("OP_RW_CON_NATURE=:OP_RW_CON_NATURE,");
			strSql.Append("CERTIFICATION=:CERTIFICATION,");
			strSql.Append("DISP_RCVD=:DISP_RCVD,");
			strSql.Append("DISP_FILED=:DISP_FILED,");
			strSql.Append("DISP_CON_RCVD=:DISP_CON_RCVD,");
			strSql.Append("DISP_CON_NATURE=:DISP_CON_NATURE,");
			strSql.Append("UNDER_LITIGATION=:UNDER_LITIGATION,");
			strSql.Append("AGENT=:AGENT,");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("OP_CON_EXT=:OP_CON_EXT,");
			strSql.Append("CLIENT2=:CLIENT2,");
			strSql.Append("CLIENT3=:CLIENT3,");
			strSql.Append("CLIENT4=:CLIENT4,");
			strSql.Append("CLIENT5=:CLIENT5,");
			strSql.Append("APPL_CODE1=:APPL_CODE1,");
			strSql.Append("APPL_CODE2=:APPL_CODE2,");
			strSql.Append("APPL_CODE3=:APPL_CODE3,");
			strSql.Append("DIARY=:DIARY,");
			strSql.Append("STATUSMARKS=:STATUSMARKS,");
			strSql.Append("BASICINFO=:BASICINFO");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":WITHDREW", OracleType.Char,1),
					new OracleParameter(":CLIENT", OracleType.Char,4),
					new OracleParameter(":CLIENT_NUMBER", OracleType.VarChar,30),
					new OracleParameter(":RECEIVED", OracleType.DateTime),
					new OracleParameter(":FILING_DATE", OracleType.DateTime),
					new OracleParameter(":PRIORITY", OracleType.DateTime),
					new OracleParameter(":CERT_FILED", OracleType.Char,1),
					new OracleParameter(":APPLICATION_NO", OracleType.VarChar,15),
					new OracleParameter(":AM_RCVD", OracleType.DateTime),
					new OracleParameter(":AM_FILED", OracleType.DateTime),
					new OracleParameter(":AM_REFUSAL_RCVD", OracleType.DateTime),
					new OracleParameter(":AM_RW_CON_NATURE", OracleType.Char,1),
					new OracleParameter(":OA_RCVD", OracleType.DateTime),
					new OracleParameter(":OA_FILED", OracleType.DateTime),
					new OracleParameter(":OA_REFUSAL_RCVD", OracleType.DateTime),
					new OracleParameter(":OA_REFUSAL_EXT", OracleType.Char,1),
					new OracleParameter(":OA_RW_FILED", OracleType.DateTime),
					new OracleParameter(":OA_RW_CON_RCVD", OracleType.DateTime),
					new OracleParameter(":OA_RW_CON_NATURE", OracleType.Char,1),
					new OracleParameter(":PRE_PUBLISHED", OracleType.DateTime),
					new OracleParameter(":OP_RCVD", OracleType.DateTime),
					new OracleParameter(":OP_FILED", OracleType.DateTime),
					new OracleParameter(":OP_CON_RCVD", OracleType.DateTime),
					new OracleParameter(":OP_CON_NATURE", OracleType.Char,1),
					new OracleParameter(":OP_RW_FILED", OracleType.DateTime),
					new OracleParameter(":OP_RW_CON_RCVD", OracleType.DateTime),
					new OracleParameter(":OP_RW_CON_NATURE", OracleType.Char,1),
					new OracleParameter(":CERTIFICATION", OracleType.DateTime),
					new OracleParameter(":DISP_RCVD", OracleType.DateTime),
					new OracleParameter(":DISP_FILED", OracleType.DateTime),
					new OracleParameter(":DISP_CON_RCVD", OracleType.DateTime),
					new OracleParameter(":DISP_CON_NATURE", OracleType.Char,1),
					new OracleParameter(":UNDER_LITIGATION", OracleType.Char,1),
					new OracleParameter(":AGENT", OracleType.Char,3),
					new OracleParameter(":OURNO", OracleType.VarChar,18),
					new OracleParameter(":OP_CON_EXT", OracleType.Char,1),
					new OracleParameter(":CLIENT2", OracleType.Char,4),
					new OracleParameter(":CLIENT3", OracleType.Char,4),
					new OracleParameter(":CLIENT4", OracleType.Char,4),
					new OracleParameter(":CLIENT5", OracleType.Char,4),
					new OracleParameter(":APPL_CODE1", OracleType.Char,4),
					new OracleParameter(":APPL_CODE2", OracleType.Char,4),
					new OracleParameter(":APPL_CODE3", OracleType.Char,4),
					new OracleParameter(":DIARY", OracleType.VarChar,4000),
					new OracleParameter(":STATUSMARKS", OracleType.VarChar,20),
					new OracleParameter(":BASICINFO", OracleType.VarChar,500)};
			parameters[0].Value = model.WITHDREW;
			parameters[1].Value = model.CLIENT;
			parameters[2].Value = model.CLIENT_NUMBER;
			parameters[3].Value = model.RECEIVED;
			parameters[4].Value = model.FILING_DATE;
			parameters[5].Value = model.PRIORITY;
			parameters[6].Value = model.CERT_FILED;
			parameters[7].Value = model.APPLICATION_NO;
			parameters[8].Value = model.AM_RCVD;
			parameters[9].Value = model.AM_FILED;
			parameters[10].Value = model.AM_REFUSAL_RCVD;
			parameters[11].Value = model.AM_RW_CON_NATURE;
			parameters[12].Value = model.OA_RCVD;
			parameters[13].Value = model.OA_FILED;
			parameters[14].Value = model.OA_REFUSAL_RCVD;
			parameters[15].Value = model.OA_REFUSAL_EXT;
			parameters[16].Value = model.OA_RW_FILED;
			parameters[17].Value = model.OA_RW_CON_RCVD;
			parameters[18].Value = model.OA_RW_CON_NATURE;
			parameters[19].Value = model.PRE_PUBLISHED;
			parameters[20].Value = model.OP_RCVD;
			parameters[21].Value = model.OP_FILED;
			parameters[22].Value = model.OP_CON_RCVD;
			parameters[23].Value = model.OP_CON_NATURE;
			parameters[24].Value = model.OP_RW_FILED;
			parameters[25].Value = model.OP_RW_CON_RCVD;
			parameters[26].Value = model.OP_RW_CON_NATURE;
			parameters[27].Value = model.CERTIFICATION;
			parameters[28].Value = model.DISP_RCVD;
			parameters[29].Value = model.DISP_FILED;
			parameters[30].Value = model.DISP_CON_RCVD;
			parameters[31].Value = model.DISP_CON_NATURE;
			parameters[32].Value = model.UNDER_LITIGATION;
			parameters[33].Value = model.AGENT;
			parameters[34].Value = model.OURNO;
			parameters[35].Value = model.OP_CON_EXT;
			parameters[36].Value = model.CLIENT2;
			parameters[37].Value = model.CLIENT3;
			parameters[38].Value = model.CLIENT4;
			parameters[39].Value = model.CLIENT5;
			parameters[40].Value = model.APPL_CODE1;
			parameters[41].Value = model.APPL_CODE2;
			parameters[42].Value = model.APPL_CODE3;
			parameters[43].Value = model.DIARY;
			parameters[44].Value = model.STATUSMARKS;
			parameters[45].Value = model.BASICINFO;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(string OURNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TMCASE ");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,18)			};
			parameters[0].Value = OURNO;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string OURNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TMCASE ");
			strSql.Append(" where OURNO in ("+OURNOlist + ")  ");
			int rows=DbHelperOra.ExecuteSql(strSql.ToString());
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
		public Model.TMCASE GetModel(string OURNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select WITHDREW,CLIENT,CLIENT_NUMBER,RECEIVED,FILING_DATE,PRIORITY,CERT_FILED,APPLICATION_NO,AM_RCVD,AM_FILED,AM_REFUSAL_RCVD,AM_RW_CON_NATURE,OA_RCVD,OA_FILED,OA_REFUSAL_RCVD,OA_REFUSAL_EXT,OA_RW_FILED,OA_RW_CON_RCVD,OA_RW_CON_NATURE,PRE_PUBLISHED,OP_RCVD,OP_FILED,OP_CON_RCVD,OP_CON_NATURE,OP_RW_FILED,OP_RW_CON_RCVD,OP_RW_CON_NATURE,CERTIFICATION,DISP_RCVD,DISP_FILED,DISP_CON_RCVD,DISP_CON_NATURE,UNDER_LITIGATION,AGENT,OURNO,OP_CON_EXT,CLIENT2,CLIENT3,CLIENT4,CLIENT5,APPL_CODE1,APPL_CODE2,APPL_CODE3,DIARY,STATUSMARKS,BASICINFO from TMCASE ");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,18)			};
			parameters[0].Value = OURNO;

			Model.TMCASE model=new Model.TMCASE();
			DataSet ds=DbHelperOra.Query(strSql.ToString(),parameters);
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
		public Model.TMCASE DataRowToModel(DataRow row)
		{
			Model.TMCASE model=new Model.TMCASE();
			if (row != null)
			{
				if(row["WITHDREW"]!=null)
				{
					model.WITHDREW=row["WITHDREW"].ToString();
				}
				if(row["CLIENT"]!=null)
				{
					model.CLIENT=row["CLIENT"].ToString();
				}
				if(row["CLIENT_NUMBER"]!=null)
				{
					model.CLIENT_NUMBER=row["CLIENT_NUMBER"].ToString();
				}
				if(row["RECEIVED"]!=null && row["RECEIVED"].ToString()!="")
				{
					model.RECEIVED=DateTime.Parse(row["RECEIVED"].ToString());
				}
				if(row["FILING_DATE"]!=null && row["FILING_DATE"].ToString()!="")
				{
					model.FILING_DATE=DateTime.Parse(row["FILING_DATE"].ToString());
				}
				if(row["PRIORITY"]!=null && row["PRIORITY"].ToString()!="")
				{
					model.PRIORITY=DateTime.Parse(row["PRIORITY"].ToString());
				}
				if(row["CERT_FILED"]!=null)
				{
					model.CERT_FILED=row["CERT_FILED"].ToString();
				}
				if(row["APPLICATION_NO"]!=null)
				{
					model.APPLICATION_NO=row["APPLICATION_NO"].ToString();
				}
				if(row["AM_RCVD"]!=null && row["AM_RCVD"].ToString()!="")
				{
					model.AM_RCVD=DateTime.Parse(row["AM_RCVD"].ToString());
				}
				if(row["AM_FILED"]!=null && row["AM_FILED"].ToString()!="")
				{
					model.AM_FILED=DateTime.Parse(row["AM_FILED"].ToString());
				}
				if(row["AM_REFUSAL_RCVD"]!=null && row["AM_REFUSAL_RCVD"].ToString()!="")
				{
					model.AM_REFUSAL_RCVD=DateTime.Parse(row["AM_REFUSAL_RCVD"].ToString());
				}
				if(row["AM_RW_CON_NATURE"]!=null)
				{
					model.AM_RW_CON_NATURE=row["AM_RW_CON_NATURE"].ToString();
				}
				if(row["OA_RCVD"]!=null && row["OA_RCVD"].ToString()!="")
				{
					model.OA_RCVD=DateTime.Parse(row["OA_RCVD"].ToString());
				}
				if(row["OA_FILED"]!=null && row["OA_FILED"].ToString()!="")
				{
					model.OA_FILED=DateTime.Parse(row["OA_FILED"].ToString());
				}
				if(row["OA_REFUSAL_RCVD"]!=null && row["OA_REFUSAL_RCVD"].ToString()!="")
				{
					model.OA_REFUSAL_RCVD=DateTime.Parse(row["OA_REFUSAL_RCVD"].ToString());
				}
				if(row["OA_REFUSAL_EXT"]!=null)
				{
					model.OA_REFUSAL_EXT=row["OA_REFUSAL_EXT"].ToString();
				}
				if(row["OA_RW_FILED"]!=null && row["OA_RW_FILED"].ToString()!="")
				{
					model.OA_RW_FILED=DateTime.Parse(row["OA_RW_FILED"].ToString());
				}
				if(row["OA_RW_CON_RCVD"]!=null && row["OA_RW_CON_RCVD"].ToString()!="")
				{
					model.OA_RW_CON_RCVD=DateTime.Parse(row["OA_RW_CON_RCVD"].ToString());
				}
				if(row["OA_RW_CON_NATURE"]!=null)
				{
					model.OA_RW_CON_NATURE=row["OA_RW_CON_NATURE"].ToString();
				}
				if(row["PRE_PUBLISHED"]!=null && row["PRE_PUBLISHED"].ToString()!="")
				{
					model.PRE_PUBLISHED=DateTime.Parse(row["PRE_PUBLISHED"].ToString());
				}
				if(row["OP_RCVD"]!=null && row["OP_RCVD"].ToString()!="")
				{
					model.OP_RCVD=DateTime.Parse(row["OP_RCVD"].ToString());
				}
				if(row["OP_FILED"]!=null && row["OP_FILED"].ToString()!="")
				{
					model.OP_FILED=DateTime.Parse(row["OP_FILED"].ToString());
				}
				if(row["OP_CON_RCVD"]!=null && row["OP_CON_RCVD"].ToString()!="")
				{
					model.OP_CON_RCVD=DateTime.Parse(row["OP_CON_RCVD"].ToString());
				}
				if(row["OP_CON_NATURE"]!=null)
				{
					model.OP_CON_NATURE=row["OP_CON_NATURE"].ToString();
				}
				if(row["OP_RW_FILED"]!=null && row["OP_RW_FILED"].ToString()!="")
				{
					model.OP_RW_FILED=DateTime.Parse(row["OP_RW_FILED"].ToString());
				}
				if(row["OP_RW_CON_RCVD"]!=null && row["OP_RW_CON_RCVD"].ToString()!="")
				{
					model.OP_RW_CON_RCVD=DateTime.Parse(row["OP_RW_CON_RCVD"].ToString());
				}
				if(row["OP_RW_CON_NATURE"]!=null)
				{
					model.OP_RW_CON_NATURE=row["OP_RW_CON_NATURE"].ToString();
				}
				if(row["CERTIFICATION"]!=null && row["CERTIFICATION"].ToString()!="")
				{
					model.CERTIFICATION=DateTime.Parse(row["CERTIFICATION"].ToString());
				}
				if(row["DISP_RCVD"]!=null && row["DISP_RCVD"].ToString()!="")
				{
					model.DISP_RCVD=DateTime.Parse(row["DISP_RCVD"].ToString());
				}
				if(row["DISP_FILED"]!=null && row["DISP_FILED"].ToString()!="")
				{
					model.DISP_FILED=DateTime.Parse(row["DISP_FILED"].ToString());
				}
				if(row["DISP_CON_RCVD"]!=null && row["DISP_CON_RCVD"].ToString()!="")
				{
					model.DISP_CON_RCVD=DateTime.Parse(row["DISP_CON_RCVD"].ToString());
				}
				if(row["DISP_CON_NATURE"]!=null)
				{
					model.DISP_CON_NATURE=row["DISP_CON_NATURE"].ToString();
				}
				if(row["UNDER_LITIGATION"]!=null)
				{
					model.UNDER_LITIGATION=row["UNDER_LITIGATION"].ToString();
				}
				if(row["AGENT"]!=null)
				{
					model.AGENT=row["AGENT"].ToString();
				}
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["OP_CON_EXT"]!=null)
				{
					model.OP_CON_EXT=row["OP_CON_EXT"].ToString();
				}
				if(row["CLIENT2"]!=null)
				{
					model.CLIENT2=row["CLIENT2"].ToString();
				}
				if(row["CLIENT3"]!=null)
				{
					model.CLIENT3=row["CLIENT3"].ToString();
				}
				if(row["CLIENT4"]!=null)
				{
					model.CLIENT4=row["CLIENT4"].ToString();
				}
				if(row["CLIENT5"]!=null)
				{
					model.CLIENT5=row["CLIENT5"].ToString();
				}
				if(row["APPL_CODE1"]!=null)
				{
					model.APPL_CODE1=row["APPL_CODE1"].ToString();
				}
				if(row["APPL_CODE2"]!=null)
				{
					model.APPL_CODE2=row["APPL_CODE2"].ToString();
				}
				if(row["APPL_CODE3"]!=null)
				{
					model.APPL_CODE3=row["APPL_CODE3"].ToString();
				}
				if(row["DIARY"]!=null)
				{
					model.DIARY=row["DIARY"].ToString();
				}
				if(row["STATUSMARKS"]!=null)
				{
					model.STATUSMARKS=row["STATUSMARKS"].ToString();
				}
				if(row["BASICINFO"]!=null)
				{
					model.BASICINFO=row["BASICINFO"].ToString();
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
			strSql.Append("select WITHDREW,CLIENT,CLIENT_NUMBER,RECEIVED,FILING_DATE,PRIORITY,CERT_FILED,APPLICATION_NO,AM_RCVD,AM_FILED,AM_REFUSAL_RCVD,AM_RW_CON_NATURE,OA_RCVD,OA_FILED,OA_REFUSAL_RCVD,OA_REFUSAL_EXT,OA_RW_FILED,OA_RW_CON_RCVD,OA_RW_CON_NATURE,PRE_PUBLISHED,OP_RCVD,OP_FILED,OP_CON_RCVD,OP_CON_NATURE,OP_RW_FILED,OP_RW_CON_RCVD,OP_RW_CON_NATURE,CERTIFICATION,DISP_RCVD,DISP_FILED,DISP_CON_RCVD,DISP_CON_NATURE,UNDER_LITIGATION,AGENT,OURNO,OP_CON_EXT,CLIENT2,CLIENT3,CLIENT4,CLIENT5,APPL_CODE1,APPL_CODE2,APPL_CODE3,DIARY,STATUSMARKS,BASICINFO ");
			strSql.Append(" FROM TMCASE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TMCASE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperOra.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.OURNO desc");
			}
			strSql.Append(")AS Row, T.*  from TMCASE T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOra.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OracleParameter[] parameters = {
					new OracleParameter(":tblName", OracleType.VarChar, 255),
					new OracleParameter(":fldName", OracleType.VarChar, 255),
					new OracleParameter(":PageSize", OracleType.Number),
					new OracleParameter(":PageIndex", OracleType.Number),
					new OracleParameter(":IsReCount", OracleType.Clob),
					new OracleParameter(":OrderType", OracleType.Clob),
					new OracleParameter(":strWhere", OracleType.VarChar,1000),
					};
			parameters[0].Value = "TMCASE";
			parameters[1].Value = "OURNO";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

