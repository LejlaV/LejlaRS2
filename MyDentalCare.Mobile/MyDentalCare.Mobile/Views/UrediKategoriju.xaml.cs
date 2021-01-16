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
	public partial class UrediKategoriju : ContentPage
	{
		public APIService _kategorija = new APIService("Kategorija");

		UrediKategorijuViewModel model = null;
		public UrediKategoriju(Kategorija k)
		{
			InitializeComponent();
			BindingContext = model = new UrediKategorijuViewModel() { kategorija = k };
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
                    KategorijaUpsertRequest request = new KategorijaUpsertRequest()
                    {
                        Naziv = this.Naziv.Text,
                    };

                    await _kategorija.Update<dynamic>(model.kategorija.KategorijaId, request);
                    await DisplayAlert("OK", "Uspješno izmjenjeno!", "OK");
                    await Navigation.PushAsync(new PrikazKategorija());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
	}
}