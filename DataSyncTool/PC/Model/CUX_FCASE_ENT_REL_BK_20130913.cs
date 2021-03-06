﻿using System;

namespace DataSyncTool.PC.Model
{
	/// <summary>
	/// CUX_FCASE_ENT_REL_BK_20130913:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CUX_FCASE_ENT_REL_BK_20130913
	{
		public CUX_FCASE_ENT_REL_BK_20130913()
		{}
		#region Model
		private string _pid;
		private string _ourno;
		private string _eid;
		private string _role;
		private string _nationality;
		private string _country;
		private string _province;
		private string _addr;
		private decimal _ent_order;
		private string _ent_ref;
		private string _orig_name;
		private string _tran_name;
		/// <summary>
		/// 
		/// </summary>
		public string PID
		{
			set{ _pid=value;}
			get{return _pid;}
		}
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
		public string EID
		{
			set{ _eid=value;}
			get{return _eid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ROLE
		{
			set{ _role=value;}
			get{return _role;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NATIONALITY
		{
			set{ _nationality=value;}
			get{return _nationality;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COUNTRY
		{
			set{ _country=value;}
			get{return _country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROVINCE
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADDR
		{
			set{ _addr=value;}
			get{return _addr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal ENT_ORDER
		{
			set{ _ent_order=value;}
			get{return _ent_order;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ENT_REF
		{
			set{ _ent_ref=value;}
			get{return _ent_ref;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORIG_NAME
		{
			set{ _orig_name=value;}
			get{return _orig_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TRAN_NAME
		{
			set{ _tran_name=value;}
			get{return _tran_name;}
		}
		#endregion Model

	}
}

