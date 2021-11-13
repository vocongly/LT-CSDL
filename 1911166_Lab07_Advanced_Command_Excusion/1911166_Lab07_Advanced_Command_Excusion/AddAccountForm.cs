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
	 public partial class AddAccountForm : Form
	 {
		  public AddAccountForm()
		  {
				InitializeComponent();
		  }
		  public void LoadAccount(string accountName)
		  {
				this.btnLuuAccount.Enabled = false;
				this.btnUpdateAccount.Enabled = true;
				this.txtAccountName.Enabled = false;
				this.Text = "Cập nhật tài khoản";
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
				SqlCommand sqlCommand2 = sqlConnection.CreateCommand();

				sqlConnection.Open();
				sqlCommand1.CommandText = "select [AccountName],[Password],[FullName],[Email],[Tell],[DateCreated] from Account where [AccountName] = N'" + accountName + "'";
				SqlDataReader reader1 = sqlCommand1.ExecuteReader();
				while (reader1.Read())
				{
					 txtAccountName.Text = reader1["AccountName"].ToString();
					 txtHoTen.Text = reader1["FullName"].ToString();
					 txtEmail.Text = reader1["Email"].ToString();
					 mstbSDT.Text = reader1["Tell"].ToString();
				}
				sqlConnection.Close();

				sqlConnection.Open();
				sqlCommand2.CommandText = "select [RoleName],A.[Notes] as Note,[Actived] from RoleAccount A,Role B where A.RoleID = B.ID and [AccountName]= N'" + accountName + "'";
				SqlDataReader reader2 = sqlCommand2.ExecuteReader();
				while (reader2.Read())
				{
					 txtNote.Text = reader2["Note"].ToString();
					 for (int i = 0; i < this.clbVaitro.Items.Count; i++)
					 {
						  if (reader2["RoleName"].ToString().CompareTo(this.clbVaitro.Items[i].ToString()) == 0)
						  {
								this.clbVaitro.SetItemChecked(i, true);
						  }
					 }
				}
				sqlConnection.Close();
				sqlConnection.Dispose();
		  }

		  private void btnLuuAccount_Click(object sender, EventArgs e)
		  {
				this.btnUpdateAccount.Enabled = false;
				this.btnLuuAccount.Enabled = true;
				int numOfVaitro = 0;
				int numOfRowsEffected = 0;
				string hoten = txtHoTen.Text;
				string accountname = txtAccountName.Text;
				string password = "1";
				string sdt;
				if (String.IsNullOrEmpty(mstbSDT.Text))
					 sdt = null;
				else
					 sdt = mstbSDT.Text;
				string email = txtEmail.Text;
				string notes;
				if (String.IsNullOrEmpty(txtNote.Text))
					 notes = null;
				else
					 notes = txtNote.Text;

				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "SET DATEFORMAT mdy INSERT INTO Account([AccountName],[Password],[FullName],[Email],[Tell],[DateCreated]) Values(N'" + accountname +
					 "',N'" + password + "',N'" + hoten + "',N'" + email + "','" + sdt + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "')";
				numOfRowsEffected += sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();

				sqlConnection.Open();
				foreach (var item in clbVaitro.CheckedItems)
				{
					 if (item.ToString() == "Adminstrator")
						  numOfVaitro = 1;
					 else if (item.ToString() == "Kế toán")
						  numOfVaitro = 2;
					 else if (item.ToString() == "Nhân viên thanh toán")
						  numOfVaitro = 3;
					 else
						  numOfVaitro = 4;

					 sqlCommand.CommandText = "INSERT INTO RoleAccount([RoleID],[AccountName],[Actived],[Notes]) Values(" + numOfVaitro +
						  ",N'" + accountname + "',1,N'" + notes + "')";
					 numOfRowsEffected += sqlCommand.ExecuteNonQuery();
				}
				sqlConnection.Close();
				if (numOfRowsEffected == this.clbVaitro.CheckedItems.Count + 1)
				{
					 MessageBox.Show("Thêm tài khoản thành công");
					 this.DialogResult = DialogResult.OK;
					 Close();
				}
				else
				{
					 MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại!");
				}
		  }

		  private void btnUpdateAccount_Click(object sender, EventArgs e)
		  {
				int numOfRowEffected = 0;
				int numOfVaitro = 0;
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "Update Account set [FullName]=N'" + txtHoTen.Text + "',[Email]=N'" + txtEmail.Text +
					 "',[Tell]= '" + mstbSDT.Text + "'  where [AccountName] = N'" + txtAccountName.Text + "'";
				numOfRowEffected += sqlCommand.ExecuteNonQuery();

				sqlCommand.CommandText = "delete from RoleAccount where [AccountName] = N'" + txtAccountName.Text+ "'";
				sqlCommand.ExecuteNonQuery();

				foreach(var item in clbVaitro.CheckedItems)
				{
					 if (item.ToString() == "Adminstrator")
						  numOfVaitro = 1;
					 else if (item.ToString() == "Kế toán")
						  numOfVaitro = 2;
					 else if (item.ToString() == "Nhân viên thanh toán")
						  numOfVaitro = 3;
					 else
						  numOfVaitro = 4;

					 sqlCommand.CommandText = "insert into RoleAccount([RoleID],[AccountName],[Actived],[Notes]) values(" + numOfVaitro + ",N'" + txtAccountName.Text + "',1,N'"+txtNote.Text+"')";
					 numOfRowEffected += sqlCommand.ExecuteNonQuery();

				}
				sqlConnection.Close();
				if(numOfRowEffected == this.clbVaitro.CheckedItems.Count + 1)
				{
					 MessageBox.Show("Cập nhật tài khoản thành công");
					 this.Close();
					 this.DialogResult = DialogResult.OK;
				}
				else
				{
					 MessageBox.Show("Cập nhật tài khoản thất bại!");
				}
		  }
	 }
}
