using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// DROPPING_TEMP_SUTFER:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DROPPING_TEMP_SUTFER
	{
		public DROPPING_TEMP_SUTFER()
		{}
		#region Model
		private string _ipdno;
		private string _country;
		private string _ourno;
		private string _appstatus;
		private string _appno;
		private DateTime _filingdate;
		/// <summary>
		/// 
		/// </summary>
		public string IPDNO
		{
			set{ _ipdno=value;}
			get{return _ipdno;}
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
		public string OURNO
		{
			set{ _ourno=value;}
			get{return _ourno;}
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
		public DateTime FILINGDATE
		{
			set{ _filingdate=value;}
			get{return _filingdate;}
		}
		#endregion Model

	}
}

