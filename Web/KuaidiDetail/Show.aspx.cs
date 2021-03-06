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
namespace Maticsoft.Web.KuaidiDetail
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
					int Id=(Convert.ToInt32(strid));
					ShowInfo(Id);
				}
			}
		}
		
	private void ShowInfo(int Id)
	{
		Maticsoft.BLL.KuaidiDetail bll=new Maticsoft.BLL.KuaidiDetail();
		Maticsoft.Model.KuaidiDetail model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblFKuaiDiId.Text=model.FKuaiDiId;
		this.lblFItemID.Text=model.FItemID.ToString();
		this.lblFInterID.Text=model.FInterID.ToString();
		this.lblFOrderInterID.Text=model.FOrderInterID.ToString();
		this.lblFCItemID.Text=model.FCItemID.ToString();
		this.lblFQty.Text=model.FQty.ToString();
		this.lblFSize.Text=model.FSize.ToString();
		this.lblFGrossWeight.Text=model.FGrossWeight.ToString();
		this.lblFSSize.Text=model.FSSize.ToString();
		this.lblFSGrossWeight.Text=model.FSGrossWeight.ToString();
		this.lblFMemo.Text=model.FMemo;

	}


    }
}
