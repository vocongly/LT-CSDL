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
	 public partial class Roles : Form
	 {
		  public Roles()
		  {
				InitializeComponent();
		  }
		  public void LoadRoles(string accountName)
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select A.AccountName as 'Tên tài khoản',A.FullName as 'Họ và tên',C.RoleName as 'Vai trò' from Account A, RoleAccount B,Role C " +
					 "where A.AccountName = B.AccountName and B.RoleID = C.ID and A.AccountName = N'"+accountName+"'";

				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Roles");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvRoles.DataSource = dt;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();
		  }
	 }
}
