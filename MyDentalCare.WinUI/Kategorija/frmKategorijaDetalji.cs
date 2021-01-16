using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.WinUI.Kategorija
{
	public partial class frmKategorijaDetalji : Form
	{
		private readonly APIService _apiService = new APIService("kategorija");
		private int? _Id = null;
		public frmKategorijaDetalji(int? KategorijaId = null)
		{
			InitializeComponent();
			_Id = KategorijaId;
		}

		private async void btnSnimi_Click(object sender, EventArgs e)
		{
				if (this.ValidateChildren())
				{
					var request = new KategorijaUpsertRequest()
					{
						Naziv = txtNaziv.Text,
					};

					if (!_Id.HasValue)
					{
						await _apiService.Insert<Model.Kategorija>(request);
					}
					else
					{
						await _apiService.Update<Model.Kategorija>(_Id, request);
					}
					MessageBox.Show("Operacija uspješna!");
					this.Close();
			}
			else
				{
				MessageBox.Show("Operacija nije uspjela!");
				this.Close();
				}
		}

		private void txtNaziv_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNaziv.Text))
			{
				e.Cancel = true;
				errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
			}
			else
			{
				errorProvider.SetError(txtNaziv, null);
			}
		}

		private async void frmKategorijaDetalji_Load(object sender, EventArgs e)
		{
			if(_Id.HasValue)
			{
				var kategorija = await _apiService.GetById<Model.Kategorija>(_Id);

				txtNaziv.Text = kategorija.Naziv;
			}
		}
	}
}
