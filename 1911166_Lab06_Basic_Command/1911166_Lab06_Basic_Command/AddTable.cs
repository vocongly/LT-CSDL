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
	 public partial class AddTable : Form
	 {
		  public AddTable()
		  {
				InitializeComponent();
				this.btnAdd.Enabled = true;
				this.btnUpdate.Enabled = false;
		  }
		  string IDTable;
		  public void LoadTable(string id)
		  {
				IDTable = id;
				this.btnAdd.Enabled = false;
				this.btnUpdate.Enabled = true;
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();
				sqlCommand.CommandText = "select [Name],[Status],[Capacity] from [Table] where [ID] = N'" + id+ "'";
				SqlDataReader reader = sqlCommand.ExecuteReader();

				while (reader.Read())
				{
					 txtTableName.Text = reader["Name"].ToString();
					 cbbStatus.Text = reader["Status"].ToString();
					 nudCapacity.Value = int.Parse(reader["Capacity"].ToString());
				}
				sqlConnection.Close();
				sqlConnection.Dispose();
		  }

		  private void btnAdd_Click(object sender, EventArgs e)
		  {
				string connectionString = "server=localhost; database= RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlCommand.CommandText = "EXEC InsertTable @id OUTPUT, @Name,@Status,@Capacity";

				// Thêm tham số vào đối tượng Command
				sqlCommand.Parameters.Add("@id", SqlDbType.Int);
				sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100);
				sqlCommand.Parameters.Add("@Status", SqlDbType.Int);
				sqlCommand.Parameters.Add("@Capacity", SqlDbType.Int);

				sqlCommand.Parameters["@id"].Direction = ParameterDirection.Output;

				// truyền giá trị vào thủ tục qua tham số
				sqlCommand.Parameters["@Name"].Value = txtTableName.Text;
				sqlCommand.Parameters["@Status"].Value = cbbStatus.Text;
				sqlCommand.Parameters["@Capacity"].Value = nudCapacity.Value;

				sqlConnection.Open();

				int numOfRowAffected = sqlCommand.ExecuteNonQuery();
				if (numOfRowAffected == 1)
				{
					 MessageBox.Show("Thêm bàn thành công");
					 this.Close();
					 this.DialogResult = DialogResult.OK;
				}
				else
				{
					 MessageBox.Show("Thêm bàn thất bại!");
				}

				sqlConnection.Close();
				sqlConnection.Dispose();
		  }

		  private void btnUpdate_Click(object sender, EventArgs e)
		  {
				string connectionString = "server=localhost; database= RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "update [Table] set [Name]=N'" + txtTableName.Text + "',[Status]=" + cbbStatus.Text + ",[Capacity]=" +
					 nudCapacity.Value + " where [ID]= " + IDTable;

				int numOfRowEffered = sqlCommand.ExecuteNonQuery();

				if (numOfRowEffered == 1)
				{
					 MessageBox.Show("Cập nhật bàn thành công");
					 this.Close();
					 this.DialogResult = DialogResult.OK;
				}
				else
				{
					 MessageBox.Show("Cập nhật bàn thất bại!");
				}

				sqlConnection.Close();
				sqlConnection.Dispose();
		  }
	 }
}
