using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// CHANGETYPETEXT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CHANGETYPETEXT
	{
		public CHANGETYPETEXT()
		{}
		#region Model
		private string _change;
		private string _text;
		/// <summary>
		/// 
		/// </summary>
		public string CHANGE
		{
			set{ _change=value;}
			get{return _change;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TEXT
		{
			set{ _text=value;}
			get{return _text;}
		}
		#endregion Model

	}
}

