namespace MyDentalCare.WinUI.MedicinskiKarton
{
	partial class frmMedicinskiKartoni
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
			this.cmbPacijenti = new System.Windows.Forms.ComboBox();
			this.dgvMedicinskiKartoni = new System.Windows.Forms.DataGridView();
			this.MedicinskiKartonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pacijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PacijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvMedicinskiKartoni)).BeginInit();
			this.SuspendLayout();
			// 
			// Doktori
			// 
			this.Doktori.AutoSize = true;
			this.Doktori.Location = new System.Drawing.Point(78, 126);
			this.Doktori.Name = "Doktori";
			this.Doktori.Size = new System.Drawing.Size(47, 13);
			this.Doktori.TabIndex = 8;
			this.Doktori.Text = "Pacijenti";
			// 
			// cmbPacijenti
			// 
			this.cmbPacijenti.FormattingEnabled = true;
			this.cmbPacijenti.Location = new System.Drawing.Point(137, 126);
			this.cmbPacijenti.Name = "cmbPacijenti";
			this.cmbPacijenti.Size = new System.Drawing.Size(419, 21);
			this.cmbPacijenti.TabIndex = 7;
			this.cmbPacijenti.SelectedIndexChanged += new System.EventHandler(this.cmbPacijenti_SelectedIndexChanged);
			// 
			// dgvMedicinskiKartoni
			// 
			this.dgvMedicinskiKartoni.AllowUserToAddRows = false;
			this.dgvMedicinskiKartoni.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvMedicinskiKartoni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMedicinskiKartoni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicinskiKartonId,
            this.Pacijent,
            this.DatumVrijeme,
            this.PacijentId,
            this.Naziv,
            this.Opis});
			this.dgvMedicinskiKartoni.GridColor = System.Drawing.SystemColors.Window;
			this.dgvMedicinskiKartoni.Location = new System.Drawing.Point(81, 177);
			this.dgvMedicinskiKartoni.Name = "dgvMedicinskiKartoni";
			this.dgvMedicinskiKartoni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMedicinskiKartoni.Size = new System.Drawing.Size(475, 254);
			this.dgvMedicinskiKartoni.TabIndex = 9;
			this.dgvMedicinskiKartoni.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMedicinskiKartoni_CellMouseDoubleClick);
			// 
			// MedicinskiKartonId
			// 
			this.MedicinskiKartonId.DataPropertyName = "MedicinskiKartonId";
			this.MedicinskiKartonId.HeaderText = "MedicinskiKartonId";
			this.MedicinskiKartonId.Name = "MedicinskiKartonId";
			this.MedicinskiKartonId.Visible = false;
			// 
			// Pacijent
			// 
			this.Pacijent.DataPropertyName = "Pacijent";
			this.Pacijent.HeaderText = "Pacijent";
			this.Pacijent.Name = "Pacijent";
			this.Pacijent.Visible = false;
			// 
			// DatumVrijeme
			// 
			this.DatumVrijeme.DataPropertyName = "DatumVrijeme";
			this.DatumVrijeme.HeaderText = "Datum kreiranja";
			this.DatumVrijeme.Name = "DatumVrijeme";
			this.DatumVrijeme.ReadOnly = true;
			this.DatumVrijeme.Width = 130;
			// 
			// PacijentId
			// 
			this.PacijentId.DataPropertyName = "PacijentId";
			this.PacijentId.HeaderText = "PacijentId";
			this.PacijentId.Name = "PacijentId";
			this.PacijentId.Visible = false;
			// 
			// Naziv
			// 
			this.Naziv.DataPropertyName = "Naziv";
			this.Naziv.HeaderText = "Naziv";
			this.Naziv.Name = "Naziv";
			this.Naziv.ReadOnly = true;
			this.Naziv.Width = 200;
			// 
			// Opis
			// 
			this.Opis.DataPropertyName = "Opis";
			this.Opis.HeaderText = "Opis";
			this.Opis.Name = "Opis";
			this.Opis.ReadOnly = true;
			// 
			// frmMedicinskiKartoni
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dgvMedicinskiKartoni);
			this.Controls.Add(this.Doktori);
			this.Controls.Add(this.cmbPacijenti);
			this.Name = "frmMedicinskiKartoni";
			this.Text = "frmMedicinskiKartoni";
			this.Load += new System.EventHandler(this.frmMedicinskiKartoni_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMedicinskiKartoni)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Doktori;
		private System.Windows.Forms.ComboBox cmbPacijenti;
		private System.Windows.Forms.DataGridView dgvMedicinskiKartoni;
		private System.Windows.Forms.DataGridViewTextBoxColumn MedicinskiKartonId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Pacijent;
		private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
		private System.Windows.Forms.DataGridViewTextBoxColumn PacijentId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
	}
}