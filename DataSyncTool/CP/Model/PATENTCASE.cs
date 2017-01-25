using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// PATENTCASE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PATENTCASE
	{
		public PATENTCASE()
		{}
		#region Model
		private string _client;
		private DateTime _received;
		private string _agent;
		private string _client_number;
		private DateTime _filing_date;
		private string _application_no;
		private DateTime _earliest_priority;
		private DateTime _publication;
		private DateTime _first_hk_date;
		private string _first_hk_cancelled;
		private string _se_status;
		private string _se_initiated;
		private string _oa_received;
		private DateTime _gazette;
		private string _second_hk_cancelled;
		private DateTime _second_hk_date;
		private string _rejected;
		private string _withdrew;
		private string _under_invalidate;
		private string _under_reexamination;
		private string _under_litigation;
		private string _invalidated;
		private string _ourno;
		private string _client2;
		private string _client3;
		private string _applicant1;
		private string _applicant2;
		private string _applicant3;
		private string _applicant4;
		private string _applicant5;
		private string _inventor1;
		private string _inventor2;
		private string _inventor3;
		private string _inventor4;
		private string _inventor5;
		private string _inventor6;
		private string _inventor7;
		private string _title;
		private string _pri_country;
		private string _pri_number;
		private string _pri_country2;
		private string _pri_number2;
		private string _pri_country3;
		private string _pri_number3;
		private string _pri_country4;
		private string _pri_number4;
		private string _pri_country5;
		private string _pri_number5;
		private string _pct_number;
		private DateTime _pct_appn_date;
		private DateTime _filing_due;
		private DateTime _pri_date2;
		private DateTime _pri_date3;
		private DateTime _pri_date4;
		private DateTime _pri_date5;
		private string _inventor8;
		private string _inventor9;
		private string _inventor10;
		private string _inventor11;
		private string _inventor12;
		private string _inventor13;
		private string _inventor14;
		private string _inventor15;
		private string _comments;
		private string _pri_number6;
		private DateTime _pri_date6;
		private string _pri_country6;
		private string _pri_number7;
		private DateTime _pri_date7;
		private string _pri_country7;
		private string _pri_number8;
		private DateTime _pri_date8;
		private string _pri_country8;
		private string _pri_number9;
		private DateTime _pri_date9;
		private string _pri_country9;
		private string _pri_number10;
		private DateTime _pri_date10;
		private string _pri_country10;
		private string _client_name;
		private decimal _total_pri;
		private DateTime _pct_pubdate;
		private string _pct_pubnum;
		private DateTime _deadline;
		private string _title_chinese;
		private string _appl_code1;
		private string _appl_code2;
		private string _appl_code3;
		private string _appl_code4;
		private string _appl_code5;
		private string _inventor_ch1;
		private string _inventor_ch2;
		private string _inventor_ch3;
		private string _inventor_ch4;
		private string _inventor_ch5;
		private string _inventor_ch6;
		private string _inventor_ch7;
		private string _inventor_ch8;
		private string _inventor_ch9;
		private string _inventor_ch10;
		private string _inventor_ch11;
		private string _inventor_ch12;
		private string _inventor_ch13;
		private string _inventor_ch14;
		private string _inventor_ch15;
		private string _agent_actual;
		private decimal _appn_copy;
		private decimal _bill_copy;
		private string _mailing_addr;
		private string _mailing_contact;
		private string _billing_contact;
		private decimal _charcount;
		private decimal _claim_num;
		private string _language;
		private decimal _appl_num;
		private decimal _inven_num;
		private DateTime _pre_exam_passed;
		private string _publication_no;
		private DateTime _se_date;
		private DateTime _grantnotic_date;
		private DateTime _regfee_dl;
		private DateTime _regfee_submit;
		private string _anno_no;
		private DateTime _status_date;
		private string _client_status;
		private DateTime _yfee_date;
		private DateTime _yfee1;
		private DateTime _yfee2;
		private decimal _certificate_no;
		private string _client4;
		private string _client5;
		private string _oagent1;
		private string _oagent2;
		private string _sefee;
		private string _appfee;
		private string _ignoreannualfee;
		private string _applicant_ch1;
		private string _applicant_ch2;
		private string _applicant_ch3;
		private string _applicant_ch4;
		private string _applicant_ch5;
		private string _inventor16;
		private string _inventor17;
		private string _inventor18;
		private string _inventor19;
		private string _inventor20;
		private string _inventor21;
		private string _inventor_ch16;
		private string _inventor_ch17;
		private string _inventor_ch18;
		private string _inventor_ch19;
		private string _inventor_ch20;
		private string _inventor_ch21;
		private string _translator;
		private string _corrector1;
		private string _corrector2;
		private decimal _urgent_co;
		private DateTime _pri_date11;
		private DateTime _pri_date12;
		private string _pri_number11;
		private string _pri_number12;
		private string _pri_country11;
		private string _pri_country12;
		private string _app_ref;
		private DateTime _div_filingdate;
		private string _div_parentappno;
		private string _status;
		/// <summary>
		/// 
		/// </summary>
		public string CLIENT
		{
			set{ _client=value;}
			get{return _client;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime RECEIVED
		{
			set{ _received=value;}
			get{return _received;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AGENT
		{
			set{ _agent=value;}
			get{return _agent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLIENT_NUMBER
		{
			set{ _client_number=value;}
			get{return _client_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime FILING_DATE
		{
			set{ _filing_date=value;}
			get{return _filing_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPLICATION_NO
		{
			set{ _application_no=value;}
			get{return _application_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EARLIEST_PRIORITY
		{
			set{ _earliest_priority=value;}
			get{return _earliest_priority;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PUBLICATION
		{
			set{ _publication=value;}
			get{return _publication;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime FIRST_HK_DATE
		{
			set{ _first_hk_date=value;}
			get{return _first_hk_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIRST_HK_CANCELLED
		{
			set{ _first_hk_cancelled=value;}
			get{return _first_hk_cancelled;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SE_STATUS
		{
			set{ _se_status=value;}
			get{return _se_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SE_INITIATED
		{
			set{ _se_initiated=value;}
			get{return _se_initiated;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OA_RECEIVED
		{
			set{ _oa_received=value;}
			get{return _oa_received;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime GAZETTE
		{
			set{ _gazette=value;}
			get{return _gazette;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SECOND_HK_CANCELLED
		{
			set{ _second_hk_cancelled=value;}
			get{return _second_hk_cancelled;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SECOND_HK_DATE
		{
			set{ _second_hk_date=value;}
			get{return _second_hk_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REJECTED
		{
			set{ _rejected=value;}
			get{return _rejected;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WITHDREW
		{
			set{ _withdrew=value;}
			get{return _withdrew;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UNDER_INVALIDATE
		{
			set{ _under_invalidate=value;}
			get{return _under_invalidate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UNDER_REEXAMINATION
		{
			set{ _under_reexamination=value;}
			get{return _under_reexamination;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UNDER_LITIGATION
		{
			set{ _under_litigation=value;}
			get{return _under_litigation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVALIDATED
		{
			set{ _invalidated=value;}
			get{return _invalidated;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OURNO
		{
			set{ _ourno=value;}
			get{return _ourno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLIENT2
		{
			set{ _client2=value;}
			get{return _client2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLIENT3
		{
			set{ _client3=value;}
			get{return _client3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPLICANT1
		{
			set{ _applicant1=value;}
			get{return _applicant1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPLICANT2
		{
			set{ _applicant2=value;}
			get{return _applicant2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPLICANT3
		{
			set{ _applicant3=value;}
			get{return _applicant3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPLICANT4
		{
			set{ _applicant4=value;}
			get{return _applicant4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPLICANT5
		{
			set{ _applicant5=value;}
			get{return _applicant5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR1
		{
			set{ _inventor1=value;}
			get{return _inventor1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR2
		{
			set{ _inventor2=value;}
			get{return _inventor2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR3
		{
			set{ _inventor3=value;}
			get{return _inventor3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR4
		{
			set{ _inventor4=value;}
			get{return _inventor4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR5
		{
			set{ _inventor5=value;}
			get{return _inventor5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR6
		{
			set{ _inventor6=value;}
			get{return _inventor6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR7
		{
			set{ _inventor7=value;}
			get{return _inventor7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TITLE
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_COUNTRY
		{
			set{ _pri_country=value;}
			get{return _pri_country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_NUMBER
		{
			set{ _pri_number=value;}
			get{return _pri_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_COUNTRY2
		{
			set{ _pri_country2=value;}
			get{return _pri_country2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_NUMBER2
		{
			set{ _pri_number2=value;}
			get{return _pri_number2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_COUNTRY3
		{
			set{ _pri_country3=value;}
			get{return _pri_country3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_NUMBER3
		{
			set{ _pri_number3=value;}
			get{return _pri_number3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_COUNTRY4
		{
			set{ _pri_country4=value;}
			get{return _pri_country4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_NUMBER4
		{
			set{ _pri_number4=value;}
			get{return _pri_number4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_COUNTRY5
		{
			set{ _pri_country5=value;}
			get{return _pri_country5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_NUMBER5
		{
			set{ _pri_number5=value;}
			get{return _pri_number5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PCT_NUMBER
		{
			set{ _pct_number=value;}
			get{return _pct_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PCT_APPN_DATE
		{
			set{ _pct_appn_date=value;}
			get{return _pct_appn_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime FILING_DUE
		{
			set{ _filing_due=value;}
			get{return _filing_due;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRI_DATE2
		{
			set{ _pri_date2=value;}
			get{return _pri_date2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRI_DATE3
		{
			set{ _pri_date3=value;}
			get{return _pri_date3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRI_DATE4
		{
			set{ _pri_date4=value;}
			get{return _pri_date4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRI_DATE5
		{
			set{ _pri_date5=value;}
			get{return _pri_date5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR8
		{
			set{ _inventor8=value;}
			get{return _inventor8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR9
		{
			set{ _inventor9=value;}
			get{return _inventor9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR10
		{
			set{ _inventor10=value;}
			get{return _inventor10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR11
		{
			set{ _inventor11=value;}
			get{return _inventor11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR12
		{
			set{ _inventor12=value;}
			get{return _inventor12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR13
		{
			set{ _inventor13=value;}
			get{return _inventor13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR14
		{
			set{ _inventor14=value;}
			get{return _inventor14;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR15
		{
			set{ _inventor15=value;}
			get{return _inventor15;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMMENTS
		{
			set{ _comments=value;}
			get{return _comments;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_NUMBER6
		{
			set{ _pri_number6=value;}
			get{return _pri_number6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRI_DATE6
		{
			set{ _pri_date6=value;}
			get{return _pri_date6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_COUNTRY6
		{
			set{ _pri_country6=value;}
			get{return _pri_country6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_NUMBER7
		{
			set{ _pri_number7=value;}
			get{return _pri_number7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRI_DATE7
		{
			set{ _pri_date7=value;}
			get{return _pri_date7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_COUNTRY7
		{
			set{ _pri_country7=value;}
			get{return _pri_country7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_NUMBER8
		{
			set{ _pri_number8=value;}
			get{return _pri_number8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRI_DATE8
		{
			set{ _pri_date8=value;}
			get{return _pri_date8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_COUNTRY8
		{
			set{ _pri_country8=value;}
			get{return _pri_country8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_NUMBER9
		{
			set{ _pri_number9=value;}
			get{return _pri_number9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRI_DATE9
		{
			set{ _pri_date9=value;}
			get{return _pri_date9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_COUNTRY9
		{
			set{ _pri_country9=value;}
			get{return _pri_country9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_NUMBER10
		{
			set{ _pri_number10=value;}
			get{return _pri_number10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRI_DATE10
		{
			set{ _pri_date10=value;}
			get{return _pri_date10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_COUNTRY10
		{
			set{ _pri_country10=value;}
			get{return _pri_country10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLIENT_NAME
		{
			set{ _client_name=value;}
			get{return _client_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal TOTAL_PRI
		{
			set{ _total_pri=value;}
			get{return _total_pri;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PCT_PUBDATE
		{
			set{ _pct_pubdate=value;}
			get{return _pct_pubdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PCT_PUBNUM
		{
			set{ _pct_pubnum=value;}
			get{return _pct_pubnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DEADLINE
		{
			set{ _deadline=value;}
			get{return _deadline;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TITLE_CHINESE
		{
			set{ _title_chinese=value;}
			get{return _title_chinese;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPL_CODE1
		{
			set{ _appl_code1=value;}
			get{return _appl_code1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPL_CODE2
		{
			set{ _appl_code2=value;}
			get{return _appl_code2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPL_CODE3
		{
			set{ _appl_code3=value;}
			get{return _appl_code3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPL_CODE4
		{
			set{ _appl_code4=value;}
			get{return _appl_code4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPL_CODE5
		{
			set{ _appl_code5=value;}
			get{return _appl_code5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH1
		{
			set{ _inventor_ch1=value;}
			get{return _inventor_ch1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH2
		{
			set{ _inventor_ch2=value;}
			get{return _inventor_ch2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH3
		{
			set{ _inventor_ch3=value;}
			get{return _inventor_ch3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH4
		{
			set{ _inventor_ch4=value;}
			get{return _inventor_ch4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH5
		{
			set{ _inventor_ch5=value;}
			get{return _inventor_ch5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH6
		{
			set{ _inventor_ch6=value;}
			get{return _inventor_ch6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH7
		{
			set{ _inventor_ch7=value;}
			get{return _inventor_ch7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH8
		{
			set{ _inventor_ch8=value;}
			get{return _inventor_ch8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH9
		{
			set{ _inventor_ch9=value;}
			get{return _inventor_ch9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH10
		{
			set{ _inventor_ch10=value;}
			get{return _inventor_ch10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH11
		{
			set{ _inventor_ch11=value;}
			get{return _inventor_ch11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH12
		{
			set{ _inventor_ch12=value;}
			get{return _inventor_ch12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH13
		{
			set{ _inventor_ch13=value;}
			get{return _inventor_ch13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH14
		{
			set{ _inventor_ch14=value;}
			get{return _inventor_ch14;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH15
		{
			set{ _inventor_ch15=value;}
			get{return _inventor_ch15;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AGENT_ACTUAL
		{
			set{ _agent_actual=value;}
			get{return _agent_actual;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal APPN_COPY
		{
			set{ _appn_copy=value;}
			get{return _appn_copy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal BILL_COPY
		{
			set{ _bill_copy=value;}
			get{return _bill_copy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MAILING_ADDR
		{
			set{ _mailing_addr=value;}
			get{return _mailing_addr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MAILING_CONTACT
		{
			set{ _mailing_contact=value;}
			get{return _mailing_contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BILLING_CONTACT
		{
			set{ _billing_contact=value;}
			get{return _billing_contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal CHARCOUNT
		{
			set{ _charcount=value;}
			get{return _charcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal CLAIM_NUM
		{
			set{ _claim_num=value;}
			get{return _claim_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LANGUAGE
		{
			set{ _language=value;}
			get{return _language;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal APPL_NUM
		{
			set{ _appl_num=value;}
			get{return _appl_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal INVEN_NUM
		{
			set{ _inven_num=value;}
			get{return _inven_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRE_EXAM_PASSED
		{
			set{ _pre_exam_passed=value;}
			get{return _pre_exam_passed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PUBLICATION_NO
		{
			set{ _publication_no=value;}
			get{return _publication_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SE_DATE
		{
			set{ _se_date=value;}
			get{return _se_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime GRANTNOTIC_DATE
		{
			set{ _grantnotic_date=value;}
			get{return _grantnotic_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime REGFEE_DL
		{
			set{ _regfee_dl=value;}
			get{return _regfee_dl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime REGFEE_SUBMIT
		{
			set{ _regfee_submit=value;}
			get{return _regfee_submit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ANNO_NO
		{
			set{ _anno_no=value;}
			get{return _anno_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime STATUS_DATE
		{
			set{ _status_date=value;}
			get{return _status_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLIENT_STATUS
		{
			set{ _client_status=value;}
			get{return _client_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime YFEE_DATE
		{
			set{ _yfee_date=value;}
			get{return _yfee_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime YFEE1
		{
			set{ _yfee1=value;}
			get{return _yfee1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime YFEE2
		{
			set{ _yfee2=value;}
			get{return _yfee2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal CERTIFICATE_NO
		{
			set{ _certificate_no=value;}
			get{return _certificate_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLIENT4
		{
			set{ _client4=value;}
			get{return _client4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLIENT5
		{
			set{ _client5=value;}
			get{return _client5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OAGENT1
		{
			set{ _oagent1=value;}
			get{return _oagent1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OAGENT2
		{
			set{ _oagent2=value;}
			get{return _oagent2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SEFEE
		{
			set{ _sefee=value;}
			get{return _sefee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPFEE
		{
			set{ _appfee=value;}
			get{return _appfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IGNOREANNUALFEE
		{
			set{ _ignoreannualfee=value;}
			get{return _ignoreannualfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPLICANT_CH1
		{
			set{ _applicant_ch1=value;}
			get{return _applicant_ch1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPLICANT_CH2
		{
			set{ _applicant_ch2=value;}
			get{return _applicant_ch2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPLICANT_CH3
		{
			set{ _applicant_ch3=value;}
			get{return _applicant_ch3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPLICANT_CH4
		{
			set{ _applicant_ch4=value;}
			get{return _applicant_ch4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPLICANT_CH5
		{
			set{ _applicant_ch5=value;}
			get{return _applicant_ch5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR16
		{
			set{ _inventor16=value;}
			get{return _inventor16;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR17
		{
			set{ _inventor17=value;}
			get{return _inventor17;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR18
		{
			set{ _inventor18=value;}
			get{return _inventor18;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR19
		{
			set{ _inventor19=value;}
			get{return _inventor19;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR20
		{
			set{ _inventor20=value;}
			get{return _inventor20;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR21
		{
			set{ _inventor21=value;}
			get{return _inventor21;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH16
		{
			set{ _inventor_ch16=value;}
			get{return _inventor_ch16;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH17
		{
			set{ _inventor_ch17=value;}
			get{return _inventor_ch17;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH18
		{
			set{ _inventor_ch18=value;}
			get{return _inventor_ch18;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH19
		{
			set{ _inventor_ch19=value;}
			get{return _inventor_ch19;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH20
		{
			set{ _inventor_ch20=value;}
			get{return _inventor_ch20;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH21
		{
			set{ _inventor_ch21=value;}
			get{return _inventor_ch21;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRANSLATOR
		{
			set{ _translator=value;}
			get{return _translator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CORRECTOR1
		{
			set{ _corrector1=value;}
			get{return _corrector1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CORRECTOR2
		{
			set{ _corrector2=value;}
			get{return _corrector2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal URGENT_CO
		{
			set{ _urgent_co=value;}
			get{return _urgent_co;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRI_DATE11
		{
			set{ _pri_date11=value;}
			get{return _pri_date11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRI_DATE12
		{
			set{ _pri_date12=value;}
			get{return _pri_date12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_NUMBER11
		{
			set{ _pri_number11=value;}
			get{return _pri_number11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_NUMBER12
		{
			set{ _pri_number12=value;}
			get{return _pri_number12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_COUNTRY11
		{
			set{ _pri_country11=value;}
			get{return _pri_country11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRI_COUNTRY12
		{
			set{ _pri_country12=value;}
			get{return _pri_country12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APP_REF
		{
			set{ _app_ref=value;}
			get{return _app_ref;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DIV_FILINGDATE
		{
			set{ _div_filingdate=value;}
			get{return _div_filingdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DIV_PARENTAPPNO
		{
			set{ _div_parentappno=value;}
			get{return _div_parentappno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}

