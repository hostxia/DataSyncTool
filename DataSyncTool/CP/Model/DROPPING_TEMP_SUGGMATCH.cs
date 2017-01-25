using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// DROPPING_TEMP_SUGGMATCH:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DROPPING_TEMP_SUGGMATCH
	{
		public DROPPING_TEMP_SUGGMATCH()
		{}
		#region Model
		private string _caseno;
		private string _subno;
		private string _country;
		private string _appstatus;
		private string _appno;
		private string _ourno;
		/// <summary>
		/// 
		/// </summary>
		public string CASENO
		{
			set{ _caseno=value;}
			get{return _caseno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUBNO
		{
			set{ _subno=value;}
			get{return _subno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COUNTRY
		{
			set{ _country=value;}
			get{return _country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPSTATUS
		{
			set{ _appstatus=value;}
			get{return _appstatus;}
		}
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
		public string OURNO
		{
			set{ _ourno=value;}
			get{return _ourno;}
		}
		#endregion Model

	}
}

