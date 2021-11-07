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
	 public partial class AccountManager : Form
	 {
		  public AccountManager()
		  {
				InitializeComponent();
		  }

		  public void LoadAccount()
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID ";
				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Account");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvAccount.DataSource = dt;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();
		  }

		  private void tsmiAdmin_Click(object sender, EventArgs e)
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID and C.RoleName = 'Adminstrator'";
				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Account");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvAccount.DataSource = dt;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();
		  }

		  private void tsmiMath_Click(object sender, EventArgs e)
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID and C.RoleName = N'Kế toán'";
				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Account");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvAccount.DataSource = dt;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();
		  }

		  private void tsmiPayment_Click(object sender, EventArgs e)
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID and C.RoleName = N'Nhân viên thanh toán'";
				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Account");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvAccount.DataSource = dt;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();
		  }

		  private void tsmiServe_Click(object sender, EventArgs e)
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID and C.RoleName = N'Nhân viên phục vụ'";
				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Account");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvAccount.DataSource = dt;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();
		  }

		  private void tsmiAll_Click(object sender, EventArgs e)
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID ";
				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Account");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvAccount.DataSource = dt;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();
		  }

		  private void tsmiActive_Click(object sender, EventArgs e)
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID and A.Actived = 1 ";
				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Account");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvAccount.DataSource = dt;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();
		  }

		  private void tsmiNotActive_Click(object sender, EventArgs e)
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID and A.Actived = 0 ";
				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Account");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvAccount.DataSource = dt;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();
		  }

		  private void btnAddAccount_Click(object sender, EventArgs e)
		  {
				AddAccount frm = new AddAccount();
				if(frm.ShowDialog() == DialogResult.OK)
				{
					 this.LoadAccount();
				}
		  }

		  private void dgvAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		  {
				DataGridViewRow row = dgvAccount.Rows[e.RowIndex];
				DataRowView rowView = row.DataBoundItem as DataRowView;
				string accountName = rowView["AccountName"].ToString();
				AddAccount frm = new AddAccount();
				//frm.Show(this);
				frm.DisplayAccount(accountName);
				if(frm.ShowDialog() == DialogResult.OK)
				{
					 this.LoadAccount();
				}
		  }

		  private void tsmDeleteAccount_Click(object sender, EventArgs e)
		  {
				if (dgvAccount.SelectedRows.Count > 0)
				{
					 DataGridViewRow row = dgvAccount.SelectedRows[0];
					 string accountName = row.Cells[0].Value.ToString();
					 // Tạo đối tượng kết nối
					 string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
					 SqlConnection sqlConnection = new SqlConnection(connectionString);

					 // tạo đối tượng thực thi lệnh
					 SqlCommand sqlCommand = sqlConnection.CreateCommand();

					 sqlConnection.Open();
					 sqlCommand.CommandText="UPDATE RoleAccount SET [Actived] = 0 WHERE [AccountName] = N'"+accountName+"'";
					 int numOfRowsEffered = sqlCommand.ExecuteNonQuery();
					 sqlConnection.Close();
					 if (numOfRowsEffered > 0)
					 {
						  MessageBox.Show("Xóa tài khoản thành công");
						  this.LoadAccount();
					 }
					 else
					 {
						  MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại");
					 }
				}
		  }

		  private void tsmRoles_Click(object sender, EventArgs e)
		  {
				if (dgvAccount.SelectedRows.Count > 0)
				{
					 DataGridViewRow row = dgvAccount.SelectedRows[0];
					 string accountName = row.Cells[0].Value.ToString();
					 Roles frm = new Roles();
					 frm.Show(this);
					 frm.LoadRoles(accountName);
				}
		  }

		  private void tsmResetPassword_Click(object sender, EventArgs e)
		  {
				if(dgvAccount.SelectedRows.Count > 0)
				{
					 DataGridViewRow row = dgvAccount.SelectedRows[0];
					 string accountName = row.Cells[0].Value.ToString();

					 // Tạo đối tượng kết nối
					 string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
					 SqlConnection sqlConnection = new SqlConnection(connectionString);

					 // tạo đối tượng thực thi lệnh
					 SqlCommand sqlCommand = sqlConnection.CreateCommand();

					 sqlCommand.CommandText = "update Account set [Password] = 1 where [AccountName]= N'" + accountName + "'";

					 sqlConnection.Open();
					 int numOfRowsEffered = sqlCommand.ExecuteNonQuery();
					 
					 if(numOfRowsEffered == 1)
					 {
						  MessageBox.Show("Reset mật khẩu thành công");
						  this.LoadAccount();
					 }
					 else
					 {
						  MessageBox.Show("Reset mật khẩu thất bại. Vui lòng thử lại");
					 }
					 sqlConnection.Close();
					 sqlConnection.Dispose();
				}
		  }
	 }
}
