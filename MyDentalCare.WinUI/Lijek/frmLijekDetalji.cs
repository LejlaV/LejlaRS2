using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.WinUI.Lijek
{
	public partial class frmLijekDetalji : Form
	{
		private readonly APIService _apiService = new APIService("lijek");
		private int? _Id = null;
		public frmLijekDetalji(int? LijekId = null)
		{
			InitializeComponent();
			_Id = LijekId;
		}

		private async void btnSnimi_Click(object sender, EventArgs e)
		{
			if (this.ValidateChildren())
			{
				var request = new LijekUpsertRequest()
				{
					Naziv = txtNaziv.Text,
					Uputstvo=txtUputstvo.Text
				};

				if (!_Id.HasValue)
				{
					await _apiService.Insert<Model.Lijek>(request);
				}
				else
				{
					await _apiService.Update<Model.Lijek>(_Id, request);
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

		private async void frmLijekDetalji_Load(object sender, EventArgs e)
		{
			if (_Id.HasValue)
			{
				var Lijek = await _apiService.GetById<Model.Lijek>(_Id);

				txtNaziv.Text = Lijek.Naziv;
				txtUputstvo.Text = Lijek.Uputstvo;
			}
		}

		private void txtNaziv_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNaziv.Text))
			{
				e.Cancel = true;
				errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
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

		private void txtUputstvo_Validating(object sender, CancelEventArgs e)
		{
			if (!Regex.IsMatch(txtUputstvo.Text, @"^[a-zA-Z ]+$"))
			{
				errorProvider.SetError(txtUputstvo, "Možete unijeti samo textualne podatke!");
				e.Cancel = true;
			}
			else
			{
				errorProvider.SetError(txtUputstvo, null);
			}
		}
	}
}
