/**  版本信息模板在安装目录下，可自行修改。
* Table_Log.cs
*
* 功 能： N/A
* 类 名： Table_Log
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:22   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/

using System;

namespace DataSyncTool.IPSP.Model
{
	/// <summary>
	/// Table_Log:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Table_Log
	{
		public Table_Log()
		{}
		#region Model
		private int _n_id;
		private int? _n_caseid;
		private int? _n_rowid;
		private string _s_caseserial;
		private string _strsql;
		private string _tablename;
		private string _excelname;
		private string _str2;
		private string _msg;
		/// <summary>
		/// 
		/// </summary>
		public int n_ID
		{
			set{ _n_id=value;}
			get{return _n_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CaseID
		{
			set{ _n_caseid=value;}
			get{return _n_caseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_RowID
		{
			set{ _n_rowid=value;}
			get{return _n_rowid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CaseSerial
		{
			set{ _s_caseserial=value;}
			get{return _s_caseserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string strsql
		{
			set{ _strsql=value;}
			get{return _strsql;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tableName
		{
			set{ _tablename=value;}
			get{return _tablename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExcelName
		{
			set{ _excelname=value;}
			get{return _excelname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string str2
		{
			set{ _str2=value;}
			get{return _str2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string msg
		{
			set{ _msg=value;}
			get{return _msg;}
		}
		#endregion Model

	}
}

