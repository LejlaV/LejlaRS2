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

namespace MyDentalCare.Mobile.Views.Pacijent
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UslugePage : ContentPage
	{
		public APIService _usluga = new APIService("Usluga");
		public APIService _rezervacije = new APIService("Rezervacija");

		UslugeViewModel model = null;

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

	}
}