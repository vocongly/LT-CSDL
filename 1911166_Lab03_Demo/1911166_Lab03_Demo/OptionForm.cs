using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911166_Lab03_Demo
{
	 public partial class OptionForm : Form
	 {
		  public List<SinhVien> dsSV;
		  int i;
		  public OptionForm(QuanLySinhVien qlgv,int number)
		  {
				dsSV = qlgv.DanhSach;
				i = number;
				InitializeComponent();
		  }
		  private void OptionForm_Load(object sender, EventArgs e)
		  {
				if (i == 0)
				{
					 pnSearch.Enabled = false;
				}
				else
				{
					 btnSort.Enabled = false;
				}
		  }
		  private void btnExit_Click(object sender, EventArgs e)
		  {
				Close();
		  }

		  private void btnSearch_Click(object sender, EventArgs e)
		  {
				string timkiem = txtInfo.Text;
				List<SinhVien> dskq = new List<SinhVien>();
				if (string.IsNullOrEmpty(timkiem))
				{
					 MessageBox.Show("Hãy nhận thông tin tìm!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					 if (rdMaSV.Checked == true)
					 {
						  foreach(var sv in dsSV)
						  {
								if(sv.MaSo.Trim() == timkiem.Trim())
								{
									 dskq.Add(sv);
								}
						  }
						  dsSV.Clear();
						  if (dskq.Count == 0)
						  {
								MessageBox.Show("Không tìm thấy sinh viên có mã số là " + timkiem,"Lỗi");
						  }
						  else
						  {
								dsSV = dskq;
								MessageBox.Show("Số sinh viên tìm thấy: " + dsSV.Count);
								Close();
						  }
					 }
					 if (rdHoTen.Checked == true)
					 {
						  foreach (var sv in dsSV)
						  {
								if (sv.HoTen.Trim().ToLower() == timkiem.Trim().ToLower())
								{
									 dskq.Add(sv);
								}
						  }
						  dsSV.Clear();
						  if (dskq.Count == 0)
						  {
								MessageBox.Show("Không tìm thấy sinh viên có họ tên là " + timkiem, "Lỗi");
						  }
						  else
						  {
								dsSV = dskq;
								MessageBox.Show("Số sinh viên tìm thấy: " + dsSV.Count);
								Close();
						  }
					 }
					 if (rdNgaySinh.Checked == true)
					 {
						  foreach (var sv in dsSV)
						  {
								if (sv.NgaySinh == DateTime.Parse(timkiem))
								{
									 dskq.Add(sv);
								}
						  }
						  dsSV.Clear();
						  if (dskq.Count == 0)
						  {
								MessageBox.Show("Không tìm thấy sinh viên có ngày sinh là " + timkiem, "Lỗi");
						  }
						  else
						  {
								dsSV = dskq;
								MessageBox.Show("Số sinh viên tìm thấy: " + dsSV.Count);
								Close();
						  }
					 }
				}
		  }
		  private void btnSort_Click(object sender, EventArgs e)
		  {
			   if(rdMaSV.Checked == true)
			   {
					 dsSV =  dsSV.OrderBy(x => x.MaSo).ToList();
					 Close();
			   }
			   if (rdHoTen.Checked == true)
			   {
					 dsSV = dsSV.OrderBy(x => x.HoTen).ToList();
					 Close();
			   }
			   if (rdNgaySinh.Checked == true)
			   {
					 dsSV = dsSV.OrderBy(x => x.NgaySinh).ToList();
					 Close();
			   }
		  }

		  
	 }
}
