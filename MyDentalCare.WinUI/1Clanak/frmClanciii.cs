using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.WinUI.Clanak
{
	public partial class frmClanci : Form
	{
		private readonly APIService _clanak = new APIService("clanak");
		private readonly APIService _kateogorije = new APIService("kategorija");

		public frmClanci()
		{
			InitializeComponent();
		}
		private async Task LoadKategorije()
		{
			var result = await _kateogorije.Get<List<Model.Kategorija>>(null);
			result.Insert(0, new Model.Kategorija());
			cmbKategorije.DisplayMember = "Naziv";
			cmbKategorije.ValueMember = "KategorijaId";
			cmbKategorije.DataSource = result;
		}

		private async void frmClanci_Load(object sender, EventArgs e)
		{
			await LoadKategorije();
			var result = await _clanak.Get<List<Model.Clanak>>(null);
			dgvClanci.AutoGenerateColumns = false;
			dgvClanci.DataSource = result;
		}
		private async void cmbKategorije_SelectedIndexChanged(object sender, EventArgs e)
		{
			var idObj = cmbKategorije.SelectedValue;

			if (int.TryParse(idObj.ToString(), out int id))
			{
				await LoadClanci(id);
			}
		}

		private async Task LoadClanci(int kategorijaId)
		{
			var result = await _clanak.Get<List<Model.Clanak>>(new ClanakSearchRequest()
			{
				KategorijaId = kategorijaId
			});

			dgvClanci.DataSource = result;
		}

		ClanakUpsertRequest request = new ClanakUpsertRequest();

		private async void btnSnimi_Click(object sender, EventArgs e)
		{
			var idObj = cmbKategorije.SelectedValue;

			if(int.TryParse(idObj.ToString(), out int kategorijaId))
			{
				request.KategorijaId = kategorijaId;
			}
			request.Naslov = txtNaslov.Text;
			request.Sadrzaj = txtSadrzaj.Text;
			request.DatumObjave = DateTime.Now;
			request.KorisnikId = 1;

			await _clanak.Insert<Model.Clanak>(request);
			MessageBox.Show("Operacija uspješna!");
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
	}
}
