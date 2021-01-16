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
	public class GradViewModel : BaseViewModel
	{
		private readonly APIService _grad = new APIService("grad");
		private readonly APIService _drzava = new APIService("drzava");

		public GradViewModel()
		{
			PrikazGradCommand = new Command(async () => await PrikazGrad());
			DodajGradCommand = new Command(async () => await DodajGrad());
			PretragaGradCommand = new Command(async () => await PretragaGrad());
			UcitajDrzave();
		}
		public Grad Grad { get; set; }
		public ObservableCollection<Grad> GradList { get; set; } = new ObservableCollection<Grad>();
		public List<Drzava> DrzavaList { get; set; } = new List<Drzava>();
		public ICommand PrikazGradCommand { get; set; }
		public ICommand PretragaGradCommand { get; set; }
		public ICommand DodajGradCommand { get; set; }

		Drzava _selectedDrzava = null;

		public Drzava SelectedDrzava
		{
			get { return _selectedDrzava; }
			set
			{
				SetProperty(ref _selectedDrzava, value);
				if (value != null)
				{
					PretragaGradCommand.Execute(null);
				}
			}
		}
		public async Task PretragaGrad()
		{
			if (DrzavaList.Count == 0)
			{
				var drzavalist = await _drzava.Get<List<Drzava>>(null);
				foreach (var i in drzavalist)
				{
					DrzavaList.Add(i);
				}
			}
			if (SelectedDrzava != null)
			{
				GradSearchRequest request = new GradSearchRequest();
				request.DrzavaId = SelectedDrzava.DrzavaId;
				var list = await _grad.Get<List<Grad>>(request);
				GradList.Clear();
				foreach (var item in list)
				{
					GradList.Add(item);
				}
			}
		}
		public async Task PrikazGrad()
		{
			var list = await _grad.Get<IEnumerable<Grad>>(null);
			GradList.Clear();
			foreach (var item in list)
			{
				GradList.Add(item);
			}
		}
		public void UcitajDrzave()
		{
			Task<List<Drzava>> task = Task.Run<List<Drzava>>(async () => await _drzava.Get<List<Drzava>>(null));
			DrzavaList.Clear();
			DrzavaList.AddRange(task.Result);
		}
		public async Task DodajGrad()
		{
			IsBusy = true;
			await _grad.Insert<Grad>(new GradUpsertRequest()
			{
				Naziv = _naziv,
				PostanskiBroj = _postanskiBroj,
				DrzavaId = _drzavaId
			});
			await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvani podaci", "OK");
		}

		string _naziv = string.Empty;
		public string Naziv
		{
			get { return _naziv; }
			set { SetProperty(ref _naziv, value); }
		}

		string _postanskiBroj = string.Empty;
		public string postanskiBroj
		{
			get { return _postanskiBroj; }
			set { SetProperty(ref _postanskiBroj, value); }
		}
		int _drzavaId = 0;
		public int DrzavaId
		{
			get { return _drzavaId; }
			set { SetProperty(ref _drzavaId, value); }
		}
	}
}
