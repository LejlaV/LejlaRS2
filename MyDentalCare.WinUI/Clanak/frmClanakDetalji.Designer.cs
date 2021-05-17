namespace MyDentalCare.WinUI.Clanak
{
	partial class frmClanakDetalji
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
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.btnSnimi = new System.Windows.Forms.Button();
			this.btnDodajSliku = new System.Windows.Forms.Button();
			this.txtSlikaInput = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSadrzaj = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Naziv = new System.Windows.Forms.Label();
			this.txtNaslov = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbKategorije = new System.Windows.Forms.ComboBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(748, 137);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(155, 181);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox.TabIndex = 26;
			this.pictureBox.TabStop = false;
			// 
			// btnSnimi
			// 
			this.btnSnimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnSnimi.Location = new System.Drawing.Point(748, 341);
			this.btnSnimi.Name = "btnSnimi";
			this.btnSnimi.Size = new System.Drawing.Size(155, 23);
			this.btnSnimi.TabIndex = 25;
			this.btnSnimi.Text = "Sačuvaj";
			this.btnSnimi.UseVisualStyleBackColor = false;
			this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
			// 
			// btnDodajSliku
			// 
			this.btnDodajSliku.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnDodajSliku.Location = new System.Drawing.Point(531, 341);
			this.btnDodajSliku.Name = "btnDodajSliku";
			this.btnDodajSliku.Size = new System.Drawing.Size(80, 23);
			this.btnDodajSliku.TabIndex = 24;
			this.btnDodajSliku.Text = "Dodaj sliku";
			this.btnDodajSliku.UseVisualStyleBackColor = false;
			this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
			// 
			// txtSlikaInput
			// 
			this.txtSlikaInput.Location = new System.Drawing.Point(255, 341);
			this.txtSlikaInput.Name = "txtSlikaInput";
			this.txtSlikaInput.Size = new System.Drawing.Size(255, 20);
			this.txtSlikaInput.TabIndex = 23;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(157, 339);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 22;
			this.label4.Text = "Slika:";
			// 
			// txtSadrzaj
			// 
			this.txtSadrzaj.Location = new System.Drawing.Point(255, 212);
			this.txtSadrzaj.Name = "txtSadrzaj";
			this.txtSadrzaj.Size = new System.Drawing.Size(255, 106);
			this.txtSadrzaj.TabIndex = 21;
			this.txtSadrzaj.Text = "";
			this.txtSadrzaj.Validating += new System.ComponentModel.CancelEventHandler(this.txtSadrzaj_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(157, 212);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 20;
			this.label2.Text = "Sadržaj:";
			// 
			// Naziv
			// 
			this.Naziv.AutoSize = true;
			this.Naziv.Location = new System.Drawing.Point(157, 175);
			this.Naziv.Name = "Naziv";
			this.Naziv.Size = new System.Drawing.Size(43, 13);
			this.Naziv.TabIndex = 19;
			this.Naziv.Text = "Naslov:";
			// 
			// txtNaslov
			// 
			this.txtNaslov.Location = new System.Drawing.Point(255, 175);
			this.txtNaslov.Name = "txtNaslov";
			this.txtNaslov.Size = new System.Drawing.Size(255, 20);
			this.txtNaslov.TabIndex = 18;
			this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaslov_Validating);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(157, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "Kategorija članka:";
			// 
			// cmbKategorije
			// 
			this.cmbKategorije.FormattingEnabled = true;
			this.cmbKategorije.Location = new System.Drawing.Point(255, 137);
			this.cmbKategorije.Name = "cmbKategorije";
			this.cmbKategorije.Size = new System.Drawing.Size(255, 21);
			this.cmbKategorije.TabIndex = 16;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// frmClanakDetalji
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1080, 710);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.btnSnimi);
			this.Controls.Add(this.btnDodajSliku);
			this.Controls.Add(this.txtSlikaInput);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSadrzaj);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Naziv);
			this.Controls.Add(this.txtNaslov);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbKategorije);
			this.Name = "frmClanakDetalji";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmClanakDetalji";
			this.Load += new System.EventHandler(this.frmClanakDetalji_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button btnSnimi;
		private System.Windows.Forms.Button btnDodajSliku;
		private System.Windows.Forms.TextBox txtSlikaInput;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox txtSadrzaj;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Naziv;
		private System.Windows.Forms.TextBox txtNaslov;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbKategorije;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}