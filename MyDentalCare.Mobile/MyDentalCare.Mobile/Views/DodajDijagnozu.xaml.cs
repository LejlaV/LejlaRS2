using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DodajDijagnozu : ContentPage
	{
		private APIService _dijagnoze = new APIService("Dijagnoza");
		
		DijagnozeViewModel model = null;

		public DodajDijagnozu()
		{
			InitializeComponent();
			BindingContext = model = new DijagnozeViewModel();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Naziv lijeka ne može biti manji od 4 karaktera!", "OK");
            }
            else
            {
                try
                {
                    model.Naziv = this.Naziv.Text;
                    await model.DodajDijagnozu();
                    await Navigation.PushAsync(new PrikazDijagnoza());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
	}
}