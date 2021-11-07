
namespace _1911166_Lab06_Basic_Command
{
	 partial class AccountManager
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
				this.components = new System.ComponentModel.Container();
				this.dgvAccount = new System.Windows.Forms.DataGridView();
				this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
				this.tsmDeleteAccount = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmRoles = new System.Windows.Forms.ToolStripMenuItem();
				this.menuStrip1 = new System.Windows.Forms.MenuStrip();
				this.vaiTròToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmiMath = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmiPayment = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmiServe = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmiAll = new System.Windows.Forms.ToolStripMenuItem();
				this.activiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmiActive = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmiNotActive = new System.Windows.Forms.ToolStripMenuItem();
				this.btnAddAccount = new System.Windows.Forms.Button();
				this.tsmResetPassword = new System.Windows.Forms.ToolStripMenuItem();
				((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
				this.contextMenuStrip2.SuspendLayout();
				this.menuStrip1.SuspendLayout();
				this.SuspendLayout();
				// 
				// dgvAccount
				// 
				this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				this.dgvAccount.ContextMenuStrip = this.contextMenuStrip2;
				this.dgvAccount.Location = new System.Drawing.Point(3, 69);
				this.dgvAccount.Name = "dgvAccount";
				this.dgvAccount.RowHeadersWidth = 51;
				this.dgvAccount.RowTemplate.Height = 24;
				this.dgvAccount.Size = new System.Drawing.Size(793, 378);
				this.dgvAccount.TabIndex = 0;
				this.dgvAccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellDoubleClick);
				// 
				// contextMenuStrip2
				// 
				this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
				this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDeleteAccount,
            this.tsmRoles,
            this.tsmResetPassword});
				this.contextMenuStrip2.Name = "contextMenuStrip2";
				this.contextMenuStrip2.Size = new System.Drawing.Size(225, 104);
				// 
				// tsmDeleteAccount
				// 
				this.tsmDeleteAccount.Name = "tsmDeleteAccount";
				this.tsmDeleteAccount.Size = new System.Drawing.Size(224, 24);
				this.tsmDeleteAccount.Text = "Xóa tài khoản";
				this.tsmDeleteAccount.Click += new System.EventHandler(this.tsmDeleteAccount_Click);
				// 
				// tsmRoles
				// 
				this.tsmRoles.Name = "tsmRoles";
				this.tsmRoles.Size = new System.Drawing.Size(224, 24);
				this.tsmRoles.Text = "Xem danh sách vai trò";
				this.tsmRoles.Click += new System.EventHandler(this.tsmRoles_Click);
				// 
				// menuStrip1
				// 
				this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
				this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vaiTròToolStripMenuItem,
            this.activiToolStripMenuItem});
				this.menuStrip1.Location = new System.Drawing.Point(0, 0);
				this.menuStrip1.Name = "menuStrip1";
				this.menuStrip1.Size = new System.Drawing.Size(800, 28);
				this.menuStrip1.TabIndex = 1;
				this.menuStrip1.Text = "menuStrip1";
				// 
				// vaiTròToolStripMenuItem
				// 
				this.vaiTròToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdmin,
            this.tsmiMath,
            this.tsmiPayment,
            this.tsmiServe,
            this.tsmiAll});
				this.vaiTròToolStripMenuItem.Name = "vaiTròToolStripMenuItem";
				this.vaiTròToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
				this.vaiTròToolStripMenuItem.Text = "Vai trò";
				// 
				// tsmiAdmin
				// 
				this.tsmiAdmin.Name = "tsmiAdmin";
				this.tsmiAdmin.Size = new System.Drawing.Size(233, 26);
				this.tsmiAdmin.Text = "Adminstrator";
				this.tsmiAdmin.Click += new System.EventHandler(this.tsmiAdmin_Click);
				// 
				// tsmiMath
				// 
				this.tsmiMath.Name = "tsmiMath";
				this.tsmiMath.Size = new System.Drawing.Size(233, 26);
				this.tsmiMath.Text = "Kế toán";
				this.tsmiMath.Click += new System.EventHandler(this.tsmiMath_Click);
				// 
				// tsmiPayment
				// 
				this.tsmiPayment.Name = "tsmiPayment";
				this.tsmiPayment.Size = new System.Drawing.Size(233, 26);
				this.tsmiPayment.Text = "Nhân viên thanh toán";
				this.tsmiPayment.Click += new System.EventHandler(this.tsmiPayment_Click);
				// 
				// tsmiServe
				// 
				this.tsmiServe.Name = "tsmiServe";
				this.tsmiServe.Size = new System.Drawing.Size(233, 26);
				this.tsmiServe.Text = "Nhân viên phục vụ";
				this.tsmiServe.Click += new System.EventHandler(this.tsmiServe_Click);
				// 
				// tsmiAll
				// 
				this.tsmiAll.Name = "tsmiAll";
				this.tsmiAll.Size = new System.Drawing.Size(233, 26);
				this.tsmiAll.Text = "Tất cả";
				this.tsmiAll.Click += new System.EventHandler(this.tsmiAll_Click);
				// 
				// activiToolStripMenuItem
				// 
				this.activiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActive,
            this.tsmiNotActive});
				this.activiToolStripMenuItem.Name = "activiToolStripMenuItem";
				this.activiToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
				this.activiToolStripMenuItem.Text = "Active";
				// 
				// tsmiActive
				// 
				this.tsmiActive.Name = "tsmiActive";
				this.tsmiActive.Size = new System.Drawing.Size(180, 26);
				this.tsmiActive.Text = "Active";
				this.tsmiActive.Click += new System.EventHandler(this.tsmiActive_Click);
				// 
				// tsmiNotActive
				// 
				this.tsmiNotActive.Name = "tsmiNotActive";
				this.tsmiNotActive.Size = new System.Drawing.Size(180, 26);
				this.tsmiNotActive.Text = "Không Active";
				this.tsmiNotActive.Click += new System.EventHandler(this.tsmiNotActive_Click);
				// 
				// btnAddAccount
				// 
				this.btnAddAccount.Location = new System.Drawing.Point(666, 31);
				this.btnAddAccount.Name = "btnAddAccount";
				this.btnAddAccount.Size = new System.Drawing.Size(130, 32);
				this.btnAddAccount.TabIndex = 2;
				this.btnAddAccount.Text = "Thêm tài khoản";
				this.btnAddAccount.UseVisualStyleBackColor = true;
				this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
				// 
				// tsmResetPassword
				// 
				this.tsmResetPassword.Name = "tsmResetPassword";
				this.tsmResetPassword.Size = new System.Drawing.Size(224, 24);
				this.tsmResetPassword.Text = "Reset mật khẩu";
				this.tsmResetPassword.Click += new System.EventHandler(this.tsmResetPassword_Click);
				// 
				// AccountManager
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(800, 450);
				this.Controls.Add(this.btnAddAccount);
				this.Controls.Add(this.dgvAccount);
				this.Controls.Add(this.menuStrip1);
				this.MainMenuStrip = this.menuStrip1;
				this.Name = "AccountManager";
				this.Text = "AccountManager";
				((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
				this.contextMenuStrip2.ResumeLayout(false);
				this.menuStrip1.ResumeLayout(false);
				this.menuStrip1.PerformLayout();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.DataGridView dgvAccount;
		  private System.Windows.Forms.MenuStrip menuStrip1;
		  private System.Windows.Forms.ToolStripMenuItem vaiTròToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
		  private System.Windows.Forms.ToolStripMenuItem tsmiMath;
		  private System.Windows.Forms.ToolStripMenuItem tsmiPayment;
		  private System.Windows.Forms.ToolStripMenuItem tsmiServe;
		  private System.Windows.Forms.ToolStripMenuItem tsmiAll;
		  private System.Windows.Forms.ToolStripMenuItem activiToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem tsmiActive;
		  private System.Windows.Forms.ToolStripMenuItem tsmiNotActive;
		  private System.Windows.Forms.Button btnAddAccount;
		  private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		  private System.Windows.Forms.ToolStripMenuItem tsmDeleteAccount;
		  private System.Windows.Forms.ToolStripMenuItem tsmRoles;
		  private System.Windows.Forms.ToolStripMenuItem tsmResetPassword;
	 }
}