using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// TEST_AGT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST_AGT
	{
		public TEST_AGT()
		{}
		#region Model
		private string _agt_number;
		private string _name1;
		private string _name2;
		/// <summary>
		/// 
		/// </summary>
		public string AGT_NUMBER
		{
			set{ _agt_number=value;}
			get{return _agt_number;}
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

