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
	public class MojMedicinskiKartonViewModel
	{
		private readonly APIService _pacijent = new APIService("Pacijent");
		private readonly APIService _medicinskiKarton = new APIService("MedicinskiKarton");
		private readonly APIService _pregled = new APIService("Pregled");

		public MojMedicinskiKartonViewModel()
		{
			PrikazPregledaCommand = new Command(async () => await PrikazPregleda());
		}
		public ICommand PrikazPregledaCommand { get; set; }
		public ObservableCollection<Pregled> PregledList { get; set; } = new ObservableCollection<Pregled>();
		public Pacijent Pacijent { get; set; }
		public MedicinskiKarton PacijentMedicinskiKarton { get; set; }

		public async Task PrikazPregleda()
		{
			var username = APIService.Username;
			List<Pacijent> listPacijenti = await _pacijent.Get<List<Pacijent>>(null);
			foreach (var item in listPacijenti)
			{
				if (item.KorisnickoIme == username)
				{
					Pacijent = item;
				}
			}
			var listMedKarton = await _medicinskiKarton.Get<IEnumerable<MedicinskiKarton>>(null);
			var listPregledi = await _pregled.Get<IEnumerable<Pregled>>(null);
			foreach (var item in listMedKarton)
			{
				if(item.PacijentId==Pacijent.PacijentId)
				{
					PacijentMedicinskiKarton = item;

					foreach (var item2 in listPregledi)
					{
						if (item.MedicinskiKartonId == item2.MedicinskiKartonId)
						{
							PregledList.Add(item2);
						}
					}
				}
			}
			
		}
	}
}
