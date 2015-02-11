using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Maticsoft.BLL;
using Maticsoft.Common;
using Maticsoft.Model;

namespace WuLiu
{
	/// <summary>
	/// Description of Form_Receive.
	/// </summary>
	
	public partial class Form_Receive : Form
	{
		public Form_Receive()
		{			
			InitializeComponent();	
		}
		
		Maticsoft.BLL.t_Organization Bt_Organization=new Maticsoft.BLL.t_Organization();
		Maticsoft.BLL.Recive bRecive=new Maticsoft.BLL.Recive();
		Maticsoft.Model.Recive MRecive=new Maticsoft.Model.Recive();
		
		void Button_SearchClick(object sender, EventArgs e)
		{
			if (!Maticsoft.Common.Blank.IsBlank(textBox_FName.Text)) {
				DataSet ds=Bt_Organization.GetList("FName like '%"+textBox_FName.Text.Trim()+"%'");
				listBox_FName.DataSource=ds.Tables[0];
				listBox_FName.DisplayMember="FName";
				listBox_FName.ValueMember="FItemID";
				textBox_FItemId.Text="0";
			    } else {
			    	MessageBox.Show("客户名称不能为空!","错误");
			    	textBox_FName.Focus();
			    }
		}
		
		void Button_InsClick(object sender, EventArgs e)
		{
			if (textBox_FItemId.Text=="0") {
				MessageBox.Show("请先点击列表框中的某一客户","错误");
			}	else {
				if ((!Blank.IsBlank(textBox_CompanyName.Text.Trim())) &&
				     (!Blank.IsBlank(textBox_ToName.Text.Trim())) &&
				      (!Blank.IsBlank(textBox_Phone.Text.Trim())) &&
				       (!Blank.IsBlank(textBox_Address.Text.Trim())))
				{
					MRecive.CompanyName=textBox_CompanyName.Text.Trim();
					MRecive.ToName=textBox_ToName.Text.Trim();
					MRecive.Phone=textBox_Phone.Text.Trim();
					MRecive.Address=textBox_Address.Text.Trim();
					MRecive.FItemId=Convert.ToInt32(textBox_FItemId.Text.Trim());
					
					int i = bRecive.Add(MRecive);
					if (i>0) {
						MessageBox.Show("插入成功","成功");
					}
					
		       } else {
		       	MessageBox.Show("所有文本框不能为空","错误");
		       }
				
			}
		}
		
		void ListBox_FNameSelectedIndexChanged(object sender, EventArgs e)
		{
			textBox_FItemId.Text=listBox_FName.SelectedValue.ToString();
		}
		
		void Button_Search_ModClick(object sender, EventArgs e)
		{
			if (!Maticsoft.Common.Blank.IsBlank(textBox_FName_Mod.Text)) {
				DataSet ds=Bt_Organization.GetList("FName like '%"+textBox_FName_Mod.Text.Trim()+"%'");
				listBox_Mod.DataSource=ds.Tables[0];
				listBox_Mod.DisplayMember="FName";
				listBox_Mod.ValueMember="FItemID";
				dataGridView_Mod.DataSource=null;				
			    } else {
			    	MessageBox.Show("客户名称不能为空!","错误");
			    	textBox_FName_Mod.Focus();
			    }
		}		
		
		
		void ListBox_ModClick(object sender, EventArgs e)
		{
			DataSet ds=bRecive.GetList("FItemId="+listBox_Mod.SelectedValue.ToString());
			dataGridView_Mod.DataSource=ds.Tables[0];
		}
		
		void DataGridView_ModCellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rows=e.RowIndex;
			textBox_ReceiveId.Text=dataGridView_Mod.Rows[rows].Cells["ReciveId"].Value.ToString();
			textBox_CompanyName_Mod.Text=dataGridView_Mod.Rows[rows].Cells["CompanyName"].Value.ToString();
			textBox_ToName_Mod.Text=dataGridView_Mod.Rows[rows].Cells["ToName"].Value.ToString();
			textBox_Phone_Mod.Text=dataGridView_Mod.Rows[rows].Cells["Phone"].Value.ToString();
			textBox_Address_Mod.Text=dataGridView_Mod.Rows[rows].Cells["Address"].Value.ToString();
			textBox_FItemId_Mod.Text=dataGridView_Mod.Rows[rows].Cells["FItemId"].Value.ToString();
			
		}
		
		void Button_ModClick(object sender, EventArgs e)
		{
			if ((!Blank.IsBlank(textBox_FItemId_Mod.Text.Trim())) && 
			(!Blank.IsBlank(textBox_ReceiveId.Text.Trim())) && 
			(!Blank.IsBlank(textBox_CompanyName_Mod.Text.Trim())) &&
			(!Blank.IsBlank(textBox_Phone_Mod.Text.Trim())) &&
			(!Blank.IsBlank(textBox_Address_Mod.Text.Trim())) &&
				(!Blank.IsBlank(textBox_ToName_Mod.Text.Trim()))){
				
				MRecive.ReciveId=Convert.ToInt32(textBox_ReceiveId.Text.ToString().Trim());
				MRecive.FItemId=Convert.ToInt32(textBox_FItemId_Mod.Text.ToString().Trim());
				MRecive.CompanyName=textBox_CompanyName_Mod.Text.ToString().Trim();
				MRecive.ToName=textBox_ToName_Mod.Text.ToString().Trim();
				MRecive.Phone=textBox_Phone_Mod.Text.ToString().Trim();
				MRecive.Address=textBox_Address_Mod.Text.ToString().Trim();
				
				bool b=bRecive.Update(MRecive);
				if (b) {
					MessageBox.Show("修改成功","成功");
					textBox_ReceiveId.Text="";
					textBox_FItemId_Mod.Text="";
					textBox_CompanyName_Mod.Text="";
					textBox_ToName_Mod.Text="";
					textBox_Phone_Mod.Text="";
					textBox_Address_Mod.Text="";
				}
				
			}		else {
				MessageBox.Show("所有文本框不能为空","错误");
			}
		}
	}
}
