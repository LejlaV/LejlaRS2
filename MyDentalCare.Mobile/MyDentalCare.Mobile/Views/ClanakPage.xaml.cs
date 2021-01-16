using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClanakPage : ContentPage
	{
		private ClanakViewModel model = null;
		public ClanakPage()
		{
			InitializeComponent();
			BindingContext = model = new ClanakViewModel();
		}
		private void Button_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new PrikazClanaka());
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DodajClanak());
		}
	}
}