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

namespace MyDentalCare.WinUI.Lokacije
{
	public partial class frmAdresaDetalji : Form
	{
		private readonly APIService _apiService = new APIService("adresa");
		private readonly APIService _gradovi = new APIService("grad");
		private readonly int? _Id = null;
		public frmAdresaDetalji(int? adresaId=null)
		{
			InitializeComponent();
			_Id = adresaId;
		}

		private async void frmAdresaDetalji_Load(object sender, EventArgs e)
		{
			if (_Id.HasValue)
			{
				await LoadGradove();
				var adresa = await _apiService.GetById<Model.Adresa>(_Id);
				txtNaziv.Text = adresa.Naziv;
			}
			else
			{
				var result = await _gradovi.Get<List<Model.Grad>>(null);
				result.Insert(0, new Model.Grad());
				cmbGrad.DisplayMember = "Naziv";
				cmbGrad.ValueMember = "GradId";
				cmbGrad.DataSource = result;
			}
		}
		private async Task LoadGradove()
		{
			var result = await _gradovi.Get<List<Model.Grad>>(null);
			cmbGrad.DisplayMember = "Naziv";
			cmbGrad.ValueMember = "GradId";
			cmbGrad.DataSource = result;
		}

		private async void btnSnimi_Click(object sender, EventArgs e)
		{
			AdresaUpsertRequest request = new AdresaUpsertRequest();

			var idObj = cmbGrad.SelectedValue;

			if (int.TryParse(idObj.ToString(), out int GradId))
			{
				request.GradId = GradId;
			}
			
			if(this.ValidateChildren())
			{
				request.Naziv = txtNaziv.Text;

				if (!_Id.HasValue)
				{
					await _apiService.Insert<Model.Adresa>(request);
				}
				else
				{
					await _apiService.Update<Model.Adresa>(_Id, request);
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
			else if (txtNaziv.TextLength < 4)
			{
				e.Cancel = true;
				errorProvider.SetError(txtNaziv, "Polje mora sadržavati više od 4 karaktera!");
			}
			else
			{
				errorProvider.SetError(txtNaziv, null);
			}
		}
	}
}
