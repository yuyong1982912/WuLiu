/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014-02-28
 * 时间: 12:56
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WuLiu
{
	partial class Form_KuaidiType
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
			this.textBox_Name_Ins = new System.Windows.Forms.TextBox();
			this.label_Name = new System.Windows.Forms.Label();
			this.button_Ins = new System.Windows.Forms.Button();
			this.listBox_Name = new System.Windows.Forms.ListBox();
			this.tabControl_Name = new System.Windows.Forms.TabControl();
			this.tabPage_Ins = new System.Windows.Forms.TabPage();
			this.tabPage_Mod = new System.Windows.Forms.TabPage();
			this.textBox_Name_Mod = new System.Windows.Forms.TextBox();
			this.button_Mod = new System.Windows.Forms.Button();
			this.tabControl_Name.SuspendLayout();
			this.tabPage_Ins.SuspendLayout();
			this.tabPage_Mod.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox_Name_Ins
			// 
			this.textBox_Name_Ins.Location = new System.Drawing.Point(71, 55);
			this.textBox_Name_Ins.Name = "textBox_Name_Ins";
			this.textBox_Name_Ins.Size = new System.Drawing.Size(129, 21);
			this.textBox_Name_Ins.TabIndex = 0;
			// 
			// label_Name
			// 
			this.label_Name.AutoSize = true;
			this.label_Name.Location = new System.Drawing.Point(0, 58);
			this.label_Name.Name = "label_Name";
			this.label_Name.Size = new System.Drawing.Size(65, 12);
			this.label_Name.TabIndex = 1;
			this.label_Name.Text = "快递名称：";
			// 
			// button_Ins
			// 
			this.button_Ins.Location = new System.Drawing.Point(8, 97);
			this.button_Ins.Name = "button_Ins";
			this.button_Ins.Size = new System.Drawing.Size(75, 23);
			this.button_Ins.TabIndex = 2;
			this.button_Ins.Text = "新增";
			this.button_Ins.UseVisualStyleBackColor = true;
			this.button_Ins.Click += new System.EventHandler(this.Button_InsClick);
			// 
			// listBox_Name
			// 
			this.listBox_Name.FormattingEnabled = true;
			this.listBox_Name.ItemHeight = 12;
			this.listBox_Name.Location = new System.Drawing.Point(8, 6);
			this.listBox_Name.Name = "listBox_Name";
			this.listBox_Name.Size = new System.Drawing.Size(120, 148);
			this.listBox_Name.TabIndex = 3;
			this.listBox_Name.SelectedIndexChanged += new System.EventHandler(this.ListBox_NameSelectedIndexChanged);
			// 
			// tabControl_Name
			// 
			this.tabControl_Name.Controls.Add(this.tabPage_Ins);
			this.tabControl_Name.Controls.Add(this.tabPage_Mod);
			this.tabControl_Name.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl_Name.Location = new System.Drawing.Point(0, 0);
			this.tabControl_Name.Name = "tabControl_Name";
			this.tabControl_Name.SelectedIndex = 0;
			this.tabControl_Name.Size = new System.Drawing.Size(343, 183);
			this.tabControl_Name.TabIndex = 4;
			// 
			// tabPage_Ins
			// 
			this.tabPage_Ins.Controls.Add(this.button_Ins);
			this.tabPage_Ins.Controls.Add(this.label_Name);
			this.tabPage_Ins.Controls.Add(this.textBox_Name_Ins);
			this.tabPage_Ins.Location = new System.Drawing.Point(4, 21);
			this.tabPage_Ins.Name = "tabPage_Ins";
			this.tabPage_Ins.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Ins.Size = new System.Drawing.Size(335, 158);
			this.tabPage_Ins.TabIndex = 0;
			this.tabPage_Ins.Text = "新增";
			this.tabPage_Ins.UseVisualStyleBackColor = true;
			// 
			// tabPage_Mod
			// 
			this.tabPage_Mod.Controls.Add(this.textBox_Name_Mod);
			this.tabPage_Mod.Controls.Add(this.button_Mod);
			this.tabPage_Mod.Controls.Add(this.listBox_Name);
			this.tabPage_Mod.Location = new System.Drawing.Point(4, 21);
			this.tabPage_Mod.Name = "tabPage_Mod";
			this.tabPage_Mod.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Mod.Size = new System.Drawing.Size(335, 158);
			this.tabPage_Mod.TabIndex = 1;
			this.tabPage_Mod.Text = "修改";
			this.tabPage_Mod.UseVisualStyleBackColor = true;
			this.tabPage_Mod.Enter += new System.EventHandler(this.TabPage_ModEnter);
			// 
			// textBox_Name_Mod
			// 
			this.textBox_Name_Mod.Location = new System.Drawing.Point(157, 7);
			this.textBox_Name_Mod.Name = "textBox_Name_Mod";
			this.textBox_Name_Mod.Size = new System.Drawing.Size(170, 21);
			this.textBox_Name_Mod.TabIndex = 5;
			// 
			// button_Mod
			// 
			this.button_Mod.Location = new System.Drawing.Point(157, 127);
			this.button_Mod.Name = "button_Mod";
			this.button_Mod.Size = new System.Drawing.Size(75, 23);
			this.button_Mod.TabIndex = 4;
			this.button_Mod.Text = "修改";
			this.button_Mod.UseVisualStyleBackColor = true;
			this.button_Mod.Click += new System.EventHandler(this.Button_ModClick);
			// 
			// Form_KuaidiType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 183);
			this.Controls.Add(this.tabControl_Name);
			this.Name = "Form_KuaidiType";
			this.Text = "快递单类型";
			this.tabControl_Name.ResumeLayout(false);
			this.tabPage_Ins.ResumeLayout(false);
			this.tabPage_Ins.PerformLayout();
			this.tabPage_Mod.ResumeLayout(false);
			this.tabPage_Mod.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button_Mod;
		private System.Windows.Forms.TextBox textBox_Name_Mod;
		private System.Windows.Forms.TabPage tabPage_Mod;
		private System.Windows.Forms.TabPage tabPage_Ins;
		private System.Windows.Forms.TabControl tabControl_Name;
		private System.Windows.Forms.ListBox listBox_Name;
		private System.Windows.Forms.Button button_Ins;
		private System.Windows.Forms.Label label_Name;
		private System.Windows.Forms.TextBox textBox_Name_Ins;
	}
}
