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

namespace MyDentalCare.WinUI.Pacijent
{
	public partial class frmPacijentDetalji : Form
	{
		private readonly APIService _pacijenti = new APIService("Pacijent");
		private readonly int? _Id = null;
		public frmPacijentDetalji(int? pacijentId=null)
		{
			InitializeComponent();
			_Id = pacijentId;
		}

		private async void btnSnimi_Click(object sender, EventArgs e)
		{
			if (this.ValidateChildren())
			{
				var request = new PacijentUpsertRequest()
				{
					Email = txtEmail.Text,
					Ime = txtIme.Text,
					KorisnickoIme = txtKorisnickoIme.Text,
					Password = txtPassword.Text,
					PasswordConfirmation = txtPasswordConfirmation.Text,
					Prezime = txtPrezime.Text,
					BrojTelefona = txtBrojTelefona.Text,
					DatumRegistracije = dateTimePicker1.Value
				};

				if (!_Id.HasValue)
				{
					await _pacijenti.Insert<Model.Pacijent>(request);
				}
				else
				{
					await _pacijenti.Update<Model.Pacijent>(_Id, request);
				}
				MessageBox.Show("Operacija uspješna!");
			}
			else
			{
				MessageBox.Show("Operacija nije uspjela!");
				this.Close();
			}
		}

		private async void frmPacijentDetalji_Load(object sender, EventArgs e)
		{
			if (_Id.HasValue)
			{
				var pacijent = await _pacijenti.GetById<Model.Pacijent>(_Id);

				txtIme.Text = pacijent.Ime;
				txtPrezime.Text = pacijent.Prezime;
				txtEmail.Text = pacijent.Email;
				txtBrojTelefona.Text = pacijent.BrojTelefona;
				txtKorisnickoIme.Text = pacijent.KorisnickoIme;
			}
		}

		private void txtIme_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtIme.Text))
			{
				e.Cancel = true;
				errorProvider.SetError(txtIme, "Ovo polje je obavezno");
			}
			else if (txtIme.TextLength < 4)
			{
				e.Cancel = true;
				errorProvider.SetError(txtIme, "Polje mora sadržavati više od 4 karaktera!");
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
				errorProvider.SetError(txtPrezime, "Ovo polje je obavezno");
			}
			else if (txtIme.TextLength < 4)
			{
				e.Cancel = true;
				errorProvider.SetError(txtPrezime, "Polje mora sadržavati više od 4 karaktera!");
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
	}
}
