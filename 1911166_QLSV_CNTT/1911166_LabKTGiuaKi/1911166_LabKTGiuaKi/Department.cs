using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911166_LabKTGiuaKi
{
	 public class Department
	 {
		  public string TenKhoa { get; set; }
		  public List<Class> DSLop { get; set; }
		  public List<Students> dssv { get; set; }
		  public Department()
		  {

		  }
		  public Department(string tenkhoa)
		  {
				this.TenKhoa = tenkhoa;
				DSLop = new List<Class>();
				dssv = new List<Students>();
		  }
		  public void AddSV(Students sv)
		  {
				int index = DSLop.FindIndex(x => x.TenLop == sv.Lop);
				if(index == -1)
				{
					 Class lop = new Class(sv.Lop);
					 lop.dsSV.Add(sv);
					 DSLop.Add(lop);
				}
				else
				{
					 DSLop[index].dsSV.Add(sv);
				}
				dssv.Add(sv);
		  }
	 }
}
