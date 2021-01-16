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
using MyDentalCare.WinUI;

namespace MyDentalCare.WinUI.Lijek
{
	public partial class frmLijekovi : Form
	{
		private readonly APIService _apiService = new APIService("lijek");
		public frmLijekovi()
		{
			InitializeComponent();
		}
		private async void btnPrikazi_Click(object sender, EventArgs e)
		{
			var search = new LijekSearchRequest()
			{
				Naziv = txtPretraga.Text
			};
			var result = await _apiService.Get<List<Model.Lijek>>(search);

			dgvLijekovi.DataSource = result;
		}
		private async void frmLijekovi_Load(object sender, EventArgs e)
		{
			var result = await _apiService.Get<List<Model.Lijek>>(null);

			dgvLijekovi.AutoGenerateColumns = false;
			dgvLijekovi.DataSource = result;
		}

		private void dgvLijekovi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = dgvLijekovi.SelectedRows[0].Cells[0].Value;

			frmLijekDetalji frm = new frmLijekDetalji(int.Parse(id.ToString()));
			frm.Show();
		}
	}
}
