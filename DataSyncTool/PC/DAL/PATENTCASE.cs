using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using DataSyncTool.DBUtility;
namespace DataSyncTool.PC.DAL
{
    /// <summary>
    /// 数据访问类:PATENTCASE
    /// </summary>
    public partial class PATENTCASE
    {
        public PATENTCASE()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string OURNO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PATENTCASE");
            strSql.Append(" where OURNO=:OURNO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":OURNO", OracleType.VarChar,50)            };
            parameters[0].Value = OURNO;

            return DbHelperOra.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(DataSyncTool.PC.Model.PATENTCASE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PATENTCASE(");
            strSql.Append("CLIENT,RECEIVED,AGENT,CLIENT_NUMBER,FILING_DATE,APPLICATION_NO,EARLIEST_PRIORITY,PUBLICATION,FIRST_HK_DATE,FIRST_HK_CANCELLED,SE_STATUS,SE_INITIATED,OA_RECEIVED,GAZETTE,SECOND_HK_CANCELLED,SECOND_HK_DATE,REJECTED,WITHDREW,UNDER_INVALIDATE,UNDER_REEXAMINATION,UNDER_LITIGATION,INVALIDATED,OURNO,CLIENT2,CLIENT3,APPLICANT1,APPLICANT2,APPLICANT3,APPLICANT4,APPLICANT5,INVENTOR1,INVENTOR2,INVENTOR3,INVENTOR4,INVENTOR5,INVENTOR6,INVENTOR7,TITLE,PRI_COUNTRY,PRI_NUMBER,PRI_COUNTRY2,PRI_NUMBER2,PRI_COUNTRY3,PRI_NUMBER3,PRI_COUNTRY4,PRI_NUMBER4,PRI_COUNTRY5,PRI_NUMBER5,PCT_NUMBER,PCT_APPN_DATE,FILING_DUE,PRI_DATE2,PRI_DATE3,PRI_DATE4,PRI_DATE5,INVENTOR8,INVENTOR9,INVENTOR10,INVENTOR11,INVENTOR12,INVENTOR13,INVENTOR14,INVENTOR15,COMMENTS,PRI_NUMBER6,PRI_DATE6,PRI_COUNTRY6,PRI_NUMBER7,PRI_DATE7,PRI_COUNTRY7,PRI_NUMBER8,PRI_DATE8,PRI_COUNTRY8,PRI_NUMBER9,PRI_DATE9,PRI_COUNTRY9,PRI_NUMBER10,PRI_DATE10,PRI_COUNTRY10,CLIENT_NAME,TOTAL_PRI,PCT_PUBDATE,PCT_PUBNUM,DEADLINE,TITLE_CHINESE,APPL_CODE1,APPL_CODE2,APPL_CODE3,APPL_CODE4,APPL_CODE5,INVENTOR_CH1,INVENTOR_CH2,INVENTOR_CH3,INVENTOR_CH4,INVENTOR_CH5,INVENTOR_CH6,INVENTOR_CH7,INVENTOR_CH8,INVENTOR_CH9,INVENTOR_CH10,INVENTOR_CH11,INVENTOR_CH12,INVENTOR_CH13,INVENTOR_CH14,INVENTOR_CH15,AGENT_ACTUAL,APPN_COPY,BILL_COPY,MAILING_ADDR,MAILING_CONTACT,BILLING_CONTACT,CHARCOUNT,CLAIM_NUM,LANGUAGE,APPL_NUM,INVEN_NUM,PRE_EXAM_PASSED,PUBLICATION_NO,SE_DATE,GRANTNOTIC_DATE,REGFEE_DL,REGFEE_SUBMIT,ANNO_NO,STATUS_DATE,CLIENT_STATUS,YFEE_DATE,YFEE1,YFEE2,CERTIFICATE_NO,CLIENT4,CLIENT5,OAGENT1,OAGENT2,SEFEE,APPFEE,IGNOREANNUALFEE,APPLICANT_CH1,APPLICANT_CH2,APPLICANT_CH3,APPLICANT_CH4,APPLICANT_CH5,INVENTOR16,INVENTOR17,INVENTOR18,INVENTOR19,INVENTOR20,INVENTOR21,INVENTOR_CH16,INVENTOR_CH17,INVENTOR_CH18,INVENTOR_CH19,INVENTOR_CH20,INVENTOR_CH21,TRANSLATOR,CORRECTOR1,CORRECTOR2,URGENT_CO,PRI_DATE11,PRI_DATE12,PRI_NUMBER11,PRI_NUMBER12,PRI_COUNTRY11,PRI_COUNTRY12,APP_REF,DIV_FILINGDATE,DIV_PARENTAPPNO,STATUS)");
            strSql.Append(" values (");
            strSql.Append(":CLIENT,:RECEIVED,:AGENT,:CLIENT_NUMBER,:FILING_DATE,:APPLICATION_NO,:EARLIEST_PRIORITY,:PUBLICATION,:FIRST_HK_DATE,:FIRST_HK_CANCELLED,:SE_STATUS,:SE_INITIATED,:OA_RECEIVED,:GAZETTE,:SECOND_HK_CANCELLED,:SECOND_HK_DATE,:REJECTED,:WITHDREW,:UNDER_INVALIDATE,:UNDER_REEXAMINATION,:UNDER_LITIGATION,:INVALIDATED,:OURNO,:CLIENT2,:CLIENT3,:APPLICANT1,:APPLICANT2,:APPLICANT3,:APPLICANT4,:APPLICANT5,:INVENTOR1,:INVENTOR2,:INVENTOR3,:INVENTOR4,:INVENTOR5,:INVENTOR6,:INVENTOR7,:TITLE,:PRI_COUNTRY,:PRI_NUMBER,:PRI_COUNTRY2,:PRI_NUMBER2,:PRI_COUNTRY3,:PRI_NUMBER3,:PRI_COUNTRY4,:PRI_NUMBER4,:PRI_COUNTRY5,:PRI_NUMBER5,:PCT_NUMBER,:PCT_APPN_DATE,:FILING_DUE,:PRI_DATE2,:PRI_DATE3,:PRI_DATE4,:PRI_DATE5,:INVENTOR8,:INVENTOR9,:INVENTOR10,:INVENTOR11,:INVENTOR12,:INVENTOR13,:INVENTOR14,:INVENTOR15,:COMMENTS,:PRI_NUMBER6,:PRI_DATE6,:PRI_COUNTRY6,:PRI_NUMBER7,:PRI_DATE7,:PRI_COUNTRY7,:PRI_NUMBER8,:PRI_DATE8,:PRI_COUNTRY8,:PRI_NUMBER9,:PRI_DATE9,:PRI_COUNTRY9,:PRI_NUMBER10,:PRI_DATE10,:PRI_COUNTRY10,:CLIENT_NAME,:TOTAL_PRI,:PCT_PUBDATE,:PCT_PUBNUM,:DEADLINE,:TITLE_CHINESE,:APPL_CODE1,:APPL_CODE2,:APPL_CODE3,:APPL_CODE4,:APPL_CODE5,:INVENTOR_CH1,:INVENTOR_CH2,:INVENTOR_CH3,:INVENTOR_CH4,:INVENTOR_CH5,:INVENTOR_CH6,:INVENTOR_CH7,:INVENTOR_CH8,:INVENTOR_CH9,:INVENTOR_CH10,:INVENTOR_CH11,:INVENTOR_CH12,:INVENTOR_CH13,:INVENTOR_CH14,:INVENTOR_CH15,:AGENT_ACTUAL,:APPN_COPY,:BILL_COPY,:MAILING_ADDR,:MAILING_CONTACT,:BILLING_CONTACT,:CHARCOUNT,:CLAIM_NUM,:LANGUAGE,:APPL_NUM,:INVEN_NUM,:PRE_EXAM_PASSED,:PUBLICATION_NO,:SE_DATE,:GRANTNOTIC_DATE,:REGFEE_DL,:REGFEE_SUBMIT,:ANNO_NO,:STATUS_DATE,:CLIENT_STATUS,:YFEE_DATE,:YFEE1,:YFEE2,:CERTIFICATE_NO,:CLIENT4,:CLIENT5,:OAGENT1,:OAGENT2,:SEFEE,:APPFEE,:IGNOREANNUALFEE,:APPLICANT_CH1,:APPLICANT_CH2,:APPLICANT_CH3,:APPLICANT_CH4,:APPLICANT_CH5,:INVENTOR16,:INVENTOR17,:INVENTOR18,:INVENTOR19,:INVENTOR20,:INVENTOR21,:INVENTOR_CH16,:INVENTOR_CH17,:INVENTOR_CH18,:INVENTOR_CH19,:INVENTOR_CH20,:INVENTOR_CH21,:TRANSLATOR,:CORRECTOR1,:CORRECTOR2,:URGENT_CO,:PRI_DATE11,:PRI_DATE12,:PRI_NUMBER11,:PRI_NUMBER12,:PRI_COUNTRY11,:PRI_COUNTRY12,:APP_REF,:DIV_FILINGDATE,:DIV_PARENTAPPNO,:STATUS)");
            OracleParameter[] parameters = {
                    new OracleParameter(":CLIENT", OracleType.Char,4),
                    new OracleParameter(":RECEIVED", OracleType.DateTime),
                    new OracleParameter(":AGENT", OracleType.Char,3),
                    new OracleParameter(":CLIENT_NUMBER", OracleType.VarChar,50),
                    new OracleParameter(":FILING_DATE", OracleType.DateTime),
                    new OracleParameter(":APPLICATION_NO", OracleType.VarChar,30),
                    new OracleParameter(":EARLIEST_PRIORITY", OracleType.DateTime),
                    new OracleParameter(":PUBLICATION", OracleType.DateTime),
                    new OracleParameter(":FIRST_HK_DATE", OracleType.DateTime),
                    new OracleParameter(":FIRST_HK_CANCELLED", OracleType.Char,1),
                    new OracleParameter(":SE_STATUS", OracleType.Char,1),
                    new OracleParameter(":SE_INITIATED", OracleType.Char,1),
                    new OracleParameter(":OA_RECEIVED", OracleType.Char,1),
                    new OracleParameter(":GAZETTE", OracleType.DateTime),
                    new OracleParameter(":SECOND_HK_CANCELLED", OracleType.Char,1),
                    new OracleParameter(":SECOND_HK_DATE", OracleType.DateTime),
                    new OracleParameter(":REJECTED", OracleType.Char,1),
                    new OracleParameter(":WITHDREW", OracleType.Char,1),
                    new OracleParameter(":UNDER_INVALIDATE", OracleType.Char,1),
                    new OracleParameter(":UNDER_REEXAMINATION", OracleType.Char,1),
                    new OracleParameter(":UNDER_LITIGATION", OracleType.Char,1),
                    new OracleParameter(":INVALIDATED", OracleType.Char,1),
                    new OracleParameter(":OURNO", OracleType.VarChar,50),
                    new OracleParameter(":CLIENT2", OracleType.Char,4),
                    new OracleParameter(":CLIENT3", OracleType.Char,4),
                    new OracleParameter(":APPLICANT1", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT2", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT3", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT4", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT5", OracleType.VarChar,200),
                    new OracleParameter(":INVENTOR1", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR2", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR3", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR4", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR5", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR6", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR7", OracleType.VarChar,100),
                    new OracleParameter(":TITLE", OracleType.VarChar,500),
                    new OracleParameter(":PRI_COUNTRY", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER", OracleType.VarChar,20),
                    new OracleParameter(":PRI_COUNTRY2", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER2", OracleType.VarChar,20),
                    new OracleParameter(":PRI_COUNTRY3", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER3", OracleType.VarChar,20),
                    new OracleParameter(":PRI_COUNTRY4", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER4", OracleType.VarChar,20),
                    new OracleParameter(":PRI_COUNTRY5", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER5", OracleType.VarChar,20),
                    new OracleParameter(":PCT_NUMBER", OracleType.VarChar,20),
                    new OracleParameter(":PCT_APPN_DATE", OracleType.DateTime),
                    new OracleParameter(":FILING_DUE", OracleType.DateTime),
                    new OracleParameter(":PRI_DATE2", OracleType.DateTime),
                    new OracleParameter(":PRI_DATE3", OracleType.DateTime),
                    new OracleParameter(":PRI_DATE4", OracleType.DateTime),
                    new OracleParameter(":PRI_DATE5", OracleType.DateTime),
                    new OracleParameter(":INVENTOR8", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR9", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR10", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR11", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR12", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR13", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR14", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR15", OracleType.VarChar,100),
                    new OracleParameter(":COMMENTS", OracleType.VarChar,2000),
                    new OracleParameter(":PRI_NUMBER6", OracleType.VarChar,20),
                    new OracleParameter(":PRI_DATE6", OracleType.DateTime),
                    new OracleParameter(":PRI_COUNTRY6", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER7", OracleType.VarChar,20),
                    new OracleParameter(":PRI_DATE7", OracleType.DateTime),
                    new OracleParameter(":PRI_COUNTRY7", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER8", OracleType.VarChar,20),
                    new OracleParameter(":PRI_DATE8", OracleType.DateTime),
                    new OracleParameter(":PRI_COUNTRY8", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER9", OracleType.VarChar,20),
                    new OracleParameter(":PRI_DATE9", OracleType.DateTime),
                    new OracleParameter(":PRI_COUNTRY9", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER10", OracleType.VarChar,20),
                    new OracleParameter(":PRI_DATE10", OracleType.DateTime),
                    new OracleParameter(":PRI_COUNTRY10", OracleType.Char,2),
                    new OracleParameter(":CLIENT_NAME", OracleType.VarChar,100),
                    new OracleParameter(":TOTAL_PRI", OracleType.Number,2),
                    new OracleParameter(":PCT_PUBDATE", OracleType.DateTime),
                    new OracleParameter(":PCT_PUBNUM", OracleType.VarChar,20),
                    new OracleParameter(":DEADLINE", OracleType.DateTime),
                    new OracleParameter(":TITLE_CHINESE", OracleType.VarChar,300),
                    new OracleParameter(":APPL_CODE1", OracleType.Char,4),
                    new OracleParameter(":APPL_CODE2", OracleType.Char,4),
                    new OracleParameter(":APPL_CODE3", OracleType.Char,4),
                    new OracleParameter(":APPL_CODE4", OracleType.Char,4),
                    new OracleParameter(":APPL_CODE5", OracleType.Char,4),
                    new OracleParameter(":INVENTOR_CH1", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH2", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH3", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH4", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH5", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH6", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH7", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH8", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH9", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH10", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH11", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH12", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH13", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH14", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH15", OracleType.VarChar,150),
                    new OracleParameter(":AGENT_ACTUAL", OracleType.Char,3),
                    new OracleParameter(":APPN_COPY", OracleType.Number,2),
                    new OracleParameter(":BILL_COPY", OracleType.Number,2),
                    new OracleParameter(":MAILING_ADDR", OracleType.VarChar,700),
                    new OracleParameter(":MAILING_CONTACT", OracleType.VarChar,700),
                    new OracleParameter(":BILLING_CONTACT", OracleType.VarChar,700),
                    new OracleParameter(":CHARCOUNT", OracleType.Number,4),
                    new OracleParameter(":CLAIM_NUM", OracleType.Number,3),
                    new OracleParameter(":LANGUAGE", OracleType.Char,2),
                    new OracleParameter(":APPL_NUM", OracleType.Number,2),
                    new OracleParameter(":INVEN_NUM", OracleType.Number,2),
                    new OracleParameter(":PRE_EXAM_PASSED", OracleType.DateTime),
                    new OracleParameter(":PUBLICATION_NO", OracleType.VarChar,20),
                    new OracleParameter(":SE_DATE", OracleType.DateTime),
                    new OracleParameter(":GRANTNOTIC_DATE", OracleType.DateTime),
                    new OracleParameter(":REGFEE_DL", OracleType.DateTime),
                    new OracleParameter(":REGFEE_SUBMIT", OracleType.DateTime),
                    new OracleParameter(":ANNO_NO", OracleType.VarChar,15),
                    new OracleParameter(":STATUS_DATE", OracleType.DateTime),
                    new OracleParameter(":CLIENT_STATUS", OracleType.Char,1),
                    new OracleParameter(":YFEE_DATE", OracleType.DateTime),
                    new OracleParameter(":YFEE1", OracleType.DateTime),
                    new OracleParameter(":YFEE2", OracleType.DateTime),
                    new OracleParameter(":CERTIFICATE_NO", OracleType.Number,8),
                    new OracleParameter(":CLIENT4", OracleType.Char,4),
                    new OracleParameter(":CLIENT5", OracleType.Char,4),
                    new OracleParameter(":OAGENT1", OracleType.Char,3),
                    new OracleParameter(":OAGENT2", OracleType.Char,3),
                    new OracleParameter(":SEFEE", OracleType.Char,1),
                    new OracleParameter(":APPFEE", OracleType.Char,1),
                    new OracleParameter(":IGNOREANNUALFEE", OracleType.VarChar,300),
                    new OracleParameter(":APPLICANT_CH1", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT_CH2", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT_CH3", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT_CH4", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT_CH5", OracleType.VarChar,200),
                    new OracleParameter(":INVENTOR16", OracleType.VarChar,50),
                    new OracleParameter(":INVENTOR17", OracleType.VarChar,50),
                    new OracleParameter(":INVENTOR18", OracleType.VarChar,50),
                    new OracleParameter(":INVENTOR19", OracleType.VarChar,50),
                    new OracleParameter(":INVENTOR20", OracleType.VarChar,50),
                    new OracleParameter(":INVENTOR21", OracleType.VarChar,50),
                    new OracleParameter(":INVENTOR_CH16", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH17", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH18", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH19", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH20", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH21", OracleType.VarChar,150),
                    new OracleParameter(":TRANSLATOR", OracleType.Char,3),
                    new OracleParameter(":CORRECTOR1", OracleType.Char,3),
                    new OracleParameter(":CORRECTOR2", OracleType.Char,3),
                    new OracleParameter(":URGENT_CO", OracleType.Number,4),
                    new OracleParameter(":PRI_DATE11", OracleType.DateTime),
                    new OracleParameter(":PRI_DATE12", OracleType.DateTime),
                    new OracleParameter(":PRI_NUMBER11", OracleType.VarChar,20),
                    new OracleParameter(":PRI_NUMBER12", OracleType.VarChar,20),
                    new OracleParameter(":PRI_COUNTRY11", OracleType.Char,2),
                    new OracleParameter(":PRI_COUNTRY12", OracleType.Char,2),
                    new OracleParameter(":APP_REF", OracleType.VarChar,100),
                    new OracleParameter(":DIV_FILINGDATE", OracleType.DateTime),
                    new OracleParameter(":DIV_PARENTAPPNO", OracleType.VarChar,20),
                    new OracleParameter(":STATUS", OracleType.VarChar,20)};
            parameters[0].Value = model.CLIENT;
            parameters[1].Value = model.RECEIVED;
            parameters[2].Value = model.AGENT;
            parameters[3].Value = model.CLIENT_NUMBER;
            parameters[4].Value = model.FILING_DATE;
            parameters[5].Value = model.APPLICATION_NO;
            parameters[6].Value = model.EARLIEST_PRIORITY;
            parameters[7].Value = model.PUBLICATION;
            parameters[8].Value = model.FIRST_HK_DATE;
            parameters[9].Value = model.FIRST_HK_CANCELLED;
            parameters[10].Value = model.SE_STATUS;
            parameters[11].Value = model.SE_INITIATED;
            parameters[12].Value = model.OA_RECEIVED;
            parameters[13].Value = model.GAZETTE;
            parameters[14].Value = model.SECOND_HK_CANCELLED;
            parameters[15].Value = model.SECOND_HK_DATE;
            parameters[16].Value = model.REJECTED;
            parameters[17].Value = model.WITHDREW;
            parameters[18].Value = model.UNDER_INVALIDATE;
            parameters[19].Value = model.UNDER_REEXAMINATION;
            parameters[20].Value = model.UNDER_LITIGATION;
            parameters[21].Value = model.INVALIDATED;
            parameters[22].Value = model.OURNO;
            parameters[23].Value = model.CLIENT2;
            parameters[24].Value = model.CLIENT3;
            parameters[25].Value = model.APPLICANT1;
            parameters[26].Value = model.APPLICANT2;
            parameters[27].Value = model.APPLICANT3;
            parameters[28].Value = model.APPLICANT4;
            parameters[29].Value = model.APPLICANT5;
            parameters[30].Value = model.INVENTOR1;
            parameters[31].Value = model.INVENTOR2;
            parameters[32].Value = model.INVENTOR3;
            parameters[33].Value = model.INVENTOR4;
            parameters[34].Value = model.INVENTOR5;
            parameters[35].Value = model.INVENTOR6;
            parameters[36].Value = model.INVENTOR7;
            parameters[37].Value = model.TITLE;
            parameters[38].Value = model.PRI_COUNTRY;
            parameters[39].Value = model.PRI_NUMBER;
            parameters[40].Value = model.PRI_COUNTRY2;
            parameters[41].Value = model.PRI_NUMBER2;
            parameters[42].Value = model.PRI_COUNTRY3;
            parameters[43].Value = model.PRI_NUMBER3;
            parameters[44].Value = model.PRI_COUNTRY4;
            parameters[45].Value = model.PRI_NUMBER4;
            parameters[46].Value = model.PRI_COUNTRY5;
            parameters[47].Value = model.PRI_NUMBER5;
            parameters[48].Value = model.PCT_NUMBER;
            parameters[49].Value = model.PCT_APPN_DATE;
            parameters[50].Value = model.FILING_DUE;
            parameters[51].Value = model.PRI_DATE2;
            parameters[52].Value = model.PRI_DATE3;
            parameters[53].Value = model.PRI_DATE4;
            parameters[54].Value = model.PRI_DATE5;
            parameters[55].Value = model.INVENTOR8;
            parameters[56].Value = model.INVENTOR9;
            parameters[57].Value = model.INVENTOR10;
            parameters[58].Value = model.INVENTOR11;
            parameters[59].Value = model.INVENTOR12;
            parameters[60].Value = model.INVENTOR13;
            parameters[61].Value = model.INVENTOR14;
            parameters[62].Value = model.INVENTOR15;
            parameters[63].Value = model.COMMENTS;
            parameters[64].Value = model.PRI_NUMBER6;
            parameters[65].Value = model.PRI_DATE6;
            parameters[66].Value = model.PRI_COUNTRY6;
            parameters[67].Value = model.PRI_NUMBER7;
            parameters[68].Value = model.PRI_DATE7;
            parameters[69].Value = model.PRI_COUNTRY7;
            parameters[70].Value = model.PRI_NUMBER8;
            parameters[71].Value = model.PRI_DATE8;
            parameters[72].Value = model.PRI_COUNTRY8;
            parameters[73].Value = model.PRI_NUMBER9;
            parameters[74].Value = model.PRI_DATE9;
            parameters[75].Value = model.PRI_COUNTRY9;
            parameters[76].Value = model.PRI_NUMBER10;
            parameters[77].Value = model.PRI_DATE10;
            parameters[78].Value = model.PRI_COUNTRY10;
            parameters[79].Value = model.CLIENT_NAME;
            parameters[80].Value = model.TOTAL_PRI;
            parameters[81].Value = model.PCT_PUBDATE;
            parameters[82].Value = model.PCT_PUBNUM;
            parameters[83].Value = model.DEADLINE;
            parameters[84].Value = model.TITLE_CHINESE;
            parameters[85].Value = model.APPL_CODE1;
            parameters[86].Value = model.APPL_CODE2;
            parameters[87].Value = model.APPL_CODE3;
            parameters[88].Value = model.APPL_CODE4;
            parameters[89].Value = model.APPL_CODE5;
            parameters[90].Value = model.INVENTOR_CH1;
            parameters[91].Value = model.INVENTOR_CH2;
            parameters[92].Value = model.INVENTOR_CH3;
            parameters[93].Value = model.INVENTOR_CH4;
            parameters[94].Value = model.INVENTOR_CH5;
            parameters[95].Value = model.INVENTOR_CH6;
            parameters[96].Value = model.INVENTOR_CH7;
            parameters[97].Value = model.INVENTOR_CH8;
            parameters[98].Value = model.INVENTOR_CH9;
            parameters[99].Value = model.INVENTOR_CH10;
            parameters[100].Value = model.INVENTOR_CH11;
            parameters[101].Value = model.INVENTOR_CH12;
            parameters[102].Value = model.INVENTOR_CH13;
            parameters[103].Value = model.INVENTOR_CH14;
            parameters[104].Value = model.INVENTOR_CH15;
            parameters[105].Value = model.AGENT_ACTUAL;
            parameters[106].Value = model.APPN_COPY;
            parameters[107].Value = model.BILL_COPY;
            parameters[108].Value = model.MAILING_ADDR;
            parameters[109].Value = model.MAILING_CONTACT;
            parameters[110].Value = model.BILLING_CONTACT;
            parameters[111].Value = model.CHARCOUNT;
            parameters[112].Value = model.CLAIM_NUM;
            parameters[113].Value = model.LANGUAGE;
            parameters[114].Value = model.APPL_NUM;
            parameters[115].Value = model.INVEN_NUM;
            parameters[116].Value = model.PRE_EXAM_PASSED;
            parameters[117].Value = model.PUBLICATION_NO;
            parameters[118].Value = model.SE_DATE;
            parameters[119].Value = model.GRANTNOTIC_DATE;
            parameters[120].Value = model.REGFEE_DL;
            parameters[121].Value = model.REGFEE_SUBMIT;
            parameters[122].Value = model.ANNO_NO;
            parameters[123].Value = model.STATUS_DATE;
            parameters[124].Value = model.CLIENT_STATUS;
            parameters[125].Value = model.YFEE_DATE;
            parameters[126].Value = model.YFEE1;
            parameters[127].Value = model.YFEE2;
            parameters[128].Value = model.CERTIFICATE_NO;
            parameters[129].Value = model.CLIENT4;
            parameters[130].Value = model.CLIENT5;
            parameters[131].Value = model.OAGENT1;
            parameters[132].Value = model.OAGENT2;
            parameters[133].Value = model.SEFEE;
            parameters[134].Value = model.APPFEE;
            parameters[135].Value = model.IGNOREANNUALFEE;
            parameters[136].Value = model.APPLICANT_CH1;
            parameters[137].Value = model.APPLICANT_CH2;
            parameters[138].Value = model.APPLICANT_CH3;
            parameters[139].Value = model.APPLICANT_CH4;
            parameters[140].Value = model.APPLICANT_CH5;
            parameters[141].Value = model.INVENTOR16;
            parameters[142].Value = model.INVENTOR17;
            parameters[143].Value = model.INVENTOR18;
            parameters[144].Value = model.INVENTOR19;
            parameters[145].Value = model.INVENTOR20;
            parameters[146].Value = model.INVENTOR21;
            parameters[147].Value = model.INVENTOR_CH16;
            parameters[148].Value = model.INVENTOR_CH17;
            parameters[149].Value = model.INVENTOR_CH18;
            parameters[150].Value = model.INVENTOR_CH19;
            parameters[151].Value = model.INVENTOR_CH20;
            parameters[152].Value = model.INVENTOR_CH21;
            parameters[153].Value = model.TRANSLATOR;
            parameters[154].Value = model.CORRECTOR1;
            parameters[155].Value = model.CORRECTOR2;
            parameters[156].Value = model.URGENT_CO;
            parameters[157].Value = model.PRI_DATE11;
            parameters[158].Value = model.PRI_DATE12;
            parameters[159].Value = model.PRI_NUMBER11;
            parameters[160].Value = model.PRI_NUMBER12;
            parameters[161].Value = model.PRI_COUNTRY11;
            parameters[162].Value = model.PRI_COUNTRY12;
            parameters[163].Value = model.APP_REF;
            parameters[164].Value = model.DIV_FILINGDATE;
            parameters[165].Value = model.DIV_PARENTAPPNO;
            parameters[166].Value = model.STATUS;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(DataSyncTool.PC.Model.PATENTCASE model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PATENTCASE set ");
            strSql.Append("CLIENT=:CLIENT,");
            strSql.Append("RECEIVED=:RECEIVED,");
            strSql.Append("AGENT=:AGENT,");
            strSql.Append("CLIENT_NUMBER=:CLIENT_NUMBER,");
            strSql.Append("FILING_DATE=:FILING_DATE,");
            strSql.Append("APPLICATION_NO=:APPLICATION_NO,");
            strSql.Append("EARLIEST_PRIORITY=:EARLIEST_PRIORITY,");
            strSql.Append("PUBLICATION=:PUBLICATION,");
            strSql.Append("FIRST_HK_DATE=:FIRST_HK_DATE,");
            strSql.Append("FIRST_HK_CANCELLED=:FIRST_HK_CANCELLED,");
            strSql.Append("SE_STATUS=:SE_STATUS,");
            strSql.Append("SE_INITIATED=:SE_INITIATED,");
            strSql.Append("OA_RECEIVED=:OA_RECEIVED,");
            strSql.Append("GAZETTE=:GAZETTE,");
            strSql.Append("SECOND_HK_CANCELLED=:SECOND_HK_CANCELLED,");
            strSql.Append("SECOND_HK_DATE=:SECOND_HK_DATE,");
            strSql.Append("REJECTED=:REJECTED,");
            strSql.Append("WITHDREW=:WITHDREW,");
            strSql.Append("UNDER_INVALIDATE=:UNDER_INVALIDATE,");
            strSql.Append("UNDER_REEXAMINATION=:UNDER_REEXAMINATION,");
            strSql.Append("UNDER_LITIGATION=:UNDER_LITIGATION,");
            strSql.Append("INVALIDATED=:INVALIDATED,");
            strSql.Append("OURNO=:OURNO,");
            strSql.Append("CLIENT2=:CLIENT2,");
            strSql.Append("CLIENT3=:CLIENT3,");
            strSql.Append("APPLICANT1=:APPLICANT1,");
            strSql.Append("APPLICANT2=:APPLICANT2,");
            strSql.Append("APPLICANT3=:APPLICANT3,");
            strSql.Append("APPLICANT4=:APPLICANT4,");
            strSql.Append("APPLICANT5=:APPLICANT5,");
            strSql.Append("INVENTOR1=:INVENTOR1,");
            strSql.Append("INVENTOR2=:INVENTOR2,");
            strSql.Append("INVENTOR3=:INVENTOR3,");
            strSql.Append("INVENTOR4=:INVENTOR4,");
            strSql.Append("INVENTOR5=:INVENTOR5,");
            strSql.Append("INVENTOR6=:INVENTOR6,");
            strSql.Append("INVENTOR7=:INVENTOR7,");
            strSql.Append("TITLE=:TITLE,");
            strSql.Append("PRI_COUNTRY=:PRI_COUNTRY,");
            strSql.Append("PRI_NUMBER=:PRI_NUMBER,");
            strSql.Append("PRI_COUNTRY2=:PRI_COUNTRY2,");
            strSql.Append("PRI_NUMBER2=:PRI_NUMBER2,");
            strSql.Append("PRI_COUNTRY3=:PRI_COUNTRY3,");
            strSql.Append("PRI_NUMBER3=:PRI_NUMBER3,");
            strSql.Append("PRI_COUNTRY4=:PRI_COUNTRY4,");
            strSql.Append("PRI_NUMBER4=:PRI_NUMBER4,");
            strSql.Append("PRI_COUNTRY5=:PRI_COUNTRY5,");
            strSql.Append("PRI_NUMBER5=:PRI_NUMBER5,");
            strSql.Append("PCT_NUMBER=:PCT_NUMBER,");
            strSql.Append("PCT_APPN_DATE=:PCT_APPN_DATE,");
            strSql.Append("FILING_DUE=:FILING_DUE,");
            strSql.Append("PRI_DATE2=:PRI_DATE2,");
            strSql.Append("PRI_DATE3=:PRI_DATE3,");
            strSql.Append("PRI_DATE4=:PRI_DATE4,");
            strSql.Append("PRI_DATE5=:PRI_DATE5,");
            strSql.Append("INVENTOR8=:INVENTOR8,");
            strSql.Append("INVENTOR9=:INVENTOR9,");
            strSql.Append("INVENTOR10=:INVENTOR10,");
            strSql.Append("INVENTOR11=:INVENTOR11,");
            strSql.Append("INVENTOR12=:INVENTOR12,");
            strSql.Append("INVENTOR13=:INVENTOR13,");
            strSql.Append("INVENTOR14=:INVENTOR14,");
            strSql.Append("INVENTOR15=:INVENTOR15,");
            strSql.Append("COMMENTS=:COMMENTS,");
            strSql.Append("PRI_NUMBER6=:PRI_NUMBER6,");
            strSql.Append("PRI_DATE6=:PRI_DATE6,");
            strSql.Append("PRI_COUNTRY6=:PRI_COUNTRY6,");
            strSql.Append("PRI_NUMBER7=:PRI_NUMBER7,");
            strSql.Append("PRI_DATE7=:PRI_DATE7,");
            strSql.Append("PRI_COUNTRY7=:PRI_COUNTRY7,");
            strSql.Append("PRI_NUMBER8=:PRI_NUMBER8,");
            strSql.Append("PRI_DATE8=:PRI_DATE8,");
            strSql.Append("PRI_COUNTRY8=:PRI_COUNTRY8,");
            strSql.Append("PRI_NUMBER9=:PRI_NUMBER9,");
            strSql.Append("PRI_DATE9=:PRI_DATE9,");
            strSql.Append("PRI_COUNTRY9=:PRI_COUNTRY9,");
            strSql.Append("PRI_NUMBER10=:PRI_NUMBER10,");
            strSql.Append("PRI_DATE10=:PRI_DATE10,");
            strSql.Append("PRI_COUNTRY10=:PRI_COUNTRY10,");
            strSql.Append("CLIENT_NAME=:CLIENT_NAME,");
            strSql.Append("TOTAL_PRI=:TOTAL_PRI,");
            strSql.Append("PCT_PUBDATE=:PCT_PUBDATE,");
            strSql.Append("PCT_PUBNUM=:PCT_PUBNUM,");
            strSql.Append("DEADLINE=:DEADLINE,");
            strSql.Append("TITLE_CHINESE=:TITLE_CHINESE,");
            strSql.Append("APPL_CODE1=:APPL_CODE1,");
            strSql.Append("APPL_CODE2=:APPL_CODE2,");
            strSql.Append("APPL_CODE3=:APPL_CODE3,");
            strSql.Append("APPL_CODE4=:APPL_CODE4,");
            strSql.Append("APPL_CODE5=:APPL_CODE5,");
            strSql.Append("INVENTOR_CH1=:INVENTOR_CH1,");
            strSql.Append("INVENTOR_CH2=:INVENTOR_CH2,");
            strSql.Append("INVENTOR_CH3=:INVENTOR_CH3,");
            strSql.Append("INVENTOR_CH4=:INVENTOR_CH4,");
            strSql.Append("INVENTOR_CH5=:INVENTOR_CH5,");
            strSql.Append("INVENTOR_CH6=:INVENTOR_CH6,");
            strSql.Append("INVENTOR_CH7=:INVENTOR_CH7,");
            strSql.Append("INVENTOR_CH8=:INVENTOR_CH8,");
            strSql.Append("INVENTOR_CH9=:INVENTOR_CH9,");
            strSql.Append("INVENTOR_CH10=:INVENTOR_CH10,");
            strSql.Append("INVENTOR_CH11=:INVENTOR_CH11,");
            strSql.Append("INVENTOR_CH12=:INVENTOR_CH12,");
            strSql.Append("INVENTOR_CH13=:INVENTOR_CH13,");
            strSql.Append("INVENTOR_CH14=:INVENTOR_CH14,");
            strSql.Append("INVENTOR_CH15=:INVENTOR_CH15,");
            strSql.Append("AGENT_ACTUAL=:AGENT_ACTUAL,");
            strSql.Append("APPN_COPY=:APPN_COPY,");
            strSql.Append("BILL_COPY=:BILL_COPY,");
            strSql.Append("MAILING_ADDR=:MAILING_ADDR,");
            strSql.Append("MAILING_CONTACT=:MAILING_CONTACT,");
            strSql.Append("BILLING_CONTACT=:BILLING_CONTACT,");
            strSql.Append("CHARCOUNT=:CHARCOUNT,");
            strSql.Append("CLAIM_NUM=:CLAIM_NUM,");
            strSql.Append("LANGUAGE=:LANGUAGE,");
            strSql.Append("APPL_NUM=:APPL_NUM,");
            strSql.Append("INVEN_NUM=:INVEN_NUM,");
            strSql.Append("PRE_EXAM_PASSED=:PRE_EXAM_PASSED,");
            strSql.Append("PUBLICATION_NO=:PUBLICATION_NO,");
            strSql.Append("SE_DATE=:SE_DATE,");
            strSql.Append("GRANTNOTIC_DATE=:GRANTNOTIC_DATE,");
            strSql.Append("REGFEE_DL=:REGFEE_DL,");
            strSql.Append("REGFEE_SUBMIT=:REGFEE_SUBMIT,");
            strSql.Append("ANNO_NO=:ANNO_NO,");
            strSql.Append("STATUS_DATE=:STATUS_DATE,");
            strSql.Append("CLIENT_STATUS=:CLIENT_STATUS,");
            strSql.Append("YFEE_DATE=:YFEE_DATE,");
            strSql.Append("YFEE1=:YFEE1,");
            strSql.Append("YFEE2=:YFEE2,");
            strSql.Append("CERTIFICATE_NO=:CERTIFICATE_NO,");
            strSql.Append("CLIENT4=:CLIENT4,");
            strSql.Append("CLIENT5=:CLIENT5,");
            strSql.Append("OAGENT1=:OAGENT1,");
            strSql.Append("OAGENT2=:OAGENT2,");
            strSql.Append("SEFEE=:SEFEE,");
            strSql.Append("APPFEE=:APPFEE,");
            strSql.Append("IGNOREANNUALFEE=:IGNOREANNUALFEE,");
            strSql.Append("APPLICANT_CH1=:APPLICANT_CH1,");
            strSql.Append("APPLICANT_CH2=:APPLICANT_CH2,");
            strSql.Append("APPLICANT_CH3=:APPLICANT_CH3,");
            strSql.Append("APPLICANT_CH4=:APPLICANT_CH4,");
            strSql.Append("APPLICANT_CH5=:APPLICANT_CH5,");
            strSql.Append("INVENTOR16=:INVENTOR16,");
            strSql.Append("INVENTOR17=:INVENTOR17,");
            strSql.Append("INVENTOR18=:INVENTOR18,");
            strSql.Append("INVENTOR19=:INVENTOR19,");
            strSql.Append("INVENTOR20=:INVENTOR20,");
            strSql.Append("INVENTOR21=:INVENTOR21,");
            strSql.Append("INVENTOR_CH16=:INVENTOR_CH16,");
            strSql.Append("INVENTOR_CH17=:INVENTOR_CH17,");
            strSql.Append("INVENTOR_CH18=:INVENTOR_CH18,");
            strSql.Append("INVENTOR_CH19=:INVENTOR_CH19,");
            strSql.Append("INVENTOR_CH20=:INVENTOR_CH20,");
            strSql.Append("INVENTOR_CH21=:INVENTOR_CH21,");
            strSql.Append("TRANSLATOR=:TRANSLATOR,");
            strSql.Append("CORRECTOR1=:CORRECTOR1,");
            strSql.Append("CORRECTOR2=:CORRECTOR2,");
            strSql.Append("URGENT_CO=:URGENT_CO,");
            strSql.Append("PRI_DATE11=:PRI_DATE11,");
            strSql.Append("PRI_DATE12=:PRI_DATE12,");
            strSql.Append("PRI_NUMBER11=:PRI_NUMBER11,");
            strSql.Append("PRI_NUMBER12=:PRI_NUMBER12,");
            strSql.Append("PRI_COUNTRY11=:PRI_COUNTRY11,");
            strSql.Append("PRI_COUNTRY12=:PRI_COUNTRY12,");
            strSql.Append("APP_REF=:APP_REF,");
            strSql.Append("DIV_FILINGDATE=:DIV_FILINGDATE,");
            strSql.Append("DIV_PARENTAPPNO=:DIV_PARENTAPPNO,");
            strSql.Append("STATUS=:STATUS");
            strSql.Append(" where OURNO=:OURNO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":CLIENT", OracleType.Char,4),
                    new OracleParameter(":RECEIVED", OracleType.DateTime),
                    new OracleParameter(":AGENT", OracleType.Char,3),
                    new OracleParameter(":CLIENT_NUMBER", OracleType.VarChar,50),
                    new OracleParameter(":FILING_DATE", OracleType.DateTime),
                    new OracleParameter(":APPLICATION_NO", OracleType.VarChar,30),
                    new OracleParameter(":EARLIEST_PRIORITY", OracleType.DateTime),
                    new OracleParameter(":PUBLICATION", OracleType.DateTime),
                    new OracleParameter(":FIRST_HK_DATE", OracleType.DateTime),
                    new OracleParameter(":FIRST_HK_CANCELLED", OracleType.Char,1),
                    new OracleParameter(":SE_STATUS", OracleType.Char,1),
                    new OracleParameter(":SE_INITIATED", OracleType.Char,1),
                    new OracleParameter(":OA_RECEIVED", OracleType.Char,1),
                    new OracleParameter(":GAZETTE", OracleType.DateTime),
                    new OracleParameter(":SECOND_HK_CANCELLED", OracleType.Char,1),
                    new OracleParameter(":SECOND_HK_DATE", OracleType.DateTime),
                    new OracleParameter(":REJECTED", OracleType.Char,1),
                    new OracleParameter(":WITHDREW", OracleType.Char,1),
                    new OracleParameter(":UNDER_INVALIDATE", OracleType.Char,1),
                    new OracleParameter(":UNDER_REEXAMINATION", OracleType.Char,1),
                    new OracleParameter(":UNDER_LITIGATION", OracleType.Char,1),
                    new OracleParameter(":INVALIDATED", OracleType.Char,1),
                    new OracleParameter(":OURNO", OracleType.VarChar,50),
                    new OracleParameter(":CLIENT2", OracleType.Char,4),
                    new OracleParameter(":CLIENT3", OracleType.Char,4),
                    new OracleParameter(":APPLICANT1", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT2", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT3", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT4", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT5", OracleType.VarChar,200),
                    new OracleParameter(":INVENTOR1", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR2", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR3", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR4", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR5", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR6", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR7", OracleType.VarChar,100),
                    new OracleParameter(":TITLE", OracleType.VarChar,500),
                    new OracleParameter(":PRI_COUNTRY", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER", OracleType.VarChar,20),
                    new OracleParameter(":PRI_COUNTRY2", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER2", OracleType.VarChar,20),
                    new OracleParameter(":PRI_COUNTRY3", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER3", OracleType.VarChar,20),
                    new OracleParameter(":PRI_COUNTRY4", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER4", OracleType.VarChar,20),
                    new OracleParameter(":PRI_COUNTRY5", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER5", OracleType.VarChar,20),
                    new OracleParameter(":PCT_NUMBER", OracleType.VarChar,20),
                    new OracleParameter(":PCT_APPN_DATE", OracleType.DateTime),
                    new OracleParameter(":FILING_DUE", OracleType.DateTime),
                    new OracleParameter(":PRI_DATE2", OracleType.DateTime),
                    new OracleParameter(":PRI_DATE3", OracleType.DateTime),
                    new OracleParameter(":PRI_DATE4", OracleType.DateTime),
                    new OracleParameter(":PRI_DATE5", OracleType.DateTime),
                    new OracleParameter(":INVENTOR8", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR9", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR10", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR11", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR12", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR13", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR14", OracleType.VarChar,100),
                    new OracleParameter(":INVENTOR15", OracleType.VarChar,100),
                    new OracleParameter(":COMMENTS", OracleType.VarChar,2000),
                    new OracleParameter(":PRI_NUMBER6", OracleType.VarChar,20),
                    new OracleParameter(":PRI_DATE6", OracleType.DateTime),
                    new OracleParameter(":PRI_COUNTRY6", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER7", OracleType.VarChar,20),
                    new OracleParameter(":PRI_DATE7", OracleType.DateTime),
                    new OracleParameter(":PRI_COUNTRY7", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER8", OracleType.VarChar,20),
                    new OracleParameter(":PRI_DATE8", OracleType.DateTime),
                    new OracleParameter(":PRI_COUNTRY8", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER9", OracleType.VarChar,20),
                    new OracleParameter(":PRI_DATE9", OracleType.DateTime),
                    new OracleParameter(":PRI_COUNTRY9", OracleType.Char,2),
                    new OracleParameter(":PRI_NUMBER10", OracleType.VarChar,20),
                    new OracleParameter(":PRI_DATE10", OracleType.DateTime),
                    new OracleParameter(":PRI_COUNTRY10", OracleType.Char,2),
                    new OracleParameter(":CLIENT_NAME", OracleType.VarChar,100),
                    new OracleParameter(":TOTAL_PRI", OracleType.Number,2),
                    new OracleParameter(":PCT_PUBDATE", OracleType.DateTime),
                    new OracleParameter(":PCT_PUBNUM", OracleType.VarChar,20),
                    new OracleParameter(":DEADLINE", OracleType.DateTime),
                    new OracleParameter(":TITLE_CHINESE", OracleType.VarChar,300),
                    new OracleParameter(":APPL_CODE1", OracleType.Char,4),
                    new OracleParameter(":APPL_CODE2", OracleType.Char,4),
                    new OracleParameter(":APPL_CODE3", OracleType.Char,4),
                    new OracleParameter(":APPL_CODE4", OracleType.Char,4),
                    new OracleParameter(":APPL_CODE5", OracleType.Char,4),
                    new OracleParameter(":INVENTOR_CH1", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH2", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH3", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH4", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH5", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH6", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH7", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH8", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH9", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH10", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH11", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH12", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH13", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH14", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH15", OracleType.VarChar,150),
                    new OracleParameter(":AGENT_ACTUAL", OracleType.Char,3),
                    new OracleParameter(":APPN_COPY", OracleType.Number,2),
                    new OracleParameter(":BILL_COPY", OracleType.Number,2),
                    new OracleParameter(":MAILING_ADDR", OracleType.VarChar,700),
                    new OracleParameter(":MAILING_CONTACT", OracleType.VarChar,700),
                    new OracleParameter(":BILLING_CONTACT", OracleType.VarChar,700),
                    new OracleParameter(":CHARCOUNT", OracleType.Number,4),
                    new OracleParameter(":CLAIM_NUM", OracleType.Number,3),
                    new OracleParameter(":LANGUAGE", OracleType.Char,2),
                    new OracleParameter(":APPL_NUM", OracleType.Number,2),
                    new OracleParameter(":INVEN_NUM", OracleType.Number,2),
                    new OracleParameter(":PRE_EXAM_PASSED", OracleType.DateTime),
                    new OracleParameter(":PUBLICATION_NO", OracleType.VarChar,20),
                    new OracleParameter(":SE_DATE", OracleType.DateTime),
                    new OracleParameter(":GRANTNOTIC_DATE", OracleType.DateTime),
                    new OracleParameter(":REGFEE_DL", OracleType.DateTime),
                    new OracleParameter(":REGFEE_SUBMIT", OracleType.DateTime),
                    new OracleParameter(":ANNO_NO", OracleType.VarChar,15),
                    new OracleParameter(":STATUS_DATE", OracleType.DateTime),
                    new OracleParameter(":CLIENT_STATUS", OracleType.Char,1),
                    new OracleParameter(":YFEE_DATE", OracleType.DateTime),
                    new OracleParameter(":YFEE1", OracleType.DateTime),
                    new OracleParameter(":YFEE2", OracleType.DateTime),
                    new OracleParameter(":CERTIFICATE_NO", OracleType.Number,8),
                    new OracleParameter(":CLIENT4", OracleType.Char,4),
                    new OracleParameter(":CLIENT5", OracleType.Char,4),
                    new OracleParameter(":OAGENT1", OracleType.Char,3),
                    new OracleParameter(":OAGENT2", OracleType.Char,3),
                    new OracleParameter(":SEFEE", OracleType.Char,1),
                    new OracleParameter(":APPFEE", OracleType.Char,1),
                    new OracleParameter(":IGNOREANNUALFEE", OracleType.VarChar,300),
                    new OracleParameter(":APPLICANT_CH1", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT_CH2", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT_CH3", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT_CH4", OracleType.VarChar,200),
                    new OracleParameter(":APPLICANT_CH5", OracleType.VarChar,200),
                    new OracleParameter(":INVENTOR16", OracleType.VarChar,50),
                    new OracleParameter(":INVENTOR17", OracleType.VarChar,50),
                    new OracleParameter(":INVENTOR18", OracleType.VarChar,50),
                    new OracleParameter(":INVENTOR19", OracleType.VarChar,50),
                    new OracleParameter(":INVENTOR20", OracleType.VarChar,50),
                    new OracleParameter(":INVENTOR21", OracleType.VarChar,50),
                    new OracleParameter(":INVENTOR_CH16", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH17", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH18", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH19", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH20", OracleType.VarChar,150),
                    new OracleParameter(":INVENTOR_CH21", OracleType.VarChar,150),
                    new OracleParameter(":TRANSLATOR", OracleType.Char,3),
                    new OracleParameter(":CORRECTOR1", OracleType.Char,3),
                    new OracleParameter(":CORRECTOR2", OracleType.Char,3),
                    new OracleParameter(":URGENT_CO", OracleType.Number,4),
                    new OracleParameter(":PRI_DATE11", OracleType.DateTime),
                    new OracleParameter(":PRI_DATE12", OracleType.DateTime),
                    new OracleParameter(":PRI_NUMBER11", OracleType.VarChar,20),
                    new OracleParameter(":PRI_NUMBER12", OracleType.VarChar,20),
                    new OracleParameter(":PRI_COUNTRY11", OracleType.Char,2),
                    new OracleParameter(":PRI_COUNTRY12", OracleType.Char,2),
                    new OracleParameter(":APP_REF", OracleType.VarChar,100),
                    new OracleParameter(":DIV_FILINGDATE", OracleType.DateTime),
                    new OracleParameter(":DIV_PARENTAPPNO", OracleType.VarChar,20),
                    new OracleParameter(":STATUS", OracleType.VarChar,20)};
            parameters[0].Value = model.CLIENT;
            parameters[1].Value = model.RECEIVED;
            parameters[2].Value = model.AGENT;
            parameters[3].Value = model.CLIENT_NUMBER;
            parameters[4].Value = model.FILING_DATE;
            parameters[5].Value = model.APPLICATION_NO;
            parameters[6].Value = model.EARLIEST_PRIORITY;
            parameters[7].Value = model.PUBLICATION;
            parameters[8].Value = model.FIRST_HK_DATE;
            parameters[9].Value = model.FIRST_HK_CANCELLED;
            parameters[10].Value = model.SE_STATUS;
            parameters[11].Value = model.SE_INITIATED;
            parameters[12].Value = model.OA_RECEIVED;
            parameters[13].Value = model.GAZETTE;
            parameters[14].Value = model.SECOND_HK_CANCELLED;
            parameters[15].Value = model.SECOND_HK_DATE;
            parameters[16].Value = model.REJECTED;
            parameters[17].Value = model.WITHDREW;
            parameters[18].Value = model.UNDER_INVALIDATE;
            parameters[19].Value = model.UNDER_REEXAMINATION;
            parameters[20].Value = model.UNDER_LITIGATION;
            parameters[21].Value = model.INVALIDATED;
            parameters[22].Value = model.OURNO;
            parameters[23].Value = model.CLIENT2;
            parameters[24].Value = model.CLIENT3;
            parameters[25].Value = model.APPLICANT1;
            parameters[26].Value = model.APPLICANT2;
            parameters[27].Value = model.APPLICANT3;
            parameters[28].Value = model.APPLICANT4;
            parameters[29].Value = model.APPLICANT5;
            parameters[30].Value = model.INVENTOR1;
            parameters[31].Value = model.INVENTOR2;
            parameters[32].Value = model.INVENTOR3;
            parameters[33].Value = model.INVENTOR4;
            parameters[34].Value = model.INVENTOR5;
            parameters[35].Value = model.INVENTOR6;
            parameters[36].Value = model.INVENTOR7;
            parameters[37].Value = model.TITLE;
            parameters[38].Value = model.PRI_COUNTRY;
            parameters[39].Value = model.PRI_NUMBER;
            parameters[40].Value = model.PRI_COUNTRY2;
            parameters[41].Value = model.PRI_NUMBER2;
            parameters[42].Value = model.PRI_COUNTRY3;
            parameters[43].Value = model.PRI_NUMBER3;
            parameters[44].Value = model.PRI_COUNTRY4;
            parameters[45].Value = model.PRI_NUMBER4;
            parameters[46].Value = model.PRI_COUNTRY5;
            parameters[47].Value = model.PRI_NUMBER5;
            parameters[48].Value = model.PCT_NUMBER;
            parameters[49].Value = model.PCT_APPN_DATE;
            parameters[50].Value = model.FILING_DUE;
            parameters[51].Value = model.PRI_DATE2;
            parameters[52].Value = model.PRI_DATE3;
            parameters[53].Value = model.PRI_DATE4;
            parameters[54].Value = model.PRI_DATE5;
            parameters[55].Value = model.INVENTOR8;
            parameters[56].Value = model.INVENTOR9;
            parameters[57].Value = model.INVENTOR10;
            parameters[58].Value = model.INVENTOR11;
            parameters[59].Value = model.INVENTOR12;
            parameters[60].Value = model.INVENTOR13;
            parameters[61].Value = model.INVENTOR14;
            parameters[62].Value = model.INVENTOR15;
            parameters[63].Value = model.COMMENTS;
            parameters[64].Value = model.PRI_NUMBER6;
            parameters[65].Value = model.PRI_DATE6;
            parameters[66].Value = model.PRI_COUNTRY6;
            parameters[67].Value = model.PRI_NUMBER7;
            parameters[68].Value = model.PRI_DATE7;
            parameters[69].Value = model.PRI_COUNTRY7;
            parameters[70].Value = model.PRI_NUMBER8;
            parameters[71].Value = model.PRI_DATE8;
            parameters[72].Value = model.PRI_COUNTRY8;
            parameters[73].Value = model.PRI_NUMBER9;
            parameters[74].Value = model.PRI_DATE9;
            parameters[75].Value = model.PRI_COUNTRY9;
            parameters[76].Value = model.PRI_NUMBER10;
            parameters[77].Value = model.PRI_DATE10;
            parameters[78].Value = model.PRI_COUNTRY10;
            parameters[79].Value = model.CLIENT_NAME;
            parameters[80].Value = model.TOTAL_PRI;
            parameters[81].Value = model.PCT_PUBDATE;
            parameters[82].Value = model.PCT_PUBNUM;
            parameters[83].Value = model.DEADLINE;
            parameters[84].Value = model.TITLE_CHINESE;
            parameters[85].Value = model.APPL_CODE1;
            parameters[86].Value = model.APPL_CODE2;
            parameters[87].Value = model.APPL_CODE3;
            parameters[88].Value = model.APPL_CODE4;
            parameters[89].Value = model.APPL_CODE5;
            parameters[90].Value = model.INVENTOR_CH1;
            parameters[91].Value = model.INVENTOR_CH2;
            parameters[92].Value = model.INVENTOR_CH3;
            parameters[93].Value = model.INVENTOR_CH4;
            parameters[94].Value = model.INVENTOR_CH5;
            parameters[95].Value = model.INVENTOR_CH6;
            parameters[96].Value = model.INVENTOR_CH7;
            parameters[97].Value = model.INVENTOR_CH8;
            parameters[98].Value = model.INVENTOR_CH9;
            parameters[99].Value = model.INVENTOR_CH10;
            parameters[100].Value = model.INVENTOR_CH11;
            parameters[101].Value = model.INVENTOR_CH12;
            parameters[102].Value = model.INVENTOR_CH13;
            parameters[103].Value = model.INVENTOR_CH14;
            parameters[104].Value = model.INVENTOR_CH15;
            parameters[105].Value = model.AGENT_ACTUAL;
            parameters[106].Value = model.APPN_COPY;
            parameters[107].Value = model.BILL_COPY;
            parameters[108].Value = model.MAILING_ADDR;
            parameters[109].Value = model.MAILING_CONTACT;
            parameters[110].Value = model.BILLING_CONTACT;
            parameters[111].Value = model.CHARCOUNT;
            parameters[112].Value = model.CLAIM_NUM;
            parameters[113].Value = model.LANGUAGE;
            parameters[114].Value = model.APPL_NUM;
            parameters[115].Value = model.INVEN_NUM;
            parameters[116].Value = model.PRE_EXAM_PASSED;
            parameters[117].Value = model.PUBLICATION_NO;
            parameters[118].Value = model.SE_DATE;
            parameters[119].Value = model.GRANTNOTIC_DATE;
            parameters[120].Value = model.REGFEE_DL;
            parameters[121].Value = model.REGFEE_SUBMIT;
            parameters[122].Value = model.ANNO_NO;
            parameters[123].Value = model.STATUS_DATE;
            parameters[124].Value = model.CLIENT_STATUS;
            parameters[125].Value = model.YFEE_DATE;
            parameters[126].Value = model.YFEE1;
            parameters[127].Value = model.YFEE2;
            parameters[128].Value = model.CERTIFICATE_NO;
            parameters[129].Value = model.CLIENT4;
            parameters[130].Value = model.CLIENT5;
            parameters[131].Value = model.OAGENT1;
            parameters[132].Value = model.OAGENT2;
            parameters[133].Value = model.SEFEE;
            parameters[134].Value = model.APPFEE;
            parameters[135].Value = model.IGNOREANNUALFEE;
            parameters[136].Value = model.APPLICANT_CH1;
            parameters[137].Value = model.APPLICANT_CH2;
            parameters[138].Value = model.APPLICANT_CH3;
            parameters[139].Value = model.APPLICANT_CH4;
            parameters[140].Value = model.APPLICANT_CH5;
            parameters[141].Value = model.INVENTOR16;
            parameters[142].Value = model.INVENTOR17;
            parameters[143].Value = model.INVENTOR18;
            parameters[144].Value = model.INVENTOR19;
            parameters[145].Value = model.INVENTOR20;
            parameters[146].Value = model.INVENTOR21;
            parameters[147].Value = model.INVENTOR_CH16;
            parameters[148].Value = model.INVENTOR_CH17;
            parameters[149].Value = model.INVENTOR_CH18;
            parameters[150].Value = model.INVENTOR_CH19;
            parameters[151].Value = model.INVENTOR_CH20;
            parameters[152].Value = model.INVENTOR_CH21;
            parameters[153].Value = model.TRANSLATOR;
            parameters[154].Value = model.CORRECTOR1;
            parameters[155].Value = model.CORRECTOR2;
            parameters[156].Value = model.URGENT_CO;
            parameters[157].Value = model.PRI_DATE11;
            parameters[158].Value = model.PRI_DATE12;
            parameters[159].Value = model.PRI_NUMBER11;
            parameters[160].Value = model.PRI_NUMBER12;
            parameters[161].Value = model.PRI_COUNTRY11;
            parameters[162].Value = model.PRI_COUNTRY12;
            parameters[163].Value = model.APP_REF;
            parameters[164].Value = model.DIV_FILINGDATE;
            parameters[165].Value = model.DIV_PARENTAPPNO;
            parameters[166].Value = model.STATUS;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PATENTCASE ");
            strSql.Append(" where OURNO=:OURNO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":OURNO", OracleType.VarChar,50)            };
            parameters[0].Value = OURNO;

            int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string OURNOlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PATENTCASE ");
            strSql.Append(" where OURNO in (" + OURNOlist + ")  ");
            int rows = DbHelperOra.ExecuteSql(strSql.ToString());
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
        public DataSyncTool.PC.Model.PATENTCASE GetModel(string OURNO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CLIENT,RECEIVED,AGENT,CLIENT_NUMBER,FILING_DATE,APPLICATION_NO,EARLIEST_PRIORITY,PUBLICATION,FIRST_HK_DATE,FIRST_HK_CANCELLED,SE_STATUS,SE_INITIATED,OA_RECEIVED,GAZETTE,SECOND_HK_CANCELLED,SECOND_HK_DATE,REJECTED,WITHDREW,UNDER_INVALIDATE,UNDER_REEXAMINATION,UNDER_LITIGATION,INVALIDATED,OURNO,CLIENT2,CLIENT3,APPLICANT1,APPLICANT2,APPLICANT3,APPLICANT4,APPLICANT5,INVENTOR1,INVENTOR2,INVENTOR3,INVENTOR4,INVENTOR5,INVENTOR6,INVENTOR7,TITLE,PRI_COUNTRY,PRI_NUMBER,PRI_COUNTRY2,PRI_NUMBER2,PRI_COUNTRY3,PRI_NUMBER3,PRI_COUNTRY4,PRI_NUMBER4,PRI_COUNTRY5,PRI_NUMBER5,PCT_NUMBER,PCT_APPN_DATE,FILING_DUE,PRI_DATE2,PRI_DATE3,PRI_DATE4,PRI_DATE5,INVENTOR8,INVENTOR9,INVENTOR10,INVENTOR11,INVENTOR12,INVENTOR13,INVENTOR14,INVENTOR15,COMMENTS,PRI_NUMBER6,PRI_DATE6,PRI_COUNTRY6,PRI_NUMBER7,PRI_DATE7,PRI_COUNTRY7,PRI_NUMBER8,PRI_DATE8,PRI_COUNTRY8,PRI_NUMBER9,PRI_DATE9,PRI_COUNTRY9,PRI_NUMBER10,PRI_DATE10,PRI_COUNTRY10,CLIENT_NAME,TOTAL_PRI,PCT_PUBDATE,PCT_PUBNUM,DEADLINE,TITLE_CHINESE,APPL_CODE1,APPL_CODE2,APPL_CODE3,APPL_CODE4,APPL_CODE5,INVENTOR_CH1,INVENTOR_CH2,INVENTOR_CH3,INVENTOR_CH4,INVENTOR_CH5,INVENTOR_CH6,INVENTOR_CH7,INVENTOR_CH8,INVENTOR_CH9,INVENTOR_CH10,INVENTOR_CH11,INVENTOR_CH12,INVENTOR_CH13,INVENTOR_CH14,INVENTOR_CH15,AGENT_ACTUAL,APPN_COPY,BILL_COPY,MAILING_ADDR,MAILING_CONTACT,BILLING_CONTACT,CHARCOUNT,CLAIM_NUM,LANGUAGE,APPL_NUM,INVEN_NUM,PRE_EXAM_PASSED,PUBLICATION_NO,SE_DATE,GRANTNOTIC_DATE,REGFEE_DL,REGFEE_SUBMIT,ANNO_NO,STATUS_DATE,CLIENT_STATUS,YFEE_DATE,YFEE1,YFEE2,CERTIFICATE_NO,CLIENT4,CLIENT5,OAGENT1,OAGENT2,SEFEE,APPFEE,IGNOREANNUALFEE,APPLICANT_CH1,APPLICANT_CH2,APPLICANT_CH3,APPLICANT_CH4,APPLICANT_CH5,INVENTOR16,INVENTOR17,INVENTOR18,INVENTOR19,INVENTOR20,INVENTOR21,INVENTOR_CH16,INVENTOR_CH17,INVENTOR_CH18,INVENTOR_CH19,INVENTOR_CH20,INVENTOR_CH21,TRANSLATOR,CORRECTOR1,CORRECTOR2,URGENT_CO,PRI_DATE11,PRI_DATE12,PRI_NUMBER11,PRI_NUMBER12,PRI_COUNTRY11,PRI_COUNTRY12,APP_REF,DIV_FILINGDATE,DIV_PARENTAPPNO,STATUS from PATENTCASE ");
            strSql.Append(" where OURNO=:OURNO ");
            OracleParameter[] parameters = {
                    new OracleParameter(":OURNO", OracleType.VarChar,50)            };
            parameters[0].Value = OURNO;

            DataSyncTool.PC.Model.PATENTCASE model = new DataSyncTool.PC.Model.PATENTCASE();
            DataSet ds = DbHelperOra.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public DataSyncTool.PC.Model.PATENTCASE DataRowToModel(DataRow row)
        {
            DataSyncTool.PC.Model.PATENTCASE model = new DataSyncTool.PC.Model.PATENTCASE();
            if (row != null)
            {
                if (row["CLIENT"] != null)
                {
                    model.CLIENT = row["CLIENT"].ToString();
                }
                if (row["RECEIVED"] != null && row["RECEIVED"].ToString() != "")
                {
                    model.RECEIVED = DateTime.Parse(row["RECEIVED"].ToString());
                }
                if (row["AGENT"] != null)
                {
                    model.AGENT = row["AGENT"].ToString();
                }
                if (row["CLIENT_NUMBER"] != null)
                {
                    model.CLIENT_NUMBER = row["CLIENT_NUMBER"].ToString();
                }
                if (row["FILING_DATE"] != null && row["FILING_DATE"].ToString() != "")
                {
                    model.FILING_DATE = DateTime.Parse(row["FILING_DATE"].ToString());
                }
                if (row["APPLICATION_NO"] != null)
                {
                    model.APPLICATION_NO = row["APPLICATION_NO"].ToString();
                }
                if (row["EARLIEST_PRIORITY"] != null && row["EARLIEST_PRIORITY"].ToString() != "")
                {
                    model.EARLIEST_PRIORITY = DateTime.Parse(row["EARLIEST_PRIORITY"].ToString());
                }
                if (row["PUBLICATION"] != null && row["PUBLICATION"].ToString() != "")
                {
                    model.PUBLICATION = DateTime.Parse(row["PUBLICATION"].ToString());
                }
                if (row["FIRST_HK_DATE"] != null && row["FIRST_HK_DATE"].ToString() != "")
                {
                    model.FIRST_HK_DATE = DateTime.Parse(row["FIRST_HK_DATE"].ToString());
                }
                if (row["FIRST_HK_CANCELLED"] != null)
                {
                    model.FIRST_HK_CANCELLED = row["FIRST_HK_CANCELLED"].ToString();
                }
                if (row["SE_STATUS"] != null)
                {
                    model.SE_STATUS = row["SE_STATUS"].ToString();
                }
                if (row["SE_INITIATED"] != null)
                {
                    model.SE_INITIATED = row["SE_INITIATED"].ToString();
                }
                if (row["OA_RECEIVED"] != null)
                {
                    model.OA_RECEIVED = row["OA_RECEIVED"].ToString();
                }
                if (row["GAZETTE"] != null && row["GAZETTE"].ToString() != "")
                {
                    model.GAZETTE = DateTime.Parse(row["GAZETTE"].ToString());
                }
                if (row["SECOND_HK_CANCELLED"] != null)
                {
                    model.SECOND_HK_CANCELLED = row["SECOND_HK_CANCELLED"].ToString();
                }
                if (row["SECOND_HK_DATE"] != null && row["SECOND_HK_DATE"].ToString() != "")
                {
                    model.SECOND_HK_DATE = DateTime.Parse(row["SECOND_HK_DATE"].ToString());
                }
                if (row["REJECTED"] != null)
                {
                    model.REJECTED = row["REJECTED"].ToString();
                }
                if (row["WITHDREW"] != null)
                {
                    model.WITHDREW = row["WITHDREW"].ToString();
                }
                if (row["UNDER_INVALIDATE"] != null)
                {
                    model.UNDER_INVALIDATE = row["UNDER_INVALIDATE"].ToString();
                }
                if (row["UNDER_REEXAMINATION"] != null)
                {
                    model.UNDER_REEXAMINATION = row["UNDER_REEXAMINATION"].ToString();
                }
                if (row["UNDER_LITIGATION"] != null)
                {
                    model.UNDER_LITIGATION = row["UNDER_LITIGATION"].ToString();
                }
                if (row["INVALIDATED"] != null)
                {
                    model.INVALIDATED = row["INVALIDATED"].ToString();
                }
                if (row["OURNO"] != null)
                {
                    model.OURNO = row["OURNO"].ToString();
                }
                if (row["CLIENT2"] != null)
                {
                    model.CLIENT2 = row["CLIENT2"].ToString();
                }
                if (row["CLIENT3"] != null)
                {
                    model.CLIENT3 = row["CLIENT3"].ToString();
                }
                if (row["APPLICANT1"] != null)
                {
                    model.APPLICANT1 = row["APPLICANT1"].ToString();
                }
                if (row["APPLICANT2"] != null)
                {
                    model.APPLICANT2 = row["APPLICANT2"].ToString();
                }
                if (row["APPLICANT3"] != null)
                {
                    model.APPLICANT3 = row["APPLICANT3"].ToString();
                }
                if (row["APPLICANT4"] != null)
                {
                    model.APPLICANT4 = row["APPLICANT4"].ToString();
                }
                if (row["APPLICANT5"] != null)
                {
                    model.APPLICANT5 = row["APPLICANT5"].ToString();
                }
                if (row["INVENTOR1"] != null)
                {
                    model.INVENTOR1 = row["INVENTOR1"].ToString();
                }
                if (row["INVENTOR2"] != null)
                {
                    model.INVENTOR2 = row["INVENTOR2"].ToString();
                }
                if (row["INVENTOR3"] != null)
                {
                    model.INVENTOR3 = row["INVENTOR3"].ToString();
                }
                if (row["INVENTOR4"] != null)
                {
                    model.INVENTOR4 = row["INVENTOR4"].ToString();
                }
                if (row["INVENTOR5"] != null)
                {
                    model.INVENTOR5 = row["INVENTOR5"].ToString();
                }
                if (row["INVENTOR6"] != null)
                {
                    model.INVENTOR6 = row["INVENTOR6"].ToString();
                }
                if (row["INVENTOR7"] != null)
                {
                    model.INVENTOR7 = row["INVENTOR7"].ToString();
                }
                if (row["TITLE"] != null)
                {
                    model.TITLE = row["TITLE"].ToString();
                }
                if (row["PRI_COUNTRY"] != null)
                {
                    model.PRI_COUNTRY = row["PRI_COUNTRY"].ToString();
                }
                if (row["PRI_NUMBER"] != null)
                {
                    model.PRI_NUMBER = row["PRI_NUMBER"].ToString();
                }
                if (row["PRI_COUNTRY2"] != null)
                {
                    model.PRI_COUNTRY2 = row["PRI_COUNTRY2"].ToString();
                }
                if (row["PRI_NUMBER2"] != null)
                {
                    model.PRI_NUMBER2 = row["PRI_NUMBER2"].ToString();
                }
                if (row["PRI_COUNTRY3"] != null)
                {
                    model.PRI_COUNTRY3 = row["PRI_COUNTRY3"].ToString();
                }
                if (row["PRI_NUMBER3"] != null)
                {
                    model.PRI_NUMBER3 = row["PRI_NUMBER3"].ToString();
                }
                if (row["PRI_COUNTRY4"] != null)
                {
                    model.PRI_COUNTRY4 = row["PRI_COUNTRY4"].ToString();
                }
                if (row["PRI_NUMBER4"] != null)
                {
                    model.PRI_NUMBER4 = row["PRI_NUMBER4"].ToString();
                }
                if (row["PRI_COUNTRY5"] != null)
                {
                    model.PRI_COUNTRY5 = row["PRI_COUNTRY5"].ToString();
                }
                if (row["PRI_NUMBER5"] != null)
                {
                    model.PRI_NUMBER5 = row["PRI_NUMBER5"].ToString();
                }
                if (row["PCT_NUMBER"] != null)
                {
                    model.PCT_NUMBER = row["PCT_NUMBER"].ToString();
                }
                if (row["PCT_APPN_DATE"] != null && row["PCT_APPN_DATE"].ToString() != "")
                {
                    model.PCT_APPN_DATE = DateTime.Parse(row["PCT_APPN_DATE"].ToString());
                }
                if (row["FILING_DUE"] != null && row["FILING_DUE"].ToString() != "")
                {
                    model.FILING_DUE = DateTime.Parse(row["FILING_DUE"].ToString());
                }
                if (row["PRI_DATE2"] != null && row["PRI_DATE2"].ToString() != "")
                {
                    model.PRI_DATE2 = DateTime.Parse(row["PRI_DATE2"].ToString());
                }
                if (row["PRI_DATE3"] != null && row["PRI_DATE3"].ToString() != "")
                {
                    model.PRI_DATE3 = DateTime.Parse(row["PRI_DATE3"].ToString());
                }
                if (row["PRI_DATE4"] != null && row["PRI_DATE4"].ToString() != "")
                {
                    model.PRI_DATE4 = DateTime.Parse(row["PRI_DATE4"].ToString());
                }
                if (row["PRI_DATE5"] != null && row["PRI_DATE5"].ToString() != "")
                {
                    model.PRI_DATE5 = DateTime.Parse(row["PRI_DATE5"].ToString());
                }
                if (row["INVENTOR8"] != null)
                {
                    model.INVENTOR8 = row["INVENTOR8"].ToString();
                }
                if (row["INVENTOR9"] != null)
                {
                    model.INVENTOR9 = row["INVENTOR9"].ToString();
                }
                if (row["INVENTOR10"] != null)
                {
                    model.INVENTOR10 = row["INVENTOR10"].ToString();
                }
                if (row["INVENTOR11"] != null)
                {
                    model.INVENTOR11 = row["INVENTOR11"].ToString();
                }
                if (row["INVENTOR12"] != null)
                {
                    model.INVENTOR12 = row["INVENTOR12"].ToString();
                }
                if (row["INVENTOR13"] != null)
                {
                    model.INVENTOR13 = row["INVENTOR13"].ToString();
                }
                if (row["INVENTOR14"] != null)
                {
                    model.INVENTOR14 = row["INVENTOR14"].ToString();
                }
                if (row["INVENTOR15"] != null)
                {
                    model.INVENTOR15 = row["INVENTOR15"].ToString();
                }
                if (row["COMMENTS"] != null)
                {
                    model.COMMENTS = row["COMMENTS"].ToString();
                }
                if (row["PRI_NUMBER6"] != null)
                {
                    model.PRI_NUMBER6 = row["PRI_NUMBER6"].ToString();
                }
                if (row["PRI_DATE6"] != null && row["PRI_DATE6"].ToString() != "")
                {
                    model.PRI_DATE6 = DateTime.Parse(row["PRI_DATE6"].ToString());
                }
                if (row["PRI_COUNTRY6"] != null)
                {
                    model.PRI_COUNTRY6 = row["PRI_COUNTRY6"].ToString();
                }
                if (row["PRI_NUMBER7"] != null)
                {
                    model.PRI_NUMBER7 = row["PRI_NUMBER7"].ToString();
                }
                if (row["PRI_DATE7"] != null && row["PRI_DATE7"].ToString() != "")
                {
                    model.PRI_DATE7 = DateTime.Parse(row["PRI_DATE7"].ToString());
                }
                if (row["PRI_COUNTRY7"] != null)
                {
                    model.PRI_COUNTRY7 = row["PRI_COUNTRY7"].ToString();
                }
                if (row["PRI_NUMBER8"] != null)
                {
                    model.PRI_NUMBER8 = row["PRI_NUMBER8"].ToString();
                }
                if (row["PRI_DATE8"] != null && row["PRI_DATE8"].ToString() != "")
                {
                    model.PRI_DATE8 = DateTime.Parse(row["PRI_DATE8"].ToString());
                }
                if (row["PRI_COUNTRY8"] != null)
                {
                    model.PRI_COUNTRY8 = row["PRI_COUNTRY8"].ToString();
                }
                if (row["PRI_NUMBER9"] != null)
                {
                    model.PRI_NUMBER9 = row["PRI_NUMBER9"].ToString();
                }
                if (row["PRI_DATE9"] != null && row["PRI_DATE9"].ToString() != "")
                {
                    model.PRI_DATE9 = DateTime.Parse(row["PRI_DATE9"].ToString());
                }
                if (row["PRI_COUNTRY9"] != null)
                {
                    model.PRI_COUNTRY9 = row["PRI_COUNTRY9"].ToString();
                }
                if (row["PRI_NUMBER10"] != null)
                {
                    model.PRI_NUMBER10 = row["PRI_NUMBER10"].ToString();
                }
                if (row["PRI_DATE10"] != null && row["PRI_DATE10"].ToString() != "")
                {
                    model.PRI_DATE10 = DateTime.Parse(row["PRI_DATE10"].ToString());
                }
                if (row["PRI_COUNTRY10"] != null)
                {
                    model.PRI_COUNTRY10 = row["PRI_COUNTRY10"].ToString();
                }
                if (row["CLIENT_NAME"] != null)
                {
                    model.CLIENT_NAME = row["CLIENT_NAME"].ToString();
                }
                if (row["TOTAL_PRI"] != null && row["TOTAL_PRI"].ToString() != "")
                {
                    model.TOTAL_PRI = decimal.Parse(row["TOTAL_PRI"].ToString());
                }
                if (row["PCT_PUBDATE"] != null && row["PCT_PUBDATE"].ToString() != "")
                {
                    model.PCT_PUBDATE = DateTime.Parse(row["PCT_PUBDATE"].ToString());
                }
                if (row["PCT_PUBNUM"] != null)
                {
                    model.PCT_PUBNUM = row["PCT_PUBNUM"].ToString();
                }
                if (row["DEADLINE"] != null && row["DEADLINE"].ToString() != "")
                {
                    model.DEADLINE = DateTime.Parse(row["DEADLINE"].ToString());
                }
                if (row["TITLE_CHINESE"] != null)
                {
                    model.TITLE_CHINESE = row["TITLE_CHINESE"].ToString();
                }
                if (row["APPL_CODE1"] != null)
                {
                    model.APPL_CODE1 = row["APPL_CODE1"].ToString();
                }
                if (row["APPL_CODE2"] != null)
                {
                    model.APPL_CODE2 = row["APPL_CODE2"].ToString();
                }
                if (row["APPL_CODE3"] != null)
                {
                    model.APPL_CODE3 = row["APPL_CODE3"].ToString();
                }
                if (row["APPL_CODE4"] != null)
                {
                    model.APPL_CODE4 = row["APPL_CODE4"].ToString();
                }
                if (row["APPL_CODE5"] != null)
                {
                    model.APPL_CODE5 = row["APPL_CODE5"].ToString();
                }
                if (row["INVENTOR_CH1"] != null)
                {
                    model.INVENTOR_CH1 = row["INVENTOR_CH1"].ToString();
                }
                if (row["INVENTOR_CH2"] != null)
                {
                    model.INVENTOR_CH2 = row["INVENTOR_CH2"].ToString();
                }
                if (row["INVENTOR_CH3"] != null)
                {
                    model.INVENTOR_CH3 = row["INVENTOR_CH3"].ToString();
                }
                if (row["INVENTOR_CH4"] != null)
                {
                    model.INVENTOR_CH4 = row["INVENTOR_CH4"].ToString();
                }
                if (row["INVENTOR_CH5"] != null)
                {
                    model.INVENTOR_CH5 = row["INVENTOR_CH5"].ToString();
                }
                if (row["INVENTOR_CH6"] != null)
                {
                    model.INVENTOR_CH6 = row["INVENTOR_CH6"].ToString();
                }
                if (row["INVENTOR_CH7"] != null)
                {
                    model.INVENTOR_CH7 = row["INVENTOR_CH7"].ToString();
                }
                if (row["INVENTOR_CH8"] != null)
                {
                    model.INVENTOR_CH8 = row["INVENTOR_CH8"].ToString();
                }
                if (row["INVENTOR_CH9"] != null)
                {
                    model.INVENTOR_CH9 = row["INVENTOR_CH9"].ToString();
                }
                if (row["INVENTOR_CH10"] != null)
                {
                    model.INVENTOR_CH10 = row["INVENTOR_CH10"].ToString();
                }
                if (row["INVENTOR_CH11"] != null)
                {
                    model.INVENTOR_CH11 = row["INVENTOR_CH11"].ToString();
                }
                if (row["INVENTOR_CH12"] != null)
                {
                    model.INVENTOR_CH12 = row["INVENTOR_CH12"].ToString();
                }
                if (row["INVENTOR_CH13"] != null)
                {
                    model.INVENTOR_CH13 = row["INVENTOR_CH13"].ToString();
                }
                if (row["INVENTOR_CH14"] != null)
                {
                    model.INVENTOR_CH14 = row["INVENTOR_CH14"].ToString();
                }
                if (row["INVENTOR_CH15"] != null)
                {
                    model.INVENTOR_CH15 = row["INVENTOR_CH15"].ToString();
                }
                if (row["AGENT_ACTUAL"] != null)
                {
                    model.AGENT_ACTUAL = row["AGENT_ACTUAL"].ToString();
                }
                if (row["APPN_COPY"] != null && row["APPN_COPY"].ToString() != "")
                {
                    model.APPN_COPY = decimal.Parse(row["APPN_COPY"].ToString());
                }
                if (row["BILL_COPY"] != null && row["BILL_COPY"].ToString() != "")
                {
                    model.BILL_COPY = decimal.Parse(row["BILL_COPY"].ToString());
                }
                if (row["MAILING_ADDR"] != null)
                {
                    model.MAILING_ADDR = row["MAILING_ADDR"].ToString();
                }
                if (row["MAILING_CONTACT"] != null)
                {
                    model.MAILING_CONTACT = row["MAILING_CONTACT"].ToString();
                }
                if (row["BILLING_CONTACT"] != null)
                {
                    model.BILLING_CONTACT = row["BILLING_CONTACT"].ToString();
                }
                if (row["CHARCOUNT"] != null && row["CHARCOUNT"].ToString() != "")
                {
                    model.CHARCOUNT = decimal.Parse(row["CHARCOUNT"].ToString());
                }
                if (row["CLAIM_NUM"] != null && row["CLAIM_NUM"].ToString() != "")
                {
                    model.CLAIM_NUM = decimal.Parse(row["CLAIM_NUM"].ToString());
                }
                if (row["LANGUAGE"] != null)
                {
                    model.LANGUAGE = row["LANGUAGE"].ToString();
                }
                if (row["APPL_NUM"] != null && row["APPL_NUM"].ToString() != "")
                {
                    model.APPL_NUM = decimal.Parse(row["APPL_NUM"].ToString());
                }
                if (row["INVEN_NUM"] != null && row["INVEN_NUM"].ToString() != "")
                {
                    model.INVEN_NUM = decimal.Parse(row["INVEN_NUM"].ToString());
                }
                if (row["PRE_EXAM_PASSED"] != null && row["PRE_EXAM_PASSED"].ToString() != "")
                {
                    model.PRE_EXAM_PASSED = DateTime.Parse(row["PRE_EXAM_PASSED"].ToString());
                }
                if (row["PUBLICATION_NO"] != null)
                {
                    model.PUBLICATION_NO = row["PUBLICATION_NO"].ToString();
                }
                if (row["SE_DATE"] != null && row["SE_DATE"].ToString() != "")
                {
                    model.SE_DATE = DateTime.Parse(row["SE_DATE"].ToString());
                }
                if (row["GRANTNOTIC_DATE"] != null && row["GRANTNOTIC_DATE"].ToString() != "")
                {
                    model.GRANTNOTIC_DATE = DateTime.Parse(row["GRANTNOTIC_DATE"].ToString());
                }
                if (row["REGFEE_DL"] != null && row["REGFEE_DL"].ToString() != "")
                {
                    model.REGFEE_DL = DateTime.Parse(row["REGFEE_DL"].ToString());
                }
                if (row["REGFEE_SUBMIT"] != null && row["REGFEE_SUBMIT"].ToString() != "")
                {
                    model.REGFEE_SUBMIT = DateTime.Parse(row["REGFEE_SUBMIT"].ToString());
                }
                if (row["ANNO_NO"] != null)
                {
                    model.ANNO_NO = row["ANNO_NO"].ToString();
                }
                if (row["STATUS_DATE"] != null && row["STATUS_DATE"].ToString() != "")
                {
                    model.STATUS_DATE = DateTime.Parse(row["STATUS_DATE"].ToString());
                }
                if (row["CLIENT_STATUS"] != null)
                {
                    model.CLIENT_STATUS = row["CLIENT_STATUS"].ToString();
                }
                if (row["YFEE_DATE"] != null && row["YFEE_DATE"].ToString() != "")
                {
                    model.YFEE_DATE = DateTime.Parse(row["YFEE_DATE"].ToString());
                }
                if (row["YFEE1"] != null && row["YFEE1"].ToString() != "")
                {
                    model.YFEE1 = DateTime.Parse(row["YFEE1"].ToString());
                }
                if (row["YFEE2"] != null && row["YFEE2"].ToString() != "")
                {
                    model.YFEE2 = DateTime.Parse(row["YFEE2"].ToString());
                }
                if (row["CERTIFICATE_NO"] != null && row["CERTIFICATE_NO"].ToString() != "")
                {
                    model.CERTIFICATE_NO = decimal.Parse(row["CERTIFICATE_NO"].ToString());
                }
                if (row["CLIENT4"] != null)
                {
                    model.CLIENT4 = row["CLIENT4"].ToString();
                }
                if (row["CLIENT5"] != null)
                {
                    model.CLIENT5 = row["CLIENT5"].ToString();
                }
                if (row["OAGENT1"] != null)
                {
                    model.OAGENT1 = row["OAGENT1"].ToString();
                }
                if (row["OAGENT2"] != null)
                {
                    model.OAGENT2 = row["OAGENT2"].ToString();
                }
                if (row["SEFEE"] != null)
                {
                    model.SEFEE = row["SEFEE"].ToString();
                }
                if (row["APPFEE"] != null)
                {
                    model.APPFEE = row["APPFEE"].ToString();
                }
                if (row["IGNOREANNUALFEE"] != null)
                {
                    model.IGNOREANNUALFEE = row["IGNOREANNUALFEE"].ToString();
                }
                if (row["APPLICANT_CH1"] != null)
                {
                    model.APPLICANT_CH1 = row["APPLICANT_CH1"].ToString();
                }
                if (row["APPLICANT_CH2"] != null)
                {
                    model.APPLICANT_CH2 = row["APPLICANT_CH2"].ToString();
                }
                if (row["APPLICANT_CH3"] != null)
                {
                    model.APPLICANT_CH3 = row["APPLICANT_CH3"].ToString();
                }
                if (row["APPLICANT_CH4"] != null)
                {
                    model.APPLICANT_CH4 = row["APPLICANT_CH4"].ToString();
                }
                if (row["APPLICANT_CH5"] != null)
                {
                    model.APPLICANT_CH5 = row["APPLICANT_CH5"].ToString();
                }
                if (row["INVENTOR16"] != null)
                {
                    model.INVENTOR16 = row["INVENTOR16"].ToString();
                }
                if (row["INVENTOR17"] != null)
                {
                    model.INVENTOR17 = row["INVENTOR17"].ToString();
                }
                if (row["INVENTOR18"] != null)
                {
                    model.INVENTOR18 = row["INVENTOR18"].ToString();
                }
                if (row["INVENTOR19"] != null)
                {
                    model.INVENTOR19 = row["INVENTOR19"].ToString();
                }
                if (row["INVENTOR20"] != null)
                {
                    model.INVENTOR20 = row["INVENTOR20"].ToString();
                }
                if (row["INVENTOR21"] != null)
                {
                    model.INVENTOR21 = row["INVENTOR21"].ToString();
                }
                if (row["INVENTOR_CH16"] != null)
                {
                    model.INVENTOR_CH16 = row["INVENTOR_CH16"].ToString();
                }
                if (row["INVENTOR_CH17"] != null)
                {
                    model.INVENTOR_CH17 = row["INVENTOR_CH17"].ToString();
                }
                if (row["INVENTOR_CH18"] != null)
                {
                    model.INVENTOR_CH18 = row["INVENTOR_CH18"].ToString();
                }
                if (row["INVENTOR_CH19"] != null)
                {
                    model.INVENTOR_CH19 = row["INVENTOR_CH19"].ToString();
                }
                if (row["INVENTOR_CH20"] != null)
                {
                    model.INVENTOR_CH20 = row["INVENTOR_CH20"].ToString();
                }
                if (row["INVENTOR_CH21"] != null)
                {
                    model.INVENTOR_CH21 = row["INVENTOR_CH21"].ToString();
                }
                if (row["TRANSLATOR"] != null)
                {
                    model.TRANSLATOR = row["TRANSLATOR"].ToString();
                }
                if (row["CORRECTOR1"] != null)
                {
                    model.CORRECTOR1 = row["CORRECTOR1"].ToString();
                }
                if (row["CORRECTOR2"] != null)
                {
                    model.CORRECTOR2 = row["CORRECTOR2"].ToString();
                }
                if (row["URGENT_CO"] != null && row["URGENT_CO"].ToString() != "")
                {
                    model.URGENT_CO = decimal.Parse(row["URGENT_CO"].ToString());
                }
                if (row["PRI_DATE11"] != null && row["PRI_DATE11"].ToString() != "")
                {
                    model.PRI_DATE11 = DateTime.Parse(row["PRI_DATE11"].ToString());
                }
                if (row["PRI_DATE12"] != null && row["PRI_DATE12"].ToString() != "")
                {
                    model.PRI_DATE12 = DateTime.Parse(row["PRI_DATE12"].ToString());
                }
                if (row["PRI_NUMBER11"] != null)
                {
                    model.PRI_NUMBER11 = row["PRI_NUMBER11"].ToString();
                }
                if (row["PRI_NUMBER12"] != null)
                {
                    model.PRI_NUMBER12 = row["PRI_NUMBER12"].ToString();
                }
                if (row["PRI_COUNTRY11"] != null)
                {
                    model.PRI_COUNTRY11 = row["PRI_COUNTRY11"].ToString();
                }
                if (row["PRI_COUNTRY12"] != null)
                {
                    model.PRI_COUNTRY12 = row["PRI_COUNTRY12"].ToString();
                }
                if (row["APP_REF"] != null)
                {
                    model.APP_REF = row["APP_REF"].ToString();
                }
                if (row["DIV_FILINGDATE"] != null && row["DIV_FILINGDATE"].ToString() != "")
                {
                    model.DIV_FILINGDATE = DateTime.Parse(row["DIV_FILINGDATE"].ToString());
                }
                if (row["DIV_PARENTAPPNO"] != null)
                {
                    model.DIV_PARENTAPPNO = row["DIV_PARENTAPPNO"].ToString();
                }
                if (row["STATUS"] != null)
                {
                    model.STATUS = row["STATUS"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CLIENT,RECEIVED,AGENT,CLIENT_NUMBER,FILING_DATE,APPLICATION_NO,EARLIEST_PRIORITY,PUBLICATION,FIRST_HK_DATE,FIRST_HK_CANCELLED,SE_STATUS,SE_INITIATED,OA_RECEIVED,GAZETTE,SECOND_HK_CANCELLED,SECOND_HK_DATE,REJECTED,WITHDREW,UNDER_INVALIDATE,UNDER_REEXAMINATION,UNDER_LITIGATION,INVALIDATED,OURNO,CLIENT2,CLIENT3,APPLICANT1,APPLICANT2,APPLICANT3,APPLICANT4,APPLICANT5,INVENTOR1,INVENTOR2,INVENTOR3,INVENTOR4,INVENTOR5,INVENTOR6,INVENTOR7,TITLE,PRI_COUNTRY,PRI_NUMBER,PRI_COUNTRY2,PRI_NUMBER2,PRI_COUNTRY3,PRI_NUMBER3,PRI_COUNTRY4,PRI_NUMBER4,PRI_COUNTRY5,PRI_NUMBER5,PCT_NUMBER,PCT_APPN_DATE,FILING_DUE,PRI_DATE2,PRI_DATE3,PRI_DATE4,PRI_DATE5,INVENTOR8,INVENTOR9,INVENTOR10,INVENTOR11,INVENTOR12,INVENTOR13,INVENTOR14,INVENTOR15,COMMENTS,PRI_NUMBER6,PRI_DATE6,PRI_COUNTRY6,PRI_NUMBER7,PRI_DATE7,PRI_COUNTRY7,PRI_NUMBER8,PRI_DATE8,PRI_COUNTRY8,PRI_NUMBER9,PRI_DATE9,PRI_COUNTRY9,PRI_NUMBER10,PRI_DATE10,PRI_COUNTRY10,CLIENT_NAME,TOTAL_PRI,PCT_PUBDATE,PCT_PUBNUM,DEADLINE,TITLE_CHINESE,APPL_CODE1,APPL_CODE2,APPL_CODE3,APPL_CODE4,APPL_CODE5,INVENTOR_CH1,INVENTOR_CH2,INVENTOR_CH3,INVENTOR_CH4,INVENTOR_CH5,INVENTOR_CH6,INVENTOR_CH7,INVENTOR_CH8,INVENTOR_CH9,INVENTOR_CH10,INVENTOR_CH11,INVENTOR_CH12,INVENTOR_CH13,INVENTOR_CH14,INVENTOR_CH15,AGENT_ACTUAL,APPN_COPY,BILL_COPY,MAILING_ADDR,MAILING_CONTACT,BILLING_CONTACT,CHARCOUNT,CLAIM_NUM,LANGUAGE,APPL_NUM,INVEN_NUM,PRE_EXAM_PASSED,PUBLICATION_NO,SE_DATE,GRANTNOTIC_DATE,REGFEE_DL,REGFEE_SUBMIT,ANNO_NO,STATUS_DATE,CLIENT_STATUS,YFEE_DATE,YFEE1,YFEE2,CERTIFICATE_NO,CLIENT4,CLIENT5,OAGENT1,OAGENT2,SEFEE,APPFEE,IGNOREANNUALFEE,APPLICANT_CH1,APPLICANT_CH2,APPLICANT_CH3,APPLICANT_CH4,APPLICANT_CH5,INVENTOR16,INVENTOR17,INVENTOR18,INVENTOR19,INVENTOR20,INVENTOR21,INVENTOR_CH16,INVENTOR_CH17,INVENTOR_CH18,INVENTOR_CH19,INVENTOR_CH20,INVENTOR_CH21,TRANSLATOR,CORRECTOR1,CORRECTOR2,URGENT_CO,PRI_DATE11,PRI_DATE12,PRI_NUMBER11,PRI_NUMBER12,PRI_COUNTRY11,PRI_COUNTRY12,APP_REF,DIV_FILINGDATE,DIV_PARENTAPPNO,STATUS ");
            strSql.Append(" FROM PATENTCASE ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOra.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM PATENTCASE ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.OURNO desc");
            }
            strSql.Append(")AS Row, T.*  from PATENTCASE T ");
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
			parameters[0].Value = "PATENTCASE";
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

