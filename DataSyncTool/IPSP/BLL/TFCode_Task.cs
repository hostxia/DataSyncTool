﻿/**  版本信息模板在安装目录下，可自行修改。
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
using System.Collections.Generic;
using System.Data;

namespace DataSyncTool.IPSP.BLL
{
	/// <summary>
	/// TFCode_Task
	/// </summary>
	public partial class TFCode_Task
	{
		private readonly IPSP.DAL.TFCode_Task dal=new IPSP.DAL.TFCode_Task();
		public TFCode_Task()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid g_ID)
		{
			return dal.Exists(g_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(IPSP.Model.TFCode_Task model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(IPSP.Model.TFCode_Task model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid g_ID)
		{
			
			return dal.Delete(g_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string g_IDlist )
		{
			return dal.DeleteList(Common.PageValidate.SafeLongFilter(g_IDlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public IPSP.Model.TFCode_Task GetModel(Guid g_ID)
		{
			
			return dal.GetModel(g_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public IPSP.Model.TFCode_Task GetModelByCache(Guid g_ID)
		{
			
			string CacheKey = "TFCode_TaskModel-" + g_ID;
			object objModel = Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(g_ID);
					if (objModel != null)
					{
						int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
						Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (IPSP.Model.TFCode_Task)objModel;
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
		public List<IPSP.Model.TFCode_Task> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<IPSP.Model.TFCode_Task> DataTableToList(DataTable dt)
		{
			List<IPSP.Model.TFCode_Task> modelList = new List<IPSP.Model.TFCode_Task>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				IPSP.Model.TFCode_Task model;
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

