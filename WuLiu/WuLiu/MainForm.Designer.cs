/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014-02-28
 * 时间: 9:32
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace WuLiu
{
	partial class Form_Main
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
			this.Menu_Main = new System.Windows.Forms.MenuStrip();
			this.基础资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.快递单类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.收件人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.发件人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.快递操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.快递单打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Menu_Main.SuspendLayout();
			this.SuspendLayout();
			// 
			// Menu_Main
			// 
			this.Menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.基础资料ToolStripMenuItem,
									this.快递操作ToolStripMenuItem});
			this.Menu_Main.Location = new System.Drawing.Point(0, 0);
			this.Menu_Main.Name = "Menu_Main";
			this.Menu_Main.Size = new System.Drawing.Size(765, 24);
			this.Menu_Main.TabIndex = 1;
			this.Menu_Main.Text = "menuStrip1";
			// 
			// 基础资料ToolStripMenuItem
			// 
			this.基础资料ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.快递单类型ToolStripMenuItem,
									this.收件人信息ToolStripMenuItem,
									this.发件人信息ToolStripMenuItem});
			this.基础资料ToolStripMenuItem.Name = "基础资料ToolStripMenuItem";
			this.基础资料ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.基础资料ToolStripMenuItem.Text = "基础资料";
			// 
			// 快递单类型ToolStripMenuItem
			// 
			this.快递单类型ToolStripMenuItem.Name = "快递单类型ToolStripMenuItem";
			this.快递单类型ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.快递单类型ToolStripMenuItem.Text = "快递单类型";
			this.快递单类型ToolStripMenuItem.Click += new System.EventHandler(this.快递单类型ToolStripMenuItemClick);
			// 
			// 收件人信息ToolStripMenuItem
			// 
			this.收件人信息ToolStripMenuItem.Name = "收件人信息ToolStripMenuItem";
			this.收件人信息ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.收件人信息ToolStripMenuItem.Text = "收件人信息";
			this.收件人信息ToolStripMenuItem.Click += new System.EventHandler(this.收件人信息ToolStripMenuItemClick);
			// 
			// 发件人信息ToolStripMenuItem
			// 
			this.发件人信息ToolStripMenuItem.Name = "发件人信息ToolStripMenuItem";
			this.发件人信息ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.发件人信息ToolStripMenuItem.Text = "发件人信息";
			this.发件人信息ToolStripMenuItem.Click += new System.EventHandler(this.发件人信息ToolStripMenuItemClick);
			// 
			// 快递操作ToolStripMenuItem
			// 
			this.快递操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.快递单打印ToolStripMenuItem});
			this.快递操作ToolStripMenuItem.Name = "快递操作ToolStripMenuItem";
			this.快递操作ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.快递操作ToolStripMenuItem.Text = "快递操作";
			// 
			// 快递单打印ToolStripMenuItem
			// 
			this.快递单打印ToolStripMenuItem.Name = "快递单打印ToolStripMenuItem";
			this.快递单打印ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.快递单打印ToolStripMenuItem.Text = "快递单打印";
			this.快递单打印ToolStripMenuItem.Click += new System.EventHandler(this.快递单打印ToolStripMenuItemClick);
			// 
			// Form_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 475);
			this.Controls.Add(this.Menu_Main);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.Menu_Main;
			this.Name = "Form_Main";
			this.Text = "物流";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Menu_Main.ResumeLayout(false);
			this.Menu_Main.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem 快递单打印ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 快递操作ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 发件人信息ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 快递单类型ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 收件人信息ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 基础资料ToolStripMenuItem;
		private System.Windows.Forms.MenuStrip Menu_Main;
	}
}
