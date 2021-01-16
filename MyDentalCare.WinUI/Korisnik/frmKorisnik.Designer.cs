namespace MyDentalCare.WinUI.Korisnik
{
	partial class frmKorisnik
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvKorisnik = new System.Windows.Forms.DataGridView();
			this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnPrikazi = new System.Windows.Forms.Button();
			this.txtPretraga = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKorisnik)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvKorisnik);
			this.groupBox1.Location = new System.Drawing.Point(246, 165);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(606, 287);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lista korisnika";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// dgvKorisnik
			// 
			this.dgvKorisnik.AllowUserToAddRows = false;
			this.dgvKorisnik.AllowUserToDeleteRows = false;
			this.dgvKorisnik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvKorisnik.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvKorisnik.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvKorisnik.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvKorisnik.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvKorisnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKorisnik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikId,
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.DatumRodjenja,
            this.Email,
            this.BrojTelefona});
			this.dgvKorisnik.Location = new System.Drawing.Point(3, 16);
			this.dgvKorisnik.Name = "dgvKorisnik";
			this.dgvKorisnik.ReadOnly = true;
			this.dgvKorisnik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvKorisnik.Size = new System.Drawing.Size(600, 268);
			this.dgvKorisnik.TabIndex = 0;
			this.dgvKorisnik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnik_CellContentCli);
			this.dgvKorisnik.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnik_CellDoubleClick);
			this.dgvKorisnik.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKorisnik_CellMouseDoubleClick);
			// 
			// KorisnikId
			// 
			this.KorisnikId.DataPropertyName = "KorisnikId";
			this.KorisnikId.HeaderText = "KorisnikId";
			this.KorisnikId.Name = "KorisnikId";
			this.KorisnikId.ReadOnly = true;
			this.KorisnikId.Visible = false;
			this.KorisnikId.Width = 80;
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
			this.KorisnickoIme.HeaderText = "Korisničko ime";
			this.KorisnickoIme.Name = "KorisnickoIme";
			this.KorisnickoIme.ReadOnly = true;
			this.KorisnickoIme.Width = 90;
			// 
			// DatumRodjenja
			// 
			this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
			this.DatumRodjenja.HeaderText = "Datum rođenja";
			this.DatumRodjenja.Name = "DatumRodjenja";
			this.DatumRodjenja.ReadOnly = true;
			this.DatumRodjenja.Width = 90;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "Email";
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			this.Email.Width = 95;
			// 
			// BrojTelefona
			// 
			this.BrojTelefona.DataPropertyName = "BrojTelefona";
			this.BrojTelefona.HeaderText = "Broj telefona";
			this.BrojTelefona.Name = "BrojTelefona";
			this.BrojTelefona.ReadOnly = true;
			this.BrojTelefona.Width = 95;
			// 
			// btnPrikazi
			// 
			this.btnPrikazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrikazi.Location = new System.Drawing.Point(774, 127);
			this.btnPrikazi.Name = "btnPrikazi";
			this.btnPrikazi.Size = new System.Drawing.Size(75, 20);
			this.btnPrikazi.TabIndex = 1;
			this.btnPrikazi.Text = "Prikazi";
			this.btnPrikazi.UseVisualStyleBackColor = true;
			this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
			// 
			// txtPretraga
			// 
			this.txtPretraga.Location = new System.Drawing.Point(246, 127);
			this.txtPretraga.Name = "txtPretraga";
			this.txtPretraga.Size = new System.Drawing.Size(506, 20);
			this.txtPretraga.TabIndex = 2;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// frmKorisnik
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1096, 749);
			this.Controls.Add(this.txtPretraga);
			this.Controls.Add(this.btnPrikazi);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmKorisnik";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmKorisnik";
			this.Load += new System.EventHandler(this.frmKorisnik_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvKorisnik)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvKorisnik;
		private System.Windows.Forms.Button btnPrikazi;
		private System.Windows.Forms.TextBox txtPretraga;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
		private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
		private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
		private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn BrojTelefona;
	}
}