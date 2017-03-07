using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// JOBINCIDENT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JOBINCIDENT
	{
		public JOBINCIDENT()
		{}
		#region Model
		private string _jobid;
		private string _incident;
		private string _severity;
		private string _comments;
		/// <summary>
		/// 
		/// </summary>
		public string JOBID
		{
			set{ _jobid=value;}
			get{return _jobid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INCIDENT
		{
			set{ _incident=value;}
			get{return _incident;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SEVERITY
		{
			set{ _severity=value;}
			get{return _severity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMMENTS
		{
			set{ _comments=value;}
			get{return _comments;}
		}
		#endregion Model

	}
}

