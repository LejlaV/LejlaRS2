namespace MyDentalCare.WinUI.Pacijent
{
	partial class frmPacijentDetalji
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
			this.KorisnickoIme = new System.Windows.Forms.Label();
			this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
			this.BrojTelefona = new System.Windows.Forms.Label();
			this.txtBrojTelefona = new System.Windows.Forms.TextBox();
			this.Email = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.Prezime = new System.Windows.Forms.Label();
			this.txtPrezime = new System.Windows.Forms.TextBox();
			this.Ime = new System.Windows.Forms.Label();
			this.txtIme = new System.Windows.Forms.TextBox();
			this.PasswordConfirmation = new System.Windows.Forms.Label();
			this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// KorisnickoIme
			// 
			this.KorisnickoIme.AutoSize = true;
			this.KorisnickoIme.Location = new System.Drawing.Point(382, 382);
			this.KorisnickoIme.Name = "KorisnickoIme";
			this.KorisnickoIme.Size = new System.Drawing.Size(75, 13);
			this.KorisnickoIme.TabIndex = 21;
			this.KorisnickoIme.Text = "Korisničko ime";
			// 
			// txtKorisnickoIme
			// 
			this.txtKorisnickoIme.Location = new System.Drawing.Point(382, 398);
			this.txtKorisnickoIme.Name = "txtKorisnickoIme";
			this.txtKorisnickoIme.Size = new System.Drawing.Size(312, 20);
			this.txtKorisnickoIme.TabIndex = 20;
			this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
			// 
			// BrojTelefona
			// 
			this.BrojTelefona.AutoSize = true;
			this.BrojTelefona.Location = new System.Drawing.Point(382, 280);
			this.BrojTelefona.Name = "BrojTelefona";
			this.BrojTelefona.Size = new System.Drawing.Size(66, 13);
			this.BrojTelefona.TabIndex = 19;
			this.BrojTelefona.Text = "Broj telefona";
			// 
			// txtBrojTelefona
			// 
			this.txtBrojTelefona.Location = new System.Drawing.Point(382, 296);
			this.txtBrojTelefona.Name = "txtBrojTelefona";
			this.txtBrojTelefona.Size = new System.Drawing.Size(312, 20);
			this.txtBrojTelefona.TabIndex = 18;
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Location = new System.Drawing.Point(382, 228);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(32, 13);
			this.Email.TabIndex = 17;
			this.Email.Text = "Email";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(382, 244);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(312, 20);
			this.txtEmail.TabIndex = 16;
			this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
			// 
			// Prezime
			// 
			this.Prezime.AutoSize = true;
			this.Prezime.Location = new System.Drawing.Point(382, 180);
			this.Prezime.Name = "Prezime";
			this.Prezime.Size = new System.Drawing.Size(44, 13);
			this.Prezime.TabIndex = 15;
			this.Prezime.Text = "Prezime";
			// 
			// txtPrezime
			// 
			this.txtPrezime.Location = new System.Drawing.Point(382, 196);
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(312, 20);
			this.txtPrezime.TabIndex = 14;
			this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
			// 
			// Ime
			// 
			this.Ime.AutoSize = true;
			this.Ime.Location = new System.Drawing.Point(382, 124);
			this.Ime.Name = "Ime";
			this.Ime.Size = new System.Drawing.Size(24, 13);
			this.Ime.TabIndex = 13;
			this.Ime.Text = "Ime";
			// 
			// txtIme
			// 
			this.txtIme.Location = new System.Drawing.Point(382, 140);
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(312, 20);
			this.txtIme.TabIndex = 12;
			this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
			// 
			// PasswordConfirmation
			// 
			this.PasswordConfirmation.AutoSize = true;
			this.PasswordConfirmation.Location = new System.Drawing.Point(534, 434);
			this.PasswordConfirmation.Name = "PasswordConfirmation";
			this.PasswordConfirmation.Size = new System.Drawing.Size(76, 13);
			this.PasswordConfirmation.TabIndex = 25;
			this.PasswordConfirmation.Text = "Potrvdi lozinku";
			// 
			// txtPasswordConfirmation
			// 
			this.txtPasswordConfirmation.Location = new System.Drawing.Point(534, 450);
			this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
			this.txtPasswordConfirmation.PasswordChar = '*';
			this.txtPasswordConfirmation.Size = new System.Drawing.Size(160, 20);
			this.txtPasswordConfirmation.TabIndex = 24;
			// 
			// Password
			// 
			this.Password.AutoSize = true;
			this.Password.Location = new System.Drawing.Point(382, 434);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(44, 13);
			this.Password.TabIndex = 23;
			this.Password.Text = "Lozinka";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(382, 450);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(146, 20);
			this.txtPassword.TabIndex = 22;
			// 
			// btnSnimi
			// 
			this.btnSnimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnSnimi.Location = new System.Drawing.Point(607, 485);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(87, 23);
			this.btnSnimi.TabIndex = 26;
			this.btnSnimi.Text = "Sačuvaj";
			this.btnSnimi.UseVisualStyleBackColor = false;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(379, 329);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 27;
			this.label1.Text = "Datum registracije";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(382, 345);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(312, 20);
			this.dateTimePicker1.TabIndex = 28;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// frmPacijentDetalji
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label1);
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
			this.Name = "frmPacijentDetalji";
			this.Text = "frmPacijentDetalji";
			this.Load += new System.EventHandler(this.frmPacijentDetalji_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label KorisnickoIme;
		private System.Windows.Forms.TextBox txtKorisnickoIme;
		private System.Windows.Forms.Label BrojTelefona;
		private System.Windows.Forms.TextBox txtBrojTelefona;
		private System.Windows.Forms.Label Email;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label Prezime;
		private System.Windows.Forms.TextBox txtPrezime;
		private System.Windows.Forms.Label Ime;
		private System.Windows.Forms.TextBox txtIme;
		private System.Windows.Forms.Label PasswordConfirmation;
		private System.Windows.Forms.TextBox txtPasswordConfirmation;
		private System.Windows.Forms.Label Password;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnSnimi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}