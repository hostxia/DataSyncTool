using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// TEST1:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST1
	{
		public TEST1()
		{}
		#region Model
		private string _ourno;
		private string _string;
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
		public string STRING
		{
			set{ _string=value;}
			get{return _string;}
		}
		#endregion Model

	}
}

