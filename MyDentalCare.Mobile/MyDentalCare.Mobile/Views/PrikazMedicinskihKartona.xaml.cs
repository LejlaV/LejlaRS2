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
	public partial class PrikazMedicinskihKartona : ContentPage
	{
		private readonly APIService _medicinskiKarton = new APIService("MedicinskiKarton");
		private readonly APIService _pacijent = new APIService("Pacijent");

		private MedicinskiKartonViewModel model = null;

		public PrikazMedicinskihKartona()
		{
			InitializeComponent();
			BindingContext = model = new MedicinskiKartonViewModel();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazMedicinskiKarton();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			var btn = sender as Button;
			var item = btn.BindingContext as MedicinskiKarton;

			await Navigation.PushAsync(new UrediMedicinskiKarton(item));
		}
	}
}