using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// BILL:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BILL
	{
		public BILL()
		{}
		#region Model
		private string _caseno;
		private string _notenumber;
		private string _issuenumber;
		private string _type;
		private DateTime _issued;
		private DateTime _paid;
		private string _status;
		private string _comments;
		private string _address;
		private string _client;
		private string _owner;
		private string _currencyid;
		private string _accountid;
		private DateTime _billing_start_date;
		private DateTime _billing_end_date;
		private string _firmid;
		private string _client_matterid;
		private string _sigs;
		private string _descline;
		/// <summary>
		/// 
		/// </summary>
		public string CASENO
		{
			set{ _caseno=value;}
			get{return _caseno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NOTENUMBER
		{
			set{ _notenumber=value;}
			get{return _notenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ISSUENUMBER
		{
			set{ _issuenumber=value;}
			get{return _issuenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPE
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ISSUED
		{
			set{ _issued=value;}
			get{return _issued;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PAID
		{
			set{ _paid=value;}
			get{return _paid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STATUS
		{
			set{ _status=value;}
			get{return _status;}
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
		public string ADDRESS
		{
			set{ _address=value;}
			get{return _address;}
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
		public string OWNER
		{
			set{ _owner=value;}
			get{return _owner;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CURRENCYID
		{
			set{ _currencyid=value;}
			get{return _currencyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ACCOUNTID
		{
			set{ _accountid=value;}
			get{return _accountid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime BILLING_START_DATE
		{
			set{ _billing_start_date=value;}
			get{return _billing_start_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime BILLING_END_DATE
		{
			set{ _billing_end_date=value;}
			get{return _billing_end_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIRMID
		{
			set{ _firmid=value;}
			get{return _firmid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLIENT_MATTERID
		{
			set{ _client_matterid=value;}
			get{return _client_matterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SIGS
		{
			set{ _sigs=value;}
			get{return _sigs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DESCLINE
		{
			set{ _descline=value;}
			get{return _descline;}
		}
		#endregion Model

	}
}

