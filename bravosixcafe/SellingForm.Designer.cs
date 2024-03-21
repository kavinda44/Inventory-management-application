namespace bravosixcafe
{
	partial class SellingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.ORDERDGV = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amtlbl = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SellerNamelbl = new System.Windows.Forms.Label();
			this.ProdDGV1 = new System.Windows.Forms.DataGridView();
			this.Datelbl = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.BillsDGV = new System.Windows.Forms.DataGridView();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.ProdQty = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ProdPrice = new System.Windows.Forms.TextBox();
			this.ProdName = new System.Windows.Forms.TextBox();
			this.BillID = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkViolet;
			this.panel1.BackgroundImage = global::bravosixcafe.Properties.Resources.pexels_lucie_liz_31653351;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.ORDERDGV);
			this.panel1.Controls.Add(this.Amtlbl);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.SellerNamelbl);
			this.panel1.Controls.Add(this.ProdDGV1);
			this.panel1.Controls.Add(this.Datelbl);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.BillsDGV);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.ProdQty);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.ProdPrice);
			this.panel1.Controls.Add(this.ProdName);
			this.panel1.Controls.Add(this.BillID);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(184, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(992, 646);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.Info;
			this.label7.Location = new System.Drawing.Point(622, 319);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(157, 24);
			this.label7.TabIndex = 28;
			this.label7.Text = "SELLS LIST";
			// 
			// ORDERDGV
			// 
			this.ORDERDGV.BackgroundColor = System.Drawing.Color.White;
			this.ORDERDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ORDERDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
			this.ORDERDGV.Location = new System.Drawing.Point(371, 82);
			this.ORDERDGV.Name = "ORDERDGV";
			this.ORDERDGV.RowHeadersWidth = 51;
			this.ORDERDGV.RowTemplate.Height = 24;
			this.ORDERDGV.Size = new System.Drawing.Size(609, 176);
			this.ORDERDGV.TabIndex = 27;
			// 
			// id
			// 
			this.id.HeaderText = "prodId";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.Width = 125;
			// 
			// PName
			// 
			this.PName.HeaderText = "ProdName";
			this.PName.MinimumWidth = 6;
			this.PName.Name = "PName";
			this.PName.Width = 125;
			// 
			// Price
			// 
			this.Price.HeaderText = "Price";
			this.Price.MinimumWidth = 6;
			this.Price.Name = "Price";
			this.Price.Width = 125;
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.MinimumWidth = 6;
			this.Quantity.Name = "Quantity";
			this.Quantity.Width = 125;
			// 
			// Total
			// 
			this.Total.HeaderText = "Total";
			this.Total.MinimumWidth = 6;
			this.Total.Name = "Total";
			this.Total.Width = 125;
			// 
			// Amtlbl
			// 
			this.Amtlbl.AutoSize = true;
			this.Amtlbl.BackColor = System.Drawing.Color.Transparent;
			this.Amtlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Amtlbl.ForeColor = System.Drawing.SystemColors.Info;
			this.Amtlbl.Location = new System.Drawing.Point(719, 275);
			this.Amtlbl.Name = "Amtlbl";
			this.Amtlbl.Size = new System.Drawing.Size(31, 23);
			this.Amtlbl.TabIndex = 26;
			this.Amtlbl.Text = "Rs";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Info;
			this.label5.Location = new System.Drawing.Point(590, 275);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 23);
			this.label5.TabIndex = 26;
			this.label5.Text = "AMOUNT Rs";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.button1.ForeColor = System.Drawing.SystemColors.Info;
			this.button1.Location = new System.Drawing.Point(39, 206);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(259, 34);
			this.button1.TabIndex = 25;
			this.button1.Text = "ADD ITEM";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SellerNamelbl
			// 
			this.SellerNamelbl.AutoSize = true;
			this.SellerNamelbl.BackColor = System.Drawing.Color.Transparent;
			this.SellerNamelbl.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SellerNamelbl.ForeColor = System.Drawing.Color.White;
			this.SellerNamelbl.Location = new System.Drawing.Point(4, 21);
			this.SellerNamelbl.Name = "SellerNamelbl";
			this.SellerNamelbl.Size = new System.Drawing.Size(70, 23);
			this.SellerNamelbl.TabIndex = 24;
			this.SellerNamelbl.Text = "Seller";
			// 
			// ProdDGV1
			// 
			this.ProdDGV1.BackgroundColor = System.Drawing.Color.White;
			this.ProdDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProdDGV1.Location = new System.Drawing.Point(0, 304);
			this.ProdDGV1.Name = "ProdDGV1";
			this.ProdDGV1.RowHeadersWidth = 51;
			this.ProdDGV1.RowTemplate.Height = 24;
			this.ProdDGV1.Size = new System.Drawing.Size(298, 339);
			this.ProdDGV1.TabIndex = 23;
			this.ProdDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV1_CellContentClick);
			// 
			// Datelbl
			// 
			this.Datelbl.AutoSize = true;
			this.Datelbl.BackColor = System.Drawing.Color.Transparent;
			this.Datelbl.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Datelbl.ForeColor = System.Drawing.Color.White;
			this.Datelbl.Location = new System.Drawing.Point(837, 21);
			this.Datelbl.Name = "Datelbl";
			this.Datelbl.Size = new System.Drawing.Size(59, 23);
			this.Datelbl.TabIndex = 22;
			this.Datelbl.Text = "Date";
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Transparent;
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.button8.ForeColor = System.Drawing.SystemColors.Info;
			this.button8.Location = new System.Drawing.Point(203, 264);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(99, 34);
			this.button8.TabIndex = 21;
			this.button8.Text = "Refesh";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.BackColor = System.Drawing.Color.Black;
			this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox2.ForeColor = System.Drawing.Color.DarkViolet;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "ADMIN",
            "EMPLOYEE"});
			this.comboBox2.Location = new System.Drawing.Point(8, 269);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(172, 29);
			this.comboBox2.TabIndex = 20;
			this.comboBox2.Text = "Select Category";
			this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
			// 
			// BillsDGV
			// 
			this.BillsDGV.BackgroundColor = System.Drawing.Color.White;
			this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BillsDGV.Location = new System.Drawing.Point(407, 346);
			this.BillsDGV.Name = "BillsDGV";
			this.BillsDGV.RowHeadersWidth = 51;
			this.BillsDGV.RowTemplate.Height = 24;
			this.BillsDGV.Size = new System.Drawing.Size(573, 230);
			this.BillsDGV.TabIndex = 19;
			this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellContentClick);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Transparent;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.button6.ForeColor = System.Drawing.SystemColors.Info;
			this.button6.Location = new System.Drawing.Point(733, 582);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(99, 34);
			this.button6.TabIndex = 18;
			this.button6.Text = "PRINT";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Transparent;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.button5.ForeColor = System.Drawing.SystemColors.Info;
			this.button5.Location = new System.Drawing.Point(559, 582);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(99, 34);
			this.button5.TabIndex = 18;
			this.button5.Text = "ADD";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// ProdQty
			// 
			this.ProdQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ProdQty.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdQty.ForeColor = System.Drawing.Color.Black;
			this.ProdQty.Location = new System.Drawing.Point(176, 161);
			this.ProdQty.Name = "ProdQty";
			this.ProdQty.Size = new System.Drawing.Size(175, 28);
			this.ProdQty.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Info;
			this.label4.Location = new System.Drawing.Point(4, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "QUANTITY";
			// 
			// ProdPrice
			// 
			this.ProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ProdPrice.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdPrice.ForeColor = System.Drawing.Color.Black;
			this.ProdPrice.Location = new System.Drawing.Point(176, 129);
			this.ProdPrice.Name = "ProdPrice";
			this.ProdPrice.Size = new System.Drawing.Size(175, 28);
			this.ProdPrice.TabIndex = 12;
			// 
			// ProdName
			// 
			this.ProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ProdName.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdName.ForeColor = System.Drawing.Color.Black;
			this.ProdName.Location = new System.Drawing.Point(176, 95);
			this.ProdName.Name = "ProdName";
			this.ProdName.Size = new System.Drawing.Size(175, 28);
			this.ProdName.TabIndex = 12;
			// 
			// BillID
			// 
			this.BillID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BillID.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BillID.ForeColor = System.Drawing.Color.Black;
			this.BillID.Location = new System.Drawing.Point(176, 61);
			this.BillID.Name = "BillID";
			this.BillID.Size = new System.Drawing.Size(175, 28);
			this.BillID.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Info;
			this.label8.Location = new System.Drawing.Point(0, 131);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 20);
			this.label8.TabIndex = 11;
			this.label8.Text = "PRICE";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Info;
			this.label2.Location = new System.Drawing.Point(0, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "ITEM NAME";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Info;
			this.label1.Location = new System.Drawing.Point(0, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Bill ID";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Info;
			this.label3.Location = new System.Drawing.Point(462, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(164, 34);
			this.label3.TabIndex = 11;
			this.label3.Text = "SELLING";
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(29, 511);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 25;
			this.label6.Text = "Logout";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// SellingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1176, 659);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SellingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SellingForm";
			this.Load += new System.EventHandler(this.SellingForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView ProdDGV1;
		private System.Windows.Forms.Label Datelbl;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.DataGridView BillsDGV;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox ProdQty;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ProdPrice;
		private System.Windows.Forms.TextBox ProdName;
		private System.Windows.Forms.TextBox BillID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label SellerNamelbl;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView ORDERDGV;
		private System.Windows.Forms.Label Amtlbl;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn PName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Label label6;
	}
}