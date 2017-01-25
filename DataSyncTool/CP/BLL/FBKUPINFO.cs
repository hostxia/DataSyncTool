﻿using System;
using System.Collections.Generic;
using System.Data;
using DataSyncTool.Common;

namespace DataSyncTool.CP.BLL
{
	/// <summary>
	/// FBKUPINFO
	/// </summary>
	public partial class FBKUPINFO
	{
		private readonly DAL.FBKUPINFO dal=new DAL.FBKUPINFO();
		public FBKUPINFO()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string FNAME)
		{
			return dal.Exists(FNAME);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.FBKUPINFO model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.FBKUPINFO model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string FNAME)
		{
			
			return dal.Delete(FNAME);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string FNAMElist )
		{
			return dal.DeleteList(PageValidate.SafeLongFilter(FNAMElist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.FBKUPINFO GetModel(string FNAME)
		{
			
			return dal.GetModel(FNAME);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.FBKUPINFO GetModelByCache(string FNAME)
		{
			
			string CacheKey = "FBKUPINFOModel-" + FNAME;
			object objModel = DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(FNAME);
					if (objModel != null)
					{
						int ModelCache = ConfigHelper.GetConfigInt("ModelCache");
						DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.FBKUPINFO)objModel;
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
		public List<Model.FBKUPINFO> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.FBKUPINFO> DataTableToList(DataTable dt)
		{
			List<Model.FBKUPINFO> modelList = new List<Model.FBKUPINFO>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.FBKUPINFO model;
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

