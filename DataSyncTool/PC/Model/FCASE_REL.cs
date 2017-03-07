using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// FCASE_REL:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FCASE_REL
	{
		public FCASE_REL()
		{}
		#region Model
		private string _pid;
		private string _earlier;
		private string _later;
		private string _relation;
		private string _explanation;
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
		public string EARLIER
		{
			set{ _earlier=value;}
			get{return _earlier;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LATER
		{
			set{ _later=value;}
			get{return _later;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RELATION
		{
			set{ _relation=value;}
			get{return _relation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EXPLANATION
		{
			set{ _explanation=value;}
			get{return _explanation;}
		}
		#endregion Model

	}
}

