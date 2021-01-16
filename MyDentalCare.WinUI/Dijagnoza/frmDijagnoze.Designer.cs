namespace MyDentalCare.WinUI.Dijagnoza
{
	partial class frmDijagnoze
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
			this.dgvDijagnoze = new System.Windows.Forms.DataGridView();
			this.DijagnozaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvDijagnoze)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPretraga
			// 
			this.txtPretraga.Location = new System.Drawing.Point(92, 134);
			this.txtPretraga.Name = "txtPretraga";
			this.txtPretraga.Size = new System.Drawing.Size(237, 20);
			this.txtPretraga.TabIndex = 0;
			// 
			// btnPrikazi
			// 
			this.btnPrikazi.Location = new System.Drawing.Point(352, 134);
			this.btnPrikazi.Name = "btnPrikazi";
			this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
			this.btnPrikazi.TabIndex = 1;
			this.btnPrikazi.Text = "Prikaži";
			this.btnPrikazi.UseVisualStyleBackColor = true;
			this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
			// 
			// dgvDijagnoze
			// 
			this.dgvDijagnoze.AllowUserToAddRows = false;
			this.dgvDijagnoze.AllowUserToDeleteRows = false;
			this.dgvDijagnoze.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvDijagnoze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDijagnoze.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DijagnozaId,
            this.Naziv});
			this.dgvDijagnoze.Location = new System.Drawing.Point(92, 177);
			this.dgvDijagnoze.Name = "dgvDijagnoze";
			this.dgvDijagnoze.ReadOnly = true;
			this.dgvDijagnoze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDijagnoze.Size = new System.Drawing.Size(335, 191);
			this.dgvDijagnoze.TabIndex = 2;
			this.dgvDijagnoze.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDijagnoze_CellMouseDoubleClick);
			// 
			// DijagnozaId
			// 
			this.DijagnozaId.DataPropertyName = "DijagnozaId";
			this.DijagnozaId.HeaderText = "DijagnozaId";
			this.DijagnozaId.Name = "DijagnozaId";
			this.DijagnozaId.ReadOnly = true;
			this.DijagnozaId.Visible = false;
			// 
			// Naziv
			// 
			this.Naziv.DataPropertyName = "Naziv";
			this.Naziv.HeaderText = "Naziv";
			this.Naziv.Name = "Naziv";
			this.Naziv.ReadOnly = true;
			// 
			// frmDijagnoze
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dgvDijagnoze);
			this.Controls.Add(this.btnPrikazi);
			this.Controls.Add(this.txtPretraga);
			this.Name = "frmDijagnoze";
			this.Text = "frmDijagnoze";
			this.Load += new System.EventHandler(this.frmDijagnoze_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDijagnoze)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPretraga;
		private System.Windows.Forms.Button btnPrikazi;
		private System.Windows.Forms.DataGridView dgvDijagnoze;
		private System.Windows.Forms.DataGridViewTextBoxColumn DijagnozaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
	}
}