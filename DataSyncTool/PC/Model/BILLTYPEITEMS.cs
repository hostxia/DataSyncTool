using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// BILLTYPEITEMS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BILLTYPEITEMS
	{
		public BILLTYPEITEMS()
		{}
		#region Model
		private string _billtype;
		private string _billcode;
		/// <summary>
		/// 
		/// </summary>
		public string BILLTYPE
		{
			set{ _billtype=value;}
			get{return _billtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BILLCODE
		{
			set{ _billcode=value;}
			get{return _billcode;}
		}
		#endregion Model

	}
}

