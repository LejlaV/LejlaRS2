namespace MyDentalCare.WinUI.Pregled
{
	partial class frmPregledDetalji
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
			this.dateTimePregled = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNaziv = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtOpis = new System.Windows.Forms.RichTextBox();
			this.Pacijenti = new System.Windows.Forms.Label();
			this.cmbLjekar = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbDijagnoza = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbLijek = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbRezervacija = new System.Windows.Forms.ComboBox();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.cmbMedicinskiKarton = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// dateTimePregled
			// 
			this.dateTimePregled.Location = new System.Drawing.Point(577, 159);
			this.dateTimePregled.Name = "dateTimePregled";
			this.dateTimePregled.Size = new System.Drawing.Size(231, 20);
			this.dateTimePregled.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(574, 132);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Datum i vrijeme obavljenog pregleda";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(192, 337);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Naziv";
			// 
			// txtNaziv
			// 
			this.txtNaziv.Location = new System.Drawing.Point(195, 358);
			this.txtNaziv.Name = "txtNaziv";
			this.txtNaziv.Size = new System.Drawing.Size(229, 20);
			this.txtNaziv.TabIndex = 16;
			this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(192, 397);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "Opis";
			// 
			// txtOpis
			// 
			this.txtOpis.Location = new System.Drawing.Point(193, 430);
			this.txtOpis.Name = "txtOpis";
			this.txtOpis.Size = new System.Drawing.Size(231, 96);
			this.txtOpis.TabIndex = 19;
			this.txtOpis.Text = "";
			this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
			// 
			// Pacijenti
			// 
			this.Pacijenti.AutoSize = true;
			this.Pacijenti.Location = new System.Drawing.Point(190, 132);
			this.Pacijenti.Name = "Pacijenti";
			this.Pacijenti.Size = new System.Drawing.Size(36, 13);
			this.Pacijenti.TabIndex = 21;
			this.Pacijenti.Text = "Ljekar";
			// 
			// cmbLjekar
			// 
			this.cmbLjekar.FormattingEnabled = true;
			this.cmbLjekar.Location = new System.Drawing.Point(193, 158);
			this.cmbLjekar.Name = "cmbLjekar";
			this.cmbLjekar.Size = new System.Drawing.Size(231, 21);
			this.cmbLjekar.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(190, 270);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 23;
			this.label4.Text = "Dijagnoza";
			// 
			// cmbDijagnoza
			// 
			this.cmbDijagnoza.FormattingEnabled = true;
			this.cmbDijagnoza.Location = new System.Drawing.Point(193, 296);
			this.cmbDijagnoza.Name = "cmbDijagnoza";
			this.cmbDijagnoza.Size = new System.Drawing.Size(231, 21);
			this.cmbDijagnoza.TabIndex = 22;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(574, 276);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 25;
			this.label5.Text = "Lijek";
			// 
			// cmbLijek
			// 
			this.cmbLijek.FormattingEnabled = true;
			this.cmbLijek.Location = new System.Drawing.Point(577, 296);
			this.cmbLijek.Name = "cmbLijek";
			this.cmbLijek.Size = new System.Drawing.Size(231, 21);
			this.cmbLijek.TabIndex = 24;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(190, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 13);
			this.label6.TabIndex = 27;
			this.label6.Text = "Rezervacija";
			// 
			// cmbRezervacija
			// 
			this.cmbRezervacija.FormattingEnabled = true;
			this.cmbRezervacija.Location = new System.Drawing.Point(193, 227);
			this.cmbRezervacija.Name = "cmbRezervacija";
			this.cmbRezervacija.Size = new System.Drawing.Size(231, 21);
			this.cmbRezervacija.TabIndex = 26;
			// 
			// btnSnimi
			// 
			this.btnSnimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnSnimi.Location = new System.Drawing.Point(841, 549);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(109, 24);
			this.btnSnimi.TabIndex = 28;
			this.btnSnimi.Text = "Sačuvaj";
			this.btnSnimi.UseVisualStyleBackColor = false;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(574, 200);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(136, 13);
			this.label7.TabIndex = 30;
			this.label7.Text = "Medicinski karton pacijenta";
			// 
			// cmbMedicinskiKarton
			// 
			this.cmbMedicinskiKarton.FormattingEnabled = true;
			this.cmbMedicinskiKarton.Location = new System.Drawing.Point(577, 227);
			this.cmbMedicinskiKarton.Name = "cmbMedicinskiKarton";
			this.cmbMedicinskiKarton.Size = new System.Drawing.Size(231, 21);
			this.cmbMedicinskiKarton.TabIndex = 29;
			// 
			// frmPregledDetalji
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmbMedicinskiKarton);
			this.Controls.Add(this.btnSnimi);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbRezervacija);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbLijek);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbDijagnoza);
			this.Controls.Add(this.Pacijenti);
			this.Controls.Add(this.cmbLjekar);
			this.Controls.Add(this.txtOpis);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNaziv);
			this.Controls.Add(this.dateTimePregled);
			this.Controls.Add(this.label1);
			this.Name = "frmPregledDetalji";
			this.Text = "frmPregledDetalji";
			this.Load += new System.EventHandler(this.frmPregledDetalji_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePregled;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNaziv;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox txtOpis;
		private System.Windows.Forms.Label Pacijenti;
		private System.Windows.Forms.ComboBox cmbLjekar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbDijagnoza;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbLijek;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbRezervacija;
		private System.Windows.Forms.Button btnSnimi;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbMedicinskiKarton;
	}
}