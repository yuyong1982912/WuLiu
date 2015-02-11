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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			if(!PageValidate.IsNumber(txtFItemId.Text))
			{
				strErr+="FItemId格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CompanyName=this.txtCompanyName.Text;
			string ToName=this.txtToName.Text;
			string Phone=this.txtPhone.Text;
			string Address=this.txtAddress.Text;
			int FItemId=int.Parse(this.txtFItemId.Text);

			Maticsoft.Model.Recive model=new Maticsoft.Model.Recive();
			model.CompanyName=CompanyName;
			model.ToName=ToName;
			model.Phone=Phone;
			model.Address=Address;
			model.FItemId=FItemId;

			Maticsoft.BLL.Recive bll=new Maticsoft.BLL.Recive();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
