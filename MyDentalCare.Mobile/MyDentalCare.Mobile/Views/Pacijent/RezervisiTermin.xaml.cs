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
	public partial class RezervisiTermin : ContentPage
	{
		private readonly APIService _rezervacije = new APIService("Rezervacija");
		private readonly APIService _pacijenti = new APIService("Pacijent");
		private readonly APIService _usluge = new APIService("Usluga");

		public RezervisiTerminViewModel model = null;

		public RezervisiTermin()
		{
			InitializeComponent();
			BindingContext = model = new RezervisiTerminViewModel();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			if (this.UslugaPicker.SelectedItem == null)
			{
				await DisplayAlert("Greška", "Morate odabrati uslugu za rezervaciju", "OK");
			}
			else if (this.DatumVrijeme.Date < DateTime.Now) 
			{
				await DisplayAlert("Greška", "Unesite validan datum", "OK");
			}
			else
			{
				try
				{
					model.Razlog = this.Razlog.Text;
					model.DatumVrijeme = this.DatumVrijeme.Date;
					Usluga usluga = this.UslugaPicker.SelectedItem as Usluga;
					model.UslugaId = usluga.UslugaId;
					await model.DodajRezervaciju();
					await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste rezervisali termin", "OK");
					await Navigation.PushAsync(new MojeRezervacije());
				}
				catch (Exception err)
				{
					throw new Exception(err.Message);
				}
			}
		}
	}
}