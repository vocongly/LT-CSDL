
namespace RestaurantManagementProject
{
	 partial class AddCategoryForm
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
				this.btnCancelCategory = new System.Windows.Forms.Button();
				this.btnAddCategory = new System.Windows.Forms.Button();
				this.cbbType = new System.Windows.Forms.ComboBox();
				this.txtCategoryName = new System.Windows.Forms.TextBox();
				this.label2 = new System.Windows.Forms.Label();
				this.label1 = new System.Windows.Forms.Label();
				this.SuspendLayout();
				// 
				// btnCancelCategory
				// 
				this.btnCancelCategory.Location = new System.Drawing.Point(330, 78);
				this.btnCancelCategory.Name = "btnCancelCategory";
				this.btnCancelCategory.Size = new System.Drawing.Size(75, 23);
				this.btnCancelCategory.TabIndex = 11;
				this.btnCancelCategory.Text = "Cancel";
				this.btnCancelCategory.UseVisualStyleBackColor = true;
				this.btnCancelCategory.Click += new System.EventHandler(this.btnCancelCategory_Click);
				// 
				// btnAddCategory
				// 
				this.btnAddCategory.Location = new System.Drawing.Point(217, 78);
				this.btnAddCategory.Name = "btnAddCategory";
				this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
				this.btnAddCategory.TabIndex = 10;
				this.btnAddCategory.Text = "Add";
				this.btnAddCategory.UseVisualStyleBackColor = true;
				this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
				// 
				// cbbType
				// 
				this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				this.cbbType.FormattingEnabled = true;
				this.cbbType.Items.AddRange(new object[] {
            "Thức ăn",
            "Đồ uống"});
				this.cbbType.Location = new System.Drawing.Point(145, 38);
				this.cbbType.Name = "cbbType";
				this.cbbType.Size = new System.Drawing.Size(262, 24);
				this.cbbType.TabIndex = 9;
				// 
				// txtCategoryName
				// 
				this.txtCategoryName.Location = new System.Drawing.Point(145, 9);
				this.txtCategoryName.Name = "txtCategoryName";
				this.txtCategoryName.Size = new System.Drawing.Size(262, 22);
				this.txtCategoryName.TabIndex = 8;
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(12, 38);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(39, 17);
				this.label2.TabIndex = 7;
				this.label2.Text = "Loại:";
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(12, 9);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(127, 17);
				this.label1.TabIndex = 6;
				this.label1.Text = "Tên nhóm thức ăn:";
				// 
				// AddCategoryForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(423, 110);
				this.Controls.Add(this.btnCancelCategory);
				this.Controls.Add(this.btnAddCategory);
				this.Controls.Add(this.cbbType);
				this.Controls.Add(this.txtCategoryName);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.label1);
				this.Name = "AddCategoryForm";
				this.Text = "AddCategoryForm";
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Button btnCancelCategory;
		  private System.Windows.Forms.Button btnAddCategory;
		  private System.Windows.Forms.ComboBox cbbType;
		  private System.Windows.Forms.TextBox txtCategoryName;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.Label label1;
	 }
}