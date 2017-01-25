using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// TEST_BOR_CASE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST_BOR_CASE
	{
		public TEST_BOR_CASE()
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

