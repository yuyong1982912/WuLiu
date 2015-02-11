/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014-03-04
 * 时间: 9:56
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WuLiu
{
	partial class Form_WuLiu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl_WuLiu = new System.Windows.Forms.TabControl();
			this.tabPage_Ins = new System.Windows.Forms.TabPage();
			this.textBox_FSGrossWeight = new System.Windows.Forms.TextBox();
			this.label_FSGrossWeight = new System.Windows.Forms.Label();
			this.textBox_FSSize = new System.Windows.Forms.TextBox();
			this.label_FSSize = new System.Windows.Forms.Label();
			this.mCCB_FbillNo = new MultiColumnComboBoxDemo.MultiColumnComboBox();
			this.label_FbillNo = new System.Windows.Forms.Label();
			this.button_Ins = new System.Windows.Forms.Button();
			this.mCCB_SendId = new MultiColumnComboBoxDemo.MultiColumnComboBox();
			this.mCCB_KuaidiTypeId = new MultiColumnComboBoxDemo.MultiColumnComboBox();
			this.mCCB_ReceiveId = new MultiColumnComboBoxDemo.MultiColumnComboBox();
			this.mCCB_FItemId = new MultiColumnComboBoxDemo.MultiColumnComboBox();
			this.dataGridView_KuaidiDetail = new System.Windows.Forms.DataGridView();
			this.FNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FInterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FOrderInterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FGrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FSSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FSGrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox_Memo = new System.Windows.Forms.TextBox();
			this.textBox_Amount = new System.Windows.Forms.TextBox();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.label_Memo = new System.Windows.Forms.Label();
			this.label_Amount = new System.Windows.Forms.Label();
			this.label_Id = new System.Windows.Forms.Label();
			this.label_SendId = new System.Windows.Forms.Label();
			this.label_ReceiveId = new System.Windows.Forms.Label();
			this.label_KuaidiTypeId = new System.Windows.Forms.Label();
			this.label_FItemId = new System.Windows.Forms.Label();
			this.tabPage_Mod = new System.Windows.Forms.TabPage();
			this.tabControl_WuLiu.SuspendLayout();
			this.tabPage_Ins.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_KuaidiDetail)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl_WuLiu
			// 
			this.tabControl_WuLiu.Controls.Add(this.tabPage_Ins);
			this.tabControl_WuLiu.Controls.Add(this.tabPage_Mod);
			this.tabControl_WuLiu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl_WuLiu.Location = new System.Drawing.Point(0, 0);
			this.tabControl_WuLiu.Name = "tabControl_WuLiu";
			this.tabControl_WuLiu.SelectedIndex = 0;
			this.tabControl_WuLiu.Size = new System.Drawing.Size(674, 480);
			this.tabControl_WuLiu.TabIndex = 0;
			// 
			// tabPage_Ins
			// 
			this.tabPage_Ins.Controls.Add(this.textBox_FSGrossWeight);
			this.tabPage_Ins.Controls.Add(this.label_FSGrossWeight);
			this.tabPage_Ins.Controls.Add(this.textBox_FSSize);
			this.tabPage_Ins.Controls.Add(this.label_FSSize);
			this.tabPage_Ins.Controls.Add(this.mCCB_FbillNo);
			this.tabPage_Ins.Controls.Add(this.label_FbillNo);
			this.tabPage_Ins.Controls.Add(this.button_Ins);
			this.tabPage_Ins.Controls.Add(this.mCCB_SendId);
			this.tabPage_Ins.Controls.Add(this.mCCB_KuaidiTypeId);
			this.tabPage_Ins.Controls.Add(this.mCCB_ReceiveId);
			this.tabPage_Ins.Controls.Add(this.mCCB_FItemId);
			this.tabPage_Ins.Controls.Add(this.dataGridView_KuaidiDetail);
			this.tabPage_Ins.Controls.Add(this.textBox_Memo);
			this.tabPage_Ins.Controls.Add(this.textBox_Amount);
			this.tabPage_Ins.Controls.Add(this.textBoxId);
			this.tabPage_Ins.Controls.Add(this.label_Memo);
			this.tabPage_Ins.Controls.Add(this.label_Amount);
			this.tabPage_Ins.Controls.Add(this.label_Id);
			this.tabPage_Ins.Controls.Add(this.label_SendId);
			this.tabPage_Ins.Controls.Add(this.label_ReceiveId);
			this.tabPage_Ins.Controls.Add(this.label_KuaidiTypeId);
			this.tabPage_Ins.Controls.Add(this.label_FItemId);
			this.tabPage_Ins.Location = new System.Drawing.Point(4, 21);
			this.tabPage_Ins.Name = "tabPage_Ins";
			this.tabPage_Ins.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Ins.Size = new System.Drawing.Size(666, 455);
			this.tabPage_Ins.TabIndex = 0;
			this.tabPage_Ins.Text = "新建";
			this.tabPage_Ins.UseVisualStyleBackColor = true;
			this.tabPage_Ins.Enter += new System.EventHandler(this.TabPage_InsEnter);
			// 
			// textBox_FSGrossWeight
			// 
			this.textBox_FSGrossWeight.Location = new System.Drawing.Point(574, 128);
			this.textBox_FSGrossWeight.Name = "textBox_FSGrossWeight";
			this.textBox_FSGrossWeight.Size = new System.Drawing.Size(76, 21);
			this.textBox_FSGrossWeight.TabIndex = 34;
			// 
			// label_FSGrossWeight
			// 
			this.label_FSGrossWeight.AutoSize = true;
			this.label_FSGrossWeight.Location = new System.Drawing.Point(527, 133);
			this.label_FSGrossWeight.Name = "label_FSGrossWeight";
			this.label_FSGrossWeight.Size = new System.Drawing.Size(53, 12);
			this.label_FSGrossWeight.TabIndex = 33;
			this.label_FSGrossWeight.Text = "总毛重：";
			// 
			// textBox_FSSize
			// 
			this.textBox_FSSize.Location = new System.Drawing.Point(433, 130);
			this.textBox_FSSize.Name = "textBox_FSSize";
			this.textBox_FSSize.Size = new System.Drawing.Size(79, 21);
			this.textBox_FSSize.TabIndex = 32;
			// 
			// label_FSSize
			// 
			this.label_FSSize.AutoSize = true;
			this.label_FSSize.Location = new System.Drawing.Point(350, 134);
			this.label_FSSize.Name = "label_FSSize";
			this.label_FSSize.Size = new System.Drawing.Size(53, 12);
			this.label_FSSize.TabIndex = 31;
			this.label_FSSize.Text = "总体积：";
			// 
			// mCCB_FbillNo
			// 
			this.mCCB_FbillNo.AutoComplete = true;
			this.mCCB_FbillNo.AutoDropdown = true;
			this.mCCB_FbillNo.BackColorEven = System.Drawing.Color.White;
			this.mCCB_FbillNo.BackColorOdd = System.Drawing.Color.White;
			this.mCCB_FbillNo.ColumnNames = "";
			this.mCCB_FbillNo.ColumnWidthDefault = 75;
			this.mCCB_FbillNo.ColumnWidths = "";
			this.mCCB_FbillNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.mCCB_FbillNo.FormattingEnabled = true;
			this.mCCB_FbillNo.LinkedColumnIndex = 0;
			this.mCCB_FbillNo.LinkedTextBox = null;
			this.mCCB_FbillNo.Location = new System.Drawing.Point(88, 130);
			this.mCCB_FbillNo.Name = "mCCB_FbillNo";
			this.mCCB_FbillNo.Size = new System.Drawing.Size(256, 22);
			this.mCCB_FbillNo.TabIndex = 30;
			this.mCCB_FbillNo.OpenSearchForm += new System.EventHandler(this.multiColumnComboBox_OpenSearchForm);
			this.mCCB_FbillNo.SelectionChangeCommitted += new System.EventHandler(this.MCCB_FbillNoSelectionChangeCommitted);
			// 
			// label_FbillNo
			// 
			this.label_FbillNo.AutoSize = true;
			this.label_FbillNo.Location = new System.Drawing.Point(8, 133);
			this.label_FbillNo.Name = "label_FbillNo";
			this.label_FbillNo.Size = new System.Drawing.Size(77, 12);
			this.label_FbillNo.TabIndex = 29;
			this.label_FbillNo.Text = "销售出库单：";
			// 
			// button_Ins
			// 
			this.button_Ins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Ins.Location = new System.Drawing.Point(9, 429);
			this.button_Ins.Name = "button_Ins";
			this.button_Ins.Size = new System.Drawing.Size(75, 23);
			this.button_Ins.TabIndex = 28;
			this.button_Ins.Text = "新建";
			this.button_Ins.UseVisualStyleBackColor = true;
			this.button_Ins.Click += new System.EventHandler(this.Button_InsClick);
			// 
			// mCCB_SendId
			// 
			this.mCCB_SendId.AutoComplete = true;
			this.mCCB_SendId.AutoDropdown = true;
			this.mCCB_SendId.BackColorEven = System.Drawing.Color.White;
			this.mCCB_SendId.BackColorOdd = System.Drawing.Color.White;
			this.mCCB_SendId.ColumnNames = "";
			this.mCCB_SendId.ColumnWidthDefault = 75;
			this.mCCB_SendId.ColumnWidths = "";
			this.mCCB_SendId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.mCCB_SendId.FormattingEnabled = true;
			this.mCCB_SendId.LinkedColumnIndex = 0;
			this.mCCB_SendId.LinkedTextBox = null;
			this.mCCB_SendId.Location = new System.Drawing.Point(88, 100);
			this.mCCB_SendId.Name = "mCCB_SendId";
			this.mCCB_SendId.Size = new System.Drawing.Size(256, 22);
			this.mCCB_SendId.TabIndex = 27;
			this.mCCB_SendId.OpenSearchForm += new System.EventHandler(this.multiColumnComboBox_OpenSearchForm);
			// 
			// mCCB_KuaidiTypeId
			// 
			this.mCCB_KuaidiTypeId.AutoComplete = true;
			this.mCCB_KuaidiTypeId.AutoDropdown = true;
			this.mCCB_KuaidiTypeId.BackColorEven = System.Drawing.Color.White;
			this.mCCB_KuaidiTypeId.BackColorOdd = System.Drawing.Color.White;
			this.mCCB_KuaidiTypeId.ColumnNames = "";
			this.mCCB_KuaidiTypeId.ColumnWidthDefault = 75;
			this.mCCB_KuaidiTypeId.ColumnWidths = "";
			this.mCCB_KuaidiTypeId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.mCCB_KuaidiTypeId.FormattingEnabled = true;
			this.mCCB_KuaidiTypeId.LinkedColumnIndex = 0;
			this.mCCB_KuaidiTypeId.LinkedTextBox = null;
			this.mCCB_KuaidiTypeId.Location = new System.Drawing.Point(88, 41);
			this.mCCB_KuaidiTypeId.Name = "mCCB_KuaidiTypeId";
			this.mCCB_KuaidiTypeId.Size = new System.Drawing.Size(256, 22);
			this.mCCB_KuaidiTypeId.TabIndex = 26;
			this.mCCB_KuaidiTypeId.OpenSearchForm += new System.EventHandler(this.multiColumnComboBox_OpenSearchForm);
			// 
			// mCCB_ReceiveId
			// 
			this.mCCB_ReceiveId.AutoComplete = true;
			this.mCCB_ReceiveId.AutoDropdown = true;
			this.mCCB_ReceiveId.BackColorEven = System.Drawing.Color.Gray;
			this.mCCB_ReceiveId.BackColorOdd = System.Drawing.Color.White;
			this.mCCB_ReceiveId.ColumnNames = "";
			this.mCCB_ReceiveId.ColumnWidthDefault = 75;
			this.mCCB_ReceiveId.ColumnWidths = "";
			this.mCCB_ReceiveId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.mCCB_ReceiveId.FormattingEnabled = true;
			this.mCCB_ReceiveId.LinkedColumnIndex = 0;
			this.mCCB_ReceiveId.LinkedTextBox = null;
			this.mCCB_ReceiveId.Location = new System.Drawing.Point(88, 71);
			this.mCCB_ReceiveId.Name = "mCCB_ReceiveId";
			this.mCCB_ReceiveId.Size = new System.Drawing.Size(256, 22);
			this.mCCB_ReceiveId.TabIndex = 25;
			this.mCCB_ReceiveId.OpenSearchForm += new System.EventHandler(this.multiColumnComboBox_OpenSearchForm);
			// 
			// mCCB_FItemId
			// 
			this.mCCB_FItemId.AutoComplete = true;
			this.mCCB_FItemId.AutoDropdown = true;
			this.mCCB_FItemId.BackColorEven = System.Drawing.Color.Gray;
			this.mCCB_FItemId.BackColorOdd = System.Drawing.Color.White;
			this.mCCB_FItemId.ColumnNames = "";
			this.mCCB_FItemId.ColumnWidthDefault = 75;
			this.mCCB_FItemId.ColumnWidths = "50;150";
			this.mCCB_FItemId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.mCCB_FItemId.FormattingEnabled = true;
			this.mCCB_FItemId.LinkedColumnIndex = 0;
			this.mCCB_FItemId.LinkedTextBox = null;
			this.mCCB_FItemId.Location = new System.Drawing.Point(88, 9);
			this.mCCB_FItemId.Name = "mCCB_FItemId";
			this.mCCB_FItemId.Size = new System.Drawing.Size(256, 22);
			this.mCCB_FItemId.TabIndex = 24;
			this.mCCB_FItemId.OpenSearchForm += new System.EventHandler(this.multiColumnComboBox_OpenSearchForm);
			this.mCCB_FItemId.SelectedIndexChanged += new System.EventHandler(this.MCCB_FItemIdSelectedIndexChanged);
			// 
			// dataGridView_KuaidiDetail
			// 
			this.dataGridView_KuaidiDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_KuaidiDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_KuaidiDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.FNumber,
									this.FModel,
									this.FInterId,
									this.FOrderInterId,
									this.FQty,
									this.FSize,
									this.FGrossWeight,
									this.FSSize,
									this.FSGrossWeight,
									this.FMemo});
			this.dataGridView_KuaidiDetail.Location = new System.Drawing.Point(8, 158);
			this.dataGridView_KuaidiDetail.Name = "dataGridView_KuaidiDetail";
			this.dataGridView_KuaidiDetail.RowTemplate.Height = 23;
			this.dataGridView_KuaidiDetail.Size = new System.Drawing.Size(649, 264);
			this.dataGridView_KuaidiDetail.TabIndex = 23;
			this.dataGridView_KuaidiDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_KuaidiDetailCellEndEdit);
			// 
			// FNumber
			// 
			this.FNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.FNumber.HeaderText = "物料代码";
			this.FNumber.Name = "FNumber";
			this.FNumber.Width = 59;
			// 
			// FModel
			// 
			this.FModel.HeaderText = "规格型号";
			this.FModel.Name = "FModel";
			// 
			// FInterId
			// 
			this.FInterId.HeaderText = "销售出库单单号";
			this.FInterId.Name = "FInterId";
			// 
			// FOrderInterId
			// 
			this.FOrderInterId.HeaderText = "销售订单单号";
			this.FOrderInterId.Name = "FOrderInterId";
			// 
			// FQty
			// 
			this.FQty.HeaderText = "数量";
			this.FQty.Name = "FQty";
			// 
			// FSize
			// 
			this.FSize.HeaderText = "体积";
			this.FSize.Name = "FSize";
			// 
			// FGrossWeight
			// 
			this.FGrossWeight.HeaderText = "毛重";
			this.FGrossWeight.Name = "FGrossWeight";
			// 
			// FSSize
			// 
			this.FSSize.HeaderText = "总体积";
			this.FSSize.Name = "FSSize";
			// 
			// FSGrossWeight
			// 
			this.FSGrossWeight.HeaderText = "总毛重";
			this.FSGrossWeight.Name = "FSGrossWeight";
			// 
			// FMemo
			// 
			this.FMemo.HeaderText = "备注";
			this.FMemo.Name = "FMemo";
			// 
			// textBox_Memo
			// 
			this.textBox_Memo.Location = new System.Drawing.Point(433, 71);
			this.textBox_Memo.Multiline = true;
			this.textBox_Memo.Name = "textBox_Memo";
			this.textBox_Memo.Size = new System.Drawing.Size(217, 51);
			this.textBox_Memo.TabIndex = 14;
			// 
			// textBox_Amount
			// 
			this.textBox_Amount.Location = new System.Drawing.Point(433, 41);
			this.textBox_Amount.Name = "textBox_Amount";
			this.textBox_Amount.Size = new System.Drawing.Size(217, 21);
			this.textBox_Amount.TabIndex = 13;
			// 
			// textBoxId
			// 
			this.textBoxId.Location = new System.Drawing.Point(433, 15);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(217, 21);
			this.textBoxId.TabIndex = 12;
			// 
			// label_Memo
			// 
			this.label_Memo.AutoSize = true;
			this.label_Memo.Location = new System.Drawing.Point(350, 71);
			this.label_Memo.Name = "label_Memo";
			this.label_Memo.Size = new System.Drawing.Size(41, 12);
			this.label_Memo.TabIndex = 11;
			this.label_Memo.Text = "备注：";
			// 
			// label_Amount
			// 
			this.label_Amount.AutoSize = true;
			this.label_Amount.Location = new System.Drawing.Point(350, 45);
			this.label_Amount.Name = "label_Amount";
			this.label_Amount.Size = new System.Drawing.Size(41, 12);
			this.label_Amount.TabIndex = 10;
			this.label_Amount.Text = "保价：";
			// 
			// label_Id
			// 
			this.label_Id.AutoSize = true;
			this.label_Id.Location = new System.Drawing.Point(350, 19);
			this.label_Id.Name = "label_Id";
			this.label_Id.Size = new System.Drawing.Size(77, 12);
			this.label_Id.TabIndex = 8;
			this.label_Id.Text = "快递单编号：";
			// 
			// label_SendId
			// 
			this.label_SendId.AutoSize = true;
			this.label_SendId.Location = new System.Drawing.Point(8, 103);
			this.label_SendId.Name = "label_SendId";
			this.label_SendId.Size = new System.Drawing.Size(53, 12);
			this.label_SendId.TabIndex = 7;
			this.label_SendId.Text = "发件人：";
			// 
			// label_ReceiveId
			// 
			this.label_ReceiveId.AutoSize = true;
			this.label_ReceiveId.Location = new System.Drawing.Point(8, 71);
			this.label_ReceiveId.Name = "label_ReceiveId";
			this.label_ReceiveId.Size = new System.Drawing.Size(53, 12);
			this.label_ReceiveId.TabIndex = 5;
			this.label_ReceiveId.Text = "收件人：";
			// 
			// label_KuaidiTypeId
			// 
			this.label_KuaidiTypeId.AutoSize = true;
			this.label_KuaidiTypeId.Location = new System.Drawing.Point(8, 44);
			this.label_KuaidiTypeId.Name = "label_KuaidiTypeId";
			this.label_KuaidiTypeId.Size = new System.Drawing.Size(77, 12);
			this.label_KuaidiTypeId.TabIndex = 3;
			this.label_KuaidiTypeId.Text = "快递单类型：";
			// 
			// label_FItemId
			// 
			this.label_FItemId.AutoSize = true;
			this.label_FItemId.Location = new System.Drawing.Point(8, 12);
			this.label_FItemId.Name = "label_FItemId";
			this.label_FItemId.Size = new System.Drawing.Size(65, 12);
			this.label_FItemId.TabIndex = 1;
			this.label_FItemId.Text = "客户名称：";
			// 
			// tabPage_Mod
			// 
			this.tabPage_Mod.Location = new System.Drawing.Point(4, 21);
			this.tabPage_Mod.Name = "tabPage_Mod";
			this.tabPage_Mod.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Mod.Size = new System.Drawing.Size(666, 455);
			this.tabPage_Mod.TabIndex = 1;
			this.tabPage_Mod.Text = "修改";
			this.tabPage_Mod.UseVisualStyleBackColor = true;
			// 
			// Form_WuLiu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 480);
			this.Controls.Add(this.tabControl_WuLiu);
			this.Name = "Form_WuLiu";
			this.Text = "快递单";
			this.tabControl_WuLiu.ResumeLayout(false);
			this.tabPage_Ins.ResumeLayout(false);
			this.tabPage_Ins.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_KuaidiDetail)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label_FSSize;
		private System.Windows.Forms.TextBox textBox_FSSize;
		private System.Windows.Forms.Label label_FSGrossWeight;
		private System.Windows.Forms.TextBox textBox_FSGrossWeight;
		private System.Windows.Forms.DataGridViewTextBoxColumn FMemo;
		private System.Windows.Forms.DataGridViewTextBoxColumn FSGrossWeight;
		private System.Windows.Forms.DataGridViewTextBoxColumn FSSize;
		private System.Windows.Forms.DataGridViewTextBoxColumn FGrossWeight;
		private System.Windows.Forms.DataGridViewTextBoxColumn FSize;
		private System.Windows.Forms.DataGridViewTextBoxColumn FQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn FOrderInterId;
		private System.Windows.Forms.DataGridViewTextBoxColumn FInterId;
		private System.Windows.Forms.DataGridViewTextBoxColumn FModel;
		private System.Windows.Forms.DataGridViewTextBoxColumn FNumber;
		private System.Windows.Forms.Label label_FbillNo;
		private MultiColumnComboBoxDemo.MultiColumnComboBox mCCB_FbillNo;
		private System.Windows.Forms.Button button_Ins;
		private MultiColumnComboBoxDemo.MultiColumnComboBox mCCB_KuaidiTypeId;
		private MultiColumnComboBoxDemo.MultiColumnComboBox mCCB_SendId;
		private MultiColumnComboBoxDemo.MultiColumnComboBox mCCB_ReceiveId;
		private MultiColumnComboBoxDemo.MultiColumnComboBox mCCB_FItemId;
		private System.Windows.Forms.DataGridView dataGridView_KuaidiDetail;
		private System.Windows.Forms.Label label_Amount;
		private System.Windows.Forms.Label label_Memo;
		private System.Windows.Forms.TextBox textBoxId;
		private System.Windows.Forms.TextBox textBox_Amount;
		private System.Windows.Forms.TextBox textBox_Memo;
		private System.Windows.Forms.Label label_KuaidiTypeId;
		private System.Windows.Forms.Label label_ReceiveId;
		private System.Windows.Forms.Label label_SendId;
		private System.Windows.Forms.Label label_Id;
		private System.Windows.Forms.Label label_FItemId;
		private System.Windows.Forms.TabPage tabPage_Mod;
		private System.Windows.Forms.TabPage tabPage_Ins;
		private System.Windows.Forms.TabControl tabControl_WuLiu;
	}
}
