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
	public partial class frmMedicinskiKartoni : Form
	{
		private readonly APIService _medKartoni = new APIService("MedicinskiKarton");
		private readonly APIService _pacijenti = new APIService("Pacijent");

		public frmMedicinskiKartoni()
		{
			InitializeComponent();
		}
		private async Task LoadPacijenteComboBox()
		{
			var result = await _pacijenti.Get<List<Model.Pacijent>>(null);
			foreach (var item in result)
			{
				item.PacijentPodaci = item.Ime + " " + item.Prezime;
			}
			result.Insert(0, new Model.Pacijent());
			cmbPacijenti.DisplayMember = "PacijentPodaci";
			cmbPacijenti.ValueMember = "PacijentId";
			cmbPacijenti.DataSource = result;
		}
		private async void frmMedicinskiKartoni_Load(object sender, EventArgs e)
		{
			await LoadPacijenteComboBox();

			var result = await _medKartoni.Get<List<Model.MedicinskiKarton>>(null);
			dgvMedicinskiKartoni.AutoGenerateColumns = false;
			dgvMedicinskiKartoni.DataSource = result;
		}
		private async void cmbPacijenti_SelectedIndexChanged(object sender, EventArgs e)
		{
			var idObj = cmbPacijenti.SelectedValue;

			if (int.TryParse(idObj.ToString(), out int id))
			{
				await LoadPacijenteSearch(id);
			}
		}
		private async Task LoadPacijenteSearch(int pacijentId)
		{
			var result = await _medKartoni.Get<List<Model.MedicinskiKarton>>(new MedicinskiKartonSearchRequest()
			{
				PacijentId = pacijentId
			});

			dgvMedicinskiKartoni.DataSource = result;
		}

		private void dgvMedicinskiKartoni_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = dgvMedicinskiKartoni.SelectedRows[0].Cells[0].Value;
			frmMedicinskiKartonDetalji frm = new frmMedicinskiKartonDetalji(int.Parse(id.ToString()));
			frm.Show();
		}
	}
}
