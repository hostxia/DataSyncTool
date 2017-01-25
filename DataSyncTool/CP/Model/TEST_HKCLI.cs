using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// TEST_HKCLI:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST_HKCLI
	{
		public TEST_HKCLI()
		{}
		#region Model
		private string _ourno;
		private string _code;
		/// <summary>
		/// 
		/// </summary>
		public string OURNO
		{
			set{ _ourno=value;}
			get{return _ourno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CODE
		{
			set{ _code=value;}
			get{return _code;}
		}
		#endregion Model

	}
}

