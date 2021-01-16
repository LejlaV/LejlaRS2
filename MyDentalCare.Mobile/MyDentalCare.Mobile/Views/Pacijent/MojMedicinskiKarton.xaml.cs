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

namespace MyDentalCare.Mobile.Views.Pacijent
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MojMedicinskiKarton : ContentPage
	{
		private readonly APIService _medicinskiKarton = new APIService("MedicinskiKarton");
		private readonly APIService _pregled = new APIService("Pregled");

		private MojMedicinskiKartonViewModel model = null;

		public MojMedicinskiKarton(MedicinskiKarton m)
		{
			InitializeComponent();
			BindingContext = model = new MojMedicinskiKartonViewModel() { PacijentMedicinskiKarton = m};
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			await model.PrikazPregleda();
		}
	}
}