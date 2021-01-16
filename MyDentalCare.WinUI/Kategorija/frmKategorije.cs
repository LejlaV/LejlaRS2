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

namespace MyDentalCare.WinUI.Kategorija
{
	public partial class frmKategorije : Form
	{
		private readonly APIService _apiService = new APIService("kategorija");
		public frmKategorije()
		{
			InitializeComponent();
		}

		private async void frmKategorije_Load(object sender, EventArgs e)
		{
			var result = await _apiService.Get<List<Model.Kategorija>>(null);

			dgvKategorije.AutoGenerateColumns = false;
			dgvKategorije.DataSource = result;
		}

		private async void btnPrikazi_Click(object sender, EventArgs e)
		{
			var search = new KategorijaSearchRequest()
			{
				Naziv = txtPretraga.Text
			};
			var result = await _apiService.Get<List<Model.Kategorija>>(search);

			dgvKategorije.DataSource = result;
		}

		private void dgvKategorije_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = dgvKategorije.SelectedRows[0].Cells[0].Value;

			frmKategorijaDetalji frm = new frmKategorijaDetalji(int.Parse(id.ToString()));
			frm.Show();
		}
	}
}
