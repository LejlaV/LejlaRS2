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
	public partial class UrediAdresu : ContentPage
	{
		private readonly APIService _adresa = new APIService("adresa");
		private readonly APIService _grad = new APIService("grad");

		UrediAdresuViewModel model = new UrediAdresuViewModel();

		public UrediAdresu(Adresa adresa)
		{
			InitializeComponent();
			BindingContext = model = new UrediAdresuViewModel() { Adresa = adresa };
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
			BindingContext = model;
		}
		private async void Button_Clicked(object sender, EventArgs e)
		{
			if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
			{
				await DisplayAlert("Greška", "Naziv ne može biti manji od 4 karaktera!", "OK");
			}
			else
			{
				try
				{
					AdresaUpsertRequest request = new AdresaUpsertRequest();
					request.Naziv = this.Naziv.Text;
					Grad grad = this.GradPicker.SelectedItem as Grad;
					request.GradId = grad.GradId;
					await _adresa.Update<dynamic>(model.Adresa.AdresaId, request);
					await DisplayAlert("OK", "Uspješno izmjenjeno!", "OK");
					await Navigation.PushAsync(new PrikazAdresa());
				}
				catch (Exception err)
				{
					throw new Exception(err.Message);
				}
			}
		}
	}
}