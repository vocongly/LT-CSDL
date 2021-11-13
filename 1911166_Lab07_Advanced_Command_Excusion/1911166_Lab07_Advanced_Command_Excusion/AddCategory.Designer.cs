
namespace _1911166_Lab07_Advanced_Command_Excusion
{
	 partial class AddCategory
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
				this.txtCategoryName = new System.Windows.Forms.TextBox();
				this.cbbType = new System.Windows.Forms.ComboBox();
				this.btnAddCategory = new System.Windows.Forms.Button();
				this.btnCancelCategory = new System.Windows.Forms.Button();
				this.SuspendLayout();
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(12, 21);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(127, 17);
				this.label1.TabIndex = 0;
				this.label1.Text = "Tên nhóm thức ăn:";
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(12, 50);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(39, 17);
				this.label2.TabIndex = 1;
				this.label2.Text = "Loại:";
				// 
				// txtCategoryName
				// 
				this.txtCategoryName.Location = new System.Drawing.Point(145, 21);
				this.txtCategoryName.Name = "txtCategoryName";
				this.txtCategoryName.Size = new System.Drawing.Size(262, 22);
				this.txtCategoryName.TabIndex = 2;
				// 
				// cbbType
				// 
				this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				this.cbbType.FormattingEnabled = true;
				this.cbbType.Items.AddRange(new object[] {
            "Thức ăn",
            "Đồ uống"});
				this.cbbType.Location = new System.Drawing.Point(145, 50);
				this.cbbType.Name = "cbbType";
				this.cbbType.Size = new System.Drawing.Size(262, 24);
				this.cbbType.TabIndex = 3;
				// 
				// btnAddCategory
				// 
				this.btnAddCategory.Location = new System.Drawing.Point(217, 90);
				this.btnAddCategory.Name = "btnAddCategory";
				this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
				this.btnAddCategory.TabIndex = 4;
				this.btnAddCategory.Text = "Add";
				this.btnAddCategory.UseVisualStyleBackColor = true;
				this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
				// 
				// btnCancelCategory
				// 
				this.btnCancelCategory.Location = new System.Drawing.Point(330, 90);
				this.btnCancelCategory.Name = "btnCancelCategory";
				this.btnCancelCategory.Size = new System.Drawing.Size(75, 23);
				this.btnCancelCategory.TabIndex = 5;
				this.btnCancelCategory.Text = "Cancel";
				this.btnCancelCategory.UseVisualStyleBackColor = true;
				// 
				// AddCategory
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(417, 125);
				this.Controls.Add(this.btnCancelCategory);
				this.Controls.Add(this.btnAddCategory);
				this.Controls.Add(this.cbbType);
				this.Controls.Add(this.txtCategoryName);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.label1);
				this.Name = "AddCategory";
				this.Text = "AddCategory";
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.TextBox txtCategoryName;
		  private System.Windows.Forms.ComboBox cbbType;
		  private System.Windows.Forms.Button btnAddCategory;
		  private System.Windows.Forms.Button btnCancelCategory;
	 }
}