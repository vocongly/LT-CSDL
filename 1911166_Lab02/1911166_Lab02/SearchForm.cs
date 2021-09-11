using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _1911166_Lab02
{
	 public partial class SearchForm : Form
	 {
		  public List<GiaoVien> dsGV;
		  public GiaoVien gv;

		  public SearchForm(QuanLyGiaoVien qlgv)
		  {
				dsGV = qlgv.dsGiaoVien;
				InitializeComponent();
		  }
		  private void rdMaSo_CheckedChanged(object sender, EventArgs e)
		  {
				if (sender is RadioButton)
				{
					 RadioButton radioButton = (RadioButton)sender;
					 if (rdMaSo.Checked)
					 {
						  label1.Text = rdMaSo.Text;
					 }
				}
		  }

		  private void rdHoTen_CheckedChanged(object sender, EventArgs e)
		  {
				if (sender is RadioButton)
				{
					 RadioButton radioButton = (RadioButton)sender;
					 if (rdHoTen.Checked)
					 {
						  label1.Text = rdHoTen.Text;
					 }
				}
		  }

		  private void rdSDT_CheckedChanged(object sender, EventArgs e)
		  {
				if (sender is RadioButton)
				{
					 RadioButton radioButton = (RadioButton)sender;
					 if (rdSDT.Checked)
					 {
						  label1.Text = rdSDT.Text;
					 }
				}
		  }

		  private void btnOK_Click(object sender, EventArgs e)
		  {
				var timkiem = txtSearch.Text;
				if (rdMaSo.Checked == true)
				{
					 GiaoVien kq = dsGV.Find(x => x.MaSo.Trim() == timkiem.Trim());
					 if (kq == null)
					 {
						  MessageBox.Show("Không tìm thấy giáo viên có mã số " + timkiem, "Lỗi");
					 }
					 else
					 {
						  TBGiaoVienForm frm = new TBGiaoVienForm();
						  frm.SetText(kq.ToString());
						  frm.ShowDialog();
					 }
				}
				if (rdHoTen.Checked == true)
				{
					 GiaoVien kq = dsGV.Find(x => x.HoTen.ToLower().Trim() == timkiem.ToLower().Trim());
					 if (kq == null)
					 {
						  MessageBox.Show("Không tìm thấy giáo viên có họ tên " + timkiem, "Lỗi");
					 }
					 else
					 {
						  TBGiaoVienForm frm = new TBGiaoVienForm();
						  frm.SetText(kq.ToString());
						  frm.ShowDialog();
					 }
				}
				if (rdSDT.Checked == true)
				{
					 GiaoVien kq = dsGV.Find(x => x.SoDT.Trim() == timkiem.Trim());
					 if (kq == null)
					 {
						  MessageBox.Show("Không tìm thấy giáo viên có số điện thoại " + timkiem, "Lỗi");
					 }
					 else
					 {
						  TBGiaoVienForm frm = new TBGiaoVienForm();
						  frm.SetText(kq.ToString());
						  frm.ShowDialog();
					 }
				}
		  }
	 }
}
