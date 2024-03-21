using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bravosixcafe
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public static string Sellername = "";
		SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\niro\Documents\bravosixdb.mdf;Integrated Security = True; Connect Timeout = 30");
		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void label8_Click(object sender, EventArgs e)
		{
			Application.Exit();
			UnameTb.Text = "";
			PassTb.Text = "";
		}

		private void label7_Click(object sender, EventArgs e)
		{
			if (UnameTb.Text == "" || PassTb.Text == "")
			{
				MessageBox.Show("Enter The User name and Password");
			}
			else
			{
				if (RoleCb.SelectedIndex > -1)
				{


					if (RoleCb.SelectedItem.ToString() == "ADMIN")
					{
						if (UnameTb.Text == "Admin" && PassTb.Text == "Admin")
						{
							ProductForm prod = new ProductForm();
							prod.Show();
							this.Hide();
						}
						else
						{
							MessageBox.Show("If you are the admin,Enter the correct id and the password");
						}
					}
					else
					{

						//MessageBox.Show("You in the employee section");
						Con.Open();
						SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select count(8) from SellerTbl where SellerName='" + UnameTb.Text + "'and SellerPass='" + PassTb.Text + "'", Con);
						DataTable dt = new DataTable();
						sqlDataAdapter.Fill(dt);
						if (dt.Rows[0][0].ToString() == "1")
						{
							Sellername=UnameTb.Text;
							SellingForm sell = new SellingForm();
							sell.Show();
							this.Hide();
							Con.Close();

							

						}
						else
						{
							MessageBox.Show("wrong username or password");
						}
						Con.Close();

					}
				}
				else
				{
					MessageBox.Show("Select A role");
				}
			}
		}
	}
}
