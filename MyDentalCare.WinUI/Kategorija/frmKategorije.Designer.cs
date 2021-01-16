namespace MyDentalCare.WinUI.Kategorija
{
	partial class frmKategorije
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
			this.txtPretraga = new System.Windows.Forms.TextBox();
			this.btnPrikazi = new System.Windows.Forms.Button();
			this.dgvKategorije = new System.Windows.Forms.DataGridView();
			this.KategorijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPretraga
			// 
			this.txtPretraga.Location = new System.Drawing.Point(93, 102);
			this.txtPretraga.Name = "txtPretraga";
			this.txtPretraga.Size = new System.Drawing.Size(331, 20);
			this.txtPretraga.TabIndex = 0;
			// 
			// btnPrikazi
			// 
			this.btnPrikazi.Location = new System.Drawing.Point(448, 102);
			this.btnPrikazi.Name = "btnPrikazi";
			this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
			this.btnPrikazi.TabIndex = 1;
			this.btnPrikazi.Text = "Prikaži";
			this.btnPrikazi.UseVisualStyleBackColor = true;
			this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
			// 
			// dgvKategorije
			// 
			this.dgvKategorije.AllowUserToAddRows = false;
			this.dgvKategorije.AllowUserToDeleteRows = false;
			this.dgvKategorije.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKategorije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KategorijaId,
            this.Naziv});
			this.dgvKategorije.Location = new System.Drawing.Point(93, 144);
			this.dgvKategorije.Name = "dgvKategorije";
			this.dgvKategorije.ReadOnly = true;
			this.dgvKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvKategorije.Size = new System.Drawing.Size(430, 203);
			this.dgvKategorije.TabIndex = 2;
			this.dgvKategorije.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKategorije_CellMouseDoubleClick);
			// 
			// KategorijaId
			// 
			this.KategorijaId.DataPropertyName = "KategorijaId";
			this.KategorijaId.HeaderText = "KategorijaId";
			this.KategorijaId.Name = "KategorijaId";
			this.KategorijaId.ReadOnly = true;
			this.KategorijaId.Visible = false;
			// 
			// Naziv
			// 
			this.Naziv.DataPropertyName = "Naziv";
			this.Naziv.HeaderText = "Naziv";
			this.Naziv.Name = "Naziv";
			this.Naziv.ReadOnly = true;
			// 
			// frmKategorije
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dgvKategorije);
			this.Controls.Add(this.btnPrikazi);
			this.Controls.Add(this.txtPretraga);
			this.Name = "frmKategorije";
			this.Text = "frmKategorije";
			this.Load += new System.EventHandler(this.frmKategorije_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPretraga;
		private System.Windows.Forms.Button btnPrikazi;
		private System.Windows.Forms.DataGridView dgvKategorije;
		private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
	}
}