
namespace _1911166_Lab02
{
	 partial class TBGiaoVienForm
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
				this.lbThongBao = new System.Windows.Forms.Label();
				this.SuspendLayout();
				// 
				// lbThongBao
				// 
				this.lbThongBao.AutoSize = true;
				this.lbThongBao.ForeColor = System.Drawing.Color.Fuchsia;
				this.lbThongBao.Location = new System.Drawing.Point(39, 38);
				this.lbThongBao.Name = "lbThongBao";
				this.lbThongBao.Size = new System.Drawing.Size(50, 20);
				this.lbThongBao.TabIndex = 0;
				this.lbThongBao.Text = "label1";
				// 
				// TBGiaoVienForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(501, 396);
				this.Controls.Add(this.lbThongBao);
				this.Name = "TBGiaoVienForm";
				this.Text = "TBGiaoVienForm";
				this.Load += new System.EventHandler(this.TBGiaoVienForm_Load);
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Label lbThongBao;
	 }
}