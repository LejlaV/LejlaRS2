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

namespace MyDentalCare.WinUI.Korisnik
{
	public partial class frmKorisnikDetalji : Form
	{
		private readonly APIService _service = new APIService("korisnik");
		private readonly APIService _uloge = new APIService("Uloga");
		private int? _Id = null;
		public frmKorisnikDetalji(int? KorisnikId = null)
		{
			InitializeComponent();
			_Id = KorisnikId;
		}
		private async void btnSnimi_Click(object sender, EventArgs e)
		{
			if(this.ValidateChildren())
			{
				var listaUloga = clbUloge.CheckedItems.Cast<Model.Uloga>().Select(x => x.UlogaId).ToList();

				var request = new KorisnikInsertRequest()
				{
					Ime = txtIme.Text,
					Prezime = txtPrezime.Text,
					Email = txtEmail.Text,
					BrojTelefona = txtBrojTelefona.Text,
					DatumRodjenja = dateTimePicker.Value,
					KorisnickoIme = txtKorisnickoIme.Text,
					Password = txtPassword.Text,
					PasswordConfirmation = txtPasswordConfirmation.Text,
					Uloge = listaUloga
				};

				if (!_Id.HasValue)
				{ 
					await _service.Insert<Model.Korisnik>(request);
				}
				else
				{
					await _service.Update<Model.Korisnik>(_Id, request);
				}
				MessageBox.Show("Operacija uspješna!");
			}
		}

		private async void frmKorisnikDetalji_LoadAsync(object sender, EventArgs e)
		{
			var uloge = await _uloge.Get<List<Model.Uloga>>(null);
			clbUloge.DataSource = uloge;
			clbUloge.DisplayMember = "Naziv";

			if (_Id.HasValue)
			{
				var Korisnik = await _service.GetById<Model.Korisnik>(_Id);

				txtIme.Text = Korisnik.Ime;
				txtPrezime.Text = Korisnik.Prezime;
				txtEmail.Text = Korisnik.Email;
				txtBrojTelefona.Text = Korisnik.BrojTelefona;
				txtKorisnickoIme.Text = Korisnik.KorisnickoIme;
			}
		}

		private void txtIme_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtIme.Text))
			{
				e.Cancel = true;
				errorProvider.SetError(txtIme, "Ovo polje je obavezno");
			}
			else
			{
				errorProvider.SetError(txtIme, null);
			}
		}

		private void txtPrezime_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtPrezime.Text))
			{
				e.Cancel = true;
				errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
			}
			else
			{
				errorProvider.SetError(txtPrezime, null);
			}
		}

		private void txtEmail_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtEmail.Text))
			{
				e.Cancel = true;
				errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
			}
			else
			{
				errorProvider.SetError(txtEmail, null);
			}
		}

		private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || txtKorisnickoIme.Text.Length < 3)
			{
				e.Cancel = true;
				errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
			}
			else
			{
				errorProvider.SetError(txtEmail, null);
			}
		}

		private void clbUloge_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
