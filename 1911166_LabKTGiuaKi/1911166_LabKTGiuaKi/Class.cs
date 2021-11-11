using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911166_LabKTGiuaKi
{
	 public class Class
	 {
		  public string TenLop { get; set; }
		  public List<Students> dsSV { get; set; }

		  public Class()
		  {

		  }
		  public Class(string tenlop)
		  {
				this.TenLop = tenlop;
				dsSV = new List<Students>();
		  }
		  public void AddSV(Students sv)
		  {
				
		  }
	 }
}
