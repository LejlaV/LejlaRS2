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
	public partial class KategorijaPage : ContentPage
	{
		private KategorijaViewModel model = null;

		public KategorijaPage()
		{
			InitializeComponent();
			BindingContext = model = new KategorijaViewModel();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazKategorija();
		}
		private void Button_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new PrikazKategorija());

		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DodajKategoriju());
		}
	}
}