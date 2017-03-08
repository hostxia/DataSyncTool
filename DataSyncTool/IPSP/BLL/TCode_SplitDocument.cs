﻿/**  版本信息模板在安装目录下，可自行修改。
* TCode_SplitDocument.cs
*
* 功 能： N/A
* 类 名： TCode_SplitDocument
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:03   N/A    初版
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
	/// TCode_SplitDocument
	/// </summary>
	public partial class TCode_SplitDocument
	{
		private readonly IPSP.DAL.TCode_SplitDocument dal=new IPSP.DAL.TCode_SplitDocument();
		public TCode_SplitDocument()
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
		public bool Exists(int n_TemplateID,int n_SplitID)
		{
			return dal.Exists(n_TemplateID,n_SplitID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(IPSP.Model.TCode_SplitDocument model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(IPSP.Model.TCode_SplitDocument model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int n_SplitID)
		{
			
			return dal.Delete(n_SplitID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int n_TemplateID,int n_SplitID)
		{
			
			return dal.Delete(n_TemplateID,n_SplitID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string n_SplitIDlist )
		{
			return dal.DeleteList(Common.PageValidate.SafeLongFilter(n_SplitIDlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public IPSP.Model.TCode_SplitDocument GetModel(int n_SplitID)
		{
			
			return dal.GetModel(n_SplitID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public IPSP.Model.TCode_SplitDocument GetModelByCache(int n_SplitID)
		{
			
			string CacheKey = "TCode_SplitDocumentModel-" + n_SplitID;
			object objModel = Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(n_SplitID);
					if (objModel != null)
					{
						int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
						Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (IPSP.Model.TCode_SplitDocument)objModel;
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
		public List<IPSP.Model.TCode_SplitDocument> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<IPSP.Model.TCode_SplitDocument> DataTableToList(DataTable dt)
		{
			List<IPSP.Model.TCode_SplitDocument> modelList = new List<IPSP.Model.TCode_SplitDocument>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				IPSP.Model.TCode_SplitDocument model;
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
