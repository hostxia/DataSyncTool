using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// TEST_CLIENT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST_CLIENT
	{
		public TEST_CLIENT()
		{}
		#region Model
		private string _client_number;
		private string _name1;
		private string _name2;
		/// <summary>
		/// 
		/// </summary>
		public string CLIENT_NUMBER
		{
			set{ _client_number=value;}
			get{return _client_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NAME1
		{
			set{ _name1=value;}
			get{return _name1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NAME2
		{
			set{ _name2=value;}
			get{return _name2;}
		}
		#endregion Model

	}
}

