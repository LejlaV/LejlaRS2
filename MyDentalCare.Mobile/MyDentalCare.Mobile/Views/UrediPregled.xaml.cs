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
	public partial class UrediPregled : ContentPage
	{
		private readonly APIService _pregled = new APIService("Pregled");
		private readonly APIService _rezervacija = new APIService("Rezervacija");
		private readonly APIService _medicinskiKarton = new APIService("MedicinskiKarton");
		private readonly APIService _korisnik = new APIService("Korisnik");
		private readonly APIService _lijek = new APIService("Lijek");
		private readonly APIService _dijagnoza = new APIService("Dijagnoza");

		UrediPregledViewModel model = new UrediPregledViewModel();

		public UrediPregled(Pregled pregled)
		{
			InitializeComponent();
			BindingContext = model = new UrediPregledViewModel() { Pregled = pregled };
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
			BindingContext = model;
		}
		private async void Button_Clicked(object sender, EventArgs e)
		{
			try
			{
				var listaPregleda = await _pregled.Get<List<Pregled>>(null);
				foreach (var item in listaPregleda)
				{
					if (item.PregledId == model.Pregled.PregledId)
					{
						PregledUpsertRequest request = new PregledUpsertRequest();
						request.Opis = this.Opis.Text;
						request.Naziv = this.Naziv.Text;
						request.DatumVrijeme = this.DatumVrijeme.Date;
						if(KorisnikPicker.SelectedItem!=null)
						{
							Korisnik korisnik = this.KorisnikPicker.SelectedItem as Korisnik;
							request.KorisnikId = korisnik.KorisnikId;
						}
						else
						{
							request.KorisnikId = item.KorisnikId;
						}
						if (RezervacijaPicker.SelectedItem != null)
						{
							Rezervacija Rezervacija = this.RezervacijaPicker.SelectedItem as Rezervacija;
							request.RezervacijaId = Rezervacija.RezervacijaId;
						}
						else
						{
							request.RezervacijaId = item.RezervacijaId;
						}
						if (MedicinskiKartonPicker.SelectedItem != null)
						{
							MedicinskiKarton MedicinskiKarton = this.MedicinskiKartonPicker.SelectedItem as MedicinskiKarton;
							request.MedicinskiKartonId = MedicinskiKarton.MedicinskiKartonId;
						}
						else
						{
							request.MedicinskiKartonId = item.MedicinskiKartonId;
						}
						if (DijagnozaPicker.SelectedItem != null)
						{
							Dijagnoza Dijagnoza = this.DijagnozaPicker.SelectedItem as Dijagnoza;
							request.DijagnozaId = Dijagnoza.DijagnozaId;
						}
						else
						{
							request.DijagnozaId = item.DijagnozaId;
						}
						if (LijekPicker.SelectedItem != null)
						{
							Lijek Lijek = this.LijekPicker.SelectedItem as Lijek;
							request.LijekId = Lijek.LijekId;
						}
						else
						{
							request.LijekId = item.LijekId;
						}
						await _pregled.Update<dynamic>(model.Pregled.PregledId, request);
						await DisplayAlert("OK", "Uspješno izmjenjeno!", "OK");
						await Navigation.PushAsync(new PrikazPregleda());
					}
				}
			}
			catch (Exception err)
			{
				throw new Exception(err.Message);
			}
		}
	}
}