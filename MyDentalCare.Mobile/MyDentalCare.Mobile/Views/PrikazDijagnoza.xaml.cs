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
	public partial class PrikazDijagnoza : ContentPage
	{
		public APIService _dijagnoze = new APIService("Dijagnoza");

		DijagnozeViewModel model = null;
		public PrikazDijagnoza()
		{
			InitializeComponent();
			BindingContext = model = new DijagnozeViewModel();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazDijagnoza();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			var btn = sender as Button;
			var item = btn.BindingContext as Dijagnoza;

			await Navigation.PushAsync(new UrediDijagnozu(item));
		}
	}
}