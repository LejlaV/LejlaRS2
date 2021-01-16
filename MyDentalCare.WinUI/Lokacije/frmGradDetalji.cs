using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.WinUI.Lokacije
{
	public partial class frmGradDetalji : Form
	{
		private readonly APIService _apiService = new APIService("grad");
		private readonly APIService _drzave = new APIService("drzava");
		private readonly int? _Id = null;
		public frmGradDetalji(int? GradId = null)
		{
			InitializeComponent();
			_Id = GradId;
		}

		private async void frmGradDetalji_Load(object sender, EventArgs e)
		{
			if (_Id.HasValue)
			{
				await LoadDrzave();
				var grad = await _apiService.GetById<Model.Grad>(_Id);
				txtNaziv.Text = grad.Naziv;
				txtPostanskiBroj.Text = grad.PostanskiBroj;
			}
			else
			{
				var result = await _drzave.Get<List<Model.Drzava>>(null);
				result.Insert(0, new Model.Drzava());
				cmbDrzava.DisplayMember = "Naziv";
				cmbDrzava.ValueMember = "DrzavaId";
				cmbDrzava.DataSource = result;
			}
		}

		private async Task LoadDrzave()
		{
			var result = await _drzave.Get<List<Model.Drzava>>(null);
			cmbDrzava.DisplayMember = "Naziv";
			cmbDrzava.ValueMember = "DrzavaId";
			cmbDrzava.DataSource = result;
		}

		private async void btnSnimi_Click(object sender, EventArgs e)
		{
			GradUpsertRequest request = new GradUpsertRequest();

			var idObj = cmbDrzava.SelectedValue;

			if (int.TryParse(idObj.ToString(), out int DrzavaId))
			{
				request.DrzavaId = DrzavaId;
			}
			
			if(this.Validate())
			{
				request.Naziv = txtNaziv.Text;
				request.PostanskiBroj = txtPostanskiBroj.Text;

				if (!_Id.HasValue)
				{
					await _apiService.Insert<Model.Grad>(request);
				}
				else
				{
					await _apiService.Update<Model.Grad>(_Id, request);
				}
				MessageBox.Show("Operacija uspješna!");
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

		private void txtPostanskiBroj_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtPostanskiBroj.Text))
			{
				e.Cancel = true;
				errorProvider.SetError(txtPostanskiBroj, Properties.Resources.Validation_RequiredField);
			}
			else if (txtNaziv.TextLength < 4)
			{
				e.Cancel = true;
				errorProvider.SetError(txtPostanskiBroj, "Polje mora sadržavati više od 4 karaktera!");
			}
			else
			{
				errorProvider.SetError(txtPostanskiBroj, null);
			}
		}
	}
}
