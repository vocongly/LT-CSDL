using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementProject
{
	 public partial class AddCategoryForm : Form
	 {
		  public AddCategoryForm()
		  {
				InitializeComponent();
		  }

		  private void btnCancelCategory_Click(object sender, EventArgs e)
		  {
				this.Close();
		  }

		  private int InsertCategory()
		  {
				Category category = new Category();
				category.ID = 0;
				int number = 0;
				if(txtCategoryName.Text == "" && cbbType.Text == "")
				{
					 MessageBox.Show("Thiếu dữ liệu của các ô. Vui lòng nhập");
				}
				else
				{
					 if(cbbType.Text.ToLower() == "thức ăn")
					 {
						  number = 1;
					 }
					 category.Name = txtCategoryName.Text.Trim();
					 category.Type = number;

					 CategoryBL categoryBL = new CategoryBL();
					 return categoryBL.Insert(category);
				}
				return -1;
		  }

		  private void btnAddCategory_Click(object sender, EventArgs e)
		  {
				int result = InsertCategory();
				if(result > 0)
				{
					 MessageBox.Show("Thêm nhóm món ăn thành công");
					 this.Close();
					 this.DialogResult = DialogResult.OK;
				}
				else
				{
					 MessageBox.Show("Thêm nhóm món ăn thất bại. Vui lòng thử lại");
				}
		  }
	 }
}
