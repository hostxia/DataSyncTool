using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// TEST11:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST11
	{
		public TEST11()
		{}
		#region Model
		private string _t1;
		private string _t2;
		/// <summary>
		/// 
		/// </summary>
		public string T1
		{
			set{ _t1=value;}
			get{return _t1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string T2
		{
			set{ _t2=value;}
			get{return _t2;}
		}
		#endregion Model

	}
}

