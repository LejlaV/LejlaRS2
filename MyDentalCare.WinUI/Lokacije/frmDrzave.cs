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
	public partial class frmDrzave : Form
	{
		private readonly APIService _apiService = new APIService("drzava");

		public frmDrzave()
		{
			InitializeComponent();
		}
		private async void frmDrzave_Load(object sender, EventArgs e)
		{
			var result = await _apiService.Get<List<Model.Drzava>>(null);
			dgvDrzave.AutoGenerateColumns = false;
			dgvDrzave.DataSource = result;
		}
	}
}
