using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// TEST8:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST8
	{
		public TEST8()
		{}
		#region Model
		private string _application_no;
		private string _str;
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
		#endregion Model

	}
}

