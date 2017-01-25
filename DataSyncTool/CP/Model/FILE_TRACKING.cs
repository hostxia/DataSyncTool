using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// FILE_TRACKING:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FILE_TRACKING
	{
		public FILE_TRACKING()
		{}
		#region Model
		private string _ourno;
		private string _borrower;
		private DateTime _borrowtime;
		private string _status;
		private string _library;
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
		public string BORROWER
		{
			set{ _borrower=value;}
			get{return _borrower;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime BORROWTIME
		{
			set{ _borrowtime=value;}
			get{return _borrowtime;}
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
		/// 所在卷库
		/// </summary>
		public string LIBRARY
		{
			set{ _library=value;}
			get{return _library;}
		}
		#endregion Model

	}
}

