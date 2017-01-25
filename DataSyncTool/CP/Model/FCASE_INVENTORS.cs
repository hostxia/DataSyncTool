using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// FCASE_INVENTORS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FCASE_INVENTORS
	{
		public FCASE_INVENTORS()
		{}
		#region Model
		private string _pid;
		private string _ourno;
		private decimal _ent_order;
		private string _nationality;
		private string _country;
		private string _province;
		private string _addr;
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
		public decimal ENT_ORDER
		{
			set{ _ent_order=value;}
			get{return _ent_order;}
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

