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
	public class OcijeniClanakViewModel : BaseViewModel
	{
		private readonly APIService _ocjene = new APIService("Ocjena");
		private readonly APIService _clanak = new APIService("Clanak");
		private readonly APIService _pacijent = new APIService("Pacijent");

		public Ocjena Ocjena { get; set; }
		public Clanak Clanak { get; set; }
		public ObservableCollection<Clanak> ClanakList { get; set; } = new ObservableCollection<Clanak>();
		public ObservableCollection<Pacijent> PacijentList { get; set; } = new ObservableCollection<Pacijent>();
	
		public OcijeniClanakViewModel()
		{
			InitCommand = new Command(async () => await DodajOcjenu());
		}

		decimal _ocjena = 0;
		public decimal Ocjena1
		{
			get { return _ocjena; }
			set { SetProperty(ref _ocjena, value); }
		}

		int _clanakId = 0;
		public int ClanakId
		{
			get { return _clanakId; }
			set { SetProperty(ref _clanakId, value); }
		}

		int _pacijentId = 0;
		public int PacijentId
		{
			get { return _pacijentId; }
			set { SetProperty(ref _pacijentId, value); }
		}
		public ICommand InitCommand { get; set; }
		public async Task Init()
		{
			Pacijent pacijent = new Pacijent();
			var username = APIService.Username;
			List<Pacijent> listaPacijenata = await _pacijent.Get<List<Pacijent>>(null);
			foreach (var item in listaPacijenata)
			{
				if (item.KorisnickoIme == username)
				{
					pacijent = item;
					break;
				}
			}
			var request = new OcjenaSearchRequest
			{
				ClanakId = Clanak.ClanakId,
				PacijentId = pacijent.PacijentId
			};
			var ocjene = await _ocjene.Get<List<Ocjena>>(request);
			if (ocjene != null && ocjene.Count > 0)
			{
				Ocjena = ocjene[0];
				Ocjena1 = Ocjena.Ocjena1;
			}
		}

		public async Task DodajOcjenu()
		{
			IsBusy = true;
			if (Ocjena != null)
			{
				await _ocjene.Delete<Ocjena>(Ocjena.OcjenaId);
			}

			Ocjena = await _ocjene.Insert<Ocjena>(new OcjenaUpsertRequest()
			{
				Ocjena1 = _ocjena,
				PacijentId = _pacijentId,
				ClanakId = _clanakId
			});
			await Application.Current.MainPage.DisplayAlert(" ", "Uspješno ocjenjeno!", "OK");
		}
	}
}
