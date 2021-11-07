
namespace _1911166_Lab06_Basic_Command
{
	 partial class AddAccount
	 {
		  /// <summary>
		  /// Required designer variable.
		  /// </summary>
		  private System.ComponentModel.IContainer components = null;

		  /// <summary>
		  /// Clean up any resources being used.
		  /// </summary>
		  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		  protected override void Dispose(bool disposing)
		  {
				if (disposing && (components != null))
				{
					 components.Dispose();
				}
				base.Dispose(disposing);
		  }

		  #region Windows Form Designer generated code

		  /// <summary>
		  /// Required method for Designer support - do not modify
		  /// the contents of this method with the code editor.
		  /// </summary>
		  private void InitializeComponent()
		  {
				this.label1 = new System.Windows.Forms.Label();
				this.txtHoTen = new System.Windows.Forms.TextBox();
				this.label2 = new System.Windows.Forms.Label();
				this.txtAccountName = new System.Windows.Forms.TextBox();
				this.label3 = new System.Windows.Forms.Label();
				this.txtPassword = new System.Windows.Forms.TextBox();
				this.label4 = new System.Windows.Forms.Label();
				this.txtEmail = new System.Windows.Forms.TextBox();
				this.label5 = new System.Windows.Forms.Label();
				this.mstbSDT = new System.Windows.Forms.MaskedTextBox();
				this.label7 = new System.Windows.Forms.Label();
				this.label9 = new System.Windows.Forms.Label();
				this.txtNote = new System.Windows.Forms.TextBox();
				this.clbVaitro = new System.Windows.Forms.CheckedListBox();
				this.btnLuuAccount = new System.Windows.Forms.Button();
				this.btnUpdateAccount = new System.Windows.Forms.Button();
				this.SuspendLayout();
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(12, 9);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(77, 17);
				this.label1.TabIndex = 0;
				this.label1.Text = "Họ và tên: ";
				// 
				// txtHoTen
				// 
				this.txtHoTen.Location = new System.Drawing.Point(130, 4);
				this.txtHoTen.Name = "txtHoTen";
				this.txtHoTen.Size = new System.Drawing.Size(198, 22);
				this.txtHoTen.TabIndex = 1;
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(12, 46);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(108, 17);
				this.label2.TabIndex = 2;
				this.label2.Text = "Account Name: ";
				// 
				// txtAccountName
				// 
				this.txtAccountName.Location = new System.Drawing.Point(130, 43);
				this.txtAccountName.Name = "txtAccountName";
				this.txtAccountName.Size = new System.Drawing.Size(198, 22);
				this.txtAccountName.TabIndex = 3;
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Location = new System.Drawing.Point(12, 84);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(73, 17);
				this.label3.TabIndex = 4;
				this.label3.Text = "Password:";
				// 
				// txtPassword
				// 
				this.txtPassword.Location = new System.Drawing.Point(130, 81);
				this.txtPassword.Name = "txtPassword";
				this.txtPassword.Size = new System.Drawing.Size(198, 22);
				this.txtPassword.TabIndex = 5;
				// 
				// label4
				// 
				this.label4.AutoSize = true;
				this.label4.Location = new System.Drawing.Point(12, 118);
				this.label4.Name = "label4";
				this.label4.Size = new System.Drawing.Size(46, 17);
				this.label4.TabIndex = 6;
				this.label4.Text = "Email:";
				// 
				// txtEmail
				// 
				this.txtEmail.Location = new System.Drawing.Point(75, 115);
				this.txtEmail.Name = "txtEmail";
				this.txtEmail.Size = new System.Drawing.Size(253, 22);
				this.txtEmail.TabIndex = 7;
				// 
				// label5
				// 
				this.label5.AutoSize = true;
				this.label5.Location = new System.Drawing.Point(347, 7);
				this.label5.Name = "label5";
				this.label5.Size = new System.Drawing.Size(32, 17);
				this.label5.TabIndex = 8;
				this.label5.Text = "Tel:";
				// 
				// mstbSDT
				// 
				this.mstbSDT.Location = new System.Drawing.Point(410, 6);
				this.mstbSDT.Mask = "0000.000.000";
				this.mstbSDT.Name = "mstbSDT";
				this.mstbSDT.Size = new System.Drawing.Size(254, 22);
				this.mstbSDT.TabIndex = 9;
				this.mstbSDT.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
				// 
				// label7
				// 
				this.label7.AutoSize = true;
				this.label7.Location = new System.Drawing.Point(347, 46);
				this.label7.Name = "label7";
				this.label7.Size = new System.Drawing.Size(57, 17);
				this.label7.TabIndex = 12;
				this.label7.Text = "Vai trò: ";
				// 
				// label9
				// 
				this.label9.AutoSize = true;
				this.label9.Location = new System.Drawing.Point(12, 151);
				this.label9.Name = "label9";
				this.label9.Size = new System.Drawing.Size(46, 17);
				this.label9.TabIndex = 16;
				this.label9.Text = "Note: ";
				// 
				// txtNote
				// 
				this.txtNote.Location = new System.Drawing.Point(76, 148);
				this.txtNote.Name = "txtNote";
				this.txtNote.Size = new System.Drawing.Size(589, 22);
				this.txtNote.TabIndex = 17;
				// 
				// clbVaitro
				// 
				this.clbVaitro.FormattingEnabled = true;
				this.clbVaitro.Items.AddRange(new object[] {
            "Adminstrator",
            "Kế toán",
            "Nhân viên thanh toán",
            "Nhân viên phục vụ"});
				this.clbVaitro.Location = new System.Drawing.Point(410, 43);
				this.clbVaitro.MultiColumn = true;
				this.clbVaitro.Name = "clbVaitro";
				this.clbVaitro.Size = new System.Drawing.Size(255, 89);
				this.clbVaitro.TabIndex = 18;
				// 
				// btnLuuAccount
				// 
				this.btnLuuAccount.Location = new System.Drawing.Point(577, 176);
				this.btnLuuAccount.Name = "btnLuuAccount";
				this.btnLuuAccount.Size = new System.Drawing.Size(87, 33);
				this.btnLuuAccount.TabIndex = 19;
				this.btnLuuAccount.Text = "Thêm";
				this.btnLuuAccount.UseVisualStyleBackColor = true;
				this.btnLuuAccount.Click += new System.EventHandler(this.btnLuuAccount_Click);
				// 
				// btnUpdateAccount
				// 
				this.btnUpdateAccount.Location = new System.Drawing.Point(474, 176);
				this.btnUpdateAccount.Name = "btnUpdateAccount";
				this.btnUpdateAccount.Size = new System.Drawing.Size(87, 33);
				this.btnUpdateAccount.TabIndex = 20;
				this.btnUpdateAccount.Text = "Cập nhật";
				this.btnUpdateAccount.UseVisualStyleBackColor = true;
				this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
				// 
				// AddAccount
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(677, 217);
				this.Controls.Add(this.btnUpdateAccount);
				this.Controls.Add(this.btnLuuAccount);
				this.Controls.Add(this.clbVaitro);
				this.Controls.Add(this.txtNote);
				this.Controls.Add(this.label9);
				this.Controls.Add(this.label7);
				this.Controls.Add(this.mstbSDT);
				this.Controls.Add(this.label5);
				this.Controls.Add(this.txtEmail);
				this.Controls.Add(this.label4);
				this.Controls.Add(this.txtPassword);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.txtAccountName);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.txtHoTen);
				this.Controls.Add(this.label1);
				this.Name = "AddAccount";
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				this.Text = "AddAccount";
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.TextBox txtHoTen;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.TextBox txtAccountName;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.TextBox txtPassword;
		  private System.Windows.Forms.Label label4;
		  private System.Windows.Forms.TextBox txtEmail;
		  private System.Windows.Forms.Label label5;
		  private System.Windows.Forms.MaskedTextBox mstbSDT;
		  private System.Windows.Forms.Label label7;
		  private System.Windows.Forms.Label label9;
		  private System.Windows.Forms.TextBox txtNote;
		  private System.Windows.Forms.CheckedListBox clbVaitro;
		  private System.Windows.Forms.Button btnLuuAccount;
		  private System.Windows.Forms.Button btnUpdateAccount;
	 }
}