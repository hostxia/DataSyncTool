using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// SIMPLECOMMANDS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SIMPLECOMMANDS
	{
		public SIMPLECOMMANDS()
		{}
		#region Model
		private string _id;
		private string _name;
		private string _comments;
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
		public string COMMENTS
		{
			set{ _comments=value;}
			get{return _comments;}
		}
		#endregion Model

	}
}

