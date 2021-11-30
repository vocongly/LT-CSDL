
namespace RestaurantManagementProject
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
				this.btnAddAccount = new System.Windows.Forms.Button();
				this.dgvAccount = new System.Windows.Forms.DataGridView();
				((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
				this.SuspendLayout();
				// 
				// btnAddAccount
				// 
				this.btnAddAccount.Location = new System.Drawing.Point(666, 10);
				this.btnAddAccount.Name = "btnAddAccount";
				this.btnAddAccount.Size = new System.Drawing.Size(122, 23);
				this.btnAddAccount.TabIndex = 3;
				this.btnAddAccount.Text = "Thêm tài khoản";
				this.btnAddAccount.UseVisualStyleBackColor = true;
				// 
				// dgvAccount
				// 
				this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				this.dgvAccount.Location = new System.Drawing.Point(3, 51);
				this.dgvAccount.Name = "dgvAccount";
				this.dgvAccount.RowHeadersWidth = 51;
				this.dgvAccount.RowTemplate.Height = 24;
				this.dgvAccount.Size = new System.Drawing.Size(795, 389);
				this.dgvAccount.TabIndex = 2;
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
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.Button btnAddAccount;
		  private System.Windows.Forms.DataGridView dgvAccount;
	 }
}