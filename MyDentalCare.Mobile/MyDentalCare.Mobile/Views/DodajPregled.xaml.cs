using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DodajPregled : ContentPage
	{
		private readonly APIService _pregled = new APIService("Pregled");
		private readonly APIService _rezervacija = new APIService("Rezervacija");
		private readonly APIService _medicinskiKarton = new APIService("MedicinskiKarton");
		private readonly APIService _korisnik = new APIService("Korisnik");
		private readonly APIService _lijek = new APIService("Lijek");
		private readonly APIService _dijagnoza = new APIService("Dijagnoza");

		public PregledViewModel model = null;
		public DodajPregled()
		{
			InitializeComponent();
			BindingContext = model = new PregledViewModel();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			Model.Rezervacija r = this.RezervacijaPicker.SelectedItem as Model.Rezervacija;
			if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
			{
				await DisplayAlert("Greška", "Naziv pregleda ne može biti manji od 4 karaktera!", "OK");
			}
			else
			{
				try
				{
					if (this.RezervacijaPicker.SelectedItem != null) 
					{
						var listaPregleda = await _pregled.Get<List<Model.Pregled>>(null);
						foreach (var item in listaPregleda)
						{
							if (item.RezervacijaId == r.RezervacijaId)
							{
								await Application.Current.MainPage.DisplayAlert(" ", "Pregled za ovu rezervaciju je vec obavljen!", "OK");
								return;
							}
						}
					}
					model.Naziv = this.Naziv.Text;
					model.Opis = this.Opis.Text;
					model.DatumVrijeme = this.DatumVrijeme.Date;
					Korisnik korisnik = this.KorisnikPicker.SelectedItem as Korisnik;
					model.KorisnikId = korisnik.KorisnikId;
					Rezervacija rezervacija = this.RezervacijaPicker.SelectedItem as Rezervacija;
					model.RezervacijaId = rezervacija.RezervacijaId;
					MedicinskiKarton medicinskiKarton = this.MedicinskiKartonPicker.SelectedItem as MedicinskiKarton;
					model.MedicinskiKartonId = medicinskiKarton.MedicinskiKartonId;
					Dijagnoza dijagnoza = this.DijagnozaPicker.SelectedItem as Dijagnoza;
					model.DijagnozaId = dijagnoza.DijagnozaId;
					Lijek lijek = this.LijekPicker.SelectedItem as Lijek;
					model.LijekId = lijek.LijekId;
					await model.DodajPregled();
					await Navigation.PushAsync(new PrikazPregleda());
				}
				catch (Exception err)
				{
					throw new Exception(err.Message);
				}
			}
		}
	}
}