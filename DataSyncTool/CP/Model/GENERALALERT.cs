using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// GENERALALERT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GENERALALERT
	{
		public GENERALALERT()
		{}
		#region Model
		private DateTime _created= DateTime.Now;
		private string _typeid;
		private string _ourno;
		private decimal _itemnumber;
		private DateTime _trigerdate1;
		private DateTime _subcomplete1;
		private DateTime _subcomplete2;
		private DateTime _subcomplete3;
		private DateTime _subcomplete4;
		private DateTime _duedate;
		private DateTime _completedate;
		private string _comments;
		private string _oatype;
		private string _agent;
		private string _dltype;
		/// <summary>
		/// 
		/// </summary>
		public DateTime CREATED
		{
			set{ _created=value;}
			get{return _created;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPEID
		{
			set{ _typeid=value;}
			get{return _typeid;}
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
		public decimal ITEMNUMBER
		{
			set{ _itemnumber=value;}
			get{return _itemnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TRIGERDATE1
		{
			set{ _trigerdate1=value;}
			get{return _trigerdate1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SUBCOMPLETE1
		{
			set{ _subcomplete1=value;}
			get{return _subcomplete1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SUBCOMPLETE2
		{
			set{ _subcomplete2=value;}
			get{return _subcomplete2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SUBCOMPLETE3
		{
			set{ _subcomplete3=value;}
			get{return _subcomplete3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SUBCOMPLETE4
		{
			set{ _subcomplete4=value;}
			get{return _subcomplete4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DUEDATE
		{
			set{ _duedate=value;}
			get{return _duedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime COMPLETEDATE
		{
			set{ _completedate=value;}
			get{return _completedate;}
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
		public string OATYPE
		{
			set{ _oatype=value;}
			get{return _oatype;}
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
		public string DLTYPE
		{
			set{ _dltype=value;}
			get{return _dltype;}
		}
		#endregion Model

	}
}

