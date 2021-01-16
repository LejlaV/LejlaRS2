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
	public partial class PrikazGradova : ContentPage
	{
		public APIService _gradovi = new APIService("Grad");
		private readonly APIService _drzave = new APIService("Drzava");

		private GradViewModel model = null;

		public PrikazGradova()
		{
			InitializeComponent();
			BindingContext = model = new GradViewModel();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazGrad();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			var btn = sender as Button;
			var item = btn.BindingContext as Grad;

			await Navigation.PushAsync(new UrediGrad(item));
		}
	}
}