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
	public partial class StomatoloskaOrdinacija : ContentPage
	{
		private readonly APIService _stomatoloskaOrdinacija = new APIService("StomatoloskaOrdinacija");
		private StomatoloskaOrdinacijaViewModel model = null;

		public StomatoloskaOrdinacija()
		{
			InitializeComponent();
			BindingContext = model = new StomatoloskaOrdinacijaViewModel();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazOrdinacije();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			var btn = sender as Button;
			var item = btn.BindingContext as Model.StomatoloskaOrdinacija;
			await Navigation.PushAsync(new UrediStomatoloskuOrdinaciju(item));
		}
	}
}