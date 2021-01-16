using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrikazClanaka : ContentPage
	{
		private readonly APIService _clanci = new APIService("clanak");
		private readonly APIService _kategorije = new APIService("Kategorija");

		public ClanakViewModel model = null;
		public PrikazClanaka()
		{
			InitializeComponent();
			BindingContext = model = new ClanakViewModel();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazClanaka();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			var btn = sender as Button;
			var item = btn.BindingContext as Clanak;

			await Navigation.PushAsync(new UrediClanak(item));
		}
	}
}