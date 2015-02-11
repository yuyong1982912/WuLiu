/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014-03-03
 * 时间: 14:26
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WuLiu
{
	partial class Form_Receive
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
			this.tabControl_Receive = new System.Windows.Forms.TabControl();
			this.tabPage_Receive_Ins = new System.Windows.Forms.TabPage();
			this.textBox_FItemId = new System.Windows.Forms.TextBox();
			this.button_Search = new System.Windows.Forms.Button();
			this.button_Ins = new System.Windows.Forms.Button();
			this.textBox_Address = new System.Windows.Forms.TextBox();
			this.label_Address = new System.Windows.Forms.Label();
			this.textBox_Phone = new System.Windows.Forms.TextBox();
			this.label_Phone = new System.Windows.Forms.Label();
			this.textBox_ToName = new System.Windows.Forms.TextBox();
			this.label_ToName = new System.Windows.Forms.Label();
			this.textBox_CompanyName = new System.Windows.Forms.TextBox();
			this.label_CompanyName = new System.Windows.Forms.Label();
			this.listBox_FName = new System.Windows.Forms.ListBox();
			this.textBox_FName = new System.Windows.Forms.TextBox();
			this.label_FName = new System.Windows.Forms.Label();
			this.tabPage_Receive_Mod = new System.Windows.Forms.TabPage();
			this.textBox_ReceiveId = new System.Windows.Forms.TextBox();
			this.dataGridView_Mod = new System.Windows.Forms.DataGridView();
			this.textBox_FItemId_Mod = new System.Windows.Forms.TextBox();
			this.button_Search_Mod = new System.Windows.Forms.Button();
			this.button_Mod = new System.Windows.Forms.Button();
			this.textBox_Address_Mod = new System.Windows.Forms.TextBox();
			this.label_Address_Mod = new System.Windows.Forms.Label();
			this.textBox_Phone_Mod = new System.Windows.Forms.TextBox();
			this.label_Phone_Name = new System.Windows.Forms.Label();
			this.textBox_ToName_Mod = new System.Windows.Forms.TextBox();
			this.label_ToName_Mod = new System.Windows.Forms.Label();
			this.textBox_CompanyName_Mod = new System.Windows.Forms.TextBox();
			this.label_CompanyName_Mod = new System.Windows.Forms.Label();
			this.listBox_Mod = new System.Windows.Forms.ListBox();
			this.textBox_FName_Mod = new System.Windows.Forms.TextBox();
			this.label_FName_Mod = new System.Windows.Forms.Label();
			this.button_Del = new System.Windows.Forms.Button();
			this.tabControl_Receive.SuspendLayout();
			this.tabPage_Receive_Ins.SuspendLayout();
			this.tabPage_Receive_Mod.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Mod)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl_Receive
			// 
			this.tabControl_Receive.Controls.Add(this.tabPage_Receive_Ins);
			this.tabControl_Receive.Controls.Add(this.tabPage_Receive_Mod);
			this.tabControl_Receive.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl_Receive.Location = new System.Drawing.Point(0, 0);
			this.tabControl_Receive.Name = "tabControl_Receive";
			this.tabControl_Receive.SelectedIndex = 0;
			this.tabControl_Receive.Size = new System.Drawing.Size(758, 485);
			this.tabControl_Receive.TabIndex = 0;
			// 
			// tabPage_Receive_Ins
			// 
			this.tabPage_Receive_Ins.Controls.Add(this.textBox_FItemId);
			this.tabPage_Receive_Ins.Controls.Add(this.button_Search);
			this.tabPage_Receive_Ins.Controls.Add(this.button_Ins);
			this.tabPage_Receive_Ins.Controls.Add(this.textBox_Address);
			this.tabPage_Receive_Ins.Controls.Add(this.label_Address);
			this.tabPage_Receive_Ins.Controls.Add(this.textBox_Phone);
			this.tabPage_Receive_Ins.Controls.Add(this.label_Phone);
			this.tabPage_Receive_Ins.Controls.Add(this.textBox_ToName);
			this.tabPage_Receive_Ins.Controls.Add(this.label_ToName);
			this.tabPage_Receive_Ins.Controls.Add(this.textBox_CompanyName);
			this.tabPage_Receive_Ins.Controls.Add(this.label_CompanyName);
			this.tabPage_Receive_Ins.Controls.Add(this.listBox_FName);
			this.tabPage_Receive_Ins.Controls.Add(this.textBox_FName);
			this.tabPage_Receive_Ins.Controls.Add(this.label_FName);
			this.tabPage_Receive_Ins.Location = new System.Drawing.Point(4, 21);
			this.tabPage_Receive_Ins.Name = "tabPage_Receive_Ins";
			this.tabPage_Receive_Ins.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Receive_Ins.Size = new System.Drawing.Size(750, 460);
			this.tabPage_Receive_Ins.TabIndex = 0;
			this.tabPage_Receive_Ins.Text = "新建";
			this.tabPage_Receive_Ins.UseVisualStyleBackColor = true;
			// 
			// textBox_FItemId
			// 
			this.textBox_FItemId.Location = new System.Drawing.Point(92, 359);
			this.textBox_FItemId.Name = "textBox_FItemId";
			this.textBox_FItemId.Size = new System.Drawing.Size(100, 21);
			this.textBox_FItemId.TabIndex = 13;
			this.textBox_FItemId.Text = "0";
			this.textBox_FItemId.Visible = false;
			// 
			// button_Search
			// 
			this.button_Search.Location = new System.Drawing.Point(279, 28);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(75, 23);
			this.button_Search.TabIndex = 12;
			this.button_Search.Text = "查找";
			this.button_Search.UseVisualStyleBackColor = true;
			this.button_Search.Click += new System.EventHandler(this.Button_SearchClick);
			// 
			// button_Ins
			// 
			this.button_Ins.Location = new System.Drawing.Point(9, 359);
			this.button_Ins.Name = "button_Ins";
			this.button_Ins.Size = new System.Drawing.Size(75, 23);
			this.button_Ins.TabIndex = 11;
			this.button_Ins.Text = "新增";
			this.button_Ins.UseVisualStyleBackColor = true;
			this.button_Ins.Click += new System.EventHandler(this.Button_InsClick);
			// 
			// textBox_Address
			// 
			this.textBox_Address.Location = new System.Drawing.Point(92, 303);
			this.textBox_Address.Name = "textBox_Address";
			this.textBox_Address.Size = new System.Drawing.Size(425, 21);
			this.textBox_Address.TabIndex = 10;
			// 
			// label_Address
			// 
			this.label_Address.AutoSize = true;
			this.label_Address.Location = new System.Drawing.Point(9, 306);
			this.label_Address.Name = "label_Address";
			this.label_Address.Size = new System.Drawing.Size(77, 12);
			this.label_Address.TabIndex = 9;
			this.label_Address.Text = "收件人地址：";
			// 
			// textBox_Phone
			// 
			this.textBox_Phone.Location = new System.Drawing.Point(92, 264);
			this.textBox_Phone.Name = "textBox_Phone";
			this.textBox_Phone.Size = new System.Drawing.Size(425, 21);
			this.textBox_Phone.TabIndex = 8;
			// 
			// label_Phone
			// 
			this.label_Phone.AutoSize = true;
			this.label_Phone.Location = new System.Drawing.Point(9, 267);
			this.label_Phone.Name = "label_Phone";
			this.label_Phone.Size = new System.Drawing.Size(65, 12);
			this.label_Phone.TabIndex = 7;
			this.label_Phone.Text = "联系电话：";
			// 
			// textBox_ToName
			// 
			this.textBox_ToName.Location = new System.Drawing.Point(92, 227);
			this.textBox_ToName.Name = "textBox_ToName";
			this.textBox_ToName.Size = new System.Drawing.Size(425, 21);
			this.textBox_ToName.TabIndex = 6;
			// 
			// label_ToName
			// 
			this.label_ToName.AutoSize = true;
			this.label_ToName.Location = new System.Drawing.Point(9, 230);
			this.label_ToName.Name = "label_ToName";
			this.label_ToName.Size = new System.Drawing.Size(77, 12);
			this.label_ToName.TabIndex = 5;
			this.label_ToName.Text = "收件人姓名：";
			// 
			// textBox_CompanyName
			// 
			this.textBox_CompanyName.Location = new System.Drawing.Point(92, 189);
			this.textBox_CompanyName.Name = "textBox_CompanyName";
			this.textBox_CompanyName.Size = new System.Drawing.Size(425, 21);
			this.textBox_CompanyName.TabIndex = 4;
			// 
			// label_CompanyName
			// 
			this.label_CompanyName.AutoSize = true;
			this.label_CompanyName.Location = new System.Drawing.Point(9, 192);
			this.label_CompanyName.Name = "label_CompanyName";
			this.label_CompanyName.Size = new System.Drawing.Size(65, 12);
			this.label_CompanyName.TabIndex = 3;
			this.label_CompanyName.Text = "单位名称：";
			// 
			// listBox_FName
			// 
			this.listBox_FName.FormattingEnabled = true;
			this.listBox_FName.ItemHeight = 12;
			this.listBox_FName.Location = new System.Drawing.Point(8, 57);
			this.listBox_FName.Name = "listBox_FName";
			this.listBox_FName.Size = new System.Drawing.Size(734, 112);
			this.listBox_FName.TabIndex = 2;
			this.listBox_FName.SelectedIndexChanged += new System.EventHandler(this.ListBox_FNameSelectedIndexChanged);
			// 
			// textBox_FName
			// 
			this.textBox_FName.Location = new System.Drawing.Point(79, 30);
			this.textBox_FName.Name = "textBox_FName";
			this.textBox_FName.Size = new System.Drawing.Size(193, 21);
			this.textBox_FName.TabIndex = 1;
			// 
			// label_FName
			// 
			this.label_FName.AutoSize = true;
			this.label_FName.Location = new System.Drawing.Point(8, 33);
			this.label_FName.Name = "label_FName";
			this.label_FName.Size = new System.Drawing.Size(65, 12);
			this.label_FName.TabIndex = 0;
			this.label_FName.Text = "客户名称：";
			// 
			// tabPage_Receive_Mod
			// 
			this.tabPage_Receive_Mod.Controls.Add(this.button_Del);
			this.tabPage_Receive_Mod.Controls.Add(this.textBox_ReceiveId);
			this.tabPage_Receive_Mod.Controls.Add(this.dataGridView_Mod);
			this.tabPage_Receive_Mod.Controls.Add(this.textBox_FItemId_Mod);
			this.tabPage_Receive_Mod.Controls.Add(this.button_Search_Mod);
			this.tabPage_Receive_Mod.Controls.Add(this.button_Mod);
			this.tabPage_Receive_Mod.Controls.Add(this.textBox_Address_Mod);
			this.tabPage_Receive_Mod.Controls.Add(this.label_Address_Mod);
			this.tabPage_Receive_Mod.Controls.Add(this.textBox_Phone_Mod);
			this.tabPage_Receive_Mod.Controls.Add(this.label_Phone_Name);
			this.tabPage_Receive_Mod.Controls.Add(this.textBox_ToName_Mod);
			this.tabPage_Receive_Mod.Controls.Add(this.label_ToName_Mod);
			this.tabPage_Receive_Mod.Controls.Add(this.textBox_CompanyName_Mod);
			this.tabPage_Receive_Mod.Controls.Add(this.label_CompanyName_Mod);
			this.tabPage_Receive_Mod.Controls.Add(this.listBox_Mod);
			this.tabPage_Receive_Mod.Controls.Add(this.textBox_FName_Mod);
			this.tabPage_Receive_Mod.Controls.Add(this.label_FName_Mod);
			this.tabPage_Receive_Mod.Location = new System.Drawing.Point(4, 21);
			this.tabPage_Receive_Mod.Name = "tabPage_Receive_Mod";
			this.tabPage_Receive_Mod.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Receive_Mod.Size = new System.Drawing.Size(750, 460);
			this.tabPage_Receive_Mod.TabIndex = 1;
			this.tabPage_Receive_Mod.Text = "修改";
			this.tabPage_Receive_Mod.UseVisualStyleBackColor = true;
			// 
			// textBox_ReceiveId
			// 
			this.textBox_ReceiveId.Location = new System.Drawing.Point(280, 429);
			this.textBox_ReceiveId.Name = "textBox_ReceiveId";
			this.textBox_ReceiveId.Size = new System.Drawing.Size(100, 21);
			this.textBox_ReceiveId.TabIndex = 29;
			this.textBox_ReceiveId.Visible = false;
			// 
			// dataGridView_Mod
			// 
			this.dataGridView_Mod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Mod.Location = new System.Drawing.Point(10, 170);
			this.dataGridView_Mod.Name = "dataGridView_Mod";
			this.dataGridView_Mod.RowTemplate.Height = 23;
			this.dataGridView_Mod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Mod.Size = new System.Drawing.Size(732, 113);
			this.dataGridView_Mod.TabIndex = 28;
			this.dataGridView_Mod.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ModCellClick);
			// 
			// textBox_FItemId_Mod
			// 
			this.textBox_FItemId_Mod.Location = new System.Drawing.Point(174, 429);
			this.textBox_FItemId_Mod.Name = "textBox_FItemId_Mod";
			this.textBox_FItemId_Mod.Size = new System.Drawing.Size(100, 21);
			this.textBox_FItemId_Mod.TabIndex = 27;
			this.textBox_FItemId_Mod.Visible = false;
			// 
			// button_Search_Mod
			// 
			this.button_Search_Mod.Location = new System.Drawing.Point(279, 22);
			this.button_Search_Mod.Name = "button_Search_Mod";
			this.button_Search_Mod.Size = new System.Drawing.Size(75, 23);
			this.button_Search_Mod.TabIndex = 26;
			this.button_Search_Mod.Text = "查找";
			this.button_Search_Mod.UseVisualStyleBackColor = true;
			this.button_Search_Mod.Click += new System.EventHandler(this.Button_Search_ModClick);
			// 
			// button_Mod
			// 
			this.button_Mod.Location = new System.Drawing.Point(10, 430);
			this.button_Mod.Name = "button_Mod";
			this.button_Mod.Size = new System.Drawing.Size(75, 23);
			this.button_Mod.TabIndex = 25;
			this.button_Mod.Text = "修改";
			this.button_Mod.UseVisualStyleBackColor = true;
			this.button_Mod.Click += new System.EventHandler(this.Button_ModClick);
			// 
			// textBox_Address_Mod
			// 
			this.textBox_Address_Mod.Location = new System.Drawing.Point(93, 403);
			this.textBox_Address_Mod.Name = "textBox_Address_Mod";
			this.textBox_Address_Mod.Size = new System.Drawing.Size(425, 21);
			this.textBox_Address_Mod.TabIndex = 24;
			// 
			// label_Address_Mod
			// 
			this.label_Address_Mod.AutoSize = true;
			this.label_Address_Mod.Location = new System.Drawing.Point(10, 406);
			this.label_Address_Mod.Name = "label_Address_Mod";
			this.label_Address_Mod.Size = new System.Drawing.Size(77, 12);
			this.label_Address_Mod.TabIndex = 23;
			this.label_Address_Mod.Text = "收件人地址：";
			// 
			// textBox_Phone_Mod
			// 
			this.textBox_Phone_Mod.Location = new System.Drawing.Point(93, 364);
			this.textBox_Phone_Mod.Name = "textBox_Phone_Mod";
			this.textBox_Phone_Mod.Size = new System.Drawing.Size(425, 21);
			this.textBox_Phone_Mod.TabIndex = 22;
			// 
			// label_Phone_Name
			// 
			this.label_Phone_Name.AutoSize = true;
			this.label_Phone_Name.Location = new System.Drawing.Point(10, 367);
			this.label_Phone_Name.Name = "label_Phone_Name";
			this.label_Phone_Name.Size = new System.Drawing.Size(65, 12);
			this.label_Phone_Name.TabIndex = 21;
			this.label_Phone_Name.Text = "联系电话：";
			// 
			// textBox_ToName_Mod
			// 
			this.textBox_ToName_Mod.Location = new System.Drawing.Point(93, 327);
			this.textBox_ToName_Mod.Name = "textBox_ToName_Mod";
			this.textBox_ToName_Mod.Size = new System.Drawing.Size(425, 21);
			this.textBox_ToName_Mod.TabIndex = 20;
			// 
			// label_ToName_Mod
			// 
			this.label_ToName_Mod.AutoSize = true;
			this.label_ToName_Mod.Location = new System.Drawing.Point(10, 330);
			this.label_ToName_Mod.Name = "label_ToName_Mod";
			this.label_ToName_Mod.Size = new System.Drawing.Size(77, 12);
			this.label_ToName_Mod.TabIndex = 19;
			this.label_ToName_Mod.Text = "收件人姓名：";
			// 
			// textBox_CompanyName_Mod
			// 
			this.textBox_CompanyName_Mod.Location = new System.Drawing.Point(93, 289);
			this.textBox_CompanyName_Mod.Name = "textBox_CompanyName_Mod";
			this.textBox_CompanyName_Mod.Size = new System.Drawing.Size(425, 21);
			this.textBox_CompanyName_Mod.TabIndex = 18;
			// 
			// label_CompanyName_Mod
			// 
			this.label_CompanyName_Mod.AutoSize = true;
			this.label_CompanyName_Mod.Location = new System.Drawing.Point(10, 292);
			this.label_CompanyName_Mod.Name = "label_CompanyName_Mod";
			this.label_CompanyName_Mod.Size = new System.Drawing.Size(65, 12);
			this.label_CompanyName_Mod.TabIndex = 17;
			this.label_CompanyName_Mod.Text = "单位名称：";
			// 
			// listBox_Mod
			// 
			this.listBox_Mod.FormattingEnabled = true;
			this.listBox_Mod.ItemHeight = 12;
			this.listBox_Mod.Location = new System.Drawing.Point(8, 51);
			this.listBox_Mod.Name = "listBox_Mod";
			this.listBox_Mod.Size = new System.Drawing.Size(734, 112);
			this.listBox_Mod.TabIndex = 16;
			this.listBox_Mod.Click += new System.EventHandler(this.ListBox_ModClick);
			// 
			// textBox_FName_Mod
			// 
			this.textBox_FName_Mod.Location = new System.Drawing.Point(79, 24);
			this.textBox_FName_Mod.Name = "textBox_FName_Mod";
			this.textBox_FName_Mod.Size = new System.Drawing.Size(193, 21);
			this.textBox_FName_Mod.TabIndex = 15;
			// 
			// label_FName_Mod
			// 
			this.label_FName_Mod.AutoSize = true;
			this.label_FName_Mod.Location = new System.Drawing.Point(8, 27);
			this.label_FName_Mod.Name = "label_FName_Mod";
			this.label_FName_Mod.Size = new System.Drawing.Size(65, 12);
			this.label_FName_Mod.TabIndex = 14;
			this.label_FName_Mod.Text = "客户名称：";
			// 
			// button_Del
			// 
			this.button_Del.Location = new System.Drawing.Point(91, 429);
			this.button_Del.Name = "button_Del";
			this.button_Del.Size = new System.Drawing.Size(75, 23);
			this.button_Del.TabIndex = 30;
			this.button_Del.Text = "删除";
			this.button_Del.UseVisualStyleBackColor = true;
			this.button_Del.Click += new System.EventHandler(this.Button_DelClick);
			// 
			// Form_Receive
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 485);
			this.Controls.Add(this.tabControl_Receive);
			this.Name = "Form_Receive";
			this.Text = "收件人信息";
			this.tabControl_Receive.ResumeLayout(false);
			this.tabPage_Receive_Ins.ResumeLayout(false);
			this.tabPage_Receive_Ins.PerformLayout();
			this.tabPage_Receive_Mod.ResumeLayout(false);
			this.tabPage_Receive_Mod.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Mod)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button_Del;
		private System.Windows.Forms.TextBox textBox_ReceiveId;
		private System.Windows.Forms.Label label_FName_Mod;
		private System.Windows.Forms.TextBox textBox_FName_Mod;
		private System.Windows.Forms.ListBox listBox_Mod;
		private System.Windows.Forms.Label label_CompanyName_Mod;
		private System.Windows.Forms.TextBox textBox_CompanyName_Mod;
		private System.Windows.Forms.Label label_ToName_Mod;
		private System.Windows.Forms.TextBox textBox_ToName_Mod;
		private System.Windows.Forms.Label label_Phone_Name;
		private System.Windows.Forms.TextBox textBox_Phone_Mod;
		private System.Windows.Forms.Label label_Address_Mod;
		private System.Windows.Forms.TextBox textBox_Address_Mod;
		private System.Windows.Forms.Button button_Mod;
		private System.Windows.Forms.Button button_Search_Mod;
		private System.Windows.Forms.TextBox textBox_FItemId_Mod;
		private System.Windows.Forms.DataGridView dataGridView_Mod;
		private System.Windows.Forms.TextBox textBox_FItemId;
		private System.Windows.Forms.Button button_Search;
		private System.Windows.Forms.Button button_Ins;
		private System.Windows.Forms.Label label_FName;
		private System.Windows.Forms.TextBox textBox_FName;
		private System.Windows.Forms.ListBox listBox_FName;
		private System.Windows.Forms.Label label_CompanyName;
		private System.Windows.Forms.TextBox textBox_CompanyName;
		private System.Windows.Forms.Label label_ToName;
		private System.Windows.Forms.TextBox textBox_ToName;
		private System.Windows.Forms.Label label_Phone;
		private System.Windows.Forms.TextBox textBox_Phone;
		private System.Windows.Forms.Label label_Address;
		private System.Windows.Forms.TextBox textBox_Address;
		private System.Windows.Forms.TabPage tabPage_Receive_Mod;
		private System.Windows.Forms.TabPage tabPage_Receive_Ins;
		private System.Windows.Forms.TabControl tabControl_Receive;
	}
}
