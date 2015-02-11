using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace Maticsoft.Web.KuaiDi
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					string Id= strid;
					ShowInfo(Id);
				}
			}
		}
		
	private void ShowInfo(string Id)
	{
		Maticsoft.BLL.KuaiDi bll=new Maticsoft.BLL.KuaiDi();
		Maticsoft.Model.KuaiDi model=bll.GetModel(Id);
		this.lblId.Text=model.Id;
		this.lblDate.Text=model.Date.ToString();
		this.lblAmount.Text=model.Amount.ToString();
		this.lblKuaidiTypeId.Text=model.KuaidiTypeId.ToString();
		this.lblMemo.Text=model.Memo;

	}


    }
}
