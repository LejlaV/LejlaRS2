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
	public class LijekoviViewModel : BaseViewModel
	{
		private APIService _lijekovi = new APIService("Lijek");

		public LijekoviViewModel()
		{
			PrikazLijekovaViewModel = new Command(async () => await PrikazLijekova());
		}
		public ICommand PrikazLijekovaViewModel { get; set; }
		public ObservableCollection<Lijek> LijekoviList { get; set; } = new ObservableCollection<Lijek>();
		public async Task PrikazLijekova()
		{
			var listaLijekova = await _lijekovi.Get<IEnumerable<Lijek>>(null);
			LijekoviList.Clear();
			foreach (var item in listaLijekova)
			{
				LijekoviList.Add(item);
			}
		}
		public async Task DodajLijek()
		{
			await _lijekovi.Insert<Lijek>(new LijekUpsertRequest()
			{
				Naziv = _naziv,
				Uputstvo = _uputstvo
			});
			await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvano!", "OK");
		}

		string _naziv = string.Empty;
		public string Naziv
		{
			get { return _naziv; }
			set { SetProperty(ref _naziv, value); }
		}

		string _uputstvo = string.Empty;
		public string Uputstvo
		{
			get { return _uputstvo; }
			set { SetProperty(ref _uputstvo, value); }
		}
	}
}
