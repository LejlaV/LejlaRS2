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
	public partial class UrediLijek : ContentPage
	{
		public APIService _lijek = new APIService("Lijek");

		UrediLijekViewModel model = null;
		public UrediLijek(Lijek l)
		{
			InitializeComponent();
			BindingContext = model = new UrediLijekViewModel() { lijek = l };
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

            else
            {
                try
                {
                    LijekUpsertRequest request = new LijekUpsertRequest()
                    {
                        Naziv = this.Naziv.Text,
                        Uputstvo = this.Uputstvo.Text
                    };

                    await _lijek.Update<dynamic>(model.lijek.LijekId, request);
                    await DisplayAlert("OK", "Uspješno izmjenjeno!", "OK");
                    await Navigation.PushAsync(new PrikazLijekova());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
	}
}