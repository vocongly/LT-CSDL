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
	 public partial class OrderDetailsForm : Form
	 {
		  public OrderDetailsForm()
		  {
				InitializeComponent();
		  }
		  public void LoadOrderDetails(string IDBills)
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				SqlCommand sqlCommand1 = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select A.[ID],B.[Name] as 'Tên món ăn',B.[Price] as 'Đơn giá',[Quantity] as 'Số lượng',B.Price*Quantity as 'Thành tiền' "+
					 "from BillDetails A,Food B where A.FoodID = B.ID and[InvoiceID] = "+IDBills;

				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Bills");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvOrderDetails.DataSource = dt;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();
		  }
	 }
}
