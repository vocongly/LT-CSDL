
namespace _1911166_Lab07_Advanced_Command_Excusion
{
	 partial class AccountForm
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
				this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
				this.tsmRoles = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmDiary = new System.Windows.Forms.ToolStripMenuItem();
				this.btnAddAccount = new System.Windows.Forms.Button();
				((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
				this.contextMenuStrip1.SuspendLayout();
				this.SuspendLayout();
				// 
				// dgvAccount
				// 
				this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				this.dgvAccount.ContextMenuStrip = this.contextMenuStrip1;
				this.dgvAccount.Location = new System.Drawing.Point(3, 62);
				this.dgvAccount.Name = "dgvAccount";
				this.dgvAccount.RowHeadersWidth = 51;
				this.dgvAccount.RowTemplate.Height = 24;
				this.dgvAccount.Size = new System.Drawing.Size(795, 389);
				this.dgvAccount.TabIndex = 0;
				this.dgvAccount.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccount_CellMouseDoubleClick);
				// 
				// contextMenuStrip1
				// 
				this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
				this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRoles,
            this.tsmDiary});
				this.contextMenuStrip1.Name = "contextMenuStrip1";
				this.contextMenuStrip1.Size = new System.Drawing.Size(233, 80);
				// 
				// tsmRoles
				// 
				this.tsmRoles.Name = "tsmRoles";
				this.tsmRoles.Size = new System.Drawing.Size(232, 24);
				this.tsmRoles.Text = "Xem danh sách vai trò";
				this.tsmRoles.Click += new System.EventHandler(this.tsmRoles_Click);
				// 
				// tsmDiary
				// 
				this.tsmDiary.Name = "tsmDiary";
				this.tsmDiary.Size = new System.Drawing.Size(232, 24);
				this.tsmDiary.Text = "Xem nhật ký hoạt động";
				this.tsmDiary.Click += new System.EventHandler(this.tsmDiary_Click);
				// 
				// btnAddAccount
				// 
				this.btnAddAccount.Location = new System.Drawing.Point(666, 21);
				this.btnAddAccount.Name = "btnAddAccount";
				this.btnAddAccount.Size = new System.Drawing.Size(122, 23);
				this.btnAddAccount.TabIndex = 1;
				this.btnAddAccount.Text = "Thêm tài khoản";
				this.btnAddAccount.UseVisualStyleBackColor = true;
				this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
				// 
				// AccountForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(800, 450);
				this.Controls.Add(this.btnAddAccount);
				this.Controls.Add(this.dgvAccount);
				this.Name = "AccountForm";
				this.Text = "AccountForm";
				((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
				this.contextMenuStrip1.ResumeLayout(false);
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.DataGridView dgvAccount;
		  private System.Windows.Forms.Button btnAddAccount;
		  private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		  private System.Windows.Forms.ToolStripMenuItem tsmRoles;
		  private System.Windows.Forms.ToolStripMenuItem tsmDiary;
	 }
}