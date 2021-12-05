
namespace _1911166_Lab09_Entity_FrameWork
{
	 partial class UpdateCategoryForm
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
				this.label1 = new System.Windows.Forms.Label();
				this.txtCategoryId = new System.Windows.Forms.TextBox();
				this.label2 = new System.Windows.Forms.Label();
				this.txtCategoryName = new System.Windows.Forms.TextBox();
				this.label3 = new System.Windows.Forms.Label();
				this.cbbCategoryType = new System.Windows.Forms.ComboBox();
				this.btnCancel = new System.Windows.Forms.Button();
				this.btnSave = new System.Windows.Forms.Button();
				this.SuspendLayout();
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(13, 13);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(46, 17);
				this.label1.TabIndex = 0;
				this.label1.Text = "Mã số";
				// 
				// txtCategoryId
				// 
				this.txtCategoryId.Enabled = false;
				this.txtCategoryId.Location = new System.Drawing.Point(142, 10);
				this.txtCategoryId.Name = "txtCategoryId";
				this.txtCategoryId.ReadOnly = true;
				this.txtCategoryId.Size = new System.Drawing.Size(100, 22);
				this.txtCategoryId.TabIndex = 1;
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(13, 47);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(123, 17);
				this.label2.TabIndex = 2;
				this.label2.Text = "Tên nhóm thức ăn";
				// 
				// txtCategoryName
				// 
				this.txtCategoryName.Location = new System.Drawing.Point(142, 44);
				this.txtCategoryName.Name = "txtCategoryName";
				this.txtCategoryName.Size = new System.Drawing.Size(291, 22);
				this.txtCategoryName.TabIndex = 3;
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Location = new System.Drawing.Point(13, 83);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(35, 17);
				this.label3.TabIndex = 4;
				this.label3.Text = "Loại";
				// 
				// cbbCategoryType
				// 
				this.cbbCategoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				this.cbbCategoryType.FormattingEnabled = true;
				this.cbbCategoryType.Items.AddRange(new object[] {
            "Thức uống",
            "Đồ ăn"});
				this.cbbCategoryType.Location = new System.Drawing.Point(142, 80);
				this.cbbCategoryType.Name = "cbbCategoryType";
				this.cbbCategoryType.Size = new System.Drawing.Size(291, 24);
				this.cbbCategoryType.TabIndex = 5;
				// 
				// btnCancel
				// 
				this.btnCancel.Location = new System.Drawing.Point(358, 126);
				this.btnCancel.Name = "btnCancel";
				this.btnCancel.Size = new System.Drawing.Size(75, 23);
				this.btnCancel.TabIndex = 6;
				this.btnCancel.Text = "Thoát";
				this.btnCancel.UseVisualStyleBackColor = true;
				this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
				// 
				// btnSave
				// 
				this.btnSave.Location = new System.Drawing.Point(260, 126);
				this.btnSave.Name = "btnSave";
				this.btnSave.Size = new System.Drawing.Size(75, 23);
				this.btnSave.TabIndex = 7;
				this.btnSave.Text = "Lưu";
				this.btnSave.UseVisualStyleBackColor = true;
				this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
				// 
				// UpdateCategoryForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(446, 167);
				this.Controls.Add(this.btnSave);
				this.Controls.Add(this.btnCancel);
				this.Controls.Add(this.cbbCategoryType);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.txtCategoryName);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.txtCategoryId);
				this.Controls.Add(this.label1);
				this.Name = "UpdateCategoryForm";
				this.Text = "Thêm/cập nhật nhóm thực ăn";
				this.Load += new System.EventHandler(this.UpdateCategoryForm_Load);
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.TextBox txtCategoryId;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.TextBox txtCategoryName;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.ComboBox cbbCategoryType;
		  private System.Windows.Forms.Button btnCancel;
		  private System.Windows.Forms.Button btnSave;
	 }
}