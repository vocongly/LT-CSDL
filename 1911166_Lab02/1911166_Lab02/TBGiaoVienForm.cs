using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _1911166_Lab02
{
	 public partial class TBGiaoVienForm : Form
	 {
		  public TBGiaoVienForm()
		  {
				InitializeComponent();
		  }

		  private void TBGiaoVienForm_Load(object sender, EventArgs e)
		  {

		  }
		  public void SetText(string s)
		  {
				this.lbThongBao.Text = s;
		  }
	 }
}
