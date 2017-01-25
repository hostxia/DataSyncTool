using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// DROPPING_PATENTBILLINPUT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DROPPING_PATENTBILLINPUT
	{
		public DROPPING_PATENTBILLINPUT()
		{}
		#region Model
		private string _pid;
		private string _notenumber;
		private string _type;
		private string _text;
		private decimal _quantity;
		private decimal _officialfee;
		private decimal _otherfee;
		private string _waive;
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
		public string NOTENUMBER
		{
			set{ _notenumber=value;}
			get{return _notenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPE
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TEXT
		{
			set{ _text=value;}
			get{return _text;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal QUANTITY
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal OFFICIALFEE
		{
			set{ _officialfee=value;}
			get{return _officialfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal OTHERFEE
		{
			set{ _otherfee=value;}
			get{return _otherfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WAIVE
		{
			set{ _waive=value;}
			get{return _waive;}
		}
		#endregion Model

	}
}

