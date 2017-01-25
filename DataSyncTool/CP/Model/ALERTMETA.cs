using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// ALERTMETA:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ALERTMETA
	{
		public ALERTMETA()
		{}
		#region Model
		private string _typeid;
		private string _businessfieldsig;
		private string _inputtypesig;
		private string _alert_class;
		private string _alert_select;
		private string _alert_from;
		private string _alert_where;
		private string _alert_orderby;
		private string _classifier;
		private string _title;
		private string _th;
		private string _legend;
		private string _comments;
		private decimal _count;
		private DateTime _lastupdated;
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
		public string BUSINESSFIELDSIG
		{
			set{ _businessfieldsig=value;}
			get{return _businessfieldsig;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INPUTTYPESIG
		{
			set{ _inputtypesig=value;}
			get{return _inputtypesig;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ALERT_CLASS
		{
			set{ _alert_class=value;}
			get{return _alert_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ALERT_SELECT
		{
			set{ _alert_select=value;}
			get{return _alert_select;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ALERT_FROM
		{
			set{ _alert_from=value;}
			get{return _alert_from;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ALERT_WHERE
		{
			set{ _alert_where=value;}
			get{return _alert_where;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ALERT_ORDERBY
		{
			set{ _alert_orderby=value;}
			get{return _alert_orderby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLASSIFIER
		{
			set{ _classifier=value;}
			get{return _classifier;}
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
		public string TH
		{
			set{ _th=value;}
			get{return _th;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LEGEND
		{
			set{ _legend=value;}
			get{return _legend;}
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
		public decimal COUNT
		{
			set{ _count=value;}
			get{return _count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime LASTUPDATED
		{
			set{ _lastupdated=value;}
			get{return _lastupdated;}
		}
		#endregion Model

	}
}

