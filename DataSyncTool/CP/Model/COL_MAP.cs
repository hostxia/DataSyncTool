using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// COL_MAP:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class COL_MAP
	{
		public COL_MAP()
		{}
		#region Model
		private string _col;
		private string _heading;
		/// <summary>
		/// 
		/// </summary>
		public string COL
		{
			set{ _col=value;}
			get{return _col;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HEADING
		{
			set{ _heading=value;}
			get{return _heading;}
		}
		#endregion Model

	}
}

