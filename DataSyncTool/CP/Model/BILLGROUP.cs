﻿using System;

namespace DataSyncTool.CP.Model
{
	/// <summary>
	/// BILLGROUP:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BILLGROUP
	{
		public BILLGROUP()
		{}
		#region Model
		private string _groupid;
		private string _description;
		private string _text;
		private string _types;
		private decimal _displayorder;
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
		public string DESCRIPTION
		{
			set{ _description=value;}
			get{return _description;}
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
		public string TYPES
		{
			set{ _types=value;}
			get{return _types;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal DISPLAYORDER
		{
			set{ _displayorder=value;}
			get{return _displayorder;}
		}
		#endregion Model

	}
}

