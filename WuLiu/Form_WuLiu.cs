using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;//要支持List<T>的用法要引用此类
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
		Maticsoft.BLL.KuaiDi BKuaiDi=new Maticsoft.BLL.KuaiDi();
		//Maticsoft.Model.KuaidiDetail MKuaidiDetail=new Maticsoft.Model.KuaidiDetail();
		Maticsoft.Model.KuaiDi MkuaiDi=new Maticsoft.Model.KuaiDi();
		
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
                      DataSet ds_vwICBill = bvwICBill.GetList("FSourceTranType=83 AND (a.Fauxqty - ISNULL(c.FQty,0)) > 0 AND Fdate >= '2014-01-01' AND FCheckFlag != '' AND FSupplyID ='" + sFName + "' ORDER BY Fdate DESC");
		              mCCB_FbillNo.DataSource=ds_vwICBill.Tables[0];
		              mCCB_FbillNo.DisplayMember = "FbillNo";
		              mCCB_FbillNo.ValueMember = "FbillNo";
		              mCCB_FbillNo.SelectedIndex = -1;
		              mCCB_FbillNo.Text = "";		              
			}
		}
		
		//将下拉框中的数据带到表格中
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
				string RowSumSize= (DFQty * DFSize).ToString("N");
                string RowSumGrossWeight = (DFQty * DFGrossWeight).ToString("N");
                Decimal SumSize = 0;
                Decimal SumGrossWeight = 0;

			    string[] sResult={drv.Row.ItemArray[5].ToString(),drv.Row.ItemArray[6].ToString(),drv.Row.ItemArray[3].ToString(),
				drv.Row.ItemArray[8].ToString(),FQty,FSize,FGrossWeight,RowSumSize,RowSumGrossWeight,drv.Row.ItemArray[4].ToString()};
			    dataGridView_KuaidiDetail.Rows.Add(sResult);

                foreach (DataGridViewRow row in dataGridView_KuaidiDetail.Rows)
                {
                    SumSize = SumSize + Convert.ToDecimal(row.Cells[7].Value);
                    SumGrossWeight = SumGrossWeight + Convert.ToDecimal(row.Cells[8].Value);
                }

                textBox_FSSize.Text = SumSize.ToString();
                textBox_FSGrossWeight.Text = SumGrossWeight.ToString();
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
					//判断文本框是否为空
					if ((!Blank.IsBlank(textBox_Id.Text)) &&
					    (!Blank.IsBlank(mCCB_KuaidiTypeId.Text)) &&
					    (!Blank.IsBlank(mCCB_ReceiveId.Text)) &&
					    (!Blank.IsBlank(mCCB_SendId.Text)) &&
					    (!Blank.IsBlank(mCCB_FItemId.Text)))
					{//准备数据写入数据库,子表
						List<Maticsoft.Model.KuaidiDetail> lKuaidiDetail=new List<Maticsoft.Model.KuaidiDetail>();
						for (int i = 0; i < dataGridView_KuaidiDetail.Rows.Count-1; i++) {
							Maticsoft.Model.KuaidiDetail MKuaidiDetail=new Maticsoft.Model.KuaidiDetail();
							MKuaidiDetail.FKuaiDiId=textBox_Id.Text.Trim();
							MKuaidiDetail.FNumber=dataGridView_KuaidiDetail[0,i].FormattedValue.ToString();
							MKuaidiDetail.FModel=dataGridView_KuaidiDetail[1,i].FormattedValue.ToString();
							MKuaidiDetail.FInterID=dataGridView_KuaidiDetail[2,i].FormattedValue.ToString();
							MKuaidiDetail.FOrderInterID=dataGridView_KuaidiDetail[3,i].FormattedValue.ToString();
							MKuaidiDetail.FCItemID=dataGridView_KuaidiDetail[9,i].FormattedValue.ToString();
							decimal dFQty = 0;
			        		decimal.TryParse(this.dataGridView_KuaidiDetail[4, i].FormattedValue.ToString(), out dFQty);
							MKuaidiDetail.FQty=dFQty;
							decimal dFSize = 0;
			        		decimal.TryParse(this.dataGridView_KuaidiDetail[5, i].FormattedValue.ToString(), out dFSize);
							MKuaidiDetail.FSize=dFSize;
							decimal dFGrossWeight = 0;
			        		decimal.TryParse(this.dataGridView_KuaidiDetail[6, i].FormattedValue.ToString(), out dFGrossWeight);
							MKuaidiDetail.FGrossWeight=dFGrossWeight;
							decimal dFSSize = 0;
			        		decimal.TryParse(this.dataGridView_KuaidiDetail[7, i].FormattedValue.ToString(), out dFSSize);
							MKuaidiDetail.FSSize =dFSSize;
							decimal dFSGrossWeight = 0;
			        		decimal.TryParse(this.dataGridView_KuaidiDetail[8, i].FormattedValue.ToString(), out dFSGrossWeight);
							MKuaidiDetail.FSGrossWeight =dFSGrossWeight;
							MKuaidiDetail.FMemo=dataGridView_KuaidiDetail[10,i].FormattedValue.ToString();		
							
							lKuaidiDetail.Add(MKuaidiDetail);//将一项子表加入到父表中
						}
						//准备数据，父表
						MkuaiDi.Date=System.DateTime.Now;
						if (!Blank.IsBlank(textBox_Amount.Text)) {
						MkuaiDi.Amount=Convert.ToDecimal(textBox_Amount.Text.Trim());	
						} else { MkuaiDi.Amount=0;}
						
						MkuaiDi.KuaidiTypeId=(int)mCCB_KuaidiTypeId.SelectedValue;
						MkuaiDi.ReceiveId=(int)mCCB_ReceiveId.SelectedValue;
						MkuaiDi.SendId=(int)mCCB_SendId.SelectedValue;
						MkuaiDi.FItemId=(int)mCCB_FItemId.SelectedValue;
						MkuaiDi.FSumSize=Convert.ToDecimal(textBox_FSSize.Text.Trim());
						MkuaiDi.FSumGrossWeight=Convert.ToDecimal(textBox_FSGrossWeight.Text.Trim());
						MkuaiDi.Memo=textBox_Memo.Text;
						MkuaiDi.Id=textBox_Id.Text.Trim();
						
						MkuaiDi.KuaidiDetails=lKuaidiDetail;
						
						//真正的写入数据库
						if (BKuaiDi.Exists(textBox_Id.Text.Trim())) {
							MessageBox.Show("系统中已存在此快递单号","失败");
						} else { 
							BKuaiDi.Add(MkuaiDi);
						if (BKuaiDi.Exists(textBox_Id.Text.Trim())) {
							MessageBox.Show("插入数据库成功","成功");
						} else {MessageBox.Show("插入数据库失败","失败");}
						}
					}
					else{
						MessageBox.Show("带星号的项目不能为空","错误");
					}
				}
			} else {
				MessageBox.Show("快递单明细为空","错误");
			}		
			
			
		}
		
		//获取打印数据
		void Button_PrintClick(object sender, EventArgs e)
		{	
			if (Blank.IsBlank(textBox_Id.Text.Trim())) {
			    	MessageBox.Show("快递单号为空","错误");
			    	return;
			}					
			DataSet dsPrint_Send=BSend.GetList("SendId= (select SendId from Kuaidi where Id='"+ textBox_Id.Text.Trim()+"')");
			DataSet dsPrint_Receive=Brecive.GetList("ReciveId= (select ReceiveId from Kuaidi where Id='"+ textBox_Id.Text.Trim()+"')");
			DataSet dsPrint_Kuaidi=BKuaiDi.GetList(" Id='"+ textBox_Id.Text.Trim()+"'");
			Maticsoft.Model.KuaiDi DMKuaidi=BKuaiDi.GetModel(textBox_Id.Text.Trim());
			tabControl_WuLiu.SelectedIndex=1;			
			label_Send_Address.Text=dsPrint_Send.Tables[0].Rows[0]["Address"].ToString();
			label_Send_FromName.Text=dsPrint_Send.Tables[0].Rows[0]["FromName"].ToString();
			label_Send_CompanyName.Text=dsPrint_Send.Tables[0].Rows[0]["CompanyName"].ToString();
			label_Send_Phone.Text=dsPrint_Send.Tables[0].Rows[0]["Phone"].ToString();
			label_Receive_Address.Text=dsPrint_Receive.Tables[0].Rows[0]["Address"].ToString();
			label_Receive_CompanyName.Text=dsPrint_Receive.Tables[0].Rows[0]["CompanyName"].ToString();
			label_Receive_Phone.Text=dsPrint_Receive.Tables[0].Rows[0]["Phone"].ToString();
			label_Receive_ToName.Text=dsPrint_Receive.Tables[0].Rows[0]["ToName"].ToString();
			label_Kuaidi_Amount.Text=Convert.ToDecimal(dsPrint_Kuaidi.Tables[0].Rows[0]["Amount"]).ToString("N");
			label_Kuaidi_FSumGrossWeight.Text= Convert.ToDecimal(dsPrint_Kuaidi.Tables[0].Rows[0]["FSumGrossWeight"]).ToString("N");
			label_Kuaidi_FSumSize.Text=Convert.ToDecimal(dsPrint_Kuaidi.Tables[0].Rows[0]["FSumSize"]).ToString("N");
			//取子表里面的项目
			foreach (Maticsoft.Model.KuaidiDetail MKuaidiDetail in DMKuaidi.KuaidiDetails) {
				string sMKuaidiDetail=MKuaidiDetail.FModel+"*"+Convert.ToDecimal(MKuaidiDetail.FQty).ToString("N")+"\n";
				
				label_KuaidiDetail.Text+=sMKuaidiDetail;
			}
			
			
		}
		
		//使GroupBox控件中的文本框可移动,并取得布局文件中的布局信息
		void TabPage_PrintEnter(object sender, EventArgs e)
		{
			if (Blank.IsBlank(textBox_Id.Text.Trim())) {
			    	MessageBox.Show("快递单号为空","错误");
			    	return;
			}			
			this.printDocument_Kuaidi.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument_Kuaidi_Print);
			int x,y;
			DataSet dsPrint_KuaidiType=BKuaiDi.GetList("Id='"+ textBox_Id.Text.Trim() +"'");
			string sPath=dsPrint_KuaidiType.Tables[0].Rows[0]["KuaidiTypeId"].ToString();
			INIFile iNIFile=new INIFile(".\\"+sPath+".ini");
			foreach (Control ctr in groupBox_Print.Controls) {
				if (ctr is Label) {
					ControlMoveResize cmr=new ControlMoveResize(ctr,this);
					x=Convert.ToInt32(iNIFile.IniReadValue(ctr.Name,"X"));
					y=Convert.ToInt32(iNIFile.IniReadValue(ctr.Name,"Y"));
					ctr.Location=new System.Drawing.Point(x,y);
				}
			}
		}
		
		//保存布局到一个文件
		void Button_SaveLayoutClick(object sender, EventArgs e)
		{
			
			if (Blank.IsBlank(textBox_Id.Text.Trim())) {
			    	MessageBox.Show("快递单号为空","错误");
			    	return;
			}
			DataSet dsPrint_KuaidiType=BKuaiDi.GetList("Id='"+ textBox_Id.Text.Trim() +"'");
			string sPath=dsPrint_KuaidiType.Tables[0].Rows[0]["KuaidiTypeId"].ToString();			
			INIFile iNIFile=new INIFile(".\\"+sPath+".ini");
			foreach (Control ctr in groupBox_Print.Controls) {
				if (ctr is Label) {
					iNIFile.IniWriteValue(ctr.Name,"X",ctr.Location.X.ToString());
					iNIFile.IniWriteValue(ctr.Name,"Y",ctr.Location.Y.ToString());
				}
			}						
		}
		
		void Button_Print_TrueClick(object sender, EventArgs e)
		{
			printDialog_Kuaidi.AllowSomePages=true;
			printDialog_Kuaidi.ShowHelp=true;
			printDialog_Kuaidi.Document=printDocument_Kuaidi;
			DialogResult result=printDialog_Kuaidi.ShowDialog();
			if (result==DialogResult.OK) {
				this.printDocument_Kuaidi.Print();
			}					
		}
		
		//将Form转换成为可打印的图片
		void printDocument_Kuaidi_Print(object sender,System.Drawing.Printing.PrintPageEventArgs e)
		{
			Bitmap newBitmap=new Bitmap(groupBox_Print.Width,groupBox_Print.Height);
			groupBox_Print.DrawToBitmap(newBitmap,new Rectangle(0,0,newBitmap.Width,newBitmap.Height));
			e.Graphics.DrawImage(newBitmap,0,0,newBitmap.Width,newBitmap.Height);
		}
		
		void Button_ModClick(object sender, EventArgs e)
		{
			if ((!Blank.IsBlank(textBox_ModKuaiDiID.Text)) && (!Blank.IsBlank(textBox_Id.Text))) {
				bool b = BKuaiDi.Exists(textBox_Id.Text);
				if (b) {
					bool b1=BKuaiDi.UpdateId(textBox_Id.Text,textBox_ModKuaiDiID.Text);
					if (b1) {MessageBox.Show("更新成功","更新");
						textBox_Id.Text=textBox_ModKuaiDiID.Text;
					} else {MessageBox.Show("更新不成功,请联系管理员!","更新");}
					
				} else {
					MessageBox.Show("原快递单并未保存，请先保存原快递单","错误");
				}
			}	else {
				MessageBox.Show("快递号为空","错误");
				textBox_ModKuaiDiID.Focus();
			}
		}
	}
}
