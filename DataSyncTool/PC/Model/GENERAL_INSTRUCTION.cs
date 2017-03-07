using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// GENERAL_INSTRUCTION:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GENERAL_INSTRUCTION
	{
		public GENERAL_INSTRUCTION()
		{}
		#region Model
		private string _pid;
		private string _client_no;
		private DateTime _received;
		private string _received_by;
		private string _relates_to;
		private string _content_cn;
		private string _content_origin;
		private string _instructor;
		private string _status;
		private DateTime _expire_date;
		private string _comments;
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
		public string CLIENT_NO
		{
			set{ _client_no=value;}
			get{return _client_no;}
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
		public string RECEIVED_BY
		{
			set{ _received_by=value;}
			get{return _received_by;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RELATES_TO
		{
			set{ _relates_to=value;}
			get{return _relates_to;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTENT_CN
		{
			set{ _content_cn=value;}
			get{return _content_cn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTENT_ORIGIN
		{
			set{ _content_origin=value;}
			get{return _content_origin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INSTRUCTOR
		{
			set{ _instructor=value;}
			get{return _instructor;}
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
		public DateTime EXPIRE_DATE
		{
			set{ _expire_date=value;}
			get{return _expire_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMMENTS
		{
			set{ _comments=value;}
			get{return _comments;}
		}
		#endregion Model

	}
}

