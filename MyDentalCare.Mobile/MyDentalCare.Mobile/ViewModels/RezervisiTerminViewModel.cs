using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Xamarin.Forms;

namespace MyDentalCare.Mobile.ViewModels
{
	public class RezervisiTerminViewModel : BaseViewModel
	{
		private readonly APIService _rezervacije = new APIService("Rezervacija");
		private readonly APIService _pacijenti = new APIService("Pacijent");
		private readonly APIService _usluge = new APIService("Usluga");

		public RezervisiTerminViewModel()
		{
			UcitajUsluge();
		}
		public ObservableCollection<Rezervacija> RezervacijaList { get; set; } = new ObservableCollection<Rezervacija>();
		public List<Usluga> UslugaList { get; set; } = new List<Usluga>();

		public void UcitajUsluge()
		{
			Task<List<Usluga>> task = Task.Run<List<Usluga>>(async () => await _usluge.Get<List<Usluga>>(null));
			UslugaList.Clear();
			UslugaList.AddRange(task.Result);
		}
		public async Task DodajRezervaciju()
		{
			IsBusy = true;
			Pacijent pacijent = new Pacijent();
			var username = APIService.Username;
			List<Pacijent> listaPacijenata = await _pacijenti.Get<List<Pacijent>>(null);

			foreach (var item in listaPacijenata)
			{
				if (item.KorisnickoIme == username)
				{
					pacijent = item;
				}
			}
			await _rezervacije.Insert<Rezervacija>(new RezervacijaUpsertRequest()
			{
				Razlog = _razlog,
				DatumVrijeme = _datumVrijeme,
				UslugaId = _uslugaId,
				PacijentId = pacijent.PacijentId,
				Aktivna = Aktivna
			});
		}
		string _razlog = string.Empty;
		public string Razlog
		{
			get { return _razlog; }
			set { SetProperty(ref _razlog, value); }
		}

		DateTime _datumVrijeme;
		public DateTime DatumVrijeme
		{
			get { return _datumVrijeme; }
			set { SetProperty(ref _datumVrijeme, value); }
		}

		int _uslugaId = 0;
		public int UslugaId
		{
			get { return _uslugaId; }
			set { SetProperty(ref _uslugaId, value); }
		}

		bool Aktivna = true;
	}
}
