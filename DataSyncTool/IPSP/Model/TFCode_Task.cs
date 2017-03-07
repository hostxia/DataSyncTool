/**  版本信息模板在安装目录下，可自行修改。
* TFCode_Task.cs
*
* 功 能： N/A
* 类 名： TFCode_Task
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:49   N/A    初版
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
	/// TFCode_Task:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TFCode_Task
	{
		public TFCode_Task()
		{}
		#region Model
		private Guid _g_id;
		private string _s_name;
		private string _s_description;
		private int? _n_tasktypeid;
		private int? _n_demandtypeid;
		private int? _n_level;
		private string _s_executortype;
		private string _s_executorvalue;
		private string _s_finishcondition;
		private string _s_startdatecalcrule;
		private string _s_startdatetaskcode;
		private string _s_startdatetaskdatetype;
		private Guid _g_startcodedeadlineguid;
		private int? _n_startdatevalue1;
		private string _s_startdatetype1;
		private int? _n_startdatevalue2;
		private string _s_startdatetype2;
		private string _s_enddatecalcrule;
		private string _s_enddatetaskcode;
		private string _s_enddatetaskdatetype;
		private Guid _g_endcodedeadlineguid;
		private int? _n_enddatevalue1;
		private string _s_enddatetype1;
		private int? _n_enddatevalue2;
		private string _s_enddatetype2;
		private Guid _g_endfinallycodedeadlineguid;
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
		public int? n_TaskTypeID
		{
			set{ _n_tasktypeid=value;}
			get{return _n_tasktypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_DemandTypeID
		{
			set{ _n_demandtypeid=value;}
			get{return _n_demandtypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Level
		{
			set{ _n_level=value;}
			get{return _n_level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ExecutorType
		{
			set{ _s_executortype=value;}
			get{return _s_executortype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ExecutorValue
		{
			set{ _s_executorvalue=value;}
			get{return _s_executorvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FinishCondition
		{
			set{ _s_finishcondition=value;}
			get{return _s_finishcondition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_StartDateCalcRule
		{
			set{ _s_startdatecalcrule=value;}
			get{return _s_startdatecalcrule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_StartDateTaskCode
		{
			set{ _s_startdatetaskcode=value;}
			get{return _s_startdatetaskcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_StartDateTaskDateType
		{
			set{ _s_startdatetaskdatetype=value;}
			get{return _s_startdatetaskdatetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_StartCodeDeadlineGuid
		{
			set{ _g_startcodedeadlineguid=value;}
			get{return _g_startcodedeadlineguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_StartDateValue1
		{
			set{ _n_startdatevalue1=value;}
			get{return _n_startdatevalue1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_StartDateType1
		{
			set{ _s_startdatetype1=value;}
			get{return _s_startdatetype1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_StartDateValue2
		{
			set{ _n_startdatevalue2=value;}
			get{return _n_startdatevalue2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_StartDateType2
		{
			set{ _s_startdatetype2=value;}
			get{return _s_startdatetype2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EndDateCalcRule
		{
			set{ _s_enddatecalcrule=value;}
			get{return _s_enddatecalcrule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EndDateTaskCode
		{
			set{ _s_enddatetaskcode=value;}
			get{return _s_enddatetaskcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EndDateTaskDateType
		{
			set{ _s_enddatetaskdatetype=value;}
			get{return _s_enddatetaskdatetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_EndCodeDeadlineGuid
		{
			set{ _g_endcodedeadlineguid=value;}
			get{return _g_endcodedeadlineguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_EndDateValue1
		{
			set{ _n_enddatevalue1=value;}
			get{return _n_enddatevalue1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EndDateType1
		{
			set{ _s_enddatetype1=value;}
			get{return _s_enddatetype1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_EndDateValue2
		{
			set{ _n_enddatevalue2=value;}
			get{return _n_enddatevalue2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EndDateType2
		{
			set{ _s_enddatetype2=value;}
			get{return _s_enddatetype2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_EndFinallyCodeDeadlineGuid
		{
			set{ _g_endfinallycodedeadlineguid=value;}
			get{return _g_endfinallycodedeadlineguid;}
		}
		#endregion Model

	}
}

