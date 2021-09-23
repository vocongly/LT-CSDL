using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911166_QLSV_CNTT
{
	 public partial class QLSVForm : Form
	 {
		  QuanLySinhVien qlsv;
		  public bool checkChange= false;
		  public QLSVForm()
		  {
				InitializeComponent();
		  }
		  private void QLSVForm_Load(object sender, EventArgs e)
		  {
				qlsv = new QuanLySinhVien();
				qlsv.DocTuFile();
				LoadListView(qlsv.dsSV);
		  }
		  private void btnChonHinh_Click(object sender, EventArgs e)
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
					 txtLinkImage.Text = filename;
					 pbHinhSV.Load(filename);
				}
		  }

		  private void btnMacDinh_Click(object sender, EventArgs e)
		  {
				this.mstbMSSV.Text = "";
				this.txtHoTen.Text = "";
				this.txtEmail.Text = "";
				this.txtAddress.Text = "";
				this.txtLinkImage.Text = "";
				this.dtpNgaySinh.Value = DateTime.Now;
				this.rdNam.Checked = true;
				this.cbbLop.Text = this.cbbLop.Items[0].ToString();
				this.mstbNumberPhone.Text = "";
		  }

		  private void btnSave_Click(object sender, EventArgs e)
		  {
				if(mstbMSSV.Text=="" && txtHoTen.Text == "" && txtEmail.Text =="" && txtAddress.Text== "" && cbbLop.Text == "" && txtLinkImage.Text == "")
				{
					 MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					 SinhVien sv = GetSinhVien();
					 bool kq = qlsv.Tim(sv);
					 if (kq == true)
					 {
						  this.qlsv.Them(sv);
						  this.LoadListView();
						  checkChange = true;
					 }
					 else
					 {
						  DialogResult dlg = MessageBox.Show("Mã sinh viên đã tồn tại " + "\n" + "Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
						  if(dlg == DialogResult.OK)
						  {
								this.qlsv.Sua(sv);
								this.LoadListView();
								checkChange = true;
						  }
						  if(dlg == DialogResult.Cancel)
						  {
								return;
								this.btnMacDinh.PerformClick();
						  }
					 }
				}
				
		  }

		  private void btnExit_Click(object sender, EventArgs e)
		  {
				Application.Exit();
		  }

		  private SinhVien GetSinhVien()
		  {
				SinhVien sv = new SinhVien();
				bool gt = true;
				sv.MaSo = this.mstbMSSV.Text;
				sv.HoTen = this.txtHoTen.Text;
				sv.Email = this.txtEmail.Text;
				sv.DiaChi = this.txtAddress.Text;
				sv.LinkHinh = this.txtLinkImage.Text;
				sv.NgaySinh = this.dtpNgaySinh.Value;
				if (rdNu.Checked == true)
					 gt = false;
				sv.Phai = gt;
				sv.Lop = this.cbbLop.Text;
				sv.SDT = this.mstbNumberPhone.Text;
				return sv;
		  }
		  private SinhVien GetSinhVien(ListViewItem lvItem)
		  {
				SinhVien sv = new SinhVien();
				sv.MaSo = lvItem.SubItems[0].Text;
				sv.HoTen = lvItem.SubItems[1].Text;
				sv.Phai = false;
				if (lvItem.SubItems[2].Text == "Nam")
					 sv.Phai = true;
				sv.NgaySinh = DateTime.Parse(lvItem.SubItems[3].Text);
				sv.Lop = lvItem.SubItems[4].Text;
				sv.SDT = lvItem.SubItems[5].Text;
				sv.Email = lvItem.SubItems[6].Text;
				sv.DiaChi = lvItem.SubItems[7].Text;
				sv.LinkHinh = lvItem.SubItems[8].Text;
				return sv;
		  }
		  private void ThemSV(SinhVien sv)
		  {
				ListViewItem lvItem = new ListViewItem(sv.MaSo);
				lvItem.SubItems.Add(sv.HoTen);
				string gt = "Nữ";
				if (sv.Phai)
					 gt = "Nam";
				lvItem.SubItems.Add(gt);
				lvItem.SubItems.Add(sv.NgaySinh.ToShortDateString());
				lvItem.SubItems.Add(sv.Lop);
				lvItem.SubItems.Add(sv.SDT);
				lvItem.SubItems.Add(sv.Email);
				lvItem.SubItems.Add(sv.DiaChi);
				lvItem.SubItems.Add(sv.LinkHinh);
				this.lvDSSV.Items.Add(lvItem);
		  }
		  private void LoadListView()
		  {
				this.lvDSSV.Items.Clear();
				foreach(SinhVien sv in qlsv.dsSV)
				{
					 ThemSV(sv);
				}
		  }
		  private void LoadListView(List<SinhVien> dsSinhVien)
		  {
				this.lvDSSV.Items.Clear();
				foreach (SinhVien sv in dsSinhVien)
				{
					 ThemSV(sv);
				}
		  }
		  private void ThietLapSinhVien(SinhVien sv)
		  {
				this.mstbMSSV.Text = sv.MaSo;
				this.txtHoTen.Text = sv.HoTen;
				this.txtEmail.Text = sv.Email;
				this.txtAddress.Text = sv.DiaChi;
				this.txtLinkImage.Text = sv.LinkHinh;
				this.cbbLop.Text = sv.Lop;
				this.rdNu.Checked = true;
				if (sv.Phai)
					 this.rdNam.Checked = true;
				else
					 this.rdNu.Checked = true;
				this.mstbNumberPhone.Text = sv.SDT;
				this.dtpNgaySinh.Value = sv.NgaySinh;
				if(sv.LinkHinh == "")
				{
					 this.pbHinhSV.Image = null;
				}
				else
				{
					 this.pbHinhSV.ImageLocation = sv.LinkHinh;
				}

		  }

		  private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
		  {
				int count = this.lvDSSV.SelectedItems.Count;
				if(count > 0)
				{
					 ListViewItem lvItem = this.lvDSSV.SelectedItems[0];
					 SinhVien sv = GetSinhVien(lvItem);
					 ThietLapSinhVien(sv);
				}
		  }

		  private void XoaToolStripMenuItem_Click(object sender, EventArgs e)
		  {
				int count, i;
				ListViewItem lvItem;
				count = this.lvDSSV.Items.Count - 1;
				for(i = count; i >= 0; i--)
				{
					 lvItem = this.lvDSSV.Items[i];
					 if(lvItem.Checked)
					 {
						  qlsv.Xoa(lvItem.SubItems[0].Text);
					 }
				}
				this.LoadListView();
				this.btnMacDinh.PerformClick();
		  }

		  private void ReloadDSSVToolStripMenuItem_Click(object sender, EventArgs e)
		  {
				qlsv.dsSV.Clear();
				qlsv.DocTuFile();
				this.LoadListView();
		  }
		  
		  private void QLSVForm_FormClosing(object sender, FormClosingEventArgs e)
		  {
				if (checkChange)
				{
					 DialogResult dlg = MessageBox.Show("Bạn có muốn lưu chỉnh sửa của mình không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
					 if(dlg == DialogResult.Yes)
					 {
						  this.qlsv.Save(qlsv.dsSV);
					 }
					 if(dlg == DialogResult.Cancel)
					 {
						  e.Cancel = true;
					 }
				}
		  }
	 }
}
