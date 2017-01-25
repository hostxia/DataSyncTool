using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// FCASE_LOG:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FCASE_LOG
	{
		public FCASE_LOG()
		{}
		#region Model
		private string _pid;
		private DateTime _logdate;
		private string _content;
		private string _ourno;
		private string _item;
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
		public DateTime LOGDATE
		{
			set{ _logdate=value;}
			get{return _logdate;}
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
		public string OURNO
		{
			set{ _ourno=value;}
			get{return _ourno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM
		{
			set{ _item=value;}
			get{return _item;}
		}
		#endregion Model

	}
}

