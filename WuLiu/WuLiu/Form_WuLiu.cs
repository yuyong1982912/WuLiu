using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Maticsoft.BLL;
using Maticsoft.Common;
using Maticsoft.Model;
using MultiColumnComboBoxDemo;

namespace WuLiu
{
	/// <summary>
	/// Description of Form_WuLiu.
	/// </summary>
	public partial class Form_WuLiu : Form
	{
		public Form_WuLiu()
		{			
			InitializeComponent();			
		}
		
		//按F3弹出查找对话框
		private void multiColumnComboBox_OpenSearchForm(object sender, EventArgs e)
	        {
	            FormSearch newForm = new FormSearch((MultiColumnComboBoxDemo.MultiColumnComboBox)sender);
	            newForm.ShowDialog();      
	        }		
		
		Maticsoft.BLL.t_Organization Bt_Organization=new Maticsoft.BLL.t_Organization();
		Maticsoft.BLL.KuaidiType BkuaidiType=new Maticsoft.BLL.KuaidiType();
		Maticsoft.BLL.Recive Brecive=new Maticsoft.BLL.Recive();
		Maticsoft.BLL.Send BSend=new Maticsoft.BLL.Send();	
		Maticsoft.BLL.vwICBill bvwICBill =new Maticsoft.BLL.vwICBill();
		
		void TabPage_InsEnter(object sender, EventArgs e)
		{
			//将数量列的背景设为黄色
			dataGridView_KuaidiDetail.Columns[4].DefaultCellStyle.BackColor=Color.Yellow;
			//客户信息
			DataSet ds=Bt_Organization.GetAllList();			
			mCCB_FItemId.DataSource = ds.Tables[0];
            		mCCB_FItemId.DisplayMember = "FName";
	              mCCB_FItemId.ValueMember = "FItemId";
	              mCCB_FItemId.SelectedIndex = -1;
	              mCCB_FItemId.Text = "";
	              
			//快递单类型
			DataSet ds_KudiType=BkuaidiType.GetAllList();			
			mCCB_KuaidiTypeId.DataSource=ds_KudiType.Tables[0];
			mCCB_KuaidiTypeId.DisplayMember = "Name";
	              mCCB_KuaidiTypeId.ValueMember = "Id";
	              mCCB_KuaidiTypeId.SelectedIndex = -1;
	              mCCB_KuaidiTypeId.Text = "";
			
			//发件人信息
			DataSet ds_Send=BSend.GetAllList();			
			mCCB_SendId.DataSource=ds_Send.Tables[0];
			mCCB_SendId.DisplayMember = "FromName";
	              mCCB_SendId.ValueMember = "SendId";
	              mCCB_SendId.SelectedIndex = -1;
	              mCCB_SendId.Text = "";
		}		
		
		void MCCB_FItemIdSelectedIndexChanged(object sender, EventArgs e)
		{			
			if (mCCB_FItemId.SelectedIndex>0) {
				//根据客户信息查找该客户下的所有联系人
				string sFItemId=mCCB_FItemId.SelectedValue.ToString();
				DataSet ds_Recive=Brecive.GetList("FItemId = '" + sFItemId +"'");
				mCCB_ReceiveId .DataSource = ds_Recive.Tables[0];
	            		mCCB_ReceiveId.DisplayMember = "ToName";
		              mCCB_ReceiveId.ValueMember = "ReciveId";
		              mCCB_ReceiveId.SelectedIndex = -1;
		              mCCB_ReceiveId.Text = "";
		              
		              //根据客户信息查找该客户的当月的已审核的所有蓝字销售出库单
		              string sFName=mCCB_FItemId.Text.ToString();
		              DataSet ds_vwICBill=bvwICBill.GetList("DATEDIFF(MONTH, [Fdate], GETDATE())=0 AND FSourceTranType=83 AND FCheckFlag != '' AND FSupplyID ='"+sFName+"'");
		              mCCB_FbillNo.DataSource=ds_vwICBill.Tables[0];
		              mCCB_FbillNo.DisplayMember = "FbillNo";
		              mCCB_FbillNo.ValueMember = "FbillNo";
		              mCCB_FbillNo.SelectedIndex = -1;
		              mCCB_FbillNo.Text = "";		              
			}
		}
		
		void MCCB_FbillNoSelectionChangeCommitted(object sender, EventArgs e)
		{
			if (mCCB_FbillNo.SelectedIndex>=0) {				
				DataRowView drv=(DataRowView)mCCB_FbillNo.SelectedItem;
				Decimal DFQty=Convert.ToDecimal(drv.Row.ItemArray[9]);
				Decimal DFSize=Convert.ToDecimal(drv.Row.ItemArray[10]);
				Decimal DFGrossWeight=Convert.ToDecimal(drv.Row.ItemArray[11]);
				string FQty=DFQty.ToString("N");
				string FSize=DFSize.ToString("N");
				string FGrossWeight=DFGrossWeight.ToString("N");
			    string[] sResult={drv.Row.ItemArray[5].ToString(),drv.Row.ItemArray[6].ToString(),drv.Row.ItemArray[3].ToString(),
				drv.Row.ItemArray[8].ToString(),FQty,FSize,FGrossWeight};
			    dataGridView_KuaidiDetail.Rows.Add(sResult);			    
			}
		}
		
		void DataGridView_KuaidiDetailCellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex==4)
            {
                decimal iFQty=0;
                bool isFQty = decimal.TryParse(this.dataGridView_KuaidiDetail.CurrentRow.Cells[4].EditedFormattedValue.ToString(), out iFQty);

                decimal iFSize = 0;
                bool isFsize =decimal.TryParse(this.dataGridView_KuaidiDetail.CurrentRow.Cells[5].EditedFormattedValue.ToString(),out iFSize);
                
                decimal iFGrossWeight=0;
                bool isFGrossWeight =decimal.TryParse(this.dataGridView_KuaidiDetail.CurrentRow.Cells[6].EditedFormattedValue.ToString(),out iFGrossWeight);                
                //计算该行的总体积
                decimal iFSSize= iFQty * iFSize;
                this.dataGridView_KuaidiDetail.CurrentRow.Cells[7].Value = iFSSize.ToString();
                //计算该行的总毛重
                decimal iFSGrossWeight= iFQty * iFGrossWeight;
                this.dataGridView_KuaidiDetail.CurrentRow.Cells[8].Value = iFSGrossWeight.ToString();
                
                //计算该快递单的总体积
                decimal DFsize=0;
			    for (int i = 0; i < dataGridView_KuaidiDetail.Rows.Count; ++i)
			    {
			        decimal dec = 0;
			        decimal.TryParse(this.dataGridView_KuaidiDetail[7, i].FormattedValue.ToString(), out dec);
			        DFsize += dec;			        
			    }
			    DFsize = Math.Round(DFsize);
			    textBox_FSSize.Text = DFsize.ToString("0.00");
			    
			    //计算该快递单的总毛重
                decimal DFGrossWeight=0;
			    for (int i = 0; i < dataGridView_KuaidiDetail.Rows.Count; ++i)
			    {
			        decimal dec = 0;
			        decimal.TryParse(this.dataGridView_KuaidiDetail[8, i].FormattedValue.ToString(), out dec);
			        DFGrossWeight += dec;			        
			    }
			    DFGrossWeight = Math.Round(DFGrossWeight);
			    textBox_FSGrossWeight.Text = DFGrossWeight.ToString("0.00");
			 }
		}
		
		void Button_InsClick(object sender, EventArgs e)
		{
			//常规检查是否为空
			bool isBlank=false;//行总体积标志，是否为空
			if (dataGridView_KuaidiDetail.Rows.Count > 1) {//有数据行
				for (int i = 0; i < dataGridView_KuaidiDetail.Rows.Count-1; i++) {
					if (Blank.IsBlank(dataGridView_KuaidiDetail[7, i].FormattedValue.ToString())) {
						isBlank=true;//如果行总体积为空，则isBlank标志为真
					}
				}
				if (isBlank!=false) {
					MessageBox.Show("总体积不能为空","错误");
				} else {
					
				}
			} else {
				MessageBox.Show("快递单明细为空","错误");
			}		
			
			
		}
	}
}
