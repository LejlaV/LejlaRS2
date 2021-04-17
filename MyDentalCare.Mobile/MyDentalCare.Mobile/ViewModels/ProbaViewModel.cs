using MyDentalCare.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyDentalCare.Mobile.ViewModels
{
	class ProbaViewModel : BaseViewModel
	{
		private readonly APIService _rezervacija = new APIService("Rezervacija");
		private readonly APIService _pacijent = new APIService("Pacijent");
		private readonly APIService _usluge = new APIService("Usluga");

		public ProbaViewModel() : base()
		{
			
		}
		public ProbaViewModel(Usluga u) : base()
		{
			_usluga = u;
			InitCommand = new Command(async () => await Init());
		}
		public Usluga _usluga { get; set; } = new Usluga();
		public ICommand InitCommand { get; set; }
		public ObservableCollection<Pacijent> listaPacijenata { get; set; } = new ObservableCollection<Pacijent>();
		
		public async Task Init()
		{
			var listaUsluga = await _usluge.Get<List<Usluga>>(null);

			var rezervacije = await _rezervacija.Get<List<Model.Rezervacija>>(null);

			foreach (var item in rezervacije)
			{
				if(item.UslugaId == _usluga.UslugaId && (!listaPacijenata.Any(x=> x.PacijentId==item.PacijentId)))
				{
					listaPacijenata.Add(item.Pacijent);
				}
			}
		}
	}
}
