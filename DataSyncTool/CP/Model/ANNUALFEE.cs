using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// ANNUALFEE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ANNUALFEE
	{
		public ANNUALFEE()
		{}
		#region Model
		private string _patenttype;
		private decimal _numyear;
		private decimal _amount;
		/// <summary>
		/// 
		/// </summary>
		public string PATENTTYPE
		{
			set{ _patenttype=value;}
			get{return _patenttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal NUMYEAR
		{
			set{ _numyear=value;}
			get{return _numyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal AMOUNT
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		#endregion Model

	}
}

