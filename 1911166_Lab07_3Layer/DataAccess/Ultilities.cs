using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	 public class Ultilities
	 {
		  // lấy chuỗi kết nối từ tập tin App.Config
		  private static string StrName = "ConnectionStringName";
		  public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;
		  
		  public static string Food_GetAll = "Food_GetAll";
		  public static string Food_InsertUpdateDelete = "Food_InsertUpdateDelete";

		  public static string Category_GetAll = "Category_GetAll";
		  public static string Category_InsertUpdateDelete = "Category_InsertUpdateDelete";

		  public static string BillDetail_GetAll = "BillDetail_GetAll";
		  public static string BillDetail_InsertUpdateDelete = "BillDetail_InsertUpdateDelete";

		  public static string Bill_GetAll = "Bill_GetAll";

		  public static string Account_GetAll = "Account_GetAll";
		  public static string Account_InsertUpdateDelete = "Account_InsertUpdateDelete";

	 }
}
