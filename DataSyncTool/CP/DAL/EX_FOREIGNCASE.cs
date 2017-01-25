using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using DataSyncTool.DBUtility;

//Please add references
namespace DataSyncTool.CP.DAL
{
	/// <summary>
	/// 数据访问类:EX_FOREIGNCASE
	/// </summary>
	public partial class EX_FOREIGNCASE
	{
		public EX_FOREIGNCASE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string OURNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from EX_FOREIGNCASE");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,24)			};
			parameters[0].Value = OURNO;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.EX_FOREIGNCASE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into EX_FOREIGNCASE(");
			strSql.Append("OURNO,TITLE,NATIVE_NO,CLIENT,CLIENT_NAME,CLIENT_ADDR,CLIENT_FAX,CLIENT_REF,YOUR_AGENCY_NO,YOUR_AGENCY_NAME,YOUR_AGENCY_ADDR,YOUR_AGENCY_FAX,YOUR_AGENCY_REF,APPL_CODE,APPLICANT,APPDATE,APPLICATION_NO,PRI_NUMBER1,PRI_DATE1,PRI_NUMBER2,PRI_DATE2,PRI_NUMBER3,PRI_DATE3,PRI_NUMBER4,PRI_DATE4,PRI_NUMBER5,PRI_DATE5,PRI_NUMBER6,PRI_DATE6,PRI_NUMBER7,PRI_DATE7,PRI_NUMBER8,PRI_DATE8,PRI_NUMBER9,PRI_DATE9,COMMENTS,DEADLINE1,DL_DATE1,DL_RESP_DATE1,COMMENTS1,DEADLINE2,DL_DATE2,DL_RESP_DATE2,COMMENTS2,DEADLINE3,DL_DATE3,DL_RESP_DATE3,COMMENTS3,DEADLINE4,DL_DATE4,DL_RESP_DATE4,COMMENTS4,DEADLINE5,DL_DATE5,DL_RESP_DATE5,COMMENTS5,DEADLINE6,DL_DATE6,DL_RESP_DATE6,COMMENTS6,FILE1,FILE2,FILE3,FILE4,FILE5,FILE6,FILE7,FILE8,FILE9,FILE10,FILE11,FILE12,FILE13,FILE14,FILE15)");
			strSql.Append(" values (");
			strSql.Append(":OURNO,:TITLE,:NATIVE_NO,:CLIENT,:CLIENT_NAME,:CLIENT_ADDR,:CLIENT_FAX,:CLIENT_REF,:YOUR_AGENCY_NO,:YOUR_AGENCY_NAME,:YOUR_AGENCY_ADDR,:YOUR_AGENCY_FAX,:YOUR_AGENCY_REF,:APPL_CODE,:APPLICANT,:APPDATE,:APPLICATION_NO,:PRI_NUMBER1,:PRI_DATE1,:PRI_NUMBER2,:PRI_DATE2,:PRI_NUMBER3,:PRI_DATE3,:PRI_NUMBER4,:PRI_DATE4,:PRI_NUMBER5,:PRI_DATE5,:PRI_NUMBER6,:PRI_DATE6,:PRI_NUMBER7,:PRI_DATE7,:PRI_NUMBER8,:PRI_DATE8,:PRI_NUMBER9,:PRI_DATE9,:COMMENTS,:DEADLINE1,:DL_DATE1,:DL_RESP_DATE1,:COMMENTS1,:DEADLINE2,:DL_DATE2,:DL_RESP_DATE2,:COMMENTS2,:DEADLINE3,:DL_DATE3,:DL_RESP_DATE3,:COMMENTS3,:DEADLINE4,:DL_DATE4,:DL_RESP_DATE4,:COMMENTS4,:DEADLINE5,:DL_DATE5,:DL_RESP_DATE5,:COMMENTS5,:DEADLINE6,:DL_DATE6,:DL_RESP_DATE6,:COMMENTS6,:FILE1,:FILE2,:FILE3,:FILE4,:FILE5,:FILE6,:FILE7,:FILE8,:FILE9,:FILE10,:FILE11,:FILE12,:FILE13,:FILE14,:FILE15)");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,24),
					new OracleParameter(":TITLE", OracleType.VarChar,800),
					new OracleParameter(":NATIVE_NO", OracleType.VarChar,24),
					new OracleParameter(":CLIENT", OracleType.VarChar,20),
					new OracleParameter(":CLIENT_NAME", OracleType.VarChar,400),
					new OracleParameter(":CLIENT_ADDR", OracleType.VarChar,800),
					new OracleParameter(":CLIENT_FAX", OracleType.VarChar,50),
					new OracleParameter(":CLIENT_REF", OracleType.VarChar,60),
					new OracleParameter(":YOUR_AGENCY_NO", OracleType.VarChar,60),
					new OracleParameter(":YOUR_AGENCY_NAME", OracleType.VarChar,200),
					new OracleParameter(":YOUR_AGENCY_ADDR", OracleType.VarChar,800),
					new OracleParameter(":YOUR_AGENCY_FAX", OracleType.VarChar,60),
					new OracleParameter(":YOUR_AGENCY_REF", OracleType.VarChar,80),
					new OracleParameter(":APPL_CODE", OracleType.VarChar,30),
					new OracleParameter(":APPLICANT", OracleType.VarChar,400),
					new OracleParameter(":APPDATE", OracleType.DateTime),
					new OracleParameter(":APPLICATION_NO", OracleType.VarChar,50),
					new OracleParameter(":PRI_NUMBER1", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE1", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER2", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE2", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER3", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE3", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER4", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE4", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER5", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE5", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER6", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE6", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER7", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE7", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER8", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE8", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER9", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE9", OracleType.DateTime),
					new OracleParameter(":COMMENTS", OracleType.VarChar,800),
					new OracleParameter(":DEADLINE1", OracleType.VarChar,60),
					new OracleParameter(":DL_DATE1", OracleType.DateTime),
					new OracleParameter(":DL_RESP_DATE1", OracleType.DateTime),
					new OracleParameter(":COMMENTS1", OracleType.VarChar,300),
					new OracleParameter(":DEADLINE2", OracleType.VarChar,60),
					new OracleParameter(":DL_DATE2", OracleType.DateTime),
					new OracleParameter(":DL_RESP_DATE2", OracleType.DateTime),
					new OracleParameter(":COMMENTS2", OracleType.VarChar,300),
					new OracleParameter(":DEADLINE3", OracleType.VarChar,60),
					new OracleParameter(":DL_DATE3", OracleType.DateTime),
					new OracleParameter(":DL_RESP_DATE3", OracleType.DateTime),
					new OracleParameter(":COMMENTS3", OracleType.VarChar,300),
					new OracleParameter(":DEADLINE4", OracleType.VarChar,60),
					new OracleParameter(":DL_DATE4", OracleType.DateTime),
					new OracleParameter(":DL_RESP_DATE4", OracleType.DateTime),
					new OracleParameter(":COMMENTS4", OracleType.VarChar,300),
					new OracleParameter(":DEADLINE5", OracleType.VarChar,60),
					new OracleParameter(":DL_DATE5", OracleType.DateTime),
					new OracleParameter(":DL_RESP_DATE5", OracleType.DateTime),
					new OracleParameter(":COMMENTS5", OracleType.VarChar,300),
					new OracleParameter(":DEADLINE6", OracleType.VarChar,60),
					new OracleParameter(":DL_DATE6", OracleType.DateTime),
					new OracleParameter(":DL_RESP_DATE6", OracleType.DateTime),
					new OracleParameter(":COMMENTS6", OracleType.VarChar,300),
					new OracleParameter(":FILE1", OracleType.VarChar,400),
					new OracleParameter(":FILE2", OracleType.VarChar,400),
					new OracleParameter(":FILE3", OracleType.VarChar,400),
					new OracleParameter(":FILE4", OracleType.VarChar,400),
					new OracleParameter(":FILE5", OracleType.VarChar,400),
					new OracleParameter(":FILE6", OracleType.VarChar,400),
					new OracleParameter(":FILE7", OracleType.VarChar,400),
					new OracleParameter(":FILE8", OracleType.VarChar,400),
					new OracleParameter(":FILE9", OracleType.VarChar,400),
					new OracleParameter(":FILE10", OracleType.VarChar,400),
					new OracleParameter(":FILE11", OracleType.VarChar,400),
					new OracleParameter(":FILE12", OracleType.VarChar,400),
					new OracleParameter(":FILE13", OracleType.VarChar,400),
					new OracleParameter(":FILE14", OracleType.VarChar,400),
					new OracleParameter(":FILE15", OracleType.VarChar,400)};
			parameters[0].Value = model.OURNO;
			parameters[1].Value = model.TITLE;
			parameters[2].Value = model.NATIVE_NO;
			parameters[3].Value = model.CLIENT;
			parameters[4].Value = model.CLIENT_NAME;
			parameters[5].Value = model.CLIENT_ADDR;
			parameters[6].Value = model.CLIENT_FAX;
			parameters[7].Value = model.CLIENT_REF;
			parameters[8].Value = model.YOUR_AGENCY_NO;
			parameters[9].Value = model.YOUR_AGENCY_NAME;
			parameters[10].Value = model.YOUR_AGENCY_ADDR;
			parameters[11].Value = model.YOUR_AGENCY_FAX;
			parameters[12].Value = model.YOUR_AGENCY_REF;
			parameters[13].Value = model.APPL_CODE;
			parameters[14].Value = model.APPLICANT;
			parameters[15].Value = model.APPDATE;
			parameters[16].Value = model.APPLICATION_NO;
			parameters[17].Value = model.PRI_NUMBER1;
			parameters[18].Value = model.PRI_DATE1;
			parameters[19].Value = model.PRI_NUMBER2;
			parameters[20].Value = model.PRI_DATE2;
			parameters[21].Value = model.PRI_NUMBER3;
			parameters[22].Value = model.PRI_DATE3;
			parameters[23].Value = model.PRI_NUMBER4;
			parameters[24].Value = model.PRI_DATE4;
			parameters[25].Value = model.PRI_NUMBER5;
			parameters[26].Value = model.PRI_DATE5;
			parameters[27].Value = model.PRI_NUMBER6;
			parameters[28].Value = model.PRI_DATE6;
			parameters[29].Value = model.PRI_NUMBER7;
			parameters[30].Value = model.PRI_DATE7;
			parameters[31].Value = model.PRI_NUMBER8;
			parameters[32].Value = model.PRI_DATE8;
			parameters[33].Value = model.PRI_NUMBER9;
			parameters[34].Value = model.PRI_DATE9;
			parameters[35].Value = model.COMMENTS;
			parameters[36].Value = model.DEADLINE1;
			parameters[37].Value = model.DL_DATE1;
			parameters[38].Value = model.DL_RESP_DATE1;
			parameters[39].Value = model.COMMENTS1;
			parameters[40].Value = model.DEADLINE2;
			parameters[41].Value = model.DL_DATE2;
			parameters[42].Value = model.DL_RESP_DATE2;
			parameters[43].Value = model.COMMENTS2;
			parameters[44].Value = model.DEADLINE3;
			parameters[45].Value = model.DL_DATE3;
			parameters[46].Value = model.DL_RESP_DATE3;
			parameters[47].Value = model.COMMENTS3;
			parameters[48].Value = model.DEADLINE4;
			parameters[49].Value = model.DL_DATE4;
			parameters[50].Value = model.DL_RESP_DATE4;
			parameters[51].Value = model.COMMENTS4;
			parameters[52].Value = model.DEADLINE5;
			parameters[53].Value = model.DL_DATE5;
			parameters[54].Value = model.DL_RESP_DATE5;
			parameters[55].Value = model.COMMENTS5;
			parameters[56].Value = model.DEADLINE6;
			parameters[57].Value = model.DL_DATE6;
			parameters[58].Value = model.DL_RESP_DATE6;
			parameters[59].Value = model.COMMENTS6;
			parameters[60].Value = model.FILE1;
			parameters[61].Value = model.FILE2;
			parameters[62].Value = model.FILE3;
			parameters[63].Value = model.FILE4;
			parameters[64].Value = model.FILE5;
			parameters[65].Value = model.FILE6;
			parameters[66].Value = model.FILE7;
			parameters[67].Value = model.FILE8;
			parameters[68].Value = model.FILE9;
			parameters[69].Value = model.FILE10;
			parameters[70].Value = model.FILE11;
			parameters[71].Value = model.FILE12;
			parameters[72].Value = model.FILE13;
			parameters[73].Value = model.FILE14;
			parameters[74].Value = model.FILE15;

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
		public bool Update(Model.EX_FOREIGNCASE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update EX_FOREIGNCASE set ");
			strSql.Append("OURNO=:OURNO,");
			strSql.Append("TITLE=:TITLE,");
			strSql.Append("NATIVE_NO=:NATIVE_NO,");
			strSql.Append("CLIENT=:CLIENT,");
			strSql.Append("CLIENT_NAME=:CLIENT_NAME,");
			strSql.Append("CLIENT_ADDR=:CLIENT_ADDR,");
			strSql.Append("CLIENT_FAX=:CLIENT_FAX,");
			strSql.Append("CLIENT_REF=:CLIENT_REF,");
			strSql.Append("YOUR_AGENCY_NO=:YOUR_AGENCY_NO,");
			strSql.Append("YOUR_AGENCY_NAME=:YOUR_AGENCY_NAME,");
			strSql.Append("YOUR_AGENCY_ADDR=:YOUR_AGENCY_ADDR,");
			strSql.Append("YOUR_AGENCY_FAX=:YOUR_AGENCY_FAX,");
			strSql.Append("YOUR_AGENCY_REF=:YOUR_AGENCY_REF,");
			strSql.Append("APPL_CODE=:APPL_CODE,");
			strSql.Append("APPLICANT=:APPLICANT,");
			strSql.Append("APPDATE=:APPDATE,");
			strSql.Append("APPLICATION_NO=:APPLICATION_NO,");
			strSql.Append("PRI_NUMBER1=:PRI_NUMBER1,");
			strSql.Append("PRI_DATE1=:PRI_DATE1,");
			strSql.Append("PRI_NUMBER2=:PRI_NUMBER2,");
			strSql.Append("PRI_DATE2=:PRI_DATE2,");
			strSql.Append("PRI_NUMBER3=:PRI_NUMBER3,");
			strSql.Append("PRI_DATE3=:PRI_DATE3,");
			strSql.Append("PRI_NUMBER4=:PRI_NUMBER4,");
			strSql.Append("PRI_DATE4=:PRI_DATE4,");
			strSql.Append("PRI_NUMBER5=:PRI_NUMBER5,");
			strSql.Append("PRI_DATE5=:PRI_DATE5,");
			strSql.Append("PRI_NUMBER6=:PRI_NUMBER6,");
			strSql.Append("PRI_DATE6=:PRI_DATE6,");
			strSql.Append("PRI_NUMBER7=:PRI_NUMBER7,");
			strSql.Append("PRI_DATE7=:PRI_DATE7,");
			strSql.Append("PRI_NUMBER8=:PRI_NUMBER8,");
			strSql.Append("PRI_DATE8=:PRI_DATE8,");
			strSql.Append("PRI_NUMBER9=:PRI_NUMBER9,");
			strSql.Append("PRI_DATE9=:PRI_DATE9,");
			strSql.Append("COMMENTS=:COMMENTS,");
			strSql.Append("DEADLINE1=:DEADLINE1,");
			strSql.Append("DL_DATE1=:DL_DATE1,");
			strSql.Append("DL_RESP_DATE1=:DL_RESP_DATE1,");
			strSql.Append("COMMENTS1=:COMMENTS1,");
			strSql.Append("DEADLINE2=:DEADLINE2,");
			strSql.Append("DL_DATE2=:DL_DATE2,");
			strSql.Append("DL_RESP_DATE2=:DL_RESP_DATE2,");
			strSql.Append("COMMENTS2=:COMMENTS2,");
			strSql.Append("DEADLINE3=:DEADLINE3,");
			strSql.Append("DL_DATE3=:DL_DATE3,");
			strSql.Append("DL_RESP_DATE3=:DL_RESP_DATE3,");
			strSql.Append("COMMENTS3=:COMMENTS3,");
			strSql.Append("DEADLINE4=:DEADLINE4,");
			strSql.Append("DL_DATE4=:DL_DATE4,");
			strSql.Append("DL_RESP_DATE4=:DL_RESP_DATE4,");
			strSql.Append("COMMENTS4=:COMMENTS4,");
			strSql.Append("DEADLINE5=:DEADLINE5,");
			strSql.Append("DL_DATE5=:DL_DATE5,");
			strSql.Append("DL_RESP_DATE5=:DL_RESP_DATE5,");
			strSql.Append("COMMENTS5=:COMMENTS5,");
			strSql.Append("DEADLINE6=:DEADLINE6,");
			strSql.Append("DL_DATE6=:DL_DATE6,");
			strSql.Append("DL_RESP_DATE6=:DL_RESP_DATE6,");
			strSql.Append("COMMENTS6=:COMMENTS6,");
			strSql.Append("FILE1=:FILE1,");
			strSql.Append("FILE2=:FILE2,");
			strSql.Append("FILE3=:FILE3,");
			strSql.Append("FILE4=:FILE4,");
			strSql.Append("FILE5=:FILE5,");
			strSql.Append("FILE6=:FILE6,");
			strSql.Append("FILE7=:FILE7,");
			strSql.Append("FILE8=:FILE8,");
			strSql.Append("FILE9=:FILE9,");
			strSql.Append("FILE10=:FILE10,");
			strSql.Append("FILE11=:FILE11,");
			strSql.Append("FILE12=:FILE12,");
			strSql.Append("FILE13=:FILE13,");
			strSql.Append("FILE14=:FILE14,");
			strSql.Append("FILE15=:FILE15");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,24),
					new OracleParameter(":TITLE", OracleType.VarChar,800),
					new OracleParameter(":NATIVE_NO", OracleType.VarChar,24),
					new OracleParameter(":CLIENT", OracleType.VarChar,20),
					new OracleParameter(":CLIENT_NAME", OracleType.VarChar,400),
					new OracleParameter(":CLIENT_ADDR", OracleType.VarChar,800),
					new OracleParameter(":CLIENT_FAX", OracleType.VarChar,50),
					new OracleParameter(":CLIENT_REF", OracleType.VarChar,60),
					new OracleParameter(":YOUR_AGENCY_NO", OracleType.VarChar,60),
					new OracleParameter(":YOUR_AGENCY_NAME", OracleType.VarChar,200),
					new OracleParameter(":YOUR_AGENCY_ADDR", OracleType.VarChar,800),
					new OracleParameter(":YOUR_AGENCY_FAX", OracleType.VarChar,60),
					new OracleParameter(":YOUR_AGENCY_REF", OracleType.VarChar,80),
					new OracleParameter(":APPL_CODE", OracleType.VarChar,30),
					new OracleParameter(":APPLICANT", OracleType.VarChar,400),
					new OracleParameter(":APPDATE", OracleType.DateTime),
					new OracleParameter(":APPLICATION_NO", OracleType.VarChar,50),
					new OracleParameter(":PRI_NUMBER1", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE1", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER2", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE2", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER3", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE3", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER4", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE4", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER5", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE5", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER6", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE6", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER7", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE7", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER8", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE8", OracleType.DateTime),
					new OracleParameter(":PRI_NUMBER9", OracleType.VarChar,50),
					new OracleParameter(":PRI_DATE9", OracleType.DateTime),
					new OracleParameter(":COMMENTS", OracleType.VarChar,800),
					new OracleParameter(":DEADLINE1", OracleType.VarChar,60),
					new OracleParameter(":DL_DATE1", OracleType.DateTime),
					new OracleParameter(":DL_RESP_DATE1", OracleType.DateTime),
					new OracleParameter(":COMMENTS1", OracleType.VarChar,300),
					new OracleParameter(":DEADLINE2", OracleType.VarChar,60),
					new OracleParameter(":DL_DATE2", OracleType.DateTime),
					new OracleParameter(":DL_RESP_DATE2", OracleType.DateTime),
					new OracleParameter(":COMMENTS2", OracleType.VarChar,300),
					new OracleParameter(":DEADLINE3", OracleType.VarChar,60),
					new OracleParameter(":DL_DATE3", OracleType.DateTime),
					new OracleParameter(":DL_RESP_DATE3", OracleType.DateTime),
					new OracleParameter(":COMMENTS3", OracleType.VarChar,300),
					new OracleParameter(":DEADLINE4", OracleType.VarChar,60),
					new OracleParameter(":DL_DATE4", OracleType.DateTime),
					new OracleParameter(":DL_RESP_DATE4", OracleType.DateTime),
					new OracleParameter(":COMMENTS4", OracleType.VarChar,300),
					new OracleParameter(":DEADLINE5", OracleType.VarChar,60),
					new OracleParameter(":DL_DATE5", OracleType.DateTime),
					new OracleParameter(":DL_RESP_DATE5", OracleType.DateTime),
					new OracleParameter(":COMMENTS5", OracleType.VarChar,300),
					new OracleParameter(":DEADLINE6", OracleType.VarChar,60),
					new OracleParameter(":DL_DATE6", OracleType.DateTime),
					new OracleParameter(":DL_RESP_DATE6", OracleType.DateTime),
					new OracleParameter(":COMMENTS6", OracleType.VarChar,300),
					new OracleParameter(":FILE1", OracleType.VarChar,400),
					new OracleParameter(":FILE2", OracleType.VarChar,400),
					new OracleParameter(":FILE3", OracleType.VarChar,400),
					new OracleParameter(":FILE4", OracleType.VarChar,400),
					new OracleParameter(":FILE5", OracleType.VarChar,400),
					new OracleParameter(":FILE6", OracleType.VarChar,400),
					new OracleParameter(":FILE7", OracleType.VarChar,400),
					new OracleParameter(":FILE8", OracleType.VarChar,400),
					new OracleParameter(":FILE9", OracleType.VarChar,400),
					new OracleParameter(":FILE10", OracleType.VarChar,400),
					new OracleParameter(":FILE11", OracleType.VarChar,400),
					new OracleParameter(":FILE12", OracleType.VarChar,400),
					new OracleParameter(":FILE13", OracleType.VarChar,400),
					new OracleParameter(":FILE14", OracleType.VarChar,400),
					new OracleParameter(":FILE15", OracleType.VarChar,400)};
			parameters[0].Value = model.OURNO;
			parameters[1].Value = model.TITLE;
			parameters[2].Value = model.NATIVE_NO;
			parameters[3].Value = model.CLIENT;
			parameters[4].Value = model.CLIENT_NAME;
			parameters[5].Value = model.CLIENT_ADDR;
			parameters[6].Value = model.CLIENT_FAX;
			parameters[7].Value = model.CLIENT_REF;
			parameters[8].Value = model.YOUR_AGENCY_NO;
			parameters[9].Value = model.YOUR_AGENCY_NAME;
			parameters[10].Value = model.YOUR_AGENCY_ADDR;
			parameters[11].Value = model.YOUR_AGENCY_FAX;
			parameters[12].Value = model.YOUR_AGENCY_REF;
			parameters[13].Value = model.APPL_CODE;
			parameters[14].Value = model.APPLICANT;
			parameters[15].Value = model.APPDATE;
			parameters[16].Value = model.APPLICATION_NO;
			parameters[17].Value = model.PRI_NUMBER1;
			parameters[18].Value = model.PRI_DATE1;
			parameters[19].Value = model.PRI_NUMBER2;
			parameters[20].Value = model.PRI_DATE2;
			parameters[21].Value = model.PRI_NUMBER3;
			parameters[22].Value = model.PRI_DATE3;
			parameters[23].Value = model.PRI_NUMBER4;
			parameters[24].Value = model.PRI_DATE4;
			parameters[25].Value = model.PRI_NUMBER5;
			parameters[26].Value = model.PRI_DATE5;
			parameters[27].Value = model.PRI_NUMBER6;
			parameters[28].Value = model.PRI_DATE6;
			parameters[29].Value = model.PRI_NUMBER7;
			parameters[30].Value = model.PRI_DATE7;
			parameters[31].Value = model.PRI_NUMBER8;
			parameters[32].Value = model.PRI_DATE8;
			parameters[33].Value = model.PRI_NUMBER9;
			parameters[34].Value = model.PRI_DATE9;
			parameters[35].Value = model.COMMENTS;
			parameters[36].Value = model.DEADLINE1;
			parameters[37].Value = model.DL_DATE1;
			parameters[38].Value = model.DL_RESP_DATE1;
			parameters[39].Value = model.COMMENTS1;
			parameters[40].Value = model.DEADLINE2;
			parameters[41].Value = model.DL_DATE2;
			parameters[42].Value = model.DL_RESP_DATE2;
			parameters[43].Value = model.COMMENTS2;
			parameters[44].Value = model.DEADLINE3;
			parameters[45].Value = model.DL_DATE3;
			parameters[46].Value = model.DL_RESP_DATE3;
			parameters[47].Value = model.COMMENTS3;
			parameters[48].Value = model.DEADLINE4;
			parameters[49].Value = model.DL_DATE4;
			parameters[50].Value = model.DL_RESP_DATE4;
			parameters[51].Value = model.COMMENTS4;
			parameters[52].Value = model.DEADLINE5;
			parameters[53].Value = model.DL_DATE5;
			parameters[54].Value = model.DL_RESP_DATE5;
			parameters[55].Value = model.COMMENTS5;
			parameters[56].Value = model.DEADLINE6;
			parameters[57].Value = model.DL_DATE6;
			parameters[58].Value = model.DL_RESP_DATE6;
			parameters[59].Value = model.COMMENTS6;
			parameters[60].Value = model.FILE1;
			parameters[61].Value = model.FILE2;
			parameters[62].Value = model.FILE3;
			parameters[63].Value = model.FILE4;
			parameters[64].Value = model.FILE5;
			parameters[65].Value = model.FILE6;
			parameters[66].Value = model.FILE7;
			parameters[67].Value = model.FILE8;
			parameters[68].Value = model.FILE9;
			parameters[69].Value = model.FILE10;
			parameters[70].Value = model.FILE11;
			parameters[71].Value = model.FILE12;
			parameters[72].Value = model.FILE13;
			parameters[73].Value = model.FILE14;
			parameters[74].Value = model.FILE15;

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
			strSql.Append("delete from EX_FOREIGNCASE ");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,24)			};
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
			strSql.Append("delete from EX_FOREIGNCASE ");
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
		public Model.EX_FOREIGNCASE GetModel(string OURNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OURNO,TITLE,NATIVE_NO,CLIENT,CLIENT_NAME,CLIENT_ADDR,CLIENT_FAX,CLIENT_REF,YOUR_AGENCY_NO,YOUR_AGENCY_NAME,YOUR_AGENCY_ADDR,YOUR_AGENCY_FAX,YOUR_AGENCY_REF,APPL_CODE,APPLICANT,APPDATE,APPLICATION_NO,PRI_NUMBER1,PRI_DATE1,PRI_NUMBER2,PRI_DATE2,PRI_NUMBER3,PRI_DATE3,PRI_NUMBER4,PRI_DATE4,PRI_NUMBER5,PRI_DATE5,PRI_NUMBER6,PRI_DATE6,PRI_NUMBER7,PRI_DATE7,PRI_NUMBER8,PRI_DATE8,PRI_NUMBER9,PRI_DATE9,COMMENTS,DEADLINE1,DL_DATE1,DL_RESP_DATE1,COMMENTS1,DEADLINE2,DL_DATE2,DL_RESP_DATE2,COMMENTS2,DEADLINE3,DL_DATE3,DL_RESP_DATE3,COMMENTS3,DEADLINE4,DL_DATE4,DL_RESP_DATE4,COMMENTS4,DEADLINE5,DL_DATE5,DL_RESP_DATE5,COMMENTS5,DEADLINE6,DL_DATE6,DL_RESP_DATE6,COMMENTS6,FILE1,FILE2,FILE3,FILE4,FILE5,FILE6,FILE7,FILE8,FILE9,FILE10,FILE11,FILE12,FILE13,FILE14,FILE15 from EX_FOREIGNCASE ");
			strSql.Append(" where OURNO=:OURNO ");
			OracleParameter[] parameters = {
					new OracleParameter(":OURNO", OracleType.VarChar,24)			};
			parameters[0].Value = OURNO;

			Model.EX_FOREIGNCASE model=new Model.EX_FOREIGNCASE();
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
		public Model.EX_FOREIGNCASE DataRowToModel(DataRow row)
		{
			Model.EX_FOREIGNCASE model=new Model.EX_FOREIGNCASE();
			if (row != null)
			{
				if(row["OURNO"]!=null)
				{
					model.OURNO=row["OURNO"].ToString();
				}
				if(row["TITLE"]!=null)
				{
					model.TITLE=row["TITLE"].ToString();
				}
				if(row["NATIVE_NO"]!=null)
				{
					model.NATIVE_NO=row["NATIVE_NO"].ToString();
				}
				if(row["CLIENT"]!=null)
				{
					model.CLIENT=row["CLIENT"].ToString();
				}
				if(row["CLIENT_NAME"]!=null)
				{
					model.CLIENT_NAME=row["CLIENT_NAME"].ToString();
				}
				if(row["CLIENT_ADDR"]!=null)
				{
					model.CLIENT_ADDR=row["CLIENT_ADDR"].ToString();
				}
				if(row["CLIENT_FAX"]!=null)
				{
					model.CLIENT_FAX=row["CLIENT_FAX"].ToString();
				}
				if(row["CLIENT_REF"]!=null)
				{
					model.CLIENT_REF=row["CLIENT_REF"].ToString();
				}
				if(row["YOUR_AGENCY_NO"]!=null)
				{
					model.YOUR_AGENCY_NO=row["YOUR_AGENCY_NO"].ToString();
				}
				if(row["YOUR_AGENCY_NAME"]!=null)
				{
					model.YOUR_AGENCY_NAME=row["YOUR_AGENCY_NAME"].ToString();
				}
				if(row["YOUR_AGENCY_ADDR"]!=null)
				{
					model.YOUR_AGENCY_ADDR=row["YOUR_AGENCY_ADDR"].ToString();
				}
				if(row["YOUR_AGENCY_FAX"]!=null)
				{
					model.YOUR_AGENCY_FAX=row["YOUR_AGENCY_FAX"].ToString();
				}
				if(row["YOUR_AGENCY_REF"]!=null)
				{
					model.YOUR_AGENCY_REF=row["YOUR_AGENCY_REF"].ToString();
				}
				if(row["APPL_CODE"]!=null)
				{
					model.APPL_CODE=row["APPL_CODE"].ToString();
				}
				if(row["APPLICANT"]!=null)
				{
					model.APPLICANT=row["APPLICANT"].ToString();
				}
				if(row["APPDATE"]!=null && row["APPDATE"].ToString()!="")
				{
					model.APPDATE=DateTime.Parse(row["APPDATE"].ToString());
				}
				if(row["APPLICATION_NO"]!=null)
				{
					model.APPLICATION_NO=row["APPLICATION_NO"].ToString();
				}
				if(row["PRI_NUMBER1"]!=null)
				{
					model.PRI_NUMBER1=row["PRI_NUMBER1"].ToString();
				}
				if(row["PRI_DATE1"]!=null && row["PRI_DATE1"].ToString()!="")
				{
					model.PRI_DATE1=DateTime.Parse(row["PRI_DATE1"].ToString());
				}
				if(row["PRI_NUMBER2"]!=null)
				{
					model.PRI_NUMBER2=row["PRI_NUMBER2"].ToString();
				}
				if(row["PRI_DATE2"]!=null && row["PRI_DATE2"].ToString()!="")
				{
					model.PRI_DATE2=DateTime.Parse(row["PRI_DATE2"].ToString());
				}
				if(row["PRI_NUMBER3"]!=null)
				{
					model.PRI_NUMBER3=row["PRI_NUMBER3"].ToString();
				}
				if(row["PRI_DATE3"]!=null && row["PRI_DATE3"].ToString()!="")
				{
					model.PRI_DATE3=DateTime.Parse(row["PRI_DATE3"].ToString());
				}
				if(row["PRI_NUMBER4"]!=null)
				{
					model.PRI_NUMBER4=row["PRI_NUMBER4"].ToString();
				}
				if(row["PRI_DATE4"]!=null && row["PRI_DATE4"].ToString()!="")
				{
					model.PRI_DATE4=DateTime.Parse(row["PRI_DATE4"].ToString());
				}
				if(row["PRI_NUMBER5"]!=null)
				{
					model.PRI_NUMBER5=row["PRI_NUMBER5"].ToString();
				}
				if(row["PRI_DATE5"]!=null && row["PRI_DATE5"].ToString()!="")
				{
					model.PRI_DATE5=DateTime.Parse(row["PRI_DATE5"].ToString());
				}
				if(row["PRI_NUMBER6"]!=null)
				{
					model.PRI_NUMBER6=row["PRI_NUMBER6"].ToString();
				}
				if(row["PRI_DATE6"]!=null && row["PRI_DATE6"].ToString()!="")
				{
					model.PRI_DATE6=DateTime.Parse(row["PRI_DATE6"].ToString());
				}
				if(row["PRI_NUMBER7"]!=null)
				{
					model.PRI_NUMBER7=row["PRI_NUMBER7"].ToString();
				}
				if(row["PRI_DATE7"]!=null && row["PRI_DATE7"].ToString()!="")
				{
					model.PRI_DATE7=DateTime.Parse(row["PRI_DATE7"].ToString());
				}
				if(row["PRI_NUMBER8"]!=null)
				{
					model.PRI_NUMBER8=row["PRI_NUMBER8"].ToString();
				}
				if(row["PRI_DATE8"]!=null && row["PRI_DATE8"].ToString()!="")
				{
					model.PRI_DATE8=DateTime.Parse(row["PRI_DATE8"].ToString());
				}
				if(row["PRI_NUMBER9"]!=null)
				{
					model.PRI_NUMBER9=row["PRI_NUMBER9"].ToString();
				}
				if(row["PRI_DATE9"]!=null && row["PRI_DATE9"].ToString()!="")
				{
					model.PRI_DATE9=DateTime.Parse(row["PRI_DATE9"].ToString());
				}
				if(row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
				}
				if(row["DEADLINE1"]!=null)
				{
					model.DEADLINE1=row["DEADLINE1"].ToString();
				}
				if(row["DL_DATE1"]!=null && row["DL_DATE1"].ToString()!="")
				{
					model.DL_DATE1=DateTime.Parse(row["DL_DATE1"].ToString());
				}
				if(row["DL_RESP_DATE1"]!=null && row["DL_RESP_DATE1"].ToString()!="")
				{
					model.DL_RESP_DATE1=DateTime.Parse(row["DL_RESP_DATE1"].ToString());
				}
				if(row["COMMENTS1"]!=null)
				{
					model.COMMENTS1=row["COMMENTS1"].ToString();
				}
				if(row["DEADLINE2"]!=null)
				{
					model.DEADLINE2=row["DEADLINE2"].ToString();
				}
				if(row["DL_DATE2"]!=null && row["DL_DATE2"].ToString()!="")
				{
					model.DL_DATE2=DateTime.Parse(row["DL_DATE2"].ToString());
				}
				if(row["DL_RESP_DATE2"]!=null && row["DL_RESP_DATE2"].ToString()!="")
				{
					model.DL_RESP_DATE2=DateTime.Parse(row["DL_RESP_DATE2"].ToString());
				}
				if(row["COMMENTS2"]!=null)
				{
					model.COMMENTS2=row["COMMENTS2"].ToString();
				}
				if(row["DEADLINE3"]!=null)
				{
					model.DEADLINE3=row["DEADLINE3"].ToString();
				}
				if(row["DL_DATE3"]!=null && row["DL_DATE3"].ToString()!="")
				{
					model.DL_DATE3=DateTime.Parse(row["DL_DATE3"].ToString());
				}
				if(row["DL_RESP_DATE3"]!=null && row["DL_RESP_DATE3"].ToString()!="")
				{
					model.DL_RESP_DATE3=DateTime.Parse(row["DL_RESP_DATE3"].ToString());
				}
				if(row["COMMENTS3"]!=null)
				{
					model.COMMENTS3=row["COMMENTS3"].ToString();
				}
				if(row["DEADLINE4"]!=null)
				{
					model.DEADLINE4=row["DEADLINE4"].ToString();
				}
				if(row["DL_DATE4"]!=null && row["DL_DATE4"].ToString()!="")
				{
					model.DL_DATE4=DateTime.Parse(row["DL_DATE4"].ToString());
				}
				if(row["DL_RESP_DATE4"]!=null && row["DL_RESP_DATE4"].ToString()!="")
				{
					model.DL_RESP_DATE4=DateTime.Parse(row["DL_RESP_DATE4"].ToString());
				}
				if(row["COMMENTS4"]!=null)
				{
					model.COMMENTS4=row["COMMENTS4"].ToString();
				}
				if(row["DEADLINE5"]!=null)
				{
					model.DEADLINE5=row["DEADLINE5"].ToString();
				}
				if(row["DL_DATE5"]!=null && row["DL_DATE5"].ToString()!="")
				{
					model.DL_DATE5=DateTime.Parse(row["DL_DATE5"].ToString());
				}
				if(row["DL_RESP_DATE5"]!=null && row["DL_RESP_DATE5"].ToString()!="")
				{
					model.DL_RESP_DATE5=DateTime.Parse(row["DL_RESP_DATE5"].ToString());
				}
				if(row["COMMENTS5"]!=null)
				{
					model.COMMENTS5=row["COMMENTS5"].ToString();
				}
				if(row["DEADLINE6"]!=null)
				{
					model.DEADLINE6=row["DEADLINE6"].ToString();
				}
				if(row["DL_DATE6"]!=null && row["DL_DATE6"].ToString()!="")
				{
					model.DL_DATE6=DateTime.Parse(row["DL_DATE6"].ToString());
				}
				if(row["DL_RESP_DATE6"]!=null && row["DL_RESP_DATE6"].ToString()!="")
				{
					model.DL_RESP_DATE6=DateTime.Parse(row["DL_RESP_DATE6"].ToString());
				}
				if(row["COMMENTS6"]!=null)
				{
					model.COMMENTS6=row["COMMENTS6"].ToString();
				}
				if(row["FILE1"]!=null)
				{
					model.FILE1=row["FILE1"].ToString();
				}
				if(row["FILE2"]!=null)
				{
					model.FILE2=row["FILE2"].ToString();
				}
				if(row["FILE3"]!=null)
				{
					model.FILE3=row["FILE3"].ToString();
				}
				if(row["FILE4"]!=null)
				{
					model.FILE4=row["FILE4"].ToString();
				}
				if(row["FILE5"]!=null)
				{
					model.FILE5=row["FILE5"].ToString();
				}
				if(row["FILE6"]!=null)
				{
					model.FILE6=row["FILE6"].ToString();
				}
				if(row["FILE7"]!=null)
				{
					model.FILE7=row["FILE7"].ToString();
				}
				if(row["FILE8"]!=null)
				{
					model.FILE8=row["FILE8"].ToString();
				}
				if(row["FILE9"]!=null)
				{
					model.FILE9=row["FILE9"].ToString();
				}
				if(row["FILE10"]!=null)
				{
					model.FILE10=row["FILE10"].ToString();
				}
				if(row["FILE11"]!=null)
				{
					model.FILE11=row["FILE11"].ToString();
				}
				if(row["FILE12"]!=null)
				{
					model.FILE12=row["FILE12"].ToString();
				}
				if(row["FILE13"]!=null)
				{
					model.FILE13=row["FILE13"].ToString();
				}
				if(row["FILE14"]!=null)
				{
					model.FILE14=row["FILE14"].ToString();
				}
				if(row["FILE15"]!=null)
				{
					model.FILE15=row["FILE15"].ToString();
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
			strSql.Append("select OURNO,TITLE,NATIVE_NO,CLIENT,CLIENT_NAME,CLIENT_ADDR,CLIENT_FAX,CLIENT_REF,YOUR_AGENCY_NO,YOUR_AGENCY_NAME,YOUR_AGENCY_ADDR,YOUR_AGENCY_FAX,YOUR_AGENCY_REF,APPL_CODE,APPLICANT,APPDATE,APPLICATION_NO,PRI_NUMBER1,PRI_DATE1,PRI_NUMBER2,PRI_DATE2,PRI_NUMBER3,PRI_DATE3,PRI_NUMBER4,PRI_DATE4,PRI_NUMBER5,PRI_DATE5,PRI_NUMBER6,PRI_DATE6,PRI_NUMBER7,PRI_DATE7,PRI_NUMBER8,PRI_DATE8,PRI_NUMBER9,PRI_DATE9,COMMENTS,DEADLINE1,DL_DATE1,DL_RESP_DATE1,COMMENTS1,DEADLINE2,DL_DATE2,DL_RESP_DATE2,COMMENTS2,DEADLINE3,DL_DATE3,DL_RESP_DATE3,COMMENTS3,DEADLINE4,DL_DATE4,DL_RESP_DATE4,COMMENTS4,DEADLINE5,DL_DATE5,DL_RESP_DATE5,COMMENTS5,DEADLINE6,DL_DATE6,DL_RESP_DATE6,COMMENTS6,FILE1,FILE2,FILE3,FILE4,FILE5,FILE6,FILE7,FILE8,FILE9,FILE10,FILE11,FILE12,FILE13,FILE14,FILE15 ");
			strSql.Append(" FROM EX_FOREIGNCASE ");
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
			strSql.Append("select count(1) FROM EX_FOREIGNCASE ");
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
			strSql.Append(")AS Row, T.*  from EX_FOREIGNCASE T ");
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
			parameters[0].Value = "EX_FOREIGNCASE";
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

