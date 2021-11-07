
namespace _1911166_Lab06_Basic_Command
{
	 partial class Roles
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
				this.dgvRoles = new System.Windows.Forms.DataGridView();
				((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
				this.SuspendLayout();
				// 
				// dgvRoles
				// 
				this.dgvRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
				this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				this.dgvRoles.Location = new System.Drawing.Point(2, 2);
				this.dgvRoles.Name = "dgvRoles";
				this.dgvRoles.RowHeadersWidth = 51;
				this.dgvRoles.RowTemplate.Height = 24;
				this.dgvRoles.Size = new System.Drawing.Size(614, 200);
				this.dgvRoles.TabIndex = 0;
				// 
				// Roles
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(617, 214);
				this.Controls.Add(this.dgvRoles);
				this.Name = "Roles";
				this.Text = "Roles";
				((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.DataGridView dgvRoles;
	 }
}