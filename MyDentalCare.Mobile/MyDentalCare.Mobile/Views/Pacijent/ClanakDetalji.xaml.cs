using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using MyDentalCare.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views.Pacijent
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClanakDetalji : ContentPage
	{
		private readonly APIService _pacijent = new APIService("Pacijent");
		private readonly APIService _ocjene = new APIService("Ocjena");

		private ClanakDetaljiViewModel model = null;
		public ClanakDetalji(Clanak clanak)
		{
			InitializeComponent();
			BindingContext = model = new ClanakDetaljiViewModel() { Clanak = clanak };

			int clanakId = clanak.ClanakId;
			DodajPregledClanka(clanakId);
		}

		public async void DodajPregledClanka(int clanakId)
		{
			Model.Pacijent pacijent = new Model.Pacijent();
			var username = APIService.Username;
			List<Model.Pacijent> listaPacijenata = await _pacijent.Get<List<Model.Pacijent>>(null);
			foreach (var item in listaPacijenata)
			{
				if (item.KorisnickoIme == username)
				{
					pacijent = item;
					break;
				}
			}
			var listaOcjena = await _ocjene.Get<List<Ocjena>>(null);
			bool ocjenaPostoji = false;
			foreach (var item in listaOcjena)
			{
				if(item.PacijentId==pacijent.PacijentId && item.ClanakId==clanakId)
				{
					ocjenaPostoji = true;
				}
			}
			// ocjena je postavljena  na 0, da bih zabiljezila da je pacijent otvarao (citao) odredjeni clanak
			// zbog sistema preporuke - da se korisniku ne bi prikazivali clanci koje je prethodno procitao,
			// bez obzira sto ih mozda nije ocijenio
			if (ocjenaPostoji == false) 
			{
				await _ocjene.Insert<Ocjena>(new OcjenaUpsertRequest()
				{
					Ocjena1 = 0,
					PacijentId = pacijent.PacijentId,
					ClanakId = clanakId
				});
			}
		}
	}
}