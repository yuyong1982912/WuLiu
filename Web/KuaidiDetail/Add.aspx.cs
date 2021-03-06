﻿using System;
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
namespace Maticsoft.Web.KuaidiDetail
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtFKuaiDiId.Text.Trim().Length==0)
			{
				strErr+="FKuaiDiId不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFItemID.Text))
			{
				strErr+="FItemID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFInterID.Text))
			{
				strErr+="FInterID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFOrderInterID.Text))
			{
				strErr+="FOrderInterID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFCItemID.Text))
			{
				strErr+="FCItemID格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFQty.Text))
			{
				strErr+="FQty格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFSize.Text))
			{
				strErr+="FSize格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFGrossWeight.Text))
			{
				strErr+="FGrossWeight格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFSSize.Text))
			{
				strErr+="FSSize格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFSGrossWeight.Text))
			{
				strErr+="FSGrossWeight格式错误！\\n";	
			}
			if(this.txtFMemo.Text.Trim().Length==0)
			{
				strErr+="FMemo不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string FKuaiDiId=this.txtFKuaiDiId.Text;
			int FItemID=int.Parse(this.txtFItemID.Text);
			int FInterID=int.Parse(this.txtFInterID.Text);
			int FOrderInterID=int.Parse(this.txtFOrderInterID.Text);
			int FCItemID=int.Parse(this.txtFCItemID.Text);
			decimal FQty=decimal.Parse(this.txtFQty.Text);
			decimal FSize=decimal.Parse(this.txtFSize.Text);
			decimal FGrossWeight=decimal.Parse(this.txtFGrossWeight.Text);
			decimal FSSize=decimal.Parse(this.txtFSSize.Text);
			decimal FSGrossWeight=decimal.Parse(this.txtFSGrossWeight.Text);
			string FMemo=this.txtFMemo.Text;

			Maticsoft.Model.KuaidiDetail model=new Maticsoft.Model.KuaidiDetail();
			model.FKuaiDiId=FKuaiDiId;
			model.FItemID=FItemID;
			model.FInterID=FInterID;
			model.FOrderInterID=FOrderInterID;
			model.FCItemID=FCItemID;
			model.FQty=FQty;
			model.FSize=FSize;
			model.FGrossWeight=FGrossWeight;
			model.FSSize=FSSize;
			model.FSGrossWeight=FSGrossWeight;
			model.FMemo=FMemo;

			Maticsoft.BLL.KuaidiDetail bll=new Maticsoft.BLL.KuaidiDetail();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
