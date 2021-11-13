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
	 public partial class AccountForm : Form
	 {
		  public AccountForm()
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
				SqlCommand sqlCommand1 = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select B.AccountName as 'Tên tài khoản',B.FullName as 'Họ và tên',B.Email,B.Tell as 'Số điện thoại',A.Actived as 'Kích hoạt',C.RoleName as 'Vai trò' " +
					 " from RoleAccount A, Account B, Role C " +
					 " where A.AccountName = B.AccountName and C.ID= A.RoleID ";

				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Bills");
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
				AddAccountForm frm = new AddAccountForm();
				if (frm.ShowDialog() == DialogResult.OK)
				{
					 this.LoadAccount();
				}
		  }

		  private void dgvAccount_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		  {
				DataGridViewRow row = dgvAccount.Rows[e.RowIndex];
				string accountName = row.Cells["Tên tài khoản"].Value.ToString();
				AddAccountForm frm = new AddAccountForm();
				frm.LoadAccount(accountName);
				if(frm.ShowDialog() == DialogResult.OK)
				{
					 this.LoadAccount();
				}
		  }

		  private void tsmRoles_Click(object sender, EventArgs e)
		  {
				if(dgvAccount.SelectedRows.Count > 0)
				{
					 DataGridViewRow row = dgvAccount.SelectedRows[0];
					 string accountName = row.Cells["Tên tài khoản"].Value.ToString();
					 RolesForm frm = new RolesForm();
					 frm.LoadRoles(accountName);
					 if(frm.ShowDialog()== DialogResult.OK)
					 {
						  this.LoadAccount();
					 }
				}
		  }

		  private void tsmDiary_Click(object sender, EventArgs e)
		  {
				if (dgvAccount.SelectedRows.Count > 0)
				{
					 DataGridViewRow row = dgvAccount.SelectedRows[0];
					 string accountName = row.Cells["Tên tài khoản"].Value.ToString();
					 DiaryForm frm = new DiaryForm();
					 frm.Show(this);
					 frm.LoadDiary(accountName);
				}
		  }
	 }
}
