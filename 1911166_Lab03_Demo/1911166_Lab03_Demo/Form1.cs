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
	 public partial class SinhVienForm : Form
	 {
		  QuanLySinhVien qlsv;
		  public SinhVienForm()
		  {
				InitializeComponent();
		  }

		  private void SinhVienForm_Load(object sender, EventArgs e)
		  {
				qlsv = new QuanLySinhVien();
				qlsv.DocTuFile();
				LoadListView();
		  }
		  private SinhVien GetSinhVien()
		  {
				SinhVien sv = new SinhVien();
				bool gt = true;
				List<string> cn = new List<string>();
				sv.MaSo = this.mtxtMaSo.Text;
				sv.HoTen = this.txtHoTen.Text;
				sv.NgaySinh = this.dtpNgaySinh.Value;
				sv.DiaChi = this.txtDiaChi.Text;
				sv.Lop = this.cboLop.Text;
				if (rdNu.Checked)
					 gt = false;
				sv.GioiTinh = gt;
				for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
				{
					 if (clbChuyenNganh.GetItemChecked(i))
						  cn.Add(clbChuyenNganh.Items[i].ToString());
				}
				sv.ChuyenNganh = cn;
				sv.Hinh = this.txtHinh.Text;
				return sv;
		  }
		  // lay sinh vien tu dong item cua lv
		  private SinhVien GetSinhVien(ListViewItem lvItem)
		  {
				SinhVien sv = new SinhVien();
				sv.MaSo = lvItem.SubItems[0].Text;
				sv.HoTen = lvItem.SubItems[1].Text;
				sv.NgaySinh = DateTime.Parse(lvItem.SubItems[2].Text);
				sv.DiaChi = lvItem.SubItems[3].Text;
				sv.Lop = lvItem.SubItems[4].Text;
				sv.GioiTinh = false;
				if (lvItem.SubItems[5].Text == "Nam")
					 sv.GioiTinh = true;
				List<string> cn = new List<string>();
				string[] s = lvItem.SubItems[6].Text.Split(',');
				foreach (string item in s)
					 cn.Add(item.Trim());
				sv.ChuyenNganh = cn;
				sv.Hinh = lvItem.SubItems[7].Text;
				return sv;
		  }
		  private void ThietLapThongTin(SinhVien sv)
		  {
				this.mtxtMaSo.Text = sv.MaSo;
				this.txtHoTen.Text = sv.HoTen;
				this.dtpNgaySinh.Value = sv.NgaySinh;
				this.txtDiaChi.Text = sv.DiaChi;
				this.cboLop.Text = sv.Lop;
				this.pbHinh.ImageLocation = sv.Hinh;
				if (sv.GioiTinh)
					 this.rdNam.Checked = true;
				else
					 this.rdNu.Checked = true;
				for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
				{
					 this.clbChuyenNganh.SetItemChecked(i, false);
				}
				foreach (string s in sv.ChuyenNganh)
				{
					 for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
						  if (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
								this.clbChuyenNganh.SetItemChecked(i, true);
				}
		  }
		  private void ThemSV(SinhVien sv)
		  {
				ListViewItem lvItem = new ListViewItem(sv.MaSo);
				lvItem.SubItems.Add(sv.HoTen);
				lvItem.SubItems.Add(sv.NgaySinh.ToShortDateString());
				lvItem.SubItems.Add(sv.DiaChi);
				lvItem.SubItems.Add(sv.Lop);
				string gt = "Nữ";
				if (sv.GioiTinh)
					 gt = "Nam";
				lvItem.SubItems.Add(gt);
				string cn = "";
				foreach (string s in sv.ChuyenNganh)
					 cn += s + ",";
				cn = cn.Substring(0, cn.Length - 1);
				lvItem.SubItems.Add(cn);
				lvItem.SubItems.Add(sv.Hinh);
				this.lvSinhVien.Items.Add(lvItem);
		  }
		  private void LoadListView()
		  {
				this.lvSinhVien.Items.Clear();
				foreach (SinhVien sv in qlsv.DanhSach)
				{
					 ThemSV(sv);
				}
				tlSTongSV.Text = "Tổng sinh viên: " + lvSinhVien.Items.Count;
		  }
		  private void LoadListView(List<SinhVien> dsSV)
		  {
				this.lvSinhVien.Items.Clear();
				foreach (SinhVien sv in dsSV)
				{
					 ThemSV(sv);
				}
				tlSTongSV.Text = "Tổng sinh viên: " + lvSinhVien.Items.Count;
		  }
		  private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
		  {
				int count = this.lvSinhVien.SelectedItems.Count;
				if (count > 0)
				{
					 ListViewItem lvItem = this.lvSinhVien.SelectedItems[0];
					 SinhVien sv = GetSinhVien(lvItem);
					 ThietLapThongTin(sv);
				}
		  }

		  private void btnAdd_Click(object sender, EventArgs e)
		  {
				SinhVien sv = GetSinhVien();
				SinhVien kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2)
				 {
					  return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
				 });
				if (kq != null)
				{
					 MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu");
				}
				else
				{
					 this.qlsv.Them(sv);
					 this.LoadListView();
				}
		  }

		  private void btnThoat_Click(object sender, EventArgs e)
		  {
				Application.Exit();
		  }

		  private void btnDelete_Click(object sender, EventArgs e)
		  {
				int count, i;
				ListViewItem lvItem;
				count = this.lvSinhVien.Items.Count - 1;
				for (i = count; i >= 0; i--)
				{
					 lvItem = this.lvSinhVien.Items[i];
					 if (lvItem.Checked)
					 {
						  qlsv.Xoa(lvItem.SubItems[0].Text, SoSanhTheoMa);
					 }
				}
				this.LoadListView();
				this.btnMacDinh.PerformClick();
		  }

		  private void btnMacDinh_Click(object sender, EventArgs e)
		  {
				this.mtxtMaSo.Text = "";
				this.txtHoTen.Text = "";
				this.dtpNgaySinh.Value = DateTime.Now;
				this.txtDiaChi.Text = "";
				this.cboLop.Text = this.cboLop.Items[0].ToString();
				this.txtHinh.Text = "";
				this.pbHinh.ImageLocation = "";
				this.rdNam.Checked = true;
				for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
				{
					 this.clbChuyenNganh.SetItemChecked(i, false);
				}
		  }

		  private void btnSua_Click(object sender, EventArgs e)
		  {
				SinhVien sv = GetSinhVien();
				bool kqsua;
				kqsua = qlsv.Sua(sv, sv.MaSo, delegate(object obj1,object obj2) 
				{
					 return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
				});
				LoadListView();
		  }
		  private int SoSanhTheoMa(object obj1, object obj2)
		  {
				SinhVien sv = obj2 as SinhVien;
				return sv.MaSo.CompareTo(obj1.ToString());
		  }

		  private void btnBrowse_Click(object sender, EventArgs e)
		  {
				OpenFileDialog dlg = new OpenFileDialog();
				dlg.Title = "Select Picture";
				dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
								+ "*.jpg;*.jpeg;*.gif;*.bmp;"
								+ "*.tif;*.tiff;*.png|"
								+ "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
								+ "GIF files (*.gif)|*.gif|"
								+ "BMP files (*.bmp)|*.bmp|"
								+ "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
								+ "PNG files (*.png)|*.png|"
								+ "All files (*.*)|*.*";
				dlg.InitialDirectory = Environment.CurrentDirectory;
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					 var filename = dlg.FileName;
					 txtHinh.Text = filename;
					 pbHinh.Load(filename);
				}
		  }

		  private void tsmiSort_Click(object sender, EventArgs e)
		  {
				OptionForm frm = new OptionForm(qlsv,0);
				frm.ShowDialog();
				LoadListView(frm.dsSV);
		  }

		  private void tsmiSearch_Click(object sender, EventArgs e)
		  {
				OptionForm frm = new OptionForm(qlsv,1);
				frm.ShowDialog();
				LoadListView(frm.dsSV);
		  }

		  private void btbLoadDSSV_Click(object sender, EventArgs e)
		  {
				qlsv.DanhSach.Clear();
				qlsv.DocTuFile();
				LoadListView();
		  }
	 }
}
