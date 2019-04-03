/*
 * Created by SharpDevelop.
 * User: qiusj
 * Date: 2019/3/12
 * Time: 1:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using System.Text.RegularExpressions;

namespace LajiPwd
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			bool create = false;
			if (!File.Exists("password.db"))
			{
				create = true;
				var f = new NewMasterKeyDialog();
				f.ShowDialog(this);
				f.newKey.Focus();
				
				if (f.newKey.Text.Length == 0)
				{
					MessageBox.Show("Empty Master Key");
					Environment.Exit(1);
				}
				else
				{
					Data.SetKey(Encoding.UTF8.GetBytes(f.key));
					f.Dispose();
				}
			}
			
			InitializeComponent();
			Data.InitDatabase(create);
		}
		public void LoadData()
		{
			List<DataEntity> list;
			
			list = textKeyword.Text.Length == 0 ? Data.GetAll() : Data.GetByKeyword(textKeyword.Text);
			
			listView1.Items.Clear();
			foreach (var item in list) {
				var t = new ListViewItem(item.id.ToString());
				t.SubItems.Add(item.title);
				t.SubItems.Add(item.remark);
				t.SubItems.Add(item.account);
				t.SubItems.Add(item.create.ToString("yyyy-MM-dd HH:mm:ss"));
				t.SubItems.Add(item.update.ToString("yyyy-MM-dd HH:mm:ss"));
				listView1.Items.Add(t);
			}
		}
		public void Auth()
		{
			var f = new CheckMasterKeyDialog();
			f.ShowDialog(this);
			f.key.Focus();
			
			if (f._key.Length != 0)
			{
				Data.SetKey(Encoding.UTF8.GetBytes(f._key));
				bool result;
				try {
					result = Data.ValidateKey();
				} catch (Exception) {
					
					result = false;
				}
				
				if (result)
				{
					LoadData();
					Show();
					WindowState = FormWindowState.Normal;
					CenterToScreen();
					textKeyword.Focus();
				}
				else
				{
					MessageBox.Show("Master Key invalid");
				}
			}
			
			f.Dispose();
		}
		void NewPassword(object sender, EventArgs e)
		{
			var f = new NewPasswordDialog(new DataEntity());
			
			f.ShowDialog(this);
			
			f.Dispose();
			LoadData();
		}
		void CopyPassword(object sender, EventArgs e)
		{
			int id = GetSelectedId();
			
			if (id > 0)
			{
				var i = Data.GetById(id);
				Clipboard.SetText(i.password);
				status.Text = "Copied";
			}
			
		}
		void ModifyPassword(object sender, EventArgs e)
		{
			int id = GetSelectedId();
			
			if (id > 0)
			{
				var i = Data.GetById(id);
				var f = new NewPasswordDialog(i);
				
				f.ShowDialog(this);
				
				f.Dispose();
				LoadData();
			}
			
		}
		void TypeAccount(object sender, EventArgs e)
		{
			int id = GetSelectedId();
			
			if (id > 0)
			{
				var i = Data.GetById(id);
				Type(i.account + "\t");
				status.Text = "Ready to type account";
			}
			
		}
		void TypePassword(object sender, EventArgs e)
		{
			int id = GetSelectedId();
			
			if (id > 0)
			{
				var i = Data.GetById(id);
				Type(i.password + "\t");
				status.Text = "Ready to type password";
			}
			
		}
		void DeletePassword(object sender, EventArgs e)
		{
			int id = GetSelectedId();
			
			if (id > 0 && MessageBox.Show(String.Format("Delete id = {0}", id), "Confirm", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
			{
				Data.Delete(id);
				status.Text = "Deleted";
				LoadData();
			}
		}
		void ChangeMasterKey(object sender, EventArgs e)
		{
			var f = new NewMasterKeyDialog();
			f.ShowDialog(this);
			
			if (f.key.Length > 0)
			{
				Data.ReKey(Encoding.UTF8.GetBytes(f.key));
				f.Dispose();
				LoadData();
			}
			
		}
		void Exit(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void TaskbarShow(object sender, EventArgs e)
		{
			Auth();
		}
		void Minimized(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				Hide();
				Data.KillKey();
				listView1.Items.Clear();
			}
		}
		void Close(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		void Search(object sender, EventArgs e)
		{
			LoadData();
		}
		private int GetSelectedId()
		{
			var selected = listView1.SelectedItems;
			return selected.Count > 0 ? Int32.Parse(selected[0].Text) : 0;
		}
		private void Type(string text)
		{
			text = Regex.Replace(text, "[+^%~(){}]", "{$0}");
			var t = new Thread(() => {
			                      	
          		Thread.Sleep(3000);
				
				SendKeys.SendWait(text);
				status.Text = "Typing done";
			});
			
			t.Start();
		}
	}
}
