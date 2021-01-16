namespace MyDentalCare.WinUI.Rezervacija
{
	partial class frmRezervacije
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
			this.cmbPacijent = new System.Windows.Forms.ComboBox();
			this.Pacijenti = new System.Windows.Forms.Label();
			this.dgvRezervacije = new System.Windows.Forms.DataGridView();
			this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Razlog = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UslugaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UslugaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PacijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbPacijent
			// 
			this.cmbPacijent.FormattingEnabled = true;
			this.cmbPacijent.Location = new System.Drawing.Point(249, 123);
			this.cmbPacijent.Name = "cmbPacijent";
			this.cmbPacijent.Size = new System.Drawing.Size(583, 21);
			this.cmbPacijent.TabIndex = 0;
			this.cmbPacijent.SelectedIndexChanged += new System.EventHandler(this.cmbPacijent_SelectedIndexChanged);
			// 
			// Pacijenti
			// 
			this.Pacijenti.AutoSize = true;
			this.Pacijenti.Location = new System.Drawing.Point(246, 101);
			this.Pacijenti.Name = "Pacijenti";
			this.Pacijenti.Size = new System.Drawing.Size(47, 13);
			this.Pacijenti.TabIndex = 2;
			this.Pacijenti.Text = "Pacijenti";
			// 
			// dgvRezervacije
			// 
			this.dgvRezervacije.AllowUserToAddRows = false;
			this.dgvRezervacije.AllowUserToDeleteRows = false;
			this.dgvRezervacije.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaId,
            this.DatumVrijeme,
            this.Razlog,
            this.UslugaId,
            this.UslugaNaziv,
            this.PacijentId});
			this.dgvRezervacije.Location = new System.Drawing.Point(249, 170);
			this.dgvRezervacije.Name = "dgvRezervacije";
			this.dgvRezervacije.ReadOnly = true;
			this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRezervacije.Size = new System.Drawing.Size(583, 313);
			this.dgvRezervacije.TabIndex = 4;
			this.dgvRezervacije.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRezervacije_CellMouseDoubleClick);
			// 
			// RezervacijaId
			// 
			this.RezervacijaId.DataPropertyName = "RezervacijaId";
			this.RezervacijaId.HeaderText = "RezervacijaId";
			this.RezervacijaId.Name = "RezervacijaId";
			this.RezervacijaId.ReadOnly = true;
			this.RezervacijaId.Visible = false;
			// 
			// DatumVrijeme
			// 
			this.DatumVrijeme.DataPropertyName = "DatumVrijeme";
			this.DatumVrijeme.HeaderText = "Datum i vrijeme";
			this.DatumVrijeme.Name = "DatumVrijeme";
			this.DatumVrijeme.ReadOnly = true;
			// 
			// Razlog
			// 
			this.Razlog.DataPropertyName = "Razlog";
			this.Razlog.HeaderText = "Razlog";
			this.Razlog.Name = "Razlog";
			this.Razlog.ReadOnly = true;
			// 
			// UslugaId
			// 
			this.UslugaId.DataPropertyName = "UslugaId";
			this.UslugaId.HeaderText = "UslugaId";
			this.UslugaId.Name = "UslugaId";
			this.UslugaId.ReadOnly = true;
			this.UslugaId.Visible = false;
			// 
			// UslugaNaziv
			// 
			this.UslugaNaziv.DataPropertyName = "UslugaNaziv";
			this.UslugaNaziv.HeaderText = "Usluga";
			this.UslugaNaziv.Name = "UslugaNaziv";
			this.UslugaNaziv.ReadOnly = true;
			// 
			// PacijentId
			// 
			this.PacijentId.DataPropertyName = "PacijentId";
			this.PacijentId.HeaderText = "PacijentId";
			this.PacijentId.Name = "PacijentId";
			this.PacijentId.ReadOnly = true;
			this.PacijentId.Visible = false;
			// 
			// frmRezervacije
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dgvRezervacije);
			this.Controls.Add(this.Pacijenti);
			this.Controls.Add(this.cmbPacijent);
			this.Name = "frmRezervacije";
			this.Text = "frmRezervacije";
			this.Load += new System.EventHandler(this.frmRezervacije_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbPacijent;
		private System.Windows.Forms.Label Pacijenti;
		private System.Windows.Forms.DataGridView dgvRezervacije;
		private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
		private System.Windows.Forms.DataGridViewTextBoxColumn Razlog;
		private System.Windows.Forms.DataGridViewTextBoxColumn UslugaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn UslugaNaziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn PacijentId;
	}
}