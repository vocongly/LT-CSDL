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
	 public partial class AccountForm : Form
	 {
		  List<Account> listAccount = new List<Account>();
		  public AccountForm()
		  {
				InitializeComponent();
		  }
		  public void LoadAccount()
		  {
				AccountBL accountBL = new AccountBL();
				listAccount = accountBL.GetAll();
				dgvAccount.DataSource = listAccount;
		  }
	 }
}
