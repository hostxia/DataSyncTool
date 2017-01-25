using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// FCASE_WORKLOAD:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FCASE_WORKLOAD
	{
		public FCASE_WORKLOAD()
		{}
		#region Model
		private string _pid;
		private string _ourno;
		private string _item;
		private string _agent;
		private string _unit;
		private decimal _amount;
		private string _language;
		private DateTime _completedate;
		private string _issue;
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
		public string ITEM
		{
			set{ _item=value;}
			get{return _item;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AGENT
		{
			set{ _agent=value;}
			get{return _agent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UNIT
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal AMOUNT
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LANGUAGE
		{
			set{ _language=value;}
			get{return _language;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime COMPLETEDATE
		{
			set{ _completedate=value;}
			get{return _completedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ISSUE
		{
			set{ _issue=value;}
			get{return _issue;}
		}
		#endregion Model

	}
}

