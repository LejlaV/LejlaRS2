using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views.Pacijent
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KorisnickiProfilPage : ContentPage
	{
		public APIService _pacijent = new APIService("Pacijent");
		public KorisnickiProfilViewModel viewmodel { get; set; }
		public KorisnickiProfilPage(Model.Pacijent p)
		{
			InitializeComponent();
			BindingContext = viewmodel = new KorisnickiProfilViewModel() { Pacijent = p };
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			if (!Regex.IsMatch(this.Ime.Text, @"^[a-zA-Z]+$"))
			{
				await DisplayAlert("Greška", "Ime se sastoji samo od slova", "OK");
			}
			else if (!Regex.IsMatch(this.Prezime.Text, @"^[a-zA-Z]+$"))
			{
				await DisplayAlert("Greška", "Prezime se sastoji samo od slova", "OK");
			}
			else if (!Regex.IsMatch(this.KorisnickoIme.Text, @"^(?=.{4,40}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$"))
			{
				await DisplayAlert("Greška", "Neispravno korisničko ime", "OK");
			}
			else if (this.Password.Text != this.PasswordConfirmation.Text)
			{
				await DisplayAlert("Greška", "Lozinke moraju biti iste", "OK");

			}
			else if (this.Password.Text.Length < 4)
			{
				await DisplayAlert("Greška", "Lozinka ne smije biti kraća od 4 karaktera", "OK");
			}
			else
			{
				try
				{
					PacijentUpsertRequest request = new PacijentUpsertRequest()
					{
						Ime = this.Ime.Text,
						Prezime = this.Prezime.Text,
						KorisnickoIme = this.KorisnickoIme.Text,
						BrojTelefona = this.BrojTelefona.Text,
						Email = this.Email.Text,
						DatumRegistracije = Convert.ToDateTime(this.DatumRegistracije.Text)
					};
					var lozinka = APIService.Password;
					var korisnickoIme = APIService.Username;
					await _pacijent.Update<dynamic>(viewmodel.Pacijent.PacijentId, request);
					await DisplayAlert("OK", "Uspješno uneseni podaci", "OK");
					if (lozinka != this.Password.Text || korisnickoIme != this.KorisnickoIme.Text)
					{
						Application.Current.MainPage = new LoginPage();
					}
				}
				catch (Exception err)
				{
					throw new Exception(err.Message);
				}
			}
		}
	}
}