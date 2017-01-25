﻿using System;
using System.Collections.Generic;
using System.Data;
using DataSyncTool.Common;

namespace DataSyncTool.CP.BLL
{
	/// <summary>
	/// DROPPING_CASE
	/// </summary>
	public partial class DROPPING_CASE
	{
		private readonly DAL.DROPPING_CASE dal=new DAL.DROPPING_CASE();
		public DROPPING_CASE()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string APPNO,string PUBGZTNO)
		{
			return dal.Exists(APPNO,PUBGZTNO);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.DROPPING_CASE model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.DROPPING_CASE model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string APPNO,string PUBGZTNO)
		{
			
			return dal.Delete(APPNO,PUBGZTNO);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.DROPPING_CASE GetModel(string APPNO,string PUBGZTNO)
		{
			
			return dal.GetModel(APPNO,PUBGZTNO);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.DROPPING_CASE GetModelByCache(string APPNO,string PUBGZTNO)
		{
			
			string CacheKey = "DROPPING_CASEModel-" + APPNO+PUBGZTNO;
			object objModel = DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(APPNO,PUBGZTNO);
					if (objModel != null)
					{
						int ModelCache = ConfigHelper.GetConfigInt("ModelCache");
						DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.DROPPING_CASE)objModel;
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
		public List<Model.DROPPING_CASE> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.DROPPING_CASE> DataTableToList(DataTable dt)
		{
			List<Model.DROPPING_CASE> modelList = new List<Model.DROPPING_CASE>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.DROPPING_CASE model;
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

