using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// FCASE_PRIORITY:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FCASE_PRIORITY
	{
		public FCASE_PRIORITY()
		{}
		#region Model
		private string _pid;
		private string _ourno;
		private DateTime _prior_date;
		private string _prior_num;
		private string _prior_country;
		/// <summary>
		/// 
		/// </summary>
		public string PID
		{
			set{ _pid=value;}
			get{return _pid;}
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
		public DateTime PRIOR_DATE
		{
			set{ _prior_date=value;}
			get{return _prior_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRIOR_NUM
		{
			set{ _prior_num=value;}
			get{return _prior_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRIOR_COUNTRY
		{
			set{ _prior_country=value;}
			get{return _prior_country;}
		}
		#endregion Model

	}
}

