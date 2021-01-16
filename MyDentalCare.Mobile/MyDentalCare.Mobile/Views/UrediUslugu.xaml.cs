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
	public partial class UrediUslugu : ContentPage
	{
		public APIService _usluga = new APIService("Usluga");
		private Usluga usluga = null;
		UrediUsluguViewModel model { get; set; }
		public UrediUslugu(Usluga u)
		{
			InitializeComponent();
			BindingContext = model = new UrediUsluguViewModel() { usluga = u };
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Naziv se sastoji samo od slova i minimalno 4 karaktera", "OK");
            }
            else if (!Regex.IsMatch(this.Cijena.Text, @"^[0-9]+$"))
            {
                await DisplayAlert("Greška", "Možete unijeti samo brojeve", "OK");
            }
            else
            {
                try
                {
                    UslugaUpsertRequest request = new UslugaUpsertRequest()
                    {
                        Naziv = this.Naziv.Text,
                        Cijena = Convert.ToDecimal(this.Cijena.Text)
                };

                    await _usluga.Update<dynamic>(model.usluga.UslugaId, request);
                    await DisplayAlert("OK", "Uspješno izmjenjeno!", "OK");
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