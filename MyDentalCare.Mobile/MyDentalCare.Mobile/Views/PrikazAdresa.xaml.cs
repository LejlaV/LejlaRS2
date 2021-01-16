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
	public partial class PrikazAdresa : ContentPage
	{
		private readonly APIService _adresa = new APIService("adresa");
		private readonly APIService _grad = new APIService("grad");
		
		private AdresaViewModel model = null;

		public PrikazAdresa()
		{
			InitializeComponent();
			BindingContext = model = new AdresaViewModel();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazAdresa();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			var btn = sender as Button;
			var item = btn.BindingContext as Adresa;

			await Navigation.PushAsync(new UrediAdresu(item)); 
		}
	}
}