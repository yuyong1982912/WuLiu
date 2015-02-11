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
namespace Maticsoft.Web.Send
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
					int SendId=(Convert.ToInt32(strid));
					ShowInfo(SendId);
				}
			}
		}
		
	private void ShowInfo(int SendId)
	{
		Maticsoft.BLL.Send bll=new Maticsoft.BLL.Send();
		Maticsoft.Model.Send model=bll.GetModel(SendId);
		this.lblSendId.Text=model.SendId.ToString();
		this.lblCompanyName.Text=model.CompanyName;
		this.lblFromName.Text=model.FromName;
		this.lblPhone.Text=model.Phone;
		this.lblAddress.Text=model.Address;

	}


    }
}
