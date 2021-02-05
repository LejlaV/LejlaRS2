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

namespace MyDentalCare.WinUI.Usluge
{
	public partial class frmUslugaDetalji : Form
	{
		private readonly APIService _service = new APIService("usluga");
		private int? _Id = null;
		public frmUslugaDetalji(int? UslugaId = null)
		{
			InitializeComponent();
			_Id = UslugaId;
		}

		private async void btnSnimi_Click(object sender, EventArgs e)
		{
			if (this.ValidateChildren())
			{
				var request = new UslugaUpsertRequest()
				{
					Naziv = txtNaziv.Text,
					Cijena = numCijena.Value
				};

				if (!_Id.HasValue)
				{
					await _service.Insert<Model.Lijek>(request);
				}
				else
				{
					await _service.Update<Model.Lijek>(_Id, request);
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
		private async void frmUslugaDetalji_Load(object sender, EventArgs e)
		{
			if (_Id.HasValue)
			{
				var usluga = await _service.GetById<Model.Usluga>(_Id);

				txtNaziv.Text = usluga.Naziv;
				numCijena.Value = usluga.Cijena.Value;
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
	}
}
