using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DodajGrad : ContentPage
	{
		private readonly APIService _grad = new APIService("grad");
		GradViewModel model = null;

		public DodajGrad()
		{
			InitializeComponent();
			BindingContext = model = new GradViewModel();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Naziv grada ne može biti manji od 4 karaktera!", "OK");
            }
            else
            {
                try
                {
                    model.Naziv = this.Naziv.Text;
                    model.postanskiBroj = this.PostanskiBroj.Text;
                    Drzava drzava = this.DrzavaPicker.SelectedItem as Drzava;
                    model.DrzavaId = drzava.DrzavaId;
                    await model.DodajGrad();
                    await Navigation.PushAsync(new PrikazGradova());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
	}
}