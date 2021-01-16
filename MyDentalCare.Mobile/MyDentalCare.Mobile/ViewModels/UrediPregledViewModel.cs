using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;

namespace MyDentalCare.Mobile.ViewModels
{
	public class UrediPregledViewModel : BaseViewModel
	{
		private readonly APIService _pregled = new APIService("Pregled");
		private readonly APIService _rezervacija = new APIService("Rezervacija");
		private readonly APIService _medicinskiKarton = new APIService("MedicinskiKarton");
		private readonly APIService _korisnik = new APIService("Korisnik");
		private readonly APIService _lijek = new APIService("Lijek");
		private readonly APIService _dijagnoza = new APIService("Dijagnoza");

		public Pregled Pregled { get; set; }
		public ObservableCollection<Pregled> PregledList { get; set; } = new ObservableCollection<Pregled>();
		public List<Rezervacija> RezervacijaList { get; set; } = new List<Rezervacija>();
		public List<Korisnik> KorisnikList { get; set; } = new List<Korisnik>();
		public List<MedicinskiKarton> MedicinskiKartonList { get; set; } = new List<MedicinskiKarton>();
		public List<Lijek> LijekList { get; set; } = new List<Lijek>();
		public List<Dijagnoza> DijagnozaList { get; set; } = new List<Dijagnoza>();

		public UrediPregledViewModel()
		{
			UcitajRezervacije();
			UcitajMedicinskeKartone();
			UcitajKorisnike();
			UcitajDijagnoze();
			UcitajLijekove();
		}

		public void UcitajRezervacije()
		{
			Task<List<Rezervacija>> task = Task.Run<List<Rezervacija>>(async () => await _rezervacija.Get<List<Rezervacija>>(null));
			RezervacijaList.Clear();
			RezervacijaList.AddRange(task.Result);
		}

		public void UcitajMedicinskeKartone()
		{
			Task<List<MedicinskiKarton>> task = Task.Run<List<MedicinskiKarton>>(async () => await _medicinskiKarton.Get<List<MedicinskiKarton>>(null));
			MedicinskiKartonList.Clear();
			MedicinskiKartonList.AddRange(task.Result);
		}

		public void UcitajKorisnike()
		{
			Task<List<Korisnik>> task = Task.Run<List<Korisnik>>(async () => await _korisnik.Get<List<Korisnik>>(null));
			KorisnikList.Clear();
			KorisnikList.AddRange(task.Result);
		}

		public void UcitajDijagnoze()
		{
			Task<List<Dijagnoza>> task = Task.Run<List<Dijagnoza>>(async () => await _dijagnoza.Get<List<Dijagnoza>>(null));
			DijagnozaList.Clear();
			DijagnozaList.AddRange(task.Result);
		}

		public void UcitajLijekove()
		{
			Task<List<Lijek>> task = Task.Run<List<Lijek>>(async () => await _lijek.Get<List<Lijek>>(null));
			LijekList.Clear();
			LijekList.AddRange(task.Result);
		}

	}
}
