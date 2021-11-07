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
	 public partial class BillDetailsForm : Form
	 {
		  public BillDetailsForm()
		  {
				InitializeComponent();
		  }

		  public void LoadBillDetails(string BillID)
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select B.ID,InvoiceID,C.Name,Quantity " +
					 " from Bills A, BillDetails B, Food C" +
					 " where A.ID = B.InvoiceID and B.FoodID = C.ID and A.ID = " + BillID;

				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Bills");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvBillDetails.DataSource = dt;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();
		  }
	 }
}
