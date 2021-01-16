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
	public class MojeRezervacijeViewModel
	{
		private readonly APIService _rezervacija = new APIService("Rezervacija");
		private readonly APIService _pacijent = new APIService("Pacijent");

		public MojeRezervacijeViewModel()
		{
            InitCommand = new Command(async () => await Init());
        }

		public Pacijent Pacijent { get; set; }
		public ObservableCollection<Rezervacija> RezervacijaList { get; set; } = new ObservableCollection<Rezervacija>();

		public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var username = APIService.Username;
            List<Pacijent> listPacijenti = await _pacijent.Get<List<Pacijent>>(null);
            foreach (var item in listPacijenti)
            {
                if (item.KorisnickoIme == username)
                {
                    Pacijent = item;
                    break;
                }
            }
            var list = await _rezervacija.Get<IEnumerable<Rezervacija>>(new RezervacijaSearchRequest() { PacijentId = Pacijent.PacijentId });
            RezervacijaList.Clear();
            foreach (var rezervacija in list)
            {
                if(rezervacija.PacijentId==Pacijent.PacijentId && rezervacija.Aktivna==true)
                {
                    RezervacijaList.Add(rezervacija);
                }
            }
        }
    }
}
