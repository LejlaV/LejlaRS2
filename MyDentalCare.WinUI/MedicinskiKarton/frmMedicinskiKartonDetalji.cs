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

namespace MyDentalCare.WinUI.MedicinskiKarton
{
	public partial class frmMedicinskiKartonDetalji : Form
	{
		private readonly APIService _medKartoni = new APIService("MedicinskiKarton");
		private readonly APIService _pacijenti = new APIService("Pacijent");
		private readonly int? _Id=null;
		public frmMedicinskiKartonDetalji(int? medKartonId = null)
		{
			InitializeComponent();
			_Id = medKartonId;
		}

		private async void frmMedicinskiKartonDetalji_Load(object sender, EventArgs e)
		{
			if(_Id.HasValue)
			{
				await LoadPacijente();
				var medicinskiKarton = await _medKartoni.GetById<Model.MedicinskiKarton>(_Id);
				//txtNaziv.Text = medicinskiKarton.Naziv;
				txtOpis.Text = medicinskiKarton.Opis;
				//dateTimePregled.Value = medicinskiKarton.DatumVrijeme;
			}
			else
			{
				var result = await _pacijenti.Get<List<Model.Pacijent>>(null);
				foreach (var item in result)
				{
					item.PacijentPodaci = item.Ime + " " + item.Prezime;
				}
				result.Insert(0, new Model.Pacijent());
				cmbPacijent.DisplayMember = "PacijentPodaci";
				cmbPacijent.ValueMember = "PacijentId";
				cmbPacijent.DataSource = result;
			}
		}

		private async Task LoadPacijente()
		{
			var result = await _pacijenti.Get<List<Model.Pacijent>>(null);
			foreach (var item in result)
			{
				item.PacijentPodaci = item.Ime + " " + item.Prezime;
			}
			cmbPacijent.DisplayMember = "PacijentPodaci";
			cmbPacijent.ValueMember = "PacijentId";
			cmbPacijent.DataSource = result;
		}

		MedicinskiKartonUpsertRequest request = new MedicinskiKartonUpsertRequest();
		private async void btnSnimi_Click(object sender, EventArgs e)
		{
			var idObj = cmbPacijent.SelectedValue;
			if (int.TryParse(idObj.ToString(), out int pacijentId))
			{
				request.PacijentId = pacijentId;
			}
			
			if(this.ValidateChildren())
			{
				var listaPacijenata = await _pacijenti.Get<List<Model.Pacijent>>(null);
				foreach (var item in listaPacijenata)
				{
					var pId = cmbPacijent.SelectedValue;
					if (item.PacijentId.ToString() == cmbPacijent.SelectedValue.ToString())
					{
						 var pacijentPodaci = item.Ime + " " + item.Prezime;
						request.Naziv = "Medicinski karton -> " + pacijentPodaci;
					}
				}
				
				request.Opis = txtOpis.Text;
				request.DatumVrijeme = DateTime.Now;

				if(!_Id.HasValue)
				{
					var listaMedKartona = await _medKartoni.Get<List<Model.MedicinskiKarton>>(null);
					foreach (var item in listaMedKartona)
					{
						if (item.PacijentId == request.PacijentId) 
						{
							MessageBox.Show("Medicinski karton za ovog pacijenta vec postoji!");
							return;
						}
					}

					await _medKartoni.Insert<Model.MedicinskiKarton>(request);
				}
				else
				{
					await _medKartoni.Update<Model.MedicinskiKarton>(_Id, request);
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
	}
}
