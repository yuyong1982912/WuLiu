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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.Send
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int SendId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(SendId);
				}
			}
		}
			
	private void ShowInfo(int SendId)
	{
		Maticsoft.BLL.Send bll=new Maticsoft.BLL.Send();
		Maticsoft.Model.Send model=bll.GetModel(SendId);
		this.lblSendId.Text=model.SendId.ToString();
		this.txtCompanyName.Text=model.CompanyName;
		this.txtFromName.Text=model.FromName;
		this.txtPhone.Text=model.Phone;
		this.txtAddress.Text=model.Address;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCompanyName.Text.Trim().Length==0)
			{
				strErr+="CompanyName不能为空！\\n";	
			}
			if(this.txtFromName.Text.Trim().Length==0)
			{
				strErr+="FromName不能为空！\\n";	
			}
			if(this.txtPhone.Text.Trim().Length==0)
			{
				strErr+="Phone不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="Address不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int SendId=int.Parse(this.lblSendId.Text);
			string CompanyName=this.txtCompanyName.Text;
			string FromName=this.txtFromName.Text;
			string Phone=this.txtPhone.Text;
			string Address=this.txtAddress.Text;


			Maticsoft.Model.Send model=new Maticsoft.Model.Send();
			model.SendId=SendId;
			model.CompanyName=CompanyName;
			model.FromName=FromName;
			model.Phone=Phone;
			model.Address=Address;

			Maticsoft.BLL.Send bll=new Maticsoft.BLL.Send();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
