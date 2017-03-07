using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// BILLTYPE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BILLTYPE
	{
		public BILLTYPE()
		{}
		#region Model
		private string _billtype;
		private string _description;
		private string _casetype;
		/// <summary>
		/// 
		/// </summary>
		public string BILLTYPE1
		{
			set{ _billtype=value;}
			get{return _billtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DESCRIPTION
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CASETYPE
		{
			set{ _casetype=value;}
			get{return _casetype;}
		}
		#endregion Model

	}
}

