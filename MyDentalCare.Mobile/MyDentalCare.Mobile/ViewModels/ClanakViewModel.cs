using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Xamarin.Forms;

namespace MyDentalCare.Mobile.ViewModels
{
	public class ClanakViewModel : BaseViewModel
	{
		private readonly APIService _clanci = new APIService("clanak");
		private readonly APIService _kategorije = new APIService("Kategorija");
		private readonly APIService _korisnik = new APIService("Korisnik");
		
		public ClanakViewModel()
		{
			PrikazClanakaCommand = new Command(async () => await PrikazClanaka());
			PretragaClanakaCommand = new Command(async () => await PretragaClanaka());
			UcitajKategorije();
		}
		public ObservableCollection<Clanak> ClanciList { get; set; } = new ObservableCollection<Clanak>();
		public List<Kategorija> KategorijeList { get; set; } = new List<Kategorija>();
		public ICommand PrikazClanakaCommand { get; set; }
		public ICommand PretragaClanakaCommand { get; set; }

		Kategorija _selectedKategorija = null;

		public Kategorija SelectedKategorija
		{
			get { return _selectedKategorija; }
			set
			{
				SetProperty(ref _selectedKategorija, value);
				if (value != null)
				{
					PretragaClanakaCommand.Execute(null);
				}
			}
		}
		public async Task PretragaClanaka()
		{
			if (KategorijeList.Count == 0)
			{
				var vrstaclankalist = await _kategorije.Get<List<Kategorija>>(null);
				foreach (var i in vrstaclankalist)
				{
					KategorijeList.Add(i);
				}
			}
			if (SelectedKategorija != null)
			{
				ClanakSearchRequest request = new ClanakSearchRequest();
				request.KategorijaId = SelectedKategorija.KategorijaId;
				var list = await _clanci.Get<List<Clanak>>(request);
				ClanciList.Clear();
				foreach (var b in list)
				{
					ClanciList.Add(b);
				}
			}
		}
		public async Task PrikazClanaka()
		{
			var list = await _clanci.Get<IEnumerable<Clanak>>(null);
			ClanciList.Clear();
			foreach (var item in list)
			{
				ClanciList.Add(item);
			}
		}
		public void UcitajKategorije()
		{
			Task<List<Kategorija>> task = Task.Run<List<Kategorija>>(async () => await _kategorije.Get<List<Kategorija>>(null));
			KategorijeList.Clear();
			KategorijeList.AddRange(task.Result);
		}
		public async Task DodajClanak()
		{
			IsBusy = true;
			Korisnik korisnik = new Korisnik();
			var username = APIService.Username;
			List<Korisnik> lista = await _korisnik.Get<List<Korisnik>>(null);

			foreach (var k in lista)
			{
				if (k.KorisnickoIme == username)
				{
					korisnik = k;
					//break;
				}
			}

			await _clanci.Insert<Clanak>(new ClanakUpsertRequest()
			{
				Naslov = _naslov,
				Sadrzaj = _sadrzaj,
				DatumObjave = _datumObjave,
				KategorijaId = _kategorijaId,
				KorisnikId = korisnik.KorisnikId,
				Slika=_slika
			});	
		}

		string _naslov = string.Empty;
		public string Naslov
		{
			get { return _naslov; }
			set { SetProperty(ref _naslov, value); }
		}

		string _sadrzaj = string.Empty;
		public string Sadrzaj
		{
			get { return _sadrzaj; }
			set { SetProperty(ref _sadrzaj, value); }
		}

		DateTime _datumObjave = DateTime.Now;
		public DateTime DatumObjave
		{
			get { return _datumObjave; }
			set { SetProperty(ref _datumObjave, value); }
		}

		int _kategorijaId = 0;
		public int KategorijaId
		{
			get { return _kategorijaId; }
			set { SetProperty(ref _kategorijaId, value); }
		}

		byte[] _slika = new byte[0];
		public byte[] Slika
		{
			get { return _slika; }
			set { SetProperty(ref _slika, value); }
		}
	}
}
