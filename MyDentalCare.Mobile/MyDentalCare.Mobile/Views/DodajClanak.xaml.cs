using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using Plugin.Media;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DodajClanak : ContentPage
	{
		private APIService _clanak = new APIService("Clanak");
		ClanakViewModel model = new ClanakViewModel();
		public DodajClanak()
		{
			InitializeComponent();           
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = model;
        }
        private async void Button_Clicked(object sender, EventArgs e)
		{
            if (!Regex.IsMatch(this.Naslov.Text, @"[^A-Za-z0-9_.]") || this.Naslov.Text.Length < 4 || this.Naslov.Text == null)
            {
                await DisplayAlert("Greška", "Neispravan unos!", "OK");
            }
            else if (!Regex.IsMatch(this.Sadrzaj.Text, @"[^A-Za-z0-9_.]") || this.Sadrzaj.Text.Length < 4 || this.Sadrzaj.Text == null)
            {
                await DisplayAlert("Greška", "Neispravan unos!", "OK");
            }
            else if (this.KategorijaPicker.SelectedItem == null)
            {
                await DisplayAlert("Greška", "Morate odabrati kategoriju članka", "OK");
            }
            else
            {
                try
                {
                    model.Naslov= this.Naslov.Text;
                    model.Sadrzaj = this.Sadrzaj.Text;
                    Kategorija kategorija = this.KategorijaPicker.SelectedItem as Kategorija;
                    model.KategorijaId = kategorija.KategorijaId;
                    await model.DodajClanak();
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste dodali novi članak", "OK");
                    await Navigation.PushAsync(new PrikazClanaka());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert(" ", "Format slike nije podržan!", "OK");
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync();
            if (file == null)
                return;

            Stream stream = file.GetStream();

            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                model.Slika = ms.ToArray();
            }
        }
    }
}