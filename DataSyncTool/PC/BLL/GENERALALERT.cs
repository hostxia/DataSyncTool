﻿using System;
using System.Collections.Generic;
using System.Data;
using DataSyncTool.Common;

namespace DataSyncTool.PC.BLL
{
	/// <summary>
	/// GENERALALERT
	/// </summary>
	public partial class GENERALALERT
	{
		private readonly DAL.GENERALALERT dal=new DAL.GENERALALERT();
		public GENERALALERT()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(DateTime CREATED)
		{
			return dal.Exists(CREATED);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.GENERALALERT model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.GENERALALERT model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(DateTime CREATED)
		{
			
			return dal.Delete(CREATED);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string CREATEDlist )
		{
			return dal.DeleteList(PageValidate.SafeLongFilter(CREATEDlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.GENERALALERT GetModel(DateTime CREATED)
		{
			
			return dal.GetModel(CREATED);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.GENERALALERT GetModelByCache(DateTime CREATED)
		{
			
			string CacheKey = "GENERALALERTModel-" + CREATED;
			object objModel = DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(CREATED);
					if (objModel != null)
					{
						int ModelCache = ConfigHelper.GetConfigInt("ModelCache");
						DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.GENERALALERT)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.GENERALALERT> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.GENERALALERT> DataTableToList(DataTable dt)
		{
			List<Model.GENERALALERT> modelList = new List<Model.GENERALALERT>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.GENERALALERT model;
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

