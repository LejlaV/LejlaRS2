using MyDentalCare.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Mobile.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views.Pacijent
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProbaRezervacije : ContentPage
	{
		private APIService _usluga = new APIService("Usluga");
		private APIService _rezervacija = new APIService("Rezervacija");

		private ProbaViewModel model = null;
		
		public ProbaRezervacije(Model.Usluga usluga)
		{
			InitializeComponent();
			BindingContext = model = new ProbaViewModel(usluga);
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.Init();

		}
	}
}