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
	public class MedicinskiKartonViewModel : BaseViewModel
	{
		private readonly APIService _medicinskiKarton = new APIService("MedicinskiKarton");
		private readonly APIService _pacijent = new APIService("Pacijent");

		public MedicinskiKartonViewModel()
		{
			PrikazMedicinskiKartonCommand = new Command(async () => await PrikazMedicinskiKarton());
			PretragaPacijentCommand = new Command(async () => await PretragaPacijent());
			DodajMedicinskiKartonCommand = new Command(async () => await DodajMedicinskiKarton());
			UcitajPacijente();
		}
		public ICommand PrikazMedicinskiKartonCommand { get; set; }
		public ICommand PretragaPacijentCommand { get; set; }
		public ICommand DodajMedicinskiKartonCommand { get; set; }

		public MedicinskiKarton MedicinskiKarton { get; set; }
		public ObservableCollection<MedicinskiKarton> MedicinskiKartonList { get; set; } = new ObservableCollection<MedicinskiKarton>();
		public List<Pacijent> PacijentList { get; set; } = new List<Pacijent>();
		public async Task PrikazMedicinskiKarton()
		{
			var list = await _medicinskiKarton.Get<IEnumerable<MedicinskiKarton>>(null);
			MedicinskiKartonList.Clear();
			foreach (var item in list)
			{
				MedicinskiKartonList.Add(item);
			}
		}
		public void UcitajPacijente()
		{
			Task<List<Pacijent>> task = Task.Run<List<Pacijent>>(async () => await _pacijent.Get<List<Pacijent>>(null));
			PacijentList.Clear();
			PacijentList.AddRange(task.Result);
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
					PretragaPacijentCommand.Execute(null);
				}
			}
		}
		public async Task PretragaPacijent()
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
				MedicinskiKartonSearchRequest request = new MedicinskiKartonSearchRequest();
				request.PacijentId = SelectedPacijent.PacijentId;
				var list = await _medicinskiKarton.Get<List<MedicinskiKarton>>(request);
				MedicinskiKartonList.Clear();
				foreach (var item in list)
				{
					MedicinskiKartonList.Add(item);
				}
			}
		}
		public async Task DodajMedicinskiKarton()
		{
			IsBusy = true;
			await _medicinskiKarton.Insert<MedicinskiKarton>(new MedicinskiKartonUpsertRequest()
			{
				Naziv=_naziv,
				DatumVrijeme=_datumVrijeme,
				Opis = _opis,
				PacijentId = _pacijentId
			});
			await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvani podaci", "OK");
		}
		int _pacijentId = 0;
		public int PacijentId
		{
			get { return _pacijentId; }
			set { SetProperty(ref _pacijentId, value); }
		}
		string _opis = string.Empty;
		public string Opis
		{
			get { return _opis; }
			set { SetProperty(ref _opis, value); }
		}

		string _naziv = string.Empty;
		public string Naziv
		{
			get { return _naziv; }
			set { SetProperty(ref _naziv, value); }
		}

		DateTime _datumVrijeme = DateTime.Now;
		public DateTime DatumVrijeme
		{
			get { return _datumVrijeme; }
			set { SetProperty(ref _datumVrijeme, value); }
		}
	}
}
