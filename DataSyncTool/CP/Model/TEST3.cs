using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// TEST3:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST3
	{
		public TEST3()
		{}
		#region Model
		private string _typeid;
		private string _trans;
		/// <summary>
		/// 
		/// </summary>
		public string TYPEID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRANS
		{
			set{ _trans=value;}
			get{return _trans;}
		}
		#endregion Model

	}
}

