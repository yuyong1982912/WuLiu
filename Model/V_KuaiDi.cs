using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// V_KuaiDi:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class V_KuaiDi
	{
		public V_KuaiDi()
		{}
		#region Model
		private int _id;
		private string _fkuaidiid;
		private string _name;
		private string _fnumber;
		private string _fmodel;
		private string _finterid;
		private string _forderinterid;
		private string _fcitemid;
		private decimal? _fqty;
		private decimal? _fsize;
		private decimal? _fgrossweight;
		private decimal? _fssize;
		private decimal? _fsgrossweight;
		private string _fmemo;
		private DateTime _date;
		private string _companyname;
		private string _toname;
		private string _phone;
		private string _address;
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
		public string FKuaiDiId
		{
			set{ _fkuaidiid=value;}
			get{return _fkuaidiid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		public DateTime Date
		{
			set{ _date=value;}
			get{return _date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyName
		{
			set{ _companyname=value;}
			get{return _companyname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ToName
		{
			set{ _toname=value;}
			get{return _toname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		#endregion Model

	}
}

