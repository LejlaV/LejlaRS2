using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DodajAdresu : ContentPage
	{
		private readonly APIService _adresa = new APIService("adresa");
		AdresaViewModel model = null;
		public DodajAdresu()
		{
			InitializeComponent();
			BindingContext = model = new AdresaViewModel();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Naziv grada ne može biti manji od 4 karaktera!", "OK");
            }
            else
            {
                try
                {
                    model.Naziv = this.Naziv.Text;
                    Grad grad = this.GradPicker.SelectedItem as Grad;
                    model.GradId = grad.GradId;
                    await model.DodajAdresu();
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