namespace MyDentalCare.WinUI.Lijek
{
	partial class frmLijekDetalji
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
			this.Naziv = new System.Windows.Forms.Label();
			this.Uputstvo = new System.Windows.Forms.Label();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtUputstvo = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNaziv
			// 
			this.txtNaziv.Location = new System.Drawing.Point(89, 133);
			this.txtNaziv.Name = "txtNaziv";
			this.txtNaziv.Size = new System.Drawing.Size(294, 20);
			this.txtNaziv.TabIndex = 0;
			this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
			// 
			// Naziv
			// 
			this.Naziv.AutoSize = true;
			this.Naziv.Location = new System.Drawing.Point(89, 114);
			this.Naziv.Name = "Naziv";
			this.Naziv.Size = new System.Drawing.Size(61, 13);
			this.Naziv.TabIndex = 1;
			this.Naziv.Text = "Naziv lijeka";
			// 
			// Uputstvo
			// 
			this.Uputstvo.AutoSize = true;
			this.Uputstvo.Location = new System.Drawing.Point(89, 175);
			this.Uputstvo.Name = "Uputstvo";
			this.Uputstvo.Size = new System.Drawing.Size(112, 13);
			this.Uputstvo.TabIndex = 2;
			this.Uputstvo.Text = "Uputstvo za korištenje";
			// 
			// btnSnimi
			// 
			this.btnSnimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnSnimi.Location = new System.Drawing.Point(282, 308);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(101, 33);
			this.btnSnimi.TabIndex = 4;
			this.btnSnimi.Text = "Sačuvaj";
			this.btnSnimi.UseVisualStyleBackColor = false;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// txtUputstvo
			// 
			this.txtUputstvo.Location = new System.Drawing.Point(89, 195);
			this.txtUputstvo.Name = "txtUputstvo";
			this.txtUputstvo.Size = new System.Drawing.Size(294, 107);
			this.txtUputstvo.TabIndex = 5;
			this.txtUputstvo.Text = "";
			// 
			// frmLijekDetalji
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.txtUputstvo);
			this.Controls.Add(this.btnSnimi);
			this.Controls.Add(this.Uputstvo);
			this.Controls.Add(this.Naziv);
			this.Controls.Add(this.txtNaziv);
			this.Name = "frmLijekDetalji";
			this.Text = "frmLijekDetalji";
			this.Load += new System.EventHandler(this.frmLijekDetalji_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNaziv;
		private System.Windows.Forms.Label Naziv;
		private System.Windows.Forms.Label Uputstvo;
		private System.Windows.Forms.Button btnSnimi;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.RichTextBox txtUputstvo;
	}
}