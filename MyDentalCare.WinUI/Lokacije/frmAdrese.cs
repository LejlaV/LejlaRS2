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
	public partial class frmAdrese : Form
	{
		private readonly APIService _apiService = new APIService("adresa");
		private readonly APIService _gradovi = new APIService("grad");
		public frmAdrese()
		{
			InitializeComponent();
		}

		private async void frmAdrese_Load(object sender, EventArgs e)
		{
			await LoadGradove();
			var result = await _apiService.Get<List<Model.Adresa>>(null);
			dgvAdrese.AutoGenerateColumns = false;
			dgvAdrese.DataSource = result;
		}
		private async Task LoadGradove()
		{
			var result = await _gradovi.Get<List<Model.Grad>>(null);
			dgvAdrese.DataSource = result;
		}

		private async void btnPrikazi_Click(object sender, EventArgs e)
		{
			var search = new AdresaSearchRequest()
			{
				Naziv = txtPretraga.Text
			};
			var result = await _apiService.Get<List<Model.Adresa>>(search);
			dgvAdrese.DataSource = result;
		}

		private void dgvAdrese_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = dgvAdrese.SelectedRows[0].Cells[0].Value;

			frmAdresaDetalji frm = new frmAdresaDetalji(int.Parse(id.ToString()));
			frm.Show();
		}
	}
}
