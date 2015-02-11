using System;
using System.Collections.Generic;
namespace Maticsoft.Model
{
	/// <summary>
	/// 实体类KuaiDi 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class KuaiDi
	{
		public KuaiDi()
		{}
		#region Model
		private string _id;
		private string _memo;
		private DateTime _date;
		private decimal? _amount;
		private int? _kuaiditypeid;
		private int? _receiveid;
		private int? _sendid;
		private int? _fitemid;
		private decimal? _fsumsize;
		private decimal? _fsumgrossweight;
		/// <summary>
		/// 
		/// </summary>
		public string Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Date
		{
			set{ _date=value;}
			get{return _date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? KuaidiTypeId
		{
			set{ _kuaiditypeid=value;}
			get{return _kuaiditypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReceiveId
		{
			set{ _receiveid=value;}
			get{return _receiveid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SendId
		{
			set{ _sendid=value;}
			get{return _sendid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FItemId
		{
			set{ _fitemid=value;}
			get{return _fitemid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FSumSize
		{
			set{ _fsumsize=value;}
			get{return _fsumsize;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FSumGrossWeight
		{
			set{ _fsumgrossweight=value;}
			get{return _fsumgrossweight;}
		}
		#endregion Model

		private List<KuaidiDetail> _kuaididetails;
		/// <summary>
		/// 子类 
		/// </summary>
		public List<KuaidiDetail> KuaidiDetails
		{
			set{ _kuaididetails=value;}
			get{return _kuaididetails;}
		}

	}
	/// <summary>
	/// 实体类KuaidiDetail 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class KuaidiDetail
	{
		public KuaidiDetail()
		{}
		#region Model
		private int _id;
		private decimal? _fgrossweight;
		private decimal? _fssize;
		private decimal? _fsgrossweight;
		private string _fmemo;
		private string _fkuaidiid;
		private string _fnumber;
		private string _fmodel;
		private string _finterid;
		private string _forderinterid;
		private string _fcitemid;
		private decimal? _fqty;
		private decimal? _fsize;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FGrossWeight
		{
			set{ _fgrossweight=value;}
			get{return _fgrossweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FSSize
		{
			set{ _fssize=value;}
			get{return _fssize;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FSGrossWeight
		{
			set{ _fsgrossweight=value;}
			get{return _fsgrossweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FMemo
		{
			set{ _fmemo=value;}
			get{return _fmemo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FKuaiDiId
		{
			set{ _fkuaidiid=value;}
			get{return _fkuaidiid;}
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
		public string FModel
		{
			set{ _fmodel=value;}
			get{return _fmodel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FInterID
		{
			set{ _finterid=value;}
			get{return _finterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FOrderInterID
		{
			set{ _forderinterid=value;}
			get{return _forderinterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FCItemID
		{
			set{ _fcitemid=value;}
			get{return _fcitemid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FQty
		{
			set{ _fqty=value;}
			get{return _fqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FSize
		{
			set{ _fsize=value;}
			get{return _fsize;}
		}
		#endregion Model

	}
}

