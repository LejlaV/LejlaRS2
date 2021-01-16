namespace MyDentalCare.WinUI.Rezervacija
{
	partial class frmRezervacijaDetalji
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
			this.Usluge = new System.Windows.Forms.Label();
			this.Pacijenti = new System.Windows.Forms.Label();
			this.cmbUsluge = new System.Windows.Forms.ComboBox();
			this.cmbPacijent = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRazlog = new System.Windows.Forms.TextBox();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.dateTimeRezervacija = new System.Windows.Forms.DateTimePicker();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// Usluge
			// 
			this.Usluge.AutoSize = true;
			this.Usluge.Location = new System.Drawing.Point(111, 178);
			this.Usluge.Name = "Usluge";
			this.Usluge.Size = new System.Drawing.Size(40, 13);
			this.Usluge.TabIndex = 7;
			this.Usluge.Text = "Usluge";
			// 
			// Pacijenti
			// 
			this.Pacijenti.AutoSize = true;
			this.Pacijenti.Location = new System.Drawing.Point(111, 136);
			this.Pacijenti.Name = "Pacijenti";
			this.Pacijenti.Size = new System.Drawing.Size(47, 13);
			this.Pacijenti.TabIndex = 6;
			this.Pacijenti.Text = "Pacijenti";
			// 
			// cmbUsluge
			// 
			this.cmbUsluge.FormattingEnabled = true;
			this.cmbUsluge.Location = new System.Drawing.Point(210, 178);
			this.cmbUsluge.Name = "cmbUsluge";
			this.cmbUsluge.Size = new System.Drawing.Size(231, 21);
			this.cmbUsluge.TabIndex = 5;
			// 
			// cmbPacijent
			// 
			this.cmbPacijent.FormattingEnabled = true;
			this.cmbPacijent.Location = new System.Drawing.Point(210, 133);
			this.cmbPacijent.Name = "cmbPacijent";
			this.cmbPacijent.Size = new System.Drawing.Size(231, 21);
			this.cmbPacijent.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(111, 222);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Datum i vrijeme";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(111, 264);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Razlog";
			// 
			// txtRazlog
			// 
			this.txtRazlog.Location = new System.Drawing.Point(210, 261);
			this.txtRazlog.Name = "txtRazlog";
			this.txtRazlog.Size = new System.Drawing.Size(231, 20);
			this.txtRazlog.TabIndex = 10;
			this.txtRazlog.Validating += new System.ComponentModel.CancelEventHandler(this.txtRazlog_Validating);
			// 
			// btnSnimi
			// 
			this.btnSnimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnSnimi.Location = new System.Drawing.Point(341, 309);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(100, 24);
			this.btnSnimi.TabIndex = 12;
			this.btnSnimi.Text = "Sačuvaj";
			this.btnSnimi.UseVisualStyleBackColor = false;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// dateTimeRezervacija
			// 
			this.dateTimeRezervacija.Location = new System.Drawing.Point(210, 222);
			this.dateTimeRezervacija.Name = "dateTimeRezervacija";
			this.dateTimeRezervacija.Size = new System.Drawing.Size(231, 20);
			this.dateTimeRezervacija.TabIndex = 13;
			this.dateTimeRezervacija.Value = new System.DateTime(2020, 11, 2, 18, 41, 47, 0);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// frmRezervacijaDetalji
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.dateTimeRezervacija);
			this.Controls.Add(this.btnSnimi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtRazlog);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Usluge);
			this.Controls.Add(this.Pacijenti);
			this.Controls.Add(this.cmbUsluge);
			this.Controls.Add(this.cmbPacijent);
			this.Name = "frmRezervacijaDetalji";
			this.Text = "frmRezervacijaDetalji";
			this.Load += new System.EventHandler(this.frmRezervacijaDetalji_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Usluge;
		private System.Windows.Forms.Label Pacijenti;
		private System.Windows.Forms.ComboBox cmbUsluge;
		private System.Windows.Forms.ComboBox cmbPacijent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRazlog;
		private System.Windows.Forms.Button btnSnimi;
		private System.Windows.Forms.DateTimePicker dateTimeRezervacija;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}