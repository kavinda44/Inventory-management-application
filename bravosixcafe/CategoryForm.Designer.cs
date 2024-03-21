using System;

namespace bravosixcafe
{
	partial class CategoryForm
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
			this.CatDGV = new System.Windows.Forms.DataGridView();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.CatDescTb = new System.Windows.Forms.TextBox();
			this.CatNameTb = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.CatIdTb = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkViolet;
			this.panel1.BackgroundImage = global::bravosixcafe.Properties.Resources.pexels_lucie_liz_31653351;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.CatDGV);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.CatDescTb);
			this.panel1.Controls.Add(this.CatNameTb);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.CatIdTb);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(172, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(992, 615);
			this.panel1.TabIndex = 2;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
			// CatDGV
			// 
			this.CatDGV.BackgroundColor = System.Drawing.Color.Black;
			this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CatDGV.Location = new System.Drawing.Point(411, 130);
			this.CatDGV.Name = "CatDGV";
			this.CatDGV.RowHeadersWidth = 51;
			this.CatDGV.RowTemplate.Height = 24;
			this.CatDGV.Size = new System.Drawing.Size(573, 474);
			this.CatDGV.TabIndex = 19;
			this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Transparent;
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.button7.ForeColor = System.Drawing.SystemColors.Info;
			this.button7.Location = new System.Drawing.Point(263, 401);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(99, 34);
			this.button7.TabIndex = 18;
			this.button7.Text = "DELETE";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click_1);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Transparent;
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.button6.ForeColor = System.Drawing.SystemColors.Info;
			this.button6.Location = new System.Drawing.Point(137, 401);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(99, 34);
			this.button6.TabIndex = 18;
			this.button6.Text = "EDIT";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click_1);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Transparent;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.button5.ForeColor = System.Drawing.SystemColors.Info;
			this.button5.Location = new System.Drawing.Point(20, 401);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(99, 34);
			this.button5.TabIndex = 18;
			this.button5.Text = "ADD";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// CatDescTb
			// 
			this.CatDescTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CatDescTb.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CatDescTb.ForeColor = System.Drawing.Color.Black;
			this.CatDescTb.Location = new System.Drawing.Point(229, 279);
			this.CatDescTb.Name = "CatDescTb";
			this.CatDescTb.Size = new System.Drawing.Size(175, 28);
			this.CatDescTb.TabIndex = 12;
			this.CatDescTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// CatNameTb
			// 
			this.CatNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CatNameTb.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CatNameTb.ForeColor = System.Drawing.Color.Black;
			this.CatNameTb.Location = new System.Drawing.Point(229, 208);
			this.CatNameTb.Name = "CatNameTb";
			this.CatNameTb.Size = new System.Drawing.Size(175, 28);
			this.CatNameTb.TabIndex = 12;
			this.CatNameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("ROG Fonts", 13.8F);
			this.label4.ForeColor = System.Drawing.SystemColors.Info;
			this.label4.Location = new System.Drawing.Point(15, 279);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(208, 28);
			this.label4.TabIndex = 11;
			this.label4.Text = "DESCRIPTION";
			// 
			// CatIdTb
			// 
			this.CatIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CatIdTb.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CatIdTb.ForeColor = System.Drawing.Color.Black;
			this.CatIdTb.Location = new System.Drawing.Point(229, 143);
			this.CatIdTb.Name = "CatIdTb";
			this.CatIdTb.Size = new System.Drawing.Size(175, 28);
			this.CatIdTb.TabIndex = 12;
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Info;
			this.label3.Location = new System.Drawing.Point(315, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(399, 34);
			this.label3.TabIndex = 11;
			this.label3.Text = "MANAGE CATEGORIES";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Black;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("ROG Fonts", 13.8F);
			this.button3.ForeColor = System.Drawing.Color.DarkViolet;
			this.button3.Location = new System.Drawing.Point(1116, -9);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 35);
			this.button3.TabIndex = 3;
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
			this.button2.Location = new System.Drawing.Point(22, 172);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(141, 41);
			this.button2.TabIndex = 4;
			this.button2.Text = "Item";
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
			this.button1.Location = new System.Drawing.Point(42, 101);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 49);
			this.button1.TabIndex = 6;
			this.button1.Text = "Sellers";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(38, 600);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 27;
			this.label7.Text = "Logout";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// CategoryForm
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
			this.Name = "CategoryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CategoryForm";
			this.Load += new System.EventHandler(this.CategoryForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.DataGridView CatDGV;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox CatNameTb;
		private System.Windows.Forms.TextBox CatIdTb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox CatDescTb;
		private System.Windows.Forms.Label label4;
		private EventHandler button6_Click;
		private System.Windows.Forms.Label label7;
	}
}