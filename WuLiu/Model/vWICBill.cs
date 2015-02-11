using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// vwICBill:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class vwICBill
	{
		public vwICBill()
		{}
		#region Model
		private int _finterid;
		private int? _fentryid;
		private DateTime? _fdate;
		private string _fbillno;
		private string _fsupplyid;
		private string _fnumber;
		private string _fmodel;
		private int? _fsourcetrantype;
		private string _fsourcebillno;
		private decimal? _fauxqty;
		/// <summary>
		/// 
		/// </summary>
		public int FInterID
		{
			set{ _finterid=value;}
			get{return _finterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FEntryID
		{
			set{ _fentryid=value;}
			get{return _fentryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Fdate
		{
			set{ _fdate=value;}
			get{return _fdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FbillNo
		{
			set{ _fbillno=value;}
			get{return _fbillno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FSupplyID
		{
			set{ _fsupplyid=value;}
			get{return _fsupplyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FNumber
		{
			set{ _fnumber=value;}
			get{return _fnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Fmodel
		{
			set{ _fmodel=value;}
			get{return _fmodel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FSourceTranType
		{
			set{ _fsourcetrantype=value;}
			get{return _fsourcetrantype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FSourceBillNo
		{
			set{ _fsourcebillno=value;}
			get{return _fsourcebillno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Fauxqty
		{
			set{ _fauxqty=value;}
			get{return _fauxqty;}
		}
		#endregion Model

	}
}

