using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrikazPregleda : ContentPage
	{
		private readonly APIService _pregled = new APIService("Pregled");
		private readonly APIService _rezervacija = new APIService("Rezervacija");
		private readonly APIService _medicinskiKarton = new APIService("MedicinskiKarton");
		private readonly APIService _korisnik = new APIService("Korisnik");
		private readonly APIService _lijek = new APIService("Lijek");
		private readonly APIService _dijagnoza = new APIService("Dijagnoza");

		private PregledViewModel model = null;

		public PrikazPregleda()
		{
			InitializeComponent();
			BindingContext = model = new PregledViewModel();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazPregleda();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			var btn = sender as Button;
			var item = btn.BindingContext as Pregled;

			await Navigation.PushAsync(new UrediPregled(item));
		}
	}
}