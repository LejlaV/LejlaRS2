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
	public class KategorijaViewModel : BaseViewModel
	{
		private APIService _kategorije = new APIService("Kategorija");

		public KategorijaViewModel()
		{
			PrikazKategorijaViewModel = new Command(async () => await PrikazKategorija());
		}

		public ICommand PrikazKategorijaViewModel { get; set; }

		public ObservableCollection<Kategorija> KategorijeList { get; set; } = new ObservableCollection<Kategorija>();

		public async Task PrikazKategorija()
		{
			var list = await _kategorije.Get<IEnumerable<Kategorija>>(null);
			KategorijeList.Clear();
			foreach (var kategorija in list)
			{
				KategorijeList.Add(kategorija);
			}
		}

		public async Task DodajKategoriju()
		{
			IsBusy = true;
			await _kategorije.Insert<Kategorija>(new KategorijaUpsertRequest()
			{
				Naziv = _naziv
			});
			await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvano!", "OK");
		}

		string _naziv = string.Empty;
		public string Naziv
		{
			get { return _naziv; }
			set { SetProperty(ref _naziv, value); }
		}
	}
}
