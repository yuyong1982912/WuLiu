/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2014/3/13
 * Time: 21:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WuLiu
{
	partial class Form_Search
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView_Search = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip_Del = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).BeginInit();
			this.contextMenuStrip_Del.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView_Search
			// 
			this.dataGridView_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Search.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_Search.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_Search.Name = "dataGridView_Search";
			this.dataGridView_Search.RowTemplate.Height = 23;
			this.dataGridView_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Search.Size = new System.Drawing.Size(531, 317);
			this.dataGridView_Search.TabIndex = 0;
			this.dataGridView_Search.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_SearchCellMouseDown);
			// 
			// contextMenuStrip_Del
			// 
			this.contextMenuStrip_Del.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.删除ToolStripMenuItem});
			this.contextMenuStrip_Del.Name = "contextMenuStrip_Del";
			this.contextMenuStrip_Del.Size = new System.Drawing.Size(153, 48);			
			// 
			// 删除ToolStripMenuItem
			// 
			this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
			this.删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.删除ToolStripMenuItem.Text = "删除";
			this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItemClick);
			// 
			// Form_Search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 317);
			this.Controls.Add(this.dataGridView_Search);
			this.Name = "Form_Search";
			this.Text = "查找";
			this.Load += new System.EventHandler(this.Form_SearchLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).EndInit();
			this.contextMenuStrip_Del.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Del;
		private System.Windows.Forms.DataGridView dataGridView_Search;
	}
}
