namespace MyDentalCare.WinUI.Lijek
{
	partial class frmLijekovi
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
			this.dgvLijekovi = new System.Windows.Forms.DataGridView();
			this.LijekId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Uputstvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPretraga
			// 
			this.txtPretraga.Location = new System.Drawing.Point(122, 107);
			this.txtPretraga.Name = "txtPretraga";
			this.txtPretraga.Size = new System.Drawing.Size(232, 20);
			this.txtPretraga.TabIndex = 0;
			// 
			// btnPrikazi
			// 
			this.btnPrikazi.Location = new System.Drawing.Point(373, 107);
			this.btnPrikazi.Name = "btnPrikazi";
			this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
			this.btnPrikazi.TabIndex = 1;
			this.btnPrikazi.Text = "Prikaži";
			this.btnPrikazi.UseVisualStyleBackColor = true;
			this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
			// 
			// dgvLijekovi
			// 
			this.dgvLijekovi.AllowUserToAddRows = false;
			this.dgvLijekovi.AllowUserToDeleteRows = false;
			this.dgvLijekovi.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLijekovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LijekId,
            this.Naziv,
            this.Uputstvo});
			this.dgvLijekovi.GridColor = System.Drawing.SystemColors.Window;
			this.dgvLijekovi.Location = new System.Drawing.Point(121, 150);
			this.dgvLijekovi.Name = "dgvLijekovi";
			this.dgvLijekovi.RowHeadersWidth = 21;
			this.dgvLijekovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLijekovi.Size = new System.Drawing.Size(327, 317);
			this.dgvLijekovi.TabIndex = 2;
			this.dgvLijekovi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLijekovi_CellMouseDoubleClick);
			// 
			// LijekId
			// 
			this.LijekId.DataPropertyName = "LijekId";
			this.LijekId.HeaderText = "LijekId";
			this.LijekId.Name = "LijekId";
			this.LijekId.Visible = false;
			// 
			// Naziv
			// 
			this.Naziv.DataPropertyName = "Naziv";
			this.Naziv.HeaderText = "Naziv";
			this.Naziv.Name = "Naziv";
			this.Naziv.ReadOnly = true;
			// 
			// Uputstvo
			// 
			this.Uputstvo.DataPropertyName = "Uputstvo";
			this.Uputstvo.HeaderText = "Uputstvo";
			this.Uputstvo.Name = "Uputstvo";
			this.Uputstvo.ReadOnly = true;
			// 
			// frmLijekovi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dgvLijekovi);
			this.Controls.Add(this.btnPrikazi);
			this.Controls.Add(this.txtPretraga);
			this.Name = "frmLijekovi";
			this.Text = "frmLijekovi";
			this.Load += new System.EventHandler(this.frmLijekovi_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPretraga;
		private System.Windows.Forms.Button btnPrikazi;
		private System.Windows.Forms.DataGridView dgvLijekovi;
		private System.Windows.Forms.DataGridViewTextBoxColumn LijekId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
		private System.Windows.Forms.DataGridViewTextBoxColumn Uputstvo;
	}
}