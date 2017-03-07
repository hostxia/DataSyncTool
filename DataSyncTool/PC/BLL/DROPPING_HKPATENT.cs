using System;
using System.Collections.Generic;
using System.Data;
using DataSyncTool.Common;

namespace DataSyncTool.PC.BLL
{
	/// <summary>
	/// DROPPING_HKPATENT
	/// </summary>
	public partial class DROPPING_HKPATENT
	{
		private readonly DAL.DROPPING_HKPATENT dal=new DAL.DROPPING_HKPATENT();
		public DROPPING_HKPATENT()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string HKNO)
		{
			return dal.Exists(HKNO);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.DROPPING_HKPATENT model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.DROPPING_HKPATENT model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string HKNO)
		{
			
			return dal.Delete(HKNO);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string HKNOlist )
		{
			return dal.DeleteList(PageValidate.SafeLongFilter(HKNOlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.DROPPING_HKPATENT GetModel(string HKNO)
		{
			
			return dal.GetModel(HKNO);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.DROPPING_HKPATENT GetModelByCache(string HKNO)
		{
			
			string CacheKey = "DROPPING_HKPATENTModel-" + HKNO;
			object objModel = DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(HKNO);
					if (objModel != null)
					{
						int ModelCache = ConfigHelper.GetConfigInt("ModelCache");
						DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.DROPPING_HKPATENT)objModel;
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
		public List<Model.DROPPING_HKPATENT> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.DROPPING_HKPATENT> DataTableToList(DataTable dt)
		{
			List<Model.DROPPING_HKPATENT> modelList = new List<Model.DROPPING_HKPATENT>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.DROPPING_HKPATENT model;
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

