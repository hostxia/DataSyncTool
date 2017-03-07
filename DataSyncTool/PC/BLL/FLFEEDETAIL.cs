using System;
using System.Collections.Generic;
using System.Data;
using DataSyncTool.Common;

namespace DataSyncTool.PC.BLL
{
	/// <summary>
	/// FLFEEDETAIL
	/// </summary>
	public partial class FLFEEDETAIL
	{
		private readonly DAL.FLFEEDETAIL dal=new DAL.FLFEEDETAIL();
		public FLFEEDETAIL()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CASENO,string CLIENTNO,string VOUCHERNO,string FEETYPE,decimal AMOUNT,string PAYMETHOD,DateTime PAYDATE)
		{
			return dal.Exists(CASENO,CLIENTNO,VOUCHERNO,FEETYPE,AMOUNT,PAYMETHOD,PAYDATE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.FLFEEDETAIL model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.FLFEEDETAIL model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string CASENO,string CLIENTNO,string VOUCHERNO,string FEETYPE,decimal AMOUNT,string PAYMETHOD,DateTime PAYDATE)
		{
			
			return dal.Delete(CASENO,CLIENTNO,VOUCHERNO,FEETYPE,AMOUNT,PAYMETHOD,PAYDATE);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.FLFEEDETAIL GetModel(string CASENO,string CLIENTNO,string VOUCHERNO,string FEETYPE,decimal AMOUNT,string PAYMETHOD,DateTime PAYDATE)
		{
			
			return dal.GetModel(CASENO,CLIENTNO,VOUCHERNO,FEETYPE,AMOUNT,PAYMETHOD,PAYDATE);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.FLFEEDETAIL GetModelByCache(string CASENO,string CLIENTNO,string VOUCHERNO,string FEETYPE,decimal AMOUNT,string PAYMETHOD,DateTime PAYDATE)
		{
			
			string CacheKey = "FLFEEDETAILModel-" + CASENO+CLIENTNO+VOUCHERNO+FEETYPE+AMOUNT+PAYMETHOD+PAYDATE;
			object objModel = DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(CASENO,CLIENTNO,VOUCHERNO,FEETYPE,AMOUNT,PAYMETHOD,PAYDATE);
					if (objModel != null)
					{
						int ModelCache = ConfigHelper.GetConfigInt("ModelCache");
						DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.FLFEEDETAIL)objModel;
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
		public List<Model.FLFEEDETAIL> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.FLFEEDETAIL> DataTableToList(DataTable dt)
		{
			List<Model.FLFEEDETAIL> modelList = new List<Model.FLFEEDETAIL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.FLFEEDETAIL model;
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

