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

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UrediStomatoloskuOrdinaciju : ContentPage
	{
		private readonly APIService _stomatoloskaOrdinacija = new APIService("StomatoloskaOrdinacija");
		private readonly APIService _adresa = new APIService("adresa");

		UrediStomatoloskuOrdinacijuViewModel model = new UrediStomatoloskuOrdinacijuViewModel();

		public UrediStomatoloskuOrdinaciju(Model.StomatoloskaOrdinacija stomatoloskaOrdinacija)
		{
			InitializeComponent();
			BindingContext = model = new UrediStomatoloskuOrdinacijuViewModel() { StomatoloskaOrdinacija = stomatoloskaOrdinacija };
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			string pattern = @"^([0-9a-zA-Z]" + @"([\+\-_\.][0-9a-zA-Z]+)*" + @")+" + @"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";

			if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
			{
				await DisplayAlert("Greška", "Naziv ne može biti manji od 4 karaktera!", "OK");
			}
			else if (!Regex.IsMatch(this.Email.Text, pattern))
			{
				await DisplayAlert("Greška", "Niste unijeli ispravnu e-mail adresu!", "OK");
			}
			else
			{
				try
				{
					StomatoloskaOrdinacijaUpsertRequest request = new StomatoloskaOrdinacijaUpsertRequest();
					request.Naziv = this.Naziv.Text;
					request.Email = this.Email.Text;
					request.BrojTelefona = this.BrojTelefona.Text;
					request.RadnoVrijemeOd = this.RadnoVrijemeOd.Date;
					request.RadnoVrijemeDo = this.RadnoVrijemeDo.Date;
					Adresa a = this.AdresaPicker.SelectedItem as Adresa;
					request.AdresaId = a.AdresaId;
					await _stomatoloskaOrdinacija.Update<dynamic>(model.StomatoloskaOrdinacija.StomatoloskaOrdinacijaId, request);
					await DisplayAlert("OK", "Uspješno izmjenjeno!", "OK");
					await Navigation.PushAsync(new StomatoloskaOrdinacija());
				}
				catch (Exception err)
				{
					throw new Exception(err.Message);
				}
			}
		}
	}
}