﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using DataSyncTool.Model;
namespace DataSyncTool.BLL
{
	/// <summary>
	/// WORD_BOOKMARKS
	/// </summary>
	public partial class WORD_BOOKMARKS
	{
		private readonly DataSyncTool.DAL.WORD_BOOKMARKS dal=new DataSyncTool.DAL.WORD_BOOKMARKS();
		public WORD_BOOKMARKS()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string FILE_NAME,string BOOKMARK)
		{
			return dal.Exists(FILE_NAME,BOOKMARK);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.WORD_BOOKMARKS model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DataSyncTool.Model.WORD_BOOKMARKS model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string FILE_NAME,string BOOKMARK)
		{
			
			return dal.Delete(FILE_NAME,BOOKMARK);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DataSyncTool.Model.WORD_BOOKMARKS GetModel(string FILE_NAME,string BOOKMARK)
		{
			
			return dal.GetModel(FILE_NAME,BOOKMARK);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public DataSyncTool.Model.WORD_BOOKMARKS GetModelByCache(string FILE_NAME,string BOOKMARK)
		{
			
			string CacheKey = "WORD_BOOKMARKSModel-" + FILE_NAME+BOOKMARK;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(FILE_NAME,BOOKMARK);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (DataSyncTool.Model.WORD_BOOKMARKS)objModel;
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
		public List<DataSyncTool.Model.WORD_BOOKMARKS> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DataSyncTool.Model.WORD_BOOKMARKS> DataTableToList(DataTable dt)
		{
			List<DataSyncTool.Model.WORD_BOOKMARKS> modelList = new List<DataSyncTool.Model.WORD_BOOKMARKS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DataSyncTool.Model.WORD_BOOKMARKS model;
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

