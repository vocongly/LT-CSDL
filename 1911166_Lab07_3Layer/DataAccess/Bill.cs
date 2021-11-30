using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	 public class Bill
	 {
		  public int ID { get; set; }
		  public string Name { get; set; }
		  public int TableID { get; set; }
		  public int Amount { get; set; }
		  public double Discount { get; set; }
		  public int Tax { get; set; }
		  public int Status { get; set; }
		  public DateTime CheckoutDate { get; set; }
		  public string Account { get; set; }
	 }
}
