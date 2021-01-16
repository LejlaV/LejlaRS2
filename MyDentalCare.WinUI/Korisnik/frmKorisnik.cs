using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.WinUI.Korisnik
{
	public partial class frmKorisnik : Form
	{
		private readonly APIService _apiService = new APIService("korisnik");
		public frmKorisnik()
		{
			InitializeComponent();
		}

		private async void btnPrikazi_Click(object sender, EventArgs e)
		{
			var search = new KorisnikSearchRequest()
			{
				Ime = txtPretraga.Text
			};
			var result = await _apiService.Get<List<Model.Korisnik>>(search);

			dgvKorisnik.DataSource = result;
		}

		private async void frmKorisnik_Load(object sender, EventArgs e)
		{
			var result = await _apiService.Get<List<Model.Korisnik>>(null);
			dgvKorisnik.AutoGenerateColumns = false;
			dgvKorisnik.DataSource = result;
		}

		private void dgvKorisnik_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var id = dgvKorisnik.SelectedRows[0].Cells[0].Value;
		}

		private void dgvKorisnik_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = dgvKorisnik.SelectedRows[0].Cells[0].Value;

			frmKorisnikDetalji frm = new frmKorisnikDetalji(int.Parse(id.ToString()));
			frm.Show();
		}

		private void dgvKorisnik_CellContentCli(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
