using _1911166_LabKTGiuaKi.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911166_LabKTGiuaKi
{
	 public class QuanLySinhVien
	 {
		  public List<Students> dsSV;
		  public List<Department> dsKhoa;
		  public List<Class> dsLop;
		  private IODataSource _dataSource;

		  public QuanLySinhVien()
		  {
				dsSV = new List<Students>();
				dsKhoa = new List<Department>();
				_dataSource = new TextDataSource();
				dsSV = _dataSource.getNews();
				dsKhoa = DocKhoaTuSV(dsSV);
				dsLop = DocLopTuKhoa(dsKhoa);
		  }
		  public void ThemSV(Students sv)
		  {
				Department khoa = dsKhoa.Find(x => x.TenKhoa == sv.Khoa);
				if(khoa != null)
				{
					 khoa.AddSV(sv);
				}
		  }
		  public List<Students> getNews()
		  {
				if (dsSV == null)
				{
					 dsSV = _dataSource.getNews();
				}
				return dsSV;
		  }
		  public void Save()
		  {
				_dataSource.Save(dsSV);
		  }

		  public List<Department> DocKhoaTuSV(List<Students> dssv)
		  {
				foreach(var sv in dssv)
				{
					 int index = dsKhoa.FindIndex(x => x.TenKhoa == sv.Khoa);
					 if(index == -1)
					 {
						  Department khoa = new Department(sv.Khoa);
						  khoa.AddSV(sv);
						  dsKhoa.Add(khoa);
					 }
					 else
					 {
						  dsKhoa[index].AddSV(sv);
					 }
				}
				return dsKhoa;
		  }
		  public List<Class> DocLopTuKhoa(List<Department> dskhoa)
		  {
				List<Class> dslop = new List<Class>();
				foreach (var khoa in dskhoa)
				{
					 foreach(var lop in khoa.DSLop)
					 {
						  dslop.Add(lop);
					 }
				}
				return dslop;
		  }
		  public List<Students> getDSSV(string tenkhoa, string tenlop)
		  {
				var khoa = dsKhoa.Find(x => x.TenKhoa == tenkhoa);
				if (khoa == null) return new List<Students>();
				var lop = khoa.DSLop.Find(x => x.TenLop == tenlop);
				if (lop == null) return new List<Students>();
				return lop.dsSV;
		  }
		  public List<Students> getDSSV(string tenkhoa)
		  {
				List<Students> dskq = new List<Students>();
				var khoa = dsKhoa.Find(x => x.TenKhoa == tenkhoa);
				if (khoa == null) return new List<Students>();
				return khoa.dssv;
		  }

		  public void UpdateSV(Students sv)
		  {
				Students sinhvien = dsSV.Find(x => x.MSSV == sv.MSSV);
				if (sinhvien != null)
				{
					 sinhvien = sv;
				}
		  }
	 }
}
