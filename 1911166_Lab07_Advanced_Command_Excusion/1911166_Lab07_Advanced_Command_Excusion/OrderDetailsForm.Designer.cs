
namespace _1911166_Lab07_Advanced_Command_Excusion
{
	 partial class OrderDetailsForm
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
				this.dgvOrderDetails.Location = new System.Drawing.Point(2, 26);
				this.dgvOrderDetails.Name = "dgvOrderDetails";
				this.dgvOrderDetails.RowHeadersWidth = 51;
				this.dgvOrderDetails.RowTemplate.Height = 24;
				this.dgvOrderDetails.Size = new System.Drawing.Size(924, 301);
				this.dgvOrderDetails.TabIndex = 0;
				// 
				// OrderDetailsForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(927, 331);
				this.Controls.Add(this.dgvOrderDetails);
				this.Name = "OrderDetailsForm";
				this.Text = "OrderDetailsForm";
				((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.DataGridView dgvOrderDetails;
	 }
}