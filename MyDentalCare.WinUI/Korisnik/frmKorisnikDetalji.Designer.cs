namespace MyDentalCare.WinUI.Korisnik
{
	partial class frmKorisnikDetalji
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
			this.components = new System.ComponentModel.Container();
			this.txtIme = new System.Windows.Forms.TextBox();
			this.Ime = new System.Windows.Forms.Label();
			this.txtPrezime = new System.Windows.Forms.TextBox();
			this.Prezime = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.Email = new System.Windows.Forms.Label();
			this.txtBrojTelefona = new System.Windows.Forms.TextBox();
			this.BrojTelefona = new System.Windows.Forms.Label();
			this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
			this.KorisnickoIme = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.Label();
			this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
			this.PasswordConfirmation = new System.Windows.Forms.Label();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.clbUloge = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// txtIme
			// 
			this.txtIme.Location = new System.Drawing.Point(401, 123);
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(312, 20);
			this.txtIme.TabIndex = 0;
			this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
			// 
			// Ime
			// 
			this.Ime.AutoSize = true;
			this.Ime.Location = new System.Drawing.Point(398, 95);
			this.Ime.Name = "Ime";
			this.Ime.Size = new System.Drawing.Size(24, 13);
			this.Ime.TabIndex = 1;
			this.Ime.Text = "Ime";
			// 
			// txtPrezime
			// 
			this.txtPrezime.Location = new System.Drawing.Point(401, 179);
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(312, 20);
			this.txtPrezime.TabIndex = 2;
			this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
			// 
			// Prezime
			// 
			this.Prezime.AutoSize = true;
			this.Prezime.Location = new System.Drawing.Point(401, 163);
			this.Prezime.Name = "Prezime";
			this.Prezime.Size = new System.Drawing.Size(44, 13);
			this.Prezime.TabIndex = 3;
			this.Prezime.Text = "Prezime";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(401, 227);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(312, 20);
			this.txtEmail.TabIndex = 4;
			this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Location = new System.Drawing.Point(401, 211);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(32, 13);
			this.Email.TabIndex = 5;
			this.Email.Text = "Email";
			// 
			// txtBrojTelefona
			// 
			this.txtBrojTelefona.Location = new System.Drawing.Point(401, 279);
			this.txtBrojTelefona.Name = "txtBrojTelefona";
			this.txtBrojTelefona.Size = new System.Drawing.Size(312, 20);
			this.txtBrojTelefona.TabIndex = 6;
			// 
			// BrojTelefona
			// 
			this.BrojTelefona.AutoSize = true;
			this.BrojTelefona.Location = new System.Drawing.Point(401, 263);
			this.BrojTelefona.Name = "BrojTelefona";
			this.BrojTelefona.Size = new System.Drawing.Size(66, 13);
			this.BrojTelefona.TabIndex = 7;
			this.BrojTelefona.Text = "Broj telefona";
			// 
			// txtKorisnickoIme
			// 
			this.txtKorisnickoIme.Location = new System.Drawing.Point(401, 391);
			this.txtKorisnickoIme.Name = "txtKorisnickoIme";
			this.txtKorisnickoIme.Size = new System.Drawing.Size(312, 20);
			this.txtKorisnickoIme.TabIndex = 10;
			this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
			// 
			// KorisnickoIme
			// 
			this.KorisnickoIme.AutoSize = true;
			this.KorisnickoIme.Location = new System.Drawing.Point(401, 375);
			this.KorisnickoIme.Name = "KorisnickoIme";
			this.KorisnickoIme.Size = new System.Drawing.Size(75, 13);
			this.KorisnickoIme.TabIndex = 11;
			this.KorisnickoIme.Text = "Korisničko ime";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(401, 439);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(146, 20);
			this.txtPassword.TabIndex = 12;
			// 
			// Password
			// 
			this.Password.AutoSize = true;
			this.Password.Location = new System.Drawing.Point(401, 423);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(44, 13);
			this.Password.TabIndex = 13;
			this.Password.Text = "Lozinka";
			// 
			// txtPasswordConfirmation
			// 
			this.txtPasswordConfirmation.Location = new System.Drawing.Point(553, 439);
			this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
			this.txtPasswordConfirmation.Size = new System.Drawing.Size(160, 20);
			this.txtPasswordConfirmation.TabIndex = 14;
			// 
			// PasswordConfirmation
			// 
			this.PasswordConfirmation.AutoSize = true;
			this.PasswordConfirmation.Location = new System.Drawing.Point(553, 423);
			this.PasswordConfirmation.Name = "PasswordConfirmation";
			this.PasswordConfirmation.Size = new System.Drawing.Size(76, 13);
			this.PasswordConfirmation.TabIndex = 15;
			this.PasswordConfirmation.Text = "Potrvdi lozinku";
			// 
			// btnSnimi
			// 
			this.btnSnimi.Location = new System.Drawing.Point(626, 611);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(87, 23);
			this.btnSnimi.TabIndex = 16;
			this.btnSnimi.Text = "Sačuvaj";
			this.btnSnimi.UseVisualStyleBackColor = true;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// clbUloge
			// 
			this.clbUloge.FormattingEnabled = true;
			this.clbUloge.Location = new System.Drawing.Point(401, 493);
			this.clbUloge.Name = "clbUloge";
			this.clbUloge.Size = new System.Drawing.Size(312, 94);
			this.clbUloge.TabIndex = 17;
			this.clbUloge.SelectedIndexChanged += new System.EventHandler(this.clbUloge_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(401, 318);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Datum rođenja";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(404, 347);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(309, 20);
			this.dateTimePicker.TabIndex = 20;
			// 
			// frmKorisnikDetalji
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.clbUloge);
			this.Controls.Add(this.btnSnimi);
			this.Controls.Add(this.PasswordConfirmation);
			this.Controls.Add(this.txtPasswordConfirmation);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.KorisnickoIme);
			this.Controls.Add(this.txtKorisnickoIme);
			this.Controls.Add(this.BrojTelefona);
			this.Controls.Add(this.txtBrojTelefona);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.Prezime);
			this.Controls.Add(this.txtPrezime);
			this.Controls.Add(this.Ime);
			this.Controls.Add(this.txtIme);
			this.Name = "frmKorisnikDetalji";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmKorisnikDetalji";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmKorisnikDetalji_LoadAsync);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtIme;
		private System.Windows.Forms.Label Ime;
		private System.Windows.Forms.TextBox txtPrezime;
		private System.Windows.Forms.Label Prezime;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label Email;
		private System.Windows.Forms.TextBox txtBrojTelefona;
		private System.Windows.Forms.Label BrojTelefona;
		private System.Windows.Forms.TextBox txtKorisnickoIme;
		private System.Windows.Forms.Label KorisnickoIme;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label Password;
		private System.Windows.Forms.TextBox txtPasswordConfirmation;
		private System.Windows.Forms.Label PasswordConfirmation;
		private System.Windows.Forms.Button btnSnimi;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.CheckedListBox clbUloge;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label1;
	}
}