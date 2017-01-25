using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using DataSyncTool.Model;
namespace DataSyncTool.BLL
{
	/// <summary>
	/// BILLFEEMNT
	/// </summary>
	public partial class BILLFEEMNT
	{
		private readonly DataSyncTool.DAL.BILLFEEMNT dal=new DataSyncTool.DAL.BILLFEEMNT();
		public BILLFEEMNT()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string FEEID)
		{
			return dal.Exists(FEEID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataSyncTool.Model.BILLFEEMNT model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DataSyncTool.Model.BILLFEEMNT model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string FEEID)
		{
			
			return dal.Delete(FEEID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string FEEIDlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(FEEIDlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DataSyncTool.Model.BILLFEEMNT GetModel(string FEEID)
		{
			
			return dal.GetModel(FEEID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public DataSyncTool.Model.BILLFEEMNT GetModelByCache(string FEEID)
		{
			
			string CacheKey = "BILLFEEMNTModel-" + FEEID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(FEEID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (DataSyncTool.Model.BILLFEEMNT)objModel;
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
		public List<DataSyncTool.Model.BILLFEEMNT> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DataSyncTool.Model.BILLFEEMNT> DataTableToList(DataTable dt)
		{
			List<DataSyncTool.Model.BILLFEEMNT> modelList = new List<DataSyncTool.Model.BILLFEEMNT>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DataSyncTool.Model.BILLFEEMNT model;
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

