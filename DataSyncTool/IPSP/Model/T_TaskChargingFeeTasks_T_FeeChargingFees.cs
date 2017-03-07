/**  版本信息模板在安装目录下，可自行修改。
* T_TaskChargingFeeTasks_T_FeeChargingFees.cs
*
* 功 能： N/A
* 类 名： T_TaskChargingFeeTasks_T_FeeChargingFees
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:06   N/A    初版
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
	/// T_TaskChargingFeeTasks_T_FeeChargingFees:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_TaskChargingFeeTasks_T_FeeChargingFees
	{
		public T_TaskChargingFeeTasks_T_FeeChargingFees()
		{}
		#region Model
		private int _chargingfees;
		private int _chargingfeetasks;
		private int _oid;
		private int? _optimisticlockfield;
		/// <summary>
		/// 
		/// </summary>
		public int ChargingFees
		{
			set{ _chargingfees=value;}
			get{return _chargingfees;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ChargingFeeTasks
		{
			set{ _chargingfeetasks=value;}
			get{return _chargingfeetasks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OID
		{
			set{ _oid=value;}
			get{return _oid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OptimisticLockField
		{
			set{ _optimisticlockfield=value;}
			get{return _optimisticlockfield;}
		}
		#endregion Model

	}
}

