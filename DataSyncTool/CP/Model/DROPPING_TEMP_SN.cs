using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// DROPPING_TEMP_SN:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DROPPING_TEMP_SN
	{
		public DROPPING_TEMP_SN()
		{}
		#region Model
		private string _ourno;
		private string _spn;
		private string _sn;
		private string _stat;
		private string _appn;
		private DateTime _appd;
		private string _remarks;
		private string _ourno_orig;
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
		public string SPN
		{
			set{ _spn=value;}
			get{return _spn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SN
		{
			set{ _sn=value;}
			get{return _sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STAT
		{
			set{ _stat=value;}
			get{return _stat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPN
		{
			set{ _appn=value;}
			get{return _appn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime APPD
		{
			set{ _appd=value;}
			get{return _appd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARKS
		{
			set{ _remarks=value;}
			get{return _remarks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OURNO_ORIG
		{
			set{ _ourno_orig=value;}
			get{return _ourno_orig;}
		}
		#endregion Model

	}
}

