using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911166_LabKTGiuaKi
{
	 public partial class StudentInfo : Form
	 {
		  int i;
		  List<Students> dssv;
		  Students sv;
		  QuanLySinhVien qlgv;
		  public Students kq;
		  public StudentInfo(Students sinhvien)
		  {
				sv = sinhvien;
				InitializeComponent();
		  }

		  private void StudentInfo_Load(object sender, EventArgs e)
		  {
				qlgv = new QuanLySinhVien();
				dssv = new List<Students>();
				dssv = qlgv.dsSV;
				if (sv != null)
				{
					 this.mstbMSSV.Enabled = false;
					 ThietLapCombox();
					 ThietLapSV(sv);
				}
				else
				{
					 this.rdNam.Checked = true;
					 ThietLapCombox();
				}
		  }

		  private void ThietLapCombox()
		  {
				foreach(var item in qlgv.dsKhoa)
				{
					 this.cbbKhoa.Items.Add(item.TenKhoa);
					 foreach (var lop in item.DSLop)
					 {
						  this.cbbLop.Items.Add(lop.TenLop);
					 }
				}
		  }
		  private void ThietLapSV(Students sv)
		  {
				this.mstbMSSV.Text = sv.MSSV;
				this.txtHoTenLot.Text = sv.HoTenLot;
				this.txtTen.Text = sv.Ten;
				this.rdNam.Checked = true;
				if(sv.GioiTinh == "Nữ")
				{
					 this.rdNu.Checked = true;
				}
				try
				{
					 this.dtpNgaySinh.Text = sv.NgaySinh;
				}
				catch
				{
					 this.dtpNgaySinh.Value = DateTime.Now;
				}
				this.cbbKhoa.Text = sv.Khoa;
				this.cbbLop.Text = sv.Lop;
				this.mstbSDT.Text = sv.SoDT;
				this.txtDiaChi.Text = sv.DiaChi;
		  }

		  private Students GetSV()
		  {
				Students sinhvien = new Students();
				sinhvien.MSSV = this.mstbMSSV.Text;
				sinhvien.HoTenLot = this.txtHoTenLot.Text;
				sinhvien.Ten = this.txtTen.Text;
				sinhvien.GioiTinh = "Nam";
				if(this.rdNu.Checked == true)
				{
					 sinhvien.GioiTinh = "Nữ";
				}
				sinhvien.NgaySinh = this.dtpNgaySinh.Value.ToShortDateString();
				sinhvien.Lop = this.cbbLop.Text;
				sinhvien.Khoa = this.cbbKhoa.Text;
				sinhvien.SoDT = this.mstbSDT.Text;
				sinhvien.DiaChi = this.txtDiaChi.Text;
				return sinhvien;
		  }
		  private Students GetUpdateSV()
		  {
				sv.MSSV = this.mstbMSSV.Text;
				sv.HoTenLot = this.txtHoTenLot.Text;
				sv.Ten = this.txtTen.Text;
				sv.GioiTinh = "Nam";
				if (this.rdNu.Checked == true)
				{
					 sv.GioiTinh = "Nữ";
				}
				sv.NgaySinh = this.dtpNgaySinh.Value.ToShortDateString();
				sv.Lop = this.cbbLop.Text;
				sv.Khoa = this.cbbKhoa.Text;
				sv.SoDT = this.mstbSDT.Text;
				sv.DiaChi = this.txtDiaChi.Text;
				return sv;
		  }
		  private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
		  {
				Department khoa = qlgv.dsKhoa.Find(x => x.TenKhoa == this.cbbKhoa.Text);
				if (khoa != null)
				{
					 this.cbbLop.Items.Clear();
					 foreach(var lop in khoa.DSLop)
					 {
						  this.cbbLop.Items.Add(lop.TenLop);
					 }
				}
		  }

		  private void btnSave_Click(object sender, EventArgs e)
		  {
				if (sv != null)
				{
					 if(this.mstbMSSV.Text =="" || this.txtHoTenLot.Text=="" || this.txtTen.Text == "" || this.cbbLop.Text == "" || this.cbbKhoa.Text == "")
					 {
						  MessageBox.Show("Bạn cần nhập đầy đủ thông tin !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						  return;
					 }
					 Students kq = GetUpdateSV();
					 qlgv.UpdateSV(kq);
					 Close();
				}
				else
				{
					 if (this.mstbMSSV.Text == "" || this.txtHoTenLot.Text == "" || this.txtTen.Text == "" || this.cbbLop.Text == "" || this.cbbKhoa.Text == "")
					 {
						  MessageBox.Show("Bạn cần nhập đầy đủ thông tin !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						  return;
					 }
					 else
					 {
						  Students sv = qlgv.dsSV.Find(x => x.MSSV == this.mstbMSSV.Text);
						  if (sv != null)
						  {
								MessageBox.Show("Mã số sinh viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
						  }
						  else
						  {
								kq = GetSV();
						  }
					 }
				}
				this.DialogResult= DialogResult.OK;
		  }
	 }
}
