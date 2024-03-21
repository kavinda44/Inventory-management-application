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
	public partial class ProductForm : Form
	{
		public ProductForm()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\niro\Documents\bravosixdb.mdf;Integrated Security = True; Connect Timeout = 30");

		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				if (ProdId.Text == ""|| ProdName.Text== ""||ProdQty.Text==""||ProdPrice.Text=="")
				{
					MessageBox.Show("missing informations");

				}
				else
				{
					Con.Open();
					String query = "update ItemTbl set ItemName= '" + ProdName.Text + "',ItemQty='" + ProdQty.Text + "',ItemPrice= '" + ProdPrice.Text + " ',ItemCat='" +CatCb.SelectedValue.ToString()+"'where ItemId = " + ProdId.Text + ";"; 
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Item updated successfully");
					Con.Close();
					populate1();

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
private void fillcombo()
		{
			Con.Open();
			SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
			SqlDataReader rdr;
			rdr=cmd.ExecuteReader();
			DataTable dt=new DataTable();
			dt.Columns.Add("CatName", typeof(string));
			dt.Load(rdr);
			CatCb.ValueMember = "CatName";
			CatCb.DataSource= dt;
			comboBox2.ValueMember = "CatName";
			comboBox2.DataSource = dt;
			Con.Close();	
		}

		private void populate1()
		{
			Con.Open();
			string query = "select * from ItemTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			ProdDGV.DataSource = ds.Tables[0];
			Con.Close();

		}
		private void ProductForm_Load(object sender, EventArgs e)
		{
			fillcombo();
			populate1();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CategoryForm cat=new CategoryForm();
			cat.Show();
			this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				Con.Open();
				string query = "insert into ItemTbl values(" + ProdId.Text + ",'" + ProdName.Text + "' ," + ProdQty.Text + ","+ProdPrice.Text+",'"+CatCb.SelectedValue.ToString()+"')";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Item Added Successfully");
				Con.Close();
				//populate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ProdId.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
			ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
			ProdQty.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
			ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
			CatCb.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			try
			{
				if(ProdId.Text== "")
				{
					MessageBox.Show("select the product to delete");
					
				}
				else
				{
					Con.Open();
					String query = "delete from ItemTbl where ItemId=" + ProdId.Text + "";
						SqlCommand cmd=new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("prodcuted deleted");
					Con.Close();
					populate1();

				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
		{
			Con.Open();
			string query = "select * from ItemTbl where ItemCat='" + comboBox2.SelectedValue.ToString();
			SqlDataAdapter sda=new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			ProdDGV.DataSource = ds.Tables[0];
			Con.Close();
		}

		private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 login = new Form1();
			login.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			SellerForm seller = new SellerForm();
			seller.Show();
		}
	}
}
