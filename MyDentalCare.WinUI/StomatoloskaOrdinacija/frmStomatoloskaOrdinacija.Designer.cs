namespace MyDentalCare.WinUI.StomatoloskaOrdinacija
{
	partial class frmStomatoloskaOrdinacija
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
			this.Naziv = new System.Windows.Forms.Label();
			this.Adresa = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.Label();
			this.RadnoVrijemeOD = new System.Windows.Forms.Label();
			this.BrojTelefona = new System.Windows.Forms.Label();
			this.txtNaziv = new System.Windows.Forms.TextBox();
			this.txtBrojTelefona = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.RadnoVrijemeDO = new System.Windows.Forms.Label();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.dateRadnoVrijemeOD = new System.Windows.Forms.DateTimePicker();
			this.dateRadnoVrijemeDO = new System.Windows.Forms.DateTimePicker();
			this.cmbAdresa = new System.Windows.Forms.ComboBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// Naziv
			// 
			this.Naziv.AutoSize = true;
			this.Naziv.Location = new System.Drawing.Point(372, 123);
			this.Naziv.Name = "Naziv";
			this.Naziv.Size = new System.Drawing.Size(34, 13);
			this.Naziv.TabIndex = 0;
			this.Naziv.Text = "Naziv";
			// 
			// Adresa
			// 
			this.Adresa.AutoSize = true;
			this.Adresa.Location = new System.Drawing.Point(372, 177);
			this.Adresa.Name = "Adresa";
			this.Adresa.Size = new System.Drawing.Size(40, 13);
			this.Adresa.TabIndex = 1;
			this.Adresa.Text = "Adresa";
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Location = new System.Drawing.Point(372, 229);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(32, 13);
			this.Email.TabIndex = 2;
			this.Email.Text = "Email";
			// 
			// RadnoVrijemeOD
			// 
			this.RadnoVrijemeOD.AutoSize = true;
			this.RadnoVrijemeOD.Location = new System.Drawing.Point(372, 332);
			this.RadnoVrijemeOD.Name = "RadnoVrijemeOD";
			this.RadnoVrijemeOD.Size = new System.Drawing.Size(94, 13);
			this.RadnoVrijemeOD.TabIndex = 3;
			this.RadnoVrijemeOD.Text = "Radno vrijeme OD";
			// 
			// BrojTelefona
			// 
			this.BrojTelefona.AutoSize = true;
			this.BrojTelefona.Location = new System.Drawing.Point(372, 281);
			this.BrojTelefona.Name = "BrojTelefona";
			this.BrojTelefona.Size = new System.Drawing.Size(66, 13);
			this.BrojTelefona.TabIndex = 4;
			this.BrojTelefona.Text = "Broj telefona";
			// 
			// txtNaziv
			// 
			this.txtNaziv.Location = new System.Drawing.Point(375, 139);
			this.txtNaziv.Name = "txtNaziv";
			this.txtNaziv.Size = new System.Drawing.Size(329, 20);
			this.txtNaziv.TabIndex = 5;
			this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
			// 
			// txtBrojTelefona
			// 
			this.txtBrojTelefona.Location = new System.Drawing.Point(375, 297);
			this.txtBrojTelefona.Name = "txtBrojTelefona";
			this.txtBrojTelefona.Size = new System.Drawing.Size(329, 20);
			this.txtBrojTelefona.TabIndex = 7;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(375, 245);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(329, 20);
			this.txtEmail.TabIndex = 8;
			this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
			// 
			// RadnoVrijemeDO
			// 
			this.RadnoVrijemeDO.AutoSize = true;
			this.RadnoVrijemeDO.Location = new System.Drawing.Point(372, 397);
			this.RadnoVrijemeDO.Name = "RadnoVrijemeDO";
			this.RadnoVrijemeDO.Size = new System.Drawing.Size(94, 13);
			this.RadnoVrijemeDO.TabIndex = 10;
			this.RadnoVrijemeDO.Text = "Radno vrijeme DO";
			// 
			// btnSnimi
			// 
			this.btnSnimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnSnimi.Location = new System.Drawing.Point(599, 470);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(105, 23);
			this.btnSnimi.TabIndex = 12;
			this.btnSnimi.Text = "Sačuvaj";
			this.btnSnimi.UseVisualStyleBackColor = false;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// dateRadnoVrijemeOD
			// 
			this.dateRadnoVrijemeOD.Location = new System.Drawing.Point(375, 348);
			this.dateRadnoVrijemeOD.Name = "dateRadnoVrijemeOD";
			this.dateRadnoVrijemeOD.Size = new System.Drawing.Size(329, 20);
			this.dateRadnoVrijemeOD.TabIndex = 13;
			// 
			// dateRadnoVrijemeDO
			// 
			this.dateRadnoVrijemeDO.Location = new System.Drawing.Point(375, 413);
			this.dateRadnoVrijemeDO.Name = "dateRadnoVrijemeDO";
			this.dateRadnoVrijemeDO.Size = new System.Drawing.Size(329, 20);
			this.dateRadnoVrijemeDO.TabIndex = 14;
			// 
			// cmbAdresa
			// 
			this.cmbAdresa.FormattingEnabled = true;
			this.cmbAdresa.Location = new System.Drawing.Point(375, 201);
			this.cmbAdresa.Name = "cmbAdresa";
			this.cmbAdresa.Size = new System.Drawing.Size(329, 21);
			this.cmbAdresa.TabIndex = 15;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// frmStomatoloskaOrdinacija
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1084, 642);
			this.Controls.Add(this.cmbAdresa);
			this.Controls.Add(this.dateRadnoVrijemeDO);
			this.Controls.Add(this.dateRadnoVrijemeOD);
			this.Controls.Add(this.btnSnimi);
			this.Controls.Add(this.RadnoVrijemeDO);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtBrojTelefona);
			this.Controls.Add(this.txtNaziv);
			this.Controls.Add(this.BrojTelefona);
			this.Controls.Add(this.RadnoVrijemeOD);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.Adresa);
			this.Controls.Add(this.Naziv);
			this.Name = "frmStomatoloskaOrdinacija";
			this.Text = "frmStomatoloskaOrdinacija";
			this.Load += new System.EventHandler(this.frmStomatoloskaOrdinacija_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Naziv;
		private System.Windows.Forms.Label Adresa;
		private System.Windows.Forms.Label Email;
		private System.Windows.Forms.Label RadnoVrijemeOD;
		private System.Windows.Forms.Label BrojTelefona;
		private System.Windows.Forms.TextBox txtNaziv;
		private System.Windows.Forms.TextBox txtBrojTelefona;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label RadnoVrijemeDO;
		private System.Windows.Forms.Button btnSnimi;
		private System.Windows.Forms.DateTimePicker dateRadnoVrijemeOD;
		private System.Windows.Forms.DateTimePicker dateRadnoVrijemeDO;
		private System.Windows.Forms.ComboBox cmbAdresa;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}