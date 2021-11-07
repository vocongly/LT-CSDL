
namespace _1911166_Lab06_Basic_Command
{
	 partial class AddTable
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
				this.txtTableName = new System.Windows.Forms.TextBox();
				this.label2 = new System.Windows.Forms.Label();
				this.label3 = new System.Windows.Forms.Label();
				this.btnAdd = new System.Windows.Forms.Button();
				this.btnUpdate = new System.Windows.Forms.Button();
				this.cbbStatus = new System.Windows.Forms.ComboBox();
				this.nudCapacity = new System.Windows.Forms.NumericUpDown();
				((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
				this.SuspendLayout();
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(13, 13);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(65, 17);
				this.label1.TabIndex = 0;
				this.label1.Text = "Tên bàn ";
				// 
				// txtTableName
				// 
				this.txtTableName.Location = new System.Drawing.Point(113, 10);
				this.txtTableName.Name = "txtTableName";
				this.txtTableName.Size = new System.Drawing.Size(188, 22);
				this.txtTableName.TabIndex = 1;
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(13, 48);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(73, 17);
				this.label2.TabIndex = 2;
				this.label2.Text = "Trạng thái";
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Location = new System.Drawing.Point(19, 85);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(67, 17);
				this.label3.TabIndex = 4;
				this.label3.Text = "Sức chứa";
				// 
				// btnAdd
				// 
				this.btnAdd.Location = new System.Drawing.Point(226, 124);
				this.btnAdd.Name = "btnAdd";
				this.btnAdd.Size = new System.Drawing.Size(75, 23);
				this.btnAdd.TabIndex = 6;
				this.btnAdd.Text = "Thêm";
				this.btnAdd.UseVisualStyleBackColor = true;
				this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
				// 
				// btnUpdate
				// 
				this.btnUpdate.Location = new System.Drawing.Point(133, 124);
				this.btnUpdate.Name = "btnUpdate";
				this.btnUpdate.Size = new System.Drawing.Size(75, 23);
				this.btnUpdate.TabIndex = 7;
				this.btnUpdate.Text = "Cập nhật";
				this.btnUpdate.UseVisualStyleBackColor = true;
				this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
				// 
				// cbbStatus
				// 
				this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				this.cbbStatus.FormattingEnabled = true;
				this.cbbStatus.Items.AddRange(new object[] {
            "0",
            "1"});
				this.cbbStatus.Location = new System.Drawing.Point(113, 45);
				this.cbbStatus.Name = "cbbStatus";
				this.cbbStatus.Size = new System.Drawing.Size(188, 24);
				this.cbbStatus.TabIndex = 8;
				// 
				// nudCapacity
				// 
				this.nudCapacity.Location = new System.Drawing.Point(113, 83);
				this.nudCapacity.Name = "nudCapacity";
				this.nudCapacity.Size = new System.Drawing.Size(188, 22);
				this.nudCapacity.TabIndex = 9;
				// 
				// AddTable
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(332, 177);
				this.Controls.Add(this.nudCapacity);
				this.Controls.Add(this.cbbStatus);
				this.Controls.Add(this.btnUpdate);
				this.Controls.Add(this.btnAdd);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.txtTableName);
				this.Controls.Add(this.label1);
				this.Name = "AddTable";
				this.Text = "AddTable";
				((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.TextBox txtTableName;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.Button btnAdd;
		  private System.Windows.Forms.Button btnUpdate;
		  private System.Windows.Forms.ComboBox cbbStatus;
		  private System.Windows.Forms.NumericUpDown nudCapacity;
	 }
}