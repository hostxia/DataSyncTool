using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// HEADERMAPPINGTB:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HEADERMAPPINGTB
	{
		public HEADERMAPPINGTB()
		{}
		#region Model
		private string _id;
		private string _expression;
		private string _tablename;
		private string _type;
		private string _data_type;
		private string _nullable;
		private string _heading;
		private string _reportcol;
		private string _formatter;
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
		public string EXPRESSION
		{
			set{ _expression=value;}
			get{return _expression;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TABLENAME
		{
			set{ _tablename=value;}
			get{return _tablename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPE
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DATA_TYPE
		{
			set{ _data_type=value;}
			get{return _data_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NULLABLE
		{
			set{ _nullable=value;}
			get{return _nullable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HEADING
		{
			set{ _heading=value;}
			get{return _heading;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REPORTCOL
		{
			set{ _reportcol=value;}
			get{return _reportcol;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FORMATTER
		{
			set{ _formatter=value;}
			get{return _formatter;}
		}
		#endregion Model

	}
}

