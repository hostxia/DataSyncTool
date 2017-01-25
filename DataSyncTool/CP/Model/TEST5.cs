using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// TEST5:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST5
	{
		public TEST5()
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

