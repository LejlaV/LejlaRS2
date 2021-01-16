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

namespace MyDentalCare.WinUI.Usluge
{
	public partial class frmUsluge : Form
	{
		private readonly APIService _apiService = new APIService("usluga");
		public frmUsluge()
		{
			InitializeComponent();
		}

		private async void frmUsluge_Load(object sender, EventArgs e)
		{
			var result = await _apiService.Get<List<Model.Usluga>>(null);

			dgvUsluge.AutoGenerateColumns = false;
			dgvUsluge.DataSource = result;
		}

		private async void txtPrikazi_Click(object sender, EventArgs e)
		{
			var search = new UslugaSearchRequest()
			{
				Naziv = txtPretraga.Text
			};
			var result = await _apiService.Get<List<Model.Usluga>>(search);

			dgvUsluge.DataSource = result;
		}

		private void dgvUsluge_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = dgvUsluge.SelectedRows[0].Cells[0].Value;

			frmUslugaDetalji frm = new frmUslugaDetalji(int.Parse(id.ToString()));
			frm.Show();
		}
	}
}
