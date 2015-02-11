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
namespace Maticsoft.Web.Recive
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
					int ReciveId=(Convert.ToInt32(strid));
					ShowInfo(ReciveId);
				}
			}
		}
		
	private void ShowInfo(int ReciveId)
	{
		Maticsoft.BLL.Recive bll=new Maticsoft.BLL.Recive();
		Maticsoft.Model.Recive model=bll.GetModel(ReciveId);
		this.lblReciveId.Text=model.ReciveId.ToString();
		this.lblCompanyName.Text=model.CompanyName;
		this.lblToName.Text=model.ToName;
		this.lblPhone.Text=model.Phone;
		this.lblAddress.Text=model.Address;
		this.lblFItemId.Text=model.FItemId.ToString();

	}


    }
}
