using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// ALERTVIEW:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ALERTVIEW
	{
		public ALERTVIEW()
		{}
		#region Model
		private string _id;
		private string _status;
		private string _alerttype;
		private string _caseno;
		private string _agent;
		private DateTime _targetdate;
		private string _tr;
		private decimal _dor;
		private decimal _linenum;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
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
		public string ALERTTYPE
		{
			set{ _alerttype=value;}
			get{return _alerttype;}
		}
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
		public string AGENT
		{
			set{ _agent=value;}
			get{return _agent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TARGETDATE
		{
			set{ _targetdate=value;}
			get{return _targetdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TR
		{
			set{ _tr=value;}
			get{return _tr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal DOR
		{
			set{ _dor=value;}
			get{return _dor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal LINENUM
		{
			set{ _linenum=value;}
			get{return _linenum;}
		}
		#endregion Model

	}
}

