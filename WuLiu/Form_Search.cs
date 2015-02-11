using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace WuLiu
{
	/// <summary>
	/// Description of Form_Search.
	/// </summary>
	public partial class Form_Search : Form
	{
		public Form_Search()
		{
			
			InitializeComponent();
			
		}
		
		private string sDelF;//待删除快递单号
		Maticsoft.BLL.KuaidiDetail BKuaidiDetail=new Maticsoft.BLL.KuaidiDetail();
		Maticsoft.BLL.V_KuaiDi BV_KuaiDi=new Maticsoft.BLL.V_KuaiDi();
		
		void Form_SearchLoad(object sender, EventArgs e)
		{			
			DataSet ds=BV_KuaiDi.GetAllList();
			dataGridView_Search.DataSource=ds.Tables[0];
			DgvFilterPopup.DgvFilterManager filterManager=new DgvFilterPopup.DgvFilterManager(dataGridView_Search);			
		}
		
		void DataGridView_SearchCellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button==MouseButtons.Right) {
				if (e.RowIndex>=0) {//选中行
					if (dataGridView_Search.Rows[e.RowIndex].Selected==false) {
						dataGridView_Search.ClearSelection();
						dataGridView_Search.Rows[e.RowIndex].Selected=true;
					}
					if (dataGridView_Search.SelectedRows.Count==1) {
						dataGridView_Search.CurrentCell=dataGridView_Search.Rows[e.RowIndex].Cells[1];
						sDelF=dataGridView_Search.CurrentCell.Value.ToString().Trim();
					}
					//弹出右键菜单
					contextMenuStrip_Del.Show(MousePosition.X,MousePosition.Y);
				}
			}
		}
		
		void 删除ToolStripMenuItemClick(object sender, EventArgs e)
		{
			DialogResult result=MessageBox.Show("是否确定删除？","删除",MessageBoxButtons.OKCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
			switch(result)
			{
				case DialogResult.OK:
					Maticsoft.BLL.KuaiDi BKuaidi=new Maticsoft.BLL.KuaiDi();
					bool b=BKuaidi.Delete(sDelF);
					if (b) {
						MessageBox.Show("删除成功","成功");
						DataSet ds=BKuaidiDetail.GetAllList();
						dataGridView_Search.DataSource=ds.Tables[0];
					} else {MessageBox.Show("删除失败","失败");};
					break;
				case DialogResult.Cancel:
					MessageBox.Show("你取消了删除");
					break;
			}
		}
	}
}
