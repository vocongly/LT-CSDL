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

namespace _1911166_Lab06_Basic_Command
{
	 public partial class FoodForm : Form
	 {
		  public FoodForm()
		  {
				InitializeComponent();
		  }
		  int countBegin;
		  public void LoadFood(int categoryID)
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				// thiết lập lệnh truye vấn cho đối tượng Command
				sqlCommand.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID;

				// Mở kết nối tới cơ sở dữ liệu
				sqlConnection.Open();

				string catName = sqlCommand.ExecuteScalar().ToString();
				this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;

				sqlCommand.CommandText = "SELECT*FROM Food WHERE FoodCategoryID = " + categoryID;

				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Food");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvFood.DataSource = dt;
				countBegin = dgvFood.Rows.Count-1;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();
		  }

		  private void btnSave_Click(object sender, EventArgs e)
		  {
				string connectionString = "server=localhost; database= RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				int countAfter = this.dgvFood.Rows.Count-1;
				int numOfRowsEffected = 0;


				if (countAfter > countBegin)
				{
					 sqlConnection.Open();
					 for(int i = 0; i< countBegin; i++)
					 {
						  DataGridViewRow row = dgvFood.Rows[i];
						  sqlCommand.CommandText = "UPDATE Food SET Name = N'" + row.Cells[1].Value.ToString() +
								"', [Unit] = N'" + row.Cells[2].Value.ToString() + "'" +
								", [FoodCategoryID] = " + row.Cells[3].Value +
								", [Price] = " + row.Cells[4].Value +
								", [Notes] = N'" + row.Cells[5].Value.ToString() + "'" +
								" WHERE ID = " + row.Cells[0].Value;
						  numOfRowsEffected += sqlCommand.ExecuteNonQuery();
					 }
					 for (int i = countBegin; i< countAfter; i++)
					 {
						  DataGridViewRow row = dgvFood.Rows[i];
						  sqlCommand.CommandText = "INSERT INTO Food(Name,[Unit],[FoodCategoryID],[Price],[Notes])" +
								" VALUES (N'" + row.Cells[1].Value.ToString() + "', N'" + row.Cells[2].Value.ToString() + "'," +
								row.Cells[3].Value + ", " + row.Cells[4].Value + ", N'" + row.Cells[5].Value.ToString() + "')";
						  numOfRowsEffected += sqlCommand.ExecuteNonQuery();
					 }
					 sqlConnection.Close();
					 if(numOfRowsEffected == countAfter)
					 {
						  MessageBox.Show("Lưu thành công!");
					 }
					 else
					 {
						  MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
					 }
				}
				else if(countAfter == countBegin)
				{
					 sqlConnection.Open();
					 for (int i = 0; i < countBegin; i++)
					 {
						  DataGridViewRow row = dgvFood.Rows[i];
						  sqlCommand.CommandText = "UPDATE Food SET Name = N'" + row.Cells[1].Value.ToString() +
								"', [Unit] = N'" + row.Cells[2].Value.ToString() + "'" +
								", [FoodCategoryID] = " + row.Cells[3].Value +
								", [Price] = " + row.Cells[4].Value +
								", [Notes] = N'" + row.Cells[5].Value.ToString() + "'" +
								" WHERE ID = " + row.Cells[0].Value;
						  numOfRowsEffected += sqlCommand.ExecuteNonQuery();
					 }
					 sqlConnection.Close();
					 if (numOfRowsEffected == countAfter)
					 {
						  MessageBox.Show("Lưu thành công!");
					 }
					 else
					 {
						  MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
					 }
				}
				Close();
		  }

		  private void btnDelete_Click(object sender, EventArgs e)
		  {
				string connectionString = "server=localhost; database= RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				DataGridViewRow row = dgvFood.SelectedRows[0];

				string txtFoodID = row.Cells[0].Value.ToString();

				sqlCommand.CommandText = "DELETE FROM FOOD" +
					 " WHERE ID = " + txtFoodID;

				sqlConnection.Open();

				int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

				sqlConnection.Close();

				if(numOfRowsEffected == 1)
				{
					 DataGridViewRow rowSelect = dgvFood.SelectedRows[0];

					 if (this.dgvFood.SelectedRows.Count > 0)
					 {
						  dgvFood.Rows.RemoveAt(this.dgvFood.SelectedRows[0].Index);
					 }
					 MessageBox.Show("Xóa món ăn thành công");
				}
				else
				{
					 MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
				}

		  }
	 }
}
