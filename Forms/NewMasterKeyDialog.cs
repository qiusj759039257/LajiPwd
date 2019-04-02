/*
 * Created by SharpDevelop.
 * User: qiusj
 * Date: 2019/3/12
 * Time: 21:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LajiPwd
{
	/// <summary>
	/// Description of MasterKeyDialog.
	/// </summary>
	public partial class NewMasterKeyDialog : Form
	{
		public string key;
		
		public NewMasterKeyDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Confirm(object sender, EventArgs e)
		{
			if (newKey.Text.Equals(confirmKey.Text) && newKey.Text.Length > 0)
			{
				key = newKey.Text;
				Close();
			}
			else
			{
				MessageBox.Show("Master Key not match");
			}
		}
		void Cancel(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
