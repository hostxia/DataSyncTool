﻿using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// TEST_APP:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEST_APP
	{
		public TEST_APP()
		{}
		#region Model
		private string _app_number;
		private string _name1;
		private string _name2;
		/// <summary>
		/// 
		/// </summary>
		public string APP_NUMBER
		{
			set{ _app_number=value;}
			get{return _app_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NAME1
		{
			set{ _name1=value;}
			get{return _name1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NAME2
		{
			set{ _name2=value;}
			get{return _name2;}
		}
		#endregion Model

	}
}

