﻿using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// TEST2:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST2
	{
		public TEST2()
		{}
		#region Model
		private string _ourno;
		private string _str;
		/// <summary>
		/// 
		/// </summary>
		public string OURNO
		{
			set{ _ourno=value;}
			get{return _ourno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STR
		{
			set{ _str=value;}
			get{return _str;}
		}
		#endregion Model

	}
}

