using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DodajKategoriju : ContentPage
	{
		private APIService _kategorije = new APIService("Kategorija");

		KategorijaViewModel model = null;

		public DodajKategoriju()
		{
			InitializeComponent();
			BindingContext = model = new KategorijaViewModel();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") || this.Naziv.Text.Length < 4 || this.Naziv.Text == null)
            {
                await DisplayAlert("Greška", "Morate unijeti tekstualne podatke i minimalno 4 karaktera!", "OK");
            }
            else
            {
                try
                {
                    model.Naziv = this.Naziv.Text;
                    await model.DodajKategoriju();
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