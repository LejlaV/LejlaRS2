using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.WinUI.Clanak
{
	public partial class frmListaClanaka : Form
	{
		private readonly APIService _clanak = new APIService("clanak");
		private readonly APIService _kateogorije = new APIService("kategorija");
		private readonly APIService _korisnici = new APIService("korisnik");
		public frmListaClanaka()
		{
			InitializeComponent();
		}
		private async Task LoadKategorije()
		{
			var result = await _kateogorije.Get<List<Model.Kategorija>>(null);
			result.Insert(0, new Model.Kategorija());
			cmbKategorije.DisplayMember = "Naziv";
			cmbKategorije.ValueMember = "KategorijaId";
			cmbKategorije.DataSource = result;
		}

		private async void frmListaClanaka_Load(object sender, EventArgs e)
		{
			await LoadKategorije();
			dgvListaClanaka.AutoGenerateColumns = false;
			var result = await _clanak.Get<List<Model.Clanak>>(null);
			dgvListaClanaka.DataSource = result;
		}
		private void dgvListaClanaka_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = dgvListaClanaka.SelectedRows[0].Cells[0].Value;

			frmClanakDetalji frm = new frmClanakDetalji(int.Parse(id.ToString()));
			frm.Show();
		}
		private async void cmbKategorije_SelectedIndexChanged(object sender, EventArgs e)
		{
			var IdObj = cmbKategorije.SelectedValue;

			if (int.TryParse(IdObj.ToString(), out int id))
			{
				await LoadClanci(id);
			}
		}
		private async Task LoadClanci(int kategorijaId)
		{
			var result = await _clanak.Get<List<Model.Clanak>>(new ClanakSearchRequest()
			{
				KategorijaId = kategorijaId
			});
			dgvListaClanaka.DataSource = result;
		}
		
	}
}
