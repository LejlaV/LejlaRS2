namespace MyDentalCare.WinUI.Lokacije
{
	partial class frmDrzave
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
			this.dgvDrzave = new System.Windows.Forms.DataGridView();
			this.DrzavaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvDrzave)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDrzave
			// 
			this.dgvDrzave.AllowUserToAddRows = false;
			this.dgvDrzave.AllowUserToDeleteRows = false;
			this.dgvDrzave.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvDrzave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDrzave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrzavaId,
            this.Naziv});
			this.dgvDrzave.Location = new System.Drawing.Point(111, 91);
			this.dgvDrzave.Name = "dgvDrzave";
			this.dgvDrzave.ReadOnly = true;
			this.dgvDrzave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDrzave.Size = new System.Drawing.Size(314, 254);
			this.dgvDrzave.TabIndex = 3;
			// 
			// DrzavaId
			// 
			this.DrzavaId.DataPropertyName = "DrzavaId";
			this.DrzavaId.HeaderText = "DrzavaId";
			this.DrzavaId.Name = "DrzavaId";
			this.DrzavaId.ReadOnly = true;
			this.DrzavaId.Visible = false;
			// 
			// Naziv
			// 
			this.Naziv.DataPropertyName = "Naziv";
			this.Naziv.HeaderText = "Naziv";
			this.Naziv.Name = "Naziv";
			this.Naziv.ReadOnly = true;
			// 
			// frmDrzave
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dgvDrzave);
			this.Name = "frmDrzave";
			this.Text = "frmDrzave";
			this.Load += new System.EventHandler(this.frmDrzave_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDrzave)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvDrzave;
		private System.Windows.Forms.DataGridViewTextBoxColumn DrzavaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
	}
}