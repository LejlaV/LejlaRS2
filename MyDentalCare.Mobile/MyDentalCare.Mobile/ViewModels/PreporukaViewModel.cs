using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyDentalCare.Model;
using Xamarin.Forms;

namespace MyDentalCare.Mobile.ViewModels
{
	public class PreporukaViewModel : BaseViewModel
	{
        private readonly APIService _preporuke = new APIService("Preporuka");

        private readonly APIService _pacijenti = new APIService("Pacijent");

		public ObservableCollection<Clanak> ClanakList { get; set; } = new ObservableCollection<Clanak>();

        public PreporukaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            Pacijent pacijent = new Pacijent();
            var username = APIService.Username;
            List<Pacijent> lista = await _pacijenti.Get<List<Pacijent>>(null);
            foreach (var item in lista)
            {
                if (item.KorisnickoIme == username)
                {
                    pacijent = item;
                }
            }

            var listPreporuke = await _preporuke.GetById<List<Clanak>>(pacijent.PacijentId);
            ClanakList.Clear();

            foreach (var item in listPreporuke)
            {
                ClanakList.Add(item);
            }
        }
    }
}
