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
	public partial class UrediDijagnozu : ContentPage
	{
		private APIService _dijagnoze = new APIService("Dijagnoza");
		UrediDijagnozuViewModel model = null;
		public UrediDijagnozu(Dijagnoza d)
		{
			InitializeComponent();
			BindingContext = model = new UrediDijagnozuViewModel() { dijagnoza = d };
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
                    DijagnozaUpsertRequest request = new DijagnozaUpsertRequest()
                    {
                        Naziv = this.Naziv.Text,
                    };

                    await _dijagnoze.Update<dynamic>(model.dijagnoza.DijagnozaId, request);
                    await DisplayAlert("OK", "Uspješno izmjenjeno!", "OK");
                    await Navigation.PushAsync(new PrikazDijagnoza());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}