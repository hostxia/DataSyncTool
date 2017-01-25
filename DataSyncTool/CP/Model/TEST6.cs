using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// TEST6:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST6
	{
		public TEST6()
		{}
		#region Model
		private string _application_no;
		private string _str;
		private string _str2;
		/// <summary>
		/// 
		/// </summary>
		public string APPLICATION_NO
		{
			set{ _application_no=value;}
			get{return _application_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STR
		{
			set{ _str=value;}
			get{return _str;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STR2
		{
			set{ _str2=value;}
			get{return _str2;}
		}
		#endregion Model

	}
}

