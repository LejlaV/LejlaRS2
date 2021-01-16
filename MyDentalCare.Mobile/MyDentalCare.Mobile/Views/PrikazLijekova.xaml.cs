using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Model;
using MyDentalCare.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrikazLijekova : ContentPage
	{
		public APIService _lijekovi = new APIService("Lijek");

		LijekoviViewModel model = null;

		public PrikazLijekova()
		{
			InitializeComponent();
			BindingContext = model = new LijekoviViewModel();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazLijekova();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			var btn = sender as Button;
			var item = btn.BindingContext as Lijek;

			await Navigation.PushAsync(new UrediLijek(item));
		}
	}
}