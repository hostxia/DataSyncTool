using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// INVENTORS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class INVENTORS
	{
		public INVENTORS()
		{}
		#region Model
		private string _inventor;
		private string _inventor_ch;
		private string _appl_code1;
		private string _preferred;
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR
		{
			set{ _inventor=value;}
			get{return _inventor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVENTOR_CH
		{
			set{ _inventor_ch=value;}
			get{return _inventor_ch;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPL_CODE1
		{
			set{ _appl_code1=value;}
			get{return _appl_code1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PREFERRED
		{
			set{ _preferred=value;}
			get{return _preferred;}
		}
		#endregion Model

	}
}

