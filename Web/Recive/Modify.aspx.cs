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
namespace Maticsoft.Web.Recive
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ReciveId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ReciveId);
				}
			}
		}
			
	private void ShowInfo(int ReciveId)
	{
		Maticsoft.BLL.Recive bll=new Maticsoft.BLL.Recive();
		Maticsoft.Model.Recive model=bll.GetModel(ReciveId);
		this.lblReciveId.Text=model.ReciveId.ToString();
		this.txtCompanyName.Text=model.CompanyName;
		this.txtToName.Text=model.ToName;
		this.txtPhone.Text=model.Phone;
		this.txtAddress.Text=model.Address;
		this.lblFItemId.Text=model.FItemId.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCompanyName.Text.Trim().Length==0)
			{
				strErr+="CompanyName不能为空！\\n";	
			}
			if(this.txtToName.Text.Trim().Length==0)
			{
				strErr+="ToName不能为空！\\n";	
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
			int ReciveId=int.Parse(this.lblReciveId.Text);
			string CompanyName=this.txtCompanyName.Text;
			string ToName=this.txtToName.Text;
			string Phone=this.txtPhone.Text;
			string Address=this.txtAddress.Text;
			int FItemId=int.Parse(this.lblFItemId.Text);


			Maticsoft.Model.Recive model=new Maticsoft.Model.Recive();
			model.ReciveId=ReciveId;
			model.CompanyName=CompanyName;
			model.ToName=ToName;
			model.Phone=Phone;
			model.Address=Address;
			model.FItemId=FItemId;

			Maticsoft.BLL.Recive bll=new Maticsoft.BLL.Recive();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
