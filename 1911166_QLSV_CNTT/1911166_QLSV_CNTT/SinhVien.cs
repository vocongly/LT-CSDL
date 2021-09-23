using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911166_QLSV_CNTT
{
	 public class SinhVien
	 {
		  public string MaSo { get; set; }
		  public string HoTen { get; set; }
		  public string Email { get; set; }
		  public string DiaChi { get; set; }
		  public DateTime NgaySinh { get; set; }
		  public bool Phai { get; set; }
		  public string Lop { get; set; }
		  public string SDT { get; set; }
		  public string LinkHinh { get; set; }

		  public SinhVien()
		  {

		  }
		  public SinhVien(string maso,string hoten,string email,string diachi,DateTime ngay,
				bool gioitinh,string lop,string sdt,string hinh)
		  {
				this.MaSo = maso;
				this.HoTen = hoten;
				this.NgaySinh = ngay;
				this.Phai = gioitinh;
				this.Lop = lop;
				this.SDT = sdt;
				this.LinkHinh = hinh;
		  }


	 }
}
