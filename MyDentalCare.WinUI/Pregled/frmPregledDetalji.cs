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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace MyDentalCare.WinUI.Pregled
{
	public partial class frmPregledDetalji : Form
	{
		private readonly APIService _pregledi = new APIService("pregled");
		private readonly APIService _rezervacije = new APIService("Rezervacija");
		private readonly APIService _lijek = new APIService("lijek");
		private readonly APIService _dijagnoza = new APIService("dijagnoza");
		private readonly APIService _korisnici = new APIService("Korisnik");
		private readonly APIService _medicinskiKarton = new APIService("MedicinskiKarton");

		private readonly int? _Id = null;
		public frmPregledDetalji(int? pregledId=null)
		{
			InitializeComponent();
			_Id = pregledId;
		}
		private async Task LoadRezervacije()
		{
			var result = await _rezervacije.Get<List<Model.Rezervacija>>(null);
			cmbRezervacija.DisplayMember = "UslugaIme";
			cmbRezervacija.ValueMember = "RezervacijaId";
			cmbRezervacija.DataSource = result;
		}
		private async Task LoadLijekove()
		{
			var result = await _lijek.Get<List<Model.Lijek>>(null);
			cmbLijek.DisplayMember = "Naziv";
			cmbLijek.ValueMember = "LijekId";
			cmbLijek.DataSource = result;
		}
		private async Task LoadDijagnoze()
		{
			var result = await _dijagnoza.Get<List<Model.Dijagnoza>>(null);
			cmbDijagnoza.DisplayMember = "Naziv";
			cmbDijagnoza.ValueMember = "DijagnozaId";
			cmbDijagnoza.DataSource = result;
		}
		private async Task LoadKorisnike()
		{
			var result = await _korisnici.Get<List<Model.Korisnik>>(null);
			foreach (var item in result)
			{
				item.KorisnikPodaci = item.Ime + " " + item.Prezime;
			}
			cmbLjekar.DisplayMember = "KorisnikPodaci";
			cmbLjekar.ValueMember = "KorisnikId";
			cmbLjekar.DataSource = result;
		}
		private async Task LoadMedicinskeKartone()
		{
			var result = await _medicinskiKarton.Get<List<Model.MedicinskiKarton>>(null);
			cmbMedicinskiKarton.DisplayMember = "Naziv";
			cmbMedicinskiKarton.ValueMember = "MedicinskiKartonId";
			cmbMedicinskiKarton.DataSource = result;
		}

		private async void frmPregledDetalji_Load(object sender, EventArgs e)
		{
			if(_Id.HasValue)
			{
				await LoadKorisnike();
				await LoadRezervacije();
				await LoadDijagnoze();
				await LoadLijekove();
				await LoadMedicinskeKartone();

				var pregled = await _pregledi.GetById<Model.Pregled>(_Id);
				txtNaziv.Text = pregled.Naziv;
				txtOpis.Text = pregled.Opis;
				dateTimePregled.Value = pregled.DatumVrijeme;
			}
			else
			{
				var result = await _korisnici.Get<List<Model.Korisnik>>(null);
				foreach (var item in result)
				{
					item.KorisnikPodaci = item.Ime + " " + item.Prezime;
				}
				result.Insert(0, new Model.Korisnik());
				cmbLjekar.DisplayMember = "KorisnikPodaci";
				cmbLjekar.ValueMember = "KorisnikId";
				cmbLjekar.DataSource = result;

				var result1 = await _dijagnoza.Get<List<Model.Dijagnoza>>(null);
				result1.Insert(0, new Model.Dijagnoza());
				cmbDijagnoza.DisplayMember = "Naziv";
				cmbDijagnoza.ValueMember = "DijagnozaId";
				cmbDijagnoza.DataSource = result1;

				var result2 = await _lijek.Get<List<Model.Lijek>>(null);
				result2.Insert(0, new Model.Lijek());
				cmbLijek.DisplayMember = "Naziv";
				cmbLijek.ValueMember = "LijekId";
				cmbLijek.DataSource = result2;

				var result3 = await _rezervacije.Get<List<Model.Rezervacija>>(null);
				result3.Insert(0, new Model.Rezervacija());
				cmbRezervacija.DisplayMember = "Razlog";
				cmbRezervacija.ValueMember = "RezervacijaId";
				cmbRezervacija.DataSource = result3;

				var result4 = await _medicinskiKarton.Get<List<Model.MedicinskiKarton>>(null);
				result4.Insert(0, new Model.MedicinskiKarton());
				cmbMedicinskiKarton.DisplayMember = "Naziv";
				cmbMedicinskiKarton.ValueMember = "MedicinskiKartonId";
				cmbMedicinskiKarton.DataSource = result4;
			}
		}

		PregledUpsertRequest request = new PregledUpsertRequest();
		private async void btnSnimi_Click(object sender, EventArgs e)
		{
			if (this.ValidateChildren() && ValidateCmb())
			{
				var idObj = cmbLjekar.SelectedValue;
				if (int.TryParse(idObj.ToString(), out int ljekarId))
				{
					request.KorisnikId = ljekarId;
				}

				var idObj2 = cmbRezervacija.SelectedValue;
				if (int.TryParse(idObj2.ToString(), out int rezervacijaId))
				{
					request.RezervacijaId = rezervacijaId;

					RezervacijaUpsertRequest rezervacijaRequest = new RezervacijaUpsertRequest();
					var listaRezervacija = await _rezervacije.Get<List<Model.Rezervacija>>(null);
					foreach (var item in listaRezervacija)
					{
						if (item.RezervacijaId == rezervacijaId)
						{
							rezervacijaRequest.DatumVrijeme = item.DatumVrijeme;
							rezervacijaRequest.PacijentId = item.PacijentId;
							rezervacijaRequest.UslugaId = item.UslugaId;
							rezervacijaRequest.Razlog = item.Razlog;
							// kada se pregled upise u bazu znaci da je pregled obavljen, samim tim rezervacija vise nije aktivna
							rezervacijaRequest.Aktivna = false;
							await _rezervacije.Update<Model.Rezervacija>(rezervacijaId, rezervacijaRequest);
						}
					}

					var listaPregleda = await _pregledi.Get<List<Model.Pregled>>(null);
					foreach (var item in listaPregleda)
					{
						if (item.RezervacijaId == rezervacijaId)
						{
							MessageBox.Show("Pregled za ovu rezervaciju je vec obavljen!");
							return;
						}
					}
				}

				var idObj3 = cmbDijagnoza.SelectedValue;
				if (int.TryParse(idObj3.ToString(), out int dijagnozaId))
				{
					request.DijagnozaId = dijagnozaId;
				}

				var idObj4 = cmbLijek.SelectedValue;
				if (int.TryParse(idObj4.ToString(), out int lijekId))
				{
					request.LijekId = lijekId;
				}

				var idObj5 = cmbMedicinskiKarton.SelectedValue;
				if (int.TryParse(idObj5.ToString(), out int medicinskiKartonId))
				{
					request.MedicinskiKartonId = medicinskiKartonId;
				}

				request.DatumVrijeme = dateTimePregled.Value = Convert.ToDateTime(System.DateTime.Today.ToShortDateString() + " 10:00 PM");
				request.Naziv = txtNaziv.Text;
				request.Opis = txtOpis.Text;

				if(!_Id.HasValue)
				{
					await _pregledi.Insert<Model.Pregled>(request);
				}
				else
				{
					await _pregledi.Update<Model.Pregled>(_Id, request);
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

		private void txtOpis_Validating(object sender, CancelEventArgs e)
		{
			if (txtOpis.TextLength < 4)
			{
				e.Cancel = true;
				errorProvider.SetError(txtOpis, "Polje mora sadržavati više od 4 karaktera!");
			}
			else if (!Regex.IsMatch(txtOpis.Text, @"^[a-zA-Z ]+$"))
			{
				errorProvider.SetError(txtOpis, "Možete unijeti samo textualne podatke!");
				e.Cancel = true;
			}
			else
			{
				errorProvider.SetError(txtOpis, null);
			}
		}

		private bool ValidateCmb()
		{
			if (cmbRezervacija.SelectedValue == null || (int)cmbRezervacija.SelectedValue == 0)
				errorProvider.SetError(cmbRezervacija, Properties.Resources.Validation_RequiredField);
			else
				errorProvider.SetError(cmbRezervacija, null);

			if (cmbMedicinskiKarton.SelectedValue == null || (int)cmbMedicinskiKarton.SelectedValue == 0)
				errorProvider.SetError(cmbMedicinskiKarton, Properties.Resources.Validation_RequiredField);
			else
				errorProvider.SetError(cmbMedicinskiKarton, null);

			if (cmbDijagnoza.SelectedValue == null || (int)cmbDijagnoza.SelectedValue == 0)
				errorProvider.SetError(cmbDijagnoza, Properties.Resources.Validation_RequiredField);
			else
				errorProvider.SetError(cmbDijagnoza, null);

			if (cmbLijek.SelectedValue == null || (int)cmbLijek.SelectedValue == 0)
				errorProvider.SetError(cmbLijek, Properties.Resources.Validation_RequiredField);
			else
				errorProvider.SetError(cmbLijek, null);

			if (cmbLjekar.SelectedValue == null || (int)cmbLjekar.SelectedValue == 0)
				errorProvider.SetError(cmbLijek, Properties.Resources.Validation_RequiredField);
			else
				errorProvider.SetError(cmbLjekar, null);

			var result = string.IsNullOrWhiteSpace(errorProvider.GetError(cmbRezervacija)) &&
						 string.IsNullOrWhiteSpace(errorProvider.GetError(cmbMedicinskiKarton)) &&
						 string.IsNullOrWhiteSpace(errorProvider.GetError(cmbDijagnoza)) &&
						 string.IsNullOrWhiteSpace(errorProvider.GetError(cmbLijek)) &&
						 string.IsNullOrWhiteSpace(errorProvider.GetError(cmbLjekar));

			return result;
		}
	}
}
