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
namespace Maticsoft.Web.KuaiDi
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string Id= Request.Params["id"];
					ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(string Id)
	{
		Maticsoft.BLL.KuaiDi bll=new Maticsoft.BLL.KuaiDi();
		Maticsoft.Model.KuaiDi model=bll.GetModel(Id);
		this.lblId.Text=model.Id;
		this.txtDate.Text=model.Date.ToString();
		this.txtAmount.Text=model.Amount.ToString();
		this.txtKuaidiTypeId.Text=model.KuaidiTypeId.ToString();
		this.txtMemo.Text=model.Memo;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtDate.Text))
			{
				strErr+="Date格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtAmount.Text))
			{
				strErr+="Amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtKuaidiTypeId.Text))
			{
				strErr+="KuaidiTypeId格式错误！\\n";	
			}
			if(this.txtMemo.Text.Trim().Length==0)
			{
				strErr+="Memo不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Id=this.lblId.Text;
			DateTime Date=DateTime.Parse(this.txtDate.Text);
			decimal Amount=decimal.Parse(this.txtAmount.Text);
			int KuaidiTypeId=int.Parse(this.txtKuaidiTypeId.Text);
			string Memo=this.txtMemo.Text;


			Maticsoft.Model.KuaiDi model=new Maticsoft.Model.KuaiDi();
			model.Id=Id;
			model.Date=Date;
			model.Amount=Amount;
			model.KuaidiTypeId=KuaidiTypeId;
			model.Memo=Memo;

			Maticsoft.BLL.KuaiDi bll=new Maticsoft.BLL.KuaiDi();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
