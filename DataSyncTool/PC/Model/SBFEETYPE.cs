using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// SBFEETYPE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SBFEETYPE
	{
		public SBFEETYPE()
		{}
		#region Model
		private string _typename;
		private string _typegroup;
		/// <summary>
		/// 
		/// </summary>
		public string TYPENAME
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPEGROUP
		{
			set{ _typegroup=value;}
			get{return _typegroup;}
		}
		#endregion Model

	}
}

