using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// DROPPING_HKPATENT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DROPPING_HKPATENT
	{
		public DROPPING_HKPATENT()
		{}
		#region Model
		private string _hkno;
		private string _ourno;
		private string _cn_appno;
		private DateTime _cn_appdate;
		private string _cn_pubno;
		private DateTime _cn_pubdate;
		private string _cn_grantno;
		private DateTime _cn_grantdate;
		private DateTime _earliest_maintenance_date;
		private DateTime _earliest_renew_date;
		private DateTime _step1_date;
		private DateTime _step2_date;
		/// <summary>
		/// 
		/// </summary>
		public string HKNO
		{
			set{ _hkno=value;}
			get{return _hkno;}
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
		public string CN_APPNO
		{
			set{ _cn_appno=value;}
			get{return _cn_appno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CN_APPDATE
		{
			set{ _cn_appdate=value;}
			get{return _cn_appdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CN_PUBNO
		{
			set{ _cn_pubno=value;}
			get{return _cn_pubno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CN_PUBDATE
		{
			set{ _cn_pubdate=value;}
			get{return _cn_pubdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CN_GRANTNO
		{
			set{ _cn_grantno=value;}
			get{return _cn_grantno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CN_GRANTDATE
		{
			set{ _cn_grantdate=value;}
			get{return _cn_grantdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EARLIEST_MAINTENANCE_DATE
		{
			set{ _earliest_maintenance_date=value;}
			get{return _earliest_maintenance_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EARLIEST_RENEW_DATE
		{
			set{ _earliest_renew_date=value;}
			get{return _earliest_renew_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime STEP1_DATE
		{
			set{ _step1_date=value;}
			get{return _step1_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime STEP2_DATE
		{
			set{ _step2_date=value;}
			get{return _step2_date;}
		}
		#endregion Model

	}
}

