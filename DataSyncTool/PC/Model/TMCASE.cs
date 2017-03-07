using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// TMCASE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TMCASE
	{
		public TMCASE()
		{}
		#region Model
		private string _withdrew;
		private string _client;
		private string _client_number;
		private DateTime _received;
		private DateTime _filing_date;
		private DateTime _priority;
		private string _cert_filed;
		private string _application_no;
		private DateTime _am_rcvd;
		private DateTime _am_filed;
		private DateTime _am_refusal_rcvd;
		private string _am_rw_con_nature;
		private DateTime _oa_rcvd;
		private DateTime _oa_filed;
		private DateTime _oa_refusal_rcvd;
		private string _oa_refusal_ext;
		private DateTime _oa_rw_filed;
		private DateTime _oa_rw_con_rcvd;
		private string _oa_rw_con_nature;
		private DateTime _pre_published;
		private DateTime _op_rcvd;
		private DateTime _op_filed;
		private DateTime _op_con_rcvd;
		private string _op_con_nature;
		private DateTime _op_rw_filed;
		private DateTime _op_rw_con_rcvd;
		private string _op_rw_con_nature;
		private DateTime _certification;
		private DateTime _disp_rcvd;
		private DateTime _disp_filed;
		private DateTime _disp_con_rcvd;
		private string _disp_con_nature;
		private string _under_litigation;
		private string _agent;
		private string _ourno;
		private string _op_con_ext;
		private string _client2;
		private string _client3;
		private string _client4;
		private string _client5;
		private string _appl_code1;
		private string _appl_code2;
		private string _appl_code3;
		private string _diary;
		private string _statusmarks;
		private string _basicinfo;
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
		public string CLIENT
		{
			set{ _client=value;}
			get{return _client;}
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
		public DateTime RECEIVED
		{
			set{ _received=value;}
			get{return _received;}
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
		public DateTime PRIORITY
		{
			set{ _priority=value;}
			get{return _priority;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CERT_FILED
		{
			set{ _cert_filed=value;}
			get{return _cert_filed;}
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
		public DateTime AM_RCVD
		{
			set{ _am_rcvd=value;}
			get{return _am_rcvd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AM_FILED
		{
			set{ _am_filed=value;}
			get{return _am_filed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AM_REFUSAL_RCVD
		{
			set{ _am_refusal_rcvd=value;}
			get{return _am_refusal_rcvd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AM_RW_CON_NATURE
		{
			set{ _am_rw_con_nature=value;}
			get{return _am_rw_con_nature;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OA_RCVD
		{
			set{ _oa_rcvd=value;}
			get{return _oa_rcvd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OA_FILED
		{
			set{ _oa_filed=value;}
			get{return _oa_filed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OA_REFUSAL_RCVD
		{
			set{ _oa_refusal_rcvd=value;}
			get{return _oa_refusal_rcvd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OA_REFUSAL_EXT
		{
			set{ _oa_refusal_ext=value;}
			get{return _oa_refusal_ext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OA_RW_FILED
		{
			set{ _oa_rw_filed=value;}
			get{return _oa_rw_filed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OA_RW_CON_RCVD
		{
			set{ _oa_rw_con_rcvd=value;}
			get{return _oa_rw_con_rcvd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OA_RW_CON_NATURE
		{
			set{ _oa_rw_con_nature=value;}
			get{return _oa_rw_con_nature;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PRE_PUBLISHED
		{
			set{ _pre_published=value;}
			get{return _pre_published;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OP_RCVD
		{
			set{ _op_rcvd=value;}
			get{return _op_rcvd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OP_FILED
		{
			set{ _op_filed=value;}
			get{return _op_filed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OP_CON_RCVD
		{
			set{ _op_con_rcvd=value;}
			get{return _op_con_rcvd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OP_CON_NATURE
		{
			set{ _op_con_nature=value;}
			get{return _op_con_nature;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OP_RW_FILED
		{
			set{ _op_rw_filed=value;}
			get{return _op_rw_filed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OP_RW_CON_RCVD
		{
			set{ _op_rw_con_rcvd=value;}
			get{return _op_rw_con_rcvd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OP_RW_CON_NATURE
		{
			set{ _op_rw_con_nature=value;}
			get{return _op_rw_con_nature;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CERTIFICATION
		{
			set{ _certification=value;}
			get{return _certification;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DISP_RCVD
		{
			set{ _disp_rcvd=value;}
			get{return _disp_rcvd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DISP_FILED
		{
			set{ _disp_filed=value;}
			get{return _disp_filed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DISP_CON_RCVD
		{
			set{ _disp_con_rcvd=value;}
			get{return _disp_con_rcvd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DISP_CON_NATURE
		{
			set{ _disp_con_nature=value;}
			get{return _disp_con_nature;}
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
		public string AGENT
		{
			set{ _agent=value;}
			get{return _agent;}
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
		public string OP_CON_EXT
		{
			set{ _op_con_ext=value;}
			get{return _op_con_ext;}
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
		public string DIARY
		{
			set{ _diary=value;}
			get{return _diary;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STATUSMARKS
		{
			set{ _statusmarks=value;}
			get{return _statusmarks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BASICINFO
		{
			set{ _basicinfo=value;}
			get{return _basicinfo;}
		}
		#endregion Model

	}
}

