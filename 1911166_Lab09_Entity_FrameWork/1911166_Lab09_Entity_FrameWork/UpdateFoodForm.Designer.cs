
namespace _1911166_Lab09_Entity_FrameWork
{
	 partial class UpdateFoodForm
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
				this.label2 = new System.Windows.Forms.Label();
				this.label3 = new System.Windows.Forms.Label();
				this.label4 = new System.Windows.Forms.Label();
				this.label5 = new System.Windows.Forms.Label();
				this.label6 = new System.Windows.Forms.Label();
				this.txtFoodId = new System.Windows.Forms.TextBox();
				this.txtFoodName = new System.Windows.Forms.TextBox();
				this.cbbFoodCategory = new System.Windows.Forms.ComboBox();
				this.txtFoodUnit = new System.Windows.Forms.TextBox();
				this.nudFoodPrice = new System.Windows.Forms.NumericUpDown();
				this.txtFoodNotes = new System.Windows.Forms.TextBox();
				this.btnSave = new System.Windows.Forms.Button();
				this.btnCancel = new System.Windows.Forms.Button();
				((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).BeginInit();
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
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(13, 47);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(84, 17);
				this.label2.TabIndex = 1;
				this.label2.Text = "Tên món ăn";
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Location = new System.Drawing.Point(13, 81);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(114, 17);
				this.label3.TabIndex = 2;
				this.label3.Text = "Thuộc danh mục";
				// 
				// label4
				// 
				this.label4.AutoSize = true;
				this.label4.Location = new System.Drawing.Point(13, 118);
				this.label4.Name = "label4";
				this.label4.Size = new System.Drawing.Size(75, 17);
				this.label4.TabIndex = 3;
				this.label4.Text = "Đơn vị tính";
				// 
				// label5
				// 
				this.label5.AutoSize = true;
				this.label5.Location = new System.Drawing.Point(13, 153);
				this.label5.Name = "label5";
				this.label5.Size = new System.Drawing.Size(57, 17);
				this.label5.TabIndex = 4;
				this.label5.Text = "Đơn giá";
				// 
				// label6
				// 
				this.label6.AutoSize = true;
				this.label6.Location = new System.Drawing.Point(13, 189);
				this.label6.Name = "label6";
				this.label6.Size = new System.Drawing.Size(91, 17);
				this.label6.TabIndex = 5;
				this.label6.Text = "Ghi chú khác";
				// 
				// txtFoodId
				// 
				this.txtFoodId.Enabled = false;
				this.txtFoodId.Location = new System.Drawing.Point(159, 10);
				this.txtFoodId.Name = "txtFoodId";
				this.txtFoodId.ReadOnly = true;
				this.txtFoodId.Size = new System.Drawing.Size(100, 22);
				this.txtFoodId.TabIndex = 6;
				// 
				// txtFoodName
				// 
				this.txtFoodName.Location = new System.Drawing.Point(159, 44);
				this.txtFoodName.Name = "txtFoodName";
				this.txtFoodName.Size = new System.Drawing.Size(296, 22);
				this.txtFoodName.TabIndex = 7;
				// 
				// cbbFoodCategory
				// 
				this.cbbFoodCategory.FormattingEnabled = true;
				this.cbbFoodCategory.Location = new System.Drawing.Point(159, 78);
				this.cbbFoodCategory.Name = "cbbFoodCategory";
				this.cbbFoodCategory.Size = new System.Drawing.Size(296, 24);
				this.cbbFoodCategory.TabIndex = 8;
				// 
				// txtFoodUnit
				// 
				this.txtFoodUnit.Location = new System.Drawing.Point(159, 115);
				this.txtFoodUnit.Name = "txtFoodUnit";
				this.txtFoodUnit.Size = new System.Drawing.Size(296, 22);
				this.txtFoodUnit.TabIndex = 9;
				// 
				// nudFoodPrice
				// 
				this.nudFoodPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
				this.nudFoodPrice.Location = new System.Drawing.Point(159, 148);
				this.nudFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
				this.nudFoodPrice.Name = "nudFoodPrice";
				this.nudFoodPrice.Size = new System.Drawing.Size(296, 22);
				this.nudFoodPrice.TabIndex = 10;
				this.nudFoodPrice.ThousandsSeparator = true;
				// 
				// txtFoodNotes
				// 
				this.txtFoodNotes.Location = new System.Drawing.Point(159, 186);
				this.txtFoodNotes.Multiline = true;
				this.txtFoodNotes.Name = "txtFoodNotes";
				this.txtFoodNotes.Size = new System.Drawing.Size(296, 77);
				this.txtFoodNotes.TabIndex = 11;
				// 
				// btnSave
				// 
				this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
				this.btnSave.Location = new System.Drawing.Point(282, 284);
				this.btnSave.Name = "btnSave";
				this.btnSave.Size = new System.Drawing.Size(75, 23);
				this.btnSave.TabIndex = 12;
				this.btnSave.Text = "Lưu";
				this.btnSave.UseVisualStyleBackColor = true;
				this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
				// 
				// btnCancel
				// 
				this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
				this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
				this.btnCancel.Location = new System.Drawing.Point(380, 284);
				this.btnCancel.Name = "btnCancel";
				this.btnCancel.Size = new System.Drawing.Size(75, 23);
				this.btnCancel.TabIndex = 13;
				this.btnCancel.Text = "Thoát";
				this.btnCancel.UseVisualStyleBackColor = true;
				this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
				// 
				// UpdateFoodForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(472, 327);
				this.ControlBox = false;
				this.Controls.Add(this.btnCancel);
				this.Controls.Add(this.btnSave);
				this.Controls.Add(this.txtFoodNotes);
				this.Controls.Add(this.nudFoodPrice);
				this.Controls.Add(this.txtFoodUnit);
				this.Controls.Add(this.cbbFoodCategory);
				this.Controls.Add(this.txtFoodName);
				this.Controls.Add(this.txtFoodId);
				this.Controls.Add(this.label6);
				this.Controls.Add(this.label5);
				this.Controls.Add(this.label4);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.label1);
				this.MaximizeBox = false;
				this.MinimizeBox = false;
				this.Name = "UpdateFoodForm";
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
				this.Text = "Thêm/cập nhật món ăn";
				this.Load += new System.EventHandler(this.UpdateFoodForm_Load);
				((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).EndInit();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.Label label4;
		  private System.Windows.Forms.Label label5;
		  private System.Windows.Forms.Label label6;
		  private System.Windows.Forms.TextBox txtFoodId;
		  private System.Windows.Forms.TextBox txtFoodName;
		  private System.Windows.Forms.ComboBox cbbFoodCategory;
		  private System.Windows.Forms.TextBox txtFoodUnit;
		  private System.Windows.Forms.NumericUpDown nudFoodPrice;
		  private System.Windows.Forms.TextBox txtFoodNotes;
		  private System.Windows.Forms.Button btnSave;
		  private System.Windows.Forms.Button btnCancel;
	 }
}