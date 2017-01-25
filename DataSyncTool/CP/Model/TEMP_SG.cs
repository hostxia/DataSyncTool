using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// TEMP_SG:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEMP_SG
	{
		public TEMP_SG()
		{}
		#region Model
		private string _id;
		private string _name;
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
		#endregion Model

	}
}

