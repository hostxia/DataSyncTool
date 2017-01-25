using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// DROPPING_LEGALSTATUS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DROPPING_LEGALSTATUS
	{
		public DROPPING_LEGALSTATUS()
		{}
		#region Model
		private string _appno;
		private string _status;
		private string _content;
		private string _announced;
		private string _anno;
		/// <summary>
		/// 
		/// </summary>
		public string APPNO
		{
			set{ _appno=value;}
			get{return _appno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTENT
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ANNOUNCED
		{
			set{ _announced=value;}
			get{return _announced;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ANNO
		{
			set{ _anno=value;}
			get{return _anno;}
		}
		#endregion Model

	}
}

