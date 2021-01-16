namespace MyDentalCare.WinUI.Dijagnoza
{
	partial class frmDijagnozaDetalji
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
			this.txtNaziv = new System.Windows.Forms.TextBox();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.Naziv = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNaziv
			// 
			this.txtNaziv.Location = new System.Drawing.Point(142, 167);
			this.txtNaziv.Name = "txtNaziv";
			this.txtNaziv.Size = new System.Drawing.Size(260, 20);
			this.txtNaziv.TabIndex = 0;
			this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
			// 
			// btnSnimi
			// 
			this.btnSnimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnSnimi.Location = new System.Drawing.Point(303, 207);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(99, 27);
			this.btnSnimi.TabIndex = 1;
			this.btnSnimi.Text = "Sačuvaj";
			this.btnSnimi.UseVisualStyleBackColor = false;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// Naziv
			// 
			this.Naziv.AutoSize = true;
			this.Naziv.Location = new System.Drawing.Point(142, 148);
			this.Naziv.Name = "Naziv";
			this.Naziv.Size = new System.Drawing.Size(82, 13);
			this.Naziv.TabIndex = 2;
			this.Naziv.Text = "Naziv dijagnoze";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// frmDijagnozaDetalji
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.Naziv);
			this.Controls.Add(this.btnSnimi);
			this.Controls.Add(this.txtNaziv);
			this.Name = "frmDijagnozaDetalji";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmDijagnozaDetalji";
			this.Load += new System.EventHandler(this.frmDijagnozaDetalji_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNaziv;
		private System.Windows.Forms.Button btnSnimi;
		private System.Windows.Forms.Label Naziv;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}