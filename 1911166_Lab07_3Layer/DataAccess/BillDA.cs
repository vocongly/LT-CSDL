using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	 public class BillDA
	 {
		  public List<Bill> GetAll()
		  {
				SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
				sqlConn.Open();

				SqlCommand command = sqlConn.CreateCommand();
				command.CommandType = CommandType.StoredProcedure;
				command.CommandText = Ultilities.Bill_GetAll;

				SqlDataReader reader = command.ExecuteReader();
				List<Bill> list = new List<Bill>();
				while (reader.Read())
				{
					 Bill bill = new Bill();
					 bill.ID = Convert.ToInt32(reader["ID"]);
					 bill.Name = reader["Name"].ToString();
					 bill.TableID = Convert.ToInt32(reader["TableID"]);
					 bill.Amount = Convert.ToInt32(reader["Amount"]);
					 bill.Discount = Convert.ToDouble(reader["Discount"]);
					 bill.Tax = Convert.ToInt32(reader["Tax"]);
					 bill.Status = Convert.ToInt32(reader["Status"]);
					 bill.CheckoutDate = Convert.ToDateTime(reader["CheckoutDate"]);
					 bill.Account = reader["Account"].ToString();
					 list.Add(bill);
				}
				sqlConn.Close();
				return list;
		  }
	 }
}
