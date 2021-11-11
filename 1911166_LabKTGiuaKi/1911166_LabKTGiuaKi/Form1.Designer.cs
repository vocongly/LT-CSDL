
namespace _1911166_LabKTGiuaKi
{
	 partial class Form1
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
				this.tvKhoa = new System.Windows.Forms.TreeView();
				this.label1 = new System.Windows.Forms.Label();
				this.lvDSSV = new System.Windows.Forms.ListView();
				this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
				this.tsmiAddStudent = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmiDeleteStudent = new System.Windows.Forms.ToolStripMenuItem();
				this.groupBox1 = new System.Windows.Forms.GroupBox();
				this.txtSearch = new System.Windows.Forms.TextBox();
				this.rdHoTen = new System.Windows.Forms.RadioButton();
				this.rdSDT = new System.Windows.Forms.RadioButton();
				this.rdMSSV = new System.Windows.Forms.RadioButton();
				this.label2 = new System.Windows.Forms.Label();
				this.menuStrip1 = new System.Windows.Forms.MenuStrip();
				this.nhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmiExcel = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmiJson = new System.Windows.Forms.ToolStripMenuItem();
				this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
				this.contextMenuStrip1.SuspendLayout();
				this.groupBox1.SuspendLayout();
				this.menuStrip1.SuspendLayout();
				this.SuspendLayout();
				// 
				// tvKhoa
				// 
				this.tvKhoa.Location = new System.Drawing.Point(12, 110);
				this.tvKhoa.Name = "tvKhoa";
				this.tvKhoa.Size = new System.Drawing.Size(265, 564);
				this.tvKhoa.TabIndex = 0;
				this.tvKhoa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKhoa_AfterSelect);
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(9, 77);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(264, 17);
				this.label1.TabIndex = 1;
				this.label1.Text = "Chọn lớp để hiện thị danh sách sinh viên";
				// 
				// lvDSSV
				// 
				this.lvDSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
				this.lvDSSV.ContextMenuStrip = this.contextMenuStrip1;
				this.lvDSSV.FullRowSelect = true;
				this.lvDSSV.GridLines = true;
				this.lvDSSV.HideSelection = false;
				this.lvDSSV.Location = new System.Drawing.Point(283, 110);
				this.lvDSSV.Name = "lvDSSV";
				this.lvDSSV.Size = new System.Drawing.Size(787, 564);
				this.lvDSSV.TabIndex = 2;
				this.lvDSSV.UseCompatibleStateImageBehavior = false;
				this.lvDSSV.View = System.Windows.Forms.View.Details;
				this.lvDSSV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvDSSV_MouseDoubleClick);
				// 
				// columnHeader1
				// 
				this.columnHeader1.Text = "MSSV";
				this.columnHeader1.Width = 87;
				// 
				// columnHeader2
				// 
				this.columnHeader2.Text = "Họ và tên lót";
				this.columnHeader2.Width = 167;
				// 
				// columnHeader3
				// 
				this.columnHeader3.Text = "Tên";
				this.columnHeader3.Width = 86;
				// 
				// columnHeader4
				// 
				this.columnHeader4.Text = "Giới tính";
				this.columnHeader4.Width = 92;
				// 
				// columnHeader5
				// 
				this.columnHeader5.Text = "Ngày sinh";
				this.columnHeader5.Width = 117;
				// 
				// columnHeader6
				// 
				this.columnHeader6.Text = "Số điện thoại";
				this.columnHeader6.Width = 149;
				// 
				// columnHeader7
				// 
				this.columnHeader7.Text = "Lớp";
				this.columnHeader7.Width = 81;
				// 
				// columnHeader8
				// 
				this.columnHeader8.Text = "Địa chỉ";
				// 
				// contextMenuStrip1
				// 
				this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
				this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStudent,
            this.tsmiDeleteStudent});
				this.contextMenuStrip1.Name = "contextMenuStrip1";
				this.contextMenuStrip1.Size = new System.Drawing.Size(116, 52);
				// 
				// tsmiAddStudent
				// 
				this.tsmiAddStudent.Name = "tsmiAddStudent";
				this.tsmiAddStudent.Size = new System.Drawing.Size(115, 24);
				this.tsmiAddStudent.Text = "Thêm";
				this.tsmiAddStudent.Click += new System.EventHandler(this.tsmiAddStudent_Click);
				// 
				// tsmiDeleteStudent
				// 
				this.tsmiDeleteStudent.Name = "tsmiDeleteStudent";
				this.tsmiDeleteStudent.Size = new System.Drawing.Size(115, 24);
				this.tsmiDeleteStudent.Text = "Xóa";
				// 
				// groupBox1
				// 
				this.groupBox1.Controls.Add(this.txtSearch);
				this.groupBox1.Controls.Add(this.rdHoTen);
				this.groupBox1.Controls.Add(this.rdSDT);
				this.groupBox1.Controls.Add(this.rdMSSV);
				this.groupBox1.Controls.Add(this.label2);
				this.groupBox1.Location = new System.Drawing.Point(283, 31);
				this.groupBox1.Name = "groupBox1";
				this.groupBox1.Size = new System.Drawing.Size(787, 73);
				this.groupBox1.TabIndex = 3;
				this.groupBox1.TabStop = false;
				this.groupBox1.Text = "Tìm kiếm";
				// 
				// txtSearch
				// 
				this.txtSearch.Location = new System.Drawing.Point(215, 43);
				this.txtSearch.Name = "txtSearch";
				this.txtSearch.Size = new System.Drawing.Size(432, 22);
				this.txtSearch.TabIndex = 8;
				this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
				// 
				// rdHoTen
				// 
				this.rdHoTen.AutoSize = true;
				this.rdHoTen.Location = new System.Drawing.Point(388, 14);
				this.rdHoTen.Name = "rdHoTen";
				this.rdHoTen.Size = new System.Drawing.Size(71, 21);
				this.rdHoTen.TabIndex = 7;
				this.rdHoTen.TabStop = true;
				this.rdHoTen.Text = "Họ tên";
				this.rdHoTen.UseVisualStyleBackColor = true;
				// 
				// rdSDT
				// 
				this.rdSDT.AutoSize = true;
				this.rdSDT.Location = new System.Drawing.Point(535, 14);
				this.rdSDT.Name = "rdSDT";
				this.rdSDT.Size = new System.Drawing.Size(112, 21);
				this.rdSDT.TabIndex = 6;
				this.rdSDT.TabStop = true;
				this.rdSDT.Text = "Số điện thoại";
				this.rdSDT.UseVisualStyleBackColor = true;
				// 
				// rdMSSV
				// 
				this.rdMSSV.AutoSize = true;
				this.rdMSSV.Location = new System.Drawing.Point(215, 16);
				this.rdMSSV.Name = "rdMSSV";
				this.rdMSSV.Size = new System.Drawing.Size(67, 21);
				this.rdMSSV.TabIndex = 5;
				this.rdMSSV.TabStop = true;
				this.rdMSSV.Text = "MSSV";
				this.rdMSSV.UseVisualStyleBackColor = true;
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(91, 18);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(75, 17);
				this.label2.TabIndex = 4;
				this.label2.Text = "Tìm theo : ";
				// 
				// menuStrip1
				// 
				this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
				this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpToolStripMenuItem,
            this.lưuToolStripMenuItem,
            this.inToolStripMenuItem});
				this.menuStrip1.Location = new System.Drawing.Point(0, 0);
				this.menuStrip1.Name = "menuStrip1";
				this.menuStrip1.Size = new System.Drawing.Size(1087, 28);
				this.menuStrip1.TabIndex = 5;
				this.menuStrip1.Text = "menuStrip1";
				// 
				// nhậpToolStripMenuItem
				// 
				this.nhậpToolStripMenuItem.Name = "nhậpToolStripMenuItem";
				this.nhậpToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
				this.nhậpToolStripMenuItem.Text = "Nhập";
				// 
				// lưuToolStripMenuItem
				// 
				this.lưuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExcel,
            this.tsmiJson});
				this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
				this.lưuToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
				this.lưuToolStripMenuItem.Text = "Lưu";
				// 
				// tsmiExcel
				// 
				this.tsmiExcel.Name = "tsmiExcel";
				this.tsmiExcel.Size = new System.Drawing.Size(224, 26);
				this.tsmiExcel.Text = "Excel";
				this.tsmiExcel.Click += new System.EventHandler(this.tsmiExcel_Click);
				// 
				// tsmiJson
				// 
				this.tsmiJson.Name = "tsmiJson";
				this.tsmiJson.Size = new System.Drawing.Size(224, 26);
				this.tsmiJson.Text = "Json";
				this.tsmiJson.Click += new System.EventHandler(this.tsmiJson_Click);
				// 
				// inToolStripMenuItem
				// 
				this.inToolStripMenuItem.Name = "inToolStripMenuItem";
				this.inToolStripMenuItem.Size = new System.Drawing.Size(35, 24);
				this.inToolStripMenuItem.Text = "In";
				// 
				// Form1
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(1087, 686);
				this.Controls.Add(this.menuStrip1);
				this.Controls.Add(this.groupBox1);
				this.Controls.Add(this.lvDSSV);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.tvKhoa);
				this.MainMenuStrip = this.menuStrip1;
				this.Name = "Form1";
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				this.Text = "Form1";
				this.Load += new System.EventHandler(this.Form1_Load);
				this.contextMenuStrip1.ResumeLayout(false);
				this.groupBox1.ResumeLayout(false);
				this.groupBox1.PerformLayout();
				this.menuStrip1.ResumeLayout(false);
				this.menuStrip1.PerformLayout();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.TreeView tvKhoa;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.ListView lvDSSV;
		  private System.Windows.Forms.GroupBox groupBox1;
		  private System.Windows.Forms.TextBox txtSearch;
		  private System.Windows.Forms.RadioButton rdHoTen;
		  private System.Windows.Forms.RadioButton rdSDT;
		  private System.Windows.Forms.RadioButton rdMSSV;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.ColumnHeader columnHeader1;
		  private System.Windows.Forms.ColumnHeader columnHeader2;
		  private System.Windows.Forms.ColumnHeader columnHeader3;
		  private System.Windows.Forms.ColumnHeader columnHeader4;
		  private System.Windows.Forms.ColumnHeader columnHeader5;
		  private System.Windows.Forms.ColumnHeader columnHeader6;
		  private System.Windows.Forms.ColumnHeader columnHeader7;
		  private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		  private System.Windows.Forms.ToolStripMenuItem tsmiAddStudent;
		  private System.Windows.Forms.ToolStripMenuItem tsmiDeleteStudent;
		  private System.Windows.Forms.MenuStrip menuStrip1;
		  private System.Windows.Forms.ToolStripMenuItem nhậpToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem tsmiExcel;
		  private System.Windows.Forms.ToolStripMenuItem tsmiJson;
		  private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
		  private System.Windows.Forms.ColumnHeader columnHeader8;
		  private System.Windows.Forms.SaveFileDialog saveFileDlg;
	 }
}

