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
	public class RezervacijeViewModel : BaseViewModel
	{
		private readonly APIService _rezervacija = new APIService("Rezervacija");
		private readonly APIService _pacijent = new APIService("Pacijent");
		private readonly APIService _usluga = new APIService("Usluga");

		public RezervacijeViewModel()
		{
			PrikazRezervacijaCommand = new Command(async () => await PrikazRezervacija());
			PretragaRezervacijaCommand = new Command(async () => await PretragaRezervacija());

			UcitajPacijente();
			UcitajUsluge();
		}
		public ICommand PrikazRezervacijaCommand { get; set; }
		public ICommand PretragaRezervacijaCommand { get; set; }
		public Rezervacija Rezervacija { get; set; }
		public ObservableCollection<Rezervacija> RezervacijaList { get; set; } = new ObservableCollection<Rezervacija>();
		public List<Pacijent> PacijentList { get; set; } = new List<Pacijent>();
		public List<Usluga> UslugaList { get; set; } = new List<Usluga>();

		public async Task PrikazRezervacija()
		{
			var list = await _rezervacija.Get<IEnumerable<Rezervacija>>(null);
			RezervacijaList.Clear();
			foreach (var item in list)
			{
				RezervacijaList.Add(item);
			}
		}

		public void UcitajPacijente()
		{
			Task<List<Pacijent>> task = Task.Run<List<Pacijent>>(async () => await _pacijent.Get<List<Pacijent>>(null));
			PacijentList.Clear();
			PacijentList.AddRange(task.Result);
		}

		public void UcitajUsluge()
		{
			Task<List<Usluga>> task = Task.Run<List<Usluga>>(async () => await _usluga.Get<List<Usluga>>(null));
			UslugaList.Clear();
			UslugaList.AddRange(task.Result);
		}

		Pacijent _selectedPacijent = null;
		public Pacijent SelectedPacijent
		{
			get { return _selectedPacijent; }
			set
			{
				SetProperty(ref _selectedPacijent, value);
				if (value != null)
				{
					PretragaRezervacijaCommand.Execute(null);
				}
			}
		}

		public async Task PretragaRezervacija()
		{
			if (PacijentList.Count == 0)
			{
				var pacijentList = await _pacijent.Get<List<Pacijent>>(null);
				foreach (var i in pacijentList)
				{
					PacijentList.Add(i);
				}
			}
			if (SelectedPacijent != null)
			{
				RezervacijaSearchRequest request = new RezervacijaSearchRequest();
				request.PacijentId = SelectedPacijent.PacijentId;
				var list = await _rezervacija.Get<List<Rezervacija>>(request);
				RezervacijaList.Clear();
				foreach (var item in list)
				{
					RezervacijaList.Add(item);
				}
			}
		}

		int _pacijentId = 0;
		public int PacijentId
		{
			get { return _pacijentId; }
			set { SetProperty(ref _pacijentId, value); }
		}
	}
}