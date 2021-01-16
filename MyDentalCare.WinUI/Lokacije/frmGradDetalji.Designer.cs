namespace MyDentalCare.WinUI.Lokacije
{
	partial class frmGradDetalji
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
			this.Naziv = new System.Windows.Forms.Label();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.txtNaziv = new System.Windows.Forms.TextBox();
			this.PostanskiBroj = new System.Windows.Forms.Label();
			this.txtPostanskiBroj = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbDrzava = new System.Windows.Forms.ComboBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// Naziv
			// 
			this.Naziv.AutoSize = true;
			this.Naziv.Location = new System.Drawing.Point(85, 95);
			this.Naziv.Name = "Naziv";
			this.Naziv.Size = new System.Drawing.Size(64, 13);
			this.Naziv.TabIndex = 5;
			this.Naziv.Text = "Naziv grada";
			// 
			// btnSnimi
			// 
			this.btnSnimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnSnimi.Location = new System.Drawing.Point(246, 313);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(99, 27);
			this.btnSnimi.TabIndex = 4;
			this.btnSnimi.Text = "Sačuvaj";
			this.btnSnimi.UseVisualStyleBackColor = false;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// txtNaziv
			// 
			this.txtNaziv.Location = new System.Drawing.Point(85, 114);
			this.txtNaziv.Name = "txtNaziv";
			this.txtNaziv.Size = new System.Drawing.Size(260, 20);
			this.txtNaziv.TabIndex = 3;
			this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
			// 
			// PostanskiBroj
			// 
			this.PostanskiBroj.AutoSize = true;
			this.PostanskiBroj.Location = new System.Drawing.Point(85, 157);
			this.PostanskiBroj.Name = "PostanskiBroj";
			this.PostanskiBroj.Size = new System.Drawing.Size(73, 13);
			this.PostanskiBroj.TabIndex = 6;
			this.PostanskiBroj.Text = "Poštanski broj";
			// 
			// txtPostanskiBroj
			// 
			this.txtPostanskiBroj.Location = new System.Drawing.Point(85, 183);
			this.txtPostanskiBroj.Name = "txtPostanskiBroj";
			this.txtPostanskiBroj.Size = new System.Drawing.Size(260, 20);
			this.txtPostanskiBroj.TabIndex = 7;
			this.txtPostanskiBroj.Validating += new System.ComponentModel.CancelEventHandler(this.txtPostanskiBroj_Validating);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(85, 221);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Država";
			// 
			// cmbDrzava
			// 
			this.cmbDrzava.FormattingEnabled = true;
			this.cmbDrzava.Location = new System.Drawing.Point(85, 251);
			this.cmbDrzava.Name = "cmbDrzava";
			this.cmbDrzava.Size = new System.Drawing.Size(260, 21);
			this.cmbDrzava.TabIndex = 9;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// frmGradDetalji
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.cmbDrzava);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPostanskiBroj);
			this.Controls.Add(this.PostanskiBroj);
			this.Controls.Add(this.Naziv);
			this.Controls.Add(this.btnSnimi);
			this.Controls.Add(this.txtNaziv);
			this.Name = "frmGradDetalji";
			this.Text = "frmGradDetalji";
			this.Load += new System.EventHandler(this.frmGradDetalji_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Naziv;
		private System.Windows.Forms.Button btnSnimi;
		private System.Windows.Forms.TextBox txtNaziv;
		private System.Windows.Forms.Label PostanskiBroj;
		private System.Windows.Forms.TextBox txtPostanskiBroj;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbDrzava;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}