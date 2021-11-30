using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementProject
{
	 public partial class BillForm : Form
	 {
		  public BillForm()
		  {
				InitializeComponent();
		  }
		  List<Bill> listBill = new List<Bill>();
		  public void DisplayBill()
		  {
				BillBL billBL = new BillBL();
				listBill = billBL.GetAll();

				dgvOrder.DataSource = listBill;
		  }

		  private void btnSearchOrder_Click(object sender, EventArgs e)
		  {
				int totalAmount = 0;
				List<Bill> kq = new List<Bill>();
				string date = dtpTime.Text;
				foreach(var item in listBill)
				{
					 if(item.CheckoutDate.ToShortDateString() == date)
					 {
						  kq.Add(item);
						  totalAmount += item.Amount;
					 }
				}
				dgvOrder.DataSource = kq;
				tslTotalAmount.Text = "Tổng doanh thu trong ngày là : " + totalAmount + " VNĐ";
		  }

		  private void dgvOrder_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		  {
				DataGridViewRow row = dgvOrder.Rows[e.RowIndex];
				string idbills = row.Cells["ID"].Value.ToString();
				BillDetailForm frm = new BillDetailForm();
				frm.Show(this);
				frm.LoadOrderDetails(idbills);
		  }
	 }
}
