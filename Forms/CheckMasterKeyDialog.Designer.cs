/*
 * Created by SharpDevelop.
 * User: qiusj
 * Date: 2019/3/12
 * Time: 21:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LajiPwd
{
	partial class CheckMasterKeyDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox key;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.key = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Master key";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// key
			// 
			this.key.Location = new System.Drawing.Point(114, 21);
			this.key.Margin = new System.Windows.Forms.Padding(5);
			this.key.Name = "key";
			this.key.PasswordChar = '*';
			this.key.Size = new System.Drawing.Size(196, 23);
			this.key.TabIndex = 2;
			this.key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownAction);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 63);
			this.button1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 30);
			this.button1.TabIndex = 4;
			this.button1.Text = "Confirm";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Confirm);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(114, 63);
			this.button2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(87, 30);
			this.button2.TabIndex = 5;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Cancel);
			// 
			// CheckMasterKeyDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(324, 111);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.key);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CheckMasterKeyDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Master Key";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
