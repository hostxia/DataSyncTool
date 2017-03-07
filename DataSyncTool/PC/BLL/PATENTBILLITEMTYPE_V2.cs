using System;
using System.Collections.Generic;
using System.Data;
using DataSyncTool.Common;

namespace DataSyncTool.PC.BLL
{
	/// <summary>
	/// PATENTBILLITEMTYPE_V2
	/// </summary>
	public partial class PATENTBILLITEMTYPE_V2
	{
		private readonly DAL.PATENTBILLITEMTYPE_V2 dal=new DAL.PATENTBILLITEMTYPE_V2();
		public PATENTBILLITEMTYPE_V2()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string BILLCODE)
		{
			return dal.Exists(BILLCODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.PATENTBILLITEMTYPE_V2 model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.PATENTBILLITEMTYPE_V2 model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string BILLCODE)
		{
			
			return dal.Delete(BILLCODE);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string BILLCODElist )
		{
			return dal.DeleteList(PageValidate.SafeLongFilter(BILLCODElist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.PATENTBILLITEMTYPE_V2 GetModel(string BILLCODE)
		{
			
			return dal.GetModel(BILLCODE);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.PATENTBILLITEMTYPE_V2 GetModelByCache(string BILLCODE)
		{
			
			string CacheKey = "PATENTBILLITEMTYPE_V2Model-" + BILLCODE;
			object objModel = DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(BILLCODE);
					if (objModel != null)
					{
						int ModelCache = ConfigHelper.GetConfigInt("ModelCache");
						DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.PATENTBILLITEMTYPE_V2)objModel;
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
		public List<Model.PATENTBILLITEMTYPE_V2> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.PATENTBILLITEMTYPE_V2> DataTableToList(DataTable dt)
		{
			List<Model.PATENTBILLITEMTYPE_V2> modelList = new List<Model.PATENTBILLITEMTYPE_V2>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.PATENTBILLITEMTYPE_V2 model;
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

