using System;
using System.Drawing;
using System.Windows.Forms;
using Maticsoft.BLL;
using Maticsoft.Common;
using Maticsoft.Model;
using System.Data;

namespace WuLiu
{
	/// <summary>
	/// Description of Form_Send.
	/// </summary>
	public partial class Form_Send : Form
	{
		Maticsoft.Model.Send Msend=new Maticsoft.Model.Send();
		Maticsoft.BLL.Send Bsend=new Maticsoft.BLL.Send();
		
		public Form_Send()
		{			
			InitializeComponent();			
		}
		
		void Button_InsClick(object sender, EventArgs e)
		{
			if ((!Blank.IsBlank(textBox_CompanyName.Text.Trim())) && 
				(!Blank.IsBlank(textBox_FromName.Text.Trim())) &&
				(!Blank.IsBlank(textBox_Phone.Text.Trim())) &&
				(!Blank.IsBlank(textBox_Address.Text.Trim())))
			{
				Msend.CompanyName=textBox_CompanyName.Text.Trim();
				Msend.FromName=textBox_FromName.Text.Trim();
				Msend.Phone=textBox_Phone.Text.Trim();
				Msend.Address=textBox_Address.Text.Trim();
				int i=Bsend.Add(Msend);
				if (i>0) {
					MessageBox.Show("插入数据成功!","成功");
				}
			} else {
				MessageBox.Show("所有项目都不能为空","错误");
			}
		}
		
		void TabPage_ModEnter(object sender, EventArgs e)
		{
			DataSet ds=Bsend.GetAllList();
			dataGridView_Send.DataSource=ds.Tables[0];
		}
		
		void DataGridView_SendCellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rows=e.RowIndex;//选中行的行号
			textBox_Company_Mod.Text=dataGridView_Send.Rows[rows].Cells["CompanyName"].Value.ToString();
			textBox_FromName_Mod.Text=dataGridView_Send.Rows[rows].Cells["FromName"].Value.ToString();
			textBox_Phone_Mod.Text=dataGridView_Send.Rows[rows].Cells["Phone"].Value.ToString();
			textBox_Address_Mod.Text=dataGridView_Send.Rows[rows].Cells["Address"].Value.ToString();
			textBox_SendId.Text=dataGridView_Send.Rows[rows].Cells["SendId"].Value.ToString();
		}
		
		void Button_ModClick(object sender, EventArgs e)
		{
			if (!Blank.IsBlank(textBox_SendId.Text)) {
				Msend.CompanyName=textBox_Company_Mod.Text.Trim();
				Msend.FromName=textBox_FromName_Mod.Text.Trim();
				Msend.Phone=textBox_Phone_Mod.Text.Trim();
				Msend.Address=textBox_Address_Mod.Text.Trim();
				Msend.SendId=Convert.ToInt32(textBox_SendId.Text.Trim());
				
				bool b=Bsend.Update(Msend);
				if (b) {
					MessageBox.Show("更新成功！","成功");
				}
				
			}				
		}
	}
}
