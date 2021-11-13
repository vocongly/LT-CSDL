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
	 public partial class RolesForm : Form
	 {
		  string account;
		  int numOfRowsAffered;
		  public RolesForm()
		  {
				InitializeComponent();
				//LoadRoles();
		  }
		  public void LoadRoles(string accountName)
		  {
				account = accountName;
				txtaccountName.Text = accountName;
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				SqlCommand sqlCommand1 = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select [ID],[RoleName] from Role";

				SqlDataReader reader = sqlCommand.ExecuteReader();

				lvRoles.Items.Clear();
				while (reader.Read())
				{
					 ListViewItem item = new ListViewItem(reader["ID"].ToString());
					 lvRoles.Items.Add(item);
					 item.SubItems.Add(reader["RoleName"].ToString());
				}

				sqlConnection.Close();

				sqlConnection.Open();

				sqlCommand1.CommandText = "select [ID] from RoleAccount A,Role B where A.RoleID = B.ID and A.AccountName = N'" + accountName + "'";
				SqlDataReader reader1 = sqlCommand1.ExecuteReader();
				while (reader1.Read())
				{
					 foreach(ListViewItem item in lvRoles.Items)
					 {
						  if(reader1["ID"].ToString()== item.Text.ToString())
						  {
								item.Checked = true;
						  }
					 }
				}
				sqlConnection.Close();
				sqlConnection.Dispose();
		  }

		  private void btnCancel_Click(object sender, EventArgs e)
		  {
				this.Close();
		  }

		  private void btnUpdateRoles_Click(object sender, EventArgs e)
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText= "delete from RoleAccount where [AccountName] = N'"+account+"'";
				sqlCommand.ExecuteNonQuery();

				foreach(ListViewItem item in lvRoles.CheckedItems)
				{
					 sqlCommand.CommandText= "INSERT INTO RoleAccount([RoleID],[AccountName],[Actived],[Notes]) Values(" + item.Text.ToString() +
						  ",N'" + account + "',1,null)";
					 numOfRowsAffered += sqlCommand.ExecuteNonQuery();
				}
				sqlConnection.Close();
				if(numOfRowsAffered == this.lvRoles.CheckedItems.Count)
				{
					 MessageBox.Show("Cập nhật thành công");
					 this.DialogResult = DialogResult.OK;
					 this.Close();
				}
				else
				{
					 MessageBox.Show("Cập nhật thất bại");
				}
		  }
	 }
}
