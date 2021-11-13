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
	 public partial class AddCategory : Form
	 {
		  public AddCategory()
		  {
				InitializeComponent();
		  }

		  private void btnAddCategory_Click(object sender, EventArgs e)
		  {
				string loai = cbbType.Text;
				int number=0;
				if (loai.ToLower() == "thức ăn")
					 number = 1;
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandText = "EXECUTE InsertCategory @id OUTPUT, @name, @type";

				// thêm tham số vào đối tượng command
				sqlCommand.Parameters.Add("@id", SqlDbType.Int);
				sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				sqlCommand.Parameters.Add("@type", SqlDbType.Int);

				sqlCommand.Parameters["@id"].Direction = ParameterDirection.Output;

				// truyền giá trị vào thủ tục qua tham số
				sqlCommand.Parameters["@name"].Value = txtCategoryName.Text;
				sqlCommand.Parameters["@type"].Value = number;

				sqlConnection.Open();
				int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

				sqlConnection.Close();

				if (numOfRowsEffected == 1)
				{
					 MessageBox.Show("Thêm nhóm món ăn thành công");
					 txtCategoryName.Text = "";
					 cbbType.Text = "";
					 this.Close();
					 this.DialogResult = DialogResult.OK;
				}
				else
				{
					 MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
				}
				
		  }
	 }
}
