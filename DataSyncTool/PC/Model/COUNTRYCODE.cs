using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// COUNTRYCODE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class COUNTRYCODE
	{
		public COUNTRYCODE()
		{}
		#region Model
		private string _id;
		private string _name;
		private string _cname;
		private string _dialingprefix;
		private string _tzone;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NAME
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CNAME
		{
			set{ _cname=value;}
			get{return _cname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DIALINGPREFIX
		{
			set{ _dialingprefix=value;}
			get{return _dialingprefix;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TZONE
		{
			set{ _tzone=value;}
			get{return _tzone;}
		}
		#endregion Model

	}
}

