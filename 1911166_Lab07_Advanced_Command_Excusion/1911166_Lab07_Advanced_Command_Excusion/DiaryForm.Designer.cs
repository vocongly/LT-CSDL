
namespace _1911166_Lab07_Advanced_Command_Excusion
{
	 partial class DiaryForm
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
				this.dgvFood = new System.Windows.Forms.DataGridView();
				this.lbxDate = new System.Windows.Forms.ListBox();
				this.lbBills = new System.Windows.Forms.Label();
				this.lbTotalMoney = new System.Windows.Forms.Label();
				this.label1 = new System.Windows.Forms.Label();
				((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
				this.SuspendLayout();
				// 
				// dgvFood
				// 
				this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				this.dgvFood.Location = new System.Drawing.Point(231, 12);
				this.dgvFood.Name = "dgvFood";
				this.dgvFood.RowHeadersWidth = 51;
				this.dgvFood.RowTemplate.Height = 24;
				this.dgvFood.Size = new System.Drawing.Size(679, 478);
				this.dgvFood.TabIndex = 1;
				// 
				// lbxDate
				// 
				this.lbxDate.FormattingEnabled = true;
				this.lbxDate.ItemHeight = 16;
				this.lbxDate.Location = new System.Drawing.Point(12, 32);
				this.lbxDate.Name = "lbxDate";
				this.lbxDate.Size = new System.Drawing.Size(213, 516);
				this.lbxDate.TabIndex = 2;
				this.lbxDate.SelectedIndexChanged += new System.EventHandler(this.lbxDate_SelectedIndexChanged);
				// 
				// lbBills
				// 
				this.lbBills.AutoSize = true;
				this.lbBills.Location = new System.Drawing.Point(272, 515);
				this.lbBills.Name = "lbBills";
				this.lbBills.Size = new System.Drawing.Size(132, 17);
				this.lbBills.TabIndex = 3;
				this.lbBills.Text = "Số lượng hóa đơn : ";
				// 
				// lbTotalMoney
				// 
				this.lbTotalMoney.AutoSize = true;
				this.lbTotalMoney.Location = new System.Drawing.Point(596, 515);
				this.lbTotalMoney.Name = "lbTotalMoney";
				this.lbTotalMoney.Size = new System.Drawing.Size(76, 17);
				this.lbTotalMoney.TabIndex = 4;
				this.lbTotalMoney.Text = "Tổng tiền :";
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(12, 12);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(173, 17);
				this.label1.TabIndex = 5;
				this.label1.Text = "Ngày lập của các hóa đơn";
				// 
				// DiaryForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(922, 567);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.lbTotalMoney);
				this.Controls.Add(this.lbBills);
				this.Controls.Add(this.lbxDate);
				this.Controls.Add(this.dgvFood);
				this.Name = "DiaryForm";
				this.Text = "DiaryForm";
				((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.DataGridView dgvFood;
		  private System.Windows.Forms.ListBox lbxDate;
		  private System.Windows.Forms.Label lbBills;
		  private System.Windows.Forms.Label lbTotalMoney;
		  private System.Windows.Forms.Label label1;
	 }
}