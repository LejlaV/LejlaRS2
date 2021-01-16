using MyDentalCare.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Model;
using MyDentalCare.Mobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views.Pacijent
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PreporukaPage : ContentPage
	{
		PreporukaViewModel model = null;
		public PreporukaPage()
		{
			InitializeComponent();
			BindingContext = model = new PreporukaViewModel();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.Init();
		}

		private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as Clanak;

			await Navigation.PushAsync(new ClanakDetalji(item));
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			var btn = sender as Button;
			var item = btn.BindingContext as Clanak;
			await Navigation.PushAsync(new OcijeniClanakPreporukaPage(item));
		}
	}
}