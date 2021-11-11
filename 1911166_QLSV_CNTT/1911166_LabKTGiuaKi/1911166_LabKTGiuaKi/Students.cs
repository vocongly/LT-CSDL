using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911166_LabKTGiuaKi
{
	 public class Students
	 {
		  public string MSSV { get; set; }
		  public string HoTenLot { get; set; }
		  public string Ten { get; set; }
		  public string GioiTinh { get; set; }
		  public string NgaySinh { get; set; }
		  public string SoDT { get; set; }
		  public string Lop { get; set; }
		  public string Khoa { get; set; }
		  public string DiaChi { get; set; }

		  public Students()
		  {

		  }
		  public Students(string mssv,string hotenlot,string ten,string gioitinh,string ngaysinh,string sodt,string lop,string diachi,string khoa)
		  {
				this.MSSV = mssv;
				this.HoTenLot = hotenlot;
				this.Ten = ten;
				this.GioiTinh = gioitinh;
				this.NgaySinh = ngaysinh;
				this.SoDT = sodt;
				this.Lop = lop;
				this.Khoa = khoa;
				this.DiaChi = diachi;
		  }
	 }
}
