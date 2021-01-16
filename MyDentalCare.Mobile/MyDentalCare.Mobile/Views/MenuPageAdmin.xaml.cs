using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Mobile.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MenuPageAdmin : ContentPage
	{
		MainPageAdmin RootPage { get => Application.Current.MainPage as MainPageAdmin; }
		List<HomeMenuItemAdmin> menuItems;
		public MenuPageAdmin()
		{
			InitializeComponent();

            menuItems = new List<HomeMenuItemAdmin>
            {
                new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.Rezervacije, Title="Rezervacije" },
                new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.Pregledi, Title="Pregledi" },
                new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.MedicinskiKartoni, Title="Medicinski kartoni" },
                new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.Dijagnoze, Title="Dijagnoze" },
                new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.Lijekovi, Title="Lijekovi" },
                new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.Usluge, Title="Usluge" },
                new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.Članci, Title="Članci" },
                new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.Kategorije, Title="Kategorije članaka" },
                new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.StomatološkaOrdinacija, Title="Stomatološka ordinacija" },
                new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.Gradovi, Title="Gradovi" },
                new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.Adrese, Title="Adrese" },
                new HomeMenuItemAdmin {Id = MenuItemTypeAdmin.Odjava, Title="Odjava" },
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItemAdmin)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
	}
}