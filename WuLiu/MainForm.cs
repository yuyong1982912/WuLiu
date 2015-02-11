/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014-02-28
 * 时间: 9:32
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WuLiu
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Form_Main : Form
	{
		public Form_Main()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void 快递单类型ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form_KuaidiType form_KuaidiType=new Form_KuaidiType();
			form_KuaidiType.MdiParent=this;
			form_KuaidiType.Show();
		}
		
		void 发件人信息ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form_Send form_Send=new Form_Send();
			form_Send.MdiParent=this;
			form_Send.Show();
		}
		
		void 收件人信息ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form_Receive form_Receive=new Form_Receive();
			form_Receive.MdiParent=this;
			form_Receive.Show();
		}
		
		void 快递单打印ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form_WuLiu form_WuLiu=new Form_WuLiu();
			form_WuLiu.MdiParent=this;
			form_WuLiu.Show();
		}
		
		void 快递单查找ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form_Search form_Search=new Form_Search();
			form_Search.MdiParent=this;
			form_Search.Show();
		}
	}
}
