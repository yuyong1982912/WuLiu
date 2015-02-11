using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// KuaidiDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class KuaidiDetail
	{
		public KuaidiDetail()
		{}
		#region Model
		private int _id;
		private string _fkuaidiid;
		private int? _fitemid;
		private int? _finterid;
		private int? _forderinterid;
		private int? _fcitemid;
		private decimal? _fqty;
		private decimal? _fsize;
		private decimal? _fgrossweight;
		private decimal? _fssize;
		private decimal? _fsgrossweight;
		private string _fmemo;
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
		public int? FItemID
		{
			set{ _fitemid=value;}
			get{return _fitemid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FInterID
		{
			set{ _finterid=value;}
			get{return _finterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FOrderInterID
		{
			set{ _forderinterid=value;}
			get{return _forderinterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FCItemID
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
		#endregion Model

	}
}

