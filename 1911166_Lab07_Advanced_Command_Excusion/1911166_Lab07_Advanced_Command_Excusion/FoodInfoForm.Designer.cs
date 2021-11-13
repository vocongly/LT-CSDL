
namespace _1911166_Lab07_Advanced_Command_Excusion
{
	 partial class FoodInfoForm
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
				this.txtFoodID = new System.Windows.Forms.TextBox();
				this.txtName = new System.Windows.Forms.TextBox();
				this.txtUnit = new System.Windows.Forms.TextBox();
				this.label2 = new System.Windows.Forms.Label();
				this.label3 = new System.Windows.Forms.Label();
				this.label4 = new System.Windows.Forms.Label();
				this.cbbCatName = new System.Windows.Forms.ComboBox();
				this.btnAddNew = new System.Windows.Forms.Button();
				this.nudPrice = new System.Windows.Forms.NumericUpDown();
				this.label5 = new System.Windows.Forms.Label();
				this.txtNotes = new System.Windows.Forms.TextBox();
				this.label6 = new System.Windows.Forms.Label();
				this.btnAddFood = new System.Windows.Forms.Button();
				this.btnUpdate = new System.Windows.Forms.Button();
				this.btnCancel = new System.Windows.Forms.Button();
				((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
				this.SuspendLayout();
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(24, 26);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(53, 17);
				this.label1.TabIndex = 0;
				this.label1.Text = "FoodID";
				// 
				// txtFoodID
				// 
				this.txtFoodID.Enabled = false;
				this.txtFoodID.Location = new System.Drawing.Point(136, 21);
				this.txtFoodID.Name = "txtFoodID";
				this.txtFoodID.ReadOnly = true;
				this.txtFoodID.Size = new System.Drawing.Size(123, 22);
				this.txtFoodID.TabIndex = 2;
				// 
				// txtName
				// 
				this.txtName.Location = new System.Drawing.Point(136, 57);
				this.txtName.Name = "txtName";
				this.txtName.Size = new System.Drawing.Size(326, 22);
				this.txtName.TabIndex = 3;
				// 
				// txtUnit
				// 
				this.txtUnit.Location = new System.Drawing.Point(136, 96);
				this.txtUnit.Name = "txtUnit";
				this.txtUnit.Size = new System.Drawing.Size(326, 22);
				this.txtUnit.TabIndex = 4;
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(24, 62);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(45, 17);
				this.label2.TabIndex = 1;
				this.label2.Text = "Name";
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Location = new System.Drawing.Point(24, 99);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(33, 17);
				this.label3.TabIndex = 5;
				this.label3.Text = "Unit";
				// 
				// label4
				// 
				this.label4.AutoSize = true;
				this.label4.Location = new System.Drawing.Point(24, 137);
				this.label4.Name = "label4";
				this.label4.Size = new System.Drawing.Size(102, 17);
				this.label4.TabIndex = 6;
				this.label4.Text = "CategoryName";
				// 
				// cbbCatName
				// 
				this.cbbCatName.FormattingEnabled = true;
				this.cbbCatName.Location = new System.Drawing.Point(136, 134);
				this.cbbCatName.Name = "cbbCatName";
				this.cbbCatName.Size = new System.Drawing.Size(245, 24);
				this.cbbCatName.TabIndex = 7;
				// 
				// btnAddNew
				// 
				this.btnAddNew.Location = new System.Drawing.Point(387, 134);
				this.btnAddNew.Name = "btnAddNew";
				this.btnAddNew.Size = new System.Drawing.Size(75, 24);
				this.btnAddNew.TabIndex = 8;
				this.btnAddNew.Text = "Add New";
				this.btnAddNew.UseVisualStyleBackColor = true;
				this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
				// 
				// nudPrice
				// 
				this.nudPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
				this.nudPrice.Location = new System.Drawing.Point(136, 175);
				this.nudPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
				this.nudPrice.Name = "nudPrice";
				this.nudPrice.Size = new System.Drawing.Size(326, 22);
				this.nudPrice.TabIndex = 9;
				// 
				// label5
				// 
				this.label5.AutoSize = true;
				this.label5.Location = new System.Drawing.Point(24, 177);
				this.label5.Name = "label5";
				this.label5.Size = new System.Drawing.Size(40, 17);
				this.label5.TabIndex = 10;
				this.label5.Text = "Price";
				// 
				// txtNotes
				// 
				this.txtNotes.Location = new System.Drawing.Point(136, 215);
				this.txtNotes.Name = "txtNotes";
				this.txtNotes.Size = new System.Drawing.Size(326, 22);
				this.txtNotes.TabIndex = 11;
				// 
				// label6
				// 
				this.label6.AutoSize = true;
				this.label6.Location = new System.Drawing.Point(24, 218);
				this.label6.Name = "label6";
				this.label6.Size = new System.Drawing.Size(45, 17);
				this.label6.TabIndex = 12;
				this.label6.Text = "Notes";
				// 
				// btnAddFood
				// 
				this.btnAddFood.Location = new System.Drawing.Point(136, 253);
				this.btnAddFood.Name = "btnAddFood";
				this.btnAddFood.Size = new System.Drawing.Size(75, 24);
				this.btnAddFood.TabIndex = 13;
				this.btnAddFood.Text = "Add";
				this.btnAddFood.UseVisualStyleBackColor = true;
				this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
				// 
				// btnUpdate
				// 
				this.btnUpdate.Location = new System.Drawing.Point(258, 253);
				this.btnUpdate.Name = "btnUpdate";
				this.btnUpdate.Size = new System.Drawing.Size(75, 24);
				this.btnUpdate.TabIndex = 14;
				this.btnUpdate.Text = "Update";
				this.btnUpdate.UseVisualStyleBackColor = true;
				this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
				// 
				// btnCancel
				// 
				this.btnCancel.Location = new System.Drawing.Point(376, 253);
				this.btnCancel.Name = "btnCancel";
				this.btnCancel.Size = new System.Drawing.Size(75, 24);
				this.btnCancel.TabIndex = 15;
				this.btnCancel.Text = "Cancel";
				this.btnCancel.UseVisualStyleBackColor = true;
				this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
				// 
				// FoodInfoForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(482, 302);
				this.Controls.Add(this.btnCancel);
				this.Controls.Add(this.btnUpdate);
				this.Controls.Add(this.btnAddFood);
				this.Controls.Add(this.label6);
				this.Controls.Add(this.txtNotes);
				this.Controls.Add(this.label5);
				this.Controls.Add(this.nudPrice);
				this.Controls.Add(this.btnAddNew);
				this.Controls.Add(this.cbbCatName);
				this.Controls.Add(this.label4);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.txtUnit);
				this.Controls.Add(this.txtName);
				this.Controls.Add(this.txtFoodID);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.label1);
				this.Name = "FoodInfoForm";
				this.Text = "FoodInfoForm";
				this.Load += new System.EventHandler(this.FoodInfoForm_Load);
				((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.TextBox txtFoodID;
		  private System.Windows.Forms.TextBox txtName;
		  private System.Windows.Forms.TextBox txtUnit;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.Label label4;
		  private System.Windows.Forms.ComboBox cbbCatName;
		  private System.Windows.Forms.Button btnAddNew;
		  private System.Windows.Forms.NumericUpDown nudPrice;
		  private System.Windows.Forms.Label label5;
		  private System.Windows.Forms.TextBox txtNotes;
		  private System.Windows.Forms.Label label6;
		  private System.Windows.Forms.Button btnAddFood;
		  private System.Windows.Forms.Button btnUpdate;
		  private System.Windows.Forms.Button btnCancel;
	 }
}