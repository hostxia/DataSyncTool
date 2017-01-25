using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// RECEIVINGLOG:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RECEIVINGLOG
	{
		public RECEIVINGLOG()
		{}
		#region Model
		private string _pid;
		private DateTime _issuedate;
		private DateTime _received;
		private string _receivedby;
		private string _senderid;
		private string _sender;
		private string _ourno;
		private string _appno;
		private string _clientno;
		private string _content;
		private decimal _copies;
		private decimal _pages;
		private string _handler;
		private string _comments;
		private string _status;
		/// <summary>
		/// 
		/// </summary>
		public string PID
		{
			set{ _pid=value;}
			get{return _pid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ISSUEDATE
		{
			set{ _issuedate=value;}
			get{return _issuedate;}
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
		public string RECEIVEDBY
		{
			set{ _receivedby=value;}
			get{return _receivedby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SENDERID
		{
			set{ _senderid=value;}
			get{return _senderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SENDER
		{
			set{ _sender=value;}
			get{return _sender;}
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
		public string APPNO
		{
			set{ _appno=value;}
			get{return _appno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLIENTNO
		{
			set{ _clientno=value;}
			get{return _clientno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTENT
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal COPIES
		{
			set{ _copies=value;}
			get{return _copies;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal PAGES
		{
			set{ _pages=value;}
			get{return _pages;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HANDLER
		{
			set{ _handler=value;}
			get{return _handler;}
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
		public string STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}

