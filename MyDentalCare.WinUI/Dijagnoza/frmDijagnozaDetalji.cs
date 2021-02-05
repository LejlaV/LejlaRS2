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

namespace MyDentalCare.WinUI.Dijagnoza
{
	public partial class frmDijagnozaDetalji : Form
	{
		private readonly APIService _apiService = new APIService("dijagnoza");
		private readonly int? _Id = null;
		public frmDijagnozaDetalji(int? DijagnozaId=null)
		{
			InitializeComponent();
			_Id = DijagnozaId;
		}

		private async void btnSnimi_Click(object sender, EventArgs e)
		{
			if(this.ValidateChildren())
			{
				var request = new DijagnozaUpsertRequest()
				{
					Naziv = txtNaziv.Text
				};

				if (!_Id.HasValue)
				{
					await _apiService.Insert<Model.Dijagnoza>(request);
				}
				else
				{
					await _apiService.Update<Model.Dijagnoza>(_Id, request);
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

		private async void frmDijagnozaDetalji_Load(object sender, EventArgs e)
		{
			if(_Id.HasValue)
			{
				var dijagnoza = await _apiService.GetById<Model.Dijagnoza>(_Id);
				txtNaziv.Text = dijagnoza.Naziv;
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
