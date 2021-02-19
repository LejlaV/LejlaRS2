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
using MyDentalCare.Model;
using System.Security.Cryptography;

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

			string KorisnickoIme = txtUsername.Text;
			string Lozinka = txtPassword.Text;
			try
			{
				if (txtUsername.Text == null)
				{
					MessageBox.Show("Morate unijeti korisnicko ime", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (txtPassword.Text == null)
				{
					MessageBox.Show("Morate unijeti lozinku", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				//Model.Korisnik korisnik = null;
				//List<Model.Korisnik> lista = await _service.Get<List<Model.Korisnik>>(null);
				//foreach (var item in lista)
				//{
				//	if (item.KorisnickoIme == KorisnickoIme)
				//	{
				//			korisnik = item;
				//			break;
				//	}
				//}
				//if (korisnik != null)
				//{
				//	var newHash = GenerateHash(korisnik.PasswordSalt, Lozinka);
				//	if (newHash == korisnik.PasswordHash)
				//	{
						await _service.Get<dynamic>(null);
						formIndex frm = new formIndex();
						frm.Show();
					//}
					//else
					//{
					//	MessageBox.Show("Niste autentificirani", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
					//}
				//}
				//await _service.Get<dynamic>(null);
				//formIndex frm = new formIndex();
				//frm.Show();
			}
			catch (Exception ex)
			{
				//MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show("Niste autentificirani", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public static string GenerateHash(string salt, string password)
		{
			byte[] src = Convert.FromBase64String(salt);
			byte[] bytes = Encoding.Unicode.GetBytes(password);
			byte[] dst = new byte[src.Length + bytes.Length];

			System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
			System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

			SHA1 algorithm = SHA1.Create("SHA1");
			byte[] inArray = algorithm.ComputeHash(dst);
			return Convert.ToBase64String(inArray);
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
