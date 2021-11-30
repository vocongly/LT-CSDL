
namespace RestaurantManagementProject
{
	 partial class BillDetailForm
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
				this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
				((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
				this.SuspendLayout();
				// 
				// dgvOrderDetails
				// 
				this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				this.dgvOrderDetails.Location = new System.Drawing.Point(3, 25);
				this.dgvOrderDetails.Name = "dgvOrderDetails";
				this.dgvOrderDetails.RowHeadersWidth = 51;
				this.dgvOrderDetails.RowTemplate.Height = 24;
				this.dgvOrderDetails.Size = new System.Drawing.Size(794, 301);
				this.dgvOrderDetails.TabIndex = 1;
				// 
				// BillDetailForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(800, 334);
				this.Controls.Add(this.dgvOrderDetails);
				this.Name = "BillDetailForm";
				this.Text = "Chi tiết hóa đơn";
				((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.DataGridView dgvOrderDetails;
	 }
}