
namespace _1911166_Lab02
{
	 partial class SearchForm
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
				this.groupBox1 = new System.Windows.Forms.GroupBox();
				this.rdSDT = new System.Windows.Forms.RadioButton();
				this.rdHoTen = new System.Windows.Forms.RadioButton();
				this.rdMaSo = new System.Windows.Forms.RadioButton();
				this.txtSearch = new System.Windows.Forms.TextBox();
				this.btnOK = new System.Windows.Forms.Button();
				this.label1 = new System.Windows.Forms.Label();
				this.groupBox1.SuspendLayout();
				this.SuspendLayout();
				// 
				// groupBox1
				// 
				this.groupBox1.Controls.Add(this.rdSDT);
				this.groupBox1.Controls.Add(this.rdHoTen);
				this.groupBox1.Controls.Add(this.rdMaSo);
				this.groupBox1.Location = new System.Drawing.Point(12, 12);
				this.groupBox1.Name = "groupBox1";
				this.groupBox1.Size = new System.Drawing.Size(523, 117);
				this.groupBox1.TabIndex = 0;
				this.groupBox1.TabStop = false;
				this.groupBox1.Text = "Tìm kiếm theo";
				// 
				// rdSDT
				// 
				this.rdSDT.AutoSize = true;
				this.rdSDT.Location = new System.Drawing.Point(381, 46);
				this.rdSDT.Name = "rdSDT";
				this.rdSDT.Size = new System.Drawing.Size(118, 24);
				this.rdSDT.TabIndex = 2;
				this.rdSDT.TabStop = true;
				this.rdSDT.Text = "Số điện thoại";
				this.rdSDT.UseVisualStyleBackColor = true;
				this.rdSDT.CheckedChanged += new System.EventHandler(this.rdSDT_CheckedChanged);
				// 
				// rdHoTen
				// 
				this.rdHoTen.AutoSize = true;
				this.rdHoTen.Location = new System.Drawing.Point(210, 46);
				this.rdHoTen.Name = "rdHoTen";
				this.rdHoTen.Size = new System.Drawing.Size(75, 24);
				this.rdHoTen.TabIndex = 1;
				this.rdHoTen.TabStop = true;
				this.rdHoTen.Text = "Họ tên";
				this.rdHoTen.UseVisualStyleBackColor = true;
				this.rdHoTen.CheckedChanged += new System.EventHandler(this.rdHoTen_CheckedChanged);
				// 
				// rdMaSo
				// 
				this.rdMaSo.AutoSize = true;
				this.rdMaSo.Location = new System.Drawing.Point(37, 46);
				this.rdMaSo.Name = "rdMaSo";
				this.rdMaSo.Size = new System.Drawing.Size(70, 24);
				this.rdMaSo.TabIndex = 0;
				this.rdMaSo.TabStop = true;
				this.rdMaSo.Text = "Mã số";
				this.rdMaSo.UseVisualStyleBackColor = true;
				this.rdMaSo.CheckedChanged += new System.EventHandler(this.rdMaSo_CheckedChanged);
				// 
				// txtSearch
				// 
				this.txtSearch.Location = new System.Drawing.Point(161, 146);
				this.txtSearch.Name = "txtSearch";
				this.txtSearch.Size = new System.Drawing.Size(291, 27);
				this.txtSearch.TabIndex = 1;
				// 
				// btnOK
				// 
				this.btnOK.Location = new System.Drawing.Point(470, 144);
				this.btnOK.Name = "btnOK";
				this.btnOK.Size = new System.Drawing.Size(65, 29);
				this.btnOK.TabIndex = 3;
				this.btnOK.Text = "OK";
				this.btnOK.UseVisualStyleBackColor = true;
				this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(49, 148);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(12, 20);
				this.label1.TabIndex = 4;
				this.label1.Text = ".";
				// 
				// SearchForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(547, 200);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.btnOK);
				this.Controls.Add(this.txtSearch);
				this.Controls.Add(this.groupBox1);
				this.Name = "SearchForm";
				this.Text = "SearchForm";
				this.groupBox1.ResumeLayout(false);
				this.groupBox1.PerformLayout();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.GroupBox groupBox1;
		  private System.Windows.Forms.RadioButton rdSDT;
		  private System.Windows.Forms.RadioButton rdHoTen;
		  private System.Windows.Forms.RadioButton rdMaSo;
		  private System.Windows.Forms.TextBox txtSearch;
		  private System.Windows.Forms.Button btnOK;
		  private System.Windows.Forms.Label label1;
	 }
}