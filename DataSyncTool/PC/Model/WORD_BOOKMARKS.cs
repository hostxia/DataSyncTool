using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// WORD_BOOKMARKS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WORD_BOOKMARKS
	{
		public WORD_BOOKMARKS()
		{}
		#region Model
		private string _file_name;
		private string _bookmark;
		private string _description;
		/// <summary>
		/// 
		/// </summary>
		public string FILE_NAME
		{
			set{ _file_name=value;}
			get{return _file_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BOOKMARK
		{
			set{ _bookmark=value;}
			get{return _bookmark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DESCRIPTION
		{
			set{ _description=value;}
			get{return _description;}
		}
		#endregion Model

	}
}

