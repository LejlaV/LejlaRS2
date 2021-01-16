namespace MyDentalCare.WinUI.Pregled
{
	partial class frmPregledi
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
			this.Doktori = new System.Windows.Forms.Label();
			this.cmbMedicinskiKartoni = new System.Windows.Forms.ComboBox();
			this.dgvPregledi = new System.Windows.Forms.DataGridView();
			this.PregledId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MedicinskiKartonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DijagnozaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LijekId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DijagnozaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LijekNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).BeginInit();
			this.SuspendLayout();
			// 
			// Doktori
			// 
			this.Doktori.AutoSize = true;
			this.Doktori.Location = new System.Drawing.Point(236, 128);
			this.Doktori.Name = "Doktori";
			this.Doktori.Size = new System.Drawing.Size(90, 13);
			this.Doktori.TabIndex = 6;
			this.Doktori.Text = "Medicinski karton";
			// 
			// cmbMedicinskiKartoni
			// 
			this.cmbMedicinskiKartoni.FormattingEnabled = true;
			this.cmbMedicinskiKartoni.Location = new System.Drawing.Point(239, 150);
			this.cmbMedicinskiKartoni.Name = "cmbMedicinskiKartoni";
			this.cmbMedicinskiKartoni.Size = new System.Drawing.Size(658, 21);
			this.cmbMedicinskiKartoni.TabIndex = 4;
			this.cmbMedicinskiKartoni.SelectedIndexChanged += new System.EventHandler(this.cmbMedicinskiKartoni_SelectedIndexChanged);
			// 
			// dgvPregledi
			// 
			this.dgvPregledi.AllowUserToAddRows = false;
			this.dgvPregledi.AllowUserToDeleteRows = false;
			this.dgvPregledi.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPregledi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PregledId,
            this.MedicinskiKartonId,
            this.RezervacijaId,
            this.KorisnikId,
            this.DijagnozaId,
            this.LijekId,
            this.DijagnozaNaziv,
            this.LijekNaziv,
            this.DatumVrijeme,
            this.Naziv,
            this.Opis});
			this.dgvPregledi.Location = new System.Drawing.Point(239, 204);
			this.dgvPregledi.Name = "dgvPregledi";
			this.dgvPregledi.ReadOnly = true;
			this.dgvPregledi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPregledi.Size = new System.Drawing.Size(658, 313);
			this.dgvPregledi.TabIndex = 8;
			this.dgvPregledi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPregledi_CellMouseDoubleClick);
			// 
			// PregledId
			// 
			this.PregledId.DataPropertyName = "PregledId";
			this.PregledId.HeaderText = "PregledId";
			this.PregledId.Name = "PregledId";
			this.PregledId.ReadOnly = true;
			this.PregledId.Visible = false;
			// 
			// MedicinskiKartonId
			// 
			this.MedicinskiKartonId.DataPropertyName = "MedicinskiKartonId";
			this.MedicinskiKartonId.HeaderText = "MedicinskiKartonId";
			this.MedicinskiKartonId.Name = "MedicinskiKartonId";
			this.MedicinskiKartonId.ReadOnly = true;
			this.MedicinskiKartonId.Visible = false;
			// 
			// RezervacijaId
			// 
			this.RezervacijaId.DataPropertyName = "RezervacijaId";
			this.RezervacijaId.HeaderText = "RezervacijaId";
			this.RezervacijaId.Name = "RezervacijaId";
			this.RezervacijaId.ReadOnly = true;
			this.RezervacijaId.Visible = false;
			// 
			// KorisnikId
			// 
			this.KorisnikId.DataPropertyName = "KorisnikId";
			this.KorisnikId.HeaderText = "KorisnikId";
			this.KorisnikId.Name = "KorisnikId";
			this.KorisnikId.ReadOnly = true;
			this.KorisnikId.Visible = false;
			// 
			// DijagnozaId
			// 
			this.DijagnozaId.DataPropertyName = "DijagnozaId";
			this.DijagnozaId.HeaderText = "DijagnozaId";
			this.DijagnozaId.Name = "DijagnozaId";
			this.DijagnozaId.ReadOnly = true;
			this.DijagnozaId.Visible = false;
			// 
			// LijekId
			// 
			this.LijekId.DataPropertyName = "LijekId";
			this.LijekId.HeaderText = "LijekId";
			this.LijekId.Name = "LijekId";
			this.LijekId.ReadOnly = true;
			this.LijekId.Visible = false;
			// 
			// DijagnozaNaziv
			// 
			this.DijagnozaNaziv.DataPropertyName = "DijagnozaNaziv";
			this.DijagnozaNaziv.HeaderText = "Dijagnoza";
			this.DijagnozaNaziv.Name = "DijagnozaNaziv";
			this.DijagnozaNaziv.ReadOnly = true;
			this.DijagnozaNaziv.Visible = false;
			// 
			// LijekNaziv
			// 
			this.LijekNaziv.DataPropertyName = "LijekNaziv";
			this.LijekNaziv.HeaderText = "Lijek";
			this.LijekNaziv.Name = "LijekNaziv";
			this.LijekNaziv.ReadOnly = true;
			this.LijekNaziv.Visible = false;
			// 
			// DatumVrijeme
			// 
			this.DatumVrijeme.DataPropertyName = "DatumVrijeme";
			this.DatumVrijeme.HeaderText = "Vrijeme pregleda";
			this.DatumVrijeme.Name = "DatumVrijeme";
			this.DatumVrijeme.ReadOnly = true;
			// 
			// Naziv
			// 
			this.Naziv.DataPropertyName = "Naziv";
			this.Naziv.HeaderText = "Naziv";
			this.Naziv.Name = "Naziv";
			this.Naziv.ReadOnly = true;
			// 
			// Opis
			// 
			this.Opis.DataPropertyName = "Opis";
			this.Opis.HeaderText = "Opis";
			this.Opis.Name = "Opis";
			this.Opis.ReadOnly = true;
			// 
			// frmPregledi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dgvPregledi);
			this.Controls.Add(this.Doktori);
			this.Controls.Add(this.cmbMedicinskiKartoni);
			this.Name = "frmPregledi";
			this.Text = "frmPregledi";
			this.Load += new System.EventHandler(this.frmPregledi_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label Doktori;
		private System.Windows.Forms.ComboBox cmbMedicinskiKartoni;
		private System.Windows.Forms.DataGridView dgvPregledi;
		private System.Windows.Forms.DataGridViewTextBoxColumn PregledId;
		private System.Windows.Forms.DataGridViewTextBoxColumn MedicinskiKartonId;
		private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
		private System.Windows.Forms.DataGridViewTextBoxColumn DijagnozaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn LijekId;
		private System.Windows.Forms.DataGridViewTextBoxColumn DijagnozaNaziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn LijekNaziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
	}
}