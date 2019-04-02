/*
 * Created by SharpDevelop.
 * User: qiusj
 * Date: 2019/3/12
 * Time: 19:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LajiPwd
{
	/// <summary>
	/// Description of NewPasswordDialog.
	/// </summary>
	public partial class NewPasswordDialog : Form
	{
		private DataEntity data;
		
		public NewPasswordDialog(DataEntity d)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			data = d;
			
			textTitle.Text = data.title;
			textAccount.Text = data.account;
			textRemark.Text = data.remark;
			textPassword.Text = data.password;
			textConfirm.Text = data.password;
		}
		void DigitChange(object sender, EventArgs e)
		{
			labelDigit.Text = this.digit.Value.ToString();
		}
		void Close(object sender, EventArgs e)
		{
			Close();
		}
		void Generate(object sender, EventArgs e)
		{
			int flag = 0;
			
			if (cbNumber.Checked)
			{
				flag |= PasswordGenerator.NUMERIC;
			}
			
			if (cbUpper.Checked)
			{
				flag |= PasswordGenerator.ALPHABET_UPPER;
			}
			
			if (cbLower.Checked)
			{
				flag |= PasswordGenerator.ALPHABET_LOWER;
			}
			
			if (cbSpecial.Checked)
			{
				flag |= PasswordGenerator.SPECIAL_CHAR;
			}
			
			var g = new PasswordGenerator(flag);
			string pwd = g.generate(digit.Value);
			
			textPassword.Text = pwd;
			textConfirm.Text = pwd;
			
			Clipboard.SetText(pwd);
		}
		void Save(object sender, EventArgs e)
		{
			if (textTitle.Text.Length == 0)
			{
				MessageBox.Show("Title empty");
				return;
			}
			
			if (textAccount.Text.Length == 0)
			{
				MessageBox.Show("Account empty");
				return;
			}
			
			if (textPassword.Text.Length == 0)
			{
				MessageBox.Show("Password empty");
				return;
			}
			
			if (!textPassword.Text.Equals(textConfirm.Text))
			{
				MessageBox.Show("Password not match");
				return;
			}
			
			data.title = textTitle.Text;
			data.remark = textRemark.Text;
			data.account = textAccount.Text;
			data.password = textPassword.Text;
			
			if (data.id == 0)
			{
				Data.Insert(data);
			}
			else
			{
				Data.Update(data);
			}
			
			Clipboard.SetText(textPassword.Text);
			Close();
		}
		void Cancel(object sender, EventArgs e)
		{
			Close();
		}
	}
}
