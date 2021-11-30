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
	 public partial class FoodInfoForm : Form
	 {
		  Food foodCurrent = new Food();
		  FoodBL foodBL = new FoodBL();
		  public FoodInfoForm()
		  {
				InitializeComponent();
		  }

		  private void FoodInfoForm_Load(object sender, EventArgs e)
		  {
				LoadCategory();
		  }

		  private void ResetText()
		  {
				txtFoodID.ResetText();
				txtName.ResetText();
				txtNotes.ResetText();
				txtUnit.ResetText();
				cbbCatName.ResetText();
				nudPrice.ResetText();
		  }
		  List<Category> listCategory = new List<Category>();
		  private void LoadCategory()
		  {
				CategoryBL categoryBL = new CategoryBL();
				listCategory = categoryBL.GetAll();
				cbbCatName.DataSource = listCategory;
				cbbCatName.DisplayMember = "Name";
				cbbCatName.ValueMember = "ID";
		  }

		  public int InsertFood()
		  {
				// khai bao doi tuong Food tu tang DataAccess
				Food food = new Food();
				food.ID = 0;

				// kiem tra neu cac o nhap khac rong
				if (txtName.Text == "" || nudPrice.Text == "0" || txtUnit.Text == "")
					 MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
				else
				{
					 food.Name = txtName.Text;
					 food.Unit = txtUnit.Text;
					 food.Notes = txtNotes.Text;
					 int price = 0;
					 try
					 {
						  price = int.Parse(nudPrice.Text);
					 }
					 catch
					 {
						  price = 0;
					 }
					 food.Price = price;
					 // Giá trị FoodCategoryID được lấy từ ComboBox
					 food.FoodCategoryID = int.Parse(cbbCatName.SelectedValue.ToString());
					 // khai báo đối tượng FoodBL từ tầng Business
					 FoodBL foodBL = new FoodBL();
					 // chèn dữ liệu vào bảng
					 return foodBL.Insert(food);
				}
				return -1;
		  }

		  private void btnAddFood_Click(object sender, EventArgs e)
		  {
				int result = InsertFood();
				if(result > 0)
				{
					 MessageBox.Show("Thêm món ăn thành công");
					 this.ResetText();
					 this.Close();
				}
				else
				{
					 MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu");
				}
		  }

		  public void DisplayFood(Food rowView)
		  {
				foodCurrent = foodBL.GetByID(rowView.ID);

				try
				{
					 txtFoodID.Text = rowView.ID.ToString();
					 txtName.Text = rowView.Name.ToString();
					 txtUnit.Text = rowView.Unit.ToString();
					 nudPrice.Text = rowView.Price.ToString();
					 txtNotes.Text = rowView.Notes.ToString();

					 cbbCatName.SelectedIndex = -1;

					 // chọn nhóm ăn tương ứng
					 for (int index = 0; index < cbbCatName.Items.Count; index++)
					 {
						  Category cat = cbbCatName.Items[index] as Category;
						  if (cat.ID.ToString() == rowView.FoodCategoryID.ToString())
						  {
								cbbCatName.SelectedIndex = index;
								break;
						  }
					 }
				}
				catch(Exception exception)
				{
					 MessageBox.Show(exception.Message, "Error");
					 this.Close();
				}
		  }

		  public int UpdateFood()
		  {
				Food food = foodCurrent;
				if (txtName.Text == "" || nudPrice.Text == "0" || txtUnit.Text == "")
					 MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
				else
				{
					 food.Name = txtName.Text;
					 food.Unit = txtUnit.Text;
					 food.Notes = txtNotes.Text;
					 int price = 0;
					 try
					 {
						  price = int.Parse(nudPrice.Text);
					 }
					 catch
					 {
						  price = 0;
					 }
					 food.Price = price;
					 food.FoodCategoryID = int.Parse(cbbCatName.SelectedValue.ToString());
					 FoodBL foodBL = new FoodBL();
					 return foodBL.Update(food);
				}
				return -1;
		  }

		  private void btnUpdate_Click(object sender, EventArgs e)
		  {
				int result = UpdateFood();
				if(result > 0)
				{
					 MessageBox.Show("Cập nhật món ăn thành công");
					 this.ResetText();
					 this.Close();
				}
				else
				{
					 MessageBox.Show("Cập nhật món ăn thất bại. Vui lòng kiểm tra lại dữ liệu");
				}
		  }

		  private void btnCancel_Click(object sender, EventArgs e)
		  {
				this.Close();
		  }

		  private void btnAddNew_Click(object sender, EventArgs e)
		  {
				AddCategoryForm frm = new AddCategoryForm();
				if(frm.ShowDialog(this) == DialogResult.OK)
				{
					 this.LoadCategory();
				}
		  }
	 }
}
