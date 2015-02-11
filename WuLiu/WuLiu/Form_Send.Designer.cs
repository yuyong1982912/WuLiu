/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014-02-28
 * 时间: 17:34
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WuLiu
{
	partial class Form_Send
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
			this.tabControl_Send = new System.Windows.Forms.TabControl();
			this.tabPage_Ins = new System.Windows.Forms.TabPage();
			this.button_Ins = new System.Windows.Forms.Button();
			this.label_Adress = new System.Windows.Forms.Label();
			this.textBox_Address = new System.Windows.Forms.TextBox();
			this.label_Phone = new System.Windows.Forms.Label();
			this.textBox_Phone = new System.Windows.Forms.TextBox();
			this.label_FromName = new System.Windows.Forms.Label();
			this.textBox_FromName = new System.Windows.Forms.TextBox();
			this.label_CompanyName = new System.Windows.Forms.Label();
			this.textBox_CompanyName = new System.Windows.Forms.TextBox();
			this.tabPage_Mod = new System.Windows.Forms.TabPage();
			this.textBox_SendId = new System.Windows.Forms.TextBox();
			this.button_Mod = new System.Windows.Forms.Button();
			this.label_Address_Mod = new System.Windows.Forms.Label();
			this.textBox_Address_Mod = new System.Windows.Forms.TextBox();
			this.label_Phone_Mod = new System.Windows.Forms.Label();
			this.textBox_Phone_Mod = new System.Windows.Forms.TextBox();
			this.label_FromName_Mod = new System.Windows.Forms.Label();
			this.textBox_FromName_Mod = new System.Windows.Forms.TextBox();
			this.label_Company_Mod = new System.Windows.Forms.Label();
			this.textBox_Company_Mod = new System.Windows.Forms.TextBox();
			this.dataGridView_Send = new System.Windows.Forms.DataGridView();
			this.tabControl_Send.SuspendLayout();
			this.tabPage_Ins.SuspendLayout();
			this.tabPage_Mod.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Send)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl_Send
			// 
			this.tabControl_Send.Controls.Add(this.tabPage_Ins);
			this.tabControl_Send.Controls.Add(this.tabPage_Mod);
			this.tabControl_Send.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl_Send.Location = new System.Drawing.Point(0, 0);
			this.tabControl_Send.Name = "tabControl_Send";
			this.tabControl_Send.SelectedIndex = 0;
			this.tabControl_Send.Size = new System.Drawing.Size(501, 338);
			this.tabControl_Send.TabIndex = 0;
			// 
			// tabPage_Ins
			// 
			this.tabPage_Ins.Controls.Add(this.button_Ins);
			this.tabPage_Ins.Controls.Add(this.label_Adress);
			this.tabPage_Ins.Controls.Add(this.textBox_Address);
			this.tabPage_Ins.Controls.Add(this.label_Phone);
			this.tabPage_Ins.Controls.Add(this.textBox_Phone);
			this.tabPage_Ins.Controls.Add(this.label_FromName);
			this.tabPage_Ins.Controls.Add(this.textBox_FromName);
			this.tabPage_Ins.Controls.Add(this.label_CompanyName);
			this.tabPage_Ins.Controls.Add(this.textBox_CompanyName);
			this.tabPage_Ins.Location = new System.Drawing.Point(4, 21);
			this.tabPage_Ins.Name = "tabPage_Ins";
			this.tabPage_Ins.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Ins.Size = new System.Drawing.Size(493, 313);
			this.tabPage_Ins.TabIndex = 0;
			this.tabPage_Ins.Text = "新增";
			this.tabPage_Ins.UseVisualStyleBackColor = true;
			// 
			// button_Ins
			// 
			this.button_Ins.Location = new System.Drawing.Point(31, 168);
			this.button_Ins.Name = "button_Ins";
			this.button_Ins.Size = new System.Drawing.Size(75, 23);
			this.button_Ins.TabIndex = 8;
			this.button_Ins.Text = "新增";
			this.button_Ins.UseVisualStyleBackColor = true;
			this.button_Ins.Click += new System.EventHandler(this.Button_InsClick);
			// 
			// label_Adress
			// 
			this.label_Adress.AutoSize = true;
			this.label_Adress.Location = new System.Drawing.Point(31, 128);
			this.label_Adress.Name = "label_Adress";
			this.label_Adress.Size = new System.Drawing.Size(65, 12);
			this.label_Adress.TabIndex = 7;
			this.label_Adress.Text = "寄件地址：";
			// 
			// textBox_Address
			// 
			this.textBox_Address.Location = new System.Drawing.Point(116, 125);
			this.textBox_Address.Name = "textBox_Address";
			this.textBox_Address.Size = new System.Drawing.Size(352, 21);
			this.textBox_Address.TabIndex = 6;
			// 
			// label_Phone
			// 
			this.label_Phone.AutoSize = true;
			this.label_Phone.Location = new System.Drawing.Point(31, 89);
			this.label_Phone.Name = "label_Phone";
			this.label_Phone.Size = new System.Drawing.Size(65, 12);
			this.label_Phone.TabIndex = 5;
			this.label_Phone.Text = "联系电话：";
			// 
			// textBox_Phone
			// 
			this.textBox_Phone.Location = new System.Drawing.Point(116, 86);
			this.textBox_Phone.Name = "textBox_Phone";
			this.textBox_Phone.Size = new System.Drawing.Size(352, 21);
			this.textBox_Phone.TabIndex = 4;
			// 
			// label_FromName
			// 
			this.label_FromName.AutoSize = true;
			this.label_FromName.Location = new System.Drawing.Point(31, 51);
			this.label_FromName.Name = "label_FromName";
			this.label_FromName.Size = new System.Drawing.Size(77, 12);
			this.label_FromName.TabIndex = 3;
			this.label_FromName.Text = "寄件人姓名：";
			// 
			// textBox_FromName
			// 
			this.textBox_FromName.Location = new System.Drawing.Point(116, 48);
			this.textBox_FromName.Name = "textBox_FromName";
			this.textBox_FromName.Size = new System.Drawing.Size(352, 21);
			this.textBox_FromName.TabIndex = 2;
			// 
			// label_CompanyName
			// 
			this.label_CompanyName.AutoSize = true;
			this.label_CompanyName.Location = new System.Drawing.Point(31, 15);
			this.label_CompanyName.Name = "label_CompanyName";
			this.label_CompanyName.Size = new System.Drawing.Size(65, 12);
			this.label_CompanyName.TabIndex = 1;
			this.label_CompanyName.Text = "单位名称：";
			// 
			// textBox_CompanyName
			// 
			this.textBox_CompanyName.Location = new System.Drawing.Point(116, 12);
			this.textBox_CompanyName.Name = "textBox_CompanyName";
			this.textBox_CompanyName.Size = new System.Drawing.Size(352, 21);
			this.textBox_CompanyName.TabIndex = 0;
			// 
			// tabPage_Mod
			// 
			this.tabPage_Mod.Controls.Add(this.textBox_SendId);
			this.tabPage_Mod.Controls.Add(this.button_Mod);
			this.tabPage_Mod.Controls.Add(this.label_Address_Mod);
			this.tabPage_Mod.Controls.Add(this.textBox_Address_Mod);
			this.tabPage_Mod.Controls.Add(this.label_Phone_Mod);
			this.tabPage_Mod.Controls.Add(this.textBox_Phone_Mod);
			this.tabPage_Mod.Controls.Add(this.label_FromName_Mod);
			this.tabPage_Mod.Controls.Add(this.textBox_FromName_Mod);
			this.tabPage_Mod.Controls.Add(this.label_Company_Mod);
			this.tabPage_Mod.Controls.Add(this.textBox_Company_Mod);
			this.tabPage_Mod.Controls.Add(this.dataGridView_Send);
			this.tabPage_Mod.Location = new System.Drawing.Point(4, 21);
			this.tabPage_Mod.Name = "tabPage_Mod";
			this.tabPage_Mod.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Mod.Size = new System.Drawing.Size(493, 313);
			this.tabPage_Mod.TabIndex = 1;
			this.tabPage_Mod.Text = "修改";
			this.tabPage_Mod.UseVisualStyleBackColor = true;
			this.tabPage_Mod.Enter += new System.EventHandler(this.TabPage_ModEnter);
			// 
			// textBox_SendId
			// 
			this.textBox_SendId.Enabled = false;
			this.textBox_SendId.Location = new System.Drawing.Point(28, 289);
			this.textBox_SendId.Name = "textBox_SendId";
			this.textBox_SendId.Size = new System.Drawing.Size(79, 21);
			this.textBox_SendId.TabIndex = 18;
			this.textBox_SendId.Visible = false;
			// 
			// button_Mod
			// 
			this.button_Mod.Location = new System.Drawing.Point(113, 287);
			this.button_Mod.Name = "button_Mod";
			this.button_Mod.Size = new System.Drawing.Size(75, 23);
			this.button_Mod.TabIndex = 17;
			this.button_Mod.Text = "修改";
			this.button_Mod.UseVisualStyleBackColor = true;
			this.button_Mod.Click += new System.EventHandler(this.Button_ModClick);
			// 
			// label_Address_Mod
			// 
			this.label_Address_Mod.AutoSize = true;
			this.label_Address_Mod.Location = new System.Drawing.Point(28, 247);
			this.label_Address_Mod.Name = "label_Address_Mod";
			this.label_Address_Mod.Size = new System.Drawing.Size(65, 12);
			this.label_Address_Mod.TabIndex = 16;
			this.label_Address_Mod.Text = "寄件地址：";
			// 
			// textBox_Address_Mod
			// 
			this.textBox_Address_Mod.Location = new System.Drawing.Point(113, 244);
			this.textBox_Address_Mod.Name = "textBox_Address_Mod";
			this.textBox_Address_Mod.Size = new System.Drawing.Size(352, 21);
			this.textBox_Address_Mod.TabIndex = 15;
			// 
			// label_Phone_Mod
			// 
			this.label_Phone_Mod.AutoSize = true;
			this.label_Phone_Mod.Location = new System.Drawing.Point(28, 208);
			this.label_Phone_Mod.Name = "label_Phone_Mod";
			this.label_Phone_Mod.Size = new System.Drawing.Size(65, 12);
			this.label_Phone_Mod.TabIndex = 14;
			this.label_Phone_Mod.Text = "联系电话：";
			// 
			// textBox_Phone_Mod
			// 
			this.textBox_Phone_Mod.Location = new System.Drawing.Point(113, 205);
			this.textBox_Phone_Mod.Name = "textBox_Phone_Mod";
			this.textBox_Phone_Mod.Size = new System.Drawing.Size(352, 21);
			this.textBox_Phone_Mod.TabIndex = 13;
			// 
			// label_FromName_Mod
			// 
			this.label_FromName_Mod.AutoSize = true;
			this.label_FromName_Mod.Location = new System.Drawing.Point(28, 170);
			this.label_FromName_Mod.Name = "label_FromName_Mod";
			this.label_FromName_Mod.Size = new System.Drawing.Size(77, 12);
			this.label_FromName_Mod.TabIndex = 12;
			this.label_FromName_Mod.Text = "寄件人姓名：";
			// 
			// textBox_FromName_Mod
			// 
			this.textBox_FromName_Mod.Location = new System.Drawing.Point(113, 167);
			this.textBox_FromName_Mod.Name = "textBox_FromName_Mod";
			this.textBox_FromName_Mod.Size = new System.Drawing.Size(352, 21);
			this.textBox_FromName_Mod.TabIndex = 11;
			// 
			// label_Company_Mod
			// 
			this.label_Company_Mod.AutoSize = true;
			this.label_Company_Mod.Location = new System.Drawing.Point(28, 134);
			this.label_Company_Mod.Name = "label_Company_Mod";
			this.label_Company_Mod.Size = new System.Drawing.Size(65, 12);
			this.label_Company_Mod.TabIndex = 10;
			this.label_Company_Mod.Text = "单位名称：";
			// 
			// textBox_Company_Mod
			// 
			this.textBox_Company_Mod.Location = new System.Drawing.Point(113, 131);
			this.textBox_Company_Mod.Name = "textBox_Company_Mod";
			this.textBox_Company_Mod.Size = new System.Drawing.Size(352, 21);
			this.textBox_Company_Mod.TabIndex = 9;
			// 
			// dataGridView_Send
			// 
			this.dataGridView_Send.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Send.Location = new System.Drawing.Point(3, 3);
			this.dataGridView_Send.Name = "dataGridView_Send";
			this.dataGridView_Send.RowTemplate.Height = 23;
			this.dataGridView_Send.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Send.Size = new System.Drawing.Size(482, 112);
			this.dataGridView_Send.TabIndex = 0;
			this.dataGridView_Send.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_SendCellClick);
			// 
			// Form_Send
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 338);
			this.Controls.Add(this.tabControl_Send);
			this.Name = "Form_Send";
			this.Text = "发件人信息";
			this.tabControl_Send.ResumeLayout(false);
			this.tabPage_Ins.ResumeLayout(false);
			this.tabPage_Ins.PerformLayout();
			this.tabPage_Mod.ResumeLayout(false);
			this.tabPage_Mod.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Send)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView dataGridView_Send;
		private System.Windows.Forms.TextBox textBox_Company_Mod;
		private System.Windows.Forms.Label label_Company_Mod;
		private System.Windows.Forms.TextBox textBox_FromName_Mod;
		private System.Windows.Forms.Label label_FromName_Mod;
		private System.Windows.Forms.TextBox textBox_Phone_Mod;
		private System.Windows.Forms.Label label_Phone_Mod;
		private System.Windows.Forms.TextBox textBox_Address_Mod;
		private System.Windows.Forms.Label label_Address_Mod;
		private System.Windows.Forms.Button button_Mod;
		private System.Windows.Forms.TextBox textBox_SendId;
		private System.Windows.Forms.TabPage tabPage_Mod;
		private System.Windows.Forms.TextBox textBox_CompanyName;
		private System.Windows.Forms.Label label_CompanyName;
		private System.Windows.Forms.TextBox textBox_FromName;
		private System.Windows.Forms.Label label_FromName;
		private System.Windows.Forms.TextBox textBox_Phone;
		private System.Windows.Forms.Label label_Phone;
		private System.Windows.Forms.TextBox textBox_Address;
		private System.Windows.Forms.Label label_Adress;
		private System.Windows.Forms.Button button_Ins;
		private System.Windows.Forms.TabPage tabPage_Ins;
		private System.Windows.Forms.TabControl tabControl_Send;
	}
}
