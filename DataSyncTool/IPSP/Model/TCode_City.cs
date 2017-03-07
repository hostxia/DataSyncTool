/**  版本信息模板在安装目录下，可自行修改。
* TCode_City.cs
*
* 功 能： N/A
* 类 名： TCode_City
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:02   N/A    初版
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
	/// TCode_City:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_City
	{
		public TCode_City()
		{}
		#region Model
		private int _n_cityid;
		private int _n_stateid;
		private string _s_cityname;
		private string _s_ocityname;
		private string _s_telareacode;
		private string _s_zipcode;
		private string _s_regioncode;
		/// <summary>
		/// 
		/// </summary>
		public int n_CityID
		{
			set{ _n_cityid=value;}
			get{return _n_cityid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_StateID
		{
			set{ _n_stateid=value;}
			get{return _n_stateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CityName
		{
			set{ _s_cityname=value;}
			get{return _s_cityname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OCityName
		{
			set{ _s_ocityname=value;}
			get{return _s_ocityname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TelAreaCode
		{
			set{ _s_telareacode=value;}
			get{return _s_telareacode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ZipCode
		{
			set{ _s_zipcode=value;}
			get{return _s_zipcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RegionCode
		{
			set{ _s_regioncode=value;}
			get{return _s_regioncode;}
		}
		#endregion Model

	}
}

