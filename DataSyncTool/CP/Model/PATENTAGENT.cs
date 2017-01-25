using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// PATENTAGENT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PATENTAGENT
	{
		public PATENTAGENT()
		{}
		#region Model
		private string _id;
		private string _name;
		private string _regno;
		private string _dept;
		private string _email;
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
		public string REGNO
		{
			set{ _regno=value;}
			get{return _regno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEPT
		{
			set{ _dept=value;}
			get{return _dept;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMAIL
		{
			set{ _email=value;}
			get{return _email;}
		}
		#endregion Model

	}
}

