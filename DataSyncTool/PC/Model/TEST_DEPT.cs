using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// TEST_DEPT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST_DEPT
	{
		public TEST_DEPT()
		{}
		#region Model
		private string _code;
		private string _name;
		/// <summary>
		/// 
		/// </summary>
		public string CODE
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NAME
		{
			set{ _name=value;}
			get{return _name;}
		}
		#endregion Model

	}
}

