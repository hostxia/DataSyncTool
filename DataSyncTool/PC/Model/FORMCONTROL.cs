using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// FORMCONTROL:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FORMCONTROL
	{
		public FORMCONTROL()
		{}
		#region Model
		private string _formname;
		private string _username;
		private string _controlname;
		private string _instruction;
		/// <summary>
		/// 
		/// </summary>
		public string FORMNAME
		{
			set{ _formname=value;}
			get{return _formname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USERNAME
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTROLNAME
		{
			set{ _controlname=value;}
			get{return _controlname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INSTRUCTION
		{
			set{ _instruction=value;}
			get{return _instruction;}
		}
		#endregion Model

	}
}

