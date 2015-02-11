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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtId.Text.Trim().Length==0)
			{
				strErr+="Id不能为空！\\n";	
			}
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
			string Id=this.txtId.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
