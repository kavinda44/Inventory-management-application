namespace bravosixcafe
{
	partial class SellerForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.button8 = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.SellerDGV = new System.Windows.Forms.DataGridView();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.Spass = new System.Windows.Forms.TextBox();
			this.Sphone = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Sage = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Sname = new System.Windows.Forms.TextBox();
			this.Sid = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkViolet;
			this.panel1.BackgroundImage = global::bravosixcafe.Properties.Resources.pexels_lucie_liz_31653351;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.SellerDGV);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.Spass);
			this.panel1.Controls.Add(this.Sphone);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.Sage);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.Sname);
			this.panel1.Controls.Add(this.Sid);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(184, 43);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(992, 615);
			this.panel1.TabIndex = 1;
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Transparent;
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.button8.ForeColor = System.Drawing.SystemColors.Info;
			this.button8.Location = new System.Drawing.Point(772, 90);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(99, 34);
			this.button8.TabIndex = 21;
			this.button8.Text = "Refesh";
			this.button8.UseVisualStyleBackColor = false;
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
			this.comboBox2.Location = new System.Drawing.Point(594, 91);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(172, 29);
			this.comboBox2.TabIndex = 20;
			this.comboBox2.Text = "Select Category";
			// 
			// SellerDGV
			// 
			this.SellerDGV.BackgroundColor = System.Drawing.Color.White;
			this.SellerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SellerDGV.Location = new System.Drawing.Point(411, 130);
			this.SellerDGV.Name = "SellerDGV";
			this.SellerDGV.RowHeadersWidth = 51;
			this.SellerDGV.RowTemplate.Height = 24;
			this.SellerDGV.Size = new System.Drawing.Size(573, 474);
			this.SellerDGV.TabIndex = 19;
			this.SellerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Transparent;
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.button7.ForeColor = System.Drawing.SystemColors.Info;
			this.button7.Location = new System.Drawing.Point(248, 469);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(99, 34);
			this.button7.TabIndex = 18;
			this.button7.Text = "DELETE";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Transparent;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.button6.ForeColor = System.Drawing.SystemColors.Info;
			this.button6.Location = new System.Drawing.Point(134, 469);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(99, 34);
			this.button6.TabIndex = 18;
			this.button6.Text = "EDIT";
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
			this.button5.Location = new System.Drawing.Point(20, 469);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(99, 34);
			this.button5.TabIndex = 18;
			this.button5.Text = "ADD";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Spass
			// 
			this.Spass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Spass.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Spass.ForeColor = System.Drawing.Color.Black;
			this.Spass.Location = new System.Drawing.Point(210, 389);
			this.Spass.Name = "Spass";
			this.Spass.Size = new System.Drawing.Size(175, 28);
			this.Spass.TabIndex = 16;
			// 
			// Sphone
			// 
			this.Sphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Sphone.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Sphone.ForeColor = System.Drawing.Color.Black;
			this.Sphone.Location = new System.Drawing.Point(210, 325);
			this.Sphone.Name = "Sphone";
			this.Sphone.Size = new System.Drawing.Size(175, 28);
			this.Sphone.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("ROG Fonts", 13.8F);
			this.label5.ForeColor = System.Drawing.SystemColors.Info;
			this.label5.Location = new System.Drawing.Point(15, 325);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 28);
			this.label5.TabIndex = 15;
			this.label5.Text = "TELE";
			// 
			// Sage
			// 
			this.Sage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Sage.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Sage.ForeColor = System.Drawing.Color.Black;
			this.Sage.Location = new System.Drawing.Point(210, 271);
			this.Sage.Name = "Sage";
			this.Sage.Size = new System.Drawing.Size(175, 28);
			this.Sage.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("ROG Fonts", 13.8F);
			this.label4.ForeColor = System.Drawing.SystemColors.Info;
			this.label4.Location = new System.Drawing.Point(15, 271);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 28);
			this.label4.TabIndex = 13;
			this.label4.Text = "AGE";
			// 
			// Sname
			// 
			this.Sname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Sname.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Sname.ForeColor = System.Drawing.Color.Black;
			this.Sname.Location = new System.Drawing.Point(210, 199);
			this.Sname.Name = "Sname";
			this.Sname.Size = new System.Drawing.Size(175, 28);
			this.Sname.TabIndex = 12;
			// 
			// Sid
			// 
			this.Sid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Sid.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Sid.ForeColor = System.Drawing.Color.Black;
			this.Sid.Location = new System.Drawing.Point(210, 138);
			this.Sid.Name = "Sid";
			this.Sid.Size = new System.Drawing.Size(175, 28);
			this.Sid.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("ROG Fonts", 13.8F);
			this.label2.ForeColor = System.Drawing.SystemColors.Info;
			this.label2.Location = new System.Drawing.Point(15, 208);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 28);
			this.label2.TabIndex = 11;
			this.label2.Text = "NAME";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("ROG Fonts", 13.8F);
			this.label1.ForeColor = System.Drawing.SystemColors.Info;
			this.label1.Location = new System.Drawing.Point(15, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 28);
			this.label1.TabIndex = 11;
			this.label1.Text = "ID";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("ROG Fonts", 13.8F);
			this.label6.ForeColor = System.Drawing.SystemColors.Info;
			this.label6.Location = new System.Drawing.Point(15, 389);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(174, 28);
			this.label6.TabIndex = 11;
			this.label6.Text = "PASSWORD";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Info;
			this.label3.Location = new System.Drawing.Point(315, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(335, 34);
			this.label3.TabIndex = 11;
			this.label3.Text = "MANAGE SELLERS";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Black;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("ROG Fonts", 13.8F);
			this.button3.ForeColor = System.Drawing.Color.DarkViolet;
			this.button3.Location = new System.Drawing.Point(1126, 0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(50, 37);
			this.button3.TabIndex = 22;
			this.button3.Text = "X";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Black;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.button2.ForeColor = System.Drawing.Color.DarkViolet;
			this.button2.Location = new System.Drawing.Point(12, 147);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(141, 41);
			this.button2.TabIndex = 23;
			this.button2.Text = "Category";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.button1.ForeColor = System.Drawing.Color.DarkViolet;
			this.button1.Location = new System.Drawing.Point(32, 76);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 49);
			this.button1.TabIndex = 25;
			this.button1.Text = "Items";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(28, 580);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 28;
			this.label7.Text = "Logout";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// SellerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1176, 659);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SellerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SellerForm";
			this.Load += new System.EventHandler(this.SellerForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.DataGridView SellerDGV;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox Sphone;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Sage;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Sname;
		private System.Windows.Forms.TextBox Sid;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox Spass;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}