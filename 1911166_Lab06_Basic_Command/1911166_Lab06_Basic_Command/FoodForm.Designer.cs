﻿
namespace _1911166_Lab06_Basic_Command
{
	 partial class FoodForm
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
				this.dgvFood = new System.Windows.Forms.DataGridView();
				this.btnSave = new System.Windows.Forms.Button();
				this.btnDelete = new System.Windows.Forms.Button();
				((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
				this.SuspendLayout();
				// 
				// dgvFood
				// 
				this.dgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
				this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				this.dgvFood.Location = new System.Drawing.Point(1, 61);
				this.dgvFood.Name = "dgvFood";
				this.dgvFood.RowHeadersWidth = 51;
				this.dgvFood.RowTemplate.Height = 24;
				this.dgvFood.Size = new System.Drawing.Size(800, 391);
				this.dgvFood.TabIndex = 0;
				// 
				// btnSave
				// 
				this.btnSave.Location = new System.Drawing.Point(612, 12);
				this.btnSave.Name = "btnSave";
				this.btnSave.Size = new System.Drawing.Size(80, 31);
				this.btnSave.TabIndex = 1;
				this.btnSave.Text = "Save";
				this.btnSave.UseVisualStyleBackColor = true;
				this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
				// 
				// btnDelete
				// 
				this.btnDelete.Location = new System.Drawing.Point(708, 12);
				this.btnDelete.Name = "btnDelete";
				this.btnDelete.Size = new System.Drawing.Size(80, 31);
				this.btnDelete.TabIndex = 2;
				this.btnDelete.Text = "Delete";
				this.btnDelete.UseVisualStyleBackColor = true;
				this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
				// 
				// FoodForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(800, 450);
				this.Controls.Add(this.btnDelete);
				this.Controls.Add(this.btnSave);
				this.Controls.Add(this.dgvFood);
				this.Name = "FoodForm";
				this.Text = "FoodForm";
				((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.DataGridView dgvFood;
		  private System.Windows.Forms.Button btnSave;
		  private System.Windows.Forms.Button btnDelete;
	 }
}