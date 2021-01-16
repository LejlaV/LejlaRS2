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

namespace MyDentalCare.WinUI.Pregled
{
	public partial class frmPregledi : Form
	{
		private readonly APIService _pregledi = new APIService("pregled");
		private readonly APIService _medicinskiKartoni = new APIService("MedicinskiKarton");
		private readonly APIService _lijekovi = new APIService("Lijek");
		private readonly APIService _dijagnoze = new APIService("Dijagnoza");

		public frmPregledi()
		{
			InitializeComponent();
		}
		private async Task LoadKorisnikeComboBox()
		{
			var result = await _medicinskiKartoni.Get<List<Model.MedicinskiKarton>>(null);
			result.Insert(0, new Model.MedicinskiKarton());
			cmbMedicinskiKartoni.DisplayMember = "Naziv";
			cmbMedicinskiKartoni.ValueMember = "MedicinskiKartonId";
			cmbMedicinskiKartoni.DataSource = result;
		}
		private async void frmPregledi_Load(object sender, EventArgs e)
		{
			await LoadKorisnikeComboBox();
			//await LoadDijagnoze();
			//await LoadLijekove();
			dgvPregledi.AutoGenerateColumns = false;
			var result = await _pregledi.Get<List<Model.Pregled>>(null);
			dgvPregledi.DataSource = result;
		}
		private async Task LoadDijagnoze()
		{
			var result = await _dijagnoze.Get<List<Model.Dijagnoza>>(null);
			dgvPregledi.DataSource = result;
		}
		private async Task LoadLijekove()
		{
			var result = await _lijekovi.Get<List<Model.Lijek>>(null);
			dgvPregledi.DataSource = result;
		}
		private void dgvPregledi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = dgvPregledi.SelectedRows[0].Cells[0].Value;

			frmPregledDetalji frm = new frmPregledDetalji(int.Parse(id.ToString()));
			frm.Show();
		}

		private async void cmbMedicinskiKartoni_SelectedIndexChanged(object sender, EventArgs e)
		{
			var IdObj = cmbMedicinskiKartoni.SelectedValue;
			if (int.TryParse(IdObj.ToString(), out int id))
			{
				await LoadPreglediMedicinskiKartoni(id);
			}
		}

		private async Task LoadPreglediMedicinskiKartoni(int medicinskiKartonId)
		{
			var result = await _pregledi.Get<List<Model.Pregled>>(new PregledSearchRequest()
			{
				MedicinskiKartonId = medicinskiKartonId
			});

			dgvPregledi.DataSource = result;
		}
	}
}
