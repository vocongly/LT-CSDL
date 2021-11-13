﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911166_Lab07_Advanced_Command_Excusion
{
	 public partial class FoodInfoForm : Form
	 {
		  public FoodInfoForm()
		  {
				InitializeComponent();
		  }

		  private void FoodInfoForm_Load(object sender, EventArgs e)
		  {
				InitValues();
		  }

		  private void InitValues()
		  {
				string connectionString = "server=localhost;database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection conn = new SqlConnection(connectionString);

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "SELECT ID,Name FROM Category";

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();

				conn.Open();

				adapter.Fill(ds, "Category");

				cbbCatName.DataSource = ds.Tables["Category"];
				cbbCatName.DisplayMember = "Name";
				cbbCatName.ValueMember = "ID";

				conn.Close();
				conn.Dispose();
		  }

		  private void ResetText()
		  {
				txtFoodID.ResetText();
				txtName.ResetText();
				txtNotes.ResetText();
				txtUnit.ResetText();
				cbbCatName.ResetText();
				nudPrice.ResetText();
		  }

		  private void btnAddFood_Click(object sender, EventArgs e)
		  {
				try
				{
					 string connectionString = "server=localhost;database = RestaurantManagement; Integrated Security = true; ";
					 SqlConnection conn = new SqlConnection(connectionString);

					 SqlCommand cmd = conn.CreateCommand();
					 cmd.CommandText = "EXECUTE InsertFood @id OUTPUT, @name, @unit, @foodCategoryId, @price, @notes";

					 // thêm tham số vào đối tượng command
					 cmd.Parameters.Add("@id", SqlDbType.Int);
					 cmd.Parameters.Add("@name", SqlDbType.NVarChar,1000);
					 cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
					 cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
					 cmd.Parameters.Add("@price", SqlDbType.Int);
					 cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

					 cmd.Parameters["@id"].Direction = ParameterDirection.Output;

					 // truyền giá trị vào thủ tục qua tham số
					 cmd.Parameters["@name"].Value = txtName.Text;
					 cmd.Parameters["@unit"].Value = txtUnit.Text;
					 cmd.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
					 cmd.Parameters["@price"].Value = nudPrice.Value;
					 cmd.Parameters["@notes"].Value = txtNotes.Text;

					 conn.Open();

					 int numRowAffected = cmd.ExecuteNonQuery();

					 if (numRowAffected > 0)
					 {
						  string foodID = cmd.Parameters["@id"].Value.ToString();
						  MessageBox.Show("Thêm món mới thành công. Food ID = " + foodID, "Message");
						  this.ResetText();
					 }
					 else
					 {
						  MessageBox.Show("Thêm món thất bại");
					 }

					 // đóng kết nối
					 conn.Close();
					 conn.Dispose();
					 Close();
				}
				catch (SqlException exception)
				{
					 MessageBox.Show(exception.Message, "SQL Error");
				}

				catch(Exception exception)
				{
					 MessageBox.Show(exception.Message, "Error");
				}
		  }
		  public void DisplayFoodInfo(DataRowView rowView)
		  {
				try
				{
					 txtFoodID.Text = rowView["ID"].ToString();
					 txtName.Text = rowView["Name"].ToString();
					 txtUnit.Text = rowView["Unit"].ToString();
					 txtNotes.Text = rowView["Notes"].ToString();
					 nudPrice.Text = rowView["Price"].ToString();
					 
					 cbbCatName.SelectedIndex = -1;

					 // chọn nhóm ăn tương ứng
					 for(int index =0;index < cbbCatName.Items.Count; index++)
					 {
						  DataRowView cat = cbbCatName.Items[index] as DataRowView;
						  if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
						  {
								cbbCatName.SelectedIndex = index;
								break;
						  }
					 }
				}
				catch(Exception exception)
				{
					 MessageBox.Show(exception.Message, "Error");
					 this.Close();
				}
		  }
		  private void btnUpdate_Click(object sender, EventArgs e)
		  {
				try
				{
					 string connectionString = "server=localhost;database = RestaurantManagement; Integrated Security = true; ";
					 SqlConnection conn = new SqlConnection(connectionString);

					 SqlCommand cmd = conn.CreateCommand();
					 cmd.CommandText = "EXECUTE UpdateFood @id,@name,@unit,@foodCategoryID,@price,@notes";

					 // Thêm tham số vào đối tượng Command
					 cmd.Parameters.Add("@id", SqlDbType.Int);
					 cmd.Parameters.Add("@name", SqlDbType.NVarChar,1000);
					 cmd.Parameters.Add("@unit", SqlDbType.NVarChar,100);
					 cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
					 cmd.Parameters.Add("@price", SqlDbType.Int);
					 cmd.Parameters.Add("@notes", SqlDbType.NVarChar,3000);

					 // truyền giá trị vào thủ tục qua tham số
					 cmd.Parameters["@id"].Value = int.Parse(txtFoodID.Text);
					 cmd.Parameters["@name"].Value = txtName.Text;
					 cmd.Parameters["@unit"].Value = txtUnit.Text;
					 cmd.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
					 cmd.Parameters["@price"].Value = nudPrice.Value;
					 cmd.Parameters["@notes"].Value = txtNotes.Text;

					 conn.Open();

					 int numRowAffected = cmd.ExecuteNonQuery();

					 if(numRowAffected > 0)
					 {
						  MessageBox.Show("Cập nhật món ăn thành công !!","Message");
						  this.ResetText();
					 }
					 else
					 {
						  MessageBox.Show("Cập nhật món ăn lỗi");
					 }
					 conn.Close();
					 conn.Dispose();
					 Close();
				}
				catch (SqlException exception)
				{
					 MessageBox.Show(exception.Message, "SQL Error");
				}
				catch(Exception exception)
				{
					 MessageBox.Show(exception.Message, "Error");
				}
		  }

		  private void btnCancel_Click(object sender, EventArgs e)
		  {
				this.Close();
		  }

		  private void btnAddNew_Click(object sender, EventArgs e)
		  {
				AddCategory frm = new AddCategory();
				if(frm.ShowDialog() == DialogResult.OK)
				{
					 this.InitValues();
				}
		  }
	 }
}
