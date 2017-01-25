using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// BILLFEEMNT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BILLFEEMNT
	{
		public BILLFEEMNT()
		{}
		#region Model
		private string _feeid;
		private string _noteno;
		private string _caseno;
		private string _casetype;
		private string _clientno;
		private decimal _amount;
		private string _typ_or_grp;
		private string _paycurrency;
		private DateTime _paydate;
		private DateTime _billdate;
		private string _paymethod;
		private string _status;
		private string _checkby;
		/// <summary>
		/// 
		/// </summary>
		public string FEEID
		{
			set{ _feeid=value;}
			get{return _feeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NOTENO
		{
			set{ _noteno=value;}
			get{return _noteno;}
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
		public string CASETYPE
		{
			set{ _casetype=value;}
			get{return _casetype;}
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
		public decimal AMOUNT
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYP_OR_GRP
		{
			set{ _typ_or_grp=value;}
			get{return _typ_or_grp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PAYCURRENCY
		{
			set{ _paycurrency=value;}
			get{return _paycurrency;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PAYDATE
		{
			set{ _paydate=value;}
			get{return _paydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime BILLDATE
		{
			set{ _billdate=value;}
			get{return _billdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PAYMETHOD
		{
			set{ _paymethod=value;}
			get{return _paymethod;}
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
		public string CHECKBY
		{
			set{ _checkby=value;}
			get{return _checkby;}
		}
		#endregion Model

	}
}

