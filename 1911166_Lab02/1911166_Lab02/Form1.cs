using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911166_Lab02
{
	 public partial class MainForm : Form
	 {
		  public MainForm()
		  {
				InitializeComponent();
		  }

		  private void btnExit_Click(object sender, EventArgs e)
		  {
				Application.Exit();
		  }

		  private void btnCancel_Click(object sender, EventArgs e)
		  {
				this.Reset();
		  }
		  private void Reset()
		  {
				this.cboMaHV.Text = "";
				this.txtHoTen.Text = "";
				this.dtpNgayDangKy.Value = DateTime.Now;
				this.rdNam.Checked = true;
				this.chkTiengAnhA.Checked = false;
				this.chkTiengAnhB.Checked = false;
				this.chkTinHocA.Checked = false;
				this.chkTinHocB.Checked = false;
				this.txtTongTien.Text = "";
		  }

		  private void btnTinhTien_Click(object sender, EventArgs e)
		  {
				int s = 0;
				if (chkTinHocA.Checked)
					 s += int.Parse(lbTienTHA.Text.Split('.')[0]);
				if (chkTinHocB.Checked)
					 s += int.Parse(lbTienTHB.Text.Split('.')[0]);
				if (chkTiengAnhA.Checked)
					 s += int.Parse(lbTienTAA.Text.Split('.')[0]);
				if (chkTiengAnhB.Checked)
					 s += int.Parse(lbTienTAB.Text.Split('.')[0]);
				this.txtTongTien.Text = s + ".000 đồng";
		  }
	 }
}
