using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1911166_Lab02
{
	 public class MonHoc
	 {
		  public int Id { get; set; }
		  public string TenMH { get; set; }
		  public int SoTC { get; set; }
		  public ArrayList mh;
		  public MonHoc()
		  {
				mh = new ArrayList();
		  }
		  public MonHoc(string ten)
		  {
				this.TenMH = ten;
		  }
		  public MonHoc(int id,string ten,int tc)
		  {
				this.Id = id;
				this.TenMH = ten;
				this.SoTC = tc;
		  }
		  public void ThemMonHoc(string tenmh)
		  {
				mh.Add(tenmh);
		  }
		  public override string ToString()
		  {
				return TenMH;
		  }
	 }
}
