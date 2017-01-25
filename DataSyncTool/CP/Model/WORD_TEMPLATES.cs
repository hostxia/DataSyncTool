using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// WORD_TEMPLATES:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WORD_TEMPLATES
	{
		public WORD_TEMPLATES()
		{}
		#region Model
		private string _file_name;
		private string _description;
		private string _template_type;
		private string _usedby;
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
		public string DESCRIPTION
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TEMPLATE_TYPE
		{
			set{ _template_type=value;}
			get{return _template_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USEDBY
		{
			set{ _usedby=value;}
			get{return _usedby;}
		}
		#endregion Model

	}
}

