
namespace _1911166_Lab06_Basic_Command
{
	 partial class BillsForm
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
				this.dgvBills = new System.Windows.Forms.DataGridView();
				this.label1 = new System.Windows.Forms.Label();
				this.label2 = new System.Windows.Forms.Label();
				this.dtpFrom = new System.Windows.Forms.DateTimePicker();
				this.dtpTo = new System.Windows.Forms.DateTimePicker();
				this.btnSearch = new System.Windows.Forms.Button();
				((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
				this.SuspendLayout();
				// 
				// dgvBills
				// 
				this.dgvBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
				this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				this.dgvBills.Location = new System.Drawing.Point(1, 90);
				this.dgvBills.Name = "dgvBills";
				this.dgvBills.RowHeadersWidth = 51;
				this.dgvBills.RowTemplate.Height = 24;
				this.dgvBills.Size = new System.Drawing.Size(798, 363);
				this.dgvBills.TabIndex = 0;
				this.dgvBills.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBills_CellMouseDoubleClick);
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(23, 28);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(33, 17);
				this.label1.TabIndex = 1;
				this.label1.Text = "Từ: ";
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(292, 33);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(38, 17);
				this.label2.TabIndex = 2;
				this.label2.Text = "Đến:";
				// 
				// dtpFrom
				// 
				this.dtpFrom.CustomFormat = "MM/dd/yyyy";
				this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
				this.dtpFrom.Location = new System.Drawing.Point(63, 28);
				this.dtpFrom.Name = "dtpFrom";
				this.dtpFrom.Size = new System.Drawing.Size(200, 22);
				this.dtpFrom.TabIndex = 3;
				// 
				// dtpTo
				// 
				this.dtpTo.CustomFormat = "MM/dd/yyyy";
				this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
				this.dtpTo.Location = new System.Drawing.Point(336, 28);
				this.dtpTo.Name = "dtpTo";
				this.dtpTo.Size = new System.Drawing.Size(200, 22);
				this.dtpTo.TabIndex = 4;
				// 
				// btnSearch
				// 
				this.btnSearch.Location = new System.Drawing.Point(607, 25);
				this.btnSearch.Name = "btnSearch";
				this.btnSearch.Size = new System.Drawing.Size(83, 33);
				this.btnSearch.TabIndex = 5;
				this.btnSearch.Text = "Tìm";
				this.btnSearch.UseVisualStyleBackColor = true;
				this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
				// 
				// BillsForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(800, 450);
				this.Controls.Add(this.btnSearch);
				this.Controls.Add(this.dtpTo);
				this.Controls.Add(this.dtpFrom);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.dgvBills);
				this.Name = "BillsForm";
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				this.Text = "BillsForm";
				this.Load += new System.EventHandler(this.BillsForm_Load);
				((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.DataGridView dgvBills;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.DateTimePicker dtpFrom;
		  private System.Windows.Forms.DateTimePicker dtpTo;
		  private System.Windows.Forms.Button btnSearch;
	 }
}