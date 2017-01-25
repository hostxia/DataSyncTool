using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// ALERTTYPEGROUP:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ALERTTYPEGROUP
	{
		public ALERTTYPEGROUP()
		{}
		#region Model
		private string _groupid;
		private string _groupname;
		private string _groupmembers;
		/// <summary>
		/// 
		/// </summary>
		public string GROUPID
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GROUPNAME
		{
			set{ _groupname=value;}
			get{return _groupname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GROUPMEMBERS
		{
			set{ _groupmembers=value;}
			get{return _groupmembers;}
		}
		#endregion Model

	}
}

