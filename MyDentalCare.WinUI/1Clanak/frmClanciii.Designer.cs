namespace MyDentalCare.WinUI.Clanak
{
	partial class frmClanci
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
			this.cmbKategorije = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Naziv = new System.Windows.Forms.Label();
			this.txtNaslov = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSadrzaj = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSlikaInput = new System.Windows.Forms.TextBox();
			this.btnDodajSliku = new System.Windows.Forms.Button();
			this.dgvClanci = new System.Windows.Forms.DataGridView();
			this.ClanakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KategorijaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KategorijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DatumObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvClanci)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbKategorije
			// 
			this.cmbKategorije.FormattingEnabled = true;
			this.cmbKategorije.Location = new System.Drawing.Point(110, 31);
			this.cmbKategorije.Name = "cmbKategorije";
			this.cmbKategorije.Size = new System.Drawing.Size(255, 21);
			this.cmbKategorije.TabIndex = 0;
			this.cmbKategorije.SelectedIndexChanged += new System.EventHandler(this.cmbKategorije_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kategorija članka:";
			// 
			// Naziv
			// 
			this.Naziv.AutoSize = true;
			this.Naziv.Location = new System.Drawing.Point(12, 69);
			this.Naziv.Name = "Naziv";
			this.Naziv.Size = new System.Drawing.Size(43, 13);
			this.Naziv.TabIndex = 4;
			this.Naziv.Text = "Naslov:";
			// 
			// txtNaslov
			// 
			this.txtNaslov.Location = new System.Drawing.Point(110, 69);
			this.txtNaslov.Name = "txtNaslov";
			this.txtNaslov.Size = new System.Drawing.Size(255, 20);
			this.txtNaslov.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Sadržaj:";
			// 
			// txtSadrzaj
			// 
			this.txtSadrzaj.Location = new System.Drawing.Point(110, 106);
			this.txtSadrzaj.Name = "txtSadrzaj";
			this.txtSadrzaj.Size = new System.Drawing.Size(255, 106);
			this.txtSadrzaj.TabIndex = 7;
			this.txtSadrzaj.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 233);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Slika:";
			// 
			// txtSlikaInput
			// 
			this.txtSlikaInput.Location = new System.Drawing.Point(110, 235);
			this.txtSlikaInput.Name = "txtSlikaInput";
			this.txtSlikaInput.Size = new System.Drawing.Size(255, 20);
			this.txtSlikaInput.TabIndex = 11;
			// 
			// btnDodajSliku
			// 
			this.btnDodajSliku.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnDodajSliku.Location = new System.Drawing.Point(386, 235);
			this.btnDodajSliku.Name = "btnDodajSliku";
			this.btnDodajSliku.Size = new System.Drawing.Size(80, 23);
			this.btnDodajSliku.TabIndex = 12;
			this.btnDodajSliku.Text = "Dodaj sliku";
			this.btnDodajSliku.UseVisualStyleBackColor = false;
			this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
			// 
			// dgvClanci
			// 
			this.dgvClanci.AllowUserToAddRows = false;
			this.dgvClanci.AllowUserToDeleteRows = false;
			this.dgvClanci.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvClanci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClanci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClanakId,
            this.KorisnikId,
            this.Kategorija,
            this.KategorijaNaziv,
            this.KategorijaId,
            this.Naslov,
            this.Sadrzaj,
            this.DatumObjave,
            this.Slika});
			this.dgvClanci.Location = new System.Drawing.Point(15, 344);
			this.dgvClanci.Name = "dgvClanci";
			this.dgvClanci.ReadOnly = true;
			this.dgvClanci.Size = new System.Drawing.Size(855, 150);
			this.dgvClanci.TabIndex = 13;
			// 
			// ClanakId
			// 
			this.ClanakId.DataPropertyName = "ClanakId";
			this.ClanakId.HeaderText = "ClanakId";
			this.ClanakId.Name = "ClanakId";
			this.ClanakId.ReadOnly = true;
			this.ClanakId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ClanakId.Visible = false;
			// 
			// KorisnikId
			// 
			this.KorisnikId.DataPropertyName = "KorisnikId";
			this.KorisnikId.HeaderText = "KorisnikId";
			this.KorisnikId.Name = "KorisnikId";
			this.KorisnikId.ReadOnly = true;
			this.KorisnikId.Visible = false;
			// 
			// Kategorija
			// 
			this.Kategorija.DataPropertyName = "Kategorija";
			this.Kategorija.HeaderText = "Kategorija";
			this.Kategorija.Name = "Kategorija";
			this.Kategorija.ReadOnly = true;
			this.Kategorija.Visible = false;
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
			// Slika
			// 
			this.Slika.DataPropertyName = "Slika";
			this.Slika.HeaderText = "Slika";
			this.Slika.Name = "Slika";
			this.Slika.ReadOnly = true;
			this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnSnimi
			// 
			this.btnSnimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnSnimi.Location = new System.Drawing.Point(715, 235);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(155, 23);
			this.btnSnimi.TabIndex = 14;
			this.btnSnimi.Text = "Sačuvaj";
			this.btnSnimi.UseVisualStyleBackColor = false;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(715, 31);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(155, 181);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox.TabIndex = 15;
			this.pictureBox.TabStop = false;
			// 
			// frmClanci
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(894, 520);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.btnSnimi);
			this.Controls.Add(this.dgvClanci);
			this.Controls.Add(this.btnDodajSliku);
			this.Controls.Add(this.txtSlikaInput);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSadrzaj);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Naziv);
			this.Controls.Add(this.txtNaslov);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbKategorije);
			this.Name = "frmClanci";
			this.Text = "frmClanci";
			this.Load += new System.EventHandler(this.frmClanci_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvClanci)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbKategorije;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Naziv;
		private System.Windows.Forms.TextBox txtNaslov;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox txtSadrzaj;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSlikaInput;
		private System.Windows.Forms.Button btnDodajSliku;
		private System.Windows.Forms.DataGridView dgvClanci;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnSnimi;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClanakId;
		private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
		private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaNaziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
		private System.Windows.Forms.DataGridViewTextBoxColumn DatumObjave;
		private System.Windows.Forms.DataGridViewImageColumn Slika;
	}
}