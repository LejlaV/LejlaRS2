using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.WinUI.Pacijent
{
	public partial class frmPacijenti : Form
	{
		private readonly APIService _pacijenti = new APIService("Pacijent");
		public frmPacijenti()
		{
			InitializeComponent();
		}
		private async void frmPacijenti_Load(object sender, EventArgs e)
		{
			var result = await _pacijenti.Get<List<Model.Pacijent>>(null);
			dgvPacijenti.AutoGenerateColumns = false;
			dgvPacijenti.DataSource = result;
		}
		private async void btnPrikazi_Click(object sender, EventArgs e)
		{
			var search = new PacijentSearchRequest()
			{
				Ime = txtIme.Text,
			};
			var result = await _pacijenti.Get<List<Model.Pacijent>>(search);
			dgvPacijenti.AutoGenerateColumns = false;
			dgvPacijenti.DataSource = result;
		}
		private void dgvPacijenti_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var id = dgvPacijenti.SelectedRows[0].Cells[0].Value;
			frmPacijentDetalji frm = new frmPacijentDetalji(int.Parse(id.ToString()));
			frm.Show();
		}
	}
}
