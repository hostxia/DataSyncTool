using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// FCASE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FCASE
	{
		public FCASE()
		{}
		#region Model
		private string _ourno;
		private string _title;
		private string _ctitle;
		private DateTime _received;
		private string _appno;
		private DateTime _appdate;
		private string _comments;
		private string _status;
		private string _apptype;
		private DateTime _deadline;
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
		public string TITLE
		{
			set{ _title=value;}
			get{return _title;}
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
		public DateTime RECEIVED
		{
			set{ _received=value;}
			get{return _received;}
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
		/// <summary>
		/// 
		/// </summary>
		public string APPTYPE
		{
			set{ _apptype=value;}
			get{return _apptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DEADLINE
		{
			set{ _deadline=value;}
			get{return _deadline;}
		}
		#endregion Model

	}
}

