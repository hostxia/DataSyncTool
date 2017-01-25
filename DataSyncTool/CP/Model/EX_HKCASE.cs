using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// EX_HKCASE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EX_HKCASE
	{
		public EX_HKCASE()
		{}
		#region Model
		private string _hk_app_ref;
		private string _hk_app_no;
		private string _hk_pub_no;
		private DateTime _hk_reg1_date;
		private DateTime _hk_pub1_date;
		private DateTime _maintenance_duedate;
		private DateTime _hk_reg2_date;
		private DateTime _next_renewal_duedate;
		private string _cn_app_ref;
		private string _cn_app_no;
		private DateTime _cn_app_date;
		private DateTime _p4_sending_date;
		private DateTime _first_agency_report;
		private DateTime _to_pub;
		private DateTime _p5_sending_date;
		private DateTime _second_agency_report;
		private DateTime _to_grant;
		private string _comments;
		private string _client_ref;
		private string _client;
		private string _hk_anno_no;
		private DateTime _hk_gazette;
		private string _parent_country;
		private DateTime _received;
		private string _abandon;
		private DateTime _priority;
		private string _sendaddress;
		private string _addrcheck;
		private string _applicant;
		/// <summary>
		/// 
		/// </summary>
		public string HK_APP_REF
		{
			set{ _hk_app_ref=value;}
			get{return _hk_app_ref;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HK_APP_NO
		{
			set{ _hk_app_no=value;}
			get{return _hk_app_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HK_PUB_NO
		{
			set{ _hk_pub_no=value;}
			get{return _hk_pub_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime HK_REG1_DATE
		{
			set{ _hk_reg1_date=value;}
			get{return _hk_reg1_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime HK_PUB1_DATE
		{
			set{ _hk_pub1_date=value;}
			get{return _hk_pub1_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime MAINTENANCE_DUEDATE
		{
			set{ _maintenance_duedate=value;}
			get{return _maintenance_duedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime HK_REG2_DATE
		{
			set{ _hk_reg2_date=value;}
			get{return _hk_reg2_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime NEXT_RENEWAL_DUEDATE
		{
			set{ _next_renewal_duedate=value;}
			get{return _next_renewal_duedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CN_APP_REF
		{
			set{ _cn_app_ref=value;}
			get{return _cn_app_ref;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CN_APP_NO
		{
			set{ _cn_app_no=value;}
			get{return _cn_app_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CN_APP_DATE
		{
			set{ _cn_app_date=value;}
			get{return _cn_app_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime P4_SENDING_DATE
		{
			set{ _p4_sending_date=value;}
			get{return _p4_sending_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime FIRST_AGENCY_REPORT
		{
			set{ _first_agency_report=value;}
			get{return _first_agency_report;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TO_PUB
		{
			set{ _to_pub=value;}
			get{return _to_pub;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime P5_SENDING_DATE
		{
			set{ _p5_sending_date=value;}
			get{return _p5_sending_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SECOND_AGENCY_REPORT
		{
			set{ _second_agency_report=value;}
			get{return _second_agency_report;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TO_GRANT
		{
			set{ _to_grant=value;}
			get{return _to_grant;}
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
		public string CLIENT_REF
		{
			set{ _client_ref=value;}
			get{return _client_ref;}
		}
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
		public string HK_ANNO_NO
		{
			set{ _hk_anno_no=value;}
			get{return _hk_anno_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime HK_GAZETTE
		{
			set{ _hk_gazette=value;}
			get{return _hk_gazette;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARENT_COUNTRY
		{
			set{ _parent_country=value;}
			get{return _parent_country;}
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
		public string ABANDON
		{
			set{ _abandon=value;}
			get{return _abandon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRIORITY
		{
			set{ _priority=value;}
			get{return _priority;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SENDADDRESS
		{
			set{ _sendaddress=value;}
			get{return _sendaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADDRCHECK
		{
			set{ _addrcheck=value;}
			get{return _addrcheck;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPLICANT
		{
			set{ _applicant=value;}
			get{return _applicant;}
		}
		#endregion Model

	}
}

