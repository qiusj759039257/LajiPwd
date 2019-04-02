/*
 * Created by SharpDevelop.
 * User: qiusj
 * Date: 2019/3/12
 * Time: 0:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace LajiPwd
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			var f = new MainForm();
			f.Auth();
			
			Application.Run();
		}
		
	}
}
