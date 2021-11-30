using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace RestaurantManagementProject
{
	 public partial class FoodForm : Form
	 {
		  public FoodForm()
		  {
				InitializeComponent();
		  }

		  private void FoodForm_Load(object sender, EventArgs e)
		  {
				LoadCategory();
		  }
		  List<Category> listCategory = new List<Category>();
		  List<Food> listFood = new List<Food>();

		  private void LoadCategory()
		  {
				CategoryBL categoryBL = new CategoryBL();
				listCategory = categoryBL.GetAll();
				cbbCategory.DataSource = listCategory;
				cbbCategory.DisplayMember = "Name";
				cbbCategory.ValueMember = "ID";
		  }
		  private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
		  {
				cbbCategory.DisplayMember = "Name";
				cbbCategory.ValueMember = "ID";
				string categoryID;
				FoodBL foodBL = new FoodBL();
				if (cbbCategory.SelectedIndex == -1) return;
				if (cbbCategory.SelectedValue is DataRowView)
				{
					 DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
					 categoryID = rowView["ID"].ToString();
				}
				else
				{
					 categoryID = cbbCategory.SelectedValue.ToString();
				}
				listFood = foodBL.GetFoodByCategoryID(categoryID);

				dgvFoodList.DataSource = listFood;
				lblCatName.Text = cbbCategory.Text;
				lblQuantity.Text = dgvFoodList.Rows.Count.ToString();

		  }
		  private void txtSearchByName_TextChanged(object sender, EventArgs e)
		  {
				List<Food> kq = new List<Food>();
				if (String.IsNullOrWhiteSpace(txtSearchByName.Text))
				{
					 foreach(var item in listFood)
					 {
						  if (item.Name.ToLower().Contains(txtSearchByName.Text.ToLower()))
						  {
								kq.Add(item);
						  }
					 }
					 dgvFoodList.DataSource = kq;
				}
				else
				{
					 dgvFoodList.DataSource = listFood;
				}
				
		  }

		  private void tsmCalculateQuantity_Click(object sender, EventArgs e)
		  {
				BillDetailBL billDetailBL = new BillDetailBL();
				if (dgvFoodList.SelectedRows.Count > 0)
				{
					 DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
					 int FoodID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
					 int Quantity = billDetailBL.Quantity(FoodID);

					 MessageBox.Show("Tổng số lượng món ăn " + selectedRow.Cells[1].Value.ToString() + " đã bán là : " + Quantity + " " + selectedRow.Cells[2].Value.ToString());
				}
		  }


		  private void FoodForm_FormClosed(object sender, FormClosedEventArgs e)
		  {
				int index = cbbCategory.SelectedIndex;
				cbbCategory.SelectedIndex = -1;
				cbbCategory.SelectedIndex = index;
				this.LoadCategory();
		  }

		  private void tsmAddFood_Click(object sender, EventArgs e)
		  {
				FoodInfoForm foodForm = new FoodInfoForm();
				foodForm.FormClosed += new FormClosedEventHandler(FoodForm_FormClosed);
				foodForm.Show(this);
		  }

		  private void tsmUpdateFood_Click(object sender, EventArgs e)
		  {
				if (dgvFoodList.SelectedRows.Count > 0)
				{
					 DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
					 Food rowView = selectedRow.DataBoundItem as Food;

					 FoodInfoForm foodForm = new FoodInfoForm();
					 foodForm.FormClosed += new FormClosedEventHandler(FoodForm_FormClosed);

					 foodForm.Show(this);
					 foodForm.DisplayFood(rowView);
				}
		  }

		  private void btnBills_Click(object sender, EventArgs e)
		  {
				BillForm frm = new BillForm();
				frm.Show(this);
				frm.DisplayBill();
		  }

		  private void btnAccount_Click(object sender, EventArgs e)
		  {
				AccountForm frm = new AccountForm();
				frm.Show(this);
				frm.LoadAccount();
		  }
	 }
}
