using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// CLIENTDB:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CLIENTDB
	{
		public CLIENTDB()
		{}
		#region Model
		private string _clientid;
		private string _clientname;
		private string _clientcname;
		private decimal _pt_appn_copy;
		private decimal _pt_bill_copy;
		private string _mailing_addr;
		private string _mailing_contact;
		private string _billing_contact;
		private string _pt_general_instr;
		private string _billalias;
		/// <summary>
		/// 
		/// </summary>
		public string CLIENTID
		{
			set{ _clientid=value;}
			get{return _clientid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLIENTNAME
		{
			set{ _clientname=value;}
			get{return _clientname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLIENTCNAME
		{
			set{ _clientcname=value;}
			get{return _clientcname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal PT_APPN_COPY
		{
			set{ _pt_appn_copy=value;}
			get{return _pt_appn_copy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal PT_BILL_COPY
		{
			set{ _pt_bill_copy=value;}
			get{return _pt_bill_copy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MAILING_ADDR
		{
			set{ _mailing_addr=value;}
			get{return _mailing_addr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MAILING_CONTACT
		{
			set{ _mailing_contact=value;}
			get{return _mailing_contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BILLING_CONTACT
		{
			set{ _billing_contact=value;}
			get{return _billing_contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PT_GENERAL_INSTR
		{
			set{ _pt_general_instr=value;}
			get{return _pt_general_instr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BILLALIAS
		{
			set{ _billalias=value;}
			get{return _billalias;}
		}
		#endregion Model

	}
}

