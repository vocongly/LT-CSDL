
namespace _1911166_Lab03_Demo
{
	 partial class OptionForm
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
				this.rdMaSV = new System.Windows.Forms.RadioButton();
				this.rdHoTen = new System.Windows.Forms.RadioButton();
				this.rdNgaySinh = new System.Windows.Forms.RadioButton();
				this.pnOption = new System.Windows.Forms.Panel();
				this.btnSort = new System.Windows.Forms.Button();
				this.btnExit = new System.Windows.Forms.Button();
				this.lbNhapInfo = new System.Windows.Forms.Label();
				this.txtInfo = new System.Windows.Forms.TextBox();
				this.btnSearch = new System.Windows.Forms.Button();
				this.pnSearch = new System.Windows.Forms.Panel();
				this.pnOption.SuspendLayout();
				this.pnSearch.SuspendLayout();
				this.SuspendLayout();
				// 
				// rdMaSV
				// 
				this.rdMaSV.AutoSize = true;
				this.rdMaSV.Location = new System.Drawing.Point(16, 22);
				this.rdMaSV.Name = "rdMaSV";
				this.rdMaSV.Size = new System.Drawing.Size(70, 21);
				this.rdMaSV.TabIndex = 0;
				this.rdMaSV.TabStop = true;
				this.rdMaSV.Text = "Mã SV";
				this.rdMaSV.UseVisualStyleBackColor = true;
				// 
				// rdHoTen
				// 
				this.rdHoTen.AutoSize = true;
				this.rdHoTen.Location = new System.Drawing.Point(134, 22);
				this.rdHoTen.Name = "rdHoTen";
				this.rdHoTen.Size = new System.Drawing.Size(76, 21);
				this.rdHoTen.TabIndex = 1;
				this.rdHoTen.TabStop = true;
				this.rdHoTen.Text = "Họ Tên";
				this.rdHoTen.UseVisualStyleBackColor = true;
				// 
				// rdNgaySinh
				// 
				this.rdNgaySinh.AutoSize = true;
				this.rdNgaySinh.Location = new System.Drawing.Point(263, 22);
				this.rdNgaySinh.Name = "rdNgaySinh";
				this.rdNgaySinh.Size = new System.Drawing.Size(96, 21);
				this.rdNgaySinh.TabIndex = 2;
				this.rdNgaySinh.TabStop = true;
				this.rdNgaySinh.Text = "Ngày sinh ";
				this.rdNgaySinh.UseVisualStyleBackColor = true;
				// 
				// pnOption
				// 
				this.pnOption.Controls.Add(this.rdMaSV);
				this.pnOption.Controls.Add(this.rdNgaySinh);
				this.pnOption.Controls.Add(this.rdHoTen);
				this.pnOption.Location = new System.Drawing.Point(12, 12);
				this.pnOption.Name = "pnOption";
				this.pnOption.Size = new System.Drawing.Size(375, 69);
				this.pnOption.TabIndex = 3;
				// 
				// btnSort
				// 
				this.btnSort.ForeColor = System.Drawing.Color.Fuchsia;
				this.btnSort.Location = new System.Drawing.Point(54, 145);
				this.btnSort.Name = "btnSort";
				this.btnSort.Size = new System.Drawing.Size(72, 23);
				this.btnSort.TabIndex = 3;
				this.btnSort.Text = "Sắp xếp";
				this.btnSort.UseVisualStyleBackColor = true;
				this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
				// 
				// btnExit
				// 
				this.btnExit.ForeColor = System.Drawing.Color.Fuchsia;
				this.btnExit.Location = new System.Drawing.Point(233, 145);
				this.btnExit.Name = "btnExit";
				this.btnExit.Size = new System.Drawing.Size(72, 23);
				this.btnExit.TabIndex = 5;
				this.btnExit.Text = "Thoát";
				this.btnExit.UseVisualStyleBackColor = true;
				this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
				// 
				// lbNhapInfo
				// 
				this.lbNhapInfo.AutoSize = true;
				this.lbNhapInfo.Location = new System.Drawing.Point(13, 15);
				this.lbNhapInfo.Name = "lbNhapInfo";
				this.lbNhapInfo.Size = new System.Drawing.Size(101, 17);
				this.lbNhapInfo.TabIndex = 0;
				this.lbNhapInfo.Text = "Nhập thông tin";
				// 
				// txtInfo
				// 
				this.txtInfo.Location = new System.Drawing.Point(120, 15);
				this.txtInfo.Name = "txtInfo";
				this.txtInfo.Size = new System.Drawing.Size(173, 22);
				this.txtInfo.TabIndex = 1;
				// 
				// btnSearch
				// 
				this.btnSearch.ForeColor = System.Drawing.Color.Fuchsia;
				this.btnSearch.Location = new System.Drawing.Point(300, 13);
				this.btnSearch.Name = "btnSearch";
				this.btnSearch.Size = new System.Drawing.Size(72, 23);
				this.btnSearch.TabIndex = 2;
				this.btnSearch.Text = "Tìm";
				this.btnSearch.UseVisualStyleBackColor = true;
				this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
				// 
				// pnSearch
				// 
				this.pnSearch.Controls.Add(this.btnSearch);
				this.pnSearch.Controls.Add(this.txtInfo);
				this.pnSearch.Controls.Add(this.lbNhapInfo);
				this.pnSearch.Location = new System.Drawing.Point(12, 87);
				this.pnSearch.Name = "pnSearch";
				this.pnSearch.Size = new System.Drawing.Size(375, 52);
				this.pnSearch.TabIndex = 4;
				// 
				// OptionForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(399, 185);
				this.Controls.Add(this.btnExit);
				this.Controls.Add(this.btnSort);
				this.Controls.Add(this.pnSearch);
				this.Controls.Add(this.pnOption);
				this.Name = "OptionForm";
				this.Text = "Tùy chọn";
				this.Load += new System.EventHandler(this.OptionForm_Load);
				this.pnOption.ResumeLayout(false);
				this.pnOption.PerformLayout();
				this.pnSearch.ResumeLayout(false);
				this.pnSearch.PerformLayout();
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.RadioButton rdMaSV;
		  private System.Windows.Forms.RadioButton rdHoTen;
		  private System.Windows.Forms.RadioButton rdNgaySinh;
		  private System.Windows.Forms.Panel pnOption;
		  private System.Windows.Forms.Button btnSort;
		  private System.Windows.Forms.Button btnExit;
		  private System.Windows.Forms.Label lbNhapInfo;
		  private System.Windows.Forms.TextBox txtInfo;
		  private System.Windows.Forms.Button btnSearch;
		  private System.Windows.Forms.Panel pnSearch;
	 }
}