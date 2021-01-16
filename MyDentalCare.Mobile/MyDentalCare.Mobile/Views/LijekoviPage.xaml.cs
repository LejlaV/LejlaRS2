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
	public partial class LijekoviPage : ContentPage
	{
		private LijekoviViewModel model = null;
		public LijekoviPage()
		{
			InitializeComponent();
			BindingContext = model = new LijekoviViewModel();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazLijekova();
		}
		private void Button_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new PrikazLijekova());
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DodajLijek());
		}
	}
}