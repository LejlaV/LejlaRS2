namespace MyDentalCare.WinUI.Usluge
{
	partial class frmUsluge
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
			this.txtPrikazi = new System.Windows.Forms.Button();
			this.dgvUsluge = new System.Windows.Forms.DataGridView();
			this.UslugaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPretraga
			// 
			this.txtPretraga.Location = new System.Drawing.Point(123, 131);
			this.txtPretraga.Name = "txtPretraga";
			this.txtPretraga.Size = new System.Drawing.Size(176, 20);
			this.txtPretraga.TabIndex = 0;
			// 
			// txtPrikazi
			// 
			this.txtPrikazi.Location = new System.Drawing.Point(321, 131);
			this.txtPrikazi.Name = "txtPrikazi";
			this.txtPrikazi.Size = new System.Drawing.Size(105, 23);
			this.txtPrikazi.TabIndex = 1;
			this.txtPrikazi.Text = "Prikaži";
			this.txtPrikazi.UseVisualStyleBackColor = true;
			this.txtPrikazi.Click += new System.EventHandler(this.txtPrikazi_Click);
			// 
			// dgvUsluge
			// 
			this.dgvUsluge.AllowUserToAddRows = false;
			this.dgvUsluge.AllowUserToDeleteRows = false;
			this.dgvUsluge.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsluge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UslugaId,
            this.Cijena,
            this.Naziv});
			this.dgvUsluge.Location = new System.Drawing.Point(123, 175);
			this.dgvUsluge.Name = "dgvUsluge";
			this.dgvUsluge.ReadOnly = true;
			this.dgvUsluge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsluge.Size = new System.Drawing.Size(303, 289);
			this.dgvUsluge.TabIndex = 2;
			this.dgvUsluge.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsluge_CellMouseDoubleClick);
			// 
			// UslugaId
			// 
			this.UslugaId.DataPropertyName = "UslugaId";
			this.UslugaId.HeaderText = "UslugaId";
			this.UslugaId.Name = "UslugaId";
			this.UslugaId.ReadOnly = true;
			this.UslugaId.Visible = false;
			// 
			// Cijena
			// 
			this.Cijena.DataPropertyName = "Cijena";
			this.Cijena.HeaderText = "Cijena";
			this.Cijena.Name = "Cijena";
			this.Cijena.ReadOnly = true;
			// 
			// Naziv
			// 
			this.Naziv.DataPropertyName = "Naziv";
			this.Naziv.HeaderText = "Naziv";
			this.Naziv.Name = "Naziv";
			this.Naziv.ReadOnly = true;
			// 
			// frmUsluge
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dgvUsluge);
			this.Controls.Add(this.txtPrikazi);
			this.Controls.Add(this.txtPretraga);
			this.Name = "frmUsluge";
			this.Text = "frmUsluge";
			this.Load += new System.EventHandler(this.frmUsluge_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPretraga;
		private System.Windows.Forms.Button txtPrikazi;
		private System.Windows.Forms.DataGridView dgvUsluge;
		private System.Windows.Forms.DataGridViewTextBoxColumn UslugaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
	}
}