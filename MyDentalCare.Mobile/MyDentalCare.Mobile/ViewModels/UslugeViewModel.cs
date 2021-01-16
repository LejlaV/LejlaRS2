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
	public class UslugeViewModel:BaseViewModel
	{
        private APIService _usluga = new APIService("Usluga");

        public UslugeViewModel()
        {
            PrikazUslugaViewModel = new Command(async () => await PrikazUsluga());
        }
        public ICommand PrikazUslugaViewModel { get; set; }

		public ObservableCollection<Usluga> UslugeList { get; set; } = new ObservableCollection<Usluga>();

        public async Task PrikazUsluga()
        {
            var list = await _usluga.Get<IEnumerable<Usluga>>(null);
            UslugeList.Clear();
            foreach (var usluga in list)
            {
                UslugeList.Add(usluga);
            }
        }
        public async Task DodajUslugu()
        {
            IsBusy = true;
            await _usluga.Insert<Usluga>(new UslugaUpsertRequest()
            {
                Naziv = _naziv,
                Cijena = _cijena
            });
            await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvano!", "OK");
        }

        string _naziv = string.Empty;
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }

        decimal _cijena;
        public decimal Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value); }
        }
    }
}
