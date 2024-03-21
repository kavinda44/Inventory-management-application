using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bravosixcafe
{
	public partial class CategoryForm : Form
	{
		public CategoryForm()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\niro\Documents\bravosixdb.mdf;Integrated Security=True;Connect Timeout=30");
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				Con.Open();
				string query = "insert into CategoryTbl values(" + CatIdTb.Text + ",'" + CatNameTb.Text + "' ,'" + CatDescTb.Text + "')";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Category Added Successfully");
				Con.Close();
				populate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}
		private void populate()
		{
			Con.Open();
			string query = "select * from CategoryTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			CatDGV.DataSource = ds.Tables[0];
			Con.Close();

		}
		private void CategoryForm_Load(object sender, EventArgs e)
		{
			populate();
		}

		private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
			CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
			CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}



		private void button7_Click(object sender, EventArgs e)
		{

		}

		private void button7_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (CatIdTb.Text == "")
				{
					MessageBox.Show("select the category to delete");

				}
				else
				{
					Con.Open();
					String query = "delete from CategoryTbl where CatId=" + CatIdTb.Text + "";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Cateogry deleted");
					Con.Close();
					populate();

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button6_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (CatIdTb.Text == "")
				{
					MessageBox.Show("select the category to update");

				}
				else
				{
					Con.Open();
					String query = "update CategoryTbl set CatName= '" + CatNameTb.Text + "',CatDesc='" + CatDescTb.Text + "' where CatId= " + CatIdTb.Text + ";";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Cateogry updated successfully");
					Con.Close();
					populate();

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			ProductForm prod = new ProductForm();
			prod.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			SellerForm seller = new SellerForm();
			seller.Show();
		}

		private void label7_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 login = new Form1();
			login.Show();
		}
	}
}