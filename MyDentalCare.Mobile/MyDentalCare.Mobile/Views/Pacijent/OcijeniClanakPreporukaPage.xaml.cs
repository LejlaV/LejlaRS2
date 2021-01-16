using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views.Pacijent
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OcijeniClanakPreporukaPage : ContentPage
	{
		private readonly APIService _clanak = new APIService("Clanak");
		private readonly APIService _pacijent = new APIService("Pacijent");
		private readonly APIService _ocjene = new APIService("Ocjena");

		public OcijeniClanakViewModel model { get; set; }
		private Clanak clanak = null;
		public OcijeniClanakPreporukaPage(Clanak c)
		{
			InitializeComponent();
			BindingContext = model = new OcijeniClanakViewModel { Clanak = c };
			clanak = c;
		}
		protected override async void OnAppearing()
		{
			base.OnAppearing();
			await model.Init();
		}
		private async void Button_Clicked(object sender, EventArgs e)
		{
			if (!decimal.TryParse(this.Ocjena.Text, out decimal Ocjena) || Ocjena < 1 || Ocjena > 10)
			{
				await DisplayAlert("Greška", "Ocjena mora biti između 1 i 10.", "OK");
				return;
			}

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

			foreach (var item in listaOcjena)
			{
				if (item.ClanakId == clanak.ClanakId && item.PacijentId == pacijent.PacijentId)
				{
					OcjenaUpsertRequest request = new OcjenaUpsertRequest()
					{
						Ocjena1 = Ocjena,
						PacijentId = pacijent.PacijentId,
						ClanakId = clanak.ClanakId
					};
					await _ocjene.Update<dynamic>(model.Ocjena.OcjenaId, request);
					await DisplayAlert("OK", "Uspješno izmjenjeno!", "OK");
					await Navigation.PushAsync(new PreporukaPage());
					return;
				}
			}
			model.Ocjena1 = Ocjena;
			model.ClanakId = clanak.ClanakId;
			model.PacijentId = pacijent.PacijentId;
			await model.DodajOcjenu();
			await DisplayAlert("OK", "Uspješno ocijenjeno!", "OK");
			await Navigation.PushAsync(new PreporukaPage());
		}
	}
}