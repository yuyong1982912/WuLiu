using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// t_Organization:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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

