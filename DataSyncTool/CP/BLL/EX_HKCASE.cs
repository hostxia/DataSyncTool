using System;
using System.Collections.Generic;
using System.Data;
using DataSyncTool.Common;

namespace DataSyncTool.CP.BLL
{
	/// <summary>
	/// EX_HKCASE
	/// </summary>
	public partial class EX_HKCASE
	{
		private readonly DAL.EX_HKCASE dal=new DAL.EX_HKCASE();
		public EX_HKCASE()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string HK_APP_REF)
		{
			return dal.Exists(HK_APP_REF);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.EX_HKCASE model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.EX_HKCASE model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string HK_APP_REF)
		{
			
			return dal.Delete(HK_APP_REF);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string HK_APP_REFlist )
		{
			return dal.DeleteList(PageValidate.SafeLongFilter(HK_APP_REFlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.EX_HKCASE GetModel(string HK_APP_REF)
		{
			
			return dal.GetModel(HK_APP_REF);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.EX_HKCASE GetModelByCache(string HK_APP_REF)
		{
			
			string CacheKey = "EX_HKCASEModel-" + HK_APP_REF;
			object objModel = DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(HK_APP_REF);
					if (objModel != null)
					{
						int ModelCache = ConfigHelper.GetConfigInt("ModelCache");
						DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.EX_HKCASE)objModel;
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
		public List<Model.EX_HKCASE> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.EX_HKCASE> DataTableToList(DataTable dt)
		{
			List<Model.EX_HKCASE> modelList = new List<Model.EX_HKCASE>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.EX_HKCASE model;
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

