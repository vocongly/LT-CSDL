using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _1911166_Lab02
{
	 public delegate int SoSanh(object gv1, object gv2);
	 public class QuanLyGiaoVien
	 {
		  public List<GiaoVien> dsGiaoVien;
		  public QuanLyGiaoVien()
		  {
				dsGiaoVien = new List<GiaoVien>();
		  }
		  public void Them(GiaoVien gv)
		  {
				this.dsGiaoVien.Add(gv);
		  }
		  public GiaoVien this[int index]
		  {
				get { return dsGiaoVien[index]; }
				set { dsGiaoVien[index] = value; }
		  }
		  public void Xoa(object obj,SoSanh ss)
		  {
				for (int i = dsGiaoVien.Count - 1; i >= 0; i--)
				{
					 if (ss(obj, this[i]) == 0)
						  this.dsGiaoVien.RemoveAt(i);
				}
		  }
		  public GiaoVien Tim(object obj, SoSanh ss)
		  {
				GiaoVien gvResult = null;
				foreach(GiaoVien gv in dsGiaoVien)
				{
					 if (ss(obj, gv) == 0)
					 {
						  gvResult = gv;
						  break;
					 }
				}
				return gvResult;
		  }
		  
	 }
}
