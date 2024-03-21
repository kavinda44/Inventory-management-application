using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bravosixcafe
{
	public partial class SellerForm : Form
	{
		public SellerForm()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\niro\Documents\bravosixdb.mdf;Integrated Security = True; Connect Timeout = 30");

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			Sid.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
			Sname.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
			Sage.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
			Sphone.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
			Spass.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			try
			{
				if (Sid.Text == "")
				{
					MessageBox.Show("select the seller to delete");

				}
				else
				{
					Con.Open();
					String query = "delete from SellerTbl where SellerId=" + Sid.Text + "";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("seller deleted");
					Con.Close();


				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void populate2()
		{
			Con.Open();
			string query = "select * from SellerTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			SellerDGV.DataSource = ds.Tables[0];
			Con.Close();

		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				Con.Open();
				string query = "insert into SellerTbl values(" + Sid.Text + ",'" + Sname.Text + "' ," + Sage.Text + "," + Sphone.Text + ",'" + Spass.Text  + "')";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Seller Added Successfully");
				Con.Close();
				populate2();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void SellerForm_Load(object sender, EventArgs e)
		{
			populate2();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				if (Sid.Text == "" || Sname.Text == "" || Sage.Text == "" || Sphone.Text == ""|| Spass.Text=="")
				{
					MessageBox.Show("missing informations");

				}
				else
				{
					Con.Open();
					String query = "update SellerTbl set SellerName= '" + Sname.Text + "',SellerAge='" + Sage.Text + "',SellerPhone= '" + Sphone.Text + " ',SellerPass='" + Spass.Text + "'where SellerId = " + Sid.Text + ";";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Seller details updated successfully");
					Con.Close();
					populate2();

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ProductForm product= new ProductForm();
			product.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CategoryForm cat= new CategoryForm();
			cat.Show();
			this.Hide();
		}

		private void label7_Click(object sender, EventArgs e)
		{
			Form1 log=new Form1();
			log.Show();
			this.Hide();
		}
	}
	}

