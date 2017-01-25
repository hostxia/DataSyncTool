﻿using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// IDTEXT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class IDTEXT
	{
		public IDTEXT()
		{}
		#region Model
		private string _idgroup;
		private string _id;
		private string _text;
		private decimal _seq;
		/// <summary>
		/// 
		/// </summary>
		public string IDGROUP
		{
			set{ _idgroup=value;}
			get{return _idgroup;}
		}
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
		public string TEXT
		{
			set{ _text=value;}
			get{return _text;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal SEQ
		{
			set{ _seq=value;}
			get{return _seq;}
		}
		#endregion Model

	}
}

