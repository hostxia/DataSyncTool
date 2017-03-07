using System;
using System.Collections.Generic;
using System.Data;
using DataSyncTool.Common;

namespace DataSyncTool.PC.BLL
{
	/// <summary>
	/// PTFILE_CHECK
	/// </summary>
	public partial class PTFILE_CHECK
	{
		private readonly DAL.PTFILE_CHECK dal=new DAL.PTFILE_CHECK();
		public PTFILE_CHECK()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string NAME)
		{
			return dal.Exists(NAME);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.PTFILE_CHECK model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.PTFILE_CHECK model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string NAME)
		{
			
			return dal.Delete(NAME);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string NAMElist )
		{
			return dal.DeleteList(PageValidate.SafeLongFilter(NAMElist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.PTFILE_CHECK GetModel(string NAME)
		{
			
			return dal.GetModel(NAME);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.PTFILE_CHECK GetModelByCache(string NAME)
		{
			
			string CacheKey = "PTFILE_CHECKModel-" + NAME;
			object objModel = DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(NAME);
					if (objModel != null)
					{
						int ModelCache = ConfigHelper.GetConfigInt("ModelCache");
						DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.PTFILE_CHECK)objModel;
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
		public List<Model.PTFILE_CHECK> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.PTFILE_CHECK> DataTableToList(DataTable dt)
		{
			List<Model.PTFILE_CHECK> modelList = new List<Model.PTFILE_CHECK>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.PTFILE_CHECK model;
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

