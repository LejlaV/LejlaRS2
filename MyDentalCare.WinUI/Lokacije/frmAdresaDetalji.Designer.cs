namespace MyDentalCare.WinUI.Lokacije
{
	partial class frmAdresaDetalji
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
			this.cmbGrad = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Naziv = new System.Windows.Forms.Label();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.txtNaziv = new System.Windows.Forms.TextBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbGrad
			// 
			this.cmbGrad.FormattingEnabled = true;
			this.cmbGrad.Location = new System.Drawing.Point(107, 196);
			this.cmbGrad.Name = "cmbGrad";
			this.cmbGrad.Size = new System.Drawing.Size(260, 21);
			this.cmbGrad.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(107, 166);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Grad";
			// 
			// Naziv
			// 
			this.Naziv.AutoSize = true;
			this.Naziv.Location = new System.Drawing.Point(107, 105);
			this.Naziv.Name = "Naziv";
			this.Naziv.Size = new System.Drawing.Size(69, 13);
			this.Naziv.TabIndex = 12;
			this.Naziv.Text = "Naziv adrese";
			// 
			// btnSnimi
			// 
			this.btnSnimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnSnimi.Location = new System.Drawing.Point(268, 252);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(99, 27);
			this.btnSnimi.TabIndex = 11;
			this.btnSnimi.Text = "Sačuvaj";
			this.btnSnimi.UseVisualStyleBackColor = false;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// txtNaziv
			// 
			this.txtNaziv.Location = new System.Drawing.Point(107, 124);
			this.txtNaziv.Name = "txtNaziv";
			this.txtNaziv.Size = new System.Drawing.Size(260, 20);
			this.txtNaziv.TabIndex = 10;
			this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// frmAdresaDetalji
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.cmbGrad);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Naziv);
			this.Controls.Add(this.btnSnimi);
			this.Controls.Add(this.txtNaziv);
			this.Name = "frmAdresaDetalji";
			this.Text = "frmAdresaDetalji";
			this.Load += new System.EventHandler(this.frmAdresaDetalji_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbGrad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Naziv;
		private System.Windows.Forms.Button btnSnimi;
		private System.Windows.Forms.TextBox txtNaziv;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}