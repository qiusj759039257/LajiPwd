/*
 * Created by SharpDevelop.
 * User: qiusj
 * Date: 2019/3/12
 * Time: 19:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LajiPwd
{
	partial class NewPasswordDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox textTitle;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox textAccount;
		public System.Windows.Forms.TextBox textRemark;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.TextBox textConfirm;
		public System.Windows.Forms.TextBox textPassword;
		private System.Windows.Forms.Button buttonGenerate;
		private System.Windows.Forms.TrackBar digit;
		private System.Windows.Forms.CheckBox cbSpecial;
		private System.Windows.Forms.CheckBox cbLower;
		private System.Windows.Forms.CheckBox cbUpper;
		private System.Windows.Forms.CheckBox cbNumber;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelDigit;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textConfirm = new System.Windows.Forms.TextBox();
			this.textPassword = new System.Windows.Forms.TextBox();
			this.textAccount = new System.Windows.Forms.TextBox();
			this.textRemark = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textTitle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.labelDigit = new System.Windows.Forms.Label();
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.digit = new System.Windows.Forms.TrackBar();
			this.cbSpecial = new System.Windows.Forms.CheckBox();
			this.cbLower = new System.Windows.Forms.CheckBox();
			this.cbUpper = new System.Windows.Forms.CheckBox();
			this.cbNumber = new System.Windows.Forms.CheckBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.digit)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textConfirm);
			this.groupBox1.Controls.Add(this.textPassword);
			this.groupBox1.Controls.Add(this.textAccount);
			this.groupBox1.Controls.Add(this.textRemark);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textTitle);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(16, 20);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(296, 229);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Basic";
			// 
			// textConfirm
			// 
			this.textConfirm.Location = new System.Drawing.Point(86, 183);
			this.textConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textConfirm.Name = "textConfirm";
			this.textConfirm.PasswordChar = '*';
			this.textConfirm.Size = new System.Drawing.Size(203, 23);
			this.textConfirm.TabIndex = 9;
			// 
			// textPassword
			// 
			this.textPassword.Location = new System.Drawing.Point(86, 144);
			this.textPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textPassword.Name = "textPassword";
			this.textPassword.PasswordChar = '*';
			this.textPassword.Size = new System.Drawing.Size(203, 23);
			this.textPassword.TabIndex = 8;
			// 
			// textAccount
			// 
			this.textAccount.Location = new System.Drawing.Point(86, 106);
			this.textAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textAccount.Name = "textAccount";
			this.textAccount.Size = new System.Drawing.Size(203, 23);
			this.textAccount.TabIndex = 7;
			// 
			// textRemark
			// 
			this.textRemark.Location = new System.Drawing.Point(86, 68);
			this.textRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textRemark.Name = "textRemark";
			this.textRemark.Size = new System.Drawing.Size(203, 23);
			this.textRemark.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 178);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 33);
			this.label5.TabIndex = 5;
			this.label5.Text = "Confirm";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 33);
			this.label4.TabIndex = 4;
			this.label4.Text = "Password";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 33);
			this.label3.TabIndex = 3;
			this.label3.Text = "Account";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 33);
			this.label2.TabIndex = 2;
			this.label2.Text = "Remark";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textTitle
			// 
			this.textTitle.Location = new System.Drawing.Point(86, 29);
			this.textTitle.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.textTitle.Name = "textTitle";
			this.textTitle.Size = new System.Drawing.Size(203, 23);
			this.textTitle.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.labelDigit);
			this.groupBox2.Controls.Add(this.buttonGenerate);
			this.groupBox2.Controls.Add(this.digit);
			this.groupBox2.Controls.Add(this.cbSpecial);
			this.groupBox2.Controls.Add(this.cbLower);
			this.groupBox2.Controls.Add(this.cbUpper);
			this.groupBox2.Controls.Add(this.cbNumber);
			this.groupBox2.Location = new System.Drawing.Point(16, 261);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Size = new System.Drawing.Size(296, 177);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Generator";
			// 
			// labelDigit
			// 
			this.labelDigit.Location = new System.Drawing.Point(7, 110);
			this.labelDigit.Name = "labelDigit";
			this.labelDigit.Size = new System.Drawing.Size(186, 33);
			this.labelDigit.TabIndex = 6;
			this.labelDigit.Text = "16";
			this.labelDigit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonGenerate
			// 
			this.buttonGenerate.Location = new System.Drawing.Point(202, 76);
			this.buttonGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.Size = new System.Drawing.Size(87, 42);
			this.buttonGenerate.TabIndex = 5;
			this.buttonGenerate.Text = "Generate";
			this.buttonGenerate.UseVisualStyleBackColor = true;
			this.buttonGenerate.Click += new System.EventHandler(this.Generate);
			// 
			// digit
			// 
			this.digit.LargeChange = 1;
			this.digit.Location = new System.Drawing.Point(9, 79);
			this.digit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.digit.Maximum = 64;
			this.digit.Minimum = 1;
			this.digit.Name = "digit";
			this.digit.Size = new System.Drawing.Size(184, 45);
			this.digit.TabIndex = 4;
			this.digit.TickStyle = System.Windows.Forms.TickStyle.None;
			this.digit.Value = 16;
			this.digit.ValueChanged += new System.EventHandler(this.DigitChange);
			// 
			// cbSpecial
			// 
			this.cbSpecial.Checked = true;
			this.cbSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbSpecial.Location = new System.Drawing.Point(195, 31);
			this.cbSpecial.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.cbSpecial.Name = "cbSpecial";
			this.cbSpecial.Size = new System.Drawing.Size(94, 34);
			this.cbSpecial.TabIndex = 3;
			this.cbSpecial.Text = "~!@#$%";
			this.cbSpecial.UseVisualStyleBackColor = true;
			// 
			// cbLower
			// 
			this.cbLower.Checked = true;
			this.cbLower.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbLower.Location = new System.Drawing.Point(133, 31);
			this.cbLower.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.cbLower.Name = "cbLower";
			this.cbLower.Size = new System.Drawing.Size(50, 34);
			this.cbLower.TabIndex = 2;
			this.cbLower.Text = "a-z";
			this.cbLower.UseVisualStyleBackColor = true;
			// 
			// cbUpper
			// 
			this.cbUpper.Checked = true;
			this.cbUpper.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbUpper.Location = new System.Drawing.Point(71, 31);
			this.cbUpper.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.cbUpper.Name = "cbUpper";
			this.cbUpper.Size = new System.Drawing.Size(50, 34);
			this.cbUpper.TabIndex = 1;
			this.cbUpper.Text = "A-Z";
			this.cbUpper.UseVisualStyleBackColor = true;
			// 
			// cbNumber
			// 
			this.cbNumber.Checked = true;
			this.cbNumber.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbNumber.Location = new System.Drawing.Point(9, 31);
			this.cbNumber.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.cbNumber.Name = "cbNumber";
			this.cbNumber.Size = new System.Drawing.Size(50, 34);
			this.cbNumber.TabIndex = 0;
			this.cbNumber.Text = "0-9";
			this.cbNumber.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(16, 449);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(87, 42);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.Save);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(115, 449);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(87, 42);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.Cancel);
			// 
			// NewPasswordDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 511);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewPasswordDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New password";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.digit)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
