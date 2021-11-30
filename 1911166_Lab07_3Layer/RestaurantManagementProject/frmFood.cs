﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace RestaurantManagementProject
{
	 public partial class frmFood : Form
	 {
		  public frmFood()
		  {
				InitializeComponent();
		  }

		  private void cmdExit_Click(object sender, EventArgs e)
		  {
				Application.Exit();
		  }

		  private void cmdClear_Click(object sender, EventArgs e)
		  {
				txtName.Text = "";
				txtUnit.Text = "0";
				txtPrice.Text = "";
				txtNotes.Text = "";
				if (cbbCategory.Items.Count > 0)
					 cbbCategory.SelectedIndex = 0;
		  }
		  List<Category> listCategory = new List<Category>();
		  List<Food> listFood = new List<Food>();
		  Food foodCurrent = new Food();

		  private void frmFood_Load(object sender, EventArgs e)
		  {
				LoadCategory();
				LoadFoodDataToListView();
		  }
		  private void LoadCategory()
		  {
				CategoryBL categoryBL = new CategoryBL();
				listCategory = categoryBL.GetAll();

				cbbCategory.DataSource = listCategory;
				cbbCategory.ValueMember = "ID";
				cbbCategory.DisplayMember = "Name";
		  }

		  public void LoadFoodDataToListView()
		  {
				FoodBL foodBL = new FoodBL();

				listFood = foodBL.GetAll();

				int count = 1;

				lsvFood.Items.Clear();

				foreach (var food in listFood)
				{
					 ListViewItem item = lsvFood.Items.Add(count.ToString());

					 item.SubItems.Add(food.Name);
					 item.SubItems.Add(food.Unit);
					 item.SubItems.Add(food.Price.ToString());

					 string foodName = listCategory.Find(x => x.ID == food.FoodCategoryID).Name;
					 item.SubItems.Add(foodName);
					 item.SubItems.Add(food.Notes);
					 count++;
				}
		  }

		  private void lsvFood_Click(object sender, EventArgs e)
		  {
				for (int i = 0; i < lsvFood.Items.Count; i++)
				{
					 if (lsvFood.Items[i].Selected)
					 {
						  foodCurrent = listFood[i];
						  txtName.Text = foodCurrent.Name;
						  txtPrice.Text = foodCurrent.Price.ToString();
						  txtUnit.Text = foodCurrent.Unit;
						  txtNotes.Text = foodCurrent.Notes;
						  cbbCategory.SelectedIndex = listCategory.FindIndex(x => x.ID == foodCurrent.FoodCategoryID);

					 }
				}
		  }

		  public int InsertFood()
		  {
				// khai bao doi tuong Food tu tang DataAccess
				Food food = new Food();
				food.ID = 0;

				// kiem tra neu cac o nhap khac rong
				if (txtName.Text == "" || txtPrice.Text == "0" || txtUnit.Text == "")
					 MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
				else
				{
					 food.Name = txtName.Text;
					 food.Unit = txtUnit.Text;
					 food.Notes = txtNotes.Text;
					 int price = 0;
					 try
					 {
						  price = int.Parse(txtPrice.Text);
					 }
					 catch
					 {
						  price = 0;
					 }
					 food.Price = price;
					 // Giá trị FoodCategoryID được lấy từ ComboBox
					 food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
					 // khai báo đối tượng FoodBL từ tầng Business
					 FoodBL foodBL = new FoodBL();
					 // chèn dữ liệu vào bảng
					 return foodBL.Insert(food);
				}
				return -1;
		  }

		  private void cmdAdd_Click(object sender, EventArgs e)
		  {
				int result = InsertFood();
				if (result > 0)
				{
					 MessageBox.Show("Thêm dữ liệu thành công");
					 LoadFoodDataToListView();
				}
				else
					 MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
		  }

		  private void cmdDelete_Click(object sender, EventArgs e)
		  {
				// hỏi người dùng
				if (MessageBox.Show("Bạn có chắc chắn muốn xóa mẫu tin này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					 // khai báo đối tượng FoodBL từ BusinessLogic
					 FoodBL foodBL = new FoodBL();
					 // thuộc tính foodCurrent đã được khai báo khi click chuột vào 1 item trong listview
					 if (foodBL.Delete(foodCurrent) > 0)
					 {
						  MessageBox.Show("Xóa thực phẩm thành công");
						  LoadFoodDataToListView();
					 }
					 else MessageBox.Show("Xóa không thành công");
				}
		  }

		  public int UpdateFood()
		  {
				Food food = foodCurrent;
				if (txtName.Text == "" || txtPrice.Text == "0" || txtUnit.Text == "")
					 MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
				else
				{
					 food.Name = txtName.Text;
					 food.Unit = txtUnit.Text;
					 food.Notes = txtNotes.Text;
					 int price = 0;
					 try
					 {
						  price = int.Parse(txtPrice.Text);
					 }
					 catch
					 {
						  price = 0;
					 }
					 food.Price = price;
					 food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
					 FoodBL foodBL = new FoodBL();
					 return foodBL.Update(food);
				}
				return -1;
		  }

		  private void cmdUpdate_Click(object sender, EventArgs e)
		  {
				int result = UpdateFood();
				if (result > 0)
				{
					 MessageBox.Show("Cập nhật dữ liệu thành công");
					 LoadFoodDataToListView();
				}
				else MessageBox.Show("Cập nhật dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu nhập");
		  }
	 }
}
