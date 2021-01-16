namespace MyDentalCare.WinUI.Pacijent
{
	partial class frmPacijenti
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
			this.dgvPacijenti = new System.Windows.Forms.DataGridView();
			this.PacijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DatumRegistracije = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIme = new System.Windows.Forms.TextBox();
			this.txtPrezime = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnPrikazi = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPacijenti
			// 
			this.dgvPacijenti.AllowUserToAddRows = false;
			this.dgvPacijenti.AllowUserToDeleteRows = false;
			this.dgvPacijenti.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPacijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PacijentId,
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.Email,
            this.BrojTelefona,
            this.DatumRegistracije});
			this.dgvPacijenti.Location = new System.Drawing.Point(233, 149);
			this.dgvPacijenti.Margin = new System.Windows.Forms.Padding(2, 2, 3, 3);
			this.dgvPacijenti.Name = "dgvPacijenti";
			this.dgvPacijenti.ReadOnly = true;
			this.dgvPacijenti.Size = new System.Drawing.Size(595, 313);
			this.dgvPacijenti.TabIndex = 0;
			this.dgvPacijenti.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPacijenti_CellMouseDoubleClick);
			// 
			// PacijentId
			// 
			this.PacijentId.DataPropertyName = "PacijentId";
			this.PacijentId.HeaderText = "PacijentId";
			this.PacijentId.Name = "PacijentId";
			this.PacijentId.ReadOnly = true;
			this.PacijentId.Visible = false;
			this.PacijentId.Width = 70;
			// 
			// Ime
			// 
			this.Ime.DataPropertyName = "Ime";
			this.Ime.HeaderText = "Ime";
			this.Ime.Name = "Ime";
			this.Ime.ReadOnly = true;
			this.Ime.Width = 80;
			// 
			// Prezime
			// 
			this.Prezime.DataPropertyName = "Prezime";
			this.Prezime.HeaderText = "Prezime";
			this.Prezime.Name = "Prezime";
			this.Prezime.ReadOnly = true;
			this.Prezime.Width = 80;
			// 
			// KorisnickoIme
			// 
			this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
			this.KorisnickoIme.HeaderText = "Korisnicko ime";
			this.KorisnickoIme.Name = "KorisnickoIme";
			this.KorisnickoIme.ReadOnly = true;
			this.KorisnickoIme.Width = 80;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "Email";
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			this.Email.Width = 130;
			// 
			// BrojTelefona
			// 
			this.BrojTelefona.DataPropertyName = "BrojTelefona";
			this.BrojTelefona.HeaderText = "BrojTelefona";
			this.BrojTelefona.Name = "BrojTelefona";
			this.BrojTelefona.ReadOnly = true;
			this.BrojTelefona.Width = 80;
			// 
			// DatumRegistracije
			// 
			this.DatumRegistracije.DataPropertyName = "DatumRegistracije";
			this.DatumRegistracije.HeaderText = "Datum registracije";
			this.DatumRegistracije.Name = "DatumRegistracije";
			this.DatumRegistracije.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(233, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ime:";
			// 
			// txtIme
			// 
			this.txtIme.Location = new System.Drawing.Point(266, 96);
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(140, 20);
			this.txtIme.TabIndex = 2;
			// 
			// txtPrezime
			// 
			this.txtPrezime.Location = new System.Drawing.Point(465, 95);
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(175, 20);
			this.txtPrezime.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(412, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Prezime:";
			// 
			// btnPrikazi
			// 
			this.btnPrikazi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnPrikazi.Location = new System.Drawing.Point(665, 93);
			this.btnPrikazi.Name = "btnPrikazi";
			this.btnPrikazi.Size = new System.Drawing.Size(163, 23);
			this.btnPrikazi.TabIndex = 5;
			this.btnPrikazi.Text = "Prikaži";
			this.btnPrikazi.UseVisualStyleBackColor = false;
			this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
			// 
			// frmPacijenti
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.btnPrikazi);
			this.Controls.Add(this.txtPrezime);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtIme);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvPacijenti);
			this.Name = "frmPacijenti";
			this.Text = "frmPacijenti";
			this.Load += new System.EventHandler(this.frmPacijenti_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPacijenti;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIme;
		private System.Windows.Forms.TextBox txtPrezime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnPrikazi;
		private System.Windows.Forms.DataGridViewTextBoxColumn PacijentId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
		private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
		private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn BrojTelefona;
		private System.Windows.Forms.DataGridViewTextBoxColumn DatumRegistracije;
	}
}