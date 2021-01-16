namespace MyDentalCare.WinUI.Lokacije
{
	partial class frmGradovi
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
			this.dgvGradovi = new System.Windows.Forms.DataGridView();
			this.GradId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PostanskiBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DrzavaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DrzavaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPrikazi
			// 
			this.btnPrikazi.Location = new System.Drawing.Point(317, 109);
			this.btnPrikazi.Name = "btnPrikazi";
			this.btnPrikazi.Size = new System.Drawing.Size(102, 23);
			this.btnPrikazi.TabIndex = 3;
			this.btnPrikazi.Text = "Prikaži";
			this.btnPrikazi.UseVisualStyleBackColor = true;
			this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
			// 
			// txtPretraga
			// 
			this.txtPretraga.Location = new System.Drawing.Point(67, 109);
			this.txtPretraga.Name = "txtPretraga";
			this.txtPretraga.Size = new System.Drawing.Size(228, 20);
			this.txtPretraga.TabIndex = 2;
			// 
			// dgvGradovi
			// 
			this.dgvGradovi.AllowUserToAddRows = false;
			this.dgvGradovi.AllowUserToDeleteRows = false;
			this.dgvGradovi.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvGradovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGradovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradId,
            this.Naziv,
            this.PostanskiBroj,
            this.DrzavaNaziv,
            this.DrzavaId});
			this.dgvGradovi.Location = new System.Drawing.Point(67, 192);
			this.dgvGradovi.Name = "dgvGradovi";
			this.dgvGradovi.ReadOnly = true;
			this.dgvGradovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvGradovi.Size = new System.Drawing.Size(352, 191);
			this.dgvGradovi.TabIndex = 4;
			this.dgvGradovi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGradovi_CellMouseDoubleClick);
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
			this.Naziv.HeaderText = "Naziv";
			this.Naziv.Name = "Naziv";
			this.Naziv.ReadOnly = true;
			// 
			// PostanskiBroj
			// 
			this.PostanskiBroj.DataPropertyName = "PostanskiBroj";
			this.PostanskiBroj.HeaderText = "Poštanski broj";
			this.PostanskiBroj.Name = "PostanskiBroj";
			this.PostanskiBroj.ReadOnly = true;
			// 
			// DrzavaNaziv
			// 
			this.DrzavaNaziv.DataPropertyName = "DrzavaNaziv";
			this.DrzavaNaziv.HeaderText = "Država";
			this.DrzavaNaziv.Name = "DrzavaNaziv";
			this.DrzavaNaziv.ReadOnly = true;
			// 
			// DrzavaId
			// 
			this.DrzavaId.DataPropertyName = "DrzavaId";
			this.DrzavaId.HeaderText = "DrzavaId";
			this.DrzavaId.Name = "DrzavaId";
			this.DrzavaId.ReadOnly = true;
			this.DrzavaId.Visible = false;
			// 
			// frmGradovi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dgvGradovi);
			this.Controls.Add(this.btnPrikazi);
			this.Controls.Add(this.txtPretraga);
			this.Name = "frmGradovi";
			this.Text = "frmGradovi";
			this.Load += new System.EventHandler(this.frmGradovi_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPrikazi;
		private System.Windows.Forms.TextBox txtPretraga;
		private System.Windows.Forms.DataGridView dgvGradovi;
		private System.Windows.Forms.DataGridViewTextBoxColumn GradId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn PostanskiBroj;
		private System.Windows.Forms.DataGridViewTextBoxColumn DrzavaNaziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn DrzavaId;
	}
}