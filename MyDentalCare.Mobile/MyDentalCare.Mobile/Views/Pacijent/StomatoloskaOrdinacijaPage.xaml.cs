using MyDentalCare.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views.Pacijent
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StomatoloskaOrdinacijaPage : ContentPage
	{
		private readonly APIService _stomatoloskaOrdinacija = new APIService("StomatoloskaOrdinacija");
		private StomatoloskaOrdinacijaViewModel model = null;

		public StomatoloskaOrdinacijaPage()
		{
			InitializeComponent();
			BindingContext = model = new StomatoloskaOrdinacijaViewModel();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazOrdinacije();
		}
	}
}