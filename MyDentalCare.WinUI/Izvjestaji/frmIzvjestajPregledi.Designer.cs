namespace MyDentalCare.WinUI.Izvjestaji
{
	partial class frmIzvjestajPregledi
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
			this.btnExportToPdf = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbMjesec = new System.Windows.Forms.ComboBox();
			this.dgvIzvjestajPregledi = new System.Windows.Forms.DataGridView();
			this.brojObavljenihPregleda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.brojDijagnoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtNajcescaDijagnoza = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNajcesciLijek = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestajPregledi)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExportToPdf
			// 
			this.btnExportToPdf.Location = new System.Drawing.Point(571, 431);
			this.btnExportToPdf.Name = "btnExportToPdf";
			this.btnExportToPdf.Size = new System.Drawing.Size(143, 29);
			this.btnExportToPdf.TabIndex = 7;
			this.btnExportToPdf.Text = "Preuzmi PDF";
			this.btnExportToPdf.UseVisualStyleBackColor = true;
			this.btnExportToPdf.Click += new System.EventHandler(this.btnExportToPdf_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(315, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Odaberi mjesec:";
			// 
			// cmbMjesec
			// 
			this.cmbMjesec.FormattingEnabled = true;
			this.cmbMjesec.Location = new System.Drawing.Point(487, 128);
			this.cmbMjesec.Name = "cmbMjesec";
			this.cmbMjesec.Size = new System.Drawing.Size(227, 21);
			this.cmbMjesec.TabIndex = 5;
			this.cmbMjesec.SelectedIndexChanged += new System.EventHandler(this.cmbMjesec_SelectedIndexChanged);
			// 
			// dgvIzvjestajPregledi
			// 
			this.dgvIzvjestajPregledi.AllowUserToAddRows = false;
			this.dgvIzvjestajPregledi.AllowUserToDeleteRows = false;
			this.dgvIzvjestajPregledi.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvIzvjestajPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIzvjestajPregledi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojObavljenihPregleda,
            this.brojDijagnoza});
			this.dgvIzvjestajPregledi.Location = new System.Drawing.Point(318, 184);
			this.dgvIzvjestajPregledi.Name = "dgvIzvjestajPregledi";
			this.dgvIzvjestajPregledi.ReadOnly = true;
			this.dgvIzvjestajPregledi.Size = new System.Drawing.Size(396, 84);
			this.dgvIzvjestajPregledi.TabIndex = 8;
			// 
			// brojObavljenihPregleda
			// 
			this.brojObavljenihPregleda.DataPropertyName = "brojObavljenihPregleda";
			this.brojObavljenihPregleda.HeaderText = "Broj obavljenih pregleda";
			this.brojObavljenihPregleda.Name = "brojObavljenihPregleda";
			this.brojObavljenihPregleda.ReadOnly = true;
			// 
			// brojDijagnoza
			// 
			this.brojDijagnoza.DataPropertyName = "brojDijagnoza";
			this.brojDijagnoza.HeaderText = "Broj postavljenih dijagnoza";
			this.brojDijagnoza.Name = "brojDijagnoza";
			this.brojDijagnoza.ReadOnly = true;
			// 
			// txtNajcescaDijagnoza
			// 
			this.txtNajcescaDijagnoza.Location = new System.Drawing.Point(487, 322);
			this.txtNajcescaDijagnoza.Name = "txtNajcescaDijagnoza";
			this.txtNajcescaDijagnoza.Size = new System.Drawing.Size(227, 20);
			this.txtNajcescaDijagnoza.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(318, 325);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Najčešće postavljena dijagnoza: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(318, 371);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Najčešće propisani lijek: ";
			// 
			// txtNajcesciLijek
			// 
			this.txtNajcesciLijek.Location = new System.Drawing.Point(487, 368);
			this.txtNajcesciLijek.Name = "txtNajcesciLijek";
			this.txtNajcesciLijek.Size = new System.Drawing.Size(227, 20);
			this.txtNajcesciLijek.TabIndex = 11;
			// 
			// frmIzvjestajPregledi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNajcesciLijek);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNajcescaDijagnoza);
			this.Controls.Add(this.dgvIzvjestajPregledi);
			this.Controls.Add(this.btnExportToPdf);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbMjesec);
			this.Name = "frmIzvjestajPregledi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmIzvjestajPregledi";
			this.Load += new System.EventHandler(this.frmIzvjestajPregledi_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestajPregledi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExportToPdf;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbMjesec;
		private System.Windows.Forms.DataGridView dgvIzvjestajPregledi;
		private System.Windows.Forms.DataGridViewTextBoxColumn brojObavljenihPregleda;
		private System.Windows.Forms.DataGridViewTextBoxColumn brojDijagnoza;
		private System.Windows.Forms.TextBox txtNajcescaDijagnoza;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNajcesciLijek;
	}
}