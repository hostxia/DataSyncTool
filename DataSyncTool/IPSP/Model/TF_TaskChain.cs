/**  版本信息模板在安装目录下，可自行修改。
* TF_TaskChain.cs
*
* 功 能： N/A
* 类 名： TF_TaskChain
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:18   N/A    初版
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
	/// TF_TaskChain:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TF_TaskChain
	{
		public TF_TaskChain()
		{}
		#region Model
		private Guid _g_id;
		private Guid _g_codetaskchainguid;
		private string _s_name;
		private string _s_description;
		private string _s_state;
		private string _s_triggertype;
		private string _s_relatedobjecttype;
		private int? _n_relatedobjectid;
		private string _s_relatedinfo1;
		private string _s_relatedinfo2;
		private int? _n_creator;
		private DateTime? _dt_createtime;
		private int? _n_editor;
		private DateTime? _dt_edittime;
		private int? _n_taskchaintypeid;
		private int _n_num;
		/// <summary>
		/// 
		/// </summary>
		public Guid g_ID
		{
			set{ _g_id=value;}
			get{return _g_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_CodeTaskChainGuid
		{
			set{ _g_codetaskchainguid=value;}
			get{return _g_codetaskchainguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Name
		{
			set{ _s_name=value;}
			get{return _s_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Description
		{
			set{ _s_description=value;}
			get{return _s_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_State
		{
			set{ _s_state=value;}
			get{return _s_state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TriggerType
		{
			set{ _s_triggertype=value;}
			get{return _s_triggertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RelatedObjectType
		{
			set{ _s_relatedobjecttype=value;}
			get{return _s_relatedobjecttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_RelatedObjectID
		{
			set{ _n_relatedobjectid=value;}
			get{return _n_relatedobjectid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RelatedInfo1
		{
			set{ _s_relatedinfo1=value;}
			get{return _s_relatedinfo1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RelatedInfo2
		{
			set{ _s_relatedinfo2=value;}
			get{return _s_relatedinfo2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Creator
		{
			set{ _n_creator=value;}
			get{return _n_creator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CreateTime
		{
			set{ _dt_createtime=value;}
			get{return _dt_createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Editor
		{
			set{ _n_editor=value;}
			get{return _n_editor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_EditTime
		{
			set{ _dt_edittime=value;}
			get{return _dt_edittime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TaskChainTypeID
		{
			set{ _n_taskchaintypeid=value;}
			get{return _n_taskchaintypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_Num
		{
			set{ _n_num=value;}
			get{return _n_num;}
		}
		#endregion Model

	}
}

