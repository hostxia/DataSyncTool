using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// DROPPING_FISH_RICHARDSON:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DROPPING_FISH_RICHARDSON
	{
		public DROPPING_FISH_RICHARDSON()
		{}
		#region Model
		private string _ourno;
		private string _appno;
		private DateTime _appdate;
		private string _ctitle;
		private string _isprexam;
		private string _issubstantive;
		private string _isgrant;
		private DateTime _submitdate;
		private string _status;
		private string _app_ref;
		private string _etitle;
		private string _agent;
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
		public DateTime APPDATE
		{
			set{ _appdate=value;}
			get{return _appdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CTITLE
		{
			set{ _ctitle=value;}
			get{return _ctitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ISPREXAM
		{
			set{ _isprexam=value;}
			get{return _isprexam;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ISSUBSTANTIVE
		{
			set{ _issubstantive=value;}
			get{return _issubstantive;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ISGRANT
		{
			set{ _isgrant=value;}
			get{return _isgrant;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SUBMITDATE
		{
			set{ _submitdate=value;}
			get{return _submitdate;}
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
		public string APP_REF
		{
			set{ _app_ref=value;}
			get{return _app_ref;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ETITLE
		{
			set{ _etitle=value;}
			get{return _etitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AGENT
		{
			set{ _agent=value;}
			get{return _agent;}
		}
		#endregion Model

	}
}

