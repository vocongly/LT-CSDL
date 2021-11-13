
namespace _1911166_Lab07_Advanced_Command_Excusion
{
	 partial class OrderForm
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
				this.dgvOrder = new System.Windows.Forms.DataGridView();
				this.dtpTime = new System.Windows.Forms.DateTimePicker();
				this.btnSearchOrder = new System.Windows.Forms.Button();
				this.toolStrip1 = new System.Windows.Forms.ToolStrip();
				this.tslTotalAmount = new System.Windows.Forms.ToolStripLabel();
				((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
				this.toolStrip1.SuspendLayout();
				this.SuspendLayout();
				// 
				// dgvOrder
				// 
				this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
				this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				this.dgvOrder.Location = new System.Drawing.Point(3, 63);
				this.dgvOrder.Name = "dgvOrder";
				this.dgvOrder.RowHeadersWidth = 51;
				this.dgvOrder.RowTemplate.Height = 24;
				this.dgvOrder.Size = new System.Drawing.Size(942, 384);
				this.dgvOrder.TabIndex = 0;
				this.dgvOrder.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrder_CellMouseDoubleClick);
				// 
				// dtpTime
				// 
				this.dtpTime.CustomFormat = "dd/MM/yyyy";
				this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
				this.dtpTime.Location = new System.Drawing.Point(26, 15);
				this.dtpTime.Name = "dtpTime";
				this.dtpTime.Size = new System.Drawing.Size(200, 22);
				this.dtpTime.TabIndex = 1;
				// 
				// btnSearchOrder
				// 
				this.btnSearchOrder.Location = new System.Drawing.Point(250, 13);
				this.btnSearchOrder.Name = "btnSearchOrder";
				this.btnSearchOrder.Size = new System.Drawing.Size(87, 30);
				this.btnSearchOrder.TabIndex = 2;
				this.btnSearchOrder.Text = "Tìm";
				this.btnSearchOrder.UseVisualStyleBackColor = true;
				this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
				// 
				// toolStrip1
				// 
				this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
				this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
				this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTotalAmount});
				this.toolStrip1.Location = new System.Drawing.Point(0, 425);
				this.toolStrip1.Name = "toolStrip1";
				this.toolStrip1.Size = new System.Drawing.Size(947, 25);
				this.toolStrip1.TabIndex = 3;
				this.toolStrip1.Text = "toolStrip1";
				// 
				// tslTotalAmount
				// 
				this.tslTotalAmount.Name = "tslTotalAmount";
				this.tslTotalAmount.Size = new System.Drawing.Size(217, 22);
				this.tslTotalAmount.Text = "Tổng doanh thu trong ngày là : ";
				// 
				// OrderForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(947, 450);
				this.Controls.Add(this.toolStrip1);
				this.Controls.Add(this.btnSearchOrder);
				this.Controls.Add(this.dtpTime);
				this.Controls.Add(this.dgvOrder);
				this.Name = "OrderForm";
				this.Text = "OrderForm";
				((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
				this.toolStrip1.ResumeLayout(false);
				this.toolStrip1.PerformLayout();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.DataGridView dgvOrder;
		  private System.Windows.Forms.DateTimePicker dtpTime;
		  private System.Windows.Forms.Button btnSearchOrder;
		  private System.Windows.Forms.ToolStrip toolStrip1;
		  private System.Windows.Forms.ToolStripLabel tslTotalAmount;
	 }
}