using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Xamarin.Forms;

namespace MyDentalCare.Mobile.ViewModels
{
	public class PregledViewModel : BaseViewModel
	{
		private readonly APIService _pregled = new APIService("Pregled");
		private readonly APIService _rezervacija = new APIService("Rezervacija");
		private readonly APIService _medicinskiKarton = new APIService("MedicinskiKarton");
		private readonly APIService _korisnik = new APIService("Korisnik");
		private readonly APIService _lijek = new APIService("Lijek");
		private readonly APIService _dijagnoza = new APIService("Dijagnoza");

		public PregledViewModel()
		{
			PrikazPregledaCommand = new Command(async () => await PrikazPregleda());
			PretragaPregledaCommand = new Command(async () => await PretragaPregleda());

			UcitajRezervacije();
			UcitajMedicinskeKartone();
			UcitajKorisnike();
			UcitajDijagnoze();
			UcitajLijekove();
		}
		public ICommand PrikazPregledaCommand { get; set; }
		public ICommand PretragaPregledaCommand { get; set; }
		public ObservableCollection<Pregled> PregledList { get; set; } = new ObservableCollection<Pregled>();
		public List<Rezervacija> RezervacijaList { get; set; } = new List<Rezervacija>();
		public List<Korisnik> KorisnikList { get; set; } = new List<Korisnik>();
		public List<MedicinskiKarton> MedicinskiKartonList { get; set; } = new List<MedicinskiKarton>();
		public List<Lijek> LijekList { get; set; } = new List<Lijek>();
		public List<Dijagnoza> DijagnozaList { get; set; } = new List<Dijagnoza>();
		public Pregled Pregled { get; set; }

		public async Task PrikazPregleda()
		{
			var list = await _pregled.Get<IEnumerable<Pregled>>(null);
			PregledList.Clear();
			foreach (var item in list)
			{
				PregledList.Add(item);
			}
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

		MedicinskiKarton _selectedMedicinskiKarton = null;
		public MedicinskiKarton SelectedMedicinskiKarton
		{
			get { return _selectedMedicinskiKarton; }
			set
			{
				SetProperty(ref _selectedMedicinskiKarton, value);
				if (value != null)
				{
					PretragaPregledaCommand.Execute(null);
				}
			}
		}

		public async Task PretragaPregleda()
		{
			if (MedicinskiKartonList.Count == 0)
			{
				var medicinskiKartonList = await _medicinskiKarton.Get<List<MedicinskiKarton>>(null);
				foreach (var i in medicinskiKartonList)
				{
					MedicinskiKartonList.Add(i);
				}
			}
			if (SelectedMedicinskiKarton != null)
			{
				PregledSearchRequest request = new PregledSearchRequest();
				request.MedicinskiKartonId = SelectedMedicinskiKarton.MedicinskiKartonId;
				var list = await _pregled.Get<List<Pregled>>(request);
				PregledList.Clear();
				foreach (var item in list)
				{
					PregledList.Add(item);
				}
			}
		}
		public async Task DodajPregled()
		{
			IsBusy = true;
			await _pregled.Insert<Pregled>(new PregledUpsertRequest()
			{
				Naziv = _naziv,
				Opis = _opis,
				DatumVrijeme = _datumVrijeme,
				KorisnikId = _korisnikId,
				DijagnozaId=_dijagnozaId,
				LijekId=_lijekId,
				MedicinskiKartonId=_medicinskiKartonId,
				RezervacijaId = _rezervacijaId
			});

			RezervacijaUpsertRequest rezervacijaRequest = new RezervacijaUpsertRequest();
			var listaRezervacija = await _rezervacija.Get<List<Model.Rezervacija>>(null);
			foreach (var item in listaRezervacija)
			{
				if(item.RezervacijaId ==_rezervacijaId)
				{
					rezervacijaRequest.DatumVrijeme = item.DatumVrijeme;
					rezervacijaRequest.PacijentId = item.PacijentId;
					rezervacijaRequest.UslugaId = item.UslugaId;
					rezervacijaRequest.Razlog = item.Razlog;
					rezervacijaRequest.Aktivna = false;
					await _rezervacija.Update<Model.Rezervacija>(_rezervacijaId, rezervacijaRequest);
				}
			}
			await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvani podaci", "OK");
		}
		string _naziv = string.Empty;
		public string Naziv
		{
			get { return _naziv; }
			set { SetProperty(ref _naziv, value); }
		}
		string _opis = string.Empty;
		public string Opis
		{
			get { return _opis; }
			set { SetProperty(ref _opis, value); }
		}

		DateTime _datumVrijeme;
		public DateTime DatumVrijeme
		{
			get { return _datumVrijeme; }
			set { SetProperty(ref _datumVrijeme, value); }
		}
		int _korisnikId = 0;
		public int KorisnikId
		{
			get { return _korisnikId; }
			set { SetProperty(ref _korisnikId, value); }
		}
		int _rezervacijaId = 0;
		public int RezervacijaId
		{
			get { return _rezervacijaId; }
			set { SetProperty(ref _rezervacijaId, value); }
		}
		int _medicinskiKartonId = 0;
		public int MedicinskiKartonId
		{
			get { return _medicinskiKartonId; }
			set { SetProperty(ref _medicinskiKartonId, value); }
		}
		int _dijagnozaId = 0;
		public int DijagnozaId
		{
			get { return _dijagnozaId; }
			set { SetProperty(ref _dijagnozaId, value); }
		}
		int _lijekId = 0;
		public int LijekId
		{
			get { return _lijekId; }
			set { SetProperty(ref _lijekId, value); }
		}
	}
}
