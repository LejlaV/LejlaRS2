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

namespace MyDentalCare.WinUI.Dijagnoza
{
	public partial class frmDijagnoze : Form
	{
		private readonly APIService _apiService = new APIService("dijagnoza");
		public frmDijagnoze()
		{
			InitializeComponent();
		}

		private async void frmDijagnoze_Load(object sender, EventArgs e)
		{
			var result = await _apiService.Get<List<Model.Dijagnoza>>(null);
			dgvDijagnoze.AutoGenerateColumns = false;
			dgvDijagnoze.DataSource = result;
		}

		private async void btnPrikazi_Click(object sender, EventArgs e)
		{
			var search = new DijagnozaSearchRequest()
			{
				Naziv = txtPretraga.Text
			};
			var result = await _apiService.Get<List<Model.Dijagnoza>>(search);

			dgvDijagnoze.DataSource = result;
		}
		private void dgvDijagnoze_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = dgvDijagnoze.SelectedRows[0].Cells[0].Value;

			frmDijagnozaDetalji frm = new frmDijagnozaDetalji(int.Parse(id.ToString()));
			frm.Show();
		}

	}
}
