using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911166_Lab09_Entity_FrameWork.Models
{
	 public class Food
	 {
		  public int Id { get; set; }
		  public string Name { get; set; }
		  public string Unit { get; set; }
		  public int FoodCategoryId { get; set; }
		  public int Price { get; set; }
		  public string Notes { get; set; }
		  public Category Category { get; set; }
	 }
}
