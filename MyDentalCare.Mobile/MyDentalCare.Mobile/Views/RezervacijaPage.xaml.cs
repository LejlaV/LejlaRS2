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
	public partial class RezervacijaPage : ContentPage
	{
		private readonly APIService _rezervacija = new APIService("Rezervacija");
		private readonly APIService _pacijent = new APIService("Pacijent");
		private readonly APIService _usluga = new APIService("Usluga");

		private RezervacijeViewModel model = null;

		public RezervacijaPage()
		{
			InitializeComponent();
			BindingContext = model = new RezervacijeViewModel();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazRezervacija();
		}
	}
}