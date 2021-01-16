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

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrikazUsluga : ContentPage
	{
		public APIService _usluga = new APIService("Usluga");
		public APIService _rezervacije = new APIService("Rezervacija");

		UslugeViewModel model = null;
		public PrikazUsluga()
		{
			InitializeComponent();
			BindingContext = model = new UslugeViewModel();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazUsluga();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{

		}

		private async void Button_Clicked_1(object sender, EventArgs e)
		{
			var btn = sender as Button;
			var item = btn.BindingContext as Usluga;

			await Navigation.PushAsync(new UrediUslugu(item));
		}

		//private async void Button_Clicked_2(object sender, EventArgs e)
		//{
		//	var btn = sender as Button;
		//	var usluga = btn.BindingContext as Usluga;

		//	var listaRezervacija = await _rezervacije.Get<IEnumerable<Rezervacija>>(null);
		//	foreach (var item in listaRezervacija)
		//	{
		//		if(item.UslugaId == usluga.UslugaId)
		//		{
		//			await _rezervacije.Delete<Rezervacija>(item.RezervacijaId);
		//		}
		//	}
		//	await _usluga.Delete<Usluga>(usluga.UslugaId);
		//	await DisplayAlert("OK", "Uspješno ste obrisali uslugu!", "OK");
		//	await Navigation.PushAsync(new PrikazUsluga());

		//}
	}
}