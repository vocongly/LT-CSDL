using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _1911166_Lab02
{
	 public partial class TeacherForm : Form
	 {

		  QuanLyGiaoVien qlgv;
		  public TeacherForm()
		  {
				InitializeComponent();
		  }

		  private void TeacherForm_Load(object sender, EventArgs e)
		  {
				qlgv = new QuanLyGiaoVien();
				string lienhe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
				this.lblLienHe.Links.Add(0, lienhe.Length, lienhe);
				this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
		  }
		  
		  private void btnChon_Click(object sender, EventArgs e)
		  {
				int i = this.lbDanhSachMH.SelectedItems.Count - 1;
				while (i >= 0)
				{
					 this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
					 this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
					 i--;
				}
		  }

		  private void btnXoa_Click(object sender, EventArgs e)
		  {
				int i = this.lbMonHocDay.SelectedItems.Count - 1;
				while (i >= 0)
				{
					 this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
					 this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
					 i--;
				}
		  }
		  private void btnCancel_Click(object sender, EventArgs e)
		  {
				Reset();
		  }
		  private void Reset()
		  {
				this.cboMaSo.Text = "";
				this.txtHoTen.Text = "";
				this.txtMail.Text = "";
				this.mskSDT.Text = "";
				this.rdNam.Checked = true;
				for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
				{
					 chklbNgoaiNgu.SetItemChecked(i, false);
				}
				foreach (object ob in this.lbMonHocDay.Items)
				{
					 this.lbDanhSachMH.Items.Add(ob);
				}
				this.lbMonHocDay.Items.Clear();

		  }

		  private void lblLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		  {
				string s = e.Link.LinkData.ToString();
				Process.Start(s);
		  }

		  private void btnLuu_Click(object sender, EventArgs e)
		  {
				TBGiaoVienForm frm = new TBGiaoVienForm();
				frm.SetText(GetGiaoVien().ToString());
				frm.ShowDialog();
		  }
		  public GiaoVien GetGiaoVien()
		  {
				string gt = "Nam";
				if (rdNu.Checked)
					 gt = "Nữ";
				GiaoVien gv = new GiaoVien();
				gv.MaSo = this.cboMaSo.Text;
				gv.GioiTinh = gt;
				gv.HoTen = this.txtHoTen.Text;
				gv.NgaySinh = this.dtpNgaySinh.Value;
				gv.Mail = this.txtMail.Text;
				gv.SoDT = "0633"+this.mskSDT.Text;

				string ngoaingu = "";
				for(int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
				{
					 if (chklbNgoaiNgu.GetItemChecked(i))
					 {
						  ngoaingu += chklbNgoaiNgu.Items[i] + ";";
					 }
				}
				gv.NgoaiNgu = ngoaingu.Split(',');
				DanhMucMonHoc mh = new DanhMucMonHoc();
				foreach (object ob in lbMonHocDay.Items)
					 mh.Them(new MonHoc(ob.ToString()));
				gv.dsMonHoc = mh;

				return gv;
		  }
		  private void btnExit_Click(object sender, EventArgs e)
		  {
				Application.Exit();
		  }

		  private void btnAdd_Click(object sender, EventArgs e)
		  {
				GiaoVien gv = GetGiaoVien();
				GiaoVien kq = qlgv.Tim(gv.MaSo, delegate (object obj1, object obj2)
				  {
						return (obj2 as GiaoVien).MaSo.CompareTo(obj1.ToString());
				  });
				if(kq != null)
				{
					 MessageBox.Show("Mã giáo viên đã tồn tại!", "Lỗi");
				}
				else
				{
					 this.qlgv.Them(gv);
					 TBGiaoVienForm frm = new TBGiaoVienForm();
					 frm.SetText(GetGiaoVien().ToString());
					 frm.ShowDialog();
				}
		  }

		  private void btnSearch_Click(object sender, EventArgs e)
		  {
				SearchForm frm = new SearchForm(qlgv);
				
				frm.ShowDialog();
		  }
	 }
}
