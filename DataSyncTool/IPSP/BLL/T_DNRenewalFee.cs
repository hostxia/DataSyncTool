﻿/**  版本信息模板在安装目录下，可自行修改。
* T_DNRenewalFee.cs
*
* 功 能： N/A
* 类 名： T_DNRenewalFee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:39   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/

using System;
using System.Collections.Generic;
using System.Data;

namespace DataSyncTool.IPSP.BLL
{
	/// <summary>
	/// T_DNRenewalFee
	/// </summary>
	public partial class T_DNRenewalFee
	{
		private readonly IPSP.DAL.T_DNRenewalFee dal=new IPSP.DAL.T_DNRenewalFee();
		public T_DNRenewalFee()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_CaseID,int n_BillID,int n_DRenewalFeeID)
		{
			return dal.Exists(n_CaseID,n_BillID,n_DRenewalFeeID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(IPSP.Model.T_DNRenewalFee model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(IPSP.Model.T_DNRenewalFee model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int n_DRenewalFeeID)
		{
			
			return dal.Delete(n_DRenewalFeeID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int n_CaseID,int n_BillID,int n_DRenewalFeeID)
		{
			
			return dal.Delete(n_CaseID,n_BillID,n_DRenewalFeeID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string n_DRenewalFeeIDlist )
		{
			return dal.DeleteList(Common.PageValidate.SafeLongFilter(n_DRenewalFeeIDlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public IPSP.Model.T_DNRenewalFee GetModel(int n_DRenewalFeeID)
		{
			
			return dal.GetModel(n_DRenewalFeeID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public IPSP.Model.T_DNRenewalFee GetModelByCache(int n_DRenewalFeeID)
		{
			
			string CacheKey = "T_DNRenewalFeeModel-" + n_DRenewalFeeID;
			object objModel = Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(n_DRenewalFeeID);
					if (objModel != null)
					{
						int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
						Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (IPSP.Model.T_DNRenewalFee)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<IPSP.Model.T_DNRenewalFee> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<IPSP.Model.T_DNRenewalFee> DataTableToList(DataTable dt)
		{
			List<IPSP.Model.T_DNRenewalFee> modelList = new List<IPSP.Model.T_DNRenewalFee>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				IPSP.Model.T_DNRenewalFee model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

