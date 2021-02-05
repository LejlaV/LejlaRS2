namespace MyDentalCare.WinUI.MedicinskiKarton
{
	partial class frmMedicinskiKartonDetalji
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
			this.txtOpis = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Pacijenti = new System.Windows.Forms.Label();
			this.cmbPacijent = new System.Windows.Forms.ComboBox();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// txtOpis
			// 
			this.txtOpis.Location = new System.Drawing.Point(179, 203);
			this.txtOpis.Name = "txtOpis";
			this.txtOpis.Size = new System.Drawing.Size(231, 96);
			this.txtOpis.TabIndex = 23;
			this.txtOpis.Text = "";
			this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(80, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 22;
			this.label3.Text = "Opis";
			// 
			// Pacijenti
			// 
			this.Pacijenti.AutoSize = true;
			this.Pacijenti.Location = new System.Drawing.Point(80, 146);
			this.Pacijenti.Name = "Pacijenti";
			this.Pacijenti.Size = new System.Drawing.Size(45, 13);
			this.Pacijenti.TabIndex = 29;
			this.Pacijenti.Text = "Pacijent";
			// 
			// cmbPacijent
			// 
			this.cmbPacijent.FormattingEnabled = true;
			this.cmbPacijent.Location = new System.Drawing.Point(179, 143);
			this.cmbPacijent.Name = "cmbPacijent";
			this.cmbPacijent.Size = new System.Drawing.Size(231, 21);
			this.cmbPacijent.TabIndex = 28;
			// 
			// btnSnimi
			// 
			this.btnSnimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnSnimi.Location = new System.Drawing.Point(335, 348);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(75, 23);
			this.btnSnimi.TabIndex = 32;
			this.btnSnimi.Text = "Sačuvaj";
			this.btnSnimi.UseVisualStyleBackColor = false;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// frmMedicinskiKartonDetalji
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.btnSnimi);
			this.Controls.Add(this.Pacijenti);
			this.Controls.Add(this.cmbPacijent);
			this.Controls.Add(this.txtOpis);
			this.Controls.Add(this.label3);
			this.Name = "frmMedicinskiKartonDetalji";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmMedicinskiKartonDetalji";
			this.Load += new System.EventHandler(this.frmMedicinskiKartonDetalji_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtOpis;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label Pacijenti;
		private System.Windows.Forms.ComboBox cmbPacijent;
		private System.Windows.Forms.Button btnSnimi;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}