using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MedicinskiKartonPage : ContentPage
	{
		public MedicinskiKartonPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new PrikazMedicinskihKartona());
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DodajMedicinskiKarton());
		}
	}
}