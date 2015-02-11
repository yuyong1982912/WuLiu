using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// vwICBill
	/// </summary>
	public partial class vwICBill
	{
		private readonly Maticsoft.DAL.vwICBill dal=new Maticsoft.DAL.vwICBill();
		public vwICBill()
		{}
		#region  BasicMethod
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int FInterID,string FNumber,string Fmodel,int FSourceTranType,string FSourceBillNo,decimal Fauxqty,int FEntryID,DateTime Fdate,string FbillNo,string FSupplyID)
		{
			return dal.Exists(FInterID,FNumber,Fmodel,FSourceTranType,FSourceBillNo,Fauxqty,FEntryID,Fdate,FbillNo,FSupplyID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Add(Maticsoft.Model.vwICBill model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Maticsoft.Model.vwICBill model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int FInterID,string FNumber,string Fmodel,int FSourceTranType,string FSourceBillNo,decimal Fauxqty,int FEntryID,DateTime Fdate,string FbillNo,string FSupplyID)
		{
			
			return dal.Delete(FInterID,FNumber,Fmodel,FSourceTranType,FSourceBillNo,Fauxqty,FEntryID,Fdate,FbillNo,FSupplyID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Maticsoft.Model.vwICBill GetModel(int FInterID,string FNumber,string Fmodel,int FSourceTranType,string FSourceBillNo,decimal Fauxqty,int FEntryID,DateTime Fdate,string FbillNo,string FSupplyID)
		{
			
			return dal.GetModel(FInterID,FNumber,Fmodel,FSourceTranType,FSourceBillNo,Fauxqty,FEntryID,Fdate,FbillNo,FSupplyID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public Maticsoft.Model.vwICBill GetModelByCache(int FInterID,string FNumber,string Fmodel,int FSourceTranType,string FSourceBillNo,decimal Fauxqty,int FEntryID,DateTime Fdate,string FbillNo,string FSupplyID)
		{
			
			string CacheKey = "vwICBillModel-" + FInterID+FNumber+Fmodel+FSourceTranType+FSourceBillNo+Fauxqty+FEntryID+Fdate+FbillNo+FSupplyID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(FInterID,FNumber,Fmodel,FSourceTranType,FSourceBillNo,Fauxqty,FEntryID,Fdate,FbillNo,FSupplyID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.vwICBill)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.vwICBill> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Maticsoft.Model.vwICBill> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.vwICBill> modelList = new List<Maticsoft.Model.vwICBill>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.vwICBill model;
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
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
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

