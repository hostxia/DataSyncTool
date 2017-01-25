using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// COUNTRY_TRANSLATION:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class COUNTRY_TRANSLATION
	{
		public COUNTRY_TRANSLATION()
		{}
		#region Model
		private string _name;
		private string _cname;
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
		#endregion Model

	}
}

