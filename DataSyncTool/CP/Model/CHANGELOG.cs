using System;
namespace DataSyncTool.Model
{
	/// <summary>
	/// CHANGELOG:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CHANGELOG
	{
		public CHANGELOG()
		{}
		#region Model
		private DateTime _act_date;
		private string _ourno;
		private string _action;
		private string _col_name;
		private string _old_val;
		private string _new_val;
		private string _cur_user;
		/// <summary>
		/// 
		/// </summary>
		public DateTime ACT_DATE
		{
			set{ _act_date=value;}
			get{return _act_date;}
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
		public string ACTION
		{
			set{ _action=value;}
			get{return _action;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COL_NAME
		{
			set{ _col_name=value;}
			get{return _col_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OLD_VAL
		{
			set{ _old_val=value;}
			get{return _old_val;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NEW_VAL
		{
			set{ _new_val=value;}
			get{return _new_val;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CUR_USER
		{
			set{ _cur_user=value;}
			get{return _cur_user;}
		}
		#endregion Model

	}
}

