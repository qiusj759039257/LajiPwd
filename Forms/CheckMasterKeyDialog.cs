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
	public partial class CheckMasterKeyDialog : Form
	{
		public string _key = "";
		public CheckMasterKeyDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void _Confirm()
		{
			if (key.Text.Length > 0)
			{
				_key = key.Text;
				Close();
			}
			else
			{
				MessageBox.Show("Empty Master Key");
			}
		}
		void Confirm(object sender, EventArgs e)
		{
			_Confirm();
		}
		void Cancel(object sender, EventArgs e)
		{
			Dispose();
		}
		void KeyDownAction(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				_Confirm();
			}
		}
	}
}
