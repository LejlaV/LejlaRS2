namespace MyDentalCare.WinUI.Clanak
{
	partial class frmListaClanaka
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
			this.label1 = new System.Windows.Forms.Label();
			this.cmbKategorije = new System.Windows.Forms.ComboBox();
			this.dgvListaClanaka = new System.Windows.Forms.DataGridView();
			this.ClanakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KategorijaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KategorijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DatumObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaClanaka)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(132, 122);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Kategorija članka:";
			// 
			// cmbKategorije
			// 
			this.cmbKategorije.FormattingEnabled = true;
			this.cmbKategorije.Location = new System.Drawing.Point(230, 119);
			this.cmbKategorije.Name = "cmbKategorije";
			this.cmbKategorije.Size = new System.Drawing.Size(667, 21);
			this.cmbKategorije.TabIndex = 2;
			this.cmbKategorije.SelectedIndexChanged += new System.EventHandler(this.cmbKategorije_SelectedIndexChanged);
			// 
			// dgvListaClanaka
			// 
			this.dgvListaClanaka.AllowUserToAddRows = false;
			this.dgvListaClanaka.AllowUserToDeleteRows = false;
			this.dgvListaClanaka.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvListaClanaka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaClanaka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClanakId,
            this.KategorijaNaziv,
            this.KategorijaId,
            this.KorisnikId,
            this.Naslov,
            this.Sadrzaj,
            this.DatumObjave});
			this.dgvListaClanaka.Location = new System.Drawing.Point(135, 167);
			this.dgvListaClanaka.Name = "dgvListaClanaka";
			this.dgvListaClanaka.ReadOnly = true;
			this.dgvListaClanaka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListaClanaka.Size = new System.Drawing.Size(762, 332);
			this.dgvListaClanaka.TabIndex = 4;
			this.dgvListaClanaka.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaClanaka_CellMouseDoubleClick);
			// 
			// ClanakId
			// 
			this.ClanakId.DataPropertyName = "ClanakId";
			this.ClanakId.HeaderText = "ClanakId";
			this.ClanakId.Name = "ClanakId";
			this.ClanakId.ReadOnly = true;
			this.ClanakId.Visible = false;
			// 
			// KategorijaNaziv
			// 
			this.KategorijaNaziv.DataPropertyName = "KategorijaNaziv";
			this.KategorijaNaziv.HeaderText = "Kategorija";
			this.KategorijaNaziv.Name = "KategorijaNaziv";
			this.KategorijaNaziv.ReadOnly = true;
			// 
			// KategorijaId
			// 
			this.KategorijaId.DataPropertyName = "KategorijaId";
			this.KategorijaId.HeaderText = "KategorijaId";
			this.KategorijaId.Name = "KategorijaId";
			this.KategorijaId.ReadOnly = true;
			this.KategorijaId.Visible = false;
			// 
			// KorisnikId
			// 
			this.KorisnikId.DataPropertyName = "KorisnikId";
			this.KorisnikId.HeaderText = "KorisnikId";
			this.KorisnikId.Name = "KorisnikId";
			this.KorisnikId.ReadOnly = true;
			this.KorisnikId.Visible = false;
			// 
			// Naslov
			// 
			this.Naslov.DataPropertyName = "Naslov";
			this.Naslov.HeaderText = "Naslov";
			this.Naslov.Name = "Naslov";
			this.Naslov.ReadOnly = true;
			// 
			// Sadrzaj
			// 
			this.Sadrzaj.DataPropertyName = "Sadrzaj";
			this.Sadrzaj.HeaderText = "Sadrzaj";
			this.Sadrzaj.Name = "Sadrzaj";
			this.Sadrzaj.ReadOnly = true;
			// 
			// DatumObjave
			// 
			this.DatumObjave.DataPropertyName = "DatumObjave";
			this.DatumObjave.HeaderText = "Datum objave";
			this.DatumObjave.Name = "DatumObjave";
			this.DatumObjave.ReadOnly = true;
			// 
			// frmListaClanaka
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dgvListaClanaka);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbKategorije);
			this.Name = "frmListaClanaka";
			this.Text = "frmListaClanaka";
			this.Load += new System.EventHandler(this.frmListaClanaka_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListaClanaka)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbKategorije;
		private System.Windows.Forms.DataGridView dgvListaClanaka;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClanakId;
		private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaNaziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
		private System.Windows.Forms.DataGridViewTextBoxColumn DatumObjave;
	}
}