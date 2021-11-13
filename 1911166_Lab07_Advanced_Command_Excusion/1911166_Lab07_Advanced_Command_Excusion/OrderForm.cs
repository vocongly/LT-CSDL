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
	 public partial class OrderForm : Form
	 {
		  public OrderForm()
		  {
				InitializeComponent();
		  }
		  string totalNumber;
		  public void LoadBills()
		  {
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				SqlCommand sqlCommand1 = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "SELECT [ID],[Name] as 'Tên hóa đơn',[TableID] as 'ID Bàn',[Amount] as 'Tổng tiền',[Discount] as 'Chiết khấu',[Tax] as 'Thuế',[Status] as 'Trạng thái',[CheckoutDate] as 'Ngày lập hóa đơn',[Account] as 'Người lập hóa đơn' FROM Bills";
				
				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Bills");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvOrder.DataSource = dt;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();

				
		  }

		  private void btnSearchOrder_Click(object sender, EventArgs e)
		  {
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "SELECT [ID],[Name] as 'Tên hóa đơn',[TableID] as 'ID Bàn',[Amount] as 'Tổng tiền',[Discount] as 'Chiết khấu',[Tax] as 'Thuế',[Status] as 'Trạng thái',[CheckoutDate] as 'Ngày lập hóa đơn',[Account] as 'Người lập hóa đơn'" +
					 " FROM Bills WHERE CheckoutDate = '" + dtpTime.Value.ToString("MM/dd/yyyy")+"'";

				//Tạo đối tượng DataAdapter
				SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

				// tạo datatable để chứa dữ liệu
				DataTable dt = new DataTable("Bills");
				da.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvOrder.DataSource = dt;
				TotalAmount(dtpTime.Value.ToString("MM/dd/yyyy"));

				// Đóng cổng và giải phóng bộ nhớ 
				sqlConnection.Close();
				sqlConnection.Dispose();
				da.Dispose();

		  }
		  private void TotalAmount(string checkoutDate)
		  {
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "select @Total =  sum([Amount]) from Bills where [CheckoutDate] = '" + checkoutDate + "'";

				// Thêm tham số vào đối tượng Command
				sqlCommand.Parameters.Add("@Total", SqlDbType.Int);

				sqlCommand.Parameters["@Total"].Direction = ParameterDirection.Output;

				int numOfRowAffected = sqlCommand.ExecuteNonQuery();

				string total = sqlCommand.Parameters["@Total"].Value.ToString();
				if (String.IsNullOrEmpty(total))
					 total = "0";
				tslTotalAmount.Text = "Tổng doanh thu trong ngày là : " + total + " VNĐ";

				sqlConnection.Close();
				sqlConnection.Dispose();

		  }

		  private void dgvOrder_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		  {
				DataGridViewRow row = dgvOrder.Rows[e.RowIndex];
				string idbills = row.Cells["ID"].Value.ToString();
				OrderDetailsForm frm = new OrderDetailsForm();
				frm.Show(this);
				frm.LoadOrderDetails(idbills);
		  }
	 }
}
