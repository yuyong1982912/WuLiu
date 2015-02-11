using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Send:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Send
	{
		public Send()
		{}
		#region Model
		private int _sendid;
		private string _companyname;
		private string _fromname;
		private string _phone;
		private string _address;
		/// <summary>
		/// 
		/// </summary>
		public int SendId
		{
			set{ _sendid=value;}
			get{return _sendid;}
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
		public string FromName
		{
			set{ _fromname=value;}
			get{return _fromname;}
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

