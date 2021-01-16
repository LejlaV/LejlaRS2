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

namespace MyDentalCare.WinUI.Lokacije
{
	public partial class frmGradovi : Form
	{
		private readonly APIService _apiService = new APIService("grad");
		private readonly APIService _drzave = new APIService("drzava");

		public frmGradovi()
		{
			InitializeComponent();
		}

		private async void frmGradovi_Load(object sender, EventArgs e)
		{
			await LoadDrzave();
			var result = await _apiService.Get<List<Model.Grad>>(null);
			dgvGradovi.AutoGenerateColumns = false;
			dgvGradovi.DataSource = result;
		}
		private async Task LoadDrzave()
		{
			var result = await _drzave.Get<List<Model.Drzava>>(null);
			dgvGradovi.DataSource = result;
		}
		private async void btnPrikazi_Click(object sender, EventArgs e)
		{
			var search = new GradSearchRequest()
			{
				Naziv = txtPretraga.Text
			};
			var result = await _apiService.Get<List<Model.Grad>>(search);

			dgvGradovi.DataSource = result;
		}
		private void dgvGradovi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = dgvGradovi.SelectedRows[0].Cells[0].Value;

			frmGradDetalji frm = new frmGradDetalji(int.Parse(id.ToString()));
			frm.Show();
		}

	}
}
