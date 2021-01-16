namespace MyDentalCare.WinUI.Izvjestaji
{
	partial class frmRezervacijeIzvjestaj
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
			this.cmbMjesec = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExportToPdf = new System.Windows.Forms.Button();
			this.dgvIzvjestajRezervacije = new System.Windows.Forms.DataGridView();
			this.BrojRezervacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UkupnaZarada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNajcescaUsluga = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestajRezervacije)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbMjesec
			// 
			this.cmbMjesec.FormattingEnabled = true;
			this.cmbMjesec.Location = new System.Drawing.Point(457, 157);
			this.cmbMjesec.Name = "cmbMjesec";
			this.cmbMjesec.Size = new System.Drawing.Size(258, 21);
			this.cmbMjesec.TabIndex = 0;
			this.cmbMjesec.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(310, 157);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Odaberi mjesec:";
			// 
			// btnExportToPdf
			// 
			this.btnExportToPdf.Location = new System.Drawing.Point(577, 402);
			this.btnExportToPdf.Name = "btnExportToPdf";
			this.btnExportToPdf.Size = new System.Drawing.Size(138, 32);
			this.btnExportToPdf.TabIndex = 4;
			this.btnExportToPdf.Text = "Preuzmi PDF";
			this.btnExportToPdf.UseVisualStyleBackColor = true;
			this.btnExportToPdf.Click += new System.EventHandler(this.btnExportToPdf_Click);
			// 
			// dgvIzvjestajRezervacije
			// 
			this.dgvIzvjestajRezervacije.AllowUserToAddRows = false;
			this.dgvIzvjestajRezervacije.AllowUserToDeleteRows = false;
			this.dgvIzvjestajRezervacije.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvIzvjestajRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIzvjestajRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrojRezervacija,
            this.UkupnaZarada});
			this.dgvIzvjestajRezervacije.Location = new System.Drawing.Point(313, 204);
			this.dgvIzvjestajRezervacije.Name = "dgvIzvjestajRezervacije";
			this.dgvIzvjestajRezervacije.ReadOnly = true;
			this.dgvIzvjestajRezervacije.Size = new System.Drawing.Size(402, 84);
			this.dgvIzvjestajRezervacije.TabIndex = 5;
			// 
			// BrojRezervacija
			// 
			this.BrojRezervacija.DataPropertyName = "BrojRezervacija";
			this.BrojRezervacija.HeaderText = "Broj rezervacija";
			this.BrojRezervacija.Name = "BrojRezervacija";
			this.BrojRezervacija.ReadOnly = true;
			// 
			// UkupnaZarada
			// 
			this.UkupnaZarada.DataPropertyName = "UkupnaZarada";
			this.UkupnaZarada.HeaderText = "Ukupna zarada";
			this.UkupnaZarada.Name = "UkupnaZarada";
			this.UkupnaZarada.ReadOnly = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(310, 329);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Najčešće rezervisana usluga: ";
			// 
			// txtNajcescaUsluga
			// 
			this.txtNajcescaUsluga.Location = new System.Drawing.Point(478, 326);
			this.txtNajcescaUsluga.Name = "txtNajcescaUsluga";
			this.txtNajcescaUsluga.Size = new System.Drawing.Size(237, 20);
			this.txtNajcescaUsluga.TabIndex = 13;
			// 
			// frmRezervacijeIzvjestaj
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNajcescaUsluga);
			this.Controls.Add(this.dgvIzvjestajRezervacije);
			this.Controls.Add(this.btnExportToPdf);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbMjesec);
			this.Name = "frmRezervacijeIzvjestaj";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmRezervacijeIzvjestaj";
			this.Load += new System.EventHandler(this.frmRezervacijeIzvjestaj_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestajRezervacije)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbMjesec;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExportToPdf;
		private System.Windows.Forms.DataGridView dgvIzvjestajRezervacije;
		private System.Windows.Forms.DataGridViewTextBoxColumn BrojRezervacija;
		private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaZarada;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNajcescaUsluga;
	}
}