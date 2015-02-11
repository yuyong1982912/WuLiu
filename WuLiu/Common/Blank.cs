/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2014-02-28
 * 时间: 14:13
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Maticsoft.Common
{
	/// <summary>
	/// 判断一个字符串是否为空
	/// </summary>
	public abstract class Blank
	{
		public Blank()
		{
		}
		
		#region 判断一个字符是否空，为空返回True,否则返加Flase
		/// <summary>
		/// 判断一个字符串是否为空
		/// </summary>
		/// <param name="str">被判断的字符串</param>
        /// <returns>为空返回真</returns>
		public static bool IsBlank(string str)
		{
			if (str=="") {
				return true;
			}else{
				return false;
			}
		}		
		#endregion
	}
}
