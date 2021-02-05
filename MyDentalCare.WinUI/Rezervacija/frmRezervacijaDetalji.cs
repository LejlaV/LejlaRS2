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
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.WinUI.Rezervacija
{
	public partial class frmRezervacijaDetalji : Form
	{
		private readonly APIService _rezervacija = new APIService("Rezervacija");
		private readonly APIService _pacijent = new APIService("Pacijent");
		private readonly APIService _usluga = new APIService("Usluga");

		private readonly int? _Id = null;

		public frmRezervacijaDetalji(int? rezervacijaId=null)
		{
			InitializeComponent();
			_Id = rezervacijaId;
		}
		private async Task LoadPacijente()
		{
			var result = await _pacijent.Get<List<Model.Pacijent>>(null);
			foreach (var item in result)
			{
				item.PacijentPodaci = item.Ime + " " + item.Prezime;
			}
			cmbPacijent.DisplayMember = "PacijentPodaci";
			cmbPacijent.ValueMember = "PacijentId";
			cmbPacijent.DataSource = result;
		}
		private async Task LoadUsluge()
		{
			var result = await _usluga.Get<List<Model.Usluga>>(null);
			cmbUsluge.DisplayMember = "Naziv";
			cmbUsluge.ValueMember = "UslugaId";
			cmbUsluge.DataSource = result;
		}

		private async void frmRezervacijaDetalji_Load(object sender, EventArgs e)
		{
			if (_Id.HasValue)
			{
				await LoadPacijente();
				await LoadUsluge();
				var rezervacija = await _rezervacija.GetById<Model.Rezervacija>(_Id);
				txtRazlog.Text = rezervacija.Razlog;
			}
			else
			{
				var result = await _usluga.Get<List<Model.Usluga>>(null);
				result.Insert(0, new Model.Usluga());
				cmbUsluge.DisplayMember = "Naziv";
				cmbUsluge.ValueMember = "UslugaId";
				cmbUsluge.DataSource = result;

				var result2 = await _pacijent.Get<List<Model.Pacijent>>(null);
				foreach (var item in result2)
				{
					item.PacijentPodaci = item.Ime + " " + item.Prezime;
				}
				cmbPacijent.DisplayMember = "PacijentPodaci";
				result2.Insert(0, new Model.Pacijent());
				cmbPacijent.DisplayMember = "PacijentPodaci";
				cmbPacijent.ValueMember = "PacijentId";
				cmbPacijent.DataSource = result2;
			}
		}

		RezervacijaUpsertRequest request = new RezervacijaUpsertRequest();
		private async void btnSnimi_Click(object sender, EventArgs e)
		{
			
			if (this.ValidateChildren() && ValidateCmb())
			{
				var idObj = cmbUsluge.SelectedValue;

				if (int.TryParse(idObj.ToString(), out int uslugaId))
				{
					request.UslugaId = uslugaId;
				}
				var idObj2 = cmbPacijent.SelectedValue;

				if (int.TryParse(idObj2.ToString(), out int pacijentId))
				{
					request.PacijentId = pacijentId;
				}

				request.DatumVrijeme = dateTimeRezervacija.Value = Convert.ToDateTime(System.DateTime.Today.ToShortDateString() + " 10:00 PM");

				request.Razlog = txtRazlog.Text;
				request.Aktivna = true;
				if (!_Id.HasValue)
				{
					await _rezervacija.Insert<Model.Rezervacija>(request);
				}
				else
				{
					await _rezervacija.Update<Model.Rezervacija>(_Id, request);
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

		private void txtRazlog_Validating(object sender, CancelEventArgs e)
		{
			if(string.IsNullOrWhiteSpace(txtRazlog.Text))
			{
				e.Cancel = true;
				errorProvider.SetError(txtRazlog, Properties.Resources.Validation_RequiredField);
			}
			else if (!Regex.IsMatch(txtRazlog.Text, @"^[a-zA-Z ]+$"))
			{
				errorProvider.SetError(txtRazlog, "Možete unijeti samo textualne podatke!");
				e.Cancel = true;
			}
			else
			{
				errorProvider.SetError(txtRazlog, null);
			}
		}

		private bool ValidateCmb()
		{
			if (cmbPacijent.SelectedValue == null || (int)cmbPacijent.SelectedValue == 0)
				errorProvider.SetError(cmbPacijent, Properties.Resources.Validation_RequiredField);
			else
				errorProvider.SetError(cmbPacijent, null);

			if (cmbUsluge.SelectedValue == null || (int)cmbUsluge.SelectedValue == 0)
				errorProvider.SetError(cmbUsluge, Properties.Resources.Validation_RequiredField);
			else
				errorProvider.SetError(cmbUsluge, null);

			var result = string.IsNullOrWhiteSpace(errorProvider.GetError(cmbPacijent)) &&
						 string.IsNullOrWhiteSpace(errorProvider.GetError(cmbUsluge));

			return result;
		}
	}
}
