using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	 public class BillDetailDA
	 {
		  public List<BillDetail> GetAll()
		  {
				SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
				sqlConn.Open();

				SqlCommand command = sqlConn.CreateCommand();
				command.CommandType = CommandType.StoredProcedure;
				command.CommandText = Ultilities.BillDetail_GetAll;

				SqlDataReader reader = command.ExecuteReader();
				List<BillDetail> list = new List<BillDetail>();
				while (reader.Read())
				{
					 BillDetail billdetail = new BillDetail();
					 billdetail.ID = Convert.ToInt32(reader["ID"]);
					 billdetail.InvoiceID = Convert.ToInt32(reader["InvoiceID"]);
					 billdetail.FoodID = Convert.ToInt32(reader["FoodID"]);
					 billdetail.Quantity = Convert.ToInt32(reader["Quantity"]);
					 list.Add(billdetail);
				}

				sqlConn.Close();
				return list;
		  }

		  public int Insert_Update_Delete(BillDetail billdetail, int action)
		  {
				SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
				sqlConn.Open();
				SqlCommand command = sqlConn.CreateCommand();
				command.CommandType = CommandType.StoredProcedure;

				SqlParameter IDPara = new SqlParameter("ID", SqlDbType.Int);
				IDPara.Direction = ParameterDirection.InputOutput;
				command.Parameters.Add(IDPara).Value = billdetail.ID;
				command.Parameters.Add("@InvoiceID", SqlDbType.Int).Value = billdetail.InvoiceID;
				command.Parameters.Add("@FoodID", SqlDbType.Int).Value = billdetail.FoodID;
				command.Parameters.Add("@Quantity", SqlDbType.Int).Value = billdetail.Quantity;
				command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

				int result = command.ExecuteNonQuery();
				if (result > 0)
					 return (int)command.Parameters["@ID"].Value;
				return 0;
		  }
	 }
}
