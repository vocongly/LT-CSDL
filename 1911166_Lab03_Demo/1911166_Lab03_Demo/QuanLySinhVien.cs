using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911166_Lab03_Demo
{
	 public delegate int SoSanh(object sv1, object sv2);
	 public class QuanLySinhVien
	 {
		  public List<SinhVien> DanhSach;
		  public QuanLySinhVien()
		  {
				DanhSach = new List<SinhVien>();
		  }
		  public void Them(SinhVien sv)
		  {
				this.DanhSach.Add(sv);
		  }
		  public SinhVien this[int index]
		  {
				get { return DanhSach[index]; }
				set { DanhSach[index] = value; }
		  }
		  public void Xoa(object obj,SoSanh ss)
		  {
				int i = DanhSach.Count - 1;
				for ( ; i>=0 ; i--)
					 if (ss(obj, this[i]) == 0)
						  this.DanhSach.RemoveAt(i);
		  }
		  public SinhVien Tim(object obj, SoSanh ss)
		  {
				SinhVien svResult = null;
				foreach(SinhVien sv in DanhSach)
				{
					 if (ss(obj, sv) == 0)
					 {
						  svResult = sv;
						  break;
					 }
				}
				return svResult;
		  }
		  public bool Sua(SinhVien svSua,object obj,SoSanh ss)
		  {
				int i, count;
				bool kq = false;
				count = this.DanhSach.Count - 1;
				for (i = 0; i < count; i++)
				{
					 if (ss(obj, this[i]) == 0)
					 {
						  this[i] = svSua;
						  kq = true;
						  break;
					 }
				}
				return kq;
		  }
		  public void DocTuFile()
		  {
				var _filePath = "Data\\DanhSachSV.txt";
				SinhVien sv;
				string[] s;
				using (var stream = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
				{
					 using (var reader = new StreamReader(stream))
					 {
						  while (!reader.EndOfStream)
						  {
								var line = reader.ReadLine();
								if (line == null)
								{
									 break;
								}
								else
								{
									 s = line.Split('*');
									 sv = new SinhVien();
									 sv.MaSo = s[0];
									 sv.HoTen = s[1];
									 sv.NgaySinh = DateTime.Parse(s[2]);
									 sv.DiaChi = s[3];
									 sv.Lop = s[4];
									 sv.Hinh = s[5];
									 if (s[6] == "1")
										  sv.GioiTinh = true;
									 else
										  sv.GioiTinh = false;
									 string[] dscn = s[7].Split(',');
									 foreach (string cn in dscn)
									 {
										  sv.ChuyenNganh.Add(cn.Trim());
									 }
									 this.Them(sv);
								}
						  }
					 }
				}
		  }

	 }
}
