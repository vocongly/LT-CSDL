﻿
namespace _1911166_Lab07_Advanced_Command_Excusion
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
				this.dgvFoodList = new System.Windows.Forms.DataGridView();
				this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
				this.tsmCalculateQuantity = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmSeperator = new System.Windows.Forms.ToolStripSeparator();
				this.tsmAddFood = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmUpdateFood = new System.Windows.Forms.ToolStripMenuItem();
				this.label1 = new System.Windows.Forms.Label();
				this.cbbCategory = new System.Windows.Forms.ComboBox();
				this.label2 = new System.Windows.Forms.Label();
				this.label3 = new System.Windows.Forms.Label();
				this.lblQuantity = new System.Windows.Forms.Label();
				this.lblCatName = new System.Windows.Forms.Label();
				this.label4 = new System.Windows.Forms.Label();
				this.txtSearchByName = new System.Windows.Forms.TextBox();
				this.btnOrder = new System.Windows.Forms.Button();
				this.btnAccount = new System.Windows.Forms.Button();
				((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
				this.contextMenuStrip1.SuspendLayout();
				this.SuspendLayout();
				// 
				// dgvFoodList
				// 
				this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				this.dgvFoodList.ContextMenuStrip = this.contextMenuStrip1;
				this.dgvFoodList.Location = new System.Drawing.Point(-3, 119);
				this.dgvFoodList.Name = "dgvFoodList";
				this.dgvFoodList.RowHeadersWidth = 51;
				this.dgvFoodList.RowTemplate.Height = 24;
				this.dgvFoodList.Size = new System.Drawing.Size(800, 361);
				this.dgvFoodList.TabIndex = 0;
				// 
				// contextMenuStrip1
				// 
				this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
				this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculateQuantity,
            this.tsmSeperator,
            this.tsmAddFood,
            this.tsmUpdateFood});
				this.contextMenuStrip1.Name = "contextMenuStrip1";
				this.contextMenuStrip1.Size = new System.Drawing.Size(200, 82);
				// 
				// tsmCalculateQuantity
				// 
				this.tsmCalculateQuantity.Name = "tsmCalculateQuantity";
				this.tsmCalculateQuantity.Size = new System.Drawing.Size(199, 24);
				this.tsmCalculateQuantity.Text = "Calculate Quantity";
				this.tsmCalculateQuantity.Click += new System.EventHandler(this.tsmCalculateQuantity_Click);
				// 
				// tsmSeperator
				// 
				this.tsmSeperator.Name = "tsmSeperator";
				this.tsmSeperator.Size = new System.Drawing.Size(196, 6);
				// 
				// tsmAddFood
				// 
				this.tsmAddFood.Name = "tsmAddFood";
				this.tsmAddFood.Size = new System.Drawing.Size(199, 24);
				this.tsmAddFood.Text = "Add Food";
				this.tsmAddFood.Click += new System.EventHandler(this.tsmAddFood_Click);
				// 
				// tsmUpdateFood
				// 
				this.tsmUpdateFood.Name = "tsmUpdateFood";
				this.tsmUpdateFood.Size = new System.Drawing.Size(199, 24);
				this.tsmUpdateFood.Text = "Update Food";
				this.tsmUpdateFood.Click += new System.EventHandler(this.tsmUpdateFood_Click);
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(12, 80);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(139, 17);
				this.label1.TabIndex = 1;
				this.label1.Text = "Chọn nhóm món ăn: ";
				// 
				// cbbCategory
				// 
				this.cbbCategory.FormattingEnabled = true;
				this.cbbCategory.Location = new System.Drawing.Point(154, 77);
				this.cbbCategory.Name = "cbbCategory";
				this.cbbCategory.Size = new System.Drawing.Size(257, 24);
				this.cbbCategory.TabIndex = 2;
				this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(9, 495);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(68, 17);
				this.label2.TabIndex = 3;
				this.label2.Text = "Có tất cả ";
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Location = new System.Drawing.Point(120, 495);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(137, 17);
				this.label3.TabIndex = 4;
				this.label3.Text = "món ăn thuộc nhóm ";
				// 
				// lblQuantity
				// 
				this.lblQuantity.AutoSize = true;
				this.lblQuantity.Location = new System.Drawing.Point(83, 495);
				this.lblQuantity.Name = "lblQuantity";
				this.lblQuantity.Size = new System.Drawing.Size(20, 17);
				this.lblQuantity.TabIndex = 5;
				this.lblQuantity.Text = "...";
				// 
				// lblCatName
				// 
				this.lblCatName.AutoSize = true;
				this.lblCatName.Location = new System.Drawing.Point(263, 495);
				this.lblCatName.Name = "lblCatName";
				this.lblCatName.Size = new System.Drawing.Size(20, 17);
				this.lblCatName.TabIndex = 6;
				this.lblCatName.Text = "...";
				// 
				// label4
				// 
				this.label4.AutoSize = true;
				this.label4.Location = new System.Drawing.Point(427, 80);
				this.label4.Name = "label4";
				this.label4.Size = new System.Drawing.Size(132, 17);
				this.label4.TabIndex = 7;
				this.label4.Text = "Tìm kiếm theo tên:  ";
				// 
				// txtSearchByName
				// 
				this.txtSearchByName.Location = new System.Drawing.Point(559, 77);
				this.txtSearchByName.Name = "txtSearchByName";
				this.txtSearchByName.Size = new System.Drawing.Size(229, 22);
				this.txtSearchByName.TabIndex = 8;
				this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
				// 
				// btnOrder
				// 
				this.btnOrder.Location = new System.Drawing.Point(679, 12);
				this.btnOrder.Name = "btnOrder";
				this.btnOrder.Size = new System.Drawing.Size(109, 23);
				this.btnOrder.TabIndex = 9;
				this.btnOrder.Text = "Xem hóa đơn";
				this.btnOrder.UseVisualStyleBackColor = true;
				this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
				// 
				// btnAccount
				// 
				this.btnAccount.Location = new System.Drawing.Point(679, 41);
				this.btnAccount.Name = "btnAccount";
				this.btnAccount.Size = new System.Drawing.Size(109, 23);
				this.btnAccount.TabIndex = 10;
				this.btnAccount.Text = "Xem tài khoản";
				this.btnAccount.UseVisualStyleBackColor = true;
				this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
				// 
				// Form1
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(800, 527);
				this.Controls.Add(this.btnAccount);
				this.Controls.Add(this.btnOrder);
				this.Controls.Add(this.txtSearchByName);
				this.Controls.Add(this.label4);
				this.Controls.Add(this.lblCatName);
				this.Controls.Add(this.lblQuantity);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.cbbCategory);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.dgvFoodList);
				this.Name = "Form1";
				this.Text = "Form1";
				this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
				this.Load += new System.EventHandler(this.Form1_Load);
				((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
				this.contextMenuStrip1.ResumeLayout(false);
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.DataGridView dgvFoodList;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.ComboBox cbbCategory;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.Label lblQuantity;
		  private System.Windows.Forms.Label lblCatName;
		  private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		  private System.Windows.Forms.ToolStripMenuItem tsmCalculateQuantity;
		  private System.Windows.Forms.ToolStripMenuItem tsmAddFood;
		  private System.Windows.Forms.ToolStripMenuItem tsmUpdateFood;
		  private System.Windows.Forms.ToolStripSeparator tsmSeperator;
		  private System.Windows.Forms.Label label4;
		  private System.Windows.Forms.TextBox txtSearchByName;
		  private System.Windows.Forms.Button btnOrder;
		  private System.Windows.Forms.Button btnAccount;
	 }
}

