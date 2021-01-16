using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Xamarin.Forms;

namespace MyDentalCare.Mobile.ViewModels
{
	public class AdresaViewModel : BaseViewModel
	{
		private readonly APIService _adresa = new APIService("adresa");
		private readonly APIService _grad = new APIService("grad");

		public AdresaViewModel()
		{
			PrikazAdresaCommand = new Command(async () => await PrikazAdresa());
			DodajAdresuCommand = new Command(async () => await DodajAdresu());
			PretragaAdresaCommand = new Command(async () => await PretragaAdresa());
			UcitajGradove();
		}
		public Adresa Adresa { get; set; }
		public ObservableCollection<Adresa> AdresaList { get; set; } = new ObservableCollection<Adresa>();
		public List<Grad> GradList { get; set; } = new List<Grad>();
		public ICommand PrikazAdresaCommand { get; set; }
		public ICommand PretragaAdresaCommand { get; set; }
		public ICommand DodajAdresuCommand { get; set; }
		public async Task PrikazAdresa()
		{
			var list = await _adresa.Get<IEnumerable<Adresa>>(null);
			AdresaList.Clear();
			foreach (var item in list)
			{
				AdresaList.Add(item);
			}
		}
		public void UcitajGradove()
		{
			Task<List<Grad>> task = Task.Run<List<Grad>>(async () => await _grad.Get<List<Grad>>(null));
			GradList.Clear();
			GradList.AddRange(task.Result);
		}

		Grad _selectedGrad = null;
		public Grad SelectedGrad
		{
			get { return _selectedGrad; }
			set
			{
				SetProperty(ref _selectedGrad, value);
				if (value != null)
				{
					PretragaAdresaCommand.Execute(null);
				}
			}
		}
		public async Task PretragaAdresa()
		{
			if (GradList.Count == 0)
			{
				var gradlist = await _grad.Get<List<Grad>>(null);
				foreach (var i in gradlist)
				{
					GradList.Add(i);
				}
			}
			if ( SelectedGrad != null)
			{
				AdresaSearchRequest request = new AdresaSearchRequest();
				request.GradId = SelectedGrad.GradId;
				var list = await _adresa.Get<List<Adresa>>(request);
				AdresaList.Clear();
				foreach (var item in list)
				{
					AdresaList.Add(item);
				}
			}
		}
		public async Task DodajAdresu()
		{
			IsBusy = true;
			await _adresa.Insert<Adresa>(new AdresaUpsertRequest()
			{
				Naziv = _naziv,
				GradId = _gradId
			});
			await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvani podaci", "OK");
		}
		string _naziv = string.Empty;
		public string Naziv
		{
			get { return _naziv; }
			set { SetProperty(ref _naziv, value); }
		}

		int _gradId = 0;
		public int GradId
		{
			get { return _gradId; }
			set { SetProperty(ref _gradId, value); }
		}
	}
}
