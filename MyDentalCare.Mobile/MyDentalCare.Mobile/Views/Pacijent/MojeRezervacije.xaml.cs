using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Mobile.Views;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views.Pacijent
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MojeRezervacije : ContentPage
	{
		private readonly APIService _rezervacije = new APIService("Rezervacija");
		private readonly APIService _pacijenti = new APIService("Pacijent");
		private readonly APIService _usluge = new APIService("Usluga");
		private readonly APIService _pregledi = new APIService("Pregled");

		public MojeRezervacijeViewModel model = null;

		public MojeRezervacije()
		{
			InitializeComponent();
			BindingContext = model = new MojeRezervacijeViewModel();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.Init();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			var btn = sender as Button;
			var item = btn.BindingContext as Rezervacija;

			if ((item.DatumVrijeme - DateTime.Now).TotalDays <= 1)
			{
				await Application.Current.MainPage.DisplayAlert(" ", "Rok za otkazivanje rezervacije je prošao!", "OK");
			}
			else
			{
				await _rezervacije.Delete<Rezervacija>(item.RezervacijaId);
				await DisplayAlert("OK", "Uspješno ste otkazali rezervaciju!", "OK");
				await Navigation.PushAsync(new MojeRezervacije());
			}
		}

		private async void Button_Clicked_1(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Pacijent.RezervisiTermin());
		}
	}
}