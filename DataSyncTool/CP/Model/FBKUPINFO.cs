using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// FBKUPINFO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FBKUPINFO
	{
		public FBKUPINFO()
		{}
		#region Model
		private string _fname;
		private decimal _bktime=0M;
		private string _comments;
		private string _caseno;
		private DateTime _lbkt;
		/// <summary>
		/// 
		/// </summary>
		public string FNAME
		{
			set{ _fname=value;}
			get{return _fname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal BKTIME
		{
			set{ _bktime=value;}
			get{return _bktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMMENTS
		{
			set{ _comments=value;}
			get{return _comments;}
		}
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
		public DateTime LBKT
		{
			set{ _lbkt=value;}
			get{return _lbkt;}
		}
		#endregion Model

	}
}

