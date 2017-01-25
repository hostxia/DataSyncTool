using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// FLFEEDETAIL:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FLFEEDETAIL
	{
		public FLFEEDETAIL()
		{}
		#region Model
		private string _caseno;
		private string _clientno;
		private string _voucherno;
		private string _feetype;
		private decimal _amount;
		private string _paymethod;
		private DateTime _paydate;
		private string _checkby;
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
		public string CLIENTNO
		{
			set{ _clientno=value;}
			get{return _clientno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VOUCHERNO
		{
			set{ _voucherno=value;}
			get{return _voucherno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FEETYPE
		{
			set{ _feetype=value;}
			get{return _feetype;}
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
		public string PAYMETHOD
		{
			set{ _paymethod=value;}
			get{return _paymethod;}
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
		public string CHECKBY
		{
			set{ _checkby=value;}
			get{return _checkby;}
		}
		#endregion Model

	}
}

