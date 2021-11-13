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

namespace _1911166_Lab07_Advanced_Command_Excusion
{
	 public partial class Form1 : Form
	 {
		  private DataTable foodTable;
		  public Form1()
		  {
				InitializeComponent();
		  }

		  private void LoadCategory()
		  {
				string connectionString = "server=localhost;database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection conn = new SqlConnection(connectionString);

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "SELECT ID, Name FROM Category";

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();

				// mở kết nối
				conn.Open();

				// lấy dữ liệu tư csdl và đưa vào DataTable
				adapter.Fill(dt);

				// Đóng kết nối và giải phóng bộ nhớ
				conn.Close();
				conn.Dispose();

				cbbCategory.DataSource = dt;

				cbbCategory.DisplayMember = "Name";

				cbbCategory.ValueMember = "ID";
		  }

		  private void Form1_Load(object sender, EventArgs e)
		  {
				this.LoadCategory();
		  }

		  private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
		  {
				if (cbbCategory.SelectedIndex == -1) return;
				string connectionString = "server=localhost;database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection conn = new SqlConnection(connectionString);

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "SELECT*FROM Food Where FoodCategoryID = @categoryId";

				// truyền tham số
				cmd.Parameters.Add("@categoryID", SqlDbType.Int);

				if(cbbCategory.SelectedValue is DataRowView)
				{
					 DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
					 cmd.Parameters["@categoryId"].Value = rowView["ID"];
				}
				else
				{
					 cmd.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
				}

				// Tạo bộ điều phiếu dữ liệu 
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				foodTable = new DataTable();

				conn.Open();

				adapter.Fill(foodTable);

				conn.Close();
				conn.Dispose();

				dgvFoodList.DataSource = foodTable;

				lblQuantity.Text = foodTable.Rows.Count.ToString();
				lblCatName.Text = cbbCategory.Text;
		  }

		  private void tsmCalculateQuantity_Click(object sender, EventArgs e)
		  {
				string connectionString = "server=localhost;database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection conn = new SqlConnection(connectionString);

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails Where FoodID = @foodId";
				
				// lấy thông tin sản phẩm được chọn
				if(dgvFoodList.SelectedRows.Count > 0)
				{
					 DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];

					 DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

					 // truyền tham số
					 cmd.Parameters.Add("@foodId", SqlDbType.Int);
					 cmd.Parameters["@foodId"].Value = rowView["ID"];

					 cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
					 cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

					 conn.Open();

					 cmd.ExecuteNonQuery();

					 string result = cmd.Parameters["@numSaleFood"].Value.ToString();
					 if (String.IsNullOrEmpty(result))
						  result = "0";
					 MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là : " + result + " " + rowView["Unit"]);

					 conn.Close();

				}
				cmd.Dispose();
				conn.Dispose();
		  }

		  private void tsmAddFood_Click(object sender, EventArgs e)
		  {
				FoodInfoForm foodForm = new FoodInfoForm();
				foodForm.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
				foodForm.Show(this);
		  }

		  private void tsmUpdateFood_Click(object sender, EventArgs e)
		  {
				// lấy thông tin sản phẩm được chọn
				if(dgvFoodList.SelectedRows.Count > 0)
				{
					 DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
					 DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

					 FoodInfoForm foodForm = new FoodInfoForm();
					 foodForm.FormClosed += new FormClosedEventHandler(Form1_FormClosed);

					 foodForm.Show(this);
					 foodForm.DisplayFoodInfo(rowView);
				}

		  }

		  void Form1_FormClosed(object sender, FormClosedEventArgs e)
		  {
				int index = cbbCategory.SelectedIndex;
				cbbCategory.SelectedIndex = -1;
				cbbCategory.SelectedIndex = index;
				this.LoadCategory();
		  }

		  private void txtSearchByName_TextChanged(object sender, EventArgs e)
		  {
				if (foodTable == null) return;

				// tạo bộ lọc
				string filterExpression = "Name like '%" + txtSearchByName.Text + "%'";
				string sortExpression = "Price DESC";

				DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;

				DataView foodView = new DataView(foodTable, filterExpression, sortExpression, rowStateFilter);
				dgvFoodList.DataSource = foodView;
		  }

		  private void btnOrder_Click(object sender, EventArgs e)
		  {
				OrderForm frm = new OrderForm();
				frm.Show(this);
				frm.LoadBills();
		  }

		  private void btnAccount_Click(object sender, EventArgs e)
		  {
				AccountForm frm = new AccountForm();
				frm.Show(this);
				frm.LoadAccount();
		  }
	 }
}
