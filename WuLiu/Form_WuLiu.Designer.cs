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
            this.textBox_ModKuaiDiID = new System.Windows.Forms.TextBox();
            this.button_Mod = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
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
            this.FCItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_Memo = new System.Windows.Forms.TextBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Memo = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_SendId = new System.Windows.Forms.Label();
            this.label_ReceiveId = new System.Windows.Forms.Label();
            this.label_KuaidiTypeId = new System.Windows.Forms.Label();
            this.label_FItemId = new System.Windows.Forms.Label();
            this.tabPage_Print = new System.Windows.Forms.TabPage();
            this.button_SaveLayout = new System.Windows.Forms.Button();
            this.button_Print_True = new System.Windows.Forms.Button();
            this.groupBox_Print = new System.Windows.Forms.GroupBox();
            this.label_KuaidiDetail = new System.Windows.Forms.Label();
            this.label_Kuaidi_FSumGrossWeight = new System.Windows.Forms.Label();
            this.label_Kuaidi_FSumSize = new System.Windows.Forms.Label();
            this.label_Kuaidi_Amount = new System.Windows.Forms.Label();
            this.label_Receive_Phone = new System.Windows.Forms.Label();
            this.label_Receive_ToName = new System.Windows.Forms.Label();
            this.label_Receive_CompanyName = new System.Windows.Forms.Label();
            this.label_Receive_Address = new System.Windows.Forms.Label();
            this.label_Send_Phone = new System.Windows.Forms.Label();
            this.label_Send_FromName = new System.Windows.Forms.Label();
            this.label_Send_CompanyName = new System.Windows.Forms.Label();
            this.label_Send_Address = new System.Windows.Forms.Label();
            this.printDocument_Kuaidi = new System.Drawing.Printing.PrintDocument();
            this.printDialog_Kuaidi = new System.Windows.Forms.PrintDialog();
            this.tabControl_WuLiu.SuspendLayout();
            this.tabPage_Ins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KuaidiDetail)).BeginInit();
            this.tabPage_Print.SuspendLayout();
            this.groupBox_Print.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_WuLiu
            // 
            this.tabControl_WuLiu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_WuLiu.Controls.Add(this.tabPage_Ins);
            this.tabControl_WuLiu.Controls.Add(this.tabPage_Print);
            this.tabControl_WuLiu.Location = new System.Drawing.Point(0, 0);
            this.tabControl_WuLiu.Name = "tabControl_WuLiu";
            this.tabControl_WuLiu.SelectedIndex = 0;
            this.tabControl_WuLiu.Size = new System.Drawing.Size(933, 520);
            this.tabControl_WuLiu.TabIndex = 0;
            // 
            // tabPage_Ins
            // 
            this.tabPage_Ins.Controls.Add(this.textBox_ModKuaiDiID);
            this.tabPage_Ins.Controls.Add(this.button_Mod);
            this.tabPage_Ins.Controls.Add(this.button_Print);
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
            this.tabPage_Ins.Controls.Add(this.textBox_Id);
            this.tabPage_Ins.Controls.Add(this.label_Memo);
            this.tabPage_Ins.Controls.Add(this.label_Amount);
            this.tabPage_Ins.Controls.Add(this.label_Id);
            this.tabPage_Ins.Controls.Add(this.label_SendId);
            this.tabPage_Ins.Controls.Add(this.label_ReceiveId);
            this.tabPage_Ins.Controls.Add(this.label_KuaidiTypeId);
            this.tabPage_Ins.Controls.Add(this.label_FItemId);
            this.tabPage_Ins.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Ins.Name = "tabPage_Ins";
            this.tabPage_Ins.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Ins.Size = new System.Drawing.Size(925, 494);
            this.tabPage_Ins.TabIndex = 0;
            this.tabPage_Ins.Text = "新建";
            this.tabPage_Ins.UseVisualStyleBackColor = true;
            this.tabPage_Ins.Enter += new System.EventHandler(this.TabPage_InsEnter);
            // 
            // textBox_ModKuaiDiID
            // 
            this.textBox_ModKuaiDiID.Location = new System.Drawing.Point(266, 464);
            this.textBox_ModKuaiDiID.Name = "textBox_ModKuaiDiID";
            this.textBox_ModKuaiDiID.Size = new System.Drawing.Size(125, 20);
            this.textBox_ModKuaiDiID.TabIndex = 37;
            // 
            // button_Mod
            // 
            this.button_Mod.Location = new System.Drawing.Point(397, 464);
            this.button_Mod.Name = "button_Mod";
            this.button_Mod.Size = new System.Drawing.Size(105, 25);
            this.button_Mod.TabIndex = 36;
            this.button_Mod.Text = "更改快递单号";
            this.button_Mod.UseVisualStyleBackColor = true;
            this.button_Mod.Click += new System.EventHandler(this.Button_ModClick);
            // 
            // button_Print
            // 
            this.button_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Print.Location = new System.Drawing.Point(91, 465);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(75, 25);
            this.button_Print.TabIndex = 35;
            this.button_Print.Text = "打印";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.Button_PrintClick);
            // 
            // textBox_FSGrossWeight
            // 
            this.textBox_FSGrossWeight.Location = new System.Drawing.Point(574, 139);
            this.textBox_FSGrossWeight.Name = "textBox_FSGrossWeight";
            this.textBox_FSGrossWeight.Size = new System.Drawing.Size(76, 20);
            this.textBox_FSGrossWeight.TabIndex = 34;
            // 
            // label_FSGrossWeight
            // 
            this.label_FSGrossWeight.AutoSize = true;
            this.label_FSGrossWeight.Location = new System.Drawing.Point(527, 144);
            this.label_FSGrossWeight.Name = "label_FSGrossWeight";
            this.label_FSGrossWeight.Size = new System.Drawing.Size(59, 13);
            this.label_FSGrossWeight.TabIndex = 33;
            this.label_FSGrossWeight.Text = "*总毛重：";
            // 
            // textBox_FSSize
            // 
            this.textBox_FSSize.Location = new System.Drawing.Point(433, 141);
            this.textBox_FSSize.Name = "textBox_FSSize";
            this.textBox_FSSize.Size = new System.Drawing.Size(79, 20);
            this.textBox_FSSize.TabIndex = 32;
            // 
            // label_FSSize
            // 
            this.label_FSSize.AutoSize = true;
            this.label_FSSize.Location = new System.Drawing.Point(350, 145);
            this.label_FSSize.Name = "label_FSSize";
            this.label_FSSize.Size = new System.Drawing.Size(59, 13);
            this.label_FSSize.TabIndex = 31;
            this.label_FSSize.Text = "*总体积：";
            // 
            // mCCB_FbillNo
            // 
            this.mCCB_FbillNo.AutoComplete = true;
            this.mCCB_FbillNo.AutoDropdown = true;
            this.mCCB_FbillNo.BackColorEven = System.Drawing.Color.LightGray;
            this.mCCB_FbillNo.BackColorOdd = System.Drawing.Color.White;
            this.mCCB_FbillNo.ColumnNames = "";
            this.mCCB_FbillNo.ColumnWidthDefault = 75;
            this.mCCB_FbillNo.ColumnWidths = "";
            this.mCCB_FbillNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mCCB_FbillNo.FormattingEnabled = true;
            this.mCCB_FbillNo.LinkedColumnIndex = 0;
            this.mCCB_FbillNo.LinkedTextBox = null;
            this.mCCB_FbillNo.Location = new System.Drawing.Point(88, 141);
            this.mCCB_FbillNo.Name = "mCCB_FbillNo";
            this.mCCB_FbillNo.Size = new System.Drawing.Size(256, 21);
            this.mCCB_FbillNo.TabIndex = 30;
            this.mCCB_FbillNo.OpenSearchForm += new System.EventHandler(this.multiColumnComboBox_OpenSearchForm);
            this.mCCB_FbillNo.SelectionChangeCommitted += new System.EventHandler(this.MCCB_FbillNoSelectionChangeCommitted);
            // 
            // label_FbillNo
            // 
            this.label_FbillNo.AutoSize = true;
            this.label_FbillNo.Location = new System.Drawing.Point(8, 144);
            this.label_FbillNo.Name = "label_FbillNo";
            this.label_FbillNo.Size = new System.Drawing.Size(83, 13);
            this.label_FbillNo.TabIndex = 29;
            this.label_FbillNo.Text = "*销售出库单：";
            // 
            // button_Ins
            // 
            this.button_Ins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Ins.Location = new System.Drawing.Point(9, 465);
            this.button_Ins.Name = "button_Ins";
            this.button_Ins.Size = new System.Drawing.Size(75, 25);
            this.button_Ins.TabIndex = 28;
            this.button_Ins.Text = "新建";
            this.button_Ins.UseVisualStyleBackColor = true;
            this.button_Ins.Click += new System.EventHandler(this.Button_InsClick);
            // 
            // mCCB_SendId
            // 
            this.mCCB_SendId.AutoComplete = true;
            this.mCCB_SendId.AutoDropdown = true;
            this.mCCB_SendId.BackColorEven = System.Drawing.Color.LightGray;
            this.mCCB_SendId.BackColorOdd = System.Drawing.Color.White;
            this.mCCB_SendId.ColumnNames = "";
            this.mCCB_SendId.ColumnWidthDefault = 75;
            this.mCCB_SendId.ColumnWidths = "";
            this.mCCB_SendId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mCCB_SendId.FormattingEnabled = true;
            this.mCCB_SendId.LinkedColumnIndex = 0;
            this.mCCB_SendId.LinkedTextBox = null;
            this.mCCB_SendId.Location = new System.Drawing.Point(88, 108);
            this.mCCB_SendId.Name = "mCCB_SendId";
            this.mCCB_SendId.Size = new System.Drawing.Size(256, 21);
            this.mCCB_SendId.TabIndex = 27;
            this.mCCB_SendId.OpenSearchForm += new System.EventHandler(this.multiColumnComboBox_OpenSearchForm);
            // 
            // mCCB_KuaidiTypeId
            // 
            this.mCCB_KuaidiTypeId.AutoComplete = true;
            this.mCCB_KuaidiTypeId.AutoDropdown = true;
            this.mCCB_KuaidiTypeId.BackColorEven = System.Drawing.Color.LightGray;
            this.mCCB_KuaidiTypeId.BackColorOdd = System.Drawing.Color.White;
            this.mCCB_KuaidiTypeId.ColumnNames = "";
            this.mCCB_KuaidiTypeId.ColumnWidthDefault = 75;
            this.mCCB_KuaidiTypeId.ColumnWidths = "";
            this.mCCB_KuaidiTypeId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mCCB_KuaidiTypeId.FormattingEnabled = true;
            this.mCCB_KuaidiTypeId.LinkedColumnIndex = 0;
            this.mCCB_KuaidiTypeId.LinkedTextBox = null;
            this.mCCB_KuaidiTypeId.Location = new System.Drawing.Point(88, 44);
            this.mCCB_KuaidiTypeId.Name = "mCCB_KuaidiTypeId";
            this.mCCB_KuaidiTypeId.Size = new System.Drawing.Size(256, 21);
            this.mCCB_KuaidiTypeId.TabIndex = 26;
            this.mCCB_KuaidiTypeId.OpenSearchForm += new System.EventHandler(this.multiColumnComboBox_OpenSearchForm);
            // 
            // mCCB_ReceiveId
            // 
            this.mCCB_ReceiveId.AutoComplete = true;
            this.mCCB_ReceiveId.AutoDropdown = true;
            this.mCCB_ReceiveId.BackColorEven = System.Drawing.Color.LightGray;
            this.mCCB_ReceiveId.BackColorOdd = System.Drawing.Color.White;
            this.mCCB_ReceiveId.ColumnNames = "";
            this.mCCB_ReceiveId.ColumnWidthDefault = 75;
            this.mCCB_ReceiveId.ColumnWidths = "";
            this.mCCB_ReceiveId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mCCB_ReceiveId.FormattingEnabled = true;
            this.mCCB_ReceiveId.LinkedColumnIndex = 0;
            this.mCCB_ReceiveId.LinkedTextBox = null;
            this.mCCB_ReceiveId.Location = new System.Drawing.Point(88, 77);
            this.mCCB_ReceiveId.Name = "mCCB_ReceiveId";
            this.mCCB_ReceiveId.Size = new System.Drawing.Size(256, 21);
            this.mCCB_ReceiveId.TabIndex = 25;
            this.mCCB_ReceiveId.OpenSearchForm += new System.EventHandler(this.multiColumnComboBox_OpenSearchForm);
            // 
            // mCCB_FItemId
            // 
            this.mCCB_FItemId.AutoComplete = true;
            this.mCCB_FItemId.AutoDropdown = true;
            this.mCCB_FItemId.BackColorEven = System.Drawing.Color.LightGray;
            this.mCCB_FItemId.BackColorOdd = System.Drawing.Color.White;
            this.mCCB_FItemId.ColumnNames = "";
            this.mCCB_FItemId.ColumnWidthDefault = 75;
            this.mCCB_FItemId.ColumnWidths = "50;150";
            this.mCCB_FItemId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mCCB_FItemId.FormattingEnabled = true;
            this.mCCB_FItemId.LinkedColumnIndex = 0;
            this.mCCB_FItemId.LinkedTextBox = null;
            this.mCCB_FItemId.Location = new System.Drawing.Point(88, 10);
            this.mCCB_FItemId.Name = "mCCB_FItemId";
            this.mCCB_FItemId.Size = new System.Drawing.Size(256, 21);
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
            this.FCItemID,
            this.FMemo});
            this.dataGridView_KuaidiDetail.Location = new System.Drawing.Point(8, 171);
            this.dataGridView_KuaidiDetail.Name = "dataGridView_KuaidiDetail";
            this.dataGridView_KuaidiDetail.RowTemplate.Height = 23;
            this.dataGridView_KuaidiDetail.Size = new System.Drawing.Size(909, 286);
            this.dataGridView_KuaidiDetail.TabIndex = 23;
            this.dataGridView_KuaidiDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_KuaidiDetailCellEndEdit);
            // 
            // FNumber
            // 
            this.FNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FNumber.HeaderText = "物料代码";
            this.FNumber.Name = "FNumber";
            this.FNumber.Width = 63;
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
            // FCItemID
            // 
            this.FCItemID.HeaderText = "客户名称";
            this.FCItemID.Name = "FCItemID";
            // 
            // FMemo
            // 
            this.FMemo.HeaderText = "备注";
            this.FMemo.Name = "FMemo";
            // 
            // textBox_Memo
            // 
            this.textBox_Memo.Location = new System.Drawing.Point(433, 77);
            this.textBox_Memo.Multiline = true;
            this.textBox_Memo.Name = "textBox_Memo";
            this.textBox_Memo.Size = new System.Drawing.Size(217, 55);
            this.textBox_Memo.TabIndex = 14;
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(433, 44);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(217, 20);
            this.textBox_Amount.TabIndex = 13;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(433, 16);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(217, 20);
            this.textBox_Id.TabIndex = 12;
            // 
            // label_Memo
            // 
            this.label_Memo.AutoSize = true;
            this.label_Memo.Location = new System.Drawing.Point(350, 77);
            this.label_Memo.Name = "label_Memo";
            this.label_Memo.Size = new System.Drawing.Size(43, 13);
            this.label_Memo.TabIndex = 11;
            this.label_Memo.Text = "备注：";
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Location = new System.Drawing.Point(350, 49);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(43, 13);
            this.label_Amount.TabIndex = 10;
            this.label_Amount.Text = "保价：";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(350, 21);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(83, 13);
            this.label_Id.TabIndex = 8;
            this.label_Id.Text = "*快递单编号：";
            // 
            // label_SendId
            // 
            this.label_SendId.AutoSize = true;
            this.label_SendId.Location = new System.Drawing.Point(8, 112);
            this.label_SendId.Name = "label_SendId";
            this.label_SendId.Size = new System.Drawing.Size(59, 13);
            this.label_SendId.TabIndex = 7;
            this.label_SendId.Text = "*发件人：";
            // 
            // label_ReceiveId
            // 
            this.label_ReceiveId.AutoSize = true;
            this.label_ReceiveId.Location = new System.Drawing.Point(8, 77);
            this.label_ReceiveId.Name = "label_ReceiveId";
            this.label_ReceiveId.Size = new System.Drawing.Size(59, 13);
            this.label_ReceiveId.TabIndex = 5;
            this.label_ReceiveId.Text = "*收件人：";
            // 
            // label_KuaidiTypeId
            // 
            this.label_KuaidiTypeId.AutoSize = true;
            this.label_KuaidiTypeId.Location = new System.Drawing.Point(8, 48);
            this.label_KuaidiTypeId.Name = "label_KuaidiTypeId";
            this.label_KuaidiTypeId.Size = new System.Drawing.Size(83, 13);
            this.label_KuaidiTypeId.TabIndex = 3;
            this.label_KuaidiTypeId.Text = "*快递单类型：";
            // 
            // label_FItemId
            // 
            this.label_FItemId.AutoSize = true;
            this.label_FItemId.Location = new System.Drawing.Point(8, 13);
            this.label_FItemId.Name = "label_FItemId";
            this.label_FItemId.Size = new System.Drawing.Size(71, 13);
            this.label_FItemId.TabIndex = 1;
            this.label_FItemId.Text = "*客户名称：";
            // 
            // tabPage_Print
            // 
            this.tabPage_Print.Controls.Add(this.button_SaveLayout);
            this.tabPage_Print.Controls.Add(this.button_Print_True);
            this.tabPage_Print.Controls.Add(this.groupBox_Print);
            this.tabPage_Print.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Print.Name = "tabPage_Print";
            this.tabPage_Print.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Print.Size = new System.Drawing.Size(925, 494);
            this.tabPage_Print.TabIndex = 1;
            this.tabPage_Print.Text = "打印";
            this.tabPage_Print.UseVisualStyleBackColor = true;
            this.tabPage_Print.Enter += new System.EventHandler(this.TabPage_PrintEnter);
            // 
            // button_SaveLayout
            // 
            this.button_SaveLayout.Location = new System.Drawing.Point(107, 458);
            this.button_SaveLayout.Name = "button_SaveLayout";
            this.button_SaveLayout.Size = new System.Drawing.Size(75, 25);
            this.button_SaveLayout.TabIndex = 2;
            this.button_SaveLayout.Text = "保存布局";
            this.button_SaveLayout.UseVisualStyleBackColor = true;
            this.button_SaveLayout.Click += new System.EventHandler(this.Button_SaveLayoutClick);
            // 
            // button_Print_True
            // 
            this.button_Print_True.Location = new System.Drawing.Point(15, 458);
            this.button_Print_True.Name = "button_Print_True";
            this.button_Print_True.Size = new System.Drawing.Size(75, 25);
            this.button_Print_True.TabIndex = 1;
            this.button_Print_True.Text = "打印";
            this.button_Print_True.UseVisualStyleBackColor = true;
            this.button_Print_True.Click += new System.EventHandler(this.Button_Print_TrueClick);
            // 
            // groupBox_Print
            // 
            this.groupBox_Print.Controls.Add(this.label_KuaidiDetail);
            this.groupBox_Print.Controls.Add(this.label_Kuaidi_FSumGrossWeight);
            this.groupBox_Print.Controls.Add(this.label_Kuaidi_FSumSize);
            this.groupBox_Print.Controls.Add(this.label_Kuaidi_Amount);
            this.groupBox_Print.Controls.Add(this.label_Receive_Phone);
            this.groupBox_Print.Controls.Add(this.label_Receive_ToName);
            this.groupBox_Print.Controls.Add(this.label_Receive_CompanyName);
            this.groupBox_Print.Controls.Add(this.label_Receive_Address);
            this.groupBox_Print.Controls.Add(this.label_Send_Phone);
            this.groupBox_Print.Controls.Add(this.label_Send_FromName);
            this.groupBox_Print.Controls.Add(this.label_Send_CompanyName);
            this.groupBox_Print.Controls.Add(this.label_Send_Address);
            this.groupBox_Print.Location = new System.Drawing.Point(8, 7);
            this.groupBox_Print.Name = "groupBox_Print";
            this.groupBox_Print.Size = new System.Drawing.Size(909, 445);
            this.groupBox_Print.TabIndex = 0;
            this.groupBox_Print.TabStop = false;
            // 
            // label_KuaidiDetail
            // 
            this.label_KuaidiDetail.AutoSize = true;
            this.label_KuaidiDetail.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_KuaidiDetail.Location = new System.Drawing.Point(344, 198);
            this.label_KuaidiDetail.Name = "label_KuaidiDetail";
            this.label_KuaidiDetail.Size = new System.Drawing.Size(0, 12);
            this.label_KuaidiDetail.TabIndex = 11;
            // 
            // label_Kuaidi_FSumGrossWeight
            // 
            this.label_Kuaidi_FSumGrossWeight.AutoSize = true;
            this.label_Kuaidi_FSumGrossWeight.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Kuaidi_FSumGrossWeight.Location = new System.Drawing.Point(41, 272);
            this.label_Kuaidi_FSumGrossWeight.Name = "label_Kuaidi_FSumGrossWeight";
            this.label_Kuaidi_FSumGrossWeight.Size = new System.Drawing.Size(201, 12);
            this.label_Kuaidi_FSumGrossWeight.TabIndex = 10;
            this.label_Kuaidi_FSumGrossWeight.Text = "label_Kuaidi_FSumGrossWeight";
            // 
            // label_Kuaidi_FSumSize
            // 
            this.label_Kuaidi_FSumSize.AutoSize = true;
            this.label_Kuaidi_FSumSize.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Kuaidi_FSumSize.Location = new System.Drawing.Point(41, 237);
            this.label_Kuaidi_FSumSize.Name = "label_Kuaidi_FSumSize";
            this.label_Kuaidi_FSumSize.Size = new System.Drawing.Size(152, 12);
            this.label_Kuaidi_FSumSize.TabIndex = 9;
            this.label_Kuaidi_FSumSize.Text = "label_Kuaidi_FSumSize";
            // 
            // label_Kuaidi_Amount
            // 
            this.label_Kuaidi_Amount.AutoSize = true;
            this.label_Kuaidi_Amount.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Kuaidi_Amount.Location = new System.Drawing.Point(41, 198);
            this.label_Kuaidi_Amount.Name = "label_Kuaidi_Amount";
            this.label_Kuaidi_Amount.Size = new System.Drawing.Size(138, 12);
            this.label_Kuaidi_Amount.TabIndex = 8;
            this.label_Kuaidi_Amount.Text = "label_Kuaidi_Amount";
            // 
            // label_Receive_Phone
            // 
            this.label_Receive_Phone.AutoSize = true;
            this.label_Receive_Phone.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Receive_Phone.Location = new System.Drawing.Point(344, 152);
            this.label_Receive_Phone.Name = "label_Receive_Phone";
            this.label_Receive_Phone.Size = new System.Drawing.Size(138, 12);
            this.label_Receive_Phone.TabIndex = 7;
            this.label_Receive_Phone.Text = "label_Receive_Phone";
            // 
            // label_Receive_ToName
            // 
            this.label_Receive_ToName.AutoSize = true;
            this.label_Receive_ToName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Receive_ToName.Location = new System.Drawing.Point(344, 117);
            this.label_Receive_ToName.Name = "label_Receive_ToName";
            this.label_Receive_ToName.Size = new System.Drawing.Size(145, 12);
            this.label_Receive_ToName.TabIndex = 6;
            this.label_Receive_ToName.Text = "label_Receive_ToName";
            // 
            // label_Receive_CompanyName
            // 
            this.label_Receive_CompanyName.AutoSize = true;
            this.label_Receive_CompanyName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Receive_CompanyName.Location = new System.Drawing.Point(344, 78);
            this.label_Receive_CompanyName.Name = "label_Receive_CompanyName";
            this.label_Receive_CompanyName.Size = new System.Drawing.Size(180, 12);
            this.label_Receive_CompanyName.TabIndex = 5;
            this.label_Receive_CompanyName.Text = "label_Receive_CompanyName";
            // 
            // label_Receive_Address
            // 
            this.label_Receive_Address.AutoSize = true;
            this.label_Receive_Address.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Receive_Address.Location = new System.Drawing.Point(344, 44);
            this.label_Receive_Address.Name = "label_Receive_Address";
            this.label_Receive_Address.Size = new System.Drawing.Size(152, 12);
            this.label_Receive_Address.TabIndex = 4;
            this.label_Receive_Address.Text = "label_Receive_Address";
            // 
            // label_Send_Phone
            // 
            this.label_Send_Phone.AutoSize = true;
            this.label_Send_Phone.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Send_Phone.Location = new System.Drawing.Point(41, 152);
            this.label_Send_Phone.Name = "label_Send_Phone";
            this.label_Send_Phone.Size = new System.Drawing.Size(117, 12);
            this.label_Send_Phone.TabIndex = 3;
            this.label_Send_Phone.Text = "label_Send_Phone";
            // 
            // label_Send_FromName
            // 
            this.label_Send_FromName.AutoSize = true;
            this.label_Send_FromName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Send_FromName.Location = new System.Drawing.Point(41, 117);
            this.label_Send_FromName.Name = "label_Send_FromName";
            this.label_Send_FromName.Size = new System.Drawing.Size(138, 12);
            this.label_Send_FromName.TabIndex = 2;
            this.label_Send_FromName.Text = "label_Send_FromName";
            // 
            // label_Send_CompanyName
            // 
            this.label_Send_CompanyName.AutoSize = true;
            this.label_Send_CompanyName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Send_CompanyName.Location = new System.Drawing.Point(41, 78);
            this.label_Send_CompanyName.Name = "label_Send_CompanyName";
            this.label_Send_CompanyName.Size = new System.Drawing.Size(166, 12);
            this.label_Send_CompanyName.TabIndex = 1;
            this.label_Send_CompanyName.Text = "label1_Send_CompanyName";
            // 
            // label_Send_Address
            // 
            this.label_Send_Address.AutoSize = true;
            this.label_Send_Address.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Send_Address.Location = new System.Drawing.Point(41, 44);
            this.label_Send_Address.Name = "label_Send_Address";
            this.label_Send_Address.Size = new System.Drawing.Size(131, 12);
            this.label_Send_Address.TabIndex = 0;
            this.label_Send_Address.Text = "label_Send_Address";
            // 
            // printDialog_Kuaidi
            // 
            this.printDialog_Kuaidi.UseEXDialog = true;
            // 
            // Form_WuLiu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 520);
            this.Controls.Add(this.tabControl_WuLiu);
            this.Name = "Form_WuLiu";
            this.Text = "快递单";
            this.tabControl_WuLiu.ResumeLayout(false);
            this.tabPage_Ins.ResumeLayout(false);
            this.tabPage_Ins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KuaidiDetail)).EndInit();
            this.tabPage_Print.ResumeLayout(false);
            this.groupBox_Print.ResumeLayout(false);
            this.groupBox_Print.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button button_Mod;
		private System.Windows.Forms.TextBox textBox_ModKuaiDiID;
		private System.Windows.Forms.PrintDialog printDialog_Kuaidi;
		private System.Windows.Forms.Label label_KuaidiDetail;
		private System.Windows.Forms.Label label_Kuaidi_Amount;
		private System.Windows.Forms.Label label_Kuaidi_FSumSize;
		private System.Windows.Forms.Label label_Kuaidi_FSumGrossWeight;
		private System.Windows.Forms.Label label_Send_CompanyName;
		private System.Windows.Forms.Label label_Send_FromName;
		private System.Windows.Forms.Label label_Send_Phone;
		private System.Windows.Forms.Label label_Receive_Address;
		private System.Windows.Forms.Label label_Receive_CompanyName;
		private System.Windows.Forms.Label label_Receive_ToName;
		private System.Windows.Forms.Label label_Receive_Phone;
		private System.Drawing.Printing.PrintDocument printDocument_Kuaidi;
		private System.Windows.Forms.Label label_Send_Address;
		private System.Windows.Forms.Button button_Print_True;
		private System.Windows.Forms.Button button_SaveLayout;
		private System.Windows.Forms.GroupBox groupBox_Print;
		private System.Windows.Forms.Button button_Print;
		private System.Windows.Forms.DataGridViewTextBoxColumn FCItemID;
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
		private System.Windows.Forms.TextBox textBox_Id;
		private System.Windows.Forms.TextBox textBox_Amount;
		private System.Windows.Forms.TextBox textBox_Memo;
		private System.Windows.Forms.Label label_KuaidiTypeId;
		private System.Windows.Forms.Label label_ReceiveId;
		private System.Windows.Forms.Label label_SendId;
		private System.Windows.Forms.Label label_Id;
		private System.Windows.Forms.Label label_FItemId;
		private System.Windows.Forms.TabPage tabPage_Print;
		private System.Windows.Forms.TabPage tabPage_Ins;
		private System.Windows.Forms.TabControl tabControl_WuLiu;
	}
}
