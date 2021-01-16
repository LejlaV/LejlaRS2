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
	public class DijagnozeViewModel : BaseViewModel
	{
		private APIService _dijagnoze = new APIService("Dijagnoza");

		public DijagnozeViewModel()
		{
			PrikazDijagnozaViewModel = new Command(async () => await PrikazDijagnoza());
		}

		public ICommand PrikazDijagnozaViewModel { get; set; }
		public ObservableCollection<Dijagnoza> DijagnozeList { get; set; } = new ObservableCollection<Dijagnoza>();

		public async Task PrikazDijagnoza()
		{
			var listaDijagnoza = await _dijagnoze.Get<IEnumerable<Dijagnoza>>(null);
			DijagnozeList.Clear();
			foreach (var item in listaDijagnoza)
			{
				DijagnozeList.Add(item);
			}
		}
		public async Task DodajDijagnozu()
		{
			IsBusy = true;
			await _dijagnoze.Insert<Dijagnoza>(new DijagnozaUpsertRequest()
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
