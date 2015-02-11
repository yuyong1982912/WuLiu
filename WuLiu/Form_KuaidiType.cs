/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014-02-28
 * 时间: 12:56
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Maticsoft.BLL;
using Maticsoft.Common;
using Maticsoft.Model;
using System.Data.SqlClient;
using System.Data;

namespace WuLiu
{
	/// <summary>
	/// Description of Form_KuaidiType.
	/// </summary>
	public partial class Form_KuaidiType : Form
	{
		public Form_KuaidiType()
		{			
			InitializeComponent();
		}
		
		Maticsoft.Model.KuaidiType MkuaidiType=new Maticsoft.Model.KuaidiType();//实例化一个Model类
		Maticsoft.BLL.KuaidiType BkuaidiType=new Maticsoft.BLL.KuaidiType();//实例化一个BLL类
				
		
		void Button_InsClick(object sender, EventArgs e)
		{			
			if (!Blank.IsBlank(textBox_Name_Ins.Text)) {//如果快递单类型文本框不为空
				
				MkuaidiType.Name=textBox_Name_Ins.Text.Trim().ToString();	
				
				int Result=BkuaidiType.Add(MkuaidiType);//写入数据库
				if (Result >0) {
					MessageBox.Show("插入成功！","结果");
				}				
			}else{
				MessageBox.Show("快递单类型为空","错误");
			}
		}		
		
		void TabPage_ModEnter(object sender, EventArgs e)
		{
			DataSet ds=BkuaidiType.GetAllList();
			listBox_Name.DataSource=ds.Tables[0];
			listBox_Name.DisplayMember="Name";
			listBox_Name.ValueMember="Id";
			
			textBox_Name_Mod.Text=listBox_Name.Text;
		}
		
		void ListBox_NameSelectedIndexChanged(object sender, EventArgs e)
		{
			textBox_Name_Mod.Text=listBox_Name.Text;
		}
		
		void Button_ModClick(object sender, EventArgs e)
		{
			MkuaidiType.Name=textBox_Name_Mod.Text.Trim();
			MkuaidiType.Id=Convert.ToInt32(listBox_Name.SelectedValue);
			
			bool b=BkuaidiType.Update(MkuaidiType);
			if (b==true) {
				MessageBox.Show("更新成功!","结果");				
			}
		}
	}
}
