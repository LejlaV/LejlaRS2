namespace MyDentalCare.WinUI.Login
{
	partial class frmLogin
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
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.labelOdustani = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// txtUsername
			// 
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsername.Location = new System.Drawing.Point(80, 287);
			this.txtUsername.Multiline = true;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(143, 25);
			this.txtUsername.TabIndex = 1;
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Location = new System.Drawing.Point(80, 343);
			this.txtPassword.Multiline = true;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(140, 32);
			this.txtPassword.TabIndex = 3;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnLogin.Location = new System.Drawing.Point(49, 395);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(174, 23);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Prijava";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MyDentalCare.WinUI.Properties.Resources.a36ef67f_8482_4575_9cbf_e8cf623d7beb_200x200;
			this.pictureBox1.Location = new System.Drawing.Point(49, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(174, 182);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label3.Location = new System.Drawing.Point(77, 207);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 27);
			this.label3.TabIndex = 7;
			this.label3.Text = "PRIJAVA";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.panel1.Location = new System.Drawing.Point(49, 313);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(174, 2);
			this.panel1.TabIndex = 8;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.panel2.Location = new System.Drawing.Point(49, 373);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(174, 2);
			this.panel2.TabIndex = 9;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::MyDentalCare.WinUI.Properties.Resources.download;
			this.pictureBox2.Location = new System.Drawing.Point(49, 287);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(25, 25);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::MyDentalCare.WinUI.Properties.Resources.download__1_aaaa;
			this.pictureBox3.Location = new System.Drawing.Point(49, 343);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(25, 25);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 11;
			this.pictureBox3.TabStop = false;
			// 
			// labelOdustani
			// 
			this.labelOdustani.AutoSize = true;
			this.labelOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelOdustani.ForeColor = System.Drawing.SystemColors.Highlight;
			this.labelOdustani.Location = new System.Drawing.Point(100, 431);
			this.labelOdustani.Name = "labelOdustani";
			this.labelOdustani.Size = new System.Drawing.Size(69, 16);
			this.labelOdustani.TabIndex = 12;
			this.labelOdustani.Text = "Odustani";
			this.labelOdustani.Click += new System.EventHandler(this.labelOdustani_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(293, 465);
			this.Controls.Add(this.labelOdustani);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmLogin";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label labelOdustani;
	}
}