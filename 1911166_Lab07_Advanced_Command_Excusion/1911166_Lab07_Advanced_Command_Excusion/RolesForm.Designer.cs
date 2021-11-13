
namespace _1911166_Lab07_Advanced_Command_Excusion
{
	 partial class RolesForm
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
				this.btnCancel = new System.Windows.Forms.Button();
				this.btnUpdateRoles = new System.Windows.Forms.Button();
				this.lvRoles = new System.Windows.Forms.ListView();
				this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.label1 = new System.Windows.Forms.Label();
				this.txtaccountName = new System.Windows.Forms.TextBox();
				this.SuspendLayout();
				// 
				// btnCancel
				// 
				this.btnCancel.Location = new System.Drawing.Point(582, 333);
				this.btnCancel.Name = "btnCancel";
				this.btnCancel.Size = new System.Drawing.Size(75, 23);
				this.btnCancel.TabIndex = 1;
				this.btnCancel.Text = "Cancel";
				this.btnCancel.UseVisualStyleBackColor = true;
				this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
				// 
				// btnUpdateRoles
				// 
				this.btnUpdateRoles.Location = new System.Drawing.Point(492, 333);
				this.btnUpdateRoles.Name = "btnUpdateRoles";
				this.btnUpdateRoles.Size = new System.Drawing.Size(75, 23);
				this.btnUpdateRoles.TabIndex = 2;
				this.btnUpdateRoles.Text = "Cập nhật";
				this.btnUpdateRoles.UseVisualStyleBackColor = true;
				this.btnUpdateRoles.Click += new System.EventHandler(this.btnUpdateRoles_Click);
				// 
				// lvRoles
				// 
				this.lvRoles.CheckBoxes = true;
				this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
				this.lvRoles.FullRowSelect = true;
				this.lvRoles.GridLines = true;
				this.lvRoles.HideSelection = false;
				this.lvRoles.Location = new System.Drawing.Point(12, 58);
				this.lvRoles.Name = "lvRoles";
				this.lvRoles.Size = new System.Drawing.Size(641, 269);
				this.lvRoles.TabIndex = 4;
				this.lvRoles.UseCompatibleStateImageBehavior = false;
				this.lvRoles.View = System.Windows.Forms.View.Details;
				// 
				// columnHeader1
				// 
				this.columnHeader1.Text = "ID";
				this.columnHeader1.Width = 67;
				// 
				// columnHeader2
				// 
				this.columnHeader2.Text = "Vai trò";
				this.columnHeader2.Width = 591;
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(13, 22);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(107, 17);
				this.label1.TabIndex = 5;
				this.label1.Text = "Tên tài khoản : ";
				// 
				// txtaccountName
				// 
				this.txtaccountName.Enabled = false;
				this.txtaccountName.Location = new System.Drawing.Point(126, 19);
				this.txtaccountName.Name = "txtaccountName";
				this.txtaccountName.Size = new System.Drawing.Size(188, 22);
				this.txtaccountName.TabIndex = 6;
				// 
				// RolesForm
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(665, 363);
				this.Controls.Add(this.txtaccountName);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.lvRoles);
				this.Controls.Add(this.btnUpdateRoles);
				this.Controls.Add(this.btnCancel);
				this.Name = "RolesForm";
				this.Text = "RolesForm";
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Button btnCancel;
		  private System.Windows.Forms.Button btnUpdateRoles;
		  private System.Windows.Forms.ListView lvRoles;
		  private System.Windows.Forms.ColumnHeader columnHeader1;
		  private System.Windows.Forms.ColumnHeader columnHeader2;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.TextBox txtaccountName;
	 }
}