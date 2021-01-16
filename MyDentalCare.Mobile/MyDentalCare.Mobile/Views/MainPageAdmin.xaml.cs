using MyDentalCare.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPageAdmin : MasterDetailPage
	{

		Dictionary<int, NavigationPage> MenuPagesAdmin = new Dictionary<int, NavigationPage>();

		public MainPageAdmin()
		{
			InitializeComponent();
			MasterBehavior = MasterBehavior.Popover;
		}

		public async Task NavigateFromMenu(int id)
		{
			if (!MenuPagesAdmin.ContainsKey(id))
			{
				switch(id)
				{
					case (int)MenuItemTypeAdmin.Rezervacije:
						MenuPagesAdmin.Add(id, new NavigationPage(new RezervacijaPage()));
						break;
					case (int)MenuItemTypeAdmin.Pregledi:
						MenuPagesAdmin.Add(id, new NavigationPage(new PregledPage()));
						break;
					case (int)MenuItemTypeAdmin.MedicinskiKartoni:
						MenuPagesAdmin.Add(id, new NavigationPage(new MedicinskiKartonPage()));
						break;
					case (int)MenuItemTypeAdmin.Dijagnoze:
						MenuPagesAdmin.Add(id, new NavigationPage(new DijagnozePage()));
						break;
					case (int)MenuItemTypeAdmin.Lijekovi:
						MenuPagesAdmin.Add(id, new NavigationPage(new LijekoviPage()));
						break;
					case (int)MenuItemTypeAdmin.Usluge:
						MenuPagesAdmin.Add(id, new NavigationPage(new UslugePage()));
						break;
					case (int)MenuItemTypeAdmin.Članci:
						MenuPagesAdmin.Add(id, new NavigationPage(new ClanakPage()));
						break;
					case (int)MenuItemTypeAdmin.Kategorije:
						MenuPagesAdmin.Add(id, new NavigationPage(new KategorijaPage()));
						break;
					case (int)MenuItemTypeAdmin.StomatološkaOrdinacija:
						MenuPagesAdmin.Add(id, new NavigationPage(new StomatoloskaOrdinacija()));
						break;
					case (int)MenuItemTypeAdmin.Gradovi:
						MenuPagesAdmin.Add(id, new NavigationPage(new GradPage()));
						break;
					case (int)MenuItemTypeAdmin.Adrese:
						MenuPagesAdmin.Add(id, new NavigationPage(new AdresaPage()));
						break;
					case (int)MenuItemTypeAdmin.Odjava:
						MenuPagesAdmin.Add(id, new NavigationPage(new LoginPage()));
						break;
				}
			}
			var newPage = MenuPagesAdmin[id];

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