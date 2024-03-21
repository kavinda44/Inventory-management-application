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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace bravosixcafe
{
	public partial class SellingForm : Form
	{
		public SellingForm()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\niro\Documents\bravosixdb.mdf;Integrated Security = True; Connect Timeout = 30");
		private void populate()
		{
			Con.Open();
			string query = "select ItemName,ItemQty from ItemTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			ProdDGV1.DataSource = ds.Tables[0];
			Con.Close();

		}

		private void populatebills()
		{
			Con.Open();
			string query = "select * from BillTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			BillsDGV.DataSource = ds.Tables[0];
			Con.Close();

		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void SellingForm_Load(object sender, EventArgs e)
		{
			populate();
			populatebills();
			fillcombo();
			SellerNamelbl.Text = Form1.Sellername;
		}
		

		private void ProdDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ProdName.Text = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
			ProdQty.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
			
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
		}

		int Grdtotal = 0, n=0;

		private void button5_Click(object sender, EventArgs e)
		{
			if (BillID.Text == "")
			{
				MessageBox.Show("Missing Bill Id");
			}
			else { 
			try
			{
				Con.Open();
				string query = "insert into BillTbl values(" + BillID.Text + ",'" + SellerNamelbl.Text + "' ,'" + Datelbl.Text + "'," + Amtlbl.Text + ")";
				SqlCommand cmd = new SqlCommand(query, Con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Order Added Successfully");
				Con.Close();
				populatebills();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}

		private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString("BRAVO SIX CAFE", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
			e.Graphics.DrawString("Bill ID:"+BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100,70));
			e.Graphics.DrawString("Seller Name:" + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
			e.Graphics.DrawString("Date:" + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
		    e.Graphics.DrawString("Total Amount:" + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
			
		}

		private void printPreviewDialog1_Load(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{
			populate();
		}

		private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
		{
			Con.Open();
			string query = "select ItemName,ItemQty from ItemTbl where ItemCat='" + comboBox2.SelectedValue.ToString();
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			ProdDGV1.DataSource = ds.Tables[0];
			Con.Close();
		}
		private void fillcombo()
		{
			Con.Open();
			SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
			SqlDataReader rdr;
			rdr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Columns.Add("CatName", typeof(string));
			dt.Load(rdr);
			//CatCb.ValueMember = "CatName";
			//CatCb.DataSource = dt;
			comboBox2.ValueMember = "CatName";
			comboBox2.DataSource = dt;
			Con.Close();
		}

		private void label6_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 login = new Form1();
			login.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			if (ProdName.Text == "" || ProdQty.Text == "")
			{
				MessageBox.Show("Missing Data");
			}
			else
			{
				int  total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
				
				DataGridViewRow newRow = new DataGridViewRow();
				newRow.CreateCells(ORDERDGV);
				newRow.Cells[0].Value = n + 1;
				newRow.Cells[1].Value = ProdName.Text;
				newRow.Cells[2].Value = ProdPrice.Text;
				newRow.Cells[3].Value = ProdQty.Text;
				newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
				ORDERDGV.Rows.Add(newRow);
				n++;
				Grdtotal = Grdtotal + total;
				Amtlbl.Text = "" + Grdtotal;
			}
		}
	}
}
