using ClosedXML.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911166_LabKTGiuaKi
{
	 public partial class Form1 : Form
	 {
		  private string Holder = "Nhập thông tin cần tìm !!!";
		  public Form1()
		  {
				InitializeComponent();
		  }

		  
		  QuanLySinhVien qlsv;
		  List<Students> dsSV;
		  string lopchon = "";
		  string khoachon = "";
		  List<Department> dsKhoa;
		  private void Form1_Load(object sender, EventArgs e)
		  {
				qlsv = new QuanLySinhVien();
				dsSV = qlsv.dsSV;
				dsKhoa = qlsv.dsKhoa;
				LoadListView();
				ShowKhoaLopOnTreeView(dsKhoa);
				SetUpSearchInputText();
		  }
		  private void ThemSV(Students sv)
		  {
				ListViewItem lvItem = new ListViewItem(sv.MSSV);
				lvItem.SubItems.Add(sv.HoTenLot);
				lvItem.SubItems.Add(sv.Ten);
				if(sv.GioiTinh == null)
				{
					 lvItem.SubItems.Add("Nam");
				}
				else
				{
					 lvItem.SubItems.Add(sv.GioiTinh);
				}
				if(sv.GioiTinh == null)
				{
					 lvItem.SubItems.Add("01/01/0001");
				}
				else
				{
					 lvItem.SubItems.Add(sv.NgaySinh);
				}
				lvItem.SubItems.Add(sv.SoDT);
				lvItem.SubItems.Add(sv.Lop);
				lvItem.SubItems.Add(sv.DiaChi);
				this.lvDSSV.Items.Add(lvItem);
		  }
		  private void LoadListView()
		  {
				lvDSSV.Items.Clear();
				foreach(Students sv in qlsv.dsSV)
				{
					 ThemSV(sv);
				}
		  }
		  private void LoadListView(List<Students> dsSinhVien)
		  {
				lvDSSV.Items.Clear();
				foreach(Students sv in dsSinhVien)
				{
					 ThemSV(sv);
				}
		  }
		  private void ShowKhoaLopOnTreeView(List<Department> danhsachkhoa)
		  {
				tvKhoa.Nodes.Clear();
				foreach(Department khoa in danhsachkhoa)
				{
					 var khoaNode = tvKhoa.Nodes.Add(khoa.TenKhoa);
					 foreach(var lop in khoa.DSLop)
					 {
						  khoaNode.Nodes.Add(lop.TenLop);
					 }
				}
				tvKhoa.ExpandAll(); // khong bi thu lai
		  }

		  private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
		  {
				this.lvDSSV.Items.Clear();
				if (e.Node.Level == 0)
				{
					 List<Students> danhsachsinhvien = qlsv.getDSSV(e.Node.Text);
					 LoadListView(danhsachsinhvien);
					 lopchon = "";
				}
				if(e.Node.Level == 1)
				{
					 List<Students> dssinhvien = qlsv.getDSSV(e.Node.Parent.Text, e.Node.Text);
					 LoadListView(dssinhvien);
					 lopchon = e.Node.Text;
					 khoachon = e.Node.Parent.Text;
				}
		  }
		  private void SetUpSearchInputText()
		  {
				txtSearch.Text = Holder;
				txtSearch.GotFocus += RemovePlaceHolderText;
				txtSearch.LostFocus += ShowPlaceHolderText;
		  }
		  private void ShowPlaceHolderText(object sender, EventArgs e)
		  {
				if (string.IsNullOrEmpty(txtSearch.Text))
				{
					 txtSearch.Text = Holder;
				}
		  }

		  private void RemovePlaceHolderText(object sender, EventArgs e)
		  {
				if (txtSearch.Text == Holder)
				{
					 txtSearch.Text = "";
				}
		  }
		  private Students getSVtuListView(ListViewItem lvItem)
		  {
				Students sv = new Students();
				sv.MSSV = lvItem.SubItems[0].Text;
				sv.HoTenLot = lvItem.SubItems[1].Text;
				sv.Ten = lvItem.SubItems[2].Text;
				sv.GioiTinh = lvItem.SubItems[3].Text;
				sv.NgaySinh = lvItem.SubItems[4].Text;
				sv.SoDT = lvItem.SubItems[5].Text;
				sv.Lop = lvItem.SubItems[6].Text;
				sv.DiaChi = lvItem.SubItems[7].Text;
				return sv;
		  }
		  private void txtSearch_TextChanged(object sender, EventArgs e)
		  {
				List<Students> dssv = new List<Students>();
				List<Students> dskq = new List<Students>();
				for (int i = 0; i < this.lvDSSV.Items.Count; i++)
				{
					 Students sv = getSVtuListView(lvDSSV.Items[i]);
					 dssv.Add(sv);
				}
				if (rdMSSV.Checked)
				{
					 foreach(var sv in dssv)
					 {
						  if (sv.MSSV.Contains(txtSearch.Text))
						  {
								dskq.Add(sv);
						  }
					 }
				}
				if (rdHoTen.Checked)
				{
					 foreach (var sv in dssv)
					 {
						  if (sv.Ten.ToLower().Contains(txtSearch.Text.ToLower().Trim()))
						  {
								dskq.Add(sv);
						  }
					 }
				}
				if (rdSDT.Checked)
				{
					 foreach (var sv in dssv)
					 {
						  if (sv.SoDT.Contains(txtSearch.Text))
						  {
								dskq.Add(sv);
						  }
					 }
				}
				LoadListView(dskq);
		  }

		  private void lvDSSV_MouseDoubleClick(object sender, MouseEventArgs e)
		  {
				int count = this.lvDSSV.Items.Count;
				if (count > 0)
				{
					 ListViewItem lvItem = this.lvDSSV.SelectedItems[0];
					 Students sv = dsSV.Find(x => x.MSSV == lvItem.SubItems[0].Text);
					 if(sv == null)
					 {
						  return;
					 }
					 StudentInfo dlg = new StudentInfo(sv);
					 dlg.ShowDialog();

				}
				LoadListView();
		  }

		  private void tsmiAddStudent_Click(object sender, EventArgs e)
		  {
				StudentInfo dlg = new StudentInfo(null);
				dlg.ShowDialog();
				if(dlg.DialogResult== DialogResult.OK)
				{
					 qlsv.ThemSV(dlg.kq);
					 LoadListView();
				}
		  }

		  private void tsmiExcel_Click(object sender, EventArgs e)
		  {
				if (string.IsNullOrWhiteSpace(lopchon))
				{
					 MessageBox.Show("Bạn chưa chọn lớp để lưu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					 return;
				}
				else
				{
					 List<Students> dssv = new List<Students>();
					 for(int i= 0; i < this.lvDSSV.Items.Count; i++)
					 {
						  ListViewItem lvItem = this.lvDSSV.Items[i];
						  Students sv = new Students();
						  sv = getSVtuListView(lvItem);
						  sv.Khoa = khoachon;
						  dssv.Add(sv);
					 }
					 saveFileDlg.Title = "Lưu File";
					 saveFileDlg.Filter = "Excel |*.xlsx";
					 saveFileDlg.InitialDirectory = "D:\\";
					 saveFileDlg.FileName = lopchon;
					 if (saveFileDlg.ShowDialog() == DialogResult.OK)
					 {
						  var dataList = dssv;
						  var workbook = new XLWorkbook();
						  var wsDetailData = workbook.AddWorksheet(lopchon);
						  wsDetailData.Cell(1, 1).InsertTable(dssv);
						  workbook.SaveAs(saveFileDlg.FileName);
						  MessageBox.Show("Lưu file Excel thành công.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
	 				}
				}
		  }

		  private void tsmiJson_Click(object sender, EventArgs e)
		  {
				if (string.IsNullOrWhiteSpace(lopchon))
				{
					 MessageBox.Show("Bạn chưa chọn lớp để lưu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					 return;
				}
				else
				{
					 List<Students> dssv = new List<Students>();
					 for (int i = 0; i < this.lvDSSV.Items.Count; i++)
					 {
						  ListViewItem lvItem = this.lvDSSV.Items[i];
						  Students sv = new Students();
						  sv = getSVtuListView(lvItem);
						  sv.Khoa = khoachon;
						  dssv.Add(sv);
					 }
					
					 saveFileDlg.Title = "Lưu File";
					 saveFileDlg.Filter = "Json |*.json";
					 saveFileDlg.InitialDirectory = "D:\\";
					 saveFileDlg.FileName = lopchon;
					 if (saveFileDlg.ShowDialog() == DialogResult.OK)
					 {
						  var data = JsonConvert.SerializeObject(dssv);
						  File.WriteAllText(saveFileDlg.FileName, data);
						  MessageBox.Show("Lưu file Json thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
	 				}
				}
		  }
	 }
}
