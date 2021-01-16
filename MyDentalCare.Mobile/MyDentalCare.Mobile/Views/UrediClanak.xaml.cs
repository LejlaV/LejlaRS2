using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text.RegularExpressions;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UrediClanak : ContentPage
	{
        private APIService _clanak = new APIService("Clanak");
        UrediClanakViewModel model = new UrediClanakViewModel();
        public UrediClanak(Clanak clanak)
		{
			InitializeComponent();
            BindingContext = model = new UrediClanakViewModel() { Clanak = clanak };

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = model;
        }
        private async void Button_Clicked(object sender, EventArgs e)
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

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Naslov.Text, @"^[a-zA-Z ]+$") && this.Naslov.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Naslov ne može biti manji od 4 karaktera!", "OK");
            }
            else if (!Regex.IsMatch(this.Sadrzaj.Text, @"^[a-zA-Z ]+$") && this.Sadrzaj.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Sadržaj  mora imati minimalno 4 karaktera ", "OK");
            }
            else
            {
                try
                {
                    ClanakUpsertRequest request = new ClanakUpsertRequest();
                    request.Naslov = this.Naslov.Text;
                    request.Sadrzaj = this.Sadrzaj.Text;
                    Kategorija kategorija = this.KategorijaPicker.SelectedItem as Kategorija;
                    request.KategorijaId = kategorija.KategorijaId;
                    request.KorisnikId = 1;
                    await _clanak.Update<dynamic>(model.Clanak.ClanakId, request);
                    await DisplayAlert("OK", "Uspješno izmjenjeno!", "OK");
                    await Navigation.PushAsync(new PrikazClanaka());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
    }
}