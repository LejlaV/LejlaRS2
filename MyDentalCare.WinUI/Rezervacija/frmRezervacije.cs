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

namespace MyDentalCare.WinUI.Rezervacija
{
	public partial class frmRezervacije : Form
	{
		private readonly APIService _rezervacija = new APIService("Rezervacija");
		private readonly APIService _pacijent = new APIService("Pacijent");
		private readonly APIService _usluga = new APIService("usluga");
		public frmRezervacije()
		{
			InitializeComponent();
		}

		private async void frmRezervacije_Load(object sender, EventArgs e)
		{
			dgvRezervacije.AutoGenerateColumns = false;
			await LoadPacijenteComboBox();
			await LoadUsluge();
			var result = await _rezervacija.Get<List<Model.Rezervacija>>(null);
			dgvRezervacije.DataSource = result;
		}
		private async Task LoadUsluge()
		{
			var result = await _usluga.Get<List<Model.Usluga>>(null);
			dgvRezervacije.DataSource = result;
		}

		private async Task LoadPacijenteComboBox()
		{
			var result = await _pacijent.Get<List<Model.Pacijent>>(null);
			foreach (var item in result)
			{
				item.PacijentPodaci = item.Ime + " " + item.Prezime;
			}
			result.Insert(0, new Model.Pacijent());
			cmbPacijent.DisplayMember = "PacijentPodaci";
			cmbPacijent.ValueMember = "PacijentId";
			cmbPacijent.DataSource = result;
		}

		private async void cmbPacijent_SelectedIndexChanged(object sender, EventArgs e)
		{
			var IdObj = cmbPacijent.SelectedValue;

			if (int.TryParse(IdObj.ToString(), out int id))
			{
				await LoadRezervacijePacijenti(id);
			}
		}
		private async Task LoadRezervacijePacijenti(int pacijentId)
		{
			var result = await _rezervacija.Get<List<Model.Rezervacija>>(new RezervacijaSearchRequest()
			{
				PacijentId = pacijentId
			});

			dgvRezervacije.DataSource = result;
		}

		private void dgvRezervacije_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = dgvRezervacije.SelectedRows[0].Cells[0].Value;

			frmRezervacijaDetalji frm = new frmRezervacijaDetalji(int.Parse(id.ToString()));
			frm.Show();
		}
	}
}
