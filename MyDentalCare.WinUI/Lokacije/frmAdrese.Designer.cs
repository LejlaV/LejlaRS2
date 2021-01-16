namespace MyDentalCare.WinUI.Lokacije
{
	partial class frmAdrese
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
			this.btnPrikazi = new System.Windows.Forms.Button();
			this.txtPretraga = new System.Windows.Forms.TextBox();
			this.dgvAdrese = new System.Windows.Forms.DataGridView();
			this.AdresaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PostanskiBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DrzavaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GradId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GradNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DrzavaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdrese)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPrikazi
			// 
			this.btnPrikazi.Location = new System.Drawing.Point(314, 100);
			this.btnPrikazi.Name = "btnPrikazi";
			this.btnPrikazi.Size = new System.Drawing.Size(102, 23);
			this.btnPrikazi.TabIndex = 5;
			this.btnPrikazi.Text = "Prikaži";
			this.btnPrikazi.UseVisualStyleBackColor = true;
			this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
			// 
			// txtPretraga
			// 
			this.txtPretraga.Location = new System.Drawing.Point(64, 100);
			this.txtPretraga.Name = "txtPretraga";
			this.txtPretraga.Size = new System.Drawing.Size(228, 20);
			this.txtPretraga.TabIndex = 4;
			// 
			// dgvAdrese
			// 
			this.dgvAdrese.AllowUserToAddRows = false;
			this.dgvAdrese.AllowUserToDeleteRows = false;
			this.dgvAdrese.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvAdrese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAdrese.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdresaId,
            this.Drzava,
            this.PostanskiBroj,
            this.DrzavaNaziv,
            this.GradId,
            this.Naziv,
            this.GradNaziv,
            this.DrzavaId});
			this.dgvAdrese.Location = new System.Drawing.Point(64, 148);
			this.dgvAdrese.Name = "dgvAdrese";
			this.dgvAdrese.ReadOnly = true;
			this.dgvAdrese.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAdrese.Size = new System.Drawing.Size(352, 191);
			this.dgvAdrese.TabIndex = 6;
			this.dgvAdrese.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAdrese_CellMouseDoubleClick);
			// 
			// AdresaId
			// 
			this.AdresaId.DataPropertyName = "AdresaId";
			this.AdresaId.HeaderText = "AdresaId";
			this.AdresaId.Name = "AdresaId";
			this.AdresaId.ReadOnly = true;
			this.AdresaId.Visible = false;
			// 
			// Drzava
			// 
			this.Drzava.DataPropertyName = "Drzava";
			this.Drzava.HeaderText = "Drzava";
			this.Drzava.Name = "Drzava";
			this.Drzava.ReadOnly = true;
			this.Drzava.Visible = false;
			// 
			// PostanskiBroj
			// 
			this.PostanskiBroj.DataPropertyName = "PostanskiBroj";
			this.PostanskiBroj.HeaderText = "PostanskiBroj";
			this.PostanskiBroj.Name = "PostanskiBroj";
			this.PostanskiBroj.ReadOnly = true;
			this.PostanskiBroj.Visible = false;
			// 
			// DrzavaNaziv
			// 
			this.DrzavaNaziv.DataPropertyName = "DrzavaNaziv";
			this.DrzavaNaziv.HeaderText = "DrzavaNaziv";
			this.DrzavaNaziv.Name = "DrzavaNaziv";
			this.DrzavaNaziv.ReadOnly = true;
			this.DrzavaNaziv.Visible = false;
			// 
			// GradId
			// 
			this.GradId.DataPropertyName = "GradId";
			this.GradId.HeaderText = "GradId";
			this.GradId.Name = "GradId";
			this.GradId.ReadOnly = true;
			this.GradId.Visible = false;
			// 
			// Naziv
			// 
			this.Naziv.DataPropertyName = "Naziv";
			this.Naziv.HeaderText = "Adresa";
			this.Naziv.Name = "Naziv";
			this.Naziv.ReadOnly = true;
			// 
			// GradNaziv
			// 
			this.GradNaziv.DataPropertyName = "GradNaziv";
			this.GradNaziv.HeaderText = "Grad";
			this.GradNaziv.Name = "GradNaziv";
			this.GradNaziv.ReadOnly = true;
			// 
			// DrzavaId
			// 
			this.DrzavaId.DataPropertyName = "DrzavaId";
			this.DrzavaId.HeaderText = "DrzavaId";
			this.DrzavaId.Name = "DrzavaId";
			this.DrzavaId.ReadOnly = true;
			this.DrzavaId.Visible = false;
			// 
			// frmAdrese
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dgvAdrese);
			this.Controls.Add(this.btnPrikazi);
			this.Controls.Add(this.txtPretraga);
			this.Name = "frmAdrese";
			this.Text = "frmAdrese";
			this.Load += new System.EventHandler(this.frmAdrese_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAdrese)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPrikazi;
		private System.Windows.Forms.TextBox txtPretraga;
		private System.Windows.Forms.DataGridView dgvAdrese;
		private System.Windows.Forms.DataGridViewTextBoxColumn AdresaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
		private System.Windows.Forms.DataGridViewTextBoxColumn PostanskiBroj;
		private System.Windows.Forms.DataGridViewTextBoxColumn DrzavaNaziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn GradId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn GradNaziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn DrzavaId;
	}
}