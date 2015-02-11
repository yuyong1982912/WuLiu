using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Recive:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Recive
	{
		public Recive()
		{}
		#region Model
		private int _reciveid;
		private string _companyname;
		private string _toname;
		private string _phone;
		private string _address;
		private int _fitemid;
		/// <summary>
		/// 
		/// </summary>
		public int ReciveId
		{
			set{ _reciveid=value;}
			get{return _reciveid;}
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
		/// <summary>
		/// 
		/// </summary>
		public int FItemId
		{
			set{ _fitemid=value;}
			get{return _fitemid;}
		}
		#endregion Model

	}
}

