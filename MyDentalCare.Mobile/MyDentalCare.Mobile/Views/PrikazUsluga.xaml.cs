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
	}
}