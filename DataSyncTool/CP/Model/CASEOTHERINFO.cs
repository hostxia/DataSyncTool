using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// CASEOTHERINFO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CASEOTHERINFO
	{
		public CASEOTHERINFO()
		{}
		#region Model
		private string _caseno;
		private string _infotype;
		private string _info;
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
		public string INFOTYPE
		{
			set{ _infotype=value;}
			get{return _infotype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INFO
		{
			set{ _info=value;}
			get{return _info;}
		}
		#endregion Model

	}
}

