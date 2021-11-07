
namespace _1911166_Lab06_Basic_Command
{
	 partial class TableForm
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
				this.dgvTable = new System.Windows.Forms.DataGridView();
				this.btnAddTable = new System.Windows.Forms.Button();
				this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
				this.tsmDeleteTable = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmBills = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmBillDiary = new System.Windows.Forms.ToolStripMenuItem();
				((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
				this.contextMenuStrip1.SuspendLayout();
				this.SuspendLayout();
				// 
				// dgvTable
				// 
				this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				this.dgvTable.ContextMenuStrip = this.contextMenuStrip1;
				this.dgvTable.Location = new System.Drawing.Point(1, 47);
				this.dgvTable.Name = "dgvTable";
				this.dgvTable.RowHeadersWidth = 51;
				this.dgvTable.RowTemplate.Height = 24;
				this.dgvTable.Size = new System.Drawing.Size(592, 401);
				this.dgvTable.TabIndex = 0;
				this.dgvTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTable_CellMouseDoubleClick);
				// 
				// btnAddTable
				// 
				this.btnAddTable.Location = new System.Drawing.Point(489, 12);
				this.btnAddTable.Name = "btnAddTable";
				this.btnAddTable.Size = new System.Drawing.Size(94, 23);
				this.btnAddTable.TabIndex = 1;
				this.btnAddTable.Text = "Thêm bàn";
				this.btnAddTable.UseVisualStyleBackColor = true;
				this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
				// 
				// contextMenuStrip1
				// 
				this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
				this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDeleteTable,
            this.tsmBills,
            this.tsmBillDiary});
				this.contextMenuStrip1.Name = "contextMenuStrip1";
				this.contextMenuStrip1.Size = new System.Drawing.Size(237, 104);
				// 
				// tsmDeleteTable
				// 
				this.tsmDeleteTable.Name = "tsmDeleteTable";
				this.tsmDeleteTable.Size = new System.Drawing.Size(236, 24);
				this.tsmDeleteTable.Text = "Xóa bàn";
				this.tsmDeleteTable.Click += new System.EventHandler(this.tsmDeleteTable_Click);
				// 
				// tsmBills
				// 
				this.tsmBills.Name = "tsmBills";
				this.tsmBills.Size = new System.Drawing.Size(236, 24);
				this.tsmBills.Text = "Xem danh mục hóa đơn";
				this.tsmBills.Click += new System.EventHandler(this.tsmBills_Click);
				// 
				// tsmBillDiary
				// 
				this.tsmBillDiary.Name = "tsmBillDiary";
				this.tsmBillDiary.Size = new System.Drawing.Size(236, 24);
				this.tsmBillDiary.Text = "Xem nhật ký hóa đơn";
				this.tsmBillDiary.Click += new System.EventHandler(this.tsmBillDiary_Click);
				// 
				// TableForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(595, 450);
				this.Controls.Add(this.btnAddTable);
				this.Controls.Add(this.dgvTable);
				this.Name = "TableForm";
				this.Text = "TableForm";
				((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
				this.contextMenuStrip1.ResumeLayout(false);
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.DataGridView dgvTable;
		  private System.Windows.Forms.Button btnAddTable;
		  private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		  private System.Windows.Forms.ToolStripMenuItem tsmDeleteTable;
		  private System.Windows.Forms.ToolStripMenuItem tsmBills;
		  private System.Windows.Forms.ToolStripMenuItem tsmBillDiary;
	 }
}