using MyDentalCare.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MenuPage : ContentPage
	{
		MainPage RootPage { get => Application.Current.MainPage as MainPage; }
		List<HomeMenuItem> menuItems;
		public MenuPage()
		{
			InitializeComponent();

			menuItems = new List<HomeMenuItem>
			{
				new HomeMenuItem {Id = MenuItemType.KorisnickiProfil, Title="Moj profil" },
				new HomeMenuItem {Id = MenuItemType.MojMedicinskiKarton, Title="Moj medicinski karton" },
				new HomeMenuItem {Id = MenuItemType.MojeRezervacije, Title="Moje rezervacije" },
				new HomeMenuItem {Id = MenuItemType.RezervisiTermin, Title="Rezerviši termin" },
				new HomeMenuItem {Id = MenuItemType.Usluge, Title="Naše usluge" },
				new HomeMenuItem {Id = MenuItemType.Članci, Title="Doc. Blog" },
				new HomeMenuItem {Id = MenuItemType.Preporuke, Title="Preporuke" },
				new HomeMenuItem {Id = MenuItemType.Odjava, Title="Odjava" }
			};

			ListViewMenu.ItemsSource = menuItems;

			ListViewMenu.SelectedItem = menuItems[0];
			ListViewMenu.ItemSelected += async (sender, e) =>
			{
				if (e.SelectedItem == null)
					return;

				var id = (int)((HomeMenuItem)e.SelectedItem).Id;
				await RootPage.NavigateFromMenu(id);
			};
		}
	}
}