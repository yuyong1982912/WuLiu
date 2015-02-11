using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// t_Organization:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_Organization
	{
		public t_Organization()
		{}
		#region Model
		private int _fitemid;
		private string _fname="";
		/// <summary>
		/// 
		/// </summary>
		public int FItemID
		{
			set{ _fitemid=value;}
			get{return _fitemid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FName
		{
			set{ _fname=value;}
			get{return _fname;}
		}
		#endregion Model

	}
}

