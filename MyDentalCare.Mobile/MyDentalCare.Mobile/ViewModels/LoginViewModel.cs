using MyDentalCare.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MyDentalCare.Model;
using System.Security.Cryptography;

namespace MyDentalCare.Mobile.ViewModels
{
	public class LoginViewModel : BaseViewModel
	{
		private readonly APIService _service = new APIService("Korisnik");
		private readonly APIService _servicePacijent = new APIService("Pacijent");

		public LoginViewModel()
		{
			LoginCommand = new Command(async () => await Login());
		}

		string _korisnickoIme = string.Empty;
		public string KorisnickoIme
		{
			get { return _korisnickoIme; }
			set { SetProperty(ref _korisnickoIme, value); }
		}

		string _lozinka = string.Empty;
		public string Lozinka
		{
			get { return _lozinka; }
			set { SetProperty(ref _lozinka, value); }
		}

		public ICommand LoginCommand { get; set; }

		async Task Login()
		{
			IsBusy = true;
			APIService.Username = KorisnickoIme;
			APIService.Password = Lozinka;

			try
			{
				await _service.Get<dynamic>(null);
				//Application.Current.MainPage = new MainPage();
				if (string.IsNullOrWhiteSpace(this._korisnickoIme)) 
				{
					await Application.Current.MainPage.DisplayAlert("Greška", "Morate upisati korisničko ime!", "OK");
				}
				if (string.IsNullOrWhiteSpace(this._lozinka))
				{
					await Application.Current.MainPage.DisplayAlert("Greška", "Morate upisati lozinku!", "OK");
				}
				Pacijent pacijent = null;
				List<Pacijent> lista = await _servicePacijent.Get<List<Pacijent>>(null);
				foreach (var item in lista)
				{
					if (item.KorisnickoIme == KorisnickoIme)
					{
						pacijent = item;
						break;
					}
				}

				if (pacijent != null)
				{
					var newHash = GenerateHash(pacijent.PasswordSalt, _lozinka);
					if (newHash == pacijent.PasswordHash)
					{
						Application.Current.MainPage = new MainPage();
					}
					else
					{
						await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
					}
				}
				else
				{
					Korisnik korisnik = null;
					List<Korisnik> listaKorisnika = await _service.Get<List<Korisnik>>(null);
					foreach (var item in listaKorisnika)
					{
						if (item.KorisnickoIme == KorisnickoIme)
						{
							korisnik = item;
							break;
						}
					}
					if (korisnik != null)
					{
						var newHash = GenerateHash(korisnik.PasswordSalt, _lozinka);
						if (newHash == korisnik.PasswordHash)
						{
							Application.Current.MainPage = new MainPageAdmin();
						}
						else
						{
							await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
						}
					}
				}
			}
			catch (Exception ex)
			{

			}
			finally
			{
				IsBusy = false;
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
	}
}
