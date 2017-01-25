using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// FORWARDOAPOLICY:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FORWARDOAPOLICY
	{
		public FORWARDOAPOLICY()
		{}
		#region Model
		private string _pid;
		private decimal _days;
		private string _description;
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
		public decimal DAYS
		{
			set{ _days=value;}
			get{return _days;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DESCRIPTION
		{
			set{ _description=value;}
			get{return _description;}
		}
		#endregion Model

	}
}

