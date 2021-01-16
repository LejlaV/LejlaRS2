namespace MyDentalCare.WinUI.Usluge
{
	partial class frmUslugaDetalji
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
			this.txtNaziv = new System.Windows.Forms.TextBox();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.numCijena = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCijena)).BeginInit();
			this.SuspendLayout();
			// 
			// Naziv
			// 
			this.Naziv.AutoSize = true;
			this.Naziv.Location = new System.Drawing.Point(118, 135);
			this.Naziv.Name = "Naziv";
			this.Naziv.Size = new System.Drawing.Size(34, 13);
			this.Naziv.TabIndex = 0;
			this.Naziv.Text = "Naziv";
			// 
			// txtNaziv
			// 
			this.txtNaziv.Location = new System.Drawing.Point(121, 162);
			this.txtNaziv.Name = "txtNaziv";
			this.txtNaziv.Size = new System.Drawing.Size(230, 20);
			this.txtNaziv.TabIndex = 1;
			// 
			// btnSnimi
			// 
			this.btnSnimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnSnimi.Location = new System.Drawing.Point(266, 296);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(85, 28);
			this.btnSnimi.TabIndex = 2;
			this.btnSnimi.Text = "Sačuvaj";
			this.btnSnimi.UseVisualStyleBackColor = false;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(118, 208);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Cijena";
			// 
			// numCijena
			// 
			this.numCijena.Location = new System.Drawing.Point(121, 239);
			this.numCijena.Name = "numCijena";
			this.numCijena.Size = new System.Drawing.Size(230, 20);
			this.numCijena.TabIndex = 5;
			// 
			// frmUslugaDetalji
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.numCijena);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSnimi);
			this.Controls.Add(this.txtNaziv);
			this.Controls.Add(this.Naziv);
			this.Name = "frmUslugaDetalji";
			this.Text = "frmUslugaDetalji";
			this.Load += new System.EventHandler(this.frmUslugaDetalji_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCijena)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Naziv;
		private System.Windows.Forms.TextBox txtNaziv;
		private System.Windows.Forms.Button btnSnimi;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numCijena;
	}
}