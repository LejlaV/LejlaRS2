using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.WinUI.Clanak
{
	public partial class frmClanakDetalji : Form
	{
		private readonly APIService _clanak = new APIService("clanak");
		private readonly APIService _kateogorije = new APIService("kategorija");
		private readonly int? _Id = null;
		public frmClanakDetalji(int? clanakId = null)
		{
			InitializeComponent();
			_Id = clanakId;
		}
		private async Task LoadKategorije()
		{
			var result = await _kateogorije.Get<List<Model.Kategorija>>(null);
			cmbKategorije.DisplayMember = "Naziv";
			cmbKategorije.ValueMember = "KategorijaId";
			cmbKategorije.Text = "--- Odaberite kategoriju ---";
			cmbKategorije.DataSource = result;
		}
		private async void frmClanakDetalji_Load(object sender, EventArgs e)
		{
			if (_Id.HasValue)
			{
				await LoadKategorije();
				var clanak = await _clanak.GetById<Model.Clanak>(_Id);
				txtNaslov.Text = clanak.Naslov;
				txtSadrzaj.Text = clanak.Sadrzaj;
				txtSlikaInput.Text = clanak.Slika.ToString();
				if (clanak.Slika.Length != 0)
				{
					pictureBox.Image = BytesToImage(clanak.Slika);
				}
				else
				{
					pictureBox.Image = Properties.Resources.Noimage;
				}
			}
			else
			{
				var result = await _kateogorije.Get<List<Model.Kategorija>>(null);
				result.Insert(0, new Model.Kategorija());
				cmbKategorije.DisplayMember = "Naziv";
				cmbKategorije.ValueMember = "KategorijaId";
				cmbKategorije.DataSource = result;
			}
		}
		public Image BytesToImage(byte[] arr)
		{
			MemoryStream ms = new MemoryStream(arr);
			return Image.FromStream(ms);
		}
		ClanakUpsertRequest request = new ClanakUpsertRequest();
		private async void btnSnimi_Click(object sender, EventArgs e)
		{
			var idObj = cmbKategorije.SelectedValue;

			if (int.TryParse(idObj.ToString(), out int kategorijaId))
			{
				request.KategorijaId = kategorijaId;
			}
			
			if(this.ValidateChildren())
			{
				request.Naslov = txtNaslov.Text;
				request.Sadrzaj = txtSadrzaj.Text;
				request.DatumObjave = DateTime.Now;
				request.KorisnikId = 2002;
				if (!_Id.HasValue)
				{
					await _clanak.Insert<Model.Clanak>(request);
				}
				else
				{
					await _clanak.Update<Model.Clanak>(_Id, request);
				}
				MessageBox.Show("Operacija uspješna!");
			}
			else
			{
				MessageBox.Show("Operacija nije uspjela!");
				this.Close();
			}
		}

		private void btnDodajSliku_Click(object sender, EventArgs e)
		{
			var result = openFileDialog1.ShowDialog();

			if (result == DialogResult.OK)
			{
				var fileName = openFileDialog1.FileName;

				var file = File.ReadAllBytes(fileName);

				request.Slika = file;
				txtSlikaInput.Text = fileName;

				Image image = Image.FromFile(fileName);
				pictureBox.Image = image;
			}
		}

		private void txtNaslov_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNaslov.Text))
			{
				e.Cancel = true;
				errorProvider.SetError(txtNaslov, Properties.Resources.Validation_RequiredField);
			}
			else if (!Regex.IsMatch(txtNaslov.Text, @"[^A-Za-z0-9_.]"))
			{
				errorProvider.SetError(txtNaslov, "Nepravilan unos!");
				e.Cancel = true;
			}
			else
			{
				errorProvider.SetError(txtNaslov, null);
			}
		}

		private void txtSadrzaj_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtSadrzaj.Text))
			{
				e.Cancel = true;
				errorProvider.SetError(txtSadrzaj, Properties.Resources.Validation_RequiredField);
			}
			else if (!Regex.IsMatch(txtNaslov.Text, @"[^A-Za-z0-9_.]"))
			{
				errorProvider.SetError(txtNaslov, "Nepravilan unos!");
				e.Cancel = true;
			}
			else
			{
				errorProvider.SetError(txtSadrzaj, null);
			}
		}
	}
}
