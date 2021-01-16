using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyDentalCare.Model;
using MyDentalCare.Mobile.Models;

namespace MyDentalCare.Mobile.Views
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : MasterDetailPage
	{
		public APIService _pacijenti = new APIService("Pacijent");
		public APIService _medicinskiKarton = new APIService("MedicinskiKarton");
		public APIService _pregled = new APIService("Pregled");

		Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
		public MainPage()
		{
			InitializeComponent();

			MasterBehavior = MasterBehavior.Popover;
		}

		public async Task NavigateFromMenu(int id)
		{
			if (!MenuPages.ContainsKey(id))
			{
				switch (id)
				{
					case (int)MenuItemType.KorisnickiProfil:
						Model.Pacijent pacijent = new Model.Pacijent();
						var korisnickoIme = APIService.Username;
						List<Model.Pacijent> listaPacijenta = await _pacijenti.Get<List<Model.Pacijent>>(null);
						foreach (var item in listaPacijenta)
						{
							if (item.KorisnickoIme == korisnickoIme)
							{
								pacijent = item;
								break;
							}
						}
						MenuPages.Add(id, new NavigationPage(new Pacijent.KorisnickiProfilPage(pacijent)));
						break;
					case (int)MenuItemType.MojMedicinskiKarton:
						Model.Pacijent Pacijent = new Model.Pacijent();
						Model.MedicinskiKarton PacijentMedicinskiKarton = new Model.MedicinskiKarton();
						var username = APIService.Username;
						List<Model.Pacijent> listPacijenti = await _pacijenti.Get<List<Model.Pacijent>>(null);
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
							if (item.PacijentId == Pacijent.PacijentId)
							{
								PacijentMedicinskiKarton = item;
								break;
							}
						}
						//if (PacijentMedicinskiKarton.MedicinskiKartonId == 0)
						//{
						//	await Application.Current.MainPage.DisplayAlert(" ", "Medicinski karton još uvijek nije kreiran!", "OK");
						//}
						MenuPages.Add(id, new NavigationPage(new Pacijent.MojMedicinskiKarton(PacijentMedicinskiKarton)));
						break;
					case (int)MenuItemType.MojeRezervacije:
						MenuPages.Add(id, new NavigationPage(new Pacijent.MojeRezervacije()));
						break;
					case (int)MenuItemType.RezervisiTermin:
						MenuPages.Add(id, new NavigationPage(new Pacijent.RezervisiTermin()));
						break;
					case (int)MenuItemType.Usluge:
						MenuPages.Add(id, new NavigationPage(new Pacijent.UslugePage()));
						break;
					case (int)MenuItemType.Članci:
						MenuPages.Add(id, new NavigationPage(new Pacijent.ClanakPage()));
						break;
					case (int)MenuItemType.Preporuke:
						MenuPages.Add(id, new NavigationPage(new Pacijent.PreporukaPage()));
						break;
					case (int)MenuItemType.StomatološkaOrdinacija:
						MenuPages.Add(id, new NavigationPage(new Pacijent.StomatoloskaOrdinacijaPage()));
						break;
					case (int)MenuItemType.Odjava:
						MenuPages.Add(id, new NavigationPage(new LoginPage()));
						break;
				}
			}

			var newPage = MenuPages[id];

			if (newPage != null && Detail != newPage)
			{
				Detail = newPage;

				if (Device.RuntimePlatform == Device.Android)
					await Task.Delay(100);

				IsPresented = false;
			}
		}
	}
}