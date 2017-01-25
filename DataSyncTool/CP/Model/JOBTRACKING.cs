using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// JOBTRACKING:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JOBTRACKING
	{
		public JOBTRACKING()
		{}
		#region Model
		private string _ourno;
		private string _pid;
		private string _workerref;
		private string _jobtype;
		private decimal _amount;
		private string _workerid;
		private string _workeridl2;
		private DateTime _entrustdate;
		private DateTime _duedate;
		private DateTime _completedate;
		private decimal _score;
		private string _comments;
		private string _assessor;
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
		public string PID
		{
			set{ _pid=value;}
			get{return _pid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WORKERREF
		{
			set{ _workerref=value;}
			get{return _workerref;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JOBTYPE
		{
			set{ _jobtype=value;}
			get{return _jobtype;}
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
		public string WORKERID
		{
			set{ _workerid=value;}
			get{return _workerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WORKERIDL2
		{
			set{ _workeridl2=value;}
			get{return _workeridl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ENTRUSTDATE
		{
			set{ _entrustdate=value;}
			get{return _entrustdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DUEDATE
		{
			set{ _duedate=value;}
			get{return _duedate;}
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
		public decimal SCORE
		{
			set{ _score=value;}
			get{return _score;}
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
		public string ASSESSOR
		{
			set{ _assessor=value;}
			get{return _assessor;}
		}
		#endregion Model

	}
}

