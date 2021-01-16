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
namespace MyDentalCare.WinUI.Login
{
	public partial class frmLogin : Form
	{
		APIService _service = new APIService("Korisnik");
		APIService _Pacijent = new APIService("Pacijent");
		public frmLogin()
		{
			InitializeComponent();
		}

		private async void btnLogin_Click(object sender, EventArgs e)
		{
			APIService.Username = txtUsername.Text;
			APIService.Password = txtPassword.Text;
			string username = txtUsername.Text;
			try
			{
				//List<Model.Pacijent> lista = await _Pacijent.Get<List<Model.Pacijent>>
				//   (new PacijentSearchRequest { KorisnickoIme = username });
				//if (lista.Count > 0)
				//{
				//	Application.Restart();
				//}
				//if (listaKorisnika.Count > 0)
				//{
				//	Application.Restart();
				//}
				//List<Model.Korisnik> listaKorisnika = await _service.Get<List<Model.Korisnik>>(null);

				//foreach (var item in listaKorisnika)
				//{
				//	if (item.KorisnickoIme != username)
				//	{
				//		MessageBox.Show("Nemate pravo pristupa", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//		Application.Exit();
				//	}
				//}
				await _service.Get<dynamic>(null);
				formIndex frm = new formIndex();
				frm.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void labelOdustani_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}
	}
}
