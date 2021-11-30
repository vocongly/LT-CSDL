using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	 public class BillDetailBL
	 {
		  BillDetailDA billDetailDA = new BillDetailDA();
		  public List<BillDetail> GetAll()
		  {
				return billDetailDA.GetAll();
		  }

		  public int Quantity(int _foodID)
		  {
				return GetAll().FindAll(x => x.FoodID == _foodID).ToList().Sum(x => x.Quantity);
		  }

		  public int Insert(BillDetail billDetail)
		  {
				return billDetailDA.Insert_Update_Delete(billDetail, 0);
		  }

		  public int Update(BillDetail billDetail)
		  {
				return billDetailDA.Insert_Update_Delete(billDetail, 1);
		  }

		  public int Delete(BillDetail billDetail)
		  {
				return billDetailDA.Insert_Update_Delete(billDetail, 2);
		  }
	 }
}
