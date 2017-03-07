/**  版本信息模板在安装目录下，可自行修改。
* TCode_SecurityConfig.cs
*
* 功 能： N/A
* 类 名： TCode_SecurityConfig
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:59   N/A    初版
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
	/// TCode_SecurityConfig:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_SecurityConfig
	{
		public TCode_SecurityConfig()
		{}
		#region Model
		private int _n_id;
		private string _s_pwdcomplexity;
		private int? _n_pwdminlength;
		private string _s_pwdregular;
		private string _s_pwdcycle;
		private int? _n_pwdyear;
		private int? _n_pwdmonth;
		private int? _n_pwdday;
		private string _s_idle;
		private int? _n_timeoutday;
		private int? _n_timeouthour;
		private int? _n_timeoutminute;
		private string _s_failuretry;
		private int? _n_lockhour;
		private int? _n_lockminute;
		private int? _n_retry;
		private string _s_accesscontrol;
		private string _s_ip;
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
		public string s_PwdComplexity
		{
			set{ _s_pwdcomplexity=value;}
			get{return _s_pwdcomplexity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PwdMinLength
		{
			set{ _n_pwdminlength=value;}
			get{return _n_pwdminlength;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PwdRegular
		{
			set{ _s_pwdregular=value;}
			get{return _s_pwdregular;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PwdCycle
		{
			set{ _s_pwdcycle=value;}
			get{return _s_pwdcycle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PwdYear
		{
			set{ _n_pwdyear=value;}
			get{return _n_pwdyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PwdMonth
		{
			set{ _n_pwdmonth=value;}
			get{return _n_pwdmonth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PwdDay
		{
			set{ _n_pwdday=value;}
			get{return _n_pwdday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Idle
		{
			set{ _s_idle=value;}
			get{return _s_idle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TimeoutDay
		{
			set{ _n_timeoutday=value;}
			get{return _n_timeoutday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TimeoutHour
		{
			set{ _n_timeouthour=value;}
			get{return _n_timeouthour;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TimeoutMinute
		{
			set{ _n_timeoutminute=value;}
			get{return _n_timeoutminute;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FailureTry
		{
			set{ _s_failuretry=value;}
			get{return _s_failuretry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_LockHour
		{
			set{ _n_lockhour=value;}
			get{return _n_lockhour;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_LockMinute
		{
			set{ _n_lockminute=value;}
			get{return _n_lockminute;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Retry
		{
			set{ _n_retry=value;}
			get{return _n_retry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AccessControl
		{
			set{ _s_accesscontrol=value;}
			get{return _s_accesscontrol;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IP
		{
			set{ _s_ip=value;}
			get{return _s_ip;}
		}
		#endregion Model

	}
}

