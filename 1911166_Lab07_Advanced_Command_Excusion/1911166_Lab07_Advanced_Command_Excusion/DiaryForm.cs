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
	 public partial class DiaryForm : Form
	 {
		  string account;
		  public DiaryForm()
		  {
				InitializeComponent();
		  }
		  public void LoadDiary(string accountName)
		  {
				account = accountName;
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand1 = sqlConnection.CreateCommand();
				SqlCommand sqlCommand2 = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand1.CommandText = "select [CheckoutDate] from Bills A,Account B where A.Account = B.AccountName and B.AccountName = N'" + accountName + "'";
				SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand1);
				DataTable dt = new DataTable();

				// lấy dữ liệu tư csdl và đưa vào DataTable
				adapter.Fill(dt);

				// Đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();

				lbxDate.DataSource = dt;

				lbxDate.DisplayMember = "CheckoutDate";

				lbxDate.ValueMember = "CheckoutDate";

				sqlConnection.Open();
				sqlCommand2.CommandText = "select @Total = Sum(Amount) from Bills where [Account] = N'" + account + "'";
				// Thêm tham số vào đối tượng Command
				sqlCommand2.Parameters.Add("@Total", SqlDbType.Int);

				sqlCommand2.Parameters["@Total"].Direction = ParameterDirection.Output;

				sqlCommand2.ExecuteNonQuery();

				string total = sqlCommand2.Parameters["@Total"].Value.ToString();
				if (String.IsNullOrEmpty(total))
					 total = "0";
				lbTotalMoney.Text = "Tổng tiền : " + total + " VNĐ";

				sqlConnection.Close();
				sqlConnection.Dispose();

		  }

		  private void lbxDate_SelectedIndexChanged(object sender, EventArgs e)
		  {
				string dateBill="";

				if(lbxDate.SelectedValue is DataRowView)
				{
					 DataRowView row = this.lbxDate.SelectedValue as DataRowView;
					 dateBill = row["CheckoutDate"].ToString();
				}
				else
				{
					 dateBill = this.lbxDate.SelectedValue.ToString();
				}
				// Tạo đối tượng kết nối
				string connectionString = "server=localhost; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "set dateformat dmy select C.ID,C.Name as 'Tên món ăn',B.Quantity as 'Số lượng',C.Price as 'Đơn giá', B.Quantity*C.Price as 'Thành tiền' " +
					 " from Bills A,BillDetails B, Food C " +
					 " where A.ID = B.InvoiceID and B.FoodID = C.ID and A.CheckoutDate = '" + dateBill + "'";

				SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

				DataTable dt = new DataTable("Foods");
				adapter.Fill(dt);

				// Hiển thị danh sách món ăn lên form
				dgvFood.DataSource = dt;

				// đóng kết nối và giải phóng bộ nhớ
				sqlConnection.Close();
				sqlConnection.Dispose();
				adapter.Dispose();

				lbBills.Text = "Số lượng hóa đơn : " + this.lbxDate.Items.Count;
		  }
	 }
}
