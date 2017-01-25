using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// TEST_OURNO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST_OURNO
	{
		public TEST_OURNO()
		{}
		#region Model
		private string _ourno;
		/// <summary>
		/// 
		/// </summary>
		public string OURNO
		{
			set{ _ourno=value;}
			get{return _ourno;}
		}
		#endregion Model

	}
}

