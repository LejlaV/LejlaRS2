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
using MyDentalCare.Model;
using System.Text.RegularExpressions;

namespace MyDentalCare.WinUI.StomatoloskaOrdinacija
{
	public partial class frmStomatoloskaOrdinacija : Form
	{
		private readonly APIService _stomatoloskaOrdinacija = new APIService("StomatoloskaOrdinacija");
		private readonly APIService _adrese = new APIService("adresa");
		private readonly int? _Id = null;

		public frmStomatoloskaOrdinacija(int? ordinacijaId = null)
		{
			InitializeComponent();
			_Id = ordinacijaId;
		}

		private async Task LoadAdrese()
		{
			var result = await _adrese.Get<List<Model.Adresa>>(null);
			result.Insert(0, new Model.Adresa());
			cmbAdresa.DisplayMember = "Naziv";
			cmbAdresa.ValueMember = "AdresaId";
			cmbAdresa.DataSource = result;
		}
		private async void btnSnimi_Click(object sender, EventArgs e)
		{
			StomatoloskaOrdinacijaUpsertRequest request = new StomatoloskaOrdinacijaUpsertRequest();

			var idObj = cmbAdresa.SelectedValue;
			if (int.TryParse(idObj.ToString(), out int AdresaId))
			{
				request.AdresaId = AdresaId;
			}

			if (this.ValidateChildren())
			{
				request.Naziv = txtNaziv.Text;
				request.Email = txtEmail.Text;
				request.BrojTelefona = txtBrojTelefona.Text;
				request.RadnoVrijemeOd = dateRadnoVrijemeOD.Value = Convert.ToDateTime(System.DateTime.Today.ToShortDateString() + " 10:00 PM");
				request.RadnoVrijemeDo = dateRadnoVrijemeDO.Value = Convert.ToDateTime(System.DateTime.Today.ToShortDateString() + " 10:00 PM");

				await _stomatoloskaOrdinacija.Insert<Model.StomatoloskaOrdinacija>(request);

				MessageBox.Show("Operacija uspješna!");
				this.Close();
			}
			else
			{
				MessageBox.Show("Operacija nije uspjela!");
				this.Close();
			}
		}

		private async void frmStomatoloskaOrdinacija_Load(object sender, EventArgs e)
		{
			await LoadAdrese();
			//if (_Id.HasValue)
			//{
				var ordinacija = await _stomatoloskaOrdinacija.GetById<Model.StomatoloskaOrdinacija>(1);
				txtNaziv.Text = ordinacija.Naziv;
				txtEmail.Text = ordinacija.Email;
				txtBrojTelefona.Text = ordinacija.BrojTelefona;
				dateRadnoVrijemeOD.Text = ordinacija.RadnoVrijemeOd.ToString();
				dateRadnoVrijemeDO.Text = ordinacija.RadnoVrijemeDo.ToString();
			//}
		}

		private void txtNaziv_Validating(object sender, CancelEventArgs e)
		{
			if(string.IsNullOrWhiteSpace(txtNaziv.Text))
			{
				e.Cancel = true;
				errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
			}
			else if (txtNaziv.TextLength < 4)
			{
				errorProvider.SetError(txtNaziv, "Naziv stomatoloske ordinacije ne moze biti manji od 4 karaktera!");
			}
			else if (!Regex.IsMatch(txtNaziv.Text, @"^[a-zA-Z ]+$"))
			{
				errorProvider.SetError(txtNaziv, "Možete unijeti samo textualne podatke!");
				e.Cancel = true;
			}
			else
			{
				errorProvider.SetError(txtNaziv, null);
			}
		}

		private void txtEmail_Validating(object sender, CancelEventArgs e)
		{
			string pattern = @"^([0-9a-zA-Z]" + @"([\+\-_\.][0-9a-zA-Z]+)*" + @")+" + @"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";

			if (string.IsNullOrWhiteSpace(txtEmail.Text))
			{
				e.Cancel=true;
				errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
			}
			else if(!Regex.IsMatch(txtEmail.Text, pattern))
			{
				e.Cancel = true;
				errorProvider.SetError(txtEmail, "Niste unijeli ispravnu e-mail adresu!");
			}
			else
			{
				errorProvider.SetError(txtEmail, null);
			}
		}

		private void txtNaziv_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
