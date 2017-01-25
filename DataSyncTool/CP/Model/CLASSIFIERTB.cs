using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// CLASSIFIERTB:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CLASSIFIERTB
	{
		public CLASSIFIERTB()
		{}
		#region Model
		private string _id;
		private string _classname;
		private string _columnname;
		private string _setscale;
		private string _comments;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLASSNAME
		{
			set{ _classname=value;}
			get{return _classname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COLUMNNAME
		{
			set{ _columnname=value;}
			get{return _columnname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SETSCALE
		{
			set{ _setscale=value;}
			get{return _setscale;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMMENTS
		{
			set{ _comments=value;}
			get{return _comments;}
		}
		#endregion Model

	}
}

