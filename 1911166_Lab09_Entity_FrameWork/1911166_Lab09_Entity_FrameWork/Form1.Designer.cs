
namespace _1911166_Lab09_Entity_FrameWork
{
	 partial class MainForm
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
				this.tvwCategory = new System.Windows.Forms.TreeView();
				this.lvwFood = new System.Windows.Forms.ListView();
				this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.label1 = new System.Windows.Forms.Label();
				this.label2 = new System.Windows.Forms.Label();
				this.btnReloadCategory = new System.Windows.Forms.Button();
				this.btnAddCategory = new System.Windows.Forms.Button();
				this.btnAddFood = new System.Windows.Forms.Button();
				this.btnReloadFood = new System.Windows.Forms.Button();
				this.btnDelete = new System.Windows.Forms.Button();
				this.SuspendLayout();
				// 
				// tvwCategory
				// 
				this.tvwCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
				this.tvwCategory.Location = new System.Drawing.Point(2, 46);
				this.tvwCategory.Name = "tvwCategory";
				this.tvwCategory.Size = new System.Drawing.Size(243, 438);
				this.tvwCategory.TabIndex = 0;
				this.tvwCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwCategory_AfterSelect);
				this.tvwCategory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwCategory_NodeMouseDoubleClick);
				// 
				// lvwFood
				// 
				this.lvwFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
				this.lvwFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
				this.lvwFood.FullRowSelect = true;
				this.lvwFood.GridLines = true;
				this.lvwFood.HideSelection = false;
				this.lvwFood.Location = new System.Drawing.Point(262, 46);
				this.lvwFood.MultiSelect = false;
				this.lvwFood.Name = "lvwFood";
				this.lvwFood.Size = new System.Drawing.Size(591, 431);
				this.lvwFood.TabIndex = 1;
				this.lvwFood.UseCompatibleStateImageBehavior = false;
				this.lvwFood.View = System.Windows.Forms.View.Details;
				this.lvwFood.DoubleClick += new System.EventHandler(this.lvwFood_DoubleClick);
				// 
				// columnHeader1
				// 
				this.columnHeader1.Text = "Mã số";
				// 
				// columnHeader2
				// 
				this.columnHeader2.Text = "Tên đồ ăn/thức uống";
				this.columnHeader2.Width = 162;
				// 
				// columnHeader3
				// 
				this.columnHeader3.Text = "ĐV Tính";
				// 
				// columnHeader4
				// 
				this.columnHeader4.Text = "Giá bán";
				// 
				// columnHeader5
				// 
				this.columnHeader5.Text = "Nhóm mặt hàng";
				this.columnHeader5.Width = 126;
				// 
				// columnHeader6
				// 
				this.columnHeader6.Text = "Ghi chú";
				this.columnHeader6.Width = 134;
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(13, 13);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(72, 17);
				this.label1.TabIndex = 2;
				this.label1.Text = "Danh mục";
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(259, 13);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(68, 17);
				this.label2.TabIndex = 3;
				this.label2.Text = "Thực đơn";
				// 
				// btnReloadCategory
				// 
				this.btnReloadCategory.Location = new System.Drawing.Point(155, 10);
				this.btnReloadCategory.Name = "btnReloadCategory";
				this.btnReloadCategory.Size = new System.Drawing.Size(42, 23);
				this.btnReloadCategory.TabIndex = 4;
				this.btnReloadCategory.Text = "R";
				this.btnReloadCategory.UseVisualStyleBackColor = true;
				this.btnReloadCategory.Click += new System.EventHandler(this.btnReloadCategory_Click);
				// 
				// btnAddCategory
				// 
				this.btnAddCategory.Location = new System.Drawing.Point(203, 10);
				this.btnAddCategory.Name = "btnAddCategory";
				this.btnAddCategory.Size = new System.Drawing.Size(42, 23);
				this.btnAddCategory.TabIndex = 5;
				this.btnAddCategory.Text = "+";
				this.btnAddCategory.UseVisualStyleBackColor = true;
				this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
				// 
				// btnAddFood
				// 
				this.btnAddFood.Location = new System.Drawing.Point(790, 10);
				this.btnAddFood.Name = "btnAddFood";
				this.btnAddFood.Size = new System.Drawing.Size(42, 23);
				this.btnAddFood.TabIndex = 7;
				this.btnAddFood.Text = "+";
				this.btnAddFood.UseVisualStyleBackColor = true;
				this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
				// 
				// btnReloadFood
				// 
				this.btnReloadFood.Location = new System.Drawing.Point(694, 10);
				this.btnReloadFood.Name = "btnReloadFood";
				this.btnReloadFood.Size = new System.Drawing.Size(42, 23);
				this.btnReloadFood.TabIndex = 6;
				this.btnReloadFood.Text = "R";
				this.btnReloadFood.UseVisualStyleBackColor = true;
				this.btnReloadFood.Click += new System.EventHandler(this.btnReloadFood_Click);
				// 
				// btnDelete
				// 
				this.btnDelete.Location = new System.Drawing.Point(742, 10);
				this.btnDelete.Name = "btnDelete";
				this.btnDelete.Size = new System.Drawing.Size(42, 23);
				this.btnDelete.TabIndex = 8;
				this.btnDelete.Text = "-";
				this.btnDelete.UseVisualStyleBackColor = true;
				this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
				// 
				// MainForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(844, 487);
				this.Controls.Add(this.btnDelete);
				this.Controls.Add(this.btnAddFood);
				this.Controls.Add(this.btnReloadFood);
				this.Controls.Add(this.btnAddCategory);
				this.Controls.Add(this.btnReloadCategory);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.lvwFood);
				this.Controls.Add(this.tvwCategory);
				this.Name = "MainForm";
				this.Text = "Form1";
				this.Load += new System.EventHandler(this.MainForm_Load);
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.TreeView tvwCategory;
		  private System.Windows.Forms.ListView lvwFood;
		  private System.Windows.Forms.ColumnHeader columnHeader1;
		  private System.Windows.Forms.ColumnHeader columnHeader2;
		  private System.Windows.Forms.ColumnHeader columnHeader3;
		  private System.Windows.Forms.ColumnHeader columnHeader4;
		  private System.Windows.Forms.ColumnHeader columnHeader5;
		  private System.Windows.Forms.ColumnHeader columnHeader6;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.Button btnReloadCategory;
		  private System.Windows.Forms.Button btnAddCategory;
		  private System.Windows.Forms.Button btnAddFood;
		  private System.Windows.Forms.Button btnReloadFood;
		  private System.Windows.Forms.Button btnDelete;
	 }
}

