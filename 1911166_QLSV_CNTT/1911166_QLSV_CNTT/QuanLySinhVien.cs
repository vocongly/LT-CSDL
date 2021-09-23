using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911166_QLSV_CNTT
{
	 public class QuanLySinhVien
	 {
		  public List<SinhVien> dsSV;
		  private const string _filePath = "Data\\data.txt";
		  public QuanLySinhVien()
		  {
				dsSV = new List<SinhVien>();
		  }
		  public void Them(SinhVien sv)
		  {
				dsSV.Add(sv);
		  }
		  public bool Tim(SinhVien sv)
		  {
				var kq = dsSV.Find(x => x.MaSo == sv.MaSo);
				if(kq == null)
				{
					 return true;
				}
				return false;
		  }
		  public void Xoa(string maso)
		  {
				for(int i = this.dsSV.Count - 1; i >= 0; i--)
				{
					 if(dsSV[i].MaSo == maso)
					 {
						  this.dsSV.RemoveAt(i);
					 }
				}
		  }
		  public void Sua(SinhVien sv)
		  {
				var kq = dsSV.Find(x => x.MaSo == sv.MaSo);
				if (kq == null) return;
				else
				{
					 dsSV.RemoveAll(x => x.MaSo == sv.MaSo);
					 dsSV.Add(sv);
				}
		  }
		  public void DocTuFile()
		  {
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
									 if (s[2] == "Nam")
										  sv.Phai = true;
									 else
										  sv.Phai = false;
									 sv.NgaySinh = DateTime.Parse(s[3]);
									 sv.Lop = s[4];
									 sv.SDT = s[5];
									 sv.Email = s[6];
									 sv.DiaChi = s[7];
									 sv.LinkHinh = s[8];
									 this.Them(sv);
								}
						  }
					 }
				}
		  }
		  public void Save(List<SinhVien> dsSinhVien) 
		  {
				using (var steam = new FileStream(_filePath, FileMode.Create, FileAccess.Write))
				{
					 using (var write = new StreamWriter(steam))
					 {
						  foreach (var sv in dsSinhVien)
						  {
								write.WriteLine("{0}*{1}*{2}*{3}*{4}*{5}*{6}*{7}*{8}*",sv.MaSo,
									 sv.HoTen,sv.Phai == true ? "Nam" : "Nữ",sv.NgaySinh,sv.Lop,sv.SDT,sv.Email,sv.DiaChi,sv.LinkHinh);
						  }
					 }
				}
		  }
	 }
}
