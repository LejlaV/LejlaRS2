using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UslugePage : ContentPage
	{
		private UslugeViewModel model = null;

		public UslugePage()
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
			Navigation.PushAsync(new PrikazUsluga());
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DodajUslugu());
		}
	}
}