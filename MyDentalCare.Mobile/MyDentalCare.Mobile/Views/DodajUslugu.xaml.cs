using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using MyDentalCare.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text.RegularExpressions;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DodajUslugu : ContentPage
	{
		public APIService _usluga = new APIService("Usluga");

		UslugeViewModel model = null;
		public DodajUslugu()
		{
			InitializeComponent();
			BindingContext = model = new UslugeViewModel();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Naziv usluge ne može biti manji od 4 karaktera!", "OK");
            }
            else if (!Regex.IsMatch(this.Cijena.Text, @"^[0-9]+$"))
            {
                await DisplayAlert("Greška", "Možete unijeti samo brojeve", "OK");
            }
            else
            {
                try
                {
                    model.Naziv = this.Naziv.Text;
                    model.Cijena = Convert.ToDecimal(this.Cijena.Text);
                    await model.DodajUslugu();
                    await Navigation.PushAsync(new PrikazUsluga());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
	}
}