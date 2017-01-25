using System;
using System.Collections.Generic;
using System.Data;
using DataSyncTool.Common;

namespace DataSyncTool.CP.BLL
{
	/// <summary>
	/// WORD_TEMPLATES
	/// </summary>
	public partial class WORD_TEMPLATES
	{
		private readonly DAL.WORD_TEMPLATES dal=new DAL.WORD_TEMPLATES();
		public WORD_TEMPLATES()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string FILE_NAME)
		{
			return dal.Exists(FILE_NAME);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.WORD_TEMPLATES model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.WORD_TEMPLATES model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string FILE_NAME)
		{
			
			return dal.Delete(FILE_NAME);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string FILE_NAMElist )
		{
			return dal.DeleteList(PageValidate.SafeLongFilter(FILE_NAMElist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.WORD_TEMPLATES GetModel(string FILE_NAME)
		{
			
			return dal.GetModel(FILE_NAME);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.WORD_TEMPLATES GetModelByCache(string FILE_NAME)
		{
			
			string CacheKey = "WORD_TEMPLATESModel-" + FILE_NAME;
			object objModel = DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(FILE_NAME);
					if (objModel != null)
					{
						int ModelCache = ConfigHelper.GetConfigInt("ModelCache");
						DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.WORD_TEMPLATES)objModel;
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
		public List<Model.WORD_TEMPLATES> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.WORD_TEMPLATES> DataTableToList(DataTable dt)
		{
			List<Model.WORD_TEMPLATES> modelList = new List<Model.WORD_TEMPLATES>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.WORD_TEMPLATES model;
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

