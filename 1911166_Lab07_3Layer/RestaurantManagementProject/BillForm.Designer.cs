
namespace RestaurantManagementProject
{
	 partial class BillForm
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
				this.toolStrip1 = new System.Windows.Forms.ToolStrip();
				this.tslTotalAmount = new System.Windows.Forms.ToolStripLabel();
				this.btnSearchOrder = new System.Windows.Forms.Button();
				this.dtpTime = new System.Windows.Forms.DateTimePicker();
				this.dgvOrder = new System.Windows.Forms.DataGridView();
				this.toolStrip1.SuspendLayout();
				((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
				this.SuspendLayout();
				// 
				// toolStrip1
				// 
				this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
				this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
				this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTotalAmount});
				this.toolStrip1.Location = new System.Drawing.Point(0, 430);
				this.toolStrip1.Name = "toolStrip1";
				this.toolStrip1.Size = new System.Drawing.Size(958, 25);
				this.toolStrip1.TabIndex = 7;
				this.toolStrip1.Text = "toolStrip1";
				// 
				// tslTotalAmount
				// 
				this.tslTotalAmount.Name = "tslTotalAmount";
				this.tslTotalAmount.Size = new System.Drawing.Size(217, 22);
				this.tslTotalAmount.Text = "Tổng doanh thu trong ngày là : ";
				// 
				// btnSearchOrder
				// 
				this.btnSearchOrder.Location = new System.Drawing.Point(250, 6);
				this.btnSearchOrder.Name = "btnSearchOrder";
				this.btnSearchOrder.Size = new System.Drawing.Size(87, 30);
				this.btnSearchOrder.TabIndex = 6;
				this.btnSearchOrder.Text = "Tìm";
				this.btnSearchOrder.UseVisualStyleBackColor = true;
				this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
				// 
				// dtpTime
				// 
				this.dtpTime.CustomFormat = "dd/MM/yyyy";
				this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
				this.dtpTime.Location = new System.Drawing.Point(26, 8);
				this.dtpTime.Name = "dtpTime";
				this.dtpTime.Size = new System.Drawing.Size(200, 22);
				this.dtpTime.TabIndex = 5;
				// 
				// dgvOrder
				// 
				this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
				this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				this.dgvOrder.Location = new System.Drawing.Point(3, 56);
				this.dgvOrder.Name = "dgvOrder";
				this.dgvOrder.RowHeadersWidth = 51;
				this.dgvOrder.RowTemplate.Height = 24;
				this.dgvOrder.Size = new System.Drawing.Size(942, 371);
				this.dgvOrder.TabIndex = 4;
				this.dgvOrder.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrder_CellMouseDoubleClick);
				// 
				// BillForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(958, 455);
				this.Controls.Add(this.toolStrip1);
				this.Controls.Add(this.btnSearchOrder);
				this.Controls.Add(this.dtpTime);
				this.Controls.Add(this.dgvOrder);
				this.Name = "BillForm";
				this.Text = "Hóa đơn";
				this.toolStrip1.ResumeLayout(false);
				this.toolStrip1.PerformLayout();
				((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.ToolStrip toolStrip1;
		  private System.Windows.Forms.ToolStripLabel tslTotalAmount;
		  private System.Windows.Forms.Button btnSearchOrder;
		  private System.Windows.Forms.DateTimePicker dtpTime;
		  private System.Windows.Forms.DataGridView dgvOrder;
	 }
}